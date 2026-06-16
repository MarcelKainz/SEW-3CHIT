using System.Data;
using System.Text;
using MySqlConnector;

namespace DBScott;

public class BetterDBAccess
{
        string connectionString = "Server=localhost;Database=scottnew;Uid=root;Password=root;";
    
    public List<Dept> GetAllDepts()
    {

        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM depts", mc);
            MySqlDataReader reader = cmd.ExecuteReader();
            //StringBuilder sb = new ();
            List<Dept> departements = new List<Dept>();
            while (reader.Read())
            {
                /*sb.Append(
                    $"{reader.GetInt32(0)} " +
                    $"{reader.GetString(1)} \n");*/
                departements.Add(new Dept
                {
                    DEPTNO = reader.GetInt32(0),
                    DNAME = reader.GetString(1),
                    LOC = reader.GetString(2)
                });
            }
            return departements;
        }
    }
    
    public Dept GetDept(int id)
    {

        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM depts WHERE DEPTNO = @DEPTNO", mc);
            cmd.Parameters.Add("@DEPTNO", DbType.Int32).Value = id;
            
            MySqlDataReader reader = cmd.ExecuteReader();
            //StringBuilder sb = new ();
            Dept departement = new Dept();
            while (reader.Read())
            {
                departement=(new Dept
                    {
                        DEPTNO = reader.GetInt32(0),
                        DNAME = reader.GetString(1),
                        LOC = reader.GetString(2)
                    }
                );
            }
            return departement;
        }
    }

    public void CreateDept(Dept dept)
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO depts VALUES (@deptno,@dname,@loc)", mc);
            cmd.Parameters.Add("@deptno", DbType.Int32).Value = dept.DEPTNO;
            cmd.Parameters.Add("@dname", DbType.String).Value = dept.DNAME;
            cmd.Parameters.Add("@loc", DbType.String).Value = dept.LOC;
            cmd.ExecuteNonQuery();
        }
    }
    
    public void UpdateDept(Dept dept)
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE depts SET LOC=@loc, DNAME=@dname WHERE DEPTNO=@deptno", mc);

            cmd.Parameters.AddWithValue("@deptno", dept.DEPTNO);
            cmd.Parameters.AddWithValue("@dname", dept.DNAME);
            cmd.Parameters.AddWithValue("@loc", dept.LOC);

            cmd.ExecuteNonQuery();
        }
    }
    
    public void DeleteDept(int d) //könnt ma gleich lassen
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM depts WHERE deptno = (@deptno)", mc);
            cmd.Parameters.Add("@deptno", DbType.Int32).Value = d;
            cmd.ExecuteNonQuery();
        }
    }
}