namespace AdmissionCommitteeLabs.View
{
    partial class FormSQL
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
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonApplicantsData = new System.Windows.Forms.RadioButton();
            this.radioButtonPersonalFile = new System.Windows.Forms.RadioButton();
            this.radioButtonApplicantsRankingLists = new System.Windows.Forms.RadioButton();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            this.groupBoxSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPage2);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(800, 450);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(792, 424);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonApplicantsRankingLists);
            this.groupBoxSelect.Controls.Add(this.radioButtonPersonalFile);
            this.groupBoxSelect.Controls.Add(this.radioButtonApplicantsData);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(786, 100);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonApplicantsData
            // 
            this.radioButtonApplicantsData.AutoSize = true;
            this.radioButtonApplicantsData.Location = new System.Drawing.Point(6, 19);
            this.radioButtonApplicantsData.Name = "radioButtonApplicantsData";
            this.radioButtonApplicantsData.Size = new System.Drawing.Size(100, 17);
            this.radioButtonApplicantsData.TabIndex = 0;
            this.radioButtonApplicantsData.TabStop = true;
            this.radioButtonApplicantsData.Text = "Applicants Data";
            this.radioButtonApplicantsData.UseVisualStyleBackColor = true;
            this.radioButtonApplicantsData.CheckedChanged += new System.EventHandler(this.radioButtonApplicantsData_CheckedChanged);
            // 
            // radioButtonPersonalFile
            // 
            this.radioButtonPersonalFile.AutoSize = true;
            this.radioButtonPersonalFile.Location = new System.Drawing.Point(112, 19);
            this.radioButtonPersonalFile.Name = "radioButtonPersonalFile";
            this.radioButtonPersonalFile.Size = new System.Drawing.Size(82, 17);
            this.radioButtonPersonalFile.TabIndex = 1;
            this.radioButtonPersonalFile.TabStop = true;
            this.radioButtonPersonalFile.Text = "Personal file";
            this.radioButtonPersonalFile.UseVisualStyleBackColor = true;
            this.radioButtonPersonalFile.CheckedChanged += new System.EventHandler(this.radioButtonPersonalFile_CheckedChanged);
            // 
            // radioButtonApplicantsRankingLists
            // 
            this.radioButtonApplicantsRankingLists.AutoSize = true;
            this.radioButtonApplicantsRankingLists.Location = new System.Drawing.Point(200, 19);
            this.radioButtonApplicantsRankingLists.Name = "radioButtonApplicantsRankingLists";
            this.radioButtonApplicantsRankingLists.Size = new System.Drawing.Size(132, 17);
            this.radioButtonApplicantsRankingLists.TabIndex = 2;
            this.radioButtonApplicantsRankingLists.TabStop = true;
            this.radioButtonApplicantsRankingLists.Text = "Applicants ranking lists";
            this.radioButtonApplicantsRankingLists.UseVisualStyleBackColor = true;
            this.radioButtonApplicantsRankingLists.CheckedChanged += new System.EventHandler(this.radioButtonApplicantsRankingLists_CheckedChanged);
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 318);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonApplicantsRankingLists;
        private System.Windows.Forms.RadioButton radioButtonPersonalFile;
        private System.Windows.Forms.RadioButton radioButtonApplicantsData;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
    }
}