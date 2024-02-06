
namespace gregsListSharp.Repositories;

public class HousesRepository(IDbConnection db)
{
    private readonly IDbConnection db = db;

    internal List<House> GetAllHouses()
    {
        string sql = @"
        SELECT
        *
        FROM houses;
        ";
        List<House> houses = db.Query<House>(sql).ToList();
        return houses;
    }
}