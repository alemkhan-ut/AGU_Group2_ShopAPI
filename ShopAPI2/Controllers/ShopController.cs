using Microsoft.AspNetCore.Mvc;

namespace ShopAPI.Controllers
{
    [ApiController]

    public class ShopController : Controller
    {
        public string[] Phones { get; set; } = new string[]
        {
            "Samsung",
            "Huawei",
            "Apple",
            "Xiaomi",
        };

        [HttpGet("Phones")]
        public IResult GetPhones()
        {
            if (Phones == null || Phones.Length == null)
            {
                return Results.NotFound("Телефоны не найдены");
            }
            else
            {
                return Results.Ok(Phones);
            }

        }
        [HttpGet("RandomPhone")]
        public IResult GetRandomPhone()
        {
            Random random = new Random();
            if (Phones == null || Phones.Length == null)
            {
                return Results.NotFound("Телефоны не найдены");
            }
            else
            {
                int rend = random.Next(0, Phones.Length);
                return Results.Ok(Phones[rend]);
            }

        }
    }
}