namespace Logarifm
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
            this.btn_sim = new System.Windows.Forms.Button();
            this.btn_sqr = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.textSim = new System.Windows.Forms.TextBox();
            this.text_sqr = new System.Windows.Forms.TextBox();
            this.text_del = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_sim
            // 
            this.btn_sim.Location = new System.Drawing.Point(348, 179);
            this.btn_sim.Name = "btn_sim";
            this.btn_sim.Size = new System.Drawing.Size(75, 23);
            this.btn_sim.TabIndex = 0;
            this.btn_sim.Text = "Simpson";
            this.btn_sim.UseVisualStyleBackColor = true;
            this.btn_sim.Click += new System.EventHandler(this.btn_sim_Click);
            // 
            // btn_sqr
            // 
            this.btn_sqr.Location = new System.Drawing.Point(348, 208);
            this.btn_sqr.Name = "btn_sqr";
            this.btn_sqr.Size = new System.Drawing.Size(75, 23);
            this.btn_sqr.TabIndex = 2;
            this.btn_sqr.Text = "Sqr";
            this.btn_sqr.UseVisualStyleBackColor = true;
            this.btn_sqr.Click += new System.EventHandler(this.btn_sqr_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(348, 237);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Del";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // textSim
            // 
            this.textSim.Location = new System.Drawing.Point(429, 179);
            this.textSim.Name = "textSim";
            this.textSim.Size = new System.Drawing.Size(100, 20);
            this.textSim.TabIndex = 4;
            this.textSim.TextChanged += new System.EventHandler(this.textSim_TextChanged);
            // 
            // text_sqr
            // 
            this.text_sqr.Location = new System.Drawing.Point(429, 208);
            this.text_sqr.Name = "text_sqr";
            this.text_sqr.Size = new System.Drawing.Size(100, 20);
            this.text_sqr.TabIndex = 5;
            this.text_sqr.TextChanged += new System.EventHandler(this.text_sqr_TextChanged);
            // 
            // text_del
            // 
            this.text_del.Location = new System.Drawing.Point(429, 240);
            this.text_del.Name = "text_del";
            this.text_del.Size = new System.Drawing.Size(100, 20);
            this.text_del.TabIndex = 6;
            this.text_del.TextChanged += new System.EventHandler(this.text_del_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_del);
            this.Controls.Add(this.text_sqr);
            this.Controls.Add(this.textSim);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_sqr);
            this.Controls.Add(this.btn_sim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sim;
        private System.Windows.Forms.Button btn_sqr;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox textSim;
        private System.Windows.Forms.TextBox text_sqr;
        private System.Windows.Forms.TextBox text_del;
    }
}

