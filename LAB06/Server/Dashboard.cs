
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks.Dataflow;

namespace Server
{
    public partial class Dashboard : Form
    {
        TCPServer server = new TCPServer();

        public Dashboard()
        {
            InitializeComponent();

            txtIP.Text = GetLocalWiFiIP();
            txtPort.Text = 36363.ToString();

            server.Start(3636);

        }

        private void btnSendInfo_Click(object sender, EventArgs e)
        {
            string content = txtContent.Text.Trim();
            if (string.IsNullOrEmpty(content))
                return;

            string packet = $"NOTIFICATION|{content}";

            server.Broadcast(packet);
        }

        private string GetLocalWiFiIP()
        {
            string[] blacklist = { "virtual", "vmware", "hyper", "npcap", "loopback", "miniport" };

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                string name = ni.Name.ToLower();
                if (blacklist.Any(x => name.Contains(x)))
                    continue;

                if (ni.OperationalStatus == OperationalStatus.Up &&
                    (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet))
                {
                    foreach (var ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork &&
                            !ip.Address.ToString().StartsWith("169.254"))
                        {
                            return ip.Address.ToString();
                        }
                    }
                }
            }
            return "127.0.0.1";
        }
    }
}
