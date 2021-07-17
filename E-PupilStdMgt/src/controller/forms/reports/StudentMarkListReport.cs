using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using E_PupilStdMgt.src.payload;
using E_PupilStdMgt.src.service;
using E_PupilStdMgt.src.service.custom;
using E_PupilStdMgt.src.service.custom.impl;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace E_PupilStdMgt.src.controller.forms.reports
{
    public partial class StudentMarkListReport : Form
    {
        private IClassServiceCustom iClassServiceCustom;
        private ISubjectServiceCustom iSubjectServiceCustom;
        private IClassSubjectStudentMarkServiceCustom iClassSubjectStudentMarkServiceCustom;
        public StudentMarkListReport()
        {
            iClassServiceCustom = ServiceFactory.GetInstance().GetService<ClassServiceImpl>(ServiceFactory.ServiceTypes.CLASS);
            iSubjectServiceCustom = ServiceFactory.GetInstance().GetService<SubjectServiceImpl>(ServiceFactory.ServiceTypes.SUBJECT);
            iClassSubjectStudentMarkServiceCustom = ServiceFactory.GetInstance().GetService<ClassSubjectStudentServiceImpl>(ServiceFactory.ServiceTypes.ClASS_SUBJECT_STUDENT_MARK);
            InitializeComponent();

            LoadClassesToPicker();
            LoadClassSubjectStudentMarkDetails();
        }

        void LoadClassesToPicker()
        {
            try
            {
                List<ClassDTO> list = iClassServiceCustom.FindAllClasses();

                foreach (ClassDTO classDTO in list)
                {
                    classPicker.Items.Add(classDTO.ClassCode);
                }
            }
            catch
            {
                MessageBox.Show("Unable to load classes!", "Error!");
            }
        }

        void LoadSubjectsToPickerByClassCode()
        {
            try
            {
                subjectPicker.Items.Clear();

                List<SubjectDTO> list = iSubjectServiceCustom.FindAllSubjectsByClassCode(classPicker.SelectedItem.ToString());

                foreach (SubjectDTO subjectDTO in list)
                {
                    subjectPicker.Items.Add(subjectDTO.SubjectCode);
                }
            }
            catch
            {
                MessageBox.Show("Unable to load subjects!", "Error!");
            }
        }

        private void classPicker_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadSubjectsToPickerByClassCode();
            LoadClassSubjectStudentMarkDetails();
        }

        void LoadClassSubjectStudentMarkDetails()
        {
            try
            {
                classSubjectStudentMarkDataGrid.Rows.Clear();

                List<ClassSubjectStudentMarkDTO> list;

                if ((classPicker.SelectedItem != null && !classPicker.SelectedItem.ToString().Equals("")) && (subjectPicker.SelectedItem != null && !subjectPicker.SelectedItem.ToString().Equals("")))
                {
                    Debug.WriteLine("asdasd");
                    list = iClassSubjectStudentMarkServiceCustom.FindClassSubjectStudentMarks(classPicker.SelectedItem.ToString(), subjectPicker.SelectedItem.ToString());
                }
                else if (classPicker.SelectedItem != null && !classPicker.SelectedItem.ToString().Equals(""))
                {

                    list = iClassSubjectStudentMarkServiceCustom.FindClassSubjectStudentMarks(classPicker.SelectedItem.ToString(), null);
                }
                else
                {
                    list = iClassSubjectStudentMarkServiceCustom.FindClassSubjectStudentMarks();
                }


                foreach (ClassSubjectStudentMarkDTO dto in list)
                {
                    this.classSubjectStudentMarkDataGrid.Rows.Add(dto.ClassSubjectDTO.ClassDTO.ClassCode, dto.ClassSubjectDTO.ClassDTO.ClassName, dto.ClassSubjectDTO.SubjectDTO.SubjectCode, dto.ClassSubjectDTO.SubjectDTO.SubjectName, dto.StudentDTO.StudentName, dto.ExamDate.ToShortDateString(), dto.StudentPoint);
                }
            }
            catch
            {
                MessageBox.Show("Unable to load class details!", "Error!");
            }
        }

        private void subjectPicker_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadClassSubjectStudentMarkDetails();
        }

        private void printReportButton_Click(object sender, EventArgs e)
        {
            if (classSubjectStudentMarkDataGrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "StudentMarks.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Can not Write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(classSubjectStudentMarkDataGrid.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in classSubjectStudentMarkDataGrid.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in classSubjectStudentMarkDataGrid.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();

                                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                                Paragraph header = new Paragraph("Student Marks List", new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.BOLD));
                                header.Alignment = Element.ALIGN_CENTER;
                                header.SpacingAfter = 20;
                                pdfDoc.Add(header);

                                string classCode = classPicker.SelectedItem == null ? "All" : classPicker.SelectedItem.ToString();
                                string subjectCode = subjectPicker.SelectedItem == null ? "All" : subjectPicker.SelectedItem.ToString();

                                Paragraph classPhrase = new Paragraph($"Class : {classCode}", new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.BOLD));
                                classPhrase.SpacingAfter = 10;
                                pdfDoc.Add(classPhrase);

                                Paragraph subjectPhrase = new Paragraph($"Subject : {subjectCode}", new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.BOLD));
                                subjectPhrase.SpacingAfter = 15;
                                pdfDoc.Add(subjectPhrase);

                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("PDF File Generated!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Generete!", "Info");
            }
        }
    }
}
