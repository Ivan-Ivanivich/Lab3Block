namespace SimplePaint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.brushGroupBox = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sizeTrackBar = new System.Windows.Forms.TrackBar();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolsPanel.SuspendLayout();
            this.brushGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
            this.drawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolsPanel
            // 
            this.toolsPanel.Controls.Add(this.brushGroupBox);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsPanel.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(267, 555);
            this.toolsPanel.TabIndex = 1;
            // 
            // brushGroupBox
            // 
            this.brushGroupBox.Controls.Add(this.button4);
            this.brushGroupBox.Controls.Add(this.button3);
            this.brushGroupBox.Controls.Add(this.button2);
            this.brushGroupBox.Controls.Add(this.button1);
            this.brushGroupBox.Controls.Add(this.sizeTrackBar);
            this.brushGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.brushGroupBox.Location = new System.Drawing.Point(0, 0);
            this.brushGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brushGroupBox.Name = "brushGroupBox";
            this.brushGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brushGroupBox.Size = new System.Drawing.Size(267, 159);
            this.brushGroupBox.TabIndex = 0;
            this.brushGroupBox.TabStop = false;
            this.brushGroupBox.Text = "Выбор кисти";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(140, 123);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "Кнопка 4 lol";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 123);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Круг";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 76);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Прямоугольник";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Квадрат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sizeTrackBar
            // 
            this.sizeTrackBar.AutoSize = false;
            this.sizeTrackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.sizeTrackBar.Location = new System.Drawing.Point(4, 19);
            this.sizeTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizeTrackBar.Maximum = 50;
            this.sizeTrackBar.Minimum = 1;
            this.sizeTrackBar.Name = "sizeTrackBar";
            this.sizeTrackBar.Size = new System.Drawing.Size(259, 49);
            this.sizeTrackBar.TabIndex = 0;
            this.sizeTrackBar.Value = 1;
            // 
            // drawPanel
            // 
            this.drawPanel.Controls.Add(this.pictureBox1);
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPanel.Location = new System.Drawing.Point(267, 0);
            this.drawPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(742, 555);
            this.drawPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 555);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 555);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.toolsPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolsPanel.ResumeLayout(false);
            this.brushGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
            this.drawPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.GroupBox brushGroupBox;
        private System.Windows.Forms.TrackBar sizeTrackBar;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

