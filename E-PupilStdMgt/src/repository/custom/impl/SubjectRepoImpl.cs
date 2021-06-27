﻿using E_PupilStdMgt.src.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using E_PupilStdMgt.src.db;
using E_PupilStdMgt.src.utill;

namespace E_PupilStdMgt.src.repository.custom.impl
{
    class SubjectRepoImpl : ISubjectRepoCustom
    {
        DBConnection con = new DBConnection();

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Subject FindSubjectByCode(string code)
        {
            try
            {
                con.Open();
                ArrayList list = new ArrayList();
                string query = "select ID_SUBJECT, SUBJECT_NAME, SUBJECT_CODE, SUBJECT_DURATION, SUBJECT_TOTAL_POINTS from core_subject WHERE SUBJECT_CODE = '" + code + "'";

                MySqlDataReader reader = con.ExecuteReader(query);

                if (reader.Read())
                {
                    return new Subject(Int16.Parse(reader["ID_SUBJECT"].ToString()), reader["SUBJECT_NAME"].ToString(), reader["SUBJECT_CODE"].ToString(), Int16.Parse(reader["SUBJECT_DURATION"].ToString()), Double.Parse(reader["SUBJECT_TOTAL_POINTS"].ToString()));
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
                string query = "select ID_SUBJECT, SUBJECT_NAME, SUBJECT_CODE, SUBJECT_DURATION, SUBJECT_TOTAL_POINTS from core_subject";

                MySqlDataReader reader = con.ExecuteReader(query);

                while (reader.Read())
                {
                    list.Add(new Subject(Int16.Parse(reader["ID_SUBJECT"].ToString()), reader["SUBJECT_NAME"].ToString(), reader["SUBJECT_CODE"].ToString(), Int16.Parse(reader["SUBJECT_DURATION"].ToString()), Double.Parse(reader["SUBJECT_TOTAL_POINTS"].ToString())));
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

        public Subject GetOne()
        {
            throw new NotImplementedException();
        }

        public bool Save(Subject entity)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO core_subject(SUBJECT_NAME, SUBJECT_CODE, SUBJECT_DURATION, SUBJECT_TOTAL_POINTS)" +
                    " VALUES(@subjectName, @subjectCode, @subjectDuration, @subjectTotalPoints)";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@subjectName", entity.SubjectName),
                    new ParameterClass("@subjectCode", entity.SubjectCode),
                    new ParameterClass("@subjectDuration", entity.SubjectDuration.ToString()),
                    new ParameterClass("@subjectTotalPoints", entity.SubjectTotalPoints.ToString("0.00")),
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

        public Subject Search(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Subject entity)
        {
            throw new NotImplementedException();
        }
    }
}
