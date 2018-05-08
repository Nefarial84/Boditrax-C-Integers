namespace C_Integers
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
            this.btnIntegers = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnMixed = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDevision = new System.Windows.Forms.Button();
            this.btnExercise1 = new System.Windows.Forms.Button();
            this.btnExercise2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntegers
            // 
            this.btnIntegers.Location = new System.Drawing.Point(12, 42);
            this.btnIntegers.Name = "btnIntegers";
            this.btnIntegers.Size = new System.Drawing.Size(124, 31);
            this.btnIntegers.TabIndex = 0;
            this.btnIntegers.Text = "Integers";
            this.btnIntegers.UseVisualStyleBackColor = true;
            this.btnIntegers.Click += new System.EventHandler(this.btnIntegers_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.Location = new System.Drawing.Point(12, 79);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(124, 31);
            this.btnFloat.TabIndex = 1;
            this.btnFloat.Text = "Float";
            this.btnFloat.UseVisualStyleBackColor = true;
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(12, 116);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(124, 33);
            this.btnDouble.TabIndex = 2;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(142, 42);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(127, 31);
            this.btnAddition.TabIndex = 3;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(142, 79);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(127, 31);
            this.btnSubtraction.TabIndex = 4;
            this.btnSubtraction.Text = "Subtraction";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnMixed
            // 
            this.btnMixed.Location = new System.Drawing.Point(142, 116);
            this.btnMixed.Name = "btnMixed";
            this.btnMixed.Size = new System.Drawing.Size(127, 33);
            this.btnMixed.TabIndex = 5;
            this.btnMixed.Text = "Mixed";
            this.btnMixed.UseVisualStyleBackColor = true;
            this.btnMixed.Click += new System.EventHandler(this.btnMixed_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(12, 155);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(124, 28);
            this.btnMultiply.TabIndex = 6;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDevision
            // 
            this.btnDevision.Location = new System.Drawing.Point(142, 155);
            this.btnDevision.Name = "btnDevision";
            this.btnDevision.Size = new System.Drawing.Size(127, 28);
            this.btnDevision.TabIndex = 7;
            this.btnDevision.Text = "Devision";
            this.btnDevision.UseVisualStyleBackColor = true;
            this.btnDevision.Click += new System.EventHandler(this.btnDevision_Click);
            // 
            // btnExercise1
            // 
            this.btnExercise1.Location = new System.Drawing.Point(12, 189);
            this.btnExercise1.Name = "btnExercise1";
            this.btnExercise1.Size = new System.Drawing.Size(123, 31);
            this.btnExercise1.TabIndex = 8;
            this.btnExercise1.Text = "Exercise1";
            this.btnExercise1.UseVisualStyleBackColor = true;
            this.btnExercise1.Click += new System.EventHandler(this.btnExercise1_Click);
            // 
            // btnExercise2
            // 
            this.btnExercise2.Location = new System.Drawing.Point(142, 189);
            this.btnExercise2.Name = "btnExercise2";
            this.btnExercise2.Size = new System.Drawing.Size(127, 31);
            this.btnExercise2.TabIndex = 9;
            this.btnExercise2.Text = "Exercise2";
            this.btnExercise2.UseVisualStyleBackColor = true;
            this.btnExercise2.Click += new System.EventHandler(this.btnExercise2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 261);
            this.Controls.Add(this.btnExercise2);
            this.Controls.Add(this.btnExercise1);
            this.Controls.Add(this.btnDevision);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMixed);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.btnIntegers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntegers;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnMixed;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDevision;
        private System.Windows.Forms.Button btnExercise1;
        private System.Windows.Forms.Button btnExercise2;
    }
}

