using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bimap_Tesira_Level_Control
{
    public static class ResponseParsers
    {
        //Function to parse the response and get the total number of instances
        public static List<string> ParseList(string response)
        {
            //if response starts with -ERR, return null
            if (response.StartsWith("-ERR"))
            {
                MessageBox.Show(response);
                return null;
            }
            // parse +OK "list":["value1","value2","value3"] to list of strings
            response = response.Replace("+OK", "").Trim(' ').Replace("\"list\":", "").Trim(' ');
            // split by "
            List<string> items = response.Split('"').ToList();
            // remove all empty items and [ ]
            items.RemoveAll(item => item == " " || item == "[" || item == "]");
            return items;
        }

        //Function to parse the response and get the total number of channels
        public static int ParseInt(string response)
        {
            //if response starts with -ERR, return null
            if (response.StartsWith("-ERR"))
            {
                MessageBox.Show(response);
                return -1;
            }
            // parse +OK "value":4 to 4
            response = response.Replace("+OK", "").Trim(' ').Replace("\"value\":", "").Trim(' ');
            //return total no of channels as int
            return int.Parse(response);
        }

    }
}
