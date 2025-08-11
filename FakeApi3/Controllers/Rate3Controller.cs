using FakeApi3.Model;
using Microsoft.AspNetCore.Mvc;

namespace FakeApi3.Controllers;

[ApiController]
[Route("api/rate3")]
public class Rate3Controller : ControllerBase
{
    [HttpPost]
    public IActionResult Convert([FromBody] ExchangeRequest wrapper)
    {
        decimal tasa = 58.90m;
        decimal resultado = wrapper.Exchange.Quantity * tasa;

        return Ok(new
        {
            statusCode = 200,
            message = "Success",
            data = new { total = resultado }
        });
    }

}
