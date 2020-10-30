namespace WinFormsApp_HitTheKey
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
      this.components = new System.ComponentModel.Container();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.totalLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.accuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.difficultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      this.process1 = new System.Diagnostics.Process();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.eventLog1 = new System.Diagnostics.EventLog();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.statusStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.listBox1.ForeColor = System.Drawing.Color.LawnGreen;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 108;
      this.listBox1.Location = new System.Drawing.Point(0, 0);
      this.listBox1.MultiColumn = true;
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(860, 394);
      this.listBox1.TabIndex = 0;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // timer1
      // 
      this.timer1.Interval = 800;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missedLabel,
            this.totalLabel,
            this.accuracyLabel,
            this.toolStripStatusLabel1,
            this.difficultyProgressBar});
      this.statusStrip1.Location = new System.Drawing.Point(0, 372);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(860, 22);
      this.statusStrip1.SizingGrip = false;
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // correctLabel
      // 
      this.correctLabel.Name = "correctLabel";
      this.correctLabel.Size = new System.Drawing.Size(58, 17);
      this.correctLabel.Text = "Correct: 0";
      // 
      // missedLabel
      // 
      this.missedLabel.Name = "missedLabel";
      this.missedLabel.Size = new System.Drawing.Size(56, 17);
      this.missedLabel.Text = "Missed: 0";
      // 
      // totalLabel
      // 
      this.totalLabel.Name = "totalLabel";
      this.totalLabel.Size = new System.Drawing.Size(44, 17);
      this.totalLabel.Text = "Total: 0";
      // 
      // accuracyLabel
      // 
      this.accuracyLabel.Name = "accuracyLabel";
      this.accuracyLabel.Size = new System.Drawing.Size(78, 17);
      this.accuracyLabel.Text = "Accuracy: 0%";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(507, 17);
      this.toolStripStatusLabel1.Spring = true;
      this.toolStripStatusLabel1.Text = "Difficulty";
      this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // difficultyProgressBar
      // 
      this.difficultyProgressBar.Maximum = 701;
      this.difficultyProgressBar.Name = "difficultyProgressBar";
      this.difficultyProgressBar.Size = new System.Drawing.Size(100, 16);
      // 
      // process1
      // 
      this.process1.StartInfo.Domain = "";
      this.process1.StartInfo.LoadUserProfile = false;
      this.process1.StartInfo.Password = null;
      this.process1.StartInfo.StandardErrorEncoding = null;
      this.process1.StartInfo.StandardOutputEncoding = null;
      this.process1.StartInfo.UserName = "";
      this.process1.SynchronizingObject = this;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(12, 118);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(80, 17);
      this.checkBox1.TabIndex = 2;
      this.checkBox1.Text = "checkBox1";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // eventLog1
      // 
      this.eventLog1.SynchronizingObject = this;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new System.Drawing.Point(170, 118);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(80, 17);
      this.checkBox2.TabIndex = 3;
      this.checkBox2.Text = "checkBox2";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new System.Drawing.Point(352, 118);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(80, 17);
      this.checkBox3.TabIndex = 4;
      this.checkBox3.Text = "checkBox3";
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // checkBox4
      // 
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new System.Drawing.Point(542, 118);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new System.Drawing.Size(80, 17);
      this.checkBox4.TabIndex = 5;
      this.checkBox4.Text = "checkBox4";
      this.checkBox4.UseVisualStyleBackColor = true;
      // 
      // errorProvider2
      // 
      this.errorProvider2.ContainerControl = this;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.Crimson;
      this.label1.Location = new System.Drawing.Point(729, 118);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "label1";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(860, 394);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.checkBox4);
      this.Controls.Add(this.checkBox3);
      this.Controls.Add(this.checkBox2);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.listBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.KeyPreview = true;
      this.Name = "Form1";
      this.Text = "Hit the keys!";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel correctLabel;
        private System.Windows.Forms.ToolStripStatusLabel missedLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalLabel;
        private System.Windows.Forms.ToolStripStatusLabel accuracyLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar difficultyProgressBar;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

