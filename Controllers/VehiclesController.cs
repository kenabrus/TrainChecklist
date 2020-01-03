// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using TrainChecklist.DomainModels;
// using TrainChecklist.DTO;
// using TrainChecklist.Services;

// namespace TrainChecklist.Controllers
// {
//     // set route attribute to make request as 'api/contact'
//     [Route("api/[controller]")]
//     [ApiExplorerSettings(IgnoreApi=false)]
//     public class VehiclesController : Controller
//     {
//         private readonly IVehicleService _service;

//         public VehiclesController(IVehicleService service)
//         {
//             _service = service;
//         }

//         [HttpGet]
//         [Route("getAll")]
//         public async Task<IEnumerable<Vehicle>> GetAll()
//         {
//             return await _service.GetAllAsync();
//         }

//         [HttpGet("{id}")]
//         //[Route("get")]
//         public async Task<IActionResult> GetById(long id)
//         {
//             var item = await _service.GetByIdAsync(id);
//             if (item == null)
//             {
//                 return NotFound();
//             }
//             return new ObjectResult(item);
//         }
//         [HttpPost]
//         //[Route("post")]
//         public IActionResult Create([FromBody] VehicleDto item)
//         {
//             if (item == null)
//             {
//                 return BadRequest();
//             }

//             _service.AddAsync(item);

//             return Ok( new { message= "Vehicle is added successfully !"});
//         }

//         [HttpPut("{id}")]
//         // [Route("put")]
//         public async Task<IActionResult> Update(long id, [FromBody] VehicleDto item)
//         {
//             if (item == null || id == 0)
//             {
//                 return BadRequest();
//             }

//             var vehicle =  await _service.GetByIdAsync(id);
//             if (vehicle == null)
//             {
//                 return NotFound();
//             }

//             await _service.UpdateAsync(id, item);

//             return Ok( new { message= "Vehicle is updated successfully !"});
//         }


//         [HttpDelete("{id}")]
//         // [Route("delete")]
//         public async Task<IActionResult> Delete(long id)
//         {
//             var contact = await _service.GetByIdAsync(id);
//             if (contact == null)
//             {
//                 return NotFound();
//             }
//             await _service.DeleteAsync(id);
//             return Ok( new { message= "Vehicle is deleted successfully !"});
//         }
//     }
// }

// //gsduyhgasygfcsdyuf