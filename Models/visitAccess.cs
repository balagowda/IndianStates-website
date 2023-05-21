using System.Data.SqlClient;

namespace Assignment.Models
{
    public class visitAccess
    {
        List<Visit> VisitData = new List<Visit>();

        public List<Visit> GetStates()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=States;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from visit", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Visit v = new Visit();
                    v.visitId = int.Parse(dr[0].ToString());
                    v.visitPlace = dr[1].ToString();
                    v.visitPic = dr[2].ToString();
                    v.visitDesc = dr[3].ToString();
                    VisitData.Add(v);
                }
                return VisitData;
            }
            catch (Exception ex)
            {
                return VisitData;
            }
            finally { conn.Close(); }
        }
    }
}
