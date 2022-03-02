using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core
{
    internal class NewFolders
    {
        public void Creating(string newDirPath, string path, DateTime originalDate, string fileType, int number)
        {
            string fullPath = $"{path}/Photos/{originalDate.Year}/{originalDate.ToString("MMMM", CultureInfo.InvariantCulture)}";

            string fileName = $"{originalDate.Day}{originalDate.Hour}{originalDate.Minute}{originalDate.Second}";


            // Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory(fullPath);


            var newname = di.GetFiles("*", SearchOption.AllDirectories);

            foreach (var file in newname)
            {
                var end = file.Name.ToString().IndexOf('_');
                var splits = file.Name.ToString()[..end];
                if (Regex.IsMatch(splits, fileName))
                {
                    number++;
                }

            }

            string newLocation = $"{fullPath}/{fileName}_{number}{fileType}";
            File.Move(newDirPath, newLocation);

        }
    }
}
