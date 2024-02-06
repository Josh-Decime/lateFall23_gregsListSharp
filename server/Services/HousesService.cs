
namespace gregsListSharp.Services;

public class HousesService(HousesRepository repo)
{
    private readonly HousesRepository repo = repo;

    internal List<House> GetAllHouses()
    {
        List<House> houses = repo.GetAllHouses();
        return houses;
    }
}