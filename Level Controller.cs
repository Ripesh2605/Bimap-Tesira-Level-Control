using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bimap_Tesira_Level_Control
{
    public static class Level_Controller
    {
        private static Biamp_Level_Controller biamp;

        /// <summary>
        /// Initialize the Biamp_Level_Controller class
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public static void Initialize(string ip, string username, string password)
        {
            biamp = new Biamp_Level_Controller(ip, username, password);
        }


        /// <summary>
        /// This method is called upon selecting the instance and channel to show the current level
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static string Get(string Instance, string Channel)
        {
            string command = $"\"{Instance}\" get level {Channel}";
            string response = biamp.SendData(command);
            int currLevel = ResponseParsers.ParseInt(response);
            if (currLevel == -1)
            {
                MessageBox.Show("Error occured: Please try again:");
                return null;
            }
            return $"Current Level of the channel is: {currLevel}";
        }

        /// <summary>
        /// This method is called upon clicking the up button to increase the level
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static string Up(string Instance, string Channel)
        {
            string command = $"\"{Instance}\" increment level {Channel} 1";
            string response = biamp.SendData(command);
            int currLevel = ResponseParsers.ParseInt(response);
            if (currLevel == -1)
            {
                return null;
            }
            return $"Current Level of the channel is: {currLevel}";
        }

        /// <summary>
        /// This method is called upon clicking the down button to decrease the level
        /// </summary>
        /// <param name="Command"></param>
        /// <returns></returns>
        public static string Down(string Instance, string Channel)
        {
            string command = $"\"{Instance}\" decrement level {Channel} 1";
            string response = biamp.SendData(command);
            int currLevel = ResponseParsers.ParseInt(response);
            if (currLevel == -1)
            {
                return null;
            }
            return $"Current Level of the channel is: {currLevel}";
        }
    }
}
