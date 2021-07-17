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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;


namespace E_PupilStdMgt.src.controller.forms.reports
{
    public partial class ClassMappingReport : Form
    {
        private IClassServiceCustom iClassServiceCustom;
        public ClassMappingReport()
        {
            iClassServiceCustom = ServiceFactory.GetInstance().GetService<ClassServiceImpl>(ServiceFactory.ServiceTypes.CLASS);
            InitializeComponent();

            LoadClassesToPicker();
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
        public void LoadClassesToSubjectMapping()
        {
            List<ClassSubjectDTO> classSubjectList = iClassServiceCustom.FindSubjectMapping(classPicker.SelectedItem.ToString());

            subjectDataGrid.Rows.Clear();

            foreach (ClassSubjectDTO classSubjectDTO in classSubjectList)
            {
                this.subjectDataGrid.Rows.Add(classSubjectDTO.SubjectDTO.SubjectCode, classSubjectDTO.SubjectDTO.SubjectName);
            }
        }

        public void LoadClassesToStudentMapping()
        {
            List<ClassStudentDTO> classStudentList = iClassServiceCustom.FindStudentMapping(classPicker.SelectedItem.ToString());

            studentDataGrid.Rows.Clear();

            foreach (ClassStudentDTO classStudentDTO in classStudentList)
            {
                this.studentDataGrid.Rows.Add(classStudentDTO.StudentDTO.StudentRegNo, classStudentDTO.StudentDTO.StudentName);
            }
        }


        private void classPicker_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadClassesToSubjectMapping();
            LoadClassesToStudentMapping();
        }

        private void printReportButton_Click(object sender, EventArgs e)
        {
            if (classPicker.SelectedItem != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "ClassMapping.pdf";
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
                            PdfPTable subjectPDFTable = new PdfPTable(subjectDataGrid.Columns.Count);
                            subjectPDFTable.DefaultCell.Padding = 3;
                            subjectPDFTable.WidthPercentage = 100;
                            subjectPDFTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in subjectDataGrid.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                subjectPDFTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in subjectDataGrid.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    Debug.WriteLine(cell.Value.ToString());
                                    subjectPDFTable.AddCell(cell.Value.ToString());
                                }
                            }

                            PdfPTable studentPDFTable = new PdfPTable(subjectDataGrid.Columns.Count);
                            studentPDFTable.DefaultCell.Padding = 3;
                            studentPDFTable.WidthPercentage = 100;
                            studentPDFTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in studentDataGrid.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                studentPDFTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in studentDataGrid.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    studentPDFTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();

                                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                                Paragraph header = new Paragraph("Class Mapping", new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.BOLD));
                                header.Alignment = Element.ALIGN_CENTER;
                                header.SpacingAfter = 20;
                                pdfDoc.Add(header);

                                string classCode = classPicker.SelectedItem == null ? "All" : classPicker.SelectedItem.ToString();

                                Paragraph classPhrase = new Paragraph($"Class : {classCode}", new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD));
                                classPhrase.SpacingAfter = 15;
                                pdfDoc.Add(classPhrase);

                                Paragraph subjectTableTitle = new Paragraph("Subjects", new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.BOLD));
                                subjectTableTitle.SpacingAfter = 10;
                                pdfDoc.Add(subjectTableTitle);
                                pdfDoc.Add(subjectPDFTable);

                                Paragraph studentTableTitle = new Paragraph("Students", new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.BOLD));
                                studentTableTitle.SpacingAfter = 10;
                                studentTableTitle.SpacingBefore = 15;
                                pdfDoc.Add(studentTableTitle);
                                pdfDoc.Add(studentPDFTable);

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
                MessageBox.Show("Select Class!!");
            }
        }
    }
}
