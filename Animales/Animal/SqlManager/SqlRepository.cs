using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Animal.SqlManager
{
    public class SqlRepository : IRepository
    {
        private SqlConnectionStringBuilder sqlConnectionStringBuilder
        {
            get
            {
                return new SqlConnectionStringBuilder()
                {
                    DataSource = @"localhost\SQLExpress",
                    IntegratedSecurity = true,
                    InitialCatalog = "Animal"
                };
            }
        }


        public List<Movie> GetAll()
        {
            List<Animal> animal = new List<Animal>();
            using (SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {

                connection.Open();
                String sql = "Name, Tiene_pelo, Tiene_plumas, Pone_huevo, Da_leche, Puede_volar, Puede_nadar";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            animal.Add(new Animal()
                            {
                                Name = reader.GetInt32(0),
                                pelo = reader.GetString(1),
                                
                            });
                        }
                    }
                }
            }

            return animal;
        }

        public List<Animal> GetAnimalByName(string Name)
        {
            List<Animal> animal = new List<Animal>();
            using (SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {

                connection.Open();

                String sql = "SELECT Name";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    SqlParameter NameParam = new SqlParameter("@Name", System.Data.SqlDbType.VarChar);
                    nameParam.Value = "%" + Name + "%";
                    maneParam.Direction = System.Data.ParameterDirection.Input;
                    command.Parameters.Add(nameParam);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            animal.Add(new Animal()
                            {
                                Name = reader.GetInt32(0),
                                pelo = reader.GetString(1),
                                
                            });
                        }
                    }
                }
            }

            return animal;
        }

        public long Create(Animal animal)
        {


            /* 
             *    + " , @credits "
                        + " , @keywords "
                        + " , @poster_path "
                        + " , @backdrop_path "
                        + " , @recommendations )";*/
            try
            {


                using (SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
                {

                    connection.Open();
                    var SqlCreate = " (Name "
                            + ",Tiene_pelo"
                            + ",Tiene_plumas"
                            + ", Pone_huevos"
                            + ", Da_leche"
                            + ", Puede_volar"
                            + ", Puede_nadar "
                            + ", Es_depredador "
                            + ", Tiene_dientes "
                            + ", Tiene_espinazo "
                            + ", respira "
                            + ", Es_venenoso"
                            + ", Tiene_alas "
                            + ", Cuantas_patas"
                            + ", Tiene_cola"
                            + ", Es_domestico"
                             /* + ", credits"
                              + ", keywords"
                              + " , poster_path"
                              + " , backdrop_path"
                              + " , recommendations */ + " )"
                            + " Values ( "
                            + " @Name "
                            + " , @Tiene_pelo"
                            + " , @Tiene_plumas"
                            + " , @Pone_huevos "
                            + " , @Pone_leche "
                            + " , @Puede_volar "
                            + " , @Puede_nadar"
                            + " , @Es_depredador"
                            + " , @Tiene_dientes "
                            + " , @Tiene_espinazo "
                            + " , @respira "
                            + " , @Es_venenoso "
                            + " , @Tiene_alas "
                            + " , @Cuantas_patas "
                            + " , @Tiene_cola "
                            + " , @Es_domesticos) ";
                    //+ " , @credits )";


                    SqlCommand sqlCommand = new SqlCommand(SqlCreate, connection);

                    sqlCommand.Parameters.Add(new SqlParameter("@Name", animal.Id));

                    sqlCommand.Parameters.Add(new SqlParameter("@Tiene_pelo", animal.Tiene_pelo));
                    sqlCommand.Parameters.Add(new SqlParameter("@Tiene_plumas", animal.Tiene_plumas));
                    sqlCommand.Parameters.Add(new SqlParameter("@Pone_huevos", animal.Pone_huevos));
                    sqlCommand.Parameters.Add(new SqlParameter("@Da_leche", animal.Da_leche));
                    sqlCommand.Parameters.Add(new SqlParameter("@Puede_volar", animal.Puede_volar));
                    sqlCommand.Parameters.Add(new SqlParameter("@Puede_nadar", animal.Puede_nadar));
                    sqlCommand.Parameters.Add(new SqlParameter("@Es_domestico", animal.Es_domestico));
                    sqlCommand.Parameters.Add(new SqlParameter("@Tiene_dientes", animal.Tiene_dientes));
                    sqlCommand.Parameters.Add(new SqlParameter("@Tiene_espinazo", animal.Tiene_espinazo));
                    sqlCommand.Parameters.Add(new SqlParameter("@respira", animal.respira));
                    sqlCommand.Parameters.Add(new SqlParameter("@Es_venenoso", animal.Es_venenoso));
                    sqlCommand.Parameters.Add(new SqlParameter("@Tiene_alas", animal.Tiene_alas));
                    sqlCommand.Parameters.Add(new SqlParameter("@Cuantas_patas", animal.Cuantas_patas));
                    sqlCommand.Parameters.Add(new SqlParameter("@Tiene_cola", animal.Tiene_cola));
                    sqlCommand.Parameters.Add(new SqlParameter("@Es_domestico", animal.Es_domestico));

                    sqlCommand.ExecuteNonQuery();
                    return animal.Id;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}

