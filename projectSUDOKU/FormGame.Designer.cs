namespace projectSUDOKU
{
    partial class FormGame
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.dataGridViewLevel = new System.Windows.Forms.DataGridView();
            this.buttonENDTHEGAME = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLevel
            // 
            this.dataGridViewLevel.AllowUserToAddRows = false;
            this.dataGridViewLevel.AllowUserToDeleteRows = false;
            this.dataGridViewLevel.AllowUserToResizeColumns = false;
            this.dataGridViewLevel.AllowUserToResizeRows = false;
            this.dataGridViewLevel.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLevel.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLevel.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLevel.Location = new System.Drawing.Point(250, 100);
            this.dataGridViewLevel.Name = "dataGridViewLevel";
            this.dataGridViewLevel.ReadOnly = true;
            this.dataGridViewLevel.RowHeadersVisible = false;
            this.dataGridViewLevel.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewLevel.TabIndex = 0;
            this.dataGridViewLevel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewLevel_KeyDown);
            // 
            // buttonENDTHEGAME
            // 
            this.buttonENDTHEGAME.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonENDTHEGAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonENDTHEGAME.Location = new System.Drawing.Point(663, 470);
            this.buttonENDTHEGAME.Name = "buttonENDTHEGAME";
            this.buttonENDTHEGAME.Size = new System.Drawing.Size(182, 79);
            this.buttonENDTHEGAME.TabIndex = 1;
            this.buttonENDTHEGAME.Text = "Закончить игру";
            this.buttonENDTHEGAME.UseVisualStyleBackColor = false;
            this.buttonENDTHEGAME.Click += new System.EventHandler(this.buttonENDTHEGAME_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 561);
            this.Controls.Add(this.buttonENDTHEGAME);
            this.Controls.Add(this.dataGridViewLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.Text = "СУДОКУ";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLevel;
        private System.Windows.Forms.Button buttonENDTHEGAME;
    }
}

