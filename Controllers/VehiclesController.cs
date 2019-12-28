using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrainChecklist.DomainModels;
using TrainChecklist.DTO;
using TrainChecklist.Services;

namespace TrainChecklist.Controllers
{
    // set route attribute to make request as 'api/contact'
    [Route("api/[controller]")]
    [ApiExplorerSettings(IgnoreApi=false)]
    public class VehiclesController : Controller
    {
        private readonly IVehicleService _service;

        public VehiclesController(IVehicleService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IEnumerable<Vehicle>> GetAll()
        {
            // fetch all contact records
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        //[Route("get")]
        public async Task<IActionResult> GetById(long id)
        {
            // filter by id
            var item = await _service.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPost]
        //[Route("post")]
        public IActionResult Create([FromBody] VehicleDto item)
        {
            // set bad request if contact data is not provided in body
            if (item == null)
            {
                return BadRequest();
            }

            _service.AddAsync(item);

            return Ok( new { message= "Vehicle is added successfully !"});
        }

        [HttpPut("{id}")]
        // [Route("put")]
        public async Task<IActionResult> Update(long id, [FromBody] VehicleDto item)
        {
            // set bad request if contact data is not provided in body
            if (item == null || id == 0)
            {
                return BadRequest();
            }

            var vehicle =  await _service.GetById(id);
            if (vehicle == null)
            {
                return NotFound();
            }

            await _service.UpdateAsync(id, item);

            return Ok( new { message= "Contact is updated successfully !"});
        }


        [HttpDelete("{id}")]
        // [Route("delete")]
        public async Task<IActionResult> Delete(long id)
        {
            var contact = await _service.GetById(id);
            if (contact == null)
            {
                return NotFound();
            }
            await _service.DeleteAsync(id);
            return Ok( new { message= "Contact is deleted successfully !"});
        }
    }
}