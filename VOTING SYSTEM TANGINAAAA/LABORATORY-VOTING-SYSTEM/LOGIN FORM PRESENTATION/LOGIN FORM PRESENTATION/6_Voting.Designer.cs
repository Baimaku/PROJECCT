﻿namespace LOGIN_FORM_PRESENTATION
{
    partial class Voting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voting));
            this.voteBox = new System.Windows.Forms.ComboBox();
            this.VOTEBTN = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CD1 = new System.Windows.Forms.PictureBox();
            this.CD2 = new System.Windows.Forms.PictureBox();
            this.CD3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // voteBox
            // 
            this.voteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.voteBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voteBox.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(174)))));
            this.voteBox.FormattingEnabled = true;
            this.voteBox.Location = new System.Drawing.Point(191, 410);
            this.voteBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.voteBox.Name = "voteBox";
            this.voteBox.Size = new System.Drawing.Size(265, 31);
            this.voteBox.TabIndex = 11;
            this.voteBox.Text = "CHOOSE HERE";
            this.voteBox.SelectedIndexChanged += new System.EventHandler(this.voteBox_SelectedIndexChanged);
            // 
            // VOTEBTN
            // 
            this.VOTEBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(101)))), ((int)(((byte)(240)))));
            this.VOTEBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VOTEBTN.FlatAppearance.BorderSize = 0;
            this.VOTEBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VOTEBTN.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VOTEBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VOTEBTN.Location = new System.Drawing.Point(191, 486);
            this.VOTEBTN.Name = "VOTEBTN";
            this.VOTEBTN.Size = new System.Drawing.Size(265, 28);
            this.VOTEBTN.TabIndex = 12;
            this.VOTEBTN.Text = "VOTE";
            this.VOTEBTN.UseVisualStyleBackColor = false;
            this.VOTEBTN.Click += new System.EventHandler(this.VOTEBTN_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(262, 108);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(126, 37);
            this.welcomeLabel.TabIndex = 13;
            this.welcomeLabel.Text = "PRESIDENT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOGIN_FORM_PRESENTATION.Properties.Resources.loadingScreen;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CD1
            // 
            this.CD1.Image = ((System.Drawing.Image)(resources.GetObject("CD1.Image")));
            this.CD1.Location = new System.Drawing.Point(213, 165);
            this.CD1.Name = "CD1";
            this.CD1.Size = new System.Drawing.Size(226, 224);
            this.CD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CD1.TabIndex = 37;
            this.CD1.TabStop = false;
            // 
            // CD2
            // 
            this.CD2.Image = ((System.Drawing.Image)(resources.GetObject("CD2.Image")));
            this.CD2.Location = new System.Drawing.Point(213, 165);
            this.CD2.Name = "CD2";
            this.CD2.Size = new System.Drawing.Size(226, 224);
            this.CD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CD2.TabIndex = 38;
            this.CD2.TabStop = false;
            // 
            // CD3
            // 
            this.CD3.Image = ((System.Drawing.Image)(resources.GetObject("CD3.Image")));
            this.CD3.Location = new System.Drawing.Point(213, 165);
            this.CD3.Name = "CD3";
            this.CD3.Size = new System.Drawing.Size(226, 224);
            this.CD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CD3.TabIndex = 39;
            this.CD3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(213, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 224);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // Voting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(654, 578);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CD3);
            this.Controls.Add(this.CD2);
            this.Controls.Add(this.CD1);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.VOTEBTN);
            this.Controls.Add(this.voteBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Voting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voting";
            this.Load += new System.EventHandler(this.Voting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox voteBox;
        private System.Windows.Forms.Button VOTEBTN;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox CD1;
        private System.Windows.Forms.PictureBox CD2;
        private System.Windows.Forms.PictureBox CD3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}