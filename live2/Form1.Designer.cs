namespace live2
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            size = new TextBox();
            field = new Label();
            random = new Button();
            clean = new Button();
            stop = new Button();
            button1 = new Button();
            liveTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pole = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(size);
            panel1.Controls.Add(field);
            panel1.Controls.Add(random);
            panel1.Controls.Add(clean);
            panel1.Controls.Add(stop);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 514);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 39);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // size
            // 
            size.Location = new Point(679, 8);
            size.Name = "size";
            size.Size = new Size(125, 27);
            size.TabIndex = 4;
            // 
            // field
            // 
            field.AutoSize = true;
            field.Location = new Point(409, 10);
            field.Name = "field";
            field.Size = new Size(273, 20);
            field.TabIndex = 3;
            field.Text = "Введите размер поля через пробел - ";
            field.Click += fieldform;
            // 
            // random
            // 
            random.Location = new Point(309, 7);
            random.Name = "random";
            random.Size = new Size(94, 29);
            random.TabIndex = 1;
            random.Text = "Random";
            random.UseVisualStyleBackColor = true;
            random.Click += formRandom;
            // 
            // clean
            // 
            clean.Location = new Point(209, 7);
            clean.Name = "clean";
            clean.Size = new Size(94, 29);
            clean.TabIndex = 2;
            clean.Text = "Clean";
            clean.UseVisualStyleBackColor = true;
            clean.Click += formClean;
            // 
            // stop
            // 
            stop.Location = new Point(109, 7);
            stop.Name = "stop";
            stop.Size = new Size(94, 29);
            stop.TabIndex = 1;
            stop.Text = "Stop";
            stop.UseVisualStyleBackColor = true;
            stop.Click += formStop;
            // 
            // button1
            // 
            button1.Location = new Point(9, 7);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += formStart;
            // 
            // liveTimer
            // 
            liveTimer.Interval = 500;
            liveTimer.Tick += timerTick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.Info;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1178, 505);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pole
            // 
            pole.Location = new Point(12, 3);
            pole.Multiline = true;
            pole.Name = "pole";
            pole.Size = new Size(368, 226);
            pole.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(pole);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button random;
        private Button clean;
        private Button stop;
        private Button button1;
        private System.Windows.Forms.Timer liveTimer;
        private PictureBox pictureBox1;
        private TextBox pole;
        private TextBox size;
        private Label field;
    }
}
