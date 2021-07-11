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

        public bool AddSubjectMapping(ClassSubject classSubject)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO core_class_subject(ID_CLASS, ID_SUBJECT) VALUES(@classId, @subjectId)";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@classId", classSubject.ClassEntity.ClassId.ToString()),
                    new ParameterClass("@subjectId", classSubject.SubjectEntity.SubjectId.ToString()),
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

        public ArrayList GetSubjectMapping()
        {
            try
            {
                con.Open();
                ArrayList list = new ArrayList();
                string query = "select cs.ID_CLASS_SUBJECT, c.ID_CLASS as ID_CLASS, c.CLASS_NAME as CLASS_NAME, c.CLASS_CODE as CLASS_CODE, c.IS_ACTIVE as IS_ACTIVE, cs.ID_SUBJECT from core_class_subject cs INNER JOIN core_class c ON cs.ID_CLASS = c.ID_CLASS";

                MySqlDataReader reader = con.ExecuteReader(query);
                while (reader.Read())
                {

                    Subject subjectEntity = new Subject();
                    subjectEntity.SubjectId = Int16.Parse(reader["ID_SUBJECT"].ToString());
                    list.Add(new ClassSubject(Int16.Parse(reader["ID_CLASS_SUBJECT"].ToString()), new Class(Int16.Parse(reader["ID_CLASS"].ToString()), reader["CLASS_NAME"].ToString(), reader["CLASS_CODE"].ToString(), Int16.Parse(reader["IS_ACTIVE"].ToString())), subjectEntity));
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

        public ArrayList GetStudentMapping()
        {
            try
            {
                con.Open();
                ArrayList list = new ArrayList();
                string query = "select cs.ID_CLASS_STUDENT, c.ID_CLASS as ID_CLASS, c.CLASS_NAME as CLASS_NAME, c.CLASS_CODE as CLASS_CODE, c.IS_ACTIVE as IS_ACTIVE, cs.ID_STUDENT from core_class_student cs INNER JOIN core_class c ON cs.ID_CLASS = c.ID_CLASS";

                MySqlDataReader reader = con.ExecuteReader(query);
                while (reader.Read())
                {

                    Student studentEntity = new Student();
                    studentEntity.StudentId = Int16.Parse(reader["ID_STUDENT"].ToString());
                    list.Add(new ClassStudent(Int16.Parse(reader["ID_CLASS_STUDENT"].ToString()), new Class(Int16.Parse(reader["ID_CLASS"].ToString()), reader["CLASS_NAME"].ToString(), reader["CLASS_CODE"].ToString(), Int16.Parse(reader["IS_ACTIVE"].ToString())), studentEntity));
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

        public bool AddStudentMapping(ClassStudent classStudent)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO core_class_student(ID_CLASS, ID_STUDENT) VALUES(@classId, @studentId)";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@classId", classStudent.ClassEntity.ClassId.ToString()),
                    new ParameterClass("@studentId", classStudent.StudentEntity.StudentId.ToString()),
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

        public bool Delete(int id)
        {
            /*
            try
            {
                con.Open();
                string query = "DELETE FROM core_class WHERE ID_CLASS = @classId;";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@classId", id.ToString())
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
            */

            try
            {
                con.Open();
                string query = "UPDATE core_class SET STATUS = @status WHERE ID_CLASS = @classId;";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@status", "0"),
                    new ParameterClass("@classId", id.ToString())
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

        public Class FindClassByCode(string code)
        {
            try
            {
                con.Open();
                string query = "select ID_CLASS, CLASS_NAME, CLASS_CODE, IS_ACTIVE from core_class WHERE STATUS = 1 AND CLASS_CODE = '" + code + "'";

                MySqlDataReader reader = con.ExecuteReader(query);

                if (reader.Read())
                {
                    return new Class(Int16.Parse(reader["ID_CLASS"].ToString()), reader["CLASS_NAME"].ToString(), reader["CLASS_CODE"].ToString(), Int16.Parse(reader["IS_ACTIVE"].ToString()));
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
                string query = "select ID_CLASS, CLASS_NAME, CLASS_CODE, IS_ACTIVE from core_class WHERE STATUS = 1";

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
                string query = "INSERT INTO core_class(CLASS_NAME, CLASS_CODE, IS_ACTIVE, STATUS) VALUES(@className, @classCode, @isActive, @status)";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@className", entity.ClassName),
                    new ParameterClass("@classCode", entity.ClassCode),
                    new ParameterClass("@isActive", entity.IsActive.ToString()),
                    new ParameterClass("@status", "1"),
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
            try
            {
                con.Open();
                string query = "select ID_CLASS, CLASS_NAME, CLASS_CODE, IS_ACTIVE from core_class WHERE STATUS = 1 AND ID_CLASS = '" + id + "'";

                MySqlDataReader reader = con.ExecuteReader(query);

                if (reader.Read())
                {
                    return new Class(Int16.Parse(reader["ID_CLASS"].ToString()), reader["CLASS_NAME"].ToString(), reader["CLASS_CODE"].ToString(), Int16.Parse(reader["IS_ACTIVE"].ToString()));
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

        public bool Update(Class entity)
        {
            try
            {
                con.Open();
                string query = "UPDATE core_class SET CLASS_NAME = @className, CLASS_CODE = @classCode, IS_ACTIVE = @isActive WHERE ID_CLASS = @classId;";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@className", entity.ClassName),
                    new ParameterClass("@classCode", entity.ClassCode),
                    new ParameterClass("@isActive", entity.IsActive.ToString()),
                    new ParameterClass("@classId", entity.ClassId.ToString())
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

        public ArrayList FindSubjectMappingByStudentAndClass(int classId, int studentId)
        {
            try
            {
                con.Open();
                ArrayList list = new ArrayList();
                string query = "select cs.ID_CLASS_SUBJECT, c.ID_CLASS as ID_CLASS, c.CLASS_NAME as CLASS_NAME, c.CLASS_CODE as CLASS_CODE, c.IS_ACTIVE as IS_ACTIVE, cs.ID_SUBJECT from core_class_subject cs INNER JOIN core_class c ON cs.ID_CLASS = c.ID_CLASS INNER JOIN core_class_student cstd ON cstd.ID_CLASS = c.ID_CLASS WHERE c.ID_CLASS = '" + classId + "' and cstd.ID_STUDENT = '" + studentId + "'";

                MySqlDataReader reader = con.ExecuteReader(query);
                while (reader.Read())
                {

                    Subject subjectEntity = new Subject();
                    subjectEntity.SubjectId = Int16.Parse(reader["ID_SUBJECT"].ToString());
                    list.Add(new ClassSubject(Int16.Parse(reader["ID_CLASS_SUBJECT"].ToString()), new Class(Int16.Parse(reader["ID_CLASS"].ToString()), reader["CLASS_NAME"].ToString(), reader["CLASS_CODE"].ToString(), Int16.Parse(reader["IS_ACTIVE"].ToString())), subjectEntity));
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

        public ClassSubject FindClassSubjectByClassCodeAndSubjectCode(string classCode, string subjectCode)
        {
            try
            {
                con.Open();
                ArrayList list = new ArrayList();
                string query = "select cs.ID_CLASS_SUBJECT, c.ID_CLASS as ID_CLASS, c.CLASS_NAME as CLASS_NAME, c.CLASS_CODE as CLASS_CODE, c.IS_ACTIVE as IS_ACTIVE, cs.ID_SUBJECT from core_class_subject cs INNER JOIN core_class c ON cs.ID_CLASS = c.ID_CLASS INNER JOIN core_subject s ON cs.ID_SUBJECT = s.ID_SUBJECT WHERE c.CLASS_CODE = '" + classCode + "' and s.SUBJECT_CODE = '" + subjectCode + "'";

                MySqlDataReader reader = con.ExecuteReader(query);
                if (reader.Read())
                {

                    Subject subjectEntity = new Subject();
                    subjectEntity.SubjectId = Int16.Parse(reader["ID_SUBJECT"].ToString());
                    return new ClassSubject(Int16.Parse(reader["ID_CLASS_SUBJECT"].ToString()), new Class(Int16.Parse(reader["ID_CLASS"].ToString()), reader["CLASS_NAME"].ToString(), reader["CLASS_CODE"].ToString(), Int16.Parse(reader["IS_ACTIVE"].ToString())), subjectEntity);
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
    }
}
