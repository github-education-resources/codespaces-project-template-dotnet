using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using BlazorApp.Models;
using Microsoft.Extensions.Caching.Memory;

namespace BlazorApp.Services;

public sealed class HeroImageService
{
    private readonly HttpClient _client;
    private readonly IMemoryCache _cache;

    public HeroImageService(HttpClient client, IMemoryCache cache) =>
        (_client, _cache) = (client, cache);

    internal Task<HeroImage?> GetHeroAsync(Func<HeroImage, bool> predicate) => 
        _cache.GetOrCreateAsync("hero-images",
            async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
                var heros =
                    await _client.GetFromJsonAsync<List<HeroImage>>(
                        "sample-data/heroimages.json");

                return heros?.FirstOrDefault(predicate);
            });
}
