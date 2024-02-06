namespace gregsListSharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HousesController : ControllerBase
{
    private readonly HousesService housesService;
    public HousesController(HousesService housesService)
    {
        this.housesService = housesService;
    }

    [HttpGet]
    public ActionResult<List<House>> GetAllHouses()
    {
        try
        {
            List<House> houses = housesService.GetAllHouses();
            return Ok(houses);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }


}