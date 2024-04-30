using Microsoft.AspNetCore.Mvc;

namespace ShopAPI2.Controllers
{
    [ApiController]
    public class MobileController : Controller     
    {    
        public Mobile[] Mobiles { get; set; } = new Mobile[]    
        {
            new Mobile(){ Brend = "Apple", Model = "Iphone 15", dateTime = new DateTime (2023,11,03), DiagonalScreen = 13.5f },
            new Mobile(){ Brend = "Samsung", Model = "Samsung Galaxy S24", dateTime = new DateTime (2023,10,25), DiagonalScreen = 11.5f },
            new Mobile(){ Brend = "Xiaomi", Model = "Note 12", dateTime = new DateTime (2022,10,24), DiagonalScreen = 16.5f },
        };
        [HttpGet("Mobiles")]
        public IResult GetMobiles()
        {
            if(Mobiles == null || Mobiles.Length == 0)
            {
                return Results.NotFound("Телефоны не найдены");
            }
            else
            {
                return Results.Ok(Mobiles);
            }
        }
        [HttpGet("GetRandomMobile")]
        public IResult GetRandomMobile()
        {
            Random random = new Random();
            if (Mobiles == null || Mobiles.Length == null)
            {
                return Results.NotFound("Телефоны не найдены");
            }
            else
            {
                int rand = random.Next(0, Mobiles.Length);
                return Results.Ok(Mobiles[rand]);
            }
            
        }
    }
    public class Mobile
    {
        public string Brend { get; set; } 
        public string Model { get; set; }
        public DateTime dateTime { get; set; }
        public float DiagonalScreen { get; set; }
    }
}
