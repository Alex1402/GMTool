using System;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace GMTool
{
    public class NetThread : Thread
    {
        public int m_NetState;
        
        public Socket m_Socket;
        
        public IPAddress m_ServerIP;

        public int m_ServerPort;

        public NetThread(IPAddress ip, int port)
        {
            m_ServerIP = ip;
            m_ServerPort = port;
        }

        public static void ThreadTask()
        {
            
            while (true)
            {

            }
        }
    }
}
