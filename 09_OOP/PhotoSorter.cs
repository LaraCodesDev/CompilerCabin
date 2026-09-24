using MetadataExtractor.Formats.Exif;

public class PhotoSorter
{
    string sourceFolder;
    string destinationFolder;

    public PhotoSorter(string sourceFolder, string destinationFolder)
    {
        this.sourceFolder = sourceFolder;
        this.destinationFolder = destinationFolder;
    }

    private DateTime GetPhotoDate(string photo)
    {
        try
        {
            var directories = MetadataExtractor.ImageMetadataReader.ReadMetadata(photo);

            var exif = directories
                .OfType<ExifSubIfdDirectory>()
                .FirstOrDefault();

            if (exif != null)
            {
                string? dateText =
                    exif.GetDescription(ExifDirectoryBase.TagDateTimeOriginal);

                if (DateTime.TryParseExact(
                    dateText,
                    "yyyy:MM:dd HH:mm:ss",
                    null,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime photoDate))
                {
                    return photoDate;
                }
            }
        }
        catch
        {
            // Falls die Metadaten nicht gelesen werden können,
            // wird unten das normale Dateidatum verwendet.
        }

        FileInfo fileInfo = new FileInfo(photo);
        return fileInfo.CreationTime;
    }

    public void ShowFiles()
    {
        if (!Directory.Exists(sourceFolder))
        {
            Console.WriteLine("Source folder does not exist.");
            return;
        }

        if (!Directory.Exists(destinationFolder))
        {
            Directory.CreateDirectory(destinationFolder);
        }

        string[] photos = Directory.GetFiles(sourceFolder);

        if (photos.Length == 0)
        {
            Console.WriteLine("No files found");
            return;
        }

        foreach (var photo in photos)
        {
            string extension = Path.GetExtension(photo).ToLower();

            if (extension == ".jpg" || extension == ".png" || extension == ".jpeg")
            {
                Console.WriteLine(Path.GetFileName(photo));

                DateTime photoDate = GetPhotoDate(photo);

                int year = photoDate.Year;
                string monthName = photoDate.ToString("MMMM");

                string yearFolder = year.ToString();

                string yearPath = Path.Combine(destinationFolder, yearFolder);
                string monthPath = Path.Combine(yearPath, monthName);

                Directory.CreateDirectory(monthPath);

                string destinationPath = Path.Combine(
                    monthPath,
                    Path.GetFileName(photo)
                );

                if (!File.Exists(destinationPath))
                {
                    try
                    {
                        File.Copy(photo, destinationPath);
                        Console.WriteLine("Photo sorted: " + destinationPath);
                    }
                    catch
                    {
                        Console.WriteLine("Could not copy photo");
                    }
                }
                else
                {
                    Console.WriteLine("Photo already exists");
                }
            }
        }
    }
}