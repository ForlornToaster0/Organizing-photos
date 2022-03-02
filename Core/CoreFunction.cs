using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class CoreFunction
    {
        public static void Task(string photoPath, string newPath)
        {

            FindFolder findFolder = new();
            NewFolders newFolders = new();
            var subdirectoryEntries = Subdirectories.GetSubDirectories(photoPath);
            int i = 0;
            List<DateTime> folders = new();
            foreach (var subdirectoryEntry in subdirectoryEntries)
            {
                string fullPath = (subdirectoryEntry);

                DirectoryInfo di = new(fullPath);

                var extensions = new[] { "*.gif", "*.jpg", "*.png", "*.CR2", "*.ARW", "*.ORF" };
                foreach (var extension in extensions)
                {
                    foreach (var fi in di.GetFiles(extension, SearchOption.AllDirectories))
                    {
                        fullPath = $"{fi.FullName}";
                        string fileName = fi.Extension;

                        if (fullPath != null)
                        {

                            var test = FindFolder.OroginDate(fullPath);
                            folders.Add(test);
                            if (folders[0].Month != test.Month)
                            {
                                folders.Clear();

                            }
                            newFolders.Creating(fullPath, newPath, test, fileName, i);


                        }
                    }
                }

            }
        }
    }
}
