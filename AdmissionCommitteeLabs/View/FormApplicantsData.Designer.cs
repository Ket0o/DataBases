namespace AdmissionCommitteeLabs.View
{
    partial class FormApplicantsData
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
            System.Windows.Forms.Label applicant_IDLabel;
            System.Windows.Forms.Label identity_and_citizenship_document_codeLabel;
            System.Windows.Forms.Label previous_education_document_codeLabel;
            System.Windows.Forms.Label admission_application_and_personal_data_processing_consent_codeLabel;
            System.Windows.Forms.Label enrollment_application_codeLabel;
            System.Windows.Forms.Label unified_State_Exam_scoresLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApplicantsData));
            this.admissionCommitteeDataSet = new AdmissionCommitteeLabs.AdmissionCommitteeDataSet();
            this.applicantsDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicantsDataTableAdapter = new AdmissionCommitteeLabs.AdmissionCommitteeDataSetTableAdapters.ApplicantsDataTableAdapter();
            this.tableAdapterManager = new AdmissionCommitteeLabs.AdmissionCommitteeDataSetTableAdapters.TableAdapterManager();
            this.applicantsDataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.applicantsDataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.applicant_IDTextBox = new System.Windows.Forms.TextBox();
            this.identity_and_citizenship_document_codeTextBox = new System.Windows.Forms.TextBox();
            this.previous_education_document_codeTextBox = new System.Windows.Forms.TextBox();
            this.admission_application_and_personal_data_processing_consent_codeTextBox = new System.Windows.Forms.TextBox();
            this.enrollment_application_codeTextBox = new System.Windows.Forms.TextBox();
            this.unified_State_Exam_scoresTextBox = new System.Windows.Forms.TextBox();
            applicant_IDLabel = new System.Windows.Forms.Label();
            identity_and_citizenship_document_codeLabel = new System.Windows.Forms.Label();
            previous_education_document_codeLabel = new System.Windows.Forms.Label();
            admission_application_and_personal_data_processing_consent_codeLabel = new System.Windows.Forms.Label();
            enrollment_application_codeLabel = new System.Windows.Forms.Label();
            unified_State_Exam_scoresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.admissionCommitteeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsDataBindingNavigator)).BeginInit();
            this.applicantsDataBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicant_IDLabel
            // 
            applicant_IDLabel.AutoSize = true;
            applicant_IDLabel.Location = new System.Drawing.Point(12, 25);
            applicant_IDLabel.Name = "applicant_IDLabel";
            applicant_IDLabel.Size = new System.Drawing.Size(67, 13);
            applicant_IDLabel.TabIndex = 1;
            applicant_IDLabel.Text = "applicant ID:";
            // 
            // identity_and_citizenship_document_codeLabel
            // 
            identity_and_citizenship_document_codeLabel.AutoSize = true;
            identity_and_citizenship_document_codeLabel.Location = new System.Drawing.Point(12, 51);
            identity_and_citizenship_document_codeLabel.Name = "identity_and_citizenship_document_codeLabel";
            identity_and_citizenship_document_codeLabel.Size = new System.Drawing.Size(194, 13);
            identity_and_citizenship_document_codeLabel.TabIndex = 3;
            identity_and_citizenship_document_codeLabel.Text = "Identity and citizenship document code:";
            // 
            // previous_education_document_codeLabel
            // 
            previous_education_document_codeLabel.AutoSize = true;
            previous_education_document_codeLabel.Location = new System.Drawing.Point(12, 77);
            previous_education_document_codeLabel.Name = "previous_education_document_codeLabel";
            previous_education_document_codeLabel.Size = new System.Drawing.Size(178, 13);
            previous_education_document_codeLabel.TabIndex = 5;
            previous_education_document_codeLabel.Text = "Previous education document code:";
            // 
            // admission_application_and_personal_data_processing_consent_codeLabel
            // 
            admission_application_and_personal_data_processing_consent_codeLabel.AutoSize = true;
            admission_application_and_personal_data_processing_consent_codeLabel.Location = new System.Drawing.Point(12, 103);
            admission_application_and_personal_data_processing_consent_codeLabel.Name = "admission_application_and_personal_data_processing_consent_codeLabel";
            admission_application_and_personal_data_processing_consent_codeLabel.Size = new System.Drawing.Size(321, 13);
            admission_application_and_personal_data_processing_consent_codeLabel.TabIndex = 7;
            admission_application_and_personal_data_processing_consent_codeLabel.Text = "Admission application and personal data processing consent code:";
            // 
            // enrollment_application_codeLabel
            // 
            enrollment_application_codeLabel.AutoSize = true;
            enrollment_application_codeLabel.Location = new System.Drawing.Point(12, 129);
            enrollment_application_codeLabel.Name = "enrollment_application_codeLabel";
            enrollment_application_codeLabel.Size = new System.Drawing.Size(140, 13);
            enrollment_application_codeLabel.TabIndex = 9;
            enrollment_application_codeLabel.Text = "Enrollment application code:";
            // 
            // unified_State_Exam_scoresLabel
            // 
            unified_State_Exam_scoresLabel.AutoSize = true;
            unified_State_Exam_scoresLabel.Location = new System.Drawing.Point(12, 155);
            unified_State_Exam_scoresLabel.Name = "unified_State_Exam_scoresLabel";
            unified_State_Exam_scoresLabel.Size = new System.Drawing.Size(134, 13);
            unified_State_Exam_scoresLabel.TabIndex = 11;
            unified_State_Exam_scoresLabel.Text = "Unified State Exam scores:";
            // 
            // admissionCommitteeDataSet
            // 
            this.admissionCommitteeDataSet.DataSetName = "Selection_committeeDataSet";
            this.admissionCommitteeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantsDataBindingSource
            // 
            this.applicantsDataBindingSource.DataMember = "ApplicantsData";
            this.applicantsDataBindingSource.DataSource = this.admissionCommitteeDataSet;
            // 
            // applicantsDataTableAdapter
            // 
            this.applicantsDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicantsDataTableAdapter = this.applicantsDataTableAdapter;
            this.tableAdapterManager.ApplicantsRankingListsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EnrollmentOrdersTableAdapter = null;
            this.tableAdapterManager.PersonalFileTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AdmissionCommitteeLabs.AdmissionCommitteeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // applicantsDataBindingNavigator
            // 
            this.applicantsDataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.applicantsDataBindingNavigator.BindingSource = this.applicantsDataBindingSource;
            this.applicantsDataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.applicantsDataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.applicantsDataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.applicantsDataBindingNavigatorSaveItem});
            this.applicantsDataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.applicantsDataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.applicantsDataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.applicantsDataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.applicantsDataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.applicantsDataBindingNavigator.Name = "applicantsDataBindingNavigator";
            this.applicantsDataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.applicantsDataBindingNavigator.Size = new System.Drawing.Size(452, 25);
            this.applicantsDataBindingNavigator.TabIndex = 0;
            this.applicantsDataBindingNavigator.Text = "bindingNavigator1";
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
            // applicantsDataBindingNavigatorSaveItem
            // 
            this.applicantsDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.applicantsDataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("applicantsDataBindingNavigatorSaveItem.Image")));
            this.applicantsDataBindingNavigatorSaveItem.Name = "applicantsDataBindingNavigatorSaveItem";
            this.applicantsDataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.applicantsDataBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.applicantsDataBindingNavigatorSaveItem.Click += new System.EventHandler(this.applicantsDataBindingNavigatorSaveItem_Click);
            // 
            // applicant_IDTextBox
            // 
            this.applicant_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsDataBindingSource, "applicant_ID", true));
            this.applicant_IDTextBox.Location = new System.Drawing.Point(339, 22);
            this.applicant_IDTextBox.Name = "applicant_IDTextBox";
            this.applicant_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.applicant_IDTextBox.TabIndex = 2;
            // 
            // identity_and_citizenship_document_codeTextBox
            // 
            this.identity_and_citizenship_document_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsDataBindingSource, "Identity_and_citizenship_document_code", true));
            this.identity_and_citizenship_document_codeTextBox.Location = new System.Drawing.Point(339, 48);
            this.identity_and_citizenship_document_codeTextBox.Name = "identity_and_citizenship_document_codeTextBox";
            this.identity_and_citizenship_document_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.identity_and_citizenship_document_codeTextBox.TabIndex = 4;
            // 
            // previous_education_document_codeTextBox
            // 
            this.previous_education_document_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsDataBindingSource, "Previous_education_document_code", true));
            this.previous_education_document_codeTextBox.Location = new System.Drawing.Point(339, 74);
            this.previous_education_document_codeTextBox.Name = "previous_education_document_codeTextBox";
            this.previous_education_document_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.previous_education_document_codeTextBox.TabIndex = 6;
            // 
            // admission_application_and_personal_data_processing_consent_codeTextBox
            // 
            this.admission_application_and_personal_data_processing_consent_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsDataBindingSource, "Admission_application_and_personal_data_processing_consent_code", true));
            this.admission_application_and_personal_data_processing_consent_codeTextBox.Location = new System.Drawing.Point(339, 100);
            this.admission_application_and_personal_data_processing_consent_codeTextBox.Name = "admission_application_and_personal_data_processing_consent_codeTextBox";
            this.admission_application_and_personal_data_processing_consent_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.admission_application_and_personal_data_processing_consent_codeTextBox.TabIndex = 8;
            // 
            // enrollment_application_codeTextBox
            // 
            this.enrollment_application_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsDataBindingSource, "Enrollment_application_code", true));
            this.enrollment_application_codeTextBox.Location = new System.Drawing.Point(339, 126);
            this.enrollment_application_codeTextBox.Name = "enrollment_application_codeTextBox";
            this.enrollment_application_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.enrollment_application_codeTextBox.TabIndex = 10;
            // 
            // unified_State_Exam_scoresTextBox
            // 
            this.unified_State_Exam_scoresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantsDataBindingSource, "Unifield_State_Exam_scores", true));
            this.unified_State_Exam_scoresTextBox.Location = new System.Drawing.Point(339, 152);
            this.unified_State_Exam_scoresTextBox.Name = "unified_State_Exam_scoresTextBox";
            this.unified_State_Exam_scoresTextBox.Size = new System.Drawing.Size(100, 20);
            this.unified_State_Exam_scoresTextBox.TabIndex = 12;
            // 
            // FormApplicantsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 182);
            this.Controls.Add(applicant_IDLabel);
            this.Controls.Add(this.applicant_IDTextBox);
            this.Controls.Add(identity_and_citizenship_document_codeLabel);
            this.Controls.Add(this.identity_and_citizenship_document_codeTextBox);
            this.Controls.Add(previous_education_document_codeLabel);
            this.Controls.Add(this.previous_education_document_codeTextBox);
            this.Controls.Add(admission_application_and_personal_data_processing_consent_codeLabel);
            this.Controls.Add(this.admission_application_and_personal_data_processing_consent_codeTextBox);
            this.Controls.Add(enrollment_application_codeLabel);
            this.Controls.Add(this.enrollment_application_codeTextBox);
            this.Controls.Add(unified_State_Exam_scoresLabel);
            this.Controls.Add(this.unified_State_Exam_scoresTextBox);
            this.Controls.Add(this.applicantsDataBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(468, 221);
            this.MinimumSize = new System.Drawing.Size(468, 221);
            this.Name = "FormApplicantsData";
            this.Text = "Applicant Data";
            this.Load += new System.EventHandler(this.FormApplicantsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admissionCommitteeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsDataBindingNavigator)).EndInit();
            this.applicantsDataBindingNavigator.ResumeLayout(false);
            this.applicantsDataBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdmissionCommitteeDataSet admissionCommitteeDataSet;
        private System.Windows.Forms.BindingSource applicantsDataBindingSource;
        private AdmissionCommitteeDataSetTableAdapters.ApplicantsDataTableAdapter applicantsDataTableAdapter;
        private AdmissionCommitteeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator applicantsDataBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton applicantsDataBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox applicant_IDTextBox;
        private System.Windows.Forms.TextBox identity_and_citizenship_document_codeTextBox;
        private System.Windows.Forms.TextBox previous_education_document_codeTextBox;
        private System.Windows.Forms.TextBox admission_application_and_personal_data_processing_consent_codeTextBox;
        private System.Windows.Forms.TextBox enrollment_application_codeTextBox;
        private System.Windows.Forms.TextBox unified_State_Exam_scoresTextBox;
    }
}