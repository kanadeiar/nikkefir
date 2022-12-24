using System.Net.Http.Json;

namespace nikkefir.Services;

public class ImagesService
{
    private readonly HttpClient _httpClient;
    private IList<Image>? _images;
    public ImagesService(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }
    public async Task<IEnumerable<Image>?> GetImages()
    {
        if (_images is { })
            return _images;
        _images = new List<Image>();
        var ind = 1;
        ind = await AddImagesToList(ind, "data/images2022.json");
        ind = await AddImagesToList(ind, "data/images2021.json");
        return _images;
    }

    private async Task<int> AddImagesToList(int ind, string filename)
    {
        if (await _httpClient.GetFromJsonAsync<Image[]>(filename) is { } images2022)
        {
            foreach (var image in images2022)
            {
                image.Id = ind++;
                _images?.Add(image);
            }
        }
        return ind;
    }
}