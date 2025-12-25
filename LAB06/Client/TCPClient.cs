using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;


namespace Client
{
    internal class TCPClient
    {
        private TcpClient _client;
        private NetworkStream _stream;
        private Thread _recvThread;

        public event Action<string> OnStatus;

        public bool Connect(string ip, int port)
        {
            try
            {
                _client = new TcpClient();
                _client.Connect("127.0.0.1", port);
                _stream = _client.GetStream();

                StartReceiving();
            }
            catch (SocketException)
            {
                MessageBox.Show($"Cannot connect to server.", "Connection error");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection error: {ex.Message}");
                return false;
            }
            return true;
        }

        private void StartReceiving()
        {
            if (_recvThread != null) return;

            _recvThread = new Thread(ReceiveLoop);
            _recvThread.IsBackground = true;
            _recvThread.Start();
        }

        private void ReceiveLoop()
        {
            try
            {
                while (_client != null && _client.Connected && _stream != null)
                {
                    byte[] lenBuf = new byte[4];
                    int readLen = ReadExact(_stream, lenBuf, 0, 4);
                    if (readLen == 0) break;

                    int dataLen = BitConverter.ToInt32(lenBuf, 0);
                    if (dataLen <= 0) continue;

                    byte[] dataBuf = new byte[dataLen];
                    int got = ReadExact(_stream, dataBuf, 0, dataLen);
                    if (got == 0) break;

                    string msg = Encoding.UTF8.GetString(dataBuf, 0, got);
                    OnStatus?.Invoke(msg); 
                }
            }
            catch (Exception ex)
            {
                OnStatus?.Invoke("[CLIENT] Receive error: " + ex.Message);
            }
        }

        private static int ReadExact(NetworkStream ns, byte[] buffer, int offset, int count)
        {
            int total = 0;
            while (total < count)
            {
                int n = ns.Read(buffer, offset + total, count - total);
                if (n <= 0) return 0;
                total += n;
            }
            return total;
        }

        public void Send(string message)
        {
            try
            {
                if (_client == null || !_client.Connected || _stream == null)
                {
                    MessageBox.Show("Not connected to server. Cannot send data.", "Connection error");
                    return;
                }

                byte[] data = Encoding.UTF8.GetBytes(message);
                byte[] lengthPrefix = BitConverter.GetBytes(data.Length);

                _stream.Write(lengthPrefix, 0, lengthPrefix.Length);
                _stream.Write(data, 0, data.Length);
                _stream.Flush();
            }
            catch
            {
                MessageBox.Show($"Cannot connect to server.", "Connection error");
            }
        }

        public void Disconnect()
        {
            try
            {
                if (_stream != null && _client != null && _client.Connected)
                {
                    Send("--_DISCONNECT_--");
                }

                _stream?.Close();
                _client?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
