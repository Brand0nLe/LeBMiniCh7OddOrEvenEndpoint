//Brandon Le
//10-26-22
//Mini Challenge 7 - Odd or Even Endpoint
//Web API project that will tell the user whether the number they entered via the URL is odd or even. There is an instructions page when the user starts at the localhost url /MiniCh7 and will help them to continue with the program. There is also an error message if the user enters in anything that is not a number.
//Peer Review: Jovann Contreras: Code looks great and is very understandable it runs good on postman. One thing that I liked was that it saved the url input in postman so it made it easier to be able to add in a number quick.


using Microsoft.AspNetCore.Mvc;

namespace MiniCh7OddOrEvenEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh7Controller : ControllerBase
{
    public string Instructions()
    {
        return "Enter in a number after the localhost URL and I'll tell you if it's odd or even!\n For example: https://localhost:7178/MiniCh7/OddOrEven/\n and then you would add whatever number you want after the OddOrEven/.\n If you need an example you can copy my link: https://localhost:7178/MiniCh7/OddOrEven/11\n\n **Make sure to check the localhost number before continuing**";
    }

    [HttpGet]
    [Route("OddOrEven/{number}")]
    public string OddOrEven(string number, bool canParse, int validNum, int remainder)
    {
    canParse = Int32.TryParse(number, out validNum);

if (canParse == false)
{
    return "ERROR invalid entry. You can only input numbers!\n If you need an example try this URL: https://localhost:7178/MiniCh7/OddOrEven/11\n **But make sure to double check the localhost number before continuing**";
}
else
{
    if(remainder == (validNum % 2))
    {
        return $"Your number {number} is even.";
    }
    else
    {
        return $"You number {number} is odd";
    }
    }
}}
