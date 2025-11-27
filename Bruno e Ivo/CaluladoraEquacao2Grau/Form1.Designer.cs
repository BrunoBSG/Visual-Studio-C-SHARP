namespace CaluladoraEquacao2Grau
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
            btnTraco = new Button();
            btnCalc = new Button();
            btnLimpar = new Button();
            btnHistorico = new Button();
            listBox1 = new ListBox();
            txtXII = new TextBox();
            txtDelta = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            txtXI = new TextBox();
            label2 = new Label();
            btn0 = new Button();
            btnX = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            txtA = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtB = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtC = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnTraco
            // 
            btnTraco.BackColor = Color.NavajoWhite;
            btnTraco.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnTraco.Location = new Point(248, 289);
            btnTraco.Name = "btnTraco";
            btnTraco.Size = new Size(109, 42);
            btnTraco.TabIndex = 11;
            btnTraco.Text = "-";
            btnTraco.UseVisualStyleBackColor = false;
            btnTraco.Click += btnTraco_Click;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.NavajoWhite;
            btnCalc.Font = new Font("SansSerif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalc.Location = new Point(6, 88);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(333, 34);
            btnCalc.TabIndex = 0;
            btnCalc.Text = "CALCULAR";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.NavajoWhite;
            btnLimpar.Font = new Font("SansSerif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(6, 128);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(333, 34);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.NavajoWhite;
            btnHistorico.Font = new Font("SansSerif", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistorico.Location = new Point(4, 168);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(333, 34);
            btnHistorico.TabIndex = 2;
            btnHistorico.Text = "Ver Histórico do Cálculo";
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 208);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(333, 124);
            listBox1.TabIndex = 3;
            // 
            // txtXII
            // 
            txtXII.BackColor = Color.DarkOrange;
            txtXII.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtXII.Location = new Point(239, 52);
            txtXII.Multiline = true;
            txtXII.Name = "txtXII";
            txtXII.ReadOnly = true;
            txtXII.Size = new Size(100, 30);
            txtXII.TabIndex = 4;
            txtXII.TextChanged += txtXII_TextChanged;
            // 
            // txtDelta
            // 
            txtDelta.BackColor = Color.DarkOrange;
            txtDelta.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtDelta.Location = new Point(239, 16);
            txtDelta.Multiline = true;
            txtDelta.Name = "txtDelta";
            txtDelta.ReadOnly = true;
            txtDelta.Size = new Size(100, 30);
            txtDelta.TabIndex = 5;
            txtDelta.TextChanged += txtDelta_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(185, 52);
            label1.Name = "label1";
            label1.Size = new Size(45, 31);
            label1.TabIndex = 6;
            label1.Text = "x\":";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtXI);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDelta);
            groupBox1.Controls.Add(txtXII);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(btnHistorico);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnCalc);
            groupBox1.Location = new Point(12, 337);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 341);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SansSerif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(209, 21);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 10;
            label3.Text = "=";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.delta;
            pictureBox1.Location = new Point(142, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // txtXI
            // 
            txtXI.BackColor = Color.DarkOrange;
            txtXI.Font = new Font("SansSerif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtXI.Location = new Point(79, 53);
            txtXI.Multiline = true;
            txtXI.Name = "txtXI";
            txtXI.ReadOnly = true;
            txtXI.Size = new Size(100, 30);
            txtXI.TabIndex = 8;
            txtXI.TextChanged += txtXI_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 53);
            label2.Name = "label2";
            label2.Size = new Size(40, 31);
            label2.TabIndex = 7;
            label2.Text = "x':";
            // 
            // btn0
            // 
            btn0.BackColor = Color.NavajoWhite;
            btn0.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(127, 289);
            btn0.Name = "btn0";
            btn0.Size = new Size(115, 42);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += BtnEventClick;
            // 
            // btnX
            // 
            btnX.BackColor = Color.NavajoWhite;
            btnX.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnX.Location = new Point(12, 289);
            btnX.Name = "btnX";
            btnX.Size = new Size(109, 42);
            btnX.TabIndex = 13;
            btnX.Text = "x";
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += btnX_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.NavajoWhite;
            btn1.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(12, 241);
            btn1.Name = "btn1";
            btn1.Size = new Size(109, 42);
            btn1.TabIndex = 16;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += BtnEventClick;
            // 
            // btn2
            // 
            btn2.BackColor = Color.NavajoWhite;
            btn2.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(127, 241);
            btn2.Name = "btn2";
            btn2.Size = new Size(115, 42);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += BtnEventClick;
            // 
            // btn3
            // 
            btn3.BackColor = Color.NavajoWhite;
            btn3.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(248, 241);
            btn3.Name = "btn3";
            btn3.Size = new Size(109, 42);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += BtnEventClick;
            // 
            // btn4
            // 
            btn4.BackColor = Color.NavajoWhite;
            btn4.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(12, 193);
            btn4.Name = "btn4";
            btn4.Size = new Size(109, 42);
            btn4.TabIndex = 19;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += BtnEventClick;
            // 
            // btn5
            // 
            btn5.BackColor = Color.NavajoWhite;
            btn5.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(127, 193);
            btn5.Name = "btn5";
            btn5.Size = new Size(115, 42);
            btn5.TabIndex = 18;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += BtnEventClick;
            // 
            // btn6
            // 
            btn6.BackColor = Color.NavajoWhite;
            btn6.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(248, 193);
            btn6.Name = "btn6";
            btn6.Size = new Size(109, 42);
            btn6.TabIndex = 17;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += BtnEventClick;
            // 
            // btn7
            // 
            btn7.BackColor = Color.NavajoWhite;
            btn7.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(12, 145);
            btn7.Name = "btn7";
            btn7.Size = new Size(109, 42);
            btn7.TabIndex = 22;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += BtnEventClick;
            // 
            // btn8
            // 
            btn8.BackColor = Color.NavajoWhite;
            btn8.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(127, 145);
            btn8.Name = "btn8";
            btn8.Size = new Size(115, 42);
            btn8.TabIndex = 21;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += BtnEventClick;
            // 
            // btn9
            // 
            btn9.BackColor = Color.NavajoWhite;
            btn9.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(248, 145);
            btn9.Name = "btn9";
            btn9.Size = new Size(109, 42);
            btn9.TabIndex = 20;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += BtnEventClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.matematica;
            pictureBox2.Location = new Point(-1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(370, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SansSerif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(62, 65);
            label4.Name = "label4";
            label4.Size = new Size(227, 28);
            label4.TabIndex = 24;
            label4.Text = "Equação do 2º Grau";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 98);
            label5.Name = "label5";
            label5.Size = new Size(23, 31);
            label5.TabIndex = 25;
            label5.Text = "(";
            // 
            // txtA
            // 
            txtA.Font = new Font("SansSerif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            txtA.Location = new Point(22, 98);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.Size = new Size(49, 31);
            txtA.TabIndex = 26;
            txtA.Text = "A";
            txtA.TextAlign = HorizontalAlignment.Center;
            txtA.TextChanged += MudarCorA;
            txtA.Enter += MudarCorA;
            txtA.KeyPress += KeyPresstxt;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(62, 98);
            label6.Name = "label6";
            label6.Size = new Size(23, 31);
            label6.TabIndex = 27;
            label6.Text = ")";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(182, 98);
            label7.Name = "label7";
            label7.Size = new Size(23, 31);
            label7.TabIndex = 30;
            label7.Text = ")";
            // 
            // txtB
            // 
            txtB.Font = new Font("SansSerif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            txtB.Location = new Point(142, 98);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.Size = new Size(49, 31);
            txtB.TabIndex = 29;
            txtB.Text = "B";
            txtB.TextAlign = HorizontalAlignment.Center;
            txtB.Enter += MudarCorB;
            txtB.KeyPress += KeyPresstxt;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(123, 98);
            label8.Name = "label8";
            label8.Size = new Size(23, 31);
            label8.TabIndex = 28;
            label8.Text = "(";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(306, 98);
            label9.Name = "label9";
            label9.Size = new Size(23, 31);
            label9.TabIndex = 33;
            label9.Text = ")";
            // 
            // txtC
            // 
            txtC.Font = new Font("SansSerif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            txtC.Location = new Point(266, 98);
            txtC.Multiline = true;
            txtC.Name = "txtC";
            txtC.Size = new Size(49, 31);
            txtC.TabIndex = 32;
            txtC.Text = "C";
            txtC.TextAlign = HorizontalAlignment.Center;
            txtC.Enter += MudarCorC;
            txtC.KeyPress += KeyPresstxt;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("SansSerif", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(247, 98);
            label10.Name = "label10";
            label10.Size = new Size(23, 31);
            label10.TabIndex = 31;
            label10.Text = "(";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("SansSerif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(77, 104);
            label11.Name = "label11";
            label11.Size = new Size(48, 25);
            label11.TabIndex = 34;
            label11.Text = "x² +";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("SansSerif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(201, 104);
            label12.Name = "label12";
            label12.Size = new Size(41, 25);
            label12.TabIndex = 35;
            label12.Text = "x +";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("SansSerif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(321, 104);
            label13.Name = "label13";
            label13.Size = new Size(36, 25);
            label13.TabIndex = 36;
            label13.Text = "=0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(369, 681);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(txtC);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(txtB);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtA);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnX);
            Controls.Add(btn0);
            Controls.Add(btnTraco);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matematica Com Aplicativo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTraco;
        private Button btnCalc;
        private Button btnLimpar;
        private Button btnHistorico;
        private ListBox listBox1;
        private TextBox txtXII;
        private TextBox txtDelta;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txtXI;
        private Label label2;
        private Button btn0;
        private Button btnX;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private TextBox txtA;
        private Label label6;
        private Label label7;
        private TextBox txtB;
        private Label label8;
        private Label label9;
        private TextBox txtC;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}
