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
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonDet_NO = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_RankPosition = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Date = new System.Windows.Forms.RadioButton();
            this.textBoxApplicant = new System.Windows.Forms.TextBox();
            this.labelApplicant = new System.Windows.Forms.Label();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxPersonalFileID = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.buttonSelectApplicants = new System.Windows.Forms.Button();
            this.dataGridViewApplicants = new System.Windows.Forms.DataGridView();
            this.panelApplicant = new System.Windows.Forms.Panel();
            this.buttonOpenPhoto_Applicant = new System.Windows.Forms.Button();
            this.pictureBoxPhoto_Applicant = new System.Windows.Forms.PictureBox();
            this.labelPhoto_Applicant = new System.Windows.Forms.Label();
            this.textBoxAdmission = new System.Windows.Forms.TextBox();
            this.textBoxPersonal_dp = new System.Windows.Forms.TextBox();
            this.labelAdmission = new System.Windows.Forms.Label();
            this.labelPersonal_dp = new System.Windows.Forms.Label();
            this.textBoxPrevious_education = new System.Windows.Forms.TextBox();
            this.labelPrevious_education = new System.Windows.Forms.Label();
            this.textBoxl_identity = new System.Windows.Forms.TextBox();
            this.labelName_identity = new System.Windows.Forms.Label();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.textBoxId_applicant = new System.Windows.Forms.TextBox();
            this.labelId_applicant = new System.Windows.Forms.Label();
            this.radioButtonDelete_applicant = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate_applicant = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert_applicant = new System.Windows.Forms.RadioButton();
            this.openFileDialogApplicant = new System.Windows.Forms.OpenFileDialog();
            this.labelScores = new System.Windows.Forms.Label();
            this.textBoxScores = new System.Windows.Forms.TextBox();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicants)).BeginInit();
            this.panelApplicant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_Applicant)).BeginInit();
            this.groupBoxDML.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
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
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 424);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 211);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.Size = new System.Drawing.Size(786, 210);
            this.dataGridViewFSelect.TabIndex = 1;
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
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(153, 51);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(172, 20);
            this.textBoxMore.TabIndex = 4;
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
            // textBoxApplicant
            // 
            this.textBoxApplicant.Location = new System.Drawing.Point(153, 22);
            this.textBoxApplicant.Name = "textBoxApplicant";
            this.textBoxApplicant.Size = new System.Drawing.Size(172, 20);
            this.textBoxApplicant.TabIndex = 1;
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
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(792, 424);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 129);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.Size = new System.Drawing.Size(786, 292);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxPersonalFileID);
            this.groupBoxSubquery.Controls.Add(this.labelNumber);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(786, 126);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(6, 88);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(140, 32);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxPersonalFileID
            // 
            this.textBoxPersonalFileID.Location = new System.Drawing.Point(97, 45);
            this.textBoxPersonalFileID.Name = "textBoxPersonalFileID";
            this.textBoxPersonalFileID.Size = new System.Drawing.Size(363, 20);
            this.textBoxPersonalFileID.TabIndex = 3;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(3, 48);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(83, 13);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "personal_file_ID";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(272, 19);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(188, 17);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(175, 17);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.buttonSelectApplicants);
            this.tabPageDML.Controls.Add(this.dataGridViewApplicants);
            this.tabPageDML.Controls.Add(this.panelApplicant);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 22);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(792, 424);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // buttonSelectApplicants
            // 
            this.buttonSelectApplicants.Location = new System.Drawing.Point(294, 234);
            this.buttonSelectApplicants.Name = "buttonSelectApplicants";
            this.buttonSelectApplicants.Size = new System.Drawing.Size(212, 23);
            this.buttonSelectApplicants.TabIndex = 3;
            this.buttonSelectApplicants.Text = "Показать список абитуриентов";
            this.buttonSelectApplicants.UseVisualStyleBackColor = true;
            this.buttonSelectApplicants.Click += new System.EventHandler(this.buttonSelectApplicants_Click);
            // 
            // dataGridViewApplicants
            // 
            this.dataGridViewApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplicants.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewApplicants.Location = new System.Drawing.Point(3, 263);
            this.dataGridViewApplicants.Name = "dataGridViewApplicants";
            this.dataGridViewApplicants.Size = new System.Drawing.Size(786, 158);
            this.dataGridViewApplicants.TabIndex = 2;
            // 
            // panelApplicant
            // 
            this.panelApplicant.Controls.Add(this.textBoxScores);
            this.panelApplicant.Controls.Add(this.labelScores);
            this.panelApplicant.Controls.Add(this.buttonOpenPhoto_Applicant);
            this.panelApplicant.Controls.Add(this.pictureBoxPhoto_Applicant);
            this.panelApplicant.Controls.Add(this.labelPhoto_Applicant);
            this.panelApplicant.Controls.Add(this.textBoxAdmission);
            this.panelApplicant.Controls.Add(this.textBoxPersonal_dp);
            this.panelApplicant.Controls.Add(this.labelAdmission);
            this.panelApplicant.Controls.Add(this.labelPersonal_dp);
            this.panelApplicant.Controls.Add(this.textBoxPrevious_education);
            this.panelApplicant.Controls.Add(this.labelPrevious_education);
            this.panelApplicant.Controls.Add(this.textBoxl_identity);
            this.panelApplicant.Controls.Add(this.labelName_identity);
            this.panelApplicant.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApplicant.Location = new System.Drawing.Point(3, 83);
            this.panelApplicant.Name = "panelApplicant";
            this.panelApplicant.Size = new System.Drawing.Size(786, 145);
            this.panelApplicant.TabIndex = 1;
            // 
            // buttonOpenPhoto_Applicant
            // 
            this.buttonOpenPhoto_Applicant.Location = new System.Drawing.Point(685, 119);
            this.buttonOpenPhoto_Applicant.Name = "buttonOpenPhoto_Applicant";
            this.buttonOpenPhoto_Applicant.Size = new System.Drawing.Size(98, 23);
            this.buttonOpenPhoto_Applicant.TabIndex = 10;
            this.buttonOpenPhoto_Applicant.Text = "Открыть фото";
            this.buttonOpenPhoto_Applicant.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto_Applicant.Click += new System.EventHandler(this.buttonOpenPhoto_Applicant_Click);
            // 
            // pictureBoxPhoto_Applicant
            // 
            this.pictureBoxPhoto_Applicant.Location = new System.Drawing.Point(536, 29);
            this.pictureBoxPhoto_Applicant.Name = "pictureBoxPhoto_Applicant";
            this.pictureBoxPhoto_Applicant.Size = new System.Drawing.Size(133, 104);
            this.pictureBoxPhoto_Applicant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto_Applicant.TabIndex = 9;
            this.pictureBoxPhoto_Applicant.TabStop = false;
            // 
            // labelPhoto_Applicant
            // 
            this.labelPhoto_Applicant.AutoSize = true;
            this.labelPhoto_Applicant.Location = new System.Drawing.Point(533, 13);
            this.labelPhoto_Applicant.Name = "labelPhoto_Applicant";
            this.labelPhoto_Applicant.Size = new System.Drawing.Size(101, 13);
            this.labelPhoto_Applicant.TabIndex = 8;
            this.labelPhoto_Applicant.Text = "Фото абитуриента";
            // 
            // textBoxAdmission
            // 
            this.textBoxAdmission.Location = new System.Drawing.Point(155, 90);
            this.textBoxAdmission.Name = "textBoxAdmission";
            this.textBoxAdmission.Size = new System.Drawing.Size(348, 20);
            this.textBoxAdmission.TabIndex = 7;
            // 
            // textBoxPersonal_dp
            // 
            this.textBoxPersonal_dp.Location = new System.Drawing.Point(368, 64);
            this.textBoxPersonal_dp.Name = "textBoxPersonal_dp";
            this.textBoxPersonal_dp.Size = new System.Drawing.Size(135, 20);
            this.textBoxPersonal_dp.TabIndex = 6;
            // 
            // labelAdmission
            // 
            this.labelAdmission.AutoSize = true;
            this.labelAdmission.Location = new System.Drawing.Point(5, 93);
            this.labelAdmission.Name = "labelAdmission";
            this.labelAdmission.Size = new System.Drawing.Size(144, 13);
            this.labelAdmission.TabIndex = 5;
            this.labelAdmission.Text = "Заявление на поступление";
            // 
            // labelPersonal_dp
            // 
            this.labelPersonal_dp.AutoSize = true;
            this.labelPersonal_dp.Location = new System.Drawing.Point(5, 67);
            this.labelPersonal_dp.Name = "labelPersonal_dp";
            this.labelPersonal_dp.Size = new System.Drawing.Size(357, 13);
            this.labelPersonal_dp.TabIndex = 4;
            this.labelPersonal_dp.Text = "Заявление на прием и согласие на обработку персональных данных";
            // 
            // textBoxPrevious_education
            // 
            this.textBoxPrevious_education.Location = new System.Drawing.Point(216, 36);
            this.textBoxPrevious_education.Name = "textBoxPrevious_education";
            this.textBoxPrevious_education.Size = new System.Drawing.Size(287, 20);
            this.textBoxPrevious_education.TabIndex = 3;
            // 
            // labelPrevious_education
            // 
            this.labelPrevious_education.AutoSize = true;
            this.labelPrevious_education.Location = new System.Drawing.Point(5, 39);
            this.labelPrevious_education.Name = "labelPrevious_education";
            this.labelPrevious_education.Size = new System.Drawing.Size(205, 13);
            this.labelPrevious_education.TabIndex = 2;
            this.labelPrevious_education.Text = "Документ о предыдущем образовании";
            // 
            // textBoxl_identity
            // 
            this.textBoxl_identity.Location = new System.Drawing.Point(202, 10);
            this.textBoxl_identity.Name = "textBoxl_identity";
            this.textBoxl_identity.Size = new System.Drawing.Size(301, 20);
            this.textBoxl_identity.TabIndex = 1;
            // 
            // labelName_identity
            // 
            this.labelName_identity.AutoSize = true;
            this.labelName_identity.Location = new System.Drawing.Point(2, 13);
            this.labelName_identity.Name = "labelName_identity";
            this.labelName_identity.Size = new System.Drawing.Size(197, 13);
            this.labelName_identity.TabIndex = 0;
            this.labelName_identity.Text = "Документ удостоверяющий личность";
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.textBoxId_applicant);
            this.groupBoxDML.Controls.Add(this.labelId_applicant);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_applicant);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_applicant);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_applicant);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(786, 80);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(207, 43);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(171, 23);
            this.buttonExecuteDML.TabIndex = 5;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // textBoxId_applicant
            // 
            this.textBoxId_applicant.Location = new System.Drawing.Point(89, 45);
            this.textBoxId_applicant.Name = "textBoxId_applicant";
            this.textBoxId_applicant.Size = new System.Drawing.Size(100, 20);
            this.textBoxId_applicant.TabIndex = 4;
            // 
            // labelId_applicant
            // 
            this.labelId_applicant.AutoSize = true;
            this.labelId_applicant.Location = new System.Drawing.Point(2, 48);
            this.labelId_applicant.Name = "labelId_applicant";
            this.labelId_applicant.Size = new System.Drawing.Size(81, 13);
            this.labelId_applicant.TabIndex = 3;
            this.labelId_applicant.Text = "id абитуриента";
            // 
            // radioButtonDelete_applicant
            // 
            this.radioButtonDelete_applicant.AutoSize = true;
            this.radioButtonDelete_applicant.Location = new System.Drawing.Point(488, 19);
            this.radioButtonDelete_applicant.Name = "radioButtonDelete_applicant";
            this.radioButtonDelete_applicant.Size = new System.Drawing.Size(264, 17);
            this.radioButtonDelete_applicant.TabIndex = 2;
            this.radioButtonDelete_applicant.TabStop = true;
            this.radioButtonDelete_applicant.Text = "Удалить данные по абитуриенту с заданным id";
            this.radioButtonDelete_applicant.UseVisualStyleBackColor = true;
            this.radioButtonDelete_applicant.CheckedChanged += new System.EventHandler(this.radioButtonDelete_applicant_CheckedChanged);
            // 
            // radioButtonUpdate_applicant
            // 
            this.radioButtonUpdate_applicant.AutoSize = true;
            this.radioButtonUpdate_applicant.Location = new System.Drawing.Point(207, 19);
            this.radioButtonUpdate_applicant.Name = "radioButtonUpdate_applicant";
            this.radioButtonUpdate_applicant.Size = new System.Drawing.Size(275, 17);
            this.radioButtonUpdate_applicant.TabIndex = 1;
            this.radioButtonUpdate_applicant.TabStop = true;
            this.radioButtonUpdate_applicant.Text = " Изменить данные по абитуриенту с заданным id";
            this.radioButtonUpdate_applicant.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert_applicant
            // 
            this.radioButtonInsert_applicant.AutoSize = true;
            this.radioButtonInsert_applicant.Location = new System.Drawing.Point(5, 19);
            this.radioButtonInsert_applicant.Name = "radioButtonInsert_applicant";
            this.radioButtonInsert_applicant.Size = new System.Drawing.Size(196, 17);
            this.radioButtonInsert_applicant.TabIndex = 0;
            this.radioButtonInsert_applicant.TabStop = true;
            this.radioButtonInsert_applicant.Text = "Добавить данные по абитуриенту";
            this.radioButtonInsert_applicant.UseVisualStyleBackColor = true;
            // 
            // labelScores
            // 
            this.labelScores.AutoSize = true;
            this.labelScores.Location = new System.Drawing.Point(8, 116);
            this.labelScores.Name = "labelScores";
            this.labelScores.Size = new System.Drawing.Size(170, 13);
            this.labelScores.TabIndex = 11;
            this.labelScores.Text = "Информация о результатах ЕГЭ";
            // 
            // textBoxScores
            // 
            this.textBoxScores.Location = new System.Drawing.Point(184, 113);
            this.textBoxScores.Name = "textBoxScores";
            this.textBoxScores.Size = new System.Drawing.Size(319, 20);
            this.textBoxScores.TabIndex = 12;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicants)).EndInit();
            this.panelApplicant.ResumeLayout(false);
            this.panelApplicant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_Applicant)).EndInit();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
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
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxPersonalFileID;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.RadioButton radioButtonInsert_applicant;
        private System.Windows.Forms.RadioButton radioButtonDelete_applicant;
        private System.Windows.Forms.RadioButton radioButtonUpdate_applicant;
        private System.Windows.Forms.Panel panelApplicant;
        private System.Windows.Forms.TextBox textBoxId_applicant;
        private System.Windows.Forms.Label labelId_applicant;
        private System.Windows.Forms.Button buttonOpenPhoto_Applicant;
        private System.Windows.Forms.PictureBox pictureBoxPhoto_Applicant;
        private System.Windows.Forms.Label labelPhoto_Applicant;
        private System.Windows.Forms.TextBox textBoxAdmission;
        private System.Windows.Forms.TextBox textBoxPersonal_dp;
        private System.Windows.Forms.Label labelAdmission;
        private System.Windows.Forms.Label labelPersonal_dp;
        private System.Windows.Forms.TextBox textBoxPrevious_education;
        private System.Windows.Forms.Label labelPrevious_education;
        private System.Windows.Forms.TextBox textBoxl_identity;
        private System.Windows.Forms.Label labelName_identity;
        private System.Windows.Forms.OpenFileDialog openFileDialogApplicant;
        private System.Windows.Forms.Button buttonSelectApplicants;
        private System.Windows.Forms.DataGridView dataGridViewApplicants;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.TextBox textBoxScores;
        private System.Windows.Forms.Label labelScores;
    }
}