namespace AdmissionCommitteeLabs.View
{
    partial class FormEnrollmentOrders
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
            System.Windows.Forms.Label enrollment_order_IDLabel1;
            System.Windows.Forms.Label ranking_list_IDLabel1;
            System.Windows.Forms.Label full_nameLabel1;
            System.Windows.Forms.Label university_groupLabel1;
            System.Windows.Forms.Label studentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnrollmentOrders));
            this.enrollmentOrdersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.enrollmentOrdersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.enrollment_order_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.ranking_list_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.full_nameTextBox1 = new System.Windows.Forms.TextBox();
            this.university_groupTextBox1 = new System.Windows.Forms.TextBox();
            this.studentTextBox = new System.Windows.Forms.TextBox();
            this.enrollmentOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admissionCommitteeDataSet = new AdmissionCommitteeLabs.AdmissionCommitteeDataSet();
            this.enrollmentOrdersTableAdapter = new AdmissionCommitteeLabs.AdmissionCommitteeDataSetTableAdapters.EnrollmentOrdersTableAdapter();
            this.tableAdapterManager = new AdmissionCommitteeLabs.AdmissionCommitteeDataSetTableAdapters.TableAdapterManager();
            enrollment_order_IDLabel1 = new System.Windows.Forms.Label();
            ranking_list_IDLabel1 = new System.Windows.Forms.Label();
            full_nameLabel1 = new System.Windows.Forms.Label();
            university_groupLabel1 = new System.Windows.Forms.Label();
            studentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentOrdersBindingNavigator)).BeginInit();
            this.enrollmentOrdersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionCommitteeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // enrollment_order_IDLabel1
            // 
            enrollment_order_IDLabel1.AutoSize = true;
            enrollment_order_IDLabel1.Location = new System.Drawing.Point(12, 34);
            enrollment_order_IDLabel1.Name = "enrollment_order_IDLabel1";
            enrollment_order_IDLabel1.Size = new System.Drawing.Size(99, 13);
            enrollment_order_IDLabel1.TabIndex = 9;
            enrollment_order_IDLabel1.Text = "enrollment order ID:";
            // 
            // ranking_list_IDLabel1
            // 
            ranking_list_IDLabel1.AutoSize = true;
            ranking_list_IDLabel1.Location = new System.Drawing.Point(12, 60);
            ranking_list_IDLabel1.Name = "ranking_list_IDLabel1";
            ranking_list_IDLabel1.Size = new System.Drawing.Size(74, 13);
            ranking_list_IDLabel1.TabIndex = 11;
            ranking_list_IDLabel1.Text = "ranking list ID:";
            // 
            // full_nameLabel1
            // 
            full_nameLabel1.AutoSize = true;
            full_nameLabel1.Location = new System.Drawing.Point(12, 86);
            full_nameLabel1.Name = "full_nameLabel1";
            full_nameLabel1.Size = new System.Drawing.Size(52, 13);
            full_nameLabel1.TabIndex = 13;
            full_nameLabel1.Text = "full name:";
            // 
            // university_groupLabel1
            // 
            university_groupLabel1.AutoSize = true;
            university_groupLabel1.Location = new System.Drawing.Point(12, 112);
            university_groupLabel1.Name = "university_groupLabel1";
            university_groupLabel1.Size = new System.Drawing.Size(84, 13);
            university_groupLabel1.TabIndex = 15;
            university_groupLabel1.Text = "university group:";
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Location = new System.Drawing.Point(12, 138);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new System.Drawing.Size(45, 13);
            studentLabel.TabIndex = 17;
            studentLabel.Text = "student:";
            // 
            // enrollmentOrdersBindingNavigator
            // 
            this.enrollmentOrdersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.enrollmentOrdersBindingNavigator.BindingSource = this.enrollmentOrdersBindingSource;
            this.enrollmentOrdersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.enrollmentOrdersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.enrollmentOrdersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.enrollmentOrdersBindingNavigatorSaveItem});
            this.enrollmentOrdersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.enrollmentOrdersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.enrollmentOrdersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.enrollmentOrdersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.enrollmentOrdersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.enrollmentOrdersBindingNavigator.Name = "enrollmentOrdersBindingNavigator";
            this.enrollmentOrdersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.enrollmentOrdersBindingNavigator.Size = new System.Drawing.Size(353, 25);
            this.enrollmentOrdersBindingNavigator.TabIndex = 0;
            this.enrollmentOrdersBindingNavigator.Text = "bindingNavigator1";
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
            // enrollmentOrdersBindingNavigatorSaveItem
            // 
            this.enrollmentOrdersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enrollmentOrdersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("enrollmentOrdersBindingNavigatorSaveItem.Image")));
            this.enrollmentOrdersBindingNavigatorSaveItem.Name = "enrollmentOrdersBindingNavigatorSaveItem";
            this.enrollmentOrdersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.enrollmentOrdersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.enrollmentOrdersBindingNavigatorSaveItem.Click += new System.EventHandler(this.enrollmentOrdersBindingNavigatorSaveItem_Click);
            // 
            // enrollment_order_IDTextBox1
            // 
            this.enrollment_order_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentOrdersBindingSource, "Enrollment_order_ID", true));
            this.enrollment_order_IDTextBox1.Location = new System.Drawing.Point(117, 31);
            this.enrollment_order_IDTextBox1.Name = "enrollment_order_IDTextBox1";
            this.enrollment_order_IDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.enrollment_order_IDTextBox1.TabIndex = 10;
            // 
            // ranking_list_IDTextBox1
            // 
            this.ranking_list_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentOrdersBindingSource, "ranking_list_ID", true));
            this.ranking_list_IDTextBox1.Location = new System.Drawing.Point(117, 57);
            this.ranking_list_IDTextBox1.Name = "ranking_list_IDTextBox1";
            this.ranking_list_IDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.ranking_list_IDTextBox1.TabIndex = 12;
            // 
            // full_nameTextBox1
            // 
            this.full_nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentOrdersBindingSource, "full_name", true));
            this.full_nameTextBox1.Location = new System.Drawing.Point(117, 83);
            this.full_nameTextBox1.Name = "full_nameTextBox1";
            this.full_nameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.full_nameTextBox1.TabIndex = 14;
            // 
            // university_groupTextBox1
            // 
            this.university_groupTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentOrdersBindingSource, "university_group", true));
            this.university_groupTextBox1.Location = new System.Drawing.Point(117, 109);
            this.university_groupTextBox1.Name = "university_groupTextBox1";
            this.university_groupTextBox1.Size = new System.Drawing.Size(100, 20);
            this.university_groupTextBox1.TabIndex = 16;
            // 
            // studentTextBox
            // 
            this.studentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentOrdersBindingSource, "Student", true));
            this.studentTextBox.Location = new System.Drawing.Point(117, 135);
            this.studentTextBox.Name = "studentTextBox";
            this.studentTextBox.Size = new System.Drawing.Size(224, 20);
            this.studentTextBox.TabIndex = 18;
            // 
            // enrollmentOrdersBindingSource
            // 
            this.enrollmentOrdersBindingSource.DataMember = "EnrollmentOrders";
            this.enrollmentOrdersBindingSource.DataSource = this.admissionCommitteeDataSet;
            // 
            // admissionCommitteeDataSet
            // 
            this.admissionCommitteeDataSet.DataSetName = "AdmissionCommitteeDataSet";
            this.admissionCommitteeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enrollmentOrdersTableAdapter
            // 
            this.enrollmentOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicantsDataTableAdapter = null;
            this.tableAdapterManager.ApplicantsRankingListsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EnrollmentOrdersTableAdapter = this.enrollmentOrdersTableAdapter;
            this.tableAdapterManager.PersonalFileTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AdmissionCommitteeLabs.AdmissionCommitteeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormEnrollmentOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 166);
            this.Controls.Add(enrollment_order_IDLabel1);
            this.Controls.Add(this.enrollment_order_IDTextBox1);
            this.Controls.Add(ranking_list_IDLabel1);
            this.Controls.Add(this.ranking_list_IDTextBox1);
            this.Controls.Add(full_nameLabel1);
            this.Controls.Add(this.full_nameTextBox1);
            this.Controls.Add(university_groupLabel1);
            this.Controls.Add(this.university_groupTextBox1);
            this.Controls.Add(studentLabel);
            this.Controls.Add(this.studentTextBox);
            this.Controls.Add(this.enrollmentOrdersBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEnrollmentOrders";
            this.Text = "FormEnrollmentOrders";
            this.Load += new System.EventHandler(this.FormEnrollmentOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentOrdersBindingNavigator)).EndInit();
            this.enrollmentOrdersBindingNavigator.ResumeLayout(false);
            this.enrollmentOrdersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionCommitteeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdmissionCommitteeDataSet admissionCommitteeDataSet;
        private System.Windows.Forms.BindingSource enrollmentOrdersBindingSource;
        private AdmissionCommitteeDataSetTableAdapters.EnrollmentOrdersTableAdapter enrollmentOrdersTableAdapter;
        private AdmissionCommitteeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator enrollmentOrdersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton enrollmentOrdersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox enrollment_order_IDTextBox1;
        private System.Windows.Forms.TextBox ranking_list_IDTextBox1;
        private System.Windows.Forms.TextBox full_nameTextBox1;
        private System.Windows.Forms.TextBox university_groupTextBox1;
        private System.Windows.Forms.TextBox studentTextBox;
    }
}