using System.Drawing;
using System.Windows.Forms;

namespace StoreCreatorAndMenagmentSystem_oop_project
{
    partial class new_store
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
            this.storeName = new System.Windows.Forms.TextBox();
            this.managerName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.createStoreButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.reEnterPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.closeLable = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LoadingImg = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // storeName
            // 
            this.storeName.Location = new System.Drawing.Point(343, 159);
            this.storeName.Name = "storeName";
            this.storeName.Size = new System.Drawing.Size(443, 20);
            this.storeName.TabIndex = 4;
            this.storeName.TextChanged += new System.EventHandler(this.storeName_TextChanged);
            this.storeName.Validating += new System.ComponentModel.CancelEventHandler(this.storeName_Validating);
            // 
            // managerName
            // 
            this.managerName.Location = new System.Drawing.Point(343, 224);
            this.managerName.Name = "managerName";
            this.managerName.Size = new System.Drawing.Size(443, 20);
            this.managerName.TabIndex = 5;
            this.managerName.Validating += new System.ComponentModel.CancelEventHandler(this.managerName_Validating);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(343, 281);
            this.password.MaxLength = 16;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(443, 20);
            this.password.TabIndex = 6;
            this.toolTip1.SetToolTip(this.password, " password must contain:\r\n[1]8-16 charcters\r\n[2]one capital letter\r\n[3]one noncapi" +
        "tal letter\r\n[4]one sing");
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Validating += new System.ComponentModel.CancelEventHandler(this.password_Validating);
            // 
            // createStoreButton
            // 
            this.createStoreButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.createStoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createStoreButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.createStoreButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createStoreButton.Location = new System.Drawing.Point(343, 393);
            this.createStoreButton.Name = "createStoreButton";
            this.createStoreButton.Size = new System.Drawing.Size(153, 35);
            this.createStoreButton.TabIndex = 7;
            this.createStoreButton.Text = "Create";
            this.createStoreButton.UseVisualStyleBackColor = false;
            this.createStoreButton.Click += new System.EventHandler(this.createStoreButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            // 
            // reEnterPassword
            // 
            this.reEnterPassword.Location = new System.Drawing.Point(343, 344);
            this.reEnterPassword.MaxLength = 16;
            this.reEnterPassword.Name = "reEnterPassword";
            this.reEnterPassword.PasswordChar = '*';
            this.reEnterPassword.Size = new System.Drawing.Size(443, 20);
            this.reEnterPassword.TabIndex = 27;
            this.toolTip1.SetToolTip(this.reEnterPassword, "required only for Creation");
            this.reEnterPassword.UseSystemPasswordChar = true;
            this.reEnterPassword.Validating += new System.ComponentModel.CancelEventHandler(this.reEnterPassword_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(10, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Store creation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(10, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "and management";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(69, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Developed by";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(69, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Omri Shmuel && Matan Zror";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(10, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 30);
            this.label9.TabIndex = 14;
            this.label9.Text = "system";
            // 
            // closeLable
            // 
            this.closeLable.AutoSize = true;
            this.closeLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.closeLable.ForeColor = System.Drawing.Color.DodgerBlue;
            this.closeLable.Location = new System.Drawing.Point(796, 0);
            this.closeLable.Name = "closeLable";
            this.closeLable.Size = new System.Drawing.Size(30, 32);
            this.closeLable.TabIndex = 16;
            this.closeLable.Text = "X";
            this.closeLable.Click += new System.EventHandler(this.closeLable_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(519, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 35);
            this.button3.TabIndex = 26;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadingImg
            // 
            this.LoadingImg.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.loading;
            this.LoadingImg.Location = new System.Drawing.Point(-14, 0);
            this.LoadingImg.Name = "LoadingImg";
            this.LoadingImg.Size = new System.Drawing.Size(860, 515);
            this.LoadingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingImg.TabIndex = 30;
            this.LoadingImg.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox9.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.password1;
            this.pictureBox9.Location = new System.Drawing.Point(293, 337);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(45, 39);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 29;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox10.Location = new System.Drawing.Point(288, 329);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(497, 58);
            this.pictureBox10.TabIndex = 28;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox7.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.IF_Creator_Icon_05_03_5122;
            this.pictureBox7.Location = new System.Drawing.Point(293, 146);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(45, 39);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.password1;
            this.pictureBox6.Location = new System.Drawing.Point(293, 274);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(45, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox5.Location = new System.Drawing.Point(288, 266);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(497, 58);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox2.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.IF_Creator_Icon_05_03_5123;
            this.pictureBox2.Location = new System.Drawing.Point(10, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 543);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Image = global::StoreCreatorAndMenagmentSystem_oop_project.Properties.Resources.userLogin;
            this.pictureBox3.Location = new System.Drawing.Point(293, 211);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Location = new System.Drawing.Point(288, 203);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(497, 58);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox8.Location = new System.Drawing.Point(288, 140);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(497, 58);
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            // 
            // new_store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 515);
            this.ControlBox = false;
            this.Controls.Add(this.LoadingImg);
            this.Controls.Add(this.closeLable);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.reEnterPassword);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.password);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.managerName);
            this.Controls.Add(this.storeName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createStoreButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox8);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "new_store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "new_store";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox storeName;
        private TextBox managerName;
        private TextBox password;
        private Button createStoreButton;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox2;
        private Label closeLable;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private Button button3;
        private PictureBox pictureBox9;
        private TextBox reEnterPassword;
        private PictureBox pictureBox10;
        private ErrorProvider errorProvider1;
        private PictureBox LoadingImg;
        private System.Windows.Forms.Timer timer1;
    }
}