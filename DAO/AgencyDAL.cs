using SpaceAgencyado.Model;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using SpaceAgencyado.Interface;

namespace SpaceAgencyado.DAO
{
    public class AgencyDAL : IAgencyDA
    {
        public static IConfiguration Configuration { get; set; }

        private string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
            return Configuration.GetConnectionString("DefaultConnection");
        }


        
        
        public AgencyDAL()
        {
            
        }

        public List<Agencies> GetAgencies()
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            List<Agencies> agencies = new List<Agencies>();
            string query = "[dbo].[GetAgencies]";
            SqlCommand command = new SqlCommand(query, con);
            command.CommandType =  CommandType.StoredProcedure;
            command.CommandText = query;
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {            

                while (reader.Read())
                {
                    Agencies agency = new Agencies
                    {
                        id = (int)reader["id"],
                        name = reader["name"].ToString(),
                        fullform = reader["fullform"].ToString(),
                        country = reader["country"].ToString(),
                        budget = reader["budget"].ToString(),
                        establishment = reader["establishment"].ToString(),
                        founder = reader["founder"].ToString(),
                        launchstation = reader["launchstation"].ToString(),
                        majorprojects = reader["majorprojects"].ToString(),
                        recentproject = reader["recentproject"].ToString(),
                        upcomingprojects = reader["upcomingprojects"].ToString(),
                        owner = reader["owner"].ToString(),
                        type = reader["type"].ToString(),
                        picture = reader["picture"].ToString(),
                    };

                    agencies.Add(agency);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { con.Close(); }

            return agencies;


        }
        public List<Agencies> GetAgenciesById(int id)
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            List<Agencies> agencies = new List<Agencies>();
            string query = "[dbo].[GetAgenciesById]";
            SqlCommand command = new SqlCommand(query, con);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = query;
            command.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    Agencies agency = new Agencies
                    {
                        id = (int)reader["id"],
                        name = reader["name"].ToString(),
                        fullform = reader["fullform"].ToString(),
                        country = reader["country"].ToString(),
                        budget = reader["budget"].ToString(),
                        establishment = reader["establishment"].ToString(),
                        founder = reader["founder"].ToString(),
                        launchstation = reader["launchstation"].ToString(),
                        majorprojects = reader["majorprojects"].ToString(),
                        recentproject = reader["recentproject"].ToString(),
                        upcomingprojects = reader["upcomingprojects"].ToString(),
                        owner = reader["owner"].ToString(),
                        type = reader["type"].ToString(),
                        picture = reader["picture"].ToString(),
                    };

                    agencies.Add(agency);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { con.Close(); }

            return agencies;


        }

        public void AddAgency(Agencies agency)

        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                string query = "[dbo].[AddAgency]";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = query;
                command.Parameters.AddWithValue("@id", agency.id);
                command.Parameters.AddWithValue("@Name", agency.name);
                command.Parameters.AddWithValue("@FullForm", agency.fullform);
                command.Parameters.AddWithValue("@country", agency.country);
                command.Parameters.AddWithValue("@budget", agency.budget);
                command.Parameters.AddWithValue("@establishment", agency.establishment); 
                command.Parameters.AddWithValue("@founder", agency.founder);
                command.Parameters.AddWithValue("@launchstation", agency.launchstation);
                command.Parameters.AddWithValue("@majorprojects", agency.majorprojects);
                command.Parameters.AddWithValue("@recentproject", agency.recentproject);
                command.Parameters.AddWithValue("@upcomingprojects", agency.upcomingprojects);
                command.Parameters.AddWithValue("@owner", agency.owner);
                command.Parameters.AddWithValue("@type", agency.type);
                command.Parameters.AddWithValue("@picture", agency.picture);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateAgency(Agencies agency)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());

            
                string query = "[dbo].[UpdateAgency]";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = query;

                command.Parameters.AddWithValue("@Id", agency.id);
                command.Parameters.AddWithValue("@Name", agency.name);
                command.Parameters.AddWithValue("@Fullform", agency.fullform);
                command.Parameters.AddWithValue("@country", agency.country);
                command.Parameters.AddWithValue("@budget", agency.budget);
                command.Parameters.AddWithValue("@establishment", agency.establishment);
                command.Parameters.AddWithValue("@founder", agency.founder);
                command.Parameters.AddWithValue("@launchstation", agency.launchstation);
                command.Parameters.AddWithValue("@majorprojects", agency.majorprojects);
                command.Parameters.AddWithValue("@recentproject", agency.recentproject);

                command.Parameters.AddWithValue("@upcomingprojects", agency.upcomingprojects);
                command.Parameters.AddWithValue("@owner", agency.owner);
                command.Parameters.AddWithValue("@type", agency.type);
                command.Parameters.AddWithValue("@picture", agency.picture);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            
        }

        public void DeleteAgency(int id)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                string query = "[dbo].[DeleteAgency]";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = query;
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public List<countries> GetCountries()
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            List<countries> countries = new List<countries>();

            string query = "[dbo].[GetCountries]";
            SqlCommand command = new SqlCommand(query, con);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = query;
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    countries country = new countries
                    {
                        country_id = (int)reader["country_id"],
                        name = reader["name"].ToString(),  
                    };
                    countries.Add(country);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { con.Close(); }

            return countries;
        }

        public List<space_station> GetSp(string nm)
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            List<space_station> space_station = new List<space_station>();

            string query = "[dbo].[GetSp]";
          
            SqlCommand command = new SqlCommand(query, con);
            command.CommandType= CommandType.StoredProcedure;
            command.CommandText = query;
            command.Parameters.AddWithValue("@nm", nm);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    space_station st = new space_station
                    {
                        //st_id = (int)reader["st_id"],
                        st_name = reader["st_name"].ToString(),
                    };
                    space_station.Add(st);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { con.Close(); }

            return space_station;
        }

        public List<MissionInfo> GetSpaceMission()
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            List<MissionInfo> MissIn = new List<MissionInfo>();
            string query = "[dbo].[GetSpaceMission]";
            SqlCommand command = new SqlCommand(query, con);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = query;
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    
                    MissionInfo MI = new MissionInfo
                    {
                        majorprojects = reader["majorprojects"].ToString(),
                        fullform = reader["fullform"].ToString(),
                        country = reader["country"].ToString(),
                        st_name = reader["st_name"].ToString(),
                        name = reader["name"].ToString(),

                    };

                    MissIn.Add(MI);

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { con.Close(); }

            return MissIn;


        }
    }
}
