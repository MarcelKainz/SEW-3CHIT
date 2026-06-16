// See https://aka.ms/new-console-template for more information
using MySqlConnector;

//Server=myServerAddress;Database=myDataBase;uid=myUsername;Pwd=myPassword;

//root = "quick and dirty" - normalerweise anderer User
string connectionString = "Server=localhost;Database=scottnew;Uid=root;Pwd=insy;";

using (MySqlConnection mc = new MySqlConnection(connectionString))
{
    mc.Open();
    MySqlCommand cmd = new MySqlCommand("Select * from depts", mc);
    MySqlDataReader reader = cmd.ExecuteReader();
    Console.WriteLine($"{reader.FieldCount} Columns");
    while (reader.Read())
    {
        Console.WriteLine($"{reader.GetInt32(0)} " +
                          $"{reader.GetString(1)} " +
                          $"{reader.GetString(2)} ");
    }
    //mc.Close(); - wird automatisch durch using-Block erledigt
}


Console.WriteLine("Hello, World!");





