using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using E_PupilStdMgt.src.payload;
using E_PupilStdMgt.src.service;
using E_PupilStdMgt.src.service.custom;
using E_PupilStdMgt.src.service.custom.impl;

namespace E_PupilStdMgt.src.controller.forms.screens
{
    public partial class ReportScreenForm : Form
    {
        private IClassServiceCustom iClassServiceCustom;
        public ReportScreenForm()
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

        private void ReportScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void createPanelButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
