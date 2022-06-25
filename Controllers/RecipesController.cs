using Microsoft.AspNetCore.Mvc;

namespace mslearn_asp.net_api_net6.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipesController : ControllerBase
{
    [HttpGet]
    public string[] GetDishes()
    {
        string[] dishes = { "Oxtail", "Curry Chicken", "Dumplings"};
        return dishes;
    }
}