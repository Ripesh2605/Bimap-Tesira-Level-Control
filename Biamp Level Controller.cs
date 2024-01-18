using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace Bimap_Tesira_Level_Control
{
    //This class should have TCP/IP connection methods and methods for sending and receiving data
    //Also SSH connection should be able to establish connection with username anad password
    //use Renci package for SSH connection
    class Biamp_Level_Controller
    {
        private string IP { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private SshClient SSHClient { get; set; }


        public Biamp_Level_Controller(string ip, string username, string password)
        {
            IP = ip;
            Username = username;
            Password = password;
        }

        private void SSHConnect()
        {
            SSHClient = new SshClient(IP, Username, Password);
            SSHClient.Connect();
        }


        public void Connect()
        {
            //Exception handling for connection
            try
            {
                SSHConnect();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool isConnected() 
        {
            return SSHClient.IsConnected;
        }

        public void Disconnect()
        {
            //Disconnect from the device
            SSHClient.Disconnect();
        }

        public string SendData(string message)
        {
            //Send data to the device
            //Exception handling for sending data
            try
            { 
            SshCommand command =  SSHClient.RunCommand(message);
            command.Execute();
            return command.Result.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        
    }

}
