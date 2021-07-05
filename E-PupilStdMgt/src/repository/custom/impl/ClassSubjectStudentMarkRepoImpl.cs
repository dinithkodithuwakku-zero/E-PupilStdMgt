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
    class ClassSubjectStudentMarkRepoImpl : IClassSubjectStudentMarkRepoCustom
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
                string query = "select ID_CLASS_SUBJECT_STUDENT_MARK, ID_CLASS, ID_CLASS_SUBJECT, ID_STUDENT, EXAM_DATE, STUDENT_POINT from core_class_subject_student_mark";

                MySqlDataReader reader = con.ExecuteReader(query);
                while (reader.Read())
                {
                    list.Add(new ClassSubjectStudentMark(Int16.Parse(reader["ID_CLASS_SUBJECT_STUDENT_MARK"].ToString()), new ClassSubject(Int16.Parse(reader["ID_CLASS_SUBJECT"].ToString())), new Student(Int16.Parse(reader["ID_STUDENT"].ToString())), DateTime.Parse(reader["EXAM_DATE"].ToString()), Double.Parse(reader["STUDENT_POINT"].ToString())));
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
            throw new NotImplementedException();
        }
    }
}
