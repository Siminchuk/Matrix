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
            this.labelMatrix = new System.Windows.Forms.Label();
            this.labelMatrixT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHigh = new System.Windows.Forms.TextBox();
            this.textBoxDet = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.dataGridViewMatrixT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixT)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTrue
            // 
            this.buttonTrue.Location = new System.Drawing.Point(366, 45);
            this.buttonTrue.Name = "buttonTrue";
            this.buttonTrue.Size = new System.Drawing.Size(126, 48);
            this.buttonTrue.TabIndex = 0;
            this.buttonTrue.Text = "Прийняти";
            this.buttonTrue.UseVisualStyleBackColor = true;
            this.buttonTrue.Click += new System.EventHandler(this.buttonTrue_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(551, 45);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(130, 49);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Вихід";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Location = new System.Drawing.Point(37, 45);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(67, 13);
            this.labelHigh.TabIndex = 2;
            this.labelHigh.Text = "Розмірність";
            // 
            // labelDet
            // 
            this.labelDet.AutoSize = true;
            this.labelDet.Location = new System.Drawing.Point(40, 80);
            this.labelDet.Name = "labelDet";
            this.labelDet.Size = new System.Drawing.Size(72, 13);
            this.labelDet.TabIndex = 3;
            this.labelDet.Text = "Детермінант";
            // 
            // labelMatrix
            // 
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Location = new System.Drawing.Point(144, 142);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(51, 13);
            this.labelMatrix.TabIndex = 4;
            this.labelMatrix.Text = "Матриця";
            // 
            // labelMatrixT
            // 
            this.labelMatrixT.AutoSize = true;
            this.labelMatrixT.Location = new System.Drawing.Point(460, 142);
            this.labelMatrixT.Name = "labelMatrixT";
            this.labelMatrixT.Size = new System.Drawing.Size(132, 13);
            this.labelMatrixT.TabIndex = 5;
            this.labelMatrixT.Text = "Транспонована матриця";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // textBoxHigh
            // 
            this.textBoxHigh.Location = new System.Drawing.Point(159, 45);
            this.textBoxHigh.Name = "textBoxHigh";
            this.textBoxHigh.Size = new System.Drawing.Size(52, 20);
            this.textBoxHigh.TabIndex = 8;
            this.textBoxHigh.Text = "0";
            // 
            // textBoxDet
            // 
            this.textBoxDet.Location = new System.Drawing.Point(159, 81);
            this.textBoxDet.Name = "textBoxDet";
            this.textBoxDet.Size = new System.Drawing.Size(52, 20);
            this.textBoxDet.TabIndex = 9;
            this.textBoxDet.Text = "0";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewMatrix.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(40, 169);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.Size = new System.Drawing.Size(299, 246);
            this.dataGridViewMatrix.TabIndex = 10;
            // 
            // dataGridViewMatrixT
            // 
            this.dataGridViewMatrixT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewMatrixT.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMatrixT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixT.Location = new System.Drawing.Point(383, 169);
            this.dataGridViewMatrixT.Name = "dataGridViewMatrixT";
            this.dataGridViewMatrixT.Size = new System.Drawing.Size(317, 246);
            this.dataGridViewMatrixT.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 448);
            this.Controls.Add(this.dataGridViewMatrixT);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.textBoxDet);
            this.Controls.Add(this.textBoxHigh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMatrixT);
            this.Controls.Add(this.labelMatrix);
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
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.Label labelMatrixT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHigh;
        private System.Windows.Forms.TextBox textBoxDet;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.DataGridView dataGridViewMatrixT;
    }
}

