using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DefinitionExtraction
{
    class DB
    {
        static string con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        /// <summary>
        /// Поиск терминов
        /// </summary>
        /// <param name="like">Начало термина</param>
        /// <returns></returns>
        public DataSet GetTermins(string like = "")
        {
            like =like.Trim();
            using (SqlConnection sqlConnection = new SqlConnection(con))
            using (SqlCommand cmd = sqlConnection.CreateCommand())
            {
                if (like == "")
                    cmd.CommandText = @"SELECT d.Descriptor_content + ' (' + d.Relator + ')' as 'Дескриптор', d.id 
FROM dbo.Descriptors d
order by Descriptor_content";
                else cmd.CommandText =
@"SELECT d.Descriptor_content + ' (' + d.Relator + ')' as 'Дескриптор', d.id
FROM dbo.Descriptors d
WHERE d.Descriptor_content like '' + @like + '%'
order by Descriptor_content";
                //cmd.Parameters.AddWithValue("@like", "\'"+like+ "%\'");
                cmd.Parameters.AddWithValue("@like", like);


                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                return ds;
            }
        }


        /// <summary>
        /// Добавление термина и определения
        /// </summary>
        /// <param name="descriptor"></param>
        /// <param name="stL"></param>
        /// <param name="stC"></param>
        /// <param name="eL"></param>
        /// <param name="eC"></param>
        /// <param name="description"></param>
        /// <param name="stLD"></param>
        /// <param name="stCD"></param>
        /// <param name="eLD"></param>
        /// <param name="eCD"></param>
        /// <param name="relator"></param>
        /// <returns></returns>
        public bool AddDescriptor(string descriptor, int stL, int stC, int eL, int eC,
            string description, int stLD, int stCD, int eLD, int eCD, string relator = "")
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                //sqlConnection.Open();

                SqlCommand command = sqlConnection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = sqlConnection.BeginTransaction("AddDescriptor");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = sqlConnection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                        "Insert into Descriptors VALUES (@descriptor, @stL, @stC, @eL, @eC, @relator)" +
                        "select scope_identity()";
                    command.Parameters.AddWithValue("@descriptor", descriptor);
                    command.Parameters.AddWithValue("@stL", stL);
                    command.Parameters.AddWithValue("@stC", stC);
                    command.Parameters.AddWithValue("@eL", eL);
                    command.Parameters.AddWithValue("@eC", eC);
                    command.Parameters.AddWithValue("@relator", relator);
                    //command.ExecuteNonQuery();


                    //int des_id = Convert.ToInt32(command.ExecuteScalar());
                    var des_id = command.ExecuteScalar();

                    command.Parameters.AddWithValue("@descriptor_id", des_id);

                    command.CommandText =
                        "Insert into Definitions VALUES (@description, @stLD, @stCD, @eLD, @eCD)" +
                        "select scope_identity()";
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@stLD", stLD);
                    command.Parameters.AddWithValue("@stCD", stCD);
                    command.Parameters.AddWithValue("@eLD", eLD);
                    command.Parameters.AddWithValue("@eCD", eCD);


                    //int def_id = Convert.ToInt32(command.ExecuteScalar());
                    var def_id = command.ExecuteScalar();

                    command.Parameters.AddWithValue("@definition_id", def_id);

                    command.CommandText =
                        "Insert into Connections (descriptor_id, definition_id, insert_date) " +
                        "VALUES (@descriptor_id, @definition_id, CURRENT_TIMESTAMP)";

                    

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    //Console.WriteLine("  Message: {0}", ex.Message);

                    //// Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        //// This catch block will handle any errors that may have occurred
                        //// on the server that would cause the rollback to fail, such as
                        //// a closed connection.
                        //Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        //Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                    return false;
                }
            }
        }


        /// <summary>
        /// Удаление термина
        /// </summary>
        /// <param name="descriptorID">Идентификатор дескриптора</param>
        /// <returns></returns>
        public bool DeleteTermins(string descriptorID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {

                SqlCommand command = sqlConnection.CreateCommand();
                SqlTransaction transaction = sqlConnection.BeginTransaction("DeleteDescriptor");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = sqlConnection;
                command.Transaction = transaction;

                try
                {
                    command.Parameters.AddWithValue("@descriptor_id", descriptorID);
                    
                    command.CommandText =
                        "Select definition_id from Connections where descriptor_id = @descriptor_id";

                    int def_id = -1;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            def_id= (int)reader["definition_id"];
                        }
                    }
                    command.Parameters.AddWithValue("@definition_id", def_id);


                    
                    command.CommandText =
                        "Delete from Ascriptors where descriptor_id = @descriptor_id ";
                    command.ExecuteNonQuery();
                    command.CommandText =
                        "Delete from DefinitionLinks where rel_descriptor_id=@descriptor_id or definition_id = @definition_id ";
                    command.ExecuteNonQuery();
                    command.CommandText =
                        "Delete from Connections where descriptor_id = @descriptor_id ";
                    command.ExecuteNonQuery();
                    command.CommandText =
                        "Delete from Descriptors where id = @descriptor_id ";
                    command.ExecuteNonQuery();
                    command.CommandText =
                        "Delete from Definitions where id = @definition_id ";
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    //Console.WriteLine("  Message: {0}", ex.Message);

                    //// Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        //// This catch block will handle any errors that may have occurred
                        //// on the server that would cause the rollback to fail, such as
                        //// a closed connection.
                        //Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        //Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                    return false;
                }
            }
        }


        /// <summary>
        /// Получение термина по идентификатору
        /// </summary>
        /// <param name="descriptor_id"></param>
        /// <returns></returns>
        public Termin GetTermin(int descriptor_id)
        {
            Termin termin = new Termin();
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    cmd.Parameters.AddWithValue("@descriptor_id", descriptor_id);
                    cmd.CommandText = "select descriptor_content, relator, start_line, start_char, end_line, end_char from descriptors " +
                        "where id=@descriptor_id";
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        if (reader.Read())
                        {
                            termin.Descriptor = reader["descriptor_content"].ToString();
                            termin.Relator = reader["relator"].ToString();
                            termin.StartLine = (int)reader["start_line"];
                            termin.StartChar = (int)reader["start_char"];
                            termin.EndLine = (int)reader["end_line"];
                            termin.EndChar = (int)reader["end_char"];
                        }
                    }
                    reader.Close();
                    cmd.CommandText = "select definition_content, start_line, start_char, end_line, end_char from definitions " +
                        "where id = any(select definition_id from connections where descriptor_id=descriptor_id)";
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Definition def = new Definition();
                        def.Content = reader["definition_content"].ToString();
                        def.StartLine = (int)reader["start_line"];
                        def.StartChar = (int)reader["start_char"];
                        def.EndLine = (int)reader["end_line"];
                        def.EndChar = (int)reader["end_char"];
                        termin.Definitions.Add(def);
                    }
                    reader.Close();
                    sqlConnection.Close();
                }
            }            
            return termin;
        }


        /// <summary>
        /// Добавление информации о пользователе в базу данных
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool AddUser(User user)
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                SqlCommand command = sqlConnection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = sqlConnection.BeginTransaction("AddUser");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = sqlConnection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                        "Insert into Users (first_name, last_name, email, password_hash, registration_date) VALUES (@firstName, @lastName, @email, @password, CURRENT_TIMESTAMP)" +
                        "select scope_identity()";
                    command.Parameters.AddWithValue("@firstName", user.FirstName);
                    command.Parameters.AddWithValue("@lastName", user.LastName);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@password", user.PassHash);
                    command.ExecuteNonQuery();


                    // Attempt to commit the transaction.
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    //// Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                    }
                    return false;
                }
            }

        }

        /// <summary>
        /// Вход в систему 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool LogIn(User user)
        {
            bool returned = false;
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.CommandText = "select first_name, last_name from users " +
                        "where email=@email";
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        if (reader.Read())
                        {
                            user.FirstName = reader["first_name"].ToString().Trim();
                            user.LastName = reader["last_name"].ToString().Trim();
                            returned = true;
                        }
                    }
                    reader.Close();
                }
                sqlConnection.Close();
            }
            return returned;
        }
    }
}

