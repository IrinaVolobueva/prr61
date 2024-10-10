namespace PR_61
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
            this.Consultant = new System.Windows.Forms.Button();
            this.Camera = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Consultant
            // 
            this.Consultant.BackgroundImage = global::PR_61.Properties.Resources.cons;
            this.Consultant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Consultant.Location = new System.Drawing.Point(565, 154);
            this.Consultant.Name = "Consultant";
            this.Consultant.Size = new System.Drawing.Size(41, 44);
            this.Consultant.TabIndex = 0;
            this.Consultant.UseVisualStyleBackColor = true;
            this.Consultant.Click += new System.EventHandler(this.Consultant_Click);
            // 
            // Camera
            // 
            this.Camera.BackgroundImage = global::PR_61.Properties.Resources.camera;
            this.Camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Camera.Location = new System.Drawing.Point(49, 58);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(42, 34);
            this.Camera.TabIndex = 1;
            this.Camera.UseVisualStyleBackColor = true;
            this.Camera.Click += new System.EventHandler(this.Camera_Click);
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = global::PR_61.Properties.Resources.e;
            this.Exit.Location = new System.Drawing.Point(12, 283);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 33);
            this.Exit.TabIndex = 2;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PR_61.Properties.Resources.teh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(692, 328);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Camera);
            this.Controls.Add(this.Consultant);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Паттерны";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Consultant;
        private System.Windows.Forms.Button Camera;
        private System.Windows.Forms.Button Exit;
    }
}

