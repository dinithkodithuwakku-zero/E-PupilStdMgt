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
    class ClassRepoImpl : IClassRepoCustom
    {
        DBConnection con = new DBConnection();
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ArrayList GetAll()
        {
            try
            {
                con.Open();
                ArrayList list = new ArrayList();
                string query = "select ID_CLASS, CLASS_NAME, CLASS_CODE, IS_ACTIVE from core_class";

                MySqlDataReader reader = con.ExecuteReader(query);
                while (reader.Read())
                {
                    list.Add(new Class(Int16.Parse(reader["ID_CLASS"].ToString()), reader["CLASS_NAME"].ToString(), reader["CLASS_CODE"].ToString(), Int16.Parse(reader["IS_ACTIVE"].ToString())));
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

        public Class GetOne()
        {
            throw new NotImplementedException();
        }

        public bool Save(Class entity)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO core_class(CLASS_NAME, CLASS_CODE, IS_ACTIVE) VALUES(@className, @classCode, @isActive)";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@className", entity.ClassName),
                    new ParameterClass("@classCode", entity.ClassCode),
                    new ParameterClass("@isActive", entity.IsActive.ToString())
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

        public Class Search(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Class entity)
        {
            throw new NotImplementedException();
        }
    }
}
