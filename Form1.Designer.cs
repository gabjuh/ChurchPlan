namespace ChurchPlan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            lbSelectDate = new Label();
            btnRefresh = new Button();
            tabControlLeft = new TabControl();
            tabPageAuto = new TabPage();
            btnPreview12 = new Button();
            btnPreview11 = new Button();
            btnPreview10 = new Button();
            btnPreview9 = new Button();
            btnPreview8 = new Button();
            btnPreview7 = new Button();
            btnPreview6 = new Button();
            btnPreview5 = new Button();
            btnPreview4 = new Button();
            btnPreview3 = new Button();
            btnPreview2 = new Button();
            btnPreview1 = new Button();
            btnSong12Play = new Button();
            btnSong11Play = new Button();
            btnSong10Play = new Button();
            btnSong9Play = new Button();
            btnSong8Play = new Button();
            btnSong7Play = new Button();
            btnSong6Play = new Button();
            btnSong5Play = new Button();
            btnSong4Play = new Button();
            btnSong3Play = new Button();
            btnSong2Play = new Button();
            btnSong1Play = new Button();
            labelSong12Title = new Label();
            labelSong11Title = new Label();
            labelSong10Title = new Label();
            labelSong9Title = new Label();
            labelSong8Title = new Label();
            labelSong7Title = new Label();
            labelSong6Title = new Label();
            labelSong5Title = new Label();
            labelSong4Title = new Label();
            labelSong3Title = new Label();
            labelSong2Title = new Label();
            labelSong1Title = new Label();
            label4 = new Label();
            labelSong12Book = new Label();
            labelSong11Book = new Label();
            labelSong10Book = new Label();
            labelSong9Book = new Label();
            labelSong8Book = new Label();
            labelSong7Book = new Label();
            labelSong6Book = new Label();
            labelSong5Book = new Label();
            labelSong4Book = new Label();
            labelSong3Book = new Label();
            labelSong2Book = new Label();
            labelSong1Book = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelSong12 = new Label();
            labelSong11 = new Label();
            labelSong10 = new Label();
            labelSong9 = new Label();
            labelSong8 = new Label();
            labelSong7 = new Label();
            labelSong6 = new Label();
            labelSong5 = new Label();
            labelSong4 = new Label();
            labelSong3 = new Label();
            labelSong2 = new Label();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBoxSong12Number = new ComboBox();
            comboBoxSong11Number = new ComboBox();
            comboBoxSong10Number = new ComboBox();
            comboBoxSong9Number = new ComboBox();
            comboBoxSong8Number = new ComboBox();
            comboBoxSong7Number = new ComboBox();
            comboBoxSong6Number = new ComboBox();
            comboBoxSong5Number = new ComboBox();
            comboBoxSong4Number = new ComboBox();
            comboBoxSong3Number = new ComboBox();
            comboBoxSong2Number = new ComboBox();
            comboBoxSong1Number = new ComboBox();
            labelSong1 = new Label();
            tabPageManual = new TabPage();
            tabControlRight = new TabControl();
            tabPagePreview = new TabPage();
            labelCurrentPreviewNumber = new Label();
            btnPause = new Button();
            btnNext = new Button();
            btnPrev = new Button();
            panel1 = new Panel();
            labelPreview = new Label();
            tabPageOrigText = new TabPage();
            textBoxPlainText = new TextBox();
            tabPageJson = new TabPage();
            textBoxJsonAsText = new TextBox();
            tabControlLeft.SuspendLayout();
            tabPageAuto.SuspendLayout();
            tabControlRight.SuspendLayout();
            tabPagePreview.SuspendLayout();
            panel1.SuspendLayout();
            tabPageOrigText.SuspendLayout();
            tabPageJson.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(155, 25);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // lbSelectDate
            // 
            lbSelectDate.AutoSize = true;
            lbSelectDate.Location = new Point(18, 27);
            lbSelectDate.Name = "lbSelectDate";
            lbSelectDate.Size = new Size(105, 15);
            lbSelectDate.TabIndex = 1;
            lbSelectDate.Text = "Datum auswählen:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(302, 24);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(81, 22);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // tabControlLeft
            // 
            tabControlLeft.Controls.Add(tabPageAuto);
            tabControlLeft.Controls.Add(tabPageManual);
            tabControlLeft.Location = new Point(18, 68);
            tabControlLeft.Margin = new Padding(3, 2, 3, 2);
            tabControlLeft.Name = "tabControlLeft";
            tabControlLeft.SelectedIndex = 0;
            tabControlLeft.Size = new Size(561, 433);
            tabControlLeft.TabIndex = 3;
            // 
            // tabPageAuto
            // 
            tabPageAuto.Controls.Add(btnPreview12);
            tabPageAuto.Controls.Add(btnPreview11);
            tabPageAuto.Controls.Add(btnPreview10);
            tabPageAuto.Controls.Add(btnPreview9);
            tabPageAuto.Controls.Add(btnPreview8);
            tabPageAuto.Controls.Add(btnPreview7);
            tabPageAuto.Controls.Add(btnPreview6);
            tabPageAuto.Controls.Add(btnPreview5);
            tabPageAuto.Controls.Add(btnPreview4);
            tabPageAuto.Controls.Add(btnPreview3);
            tabPageAuto.Controls.Add(btnPreview2);
            tabPageAuto.Controls.Add(btnPreview1);
            tabPageAuto.Controls.Add(btnSong12Play);
            tabPageAuto.Controls.Add(btnSong11Play);
            tabPageAuto.Controls.Add(btnSong10Play);
            tabPageAuto.Controls.Add(btnSong9Play);
            tabPageAuto.Controls.Add(btnSong8Play);
            tabPageAuto.Controls.Add(btnSong7Play);
            tabPageAuto.Controls.Add(btnSong6Play);
            tabPageAuto.Controls.Add(btnSong5Play);
            tabPageAuto.Controls.Add(btnSong4Play);
            tabPageAuto.Controls.Add(btnSong3Play);
            tabPageAuto.Controls.Add(btnSong2Play);
            tabPageAuto.Controls.Add(btnSong1Play);
            tabPageAuto.Controls.Add(labelSong12Title);
            tabPageAuto.Controls.Add(labelSong11Title);
            tabPageAuto.Controls.Add(labelSong10Title);
            tabPageAuto.Controls.Add(labelSong9Title);
            tabPageAuto.Controls.Add(labelSong8Title);
            tabPageAuto.Controls.Add(labelSong7Title);
            tabPageAuto.Controls.Add(labelSong6Title);
            tabPageAuto.Controls.Add(labelSong5Title);
            tabPageAuto.Controls.Add(labelSong4Title);
            tabPageAuto.Controls.Add(labelSong3Title);
            tabPageAuto.Controls.Add(labelSong2Title);
            tabPageAuto.Controls.Add(labelSong1Title);
            tabPageAuto.Controls.Add(label4);
            tabPageAuto.Controls.Add(labelSong12Book);
            tabPageAuto.Controls.Add(labelSong11Book);
            tabPageAuto.Controls.Add(labelSong10Book);
            tabPageAuto.Controls.Add(labelSong9Book);
            tabPageAuto.Controls.Add(labelSong8Book);
            tabPageAuto.Controls.Add(labelSong7Book);
            tabPageAuto.Controls.Add(labelSong6Book);
            tabPageAuto.Controls.Add(labelSong5Book);
            tabPageAuto.Controls.Add(labelSong4Book);
            tabPageAuto.Controls.Add(labelSong3Book);
            tabPageAuto.Controls.Add(labelSong2Book);
            tabPageAuto.Controls.Add(labelSong1Book);
            tabPageAuto.Controls.Add(label3);
            tabPageAuto.Controls.Add(label2);
            tabPageAuto.Controls.Add(label1);
            tabPageAuto.Controls.Add(labelSong12);
            tabPageAuto.Controls.Add(labelSong11);
            tabPageAuto.Controls.Add(labelSong10);
            tabPageAuto.Controls.Add(labelSong9);
            tabPageAuto.Controls.Add(labelSong8);
            tabPageAuto.Controls.Add(labelSong7);
            tabPageAuto.Controls.Add(labelSong6);
            tabPageAuto.Controls.Add(labelSong5);
            tabPageAuto.Controls.Add(labelSong4);
            tabPageAuto.Controls.Add(labelSong3);
            tabPageAuto.Controls.Add(labelSong2);
            tabPageAuto.Controls.Add(textBox12);
            tabPageAuto.Controls.Add(textBox11);
            tabPageAuto.Controls.Add(textBox10);
            tabPageAuto.Controls.Add(textBox9);
            tabPageAuto.Controls.Add(textBox8);
            tabPageAuto.Controls.Add(textBox7);
            tabPageAuto.Controls.Add(textBox6);
            tabPageAuto.Controls.Add(textBox5);
            tabPageAuto.Controls.Add(textBox4);
            tabPageAuto.Controls.Add(textBox3);
            tabPageAuto.Controls.Add(textBox2);
            tabPageAuto.Controls.Add(textBox1);
            tabPageAuto.Controls.Add(comboBoxSong12Number);
            tabPageAuto.Controls.Add(comboBoxSong11Number);
            tabPageAuto.Controls.Add(comboBoxSong10Number);
            tabPageAuto.Controls.Add(comboBoxSong9Number);
            tabPageAuto.Controls.Add(comboBoxSong8Number);
            tabPageAuto.Controls.Add(comboBoxSong7Number);
            tabPageAuto.Controls.Add(comboBoxSong6Number);
            tabPageAuto.Controls.Add(comboBoxSong5Number);
            tabPageAuto.Controls.Add(comboBoxSong4Number);
            tabPageAuto.Controls.Add(comboBoxSong3Number);
            tabPageAuto.Controls.Add(comboBoxSong2Number);
            tabPageAuto.Controls.Add(comboBoxSong1Number);
            tabPageAuto.Controls.Add(labelSong1);
            tabPageAuto.Location = new Point(4, 24);
            tabPageAuto.Margin = new Padding(3, 2, 3, 2);
            tabPageAuto.Name = "tabPageAuto";
            tabPageAuto.Padding = new Padding(3, 2, 3, 2);
            tabPageAuto.Size = new Size(553, 405);
            tabPageAuto.TabIndex = 0;
            tabPageAuto.Text = "Automatisierte Liederauswahl";
            tabPageAuto.UseVisualStyleBackColor = true;
            // 
            // btnPreview12
            // 
            btnPreview12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview12.Location = new Point(474, 355);
            btnPreview12.Name = "btnPreview12";
            btnPreview12.Size = new Size(36, 28);
            btnPreview12.TabIndex = 56;
            btnPreview12.Tag = "12";
            btnPreview12.Text = "👁";
            btnPreview12.UseVisualStyleBackColor = true;
            btnPreview12.Visible = false;
            btnPreview12.Click += BtnPreview_Click;
            // 
            // btnPreview11
            // 
            btnPreview11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview11.Location = new Point(474, 325);
            btnPreview11.Name = "btnPreview11";
            btnPreview11.Size = new Size(36, 28);
            btnPreview11.TabIndex = 56;
            btnPreview11.Tag = "11";
            btnPreview11.Text = "👁";
            btnPreview11.UseVisualStyleBackColor = true;
            btnPreview11.Visible = false;
            btnPreview11.Click += BtnPreview_Click;
            // 
            // btnPreview10
            // 
            btnPreview10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview10.Location = new Point(474, 295);
            btnPreview10.Name = "btnPreview10";
            btnPreview10.Size = new Size(36, 28);
            btnPreview10.TabIndex = 56;
            btnPreview10.Tag = "10";
            btnPreview10.Text = "👁";
            btnPreview10.UseVisualStyleBackColor = true;
            btnPreview10.Visible = false;
            btnPreview10.Click += BtnPreview_Click;
            // 
            // btnPreview9
            // 
            btnPreview9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview9.Location = new Point(474, 265);
            btnPreview9.Name = "btnPreview9";
            btnPreview9.Size = new Size(36, 28);
            btnPreview9.TabIndex = 56;
            btnPreview9.Tag = "9";
            btnPreview9.Text = "👁";
            btnPreview9.UseVisualStyleBackColor = true;
            btnPreview9.Visible = false;
            btnPreview9.Click += BtnPreview_Click;
            // 
            // btnPreview8
            // 
            btnPreview8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview8.Location = new Point(474, 235);
            btnPreview8.Name = "btnPreview8";
            btnPreview8.Size = new Size(36, 28);
            btnPreview8.TabIndex = 56;
            btnPreview8.Tag = "8";
            btnPreview8.Text = "👁";
            btnPreview8.UseVisualStyleBackColor = true;
            btnPreview8.Visible = false;
            btnPreview8.Click += BtnPreview_Click;
            // 
            // btnPreview7
            // 
            btnPreview7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview7.Location = new Point(474, 205);
            btnPreview7.Name = "btnPreview7";
            btnPreview7.Size = new Size(36, 28);
            btnPreview7.TabIndex = 56;
            btnPreview7.Tag = "7";
            btnPreview7.Text = "👁";
            btnPreview7.UseVisualStyleBackColor = true;
            btnPreview7.Visible = false;
            btnPreview7.Click += BtnPreview_Click;
            // 
            // btnPreview6
            // 
            btnPreview6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview6.Location = new Point(474, 175);
            btnPreview6.Name = "btnPreview6";
            btnPreview6.Size = new Size(36, 28);
            btnPreview6.TabIndex = 56;
            btnPreview6.Tag = "6";
            btnPreview6.Text = "👁";
            btnPreview6.UseVisualStyleBackColor = true;
            btnPreview6.Visible = false;
            btnPreview6.Click += BtnPreview_Click;
            // 
            // btnPreview5
            // 
            btnPreview5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview5.Location = new Point(474, 146);
            btnPreview5.Name = "btnPreview5";
            btnPreview5.Size = new Size(36, 28);
            btnPreview5.TabIndex = 56;
            btnPreview5.Tag = "5";
            btnPreview5.Text = "👁";
            btnPreview5.UseVisualStyleBackColor = true;
            btnPreview5.Visible = false;
            btnPreview5.Click += BtnPreview_Click;
            // 
            // btnPreview4
            // 
            btnPreview4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview4.Location = new Point(474, 115);
            btnPreview4.Name = "btnPreview4";
            btnPreview4.Size = new Size(36, 28);
            btnPreview4.TabIndex = 56;
            btnPreview4.Tag = "4";
            btnPreview4.Text = "👁";
            btnPreview4.UseVisualStyleBackColor = true;
            btnPreview4.Visible = false;
            btnPreview4.Click += BtnPreview_Click;
            // 
            // btnPreview3
            // 
            btnPreview3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview3.Location = new Point(474, 85);
            btnPreview3.Name = "btnPreview3";
            btnPreview3.Size = new Size(36, 28);
            btnPreview3.TabIndex = 56;
            btnPreview3.Tag = "3";
            btnPreview3.Text = "👁";
            btnPreview3.UseVisualStyleBackColor = true;
            btnPreview3.Visible = false;
            btnPreview3.Click += BtnPreview_Click;
            // 
            // btnPreview2
            // 
            btnPreview2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview2.Location = new Point(474, 55);
            btnPreview2.Name = "btnPreview2";
            btnPreview2.Size = new Size(36, 28);
            btnPreview2.TabIndex = 56;
            btnPreview2.Tag = "2";
            btnPreview2.Text = "👁";
            btnPreview2.UseVisualStyleBackColor = true;
            btnPreview2.Visible = false;
            btnPreview2.Click += BtnPreview_Click;
            // 
            // btnPreview1
            // 
            btnPreview1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreview1.Location = new Point(474, 25);
            btnPreview1.Name = "btnPreview1";
            btnPreview1.Size = new Size(36, 28);
            btnPreview1.TabIndex = 56;
            btnPreview1.Tag = "1";
            btnPreview1.Text = "👁";
            btnPreview1.UseVisualStyleBackColor = true;
            btnPreview1.Visible = false;
            btnPreview1.Click += BtnPreview_Click;
            // 
            // btnSong12Play
            // 
            btnSong12Play.Location = new Point(514, 355);
            btnSong12Play.Name = "btnSong12Play";
            btnSong12Play.Size = new Size(36, 28);
            btnSong12Play.TabIndex = 54;
            btnSong12Play.Tag = "12";
            btnSong12Play.Text = "▶";
            btnSong12Play.UseVisualStyleBackColor = true;
            btnSong12Play.Visible = false;
            btnSong12Play.Click += BtnSongPlay_Click;
            // 
            // btnSong11Play
            // 
            btnSong11Play.Location = new Point(514, 325);
            btnSong11Play.Name = "btnSong11Play";
            btnSong11Play.Size = new Size(36, 28);
            btnSong11Play.TabIndex = 54;
            btnSong11Play.Tag = "11";
            btnSong11Play.Text = "▶";
            btnSong11Play.UseVisualStyleBackColor = true;
            btnSong11Play.Visible = false;
            btnSong11Play.Click += BtnSongPlay_Click;
            // 
            // btnSong10Play
            // 
            btnSong10Play.Location = new Point(514, 295);
            btnSong10Play.Name = "btnSong10Play";
            btnSong10Play.Size = new Size(36, 28);
            btnSong10Play.TabIndex = 54;
            btnSong10Play.Tag = "10";
            btnSong10Play.Text = "▶";
            btnSong10Play.UseVisualStyleBackColor = true;
            btnSong10Play.Visible = false;
            btnSong10Play.Click += BtnSongPlay_Click;
            // 
            // btnSong9Play
            // 
            btnSong9Play.Location = new Point(514, 265);
            btnSong9Play.Name = "btnSong9Play";
            btnSong9Play.Size = new Size(36, 28);
            btnSong9Play.TabIndex = 54;
            btnSong9Play.Tag = "9";
            btnSong9Play.Text = "▶";
            btnSong9Play.UseVisualStyleBackColor = true;
            btnSong9Play.Visible = false;
            btnSong9Play.Click += BtnSongPlay_Click;
            // 
            // btnSong8Play
            // 
            btnSong8Play.Location = new Point(514, 235);
            btnSong8Play.Name = "btnSong8Play";
            btnSong8Play.Size = new Size(36, 28);
            btnSong8Play.TabIndex = 54;
            btnSong8Play.Tag = "8";
            btnSong8Play.Text = "▶";
            btnSong8Play.UseVisualStyleBackColor = true;
            btnSong8Play.Visible = false;
            btnSong8Play.Click += BtnSongPlay_Click;
            // 
            // btnSong7Play
            // 
            btnSong7Play.Location = new Point(514, 205);
            btnSong7Play.Name = "btnSong7Play";
            btnSong7Play.Size = new Size(36, 28);
            btnSong7Play.TabIndex = 54;
            btnSong7Play.Tag = "7";
            btnSong7Play.Text = "▶";
            btnSong7Play.UseVisualStyleBackColor = true;
            btnSong7Play.Visible = false;
            btnSong7Play.Click += BtnSongPlay_Click;
            // 
            // btnSong6Play
            // 
            btnSong6Play.Location = new Point(514, 175);
            btnSong6Play.Name = "btnSong6Play";
            btnSong6Play.Size = new Size(36, 28);
            btnSong6Play.TabIndex = 54;
            btnSong6Play.Tag = "6";
            btnSong6Play.Text = "▶";
            btnSong6Play.UseVisualStyleBackColor = true;
            btnSong6Play.Visible = false;
            btnSong6Play.Click += BtnSongPlay_Click;
            // 
            // btnSong5Play
            // 
            btnSong5Play.Location = new Point(514, 146);
            btnSong5Play.Name = "btnSong5Play";
            btnSong5Play.Size = new Size(36, 28);
            btnSong5Play.TabIndex = 54;
            btnSong5Play.Tag = "5";
            btnSong5Play.Text = "▶";
            btnSong5Play.UseVisualStyleBackColor = true;
            btnSong5Play.Visible = false;
            btnSong5Play.Click += BtnSongPlay_Click;
            // 
            // btnSong4Play
            // 
            btnSong4Play.Location = new Point(514, 115);
            btnSong4Play.Name = "btnSong4Play";
            btnSong4Play.Size = new Size(36, 28);
            btnSong4Play.TabIndex = 54;
            btnSong4Play.Tag = "4";
            btnSong4Play.Text = "▶";
            btnSong4Play.UseVisualStyleBackColor = true;
            btnSong4Play.Visible = false;
            btnSong4Play.Click += BtnSongPlay_Click;
            // 
            // btnSong3Play
            // 
            btnSong3Play.Location = new Point(514, 85);
            btnSong3Play.Name = "btnSong3Play";
            btnSong3Play.Size = new Size(36, 28);
            btnSong3Play.TabIndex = 54;
            btnSong3Play.Tag = "3";
            btnSong3Play.Text = "▶";
            btnSong3Play.UseVisualStyleBackColor = true;
            btnSong3Play.Visible = false;
            btnSong3Play.Click += BtnSongPlay_Click;
            // 
            // btnSong2Play
            // 
            btnSong2Play.Location = new Point(514, 55);
            btnSong2Play.Name = "btnSong2Play";
            btnSong2Play.Size = new Size(36, 28);
            btnSong2Play.TabIndex = 54;
            btnSong2Play.Tag = "2";
            btnSong2Play.Text = "▶";
            btnSong2Play.UseVisualStyleBackColor = true;
            btnSong2Play.Visible = false;
            btnSong2Play.Click += BtnSongPlay_Click;
            // 
            // btnSong1Play
            // 
            btnSong1Play.Location = new Point(514, 25);
            btnSong1Play.Name = "btnSong1Play";
            btnSong1Play.Size = new Size(36, 28);
            btnSong1Play.TabIndex = 53;
            btnSong1Play.Tag = "1";
            btnSong1Play.Text = "▶";
            btnSong1Play.UseVisualStyleBackColor = true;
            btnSong1Play.Visible = false;
            btnSong1Play.Click += BtnSongPlay_Click;
            // 
            // labelSong12Title
            // 
            labelSong12Title.AutoSize = true;
            labelSong12Title.Location = new Point(295, 363);
            labelSong12Title.Name = "labelSong12Title";
            labelSong12Title.Size = new Size(27, 15);
            labelSong12Title.TabIndex = 52;
            labelSong12Title.Text = "title";
            labelSong12Title.Visible = false;
            // 
            // labelSong11Title
            // 
            labelSong11Title.AutoSize = true;
            labelSong11Title.Location = new Point(295, 333);
            labelSong11Title.Name = "labelSong11Title";
            labelSong11Title.Size = new Size(27, 15);
            labelSong11Title.TabIndex = 52;
            labelSong11Title.Text = "title";
            labelSong11Title.Visible = false;
            // 
            // labelSong10Title
            // 
            labelSong10Title.AutoSize = true;
            labelSong10Title.Location = new Point(295, 303);
            labelSong10Title.Name = "labelSong10Title";
            labelSong10Title.Size = new Size(27, 15);
            labelSong10Title.TabIndex = 52;
            labelSong10Title.Text = "title";
            labelSong10Title.Visible = false;
            // 
            // labelSong9Title
            // 
            labelSong9Title.AutoSize = true;
            labelSong9Title.Location = new Point(295, 273);
            labelSong9Title.Name = "labelSong9Title";
            labelSong9Title.Size = new Size(27, 15);
            labelSong9Title.TabIndex = 52;
            labelSong9Title.Text = "title";
            labelSong9Title.Visible = false;
            // 
            // labelSong8Title
            // 
            labelSong8Title.AutoSize = true;
            labelSong8Title.Location = new Point(295, 243);
            labelSong8Title.Name = "labelSong8Title";
            labelSong8Title.Size = new Size(27, 15);
            labelSong8Title.TabIndex = 52;
            labelSong8Title.Text = "title";
            labelSong8Title.Visible = false;
            // 
            // labelSong7Title
            // 
            labelSong7Title.AutoSize = true;
            labelSong7Title.Location = new Point(295, 213);
            labelSong7Title.Name = "labelSong7Title";
            labelSong7Title.Size = new Size(27, 15);
            labelSong7Title.TabIndex = 52;
            labelSong7Title.Text = "title";
            labelSong7Title.Visible = false;
            // 
            // labelSong6Title
            // 
            labelSong6Title.AutoSize = true;
            labelSong6Title.Location = new Point(295, 183);
            labelSong6Title.Name = "labelSong6Title";
            labelSong6Title.Size = new Size(27, 15);
            labelSong6Title.TabIndex = 52;
            labelSong6Title.Text = "title";
            labelSong6Title.Visible = false;
            // 
            // labelSong5Title
            // 
            labelSong5Title.AutoSize = true;
            labelSong5Title.Location = new Point(295, 153);
            labelSong5Title.Name = "labelSong5Title";
            labelSong5Title.Size = new Size(27, 15);
            labelSong5Title.TabIndex = 52;
            labelSong5Title.Text = "title";
            labelSong5Title.Visible = false;
            // 
            // labelSong4Title
            // 
            labelSong4Title.AutoSize = true;
            labelSong4Title.Location = new Point(295, 123);
            labelSong4Title.Name = "labelSong4Title";
            labelSong4Title.Size = new Size(27, 15);
            labelSong4Title.TabIndex = 52;
            labelSong4Title.Text = "title";
            labelSong4Title.Visible = false;
            // 
            // labelSong3Title
            // 
            labelSong3Title.AutoSize = true;
            labelSong3Title.Location = new Point(295, 93);
            labelSong3Title.Name = "labelSong3Title";
            labelSong3Title.Size = new Size(27, 15);
            labelSong3Title.TabIndex = 52;
            labelSong3Title.Text = "title";
            labelSong3Title.Visible = false;
            // 
            // labelSong2Title
            // 
            labelSong2Title.AutoSize = true;
            labelSong2Title.Location = new Point(295, 63);
            labelSong2Title.Name = "labelSong2Title";
            labelSong2Title.Size = new Size(27, 15);
            labelSong2Title.TabIndex = 52;
            labelSong2Title.Text = "title";
            labelSong2Title.Visible = false;
            // 
            // labelSong1Title
            // 
            labelSong1Title.AutoSize = true;
            labelSong1Title.Location = new Point(295, 33);
            labelSong1Title.Name = "labelSong1Title";
            labelSong1Title.Size = new Size(27, 15);
            labelSong1Title.TabIndex = 52;
            labelSong1Title.Text = "title";
            labelSong1Title.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(304, 9);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 51;
            label4.Text = "Titel des Liedes";
            // 
            // labelSong12Book
            // 
            labelSong12Book.AutoSize = true;
            labelSong12Book.Location = new Point(39, 363);
            labelSong12Book.Name = "labelSong12Book";
            labelSong12Book.Size = new Size(34, 15);
            labelSong12Book.TabIndex = 50;
            labelSong12Book.Text = "book";
            labelSong12Book.Visible = false;
            // 
            // labelSong11Book
            // 
            labelSong11Book.AutoSize = true;
            labelSong11Book.Location = new Point(39, 333);
            labelSong11Book.Name = "labelSong11Book";
            labelSong11Book.Size = new Size(34, 15);
            labelSong11Book.TabIndex = 50;
            labelSong11Book.Text = "book";
            labelSong11Book.Visible = false;
            // 
            // labelSong10Book
            // 
            labelSong10Book.AutoSize = true;
            labelSong10Book.Location = new Point(39, 303);
            labelSong10Book.Name = "labelSong10Book";
            labelSong10Book.Size = new Size(34, 15);
            labelSong10Book.TabIndex = 50;
            labelSong10Book.Text = "book";
            labelSong10Book.Visible = false;
            // 
            // labelSong9Book
            // 
            labelSong9Book.AutoSize = true;
            labelSong9Book.Location = new Point(39, 273);
            labelSong9Book.Name = "labelSong9Book";
            labelSong9Book.Size = new Size(34, 15);
            labelSong9Book.TabIndex = 50;
            labelSong9Book.Text = "book";
            labelSong9Book.Visible = false;
            // 
            // labelSong8Book
            // 
            labelSong8Book.AutoSize = true;
            labelSong8Book.Location = new Point(39, 243);
            labelSong8Book.Name = "labelSong8Book";
            labelSong8Book.Size = new Size(34, 15);
            labelSong8Book.TabIndex = 50;
            labelSong8Book.Text = "book";
            labelSong8Book.Visible = false;
            // 
            // labelSong7Book
            // 
            labelSong7Book.AutoSize = true;
            labelSong7Book.Location = new Point(39, 213);
            labelSong7Book.Name = "labelSong7Book";
            labelSong7Book.Size = new Size(34, 15);
            labelSong7Book.TabIndex = 50;
            labelSong7Book.Text = "book";
            labelSong7Book.Visible = false;
            // 
            // labelSong6Book
            // 
            labelSong6Book.AutoSize = true;
            labelSong6Book.Location = new Point(39, 183);
            labelSong6Book.Name = "labelSong6Book";
            labelSong6Book.Size = new Size(34, 15);
            labelSong6Book.TabIndex = 50;
            labelSong6Book.Text = "book";
            labelSong6Book.Visible = false;
            // 
            // labelSong5Book
            // 
            labelSong5Book.AutoSize = true;
            labelSong5Book.Location = new Point(39, 153);
            labelSong5Book.Name = "labelSong5Book";
            labelSong5Book.Size = new Size(34, 15);
            labelSong5Book.TabIndex = 50;
            labelSong5Book.Text = "book";
            labelSong5Book.Visible = false;
            // 
            // labelSong4Book
            // 
            labelSong4Book.AutoSize = true;
            labelSong4Book.Location = new Point(39, 123);
            labelSong4Book.Name = "labelSong4Book";
            labelSong4Book.Size = new Size(34, 15);
            labelSong4Book.TabIndex = 50;
            labelSong4Book.Text = "book";
            labelSong4Book.Visible = false;
            // 
            // labelSong3Book
            // 
            labelSong3Book.AutoSize = true;
            labelSong3Book.Location = new Point(39, 93);
            labelSong3Book.Name = "labelSong3Book";
            labelSong3Book.Size = new Size(34, 15);
            labelSong3Book.TabIndex = 50;
            labelSong3Book.Text = "book";
            labelSong3Book.Visible = false;
            // 
            // labelSong2Book
            // 
            labelSong2Book.AutoSize = true;
            labelSong2Book.Location = new Point(39, 63);
            labelSong2Book.Name = "labelSong2Book";
            labelSong2Book.Size = new Size(34, 15);
            labelSong2Book.TabIndex = 50;
            labelSong2Book.Text = "book";
            labelSong2Book.Visible = false;
            // 
            // labelSong1Book
            // 
            labelSong1Book.AutoSize = true;
            labelSong1Book.Location = new Point(39, 33);
            labelSong1Book.Name = "labelSong1Book";
            labelSong1Book.Size = new Size(34, 15);
            labelSong1Book.TabIndex = 50;
            labelSong1Book.Text = "book";
            labelSong1Book.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 9);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 49;
            label3.Text = "Buch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(199, 9);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 48;
            label2.Text = "Strophen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 47;
            label1.Text = "Nummer";
            // 
            // labelSong12
            // 
            labelSong12.AutoSize = true;
            labelSong12.Location = new Point(5, 363);
            labelSong12.Name = "labelSong12";
            labelSong12.Size = new Size(22, 15);
            labelSong12.TabIndex = 46;
            labelSong12.Text = "12.";
            labelSong12.Visible = false;
            // 
            // labelSong11
            // 
            labelSong11.AutoSize = true;
            labelSong11.Location = new Point(5, 333);
            labelSong11.Name = "labelSong11";
            labelSong11.Size = new Size(22, 15);
            labelSong11.TabIndex = 45;
            labelSong11.Tag = "";
            labelSong11.Text = "11.";
            labelSong11.Visible = false;
            // 
            // labelSong10
            // 
            labelSong10.AutoSize = true;
            labelSong10.Location = new Point(5, 303);
            labelSong10.Name = "labelSong10";
            labelSong10.Size = new Size(22, 15);
            labelSong10.TabIndex = 44;
            labelSong10.Text = "10.";
            labelSong10.Visible = false;
            // 
            // labelSong9
            // 
            labelSong9.AutoSize = true;
            labelSong9.Location = new Point(12, 273);
            labelSong9.Name = "labelSong9";
            labelSong9.Size = new Size(16, 15);
            labelSong9.TabIndex = 43;
            labelSong9.Text = "9.";
            labelSong9.Visible = false;
            // 
            // labelSong8
            // 
            labelSong8.AutoSize = true;
            labelSong8.Location = new Point(12, 243);
            labelSong8.Name = "labelSong8";
            labelSong8.Size = new Size(16, 15);
            labelSong8.TabIndex = 42;
            labelSong8.Text = "8.";
            labelSong8.Visible = false;
            // 
            // labelSong7
            // 
            labelSong7.AutoSize = true;
            labelSong7.Location = new Point(12, 213);
            labelSong7.Name = "labelSong7";
            labelSong7.Size = new Size(16, 15);
            labelSong7.TabIndex = 41;
            labelSong7.Text = "7.";
            labelSong7.Visible = false;
            // 
            // labelSong6
            // 
            labelSong6.AutoSize = true;
            labelSong6.Location = new Point(12, 183);
            labelSong6.Name = "labelSong6";
            labelSong6.Size = new Size(16, 15);
            labelSong6.TabIndex = 40;
            labelSong6.Text = "6.";
            labelSong6.Visible = false;
            // 
            // labelSong5
            // 
            labelSong5.AutoSize = true;
            labelSong5.Location = new Point(12, 153);
            labelSong5.Name = "labelSong5";
            labelSong5.Size = new Size(16, 15);
            labelSong5.TabIndex = 39;
            labelSong5.Text = "5.";
            labelSong5.Visible = false;
            // 
            // labelSong4
            // 
            labelSong4.AutoSize = true;
            labelSong4.Location = new Point(12, 123);
            labelSong4.Name = "labelSong4";
            labelSong4.Size = new Size(16, 15);
            labelSong4.TabIndex = 38;
            labelSong4.Text = "4.";
            labelSong4.Visible = false;
            // 
            // labelSong3
            // 
            labelSong3.AutoSize = true;
            labelSong3.Location = new Point(12, 93);
            labelSong3.Name = "labelSong3";
            labelSong3.Size = new Size(16, 15);
            labelSong3.TabIndex = 37;
            labelSong3.Text = "3.";
            labelSong3.Visible = false;
            // 
            // labelSong2
            // 
            labelSong2.AutoSize = true;
            labelSong2.Location = new Point(12, 63);
            labelSong2.Name = "labelSong2";
            labelSong2.Size = new Size(16, 15);
            labelSong2.TabIndex = 36;
            labelSong2.Text = "2.";
            labelSong2.Visible = false;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(180, 361);
            textBox12.Margin = new Padding(3, 2, 3, 2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(97, 23);
            textBox12.TabIndex = 35;
            textBox12.Visible = false;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(180, 331);
            textBox11.Margin = new Padding(3, 2, 3, 2);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(97, 23);
            textBox11.TabIndex = 34;
            textBox11.Visible = false;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(180, 301);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(97, 23);
            textBox10.TabIndex = 33;
            textBox10.Visible = false;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(180, 271);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(97, 23);
            textBox9.TabIndex = 32;
            textBox9.Visible = false;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(180, 241);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(97, 23);
            textBox8.TabIndex = 31;
            textBox8.Visible = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(180, 211);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(97, 23);
            textBox7.TabIndex = 30;
            textBox7.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(180, 181);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(97, 23);
            textBox6.TabIndex = 29;
            textBox6.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(180, 151);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(97, 23);
            textBox5.TabIndex = 28;
            textBox5.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(180, 121);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(97, 23);
            textBox4.TabIndex = 27;
            textBox4.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(180, 91);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 23);
            textBox3.TabIndex = 26;
            textBox3.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 61);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 23);
            textBox2.TabIndex = 25;
            textBox2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 31);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 23);
            textBox1.TabIndex = 24;
            textBox1.Visible = false;
            // 
            // comboBoxSong12Number
            // 
            comboBoxSong12Number.FormattingEnabled = true;
            comboBoxSong12Number.Location = new Point(100, 361);
            comboBoxSong12Number.Margin = new Padding(3, 2, 3, 2);
            comboBoxSong12Number.Name = "comboBoxSong12Number";
            comboBoxSong12Number.Size = new Size(64, 23);
            comboBoxSong12Number.TabIndex = 23;
            comboBoxSong12Number.Visible = false;
            // 
            // comboBoxSong11Number
            // 
            comboBoxSong11Number.FormattingEnabled = true;
            comboBoxSong11Number.Location = new Point(100, 331);
            comboBoxSong11Number.Margin = new Padding(3, 2, 3, 2);
            comboBoxSong11Number.Name = "comboBoxSong11Number";
            comboBoxSong11Number.Size = new Size(64, 23);
            comboBoxSong11Number.TabIndex = 22;
            comboBoxSong11Number.Visible = false;
            // 
            // comboBoxSong10Number
            // 
            comboBoxSong10Number.FormattingEnabled = true;
            comboBoxSong10Number.Location = new Point(100, 301);
            comboBoxSong10Number.Margin = new Padding(3, 2, 3, 2);
            comboBoxSong10Number.Name = "comboBoxSong10Number";
            comboBoxSong10Number.Size = new Size(64, 23);
            comboBoxSong10Number.TabIndex = 21;
            comboBoxSong10Number.Visible = false;
            // 
            // comboBoxSong9Number
            // 
            comboBoxSong9Number.FormattingEnabled = true;
            comboBoxSong9Number.Location = new Point(100, 271);
            comboBoxSong9Number.Margin = new Padding(3, 2, 3, 2);
            comboBoxSong9Number.Name = "comboBoxSong9Number";
            comboBoxSong9Number.Size = new Size(64, 23);
            comboBoxSong9Number.TabIndex = 20;
            comboBoxSong9Number.Visible = false;
            // 
            // comboBoxSong8Number
            // 
            comboBoxSong8Number.FormattingEnabled = true;
            comboBoxSong8Number.Location = new Point(100, 241);
            comboBoxSong8Number.Margin = new Padding(3, 2, 3, 2);
            comboBoxSong8Number.Name = "comboBoxSong8Number";
            comboBoxSong8Number.Size = new Size(64, 23);
            comboBoxSong8Number.TabIndex = 19;
            comboBoxSong8Number.Visible = false;
            // 
            // comboBoxSong7Number
            // 
            comboBoxSong7Number.FormattingEnabled = true;
            comboBoxSong7Number.Location = new Point(100, 211);
            comboBoxSong7Number.Margin = new Padding(3, 2, 3, 2);
            comboBoxSong7Number.Name = "comboBoxSong7Number";
            comboBoxSong7Number.Size = new Size(64, 23);
            comboBoxSong7Number.TabIndex = 18;
            comboBoxSong7Number.Visible = false;
            // 
            // comboBoxSong6Number
            // 
            comboBoxSong6Number.FormattingEnabled = true;
            comboBoxSong6Number.Location = new Point(100, 181);
            comboBoxSong6Number.Margin = new Padding(3, 2, 3, 2);
            comboBoxSong6Number.Name = "comboBoxSong6Number";
            comboBoxSong6Number.Size = new Size(64, 23);
            comboBoxSong6Number.TabIndex = 17;
            comboBoxSong6Number.Visible = false;
            // 
            // comboBoxSong5Number
            // 
            comboBoxSong5Number.FormattingEnabled = true;
            comboBoxSong5Number.Location = new Point(100, 151);
            comboBoxSong5Number.Margin = new Padding(3, 2, 3, 2);
            comboBoxSong5Number.Name = "comboBoxSong5Number";
            comboBoxSong5Number.Size = new Size(64, 23);
            comboBoxSong5Number.TabIndex = 16;
            comboBoxSong5Number.Visible = false;
            // 
            // comboBoxSong4Number
            // 
            comboBoxSong4Number.FormattingEnabled = true;
            comboBoxSong4Number.Location = new Point(100, 121);
            comboBoxSong4Number.Margin = new Padding(3, 2, 3, 2);
            comboBoxSong4Number.Name = "comboBoxSong4Number";
            comboBoxSong4Number.Size = new Size(64, 23);
            comboBoxSong4Number.TabIndex = 15;
            comboBoxSong4Number.Visible = false;
            // 
            // comboBoxSong3Number
            // 
            comboBoxSong3Number.FormattingEnabled = true;
            comboBoxSong3Number.Location = new Point(100, 91);
            comboBoxSong3Number.Margin = new Padding(3, 2, 3, 2);
            comboBoxSong3Number.Name = "comboBoxSong3Number";
            comboBoxSong3Number.Size = new Size(64, 23);
            comboBoxSong3Number.TabIndex = 14;
            comboBoxSong3Number.Visible = false;
            // 
            // comboBoxSong2Number
            // 
            comboBoxSong2Number.FormattingEnabled = true;
            comboBoxSong2Number.Location = new Point(100, 61);
            comboBoxSong2Number.Margin = new Padding(3, 2, 3, 2);
            comboBoxSong2Number.Name = "comboBoxSong2Number";
            comboBoxSong2Number.Size = new Size(64, 23);
            comboBoxSong2Number.TabIndex = 13;
            comboBoxSong2Number.Visible = false;
            // 
            // comboBoxSong1Number
            // 
            comboBoxSong1Number.FormattingEnabled = true;
            comboBoxSong1Number.Items.AddRange(new object[] { "20", "458", "123" });
            comboBoxSong1Number.Location = new Point(100, 31);
            comboBoxSong1Number.Margin = new Padding(3, 2, 3, 2);
            comboBoxSong1Number.Name = "comboBoxSong1Number";
            comboBoxSong1Number.Size = new Size(64, 23);
            comboBoxSong1Number.TabIndex = 12;
            comboBoxSong1Number.Visible = false;
            // 
            // labelSong1
            // 
            labelSong1.AutoSize = true;
            labelSong1.Location = new Point(12, 33);
            labelSong1.Name = "labelSong1";
            labelSong1.Size = new Size(16, 15);
            labelSong1.TabIndex = 0;
            labelSong1.Text = "1.";
            labelSong1.Visible = false;
            // 
            // tabPageManual
            // 
            tabPageManual.Location = new Point(4, 24);
            tabPageManual.Margin = new Padding(3, 2, 3, 2);
            tabPageManual.Name = "tabPageManual";
            tabPageManual.Padding = new Padding(3, 2, 3, 2);
            tabPageManual.Size = new Size(553, 405);
            tabPageManual.TabIndex = 1;
            tabPageManual.Text = "Manuelle Liederauswahl";
            tabPageManual.UseVisualStyleBackColor = true;
            // 
            // tabControlRight
            // 
            tabControlRight.Controls.Add(tabPagePreview);
            tabControlRight.Controls.Add(tabPageOrigText);
            tabControlRight.Controls.Add(tabPageJson);
            tabControlRight.Location = new Point(581, 68);
            tabControlRight.Margin = new Padding(3, 2, 3, 2);
            tabControlRight.Name = "tabControlRight";
            tabControlRight.SelectedIndex = 0;
            tabControlRight.Size = new Size(305, 433);
            tabControlRight.TabIndex = 4;
            // 
            // tabPagePreview
            // 
            tabPagePreview.Controls.Add(labelCurrentPreviewNumber);
            tabPagePreview.Controls.Add(btnPause);
            tabPagePreview.Controls.Add(btnNext);
            tabPagePreview.Controls.Add(btnPrev);
            tabPagePreview.Controls.Add(panel1);
            tabPagePreview.Location = new Point(4, 24);
            tabPagePreview.Name = "tabPagePreview";
            tabPagePreview.Padding = new Padding(3);
            tabPagePreview.Size = new Size(297, 405);
            tabPagePreview.TabIndex = 2;
            tabPagePreview.Text = "Vorschau";
            tabPagePreview.UseVisualStyleBackColor = true;
            // 
            // labelCurrentPreviewNumber
            // 
            labelCurrentPreviewNumber.AutoSize = true;
            labelCurrentPreviewNumber.Location = new Point(101, 215);
            labelCurrentPreviewNumber.Name = "labelCurrentPreviewNumber";
            labelCurrentPreviewNumber.Size = new Size(99, 15);
            labelCurrentPreviewNumber.TabIndex = 4;
            labelCurrentPreviewNumber.Text = "0. von 0 Strophen";
            // 
            // btnPause
            // 
            btnPause.Enabled = false;
            btnPause.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPause.Location = new Point(127, 242);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(42, 45);
            btnPause.TabIndex = 3;
            btnPause.Text = "⏸";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += BtnPause_Click;
            // 
            // btnNext
            // 
            btnNext.Enabled = false;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(175, 242);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 45);
            btnNext.TabIndex = 2;
            btnNext.Text = "⏩";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += BtnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Enabled = false;
            btnPrev.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrev.Location = new Point(46, 242);
            btnPrev.Margin = new Padding(0);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(75, 45);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "⏪";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += BtnPrev_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(labelPreview);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 198);
            panel1.TabIndex = 0;
            // 
            // labelPreview
            // 
            labelPreview.AutoSize = true;
            labelPreview.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPreview.ForeColor = SystemColors.ButtonHighlight;
            labelPreview.Location = new Point(133, 86);
            labelPreview.Name = "labelPreview";
            labelPreview.Size = new Size(19, 21);
            labelPreview.TabIndex = 1;
            labelPreview.Text = "...";
            // 
            // tabPageOrigText
            // 
            tabPageOrigText.Controls.Add(textBoxPlainText);
            tabPageOrigText.Location = new Point(4, 24);
            tabPageOrigText.Margin = new Padding(3, 2, 3, 2);
            tabPageOrigText.Name = "tabPageOrigText";
            tabPageOrigText.Padding = new Padding(3, 2, 3, 2);
            tabPageOrigText.Size = new Size(297, 405);
            tabPageOrigText.TabIndex = 0;
            tabPageOrigText.Text = "Plan in Text";
            tabPageOrigText.UseVisualStyleBackColor = true;
            // 
            // textBoxPlainText
            // 
            textBoxPlainText.Location = new Point(6, 5);
            textBoxPlainText.Multiline = true;
            textBoxPlainText.Name = "textBoxPlainText";
            textBoxPlainText.ScrollBars = ScrollBars.Vertical;
            textBoxPlainText.Size = new Size(285, 395);
            textBoxPlainText.TabIndex = 0;
            // 
            // tabPageJson
            // 
            tabPageJson.Controls.Add(textBoxJsonAsText);
            tabPageJson.Location = new Point(4, 24);
            tabPageJson.Margin = new Padding(3, 2, 3, 2);
            tabPageJson.Name = "tabPageJson";
            tabPageJson.Padding = new Padding(3, 2, 3, 2);
            tabPageJson.Size = new Size(297, 405);
            tabPageJson.TabIndex = 1;
            tabPageJson.Text = "Plan in JSON";
            tabPageJson.UseVisualStyleBackColor = true;
            // 
            // textBoxJsonAsText
            // 
            textBoxJsonAsText.BackColor = SystemColors.InfoText;
            textBoxJsonAsText.ForeColor = Color.FromArgb(0, 192, 0);
            textBoxJsonAsText.Location = new Point(3, 5);
            textBoxJsonAsText.Multiline = true;
            textBoxJsonAsText.Name = "textBoxJsonAsText";
            textBoxJsonAsText.ScrollBars = ScrollBars.Vertical;
            textBoxJsonAsText.Size = new Size(288, 395);
            textBoxJsonAsText.TabIndex = 0;
            textBoxJsonAsText.TextChanged += TextBoxJsonAsText_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 537);
            Controls.Add(tabControlRight);
            Controls.Add(tabControlLeft);
            Controls.Add(btnRefresh);
            Controls.Add(lbSelectDate);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            tabControlLeft.ResumeLayout(false);
            tabPageAuto.ResumeLayout(false);
            tabPageAuto.PerformLayout();
            tabControlRight.ResumeLayout(false);
            tabPagePreview.ResumeLayout(false);
            tabPagePreview.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageOrigText.ResumeLayout(false);
            tabPageOrigText.PerformLayout();
            tabPageJson.ResumeLayout(false);
            tabPageJson.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label lbSelectDate;
        private Button btnRefresh;
        private TabControl tabControlLeft;
        private TabPage tabPageAuto;
        private TabPage tabPageManual;
        private TabControl tabControlRight;
        private TabPage tabPageOrigText;
        private TabPage tabPageJson;
        private Label labelSong1;
        private ComboBox comboBoxSong2Number;
        private ComboBox comboBoxSong1Number;
        private Label labelSong12;
        private Label labelSong11;
        private Label labelSong10;
        private Label labelSong9;
        private Label labelSong8;
        private Label labelSong7;
        private Label labelSong6;
        private Label labelSong5;
        private Label labelSong4;
        private Label labelSong3;
        private Label labelSong2;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBoxSong12Number;
        private ComboBox comboBoxSong11Number;
        private ComboBox comboBoxSong10Number;
        private ComboBox comboBoxSong9Number;
        private ComboBox comboBoxSong8Number;
        private ComboBox comboBoxSong7Number;
        private ComboBox comboBoxSong6Number;
        private ComboBox comboBoxSong5Number;
        private ComboBox comboBoxSong4Number;
        private ComboBox comboBoxSong3Number;
        private Label label1;
        private Label label2;
        private Label labelSong12Book;
        private Label labelSong11Book;
        private Label labelSong10Book;
        private Label labelSong9Book;
        private Label labelSong8Book;
        private Label labelSong7Book;
        private Label labelSong6Book;
        private Label labelSong5Book;
        private Label labelSong4Book;
        private Label labelSong3Book;
        private Label labelSong2Book;
        private Label labelSong1Book;
        private Label label3;
        private Label labelSong12Title;
        private Label labelSong11Title;
        private Label labelSong10Title;
        private Label labelSong9Title;
        private Label labelSong8Title;
        private Label labelSong7Title;
        private Label labelSong6Title;
        private Label labelSong5Title;
        private Label labelSong4Title;
        private Label labelSong3Title;
        private Label labelSong2Title;
        private Label labelSong1Title;
        private Label label4;
        private TextBox textBoxPlainText;
        private TextBox textBoxJsonAsText;
        private Button btnSong1Play;
        private Button btnSong2Play;
        private Button btnSong12Play;
        private Button btnSong11Play;
        private Button btnSong10Play;
        private Button btnSong9Play;
        private Button btnSong8Play;
        private Button btnSong7Play;
        private Button btnSong6Play;
        private Button btnSong5Play;
        private Button btnSong4Play;
        private Button btnSong3Play;
        private TabPage tabPagePreview;
        private Panel panel1;
        private Button btnPause;
        private Button btnNext;
        private Button btnPrev;
        private Label labelCurrentPreviewNumber;
        private Button btnPreview1;
        private Label labelPreview;
        private Button btnPreview12;
        private Button btnPreview11;
        private Button btnPreview10;
        private Button btnPreview9;
        private Button btnPreview8;
        private Button btnPreview7;
        private Button btnPreview6;
        private Button btnPreview5;
        private Button btnPreview4;
        private Button btnPreview3;
        private Button btnPreview2;
    }
}