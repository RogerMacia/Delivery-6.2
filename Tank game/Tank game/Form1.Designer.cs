﻿namespace Tank_game
{
    partial class Form1
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
            this.Send_Btn = new System.Windows.Forms.Button();
            this.Peticion_txtBox = new System.Windows.Forms.TextBox();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.Disconnect_btn = new System.Windows.Forms.Button();
            this.Services_btn = new System.Windows.Forms.Button();
            this.Services_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Send_Btn
            // 
            this.Send_Btn.Location = new System.Drawing.Point(79, 108);
            this.Send_Btn.Name = "Send_Btn";
            this.Send_Btn.Size = new System.Drawing.Size(75, 23);
            this.Send_Btn.TabIndex = 0;
            this.Send_Btn.Text = "Send";
            this.Send_Btn.UseVisualStyleBackColor = true;
            this.Send_Btn.Click += new System.EventHandler(this.Send_Btn_Click);
            // 
            // Peticion_txtBox
            // 
            this.Peticion_txtBox.Location = new System.Drawing.Point(68, 56);
            this.Peticion_txtBox.Name = "Peticion_txtBox";
            this.Peticion_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Peticion_txtBox.TabIndex = 1;
            // 
            // Connect_btn
            // 
            this.Connect_btn.Location = new System.Drawing.Point(89, 10);
            this.Connect_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(56, 19);
            this.Connect_btn.TabIndex = 2;
            this.Connect_btn.Text = "Connect";
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // Disconnect_btn
            // 
            this.Disconnect_btn.Location = new System.Drawing.Point(79, 174);
            this.Disconnect_btn.Name = "Disconnect_btn";
            this.Disconnect_btn.Size = new System.Drawing.Size(75, 23);
            this.Disconnect_btn.TabIndex = 3;
            this.Disconnect_btn.Text = "Disconnect";
            this.Disconnect_btn.UseVisualStyleBackColor = true;
            this.Disconnect_btn.Click += new System.EventHandler(this.Disconnect_btn_Click);
            // 
            // Services_btn
            // 
            this.Services_btn.Location = new System.Drawing.Point(257, 48);
            this.Services_btn.Name = "Services_btn";
            this.Services_btn.Size = new System.Drawing.Size(92, 34);
            this.Services_btn.TabIndex = 4;
            this.Services_btn.Text = "Show requested services";
            this.Services_btn.UseVisualStyleBackColor = true;
            this.Services_btn.Click += new System.EventHandler(this.Services_btn_Click);
            // 
            // Services_lbl
            // 
            this.Services_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Services_lbl.Location = new System.Drawing.Point(257, 108);
            this.Services_lbl.Name = "Services_lbl";
            this.Services_lbl.Size = new System.Drawing.Size(92, 23);
            this.Services_lbl.TabIndex = 5;
            this.Services_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Services_lbl);
            this.Controls.Add(this.Services_btn);
            this.Controls.Add(this.Disconnect_btn);
            this.Controls.Add(this.Connect_btn);
            this.Controls.Add(this.Peticion_txtBox);
            this.Controls.Add(this.Send_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_Btn;
        private System.Windows.Forms.TextBox Peticion_txtBox;
        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.Button Disconnect_btn;
        private System.Windows.Forms.Button Services_btn;
        private System.Windows.Forms.Label Services_lbl;
    }
}

