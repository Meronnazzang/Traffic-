
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace Traffic
{ 

    public partial class Form1 : Form 
    {

        CarOption Option_S;
        CarOption Option_N;
        CarOption Option_W;
        CarOption Option_E;

        CarRun_S carrun_S;
        CarRun_N carrun_N;
        CarRun_W carrun_W;
        CarRun_E carrun_E;

        Car pictureBox3_S;
        Car pictureBox4_S;
        Car pictureBox5_S;
        Car pictureBox6_S;

        Car pictureBox7_N;
        Car pictureBox8_N;
        Car pictureBox9_N;
        Car pictureBox10_N;

        Car pictureBox11_W;
        Car pictureBox12_W;
        Car pictureBox13_W;
        Car pictureBox14_W;

        Car pictureBox15_E;
        Car pictureBox16_E;
        Car pictureBox17_E;
        Car pictureBox18_E;

        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_start_stop_Click(object sender, EventArgs e)
        {
            if (button1_start.Text == "start")
            {
                button1_start.Text = "stop";
                Setting();
            }
            else
            {
                button1_start.Text = "start";
                Reset(); 
            }
        }
        
       private void Timer4_NCount_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Option_N.I_StToEn_Count; i++)
            {
                Option_N.I_StToEn_CountBal++;
                label2_NtoS.Text = String.Format("NtoS : {0}", Option_N.I_StToEn_CountBal);
                if (label2_Count_Bal.Top > 15)
                {
                    label2_Count_Bal.Height += 10;
                    label2_Count_Bal.Top = 201 - label2_Count_Bal.Height;
                }
            }
            Option_N.I_StToEn_Count = 0;

        }

        private void timer5_SCount_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Option_S.I_StToEn_Count; i++)
            {
                Option_S.I_StToEn_CountBal++;
                label1_StoN.Text = String.Format("StoN : {0}", Option_S.I_StToEn_CountBal);
                if (label1_Count_Bal.Top > 15)
                {
                    label1_Count_Bal.Height += 10;
                    label1_Count_Bal.Top = 201 - label1_Count_Bal.Height;
                }
            }
            Option_S.I_StToEn_Count = 0;
        }

        private void timer6_WCount_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Option_W.I_StToEn_Count; i++)
            {
                Option_W.I_StToEn_CountBal++;
                label3_WtoE.Text = String.Format("WtoE : {0}", Option_W.I_StToEn_CountBal);
                if (label3_Count_Bal.Top > 15)
                {
                    label3_Count_Bal.Height += 10;
                    label3_Count_Bal.Top = 201 - label3_Count_Bal.Height;
                }
            }
            Option_W.I_StToEn_Count = 0;
        }

        private void timer7_ECount_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Option_E.I_StToEn_Count; i++)
            {
                Option_E.I_StToEn_CountBal++;
                label4_EtoW.Text = String.Format("WtoE : {0}", Option_E.I_StToEn_CountBal);
                if (label4_Count_Bal.Top > 15)
                {
                    label4_Count_Bal.Height += 10;
                    label4_Count_Bal.Top = 201 - label4_Count_Bal.Height;
                }
            }
            Option_E.I_StToEn_Count = 0;
        }

        private void Timer1_Green_Tick(object sender, EventArgs e)
        {
            carrun_S.TrafficLightGreen();
            carrun_N.TrafficLightGreen();
            carrun_W.TrafficLightGreen();
            carrun_E.TrafficLightGreen();
        }

        private void Timer2_Yellow_Tick(object sender, EventArgs e)
        {
            carrun_S.TrafficLightYellow();
            carrun_N.TrafficLightYellow();
            carrun_W.TrafficLightYellow();
            carrun_E.TrafficLightYellow();
        }

        private void Timer3_Red_Tick(object sender, EventArgs e)
        {
            carrun_S.TrafficLightRed();
            carrun_N.TrafficLightRed();
            carrun_W.TrafficLightRed();
            carrun_E.TrafficLightRed();
        }

        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            StoN_valus.Text = "StoN : " + Convert.ToString(hScrollBar1.Value);
        }

        private void HScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            NtoS_valus.Text = "NtoS : " + Convert.ToString(hScrollBar2.Value);
        }

        private void HScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            WtoE_valus.Text = "WtoE : " + Convert.ToString(hScrollBar3.Value);
        }
        private void HScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            EtoW_valus.Text = "EtoW : " + Convert.ToString(hScrollBar4.Value);
        }
        private void Timer4_StoN_Tick(object sender, EventArgs e)
        {
            carrun_S.StoNGO();
            carrun_N.StoNGO();
            carrun_W.StoNGO();
            carrun_E.StoNGO();
        }

        private void Setting()
        {
            Option_S = null;
            Option_W = null;
            Option_E = null;
            Option_N = null;

            timer3.Start();

            timer4_car1.Start();

            timer4_NCount.Start();
            timer5_SCount.Start();
            timer6_WCount.Start();
            timer7_ECount.Start();

            timer4_car1.Interval = 50;

            if (Option_S == null)
            {
                Option_S = new CarOption(30, 50, hScrollBar1.Value, 40, 230, 290, 350, 410, 196, 229, 370, 430, -50);
            }
            if (Option_N == null)
            {
                Option_N = new CarOption(30, 50, hScrollBar2.Value, 60, 80, 20, -40, -100, 151, 81, -60, -120, 360);
            }
            if (Option_W == null)
            {
                Option_W = new CarOption(50, 30, hScrollBar3.Value, 50, 80, 20, -40, -100, 151, 81, -60, -120, 360);
            }
            if (Option_E == null)
            {
                Option_E = new CarOption(50, 30, hScrollBar4.Value, 60, 230, 290, 350, 410, 196, 229, 370, 430, -50);
            }

                pictureBox3_S = new Car(Option_S.I_SOUTH_XPOINT, Option_S.I_CAR1_LOCARTION, Option_S.I_SIZE_W, Option_S.I_SIZE_H);
                pictureBox4_S = new Car(Option_S.I_SOUTH_XPOINT, Option_S.I_CAR2_LOCARTION, Option_S.I_SIZE_W, Option_S.I_SIZE_H);
                pictureBox5_S = new Car(Option_S.I_SOUTH_XPOINT, Option_S.I_CAR3_LOCARTION, Option_S.I_SIZE_W, Option_S.I_SIZE_H);
                pictureBox6_S = new Car(Option_S.I_SOUTH_XPOINT, Option_S.I_CAR4_LOCARTION, Option_S.I_SIZE_W, Option_S.I_SIZE_H);

                pictureBox7_N = new Car(Option_N.I_SOUTH_XPOINT, Option_N.I_CAR1_LOCARTION, Option_N.I_SIZE_W, Option_N.I_SIZE_H);
                pictureBox8_N = new Car(Option_N.I_SOUTH_XPOINT, Option_N.I_CAR2_LOCARTION, Option_N.I_SIZE_W, Option_N.I_SIZE_H);
                pictureBox9_N = new Car(Option_N.I_SOUTH_XPOINT, Option_N.I_CAR3_LOCARTION, Option_N.I_SIZE_W, Option_N.I_SIZE_H);
                pictureBox10_N = new Car(Option_N.I_SOUTH_XPOINT, Option_N.I_CAR4_LOCARTION, Option_N.I_SIZE_W, Option_N.I_SIZE_H);

                pictureBox11_W = new Car(Option_W.I_CAR1_LOCARTION, Option_W.I_SOUTH_XPOINT, Option_W.I_SIZE_W, Option_W.I_SIZE_H); // 자동차의 로케이션과 x축을 
                pictureBox12_W = new Car(Option_W.I_CAR2_LOCARTION, Option_W.I_SOUTH_XPOINT, Option_W.I_SIZE_W, Option_W.I_SIZE_H); // 바꾸어 주어야 x축기준으로 움직일 수 있다
                pictureBox13_W = new Car(Option_W.I_CAR3_LOCARTION, Option_W.I_SOUTH_XPOINT, Option_W.I_SIZE_W, Option_W.I_SIZE_H);
                pictureBox14_W = new Car(Option_W.I_CAR4_LOCARTION, Option_W.I_SOUTH_XPOINT, Option_W.I_SIZE_W, Option_W.I_SIZE_H);

                pictureBox15_E = new Car(Option_E.I_CAR1_LOCARTION, Option_E.I_SOUTH_XPOINT, Option_E.I_SIZE_W, Option_E.I_SIZE_H); // 자동차의 로케이션과 x축을 
                pictureBox16_E = new Car(Option_E.I_CAR2_LOCARTION, Option_E.I_SOUTH_XPOINT, Option_E.I_SIZE_W, Option_E.I_SIZE_H); // 바꾸어 주어야 x축기준으로 움직일 수 있다
                pictureBox17_E = new Car(Option_E.I_CAR3_LOCARTION, Option_E.I_SOUTH_XPOINT, Option_E.I_SIZE_W, Option_E.I_SIZE_H);
                pictureBox18_E = new Car(Option_E.I_CAR4_LOCARTION, Option_E.I_SOUTH_XPOINT, Option_E.I_SIZE_W, Option_E.I_SIZE_H);
            
            Controls.Add(pictureBox3_S);
            Controls.Add(pictureBox4_S);
            Controls.Add(pictureBox5_S);
            Controls.Add(pictureBox6_S);

            Controls.Add(pictureBox7_N);
            Controls.Add(pictureBox8_N);
            Controls.Add(pictureBox9_N);
            Controls.Add(pictureBox10_N);

            Controls.Add(pictureBox11_W);
            Controls.Add(pictureBox12_W);
            Controls.Add(pictureBox13_W);
            Controls.Add(pictureBox14_W);

            Controls.Add(pictureBox15_E);
            Controls.Add(pictureBox16_E);
            Controls.Add(pictureBox17_E);
            Controls.Add(pictureBox18_E);

                carrun_S = new CarRun_S(pictureBox3_S, pictureBox4_S, pictureBox5_S, pictureBox6_S, Option_S, this);
                carrun_N = new CarRun_N(pictureBox7_N, pictureBox8_N, pictureBox9_N, pictureBox10_N, Option_N, this);
                carrun_W = new CarRun_W(pictureBox11_W, pictureBox12_W, pictureBox13_W, pictureBox14_W, Option_W, this);
                carrun_E = new CarRun_E(pictureBox15_E, pictureBox16_E, pictureBox17_E, pictureBox18_E, Option_E, this);

            carrun_S.StoNEventHandler();
            carrun_N.StoNEventHandler();
            carrun_W.StoNEventHandler();
            carrun_E.StoNEventHandler();

            hScrollBar1.Enabled = false;
            hScrollBar2.Enabled = false;
            hScrollBar3.Enabled = false;
            hScrollBar4.Enabled = false;

            label1_StoN.Text = "StoN : 0";

            label2_NtoS.Text = "NtoS : 0";

            label3_WtoE.Text = "WtoE : 0";

            label4_EtoW.Text = "EtoW : 0";

            label1_Count_Bal.Height = 10;
            label1_Count_Bal.Top = 191;

            label2_Count_Bal.Height = 10;
            label2_Count_Bal.Top = 191;

            label3_Count_Bal.Height = 10;
            label3_Count_Bal.Top = 191;

            label4_Count_Bal.Height = 10;
            label4_Count_Bal.Top = 191;
        }        
        
        private void Reset()
        {

            timer1.Stop();
            timer2.Stop();
            timer3.Stop();

            timer4_NCount.Stop();
            timer5_SCount.Stop();
            timer6_WCount.Stop();
            timer7_ECount.Stop();

            timer4_car1.Stop();

            pictureBox1.Image = Properties.Resources.Red_신호등;
            pictureBox2.Image = Properties.Resources.Red_신호등;

            pictureBox8.Image = Properties.Resources.blue_신호등_가로;
            pictureBox9.Image = Properties.Resources.blue_신호등_가로;

            Option_S.check = -1;

            Option_S.i_BlueConter = 0;
            Option_S.i_YellowConter = 0;
            Option_S.i_RedConter = 0;

            Option_S.I_StToEn_Count = 0;
            Option_S.I_StToEn_CountBal = 0;

            Option_N.check = -1;

            Option_N.i_BlueConter = 0;
            Option_N.i_YellowConter = 0;
            Option_N.i_RedConter = 0;

            Option_N.I_StToEn_Count = 0;
            Option_N.I_StToEn_CountBal = 0;

            Option_W.check = -1;

            Option_W.i_BlueConter = 0;
            Option_W.i_YellowConter = 0;
            Option_W.i_RedConter = 0;

            Option_W.I_StToEn_Count = 0;
            Option_W.I_StToEn_CountBal = 0;

            Option_E.check = -1;

            Option_E.i_BlueConter = 0;
            Option_E.i_YellowConter = 0;
            Option_E.i_RedConter = 0;

            Option_E.I_StToEn_Count = 0;
            Option_E.I_StToEn_CountBal = 0;

            pictureBox3_S.Dispose();
            pictureBox4_S.Dispose();
            pictureBox5_S.Dispose();
            pictureBox6_S.Dispose();

            pictureBox7_N.Dispose();
            pictureBox8_N.Dispose();
            pictureBox9_N.Dispose();
            pictureBox10_N.Dispose();


            pictureBox11_W.Dispose();
            pictureBox12_W.Dispose();
            pictureBox13_W.Dispose();
            pictureBox14_W.Dispose();

            pictureBox15_E.Dispose();
            pictureBox16_E.Dispose();
            pictureBox17_E.Dispose();
            pictureBox18_E.Dispose();

            label1_LightCount.ForeColor = Color.Red;
            label1_LightCount.Text = "빨간불 : " + Convert.ToString(Option_S.i_RedConter);
            label2_LightCount.ForeColor = Color.Red;
            label2_LightCount.Text = "빨간불 : " + Convert.ToString(Option_S.i_RedConter);

            label3_LightCount.ForeColor = Color.Lime;
            label3_LightCount.Text = "초록불 : " + Convert.ToString(Option_W.i_BlueConter);
            label4_LightCount.ForeColor = Color.Lime;
            label4_LightCount.Text = "초록불 : " + Convert.ToString(Option_W.i_BlueConter);

            hScrollBar1.Enabled = true;
            hScrollBar2.Enabled = true;
            hScrollBar3.Enabled = true;
            hScrollBar4.Enabled = true;
        }


    }
    
}

