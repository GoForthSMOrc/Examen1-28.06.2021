namespace BestKADR
{
    partial class MainMenu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.сolumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FindButton = new System.Windows.Forms.Button();
            this.fioBox = new System.Windows.Forms.TextBox();
            this.AddNewRecordWinButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateListButton = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.OutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewUserWinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.сolumnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(680, 425);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // сolumnHeader1
            // 
            this.сolumnHeader1.Text = "№";
            this.сolumnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Телефон";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "email";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Био";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Пол";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Образование";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Позиция";
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(783, 103);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(274, 42);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "Поиск";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // fioBox
            // 
            this.fioBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioBox.Location = new System.Drawing.Point(698, 28);
            this.fioBox.Name = "fioBox";
            this.fioBox.Size = new System.Drawing.Size(422, 41);
            this.fioBox.TabIndex = 2;
            // 
            // AddNewRecordWinButton
            // 
            this.AddNewRecordWinButton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewRecordWinButton.Location = new System.Drawing.Point(698, 151);
            this.AddNewRecordWinButton.Name = "AddNewRecordWinButton";
            this.AddNewRecordWinButton.Size = new System.Drawing.Size(422, 42);
            this.AddNewRecordWinButton.TabIndex = 3;
            this.AddNewRecordWinButton.Text = "Добавить новую запись";
            this.AddNewRecordWinButton.UseVisualStyleBackColor = true;
            this.AddNewRecordWinButton.Click += new System.EventHandler(this.AddNewRecordWinButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(899, 247);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(231, 42);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить запись";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateListButton
            // 
            this.UpdateListButton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateListButton.Location = new System.Drawing.Point(698, 199);
            this.UpdateListButton.Name = "UpdateListButton";
            this.UpdateListButton.Size = new System.Drawing.Size(422, 42);
            this.UpdateListButton.TabIndex = 5;
            this.UpdateListButton.Text = "Обновить список";
            this.UpdateListButton.UseVisualStyleBackColor = true;
            this.UpdateListButton.Click += new System.EventHandler(this.UpdateListButton_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBox.Location = new System.Drawing.Point(708, 247);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(185, 41);
            this.deleteBox.TabIndex = 6;
            // 
            // OutButton
            // 
            this.OutButton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutButton.Location = new System.Drawing.Point(783, 395);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(274, 42);
            this.OutButton.TabIndex = 7;
            this.OutButton.Text = "Выйти";
            this.OutButton.UseVisualStyleBackColor = true;
            this.OutButton.Click += new System.EventHandler(this.OutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "*Введите Фамилию Имя Отчество для поиска*";
            // 
            // NewUserWinButton
            // 
            this.NewUserWinButton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewUserWinButton.Location = new System.Drawing.Point(698, 295);
            this.NewUserWinButton.Name = "NewUserWinButton";
            this.NewUserWinButton.Size = new System.Drawing.Size(422, 42);
            this.NewUserWinButton.TabIndex = 9;
            this.NewUserWinButton.Text = "Добавить нового пользователя";
            this.NewUserWinButton.UseVisualStyleBackColor = true;
            this.NewUserWinButton.Click += new System.EventHandler(this.NewUserWinButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 457);
            this.Controls.Add(this.NewUserWinButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutButton);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.UpdateListButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddNewRecordWinButton);
            this.Controls.Add(this.fioBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.listView1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader сolumnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox fioBox;
        private System.Windows.Forms.Button AddNewRecordWinButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateListButton;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewUserWinButton;
    }
}