namespace okrpz1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.розмірнаСіткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дляКофтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дляФутболокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дляШтанівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дляВзуттяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проРозробниківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Кофти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(146, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Футболки";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(12, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 73);
            this.button3.TabIndex = 2;
            this.button3.Text = "Штани";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(146, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 73);
            this.button4.TabIndex = 3;
            this.button4.Text = "Взуття";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.розмірнаСіткаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(273, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // розмірнаСіткаToolStripMenuItem
            // 
            this.розмірнаСіткаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дляКофтToolStripMenuItem,
            this.дляФутболокToolStripMenuItem,
            this.дляШтанівToolStripMenuItem,
            this.дляВзуттяToolStripMenuItem});
            this.розмірнаСіткаToolStripMenuItem.Name = "розмірнаСіткаToolStripMenuItem";
            this.розмірнаСіткаToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.розмірнаСіткаToolStripMenuItem.Text = "Розмірна сітка";
            // 
            // дляКофтToolStripMenuItem
            // 
            this.дляКофтToolStripMenuItem.Name = "дляКофтToolStripMenuItem";
            this.дляКофтToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.дляКофтToolStripMenuItem.Text = "Для кофт";
            this.дляКофтToolStripMenuItem.Click += new System.EventHandler(this.дляКофтToolStripMenuItem_Click);
            // 
            // дляФутболокToolStripMenuItem
            // 
            this.дляФутболокToolStripMenuItem.Name = "дляФутболокToolStripMenuItem";
            this.дляФутболокToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.дляФутболокToolStripMenuItem.Text = "Для футболок";
            this.дляФутболокToolStripMenuItem.Click += new System.EventHandler(this.дляФутболокToolStripMenuItem_Click);
            // 
            // дляШтанівToolStripMenuItem
            // 
            this.дляШтанівToolStripMenuItem.Name = "дляШтанівToolStripMenuItem";
            this.дляШтанівToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.дляШтанівToolStripMenuItem.Text = "Для штанів";
            this.дляШтанівToolStripMenuItem.Click += new System.EventHandler(this.дляШтанівToolStripMenuItem_Click);
            // 
            // дляВзуттяToolStripMenuItem
            // 
            this.дляВзуттяToolStripMenuItem.Name = "дляВзуттяToolStripMenuItem";
            this.дляВзуттяToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.дляВзуттяToolStripMenuItem.Text = "Для взуття";
            this.дляВзуттяToolStripMenuItem.Click += new System.EventHandler(this.дляВзуттяToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem,
            this.проРозробниківToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // проРозробниківToolStripMenuItem
            // 
            this.проРозробниківToolStripMenuItem.Name = "проРозробниківToolStripMenuItem";
            this.проРозробниківToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.проРозробниківToolStripMenuItem.Text = "Про розробників";
            this.проРозробниківToolStripMenuItem.Click += new System.EventHandler(this.проРозробниківToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(273, 197);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Барижна програма";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem розмірнаСіткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дляКофтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дляФутболокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дляШтанівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дляВзуттяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проРозробниківToolStripMenuItem;
    }
}

