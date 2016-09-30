namespace WindowsFormsApplication4
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
            this.components = new System.ComponentModel.Container();
            this.serialPortRS232 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSerial = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.richTextBoxReceiveData = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSendData = new System.Windows.Forms.RichTextBox();
            this.buttonSendData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPortRS232
            // 
            this.serialPortRS232.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortRS232_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Port";
            // 
            // comboBoxSerial
            // 
            this.comboBoxSerial.FormattingEnabled = true;
            this.comboBoxSerial.Location = new System.Drawing.Point(79, 19);
            this.comboBoxSerial.Name = "comboBoxSerial";
            this.comboBoxSerial.Size = new System.Drawing.Size(68, 21);
            this.comboBoxSerial.TabIndex = 1;
            this.comboBoxSerial.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(187, 20);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(104, 29);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(315, 20);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(86, 32);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // richTextBoxReceiveData
            // 
            this.richTextBoxReceiveData.Location = new System.Drawing.Point(36, 81);
            this.richTextBoxReceiveData.Name = "richTextBoxReceiveData";
            this.richTextBoxReceiveData.Size = new System.Drawing.Size(210, 71);
            this.richTextBoxReceiveData.TabIndex = 4;
            this.richTextBoxReceiveData.Text = "";
            this.richTextBoxReceiveData.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBoxSendData
            // 
            this.richTextBoxSendData.Location = new System.Drawing.Point(36, 178);
            this.richTextBoxSendData.Name = "richTextBoxSendData";
            this.richTextBoxSendData.Size = new System.Drawing.Size(210, 71);
            this.richTextBoxSendData.TabIndex = 5;
            this.richTextBoxSendData.Text = "";
            // 
            // buttonSendData
            // 
            this.buttonSendData.Location = new System.Drawing.Point(295, 132);
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.Size = new System.Drawing.Size(105, 73);
            this.buttonSendData.TabIndex = 6;
            this.buttonSendData.Text = "Send";
            this.buttonSendData.UseVisualStyleBackColor = true;
            this.buttonSendData.Click += new System.EventHandler(this.buttonSendData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 261);
            this.Controls.Add(this.buttonSendData);
            this.Controls.Add(this.richTextBoxSendData);
            this.Controls.Add(this.richTextBoxReceiveData);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxSerial);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortRS232;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSerial;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.RichTextBox richTextBoxReceiveData;
        private System.Windows.Forms.RichTextBox richTextBoxSendData;
        private System.Windows.Forms.Button buttonSendData;
    }
}

