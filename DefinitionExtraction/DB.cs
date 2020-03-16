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
    public enum ReturnState {Success, UniqueConstraintError, DataError };
    public enum DeleteDefinitionState { Success, DeletedWithDescriptor, DataError};
    class DB:IDisposable
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
                    cmd.CommandText =
                        "SELECT case when (LEN(d.Relator)<>0) then d.Descriptor_content + ' ('+d.Relator + ')' " +
                        "else d.Descriptor_content " +
                        "end as 'Дескриптор', d.id " +
                        "FROM dbo.Descriptors d " +
                        "order by Descriptor_content";

                else cmd.CommandText =
                        "SELECT case when (LEN(d.Relator)<>0) then d.Descriptor_content + ' ('+d.Relator + ')' " +
                        "else d.Descriptor_content " +
                        "end as 'Дескриптор', d.id " +
                        "FROM dbo.Descriptors d " +
                        "WHERE d.Descriptor_content like '' + @like + '%' " +
                        "order by Descriptor_content";

                cmd.Parameters.AddWithValue("@like", like);


                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                return ds;
            }
        }


        public ReturnState AddDescriptor(string descriptor, int stL, int stC, int eL, int eC,
            string description, int stLD, int stCD, int eLD, int eCD, string relator = "")
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                sqlConnection.Open();

                SqlCommand command = sqlConnection.CreateCommand();
                SqlTransaction transaction;

                transaction = sqlConnection.BeginTransaction("AddDescriptor");

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
                    var des_id = command.ExecuteScalar();

                    command.Parameters.AddWithValue("@descriptor_id", des_id);

                    command.CommandText =
                        "Insert into Definitions(definition_content, start_line, start_char, end_line, end_char, descriptor_id, insert_date, user_id)" +
                        " VALUES (@description, @stLD, @stCD, @eLD, @eCD, @descriptor_id,CURRENT_TIMESTAMP, @user_id)";                    
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@stLD", stLD);
                    command.Parameters.AddWithValue("@stCD", stCD);
                    command.Parameters.AddWithValue("@eLD", eLD);
                    command.Parameters.AddWithValue("@eCD", eCD);
                    command.Parameters.AddWithValue("@user_id", CurrentSession.CurrentUser.ID);

                    command.ExecuteNonQuery();

                    transaction.Commit();
                    
                    return ReturnState.Success;
                }
                catch (SqlException ex)
                {
                    //// Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                    }
                    if (ex.Number == 2601 || ex.Number == 2627)
                        return ReturnState.UniqueConstraintError;
                    else return ReturnState.DataError;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public ReturnState AddDescriptor(string descriptor, int stL, int stC, int eL, int eC,
           string description, int stLD, int stCD, int eLD, int eCD, string [] ascriptors, string relator = "")
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                sqlConnection.Open();

                SqlCommand command = sqlConnection.CreateCommand();
                SqlTransaction transaction;

                transaction = sqlConnection.BeginTransaction("AddDescriptor");

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
                    var des_id = command.ExecuteScalar();

                    command.Parameters.AddWithValue("@descriptor_id", (decimal)des_id);

                    command.CommandText =
                        "Insert into Definitions(definition_content, start_line, start_char, end_line, end_char, descriptor_id, insert_date, user_id)" +
                        " VALUES (@description, @stLD, @stCD, @eLD, @eCD, @descriptor_id,CURRENT_TIMESTAMP, @user_id)";
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@stLD", stLD);
                    command.Parameters.AddWithValue("@stCD", stCD);
                    command.Parameters.AddWithValue("@eLD", eLD);
                    command.Parameters.AddWithValue("@eCD", eCD);
                    command.Parameters.AddWithValue("@user_id", CurrentSession.CurrentUser.ID);

                    command.ExecuteNonQuery();

                    command.Parameters.AddWithValue("@ascriptor", string.Empty);
                    foreach (string ascriptor in ascriptors)
                    {
                        command.CommandText = "insert into Ascriptors(ascriptor_content, descriptor_id) values (@ascriptor, @descriptor_id)";
                        command.Parameters.RemoveAt("@ascriptor");
                        command.Parameters.AddWithValue("@ascriptor", ascriptor);
                        command.ExecuteNonQuery();

                    }
                    transaction.Commit();


                    return ReturnState.Success;
                }
                  catch (SqlException ex)
                {
                    //// Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                    }
                    if (ex.Number == 2601 || ex.Number == 2627)
                        return ReturnState.UniqueConstraintError;
                    else return ReturnState.DataError;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }


        /// <summary>
        /// Удаление термина и всех его определений
        /// </summary>
        /// <param name="descriptorID">Идентификатор дескриптора</param>
        /// <returns></returns>
        public bool DeleteTermins(string descriptorID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                sqlConnection.Open();
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
                        "Delete from Ascriptors where descriptor_id = @descriptor_id ";
                    command.ExecuteNonQuery();
                    command.CommandText =
                        "Delete from DefinitionLinks where descriptor_id=@descriptor_id or definition_id = " +
                        "any(select definition_id from definitions " +
                        "where descriptor_id=@descriptor_id)";
                    command.ExecuteNonQuery();
                    command.CommandText =
                        "Delete from Definitions where descriptor_id = @descriptor_id ";
                    command.ExecuteNonQuery();
                    command.CommandText =
                        "Delete from Descriptors where id = @descriptor_id ";
                    command.ExecuteNonQuery();


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
                finally 
                {
                    sqlConnection.Close();
                }
            }
        }

        public DeleteDefinitionState DeleteDefinition(int definitionID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                DeleteDefinitionState state = DeleteDefinitionState.Success;
                sqlConnection.Open();
                SqlCommand command = sqlConnection.CreateCommand();
                SqlTransaction transaction = sqlConnection.BeginTransaction("DeleteDescriptor");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = sqlConnection;
                command.Transaction = transaction;


                try
                {
                    command.Parameters.AddWithValue("ID", definitionID);

                    command.CommandText = "select count(descriptor_id) from definitions where descriptor_id = (select descriptor_id from definitions where ID = @ID)";
                    double count = (double)command.ExecuteScalar();
                    if (count == 0) 
                    {
                        command.CommandText =
                        "Delete from Descriptors where id = (select descriptor_id from definitions where ID = @ID); " +
                        "Delete from Ascriptors where descriptor_id = (select descriptor_id from definitions where ID = @ID); ";
                        command.ExecuteNonQuery();
                        state = DeleteDefinitionState.DeletedWithDescriptor;
                    }
                    
                    command.CommandText =
                        "Delete from DefinitionLinks where definition_id=@definition_id; " +
                        "Delete from Definitions where ID = @definition_id ";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    return state;
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
                    return DeleteDefinitionState.DataError;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public ReturnState ChangeDescription(int id, string descriptor, int stL, int stC, int eL, int eC,
            string description, int stLD, int stCD, int eLD, int eCD, string relator = "")
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                sqlConnection.Open();

                SqlCommand command = sqlConnection.CreateCommand();
                SqlTransaction transaction;

                transaction = sqlConnection.BeginTransaction("UpdateDescriptor");

                command.Connection = sqlConnection;
                command.Transaction = transaction;

                try
                {
                    //command.CommandText =
                    //    "Update Descriptors set descriptor_content = @descriptor, start_line=@stL, start_char=@stC,end_line=@eL, end_char=@eC, relator=@relator" +
                    //    "where id = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@descriptor", descriptor);
                    command.Parameters.AddWithValue("@stL", stL);
                    command.Parameters.AddWithValue("@stC", stC);
                    command.Parameters.AddWithValue("@eL", eL);
                    command.Parameters.AddWithValue("@eC", eC);
                    command.Parameters.AddWithValue("@relator", relator);
                    //command.ExecuteNonQuery();

                    command.CommandText =
                        "Update Definitions set definition_content = @description, start_line=@stLD, start_char=@stCD, end_line=@eLD, end_char=@eCD" +
                        //" where descriptor_id= @id";
                        " where id= @id";
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@stLD", stLD);
                    command.Parameters.AddWithValue("@stCD", stCD);
                    command.Parameters.AddWithValue("@eLD", eLD);
                    command.Parameters.AddWithValue("@eCD", eCD);
                    command.Parameters.AddWithValue("@user_id", CurrentSession.CurrentUser.ID);

                    command.ExecuteNonQuery();

                    transaction.Commit();
                    return ReturnState.Success;
                }
                catch (SqlException ex)
                {
                    //// Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                    }
                    if (ex.Number == 2601 || ex.Number == 2627)
                        return ReturnState.UniqueConstraintError;
                    else return ReturnState.DataError;
                }
                finally
                {
                    sqlConnection.Close();
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
                            termin.Descriptor = reader["descriptor_content"].ToString().Trim();
                            termin.Relator = reader["relator"].ToString().Trim();
                            termin.StartLine = (int)reader["start_line"];
                            termin.StartChar = (int)reader["start_char"];
                            termin.EndLine = (int)reader["end_line"];
                            termin.EndChar = (int)reader["end_char"];
                        }
                    }
                    reader.Close();
                    cmd.CommandText = "select ID, definition_content, start_line, start_char, end_line, end_char from definitions " +
                        "where descriptor_id = @descriptor_id";
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Definition def = new Definition();
                        def.ID = (int)reader["id"];
                        def.Content = reader["definition_content"].ToString().Trim();
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
        public ReturnState AddUser(User user)
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                SqlCommand command = sqlConnection.CreateCommand();
                SqlTransaction transaction;
                sqlConnection.Open();

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
                    var ID = command.ExecuteScalar();
                    user.ID = int.Parse(ID.ToString());

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    return ReturnState.Success;
                }
                catch (SqlException ex)
                {
                    //// Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                    }
                    if (ex.Number == 2601 || ex.Number == 2627)
                        return ReturnState.UniqueConstraintError;
                    else return ReturnState.DataError;
                }
                finally
                {
                    sqlConnection.Close();
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
                    cmd.CommandText = "select ID, first_name, last_name, password_hash from users " +
                        "where email=@email";
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        if (reader.Read())
                        {
                            user.ID = (int)reader["ID"];
                            user.FirstName = reader["first_name"].ToString().Trim();
                            user.LastName = reader["last_name"].ToString().Trim();
                            user.PassHash = reader["password_hash"].ToString().Trim();
                            returned = true;
                        }
                    }
                    reader.Close();
                }
                sqlConnection.Close();
            }
            return returned;
        }

        public ReturnState AddRelation(int des1ID, int des2ID, int relationID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                SqlCommand command = sqlConnection.CreateCommand();
                SqlTransaction transaction;
                sqlConnection.Open();

                // Start a local transaction.
                transaction = sqlConnection.BeginTransaction("AddRelation");

                command.Connection = sqlConnection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                        "insert into Relations (Descriptor1_ID, Descriptor2_ID, Relation_type_ID) values (@d1, @d2,@rel);";
                    command.Parameters.AddWithValue("@d1", des1ID);
                    command.Parameters.AddWithValue("@d2", des2ID);
                    command.Parameters.AddWithValue("@rel", relationID);
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    return ReturnState.Success;
                }
                catch (SqlException ex)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                    }
                    if (ex.Number == 2601 || ex.Number == 2627)
                        return ReturnState.UniqueConstraintError;
                    else return ReturnState.DataError;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        public List<Termin> DescriptorComplexQuery(Query query)
        {
            string RelDescCom;
            string TimeCom=null;
            bool noRelations=false;
            List<Termin> results = new List<Termin>();
            List<int> IDs = new List<int>();
            
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    if (query.TimeAdded)
                    {
                        TimeCom = "insert_date between @fromDate and @toDate ";
                        cmd.Parameters.AddWithValue("@fromDate",  query.FromDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@toDate", query.ToDate.ToString("yyyy-MM-dd"));
                    }
                    if (query.RelatedDescriptorID == -1 && query.RelationID==-1)
                    {
                        RelDescCom = string.Empty;
                        noRelations = true;

                    }
                    else if (query.RelatedDescriptorID== -1)
                    {
                        cmd.Parameters.AddWithValue("@relation_id", query.RelationID);
                        RelDescCom = "relation_id = @relation_id ";
                    }
                    else if (query.RelationID==-1)
                    {
                        cmd.Parameters.AddWithValue("@descriptor_id", query.RelatedDescriptorID);
                        RelDescCom = "descriptor1_id = @descriptor_id ";
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@relation_id", query.RelationID);
                        cmd.Parameters.AddWithValue("@descriptor_id", query.RelatedDescriptorID);
                        RelDescCom = "descriptor1_id = @descriptor_id and relation_type_id = @relation_id ";
                    }

                    if (query.UserAdded)
                    {
                        cmd.Parameters.AddWithValue("@user_id", CurrentSession.CurrentUser.ID);
                        if (noRelations)
                            cmd.CommandText = "select descriptor_id as descriptor2_id from definitions where user_id = @user_id ";
                        else
                            cmd.CommandText = "select descriptor2_id from relations r inner join definitions d on d.descriptor_id = r.descriptor2_id where "
                                + RelDescCom + "and user_id=@user_id ";
                        if (TimeCom != null)
                            cmd.CommandText += "and " + TimeCom;
                    }
                    else
                    {
                        cmd.CommandText = "select descriptor2_id from relations ";
                        if (TimeCom != null)
                        {
                            cmd.CommandText += "inner join definitions on descriptor_id=descriptor2_id where " + TimeCom+" and "+RelDescCom;
                        }
                        else
                            cmd.CommandText+= RelDescCom;
                        
                           
                    }
                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        if (reader.Read())
                            IDs.Add((int)reader["descriptor2_id"]);
                    }
                    reader.Close();
                }
                sqlConnection.Close();
            }
            foreach (int id in IDs)
                results.Add(GetTermin(id));
            return results;
        }

        public DataSet GetUserStatistics()
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            using (SqlCommand cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText =
                    "select dbo.UserName(user_id) as Имя, dbo.UserEmail(user_id) as Почта, count(user_id) as 'Добавлено определений' from Users u " +
                    "inner join Definitions d on u.id = d.User_ID group by user_id order by 'Добавлено определений' desc; ";


                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                return ds;
            }
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}

