using FakeApi2.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/rate2")]
public class Rate2Controller : ControllerBase
{
    [HttpPost]
    [Consumes("application/xml")]
    [Produces("application/xml")]    
    public IActionResult Convert([FromBody] XmlRequest request)
    {
      
        decimal rate = 60.10m;
        decimal result = request.Amount * rate;
        string xmlResponse = $"<XML><Result>{result}</Result></XML>";
        return Content(xmlResponse, "application/xml");
    }

}

