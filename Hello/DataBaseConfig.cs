namespace Hello
{
    internal class DataBaseConfig
    {
        public class DatabaseConfig
        {
            public static string ConnectionString;

            // Static constructor
            static DatabaseConfig()
            {
                ConnectionString = "Server=myServerAddress;Database=myDataBase;";
                Console.WriteLine("Static Constructor Executed!");
            }
        }
    }
}
