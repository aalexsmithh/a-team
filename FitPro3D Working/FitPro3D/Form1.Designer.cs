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
            this.picRef = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.capReference = new System.Windows.Forms.Button();
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
            this.pushLabel = new System.Windows.Forms.Label();
            this.SitLabel = new System.Windows.Forms.Label();
            this.crunchLabel = new System.Windows.Forms.Label();
            this.squatLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picRef)).BeginInit();
            this.chooseExer.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRef
            // 
            this.picRef.BackColor = System.Drawing.Color.White;
            this.picRef.Location = new System.Drawing.Point(12, 63);
            this.picRef.Name = "picRef";
            this.picRef.Size = new System.Drawing.Size(512, 344);
            this.picRef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRef.TabIndex = 0;
            this.picRef.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 447);
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
            this.label2.Location = new System.Drawing.Point(10, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Debug";
            // 
            // capReference
            // 
            this.capReference.Location = new System.Drawing.Point(569, 453);
            this.capReference.Name = "capReference";
            this.capReference.Size = new System.Drawing.Size(162, 43);
            this.capReference.TabIndex = 6;
            this.capReference.Text = "Capture Reference";
            this.capReference.UseVisualStyleBackColor = true;
            // 
            // stopRec
            // 
            this.stopRec.BackColor = System.Drawing.Color.Red;
            this.stopRec.Location = new System.Drawing.Point(569, 551);
            this.stopRec.Name = "stopRec";
            this.stopRec.Size = new System.Drawing.Size(162, 43);
            this.stopRec.TabIndex = 7;
            this.stopRec.Text = "Stop Recording";
            this.stopRec.UseVisualStyleBackColor = false;
            this.stopRec.Click += new System.EventHandler(this.stopRec_Click);
            // 
            // startRec
            // 
            this.startRec.BackColor = System.Drawing.Color.LawnGreen;
            this.startRec.Location = new System.Drawing.Point(569, 502);
            this.startRec.Name = "startRec";
            this.startRec.Size = new System.Drawing.Size(162, 43);
            this.startRec.TabIndex = 8;
            this.startRec.Text = "Start Recording";
            this.startRec.UseVisualStyleBackColor = false;
            this.startRec.Click += new System.EventHandler(this.startRec_Click);
            // 
            // debugLabel2
            // 
            this.debugLabel2.BackColor = System.Drawing.Color.LightBlue;
            this.debugLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debugLabel2.Location = new System.Drawing.Point(1073, 360);
            this.debugLabel2.Name = "debugLabel2";
            this.debugLabel2.Size = new System.Drawing.Size(205, 243);
            this.debugLabel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(4, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(783, 168);
            this.label4.TabIndex = 10;
            // 
            // outLabel
            // 
            this.outLabel.BackColor = System.Drawing.Color.White;
            this.outLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLabel.Location = new System.Drawing.Point(10, 474);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(502, 33);
            this.outLabel.TabIndex = 11;
            this.outLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // debugLabel
            // 
            this.debugLabel.BackColor = System.Drawing.Color.White;
            this.debugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugLabel.Location = new System.Drawing.Point(10, 552);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(502, 33);
            this.debugLabel.TabIndex = 12;
            this.debugLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 15);
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
            this.label5.Location = new System.Drawing.Point(776, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "Live";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(9, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1269, 34);
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
            this.chooseExer.Location = new System.Drawing.Point(806, 432);
            this.chooseExer.Name = "chooseExer";
            this.chooseExer.Size = new System.Drawing.Size(244, 171);
            this.chooseExer.TabIndex = 16;
            this.chooseExer.TabStop = false;
            this.chooseExer.Text = "Choose an exercise";
            // 
            // shoulderRadio
            // 
            this.shoulderRadio.AutoSize = true;
            this.shoulderRadio.Location = new System.Drawing.Point(131, 134);
            this.shoulderRadio.Name = "shoulderRadio";
            this.shoulderRadio.Size = new System.Drawing.Size(112, 19);
            this.shoulderRadio.TabIndex = 7;
            this.shoulderRadio.TabStop = true;
            this.shoulderRadio.Text = "Shoulder Press";
            this.shoulderRadio.UseVisualStyleBackColor = true;
            // 
            // biRadio
            // 
            this.biRadio.AutoSize = true;
            this.biRadio.Location = new System.Drawing.Point(131, 98);
            this.biRadio.Name = "biRadio";
            this.biRadio.Size = new System.Drawing.Size(84, 19);
            this.biRadio.TabIndex = 6;
            this.biRadio.TabStop = true;
            this.biRadio.Text = "Bicep Curl";
            this.biRadio.UseVisualStyleBackColor = true;
            // 
            // squatRadio
            // 
            this.squatRadio.AutoSize = true;
            this.squatRadio.Location = new System.Drawing.Point(131, 64);
            this.squatRadio.Name = "squatRadio";
            this.squatRadio.Size = new System.Drawing.Size(60, 19);
            this.squatRadio.TabIndex = 5;
            this.squatRadio.TabStop = true;
            this.squatRadio.Text = "Squat";
            this.squatRadio.UseVisualStyleBackColor = true;
            // 
            // jacksRadio
            // 
            this.jacksRadio.AutoSize = true;
            this.jacksRadio.Location = new System.Drawing.Point(131, 28);
            this.jacksRadio.Name = "jacksRadio";
            this.jacksRadio.Size = new System.Drawing.Size(110, 19);
            this.jacksRadio.TabIndex = 4;
            this.jacksRadio.TabStop = true;
            this.jacksRadio.Text = "Jumping Jacks";
            this.jacksRadio.UseVisualStyleBackColor = true;
            // 
            // plankRadio
            // 
            this.plankRadio.AutoSize = true;
            this.plankRadio.Location = new System.Drawing.Point(15, 134);
            this.plankRadio.Name = "plankRadio";
            this.plankRadio.Size = new System.Drawing.Size(59, 19);
            this.plankRadio.TabIndex = 3;
            this.plankRadio.TabStop = true;
            this.plankRadio.Text = "Plank";
            this.plankRadio.UseVisualStyleBackColor = true;
            // 
            // wallRadio
            // 
            this.wallRadio.AutoSize = true;
            this.wallRadio.Location = new System.Drawing.Point(15, 98);
            this.wallRadio.Name = "wallRadio";
            this.wallRadio.Size = new System.Drawing.Size(70, 19);
            this.wallRadio.TabIndex = 2;
            this.wallRadio.TabStop = true;
            this.wallRadio.Text = "Wall-Sit";
            this.wallRadio.UseVisualStyleBackColor = true;
            // 
            // sitRadio
            // 
            this.sitRadio.AutoSize = true;
            this.sitRadio.Location = new System.Drawing.Point(15, 64);
            this.sitRadio.Name = "sitRadio";
            this.sitRadio.Size = new System.Drawing.Size(62, 19);
            this.sitRadio.TabIndex = 1;
            this.sitRadio.TabStop = true;
            this.sitRadio.Text = "Sit-Up";
            this.sitRadio.UseVisualStyleBackColor = true;
            // 
            // pushRadio
            // 
            this.pushRadio.AutoSize = true;
            this.pushRadio.Location = new System.Drawing.Point(15, 28);
            this.pushRadio.Name = "pushRadio";
            this.pushRadio.Size = new System.Drawing.Size(76, 19);
            this.pushRadio.TabIndex = 0;
            this.pushRadio.TabStop = true;
            this.pushRadio.Text = "Push-Up";
            this.pushRadio.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(4, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(530, 362);
            this.label7.TabIndex = 17;
            // 
            // successIndicator
            // 
            this.successIndicator.BackColor = System.Drawing.Color.ForestGreen;
            this.successIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.successIndicator.Location = new System.Drawing.Point(537, 54);
            this.successIndicator.Name = "successIndicator";
            this.successIndicator.Size = new System.Drawing.Size(530, 362);
            this.successIndicator.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1119, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "Analysis";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Turquoise;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1137, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 31);
            this.label9.TabIndex = 20;
            this.label9.Text = "Timer";
            // 
            // timerLabel
            // 
            this.timerLabel.BackColor = System.Drawing.Color.Turquoise;
            this.timerLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(1081, 103);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(191, 53);
            this.timerLabel.TabIndex = 21;
            this.timerLabel.Text = "00:00:00";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightBlue;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1074, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "Push-up count: ";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightSalmon;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1073, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 22);
            this.label12.TabIndex = 24;
            this.label12.Text = "Records";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightBlue;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1074, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 22);
            this.label13.TabIndex = 25;
            this.label13.Text = "Sit-up count: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightBlue;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1074, 502);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 22);
            this.label14.TabIndex = 26;
            this.label14.Text = "Crunch count: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightBlue;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1074, 560);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 22);
            this.label15.TabIndex = 27;
            this.label15.Text = "Squat count: ";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Turquoise;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(1072, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(206, 120);
            this.label16.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Lime;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1104, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(173, 31);
            this.label17.TabIndex = 29;
            this.label17.Text = "Current Count";
            // 
            // curCountLabel
            // 
            this.curCountLabel.BackColor = System.Drawing.Color.Lime;
            this.curCountLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curCountLabel.Location = new System.Drawing.Point(1137, 240);
            this.curCountLabel.Name = "curCountLabel";
            this.curCountLabel.Size = new System.Drawing.Size(77, 53);
            this.curCountLabel.TabIndex = 30;
            this.curCountLabel.Text = "0";
            this.curCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Lime;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(1072, 187);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(206, 120);
            this.label19.TabIndex = 31;
            // 
            // pushLabel
            // 
            this.pushLabel.BackColor = System.Drawing.SystemColors.Control;
            this.pushLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pushLabel.Location = new System.Drawing.Point(1195, 379);
            this.pushLabel.Name = "pushLabel";
            this.pushLabel.Size = new System.Drawing.Size(77, 31);
            this.pushLabel.TabIndex = 32;
            this.pushLabel.Text = "0";
            this.pushLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SitLabel
            // 
            this.SitLabel.BackColor = System.Drawing.SystemColors.Control;
            this.SitLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SitLabel.Location = new System.Drawing.Point(1195, 438);
            this.SitLabel.Name = "SitLabel";
            this.SitLabel.Size = new System.Drawing.Size(77, 31);
            this.SitLabel.TabIndex = 33;
            this.SitLabel.Text = "0";
            this.SitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crunchLabel
            // 
            this.crunchLabel.BackColor = System.Drawing.SystemColors.Control;
            this.crunchLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crunchLabel.Location = new System.Drawing.Point(1195, 496);
            this.crunchLabel.Name = "crunchLabel";
            this.crunchLabel.Size = new System.Drawing.Size(77, 31);
            this.crunchLabel.TabIndex = 34;
            this.crunchLabel.Text = "0";
            this.crunchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // squatLabel
            // 
            this.squatLabel.BackColor = System.Drawing.SystemColors.Control;
            this.squatLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squatLabel.Location = new System.Drawing.Point(1195, 554);
            this.squatLabel.Name = "squatLabel";
            this.squatLabel.Size = new System.Drawing.Size(77, 31);
            this.squatLabel.TabIndex = 35;
            this.squatLabel.Text = "0";
            this.squatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 94;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(546, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 341);
            this.panel1.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.squatLabel);
            this.Controls.Add(this.crunchLabel);
            this.Controls.Add(this.SitLabel);
            this.Controls.Add(this.pushLabel);
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
            this.Controls.Add(this.capReference);
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
        private System.Windows.Forms.Button capReference;
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
        private System.Windows.Forms.Label pushLabel;
        private System.Windows.Forms.Label SitLabel;
        private System.Windows.Forms.Label crunchLabel;
        private System.Windows.Forms.Label squatLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton shoulderRadio;
        private System.Windows.Forms.RadioButton biRadio;
        private System.Windows.Forms.Panel panel1;
    }
}

