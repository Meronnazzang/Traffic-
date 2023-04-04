namespace Traffic
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button1_start = new System.Windows.Forms.Button();
            this.timer4_car1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1_StoN = new System.Windows.Forms.Label();
            this.timer4_NCount = new System.Windows.Forms.Timer(this.components);
            this.label1_Count_Bal = new System.Windows.Forms.Label();
            this.label1_LightCount = new System.Windows.Forms.Label();
            this.label2_LightCount = new System.Windows.Forms.Label();
            this.label2_NtoS = new System.Windows.Forms.Label();
            this.label2_Count_Bal = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.StoN_valus = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label3_WtoE = new System.Windows.Forms.Label();
            this.label3_Count_Bal = new System.Windows.Forms.Label();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.NtoS_valus = new System.Windows.Forms.Label();
            this.WtoE_valus = new System.Windows.Forms.Label();
            this.label3_LightCount = new System.Windows.Forms.Label();
            this.label4_LightCount = new System.Windows.Forms.Label();
            this.label4_Count_Bal = new System.Windows.Forms.Label();
            this.label4_EtoW = new System.Windows.Forms.Label();
            this.EtoW_valus = new System.Windows.Forms.Label();
            this.hScrollBar4 = new System.Windows.Forms.HScrollBar();
            this.timer5_SCount = new System.Windows.Forms.Timer(this.components);
            this.timer6_WCount = new System.Windows.Forms.Timer(this.components);
            this.timer7_ECount = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Green_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Traffic.Properties.Resources.Red_신호등;
            this.pictureBox1.Location = new System.Drawing.Point(232, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Traffic.Properties.Resources.Red_신호등;
            this.pictureBox2.Location = new System.Drawing.Point(124, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Yellow_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.Timer3_Red_Tick);
            // 
            // button1_start
            // 
            this.button1_start.BackColor = System.Drawing.Color.Transparent;
            this.button1_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1_start.FlatAppearance.BorderSize = 0;
            this.button1_start.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1_start.Location = new System.Drawing.Point(739, 23);
            this.button1_start.Name = "button1_start";
            this.button1_start.Size = new System.Drawing.Size(96, 35);
            this.button1_start.TabIndex = 2;
            this.button1_start.Text = "start";
            this.button1_start.UseVisualStyleBackColor = false;
            this.button1_start.Click += new System.EventHandler(this.Button1_start_stop_Click);
            // 
            // timer4_car1
            // 
            this.timer4_car1.Tick += new System.EventHandler(this.Timer4_StoN_Tick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox7.Location = new System.Drawing.Point(392, -23);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(488, 410);
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // label1_StoN
            // 
            this.label1_StoN.AutoSize = true;
            this.label1_StoN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1_StoN.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1_StoN.Location = new System.Drawing.Point(418, 209);
            this.label1_StoN.Name = "label1_StoN";
            this.label1_StoN.Size = new System.Drawing.Size(63, 13);
            this.label1_StoN.TabIndex = 6;
            this.label1_StoN.Text = "StoN : 0";
            // 
            // timer4_NCount
            // 
            this.timer4_NCount.Tick += new System.EventHandler(this.Timer4_NCount_Tick);
            // 
            // label1_Count_Bal
            // 
            this.label1_Count_Bal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1_Count_Bal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1_Count_Bal.Location = new System.Drawing.Point(432, 191);
            this.label1_Count_Bal.Name = "label1_Count_Bal";
            this.label1_Count_Bal.Size = new System.Drawing.Size(37, 10);
            this.label1_Count_Bal.TabIndex = 7;
            this.label1_Count_Bal.Text = "        ";
            this.label1_Count_Bal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1_Count_Bal.UseWaitCursor = true;
            // 
            // label1_LightCount
            // 
            this.label1_LightCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1_LightCount.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1_LightCount.ForeColor = System.Drawing.Color.Red;
            this.label1_LightCount.Location = new System.Drawing.Point(254, 95);
            this.label1_LightCount.Name = "label1_LightCount";
            this.label1_LightCount.Size = new System.Drawing.Size(100, 23);
            this.label1_LightCount.TabIndex = 8;
            this.label1_LightCount.Text = "빨간불 : 0";
            this.label1_LightCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2_LightCount
            // 
            this.label2_LightCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2_LightCount.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2_LightCount.ForeColor = System.Drawing.Color.Red;
            this.label2_LightCount.Location = new System.Drawing.Point(20, 248);
            this.label2_LightCount.Name = "label2_LightCount";
            this.label2_LightCount.Size = new System.Drawing.Size(100, 23);
            this.label2_LightCount.TabIndex = 8;
            this.label2_LightCount.Text = "빨간불 : 0";
            this.label2_LightCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2_NtoS
            // 
            this.label2_NtoS.AutoSize = true;
            this.label2_NtoS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2_NtoS.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2_NtoS.Location = new System.Drawing.Point(495, 209);
            this.label2_NtoS.Name = "label2_NtoS";
            this.label2_NtoS.Size = new System.Drawing.Size(63, 13);
            this.label2_NtoS.TabIndex = 6;
            this.label2_NtoS.Text = "NtoS : 0";
            // 
            // label2_Count_Bal
            // 
            this.label2_Count_Bal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label2_Count_Bal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2_Count_Bal.Location = new System.Drawing.Point(506, 191);
            this.label2_Count_Bal.Name = "label2_Count_Bal";
            this.label2_Count_Bal.Size = new System.Drawing.Size(37, 10);
            this.label2_Count_Bal.TabIndex = 7;
            this.label2_Count_Bal.Text = "        ";
            this.label2_Count_Bal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2_Count_Bal.UseWaitCursor = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(415, 235);
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(321, 21);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Value = 40;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar1_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.LargeChange = 1;
            this.hScrollBar2.Location = new System.Drawing.Point(415, 267);
            this.hScrollBar2.Minimum = 1;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(321, 21);
            this.hScrollBar2.TabIndex = 0;
            this.hScrollBar2.Value = 40;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar2_Scroll);
            // 
            // StoN_valus
            // 
            this.StoN_valus.AutoSize = true;
            this.StoN_valus.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StoN_valus.Location = new System.Drawing.Point(751, 239);
            this.StoN_valus.Name = "StoN_valus";
            this.StoN_valus.Size = new System.Drawing.Size(71, 13);
            this.StoN_valus.TabIndex = 6;
            this.StoN_valus.Text = "StoN : 40";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Traffic.Properties.Resources.blue_신호등_가로;
            this.pictureBox8.Location = new System.Drawing.Point(90, 119);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(53, 19);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Traffic.Properties.Resources.blue_신호등_가로;
            this.pictureBox9.Location = new System.Drawing.Point(233, 229);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(53, 19);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // label3_WtoE
            // 
            this.label3_WtoE.AutoSize = true;
            this.label3_WtoE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3_WtoE.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3_WtoE.Location = new System.Drawing.Point(573, 209);
            this.label3_WtoE.Name = "label3_WtoE";
            this.label3_WtoE.Size = new System.Drawing.Size(65, 13);
            this.label3_WtoE.TabIndex = 6;
            this.label3_WtoE.Text = "WtoE : 0";
            // 
            // label3_Count_Bal
            // 
            this.label3_Count_Bal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label3_Count_Bal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3_Count_Bal.Location = new System.Drawing.Point(584, 191);
            this.label3_Count_Bal.Name = "label3_Count_Bal";
            this.label3_Count_Bal.Size = new System.Drawing.Size(37, 10);
            this.label3_Count_Bal.TabIndex = 7;
            this.label3_Count_Bal.Text = "        ";
            this.label3_Count_Bal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3_Count_Bal.UseWaitCursor = true;
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.LargeChange = 1;
            this.hScrollBar3.Location = new System.Drawing.Point(415, 299);
            this.hScrollBar3.Minimum = 1;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(321, 21);
            this.hScrollBar3.TabIndex = 0;
            this.hScrollBar3.Value = 40;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar3_Scroll);
            // 
            // NtoS_valus
            // 
            this.NtoS_valus.AutoSize = true;
            this.NtoS_valus.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NtoS_valus.Location = new System.Drawing.Point(751, 271);
            this.NtoS_valus.Name = "NtoS_valus";
            this.NtoS_valus.Size = new System.Drawing.Size(71, 13);
            this.NtoS_valus.TabIndex = 6;
            this.NtoS_valus.Text = "NtoS : 40";
            // 
            // WtoE_valus
            // 
            this.WtoE_valus.AutoSize = true;
            this.WtoE_valus.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WtoE_valus.Location = new System.Drawing.Point(750, 303);
            this.WtoE_valus.Name = "WtoE_valus";
            this.WtoE_valus.Size = new System.Drawing.Size(73, 13);
            this.WtoE_valus.TabIndex = 6;
            this.WtoE_valus.Text = "WtoE : 40";
            // 
            // label3_LightCount
            // 
            this.label3_LightCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3_LightCount.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3_LightCount.ForeColor = System.Drawing.Color.Lime;
            this.label3_LightCount.Location = new System.Drawing.Point(254, 251);
            this.label3_LightCount.Name = "label3_LightCount";
            this.label3_LightCount.Size = new System.Drawing.Size(100, 23);
            this.label3_LightCount.TabIndex = 8;
            this.label3_LightCount.Text = "빨간불 : 0";
            this.label3_LightCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4_LightCount
            // 
            this.label4_LightCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4_LightCount.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4_LightCount.ForeColor = System.Drawing.Color.Lime;
            this.label4_LightCount.Location = new System.Drawing.Point(23, 93);
            this.label4_LightCount.Name = "label4_LightCount";
            this.label4_LightCount.Size = new System.Drawing.Size(100, 23);
            this.label4_LightCount.TabIndex = 8;
            this.label4_LightCount.Text = "빨간불 : 0";
            this.label4_LightCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4_Count_Bal
            // 
            this.label4_Count_Bal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label4_Count_Bal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4_Count_Bal.Location = new System.Drawing.Point(664, 191);
            this.label4_Count_Bal.Name = "label4_Count_Bal";
            this.label4_Count_Bal.Size = new System.Drawing.Size(37, 10);
            this.label4_Count_Bal.TabIndex = 7;
            this.label4_Count_Bal.Text = "        ";
            this.label4_Count_Bal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4_Count_Bal.UseWaitCursor = true;
            // 
            // label4_EtoW
            // 
            this.label4_EtoW.AutoSize = true;
            this.label4_EtoW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4_EtoW.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4_EtoW.Location = new System.Drawing.Point(653, 209);
            this.label4_EtoW.Name = "label4_EtoW";
            this.label4_EtoW.Size = new System.Drawing.Size(60, 13);
            this.label4_EtoW.TabIndex = 6;
            this.label4_EtoW.Text = "EtoW: 0";
            // 
            // EtoW_valus
            // 
            this.EtoW_valus.AutoSize = true;
            this.EtoW_valus.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EtoW_valus.Location = new System.Drawing.Point(750, 335);
            this.EtoW_valus.Name = "EtoW_valus";
            this.EtoW_valus.Size = new System.Drawing.Size(73, 13);
            this.EtoW_valus.TabIndex = 6;
            this.EtoW_valus.Text = "EtoW : 40";
            // 
            // hScrollBar4
            // 
            this.hScrollBar4.LargeChange = 1;
            this.hScrollBar4.Location = new System.Drawing.Point(415, 331);
            this.hScrollBar4.Minimum = 1;
            this.hScrollBar4.Name = "hScrollBar4";
            this.hScrollBar4.Size = new System.Drawing.Size(321, 21);
            this.hScrollBar4.TabIndex = 0;
            this.hScrollBar4.Value = 40;
            this.hScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar4_Scroll);
            // 
            // timer5_SCount
            // 
            this.timer5_SCount.Tick += new System.EventHandler(this.timer5_SCount_Tick);
            // 
            // timer6_WCount
            // 
            this.timer6_WCount.Tick += new System.EventHandler(this.timer6_WCount_Tick);
            // 
            // timer7_ECount
            // 
            this.timer7_ECount.Tick += new System.EventHandler(this.timer7_ECount_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Traffic.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(847, 367);
            this.Controls.Add(this.hScrollBar4);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.EtoW_valus);
            this.Controls.Add(this.WtoE_valus);
            this.Controls.Add(this.NtoS_valus);
            this.Controls.Add(this.StoN_valus);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label4_EtoW);
            this.Controls.Add(this.label3_WtoE);
            this.Controls.Add(this.label2_NtoS);
            this.Controls.Add(this.label1_StoN);
            this.Controls.Add(this.button1_start);
            this.Controls.Add(this.label2_LightCount);
            this.Controls.Add(this.label4_LightCount);
            this.Controls.Add(this.label3_LightCount);
            this.Controls.Add(this.label1_LightCount);
            this.Controls.Add(this.label4_Count_Bal);
            this.Controls.Add(this.label3_Count_Bal);
            this.Controls.Add(this.label2_Count_Bal);
            this.Controls.Add(this.label1_Count_Bal);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1_start;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer4_NCount;
        public System.Windows.Forms.Timer timer4_car1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Timer timer3;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label1_StoN;
        public System.Windows.Forms.Label label1_Count_Bal;
        public System.Windows.Forms.Label label1_LightCount;
        public System.Windows.Forms.Label label2_LightCount;
        public System.Windows.Forms.Label label2_NtoS;
        public System.Windows.Forms.Label label2_Count_Bal;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        public System.Windows.Forms.Label StoN_valus;
        public System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.PictureBox pictureBox9;
        public System.Windows.Forms.Label label3_WtoE;
        public System.Windows.Forms.Label label3_Count_Bal;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        public System.Windows.Forms.Label NtoS_valus;
        public System.Windows.Forms.Label WtoE_valus;
        public System.Windows.Forms.Label label3_LightCount;
        public System.Windows.Forms.Label label4_LightCount;
        public System.Windows.Forms.Label label4_Count_Bal;
        public System.Windows.Forms.Label label4_EtoW;
        public System.Windows.Forms.Label EtoW_valus;
        private System.Windows.Forms.HScrollBar hScrollBar4;
        private System.Windows.Forms.Timer timer5_SCount;
        private System.Windows.Forms.Timer timer6_WCount;
        private System.Windows.Forms.Timer timer7_ECount;
        public System.Windows.Forms.Timer timer5;
        public System.Windows.Forms.Timer timer4;
        public System.Windows.Forms.Timer timer6;
    }
}

