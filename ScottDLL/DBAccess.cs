/*using System.Data;
using System.Text;

namespace DBScott;
using MySqlConnector;

public class DBAccess
{


    //Server=myServerAddress;Database=myDataBase;uid=myUsername;Pwd=myPassword;

    //root = "quick and dirty" - normalerweise anderer User
    string connectionString = "Server=localhost;Database=scottnew;Uid=root;Pwd=root;";

    public List<Dept> GetAllDepts()
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from depts", mc);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Dept> depts = new List<Dept>();
            Console.WriteLine($"{reader.FieldCount} Columns\n");
            while (reader.Read())
            {
                depts.Add(new Dept
                {
                    DEPTNO = reader.GetInt32(0),
                    DNAME = reader.GetString(1),
                    LOC = reader.GetString(2)
                });

            }
            return depts;
        }
    }
    
    public void CreateDept(int deptno, string dname, string loc)
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();

            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO depts (deptno, dname, loc) VALUES (@deptno, @dname, @loc)", mc);

            cmd.Parameters.AddWithValue("@deptno", deptno);
            cmd.Parameters.AddWithValue("@dname", dname);
            cmd.Parameters.AddWithValue("@loc", loc);

            cmd.ExecuteNonQuery();
        }
    }
    
    public void DeleteDept(int deptno)
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM depts WHERE deptno = @deptno", mc);
            cmd.Parameters.AddWithValue("@deptno", deptno); // Sicher gegen SQL-Injection
            cmd.ExecuteNonQuery();
        }
    }
    
    public Dept ReadDept(int deptno)
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();
            MySqlCommand cmd = new MySqlCommand($"Select * from depts where deptno = {deptno}", mc);
            MySqlDataReader reader = cmd.ExecuteReader();
            Dept depts = new Dept();
            Console.WriteLine($"{reader.FieldCount} Columns\n");
            while (reader.Read())
            {
                depts.(new Dept
                {
                    DEPTNO = reader.GetInt32(0),
                    DNAME = reader.GetString(1),
                    LOC = reader.GetString(2)
                });

            }
            return depts;
        }
    }
    
    public void UpdateDept(int deptno, string dname, string loc)
     {
         using (MySqlConnection mc = new MySqlConnection(connectionString))
         {
             mc.Open();
             MySqlCommand cmd = new MySqlCommand(
                 "UPDATE depts SET dname = @dname, loc = @loc WHERE deptno = @deptno", mc);
             
             cmd.Parameters.AddWithValue("@deptno", deptno);
             cmd.Parameters.AddWithValue("@dname", dname);
             cmd.Parameters.AddWithValue("@loc", loc);
             cmd.ExecuteNonQuery();
         }
     }

    public void ColorText()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
    }

    public bool SaveDept(int deptno, string dname, string loc)
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();

            // Prüfen ob Datensatz existiert
            MySqlCommand checkCmd = new MySqlCommand(
                "SELECT COUNT(*) FROM depts WHERE deptno = @deptno", mc);

            checkCmd.Parameters.AddWithValue("@deptno", deptno);

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count > 0)
            {
                // UPDATE
                UpdateDept(deptno, dname, loc);
            }
            else
            {
                // INSERT
                CreateDept(deptno, dname, loc);
            }

            return true;
        }
    }
}*/