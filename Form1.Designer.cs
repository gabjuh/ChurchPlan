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
            labelSong1 = new Label();
            tabPageManual = new TabPage();
            tabControlRight = new TabControl();
            tabPageOrigText = new TabPage();
            tabPageJson = new TabPage();
            tabControlLeft.SuspendLayout();
            tabPageAuto.SuspendLayout();
            tabControlRight.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(177, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // lbSelectDate
            // 
            lbSelectDate.AutoSize = true;
            lbSelectDate.Location = new Point(21, 36);
            lbSelectDate.Name = "lbSelectDate";
            lbSelectDate.Size = new Size(130, 20);
            lbSelectDate.TabIndex = 1;
            lbSelectDate.Text = "Datum auswählen:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(345, 32);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(93, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // tabControlLeft
            // 
            tabControlLeft.Controls.Add(tabPageAuto);
            tabControlLeft.Controls.Add(tabPageManual);
            tabControlLeft.Location = new Point(21, 90);
            tabControlLeft.Name = "tabControlLeft";
            tabControlLeft.SelectedIndex = 0;
            tabControlLeft.Size = new Size(849, 732);
            tabControlLeft.TabIndex = 3;
            // 
            // tabPageAuto
            // 
            tabPageAuto.Controls.Add(labelSong1);
            tabPageAuto.Location = new Point(4, 29);
            tabPageAuto.Name = "tabPageAuto";
            tabPageAuto.Padding = new Padding(3);
            tabPageAuto.Size = new Size(841, 699);
            tabPageAuto.TabIndex = 0;
            tabPageAuto.Text = "Automatisierte Liederauswahl";
            tabPageAuto.UseVisualStyleBackColor = true;
            // 
            // labelSong1
            // 
            labelSong1.AutoSize = true;
            labelSong1.Location = new Point(21, 27);
            labelSong1.Name = "labelSong1";
            labelSong1.Size = new Size(50, 20);
            labelSong1.TabIndex = 0;
            labelSong1.Text = "label1";
            labelSong1.Visible = false;
            // 
            // tabPageManual
            // 
            tabPageManual.Location = new Point(4, 29);
            tabPageManual.Name = "tabPageManual";
            tabPageManual.Padding = new Padding(3);
            tabPageManual.Size = new Size(841, 699);
            tabPageManual.TabIndex = 1;
            tabPageManual.Text = "Manuelle Liederauswahl";
            tabPageManual.UseVisualStyleBackColor = true;
            // 
            // tabControlRight
            // 
            tabControlRight.Controls.Add(tabPageOrigText);
            tabControlRight.Controls.Add(tabPageJson);
            tabControlRight.Location = new Point(872, 90);
            tabControlRight.Name = "tabControlRight";
            tabControlRight.SelectedIndex = 0;
            tabControlRight.Size = new Size(579, 732);
            tabControlRight.TabIndex = 4;
            // 
            // tabPageOrigText
            // 
            tabPageOrigText.Location = new Point(4, 29);
            tabPageOrigText.Name = "tabPageOrigText";
            tabPageOrigText.Padding = new Padding(3);
            tabPageOrigText.Size = new Size(571, 699);
            tabPageOrigText.TabIndex = 0;
            tabPageOrigText.Text = "Plan in Text Format";
            tabPageOrigText.UseVisualStyleBackColor = true;
            // 
            // tabPageJson
            // 
            tabPageJson.Location = new Point(4, 29);
            tabPageJson.Name = "tabPageJson";
            tabPageJson.Padding = new Padding(3);
            tabPageJson.Size = new Size(571, 699);
            tabPageJson.TabIndex = 1;
            tabPageJson.Text = "Plan in JSON Format";
            tabPageJson.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 942);
            Controls.Add(tabControlRight);
            Controls.Add(tabControlLeft);
            Controls.Add(btnRefresh);
            Controls.Add(lbSelectDate);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            tabControlLeft.ResumeLayout(false);
            tabPageAuto.ResumeLayout(false);
            tabPageAuto.PerformLayout();
            tabControlRight.ResumeLayout(false);
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
    }
}