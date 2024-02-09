namespace Analyzer
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
            this.input = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.identifiersLabel = new System.Windows.Forms.Label();
            this.identifiers = new System.Windows.Forms.ListBox();
            this.constantsLabel = new System.Windows.Forms.Label();
            this.constants = new System.Windows.Forms.ListBox();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.iterations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(13, 32);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(757, 22);
            this.input.TabIndex = 0;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(13, 13);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(115, 17);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Введите строку:";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(16, 61);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(119, 27);
            this.check.TabIndex = 2;
            this.check.Text = "Анализировать";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(150, 66);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 17);
            this.result.TabIndex = 3;
            // 
            // identifiersLabel
            // 
            this.identifiersLabel.AutoSize = true;
            this.identifiersLabel.Location = new System.Drawing.Point(13, 111);
            this.identifiersLabel.Name = "identifiersLabel";
            this.identifiersLabel.Size = new System.Drawing.Size(128, 17);
            this.identifiersLabel.TabIndex = 4;
            this.identifiersLabel.Text = "Идентификаторы:";
            // 
            // identifiers
            // 
            this.identifiers.FormattingEnabled = true;
            this.identifiers.ItemHeight = 16;
            this.identifiers.Location = new System.Drawing.Point(12, 131);
            this.identifiers.Name = "identifiers";
            this.identifiers.Size = new System.Drawing.Size(373, 292);
            this.identifiers.TabIndex = 5;
            // 
            // constantsLabel
            // 
            this.constantsLabel.AutoSize = true;
            this.constantsLabel.Location = new System.Drawing.Point(394, 111);
            this.constantsLabel.Name = "constantsLabel";
            this.constantsLabel.Size = new System.Drawing.Size(84, 17);
            this.constantsLabel.TabIndex = 6;
            this.constantsLabel.Text = "Константы:";
            // 
            // constants
            // 
            this.constants.FormattingEnabled = true;
            this.constants.ItemHeight = 16;
            this.constants.Location = new System.Drawing.Point(397, 131);
            this.constants.Name = "constants";
            this.constants.Size = new System.Drawing.Size(373, 292);
            this.constants.TabIndex = 7;
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Location = new System.Drawing.Point(13, 430);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(200, 17);
            this.iterationsLabel.TabIndex = 8;
            this.iterationsLabel.Text = "Количество итераций цикла:";
            // 
            // iterations
            // 
            this.iterations.AutoSize = true;
            this.iterations.Location = new System.Drawing.Point(219, 430);
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(0, 17);
            this.iterations.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.iterations);
            this.Controls.Add(this.iterationsLabel);
            this.Controls.Add(this.constants);
            this.Controls.Add(this.constantsLabel);
            this.Controls.Add(this.identifiers);
            this.Controls.Add(this.identifiersLabel);
            this.Controls.Add(this.result);
            this.Controls.Add(this.check);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.input);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Анализатор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label identifiersLabel;
        private System.Windows.Forms.ListBox identifiers;
        private System.Windows.Forms.Label constantsLabel;
        private System.Windows.Forms.ListBox constants;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.Label iterations;
    }
}

