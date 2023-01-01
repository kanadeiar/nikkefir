namespace nikkefir.Abstracts;

public interface IImagesService
{
    public Task<IEnumerable<Image>?> GetImages();
}