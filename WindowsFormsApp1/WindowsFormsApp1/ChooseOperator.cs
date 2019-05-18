﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Model;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1
{
    public partial class ChooseOperator : Form
    {
        List<AnesthesiaData> ad = new List<AnesthesiaData>();
        AnesthesiaDataRepository apr = new AnesthesiaDataRepository();
        public ChooseOperator()
        {
            InitializeComponent();
            LoadData();
        }

        //查找相應的手術，加載第一次的數據
        private void LoadData()
        {
            ad = apr.SelectByChartNo(StaticPatient.patient.CharNo);

            if (ad.Count == 0)
                Alert();
            else
            { 
                List<string> lst = new List<string>();
                foreach (AnesthesiaData ad in ad)
                    lst.Add(ad.OperationDate.ToString());
                list.DataSource = lst;

                if (ad[0].OperationDate != null)
                    date.Text = ad[0].OperationDate.ToString();
                name.Text = StaticPatient.patient.Name;
                dname.Text = ad[0].Surgeon;
                sname.Text = ad[0].SugeryName;
                room.Text = ad[0].OperatingRoom;
                StaticPatient.AnesthesiaID = ad[0].AnesthesiaID;
            }
        }

        //這裡還有BUG！！！
        private void Alert()
        {
            DialogResult dr = MessageBox.Show("這個病人沒有即將進行的手術！", 
                "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Owner.Show();
            //this.Close();
        }

        //開始手術 會記錄時間 還有BUG！！
        private void Start_Click(object sender, EventArgs e)
        {
            apr.SetStartTime(StaticPatient.AnesthesiaID);
            MainView mv = new MainView();
            mv.Show();
            //this.Owner.Owner.Close();
            //this.Owner.Close();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            date.Text = ad[list.SelectedIndex].OperationDate.ToString();
            dname.Text = ad[list.SelectedIndex].Surgeon;
            sname.Text = ad[list.SelectedIndex].SugeryName;
            room.Text = ad[list.SelectedIndex].OperatingRoom;
            StaticPatient.AnesthesiaID = ad[list.SelectedIndex].AnesthesiaID;
        }
    }
}
