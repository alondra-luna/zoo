using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Animales.SqlManager
{
    public class SqlRepository
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


        public List<Animal> GetAll()
        {
            List<Animal> animal = new List<Animal>();
            using (SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {

                connection.Open();
                String sql = "select animal_name, [hair-pelo], [feathers-plumas], [eggs-huevos], [milk-leche], [airborne-vuela], [aquatic-acuatico] from zoo";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            animal.Add(new Animal()
                            {
                                Name = reader.GetString(0),
                                Tiene_pelo = reader.GetString(1),
                                
                            });
                        }
                    }
                }
            }

            return animal;
        }

        public List<Animal> GetAnimalByName(string Name)
        {
            List<Animal> listadeanimales = new List<Animal>();
            using (SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {

                connection.Open();

                String sql = "SELECT Name";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    SqlParameter NameParam = new SqlParameter("@Name", System.Data.SqlDbType.VarChar);
                    NameParam.Value = "%" + Name + "%";
                    NameParam.Direction = System.Data.ParameterDirection.Input;
                    command.Parameters.Add(NameParam);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listadeanimales.Add(new Animal()
                            {
                                Name = reader.GetString(0),
                                Tiene_pelo = reader.GetString(1) == "1" ? true : false,
                                Tiene_plumas = reader.GetString(2) == "1" ? true : false,
                                Pone_huevos = reader.GetString(3) == "1" ? true : false,
                                Da_leche = reader.GetString(4) == "1" ? true : false,
                                Puede_volar = reader.GetString(5)== "1" ? true : false,
                                Puede_nadar = reader.GetString(6) == "1" ? true : false,
                                Es_depredador = reader.GetString(7) == "1" ? true : false,
                                Tiene_dientes = reader.GetString(8) == "1" ? true : false,
                                Tiene_espinazo = reader.GetString(9) == "1" ? true : false,
                                Respira = reader.GetString(10) == "1" ? true : false,
                                Es_venenoso = reader.GetString(11) == "1" ? true : false,
                                Tiene_alas = reader.GetString(12) == "1" ? true : false,
                                Tiene_cola = reader.GetString(14) == "1" ? true : false,
                                Es_domestico = reader.GetString(15) == "1" ? true : false
                            } );
                             
                             var Cuantas_patas = 0;
                         if (Int32.TryParse(reader.GetString(13), out Cuantas_patas))
                             Cuantas_patas = 0;
                            
                                listadeanimales.Add(new Animal()
                            {
                                Cuantas_patas = Cuantas_patas
                            });
                            

                        }
                     }
                                                   
                    
                }
            }
        

            return listadeanimales;
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
                            + ", Respira "
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

                    sqlCommand.Parameters.Add(new SqlParameter("@Name", animal.Name));

                    sqlCommand.Parameters.Add(new SqlParameter("@Tiene_pelo", animal.Tiene_pelo));
                    sqlCommand.Parameters.Add(new SqlParameter("@Tiene_plumas", animal.Tiene_plumas));
                    sqlCommand.Parameters.Add(new SqlParameter("@Pone_huevos", animal.Pone_huevos));
                    sqlCommand.Parameters.Add(new SqlParameter("@Da_leche", animal.Da_leche));
                    sqlCommand.Parameters.Add(new SqlParameter("@Puede_volar", animal.Puede_volar));
                    sqlCommand.Parameters.Add(new SqlParameter("@Puede_nadar", animal.Puede_nadar));
                    sqlCommand.Parameters.Add(new SqlParameter("@Es_domestico", animal.Es_domestico));
                    sqlCommand.Parameters.Add(new SqlParameter("@Tiene_dientes", animal.Tiene_dientes));
                    sqlCommand.Parameters.Add(new SqlParameter("@Tiene_espinazo", animal.Tiene_espinazo));
                    sqlCommand.Parameters.Add(new SqlParameter("@Respira", animal.Respira));
                    sqlCommand.Parameters.Add(new SqlParameter("@Es_venenoso", animal.Es_venenoso));
                    sqlCommand.Parameters.Add(new SqlParameter("@Tiene_alas", animal.Tiene_alas));
                    sqlCommand.Parameters.Add(new SqlParameter("@Cuantas_patas", animal.Cuantas_patas));
                    sqlCommand.Parameters.Add(new SqlParameter("@Tiene_cola", animal.Tiene_cola));
                    sqlCommand.Parameters.Add(new SqlParameter("@Es_domestico", animal.Es_domestico));

                    sqlCommand.ExecuteNonQuery();
                    return animal.Name;

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

