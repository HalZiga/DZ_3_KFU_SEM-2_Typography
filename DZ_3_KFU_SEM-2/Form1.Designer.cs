namespace DZ_3_KFU_SEM_2
{
    partial class FormTypography
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxForWrite = new System.Windows.Forms.RichTextBox();
            this.richTextBoxForRead = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTypography = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxForWrite, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxForRead, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // richTextBoxForWrite
            // 
            this.richTextBoxForWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxForWrite.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxForWrite.Name = "richTextBoxForWrite";
            this.richTextBoxForWrite.Size = new System.Drawing.Size(394, 444);
            this.richTextBoxForWrite.TabIndex = 0;
            this.richTextBoxForWrite.Text = "";
            // 
            // richTextBoxForRead
            // 
            this.richTextBoxForRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxForRead.Location = new System.Drawing.Point(403, 3);
            this.richTextBoxForRead.Name = "richTextBoxForRead";
            this.richTextBoxForRead.Size = new System.Drawing.Size(394, 444);
            this.richTextBoxForRead.TabIndex = 1;
            this.richTextBoxForRead.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.buttonTypography, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 408);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 42);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonTypography
            // 
            this.buttonTypography.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(221)))));
            this.buttonTypography.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTypography.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTypography.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTypography.Location = new System.Drawing.Point(323, 3);
            this.buttonTypography.Name = "buttonTypography";
            this.buttonTypography.Size = new System.Drawing.Size(154, 36);
            this.buttonTypography.TabIndex = 0;
            this.buttonTypography.Text = "Типо графирую";
            this.buttonTypography.UseVisualStyleBackColor = false;
            this.buttonTypography.Click += new System.EventHandler(this.buttonTypography_Click);
            // 
            // FormTypography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormTypography";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonTypography;
        private System.Windows.Forms.RichTextBox richTextBoxForWrite;
        private System.Windows.Forms.RichTextBox richTextBoxForRead;
    }
}

