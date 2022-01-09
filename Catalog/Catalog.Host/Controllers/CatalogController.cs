using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers;

[ApiController]
[Route("[controller]")]
public class CatalogController : ControllerBase
{
    private static readonly Catalog[] Items = new[]
    {
        new Catalog() { Brand = "Intel", Model = "Core i5-10400", Currency = "UAH", Price = 4999, ImageLink = "https://content1.rozetka.com.ua/goods/images/big/24188618.jpg"},
        new Catalog() { Brand = "AMD", Model = "Ryzen 3 1200", Currency = "UAH", Price = 3099, ImageLink = "https://content2.rozetka.com.ua/goods/images/big/216855092.jpg"},
        new Catalog() { Brand = "Intel", Model = "Core i3-10300", Currency = "UAH", Price = 5100, ImageLink = "https://content.rozetka.com.ua/goods/images/big/24188769.jpg"},
        new Catalog() { Brand = "AMD", Model = "Ryzen 5 1600", Currency = "UAH", Price = 5059, ImageLink = "https://content1.rozetka.com.ua/goods/images/big/216855086.jpg"},
        new Catalog() { Brand = "AMD", Model = "Ryzen Threadripper 1900X", Currency = "UAH", Price = 2967, ImageLink = "https://hotline.ua/img/tx/307/3076195665.jpg"}
    };

    private readonly ILogger<CatalogController> _logger;

    public CatalogController(ILogger<CatalogController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCatalog")]
    public IEnumerable<Catalog> Get()
    {
        return Items;
    }
}