public class PhotoSorter
{
    string sourceFolder;
    string destinationFolder;

    public PhotoSorter(string sourceFolder, string destinationFolder)
    {
        this.sourceFolder = sourceFolder;
        this.destinationFolder = destinationFolder;
    }

    public void ShowFiles()
    {
        if (!Directory.Exists(destinationFolder))
        {
            Directory.CreateDirectory(destinationFolder);
        }

        string[] photos = Directory.GetFiles(sourceFolder);

        foreach (var photo in photos)
        {
            string extension = Path.GetExtension(photo).ToLower();

            if (extension == ".jpg" || extension == ".png" || extension == ".jpeg")
            {
                Console.WriteLine(Path.GetFileName(photo));

                FileInfo fileInfo = new FileInfo(photo);
                DateTime photoDate = fileInfo.CreationTime;

                int year = photoDate.Year;
                string monthName = photoDate.ToString("MMMM");
                int day = photoDate.Day;

                string yearFolder = year.ToString();
                string dayFolder = day.ToString();

                string yearPath = Path.Combine(destinationFolder, yearFolder);
                string monthPath = Path.Combine(yearPath, monthName);
                string dayPath = Path.Combine(monthPath, dayFolder);

                Directory.CreateDirectory(dayPath);

                string destinationPath = Path.Combine(
                    dayPath,
                    Path.GetFileName(photo)
                );

                if (!File.Exists(destinationPath))
                {
                    File.Copy(photo, destinationPath);
                    Console.WriteLine("Photo sorted: " + destinationPath);
                }
                else
                {
                    Console.WriteLine("Photo already exists");
                }
            }
        }
    }
}