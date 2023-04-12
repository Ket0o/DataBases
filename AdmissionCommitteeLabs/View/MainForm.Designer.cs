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
            this.enrollmentOrdersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applicantsRankingListsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applicantsDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
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
            this.exitToolStripMenuItem.Image = global::AdmissionCommitteeLabs.Properties.Resources.logout;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Image = global::AdmissionCommitteeLabs.Properties.Resources.information;
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
            this.applicantsDataToolStripMenuItem.Image = global::AdmissionCommitteeLabs.Properties.Resources.document;
            this.applicantsDataToolStripMenuItem.Name = "applicantsDataToolStripMenuItem";
            this.applicantsDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.applicantsDataToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.applicantsDataToolStripMenuItem.Text = "Applicants data";
            // 
            // applicantsRankingListsToolStripMenuItem
            // 
            this.applicantsRankingListsToolStripMenuItem.Image = global::AdmissionCommitteeLabs.Properties.Resources.list;
            this.applicantsRankingListsToolStripMenuItem.Name = "applicantsRankingListsToolStripMenuItem";
            this.applicantsRankingListsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.applicantsRankingListsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.applicantsRankingListsToolStripMenuItem.Text = "Applicants ranking lists";
            // 
            // personalFileToolStripMenuItem
            // 
            this.personalFileToolStripMenuItem.Image = global::AdmissionCommitteeLabs.Properties.Resources.phone_book;
            this.personalFileToolStripMenuItem.Name = "personalFileToolStripMenuItem";
            this.personalFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.personalFileToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.personalFileToolStripMenuItem.Text = "Personal file";
            // 
            // enrollmentOrdersToolStripMenuItem
            // 
            this.enrollmentOrdersToolStripMenuItem.Image = global::AdmissionCommitteeLabs.Properties.Resources.decree;
            this.enrollmentOrdersToolStripMenuItem.Name = "enrollmentOrdersToolStripMenuItem";
            this.enrollmentOrdersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
            this.enrollmentOrdersToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.enrollmentOrdersToolStripMenuItem.Text = "Enrollment orders";
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.referencesToolStripMenuItem1});
            this.contextMenuStripMain.Name = "contextMenuStrip1";
            this.contextMenuStripMain.Size = new System.Drawing.Size(132, 48);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.aboutProgramToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::AdmissionCommitteeLabs.Properties.Resources.logout;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem1
            // 
            this.aboutProgramToolStripMenuItem1.Image = global::AdmissionCommitteeLabs.Properties.Resources.information;
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
            this.referencesToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.referencesToolStripMenuItem1.Text = "References";
            // 
            // enrollmentOrdersToolStripMenuItem1
            // 
            this.enrollmentOrdersToolStripMenuItem1.Image = global::AdmissionCommitteeLabs.Properties.Resources.decree;
            this.enrollmentOrdersToolStripMenuItem1.Name = "enrollmentOrdersToolStripMenuItem1";
            this.enrollmentOrdersToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
            this.enrollmentOrdersToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.enrollmentOrdersToolStripMenuItem1.Text = "Enrollment orders";
            // 
            // personalFileToolStripMenuItem1
            // 
            this.personalFileToolStripMenuItem1.Image = global::AdmissionCommitteeLabs.Properties.Resources.phone_book;
            this.personalFileToolStripMenuItem1.Name = "personalFileToolStripMenuItem1";
            this.personalFileToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.personalFileToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.personalFileToolStripMenuItem1.Text = "Personal file";
            // 
            // applicantsRankingListsToolStripMenuItem1
            // 
            this.applicantsRankingListsToolStripMenuItem1.Image = global::AdmissionCommitteeLabs.Properties.Resources.list;
            this.applicantsRankingListsToolStripMenuItem1.Name = "applicantsRankingListsToolStripMenuItem1";
            this.applicantsRankingListsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.applicantsRankingListsToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.applicantsRankingListsToolStripMenuItem1.Text = "Applicants ranking lists";
            // 
            // applicantsDataToolStripMenuItem1
            // 
            this.applicantsDataToolStripMenuItem1.Image = global::AdmissionCommitteeLabs.Properties.Resources.document;
            this.applicantsDataToolStripMenuItem1.Name = "applicantsDataToolStripMenuItem1";
            this.applicantsDataToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.applicantsDataToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.applicantsDataToolStripMenuItem1.Text = "Applicants data";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStripMain;
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Program for admissions Committee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
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
    }
}

