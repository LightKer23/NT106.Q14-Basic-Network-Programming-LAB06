using System.Configuration;
using System.Net;
using System.Net.Mail;
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
                    var parts = msg.Split('|');
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

        private void sendEmail_Click(object sender, EventArgs e)
        {
            SendOtpEmail(emailBox.Text);
        }
        private static readonly Dictionary<string, (string otp, DateTime exp, bool verified)> _otp = new();


        private static void SendOtpEmail(string toEmail)
        {
            string host = "smtp.gmail.com";
            int port = 587;
            string fromEmail = "bahao171206@gmail.com";
            string password = "edohyrgqooqunrfc";
            var mail = new MailMessage
            {
                From = new MailAddress(fromEmail),
                Subject = "em k biet lay api",
                Body = $@"
Xin chào,

HUHU

Nếu bạn không yêu cầu, hãy bỏ qua email này.
",
                IsBodyHtml = false
            };

            mail.To.Add(toEmail);

            using var smtp = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(fromEmail, password),
                EnableSsl = true
            };

            smtp.Send(mail);
        }

        private static bool VerifyOtp(string email, string input)
        {
            if (!_otp.TryGetValue(email, out var s))
                return false;

            if (s.exp < DateTime.UtcNow)
                return false;

            if (s.otp != input)
                return false;

            _otp[email] = (s.otp, s.exp, true);
            return true;
        }


    }
}