public class PhotoAlbum
{
    string name;

    List<string> photos = new List<string>();

    public PhotoAlbum(string name)
    {
        this.name = name;
    }

    public void AddPhoto(string photo)
    {
        photos.Add(photo);
    }

    public void ShowPhotos()
    {
        foreach (string photo in photos)
        {
            Console.WriteLine(photo);
        }
    }

    public int GetPhotoCount()
    {
        return photos.Count;
    }
}