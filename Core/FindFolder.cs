

using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System.Globalization;

namespace Core
{
    public class FindFolder
    {
        public static DateTime OroginDate(string fullPath)
        {
            DateTime date = DateTime.Now;



            var directories = ImageMetadataReader.ReadMetadata(fullPath);

            var subIfdDirectory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();

            var dateTime = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagDateTimeOriginal);

            var dateTime1 = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagDateTime);
            if (dateTime != null)
            {
               date = DateTime.ParseExact(dateTime, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture);
            }

            else if (dateTime1 != null)
            {

                date = DateTime.ParseExact(dateTime1, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture);
            }

                return date;





        }
    }
}