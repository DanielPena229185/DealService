using MongoDB.Driver;

namespace DealService;

public class DatabaseConnection
{
    private const string ConnectionString = "mongodb://localhost:27017";
    private const string DatabaseName = "DealService";
    private static DatabaseConnection databaseConnection;

    public MongoClient Client { get; }

    private DatabaseConnection()
    {
        Client = new MongoClient(ConnectionString);
    }

    public static DatabaseConnection GetInstance()
    {
        if (databaseConnection == null)
        {
            databaseConnection = new DatabaseConnection();
        }

        return databaseConnection;
    }   
}
