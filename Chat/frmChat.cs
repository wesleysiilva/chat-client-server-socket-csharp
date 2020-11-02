﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat.Enums;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Chat {

  public partial class frmChat : Form {
    public EnumTpChat TpChat { get; set; }
    private TcpClient client;
    private string LocalIP;
    public StreamReader STR;
    public StreamWriter STW;
    public string recieve;
    public string TextToSend;

    public frmChat() {
      InitializeComponent();

      //Localize local IP
      IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

      foreach (IPAddress address in localIP) {
        if(address.AddressFamily == AddressFamily.InterNetwork) {
          LocalIP = address.ToString();
        }
      }
    }

    private void frmChat_Load(object sender, EventArgs e) {      
      //Interface components control
      this.btnConnect.Enabled = true;
      this.btnSendMessage.Enabled = false;
      this.txtChat.Enabled = false;
      this.txtMessage.Enabled = false;

      switch (this.TpChat) {
        case EnumTpChat.enServer:
          this.Text = "Chat com Cliente";
          this.btnConnect.Text = "Iniciar";
          break;

        case EnumTpChat.enClient:
          this.Text = "Chat com Servidor";
          this.btnConnect.Text = "Conectar";
          break;
      }
    }

    private void StartServer() {
      //Initialize Server
      TcpListener listener = new TcpListener(IPAddress.Any, 123);
      listener.Start();

      //Waits for cliente connection
      client = listener.AcceptTcpClient();      
      STR = new StreamReader(client.GetStream());
      STW = new StreamWriter(client.GetStream());
      STW.AutoFlush = true;
      backgroundWorker1.RunWorkerAsync();
      backgroundWorker2.WorkerSupportsCancellation = true;
    }

    private void ConnectToServer() {
      //Client connection to Server
      client = new TcpClient();
      IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(LocalIP),123);

      try {
        client.Connect(IpEnd);
        if (client.Connected) {
//          this.txtChat.AppendText("Connected to Server");
          //this.txtChat.AppendText(Environment.NewLine);
          STR = new StreamReader(client.GetStream());
          STW = new StreamWriter(client.GetStream());
          STW.AutoFlush = true;
          backgroundWorker1.RunWorkerAsync();
          backgroundWorker2.WorkerSupportsCancellation = true;
        }

      } catch (Exception e) {
        MessageBox.Show(e.Message.ToString());
      }
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
      while (client.Connected) {
        //Monitoring the receiveds messages
        try {
          recieve = STR.ReadLine();
          this.txtChat.Invoke(new MethodInvoker(delegate () {
            if (TpChat == EnumTpChat.enClient) {
              this.txtChat.AppendText("Server: " + recieve);
            } else {
              this.txtChat.AppendText("Client: " + recieve);
            }            
            this.txtChat.AppendText(Environment.NewLine);
          }));

          recieve = "";
        } catch (Exception a) {
          MessageBox.Show(a.Message.ToString());
        }
      }
    }

    private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e) {
      //Sends message to the pair
      if (client.Connected) {
        STW.WriteLine  (TextToSend);
        this.txtChat.Invoke(new MethodInvoker(delegate () {
          if (TpChat == EnumTpChat.enClient) {
            this.txtChat.AppendText("Client: " + TextToSend);
          } else {
            this.txtChat.AppendText("Server: " + TextToSend);
          }
          this.txtChat.AppendText(Environment.NewLine);
        }));
      } else {
        MessageBox.Show("Sending failed");
      }
      backgroundWorker2.CancelAsync();
    }

    private void btnSendMessage_Click(object sender, EventArgs e) {
      //Sends message just if exists some text to send
      if (this.txtMessage.Text.Trim() != "") {
        //Removes white spaces arround text
        TextToSend = this.txtMessage.Text.Trim();
        backgroundWorker2.RunWorkerAsync();
      }
      this.txtMessage.Text = "";
    }
    private void btnConnect_Click(object sender, EventArgs e) {
      this.txtChat.Enabled = true;
      this.txtMessage.Enabled = true;
      switch (this.TpChat) {
        case EnumTpChat.enServer:          
          this.txtChat.AppendText ( "Aguardando conexão com o cliente. Inicie uma nova instância do exe como cliente.");
          this.txtChat.AppendText(Environment.NewLine);
          this.StartServer();
          this.txtChat.AppendText ("Cliente conectado");
          this.txtChat.AppendText(Environment.NewLine);
          break;

        case EnumTpChat.enClient:
          this.Text = "Chat com Servidor";
          this.ConnectToServer();
          this.txtChat.AppendText("Conectado com o servidor");
          this.txtChat.AppendText(Environment.NewLine);
          break;
      }
      this.btnConnect.Enabled = false;
      this.btnSendMessage.Enabled = true;
    }

    private void txtChat_KeyPress(object sender, KeyPressEventArgs e) {
      //Blocks text enter in Chat Painel
      if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void txtMessage_KeyPress(object sender, KeyPressEventArgs e) {
      //Enter button sends message
      if (e.KeyChar == Convert.ToChar(Keys.Return)) {
        btnSendMessage_Click(sender, e);
        this.txtMessage.Text = this.txtMessage.Text.Replace("\n","");
        this.txtMessage.Text = this.txtMessage.Text.Replace("\r", "");
      }
    }
  }
}
