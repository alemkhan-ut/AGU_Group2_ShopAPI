using Microsoft.AspNetCore.Mvc;


namespace ShopAPI2.Controllers
{
    [ApiController]
    public class TVController : Controller
    {

        public TV[] tvs { get; set; } = new TV[]
        {
            new TV(){ Brand= "LG", Model = "XX1", Date = new DateTime(2022, 01, 01), DiagonalScreen = 25.5f },
            new TV(){ Brand= "Samsung", Model = "Galaxy", Date = new DateTime(2023, 01, 01), DiagonalScreen = 29.5f },
            new TV(){ Brand= "Xiaomi", Model = "R1", Date = new DateTime(2020, 01, 01), DiagonalScreen = 25.5f },

         };
        [HttpGet("TVs")]
        public IResult GetTVs()
        {
            if(tvs == null || tvs.Length == 0)
            {
                return Results.NotFound("Телевизоры не найдены");
            }
            else
            {
                return Results.Ok(tvs);
            }
        }
        [HttpGet("GetRandomTV")]
        public IResult GetRandomTV()
        {
            Random random = new Random();
            if (tvs == null || tvs.Length == 0)
            {
                return Results.NotFound("Телевизоры не найдены");
            }
            else
            {
                int randcount = random.Next(0 , tvs.Length);
                return Results.Ok(tvs[randcount]);
            }

        }
    }
    public class TV
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Date { get; set; }
        public float DiagonalScreen { get; set; }
    }
}
