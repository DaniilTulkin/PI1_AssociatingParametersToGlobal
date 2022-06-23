
namespace PI1_AssociatingParametersToGlobal
{
    partial class CommandForm
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
            this.lblFamily = new System.Windows.Forms.Label();
            this.lblFamilyParameter = new System.Windows.Forms.Label();
            this.lblGlobalParameter = new System.Windows.Forms.Label();
            this.cmbFamily = new System.Windows.Forms.ComboBox();
            this.cmbFamilyParameter = new System.Windows.Forms.ComboBox();
            this.cmbGlobalParameter = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(20, 20);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(63, 13);
            this.lblFamily.TabIndex = 0;
            this.lblFamily.Text = "Семейство";
            // 
            // lblFamilyParameter
            // 
            this.lblFamilyParameter.AutoSize = true;
            this.lblFamilyParameter.Location = new System.Drawing.Point(20, 65);
            this.lblFamilyParameter.Name = "lblFamilyParameter";
            this.lblFamilyParameter.Size = new System.Drawing.Size(116, 13);
            this.lblFamilyParameter.TabIndex = 1;
            this.lblFamilyParameter.Text = "Параметр семейства";
            // 
            // lblGlobalParameter
            // 
            this.lblGlobalParameter.AutoSize = true;
            this.lblGlobalParameter.Location = new System.Drawing.Point(20, 110);
            this.lblGlobalParameter.Name = "lblGlobalParameter";
            this.lblGlobalParameter.Size = new System.Drawing.Size(121, 13);
            this.lblGlobalParameter.TabIndex = 2;
            this.lblGlobalParameter.Text = "Глобальный параметр";
            // 
            // cmbFamily
            // 
            this.cmbFamily.FormattingEnabled = true;
            this.cmbFamily.Location = new System.Drawing.Point(20, 40);
            this.cmbFamily.Name = "cmbFamily";
            this.cmbFamily.Size = new System.Drawing.Size(200, 21);
            this.cmbFamily.TabIndex = 3;
            this.cmbFamily.SelectedIndexChanged += new System.EventHandler(this.cmbFamily_SelectedIndexChanged);
            // 
            // cmbFamilyParameter
            // 
            this.cmbFamilyParameter.FormattingEnabled = true;
            this.cmbFamilyParameter.Location = new System.Drawing.Point(20, 85);
            this.cmbFamilyParameter.Name = "cmbFamilyParameter";
            this.cmbFamilyParameter.Size = new System.Drawing.Size(200, 21);
            this.cmbFamilyParameter.TabIndex = 4;
            this.cmbFamilyParameter.SelectedIndexChanged += new System.EventHandler(this.cmbFamilyParameter_SelectedIndexChanged);
            // 
            // cmbGlobalParameter
            // 
            this.cmbGlobalParameter.FormattingEnabled = true;
            this.cmbGlobalParameter.Location = new System.Drawing.Point(20, 130);
            this.cmbGlobalParameter.Name = "cmbGlobalParameter";
            this.cmbGlobalParameter.Size = new System.Drawing.Size(200, 21);
            this.cmbGlobalParameter.TabIndex = 5;
            this.cmbGlobalParameter.SelectedIndexChanged += new System.EventHandler(this.cmbGlobalParameter_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(80, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CommandForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 191);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbGlobalParameter);
            this.Controls.Add(this.cmbFamilyParameter);
            this.Controls.Add(this.cmbFamily);
            this.Controls.Add(this.lblGlobalParameter);
            this.Controls.Add(this.lblFamilyParameter);
            this.Controls.Add(this.lblFamily);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CommandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.CommandForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.Label lblFamilyParameter;
        private System.Windows.Forms.Label lblGlobalParameter;
        private System.Windows.Forms.ComboBox cmbFamily;
        private System.Windows.Forms.ComboBox cmbFamilyParameter;
        private System.Windows.Forms.ComboBox cmbGlobalParameter;
        private System.Windows.Forms.Button btnOK;
    }
}