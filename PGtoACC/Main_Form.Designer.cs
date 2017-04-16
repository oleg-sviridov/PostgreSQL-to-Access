namespace WindowsFormsApplication1
{
    partial class Main_Form
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
            this.Work_Macro = new System.Windows.Forms.Button();
            this.DataBase_Name = new System.Windows.Forms.TextBox();
            this.CheckedListBox_Tables = new System.Windows.Forms.CheckedListBox();
            this.TextBox_Scheme = new System.Windows.Forms.TextBox();
            this.ListBox_Schemes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Port = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pwd = new System.Windows.Forms.TextBox();
            this.Uid = new System.Windows.Forms.TextBox();
            this.Server = new System.Windows.Forms.TextBox();
            this.Verify = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Button_Delete_All = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Обзор = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Work_Macro
            // 
            this.Work_Macro.Location = new System.Drawing.Point(309, 386);
            this.Work_Macro.Name = "Work_Macro";
            this.Work_Macro.Size = new System.Drawing.Size(87, 40);
            this.Work_Macro.TabIndex = 0;
            this.Work_Macro.Text = "Экспорт в Access Macro";
            this.Work_Macro.UseVisualStyleBackColor = true;
            this.Work_Macro.Click += new System.EventHandler(this.Work_Macro_Click);
            // 
            // DataBase_Name
            // 
            this.DataBase_Name.Location = new System.Drawing.Point(249, 270);
            this.DataBase_Name.Name = "DataBase_Name";
            this.DataBase_Name.Size = new System.Drawing.Size(177, 20);
            this.DataBase_Name.TabIndex = 1;
            // 
            // CheckedListBox_Tables
            // 
            this.CheckedListBox_Tables.FormattingEnabled = true;
            this.CheckedListBox_Tables.Items.AddRange(new object[] {
            "Abonents",
            "Blocks",
            "Bst",
            "Connectors",
            "Eascycle",
            "Fblocks",
            "Fbparameters",
            "Infbport",
            "Mechanics",
            "Modules",
            "Outfbport",
            "Pageleft",
            "Pageright",
            "Tabqrel",
            "Tabzrel",
            "Pages",
            "Functionpages"});
            this.CheckedListBox_Tables.Location = new System.Drawing.Point(284, 37);
            this.CheckedListBox_Tables.Name = "CheckedListBox_Tables";
            this.CheckedListBox_Tables.Size = new System.Drawing.Size(142, 184);
            this.CheckedListBox_Tables.TabIndex = 2;
            // 
            // TextBox_Scheme
            // 
            this.TextBox_Scheme.Location = new System.Drawing.Point(23, 12);
            this.TextBox_Scheme.Name = "TextBox_Scheme";
            this.TextBox_Scheme.Size = new System.Drawing.Size(142, 20);
            this.TextBox_Scheme.TabIndex = 3;
            this.TextBox_Scheme.Text = "Введите название схемы";
            // 
            // ListBox_Schemes
            // 
            this.ListBox_Schemes.FormattingEnabled = true;
            this.ListBox_Schemes.Location = new System.Drawing.Point(23, 37);
            this.ListBox_Schemes.Name = "ListBox_Schemes";
            this.ListBox_Schemes.Size = new System.Drawing.Size(137, 186);
            this.ListBox_Schemes.TabIndex = 4;
            this.ListBox_Schemes.SelectedIndexChanged += new System.EventHandler(this.ListBox_Schemes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите файл базы данных ЗЗИ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP-адрес или \'localhost\'";
            // 
            // Label_Port
            // 
            this.Label_Port.AutoSize = true;
            this.Label_Port.Location = new System.Drawing.Point(29, 331);
            this.Label_Port.Name = "Label_Port";
            this.Label_Port.Size = new System.Drawing.Size(32, 13);
            this.Label_Port.TabIndex = 37;
            this.Label_Port.Text = "Порт";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(155, 331);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(75, 20);
            this.Port.TabIndex = 36;
            this.Port.Text = "5439";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(29, 386);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(45, 13);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Логин";
            // 
            // Pwd
            // 
            this.Pwd.Location = new System.Drawing.Point(155, 383);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(75, 20);
            this.Pwd.TabIndex = 33;
            this.Pwd.Text = "postgres";
            // 
            // Uid
            // 
            this.Uid.Location = new System.Drawing.Point(155, 357);
            this.Uid.Name = "Uid";
            this.Uid.Size = new System.Drawing.Size(75, 20);
            this.Uid.TabIndex = 32;
            this.Uid.Text = "postgres";
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(155, 305);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(75, 20);
            this.Server.TabIndex = 31;
            this.Server.Text = "localhost";
            // 
            // Verify
            // 
            this.Verify.Location = new System.Drawing.Point(420, 386);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(87, 40);
            this.Verify.TabIndex = 38;
            this.Verify.Text = "Проведение верификации";
            this.Verify.UseVisualStyleBackColor = true;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(166, 164);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(85, 23);
            this.Import.TabIndex = 43;
            this.Import.Text = "Импорт";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(166, 133);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(85, 23);
            this.Export.TabIndex = 42;
            this.Export.Text = "Экспорт";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Button_Delete_All
            // 
            this.Button_Delete_All.Location = new System.Drawing.Point(166, 102);
            this.Button_Delete_All.Name = "Button_Delete_All";
            this.Button_Delete_All.Size = new System.Drawing.Size(85, 23);
            this.Button_Delete_All.TabIndex = 41;
            this.Button_Delete_All.Text = "Удалить все";
            this.Button_Delete_All.UseVisualStyleBackColor = true;
            this.Button_Delete_All.Click += new System.EventHandler(this.Button_Delete_All_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Enabled = false;
            this.Button_Delete.Location = new System.Drawing.Point(166, 71);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(85, 23);
            this.Button_Delete.TabIndex = 40;
            this.Button_Delete.Text = "Удалить";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(166, 40);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(85, 23);
            this.Button_Add.TabIndex = 39;
            this.Button_Add.Text = "Добавить";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Обзор
            // 
            this.Обзор.Location = new System.Drawing.Point(432, 269);
            this.Обзор.Name = "Обзор";
            this.Обзор.Size = new System.Drawing.Size(75, 21);
            this.Обзор.TabIndex = 44;
            this.Обзор.Text = "Обзор";
            this.Обзор.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Выберите таблицы из списка для обработки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 436);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Обзор);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Button_Delete_All);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Verify);
            this.Controls.Add(this.Label_Port);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.Uid);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox_Schemes);
            this.Controls.Add(this.TextBox_Scheme);
            this.Controls.Add(this.CheckedListBox_Tables);
            this.Controls.Add(this.DataBase_Name);
            this.Controls.Add(this.Work_Macro);
            this.Name = "Form1";
            this.Text = "1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Work_Macro;
        private System.Windows.Forms.TextBox DataBase_Name;
        private System.Windows.Forms.CheckedListBox CheckedListBox_Tables;
        private System.Windows.Forms.TextBox TextBox_Scheme;
        private System.Windows.Forms.ListBox ListBox_Schemes;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Label_Port;
        internal System.Windows.Forms.TextBox Port;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox Pwd;
        internal System.Windows.Forms.TextBox Uid;
        internal System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.Button Verify;
        internal System.Windows.Forms.Button Import;
        internal System.Windows.Forms.Button Export;
        internal System.Windows.Forms.Button Button_Delete_All;
        internal System.Windows.Forms.Button Button_Delete;
        internal System.Windows.Forms.Button Button_Add;
        internal System.Windows.Forms.Button Обзор;
        internal System.Windows.Forms.Label label5;
    }
}

