using System.Data.SqlClient;

namespace Assignment.Models
{
    public class StatesAccess
    {
        List <States> StatesData = new List <States> ();

        public List<States> GetStates()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=States;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from state", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    States s = new States();
                    s.statesID = int.Parse(dr[0].ToString());
                    s.statesName = dr[1].ToString();
                    s.stateCapital = dr[2].ToString();
                    s.stateLanguage = dr[3].ToString();
                    StatesData.Add(s);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return StatesData;
        }
    }
}
