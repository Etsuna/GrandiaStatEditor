
namespace GrandiaStatEditor
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SaveEnemyButton = new System.Windows.Forms.Button();
            this.SetPosition = new System.Windows.Forms.Label();
            this.EnemiePosition = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SaveTeamButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.SaveMoveAndMagicButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1759, 922);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.SaveEnemyButton);
            this.tabPage1.Controls.Add(this.SetPosition);
            this.tabPage1.Controls.Add(this.EnemiePosition);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1751, 896);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EnemyStats";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // SaveEnemyButton
            // 
            this.SaveEnemyButton.Location = new System.Drawing.Point(1620, 817);
            this.SaveEnemyButton.Name = "SaveEnemyButton";
            this.SaveEnemyButton.Size = new System.Drawing.Size(75, 23);
            this.SaveEnemyButton.TabIndex = 4;
            this.SaveEnemyButton.Text = "Save";
            this.SaveEnemyButton.UseVisualStyleBackColor = true;
            this.SaveEnemyButton.Click += new System.EventHandler(this.SaveEnemyButton_Click);
            // 
            // SetPosition
            // 
            this.SetPosition.AutoSize = true;
            this.SetPosition.Location = new System.Drawing.Point(101, 8);
            this.SetPosition.Name = "SetPosition";
            this.SetPosition.Size = new System.Drawing.Size(60, 13);
            this.SetPosition.TabIndex = 3;
            this.SetPosition.Text = "SetPosition";
            this.SetPosition.Click += new System.EventHandler(this.SetPosition_Click);
            // 
            // EnemiePosition
            // 
            this.EnemiePosition.AutoSize = true;
            this.EnemiePosition.Location = new System.Drawing.Point(81, 8);
            this.EnemiePosition.Name = "EnemiePosition";
            this.EnemiePosition.Size = new System.Drawing.Size(14, 13);
            this.EnemiePosition.TabIndex = 2;
            this.EnemiePosition.Text = "#";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.SaveTeamButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1751, 896);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CharacterStats";
            // 
            // SaveTeamButton
            // 
            this.SaveTeamButton.Location = new System.Drawing.Point(20, 6);
            this.SaveTeamButton.Name = "SaveTeamButton";
            this.SaveTeamButton.Size = new System.Drawing.Size(75, 23);
            this.SaveTeamButton.TabIndex = 0;
            this.SaveTeamButton.Text = "Save";
            this.SaveTeamButton.UseVisualStyleBackColor = true;
            this.SaveTeamButton.Click += new System.EventHandler(this.SaveTeamButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.Lavender;
            this.tabPage3.Controls.Add(this.SaveMoveAndMagicButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1751, 896);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MoveAndMagicStats";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newProjectToolStripMenuItem.Text = "New Project...";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProjectToolStripMenuItem_Click);
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.loadProjectToolStripMenuItem.Text = "Load Project...";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.infoToolStripMenuItem.Text = "Info...";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.BackColor = System.Drawing.Color.Lavender;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1751, 896);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "MoveRequirement";
            // 
            // SaveMoveAndMagicButton
            // 
            this.SaveMoveAndMagicButton.Location = new System.Drawing.Point(20, 6);
            this.SaveMoveAndMagicButton.Name = "SaveMoveAndMagicButton";
            this.SaveMoveAndMagicButton.Size = new System.Drawing.Size(75, 23);
            this.SaveMoveAndMagicButton.TabIndex = 0;
            this.SaveMoveAndMagicButton.Text = "Save";
            this.SaveMoveAndMagicButton.UseVisualStyleBackColor = true;
            this.SaveMoveAndMagicButton.Click += new System.EventHandler(this.SaveMoveAndMagicButton_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 961);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grandia Stat Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SetPosition;
        private System.Windows.Forms.Label EnemiePosition;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.Button SaveEnemyButton;
        private System.Windows.Forms.Button SaveTeamButton;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button SaveMoveAndMagicButton;
    }
}

