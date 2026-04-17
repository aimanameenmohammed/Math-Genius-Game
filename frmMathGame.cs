using MyMathGame.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MyMathGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            {
                InitializeComponent();
            }

        }
        Stack<string> Next = new Stack<string>();
        Stack<string> Prevous = new Stack<string>();


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        ClsUIcs UI = new ClsUIcs();

        void UIInterface()
        {
            UI.ApplyNumericStyle(nmTotalOfQuestion);
            UI.ApplyNumericStyle(nmLimittimeforQuestion);


            UI.CustomizeProgressBar(pgLimiteQuestion);
            UI.SetRoundedRegion(btnShow1, 10);
            UI.SetRoundedRegion(btnShow2, 10);
            UI.SetRoundedRegion(btnNext, 10);
            
            UI.SetRoundedRegion(btnRestart, 10);
            UI.SetRoundedRegion(btnShow3, 10);
            UI.SetRoundedRegion(btnShow4, 10);
            UI.SetRoundedRegion(btnREPLAY, 10);

            UI.SetRoundedRegion(rdEASY, 10);

            UI.SetRoundedRegion(rdDivide, 10);
            UI.SetRoundedRegion(rdMultiplication, 10);
            UI.SetRoundedRegion(rdMinus, 10);
            UI.SetRoundedRegion(rdMixOperaions, 10);

            UI.SetRoundedRegion(rdPlus, 10);



            UI.SetRoundedRegion(rdMEDIUM, 10);
            UI.SetRoundedRegion(rdHARD, 10);
            UI.SetRoundedRegion(rdMIX, 10);


            UI.ApplyQuestionAreaStyle(lbShowQuestions, 25);

            // إذا أردت تطبيقها على زر البدء الكبير أيضاً
            UI.SetRoundedRegion(btnStartChallenge, 20);
            UI.ApplyContainerStyle(panel3);
            UI.ApplyContainerStyle(panel4);
            UI.ApplyContainerStyle(panel2);
            UI.ApplyContainerStyle(plShowFinalResult,false);


        }



         enum eOperationType { ePlus = 1, eminus = 2, eMultiplication = 3, eDivition = 4 ,eMix=5};
        enum eOperationLevel { eHard = 1, eEasy = 2, eMedium = 3, eMix = 4 };

        class clsPlayerInfo
        {
            public string CorrectAnswer;
            public short CountFalseAnswer;
            public short CountTrueAnswer;   
            public string TotalQuestions;
            public Control btnName;
            public string OperationLevel;
            public string   OperationType;
            public string TimePerQuestion;
            public short NotAnswerQuestion;
        }
        clsPlayerInfo PlayerInfo=new clsPlayerInfo();
       
        short GetResult(short N1,short N2,string Operation)
        {

            DataTable table = new DataTable();
            object Result = table.Compute(((N1 + Operation+ N2)), "");
            short finalResult=Convert.ToInt16(Result);  
            return finalResult;

          
        }

        eOperationLevel GetOperationLevel()
        {

            if (rdMIX.Checked)
            {
                PlayerInfo.OperationLevel = rdMIX.Tag.ToString();
                return eOperationLevel.eMix;

            }
            if (rdEASY.Checked)
            {
                PlayerInfo.OperationLevel = rdEASY.Tag.ToString();
                return eOperationLevel.eEasy;

            }
            else if (rdHARD.Checked )
            {
                PlayerInfo.OperationLevel = rdHARD.Tag.ToString();
                return eOperationLevel.eHard;
            }
            else 
            {
                PlayerInfo.OperationLevel = rdMEDIUM.Tag.ToString();
                return eOperationLevel.eMedium;
            } 
        }


        Random random = new Random();   
        string GetOperationType()
        {

            eOperationType OperationType=default;

            if (rdMixOperaions.Checked)
            {
               OperationType=(eOperationType)random.Next(1,4);
                if (rdMixOperaions.Checked)
                    PlayerInfo.OperationType = rdMIX.Tag.ToString();

            }
            if (rdMultiplication.Checked || (OperationType == eOperationType.eMultiplication))
            {
                if(rdMultiplication.Checked)
                PlayerInfo.OperationType=rdMultiplication.Tag.ToString();

                return "*";

            }
            else if (rdPlus.Checked|| (OperationType == eOperationType.ePlus))
            {
                if (rdPlus.Checked)
                    PlayerInfo.OperationType = rdPlus.Tag.ToString();

                return "+";

            }
            else if (rdMinus.Checked|| (OperationType == eOperationType.eminus))
            {
                if (rdMinus.Checked)
                    PlayerInfo.OperationType = rdMinus.Tag.ToString();

                return "-";
            }
            else if (rdDivide.Checked || (OperationType == eOperationType.eDivition))
            {
                if (rdDivide.Checked)
                    PlayerInfo.OperationType = rdDivide.Tag.ToString();

                return "/";

            }
            return "";

        }
        void ShowQuestionAndSaveCurrectAnswer(Button btn,short from,short to,string Operation)
        {
           

            while (true)
            {
                short N1 = Convert.ToInt16(random.Next(from, to));
                short N2 = Convert.ToInt16(random.Next(from, to));
                short result = GetResult(N1, N2,Operation);
                if (IsAlreadyAddedBtn(result))
                {

                    lbShowQuestions.Text = (N1 + Operation + N2).ToString();

                    btn.Text = result.ToString();
                    PlayerInfo.btnName = btn;
                    break;
                }
            }
        }
        void MakeBtnEmpty()
        {
            btnShow1.Text = null;
            btnShow2.Text = null;
            btnShow3.Text = null;
            btnShow4.Text = null;
        }
        bool IsAlreadyAddedBtn(short Value)
        {
            
            List<Button> vector = new List<Button> { btnShow1, btnShow2, btnShow3, btnShow4 };
            foreach (Button btn in vector)
            {
                
                    if (btn.Text == Value.ToString())
                    {
                        return false;
                    }
                
            }
            return true;
        }
        void Showbtn(short from,short to)
        {
            MakeBtnEmpty();
            List<Button> vector = new List<Button>{ btnShow1, btnShow2,btnShow3,btnShow4};

            string Operaion = GetOperationType();

            while (vector.Count != 1)
            {
                byte Index = Convert.ToByte(random.Next(0, vector.Count));

               
                if (string.IsNullOrEmpty(vector[Index].Text) && vector[Index]!=null)
                {
                    
                    short N1 = (short)random.Next(from, to);
                    short N2 = (short)random.Next(from, to);
                    short result = GetResult(N1, N2,Operaion);
                    if (IsAlreadyAddedBtn(result))
                    {
                    vector[Index].Text =result.ToString();
                        vector.RemoveAt(Index);

                    }
                    
                }

            }
            ShowQuestionAndSaveCurrectAnswer(vector[0], from, to,Operaion);
        }
        void FullButtolRandomly(eOperationLevel operationLevel)
        {

            switch (operationLevel)
            {
                case eOperationLevel.eEasy:
                    {
                        Showbtn(1, 10);
                        break;
                    }
                case eOperationLevel.eMedium:
                    {
                        Showbtn(1,15);
                        break;
                    }
                case eOperationLevel.eHard:
                    {
                        Showbtn(1, 25);
                        break;
                    }

            }



        }
        void GenerateQuestions()
        {
            
            eOperationLevel operationLevel= GetOperationLevel();
            if(eOperationLevel.eMix== operationLevel)
            {
                operationLevel=(eOperationLevel)random.Next(1,4);
            }
            switch (operationLevel)
            {

                case eOperationLevel.eEasy:
                    {
                       
                        FullButtolRandomly(operationLevel);
                        break;
                    }
                case eOperationLevel.eMedium:
                    {
                        FullButtolRandomly(operationLevel);
                        break;
                    }

                case eOperationLevel.eHard:
                    {
                        FullButtolRandomly(operationLevel);
                        break;
                    }

            }


        }



        private void Form1_Load(object sender, EventArgs e)
       
        {
            UIInterface();
            LaodMusic();
        }


        private void ChangeColorAndAddText(object sender, EventArgs e)
        {
            RadioButton type = (RadioButton)sender;

            lbTypeSelectOfOperation.Text = type.Tag.ToString();
            type.ForeColor = Color.Green;

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }




        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void panel6_Click_1(object sender, EventArgs e)
        {
            plShowSetting.Visible = true;

        }

        private void panel10_Click_1(object sender, EventArgs e)
        {
            plShowSetting.Visible = false;

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

        }

        private void lkLinkedIN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void lkTelegram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdOFFMusic_CheckedChanged(object sender, EventArgs e)
        {
            plShowPictureMusic.BackgroundImage = Resources.OFF;
            mp3.controls.stop();
        }

        WMPLib.WindowsMediaPlayer mp3 = new WMPLib.WindowsMediaPlayer();

        private void rdONMusic_CheckedChanged(object sender, EventArgs e)
        {
            mp3.controls.play();
            plShowPictureMusic.BackgroundImage = Resources.ON;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            mp3.controls.stop();
            tabControl1.SelectedIndex = 2;

        }

        void LaodMusic()
        {
            foreach (string st in comboBox1.Items)
            {
                Next.Push(st);
            }

        }
        private void panel15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

        }
        private void GetFirstTab (object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

        }
       
        byte Hide=default;
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            lbTimer.Text = DateTime.Now.ToString("G");
            Hide++;
            if (Hide == 3)
            {
                lbshowselectAnswer.Visible = false;
                Hide = 0;
            }
        }
        void CheckIfMixOperaions()
        {
            if (rdMixOperaions.Checked)
            {
                rdMinus.Enabled = false;
                rdPlus.Enabled = false;
                rdMultiplication.Enabled = false;
                rdDivide.Enabled = false;
            }
            if(rdMIX.Checked)
            {
                rdEASY.Enabled = false; 
                rdMEDIUM.Enabled = false;   
                rdHARD.Enabled = false; 

            }



        }
        void EditBtnColor()
        {
            btnShow1.ForeColor = Color.Silver;
            btnShow2.ForeColor = Color.Silver;  
            btnShow3.ForeColor = Color.Silver;  
            btnShow4.ForeColor = Color.Silver;
        }
        
        void StartGame()
        {
            if (nmTotalOfQuestion.Value != 0)
            {
                GenerateQuestions();
                CheckIfMixOperaions();
                EditBtnColor();
                MakerdAndNmUNEnable();
                btnNext.Enabled = true;
                timer2.Enabled = true;
                PlayerInfo.TimePerQuestion = nmLimittimeforQuestion.Value.ToString();

            }
        }
        void MakerdAndNmUNEnable()
        {
            //Operations
            if (!rdDivide.Checked)
            {  rdDivide.Enabled = false;}
            if (!rdMinus.Checked)
            { rdMinus.Enabled = false; }

            if(!rdPlus.Checked)
            { rdPlus.Enabled = false;}
            if(!rdMultiplication.Checked)
                { rdMultiplication.Enabled = false; }
            if(!rdMixOperaions.Checked)
            { rdMixOperaions.Enabled = false; }

            //level
            if(!rdEASY.Checked)
                { rdEASY.Enabled = false; }
            if( !rdMEDIUM.Checked)
                { rdMEDIUM.Enabled = false; }
            if( !rdHARD.Checked)
                { rdHARD.Enabled = false; }
            btnStartChallenge.Enabled = false;
            if(!rdMIX.Checked)
            { rdMIX.Enabled=false; }

            //num
            nmTotalOfQuestion.Enabled = false;
            nmLimittimeforQuestion.Enabled = false; 



                
        }
        private void btnStartChallenge_Click(object sender, EventArgs e)
        {
            StartGame();
        }
      WindowsMediaPlayer SoundResult=new WindowsMediaPlayer();
        private void NextAndPrevousMusic(object sender, EventArgs e)
        {
            Control Ct = (Control)sender;

            if (Ct.Tag.ToString() == "1")
            {
                if (Next.Count > 0)
                {
                    mp3.URL = Next.Peek().ToString();
                    Prevous.Push(Next.Peek().ToString());
                    Next.Pop();
                    mp3.settings.setMode("loop",true);
                }
            }
            else if (Ct.Tag.ToString() == "2")
            {
                if (Prevous.Count > 0)
                {
                    mp3.URL = Prevous.Peek().ToString();
                    Next.Push(Prevous.Peek().ToString());
                    Prevous.Pop();
                    mp3.settings.setMode("loop", true);

                }
            }

        }

       
        private void ChangeColor (object sender, EventArgs e)
        {
            Control rd=(Control)sender;
            PrevousColor = rd.ForeColor;

            rd.ForeColor = Color.Black;

        }
        Color PrevousColor;
        private void ChangeColor2(object sender, EventArgs e)
        {
            Control rd = (Control)sender;
            rd.ForeColor=PrevousColor;


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void rd_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd= (RadioButton)sender;
            lbTypeSelectOfOperation.Text=rd.Tag.ToString();

        }

        private void label18_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://github.com/aimanameenmohammed");
        }

        private void label17_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.linkedin.com/in/aiman-ameen-2548673a8");
        }

        private void label19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wa.me/967730062999\r\n");
        }

        private void label20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/AimanAmeenMohammed");
        }
        void CheckAnswer(Button btn)
        {
            if (btn.Text!= "")
            {
                if (btn.Text == PlayerInfo.btnName.Text.ToString())
                {

                    PlayerInfo.CountTrueAnswer++;
                    btn.ForeColor = Color.LightGreen;
                    SoundResult.URL = "Correct_Sound.m4a";
                    SoundResult.controls.play();


                }
                else
                {

                    PlayerInfo.CountFalseAnswer++;
                    btn.ForeColor = Color.Red;
                    SoundResult.URL = "Faild_Sound.m4a";
                    SoundResult.controls.play();
                    PlayerInfo.btnName.ForeColor = Color.LightGreen;


                }
                ProgressbarQuesions();
                MakeBtnShowResultunEnable();
            }

        }

        private void CheckAswer_Click(object sender, EventArgs e)
        {
            timer2.Stop();

            Button btnAnswer = (Button)sender;
            CheckAnswer(btnAnswer);

        }
      

        string GetTextResult()
        {

            if (PlayerInfo.CountTrueAnswer > PlayerInfo.CountFalseAnswer)
                return "Excellent";
            else if (PlayerInfo.CountTrueAnswer < PlayerInfo.CountFalseAnswer)
                return "Failed";
            else
                return "Good Try";
        }
        Color GetOperationLevelColor()
        {

            if (rdMEDIUM.Checked)
                return Color.Khaki;
            else if(rdEASY.Checked)
                return Color.LightGreen;
            else if(rdHARD.Checked)
                return Color.FromArgb(255, 127, 127);

            else
                return Color.Gainsboro;
        }
        void FulltxtResult()
        {
            plShowFinalResult.Visible = true;
            txtCurrectAnswer.Text = PlayerInfo.CountTrueAnswer.ToString();
            txtFalseAnswer.Text = PlayerInfo.CountFalseAnswer.ToString();
            txtTotalquestion.Text= PlayerInfo.TotalQuestions.ToString();
            txtTimeQuestion.Text=PlayerInfo.TimePerQuestion.ToString() + "s";
            txtOP.Text=PlayerInfo.OperationType.ToString();
            txtLevel.Text=PlayerInfo.OperationLevel.ToString();
            txtMissedQuestion.Text=PlayerInfo.NotAnswerQuestion.ToString();

            txtLevel.ForeColor = GetOperationLevelColor();

        }
        void showFinalResult()
        {
            timer2.Stop();
            FulltxtResult();
            MakeBtnEmpty();
            ReturnBtnShowResultOptionColor();

        }
        void ProgressbarQuesions()
        {

           

            pgLimiteQuestion.Value++;
            lbDidQuestion.Text = pgLimiteQuestion.Value.ToString();
            pgLimiteQuestion.Refresh();
            lbDidQuestion.Refresh();

            if (pgLimiteQuestion.Value==nmTotalOfQuestion.Value)
            {
               
                btnNext.Enabled = false;
                lbShowQuestions.Text = null;
                showFinalResult();

            }
            

        }


       void MakeBtnShowResultunEnable()
        {
            btnShow1.Enabled= false;    
            btnShow2.Enabled= false;    
            btnShow3.Enabled= false;    
            btnShow4.Enabled= false;
        }
        void ReturnBtnShowResultOptionColor()
        {
            btnShow1.ForeColor = Color.Silver;
            btnShow2.ForeColor = Color.Silver;
            btnShow3.ForeColor = Color.Silver;
            btnShow4.ForeColor = Color.Silver;

        }
        void MakeBtnShowResultEnable()
        {
            btnShow1.Enabled = true;
            btnShow2.Enabled = true;
            btnShow3.Enabled = true;
            btnShow4.Enabled = true;
        }
      
        void RestartGame()
        {
            nmTotalOfQuestion.Value = 0;
            nmLimittimeforQuestion.Value = 10;
            pgLimiteQuestion.Maximum = 0;
            pgLimiteQuestion.Value = 0;


            //Operations
            rdMinus.Enabled = true;
             rdPlus.Enabled = true;
            rdMultiplication.Enabled = true;
           rdDivide.Enabled = true;
            rdPlus.Checked=true;
            rdMixOperaions.Enabled = true;
           

            //Level
            rdEASY.Enabled = true;
          rdMEDIUM.Enabled = true;
            rdHARD.Enabled = true;
            rdEASY.Checked=true;
            rdMIX.Enabled = true;
            //btn
            MakeBtnShowResultEnable();
            MakeBtnEmpty();

            //lb Show Questions 
            lbShowQuestions.Text = null;

            //  Button Show Result
            ReturnBtnShowResultOptionColor();

            //NM
            nmTotalOfQuestion.Enabled = true;
            nmLimittimeforQuestion.Enabled = true;

            btnNext.Enabled = false;
            btnStartChallenge.Enabled = true;
            lbTotalQuestions.Text = "0";
            lbDidQuestion.Text="0";


            //Restart Result
            PlayerInfo.CountFalseAnswer = 0;
            PlayerInfo.CountTrueAnswer = 0;

            //timer
            timer2.Stop();
            counter = 0;
            //txtTime
            txtPersecond.Text = "10s";
            txtPersecond.ForeColor = Color.LightGreen; 

            //panel result
            plShowFinalResult.Visible = false;


        }


        void NextQuestion()
        {
            MakeBtnShowResultEnable();
            GenerateQuestions();
            EditBtnColor();

        }
        bool IsAnswered()
        {
            return (btnShow1.ForeColor == Color.Silver && btnShow2.ForeColor == Color.Silver && btnShow3.ForeColor == Color.Silver && btnShow4.ForeColor == Color.Silver);
        }
        void CheckIsAnswerSelected()
        {
            if ((!IsAnswered()))
            {
                NextQuestion();
                counter = 0;
                txtPersecond.ForeColor = Color.LightGreen;
                timer2.Start();
            }
           
            else
            {

                lbshowselectAnswer.Visible = true;
                SoundResult.URL = "Faild_Sound.m4a";
                SoundResult.controls.play();

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CheckIsAnswerSelected();

           
        }

        private void nmTotalOfQuestion_ValueChanged(object sender, EventArgs e)
        {

            lbTotalQuestions.Text = nmTotalOfQuestion.Value.ToString();
            pgLimiteQuestion.Maximum = Convert.ToInt16(nmTotalOfQuestion.Value);
            PlayerInfo.TotalQuestions = nmTotalOfQuestion.Value.ToString();

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void panel14_Paint_1(object sender, PaintEventArgs e)
        {

        }

        byte counter = 0;
        void NextQuestionIfTimeIsDone()
        {
            counter = 0;
            timer2.Stop();
            txtPersecond.ForeColor = Color.LightGreen;
            PlayerInfo.btnName.ForeColor = Color.LightGreen;
            txtPersecond.Text = counter.ToString() + "s";
            btnNext.Focus();

            PlayerInfo.NotAnswerQuestion++;
            MakeBtnShowResultunEnable();
            ProgressbarQuesions();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (counter == nmLimittimeforQuestion.Value)
            {

                NextQuestionIfTimeIsDone();

            }
            Console.Beep(); 
            counter++;
            txtPersecond.Text = counter.ToString() + "s";
            if((Convert.ToByte(nmLimittimeforQuestion.Value)/2)==counter)
            {
                txtPersecond.ForeColor= Color.FromArgb(255, 127, 127);
            }
            

        }

        private void nmLimittimeforQuestion_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnShow4_EnabledChanged(object sender, EventArgs e)
        {
            
        }
    }
    }

