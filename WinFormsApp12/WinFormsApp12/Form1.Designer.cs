namespace WinFormsApp12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            очиститьToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnAllApplications = new Button();
            txtAllApplications = new TextBox();
            label6 = new Label();
            btnRemoveApplication = new Button();
            btnAddAplication = new Button();
            label5 = new Label();
            txtApplications = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtDestination = new TextBox();
            txtPassangerName = new TextBox();
            txtFlightNumber = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnClose = new Button();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(856, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { очиститьToolStripMenuItem, toolStripMenuItem1, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new Size(126, 22);
            очиститьToolStripMenuItem.Text = "Очистить";
            очиститьToolStripMenuItem.Click += очиститьToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(123, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(126, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(865, 513);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(21, 43);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(741, 417);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAllApplications);
            tabPage1.Controls.Add(txtAllApplications);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(btnRemoveApplication);
            tabPage1.Controls.Add(btnAddAplication);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtApplications);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(txtDestination);
            tabPage1.Controls.Add(txtPassangerName);
            tabPage1.Controls.Add(txtFlightNumber);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(733, 389);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Авиабилеты";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAllApplications
            // 
            btnAllApplications.Location = new Point(80, 265);
            btnAllApplications.Name = "btnAllApplications";
            btnAllApplications.Size = new Size(88, 23);
            btnAllApplications.TabIndex = 14;
            btnAllApplications.Text = "Все";
            btnAllApplications.UseVisualStyleBackColor = true;
            btnAllApplications.Click += btnAllApplications_Click_1;
            // 
            // txtAllApplications
            // 
            txtAllApplications.Location = new Point(488, 40);
            txtAllApplications.Multiline = true;
            txtAllApplications.Name = "txtAllApplications";
            txtAllApplications.ReadOnly = true;
            txtAllApplications.ScrollBars = ScrollBars.Vertical;
            txtAllApplications.Size = new Size(217, 343);
            txtAllApplications.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(534, 22);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 12;
            label6.Text = "Весь список заявок:";
            // 
            // btnRemoveApplication
            // 
            btnRemoveApplication.Location = new Point(143, 236);
            btnRemoveApplication.Name = "btnRemoveApplication";
            btnRemoveApplication.Size = new Size(88, 23);
            btnRemoveApplication.TabIndex = 11;
            btnRemoveApplication.Text = "Удалить";
            btnRemoveApplication.UseVisualStyleBackColor = true;
            btnRemoveApplication.Click += btnRemoveApplication_Click;
            // 
            // btnAddAplication
            // 
            btnAddAplication.Location = new Point(36, 236);
            btnAddAplication.Name = "btnAddAplication";
            btnAddAplication.Size = new Size(88, 23);
            btnAddAplication.TabIndex = 10;
            btnAddAplication.Text = "Добавить";
            btnAddAplication.UseVisualStyleBackColor = true;
            btnAddAplication.Click += btnAddAplication_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 22);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 9;
            label5.Text = "Заявки:";
            // 
            // txtApplications
            // 
            txtApplications.Location = new Point(237, 40);
            txtApplications.Multiline = true;
            txtApplications.Name = "txtApplications";
            txtApplications.ReadOnly = true;
            txtApplications.ScrollBars = ScrollBars.Vertical;
            txtApplications.Size = new Size(217, 343);
            txtApplications.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 198);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(204, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(6, 145);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(225, 23);
            txtDestination.TabIndex = 6;
            // 
            // txtPassangerName
            // 
            txtPassangerName.Location = new Point(6, 91);
            txtPassangerName.Name = "txtPassangerName";
            txtPassangerName.Size = new Size(225, 23);
            txtPassangerName.TabIndex = 5;
            // 
            // txtFlightNumber
            // 
            txtFlightNumber.Location = new Point(6, 40);
            txtFlightNumber.Name = "txtFlightNumber";
            txtFlightNumber.Size = new Size(225, 23);
            txtFlightNumber.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 127);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 3;
            label4.Text = "Пункт назначения:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 180);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Дата вылета:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 73);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "ФИО пассажира:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 22);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Номер рейса:";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(21, 466);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(102, 41);
            btnClose.TabIndex = 12;
            btnClose.Text = "Выход";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(789, 428);
            button1.Name = "button1";
            button1.Size = new Size(76, 97);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 519);
            Controls.Add(button1);
            Controls.Add(btnClose);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Авиабилеты";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtFlightNumber;
        private TextBox txtPassangerName;
        private TextBox txtDestination;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox txtApplications;
        private Button btnRemoveApplication;
        private Button btnAddAplication;
        private Button btnClose;
        private Button button1;
        private Label label6;
        private TextBox txtAllApplications;
        private Button btnAllApplications;
    }
}