using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Subdirectories
    {
        public static string[] GetSubDirectories(string path)
        {
            string root = path;

            // Get all subdirectories

            string[] subdirectoryEntries = Directory.GetDirectories(root);
            

            // Loop through them to see if they have any other subdirectories

            return subdirectoryEntries;
        }
    }
}
