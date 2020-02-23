using System;
// System 네임스페이스 : 자주 사용되는 값과 참조 데이터 형식, 이벤트와 이벤트 처리기, 인터페이스, 특성, 예외 처리 등을 정의하는 기본적인 클래스 및 기본 클래스를 포함합니다.
using System.Diagnostics;
// System.Diagnostics 네임스페이스 : 시스템 프로세스, 이벤트 로그 및 성능 카운터와 상호 작용할 수 있는 클래스를 제공합니다.
using System.Net;
// System.Net 네임스페이스 : 현재 네트워크에서 사용되는 여러 프로토콜에 대한 단순한 프로그래밍 인터페이스를 제공합니다.
using System.Net.Sockets;
// System.Net.Sockets 네임스페이스 : 네트워크에 대한 액세스를 엄격하게 제어해야 하는 개발자에게 Windows Socket(Winsock) 인터페이스의 관리되는 구현을 제공합니다.
using System.Text;
// System.Text 네임스페이스 : ASCII 및 유니코드 문자 인코딩을 나타내는 클래스, 문자와 바이트 블록 간을 변환하기 위한 추상 기본 클래스,
//                            String의 중간 인스턴스를 만들지 않고 String 개체를 조정하고 서식을 지정하는 도우미 클래스가 포함되어 있습니다.
using static System.Console;
// System.Console 클래스 : 콘솔 애플리케이션에 대한 표준 입력, 출력 및 오류 스트림을 나타냅니다.

namespace EchoClient
{
    class MainApp
    {
        static void Main(string[] args)
        {
            if (args.Length < 4)
            {
                WriteLine($"사용법 : {Process.GetCurrentProcess().ProcessName} <Bind IP> <Bind Port> <Server IP> <Message>");

                return;
            }

            string bindIp = args[0];
            int bindPort = Convert.ToInt32(args[1]);
            string serverIp = args[2];
            const int serverPort = 5425;
            string message = args[3];

            try
            {
                IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(bindIp), bindPort);
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

                WriteLine($"클라이언트: {clientAddress.ToString()}, 서버:{serverAddress.ToString()}");

                TcpClient client = new TcpClient(clientAddress);

                client.Connect(serverAddress);

                byte[] data = System.Text.Encoding.Default.GetBytes(message);

                NetworkStream stream = client.GetStream();

                stream.Write(data, 0, data.Length);

                WriteLine($"송신: {message}");

                data = new byte[256];

                string responseData = null;
                int bytes = stream.Read(data, 0, data.Length);

                responseData = Encoding.Default.GetString(data, 0, bytes);

                WriteLine($"수신: {responseData}");

                stream.Close();
                client.Close();
            }
            catch (SocketException e)
            {
                WriteLine(e);
            }

            WriteLine("클라이언트를 종료합니다.");
        }
    }
}
