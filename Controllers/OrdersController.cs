using Microsoft.AspNetCore.Mvc;

[ApiController, Route("api/[controller]")]
public class OrdersController: ControllerBase
{
    [HttpGet("{id:int}")]
    public IActionResult Get(int id) => id <= 0? BadRequest("id must be positive"): Ok(new { id, status = "Paid"});
    [HttpPost]
    public IActionResult Create([FromBody] CreateOrderRequest req) => Created($"/api/orders/1", new { id = 1, req.Amount});
}
public record CreateOrderRequest(decimal Amount);
