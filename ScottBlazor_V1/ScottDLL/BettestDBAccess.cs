using System.Data;
using MySqlConnector;

namespace DBScott;

public class BettestDBAccess
{
    public string connectionString = "Server=localhost;Database=scottnew;Uid=root;Password=root;";
    
    public List<Emp> GetAllEmps()
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM emps", mc);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<Emp> emps = new List<Emp>();

            while (reader.Read())
            {
                emps.Add(new Emp
                {
                    ID = reader.GetInt32(0),
                    ENAME = reader.GetString(1),
                    JOB = reader.GetString(2),
                    ParentID = reader.IsDBNull(3) ? null : reader.GetInt32(3),
                    HIREDATE = reader.GetDateTime(4),
                    SAL = reader.GetInt32(5),
                    COMM = reader.IsDBNull(6) ? null : reader.GetInt32(6),
                    DEPTID = reader.GetInt32(7)
                });
            }

            return emps;
        }
    }
    
    public Emp GetEmp(int id)
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM emps WHERE ID=@ID", mc);
            cmd.Parameters.Add("@ID", DbType.Int32).Value = id;

            MySqlDataReader reader = cmd.ExecuteReader();

            Emp emp = new Emp();

            while (reader.Read())
            {
                emp = new Emp
                {
                    ID = reader.GetInt32(0),
                    ENAME = reader.GetString(1),
                    JOB = reader.GetString(2),
                    ParentID = reader.IsDBNull(3) ? null : reader.GetInt32(3),
                    HIREDATE = reader.GetDateTime(4),
                    SAL = reader.GetInt32(5),
                    COMM = reader.IsDBNull(6) ? null : reader.GetInt32(6),
                    DEPTID = reader.GetInt32(7)
                };
            }

            return emp;
        }
    }
    
    public void CreateEmp(Emp emp)
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();

            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO emps VALUES (@ID,@ename,@job,@ParentID,@hiredate,@sal,@comm,@DEPTID)", mc);

            cmd.Parameters.Add("@ID", DbType.Int32).Value = emp.ID;
            cmd.Parameters.Add("@ename", DbType.String).Value = emp.ENAME;
            cmd.Parameters.Add("@job", DbType.String).Value = emp.JOB;
            cmd.Parameters.Add("@ParentID", DbType.Int32).Value = (object?)emp.ParentID ?? DBNull.Value;
            cmd.Parameters.Add("@hiredate", DbType.DateTime).Value = emp.HIREDATE;
            cmd.Parameters.Add("@sal", DbType.Decimal).Value = emp.SAL;
            cmd.Parameters.Add("@comm", DbType.Decimal).Value = (object?)emp.COMM ?? DBNull.Value;
            cmd.Parameters.Add("@DEPTID", DbType.Int32).Value = emp.DEPTID;

            cmd.ExecuteNonQuery();
        }
    }
    
    public void UpdateEmp(Emp emp)
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();

            MySqlCommand cmd = new MySqlCommand(
                @"UPDATE emps 
              SET ENAME=@ename, JOB=@job, ParentID=@ParentID, HIREDATE=@hiredate, 
                  SAL=@sal, COMM=@comm, DEPTID=@DEPTID 
              WHERE ID=@ID", mc);
            
            
            if (string.IsNullOrWhiteSpace(emp.ENAME))
            {
                Console.WriteLine("Fehler");
            }

            cmd.Parameters.AddWithValue("@ID", emp.ID);
            cmd.Parameters.Add("@ename", DbType.String).Value = emp.ENAME;
            cmd.Parameters.AddWithValue("@job", emp.JOB);
            cmd.Parameters.AddWithValue("@ParentID", (object?)emp.ParentID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@hiredate", emp.HIREDATE);
            cmd.Parameters.AddWithValue("@sal", emp.SAL);
            cmd.Parameters.AddWithValue("@comm", (object?)emp.COMM ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@DEPTID", emp.DEPTID);

            cmd.ExecuteNonQuery();
        }
    }
    
    public void DeleteEmp(int id)
    {
        using (MySqlConnection mc = new MySqlConnection(connectionString))
        {
            mc.Open();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM emps WHERE ID=@ID", mc);

            cmd.Parameters.Add("@ID", DbType.Int32).Value = id;

            cmd.ExecuteNonQuery();
        }
    }
    
    
}