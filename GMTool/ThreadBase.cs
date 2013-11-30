using System;
using System.Text;
using System.Threading;

namespace GMTool
{
    public abstract class IRunnable
    {
        public abstract bool Initize();

        public abstract bool start();

        public abstract bool stop();

        public abstract bool Destroy();
    }

    public class ThreadBase : Thread
    {
        public IRunnable m_Runnable;

    }
}
