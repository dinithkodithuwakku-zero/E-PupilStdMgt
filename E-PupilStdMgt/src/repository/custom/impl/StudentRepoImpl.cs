using E_PupilStdMgt.src.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using E_PupilStdMgt.src.db;
using E_PupilStdMgt.src.utill;
using System.Diagnostics;

namespace E_PupilStdMgt.src.repository.custom.impl
{
    class StudentRepoImpl : IStudentRepoCustom
    {
        DBConnection con = new DBConnection();
        public bool Delete(int id)
        {
            try
            {
                con.Open();
                string query = "UPDATE core_student SET STATUS = 0 WHERE ID_STUDENT = @stdId";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@stdId", id.ToString()),
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

        public Student FindStudentByRegNo(string regNo)
        {
            try
            {
                con.Open();
                ArrayList list = new ArrayList();
                string query = "select ID_STUDENT, STUDENT_REG_NO, STUDENT_NAME, STUDENT_MOBILE_NO, STUDENT_EMAIL, PERMANENT_ADDRESS, GENDER from core_student WHERE STATUS = 1 AND STUDENT_REG_NO = '" + regNo + "'";

                MySqlDataReader reader = con.ExecuteReader(query);

                if (reader.Read())
                {
                    return new Student(Int16.Parse(reader["ID_STUDENT"].ToString()), reader["STUDENT_REG_NO"].ToString(), reader["STUDENT_NAME"].ToString(), reader["STUDENT_MOBILE_NO"].ToString(), reader["GENDER"].ToString(), reader["STUDENT_EMAIL"].ToString(), reader["PERMANENT_ADDRESS"].ToString());
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

        public ArrayList FindStudents(Student student)
        {
            try
            {
                con.Open();
                ArrayList list = new ArrayList();
                string query;
                if (student.StudentRegNo != null)
                {
                    query = "select ID_STUDENT, STUDENT_REG_NO, STUDENT_NAME, STUDENT_MOBILE_NO, STUDENT_EMAIL, PERMANENT_ADDRESS, GENDER from core_student WHERE STUDENT_REG_NO = '" + student.StudentRegNo + "' AND STATUS = " + student.Status;
                }
                else
                {
                    query = "select ID_STUDENT, STUDENT_REG_NO, STUDENT_NAME, STUDENT_MOBILE_NO, STUDENT_EMAIL, PERMANENT_ADDRESS, GENDER from core_student WHERE STATUS = " + student.Status;
                }

                Debug.WriteLine(query);


                MySqlDataReader reader = con.ExecuteReader(query);

                while (reader.Read())
                {
                    list.Add(new Student(Int16.Parse(reader["ID_STUDENT"].ToString()), reader["STUDENT_REG_NO"].ToString(), reader["STUDENT_NAME"].ToString(), reader["STUDENT_MOBILE_NO"].ToString(), reader["GENDER"].ToString(), reader["STUDENT_EMAIL"].ToString(), reader["PERMANENT_ADDRESS"].ToString()));
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

        public Student FindStudentById(int id)
        {
            try
            {
                con.Open();
                ArrayList list = new ArrayList();
                string query = "select ID_STUDENT, STUDENT_REG_NO, STUDENT_NAME, STUDENT_MOBILE_NO, STUDENT_EMAIL, PERMANENT_ADDRESS, GENDER from core_student WHERE STATUS = 1 AND ID_STUDENT = '" + id + "'";

                MySqlDataReader reader = con.ExecuteReader(query);

                if (reader.Read())
                {
                    return new Student(Int16.Parse(reader["ID_STUDENT"].ToString()), reader["STUDENT_REG_NO"].ToString(), reader["STUDENT_NAME"].ToString(), reader["STUDENT_MOBILE_NO"].ToString(), reader["GENDER"].ToString(), reader["STUDENT_EMAIL"].ToString(), reader["PERMANENT_ADDRESS"].ToString());
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

        public int GenerateNextRegNo()
        {
            try
            {
                con.Open();
                string query = "select ID_STUDENT from core_student ORDER BY ID_STUDENT DESC LIMIT 1";

                MySqlDataReader reader = con.ExecuteReader(query);

                if (reader.Read())
                {
                    return Int16.Parse(reader["ID_STUDENT"].ToString());
                }

                return 0;
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
                string query = "select ID_STUDENT, STUDENT_REG_NO, STUDENT_NAME, STUDENT_MOBILE_NO, STUDENT_EMAIL, PERMANENT_ADDRESS, GENDER from core_student WHERE STATUS = 1";

                MySqlDataReader reader = con.ExecuteReader(query);

                while (reader.Read())
                {
                    list.Add(new Student(Int16.Parse(reader["ID_STUDENT"].ToString()), reader["STUDENT_REG_NO"].ToString(), reader["STUDENT_NAME"].ToString(), reader["STUDENT_MOBILE_NO"].ToString(), reader["GENDER"].ToString(), reader["STUDENT_EMAIL"].ToString(), reader["PERMANENT_ADDRESS"].ToString()));
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

        public Student GetOne()
        {
            throw new NotImplementedException();
        }

        public bool Save(Student entity)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO core_student(STUDENT_REG_NO, STUDENT_NAME, STUDENT_MOBILE_NO, GENDER, STUDENT_EMAIL, PERMANENT_ADDRESS)" +
                    " VALUES(@stdRegNo, @stdName, @stdMobileNo, @gender, @stdEmail, @stdPermanentAddress)";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@stdRegNo", entity.StudentRegNo),
                    new ParameterClass("@stdName", entity.StudentName),
                    new ParameterClass("@stdMobileNo", entity.MobileNo),
                    new ParameterClass("@gender", entity.Gender),
                    new ParameterClass("@stdEmail", entity.Email),
                    new ParameterClass("@stdPermanentAddress", entity.PermanentAddress),
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

        public Student Search(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student entity)
        {
            try
            {
                con.Open();
                string query = "UPDATE core_student SET STUDENT_NAME = @stdName, STUDENT_MOBILE_NO = @stdMobileNo, GENDER = @gender, STUDENT_EMAIL = @stdEmail, PERMANENT_ADDRESS = @stdPermanentAddress WHERE ID_STUDENT = @stdId";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@stdName", entity.StudentName),
                    new ParameterClass("@stdMobileNo", entity.MobileNo),
                    new ParameterClass("@gender", entity.Gender),
                    new ParameterClass("@stdEmail", entity.Email),
                    new ParameterClass("@stdPermanentAddress", entity.PermanentAddress),
                    new ParameterClass("@stdId", entity.StudentId.ToString()),
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

        public ArrayList FindAllStudentsByClassCode(string classCode)
        {
            try
            {
                con.Open();
                ArrayList list = new ArrayList();
                string query = "select s.ID_STUDENT, s.STUDENT_REG_NO, s.STUDENT_NAME, s.STUDENT_MOBILE_NO, s.STUDENT_EMAIL, s.PERMANENT_ADDRESS, s.GENDER from core_student s INNER JOIN core_class_student cs ON s.ID_STUDENT = cs.ID_STUDENT INNER JOIN core_class c ON c.ID_CLASS = cs.ID_CLASS WHERE s.STATUS = 1 AND c.CLASS_CODE = '" + classCode + "'";

                MySqlDataReader reader = con.ExecuteReader(query);

                while (reader.Read())
                {
                    list.Add(new Student(Int16.Parse(reader["ID_STUDENT"].ToString()), reader["STUDENT_REG_NO"].ToString(), reader["STUDENT_NAME"].ToString(), reader["STUDENT_MOBILE_NO"].ToString(), reader["GENDER"].ToString(), reader["STUDENT_EMAIL"].ToString(), reader["PERMANENT_ADDRESS"].ToString()));
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
    }
}
