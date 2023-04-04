using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Timers;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Traffic
{
    internal class Car : PictureBox
    {
        Random Rand = new Random();

        public Car(int px, int py, int carW, int carH)
        {
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Size = new Size(carW, carH);
            if (carW < carH) { Rand_Car_Color_H(this); }
            else if (carW > carH){ Rand_Car_Color_W(this); }           
            this.Location = new Point(px, py);
        }

        private void Rand_Car_Color_H(PictureBox PicBox)
        {
            int I_CarRandColor1 = Rand.Next(1, 7);

            switch (I_CarRandColor1)
            {
                case 1:
                    PicBox.Image = Properties.Resources.Car1;
                    break;
                case 2:
                    PicBox.Image = Properties.Resources.Car2;
                    break;
                case 3:
                    PicBox.Image = Properties.Resources.Car4;
                    break;
                case 4:
                    PicBox.Image = Properties.Resources.Car5;
                    break;
                case 5:
                    PicBox.Image = Properties.Resources.Car6;
                    break;
                case 6:
                    PicBox.Image = Properties.Resources.Car8;
                    break;
            }
        }

        private void Rand_Car_Color_W(PictureBox PicBox)
        {
            int I_CarRandColor1 = Rand.Next(1, 7);

            switch (I_CarRandColor1)
            {
                case 1:
                    PicBox.Image = Properties.Resources.Car1;
                    PicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 2:
                    PicBox.Image = Properties.Resources.Car2;
                    PicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 3:
                    PicBox.Image = Properties.Resources.Car4;
                    PicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 4:
                    PicBox.Image = Properties.Resources.Car5;
                    PicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 5:
                    PicBox.Image = Properties.Resources.Car6;
                    PicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 6:
                    PicBox.Image = Properties.Resources.Car8;
                    PicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
            }
        }
    }

    public class CarOption
    {
        public CarOption(int sizew, int sizeh, int BlueGo,int YellowGo,int Car1L, int Car2L,int Car3L, int Car4L, int PointX,int CutLine, int PointCUTLINE, int NnwPoint,int OutLine)
        {
            this.I_CAR1_LOCARTION = Car1L;
            this.I_CAR2_LOCARTION = Car2L;
            this.I_CAR3_LOCARTION = Car3L;
            this.I_CAR4_LOCARTION = Car4L;
            this.I_SOUTH_XPOINT = PointX;
            this.I_CUT_LINE = CutLine;
            this.I_SOUNTH_CUTLINE = PointCUTLINE;
            this.I_CAR_NEWPOINT = NnwPoint;
            this.I_OUT_LINE = OutLine;
            this.i_Blue_go = BlueGo;
            this.i_Yellow_go = YellowGo;
            this.I_SIZE_W = sizew;
            this.I_SIZE_H = sizeh;
        }
        public int i_BlueConter;
        public int i_YellowConter;
        public int i_RedConter;

        public int i_Blue_go;
        public int i_Yellow_go;

        public int I_SIZE_W;
        public int I_SIZE_H;

        public int I_SOUTH_XPOINT;

        public int I_CAR1_LOCARTION;
        public int I_CAR2_LOCARTION;
        public int I_CAR3_LOCARTION;
        public int I_CAR4_LOCARTION;

        public int I_CAR_NEWPOINT;

        public int I_OUT_LINE;

        public int I_SOUNTH_CUTLINE;

        public int I_CUT_LINE;

        public int check = -1;

        public int I_StToEn_Count = 0;

        public int I_StToEn_CountBal = 0;
    }
    
}
