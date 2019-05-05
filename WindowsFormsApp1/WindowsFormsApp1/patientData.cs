﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1
{
    public partial class PatientData : Form
    {

        private PatientBasicRepository patientBasicRepository = new PatientBasicRepository();
        private List<PatientBasic> pbList;

        public PatientData()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            pbList = patientBasicRepository.selectAll();
            List<string> nameList = new List<string>();
            foreach (PatientBasic pb in pbList)
                nameList.Add(pb.Name);
            patientName.DataSource = nameList;
        }

        private void goPatientDetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientDetail detail = new PatientDetail();
            detail.Owner = this;
            detail.Show();
            patientBasicRepository.close();
        }

        private void patientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            StaticPatient.patient = pbList[patientName.SelectedIndex];
        }
    }
}
