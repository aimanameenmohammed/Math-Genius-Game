using System.Drawing;
using System.Windows.Forms;

namespace MyMathGame
{
    partial class frmMathGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMathGame));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.plShowFinalResult = new System.Windows.Forms.Panel();
            this.txtMissedQuestion = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtTotalquestion = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnREPLAY = new System.Windows.Forms.Button();
            this.txtOP = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtTimeQuestion = new System.Windows.Forms.TextBox();
            this.txtFalseAnswer = new System.Windows.Forms.TextBox();
            this.txtCurrectAnswer = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPersecond = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmLimittimeforQuestion = new System.Windows.Forms.NumericUpDown();
            this.lbshowselectAnswer = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.plShowSetting = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTotalQuestions = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbDidQuestion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pgLimiteQuestion = new System.Windows.Forms.ProgressBar();
            this.lbQuestion = new System.Windows.Forms.Panel();
            this.lbShowQuestions = new System.Windows.Forms.Label();
            this.btnShow4 = new System.Windows.Forms.Button();
            this.btnShow3 = new System.Windows.Forms.Button();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.btnShow1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdMixOperaions = new System.Windows.Forms.RadioButton();
            this.lbTypeSelectOfOperation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdPlus = new System.Windows.Forms.RadioButton();
            this.rdMinus = new System.Windows.Forms.RadioButton();
            this.rdDivide = new System.Windows.Forms.RadioButton();
            this.rdMultiplication = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdMIX = new System.Windows.Forms.RadioButton();
            this.rdHARD = new System.Windows.Forms.RadioButton();
            this.rdMEDIUM = new System.Windows.Forms.RadioButton();
            this.rdEASY = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nmTotalOfQuestion = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartChallenge = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbNumberOfMusic = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.rdOFFMusic = new System.Windows.Forms.RadioButton();
            this.rdONMusic = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.plShowPictureMusic = new System.Windows.Forms.Panel();
            this.plPrevousMusic = new System.Windows.Forms.Panel();
            this.plNextMusic = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabPage1.SuspendLayout();
            this.plShowFinalResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLimittimeforQuestion)).BeginInit();
            this.plShowSetting.SuspendLayout();
            this.lbQuestion.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTotalOfQuestion)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tabPage1.Controls.Add(this.plShowFinalResult);
            this.tabPage1.Controls.Add(this.txtPersecond);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.nmLimittimeforQuestion);
            this.tabPage1.Controls.Add(this.lbshowselectAnswer);
            this.tabPage1.Controls.Add(this.btnRestart);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.lbTimer);
            this.tabPage1.Controls.Add(this.plShowSetting);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.lbTotalQuestions);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.lbDidQuestion);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.pgLimiteQuestion);
            this.tabPage1.Controls.Add(this.lbQuestion);
            this.tabPage1.Controls.Add(this.btnShow4);
            this.tabPage1.Controls.Add(this.btnShow3);
            this.tabPage1.Controls.Add(this.btnShow2);
            this.tabPage1.Controls.Add(this.btnShow1);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.btnStartChallenge);
            this.tabPage1.Font = new System.Drawing.Font("Engravers MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Silver;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1003, 826);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // plShowFinalResult
            // 
            this.plShowFinalResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.plShowFinalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plShowFinalResult.Controls.Add(this.txtMissedQuestion);
            this.plShowFinalResult.Controls.Add(this.label30);
            this.plShowFinalResult.Controls.Add(this.txtTotalquestion);
            this.plShowFinalResult.Controls.Add(this.label29);
            this.plShowFinalResult.Controls.Add(this.btnREPLAY);
            this.plShowFinalResult.Controls.Add(this.txtOP);
            this.plShowFinalResult.Controls.Add(this.txtLevel);
            this.plShowFinalResult.Controls.Add(this.txtTimeQuestion);
            this.plShowFinalResult.Controls.Add(this.txtFalseAnswer);
            this.plShowFinalResult.Controls.Add(this.txtCurrectAnswer);
            this.plShowFinalResult.Controls.Add(this.label28);
            this.plShowFinalResult.Controls.Add(this.label27);
            this.plShowFinalResult.Controls.Add(this.label26);
            this.plShowFinalResult.Controls.Add(this.label25);
            this.plShowFinalResult.Controls.Add(this.label24);
            this.plShowFinalResult.Controls.Add(this.label11);
            this.plShowFinalResult.Controls.Add(this.label9);
            this.plShowFinalResult.ForeColor = System.Drawing.Color.Transparent;
            this.plShowFinalResult.Location = new System.Drawing.Point(238, 77);
            this.plShowFinalResult.Name = "plShowFinalResult";
            this.plShowFinalResult.Size = new System.Drawing.Size(581, 628);
            this.plShowFinalResult.TabIndex = 64;
            this.plShowFinalResult.Visible = false;
            // 
            // txtMissedQuestion
            // 
            this.txtMissedQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtMissedQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMissedQuestion.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMissedQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtMissedQuestion.Location = new System.Drawing.Point(442, 260);
            this.txtMissedQuestion.Multiline = true;
            this.txtMissedQuestion.Name = "txtMissedQuestion";
            this.txtMissedQuestion.ReadOnly = true;
            this.txtMissedQuestion.Size = new System.Drawing.Size(98, 38);
            this.txtMissedQuestion.TabIndex = 79;
            this.txtMissedQuestion.Text = "10";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Silver;
            this.label30.Location = new System.Drawing.Point(62, 260);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(362, 37);
            this.label30.TabIndex = 78;
            this.label30.Text = "MISSED QUESTION  :";
            // 
            // txtTotalquestion
            // 
            this.txtTotalquestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtTotalquestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalquestion.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalquestion.ForeColor = System.Drawing.Color.Khaki;
            this.txtTotalquestion.Location = new System.Drawing.Point(420, 100);
            this.txtTotalquestion.Multiline = true;
            this.txtTotalquestion.Name = "txtTotalquestion";
            this.txtTotalquestion.ReadOnly = true;
            this.txtTotalquestion.Size = new System.Drawing.Size(159, 38);
            this.txtTotalquestion.TabIndex = 77;
            this.txtTotalquestion.Text = "10";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Silver;
            this.label29.Location = new System.Drawing.Point(66, 98);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(333, 37);
            this.label29.TabIndex = 76;
            this.label29.Text = "TOTAL QUESTION :";
            // 
            // btnREPLAY
            // 
            this.btnREPLAY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnREPLAY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnREPLAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREPLAY.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREPLAY.ForeColor = System.Drawing.Color.LightGreen;
            this.btnREPLAY.Location = new System.Drawing.Point(131, 538);
            this.btnREPLAY.Name = "btnREPLAY";
            this.btnREPLAY.Size = new System.Drawing.Size(323, 60);
            this.btnREPLAY.TabIndex = 75;
            this.btnREPLAY.Text = "REPLAY";
            this.btnREPLAY.UseVisualStyleBackColor = false;
            this.btnREPLAY.Click += new System.EventHandler(this.btnRestart_Click);
            this.btnREPLAY.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.btnREPLAY.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // txtOP
            // 
            this.txtOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtOP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOP.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOP.ForeColor = System.Drawing.Color.Moccasin;
            this.txtOP.Location = new System.Drawing.Point(195, 433);
            this.txtOP.Multiline = true;
            this.txtOP.Name = "txtOP";
            this.txtOP.ReadOnly = true;
            this.txtOP.Size = new System.Drawing.Size(259, 38);
            this.txtOP.TabIndex = 74;
            this.txtOP.Text = "DIVISION";
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLevel.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevel.ForeColor = System.Drawing.Color.LightGreen;
            this.txtLevel.Location = new System.Drawing.Point(235, 373);
            this.txtLevel.Multiline = true;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(259, 38);
            this.txtLevel.TabIndex = 73;
            this.txtLevel.Text = "EASY";
            // 
            // txtTimeQuestion
            // 
            this.txtTimeQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtTimeQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimeQuestion.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeQuestion.ForeColor = System.Drawing.Color.Khaki;
            this.txtTimeQuestion.Location = new System.Drawing.Point(391, 318);
            this.txtTimeQuestion.Multiline = true;
            this.txtTimeQuestion.Name = "txtTimeQuestion";
            this.txtTimeQuestion.ReadOnly = true;
            this.txtTimeQuestion.Size = new System.Drawing.Size(159, 38);
            this.txtTimeQuestion.TabIndex = 72;
            this.txtTimeQuestion.Text = "10S";
            // 
            // txtFalseAnswer
            // 
            this.txtFalseAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtFalseAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFalseAnswer.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFalseAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtFalseAnswer.Location = new System.Drawing.Point(320, 205);
            this.txtFalseAnswer.Multiline = true;
            this.txtFalseAnswer.Name = "txtFalseAnswer";
            this.txtFalseAnswer.ReadOnly = true;
            this.txtFalseAnswer.Size = new System.Drawing.Size(98, 38);
            this.txtFalseAnswer.TabIndex = 71;
            this.txtFalseAnswer.Text = "10";
            // 
            // txtCurrectAnswer
            // 
            this.txtCurrectAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCurrectAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrectAnswer.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrectAnswer.ForeColor = System.Drawing.Color.LightGreen;
            this.txtCurrectAnswer.Location = new System.Drawing.Point(277, 154);
            this.txtCurrectAnswer.Multiline = true;
            this.txtCurrectAnswer.Name = "txtCurrectAnswer";
            this.txtCurrectAnswer.ReadOnly = true;
            this.txtCurrectAnswer.Size = new System.Drawing.Size(109, 38);
            this.txtCurrectAnswer.TabIndex = 70;
            this.txtCurrectAnswer.Text = "10";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Silver;
            this.label28.Location = new System.Drawing.Point(70, 433);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(81, 37);
            this.label28.TabIndex = 69;
            this.label28.Text = "OP :";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Silver;
            this.label27.Location = new System.Drawing.Point(70, 377);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(134, 37);
            this.label27.TabIndex = 68;
            this.label27.Text = "lEVEL :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Silver;
            this.label26.Location = new System.Drawing.Point(62, 317);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(314, 37);
            this.label26.TabIndex = 67;
            this.label26.Text = "TIME/QUESTION :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Silver;
            this.label25.Location = new System.Drawing.Point(65, 208);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(239, 37);
            this.label25.TabIndex = 66;
            this.label25.Text = "INCURRECT :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Silver;
            this.label24.Location = new System.Drawing.Point(66, 152);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(199, 37);
            this.label24.TabIndex = 65;
            this.label24.Text = "CURRECT :";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label11.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(148, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(289, 3);
            this.label11.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(130, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(302, 42);
            this.label9.TabIndex = 63;
            this.label9.Text = "YOUR RESULT";
            // 
            // txtPersecond
            // 
            this.txtPersecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPersecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersecond.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersecond.ForeColor = System.Drawing.Color.LightGreen;
            this.txtPersecond.Location = new System.Drawing.Point(481, 90);
            this.txtPersecond.Multiline = true;
            this.txtPersecond.Name = "txtPersecond";
            this.txtPersecond.ReadOnly = true;
            this.txtPersecond.Size = new System.Drawing.Size(100, 38);
            this.txtPersecond.TabIndex = 63;
            this.txtPersecond.Text = "10s";
            this.txtPersecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(189, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 22);
            this.label7.TabIndex = 62;
            this.label7.Text = "TIME PER QUESTION(sec)";
            // 
            // nmLimittimeforQuestion
            // 
            this.nmLimittimeforQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.nmLimittimeforQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmLimittimeforQuestion.ForeColor = System.Drawing.Color.Silver;
            this.nmLimittimeforQuestion.Location = new System.Drawing.Point(213, 94);
            this.nmLimittimeforQuestion.Name = "nmLimittimeforQuestion";
            this.nmLimittimeforQuestion.Size = new System.Drawing.Size(232, 34);
            this.nmLimittimeforQuestion.TabIndex = 61;
            this.nmLimittimeforQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmLimittimeforQuestion.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmLimittimeforQuestion.ValueChanged += new System.EventHandler(this.nmLimittimeforQuestion_ValueChanged);
            // 
            // lbshowselectAnswer
            // 
            this.lbshowselectAnswer.AutoSize = true;
            this.lbshowselectAnswer.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbshowselectAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbshowselectAnswer.Location = new System.Drawing.Point(420, 134);
            this.lbshowselectAnswer.Name = "lbshowselectAnswer";
            this.lbshowselectAnswer.Size = new System.Drawing.Size(214, 26);
            this.lbshowselectAnswer.TabIndex = 60;
            this.lbshowselectAnswer.Text = "Select Your Answer!";
            this.lbshowselectAnswer.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Gold;
            this.btnRestart.Location = new System.Drawing.Point(456, 451);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(158, 36);
            this.btnRestart.TabIndex = 59;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            this.btnRestart.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.btnRestart.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnNext.Location = new System.Drawing.Point(456, 380);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(158, 36);
            this.btnNext.TabIndex = 58;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.btnNext.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.Silver;
            this.lbTimer.Location = new System.Drawing.Point(64, 6);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(48, 20);
            this.lbTimer.TabIndex = 57;
            this.lbTimer.Text = "Time";
            // 
            // plShowSetting
            // 
            this.plShowSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.plShowSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plShowSetting.Controls.Add(this.panel10);
            this.plShowSetting.Controls.Add(this.panel9);
            this.plShowSetting.Controls.Add(this.panel8);
            this.plShowSetting.Controls.Add(this.panel7);
            this.plShowSetting.Controls.Add(this.button8);
            this.plShowSetting.Controls.Add(this.button7);
            this.plShowSetting.Controls.Add(this.button6);
            this.plShowSetting.Location = new System.Drawing.Point(799, 101);
            this.plShowSetting.Name = "plShowSetting";
            this.plShowSetting.Size = new System.Drawing.Size(189, 272);
            this.plShowSetting.TabIndex = 56;
            this.plShowSetting.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Location = new System.Drawing.Point(0, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(60, 56);
            this.panel10.TabIndex = 7;
            this.panel10.Click += new System.EventHandler(this.panel10_Click_1);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Location = new System.Drawing.Point(5, 133);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(42, 37);
            this.panel9.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(4, 192);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(42, 37);
            this.panel8.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(5, 77);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(42, 37);
            this.panel7.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Silver;
            this.button8.Location = new System.Drawing.Point(51, 192);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 37);
            this.button8.TabIndex = 3;
            this.button8.Text = "About Me";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            this.button8.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.button8.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Silver;
            this.button7.Location = new System.Drawing.Point(51, 133);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 37);
            this.button7.TabIndex = 2;
            this.button7.Text = "Audio Mix";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.button7.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(51, 77);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 37);
            this.button6.TabIndex = 1;
            this.button6.Text = "Language";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.button6.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(886, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(90, 61);
            this.panel6.TabIndex = 55;
            this.panel6.Click += new System.EventHandler(this.panel6_Click_1);
            // 
            // label12
            // 
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(296, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(544, 47);
            this.label12.TabIndex = 54;
            this.label12.Text = "MATH GENIUS CHALLENGE";
            // 
            // lbTotalQuestions
            // 
            this.lbTotalQuestions.AutoSize = true;
            this.lbTotalQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalQuestions.ForeColor = System.Drawing.Color.Gray;
            this.lbTotalQuestions.Location = new System.Drawing.Point(341, 135);
            this.lbTotalQuestions.Name = "lbTotalQuestions";
            this.lbTotalQuestions.Size = new System.Drawing.Size(23, 25);
            this.lbTotalQuestions.TabIndex = 53;
            this.lbTotalQuestions.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(324, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 25);
            this.label10.TabIndex = 52;
            this.label10.Text = "/";
            // 
            // lbDidQuestion
            // 
            this.lbDidQuestion.AutoSize = true;
            this.lbDidQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDidQuestion.ForeColor = System.Drawing.Color.Gray;
            this.lbDidQuestion.Location = new System.Drawing.Point(296, 135);
            this.lbDidQuestion.Name = "lbDidQuestion";
            this.lbDidQuestion.Size = new System.Drawing.Size(23, 25);
            this.lbDidQuestion.TabIndex = 51;
            this.lbDidQuestion.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(202, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 50;
            this.label8.Text = "Question";
            // 
            // pgLimiteQuestion
            // 
            this.pgLimiteQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(27)))));
            this.pgLimiteQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(27)))));
            this.pgLimiteQuestion.Location = new System.Drawing.Point(211, 166);
            this.pgLimiteQuestion.Name = "pgLimiteQuestion";
            this.pgLimiteQuestion.Size = new System.Drawing.Size(627, 10);
            this.pgLimiteQuestion.TabIndex = 49;
            // 
            // lbQuestion
            // 
            this.lbQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lbQuestion.Controls.Add(this.lbShowQuestions);
            this.lbQuestion.ForeColor = System.Drawing.Color.Silver;
            this.lbQuestion.Location = new System.Drawing.Point(211, 180);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(627, 135);
            this.lbQuestion.TabIndex = 48;
            // 
            // lbShowQuestions
            // 
            this.lbShowQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lbShowQuestions.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbShowQuestions.Location = new System.Drawing.Point(3, 0);
            this.lbShowQuestions.Name = "lbShowQuestions";
            this.lbShowQuestions.Size = new System.Drawing.Size(627, 135);
            this.lbShowQuestions.TabIndex = 0;
            this.lbShowQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShow4
            // 
            this.btnShow4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnShow4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnShow4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnShow4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow4.ForeColor = System.Drawing.Color.Silver;
            this.btnShow4.Location = new System.Drawing.Point(651, 426);
            this.btnShow4.Name = "btnShow4";
            this.btnShow4.Size = new System.Drawing.Size(208, 36);
            this.btnShow4.TabIndex = 47;
            this.btnShow4.Tag = "4";
            this.btnShow4.UseVisualStyleBackColor = false;
            this.btnShow4.Click += new System.EventHandler(this.CheckAswer_Click);
            // 
            // btnShow3
            // 
            this.btnShow3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnShow3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnShow3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnShow3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow3.ForeColor = System.Drawing.Color.Silver;
            this.btnShow3.Location = new System.Drawing.Point(206, 426);
            this.btnShow3.Name = "btnShow3";
            this.btnShow3.Size = new System.Drawing.Size(202, 36);
            this.btnShow3.TabIndex = 46;
            this.btnShow3.Tag = "3";
            this.btnShow3.UseVisualStyleBackColor = false;
            this.btnShow3.Click += new System.EventHandler(this.CheckAswer_Click);
            // 
            // btnShow2
            // 
            this.btnShow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnShow2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnShow2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnShow2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow2.ForeColor = System.Drawing.Color.Silver;
            this.btnShow2.Location = new System.Drawing.Point(651, 337);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(208, 36);
            this.btnShow2.TabIndex = 45;
            this.btnShow2.Tag = "2";
            this.btnShow2.UseVisualStyleBackColor = false;
            this.btnShow2.Click += new System.EventHandler(this.CheckAswer_Click);
            // 
            // btnShow1
            // 
            this.btnShow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnShow1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnShow1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnShow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow1.ForeColor = System.Drawing.Color.Silver;
            this.btnShow1.Location = new System.Drawing.Point(206, 337);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(202, 36);
            this.btnShow1.TabIndex = 44;
            this.btnShow1.Tag = "1";
            this.btnShow1.UseVisualStyleBackColor = false;
            this.btnShow1.Click += new System.EventHandler(this.CheckAswer_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.rdMixOperaions);
            this.panel4.Controls.Add(this.lbTypeSelectOfOperation);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.rdPlus);
            this.panel4.Controls.Add(this.rdMinus);
            this.panel4.Controls.Add(this.rdDivide);
            this.panel4.Controls.Add(this.rdMultiplication);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(392, 508);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 202);
            this.panel4.TabIndex = 42;
            // 
            // rdMixOperaions
            // 
            this.rdMixOperaions.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdMixOperaions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.rdMixOperaions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdMixOperaions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdMixOperaions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdMixOperaions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMixOperaions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdMixOperaions.Location = new System.Drawing.Point(102, 97);
            this.rdMixOperaions.Name = "rdMixOperaions";
            this.rdMixOperaions.Size = new System.Drawing.Size(72, 31);
            this.rdMixOperaions.TabIndex = 13;
            this.rdMixOperaions.Tag = "MIX";
            this.rdMixOperaions.Text = "Mix";
            this.rdMixOperaions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdMixOperaions.UseVisualStyleBackColor = false;
            this.rdMixOperaions.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            this.rdMixOperaions.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.rdMixOperaions.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // lbTypeSelectOfOperation
            // 
            this.lbTypeSelectOfOperation.BackColor = System.Drawing.Color.Transparent;
            this.lbTypeSelectOfOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeSelectOfOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTypeSelectOfOperation.Location = new System.Drawing.Point(129, 146);
            this.lbTypeSelectOfOperation.Name = "lbTypeSelectOfOperation";
            this.lbTypeSelectOfOperation.Size = new System.Drawing.Size(124, 25);
            this.lbTypeSelectOfOperation.TabIndex = 12;
            this.lbTypeSelectOfOperation.Text = "PLUS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(3, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Operations:";
            // 
            // rdPlus
            // 
            this.rdPlus.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.rdPlus.Checked = true;
            this.rdPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.rdPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdPlus.Location = new System.Drawing.Point(20, 44);
            this.rdPlus.Name = "rdPlus";
            this.rdPlus.Size = new System.Drawing.Size(40, 40);
            this.rdPlus.TabIndex = 10;
            this.rdPlus.TabStop = true;
            this.rdPlus.Tag = "PLUS";
            this.rdPlus.Text = "+";
            this.rdPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdPlus.UseVisualStyleBackColor = false;
            this.rdPlus.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            this.rdPlus.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.rdPlus.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // rdMinus
            // 
            this.rdMinus.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.rdMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.rdMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdMinus.Location = new System.Drawing.Point(81, 44);
            this.rdMinus.Name = "rdMinus";
            this.rdMinus.Size = new System.Drawing.Size(42, 39);
            this.rdMinus.TabIndex = 9;
            this.rdMinus.Tag = "MINUS";
            this.rdMinus.Text = "-";
            this.rdMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdMinus.UseVisualStyleBackColor = false;
            this.rdMinus.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            this.rdMinus.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.rdMinus.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // rdDivide
            // 
            this.rdDivide.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.rdDivide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDivide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdDivide.Location = new System.Drawing.Point(144, 44);
            this.rdDivide.Name = "rdDivide";
            this.rdDivide.Size = new System.Drawing.Size(43, 39);
            this.rdDivide.TabIndex = 8;
            this.rdDivide.Tag = "DIVISION";
            this.rdDivide.Text = "/";
            this.rdDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdDivide.UseVisualStyleBackColor = false;
            this.rdDivide.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            this.rdDivide.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.rdDivide.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // rdMultiplication
            // 
            this.rdMultiplication.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.rdMultiplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdMultiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMultiplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdMultiplication.Location = new System.Drawing.Point(206, 42);
            this.rdMultiplication.Name = "rdMultiplication";
            this.rdMultiplication.Size = new System.Drawing.Size(47, 39);
            this.rdMultiplication.TabIndex = 7;
            this.rdMultiplication.Tag = "Multiplication";
            this.rdMultiplication.Text = "X";
            this.rdMultiplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdMultiplication.UseVisualStyleBackColor = false;
            this.rdMultiplication.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            this.rdMultiplication.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.rdMultiplication.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "Operation Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.rdMIX);
            this.panel3.Controls.Add(this.rdHARD);
            this.panel3.Controls.Add(this.rdMEDIUM);
            this.panel3.Controls.Add(this.rdEASY);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(93, 508);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 202);
            this.panel3.TabIndex = 41;
            // 
            // rdMIX
            // 
            this.rdMIX.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdMIX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rdMIX.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.rdMIX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdMIX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdMIX.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdMIX.Location = new System.Drawing.Point(19, 155);
            this.rdMIX.Name = "rdMIX";
            this.rdMIX.Size = new System.Drawing.Size(239, 29);
            this.rdMIX.TabIndex = 14;
            this.rdMIX.Tag = "MIX";
            this.rdMIX.Text = "MIX";
            this.rdMIX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdMIX.UseVisualStyleBackColor = false;
            this.rdMIX.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.rdMIX.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // rdHARD
            // 
            this.rdHARD.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdHARD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.rdHARD.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.rdHARD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdHARD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdHARD.ForeColor = System.Drawing.Color.Tomato;
            this.rdHARD.Location = new System.Drawing.Point(19, 115);
            this.rdHARD.Name = "rdHARD";
            this.rdHARD.Size = new System.Drawing.Size(239, 29);
            this.rdHARD.TabIndex = 13;
            this.rdHARD.Tag = "HARD";
            this.rdHARD.Text = "HARD";
            this.rdHARD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdHARD.UseVisualStyleBackColor = false;
            this.rdHARD.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.rdHARD.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // rdMEDIUM
            // 
            this.rdMEDIUM.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdMEDIUM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(10)))));
            this.rdMEDIUM.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.rdMEDIUM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdMEDIUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdMEDIUM.ForeColor = System.Drawing.Color.Gold;
            this.rdMEDIUM.Location = new System.Drawing.Point(19, 78);
            this.rdMEDIUM.Name = "rdMEDIUM";
            this.rdMEDIUM.Size = new System.Drawing.Size(239, 29);
            this.rdMEDIUM.TabIndex = 12;
            this.rdMEDIUM.Tag = "MEDIUM";
            this.rdMEDIUM.Text = "MEDIUM";
            this.rdMEDIUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdMEDIUM.UseVisualStyleBackColor = false;
            this.rdMEDIUM.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.rdMEDIUM.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // rdEASY
            // 
            this.rdEASY.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdEASY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.rdEASY.Checked = true;
            this.rdEASY.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.rdEASY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdEASY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdEASY.ForeColor = System.Drawing.Color.LimeGreen;
            this.rdEASY.Location = new System.Drawing.Point(19, 39);
            this.rdEASY.Name = "rdEASY";
            this.rdEASY.Size = new System.Drawing.Size(239, 29);
            this.rdEASY.TabIndex = 11;
            this.rdEASY.TabStop = true;
            this.rdEASY.Tag = "EASY";
            this.rdEASY.Text = "EASY";
            this.rdEASY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdEASY.UseVisualStyleBackColor = false;
            this.rdEASY.MouseEnter += new System.EventHandler(this.ChangeColor);
            this.rdEASY.MouseLeave += new System.EventHandler(this.ChangeColor2);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Level";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nmTotalOfQuestion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(679, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 202);
            this.panel2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(57, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Questions";
            // 
            // nmTotalOfQuestion
            // 
            this.nmTotalOfQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.nmTotalOfQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmTotalOfQuestion.ForeColor = System.Drawing.Color.Silver;
            this.nmTotalOfQuestion.Location = new System.Drawing.Point(62, 71);
            this.nmTotalOfQuestion.Name = "nmTotalOfQuestion";
            this.nmTotalOfQuestion.Size = new System.Drawing.Size(152, 34);
            this.nmTotalOfQuestion.TabIndex = 7;
            this.nmTotalOfQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmTotalOfQuestion.ValueChanged += new System.EventHandler(this.nmTotalOfQuestion_ValueChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Question Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStartChallenge
            // 
            this.btnStartChallenge.BackColor = System.Drawing.Color.Gold;
            this.btnStartChallenge.FlatAppearance.BorderSize = 0;
            this.btnStartChallenge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartChallenge.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartChallenge.ForeColor = System.Drawing.Color.Black;
            this.btnStartChallenge.Location = new System.Drawing.Point(330, 741);
            this.btnStartChallenge.Name = "btnStartChallenge";
            this.btnStartChallenge.Size = new System.Drawing.Size(416, 52);
            this.btnStartChallenge.TabIndex = 43;
            this.btnStartChallenge.Text = "START CHALLENGE";
            this.btnStartChallenge.UseVisualStyleBackColor = false;
            this.btnStartChallenge.Click += new System.EventHandler(this.btnStartChallenge_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-65, -27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1011, 855);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tabPage2.BackgroundImage = global::MyMathGame.Properties.Resources._1776113709631;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.panel14);
            this.tabPage2.Controls.Add(this.panel13);
            this.tabPage2.Controls.Add(this.panel12);
            this.tabPage2.Controls.Add(this.panel11);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1003, 826);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel14.BackgroundImage")));
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel14.Location = new System.Drawing.Point(21, 4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(120, 40);
            this.panel14.TabIndex = 17;
            this.panel14.Click += new System.EventHandler(this.GetFirstTab);
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint_1);
            // 
            // panel13
            // 
            this.panel13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel13.BackgroundImage")));
            this.panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel13.Location = new System.Drawing.Point(537, 658);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(38, 43);
            this.panel13.TabIndex = 16;
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Location = new System.Drawing.Point(285, 650);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(45, 43);
            this.panel12.TabIndex = 15;
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel11.BackgroundImage")));
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel11.Location = new System.Drawing.Point(537, 587);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(38, 43);
            this.panel11.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(287, 583);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 39);
            this.panel1.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Gainsboro;
            this.label20.Location = new System.Drawing.Point(581, 665);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(163, 32);
            this.label20.TabIndex = 8;
            this.label20.Text = "Telegram :";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(331, 658);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(180, 32);
            this.label19.TabIndex = 7;
            this.label19.Text = "WhatsApp :";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(586, 594);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(133, 32);
            this.label18.TabIndex = 6;
            this.label18.Text = "GitHub :";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(329, 587);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 32);
            this.label17.TabIndex = 5;
            this.label17.Text = "LinkedIn :";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(345, 517);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(345, 37);
            this.label16.TabIndex = 4;
            this.label16.Text = "my projects and profiles";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(220, 480);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(603, 37);
            this.label15.TabIndex = 3;
            this.label15.Text = "Feel free to connect with me and check out";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.label14.Location = new System.Drawing.Point(278, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(434, 38);
            this.label14.TabIndex = 2;
            this.label14.Text = "(Aiman Ameen Mohammed)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(175, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(703, 111);
            this.label13.TabIndex = 1;
            this.label13.Text = "*This game was carefully crafted and developed by\r\n\r\n      a passionate Computer " +
    "Science student.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.label6.Location = new System.Drawing.Point(275, -5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(456, 60);
            this.label6.TabIndex = 0;
            this.label6.Text = "Developer Profile";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.lbNumberOfMusic);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.rdOFFMusic);
            this.tabPage3.Controls.Add(this.rdONMusic);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.panel15);
            this.tabPage3.Controls.Add(this.plShowPictureMusic);
            this.tabPage3.Controls.Add(this.plPrevousMusic);
            this.tabPage3.Controls.Add(this.plNextMusic);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1003, 826);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(20, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 40);
            this.panel5.TabIndex = 20;
            this.panel5.Click += new System.EventHandler(this.GetFirstTab);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "music.mp3",
            "music2.mp3",
            "music3.mp3"});
            this.comboBox1.Location = new System.Drawing.Point(779, 528);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Visible = false;
            // 
            // lbNumberOfMusic
            // 
            this.lbNumberOfMusic.AutoSize = true;
            this.lbNumberOfMusic.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfMusic.ForeColor = System.Drawing.Color.Silver;
            this.lbNumberOfMusic.Location = new System.Drawing.Point(889, 448);
            this.lbNumberOfMusic.Name = "lbNumberOfMusic";
            this.lbNumberOfMusic.Size = new System.Drawing.Size(42, 42);
            this.lbNumberOfMusic.TabIndex = 10;
            this.lbNumberOfMusic.Text = "3";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Silver;
            this.label23.Location = new System.Drawing.Point(705, 446);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(178, 42);
            this.label23.TabIndex = 9;
            this.label23.Text = "Sound(s)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Silver;
            this.label22.Location = new System.Drawing.Point(197, 401);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(342, 47);
            this.label22.TabIndex = 8;
            this.label22.Text = "Sound && Mousic";
            // 
            // rdOFFMusic
            // 
            this.rdOFFMusic.AutoSize = true;
            this.rdOFFMusic.Checked = true;
            this.rdOFFMusic.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOFFMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdOFFMusic.Location = new System.Drawing.Point(583, 412);
            this.rdOFFMusic.Name = "rdOFFMusic";
            this.rdOFFMusic.Size = new System.Drawing.Size(107, 41);
            this.rdOFFMusic.TabIndex = 7;
            this.rdOFFMusic.TabStop = true;
            this.rdOFFMusic.Text = "OFF";
            this.rdOFFMusic.UseVisualStyleBackColor = true;
            this.rdOFFMusic.CheckedChanged += new System.EventHandler(this.rdOFFMusic_CheckedChanged);
            // 
            // rdONMusic
            // 
            this.rdONMusic.AutoSize = true;
            this.rdONMusic.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdONMusic.ForeColor = System.Drawing.Color.Silver;
            this.rdONMusic.Location = new System.Drawing.Point(583, 483);
            this.rdONMusic.Name = "rdONMusic";
            this.rdONMusic.Size = new System.Drawing.Size(88, 41);
            this.rdONMusic.TabIndex = 6;
            this.rdONMusic.Text = "ON";
            this.rdONMusic.UseVisualStyleBackColor = true;
            this.rdONMusic.CheckedChanged += new System.EventHandler(this.rdONMusic_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Elephant", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Silver;
            this.label21.Location = new System.Drawing.Point(293, 211);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(397, 47);
            this.label21.TabIndex = 5;
            this.label21.Text = "Select Your Mousic";
            // 
            // panel15
            // 
            this.panel15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel15.BackgroundImage")));
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel15.Location = new System.Drawing.Point(-2, -7);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(65, 60);
            this.panel15.TabIndex = 18;
            this.panel15.Click += new System.EventHandler(this.panel15_Click);
            // 
            // plShowPictureMusic
            // 
            this.plShowPictureMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plShowPictureMusic.BackgroundImage")));
            this.plShowPictureMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plShowPictureMusic.Location = new System.Drawing.Point(330, 459);
            this.plShowPictureMusic.Name = "plShowPictureMusic";
            this.plShowPictureMusic.Size = new System.Drawing.Size(66, 63);
            this.plShowPictureMusic.TabIndex = 13;
            // 
            // plPrevousMusic
            // 
            this.plPrevousMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plPrevousMusic.BackgroundImage")));
            this.plPrevousMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plPrevousMusic.Location = new System.Drawing.Point(205, 459);
            this.plPrevousMusic.Name = "plPrevousMusic";
            this.plPrevousMusic.Size = new System.Drawing.Size(51, 63);
            this.plPrevousMusic.TabIndex = 12;
            this.plPrevousMusic.Tag = "2";
            this.plPrevousMusic.Click += new System.EventHandler(this.NextAndPrevousMusic);
            // 
            // plNextMusic
            // 
            this.plNextMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plNextMusic.BackgroundImage")));
            this.plNextMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plNextMusic.Location = new System.Drawing.Point(471, 459);
            this.plNextMusic.Name = "plNextMusic";
            this.plNextMusic.Size = new System.Drawing.Size(51, 63);
            this.plNextMusic.TabIndex = 11;
            this.plNextMusic.Tag = "1";
            this.plNextMusic.Click += new System.EventHandler(this.NextAndPrevousMusic);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(917, 820);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.plShowFinalResult.ResumeLayout(false);
            this.plShowFinalResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLimittimeforQuestion)).EndInit();
            this.plShowSetting.ResumeLayout(false);
            this.lbQuestion.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTotalOfQuestion)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

}

        // أضف هذه الدالة المساعدة أسفل الـ InitializeComponent لجعل الحواف دائرية فعلياً
        private void DrawRoundedEdges(Control ctrl, System.Windows.Forms.PaintEventArgs e, int radius)
        {
            float borderSize = 1f;
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(ctrl.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(ctrl.Width - radius - 1, ctrl.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, ctrl.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();
                ctrl.Region = new System.Drawing.Region(path);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                if (ctrl is Button btn)
                    using (var pen = new System.Drawing.Pen(btn.FlatAppearance.BorderColor, borderSize))
                        e.Graphics.DrawPath(pen, path);
            }
        }
        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel plShowSetting;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Button button8;
        private Button button7;
        private Button button6;
        private Panel panel6;
        private Label label12;
        private Label lbTotalQuestions;
        private Label label10;
        private Label lbDidQuestion;
        private Label label8;
        private ProgressBar pgLimiteQuestion;
        private Panel lbQuestion;
        private Label lbShowQuestions;
        private Button btnShow4;
        private Button btnShow3;
        private Button btnShow2;
        private Button btnShow1;
        private Button btnStartChallenge;
        private Panel panel4;
        private Label lbTypeSelectOfOperation;
        private Label label3;
        private RadioButton rdPlus;
        private RadioButton rdMinus;
        private RadioButton rdDivide;
        private RadioButton rdMultiplication;
        private Label label5;
        private Panel panel3;
        private RadioButton rdMIX;
        private RadioButton rdHARD;
        private RadioButton rdMEDIUM;
        private RadioButton rdEASY;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private NumericUpDown nmTotalOfQuestion;
        private Label label2;
        private TabPage tabPage3;
        private Label label6;
        private Label label14;
        private Label label13;
        private Label label15;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Panel panel1;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private RadioButton rdONMusic;
        private Label label21;
        private Label lbNumberOfMusic;
        private Label label23;
        private Label label22;
        private RadioButton rdOFFMusic;
        private Panel plNextMusic;
        private Panel plPrevousMusic;
        private Panel plShowPictureMusic;
        private Panel panel14;
        private Panel panel15;
        private Label lbTimer;
        private Timer timer1;
        private Button btnNext;
        private ComboBox comboBox1;
        private RadioButton rdMixOperaions;
        private Button btnRestart;
        private Label lbshowselectAnswer;
        private Label label7;
        private NumericUpDown nmLimittimeforQuestion;
        private TextBox txtPersecond;
        private Timer timer2;
        private Panel panel5;
        private Panel plShowFinalResult;
        private Label label9;
        private Label label11;
        private Label label26;
        private Label label25;
        private Label label24;
        private TextBox txtFalseAnswer;
        private TextBox txtCurrectAnswer;
        private Label label28;
        private Label label27;
        private TextBox txtTimeQuestion;
        private TextBox txtLevel;
        private TextBox txtOP;
        private Button btnREPLAY;
        private TextBox txtTotalquestion;
        private Label label29;
        private TextBox txtMissedQuestion;
        private Label label30;
    }
}

