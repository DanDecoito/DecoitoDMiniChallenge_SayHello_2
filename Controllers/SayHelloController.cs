// Daniel Decoito
// 10-28-22
// MiniChallenge 2
// use api to return a string with the users name as a variable
// reviewed by: Freddy Aguilar - The program takes their mini challenge 2 and converts it int API format. it takes the input from the user, their name, and outputs it into Postman in a sentence greeting them by name. The program works as intended ! Good job!



using Microsoft.AspNetCore.Mvc;

namespace DecoitoDMiniChallenge_SayHello_2.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
   

[HttpGet]
[Route("Hello/{name}")]

public string Hello(string name)
{
    return $"Hello {name} how are you today?";

}





}
