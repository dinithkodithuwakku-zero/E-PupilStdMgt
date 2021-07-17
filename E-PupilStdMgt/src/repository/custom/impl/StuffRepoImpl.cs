using E_PupilStdMgt.src.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using E_PupilStdMgt.src.db;
using E_PupilStdMgt.src.utill;

namespace E_PupilStdMgt.src.repository.custom.impl
{
    class StuffRepoImpl : IStuffRepoCustom
    {
        DBConnection con = new DBConnection();
        public bool Delete(int id)
        {
            try
            {
                con.Open();
                string query = "UPDATE core_stuff SET STATUS = 0 WHERE ID_STUFF = @stuffId";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@stuffId", id.ToString()),
                };


                int affected = con.ExecuteQueryWithParameters(query, parameterClasses);

                if (affected != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                con.Close();
            }
        }

        public Stuff FindStuffByUserName(string userName)
        {
            try
            {
                con.Open();
                ArrayList list = new ArrayList();
                string query = "select ID_STUFF, USER_NAME, PASSWORD,  FULL_NAME, NIC, JOB_TITLE, MOBILE_NO, EMAIL, PERMANENT_ADDRESS from core_stuff WHERE STATUS = 1 AND USER_NAME = '" + userName + "'";

                MySqlDataReader reader = con.ExecuteReader(query);

                if (reader.Read())
                {
                    return new Stuff(Int16.Parse(reader["ID_STUFF"].ToString()), reader["USER_NAME"].ToString(), reader["PASSWORD"].ToString(), reader["FULL_NAME"].ToString(), reader["NIC"].ToString(), reader["JOB_TITLE"].ToString(), reader["MOBILE_NO"].ToString(), reader["EMAIL"].ToString(), reader["PERMANENT_ADDRESS"].ToString());
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                con.Close();
            }
        }

        public ArrayList GetAll()
        {
            try
            {
                con.Open();
                ArrayList list = new ArrayList();
                string query = "select ID_STUFF, USER_NAME, FULL_NAME, NIC, JOB_TITLE, MOBILE_NO, EMAIL, PERMANENT_ADDRESS from core_stuff WHERE STATUS = 1";

                MySqlDataReader reader = con.ExecuteReader(query);

                while (reader.Read())
                {
                    list.Add(new Stuff(Int16.Parse(reader["ID_STUFF"].ToString()), reader["USER_NAME"].ToString(), reader["FULL_NAME"].ToString(), reader["NIC"].ToString(), reader["JOB_TITLE"].ToString(), reader["MOBILE_NO"].ToString(), reader["EMAIL"].ToString(), reader["PERMANENT_ADDRESS"].ToString()));
                }

                return list;
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                con.Close();
            }
        }

        public Stuff GetOne()
        {
            throw new NotImplementedException();
        }

        public bool Save(Stuff entity)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO core_stuff(USER_NAME, PASSWORD, FULL_NAME, NIC, JOB_TITLE, MOBILE_NO, EMAIL, PERMANENT_ADDRESS)" +
                    " VALUES(@userName, @password, @fullName, @nic, @jobTitle, @mobileNo, @email, @permanentAddress)";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@userName", entity.UserName),
                    new ParameterClass("@password", entity.Password),
                    new ParameterClass("@fullName", entity.FullName),
                    new ParameterClass("@nic", entity.Nic),
                    new ParameterClass("@jobTitle", entity.JobTitle),
                    new ParameterClass("@mobileNo", entity.MobileNo),
                    new ParameterClass("@email", entity.Email),
                    new ParameterClass("@permanentAddress", entity.PermanentAddress),
                };


                int affected = con.ExecuteQueryWithParameters(query, parameterClasses);

                if (affected != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                con.Close();
            }
        }

        public Stuff Search(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Stuff entity)
        {
            try
            {
                con.Open();
                string query = "UPDATE core_stuff SET FULL_NAME = @fullName, NIC = @nic, JOB_TITLE = @jobTitle, MOBILE_NO = @mobileNo, EMAIL = @email, PERMANENT_ADDRESS = @permanentAddress WHERE ID_STUFF = @stuffId";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@fullName", entity.FullName),
                    new ParameterClass("@nic", entity.Nic),
                    new ParameterClass("@jobTitle", entity.JobTitle),
                    new ParameterClass("@mobileNo", entity.MobileNo),
                    new ParameterClass("@email", entity.Email),
                    new ParameterClass("@permanentAddress", entity.PermanentAddress),
                    new ParameterClass("@stuffId", entity.StuffId.ToString()),
                };


                int affected = con.ExecuteQueryWithParameters(query, parameterClasses);

                if (affected != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
