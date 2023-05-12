namespace AdmissionCommitteeLabs.View
{
    partial class FormApplicantsRankingLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApplicantsRankingLists));
            System.Windows.Forms.Label ranking_list_IDLabel;
            System.Windows.Forms.Label personal_file_IDLabel;
            System.Windows.Forms.Label scores_with_all_achievements_consideredLabel;
            System.Windows.Forms.Label rank_positionLabel;
            System.Windows.Forms.Label document_submission_dateLabel;
            this.selection_committeeDataSet = new AdmissionCommitteeLabs.Selection_committeeDataSet();
            this.applicantsRankingListsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicantsRankingListsTableAdapter = new AdmissionCommitteeLabs.Selection_committeeDataSetTableAdapters.ApplicantsRankingListsTableAdapter();
            this.tableAdapterManager = new AdmissionCommitteeLabs.Selection_committeeDataSetTableAdapters.TableAdapterManager();
            this.applicantsRankingListsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.applicantsRankingListsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.enrollmentOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentOrdersTableAdapter = new AdmissionCommitteeLabs.Selection_committeeDataSetTableAdapters.EnrollmentOrdersTableAdapter();
            this.ranking_list_IDTextBox = new System.Windows.Forms.TextBox();
            this.personal_file_IDTextBox = new System.Windows.Forms.TextBox();
            this.scores_with_all_achievements_consideredTextBox = new System.Windows.Forms.TextBox();
            this.rank_positionTextBox = new System.Windows.Forms.TextBox();
            this.document_submission_dateTextBox = new System.Windows.Forms.TextBox();
            ranking_list_IDLabel = new System.Windows.Forms.Label();
            personal_file_IDLabel = new System.Windows.Forms.Label();
            scores_with_all_achievements_consideredLabel = new System.Windows.Forms.Label();
            rank_positionLabel = new System.Windows.Forms.Label();
            document_submission_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selection_committeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsRankingListsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsRankingListsBindingNavigator)).BeginInit();
            this.applicantsRankingListsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selection_committeeDataSet
            // 
            this.selection_committeeDataSet.DataSetName = "Selection_committeeDataSet";
            this.selection_committeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantsRankingListsBindingSource
            // 
            this.applicantsRankingListsBindingSource.DataMember = "ApplicantsRankingLists";
            this.applicantsRankingListsBindingSource.DataSource = this.selection_committeeDataSet;
            // 
            // applicantsRankingListsTableAdapter
            // 
            this.applicantsRankingListsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicantsDataTableAdapter = null;
            this.tableAdapterManager.ApplicantsRankingListsTableAdapter = this.applicantsRankingListsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EnrollmentOrdersTableAdapter = null;
            this.tableAdapterManager.PersonalFileTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AdmissionCommitteeLabs.Selection_committeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // applicantsRankingListsBindingNavigator
            // 
            this.applicantsRankingListsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.applicantsRankingListsBindingNavigator.BindingSource = this.applicantsRankingListsBindingSource;
            this.applicantsRankingListsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.applicantsRankingListsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.applicantsRankingListsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.applicantsRankingListsBindingNavigatorSaveItem});
            this.applicantsRankingListsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.applicantsRankingListsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.applicantsRankingListsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.applicantsRankingListsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.applicantsRankingListsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.applicantsRankingListsBindingNavigator.Name = "applicantsRankingListsBindingNavigator";
            this.applicantsRankingListsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.applicantsRankingListsBindingNavigator.Size = new System.Drawing.Size(384, 25);
            this.applicantsRankingListsBindingNavigator.TabIndex = 0;
            this.applicantsRankingListsBindingNavigator.Text = "bindingNavigator1";
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
            // applicantsRankingListsBindingNavigatorSaveItem
            // 
            this.applicantsRankingListsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.applicantsRankingListsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("applicantsRankingListsBindingNavigatorSaveItem.Image")));
            this.applicantsRankingListsBindingNavigatorSaveItem.Name = "applicantsRankingListsBindingNavigatorSaveItem";
            this.applicantsRankingListsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.applicantsRankingListsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.applicantsRankingListsBindingNavigatorSaveItem.Click += new System.EventHandler(this.applicantsRankingListsBindingNavigatorSaveItem_Click_1);
            // 
            // enrollmentOrdersBindingSource
            // 
            this.enrollmentOrdersBindingSource.DataMember = "EnrollmentOrders";
            this.enrollmentOrdersBindingSource.DataSource = this.selection_committeeDataSet;
            // 
            // enrollmentOrdersTableAdapter
            // 
            this.enrollmentOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // ranking_list_IDLabel
            // 
            ranking_list_IDLabel.AutoSize = true;
            ranking_list_IDLabel.Location = new System.Drawing.Point(12, 34);
            ranking_list_IDLabel.Name = "ranking_list_IDLabel";
            ranking_list_IDLabel.Size = new System.Drawing.Size(74, 13);
            ranking_list_IDLabel.TabIndex = 1;
            ranking_list_IDLabel.Text = "ranking list ID:";
            // 
            // ranking_list_IDTextBox
            // 
            this.ranking_list_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsRankingListsBindingSource, "ranking_list_ID", true));
            this.ranking_list_IDTextBox.Location = new System.Drawing.Point(218, 31);
            this.ranking_list_IDTextBox.Name = "ranking_list_IDTextBox";
            this.ranking_list_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ranking_list_IDTextBox.TabIndex = 2;
            // 
            // personal_file_IDLabel
            // 
            personal_file_IDLabel.AutoSize = true;
            personal_file_IDLabel.Location = new System.Drawing.Point(12, 60);
            personal_file_IDLabel.Name = "personal_file_IDLabel";
            personal_file_IDLabel.Size = new System.Drawing.Size(80, 13);
            personal_file_IDLabel.TabIndex = 3;
            personal_file_IDLabel.Text = "personal file ID:";
            // 
            // personal_file_IDTextBox
            // 
            this.personal_file_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsRankingListsBindingSource, "personal_file_ID", true));
            this.personal_file_IDTextBox.Location = new System.Drawing.Point(218, 57);
            this.personal_file_IDTextBox.Name = "personal_file_IDTextBox";
            this.personal_file_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.personal_file_IDTextBox.TabIndex = 4;
            // 
            // scores_with_all_achievements_consideredLabel
            // 
            scores_with_all_achievements_consideredLabel.AutoSize = true;
            scores_with_all_achievements_consideredLabel.Location = new System.Drawing.Point(12, 86);
            scores_with_all_achievements_consideredLabel.Name = "scores_with_all_achievements_consideredLabel";
            scores_with_all_achievements_consideredLabel.Size = new System.Drawing.Size(200, 13);
            scores_with_all_achievements_consideredLabel.TabIndex = 5;
            scores_with_all_achievements_consideredLabel.Text = "scores with all achievements considered:";
            // 
            // scores_with_all_achievements_consideredTextBox
            // 
            this.scores_with_all_achievements_consideredTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsRankingListsBindingSource, "scores_with_all_achievements_considered", true));
            this.scores_with_all_achievements_consideredTextBox.Location = new System.Drawing.Point(218, 83);
            this.scores_with_all_achievements_consideredTextBox.Name = "scores_with_all_achievements_consideredTextBox";
            this.scores_with_all_achievements_consideredTextBox.Size = new System.Drawing.Size(100, 20);
            this.scores_with_all_achievements_consideredTextBox.TabIndex = 6;
            // 
            // rank_positionLabel
            // 
            rank_positionLabel.AutoSize = true;
            rank_positionLabel.Location = new System.Drawing.Point(12, 112);
            rank_positionLabel.Name = "rank_positionLabel";
            rank_positionLabel.Size = new System.Drawing.Size(70, 13);
            rank_positionLabel.TabIndex = 7;
            rank_positionLabel.Text = "rank position:";
            // 
            // rank_positionTextBox
            // 
            this.rank_positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsRankingListsBindingSource, "rank_position", true));
            this.rank_positionTextBox.Location = new System.Drawing.Point(218, 109);
            this.rank_positionTextBox.Name = "rank_positionTextBox";
            this.rank_positionTextBox.Size = new System.Drawing.Size(100, 20);
            this.rank_positionTextBox.TabIndex = 8;
            // 
            // document_submission_dateLabel
            // 
            document_submission_dateLabel.AutoSize = true;
            document_submission_dateLabel.Location = new System.Drawing.Point(12, 138);
            document_submission_dateLabel.Name = "document_submission_dateLabel";
            document_submission_dateLabel.Size = new System.Drawing.Size(137, 13);
            document_submission_dateLabel.TabIndex = 9;
            document_submission_dateLabel.Text = "Document submission date:";
            // 
            // document_submission_dateTextBox
            // 
            this.document_submission_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsRankingListsBindingSource, "Document_submission_date", true));
            this.document_submission_dateTextBox.Location = new System.Drawing.Point(218, 135);
            this.document_submission_dateTextBox.Name = "document_submission_dateTextBox";
            this.document_submission_dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.document_submission_dateTextBox.TabIndex = 10;
            // 
            // FormApplicantsRankingLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 165);
            this.Controls.Add(ranking_list_IDLabel);
            this.Controls.Add(this.ranking_list_IDTextBox);
            this.Controls.Add(personal_file_IDLabel);
            this.Controls.Add(this.personal_file_IDTextBox);
            this.Controls.Add(scores_with_all_achievements_consideredLabel);
            this.Controls.Add(this.scores_with_all_achievements_consideredTextBox);
            this.Controls.Add(rank_positionLabel);
            this.Controls.Add(this.rank_positionTextBox);
            this.Controls.Add(document_submission_dateLabel);
            this.Controls.Add(this.document_submission_dateTextBox);
            this.Controls.Add(this.applicantsRankingListsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(348, 171);
            this.Name = "FormApplicantsRankingLists";
            this.Text = "FormApplicantsRankingLists";
            this.Load += new System.EventHandler(this.FormApplicantsRankingLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selection_committeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsRankingListsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsRankingListsBindingNavigator)).EndInit();
            this.applicantsRankingListsBindingNavigator.ResumeLayout(false);
            this.applicantsRankingListsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Selection_committeeDataSet selection_committeeDataSet;
        private System.Windows.Forms.BindingSource applicantsRankingListsBindingSource;
        private Selection_committeeDataSetTableAdapters.ApplicantsRankingListsTableAdapter applicantsRankingListsTableAdapter;
        private Selection_committeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator applicantsRankingListsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton applicantsRankingListsBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource enrollmentOrdersBindingSource;
        private Selection_committeeDataSetTableAdapters.EnrollmentOrdersTableAdapter enrollmentOrdersTableAdapter;
        private System.Windows.Forms.TextBox ranking_list_IDTextBox;
        private System.Windows.Forms.TextBox personal_file_IDTextBox;
        private System.Windows.Forms.TextBox scores_with_all_achievements_consideredTextBox;
        private System.Windows.Forms.TextBox rank_positionTextBox;
        private System.Windows.Forms.TextBox document_submission_dateTextBox;
    }
}