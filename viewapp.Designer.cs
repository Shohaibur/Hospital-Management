
namespace Hospital_Management
{
    partial class viewapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewapp));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_view_app = new System.Windows.Forms.Button();
            this.btn_delete_app = new System.Windows.Forms.Button();
            this.lbl_v_phone = new System.Windows.Forms.Label();
            this.txt_va_phone = new System.Windows.Forms.TextBox();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 146);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_view_app
            // 
            this.btn_view_app.BackColor = System.Drawing.Color.Green;
            this.btn_view_app.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_app.Location = new System.Drawing.Point(152, 70);
            this.btn_view_app.Name = "btn_view_app";
            this.btn_view_app.Size = new System.Drawing.Size(160, 58);
            this.btn_view_app.TabIndex = 1;
            this.btn_view_app.Text = "View Appointment";
            this.btn_view_app.UseVisualStyleBackColor = false;
            this.btn_view_app.Click += new System.EventHandler(this.btn_view_app_Click);
            // 
            // btn_delete_app
            // 
            this.btn_delete_app.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete_app.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_app.Location = new System.Drawing.Point(318, 70);
            this.btn_delete_app.Name = "btn_delete_app";
            this.btn_delete_app.Size = new System.Drawing.Size(156, 58);
            this.btn_delete_app.TabIndex = 2;
            this.btn_delete_app.Text = "Delete Appointment";
            this.btn_delete_app.UseVisualStyleBackColor = false;
            this.btn_delete_app.Click += new System.EventHandler(this.btn_delete_app_Click);
            // 
            // lbl_v_phone
            // 
            this.lbl_v_phone.AutoSize = true;
            this.lbl_v_phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_v_phone.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_v_phone.Location = new System.Drawing.Point(26, 26);
            this.lbl_v_phone.Name = "lbl_v_phone";
            this.lbl_v_phone.Size = new System.Drawing.Size(232, 24);
            this.lbl_v_phone.TabIndex = 3;
            this.lbl_v_phone.Text = "Give Your Phone Number:";
            // 
            // txt_va_phone
            // 
            this.txt_va_phone.Location = new System.Drawing.Point(264, 28);
            this.txt_va_phone.Name = "txt_va_phone";
            this.txt_va_phone.Size = new System.Drawing.Size(205, 22);
            this.txt_va_phone.TabIndex = 4;
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_home.BackgroundImage")));
            this.pictureBox_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_home.Location = new System.Drawing.Point(709, 28);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(58, 44);
            this.pictureBox_home.TabIndex = 17;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // viewapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.txt_va_phone);
            this.Controls.Add(this.lbl_v_phone);
            this.Controls.Add(this.btn_delete_app);
            this.Controls.Add(this.btn_view_app);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewapp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_view_app;
        private System.Windows.Forms.Button btn_delete_app;
        private System.Windows.Forms.Label lbl_v_phone;
        private System.Windows.Forms.TextBox txt_va_phone;
        private System.Windows.Forms.PictureBox pictureBox_home;
    }
}