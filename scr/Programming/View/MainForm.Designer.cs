﻿namespace Programming.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EnumTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.ChooseSeasonComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.OutLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.FilmsGroupBox = new System.Windows.Forms.GroupBox();
            this.Genre = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.FindFilmButton = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DurationInMinutesTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.CollisionLabel = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CoordinateYTextBox = new System.Windows.Forms.TextBox();
            this.CoordinateXTextBox = new System.Windows.Forms.TextBox();
            this.FindRectangleButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBoxInClasses = new System.Windows.Forms.ListBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeletePictureBox = new System.Windows.Forms.PictureBox();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.HeightPanelTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesPanelListBox = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.IdPanelTextBox = new System.Windows.Forms.TextBox();
            this.WidthPanelTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.YPanelTextBox = new System.Windows.Forms.TextBox();
            this.XPanelTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.RectanglePanel = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EnumTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.FilmsGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EnumTabPage
            // 
            this.EnumTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumTabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumTabPage.Controls.Add(this.EnumerationsGroupBox);
            this.EnumTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumTabPage.Name = "EnumTabPage";
            this.EnumTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumTabPage.Size = new System.Drawing.Size(730, 433);
            this.EnumTabPage.TabIndex = 0;
            this.EnumTabPage.Text = "Enums";
            this.EnumTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.label5);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(359, 190);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(363, 235);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(182, 37);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(76, 21);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ChooseSeasonComboBox
            // 
            this.ChooseSeasonComboBox.FormattingEnabled = true;
            this.ChooseSeasonComboBox.Location = new System.Drawing.Point(6, 36);
            this.ChooseSeasonComboBox.Name = "ChooseSeasonComboBox";
            this.ChooseSeasonComboBox.Size = new System.Drawing.Size(167, 21);
            this.ChooseSeasonComboBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose season:";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.OutLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseInput);
            this.WeekdayParsingGroupBox.Controls.Add(this.label4);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(8, 190);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(345, 235);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // OutLabel
            // 
            this.OutLabel.AutoSize = true;
            this.OutLabel.Location = new System.Drawing.Point(6, 60);
            this.OutLabel.Name = "OutLabel";
            this.OutLabel.Size = new System.Drawing.Size(0, 13);
            this.OutLabel.TabIndex = 3;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(179, 37);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(70, 20);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseInput
            // 
            this.ParseInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParseInput.Location = new System.Drawing.Point(6, 37);
            this.ParseInput.Name = "ParseInput";
            this.ParseInput.Size = new System.Drawing.Size(167, 20);
            this.ParseInput.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type value for parsing:";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.IntBox);
            this.EnumerationsGroupBox.Controls.Add(this.label3);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.label2);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Controls.Add(this.label1);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(8, 6);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(714, 178);
            this.EnumerationsGroupBox.TabIndex = 0;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // IntBox
            // 
            this.IntBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntBox.Enabled = false;
            this.IntBox.Location = new System.Drawing.Point(351, 36);
            this.IntBox.Name = "IntBox";
            this.IntBox.Size = new System.Drawing.Size(122, 20);
            this.IntBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.IntegralHeight = false;
            this.ValuesListBox.Location = new System.Drawing.Point(179, 36);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(141, 119);
            this.ValuesListBox.TabIndex = 3;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.IntegralHeight = false;
            this.EnumsListBox.Location = new System.Drawing.Point(6, 36);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(141, 119);
            this.EnumsListBox.TabIndex = 1;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose enumerations:";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumTabPage);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(738, 459);
            this.TabControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.FilmsGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(730, 433);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // FilmsGroupBox
            // 
            this.FilmsGroupBox.Controls.Add(this.Genre);
            this.FilmsGroupBox.Controls.Add(this.label10);
            this.FilmsGroupBox.Controls.Add(this.GenreTextBox);
            this.FilmsGroupBox.Controls.Add(this.FindFilmButton);
            this.FilmsGroupBox.Controls.Add(this.TitleTextBox);
            this.FilmsGroupBox.Controls.Add(this.MoviesListBox);
            this.FilmsGroupBox.Controls.Add(this.label9);
            this.FilmsGroupBox.Controls.Add(this.label7);
            this.FilmsGroupBox.Controls.Add(this.DurationInMinutesTextBox);
            this.FilmsGroupBox.Controls.Add(this.label6);
            this.FilmsGroupBox.Controls.Add(this.YearTextBox);
            this.FilmsGroupBox.Controls.Add(this.RatingTextBox);
            this.FilmsGroupBox.Location = new System.Drawing.Point(362, 6);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(360, 419);
            this.FilmsGroupBox.TabIndex = 2;
            this.FilmsGroupBox.TabStop = false;
            this.FilmsGroupBox.Text = "Movies";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(157, 65);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(42, 13);
            this.Genre.TabIndex = 18;
            this.Genre.Text = "Genre: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Title: ";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(158, 81);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(120, 20);
            this.GenreTextBox.TabIndex = 16;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // FindFilmButton
            // 
            this.FindFilmButton.Location = new System.Drawing.Point(6, 280);
            this.FindFilmButton.Name = "FindFilmButton";
            this.FindFilmButton.Size = new System.Drawing.Size(123, 23);
            this.FindFilmButton.TabIndex = 14;
            this.FindFilmButton.Text = "Find";
            this.FindFilmButton.UseVisualStyleBackColor = true;
            this.FindFilmButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(158, 36);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(120, 20);
            this.TitleTextBox.TabIndex = 15;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.IntegralHeight = false;
            this.MoviesListBox.Location = new System.Drawing.Point(6, 24);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(123, 227);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Rating: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Year: ";
            // 
            // DurationInMinutesTextBox
            // 
            this.DurationInMinutesTextBox.Location = new System.Drawing.Point(158, 126);
            this.DurationInMinutesTextBox.Name = "DurationInMinutesTextBox";
            this.DurationInMinutesTextBox.Size = new System.Drawing.Size(120, 20);
            this.DurationInMinutesTextBox.TabIndex = 7;
            this.DurationInMinutesTextBox.TextChanged += new System.EventHandler(this.DurationInMinutesTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Duration (in minutes): ";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(160, 231);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(118, 20);
            this.YearTextBox.TabIndex = 8;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(160, 178);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(118, 20);
            this.RatingTextBox.TabIndex = 10;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.CollisionLabel);
            this.RectanglesGroupBox.Controls.Add(this.Label13);
            this.RectanglesGroupBox.Controls.Add(this.IDTextBox);
            this.RectanglesGroupBox.Controls.Add(this.label12);
            this.RectanglesGroupBox.Controls.Add(this.label11);
            this.RectanglesGroupBox.Controls.Add(this.CoordinateYTextBox);
            this.RectanglesGroupBox.Controls.Add(this.CoordinateXTextBox);
            this.RectanglesGroupBox.Controls.Add(this.FindRectangleButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.label8);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBoxInClasses);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.LenghtLabel);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(8, 6);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(348, 419);
            this.RectanglesGroupBox.TabIndex = 1;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // CollisionLabel
            // 
            this.CollisionLabel.AutoSize = true;
            this.CollisionLabel.Location = new System.Drawing.Point(6, 313);
            this.CollisionLabel.Name = "CollisionLabel";
            this.CollisionLabel.Size = new System.Drawing.Size(41, 13);
            this.CollisionLabel.TabIndex = 13;
            this.CollisionLabel.Text = "label14";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(158, 21);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(23, 13);
            this.Label13.TabIndex = 12;
            this.Label13.Text = "lD: ";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(161, 36);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(120, 20);
            this.IDTextBox.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Center (Y coordinate): ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Center (X coordinate): ";
            // 
            // CoordinateYTextBox
            // 
            this.CoordinateYTextBox.Location = new System.Drawing.Point(161, 280);
            this.CoordinateYTextBox.Name = "CoordinateYTextBox";
            this.CoordinateYTextBox.ReadOnly = true;
            this.CoordinateYTextBox.Size = new System.Drawing.Size(120, 20);
            this.CoordinateYTextBox.TabIndex = 8;
            // 
            // CoordinateXTextBox
            // 
            this.CoordinateXTextBox.Location = new System.Drawing.Point(161, 231);
            this.CoordinateXTextBox.Name = "CoordinateXTextBox";
            this.CoordinateXTextBox.ReadOnly = true;
            this.CoordinateXTextBox.Size = new System.Drawing.Size(120, 20);
            this.CoordinateXTextBox.TabIndex = 7;
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Location = new System.Drawing.Point(6, 278);
            this.FindRectangleButton.Name = "FindRectangleButton";
            this.FindRectangleButton.Size = new System.Drawing.Size(123, 23);
            this.FindRectangleButton.TabIndex = 6;
            this.FindRectangleButton.Text = "Find";
            this.FindRectangleButton.UseVisualStyleBackColor = true;
            this.FindRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(161, 178);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(120, 20);
            this.ColorTextBox.TabIndex = 2;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(161, 81);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(120, 20);
            this.LengthTextBox.TabIndex = 1;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Color: ";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(161, 126);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(120, 20);
            this.WidthTextBox.TabIndex = 0;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // RectanglesListBoxInClasses
            // 
            this.RectanglesListBoxInClasses.FormattingEnabled = true;
            this.RectanglesListBoxInClasses.IntegralHeight = false;
            this.RectanglesListBoxInClasses.Location = new System.Drawing.Point(6, 20);
            this.RectanglesListBoxInClasses.Name = "RectanglesListBoxInClasses";
            this.RectanglesListBoxInClasses.Size = new System.Drawing.Size(123, 231);
            this.RectanglesListBoxInClasses.TabIndex = 0;
            this.RectanglesListBoxInClasses.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(158, 110);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(41, 13);
            this.WidthLabel.TabIndex = 4;
            this.WidthLabel.Text = "Width: ";
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Location = new System.Drawing.Point(158, 65);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(46, 13);
            this.LenghtLabel.TabIndex = 3;
            this.LenghtLabel.Text = "Length: ";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeletePictureBox);
            this.tabPage1.Controls.Add(this.AddPictureBox);
            this.tabPage1.Controls.Add(this.HeightPanelTextBox);
            this.tabPage1.Controls.Add(this.RectanglesPanelListBox);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.IdPanelTextBox);
            this.tabPage1.Controls.Add(this.WidthPanelTextBox);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.YPanelTextBox);
            this.tabPage1.Controls.Add(this.XPanelTextBox);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.RectanglePanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(730, 433);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Rectangles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DeletePictureBox
            // 
            this.DeletePictureBox.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.DeletePictureBox.Location = new System.Drawing.Point(145, 198);
            this.DeletePictureBox.Name = "DeletePictureBox";
            this.DeletePictureBox.Size = new System.Drawing.Size(62, 49);
            this.DeletePictureBox.TabIndex = 25;
            this.DeletePictureBox.TabStop = false;
            this.DeletePictureBox.Click += new System.EventHandler(this.DeletePictureBox_Click);
            this.DeletePictureBox.MouseEnter += new System.EventHandler(this.DeletePictureBox_MouseEnter);
            this.DeletePictureBox.MouseLeave += new System.EventHandler(this.DeletePictureBox_MouseLeave);
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddPictureBox.Location = new System.Drawing.Point(30, 198);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(62, 49);
            this.AddPictureBox.TabIndex = 24;
            this.AddPictureBox.TabStop = false;
            this.AddPictureBox.Click += new System.EventHandler(this.AddPictureBox_Click);
            this.AddPictureBox.MouseEnter += new System.EventHandler(this.AddPictureBox_MouseEnter);
            this.AddPictureBox.MouseLeave += new System.EventHandler(this.AddPictureBox_MouseLeave);
            // 
            // HeightPanelTextBox
            // 
            this.HeightPanelTextBox.Location = new System.Drawing.Point(53, 331);
            this.HeightPanelTextBox.Name = "HeightPanelTextBox";
            this.HeightPanelTextBox.Size = new System.Drawing.Size(120, 20);
            this.HeightPanelTextBox.TabIndex = 14;
            this.HeightPanelTextBox.TextChanged += new System.EventHandler(this.HeightPanelTextBox_TextChanged);
            // 
            // RectanglesPanelListBox
            // 
            this.RectanglesPanelListBox.FormattingEnabled = true;
            this.RectanglesPanelListBox.Location = new System.Drawing.Point(8, 6);
            this.RectanglesPanelListBox.Name = "RectanglesPanelListBox";
            this.RectanglesPanelListBox.Size = new System.Drawing.Size(221, 186);
            this.RectanglesPanelListBox.TabIndex = 23;
            this.RectanglesPanelListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesPanelListBox_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1, 334);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Hength: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 256);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "lD: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 360);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Width: ";
            // 
            // IdPanelTextBox
            // 
            this.IdPanelTextBox.Location = new System.Drawing.Point(53, 253);
            this.IdPanelTextBox.Name = "IdPanelTextBox";
            this.IdPanelTextBox.ReadOnly = true;
            this.IdPanelTextBox.Size = new System.Drawing.Size(120, 20);
            this.IdPanelTextBox.TabIndex = 21;
            // 
            // WidthPanelTextBox
            // 
            this.WidthPanelTextBox.Location = new System.Drawing.Point(53, 357);
            this.WidthPanelTextBox.Name = "WidthPanelTextBox";
            this.WidthPanelTextBox.Size = new System.Drawing.Size(120, 20);
            this.WidthPanelTextBox.TabIndex = 13;
            this.WidthPanelTextBox.TextChanged += new System.EventHandler(this.WidthPanelTextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 308);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Y: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 282);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "X: ";
            // 
            // YPanelTextBox
            // 
            this.YPanelTextBox.Location = new System.Drawing.Point(53, 305);
            this.YPanelTextBox.Name = "YPanelTextBox";
            this.YPanelTextBox.Size = new System.Drawing.Size(120, 20);
            this.YPanelTextBox.TabIndex = 18;
            this.YPanelTextBox.TextChanged += new System.EventHandler(this.YPanelTextBox_TextChanged);
            // 
            // XPanelTextBox
            // 
            this.XPanelTextBox.Location = new System.Drawing.Point(53, 279);
            this.XPanelTextBox.Name = "XPanelTextBox";
            this.XPanelTextBox.Size = new System.Drawing.Size(120, 20);
            this.XPanelTextBox.TabIndex = 17;
            this.XPanelTextBox.TextChanged += new System.EventHandler(this.XPanelTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Selected Rectangle: ";
            // 
            // RectanglePanel
            // 
            this.RectanglePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglePanel.Location = new System.Drawing.Point(235, 6);
            this.RectanglePanel.Name = "RectanglePanel";
            this.RectanglePanel.Size = new System.Drawing.Size(487, 419);
            this.RectanglePanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 459);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.EnumTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage EnumTabPage;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IntBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParseInput;
        private System.Windows.Forms.Label OutLabel;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ComboBox ChooseSeasonComboBox;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label LenghtLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button FindRectangleButton;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.ListBox RectanglesListBoxInClasses;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox FilmsGroupBox;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DurationInMinutesTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Button FindFilmButton;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CoordinateYTextBox;
        private System.Windows.Forms.TextBox CoordinateXTextBox;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label CollisionLabel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox DeletePictureBox;
        private System.Windows.Forms.PictureBox AddPictureBox;
        private System.Windows.Forms.TextBox HeightPanelTextBox;
        private System.Windows.Forms.ListBox RectanglesPanelListBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox IdPanelTextBox;
        private System.Windows.Forms.TextBox WidthPanelTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox YPanelTextBox;
        private System.Windows.Forms.TextBox XPanelTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel RectanglePanel;
    }
}

