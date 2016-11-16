namespace InterfaceSystemController
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.deviceName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.ReadDevice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deviceName
            // 
            this.deviceName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deviceName.Location = new System.Drawing.Point(170, 58);
            this.deviceName.Name = "deviceName";
            this.deviceName.Size = new System.Drawing.Size(204, 20);
            this.deviceName.TabIndex = 0;
            this.deviceName.Text = "name";
            this.deviceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deviceName.TextChanged += new System.EventHandler(this.nameXML_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create Device";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Device Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(62, 105);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 198);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // nameSearch
            // 
            this.nameSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nameSearch.Location = new System.Drawing.Point(170, 309);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(204, 20);
            this.nameSearch.TabIndex = 6;
            this.nameSearch.Text = "name";
            this.nameSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameSearch.TextChanged += new System.EventHandler(this.nameSearch_TextChanged);
            // 
            // ReadDevice
            // 
            this.ReadDevice.Location = new System.Drawing.Point(380, 186);
            this.ReadDevice.Name = "ReadDevice";
            this.ReadDevice.Size = new System.Drawing.Size(91, 39);
            this.ReadDevice.TabIndex = 7;
            this.ReadDevice.Text = "Read Device";
            this.ReadDevice.UseVisualStyleBackColor = true;
            this.ReadDevice.Click += new System.EventHandler(this.ReadDevice_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Device to Search";
            // 
            // Action
            // 
            this.Action.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Action.Location = new System.Drawing.Point(170, 347);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(204, 20);
            this.Action.TabIndex = 9;
            this.Action.Text = "action";
            this.Action.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 388);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReadDevice);
            this.Controls.Add(this.nameSearch);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deviceName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deviceName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.Button ReadDevice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Action;
    }
}

