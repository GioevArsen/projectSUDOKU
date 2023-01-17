namespace projectSUDOKU
{
    partial class FormEnterTypeSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnterTypeSelect));
            this.buttonKEYS = new System.Windows.Forms.Button();
            this.buttonNUMPAD = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonMOUSECLICK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKEYS
            // 
            this.buttonKEYS.BackColor = System.Drawing.Color.White;
            this.buttonKEYS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKEYS.Location = new System.Drawing.Point(12, 142);
            this.buttonKEYS.Name = "buttonKEYS";
            this.buttonKEYS.Size = new System.Drawing.Size(190, 50);
            this.buttonKEYS.TabIndex = 0;
            this.buttonKEYS.Text = "Клавиши 1-9";
            this.buttonKEYS.UseVisualStyleBackColor = false;
            this.buttonKEYS.Click += new System.EventHandler(this.buttonKEYS_Click);
            // 
            // buttonNUMPAD
            // 
            this.buttonNUMPAD.BackColor = System.Drawing.Color.White;
            this.buttonNUMPAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNUMPAD.Location = new System.Drawing.Point(544, 142);
            this.buttonNUMPAD.Name = "buttonNUMPAD";
            this.buttonNUMPAD.Size = new System.Drawing.Size(190, 50);
            this.buttonNUMPAD.TabIndex = 1;
            this.buttonNUMPAD.Text = "Клавиши NUMPAD";
            this.buttonNUMPAD.UseVisualStyleBackColor = false;
            this.buttonNUMPAD.Click += new System.EventHandler(this.buttonNUMPAD_Click);
            // 
            // labelText
            // 
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(99, 26);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(537, 103);
            this.labelText.TabIndex = 3;
            this.labelText.Text = "Добро пожаловать в Судоку! Выберите как вы хотите вводить цифры:";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMOUSECLICK
            // 
            this.buttonMOUSECLICK.BackColor = System.Drawing.Color.White;
            this.buttonMOUSECLICK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMOUSECLICK.Location = new System.Drawing.Point(275, 142);
            this.buttonMOUSECLICK.Name = "buttonMOUSECLICK";
            this.buttonMOUSECLICK.Size = new System.Drawing.Size(190, 50);
            this.buttonMOUSECLICK.TabIndex = 4;
            this.buttonMOUSECLICK.Text = "Щелчок мыши";
            this.buttonMOUSECLICK.UseVisualStyleBackColor = false;
            this.buttonMOUSECLICK.Click += new System.EventHandler(this.buttonMOUSECLICK_Click_1);
            // 
            // FormEnterTypeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(746, 254);
            this.ControlBox = false;
            this.Controls.Add(this.buttonMOUSECLICK);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonNUMPAD);
            this.Controls.Add(this.buttonKEYS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEnterTypeSelect";
            this.Text = "Выберите способ ввода";
            this.Load += new System.EventHandler(this.FormEnterTypeSelect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKEYS;
        private System.Windows.Forms.Button buttonNUMPAD;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonMOUSECLICK;
    }
}