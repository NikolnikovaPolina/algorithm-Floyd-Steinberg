namespace WindowsFormsApp1
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
            this.pbSource = new System.Windows.Forms.PictureBox();
            this.pbRes = new System.Windows.Forms.PictureBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btPerform = new System.Windows.Forms.Button();
            this.dOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSource
            // 
            this.pbSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSource.Location = new System.Drawing.Point(16, 15);
            this.pbSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(332, 307);
            this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSource.TabIndex = 0;
            this.pbSource.TabStop = false;
            // 
            // pbRes
            // 
            this.pbRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbRes.Location = new System.Drawing.Point(511, 15);
            this.pbRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbRes.Name = "pbRes";
            this.pbRes.Size = new System.Drawing.Size(332, 307);
            this.pbRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRes.TabIndex = 1;
            this.pbRes.TabStop = false;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(361, 124);
            this.btOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(121, 28);
            this.btOpen.TabIndex = 2;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btPerform
            // 
            this.btPerform.Enabled = false;
            this.btPerform.Location = new System.Drawing.Point(361, 160);
            this.btPerform.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPerform.Name = "btPerform";
            this.btPerform.Size = new System.Drawing.Size(121, 28);
            this.btPerform.TabIndex = 3;
            this.btPerform.Text = "Perform";
            this.btPerform.UseVisualStyleBackColor = true;
            this.btPerform.Click += new System.EventHandler(this.btPerform_Click);
            // 
            // dOpen
            // 
            this.dOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 337);
            this.Controls.Add(this.btPerform);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.pbRes);
            this.Controls.Add(this.pbSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Floyd–Steinberg dithering";
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox pbRes;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btPerform;
        private System.Windows.Forms.OpenFileDialog dOpen;
    }
}

