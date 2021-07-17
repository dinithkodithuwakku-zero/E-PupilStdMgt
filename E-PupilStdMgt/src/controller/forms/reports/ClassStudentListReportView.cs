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

namespace E_PupilStdMgt.src.controller.forms.reports
{
    public partial class ClassStudentListReportView : Form
    {
        private IClassServiceCustom iClassServiceCustom;
        private IStudentServiceCustom iStudentServiceCustom;
        public ClassStudentListReportView()
        {
            iClassServiceCustom = ServiceFactory.GetInstance().GetService<ClassServiceImpl>(ServiceFactory.ServiceTypes.CLASS);
            iStudentServiceCustom = ServiceFactory.GetInstance().GetService<StudentServiceImpl>(ServiceFactory.ServiceTypes.STUDENT);
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

        public void LoadStudentDetails()
        {
            try
            {
                studentDataGrid.Rows.Clear();

                List<StudentDTO> list = iStudentServiceCustom.FindAllStudentsByClassCode(classPicker.SelectedItem.ToString());

                foreach (StudentDTO dto in list)
                {
                    this.studentDataGrid.Rows.Add(dto.StudentRegNo, dto.StudentName, dto.Email, dto.MobileNo, dto.PermanentAddress, dto.Gender);
                }
            }
            catch
            {
                MessageBox.Show("Unable to load student details!", "Error!");
            }
        }

        private void printReportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.csv)|*.csv";
            sfd.FileName = $"ClassStudentList-{classPicker.SelectedItem.ToString()}.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToCsV(studentDataGrid, sfd.FileName);
            }
        }

        private void classPicker_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadStudentDetails();
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            if (dGV.Rows.Count > 0)
            {
                string stOutput = "";
                // Export titles:
                string sHeaders = "";

                for (int j = 0; j < dGV.Columns.Count; j++)
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + ",";
                stOutput += sHeaders + "\r\n";
                // Export data.
                for (int i = 0; i < dGV.RowCount; i++)
                {
                    string stLine = "";
                    for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    {
                        string cellValue = Convert.ToString(dGV.Rows[i].Cells[j].Value);
                        if (cellValue.Contains(","))
                        {
                            cellValue = cellValue.Replace(",", string.Empty);
                        }
                        if (cellValue.Contains(Environment.NewLine))
                        {
                            cellValue = cellValue.Replace(Environment.NewLine, " ");
                        }
                        stLine = stLine.ToString() + cellValue + ",";
                    }

                    Debug.WriteLine(stLine);
                    stOutput += stLine + "\r\n";
                }
                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(output, 0, output.Length); //write the encoded file
                bw.Flush();
                bw.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("No Record To Generete!", "Info");
            }
        }
    }
}
