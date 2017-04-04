namespace detWinFormMain
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
            this.buttonTrue = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelDet = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHigh = new System.Windows.Forms.TextBox();
            this.textBoxDet = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.dataGridViewMatrixT = new System.Windows.Forms.DataGridView();
            this.labelMatrix = new System.Windows.Forms.Label();
            this.labelMatrixT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixT)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTrue
            // 
            this.buttonTrue.Location = new System.Drawing.Point(261, 25);
            this.buttonTrue.Name = "buttonTrue";
            this.buttonTrue.Size = new System.Drawing.Size(75, 23);
            this.buttonTrue.TabIndex = 0;
            this.buttonTrue.Text = "Прийняти";
            this.buttonTrue.UseVisualStyleBackColor = true;
            this.buttonTrue.Click += new System.EventHandler(this.buttonTrue_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(398, 24);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Вихід";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Location = new System.Drawing.Point(57, 24);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(67, 13);
            this.labelHigh.TabIndex = 4;
            this.labelHigh.Text = "Розмірність";
            // 
            // labelDet
            // 
            this.labelDet.AutoSize = true;
            this.labelDet.Location = new System.Drawing.Point(57, 58);
            this.labelDet.Name = "labelDet";
            this.labelDet.Size = new System.Drawing.Size(72, 13);
            this.labelDet.TabIndex = 5;
            this.labelDet.Text = "Детермінант";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(135, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(13, 13);
            this.label.TabIndex = 6;
            this.label.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "=";
            // 
            // textBoxHigh
            // 
            this.textBoxHigh.Location = new System.Drawing.Point(165, 25);
            this.textBoxHigh.Name = "textBoxHigh";
            this.textBoxHigh.Size = new System.Drawing.Size(59, 20);
            this.textBoxHigh.TabIndex = 8;
            this.textBoxHigh.Text = "0";
            // 
            // textBoxDet
            // 
            this.textBoxDet.Location = new System.Drawing.Point(165, 58);
            this.textBoxDet.Name = "textBoxDet";
            this.textBoxDet.Size = new System.Drawing.Size(59, 20);
            this.textBoxDet.TabIndex = 9;
            this.textBoxDet.Text = "0";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewMatrix.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(46, 114);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersWidth = 10;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(233, 232);
            this.dataGridViewMatrix.TabIndex = 4;
            // 
            // dataGridViewMatrixT
            // 
            this.dataGridViewMatrixT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewMatrixT.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMatrixT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixT.Location = new System.Drawing.Point(307, 114);
            this.dataGridViewMatrixT.Name = "dataGridViewMatrixT";
            this.dataGridViewMatrixT.RowHeadersWidth = 10;
            this.dataGridViewMatrixT.Size = new System.Drawing.Size(239, 232);
            this.dataGridViewMatrixT.TabIndex = 4;
            // 
            // labelMatrix
            // 
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Location = new System.Drawing.Point(138, 95);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(51, 13);
            this.labelMatrix.TabIndex = 10;
            this.labelMatrix.Text = "Матриця";
            // 
            // labelMatrixT
            // 
            this.labelMatrixT.AutoSize = true;
            this.labelMatrixT.Location = new System.Drawing.Point(360, 94);
            this.labelMatrixT.Name = "labelMatrixT";
            this.labelMatrixT.Size = new System.Drawing.Size(132, 13);
            this.labelMatrixT.TabIndex = 11;
            this.labelMatrixT.Text = "Транспонована матриця";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 370);
            this.Controls.Add(this.labelMatrixT);
            this.Controls.Add(this.labelMatrix);
            this.Controls.Add(this.dataGridViewMatrixT);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.textBoxDet);
            this.Controls.Add(this.textBoxHigh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelDet);
            this.Controls.Add(this.labelHigh);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonTrue);
            this.Name = "Form1";
            this.Text = "Main Matrix";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTrue;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelDet;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHigh;
        private System.Windows.Forms.TextBox textBoxDet;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.DataGridView dataGridViewMatrixT;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.Label labelMatrixT;
    }
}

