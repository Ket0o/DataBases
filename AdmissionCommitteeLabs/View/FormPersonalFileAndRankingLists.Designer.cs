namespace AdmissionCommitteeLabs.View
{
    partial class FormPersonalFileAndRankingLists
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ranking_list_IDLabel;
            System.Windows.Forms.Label personal_file_IDLabel;
            System.Windows.Forms.Label scores_with_all_achievements_consideredLabel;
            System.Windows.Forms.Label rank_positionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonalFileAndRankingLists));
            this.selection_committeeDataSet = new AdmissionCommitteeLabs.Selection_committeeDataSet();
            this.personalFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalFileTableAdapter = new AdmissionCommitteeLabs.Selection_committeeDataSetTableAdapters.PersonalFileTableAdapter();
            this.tableAdapterManager = new AdmissionCommitteeLabs.Selection_committeeDataSetTableAdapters.TableAdapterManager();
            this.applicantsRankingListsTableAdapter = new AdmissionCommitteeLabs.Selection_committeeDataSetTableAdapters.ApplicantsRankingListsTableAdapter();
            this.personalFileBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.personalFileBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personalFileDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantsRankingListsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.applicantsRankingListsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.applicantsRankingListsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ranking_list_IDTextBox = new System.Windows.Forms.TextBox();
            this.personal_file_IDTextBox = new System.Windows.Forms.TextBox();
            this.scores_with_all_achievements_consideredTextBox = new System.Windows.Forms.TextBox();
            this.rank_positionTextBox = new System.Windows.Forms.TextBox();
            ranking_list_IDLabel = new System.Windows.Forms.Label();
            personal_file_IDLabel = new System.Windows.Forms.Label();
            scores_with_all_achievements_consideredLabel = new System.Windows.Forms.Label();
            rank_positionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selection_committeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFileBindingNavigator)).BeginInit();
            this.personalFileBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalFileDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsRankingListsBindingNavigator)).BeginInit();
            this.applicantsRankingListsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsRankingListsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ranking_list_IDLabel
            // 
            ranking_list_IDLabel.AutoSize = true;
            ranking_list_IDLabel.Location = new System.Drawing.Point(12, 263);
            ranking_list_IDLabel.Name = "ranking_list_IDLabel";
            ranking_list_IDLabel.Size = new System.Drawing.Size(74, 13);
            ranking_list_IDLabel.TabIndex = 3;
            ranking_list_IDLabel.Text = "ranking list ID:";
            // 
            // personal_file_IDLabel
            // 
            personal_file_IDLabel.AutoSize = true;
            personal_file_IDLabel.Location = new System.Drawing.Point(12, 289);
            personal_file_IDLabel.Name = "personal_file_IDLabel";
            personal_file_IDLabel.Size = new System.Drawing.Size(80, 13);
            personal_file_IDLabel.TabIndex = 5;
            personal_file_IDLabel.Text = "personal file ID:";
            // 
            // scores_with_all_achievements_consideredLabel
            // 
            scores_with_all_achievements_consideredLabel.AutoSize = true;
            scores_with_all_achievements_consideredLabel.Location = new System.Drawing.Point(12, 315);
            scores_with_all_achievements_consideredLabel.Name = "scores_with_all_achievements_consideredLabel";
            scores_with_all_achievements_consideredLabel.Size = new System.Drawing.Size(200, 13);
            scores_with_all_achievements_consideredLabel.TabIndex = 7;
            scores_with_all_achievements_consideredLabel.Text = "scores with all achievements considered:";
            // 
            // rank_positionLabel
            // 
            rank_positionLabel.AutoSize = true;
            rank_positionLabel.Location = new System.Drawing.Point(12, 341);
            rank_positionLabel.Name = "rank_positionLabel";
            rank_positionLabel.Size = new System.Drawing.Size(70, 13);
            rank_positionLabel.TabIndex = 9;
            rank_positionLabel.Text = "rank position:";
            // 
            // selection_committeeDataSet
            // 
            this.selection_committeeDataSet.DataSetName = "Selection_committeeDataSet";
            this.selection_committeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalFileBindingSource
            // 
            this.personalFileBindingSource.DataMember = "PersonalFile";
            this.personalFileBindingSource.DataSource = this.selection_committeeDataSet;
            // 
            // personalFileTableAdapter
            // 
            this.personalFileTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicantsDataTableAdapter = null;
            this.tableAdapterManager.ApplicantsRankingListsTableAdapter = this.applicantsRankingListsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EnrollmentOrdersTableAdapter = null;
            this.tableAdapterManager.PersonalFileTableAdapter = this.personalFileTableAdapter;
            this.tableAdapterManager.UpdateOrder = AdmissionCommitteeLabs.Selection_committeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // applicantsRankingListsTableAdapter
            // 
            this.applicantsRankingListsTableAdapter.ClearBeforeFill = true;
            // 
            // personalFileBindingNavigator
            // 
            this.personalFileBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personalFileBindingNavigator.BindingSource = this.personalFileBindingSource;
            this.personalFileBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personalFileBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personalFileBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personalFileBindingNavigatorSaveItem});
            this.personalFileBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personalFileBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personalFileBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personalFileBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personalFileBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personalFileBindingNavigator.Name = "personalFileBindingNavigator";
            this.personalFileBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personalFileBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.personalFileBindingNavigator.TabIndex = 0;
            this.personalFileBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // personalFileBindingNavigatorSaveItem
            // 
            this.personalFileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personalFileBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personalFileBindingNavigatorSaveItem.Image")));
            this.personalFileBindingNavigatorSaveItem.Name = "personalFileBindingNavigatorSaveItem";
            this.personalFileBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personalFileBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.personalFileBindingNavigatorSaveItem.Click += new System.EventHandler(this.personalFileBindingNavigatorSaveItem_Click);
            // 
            // personalFileDataGridView
            // 
            this.personalFileDataGridView.AutoGenerateColumns = false;
            this.personalFileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personalFileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalFileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.personalFileDataGridView.DataSource = this.personalFileBindingSource;
            this.personalFileDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.personalFileDataGridView.Location = new System.Drawing.Point(0, 25);
            this.personalFileDataGridView.Name = "personalFileDataGridView";
            this.personalFileDataGridView.Size = new System.Drawing.Size(800, 203);
            this.personalFileDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "personal_file_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "personal_file_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "applicant_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "applicant_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Document_submission_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Document_submission_date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // applicantsRankingListsBindingNavigator
            // 
            this.applicantsRankingListsBindingNavigator.AddNewItem = this.toolStripButton1;
            this.applicantsRankingListsBindingNavigator.BindingSource = this.applicantsRankingListsBindingSource;
            this.applicantsRankingListsBindingNavigator.CountItem = this.toolStripLabel1;
            this.applicantsRankingListsBindingNavigator.DeleteItem = this.toolStripButton2;
            this.applicantsRankingListsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.applicantsRankingListsBindingNavigatorSaveItem});
            this.applicantsRankingListsBindingNavigator.Location = new System.Drawing.Point(0, 228);
            this.applicantsRankingListsBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.applicantsRankingListsBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.applicantsRankingListsBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.applicantsRankingListsBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.applicantsRankingListsBindingNavigator.Name = "applicantsRankingListsBindingNavigator";
            this.applicantsRankingListsBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.applicantsRankingListsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.applicantsRankingListsBindingNavigator.TabIndex = 2;
            this.applicantsRankingListsBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";
            // 
            // applicantsRankingListsBindingSource
            // 
            this.applicantsRankingListsBindingSource.DataMember = "FK_ApplicantsRankingLists_PersonalFile";
            this.applicantsRankingListsBindingSource.DataSource = this.personalFileBindingSource;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // applicantsRankingListsBindingNavigatorSaveItem
            // 
            this.applicantsRankingListsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.applicantsRankingListsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("applicantsRankingListsBindingNavigatorSaveItem.Image")));
            this.applicantsRankingListsBindingNavigatorSaveItem.Name = "applicantsRankingListsBindingNavigatorSaveItem";
            this.applicantsRankingListsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.applicantsRankingListsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.applicantsRankingListsBindingNavigatorSaveItem.Click += new System.EventHandler(this.applicantsRankingListsBindingNavigatorSaveItem_Click);
            // 
            // ranking_list_IDTextBox
            // 
            this.ranking_list_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsRankingListsBindingSource, "ranking_list_ID", true));
            this.ranking_list_IDTextBox.Location = new System.Drawing.Point(218, 260);
            this.ranking_list_IDTextBox.Name = "ranking_list_IDTextBox";
            this.ranking_list_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ranking_list_IDTextBox.TabIndex = 4;
            // 
            // personal_file_IDTextBox
            // 
            this.personal_file_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsRankingListsBindingSource, "personal_file_ID", true));
            this.personal_file_IDTextBox.Location = new System.Drawing.Point(218, 286);
            this.personal_file_IDTextBox.Name = "personal_file_IDTextBox";
            this.personal_file_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.personal_file_IDTextBox.TabIndex = 6;
            // 
            // scores_with_all_achievements_consideredTextBox
            // 
            this.scores_with_all_achievements_consideredTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsRankingListsBindingSource, "scores_with_all_achievements_considered", true));
            this.scores_with_all_achievements_consideredTextBox.Location = new System.Drawing.Point(218, 312);
            this.scores_with_all_achievements_consideredTextBox.Name = "scores_with_all_achievements_consideredTextBox";
            this.scores_with_all_achievements_consideredTextBox.Size = new System.Drawing.Size(100, 20);
            this.scores_with_all_achievements_consideredTextBox.TabIndex = 8;
            // 
            // rank_positionTextBox
            // 
            this.rank_positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsRankingListsBindingSource, "rank_position", true));
            this.rank_positionTextBox.Location = new System.Drawing.Point(218, 338);
            this.rank_positionTextBox.Name = "rank_positionTextBox";
            this.rank_positionTextBox.Size = new System.Drawing.Size(100, 20);
            this.rank_positionTextBox.TabIndex = 10;
            // 
            // FormPersonalFileAndRankingLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(ranking_list_IDLabel);
            this.Controls.Add(this.ranking_list_IDTextBox);
            this.Controls.Add(personal_file_IDLabel);
            this.Controls.Add(this.personal_file_IDTextBox);
            this.Controls.Add(scores_with_all_achievements_consideredLabel);
            this.Controls.Add(this.scores_with_all_achievements_consideredTextBox);
            this.Controls.Add(rank_positionLabel);
            this.Controls.Add(this.rank_positionTextBox);
            this.Controls.Add(this.applicantsRankingListsBindingNavigator);
            this.Controls.Add(this.personalFileDataGridView);
            this.Controls.Add(this.personalFileBindingNavigator);
            this.Name = "FormPersonalFileAndRankingLists";
            this.Text = "FormPersonalFileAndRankingLists";
            this.Load += new System.EventHandler(this.FormPersonalFileAndRankingLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selection_committeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFileBindingNavigator)).EndInit();
            this.personalFileBindingNavigator.ResumeLayout(false);
            this.personalFileBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalFileDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsRankingListsBindingNavigator)).EndInit();
            this.applicantsRankingListsBindingNavigator.ResumeLayout(false);
            this.applicantsRankingListsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsRankingListsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Selection_committeeDataSet selection_committeeDataSet;
        private System.Windows.Forms.BindingSource personalFileBindingSource;
        private Selection_committeeDataSetTableAdapters.PersonalFileTableAdapter personalFileTableAdapter;
        private Selection_committeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personalFileBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personalFileBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView personalFileDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingNavigator applicantsRankingListsBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton applicantsRankingListsBindingNavigatorSaveItem;
        private Selection_committeeDataSetTableAdapters.ApplicantsRankingListsTableAdapter applicantsRankingListsTableAdapter;
        private System.Windows.Forms.BindingSource applicantsRankingListsBindingSource;
        private System.Windows.Forms.TextBox ranking_list_IDTextBox;
        private System.Windows.Forms.TextBox personal_file_IDTextBox;
        private System.Windows.Forms.TextBox scores_with_all_achievements_consideredTextBox;
        private System.Windows.Forms.TextBox rank_positionTextBox;
    }
}