using Ojeda.Concesionario.DB.Entities;
using Microsoft.Data.SqlClient;

namespace Ojeda.Concesionario.DB.DataAccess
{
    public class CarRepository
    {
        private readonly string _connectionString;

        public CarRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Car v)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Car 
                                (Code, Type, Brand, Model, Year, Description, Patent, Kilometers, Price, Active, IncomeDate) 
                                VALUES (@Code, @Type, @Brand, @Model, @Year, @Description, @Patent, @Kilometers, @Price, 1, @IncomeDate)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Code", v.Code);
                cmd.Parameters.AddWithValue("@Type", v.Type);
                cmd.Parameters.AddWithValue("@Brand", v.Brand);
                cmd.Parameters.AddWithValue("@Model", v.Model);
                cmd.Parameters.AddWithValue("@Year", v.Year);
                cmd.Parameters.AddWithValue("@Description", v.Description ?? "");
                cmd.Parameters.AddWithValue("@Patent", v.Patent);
                cmd.Parameters.AddWithValue("@Kilometers", v.Kilometers);
                cmd.Parameters.AddWithValue("@Price", v.Price);
                cmd.Parameters.AddWithValue("@IncomeDate", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Car v)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE Car SET 
                                Code=@Code, Type=@Type, Brand=@Brand, Model=@Model, Year=@Year, 
                                Description=@Description, Patent=@Patent, Kilometers=@Kilometers, Price=@Price
                                WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", v.Id);
                cmd.Parameters.AddWithValue("@Code", v.Code);
                cmd.Parameters.AddWithValue("@Type", v.Type);
                cmd.Parameters.AddWithValue("@Brand", v.Brand);
                cmd.Parameters.AddWithValue("@Model", v.Model);
                cmd.Parameters.AddWithValue("@Year", v.Year);
                cmd.Parameters.AddWithValue("@Description", v.Description ?? "");
                cmd.Parameters.AddWithValue("@Patent", v.Patent);
                cmd.Parameters.AddWithValue("@Kilometers", v.Kilometers);
                cmd.Parameters.AddWithValue("@Price", v.Price);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Baja lógica
        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE Car SET Active=0 WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Car GetByID(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Car WHERE Id=@Id AND Active=1";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return MapVehiculo(reader);
                }
                return null;
            }
        }

        public List<Car> Get()
        {
            var lista = new List<Car>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Car WHERE Active=1";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(MapVehiculo(reader));
                }
            }
            return lista;
        }

        private Car MapVehiculo(SqlDataReader reader)
        {
            return new Car
            {
                Id = Convert.ToInt32(reader["Id"]),
                Code = reader["Code"].ToString(),
                Type = reader["Type"].ToString(),
                Brand = reader["Brand"].ToString(),
                Model = reader["Model"].ToString(),
                Year = Convert.ToInt32(reader["Year"]),
                Description = reader["Description"].ToString(),
                Patent = reader["Patent"].ToString(),
                Kilometers = Convert.ToInt32(reader["Kilometers"]),
                Price = Convert.ToDecimal(reader["Price"]),
                Active = Convert.ToBoolean(reader["Active"]),
                IncomeDate = Convert.ToDateTime(reader["IncomeDate"])
            };
        }
    }
}
