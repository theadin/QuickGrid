using Microsoft.AspNetCore.Mvc;
using QuickGrid.Client.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuickGrid.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MockDataController : ControllerBase
{
    // GET: api/<MockDataController>
    //[HttpGet]
    //public IEnumerable<string> Get()
    //{
    //    return new string[] { "value1", "value2" };
    //}

    // GET api/<MockDataController>/5
    //[HttpGet("{skip}/{limit}")]
    public ActionResult<FoodRecallQueryResult> Get(int skip, int limit)
    {
        FoodRecallQueryResult foodRecallQueryResult = new();
        foodRecallQueryResult.meta = new Meta
        {
            results = new Client.Models.Results
            {
                limit = 10,
                skip = 0,
                total = 100
            }
        };
        foodRecallQueryResult.results = [new Result() { event_id = "1", city = "a" }, new Result() { event_id = "2", city = "b" }];
        return foodRecallQueryResult;
    }

    // GET api/<MockDataController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<MockDataController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<MockDataController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<MockDataController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
