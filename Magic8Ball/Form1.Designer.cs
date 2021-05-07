
namespace Magic8Ball
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
            this.question = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.Transparent;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(173, -3);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(302, 44);
            this.question.TabIndex = 0;
            this.question.Text = "Think of a question ";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputButton
            // 
            this.inputButton.BackColor = System.Drawing.Color.Transparent;
            this.inputButton.FlatAppearance.BorderSize = 0;
            this.inputButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.inputButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.inputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputButton.Location = new System.Drawing.Point(245, 187);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(148, 135);
            this.inputButton.TabIndex = 1;
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(12, 472);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(631, 51);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Magic8Ball.Properties.Resources.clickBall1;
            this.ClientSize = new System.Drawing.Size(655, 532);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.question);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

