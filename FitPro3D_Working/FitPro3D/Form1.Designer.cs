namespace FitPro3D
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picRef = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopRec = new System.Windows.Forms.Button();
            this.startRec = new System.Windows.Forms.Button();
            this.debugLabel2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outLabel = new System.Windows.Forms.Label();
            this.debugLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chooseExer = new System.Windows.Forms.GroupBox();
            this.shoulderRadio = new System.Windows.Forms.RadioButton();
            this.biRadio = new System.Windows.Forms.RadioButton();
            this.squatRadio = new System.Windows.Forms.RadioButton();
            this.jacksRadio = new System.Windows.Forms.RadioButton();
            this.plankRadio = new System.Windows.Forms.RadioButton();
            this.wallRadio = new System.Windows.Forms.RadioButton();
            this.sitRadio = new System.Windows.Forms.RadioButton();
            this.pushRadio = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.successIndicator = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.curCountLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.jumpLabel = new System.Windows.Forms.Label();
            this.sqLabel = new System.Windows.Forms.Label();
            this.biLabel = new System.Windows.Forms.Label();
            this.shLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picRef)).BeginInit();
            this.chooseExer.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRef
            // 
            this.picRef.BackColor = System.Drawing.Color.White;
            this.picRef.Location = new System.Drawing.Point(16, 78);
            this.picRef.Margin = new System.Windows.Forms.Padding(4);
            this.picRef.Name = "picRef";
            this.picRef.Size = new System.Drawing.Size(683, 423);
            this.picRef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRef.TabIndex = 0;
            this.picRef.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 550);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 646);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Debug";
            // 
            // stopRec
            // 
            this.stopRec.BackColor = System.Drawing.Color.Red;
            this.stopRec.Location = new System.Drawing.Point(759, 665);
            this.stopRec.Margin = new System.Windows.Forms.Padding(4);
            this.stopRec.Name = "stopRec";
            this.stopRec.Size = new System.Drawing.Size(216, 53);
            this.stopRec.TabIndex = 7;
            this.stopRec.Text = "Stop Recording";
            this.stopRec.UseVisualStyleBackColor = false;
            this.stopRec.Click += new System.EventHandler(this.stopRec_Click);
            // 
            // startRec
            // 
            this.startRec.BackColor = System.Drawing.Color.LawnGreen;
            this.startRec.Location = new System.Drawing.Point(759, 571);
            this.startRec.Margin = new System.Windows.Forms.Padding(4);
            this.startRec.Name = "startRec";
            this.startRec.Size = new System.Drawing.Size(216, 53);
            this.startRec.TabIndex = 8;
            this.startRec.Text = "Start Recording";
            this.startRec.UseVisualStyleBackColor = false;
            this.startRec.Click += new System.EventHandler(this.startRec_Click);
            // 
            // debugLabel2
            // 
            this.debugLabel2.BackColor = System.Drawing.Color.LightBlue;
            this.debugLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debugLabel2.Location = new System.Drawing.Point(1425, 443);
            this.debugLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.debugLabel2.Name = "debugLabel2";
            this.debugLabel2.Size = new System.Drawing.Size(258, 299);
            this.debugLabel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(5, 539);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1043, 206);
            this.label4.TabIndex = 10;
            // 
            // outLabel
            // 
            this.outLabel.BackColor = System.Drawing.Color.White;
            this.outLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLabel.Location = new System.Drawing.Point(13, 583);
            this.outLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(669, 41);
            this.outLabel.TabIndex = 11;
            this.outLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // debugLabel
            // 
            this.debugLabel.BackColor = System.Drawing.Color.White;
            this.debugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugLabel.Location = new System.Drawing.Point(13, 679);
            this.debugLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(669, 41);
            this.debugLabel.TabIndex = 12;
            this.debugLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Reference";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1035, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "Live";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1691, 41);
            this.label6.TabIndex = 15;
            // 
            // chooseExer
            // 
            this.chooseExer.Controls.Add(this.shoulderRadio);
            this.chooseExer.Controls.Add(this.biRadio);
            this.chooseExer.Controls.Add(this.squatRadio);
            this.chooseExer.Controls.Add(this.jacksRadio);
            this.chooseExer.Controls.Add(this.plankRadio);
            this.chooseExer.Controls.Add(this.wallRadio);
            this.chooseExer.Controls.Add(this.sitRadio);
            this.chooseExer.Controls.Add(this.pushRadio);
            this.chooseExer.Location = new System.Drawing.Point(1075, 532);
            this.chooseExer.Margin = new System.Windows.Forms.Padding(4);
            this.chooseExer.Name = "chooseExer";
            this.chooseExer.Padding = new System.Windows.Forms.Padding(4);
            this.chooseExer.Size = new System.Drawing.Size(325, 210);
            this.chooseExer.TabIndex = 16;
            this.chooseExer.TabStop = false;
            this.chooseExer.Text = "Choose an exercise";
            // 
            // shoulderRadio
            // 
            this.shoulderRadio.AutoSize = true;
            this.shoulderRadio.Location = new System.Drawing.Point(175, 165);
            this.shoulderRadio.Margin = new System.Windows.Forms.Padding(4);
            this.shoulderRadio.Name = "shoulderRadio";
            this.shoulderRadio.Size = new System.Drawing.Size(126, 21);
            this.shoulderRadio.TabIndex = 7;
            this.shoulderRadio.TabStop = true;
            this.shoulderRadio.Text = "Shoulder Press";
            this.shoulderRadio.UseVisualStyleBackColor = true;
            // 
            // biRadio
            // 
            this.biRadio.AutoSize = true;
            this.biRadio.Location = new System.Drawing.Point(175, 121);
            this.biRadio.Margin = new System.Windows.Forms.Padding(4);
            this.biRadio.Name = "biRadio";
            this.biRadio.Size = new System.Drawing.Size(93, 21);
            this.biRadio.TabIndex = 6;
            this.biRadio.TabStop = true;
            this.biRadio.Text = "Bicep Curl";
            this.biRadio.UseVisualStyleBackColor = true;
            // 
            // squatRadio
            // 
            this.squatRadio.AutoSize = true;
            this.squatRadio.Location = new System.Drawing.Point(175, 79);
            this.squatRadio.Margin = new System.Windows.Forms.Padding(4);
            this.squatRadio.Name = "squatRadio";
            this.squatRadio.Size = new System.Drawing.Size(66, 21);
            this.squatRadio.TabIndex = 5;
            this.squatRadio.TabStop = true;
            this.squatRadio.Text = "Squat";
            this.squatRadio.UseVisualStyleBackColor = true;
            // 
            // jacksRadio
            // 
            this.jacksRadio.AutoSize = true;
            this.jacksRadio.Location = new System.Drawing.Point(175, 34);
            this.jacksRadio.Margin = new System.Windows.Forms.Padding(4);
            this.jacksRadio.Name = "jacksRadio";
            this.jacksRadio.Size = new System.Drawing.Size(122, 21);
            this.jacksRadio.TabIndex = 4;
            this.jacksRadio.TabStop = true;
            this.jacksRadio.Text = "Jumping Jacks";
            this.jacksRadio.UseVisualStyleBackColor = true;
            // 
            // plankRadio
            // 
            this.plankRadio.AutoSize = true;
            this.plankRadio.Location = new System.Drawing.Point(20, 165);
            this.plankRadio.Margin = new System.Windows.Forms.Padding(4);
            this.plankRadio.Name = "plankRadio";
            this.plankRadio.Size = new System.Drawing.Size(64, 21);
            this.plankRadio.TabIndex = 3;
            this.plankRadio.TabStop = true;
            this.plankRadio.Text = "Plank";
            this.plankRadio.UseVisualStyleBackColor = true;
            // 
            // wallRadio
            // 
            this.wallRadio.AutoSize = true;
            this.wallRadio.Location = new System.Drawing.Point(20, 121);
            this.wallRadio.Margin = new System.Windows.Forms.Padding(4);
            this.wallRadio.Name = "wallRadio";
            this.wallRadio.Size = new System.Drawing.Size(77, 21);
            this.wallRadio.TabIndex = 2;
            this.wallRadio.TabStop = true;
            this.wallRadio.Text = "Wall-Sit";
            this.wallRadio.UseVisualStyleBackColor = true;
            // 
            // sitRadio
            // 
            this.sitRadio.AutoSize = true;
            this.sitRadio.Location = new System.Drawing.Point(20, 79);
            this.sitRadio.Margin = new System.Windows.Forms.Padding(4);
            this.sitRadio.Name = "sitRadio";
            this.sitRadio.Size = new System.Drawing.Size(68, 21);
            this.sitRadio.TabIndex = 1;
            this.sitRadio.TabStop = true;
            this.sitRadio.Text = "Sit-Up";
            this.sitRadio.UseVisualStyleBackColor = true;
            // 
            // pushRadio
            // 
            this.pushRadio.AutoSize = true;
            this.pushRadio.Location = new System.Drawing.Point(20, 34);
            this.pushRadio.Margin = new System.Windows.Forms.Padding(4);
            this.pushRadio.Name = "pushRadio";
            this.pushRadio.Size = new System.Drawing.Size(84, 21);
            this.pushRadio.TabIndex = 0;
            this.pushRadio.TabStop = true;
            this.pushRadio.Text = "Push-Up";
            this.pushRadio.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(5, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(706, 445);
            this.label7.TabIndex = 17;
            // 
            // successIndicator
            // 
            this.successIndicator.BackColor = System.Drawing.Color.ForestGreen;
            this.successIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.successIndicator.Location = new System.Drawing.Point(716, 66);
            this.successIndicator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.successIndicator.Name = "successIndicator";
            this.successIndicator.Size = new System.Drawing.Size(706, 445);
            this.successIndicator.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1492, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "Analysis";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Turquoise;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1516, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 38);
            this.label9.TabIndex = 20;
            this.label9.Text = "Timer";
            // 
            // timerLabel
            // 
            this.timerLabel.BackColor = System.Drawing.Color.Turquoise;
            this.timerLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(1441, 127);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(237, 65);
            this.timerLabel.TabIndex = 21;
            this.timerLabel.Text = "00:00:00";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightBlue;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1426, 474);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 27);
            this.label11.TabIndex = 23;
            this.label11.Text = "Jumping Jacks: ";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Yellow;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1425, 408);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(258, 36);
            this.label12.TabIndex = 24;
            this.label12.Text = "Records";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightBlue;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1426, 539);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 27);
            this.label13.TabIndex = 25;
            this.label13.Text = "Squat Count: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightBlue;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1426, 618);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 27);
            this.label14.TabIndex = 26;
            this.label14.Text = "Bicep Curls:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightBlue;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1426, 689);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 27);
            this.label15.TabIndex = 27;
            this.label15.Text = "Shoulder Presses: ";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Turquoise;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(1429, 68);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(254, 147);
            this.label16.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Lime;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1463, 244);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(196, 38);
            this.label17.TabIndex = 29;
            this.label17.Text = "Current Count";
            // 
            // curCountLabel
            // 
            this.curCountLabel.BackColor = System.Drawing.Color.Lime;
            this.curCountLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curCountLabel.Location = new System.Drawing.Point(1512, 293);
            this.curCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curCountLabel.Name = "curCountLabel";
            this.curCountLabel.Size = new System.Drawing.Size(103, 65);
            this.curCountLabel.TabIndex = 30;
            this.curCountLabel.Text = "0";
            this.curCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Lime;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(1429, 230);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(254, 147);
            this.label19.TabIndex = 31;
            // 
            // jumpLabel
            // 
            this.jumpLabel.BackColor = System.Drawing.Color.LightBlue;
            this.jumpLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumpLabel.Location = new System.Drawing.Point(1616, 466);
            this.jumpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jumpLabel.Name = "jumpLabel";
            this.jumpLabel.Size = new System.Drawing.Size(61, 38);
            this.jumpLabel.TabIndex = 32;
            this.jumpLabel.Text = "0";
            this.jumpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sqLabel
            // 
            this.sqLabel.BackColor = System.Drawing.Color.LightBlue;
            this.sqLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqLabel.Location = new System.Drawing.Point(1616, 539);
            this.sqLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sqLabel.Name = "sqLabel";
            this.sqLabel.Size = new System.Drawing.Size(62, 38);
            this.sqLabel.TabIndex = 33;
            this.sqLabel.Text = "0";
            this.sqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // biLabel
            // 
            this.biLabel.BackColor = System.Drawing.Color.LightBlue;
            this.biLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biLabel.Location = new System.Drawing.Point(1618, 610);
            this.biLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.biLabel.Name = "biLabel";
            this.biLabel.Size = new System.Drawing.Size(60, 38);
            this.biLabel.TabIndex = 34;
            this.biLabel.Text = "0";
            this.biLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shLabel
            // 
            this.shLabel.BackColor = System.Drawing.Color.LightBlue;
            this.shLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shLabel.Location = new System.Drawing.Point(1620, 682);
            this.shLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shLabel.Name = "shLabel";
            this.shLabel.Size = new System.Drawing.Size(58, 38);
            this.shLabel.TabIndex = 35;
            this.shLabel.Text = "0";
            this.shLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 94;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(728, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 420);
            this.panel1.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1687, 799);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shLabel);
            this.Controls.Add(this.biLabel);
            this.Controls.Add(this.sqLabel);
            this.Controls.Add(this.jumpLabel);
            this.Controls.Add(this.curCountLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chooseExer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.debugLabel2);
            this.Controls.Add(this.startRec);
            this.Controls.Add(this.stopRec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picRef);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.successIndicator);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitPro3D";
            ((System.ComponentModel.ISupportInitialize)(this.picRef)).EndInit();
            this.chooseExer.ResumeLayout(false);
            this.chooseExer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stopRec;
        private System.Windows.Forms.Button startRec;
        private System.Windows.Forms.Label debugLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox chooseExer;
        private System.Windows.Forms.RadioButton squatRadio;
        private System.Windows.Forms.RadioButton jacksRadio;
        private System.Windows.Forms.RadioButton plankRadio;
        private System.Windows.Forms.RadioButton wallRadio;
        private System.Windows.Forms.RadioButton sitRadio;
        private System.Windows.Forms.RadioButton pushRadio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label successIndicator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label curCountLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label jumpLabel;
        private System.Windows.Forms.Label sqLabel;
        private System.Windows.Forms.Label biLabel;
        private System.Windows.Forms.Label shLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton shoulderRadio;
        private System.Windows.Forms.RadioButton biRadio;
        private System.Windows.Forms.Panel panel1;
    }
}

