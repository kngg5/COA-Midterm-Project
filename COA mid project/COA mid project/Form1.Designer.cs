namespace COA_mid_project
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
            this.menuBar = new System.Windows.Forms.Panel();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eraserBrush = new System.Windows.Forms.PictureBox();
            this.pencilBrush = new System.Windows.Forms.PictureBox();
            this.pencilBrush_size = new System.Windows.Forms.NumericUpDown();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eraserBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilBrush_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuBar.Controls.Add(this.label2);
            this.menuBar.Controls.Add(this.button3);
            this.menuBar.Controls.Add(this.colorBox);
            this.menuBar.Controls.Add(this.pencilBrush_size);
            this.menuBar.Controls.Add(this.eraserBrush);
            this.menuBar.Controls.Add(this.pencilBrush);
            this.menuBar.Controls.Add(this.label1);
            this.menuBar.Controls.Add(this.button2);
            this.menuBar.Controls.Add(this.button1);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(800, 56);
            this.menuBar.TabIndex = 0;
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.Color.White;
            this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawingPanel.Location = new System.Drawing.Point(0, 56);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(800, 403);
            this.drawingPanel.TabIndex = 1;
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.draw_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.draw_MouseMove);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(583, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(699, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Draw Now";
            // 
            // eraserBrush
            // 
            this.eraserBrush.Image = global::COA_mid_project.Properties.Resources.eraserIcon;
            this.eraserBrush.Location = new System.Drawing.Point(233, 3);
            this.eraserBrush.Name = "eraserBrush";
            this.eraserBrush.Size = new System.Drawing.Size(44, 50);
            this.eraserBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eraserBrush.TabIndex = 0;
            this.eraserBrush.TabStop = false;
            this.eraserBrush.Click += new System.EventHandler(this.eraserBrush_Click);
            // 
            // pencilBrush
            // 
            this.pencilBrush.BackColor = System.Drawing.SystemColors.ControlText;
            this.pencilBrush.Image = global::COA_mid_project.Properties.Resources.pencilImage;
            this.pencilBrush.Location = new System.Drawing.Point(179, 3);
            this.pencilBrush.Name = "pencilBrush";
            this.pencilBrush.Size = new System.Drawing.Size(48, 50);
            this.pencilBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pencilBrush.TabIndex = 0;
            this.pencilBrush.TabStop = false;
            this.pencilBrush.Click += new System.EventHandler(this.pencilBrush_Click);
            // 
            // pencilBrush_size
            // 
            this.pencilBrush_size.Location = new System.Drawing.Point(306, 28);
            this.pencilBrush_size.Name = "pencilBrush_size";
            this.pencilBrush_size.Size = new System.Drawing.Size(60, 20);
            this.pencilBrush_size.TabIndex = 3;
            this.pencilBrush_size.ValueChanged += new System.EventHandler(this.pencilBrushSize);
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Black;
            this.colorBox.Location = new System.Drawing.Point(413, 10);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(36, 40);
            this.colorBox.TabIndex = 4;
            this.colorBox.TabStop = false;
            this.colorBox.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(483, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(303, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Size of brush";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Draw Now";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eraserBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilBrush_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.PictureBox pencilBrush;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox eraserBrush;
        private System.Windows.Forms.NumericUpDown pencilBrush_size;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}

