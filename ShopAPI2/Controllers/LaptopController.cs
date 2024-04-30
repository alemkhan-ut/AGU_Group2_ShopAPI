using Microsoft.AspNetCore.Mvc;

namespace ShopAPI2.Controllers
{
    [ApiController]
    public class LaptopController : Controller
    {
        public Laptop[] laptops { get; set; } = new Laptop[]
        {
            new Laptop() {Brend = "lenevo",Model = "lnv", Datetime = new DateTime (2005,01,01),DiagonalScreen = 3.5f },
            new Laptop() {Brend = "samsung",Model = "smg", Datetime = new DateTime (2004,02,02),DiagonalScreen = 4.5f },
            new Laptop() {Brend = "hiaomi",Model = "note11", Datetime = new DateTime (2003,03,04),DiagonalScreen = 5.5f}
        };
        [HttpGet("Laptops")]
        public IResult GetLaptops()
        {
            if (laptops == null || laptops.Length == 0)
            {
                return Results.NotFound("ноутбук не найдены"); 
            }
            else
            {
                return Results.Ok(laptops);
            }
        }
        [HttpGet("RandomLaptop")]
        public IResult GetRandomLaptop()
        {
            Random rnd = new Random();
            if (laptops == null || laptops.Length == 0)
            {
                return Results.NotFound("ноутбук не найдены");
            }
            else
            {
                int random = rnd.Next(0,laptops.Length);
                return Results.Ok(laptops[random]);
            }
        }
    }
    
}
public class Laptop
{
    public string Brend { get; set;}
    public string Model { get;set;}
    public DateTime Datetime { get; set;}
    public float DiagonalScreen { get; set;}
}