namespace SportsLotteryTicketNumberBookVideo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWriteNum = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnConfirmNum = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRandomSelectNum = new System.Windows.Forms.Button();
            this.btnRandomSelectNums = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum7 = new System.Windows.Forms.TextBox();
            this.txtNum6 = new System.Windows.Forms.TextBox();
            this.txtNum5 = new System.Windows.Forms.TextBox();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNumCount = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lbNumList = new System.Windows.Forms.ListBox();
            this.lblNum7 = new System.Windows.Forms.Label();
            this.lblNum6 = new System.Windows.Forms.Label();
            this.lblNum5 = new System.Windows.Forms.Label();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFrmName = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.RandomTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.btnWriteNum);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnConfirmNum);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnRandomSelectNum);
            this.panel1.Controls.Add(this.btnRandomSelectNums);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNum7);
            this.panel1.Controls.Add(this.txtNum6);
            this.panel1.Controls.Add(this.txtNum5);
            this.panel1.Controls.Add(this.txtNum4);
            this.panel1.Controls.Add(this.txtNum3);
            this.panel1.Controls.Add(this.txtNum2);
            this.panel1.Controls.Add(this.txtNumCount);
            this.panel1.Controls.Add(this.txtNum1);
            this.panel1.Controls.Add(this.lbNumList);
            this.panel1.Controls.Add(this.lblNum7);
            this.panel1.Controls.Add(this.lblNum6);
            this.panel1.Controls.Add(this.lblNum5);
            this.panel1.Controls.Add(this.lblNum4);
            this.panel1.Controls.Add(this.lblNum3);
            this.panel1.Controls.Add(this.lblNum2);
            this.panel1.Controls.Add(this.lblNum1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 566);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // btnWriteNum
            // 
            this.btnWriteNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteNum.Location = new System.Drawing.Point(706, 295);
            this.btnWriteNum.Name = "btnWriteNum";
            this.btnWriteNum.Size = new System.Drawing.Size(113, 39);
            this.btnWriteNum.TabIndex = 5;
            this.btnWriteNum.Text = "手写号码";
            this.btnWriteNum.UseVisualStyleBackColor = true;
            this.btnWriteNum.Click += new System.EventHandler(this.btnWriteNum_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(706, 389);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(113, 137);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnConfirmNum
            // 
            this.btnConfirmNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirmNum.Location = new System.Drawing.Point(566, 389);
            this.btnConfirmNum.Name = "btnConfirmNum";
            this.btnConfirmNum.Size = new System.Drawing.Size(113, 50);
            this.btnConfirmNum.TabIndex = 5;
            this.btnConfirmNum.Text = "确认选号";
            this.btnConfirmNum.UseVisualStyleBackColor = true;
            this.btnConfirmNum.Click += new System.EventHandler(this.btnConfirmNum_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(566, 476);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 50);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清  空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(435, 476);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 50);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删   除";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRandomSelectNum
            // 
            this.btnRandomSelectNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRandomSelectNum.Location = new System.Drawing.Point(436, 389);
            this.btnRandomSelectNum.Name = "btnRandomSelectNum";
            this.btnRandomSelectNum.Size = new System.Drawing.Size(113, 50);
            this.btnRandomSelectNum.TabIndex = 5;
            this.btnRandomSelectNum.Text = "随机选号";
            this.btnRandomSelectNum.UseVisualStyleBackColor = true;
            this.btnRandomSelectNum.Click += new System.EventHandler(this.btnRandomSelectNum_Click);
            // 
            // btnRandomSelectNums
            // 
            this.btnRandomSelectNums.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRandomSelectNums.Location = new System.Drawing.Point(584, 295);
            this.btnRandomSelectNums.Name = "btnRandomSelectNums";
            this.btnRandomSelectNums.Size = new System.Drawing.Size(113, 39);
            this.btnRandomSelectNums.TabIndex = 5;
            this.btnRandomSelectNums.Text = "随机组选";
            this.btnRandomSelectNums.UseVisualStyleBackColor = true;
            this.btnRandomSelectNums.Click += new System.EventHandler(this.btnRandomSelectNums_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(429, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "组数：";
            // 
            // txtNum7
            // 
            this.txtNum7.BackColor = System.Drawing.Color.Orange;
            this.txtNum7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum7.Location = new System.Drawing.Point(783, 219);
            this.txtNum7.Name = "txtNum7";
            this.txtNum7.Size = new System.Drawing.Size(36, 39);
            this.txtNum7.TabIndex = 3;
            this.txtNum7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum6
            // 
            this.txtNum6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum6.Location = new System.Drawing.Point(686, 218);
            this.txtNum6.Name = "txtNum6";
            this.txtNum6.Size = new System.Drawing.Size(36, 39);
            this.txtNum6.TabIndex = 3;
            this.txtNum6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum5
            // 
            this.txtNum5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum5.Location = new System.Drawing.Point(636, 218);
            this.txtNum5.Name = "txtNum5";
            this.txtNum5.Size = new System.Drawing.Size(36, 39);
            this.txtNum5.TabIndex = 3;
            this.txtNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum4
            // 
            this.txtNum4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum4.Location = new System.Drawing.Point(586, 218);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(36, 39);
            this.txtNum4.TabIndex = 3;
            this.txtNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum3
            // 
            this.txtNum3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum3.Location = new System.Drawing.Point(536, 218);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(36, 39);
            this.txtNum3.TabIndex = 3;
            this.txtNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum2.Location = new System.Drawing.Point(486, 218);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(36, 39);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumCount
            // 
            this.txtNumCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNumCount.Location = new System.Drawing.Point(523, 295);
            this.txtNumCount.Name = "txtNumCount";
            this.txtNumCount.Size = new System.Drawing.Size(36, 39);
            this.txtNumCount.TabIndex = 3;
            this.txtNumCount.Text = "5";
            this.txtNumCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum1.Location = new System.Drawing.Point(436, 218);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(36, 39);
            this.txtNum1.TabIndex = 3;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbNumList
            // 
            this.lbNumList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNumList.FormattingEnabled = true;
            this.lbNumList.ItemHeight = 28;
            this.lbNumList.Location = new System.Drawing.Point(45, 218);
            this.lbNumList.Name = "lbNumList";
            this.lbNumList.Size = new System.Drawing.Size(368, 312);
            this.lbNumList.TabIndex = 2;
            // 
            // lblNum7
            // 
            this.lblNum7.BackColor = System.Drawing.Color.Orange;
            this.lblNum7.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNum7.ForeColor = System.Drawing.Color.Black;
            this.lblNum7.Location = new System.Drawing.Point(769, 135);
            this.lblNum7.Name = "lblNum7";
            this.lblNum7.Size = new System.Drawing.Size(50, 49);
            this.lblNum7.TabIndex = 1;
            this.lblNum7.Text = "0";
            this.lblNum7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum6
            // 
            this.lblNum6.BackColor = System.Drawing.Color.White;
            this.lblNum6.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNum6.ForeColor = System.Drawing.Color.Black;
            this.lblNum6.Location = new System.Drawing.Point(611, 135);
            this.lblNum6.Name = "lblNum6";
            this.lblNum6.Size = new System.Drawing.Size(50, 49);
            this.lblNum6.TabIndex = 1;
            this.lblNum6.Text = "0";
            this.lblNum6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum5
            // 
            this.lblNum5.BackColor = System.Drawing.Color.White;
            this.lblNum5.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNum5.ForeColor = System.Drawing.Color.Black;
            this.lblNum5.Location = new System.Drawing.Point(498, 135);
            this.lblNum5.Name = "lblNum5";
            this.lblNum5.Size = new System.Drawing.Size(50, 49);
            this.lblNum5.TabIndex = 1;
            this.lblNum5.Text = "0";
            this.lblNum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum4
            // 
            this.lblNum4.BackColor = System.Drawing.Color.White;
            this.lblNum4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNum4.ForeColor = System.Drawing.Color.Black;
            this.lblNum4.Location = new System.Drawing.Point(385, 135);
            this.lblNum4.Name = "lblNum4";
            this.lblNum4.Size = new System.Drawing.Size(50, 49);
            this.lblNum4.TabIndex = 1;
            this.lblNum4.Text = "0";
            this.lblNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum3
            // 
            this.lblNum3.BackColor = System.Drawing.Color.White;
            this.lblNum3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNum3.ForeColor = System.Drawing.Color.Black;
            this.lblNum3.Location = new System.Drawing.Point(272, 135);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(50, 49);
            this.lblNum3.TabIndex = 1;
            this.lblNum3.Text = "0";
            this.lblNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum2
            // 
            this.lblNum2.BackColor = System.Drawing.Color.White;
            this.lblNum2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNum2.ForeColor = System.Drawing.Color.Black;
            this.lblNum2.Location = new System.Drawing.Point(159, 135);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(50, 49);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "0";
            this.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum1
            // 
            this.lblNum1.BackColor = System.Drawing.Color.White;
            this.lblNum1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNum1.ForeColor = System.Drawing.Color.Black;
            this.lblNum1.Location = new System.Drawing.Point(46, 135);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(50, 49);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "0";
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(162, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(492, 67);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "6+1体育彩票选号器";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblFrmName);
            this.panel2.Controls.Add(this.picBoxLogo);
            this.panel2.Controls.Add(this.btnMax);
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 67);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // lblFrmName
            // 
            this.lblFrmName.AutoSize = true;
            this.lblFrmName.Font = new System.Drawing.Font("仿宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFrmName.ForeColor = System.Drawing.Color.White;
            this.lblFrmName.Location = new System.Drawing.Point(77, 20);
            this.lblFrmName.Name = "lblFrmName";
            this.lblFrmName.Size = new System.Drawing.Size(215, 28);
            this.lblFrmName.TabIndex = 2;
            this.lblFrmName.Text = "体育彩票选号器";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(48, 41);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 1;
            this.picBoxLogo.TabStop = false;
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(765, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(36, 34);
            this.btnMax.TabIndex = 0;
            this.btnMax.Text = "□";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(807, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(36, 34);
            this.btnMin.TabIndex = 0;
            this.btnMin.Text = "▁";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(849, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RandomTimer
            // 
            this.RandomTimer.Tick += new System.EventHandler(this.RandomTimer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(897, 669);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "体育彩票选号器";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblFrmName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNum6;
        private System.Windows.Forms.Label lblNum5;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum7;
        private System.Windows.Forms.ListBox lbNumList;
        private System.Windows.Forms.TextBox txtNum7;
        private System.Windows.Forms.TextBox txtNum6;
        private System.Windows.Forms.TextBox txtNum5;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNumCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWriteNum;
        private System.Windows.Forms.Button btnRandomSelectNums;
        private System.Windows.Forms.Button btnConfirmNum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRandomSelectNum;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Timer RandomTimer;
    }
}

