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
        string [] photos = Directory.GetFiles(sourceFolder);

        foreach (var photo in photos)
        {
            string extension = Path.GetExtension(photo).ToLower();

            if (extension == ".jpg" || extension == ".png" ||extension == ".jpeg")
            {
                Console.WriteLine(Path.GetFileName(photo));
                string destinationPath = Path.Combine(destinationFolder, Path.GetFileName(photo));
                
                if (File.Exists(destinationPath))
                {
                    Console.WriteLine("Photo already exists.");
                }
                
                else
                {
                    File.Copy(photo, destinationPath);
                    Console.WriteLine("Photo copied successfully.");    
                }
                Console.WriteLine(destinationPath);
            }
            
        }
    }
}