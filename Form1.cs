using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bimap_Tesira_Level_Control
{
    public partial class Form1 : Form
    {
        Biamp_Level_Controller biamp;
        /// <summary>
        /// This is the main form of the application
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //Disable Up and Down buttons and InstanceTagdrp and Channels comboboxes
            Up.Enabled = Down.Enabled = InstanceTagdrp.Enabled = Channels.Enabled = CurrentLevel.Enabled = false;
        }
        /// <summary>
        /// Called upon clicking Login/Logout button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Click(object sender, EventArgs e)
        {
            if(Login.Text == "Login")
            {
                if (LoginToDevice())
                {
                    Login.Text = "Logout";
                    //Enable the combobox InstanceTagdrp and listbox Channels
                    InstanceTagdrp.Enabled = Channels.Enabled = true;
                    //Send the command to get the number of Instances "SESSION get aliases"
                    string instances = biamp.SendData("SESSION get aliases");
                    List<string> instancesList = ResponseParsers.ParseList(instances);
                    InstanceTagdrp.Items.Clear();
                    if (instancesList == null)
                    {
                        return;
                    }
                    

                    foreach (string instance in instancesList)
                    {
                        InstanceTagdrp.Items.Add(instance);
                    }
                    CurrentLevel.Text = "Select Instance Tag and Channel to See Current Level:";
                }
            }
            else
            {
                    biamp?.Disconnect();
                    MessageBox.Show("Logout successfully");
                    //UI Cleanup
                    Login.Text = "Login";
                    Channels.Items.Clear();
                    InstanceTagdrp.Items.Clear();
                    Up.Enabled = Down.Enabled = false;
                    IPAddress.Enabled = UserID.Enabled = Password.Enabled = Login.Enabled = true;
                    CurrentLevel.Text = "Current level:";
            }   
        }
        /// <summary>
        /// Called upon Loggin in to the device
        /// </summary>
        /// <returns></returns>
        private bool LoginToDevice()
        {
            //Validate credentials
            if(!ValidateIPAddress(IPAddress.Text))
            {
                MessageBox.Show("Please enter a valid IP address");
                return false;
            }
            if (UserID.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please enter the Username and Password");
                return false;
            }
            //Instantiate the Biamp_Level_Controller class
            biamp = new Biamp_Level_Controller(IPAddress.Text, UserID.Text, Password.Text);
            biamp.Connect();
            //If the connection is successful, then show the message and disable the textboxes and login button
            if (biamp.isConnected())
            {
                MessageBox.Show("Connected to the device");
                IPAddress.Enabled = UserID.Enabled = Password.Enabled = Login.Enabled = false;
                return true;
            }
            else
            {
                MessageBox.Show("Could not connect to the device");
                return false;
            }
        }
        /// <summary>
        /// Check if the IP address is valid
        /// </summary>
        /// <param name="ipaddress"></param>
        /// <returns></returns>
        private bool ValidateIPAddress(string ipaddress)
        {
            System.Net.IPAddress ip;
            bool isValid = System.Net.IPAddress.TryParse(ipaddress, out ip);
            return isValid;
        }
        
        /// <summary>
        /// Called upon selecting the instance tag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstanceTagdrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = InstanceTagdrp.SelectedItem.ToString();
            string command = $"\"{selectedItem}\" get numChannels";
            string numChannels = biamp.SendData(command);
            int numChannelsInt = ResponseParsers.ParseInt(numChannels);
            if (numChannelsInt == -1)
            {
                return;
            }

            Channels.Items.Clear();
            for (int i = 1; i <= numChannelsInt; i++)
            {
                Channels.Items.Add(i);
            }
        }

        /// <summary>
        /// Called upon selecting the channel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Channels_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string command = $"\"{InstanceTagdrp.SelectedItem}\" get level {Channels.SelectedItem}";
            string Instance = InstanceTagdrp.SelectedItem.ToString();
            string Channel = Channels.SelectedItem.ToString();
            CurrentLevel.Text = Level_Controller.Get(Instance, Channel);
            Up.Enabled = Down.Enabled= true;
        }

        /// <summary>
        /// This is the function to increase the level of the selected channel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Up_Click(object sender, EventArgs e)
        {
            string Instance = InstanceTagdrp.SelectedItem.ToString();
            string Channel = Channels.SelectedItem.ToString();
            //string command = $"\"{InstanceTagdrp.SelectedItem.ToString()}\" increment level {Channels.SelectedItem.ToString()} 1";
            CurrentLevel.Text = Level_Controller.Up(Instance, Channel);
        }

        /// <summary>
        /// This is the function to decrease the level of the selected channel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Down_Click(object sender, EventArgs e)
        {
            string Instance = InstanceTagdrp.SelectedItem.ToString();
            string Channel = Channels.SelectedItem.ToString();
            //string command = $"\"{InstanceTagdrp.SelectedItem.ToString()}\" decrement level {Channels.SelectedItem.ToString()} 1";
            CurrentLevel.Text = Level_Controller.Down(Instance,Channel);
        }
    }
}