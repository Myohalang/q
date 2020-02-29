using System;
using System.IO;

namespace FUP
{
    public class MessageUtil
    {
        public static void Send(Stream writer, Message msg)
        {
            writer.Write(msg.GetBytes(), 0, msg.GetSize());
        }
        // System.IO.Stream 클래스 : 바이트 시퀀스에 대한 일반 뷰를 제공합니다. 이 클래스는 추상 클래스입니다.
        /*System.IO.Stream.Write 메서드
        오버로드
            Write(Byte[], Int32, Int32) 파생 클래스를 재정의될 때 현재 스트림에 바이트의 시퀀스를 쓰고 쓰여진 바이트 수만큼 이 스트림 내에서 앞으로 이동합니다.
        매개 변수
            buffer Byte[] 바이트 배열입니다. 이 메서드는 count의 buffer 바이트를 현재 스트림으로 복사합니다.
            offset Int32 현재 스트림으로 바이트를 복사하기 시작할 buffer의 바이트 오프셋(0부터 시작)입니다.
            count Int32 현재 스트림에 쓸 바이트 수입니다.*/

        public static Message Receive(Stream reader)
        {
            int totalRecv = 0;
            int sizeToRead = 16;
            byte[] hBuffer = new byte[sizeToRead];

            while (sizeToRead > 0)
            {
                byte[] buffer = new byte[sizeToRead];
                int recv = reader.Read(buffer, 0, sizeToRead);
                if (recv == 0)
                {
                    return null;
                }
                buffer.CopyTo(hBuffer, totalRecv);
                totalRecv += recv;
                sizeToRead -= recv;
            }
            /*System.IO.Stream.Read 메서드
            오버로드
                Read(Byte[], Int32, Int32) 파생 클래스에서 재정의되면 현재 스트림에서 바이트의 시퀀스를 읽고, 읽은 바이트 수만큼 스트림 내에서 앞으로 이동합니다.
            매개 변수
                buffer Byte[] 바이트 배열입니다. 이 메서드는 지정된 바이트 배열의 값이 offset과 (offset + count - 1) 사이에서 현재 원본으로부터 읽어온 바이트로 교체된 상태로 반환됩니다.
                offset Int32 현재 스트림에서 읽은 데이터를 저장하기 시작하는 buffer의 바이트 오프셋(0부터 시작)입니다.
                count Int32 현재 스트림에서 읽을 최대 바이트 수입니다.*/

            Header header = new Header(hBuffer);

            totalRecv = 0;
            byte[] bBuffer = new byte[header.BODYLEN];
            sizeToRead = ((int)header.BODYLEN);

            while (sizeToRead > 0)
            {
                byte[] buffer = new byte[sizeToRead];
                int recv = reader.Read(buffer, 0, sizeToRead);
                if (recv == 0)
                {
                    return null;
                }
                buffer.CopyTo(bBuffer, totalRecv);
                totalRecv += recv;
                sizeToRead -= recv;
            }

            ISerializable body;
            switch (header.MSGTYPE)
            {
                case CONSTANTS.REQ_FILE_SEND:
                    body = new BodyRequest(bBuffer);
                    break;
                case CONSTANTS.REP_FILE_SEND:
                    body = new BodyResponse(bBuffer);
                    break;
                case CONSTANTS.FILE_SEND_DATA:
                    body = new BodyData(bBuffer);
                    break;
                case CONSTANTS.FILE_SEND_RES:
                    body = new BodyResult(bBuffer);
                    break;
                default:
                    throw new Exception(String.Format($"Unknown MSGTYPE : {header.MSGTYPE}"));
            }

            return new Message() { Header = header, Body = body };
        }
    }
}
