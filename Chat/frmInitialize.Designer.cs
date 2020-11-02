namespace Chat
{
  partial class frmInitialize
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.btnClient = new System.Windows.Forms.Button();
      this.btnServer = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(39, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(104, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "INICIALIZAR COMO";
      // 
      // btnClient
      // 
      this.btnClient.Location = new System.Drawing.Point(12, 36);
      this.btnClient.Name = "btnClient";
      this.btnClient.Size = new System.Drawing.Size(75, 23);
      this.btnClient.TabIndex = 1;
      this.btnClient.Text = "CLIENTE";
      this.btnClient.UseVisualStyleBackColor = true;
      this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
      // 
      // btnServer
      // 
      this.btnServer.Location = new System.Drawing.Point(93, 36);
      this.btnServer.Name = "btnServer";
      this.btnServer.Size = new System.Drawing.Size(75, 23);
      this.btnServer.TabIndex = 2;
      this.btnServer.Text = "SERVIDOR";
      this.btnServer.UseVisualStyleBackColor = true;
      this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
      // 
      // frmInitialize
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(179, 62);
      this.Controls.Add(this.btnServer);
      this.Controls.Add(this.btnClient);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "frmInitialize";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Inicializar";
      this.Load += new System.EventHandler(this.frmInitialize_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnServer;
    }
}

