namespace Chat
{
  partial class frmChat
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
      this.txtChat = new System.Windows.Forms.TextBox();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
      this.btnSendMessage = new System.Windows.Forms.Button();
      this.btnConnect = new System.Windows.Forms.Button();
      this.txtMessage = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // txtChat
      // 
      this.txtChat.Location = new System.Drawing.Point(12, 12);
      this.txtChat.Multiline = true;
      this.txtChat.Name = "txtChat";
      this.txtChat.Size = new System.Drawing.Size(480, 172);
      this.txtChat.TabIndex = 1;
      this.txtChat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChat_KeyPress);
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      // 
      // backgroundWorker2
      // 
      this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
      // 
      // btnSendMessage
      // 
      this.btnSendMessage.Location = new System.Drawing.Point(417, 243);
      this.btnSendMessage.Name = "btnSendMessage";
      this.btnSendMessage.Size = new System.Drawing.Size(75, 23);
      this.btnSendMessage.TabIndex = 2;
      this.btnSendMessage.Text = "Enviar";
      this.btnSendMessage.UseVisualStyleBackColor = true;
      this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(336, 243);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(75, 23);
      this.btnConnect.TabIndex = 3;
      this.btnConnect.Text = "Iniciar";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
      // 
      // txtMessage
      // 
      this.txtMessage.Location = new System.Drawing.Point(12, 190);
      this.txtMessage.Multiline = true;
      this.txtMessage.Name = "txtMessage";
      this.txtMessage.Size = new System.Drawing.Size(480, 47);
      this.txtMessage.TabIndex = 4;
      this.txtMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessage_KeyPress);
      // 
      // frmChat
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(497, 274);
      this.Controls.Add(this.txtMessage);
      this.Controls.Add(this.btnConnect);
      this.Controls.Add(this.btnSendMessage);
      this.Controls.Add(this.txtChat);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "frmChat";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Chat com ";
      this.Load += new System.EventHandler(this.frmChat_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        internal System.Windows.Forms.TextBox txtChat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnSendMessage;
    private System.Windows.Forms.Button btnConnect;
    internal System.Windows.Forms.TextBox txtMessage;
  }
}