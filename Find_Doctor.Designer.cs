
namespace Hospital_Management
{
    partial class Find_Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find_Doctor));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_f_DocName = new System.Windows.Forms.Label();
            this.lbl_f_Dep = new System.Windows.Forms.Label();
            this.comboBox_f_Dep = new System.Windows.Forms.ComboBox();
            this.btn_fDbyname = new System.Windows.Forms.Button();
            this.btn_fDocbyDep = new System.Windows.Forms.Button();
            this.txt_f_Dname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find a Doctor";
            // 
            // lbl_f_DocName
            // 
            this.lbl_f_DocName.AutoSize = true;
            this.lbl_f_DocName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_f_DocName.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_f_DocName.Location = new System.Drawing.Point(165, 96);
            this.lbl_f_DocName.Name = "lbl_f_DocName";
            this.lbl_f_DocName.Size = new System.Drawing.Size(174, 31);
            this.lbl_f_DocName.TabIndex = 1;
            this.lbl_f_DocName.Text = "Doctor Name:";
            // 
            // lbl_f_Dep
            // 
            this.lbl_f_Dep.AutoSize = true;
            this.lbl_f_Dep.BackColor = System.Drawing.Color.Transparent;
            this.lbl_f_Dep.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_f_Dep.Location = new System.Drawing.Point(166, 198);
            this.lbl_f_Dep.Name = "lbl_f_Dep";
            this.lbl_f_Dep.Size = new System.Drawing.Size(158, 31);
            this.lbl_f_Dep.TabIndex = 2;
            this.lbl_f_Dep.Text = "Department:";
            // 
            // comboBox_f_Dep
            // 
            this.comboBox_f_Dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_f_Dep.FormattingEnabled = true;
            this.comboBox_f_Dep.Items.AddRange(new object[] {
            "Neurologist",
            "Anesthesiologists",
            "Cardiologists"});
            this.comboBox_f_Dep.Location = new System.Drawing.Point(359, 204);
            this.comboBox_f_Dep.Name = "comboBox_f_Dep";
            this.comboBox_f_Dep.Size = new System.Drawing.Size(195, 24);
            this.comboBox_f_Dep.TabIndex = 4;
            // 
            // btn_fDbyname
            // 
            this.btn_fDbyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fDbyname.Location = new System.Drawing.Point(593, 103);
            this.btn_fDbyname.Name = "btn_fDbyname";
            this.btn_fDbyname.Size = new System.Drawing.Size(93, 36);
            this.btn_fDbyname.TabIndex = 5;
            this.btn_fDbyname.Text = "Find";
            this.btn_fDbyname.UseVisualStyleBackColor = true;
            this.btn_fDbyname.Click += new System.EventHandler(this.btn_fDbyname_Click);
            // 
            // btn_fDocbyDep
            // 
            this.btn_fDocbyDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fDocbyDep.Location = new System.Drawing.Point(593, 198);
            this.btn_fDocbyDep.Name = "btn_fDocbyDep";
            this.btn_fDocbyDep.Size = new System.Drawing.Size(93, 36);
            this.btn_fDocbyDep.TabIndex = 5;
            this.btn_fDocbyDep.Text = "Find";
            this.btn_fDocbyDep.UseVisualStyleBackColor = true;
            this.btn_fDocbyDep.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_f_Dname
            // 
            this.txt_f_Dname.BackColor = System.Drawing.Color.Snow;
            this.txt_f_Dname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_f_Dname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_f_Dname.Location = new System.Drawing.Point(359, 103);
            this.txt_f_Dname.Name = "txt_f_Dname";
            this.txt_f_Dname.Size = new System.Drawing.Size(195, 27);
            this.txt_f_Dname.TabIndex = 13;
            this.txt_f_Dname.TextChanged += new System.EventHandler(this.txt_f_Dname_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_home.BackgroundImage")));
            this.pictureBox_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_home.Location = new System.Drawing.Point(712, 19);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(58, 44);
            this.pictureBox_home.TabIndex = 15;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // Find_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_f_Dname);
            this.Controls.Add(this.btn_fDocbyDep);
            this.Controls.Add(this.btn_fDbyname);
            this.Controls.Add(this.comboBox_f_Dep);
            this.Controls.Add(this.lbl_f_Dep);
            this.Controls.Add(this.lbl_f_DocName);
            this.Controls.Add(this.label1);
            this.Name = "Find_Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find_Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_f_DocName;
        private System.Windows.Forms.Label lbl_f_Dep;
        private System.Windows.Forms.ComboBox comboBox_f_Dep;
        private System.Windows.Forms.Button btn_fDbyname;
        private System.Windows.Forms.Button btn_fDocbyDep;
        private System.Windows.Forms.TextBox txt_f_Dname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox_home;
    }
}