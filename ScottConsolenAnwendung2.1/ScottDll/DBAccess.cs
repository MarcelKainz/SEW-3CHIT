using System.Data;
using System.Text;

namespace DBScott;
using MySqlConnector;

public class DBAccess
{


    //Server=myServerAddress;Database=myDataBase;uid=myUsername;Pwd=myPassword;

    //root = "quick and dirty" - normalerweise anderer User
    string connectionString = "Server=localhost;Database=scottnew;Uid=root;Pwd=insy;";

    public string GetAllDepts()
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from depts", mc);
            MySqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine($"{reader.FieldCount} Columns\n");
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                sb.Append($"{reader.GetInt32(0)} " +
                                  $"{reader.GetString(1)} " +
                                  $"{reader.GetString(2)} \n");
            }
            return sb.ToString();
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
            MySqlCommand cmd = new MySqlCommand($"Delete from depts where deptno = {deptno}", mc);
            cmd.Parameters.Add("deptno", DbType.Int32).Value = deptno;
            cmd.ExecuteNonQuery();
        }
    }
    
    public string ReadDept(int deptno)
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();
            MySqlCommand cmd = new MySqlCommand($"Select * from depts where deptno = {deptno}", mc);
            MySqlDataReader reader = cmd.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                sb.Append($"{reader.GetInt32(0)} " +
                                  $"{reader.GetString(1)} " +
                                  $"{reader.GetString(2)} \n");
            }
            return sb.ToString();
        }
    }
    
    public void UpdateDept(int deptno, string dname, string loc)
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();
            MySqlCommand cmd = new MySqlCommand($"Update depts set dname = '{dname}', loc = '{loc}' where deptno = {deptno}", mc);
            cmd.Parameters.Add("deptno", DbType.Int32).Value = deptno;
            cmd.Parameters.Add("dbname", DbType.String).Value = dname;
            cmd.Parameters.Add("loc", DbType.Int32).Value = loc;
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
}