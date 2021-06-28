namespace BestKADR
{
    partial class AddNewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.newlogBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newpassBox = new System.Windows.Forms.TextBox();
            this.AddNewUserButton = new System.Windows.Forms.Button();
            this.ToMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // newlogBox
            // 
            this.newlogBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newlogBox.Location = new System.Drawing.Point(172, 112);
            this.newlogBox.Name = "newlogBox";
            this.newlogBox.Size = new System.Drawing.Size(279, 41);
            this.newlogBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // newpassBox
            // 
            this.newpassBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newpassBox.Location = new System.Drawing.Point(172, 173);
            this.newpassBox.Name = "newpassBox";
            this.newpassBox.Size = new System.Drawing.Size(279, 41);
            this.newpassBox.TabIndex = 4;
            // 
            // AddNewUserButton
            // 
            this.AddNewUserButton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewUserButton.Location = new System.Drawing.Point(275, 388);
            this.AddNewUserButton.Name = "AddNewUserButton";
            this.AddNewUserButton.Size = new System.Drawing.Size(176, 50);
            this.AddNewUserButton.TabIndex = 5;
            this.AddNewUserButton.Text = "Добавить";
            this.AddNewUserButton.UseVisualStyleBackColor = true;
            this.AddNewUserButton.Click += new System.EventHandler(this.AddNewUserButton_Click);
            // 
            // ToMainMenuButton
            // 
            this.ToMainMenuButton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainMenuButton.Location = new System.Drawing.Point(12, 388);
            this.ToMainMenuButton.Name = "ToMainMenuButton";
            this.ToMainMenuButton.Size = new System.Drawing.Size(220, 50);
            this.ToMainMenuButton.TabIndex = 6;
            this.ToMainMenuButton.Text = "Главное меню";
            this.ToMainMenuButton.UseVisualStyleBackColor = true;
            this.ToMainMenuButton.Click += new System.EventHandler(this.ToMainMenuButton_Click);
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.ToMainMenuButton);
            this.Controls.Add(this.AddNewUserButton);
            this.Controls.Add(this.newpassBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newlogBox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewUser";
            this.Text = "AddNewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newlogBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newpassBox;
        private System.Windows.Forms.Button AddNewUserButton;
        private System.Windows.Forms.Button ToMainMenuButton;
    }
}