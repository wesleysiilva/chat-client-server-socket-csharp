using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chat {
  public partial class frmInitialize : Form {
    public frmInitialize() {
      InitializeComponent();
    }

    private void frmInitialize_Load(object sender, EventArgs e) {
      this.btnServer.Focus();
    }

    private void btnClient_Click(object sender, EventArgs e) {
      CallChat(Enums.EnumTpChat.enClient);
    }
    private void btnServer_Click(object sender, EventArgs e) {
      CallChat(Enums.EnumTpChat.enServer);
    }

    private void CallChat(Chat.Enums.EnumTpChat tpChat) {
      frmChat chat = new frmChat();
      chat.TpChat = tpChat;
      this.Hide();
      chat.Show();
    }
  }
}
