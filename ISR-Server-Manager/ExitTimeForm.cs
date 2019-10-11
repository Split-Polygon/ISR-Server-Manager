// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISR_Server_Manager
{
    public partial class ExitTimeForm : Form
    {
        public Int16 Minutes
        {
            get
            {
                return Int16.Parse(mtbMinutes.Text);
            }
            set
            {
                mtbMinutes.Text = value.ToString();
            }
        }

        public Boolean RestartEnabled
        {
            get
            {
                return chkRestart.Checked;
            }
            set
            {
                chkRestart.Checked = value;
            }
        }

        public ExitTimeForm()
        {
            InitializeComponent();
        }

        private void ButConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
