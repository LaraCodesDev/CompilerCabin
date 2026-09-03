public class PhotoSorter
{
    string sourceFolder;

    public PhotoSorter(string sourceFolder)
    {
        this.sourceFolder = sourceFolder;
    }

    public void ShowFiles()
    {
        string [] photos = Directory.GetFiles(sourceFolder);

        foreach (var photo in photos)
        {
            Console.WriteLine(Path.GetFileName(photo));
        }
    }
}