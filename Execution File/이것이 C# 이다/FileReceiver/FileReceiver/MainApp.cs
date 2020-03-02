using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using FUP;
using static System.Console;
// System.Diagnostics 네임스페이스 : 시스템 프로세스, 이벤트 로그 및 성능 카운터와 상호 작용할 수 있는 클래스를 제공합니다.
// System.IO 네임스페이스 : 파일과 데이터 스트림에 읽고 쓸 수 있게 하는 형식과 기본 파일과 디렉터리 지원을 제공하는 형식이 포함됩니다.
// System.Net 네임스페이스 : 현재 네트워크에서 사용되는 여러 프로토콜에 대한 단순한 프로그래밍 인터페이스를 제공합니다.
// System.Net.Sockets 네임스페이스 : 네트워크에 대한 액세스를 엄격하게 제어해야 하는 개발자에게 Windows Socket(Winsock) 인터페이스의 관리되는 구현을 제공합니다.
/* System.Text 네임스페이스 : ASCII 및 유니코드 문자 인코딩을 나타내는 클래스, 문자와 바이트 블록 간을 변환하기 위한 추상 기본 클래스,
			                  String의 중간 인스턴스를 만들지 않고 String 개체를 조정하고 서식을 지정하는 도우미 클래스가 포함되어 있습니다. */
// System.Console 클래스 : 콘솔 애플리케이션에 대한 표준 입력, 출력 및 오류 스트림을 나타냅니다. 이 클래스는 상속할 수 없습니다.

namespace FileReceiver
{
    class MainApp
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                WriteLine($"사용법 : {Process.GetCurrentProcess().ProcessName} <Directory>");
                return;
            }
            // System.Array.Length 속성 : 모든 차원의 Array에서 요소의 총수를 가져옵니다.
            // System.Diagnostics.Process 클래스 : 로컬 및 원격 프로세스에 대한 액세스를 제공하고 로컬 시스템 프로세스를 시작하고 중지할 수 있습니다.
            // System.Diagnostics.Process.GetCurrentProcess 메서드 : 새 Process 구성 요소를 가져온 후 현재 활성화되어 있는 프로세스에 연결합니다.
            // System.Diagnostics.Process.ProcessName 속성 : 프로세스의 이름을 가져옵니다.

            uint msgId = 0;

            string dir = args[0];
            if (Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);
            }
            // System.IO.Directory 클래스 : 디렉터리와 하위 디렉터리에서 만들기, 이동 및 열거를 위한 정적 메서드를 노출합니다. 이 클래스는 상속할 수 없습니다.
            // System.IO.Directory.Exists(String) 메서드 : 지정된 경로가 디스크에 있는 기존 디렉터리를 참조하는지를 확인합니다.
            /* System.IO.Directory.CreateDirectory 메서드 : 지정된 경로에 모든 디렉터리를 만듭니다.
               오버로드
               CreateDirectory(String) 이미 존재하지 않는 한 지정된 경로에 모든 디렉터리와 하위 디렉터리를 만듭니다. */

            const int bindPort = 5425;
            TcpListener server = null;
            // System.Net.Sockets.TcpListener 클래스 : TCP 네트워크 클라이언트에서 연결을 수신합니다.
            try
            {
                IPEndPoint localAddress = new IPEndPoint(0, bindPort);
                // System.Net.IPEndPoint 클래스 : 네트워크 엔드포인트를 IP 주소와 포트 번호로 나타냅니다.
                /* System.Net.IPEndPoint 생성자 : IPEndPoint 클래스의 새 인스턴스를 초기화합니다.
                   오버로드
                   IPEndPoint(Int64, Int32) 지정된 주소와 포트 번호를 사용하여 IPEndPoint 클래스의 새 인스턴스를 초기화합니다.
                   매개 변수
                   address Int64 인터넷 호스트의 IP 주소입니다.
                   port Int32 address와 연결된 포트 번호이거나, 사용할 수 있는 포트를 지정할 경우 0입니다. port는 호스트 순서로 지정됩니다. */
                // IP주소를 0으로 입력하면 127.0.01뿐 아니라 OS에 할당되어 있는 어떤 주소로도 서버에 접속이 가능합니다.

                server = new TcpListener(localAddress);
                /* System.Net.Sockets.TcpListener 생성자 : TcpListener 클래스의 새 인스턴스를 초기화합니다.
			       오버로드
			       TcpListener(IPEndPoint) : 지정된 로컬 엔드포인트를 사용하여 TcpListener 클래스의 새 인스턴스를 초기화합니다.
			       매개 변수
			       localEP IPEndPoint : IPEndPoint수신기를 바인딩할 로컬 엔드포인트를 나타내는 Socket입니다. */
                server.Start();
                /* System.Net.Sockets.TcpListener.Start 메서드 : 들어오는 연결 요청의 수신을 시작합니다.
                   오버로드
                   Start() 들어오는 연결 요청의 수신을 시작합니다. */

                WriteLine("파일 업로드 서버 시작...");

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    // System.Net.Sockets.TcpClient 클래스 : TCP 네트워크 서비스에 대한 클라이언트 연결을 제공합니다.
                    /* System.Net.Sockets.TcpListener.AcceptSocket 메서드 : 보류 중인 연결 요청을 받아들입니다.
                       반환
                       Socket : 데이터를 보내고 받는 데 사용되는 Socket입니다.*/
                    WriteLine($"클라이언트 접속 : {((IPEndPoint)client.Client.RemoteEndPoint).ToString()}");
                    /* System.Net.Sockets.TcpClient.Client 속성 : 내부 Socket을 가져오거나 설정합니다.
                       속성 값
                       Socket : 내부 네트워크 Socket입니다. */
                    /* System.Net.Sockets.Socket.RemoteEndPoint 속성 : 원격 엔드포인트를 가져옵니다.
                       속성 값
                       EndPoint : EndPoint이 통신에 사용하는 Socket입니다. */

                    NetworkStream stream = client.GetStream();
                    // System.Net.Sockets.NetworkStream 클래스 : 네트워크 액세스를 위한 데이터의 기본 스트림을 제공합니다.
                    /* System.Net.Sockets.TcpClient.GetStream 메서드 : 데이터를 보내고 받는 데 사용되는 NetworkStream을 반환합니다.
                       반환
                       NetworkStream : 내부 NetworkStream입니다. */
                    Message reqMsg = MessageUtil.Receive(stream);

                    if (reqMsg.Header.MSGTYPE != CONSTANTS.REQ_FILE_SEND)
                    {
                        stream.Close();
                        client.Close();
                        continue;
                    }

                    BodyRequest reqBody = (BodyRequest)reqMsg.Body;

                    WriteLine("파일 업로드 요청이 왔습니다. 수락하시겠습니까? yes/no");
                    string answer = ReadLine();

                    Message rspMsg = new Message();
                    rspMsg.Body = new BodyResponse()
                    {
                        MSGID = reqMsg.Header.MSGID,
                        RESPONSE = CONSTANTS.ACCEPTED
                    };
                    rspMsg.Header = new Header()
                    {
                        MSGID = msgId++,
                        MSGTYPE = CONSTANTS.REP_FILE_SEND,
                        BODYLEN = (uint)rspMsg.Body.GetSize(),
                        FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
                        LASTMSG = CONSTANTS.LASTMSG,
                        SEQ = 0
                    };

                    if (answer != "yes")
                    {
                        rspMsg.Body = new BodyResponse()
                        {
                            MSGID = reqMsg.Header.MSGID,
                            RESPONSE = CONSTANTS.DENIED
                        };
                        MessageUtil.Send(stream, rspMsg);
                        stream.Close();
                        client.Close();

                        continue;
                    }
                    else
                    {
                        MessageUtil.Send(stream, rspMsg);
                    }

                    WriteLine("파일 전송을 시작합니다...");

                    long fileSize = reqBody.FILESIZE;
                    string fileName = Encoding.Default.GetString(reqBody.FILENAME);
                    FileStream file = new FileStream(dir + "\\" + fileName, FileMode.Create);

                    uint? dataMsgId = null;
                    ushort prevSeq = 0;
                    while ((reqMsg = MessageUtil.Receive(stream)) != null)
                    {
                        Write("#");
                        if (reqMsg.Header.MSGTYPE != CONSTANTS.FILE_SEND_DATA)
                        {
                            break;
                        }
                        if (dataMsgId == null)
                        {
                            dataMsgId = reqMsg.Header.MSGID;
                        }
                        else
                        {
                            if (dataMsgId != reqMsg.Header.MSGID)
                            {
                                break;
                            }
                        }
                        if (prevSeq++ != reqMsg.Header.SEQ)
                        {
                            WriteLine($"{prevSeq}, {reqMsg.Header.SEQ}");
                            break;
                        }

                        file.Write(reqMsg.Body.GetBytes(), 0, reqMsg.Body.GetSize());

                        if (reqMsg.Header.FRAGMENTED == CONSTANTS.NOT_FRAGMENTED)
                        {
                            break;
                        }
                        if (reqMsg.Header.LASTMSG == CONSTANTS.LASTMSG)
                        {
                            break;
                        }
                    }

                    long recvFileSize = file.Length;
                    file.Close();

                    WriteLine();
                    WriteLine($"수신 파일 크기 : {recvFileSize} bytes");

                    Message rstMsg = new Message();
                    rstMsg.Body = new BodyResult()
                    {
                        MSGID = reqMsg.Header.MSGID,
                        RESULT = CONSTANTS.SUCCESS
                    };
                    rstMsg.Header = new Header()
                    {
                        MSGID = msgId++,
                        MSGTYPE = CONSTANTS.FILE_SEND_RES,
                        BODYLEN = (uint)rstMsg.Body.GetSize(),
                        FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
                        LASTMSG = CONSTANTS.LASTMSG,
                        SEQ = 0
                    };

                    if (fileSize == recvFileSize)
                    {
                        MessageUtil.Send(stream, rstMsg);
                    }
                    else
                    {
                        rstMsg.Body = new BodyResult()
                        {
                            MSGID = reqMsg.Header.MSGID,
                            RESULT = CONSTANTS.FAIL
                        };

                        MessageUtil.Send(stream, rstMsg);
                    }
                    WriteLine("파일 전송을 마쳤습니다.");

                    stream.Close();
                    client.Close();
                    
                }
            }
            catch (SocketException e)
            {
                WriteLine(e);
            }
            finally
            {
                server.Stop();
            }
            
            WriteLine("서버를 종료합니다.");
        }
    }
}

