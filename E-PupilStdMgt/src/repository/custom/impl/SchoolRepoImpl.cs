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
    class SchoolRepoImpl : ISchoolRepoCustom
    {

        DBConnection con = new DBConnection();

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ArrayList GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Save(School entity)
        {
            throw new NotImplementedException();
        }

        public School Search(int id)
        {
            throw new NotImplementedException();
        }

        public School GetOne()
        {
            try
            {
                con.Open();
                string query = "select ID_SCHOOL, SCHOOL_NAME, SCHOOL_DESCRIPTION, SCHOOL_CONTACT_NO, SCHOOL_ADDRESS, SCHOOL_BADGE_FILE_PATH from core_school";

                MySqlDataReader reader = con.ExecuteReader(query);

                if (reader.Read())
                {
                    return new School(Int16.Parse(reader["ID_SCHOOL"].ToString()), reader["SCHOOL_NAME"].ToString(), reader["SCHOOL_DESCRIPTION"].ToString(), reader["SCHOOL_CONTACT_NO"].ToString(), reader["SCHOOL_ADDRESS"].ToString(), reader["SCHOOL_BADGE_FILE_PATH"].ToString());
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

        public bool Update(School entity)
        {

            try
            {
                con.Open();
                string query = "update core_school set SCHOOL_NAME = @schoolName, SCHOOL_DESCRIPTION = @schoolDescription, SCHOOL_CONTACT_NO = @schoolContactNo, SCHOOL_ADDRESS = @schoolAddress, SCHOOL_BADGE_FILE_PATH = @schoolBadgeFilePath where ID_SCHOOL = @schoolId";

                // MySqlCommand updateCommand = new MySqlCommand(query, con.getConnection());
                // updateCommand.Parameters.AddWithValue("@schoolName", schoolNameInput.Text);
                // updateCommand.Parameters.AddWithValue("@schoolDescription", schoolDescriptionInput.Text);
                // updateCommand.Parameters.AddWithValue("@schoolContactNo", schoolContactNoInput.Text);
                // updateCommand.Parameters.AddWithValue("@schoolAddress", schoolAddressInput.Text);
                // updateCommand.Parameters.AddWithValue("@schoolBadgeFilePath", schoolBadgeFilePath);
                // updateCommand.Parameters.AddWithValue("@schoolId", schoolId);
                // updateCommand.ExecuteNonQuery();

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@schoolName", entity.SchoolName),
                    new ParameterClass("@schoolDescription", entity.SchoolDescription),
                    new ParameterClass("@schoolContactNo", entity.SchoolContactNo),
                    new ParameterClass("@schoolAddress", entity.SchoolAddress),
                    new ParameterClass("@schoolBadgeFilePath",entity.SchoolBadgeImagePath),
                    new ParameterClass("@schoolId", entity.SchoolId.ToString())
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
