using System.Net.WebSockets;

namespace Client
{
    public partial class TradingTerminal : Form
    {
        private TCPClient _tcp = new TCPClient();

        public TradingTerminal()
        {
            InitializeComponent();

            _tcp.Connect("127.0.0.1", 3636);

            _tcp.OnStatus += msg =>
            {
                if (IsHandleCreated)
                { 
                    var parts= msg.Split('|');
                    string cmd = parts[1].Trim();
                    BeginInvoke(new Action(() =>
                    {
                        systemMessage.Items.Add(cmd);
                        systemMessage.TopIndex = systemMessage.Items.Count - 1;
                    }));
                }
            };


        }

        private void ConnectSomewhere()
        {
            _tcp.Connect("127.0.0.1", 3636);
        }
    }
}
