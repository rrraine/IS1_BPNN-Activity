namespace BackPropagation
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.outputN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.input3 = new System.Windows.Forms.TextBox();
            this.input4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(171, 195);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(324, 22);
            this.input1.TabIndex = 0;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(171, 230);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(324, 22);
            this.input2.TabIndex = 1;
            // 
            // outputN
            // 
            this.outputN.Location = new System.Drawing.Point(573, 230);
            this.outputN.Name = "outputN";
            this.outputN.Size = new System.Drawing.Size(324, 22);
            this.outputN.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(171, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "create BPNN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createNeuralNetBtnClick);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(415, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Train the Neural Net";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.trainNeuralNetBtnClick);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(659, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.testBtnClick);
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(171, 267);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(324, 22);
            this.input3.TabIndex = 6;
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(171, 308);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(324, 22);
            this.input4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 670);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputN);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox outputN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.TextBox input4;
    }
}

