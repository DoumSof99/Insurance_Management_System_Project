namespace Insurance_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IMSLabel = new System.Windows.Forms.Label();
            this.btnMembersData = new System.Windows.Forms.Button();
            this.btnMemberPayment = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnClientData = new System.Windows.Forms.Button();
            this.btnClientUncollected = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnInactiveMember = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnManageMeeting = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1125, 675);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IMSLabel
            // 
            this.IMSLabel.AutoSize = true;
            this.IMSLabel.Font = new System.Drawing.Font("Fugaz One", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMSLabel.ForeColor = System.Drawing.Color.Black;
            this.IMSLabel.Location = new System.Drawing.Point(371, 24);
            this.IMSLabel.Name = "IMSLabel";
            this.IMSLabel.Size = new System.Drawing.Size(851, 70);
            this.IMSLabel.TabIndex = 2;
            this.IMSLabel.Text = "INSURANCE MANAGEMENT SYSTEM";
            // 
            // btnMembersData
            // 
            this.btnMembersData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnMembersData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMembersData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnMembersData.FlatAppearance.BorderSize = 0;
            this.btnMembersData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMembersData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMembersData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembersData.ForeColor = System.Drawing.Color.White;
            this.btnMembersData.Location = new System.Drawing.Point(3, 599);
            this.btnMembersData.Name = "btnMembersData";
            this.btnMembersData.Size = new System.Drawing.Size(237, 56);
            this.btnMembersData.TabIndex = 4;
            this.btnMembersData.Text = "Group Members Data";
            this.btnMembersData.UseVisualStyleBackColor = false;
            this.btnMembersData.Click += new System.EventHandler(this.btnMembersData_Click);
            // 
            // btnMemberPayment
            // 
            this.btnMemberPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnMemberPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMemberPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnMemberPayment.FlatAppearance.BorderSize = 0;
            this.btnMemberPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMemberPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMemberPayment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberPayment.ForeColor = System.Drawing.Color.White;
            this.btnMemberPayment.Location = new System.Drawing.Point(3, 537);
            this.btnMemberPayment.Name = "btnMemberPayment";
            this.btnMemberPayment.Size = new System.Drawing.Size(237, 56);
            this.btnMemberPayment.TabIndex = 5;
            this.btnMemberPayment.Text = "Member Payment";
            this.btnMemberPayment.UseVisualStyleBackColor = false;
            this.btnMemberPayment.Click += new System.EventHandler(this.btnMemberPayment_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnEditMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnEditMember.FlatAppearance.BorderSize = 0;
            this.btnEditMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditMember.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMember.ForeColor = System.Drawing.Color.White;
            this.btnEditMember.Location = new System.Drawing.Point(3, 475);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(237, 56);
            this.btnEditMember.TabIndex = 6;
            this.btnEditMember.Text = "Edit Group-Member Data";
            this.btnEditMember.UseVisualStyleBackColor = false;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnAddMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddMember.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.Location = new System.Drawing.Point(3, 413);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(237, 56);
            this.btnAddMember.TabIndex = 7;
            this.btnAddMember.Text = "Add Goup-Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnClientData
            // 
            this.btnClientData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnClientData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClientData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnClientData.FlatAppearance.BorderSize = 0;
            this.btnClientData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClientData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClientData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientData.ForeColor = System.Drawing.Color.White;
            this.btnClientData.Location = new System.Drawing.Point(3, 351);
            this.btnClientData.Name = "btnClientData";
            this.btnClientData.Size = new System.Drawing.Size(237, 56);
            this.btnClientData.TabIndex = 8;
            this.btnClientData.Text = "Clients Data Records";
            this.btnClientData.UseVisualStyleBackColor = false;
            this.btnClientData.Click += new System.EventHandler(this.btnClientData_Click);
            // 
            // btnClientUncollected
            // 
            this.btnClientUncollected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnClientUncollected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClientUncollected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnClientUncollected.FlatAppearance.BorderSize = 0;
            this.btnClientUncollected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClientUncollected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClientUncollected.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientUncollected.ForeColor = System.Drawing.Color.White;
            this.btnClientUncollected.Location = new System.Drawing.Point(3, 290);
            this.btnClientUncollected.Name = "btnClientUncollected";
            this.btnClientUncollected.Size = new System.Drawing.Size(237, 56);
            this.btnClientUncollected.TabIndex = 9;
            this.btnClientUncollected.Text = "Customer Amount";
            this.btnClientUncollected.UseVisualStyleBackColor = false;
            this.btnClientUncollected.Click += new System.EventHandler(this.btnClientUncollected_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnEditClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnEditClient.FlatAppearance.BorderSize = 0;
            this.btnEditClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.ForeColor = System.Drawing.Color.White;
            this.btnEditClient.Location = new System.Drawing.Point(3, 228);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(237, 56);
            this.btnEditClient.TabIndex = 10;
            this.btnEditClient.Text = "Edit Client Data";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(3, 166);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(237, 56);
            this.btnAddClient.TabIndex = 11;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnInactiveMember
            // 
            this.btnInactiveMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnInactiveMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInactiveMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnInactiveMember.FlatAppearance.BorderSize = 0;
            this.btnInactiveMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnInactiveMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInactiveMember.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactiveMember.ForeColor = System.Drawing.Color.White;
            this.btnInactiveMember.Location = new System.Drawing.Point(3, 661);
            this.btnInactiveMember.Name = "btnInactiveMember";
            this.btnInactiveMember.Size = new System.Drawing.Size(237, 56);
            this.btnInactiveMember.TabIndex = 12;
            this.btnInactiveMember.Text = "Inactive Members";
            this.btnInactiveMember.UseVisualStyleBackColor = false;
            this.btnInactiveMember.Click += new System.EventHandler(this.btnInactiveMember_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(3, 723);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(237, 56);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnManageMeeting
            // 
            this.btnManageMeeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnManageMeeting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManageMeeting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.btnManageMeeting.FlatAppearance.BorderSize = 0;
            this.btnManageMeeting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnManageMeeting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageMeeting.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMeeting.ForeColor = System.Drawing.Color.White;
            this.btnManageMeeting.Location = new System.Drawing.Point(3, 104);
            this.btnManageMeeting.Name = "btnManageMeeting";
            this.btnManageMeeting.Size = new System.Drawing.Size(237, 56);
            this.btnManageMeeting.TabIndex = 14;
            this.btnManageMeeting.Text = "Manage a Meeting";
            this.btnManageMeeting.UseVisualStyleBackColor = false;
            this.btnManageMeeting.Click += new System.EventHandler(this.btnMeeting_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "NAVIGATION BAR";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnManageMeeting);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnInactiveMember);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnClientUncollected);
            this.Controls.Add(this.btnClientData);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnEditMember);
            this.Controls.Add(this.btnMemberPayment);
            this.Controls.Add(this.btnMembersData);
            this.Controls.Add(this.IMSLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label IMSLabel;
        private System.Windows.Forms.Button btnMembersData;
        private System.Windows.Forms.Button btnMemberPayment;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnClientData;
        private System.Windows.Forms.Button btnClientUncollected;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnInactiveMember;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnManageMeeting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

