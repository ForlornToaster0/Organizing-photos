using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class CoreFunction
    {


        public static void Task(string photoPath, string newPath)
        {

            NewFolders newFolders = new();
            int i = 0;
            List<DateTime> folders = new();

            string[] allfiles = Directory.GetFiles(photoPath, "*.*", SearchOption.AllDirectories);
            DirectoryInfo di = new(photoPath);

            var extensions = new[] { ".GIF", ".JPG", ".PNG", ".CR2", ".ARW", ".ORF" };

            foreach (var fi in di.GetFiles("*", SearchOption.AllDirectories))
            {

                string fileName = fi.Extension;
                if (extensions.Contains(fileName.ToUpper()))
                {

                    string fullPath = $"{fi.FullName}";

                    if (fullPath != null)
                    {

                        var test = FindFolder.OroginDate(photoPath);
                        folders.Add(test);
                        if (folders[0].Month != test.Month)
                        {
                            folders.Clear();

                        }
                        newFolders.Creating(photoPath, newPath, test, fileName, i);


                    }

                }


            }
        }
    }
}
