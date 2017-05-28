namespace Stepovyi_IS_51_Neruhomist
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ListObjects = new System.Windows.Forms.Button();
            this.ListClient = new System.Windows.Forms.Button();
            this.AuthorInfo = new System.Windows.Forms.Button();
            this.ProgInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListObjects
            // 
            this.ListObjects.Location = new System.Drawing.Point(63, 71);
            this.ListObjects.Name = "ListObjects";
            this.ListObjects.Size = new System.Drawing.Size(108, 50);
            this.ListObjects.TabIndex = 0;
            this.ListObjects.Text = "Переглянути список доступних квартир";
            this.ListObjects.UseVisualStyleBackColor = true;
            this.ListObjects.Click += new System.EventHandler(this.ListObjects_Click);
            // 
            // ListClient
            // 
            this.ListClient.Location = new System.Drawing.Point(197, 71);
            this.ListClient.Name = "ListClient";
            this.ListClient.Size = new System.Drawing.Size(119, 50);
            this.ListClient.TabIndex = 1;
            this.ListClient.Text = "Переглянути список задоволених клієнтів";
            this.ListClient.UseVisualStyleBackColor = true;
            this.ListClient.Click += new System.EventHandler(this.ListClient_Click);
            // 
            // AuthorInfo
            // 
            this.AuthorInfo.Location = new System.Drawing.Point(349, 71);
            this.AuthorInfo.Name = "AuthorInfo";
            this.AuthorInfo.Size = new System.Drawing.Size(97, 23);
            this.AuthorInfo.TabIndex = 2;
            this.AuthorInfo.Text = "Автор";
            this.AuthorInfo.UseVisualStyleBackColor = true;
            this.AuthorInfo.Click += new System.EventHandler(this.AuthorInfo_Click);
            // 
            // ProgInfo
            // 
            this.ProgInfo.Location = new System.Drawing.Point(349, 98);
            this.ProgInfo.Name = "ProgInfo";
            this.ProgInfo.Size = new System.Drawing.Size(97, 23);
            this.ProgInfo.TabIndex = 3;
            this.ProgInfo.Text = "Про программу";
            this.ProgInfo.UseVisualStyleBackColor = true;
            this.ProgInfo.Click += new System.EventHandler(this.ProgInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(194, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вітаємо в Комфорт-тауні!";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgInfo);
            this.Controls.Add(this.AuthorInfo);
            this.Controls.Add(this.ListClient);
            this.Controls.Add(this.ListObjects);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListObjects;
        private System.Windows.Forms.Button ListClient;
        private System.Windows.Forms.Button AuthorInfo;
        private System.Windows.Forms.Button ProgInfo;
        private System.Windows.Forms.Label label1;
    }
}