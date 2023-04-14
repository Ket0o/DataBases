namespace AdmissionCommitteeLabs.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicantsDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicantsRankingListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollmentOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.referencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applicantsDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applicantsRankingListsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollmentOrdersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.ExitButton = new System.Windows.Forms.ToolStripButton();
            this.AboutProgramButton = new System.Windows.Forms.ToolStripButton();
            this.ApplicantsDataButton = new System.Windows.Forms.ToolStripButton();
            this.ApplicantsRankingListsButton = new System.Windows.Forms.ToolStripButton();
            this.PersonalFileButton = new System.Windows.Forms.ToolStripButton();
            this.EnrollmentOrdersButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.referencesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::AdmissionCommitteeLabs.Properties.Resources.exit_16x16;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Image = global::AdmissionCommitteeLabs.Properties.Resources.about_program_16x16;
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.aboutProgramToolStripMenuItem.Text = "About program...";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // referencesToolStripMenuItem
            // 
            this.referencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicantsDataToolStripMenuItem,
            this.applicantsRankingListsToolStripMenuItem,
            this.personalFileToolStripMenuItem,
            this.enrollmentOrdersToolStripMenuItem});
            this.referencesToolStripMenuItem.Name = "referencesToolStripMenuItem";
            this.referencesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.referencesToolStripMenuItem.Text = "References";
            // 
            // applicantsDataToolStripMenuItem
            // 
            this.applicantsDataToolStripMenuItem.Image = global::AdmissionCommitteeLabs.Properties.Resources.applicant_data_16x16;
            this.applicantsDataToolStripMenuItem.Name = "applicantsDataToolStripMenuItem";
            this.applicantsDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.applicantsDataToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.applicantsDataToolStripMenuItem.Text = "Applicants data";
            this.applicantsDataToolStripMenuItem.Click += new System.EventHandler(this.applicantsDataToolStripMenuItem_Click);
            // 
            // applicantsRankingListsToolStripMenuItem
            // 
            this.applicantsRankingListsToolStripMenuItem.Image = global::AdmissionCommitteeLabs.Properties.Resources.list;
            this.applicantsRankingListsToolStripMenuItem.Name = "applicantsRankingListsToolStripMenuItem";
            this.applicantsRankingListsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.applicantsRankingListsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.applicantsRankingListsToolStripMenuItem.Text = "Applicants ranking lists";
            this.applicantsRankingListsToolStripMenuItem.Click += new System.EventHandler(this.applicantsRankingListsToolStripMenuItem_Click);
            // 
            // personalFileToolStripMenuItem
            // 
            this.personalFileToolStripMenuItem.Image = global::AdmissionCommitteeLabs.Properties.Resources.phone_book;
            this.personalFileToolStripMenuItem.Name = "personalFileToolStripMenuItem";
            this.personalFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.personalFileToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.personalFileToolStripMenuItem.Text = "Personal file";
            this.personalFileToolStripMenuItem.Click += new System.EventHandler(this.personalFileToolStripMenuItem_Click);
            // 
            // enrollmentOrdersToolStripMenuItem
            // 
            this.enrollmentOrdersToolStripMenuItem.Image = global::AdmissionCommitteeLabs.Properties.Resources.enrollment_orders_16x16;
            this.enrollmentOrdersToolStripMenuItem.Name = "enrollmentOrdersToolStripMenuItem";
            this.enrollmentOrdersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
            this.enrollmentOrdersToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.enrollmentOrdersToolStripMenuItem.Text = "Enrollment orders";
            this.enrollmentOrdersToolStripMenuItem.Click += new System.EventHandler(this.enrollmentOrdersToolStripMenuItem_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.referencesToolStripMenuItem1});
            this.contextMenuStripMain.Name = "contextMenuStrip1";
            this.contextMenuStripMain.Size = new System.Drawing.Size(181, 70);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.aboutProgramToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::AdmissionCommitteeLabs.Properties.Resources.exit_16x16;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem1
            // 
            this.aboutProgramToolStripMenuItem1.Image = global::AdmissionCommitteeLabs.Properties.Resources.about_program_16x16;
            this.aboutProgramToolStripMenuItem1.Name = "aboutProgramToolStripMenuItem1";
            this.aboutProgramToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.aboutProgramToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.aboutProgramToolStripMenuItem1.Text = "About program";
            this.aboutProgramToolStripMenuItem1.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // referencesToolStripMenuItem1
            // 
            this.referencesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicantsDataToolStripMenuItem1,
            this.applicantsRankingListsToolStripMenuItem1,
            this.personalFileToolStripMenuItem1,
            this.enrollmentOrdersToolStripMenuItem1});
            this.referencesToolStripMenuItem1.Name = "referencesToolStripMenuItem1";
            this.referencesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.referencesToolStripMenuItem1.Text = "References";
            // 
            // applicantsDataToolStripMenuItem1
            // 
            this.applicantsDataToolStripMenuItem1.Image = global::AdmissionCommitteeLabs.Properties.Resources.applicant_data_16x16;
            this.applicantsDataToolStripMenuItem1.Name = "applicantsDataToolStripMenuItem1";
            this.applicantsDataToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.applicantsDataToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.applicantsDataToolStripMenuItem1.Text = "Applicants data";
            this.applicantsDataToolStripMenuItem1.Click += new System.EventHandler(this.applicantsDataToolStripMenuItem_Click);
            // 
            // applicantsRankingListsToolStripMenuItem1
            // 
            this.applicantsRankingListsToolStripMenuItem1.Image = global::AdmissionCommitteeLabs.Properties.Resources.list;
            this.applicantsRankingListsToolStripMenuItem1.Name = "applicantsRankingListsToolStripMenuItem1";
            this.applicantsRankingListsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.applicantsRankingListsToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.applicantsRankingListsToolStripMenuItem1.Text = "Applicants ranking lists";
            this.applicantsRankingListsToolStripMenuItem1.Click += new System.EventHandler(this.applicantsRankingListsToolStripMenuItem_Click);
            // 
            // personalFileToolStripMenuItem1
            // 
            this.personalFileToolStripMenuItem1.Image = global::AdmissionCommitteeLabs.Properties.Resources.phone_book;
            this.personalFileToolStripMenuItem1.Name = "personalFileToolStripMenuItem1";
            this.personalFileToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.personalFileToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.personalFileToolStripMenuItem1.Text = "Personal file";
            this.personalFileToolStripMenuItem1.Click += new System.EventHandler(this.personalFileToolStripMenuItem_Click);
            // 
            // enrollmentOrdersToolStripMenuItem1
            // 
            this.enrollmentOrdersToolStripMenuItem1.Image = global::AdmissionCommitteeLabs.Properties.Resources.enrollment_orders_16x16;
            this.enrollmentOrdersToolStripMenuItem1.Name = "enrollmentOrdersToolStripMenuItem1";
            this.enrollmentOrdersToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
            this.enrollmentOrdersToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.enrollmentOrdersToolStripMenuItem1.Text = "Enrollment orders";
            this.enrollmentOrdersToolStripMenuItem1.Click += new System.EventHandler(this.enrollmentOrdersToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitButton,
            this.AboutProgramButton,
            this.ApplicantsDataButton,
            this.ApplicantsRankingListsButton,
            this.PersonalFileButton,
            this.EnrollmentOrdersButton});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(800, 25);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // ExitButton
            // 
            this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitButton.Image = global::AdmissionCommitteeLabs.Properties.Resources.exit_16x16;
            this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(23, 22);
            this.ExitButton.Text = "toolStripButton1";
            this.ExitButton.ToolTipText = "Exit button";
            this.ExitButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AboutProgramButton
            // 
            this.AboutProgramButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutProgramButton.Image = global::AdmissionCommitteeLabs.Properties.Resources.about_program_16x16;
            this.AboutProgramButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Size = new System.Drawing.Size(23, 22);
            this.AboutProgramButton.Text = "toolStripButton1";
            this.AboutProgramButton.ToolTipText = "About program button";
            this.AboutProgramButton.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // ApplicantsDataButton
            // 
            this.ApplicantsDataButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ApplicantsDataButton.Image = global::AdmissionCommitteeLabs.Properties.Resources.applicant_data_16x16;
            this.ApplicantsDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApplicantsDataButton.Name = "ApplicantsDataButton";
            this.ApplicantsDataButton.Size = new System.Drawing.Size(23, 22);
            this.ApplicantsDataButton.Text = "toolStripButton1";
            this.ApplicantsDataButton.ToolTipText = "Applicants data button";
            this.ApplicantsDataButton.Click += new System.EventHandler(this.applicantsDataToolStripMenuItem_Click);
            // 
            // ApplicantsRankingListsButton
            // 
            this.ApplicantsRankingListsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ApplicantsRankingListsButton.Image = global::AdmissionCommitteeLabs.Properties.Resources.list;
            this.ApplicantsRankingListsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApplicantsRankingListsButton.Name = "ApplicantsRankingListsButton";
            this.ApplicantsRankingListsButton.Size = new System.Drawing.Size(23, 22);
            this.ApplicantsRankingListsButton.Text = "toolStripButton2";
            this.ApplicantsRankingListsButton.ToolTipText = "Applicants ranking lists button";
            this.ApplicantsRankingListsButton.Click += new System.EventHandler(this.applicantsRankingListsToolStripMenuItem_Click);
            // 
            // PersonalFileButton
            // 
            this.PersonalFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PersonalFileButton.Image = global::AdmissionCommitteeLabs.Properties.Resources.phone_book;
            this.PersonalFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PersonalFileButton.Name = "PersonalFileButton";
            this.PersonalFileButton.Size = new System.Drawing.Size(23, 22);
            this.PersonalFileButton.Text = "toolStripButton3";
            this.PersonalFileButton.ToolTipText = "Personal file button";
            this.PersonalFileButton.Click += new System.EventHandler(this.personalFileToolStripMenuItem_Click);
            // 
            // EnrollmentOrdersButton
            // 
            this.EnrollmentOrdersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EnrollmentOrdersButton.Image = global::AdmissionCommitteeLabs.Properties.Resources.enrollment_orders_16x16;
            this.EnrollmentOrdersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EnrollmentOrdersButton.Name = "EnrollmentOrdersButton";
            this.EnrollmentOrdersButton.Size = new System.Drawing.Size(23, 22);
            this.EnrollmentOrdersButton.Text = "toolStripButton4";
            this.EnrollmentOrdersButton.ToolTipText = "Enrollment orders button";
            this.EnrollmentOrdersButton.Click += new System.EventHandler(this.enrollmentOrdersToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStripMain;
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStrip);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::AdmissionCommitteeLabs.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::AdmissionCommitteeLabs.Properties.Settings.Default.FormPos;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Program for admissions Committee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicantsDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicantsRankingListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollmentOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem referencesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem applicantsDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem applicantsRankingListsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personalFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enrollmentOrdersToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton ExitButton;
        private System.Windows.Forms.ToolStripButton AboutProgramButton;
        private System.Windows.Forms.ToolStripButton ApplicantsDataButton;
        private System.Windows.Forms.ToolStripButton ApplicantsRankingListsButton;
        private System.Windows.Forms.ToolStripButton PersonalFileButton;
        private System.Windows.Forms.ToolStripButton EnrollmentOrdersButton;
    }
}

