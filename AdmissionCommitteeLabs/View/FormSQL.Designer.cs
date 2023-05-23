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
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonApplicantsRankingLists = new System.Windows.Forms.RadioButton();
            this.radioButtonPersonalFile = new System.Windows.Forms.RadioButton();
            this.radioButtonApplicantsData = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.labelApplicant = new System.Windows.Forms.Label();
            this.textBoxApplicant = new System.Windows.Forms.TextBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonDet_Date = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_RankPosition = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_NO = new System.Windows.Forms.RadioButton();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
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
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 318);
            this.dataGridViewSelect.TabIndex = 1;
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
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridView1);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 424);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_select);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.textBoxApplicant);
            this.groupBoxFSelect.Controls.Add(this.labelApplicant);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(786, 208);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Баллы абитуриентов";
            // 
            // labelApplicant
            // 
            this.labelApplicant.AutoSize = true;
            this.labelApplicant.Location = new System.Drawing.Point(6, 25);
            this.labelApplicant.Name = "labelApplicant";
            this.labelApplicant.Size = new System.Drawing.Size(78, 13);
            this.labelApplicant.TabIndex = 0;
            this.labelApplicant.Text = "Personal file ID";
            // 
            // textBoxApplicant
            // 
            this.textBoxApplicant.Location = new System.Drawing.Point(153, 22);
            this.textBoxApplicant.Name = "textBoxApplicant";
            this.textBoxApplicant.Size = new System.Drawing.Size(172, 20);
            this.textBoxApplicant.TabIndex = 1;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonDet_NO);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_RankPosition);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Date);
            this.groupBoxDet.Location = new System.Drawing.Point(509, 25);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(257, 106);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация баллов абитуриентов";
            // 
            // radioButtonDet_Date
            // 
            this.radioButtonDet_Date.AutoSize = true;
            this.radioButtonDet_Date.Location = new System.Drawing.Point(6, 28);
            this.radioButtonDet_Date.Name = "radioButtonDet_Date";
            this.radioButtonDet_Date.Size = new System.Drawing.Size(179, 17);
            this.radioButtonDet_Date.TabIndex = 0;
            this.radioButtonDet_Date.TabStop = true;
            this.radioButtonDet_Date.Text = "Баллы абитуриентов по датам";
            this.radioButtonDet_Date.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_RankPosition
            // 
            this.radioButtonDet_RankPosition.AutoSize = true;
            this.radioButtonDet_RankPosition.Location = new System.Drawing.Point(6, 51);
            this.radioButtonDet_RankPosition.Name = "radioButtonDet_RankPosition";
            this.radioButtonDet_RankPosition.Size = new System.Drawing.Size(236, 17);
            this.radioButtonDet_RankPosition.TabIndex = 1;
            this.radioButtonDet_RankPosition.TabStop = true;
            this.radioButtonDet_RankPosition.Text = "Баллы абитуриентов по месту в рейтинге";
            this.radioButtonDet_RankPosition.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_NO
            // 
            this.radioButtonDet_NO.AutoSize = true;
            this.radioButtonDet_NO.Location = new System.Drawing.Point(6, 74);
            this.radioButtonDet_NO.Name = "radioButtonDet_NO";
            this.radioButtonDet_NO.Size = new System.Drawing.Size(112, 17);
            this.radioButtonDet_NO.TabIndex = 2;
            this.radioButtonDet_NO.TabStop = true;
            this.radioButtonDet_NO.Text = "Нет детализации";
            this.radioButtonDet_NO.UseVisualStyleBackColor = true;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(9, 53);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(138, 17);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Выбрать баллы более";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(153, 51);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(172, 20);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(9, 86);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(244, 17);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.Text = "Включить сортировку по убыванию баллов";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // buttonF_select
            // 
            this.buttonF_select.Location = new System.Drawing.Point(587, 152);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(179, 32);
            this.buttonF_select.TabIndex = 6;
            this.buttonF_select.Text = "Баллы абитуриентов";
            this.buttonF_select.UseVisualStyleBackColor = true;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 210);
            this.dataGridView1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonApplicantsRankingLists;
        private System.Windows.Forms.RadioButton radioButtonPersonalFile;
        private System.Windows.Forms.RadioButton radioButtonApplicantsData;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.Button buttonF_select;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonDet_NO;
        private System.Windows.Forms.RadioButton radioButtonDet_RankPosition;
        private System.Windows.Forms.RadioButton radioButtonDet_Date;
        private System.Windows.Forms.TextBox textBoxApplicant;
        private System.Windows.Forms.Label labelApplicant;
    }
}