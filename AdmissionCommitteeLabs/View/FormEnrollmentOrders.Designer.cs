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
            System.Windows.Forms.Label enrollment_order_IDLabel;
            System.Windows.Forms.Label ranking_list_IDLabel;
            System.Windows.Forms.Label full_nameLabel;
            System.Windows.Forms.Label university_groupLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnrollmentOrders));
            this.selection_committeeDataSet = new AdmissionCommitteeLabs.Selection_committeeDataSet();
            this.enrollmentOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentOrdersTableAdapter = new AdmissionCommitteeLabs.Selection_committeeDataSetTableAdapters.EnrollmentOrdersTableAdapter();
            this.tableAdapterManager = new AdmissionCommitteeLabs.Selection_committeeDataSetTableAdapters.TableAdapterManager();
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
            this.enrollment_order_IDTextBox = new System.Windows.Forms.TextBox();
            this.ranking_list_IDTextBox = new System.Windows.Forms.TextBox();
            this.full_nameTextBox = new System.Windows.Forms.TextBox();
            this.university_groupTextBox = new System.Windows.Forms.TextBox();
            enrollment_order_IDLabel = new System.Windows.Forms.Label();
            ranking_list_IDLabel = new System.Windows.Forms.Label();
            full_nameLabel = new System.Windows.Forms.Label();
            university_groupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selection_committeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentOrdersBindingNavigator)).BeginInit();
            this.enrollmentOrdersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // enrollment_order_IDLabel
            // 
            enrollment_order_IDLabel.AutoSize = true;
            enrollment_order_IDLabel.Location = new System.Drawing.Point(45, 35);
            enrollment_order_IDLabel.Name = "enrollment_order_IDLabel";
            enrollment_order_IDLabel.Size = new System.Drawing.Size(99, 13);
            enrollment_order_IDLabel.TabIndex = 1;
            enrollment_order_IDLabel.Text = "enrollment order ID:";
            // 
            // ranking_list_IDLabel
            // 
            ranking_list_IDLabel.AutoSize = true;
            ranking_list_IDLabel.Location = new System.Drawing.Point(45, 61);
            ranking_list_IDLabel.Name = "ranking_list_IDLabel";
            ranking_list_IDLabel.Size = new System.Drawing.Size(74, 13);
            ranking_list_IDLabel.TabIndex = 3;
            ranking_list_IDLabel.Text = "ranking list ID:";
            // 
            // full_nameLabel
            // 
            full_nameLabel.AutoSize = true;
            full_nameLabel.Location = new System.Drawing.Point(45, 87);
            full_nameLabel.Name = "full_nameLabel";
            full_nameLabel.Size = new System.Drawing.Size(52, 13);
            full_nameLabel.TabIndex = 5;
            full_nameLabel.Text = "full name:";
            // 
            // university_groupLabel
            // 
            university_groupLabel.AutoSize = true;
            university_groupLabel.Location = new System.Drawing.Point(45, 113);
            university_groupLabel.Name = "university_groupLabel";
            university_groupLabel.Size = new System.Drawing.Size(84, 13);
            university_groupLabel.TabIndex = 7;
            university_groupLabel.Text = "university group:";
            // 
            // selection_committeeDataSet
            // 
            this.selection_committeeDataSet.DataSetName = "Selection_committeeDataSet";
            this.selection_committeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicantsDataTableAdapter = null;
            this.tableAdapterManager.ApplicantsRankingListsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EnrollmentOrdersTableAdapter = this.enrollmentOrdersTableAdapter;
            this.tableAdapterManager.PersonalFileTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AdmissionCommitteeLabs.Selection_committeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.enrollmentOrdersBindingNavigator.Size = new System.Drawing.Size(294, 25);
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
            // enrollment_order_IDTextBox
            // 
            this.enrollment_order_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentOrdersBindingSource, "enrollment_order_ID", true));
            this.enrollment_order_IDTextBox.Location = new System.Drawing.Point(150, 32);
            this.enrollment_order_IDTextBox.Name = "enrollment_order_IDTextBox";
            this.enrollment_order_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.enrollment_order_IDTextBox.TabIndex = 2;
            // 
            // ranking_list_IDTextBox
            // 
            this.ranking_list_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentOrdersBindingSource, "ranking_list_ID", true));
            this.ranking_list_IDTextBox.Location = new System.Drawing.Point(150, 58);
            this.ranking_list_IDTextBox.Name = "ranking_list_IDTextBox";
            this.ranking_list_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ranking_list_IDTextBox.TabIndex = 4;
            // 
            // full_nameTextBox
            // 
            this.full_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentOrdersBindingSource, "full_name", true));
            this.full_nameTextBox.Location = new System.Drawing.Point(150, 84);
            this.full_nameTextBox.Name = "full_nameTextBox";
            this.full_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.full_nameTextBox.TabIndex = 6;
            // 
            // university_groupTextBox
            // 
            this.university_groupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentOrdersBindingSource, "university_group", true));
            this.university_groupTextBox.Location = new System.Drawing.Point(150, 110);
            this.university_groupTextBox.Name = "university_groupTextBox";
            this.university_groupTextBox.Size = new System.Drawing.Size(100, 20);
            this.university_groupTextBox.TabIndex = 8;
            // 
            // FormEnrollmentOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 159);
            this.Controls.Add(enrollment_order_IDLabel);
            this.Controls.Add(this.enrollment_order_IDTextBox);
            this.Controls.Add(ranking_list_IDLabel);
            this.Controls.Add(this.ranking_list_IDTextBox);
            this.Controls.Add(full_nameLabel);
            this.Controls.Add(this.full_nameTextBox);
            this.Controls.Add(university_groupLabel);
            this.Controls.Add(this.university_groupTextBox);
            this.Controls.Add(this.enrollmentOrdersBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEnrollmentOrders";
            this.Text = "FormEnrollmentOrders";
            this.Load += new System.EventHandler(this.FormEnrollmentOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selection_committeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentOrdersBindingNavigator)).EndInit();
            this.enrollmentOrdersBindingNavigator.ResumeLayout(false);
            this.enrollmentOrdersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Selection_committeeDataSet selection_committeeDataSet;
        private System.Windows.Forms.BindingSource enrollmentOrdersBindingSource;
        private Selection_committeeDataSetTableAdapters.EnrollmentOrdersTableAdapter enrollmentOrdersTableAdapter;
        private Selection_committeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox enrollment_order_IDTextBox;
        private System.Windows.Forms.TextBox ranking_list_IDTextBox;
        private System.Windows.Forms.TextBox full_nameTextBox;
        private System.Windows.Forms.TextBox university_groupTextBox;
    }
}