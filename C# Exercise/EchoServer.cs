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

namespace EchoServer
{
    class MainApp
    {
        static void Main(string[] args)
        // System.String 클래스 : 텍스트를 UTF-16 코드 단위의 시퀀스로 나타냅니다.
        {
            if (args.Length < 1)
            // System.Array.Length 속성 : 모든 차원의 Array에서 요소의 총수를 가져옵니다.
            // System.Int32 구조체 : 부호 있는 32비트 정수를 나타냅니다.
            {
                WriteLine($"사용법 : {Process.GetCurrentProcess().ProcessName} <Bind IP>");
                // System.Console.WriteLine 메서드 : 뒤에 현재 줄 종결자가 오는, 지정한 데이터를 표준 출력 스트림에 씁니다.
                // System.Diagnostics.Process 클래스 : 로컬 및 원격 프로세스에 대한 액세스를 제공하고 로컬 시스템 프로세스를 시작하고 중지할 수 있습니다.
                // System.Diagnostics.Process.GetCurrentProcess 메서드 : 새 Process 구성 요소를 가져온 후 현재 활성화되어 있는 프로세스에 연결합니다.
                // System.Diagnostics.Process.ProcessName 속성 : 프로세스의 이름을 가져옵니다.

                return;
            }

            string bindIp = args[0];
            const int bindPort = 5425;

            TcpListener server = null;
            // System.Net.Sockets.TcpListener 클래스 : TCP 네트워크 클라이언트에서 연결을 수신합니다.

            try
            {
                IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(bindIp), bindPort);
                // System.Net.IPEndPoint 클래스 : 네트워크 엔드포인트를 IP 주소와 포트 번호로 나타냅니다.
                // System.Net.IPEndPoint 생성자 : IPEndPoint 클래스의 새 인스턴스를 초기화합니다.
                    // 오버로드 IPEndPoint(IPAddress, Int32) : 지정된 주소와 포트 번호를 사용하여 IPEndPoint 클래스의 새 인스턴스를 초기화합니다.
                // System.Net.IPAddress.Parse 메서드
                    // 오버로드 Parse(String) : IP 주소 문자열을 IPAddress 인스턴스로 변환합니다.

                server = new TcpListener(localAddress);
                // System.Net.Sockets.TcpListener 생성자 : TcpListener 클래스의 새 인스턴스를 초기화합니다.
                    // 오버로드 TcpListener(IPEndPoint) : 지정된 로컬 엔드포인트를 사용하여 TcpListener 클래스의 새 인스턴스를 초기화합니다.
                server.Start();
                // System.Net.Sockets.TcpListener.Start 메서드 : 들어오는 연결 요청의 수신을 시작합니다.
                    // 오버로드 Start() : 들어오는 연결 요청의 수신을 시작합니다.

                WriteLine("메아리 서버 시작... ");

                while (true)
                // System.Boolean 구조체 : 부울(true 또는 false) 값을 나타냅니다.
                {
                    TcpClient client = server.AcceptTcpClient();
                    // System.Net.Sockets.TcpClient 클래스 : TCP 네트워크 서비스에 대한 클라이언트 연결을 제공합니다.
                    // System.Net.Sockets.TcpListener.AcceptTcpClient 메서드 : 보류 중인 연결 요청을 받아들입니다.

                    WriteLine($"클라이언트 접속 : {((IPEndPoint)client.Client.RemoteEndPoint).ToString()} ");
                    // System.Net.Sockets.TcpClient.Client 속성 : 내부 Socket을 가져오거나 설정합니다.
                    // System.Net.Sockets.Socket.RemoteEndPoint 속성 : 원격 엔드포인트를 가져옵니다.
                    // System.Net.IPEndPoint.ToString 메서드 : 지정된 엔드포인트의 IP 주소와 포트 번호를 반환합니다.

                    NetworkStream stream = client.GetStream();
                    // System.Net.Sockets.NetworkStream 클래스 : 네트워크 액세스를 위한 데이터의 기본 스트림을 제공합니다.
                    // System.Net.Sockets.TcpClient.GetStream 메서드 : 데이터를 보내고 받는 데 사용되는 NetworkStream을 반환합니다.

                    int length;
                    string data = null;
                    byte[] bytes = new byte[256];
                    // System.Byte 구조체 : 부호 없는 8비트 정수를 나타냅니다.

                    while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
                    // System.Net.Sockets.NetworkStream.Read 메서드
                        // 오버로드 Read(Byte[], Int32, Int32) : NetworkStream에서 데이터를 읽고 바이트 배열에 저장합니다.
                    {
                        data = Encoding.Default.GetString(bytes, 0, length);
                        // System.Text.Encoding 클래스 : 문자 인코딩을 나타냅니다.
                        // System.Text.Encoding.Default 속성 : 이 .NET 구현을 위한 기본 인코딩을 가져옵니다.
                        // System.Text.Encoding.GetString 메서드 : 파생 클래스에서 재정의되면 바이트 시퀀스를 문자열로 디코딩합니다.
                            // 오버로드 GetString(Byte[], Int32, Int32) : 파생 클래스에서 재정의되면 지정한 바이트 배열의 바이트 시퀀스를 문자열로 디코딩합니다.

                        WriteLine(String.Format($"수신: {data}"));
                        // System.String.Format 메서드 : 지정된 형식에 따라 개체의 값을 문자열로 변환하여 다른 문자열에 삽입 합니다.
                            // 오버로드 Format(String, Object[]) : 지정된 문자열의 형식 항목을 지정된 배열에 있는 해당 개체의 문자열 표현으로 바꿉니다.

                        byte[] msg = Encoding.Default.GetBytes(data);
                        // System.Text.Encoding.GetBytes 메서드 : 파생 클래스에서 재정의되면 문자 집합을 바이트 시퀀스로 인코딩합니다.
                            // 오버로드 GetBytes(String) : 파생 클래스에서 재정의되면 지정한 문자열의 모든 문자를 바이트 시퀀스로 인코딩합니다.

                        stream.Write(msg, 0, msg.Length);
                        // System.Net.Sockets.NetworkStream.Read 메서드
                            // 오버로드 Read(Byte[], Int32, Int32) : NetworkStream에서 데이터를 읽고 바이트 배열에 저장합니다.

                        WriteLine(String.Format($"송신: {data}"));
                    }

                    stream.Close();
                    // System.IO.Stream.Close 메서드 : 현재 스트림을 닫고 현재 스트림과 관련된 소켓과 파일 핸들 등의 리소스를 모두 해제합니다.
                    //                                 이 메서드를 호출하는 대신 스트림이 올바르게 삭제되었는지 확인합니다.
                    client.Close();
                    // System.Net.Sockets.TcpClient.Close 메서드 : 이 TcpClient 인스턴스를 삭제하고 내부 TCP 연결을 닫도록 요청합니다.
                }
            }
            catch (SocketException e)
            // System.Net.Sockets.SocketException 클래스 : 소켓 오류가 발생할 때 발생되는 예외입니다.
            {
                WriteLine(e);
            }
            finally
            {
                server.Stop();
                // System.Net.Sockets.TcpListener.Stop 메서드 : 수신기를 닫습니다.
            }

            WriteLine("서버를 종료합니다.");
        }
    }
}
