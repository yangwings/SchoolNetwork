using System.IO;
using System.IO.Pipes;

namespace SchoolNetwork.API
{
    internal class Communication
    {
        public static void Send(string message)
        {
            using (NamedPipeClientStream clientStream = new NamedPipeClientStream(".", @"SchoolNetWork.args", PipeDirection.Out))
            {
                clientStream.Connect();
                using (StreamWriter writer = new StreamWriter(clientStream))
                {
                    writer.Write(message);
                }
            }
        }
        public static void Receive(out string message)
        {
            using (NamedPipeServerStream serverStream = new NamedPipeServerStream(@"SchoolNetWork.args", PipeDirection.In))
            {
                serverStream.WaitForConnection();
                using (StreamReader reader = new StreamReader(serverStream))
                {
                    message=reader.ReadToEnd();
                }
            }
        }
    }
}
