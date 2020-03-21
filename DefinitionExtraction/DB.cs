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
    class DBQueries
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
            {
                SqlCommand cmd = sqlConnection.CreateCommand();

                if (like == "")
                    cmd.CommandText =
                        "SELECT case when (LEN(d.Relator)<>0) then d.Descriptor_content + ' ('+d.Relator + ')' " +
                        "else d.Descriptor_content " +
                        "end as 'Дескриптор', d.id as 'ID'" +
                        "FROM dbo.Descriptors d " +
                        "order by Descriptor_content";

                else cmd.CommandText =
                        "SELECT case when (LEN(d.Relator)<>0) then d.Descriptor_content + ' ('+d.Relator + ')' " +
                        "else d.Descriptor_content " +
                        "end as 'Дескриптор', d.id as 'ID' " +
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
                    command.Parameters.AddWithValue("@descriptor", descriptor);
                    command.Parameters.AddWithValue("@stL", stL);
                    command.Parameters.AddWithValue("@stC", stC);
                    command.Parameters.AddWithValue("@eL", eL);
                    command.Parameters.AddWithValue("@eC", eC);
                    command.Parameters.AddWithValue("@relator", relator);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@stLD", stLD);
                    command.Parameters.AddWithValue("@stCD", stCD);
                    command.Parameters.AddWithValue("@eLD", eLD);
                    command.Parameters.AddWithValue("@eCD", eCD);
                    command.Parameters.AddWithValue("@user_id", CurrentSession.CurrentUser.ID);

                    command.CommandText =
                        "Insert into Descriptors VALUES (@descriptor, @stL, @stC, @eL, @eC, @relator)" +
                        "select scope_identity()";
                    
                    var des_id = command.ExecuteScalar();
                    command.Parameters.AddWithValue("@descriptor_id", des_id);

                    command.CommandText =
                        "Insert into Definitions(definition_content, start_line, start_char, end_line, end_char, " +
                        "descriptor_id, insert_date, user_id)" +
                        " VALUES (@description, @stLD, @stCD, @eLD, @eCD, @descriptor_id,CURRENT_TIMESTAMP, @user_id)";                    
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
                    catch (Exception)
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
                        "Insert into Definitions(definition_content, start_line, start_char, end_line, end_char, descriptor_id, insert_date, user_id) " +
                        "VALUES (@description, @stLD, @stCD, @eLD, @eCD, @descriptor_id,CURRENT_TIMESTAMP, @user_id)";
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
                    catch (Exception)
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

                command.Connection = sqlConnection;
                command.Transaction = transaction;


                try
                {
                    command.Parameters.AddWithValue("@descriptor_id", descriptorID);


                    command.CommandText =
                        "Delete from Ascriptors where descriptor_id = @descriptor_id; " +
                        "Delete from DefinitionLinks where descriptor_id = @descriptor_id or definition_id = " +
                        "any(select definition_id from definitions " +
                        "where descriptor_id=@descriptor_id); " +
                        "Delete from Definitions where descriptor_id = @descriptor_id; " +
                        "Delete from Descriptors where id = @descriptor_id; ";
                    command.ExecuteNonQuery();
                    
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception)
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

                command.Connection = sqlConnection;
                command.Transaction = transaction;


                try
                {
                    command.Parameters.AddWithValue("ID", definitionID);

                    command.CommandText = 
                        "select count(descriptor_id) from definitions " +
                        "where descriptor_id = (select descriptor_id from definitions where ID = @ID)";
                    double count = (double)command.ExecuteScalar();
                    if (count == 1) 
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
                catch (Exception)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception)
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
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@descriptor", descriptor);
                    command.Parameters.AddWithValue("@stL", stL);
                    command.Parameters.AddWithValue("@stC", stC);
                    command.Parameters.AddWithValue("@eL", eL);
                    command.Parameters.AddWithValue("@eC", eC);
                    command.Parameters.AddWithValue("@relator", relator);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@stLD", stLD);
                    command.Parameters.AddWithValue("@stCD", stCD);
                    command.Parameters.AddWithValue("@eLD", eLD);
                    command.Parameters.AddWithValue("@eCD", eCD);
                    command.Parameters.AddWithValue("@user_id", CurrentSession.CurrentUser.ID);

                    command.CommandText = "select count(descriptor_id) from definitions where descriptor_id = (select descriptor_id from definitions where ID = @ID)";
                    int count = (int)command.ExecuteScalar();

                    

                    if (count > 1)
                    {
                        command.CommandText =
                            "Insert into Descriptors VALUES (@descriptor, @stL, @stC, @eL, @eC, @relator); " +
                            "select scope_identity()";
                        double dID = (double)command.ExecuteScalar();
                        command.Parameters.AddWithValue("@dID", dID);
                        
                        command.CommandText =
                            "Update Definitions set descriptor_id = @dID definition_content = @description, " +
                            "start_line=@stLD, start_char=@stCD, end_line=@eLD, end_char=@eCD " +
                            " where id= @id";

                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        command.CommandText =
                            "Update Descriptors set descriptor_content = @descriptor, start_line=@stL, " +
                            "start_char=@stC,end_line=@eL, end_char=@eC, relator=@relator " +
                            "where id = (select descriptor_id from definitions where id=@id)";

                        command.ExecuteNonQuery();

                        command.CommandText =
                            "Update Definitions set definition_content = @description, start_line=@stLD, " +
                            "start_char=@stCD, end_line=@eLD, end_char=@eCD " +
                            "where id= @id";

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
                    catch (Exception)
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
                SqlCommand cmd = sqlConnection.CreateCommand();
                
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
                        Definition def = new Definition
                        {
                            ID = (int)reader["id"],
                            Content = reader["definition_content"].ToString().Trim(),
                            StartLine = (int)reader["start_line"],
                            StartChar = (int)reader["start_char"],
                            EndLine = (int)reader["end_line"],
                            EndChar = (int)reader["end_char"]
                        };
                        termin.Definitions.Add(def);
                    }
                    reader.Close();

                    foreach(Definition def in termin.Definitions)
                    {
                        def.Links = GetLinks(def.ID, sqlConnection);
                    }

                    cmd.CommandText = "select ascriptor_content from ascriptors " +
                        "where descriptor_id = @descriptor_id";
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        termin.Ascriptors.Add(reader["ascriptor_content"].ToString());
                    }
                    reader.Close();

                    cmd.CommandText = "select t.ID, type_name, Descriptor2_ID, Descriptor_content " +
                        "from Relation_types t, Relations r, Descriptors d " +
                        "where r.Relation_type_ID = t.ID and Descriptor1_ID = @descriptor_id " +
                        "and d.id = Descriptor2_ID; ";
                    reader = cmd.ExecuteReader();

                    RelationsList rl = new RelationsList();
                    while (reader.Read())
                    {
                        Termin related = new Termin();
                        related.ID = (int)reader["descriptor2_id"];
                        related.Descriptor = reader["descriptor_content"].ToString();
                        rl.AddRelation(new Relation((int)reader["ID"], reader["type_name"].ToString()), related);
                    }
                    termin.Relations = rl;
                    reader.Close();

                    

                    sqlConnection.Close();
                
            }            
            return termin;
        }

        public List<Link> GetLinks(int definitionID, SqlConnection sqlConnection)
        {
            List<Link> links = new List<Link>();
            SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select descriptor_id, l.Start_char, d.descriptor_content " +
                            "from DefinitionLinks l, descriptors d " +
                            "where Definition_ID = @definition_id and descriptor_id = d.id";
                cmd.Parameters.AddWithValue("@definition_id", definitionID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    links.Add(new Link((int)reader["start_char"], (int)reader["descriptor_id"], reader["descriptor_content"].ToString()));
                reader.Close();
            
            return links;
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
                    catch (Exception)
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
                SqlCommand cmd = sqlConnection.CreateCommand();
                
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.CommandText = 
                    "select ID, first_name, last_name, password_hash from users " +
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
                    catch (Exception)
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
            List<Termin> results = new List<Termin>();
            List<int> IDs = new List<int>();
            
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();

                cmd.CommandText = "select distinct des.ID " +
                    "from descriptors des, Definitions def, Relations r " +
                    "where des.id = def.Descriptor_ID " +
                    "and(r.Descriptor1_ID = des.ID or r.Descriptor2_ID = des.ID) ";
                
                    if (query.TimeAdded)
                    {
                    cmd.CommandText+= "and def.Insert_date between @fromDate and @toDate ";
                        cmd.Parameters.AddWithValue("@fromDate",  query.FromDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@toDate", query.ToDate.ToString("yyyy-MM-dd"));
                    }
                    if (query.RelatedDescriptorID != -1)
                    {
                        cmd.CommandText += "and (r.Descriptor1_ID=@relID or r.Descriptor2_ID =@relID) and des.id <> @relID ";
                        cmd.Parameters.AddWithValue("@relID", query.RelatedDescriptorID);
                    }

                    else if (query.RelationID != -1)
                    {
                        cmd.CommandText += "and r.Relation_type_ID = @relationID ";
                        cmd.Parameters.AddWithValue("@relationID", query.RelationID);
                    }

                    if (query.UserAdded)
                    {
                    cmd.CommandText += "and user_id = @user_id ";
                        cmd.Parameters.AddWithValue("@user_id", CurrentSession.CurrentUser.ID);
                    }
                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        if (reader.Read())
                            IDs.Add((int)reader["id"]);
                    }
                    reader.Close();
                
                sqlConnection.Close();
            }

            foreach (int id in IDs)
                results.Add(GetTermin(id));
            return results;
        }

        public DataSet GetUserStatistics()
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            { 
                SqlCommand cmd = sqlConnection.CreateCommand();
            
                cmd.CommandText =
                    "select dbo.UserName(user_id) as Имя, dbo.UserEmail(user_id) as Почта, count(user_id) as 'Добавлено определений' from Users u " +
                    "inner join Definitions d on u.id = d.User_ID group by user_id order by 'Добавлено определений' desc; ";


                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                return ds;
            }
        }

        public DataSet GetUserStatistics(DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                SqlCommand cmd = sqlConnection.CreateCommand();

                cmd.CommandText =
                    "select dbo.UserName(user_id) as Имя, dbo.UserEmail(user_id) as Почта, " +
                    "count(user_id) as 'Добавлено определений' from Users u " +
                    "inner join Definitions d on u.id = d.User_ID " +
                    "where insert_date between @fromDate and @toDate " +
                    "group by user_id order by 'Добавлено определений' desc; ";
                cmd.Parameters.AddWithValue("@fromDate", fromDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("toDate", toDate.ToString("yyyy-MM-dd"));

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                return ds;
            }
        }

        public DataSet GetDescStatistics()
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                SqlCommand cmd = sqlConnection.CreateCommand();

                cmd.CommandText =
                    "select descriptor_content as Дескриптор, relator as Релятор, definition_content as Определение," +
                    " first_name+' '+last_name as Имя, insert_date as Дата " +
                    "from Users u, Definitions def, descriptors des " +
                    "where def.user_id = u.ID and def.descriptor_id = des.ID";


                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                return ds;
            }
        }
        public DataSet GetDescStatistics(DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                SqlCommand cmd = sqlConnection.CreateCommand();

                cmd.CommandText =
                    "select descriptor_content as Дескриптор, relator as Релятор, definition_content as Определение," +
                    " first_name+' '+last_name as Имя, insert_date as Дата " +
                    "from Users u, Definitions def, descriptors des " +
                    "where insert_date between @fromDate and @toDate " +
                    "and def.user_id = u.ID and def.descriptor_id = des.ID";
                cmd.Parameters.AddWithValue("@fromDate", fromDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("toDate", toDate.ToString("yyyy-MM-dd"));

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                return ds;
            }
        }

        public ReturnState AddAscriptor(int descriptorID, string ascriptor)
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                sqlConnection.Open();

                SqlCommand command = sqlConnection.CreateCommand();
                SqlTransaction transaction;

                transaction = sqlConnection.BeginTransaction("AddAscriptor");

                command.Connection = sqlConnection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                        "Insert into Ascriptors (ascriptor_content, descriptor_id) VALUES (@ascriptor, @id)";
                    command.Parameters.AddWithValue("@ascriptor", ascriptor);
                    command.Parameters.AddWithValue("@id", descriptorID);
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
                    catch (Exception)
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

        public ReturnState AddLink (int definitionID, int descriptorID, int startChar)
        {
            using (SqlConnection sqlConnection = new SqlConnection(con))
            {
                sqlConnection.Open();

                SqlCommand command = sqlConnection.CreateCommand();
                SqlTransaction transaction;

                transaction = sqlConnection.BeginTransaction("AddLink");

                command.Connection = sqlConnection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                        "Insert into DefinitionLinks (descriptor_id, definition_id, start_char) VALUES (@id, @definition, @startChar)";
                    command.Parameters.AddWithValue("@definition", definitionID);
                    command.Parameters.AddWithValue("@startChar", startChar);
                    command.Parameters.AddWithValue("@id", descriptorID);
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
                    catch (Exception)
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
    }
}

