using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Library
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        List<ComboBox> combobox = new List<ComboBox>();
        List<TextBox> tb = new List<TextBox>();
        List<TextBox> tb2 = new List<TextBox>();
        List<Button> btn = new List<Button>();
        List<Button> btn2 = new List<Button>();
        List<string> author = new List<string>();
        List<string> bName = new List<string>();
        SortedDictionary<string, List<string>> books = new SortedDictionary<string, List<string>>();
        bool savestflag = true;
        bool savebookflag = true;


        public Form1()
        {
            InitializeComponent();
        }

        void addLendBook(string author, string name, string data)
        {
            Size TextBoxS = new Size(128, 120);
            Size TextBoxDateS = new Size(95, 20);
            Size btnS = new Size(25, 25);

                combobox.Add(new ComboBox());
                combobox[combobox.Count - 1].Size = TextBoxS;
                combobox[combobox.Count - 1].Location = new Point(30, strAdd.Location.Y);
                combobox[combobox.Count - 1].Text = author;
                combobox[combobox.Count - 1].Sorted = true;
                combobox[combobox.Count - 1].TextChanged += new System.EventHandler(BooksTextChange);
                combobox[combobox.Count - 1].Tag = "author";
                AddItem(combobox[combobox.Count - 1]);
                Panel1.Controls.Add(combobox[combobox.Count - 1]);

                combobox.Add(new ComboBox());
                combobox[combobox.Count - 1].Size = TextBoxS;
                combobox[combobox.Count - 1].Location = new Point(190, strAdd.Location.Y);
                combobox[combobox.Count - 1].Text = name;
                combobox[combobox.Count - 1].Sorted = true;
                combobox[combobox.Count - 1].TextChanged += new System.EventHandler(BooksTextChange);
                combobox[combobox.Count - 1].Tag = "books";
                Panel1.Controls.Add(combobox[combobox.Count - 1]);

                tb.Add(new TextBox());
                tb[tb.Count - 1].Size = TextBoxDateS;
                tb[tb.Count - 1].Location = new Point(350, strAdd.Location.Y);
                tb[tb.Count - 1].Text = data;
                tb[tb.Count - 1].ReadOnly = true;
                Panel1.Controls.Add(tb[tb.Count - 1]);

            btn.Add(new Button());
            btn[btn.Count - 1].Size = btnS;
            btn[btn.Count - 1].Location = new Point(456, strAdd.Location.Y);
            btn[btn.Count - 1].ImageList = imageList1;
            btn[btn.Count - 1].ImageIndex = 0;
            btn[btn.Count - 1].UseVisualStyleBackColor = true;
            btn[btn.Count - 1].Click += new System.EventHandler(strDell_Click);
            Panel1.Controls.Add(btn[btn.Count - 1]);

            strAdd.Top += 35;
        }
        void addBookInList(string author, string name)
        {
            Size TextBoxS = new Size(128, 120);
            Size TextBoxDateS = new Size(95, 20);
            Size btnS = new Size(25, 25);

            tb2.Add(new TextBox());
            tb2[tb2.Count - 1].Size = TextBoxS;
            tb2[tb2.Count - 1].Location = new Point(30, bookAdd.Location.Y);
            tb2[tb2.Count - 1].Text = author;

            tb2.Add(new TextBox());
            tb2[tb2.Count - 1].Size = TextBoxS;
            tb2[tb2.Count - 1].Location = new Point(190, bookAdd.Location.Y);
            tb2[tb2.Count - 1].Text = name;

            Panel3.Controls.Add(tb2[tb2.Count - 1]);
            Panel3.Controls.Add(tb2[tb2.Count - 2]);

            btn2.Add(new Button());
            btn2[btn2.Count - 1].Size = btnS;
            btn2[btn2.Count - 1].Location = new Point(340, bookAdd.Location.Y);
            btn2[btn2.Count - 1].ImageList = imageList1;
            btn2[btn2.Count - 1].ImageIndex = 0;
            btn2[btn2.Count - 1].UseVisualStyleBackColor = true;
            btn2[btn2.Count - 1].Click += new System.EventHandler(strDell_Click);
            Panel3.Controls.Add(btn2[btn2.Count - 1]);

            bookAdd.Top += 35;
        }
        void strDell_Click(object sender, EventArgs e)
        {
            int n;
            if (Panel1.Visible)
            {
                n = btn.IndexOf((Button)sender);

                btn[n].Click -= new System.EventHandler(strDell_Click);
                Panel1.Controls.Remove(btn[n]);
                Panel1.Controls.Remove(combobox[n * 2]);
                Panel1.Controls.Remove(combobox[n * 2 + 1]);
                Panel1.Controls.Remove(tb[n]);

                for (int i = n + 1; i < btn.Count; i++)
                {
                    btn[i].Top -= 35;
                    combobox[i * 2].Top -= 35;
                    combobox[i * 2 + 1].Top -= 35;
                    tb[i].Top -= 35;
                }
                strAdd.Top -= 35;

                btn.RemoveAt(n);
                combobox.RemoveRange(n * 2, 2);
                tb.RemoveAt(n);
                savestflag = false;
            }
            else
            {
                n = btn2.IndexOf((Button)sender);

                btn2[n].Click -= new System.EventHandler(strDell_Click);
                Panel3.Controls.Remove(btn2[n]);
                Panel3.Controls.Remove(tb2[n * 2]);
                Panel3.Controls.Remove(tb2[n * 2 + 1]);

                for (int i = n + 1; i < btn2.Count; i++)
                {
                    btn2[i].Top -= 35;
                    tb2[i * 2].Top -= 35;
                    tb2[i * 2 + 1].Top -= 35;
                }
                bookAdd.Top -= 35;

                btn2.RemoveAt(n);
                tb2.RemoveRange(n * 2, 2);
                savebookflag = false;
            }
        }

        void compVisible(bool flag)
        {
            foreach (Control c in Panel1.Controls)
            {
                if (c.Name != "OpenBtn" && c.Name != "CreateBtn")
                    c.Visible = flag;
                else c.Visible = !flag;
            }
            Panel2.Visible = flag;

            if (flag)
                Panel2.BackColor = Color.FromName("InactiveCaption");
            else Panel2.BackColor = Color.FromName("InactiveCaptionText");
        }

        void SaveFile(string path)
        {
            try
            {
            XmlDocument doc = new XmlDocument();
            doc.CreateXmlDeclaration("1.0", "utf-8", null);

            XmlElement student = doc.CreateElement("student");
            doc.AppendChild(student);

                if (FName.Text == "") throw new Exception("Пустое поле \"Имя\"");
                if (SName.Text == "") throw new Exception("Пустое поле \"Фамилия\"");
                if (Patron.Text == "") throw new Exception("Пустое поле \"Отчество\"");
                if (Group.Text == "") throw new Exception("Пустое поле \"Группа\"");

            XmlAttribute fName = doc.CreateAttribute("fName");
            XmlAttribute sName = doc.CreateAttribute("sName");
            XmlAttribute patronymic = doc.CreateAttribute("patronymic");
            XmlAttribute group = doc.CreateAttribute("group");
            student.Attributes.Append(fName);
            student.Attributes.Append(sName);
            student.Attributes.Append(patronymic);
            student.Attributes.Append(group);
            fName.Value = FName.Text;
            sName.Value = SName.Text;
            patronymic.Value = Patron.Text;
            group.Value = Group.Text;
                for (int i = 0; i < btn.Count; i++)
                {
                    if (combobox[i * 2].Text == "" || combobox[i * 2 + 1].Text == "") throw new Exception("Пустое поле в разделе \"Выданные книги\" на строке №"+Convert.ToString(i));
                    XmlElement book = doc.CreateElement("book");
                    student.AppendChild(book);

                    XmlElement bName = doc.CreateElement("bName");
                    XmlElement Author = doc.CreateElement("Author");
                    XmlElement date = doc.CreateElement("date");
                    bName.InnerText = combobox[i * 2].Text;
                    Author.InnerText = combobox[i * 2 + 1].Text;
                    date.InnerText = tb[i].Text;
                    book.AppendChild(bName);
                    book.AppendChild(Author);
                    book.AppendChild(date);
                }

                doc.Save(path);
                savestflag = true;
            }
            catch (Exception e)
            { MessageBox.Show(e.Message, "Ошибка сохранения файла", MessageBoxButtons.OK); }
        }
        void SaveBookList(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.CreateXmlDeclaration("1.0", "utf-8", null);

            XmlElement booklist = doc.CreateElement("bookslist");
            doc.AppendChild(booklist);

            try
            {
                if (tb2.Count==0) throw new Exception("Создайте хотя бы одну строку в списке");
                for (int i = 0; i < btn2.Count; i++)
                {
                    if (tb2[i * 2].Text == "" || tb2[i * 2 + 1].Text == "") throw new Exception("Пустое поле на строке №"+Convert.ToString(i+1));
                    XmlElement book = doc.CreateElement("book");
                    booklist.AppendChild(book);

                    XmlElement bName = doc.CreateElement("bName");
                    XmlElement aName = doc.CreateElement("aName");
                    bName.InnerText = tb2[i * 2].Text;
                    aName.InnerText = tb2[i * 2 + 1].Text;
                    book.AppendChild(bName);
                    book.AppendChild(aName);
                }

                doc.Save(path);
                savebookflag = true;
            }
            catch (Exception e)
            { MessageBox.Show(e.Message, "Ошибка сохранения файла", MessageBoxButtons.OK);}
        }
        private void strAdd_Click(object sender, EventArgs e)
        {
            addLendBook("","",System.DateTime.Now.ToString("d"));
            savestflag = false;
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Открыть карточку";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                string name, author, date;

                XmlDocument doc = new XmlDocument();
                try
                {
                    doc.Load(filepath);

                    FName.Text = doc.DocumentElement.Attributes[0].Value;
                    SName.Text = doc.DocumentElement.Attributes[1].Value;
                    Patron.Text = doc.DocumentElement.Attributes[2].Value;
                    Group.Text = doc.DocumentElement.Attributes[3].Value;

                    foreach (XmlNode xNode in doc.DocumentElement)
                    {
                        author = xNode["Author"].InnerText;
                        name = xNode["bName"].InnerText;
                        date = xNode["date"].InnerText;
                        addLendBook(author, name, date);
                    }

                    compVisible(true);

                    OpenBtn.Tag = filepath;
                }
                catch(Exception)
                {
                    MessageBox.Show("Файл повреждён или имеет некорректную структуру","Ошибка открытия файла",MessageBoxButtons.OK);
                }
            }
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            compVisible(true);
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            if (Panel1.Visible)
            {
                if (savestflag)
                {
                    compVisible(false);

                    foreach (Button b in btn)
                    {
                        Panel1.Controls.Remove(b);
                        strAdd.Top -= 35;
                    }
                    foreach (TextBox t in tb)
                    {
                        Panel1.Controls.Remove(t);
                    }
                    foreach (ComboBox c in combobox)
                    {
                        Panel1.Controls.Remove(c);
                    }

                    btn.Clear();
                    tb.Clear();
                    combobox.Clear();

                    FName.Text = "";
                    SName.Text = "";
                    Patron.Text = "";
                    openFileDialog1.FileName = "";
                    OpenBtn.Tag = "";
                }
                else
                {
                    DialogResult result = MessageBox.Show("Файл не был сохранён после изменений. Вы точно хотите закрыть файл?", "Предупреждение", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) { savestflag = true; Closebtn_Click(Closebtn, e); }
                }
            }
            else
            {
                if (savebookflag)
                {
                    foreach (Button b in btn2)
                    {
                        Panel3.Controls.Remove(b);
                        bookAdd.Top -= 35;
                    }
                    foreach (TextBox t in tb2)
                    {
                        Panel3.Controls.Remove(t);
                    }
                    btn2.Clear();
                    tb2.Clear();
                    EditBookListbtn.Tag = "";

                    label11.Text = "Список книг не выбран";
                    label11.ForeColor = Color.Red;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Файл не был сохранён после изменений. Вы точно хотите закрыть файл?", "Предупреждение", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) { savebookflag = true; Closebtn_Click(Closebtn, e); }
                }
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (Panel1.Visible)
                if (OpenBtn.Tag!=null)
                    SaveFile(OpenBtn.Tag.ToString());
                else
                    SaveLikebtn_Click(SaveLikebtn, e);

            else
                if (EditBookListbtn.Tag.ToString() != "")
                    SaveBookList(EditBookListbtn.Tag.ToString());
            else SaveLikebtn_Click(SaveLikebtn, e);
        }

        private void SaveLikebtn_Click(object sender, EventArgs e)
        {
            if (Panel1.Visible)
            {
                try
                {
                    if (FName.Text == "") throw new Exception("Пустое поле \"Имя\"");
                    if (SName.Text == "") throw new Exception("Пустое поле \"Фамилия\"");
                    if (Patron.Text == "") throw new Exception("Пустое поле \"Отчество\"");
                    if (Group.Text == "") throw new Exception("Пустое поле \"Группа\"");

                    saveFileDialog1.FileName = String.Format("{0} {1}.{2}. - {3}", SName.Text, FName.Text[0], Patron.Text[0], Group.Text);
                    saveFileDialog1.Title = "Сохранить карточку игрока";

                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        SaveFile(saveFileDialog1.FileName);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка сохранения файла", MessageBoxButtons.OK); }

            }
            else
            {
                saveFileDialog1.FileName = "booklist";
                saveFileDialog1.Title = "Сохранить список книг";

                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    SaveBookList(saveFileDialog1.FileName);
            }
        }

        private void Group_TextChanged(object sender, EventArgs e)
        {
            string str = Group.Text;
            int u;
            for (int i = 0; i < Group.TextLength; i++)
            {
                u = Convert.ToInt16(Group.Text[i]);

                if (i == 0 || i==4 || i==5)
                    if (u < 48 || u > 57) { str = str.Substring(0, i); break; }
                if (i == 1 || i==2)
                    if (u < 1040 || u > 1103) { str = str.Substring(0, i); break; }
                    else str = str.Substring(0, i)+Char.ToUpper(str[i])+str.Substring(i+1, str.Length-i-1);
                if (i == 3)
                    if (Group.Text[i] != '-') { str = str.Substring(0, i); break; }
                if(i>5) { str = str.Substring(0, 6); break; }
            }
            Group.Text = str;
            Group.SelectionStart = Group.TextLength;

            savestflag = false;
        }

        void FIO_TextChanged(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            string str = tx.Text;
            int u;
            for (int i = 0; i < tx.TextLength; i++)
            {
                u = Convert.ToInt16(tx.Text[i]);
                if (u<1040 || u>1103) { str = str.Substring(0, i); break; }
                else if(i==0) str = Char.ToUpper(str[0]) + str.Substring(1, str.Length - 1);
            }
            tx.Text = str;
            tx.SelectionStart = tx.TextLength;

            savestflag = false;
        }

        //----------------------------------------Обработка списка книг---------------------------------------------

        void BooksInitialize()
        {
            books.Clear();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                string name, author;
                XmlDocument doc = new XmlDocument();
                try
                {
                    doc.Load(filepath);

                    foreach (XmlNode xNode in doc.DocumentElement)
                    {
                        name = xNode["bName"].InnerText;
                        author = xNode["aName"].InnerText;

                        if (books.ContainsKey(author)) books[author].Add(name);
                        else
                        {
                            List<string> list = new List<string>();
                            list.Add(name);
                            books.Add(author, list);
                        }
                    }

                    foreach(string key in books.Keys)
                    {
                        books[key].Sort();

                        foreach(string bName in books[key])
                        {
                            addBookInList(key, bName);
                        }
                    }

                    for (int i = 0; i < combobox.Count; i += 2)
                    {
                        combobox[i].Items.Clear();
                        AddItem(combobox[i]);
                    }

                    label11.Text = filepath.Substring(filepath.LastIndexOf('\\') + 1, filepath.Length - filepath.LastIndexOf('\\') - 1);
                    label11.ForeColor = Color.DarkGray;

                    EditBookListbtn.Tag = filepath;
                }
                catch (Exception)
                {
                    MessageBox.Show("Файл повреждён или имеет некорректную структуру", "Ошибка открытия файла", MessageBoxButtons.OK);
                }
            }
            else { label11.Text = "Список книг не выбран"; label11.ForeColor = Color.Red; }

            }

        private void EditBookListbtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Открыть список книг";
            BooksInitialize();
        }

        void AddItem(object sender)
        {
            ComboBox cb = (ComboBox)sender;
            author.Clear();

                foreach (string str in books.Keys)
                {
                    if (author.IndexOf(str) == -1)
                    {
                        cb.Items.Add(str);
                        author.Add(str);
                    }
                }
        }

        private void BooksTextChange(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            List<string> list = new List<string>();
            if (cb.Tag.ToString() == "author") { list = author; }
            else
                list = bName;

            cb.Items.Clear();

            foreach (string item in list)
                if (item.ToLower().IndexOf(cb.Text.ToLower()) != -1) cb.Items.Add(item);

            if (cb.Tag.ToString() == "author")
            {
                combobox[combobox.IndexOf(cb) + 1].Items.Clear();

                if (books.TryGetValue(cb.Text, out List<string> listValue))
                {
                    combobox[combobox.IndexOf(cb) + 1].Text = "";
                    bName.Clear();
                    foreach (string s in listValue)
                    {
                        combobox[combobox.IndexOf(cb) + 1].Items.Add(s);
                        bName.Add(s);
                    }
                }
            }

            cb.SelectionStart = cb.Text.Length;
            cb.DroppedDown = true;

            savestflag = false;
        }

        private void bookAdd_Click(object sender, EventArgs e)
        {
            addBookInList("", "");
            savebookflag = false;
        }

        private void StudentTab_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel3.Visible = false;

            if(OpenBtn.Visible)
            {
                Panel2.Visible = false;
                Panel2.BackColor = Color.FromName("InactiveCaptionText");
            }
        }

        private void BookEditTab_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel3.Visible = true;

            Panel2.Visible = true;
            Panel2.BackColor = Color.FromName("InactiveCaption");
        }
    }
}
