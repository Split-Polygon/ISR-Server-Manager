// Copyright (c) Chilimeat & joemorin
// SPDX-License-Identifier: MIT License

namespace ISR_Server_Manager
{
    partial class ExitTimeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butConfirm = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.mtbMinutes = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRestart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // butConfirm
            // 
            this.butConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butConfirm.Location = new System.Drawing.Point(393, 93);
            this.butConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(100, 28);
            this.butConfirm.TabIndex = 0;
            this.butConfirm.Text = "Confirm";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Click += new System.EventHandler(this.ButConfirm_Click);
            // 
            // butCancel
            // 
            this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(501, 93);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(100, 28);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.ButCancel_Click);
            // 
            // mtbMinutes
            // 
            this.mtbMinutes.Location = new System.Drawing.Point(13, 13);
            this.mtbMinutes.Mask = "990";
            this.mtbMinutes.Name = "mtbMinutes";
            this.mtbMinutes.Size = new System.Drawing.Size(59, 22);
            this.mtbMinutes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirm shutdown time.  (In minutes)";
            // 
            // chkRestart
            // 
            this.chkRestart.AutoSize = true;
            this.chkRestart.Location = new System.Drawing.Point(13, 42);
            this.chkRestart.Name = "chkRestart";
            this.chkRestart.Size = new System.Drawing.Size(76, 21);
            this.chkRestart.TabIndex = 4;
            this.chkRestart.Text = "Restart";
            this.chkRestart.UseVisualStyleBackColor = true;
            // 
            // ExitTimeForm
            // 
            this.AcceptButton = this.butConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(617, 136);
            this.Controls.Add(this.chkRestart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbMinutes);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExitTimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirm Shutdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butConfirm;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.MaskedTextBox mtbMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkRestart;
    }
}