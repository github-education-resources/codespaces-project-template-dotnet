using System.Net.Http.Json;
using BlazorApp.Models;

namespace BlazorApp.Services;

public sealed class HeroImageService : IDisposable
{
    private readonly HttpClient _client;
    private readonly Task<List<HeroImage>?> _getHeroImagesTask;

    public HeroImageService(HttpClient client)
    {
        _client = client;
        _getHeroImagesTask =
            _client.GetFromJsonAsync<List<HeroImage>>(
                "sample-data/heroimages.json");
    }

    internal async Task<HeroImage?> GetHeroAsync(Func<HeroImage, bool> predicate)
    {
        var heroes = await _getHeroImagesTask;
        return heroes?.FirstOrDefault(predicate);
    }
    
    public void Dispose() => _client.Dispose();
}
