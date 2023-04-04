using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Traffic
{
    internal class CarRun_W
    {
        public event EventHandler Timer1_Car1;
        public event EventHandler Timer2_Car2;
        public event EventHandler Timer3_Car3;
        public event EventHandler Timer4_Car4;

        public event EventHandler Timer5_Light1;
        public event EventHandler Timer6_Light2;
        public event EventHandler Timer7_Light3;

        //<StoN_Images>
        Car pictureBox3;
        Car pictureBox4;
        Car pictureBox5;
        Car pictureBox6;
        //<StoN_Images>

        Form1 Form;

        CarOption Option;

        public CarRun_W(Car pictureBox3, Car pictureBox4, Car pictureBox5, Car pictureBox6, CarOption Option, Form1 Form)
        {
            this.pictureBox3 = pictureBox3;
            this.pictureBox4 = pictureBox4;
            this.pictureBox5 = pictureBox5;
            this.pictureBox6 = pictureBox6;

            this.Option = Option;
            this.Form = Form;
        }

        public void StoNGO()
        {
            if ((this.Timer1_Car1 != null) && (this.Timer2_Car2 != null) && (this.Timer3_Car3 != null) && (this.Timer4_Car4 != null))
            {
                // 이벤트핸들러들을 호출
                Timer1_Car1(this, EventArgs.Empty);
                Timer2_Car2(this, EventArgs.Empty);
                Timer3_Car3(this, EventArgs.Empty);
                Timer4_Car4(this, EventArgs.Empty);
            }
        }

        public void TrafficLightGreen()
        {
            if ((this.Timer5_Light1 != null))
            {
                Timer5_Light1(this, EventArgs.Empty);
            }
        }
        public void TrafficLightYellow()
        {
            if ((this.Timer6_Light2 != null))
            {
                Timer6_Light2(this, EventArgs.Empty);
            }
        }
        public void TrafficLightRed()
        {
            if ((this.Timer7_Light3 != null))
            {
                Timer7_Light3(this, EventArgs.Empty);
            }
        }

        public void StoNEventHandler()
        {
            // Click 이벤트에 대한 이벤트핸들러로
            // btn_Click 이라는 메서드를 지정함
            this.Timer1_Car1 += new EventHandler(timer4_car1_Tick);
            this.Timer2_Car2 += new EventHandler(timer5_car2_Tick);
            this.Timer3_Car3 += new EventHandler(timer6_car3_Tick);
            this.Timer4_Car4 += new EventHandler(timer7_car4_Tick);
            this.Timer5_Light1 += new EventHandler(timer3_Red_Tick);
            this.Timer6_Light2 += new EventHandler(timer2_Yellow_Tick);
            this.Timer7_Light3 += new EventHandler(timer1_Green_Tick);
        }

        //<StoN>
        private void timer4_car1_Tick(object sender, EventArgs e)
        {

            if ((pictureBox3.Location.X >= Option.I_CAR1_LOCARTION) && (Option.i_BlueConter > 0))
            {
                pictureBox3.Left += Option.i_Blue_go;
            }
            else if ((pictureBox3.Location.X >= Option.I_CAR2_LOCARTION) && (Option.i_BlueConter > 5))
            {
                pictureBox3.Left += Option.i_Blue_go;
            }
            else if ((pictureBox3.Location.X >= Option.I_CAR3_LOCARTION) && (Option.i_BlueConter > 10))
            {
                pictureBox3.Left += Option.i_Blue_go;
            }
            else if ((pictureBox3.Location.X >= Option.I_CAR4_LOCARTION) && (Option.i_BlueConter > 15))
            {
                pictureBox3.Left += Option.i_Blue_go;
            }
            else if (Form.timer3.Enabled == true && (Option.i_BlueConter > 20))
            {
                pictureBox3.Left += Option.i_Blue_go;
            }



            if ((pictureBox3.Location.X >= Option.I_CUT_LINE) && (Form.timer3.Enabled == false))
            {
                pictureBox3.Left += Option.i_Yellow_go;
            }

            if ((Option.check == 0) && (pictureBox3.Location.X <= Option.I_CAR1_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox3.Left += 5;
                if (pictureBox3.Location.X == Option.I_CAR1_LOCARTION)
                    Option.check++;
            }
            else if ((Option.check == 1) && (pictureBox3.Location.X <= Option.I_CAR2_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox3.Left += 5;
                if (pictureBox3.Location.X == Option.I_CAR2_LOCARTION)
                    Option.check++;
            }
            else if ((Option.check == 2) && (pictureBox3.Location.X <= Option.I_CAR3_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox3.Left += 5;
                if (pictureBox3.Location.X == Option.I_CAR3_LOCARTION)
                    Option.check++;
            }
            else if ((Option.check == 3) && (pictureBox3.Location.X <= Option.I_CAR4_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox3.Left += 5;
                if (pictureBox3.Location.X == Option.I_CAR4_LOCARTION)
                    Option.check++;
            }

            if ((pictureBox6.Location.X > Option.I_SOUNTH_CUTLINE) && (pictureBox5.Location.X > Option.I_SOUNTH_CUTLINE) && (pictureBox4.Location.X > Option.I_SOUNTH_CUTLINE) && (pictureBox3.Location.X > Option.I_OUT_LINE))
            {
                Option.I_StToEn_Count++;
                pictureBox3.Location = new Point(-120, 151);
            }
        }

        private void timer5_car2_Tick(object sender, EventArgs e)
        {

            if ((pictureBox4.Location.X >= Option.I_CAR1_LOCARTION) && (Option.i_BlueConter > 0))
            {
                pictureBox4.Left += Option.i_Blue_go;
            }
            else if ((pictureBox4.Location.X >= Option.I_CAR2_LOCARTION) && (Option.i_BlueConter > 5))
            {
                pictureBox4.Left += Option.i_Blue_go;
            }
            else if ((pictureBox4.Location.X >= Option.I_CAR3_LOCARTION) && (Option.i_BlueConter > 10))
            {
                pictureBox4.Left += Option.i_Blue_go;
            }
            else if ((pictureBox4.Location.X >= Option.I_CAR4_LOCARTION) && (Option.i_BlueConter > 15))
            {
                pictureBox4.Left += Option.i_Blue_go;
            }
            else if (Form.timer3.Enabled == true && (Option.i_BlueConter > 20))
            {
                pictureBox4.Left += Option.i_Blue_go;
            }

            if ((pictureBox4.Location.X >= Option.I_CUT_LINE) && (Option.i_BlueConter == 0))
            {
                pictureBox4.Left += Option.i_Yellow_go;
            }

            if ((Option.check == 0) && (pictureBox4.Location.X <= Option.I_CAR1_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox4.Left += 5;
                if (pictureBox4.Location.X == Option.I_CAR1_LOCARTION)
                    Option.check++;
            }
            else if ((Option.check == 1) && (pictureBox4.Location.X <= Option.I_CAR2_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox4.Left += 5;
                if (pictureBox4.Location.X == Option.I_CAR2_LOCARTION)
                    Option.check++;
            }
            else if ((Option.check == 2) && (pictureBox4.Location.X <= Option.I_CAR3_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox4.Left += 5;
                if (pictureBox4.Location.X == Option.I_CAR3_LOCARTION)
                    Option.check++;
            }
            else if ((Option.check == 3) && (pictureBox4.Location.X <= Option.I_CAR4_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox4.Left += 5;
                if (pictureBox4.Location.X == Option.I_CAR4_LOCARTION)
                    Option.check++;
            }

            if ((pictureBox6.Location.X > Option.I_SOUNTH_CUTLINE) && (pictureBox5.Location.X > Option.I_SOUNTH_CUTLINE) && (pictureBox3.Location.X > Option.I_SOUNTH_CUTLINE) && (pictureBox4.Location.X > Option.I_OUT_LINE))
            {
                Option.I_StToEn_Count++;
                pictureBox4.Location = new Point(-120, 151);
            }
        }

        private void timer6_car3_Tick(object sender, EventArgs e)
        {

            if ((pictureBox5.Location.X >= Option.I_CAR1_LOCARTION) && (Option.i_BlueConter > 0))
            {
                pictureBox5.Left += Option.i_Blue_go;
            }
            else if ((pictureBox5.Location.X >= Option.I_CAR2_LOCARTION) && (Option.i_BlueConter > 5))
            {
                pictureBox5.Left += Option.i_Blue_go;
            }
            else if ((pictureBox5.Location.X >= Option.I_CAR3_LOCARTION) && (Option.i_BlueConter > 10))
            {
                pictureBox5.Left += Option.i_Blue_go;
            }
            else if ((pictureBox5.Location.X >= Option.I_CAR4_LOCARTION) && (Option.i_BlueConter > 15))
            {
                pictureBox5.Left += Option.i_Blue_go;
            }
            else if (Form.timer3.Enabled == true && (Option.i_BlueConter > 20))
            {
                pictureBox5.Left += Option.i_Blue_go;
            }

            if ((pictureBox5.Location.X >= Option.I_CUT_LINE) && (Option.i_BlueConter == 0))
            {
                pictureBox5.Left += Option.i_Yellow_go;
            }

            if ((Option.check == 0) && (pictureBox5.Location.X <= Option.I_CAR1_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox5.Left += 5;
                if (pictureBox5.Location.X == Option.I_CAR1_LOCARTION)
                    Option.check++;
            }
            else if ((Option.check == 1) && (pictureBox5.Location.X <= Option.I_CAR2_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox5.Left += 5;
                if (pictureBox5.Location.X == Option.I_CAR2_LOCARTION)
                    Option.check++;
            }
            else if ((Option.check == 2) && (pictureBox5.Location.X <= Option.I_CAR3_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox5.Left += 5;
                if (pictureBox5.Location.X == Option.I_CAR3_LOCARTION)
                    Option.check++;
            }
            else if ((Option.check == 3) && (pictureBox5.Location.X <= Option.I_CAR4_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox5.Left += 5;
                if (pictureBox5.Location.X == Option.I_CAR4_LOCARTION)
                    Option.check++;
            }

            if ((pictureBox6.Location.X > Option.I_SOUNTH_CUTLINE) && (pictureBox4.Location.X > Option.I_SOUNTH_CUTLINE) && (pictureBox3.Location.X > Option.I_SOUNTH_CUTLINE) && pictureBox5.Location.X > Option.I_OUT_LINE)
            {
                Option.I_StToEn_Count++;
                pictureBox5.Location = new Point(-120, 151);
            }
        }

        private void timer7_car4_Tick(object sender, EventArgs e)
        {
            if ((pictureBox6.Location.X >= Option.I_CAR1_LOCARTION) && (Option.i_BlueConter > 0))
            {
                pictureBox6.Left += Option.i_Blue_go;
            }
            else if ((pictureBox6.Location.X >= Option.I_CAR2_LOCARTION) && (Option.i_BlueConter > 5))
            {
                pictureBox6.Left += Option.i_Blue_go;
            }
            else if ((pictureBox6.Location.X >= Option.I_CAR3_LOCARTION) && (Option.i_BlueConter > 10))
            {
                pictureBox6.Left += Option.i_Blue_go;
            }
            else if ((pictureBox6.Location.X >= Option.I_CAR4_LOCARTION) && (Option.i_BlueConter > 15))
            {
                pictureBox6.Left += Option.i_Blue_go;
            }
            else if ((Form.timer3.Enabled == true) && (Option.i_BlueConter > 20))
            {
                pictureBox6.Left += Option.i_Blue_go;
            }

            if ((pictureBox6.Location.X >= Option.I_CUT_LINE) && (Form.timer3.Enabled == false))
            {
                pictureBox6.Left += Option.i_Yellow_go;
            }

            if ((Option.check == 0) && (pictureBox6.Location.X <= Option.I_CAR1_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox6.Left += 5;
                if (pictureBox6.Location.X == Option.I_CAR1_LOCARTION)
                    Option.check++;
            }
            else if ((Option.check == 1) && (pictureBox6.Location.X <= Option.I_CAR2_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox6.Left += 5;
                if (pictureBox6.Location.X == Option.I_CAR2_LOCARTION)
                    Option.check++;
            }
            else if ((Option.check == 2) && (pictureBox6.Location.X <= Option.I_CAR3_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox6.Left += 5;
                if (pictureBox6.Location.X == Option.I_CAR3_LOCARTION)
                    Option.check++;
            }
            else if ((Option.check == 3) && (pictureBox6.Location.X <= Option.I_CAR4_LOCARTION) && (Form.timer3.Enabled == false))
            {
                pictureBox6.Left += 5;
                if (pictureBox6.Location.X == Option.I_CAR4_LOCARTION)
                    Option.check++;
            }

            if ((pictureBox5.Location.X > Option.I_SOUNTH_CUTLINE) && (pictureBox4.Location.X > Option.I_SOUNTH_CUTLINE) && (pictureBox3.Location.X > Option.I_SOUNTH_CUTLINE) && pictureBox6.Location.X > Option.I_OUT_LINE)
            {
                Option.I_StToEn_Count++;
                pictureBox6.Location = new Point(-120, 151);
            }

        }

        private void timer1_Green_Tick(object sender, EventArgs e)
        {
            Option.i_BlueConter++;
            Form.label3_LightCount.ForeColor = Color.Lime;
            Form.label3_LightCount.Text = "초록불 : " + Convert.ToString(Option.i_BlueConter);
            Form.label4_LightCount.ForeColor = Color.Lime;
            Form.label4_LightCount.Text = "초록불 : " + Convert.ToString(Option.i_BlueConter);
            if (Option.i_BlueConter == 50)
            {
                Form.pictureBox8.Image = Properties.Resources.Yellow_신호등_가로;
                Form.pictureBox9.Image = Properties.Resources.Yellow_신호등_가로;
                Option.i_BlueConter = 0;
                Option.check = 0;
                Form.timer2.Start();
                Form.timer1.Stop();
            }
        }

        private void timer2_Yellow_Tick(object sender, EventArgs e)
        {
            Option.i_YellowConter++;
            Form.label3_LightCount.ForeColor = Color.Yellow;
            Form.label3_LightCount.Text = "노란불 : " + Convert.ToString(Option.i_YellowConter);
            Form.label4_LightCount.ForeColor = Color.Yellow;
            Form.label4_LightCount.Text = "노란불 : " + Convert.ToString(Option.i_YellowConter);
            if (Option.i_YellowConter == 30)
            {
                Form.pictureBox8.Image = Properties.Resources.Red_신호등가로;
                Form.pictureBox9.Image = Properties.Resources.Red_신호등가로;
                Form.timer1.Start();
                Form.timer2.Stop();
            }
            if (Option.i_YellowConter == 60)
            {
                Form.pictureBox8.Image = Properties.Resources.blue_신호등_가로;
                Form.pictureBox9.Image = Properties.Resources.blue_신호등_가로;
                Option.i_YellowConter = 0;
                Form.timer3.Start();
                Form.timer2.Stop();
            }
        }

        private void timer3_Red_Tick(object sender, EventArgs e)
        {
            Option.i_RedConter++;
            Form.label3_LightCount.ForeColor = Color.Red;
            Form.label3_LightCount.Text = "빨간불 : " + Convert.ToString(Option.i_RedConter);
            Form.label4_LightCount.ForeColor = Color.Red;
            Form.label4_LightCount.Text = "빨간불 : " + Convert.ToString(Option.i_RedConter);
            if (Option.i_RedConter == 50)
            {
                Form.pictureBox8.Image = Properties.Resources.Yellow_신호등_가로;
                Form.pictureBox9.Image = Properties.Resources.Yellow_신호등_가로;
                Form.timer2.Start();
                Option.i_RedConter = 0;
                Form.timer3.Stop();
            }
        }
    }
}
