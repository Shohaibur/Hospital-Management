
namespace Hospital_Management
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.label1 = new System.Windows.Forms.Label();
            this.picbox_FindDoctor = new System.Windows.Forms.PictureBox();
            this.lbl_FindDoctor = new System.Windows.Forms.Label();
            this.lbl_BookApp = new System.Windows.Forms.Label();
            this.pictureBox_BookApp = new System.Windows.Forms.PictureBox();
            this.lbl_ViewApp = new System.Windows.Forms.Label();
            this.pictureBox_ViewApp = new System.Windows.Forms.PictureBox();
            this.pictureBox_Logout = new System.Windows.Forms.PictureBox();
            this.lbl_logout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_FindDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BookApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ViewApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "AIHB";
            // 
            // picbox_FindDoctor
            // 
            this.picbox_FindDoctor.BackColor = System.Drawing.Color.Transparent;
            this.picbox_FindDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_FindDoctor.BackgroundImage")));
            this.picbox_FindDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_FindDoctor.Location = new System.Drawing.Point(74, 157);
            this.picbox_FindDoctor.Name = "picbox_FindDoctor";
            this.picbox_FindDoctor.Size = new System.Drawing.Size(103, 91);
            this.picbox_FindDoctor.TabIndex = 6;
            this.picbox_FindDoctor.TabStop = false;
            this.picbox_FindDoctor.Click += new System.EventHandler(this.picbox_FindDoctor_Click);
            // 
            // lbl_FindDoctor
            // 
            this.lbl_FindDoctor.AutoSize = true;
            this.lbl_FindDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FindDoctor.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FindDoctor.Location = new System.Drawing.Point(68, 251);
            this.lbl_FindDoctor.Name = "lbl_FindDoctor";
            this.lbl_FindDoctor.Size = new System.Drawing.Size(109, 22);
            this.lbl_FindDoctor.TabIndex = 7;
            this.lbl_FindDoctor.Text = "Find Doctor";
            // 
            // lbl_BookApp
            // 
            this.lbl_BookApp.AutoSize = true;
            this.lbl_BookApp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BookApp.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookApp.Location = new System.Drawing.Point(294, 251);
            this.lbl_BookApp.Name = "lbl_BookApp";
            this.lbl_BookApp.Size = new System.Drawing.Size(189, 22);
            this.lbl_BookApp.TabIndex = 7;
            this.lbl_BookApp.Text = "Book An Appointment";
            // 
            // pictureBox_BookApp
            // 
            this.pictureBox_BookApp.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_BookApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_BookApp.BackgroundImage")));
            this.pictureBox_BookApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_BookApp.Location = new System.Drawing.Point(339, 157);
            this.pictureBox_BookApp.Name = "pictureBox_BookApp";
            this.pictureBox_BookApp.Size = new System.Drawing.Size(103, 91);
            this.pictureBox_BookApp.TabIndex = 8;
            this.pictureBox_BookApp.TabStop = false;
            this.pictureBox_BookApp.Click += new System.EventHandler(this.pictureBox_BookApp_Click);
            // 
            // lbl_ViewApp
            // 
            this.lbl_ViewApp.AutoSize = true;
            this.lbl_ViewApp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ViewApp.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ViewApp.Location = new System.Drawing.Point(48, 478);
            this.lbl_ViewApp.Name = "lbl_ViewApp";
            this.lbl_ViewApp.Size = new System.Drawing.Size(158, 22);
            this.lbl_ViewApp.TabIndex = 7;
            this.lbl_ViewApp.Text = "View Appointment";
            // 
            // pictureBox_ViewApp
            // 
            this.pictureBox_ViewApp.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ViewApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_ViewApp.BackgroundImage")));
            this.pictureBox_ViewApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_ViewApp.Location = new System.Drawing.Point(78, 393);
            this.pictureBox_ViewApp.Name = "pictureBox_ViewApp";
            this.pictureBox_ViewApp.Size = new System.Drawing.Size(99, 82);
            this.pictureBox_ViewApp.TabIndex = 9;
            this.pictureBox_ViewApp.TabStop = false;
            this.pictureBox_ViewApp.Click += new System.EventHandler(this.pictureBox_ViewApp_Click);
            // 
            // pictureBox_Logout
            // 
            this.pictureBox_Logout.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logout.BackgroundImage")));
            this.pictureBox_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Logout.Location = new System.Drawing.Point(339, 383);
            this.pictureBox_Logout.Name = "pictureBox_Logout";
            this.pictureBox_Logout.Size = new System.Drawing.Size(103, 92);
            this.pictureBox_Logout.TabIndex = 10;
            this.pictureBox_Logout.TabStop = false;
            this.pictureBox_Logout.Click += new System.EventHandler(this.pictureBox_Logout_Click);
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logout.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.Location = new System.Drawing.Point(355, 478);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(78, 22);
            this.lbl_logout.TabIndex = 7;
            this.lbl_logout.Text = "Log Out";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 536);
            this.Controls.Add(this.pictureBox_Logout);
            this.Controls.Add(this.pictureBox_ViewApp);
            this.Controls.Add(this.pictureBox_BookApp);
            this.Controls.Add(this.lbl_BookApp);
            this.Controls.Add(this.lbl_ViewApp);
            this.Controls.Add(this.lbl_logout);
            this.Controls.Add(this.lbl_FindDoctor);
            this.Controls.Add(this.picbox_FindDoctor);
            this.Controls.Add(this.label1);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_FindDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BookApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ViewApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbox_FindDoctor;
        private System.Windows.Forms.Label lbl_FindDoctor;
        private System.Windows.Forms.Label lbl_BookApp;
        private System.Windows.Forms.PictureBox pictureBox_BookApp;
        private System.Windows.Forms.Label lbl_ViewApp;
        private System.Windows.Forms.PictureBox pictureBox_ViewApp;
        private System.Windows.Forms.PictureBox pictureBox_Logout;
        private System.Windows.Forms.Label lbl_logout;
    }
}