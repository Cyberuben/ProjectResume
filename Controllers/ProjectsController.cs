using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectResume.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProjectsController : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return Ok(new {
				Hello = "World"
			});
		}
	}
}