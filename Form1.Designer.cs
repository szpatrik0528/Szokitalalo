namespace Szo_kitalalo
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
            this.label_word = new System.Windows.Forms.Label();
            this.textBox_guess = new System.Windows.Forms.TextBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_word
            // 
            this.label_word.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_word.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_word.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_word.Location = new System.Drawing.Point(24, 19);
            this.label_word.Name = "label_word";
            this.label_word.Size = new System.Drawing.Size(304, 65);
            this.label_word.TabIndex = 0;
            this.label_word.Text = "Word";
            this.label_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_guess
            // 
            this.textBox_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_guess.Location = new System.Drawing.Point(23, 103);
            this.textBox_guess.Name = "textBox_guess";
            this.textBox_guess.Size = new System.Drawing.Size(305, 38);
            this.textBox_guess.TabIndex = 1;
            this.textBox_guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_next.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_next.Location = new System.Drawing.Point(23, 169);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(305, 64);
            this.button_next.TabIndex = 2;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_start.Location = new System.Drawing.Point(23, 255);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(305, 63);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_result
            // 
            this.label_result.BackColor = System.Drawing.Color.Orange;
            this.label_result.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_result.ForeColor = System.Drawing.Color.White;
            this.label_result.Location = new System.Drawing.Point(24, 345);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(304, 65);
            this.label_result.TabIndex = 4;
            this.label_result.Text = "Result";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_score.Location = new System.Drawing.Point(157, 421);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(24, 18);
            this.label_score.TabIndex = 5;
            this.label_score.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 457);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.textBox_guess);
            this.Controls.Add(this.label_word);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_word;
        private System.Windows.Forms.TextBox textBox_guess;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_score;
    }
}

