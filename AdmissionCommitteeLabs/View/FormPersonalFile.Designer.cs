namespace AdmissionCommitteeLabs.View
{
    partial class FormPersonalFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonalFile));
            this.admissionCommitteeDataSet = new AdmissionCommitteeLabs.AdmissionCommitteeDataSet();
            this.personalFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalFileTableAdapter = new AdmissionCommitteeLabs.AdmissionCommitteeDataSetTableAdapters.PersonalFileTableAdapter();
            this.tableAdapterManager = new AdmissionCommitteeLabs.AdmissionCommitteeDataSetTableAdapters.TableAdapterManager();
            this.personalFileBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.personalFileDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantsRankingListsTableAdapter = new AdmissionCommitteeLabs.AdmissionCommitteeDataSetTableAdapters.ApplicantsRankingListsTableAdapter();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.personalFileBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.applicantsRankingListsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.personalFiletoolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.checkBoxFind = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.admissionCommitteeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFileBindingNavigator)).BeginInit();
            this.personalFileBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalFileDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsRankingListsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selection_committeeDataSet
            // 
            this.admissionCommitteeDataSet.DataSetName = "AdmissionCommitteeDataSet";
            this.admissionCommitteeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalFileBindingSource
            // 
            this.personalFileBindingSource.DataMember = "PersonalFile";
            this.personalFileBindingSource.DataSource = this.admissionCommitteeDataSet;
            // 
            // personalFileTableAdapter
            // 
            this.personalFileTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicantsDataTableAdapter = null;
            this.tableAdapterManager.ApplicantsRankingListsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EnrollmentOrdersTableAdapter = null;
            this.tableAdapterManager.PersonalFileTableAdapter = this.personalFileTableAdapter;
            this.tableAdapterManager.UpdateOrder = AdmissionCommitteeLabs.AdmissionCommitteeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.personalFileBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.personalFiletoolStripTextBoxFind,
            this.toolStripButtonFind});
            this.personalFileBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personalFileBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personalFileBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personalFileBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personalFileBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personalFileBindingNavigator.Name = "personalFileBindingNavigator";
            this.personalFileBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personalFileBindingNavigator.Size = new System.Drawing.Size(604, 25);
            this.personalFileBindingNavigator.TabIndex = 0;
            this.personalFileBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.personalFileDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalFileDataGridView.Location = new System.Drawing.Point(0, 25);
            this.personalFileDataGridView.Name = "personalFileDataGridView";
            this.personalFileDataGridView.Size = new System.Drawing.Size(604, 304);
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
            // applicantsRankingListsTableAdapter
            // 
            this.applicantsRankingListsTableAdapter.ClearBeforeFill = true;
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
            // personalFileBindingNavigatorSaveItem
            // 
            this.personalFileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personalFileBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personalFileBindingNavigatorSaveItem.Image")));
            this.personalFileBindingNavigatorSaveItem.Name = "personalFileBindingNavigatorSaveItem";
            this.personalFileBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personalFileBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.personalFileBindingNavigatorSaveItem.Click += new System.EventHandler(this.personalFileBindingNavigatorSaveItem_Click_1);
            // 
            // applicantsRankingListsBindingSource
            // 
            this.applicantsRankingListsBindingSource.DataMember = "FK_ApplicantsRankingLists_PersonalFile";
            this.applicantsRankingListsBindingSource.DataSource = this.personalFileBindingSource;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // personalFiletoolStripTextBoxFind
            // 
            this.personalFiletoolStripTextBoxFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.personalFiletoolStripTextBoxFind.Name = "personalFiletoolStripTextBoxFind";
            this.personalFiletoolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.Image = global::AdmissionCommitteeLabs.Properties.Resources.search_16x16;
            this.toolStripButtonFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(62, 22);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // checkBoxFind
            // 
            this.checkBoxFind.Location = new System.Drawing.Point(455, 0);
            this.checkBoxFind.Name = "checkBoxFind";
            this.checkBoxFind.Size = new System.Drawing.Size(82, 25);
            this.checkBoxFind.TabIndex = 2;
            this.checkBoxFind.Text = "Фильтр";
            this.checkBoxFind.UseVisualStyleBackColor = true;
            this.checkBoxFind.CheckedChanged += new System.EventHandler(this.checkBoxFind_CheckedChanged);
            // 
            // FormPersonalFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 329);
            this.Controls.Add(this.checkBoxFind);
            this.Controls.Add(this.personalFileDataGridView);
            this.Controls.Add(this.personalFileBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(533, 341);
            this.Name = "FormPersonalFile";
            this.Text = "FormPersonalFile";
            this.Load += new System.EventHandler(this.FormPersonalFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admissionCommitteeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFileBindingNavigator)).EndInit();
            this.personalFileBindingNavigator.ResumeLayout(false);
            this.personalFileBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalFileDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsRankingListsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdmissionCommitteeDataSet admissionCommitteeDataSet;
        private System.Windows.Forms.BindingSource personalFileBindingSource;
        private AdmissionCommitteeDataSetTableAdapters.PersonalFileTableAdapter personalFileTableAdapter;
        private AdmissionCommitteeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.BindingSource applicantsRankingListsBindingSource;
        private AdmissionCommitteeDataSetTableAdapters.ApplicantsRankingListsTableAdapter applicantsRankingListsTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox personalFiletoolStripTextBoxFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.CheckBox checkBoxFind;
    }
}