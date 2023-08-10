using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UDP_Asynchronous_Chat;

namespace UDP_Chat_Client_Form
{
    public partial class Form1 : Form
    {
        UDP_Asynchronous_Chat.UDPAsynchronousChatClient mChatClient; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendBroadcast_Click(object sender, EventArgs e)
        {
            //buradaki soket nesnesini başlatalım.
            if(mChatClient == null)
            {
                //local port ve remote port'un integer olması gerek.Bunları integer'a çevirelim.
                int.TryParse(tbLocalPort.Text, out var nLocalPort);
                int.TryParse(tbRemotePort.Text, out var nRemotePort);

                //Elde ettiğimiz integer portları Constructora atalım.
                mChatClient =
                    new UDP_Asynchronous_Chat.
                    UDPAsynchronousChatClient
                    (nLocalPort, nRemotePort);

                mChatClient.RaisePrintStringEvent += chatClient_PrintString;
                mChatClient.ImageReceived += chatClient_ImageReceived;


            }
            mChatClient.SendBroadcast(tbBroadcastText.Text);
        }

        private void chatClient_ImageReceived(object sender, ImageReceivedEventArgs e)
        {
            try
            {
                using (MemoryStream imageStream = new MemoryStream())
                {
                    imageStream.Write(e.fileData, 0, e.fileData.Length);
                    var bm = new Bitmap(imageStream);

                    Action<Bitmap> updateImage = UpdateImageBox;

                    pbImageReceived.Invoke(updateImage, new Bitmap[] { bm });

                    Action<string> print = PrintToTextBox;
                    tbConsole.Invoke(print, new string[] { e.message });

                }
            }
            catch (Exception excp)
            {

                MessageBox.Show(excp.Message);
            }
        }

        private void UpdateImageBox(Bitmap obj)
        {
            pbImageReceived.Image = obj;
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            mChatClient.SendMessageToKnownServer(tbMessage.Text);
        }

        private void chatClient_PrintString(object sender, PrintStringEventArgs e)
        {
            Action<string> print = PrintToTextBox;

            tbConsole.Invoke(print, new string[] { e.MessageToPrint });
            //tbConsole.Text += $"{Environment.NewLine}{DateTime.Now} - {e.MessageToPrint}";
        }

        private void PrintToTextBox(string stringToPrint)
        {
            tbConsole.Text += $"{Environment.NewLine}{DateTime.Now} - {stringToPrint}";
        }

        private void btnSendImage_Click(object sender, EventArgs e)
        {
            if(!File.Exists(tbFileSelectedPath.Text))
            {
                MessageBox.Show("File does not exist.");
                return;
            }

            Image imgFromFile = Image.FromFile(tbFileSelectedPath.Text);

            using (MemoryStream imageByteStream = new MemoryStream())
            {
                imgFromFile.Save(imageByteStream, ImageFormat.Jpeg);

                mChatClient.SendImage(
                    fileName: Path.GetFileName(tbFileSelectedPath.Text),
                    fileBytes: imageByteStream.ToArray(),
                    Message: tbMessage.Text);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
