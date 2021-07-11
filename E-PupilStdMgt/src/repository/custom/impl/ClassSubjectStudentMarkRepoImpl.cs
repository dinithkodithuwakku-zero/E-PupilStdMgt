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
    class ClassSubjectStudentMarkRepoImpl : IClassSubjectStudentMarkRepoCustom
    {
        DBConnection con = new DBConnection();
        public bool Delete(int id)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM core_class_subject_student_mark WHERE ID_CLASS_SUBJECT_STUDENT_MARK = @classSubjectStudentMarkId";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@classSubjectStudentMarkId", id.ToString())
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

        public ArrayList GetAll()
        {
            try
            {
                con.Open();
                ArrayList list = new ArrayList();
                string query = "select cssm.ID_CLASS_SUBJECT_STUDENT_MARK, cssm.ID_CLASS_SUBJECT, cssm.ID_STUDENT, cssm.EXAM_DATE, cssm.STUDENT_POINT, c.ID_CLASS, sub.ID_SUBJECT, stud.ID_STUDENT from core_class_subject_student_mark cssm INNER JOIN core_class_subject csub ON cssm.ID_CLASS_SUBJECT = csub.ID_CLASS_SUBJECT INNER JOIN core_class c ON csub.ID_CLASS = c.ID_CLASS INNER JOIN core_subject sub ON csub.ID_SUBJECT = sub.ID_SUBJECT INNER JOIN core_student stud ON cssm.ID_STUDENT = stud.ID_STUDENT";

                MySqlDataReader reader = con.ExecuteReader(query);
                while (reader.Read())
                {
                    list.Add(new ClassSubjectStudentMark(Int16.Parse(reader["ID_CLASS_SUBJECT_STUDENT_MARK"].ToString()), new ClassSubject(Int16.Parse(reader["ID_CLASS_SUBJECT"].ToString()), new Class(Int16.Parse(reader["ID_CLASS"].ToString())), new Subject(Int16.Parse(reader["ID_SUBJECT"].ToString()))), new Student(Int16.Parse(reader["ID_STUDENT"].ToString())), DateTime.Parse(reader["EXAM_DATE"].ToString()), Double.Parse(reader["STUDENT_POINT"].ToString())));
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

        public ClassSubjectStudentMark GetOne()
        {
            throw new NotImplementedException();
        }

        public bool Save(ClassSubjectStudentMark entity)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO core_class_subject_student_mark(ID_CLASS_SUBJECT, ID_STUDENT, EXAM_DATE, STUDENT_POINT) VALUES(@classSubjectId, @studentId, @examDate, @studentPoint)";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@classSubjectId", entity.ClassSubject.ClassSubjectId.ToString()),
                    new ParameterClass("@studentId", entity.Student.StudentId.ToString()),
                    new ParameterClass("@examDate", entity.ExamDate.ToShortDateString()),
                    new ParameterClass("@studentPoint", entity.StudentPoint.ToString())
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

        public ClassSubjectStudentMark Search(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ClassSubjectStudentMark entity)
        {
            try
            {
                con.Open();
                string query = "UPDATE core_class_subject_student_mark SET EXAM_DATE = @examDate, STUDENT_POINT = @studentPoint WHERE ID_CLASS_SUBJECT_STUDENT_MARK = @classSubjectStudentMarkId";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@examDate", entity.ExamDate.ToShortDateString()),
                    new ParameterClass("@studentPoint", entity.StudentPoint.ToString()),
                    new ParameterClass("@classSubjectStudentMarkId", entity.ClassSubjectStudentMarkId.ToString())
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
