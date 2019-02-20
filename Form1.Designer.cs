namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.strAdd = new System.Windows.Forms.Button();
            this.FName = new System.Windows.Forms.TextBox();
            this.SName = new System.Windows.Forms.TextBox();
            this.Group = new System.Windows.Forms.TextBox();
            this.Patron = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EditBookListbtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.SaveLikebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BookEdit = new System.Windows.Forms.Button();
            this.StudentTab = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.bookAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete15.png");
            this.imageList1.Images.SetKeyName(1, "Add.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"XML файл\"|*.xml";
            this.openFileDialog1.Title = "Укажите список книг";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"XML файл\"|*.xml";
            this.saveFileDialog1.InitialDirectory = "\\";
            this.saveFileDialog1.SupportMultiDottedExtensions = true;
            this.saveFileDialog1.Title = "Сохранить карточку";
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.Controls.Add(this.strAdd);
            this.Panel1.Controls.Add(this.FName);
            this.Panel1.Controls.Add(this.SName);
            this.Panel1.Controls.Add(this.Group);
            this.Panel1.Controls.Add(this.Patron);
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Controls.Add(this.label9);
            this.Panel1.Controls.Add(this.label8);
            this.Panel1.Controls.Add(this.label7);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.label6);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.CreateBtn);
            this.Panel1.Controls.Add(this.OpenBtn);
            this.Panel1.Location = new System.Drawing.Point(0, 24);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(515, 472);
            this.Panel1.TabIndex = 0;
            // 
            // strAdd
            // 
            this.strAdd.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.strAdd.FlatAppearance.BorderSize = 3;
            this.strAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.strAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.strAdd.ImageIndex = 1;
            this.strAdd.ImageList = this.imageList1;
            this.strAdd.Location = new System.Drawing.Point(30, 319);
            this.strAdd.Name = "strAdd";
            this.strAdd.Size = new System.Drawing.Size(25, 25);
            this.strAdd.TabIndex = 87;
            this.strAdd.UseVisualStyleBackColor = true;
            this.strAdd.Visible = false;
            this.strAdd.Click += new System.EventHandler(this.strAdd_Click);
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(98, 63);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(191, 20);
            this.FName.TabIndex = 85;
            this.FName.Visible = false;
            this.FName.TextChanged += new System.EventHandler(this.FIO_TextChanged);
            // 
            // SName
            // 
            this.SName.Location = new System.Drawing.Point(98, 97);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(191, 20);
            this.SName.TabIndex = 84;
            this.SName.Visible = false;
            this.SName.TextChanged += new System.EventHandler(this.FIO_TextChanged);
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(98, 164);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(80, 20);
            this.Group.TabIndex = 83;
            this.Group.Visible = false;
            this.Group.TextChanged += new System.EventHandler(this.Group_TextChanged);
            // 
            // Patron
            // 
            this.Patron.Location = new System.Drawing.Point(98, 131);
            this.Patron.Name = "Patron";
            this.Patron.Size = new System.Drawing.Size(191, 20);
            this.Patron.TabIndex = 86;
            this.Patron.Visible = false;
            this.Patron.TextChanged += new System.EventHandler(this.FIO_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(32, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "Группа";
            this.label5.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(354, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 81;
            this.label9.Text = "Дата выдачи";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(226, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 80;
            this.label8.Text = "Название";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(68, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 79;
            this.label7.Text = "Автор";
            this.label7.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(28, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 78;
            this.label4.Text = "Отчество";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(32, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 77;
            this.label3.Text = "Фамилия";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(47, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "Имя";
            this.label2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(29, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 75;
            this.label6.Text = "Выданные книги";
            this.label6.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 19);
            this.label1.TabIndex = 74;
            this.label1.Text = "Информация о студенте";
            this.label1.Visible = false;
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CreateBtn.FlatAppearance.BorderSize = 0;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateBtn.Location = new System.Drawing.Point(194, 233);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(265, 65);
            this.CreateBtn.TabIndex = 73;
            this.CreateBtn.Text = "Создать карточку";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenBtn.FlatAppearance.BorderSize = 0;
            this.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenBtn.Location = new System.Drawing.Point(194, 103);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(265, 65);
            this.OpenBtn.TabIndex = 72;
            this.OpenBtn.Text = "Открыть карточку";
            this.OpenBtn.UseVisualStyleBackColor = false;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.label11);
            this.Panel2.Controls.Add(this.label10);
            this.Panel2.Controls.Add(this.EditBookListbtn);
            this.Panel2.Controls.Add(this.Closebtn);
            this.Panel2.Controls.Add(this.SaveLikebtn);
            this.Panel2.Controls.Add(this.Savebtn);
            this.Panel2.Location = new System.Drawing.Point(518, 25);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(125, 477);
            this.Panel2.TabIndex = 1;
            this.Panel2.Visible = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(3, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 33);
            this.label11.TabIndex = 97;
            this.label11.Text = "Список книг не выбран";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(8, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 15);
            this.label10.TabIndex = 98;
            this.label10.Text = "Список книг:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditBookListbtn
            // 
            this.EditBookListbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.EditBookListbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBookListbtn.Location = new System.Drawing.Point(14, 443);
            this.EditBookListbtn.Name = "EditBookListbtn";
            this.EditBookListbtn.Size = new System.Drawing.Size(100, 22);
            this.EditBookListbtn.TabIndex = 96;
            this.EditBookListbtn.Tag = "";
            this.EditBookListbtn.Text = "Изменить";
            this.EditBookListbtn.UseVisualStyleBackColor = false;
            this.EditBookListbtn.Click += new System.EventHandler(this.EditBookListbtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Closebtn.Location = new System.Drawing.Point(14, 106);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(100, 31);
            this.Closebtn.TabIndex = 94;
            this.Closebtn.Text = "Закрыть";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // SaveLikebtn
            // 
            this.SaveLikebtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.SaveLikebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveLikebtn.Location = new System.Drawing.Point(14, 59);
            this.SaveLikebtn.Name = "SaveLikebtn";
            this.SaveLikebtn.Size = new System.Drawing.Size(100, 31);
            this.SaveLikebtn.TabIndex = 91;
            this.SaveLikebtn.Text = "Сохранить как...";
            this.SaveLikebtn.UseVisualStyleBackColor = false;
            this.SaveLikebtn.Click += new System.EventHandler(this.SaveLikebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Savebtn.Location = new System.Drawing.Point(14, 13);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(100, 31);
            this.Savebtn.TabIndex = 90;
            this.Savebtn.Text = "Сохранить";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Controls.Add(this.BookEdit);
            this.panel4.Controls.Add(this.StudentTab);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(643, 23);
            this.panel4.TabIndex = 2;
            // 
            // BookEdit
            // 
            this.BookEdit.BackColor = System.Drawing.Color.LightGray;
            this.BookEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookEdit.Location = new System.Drawing.Point(123, 0);
            this.BookEdit.Name = "BookEdit";
            this.BookEdit.Size = new System.Drawing.Size(123, 23);
            this.BookEdit.TabIndex = 3;
            this.BookEdit.Text = "Список книг";
            this.BookEdit.UseVisualStyleBackColor = false;
            this.BookEdit.Click += new System.EventHandler(this.BookEditTab_Click);
            // 
            // StudentTab
            // 
            this.StudentTab.BackColor = System.Drawing.Color.LightGray;
            this.StudentTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentTab.Location = new System.Drawing.Point(0, 0);
            this.StudentTab.Name = "StudentTab";
            this.StudentTab.Size = new System.Drawing.Size(123, 23);
            this.StudentTab.TabIndex = 4;
            this.StudentTab.Text = "Карточка студента";
            this.StudentTab.UseVisualStyleBackColor = false;
            this.StudentTab.Click += new System.EventHandler(this.StudentTab_Click);
            // 
            // Panel3
            // 
            this.Panel3.AutoScroll = true;
            this.Panel3.Controls.Add(this.bookAdd);
            this.Panel3.Controls.Add(this.label12);
            this.Panel3.Controls.Add(this.label13);
            this.Panel3.Controls.Add(this.label14);
            this.Panel3.Location = new System.Drawing.Point(2, 24);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(512, 478);
            this.Panel3.TabIndex = 89;
            this.Panel3.Visible = false;
            // 
            // bookAdd
            // 
            this.bookAdd.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bookAdd.FlatAppearance.BorderSize = 3;
            this.bookAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bookAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bookAdd.ImageIndex = 1;
            this.bookAdd.ImageList = this.imageList1;
            this.bookAdd.Location = new System.Drawing.Point(30, 90);
            this.bookAdd.Name = "bookAdd";
            this.bookAdd.Size = new System.Drawing.Size(25, 25);
            this.bookAdd.TabIndex = 91;
            this.bookAdd.UseVisualStyleBackColor = true;
            this.bookAdd.Click += new System.EventHandler(this.bookAdd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.label12.ForeColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(225, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 90;
            this.label12.Text = "Название";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.Info;
            this.label13.Location = new System.Drawing.Point(73, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 89;
            this.label13.Text = "Автор";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(29, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 19);
            this.label14.TabIndex = 88;
            this.label14.Text = "Список книг";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(644, 502);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button strAdd;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox SName;
        private System.Windows.Forms.TextBox Group;
        private System.Windows.Forms.TextBox Patron;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button EditBookListbtn;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button SaveLikebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BookEdit;
        private System.Windows.Forms.Button StudentTab;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Button bookAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

