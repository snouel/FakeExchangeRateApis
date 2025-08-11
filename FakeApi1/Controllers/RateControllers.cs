using Microsoft.AspNetCore.Mvc;

namespace FakeApi1.Controllers;

[ApiController]
[Route("api/rate1")]
public class RateController : ControllerBase
{
    [HttpPost]
    public IActionResult Convert([FromBody] RequestDto request)
    {
        decimal tasa = 59.20m;
        decimal resultado = request.Value * tasa;
        return Ok(new { rate = resultado });
    }

    public class RequestDto
    {
        public string From { get; set; }
        public string To { get; set; }
        public decimal Value { get; set; }
    }
}
