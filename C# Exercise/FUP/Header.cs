using System;

namespace FUP
{
    public class Header : ISerializable
    {
        public uint MSGID { get; set; } // 메시지 식별 번호
        public uint MSGTYPE { get; set; } // 메시지의 종류
        public uint BODYLEN { get; set; } // 메시지 본문의 길이
        public byte FRAGMENTED { get; set; } // 메시지의 분할 여부
        public byte LASTMSG { get; set; } // 분할된 메시지가 마지막인지 여부
        public ushort SEQ { get; set; } // 메시지의 파편 번호

        public Header() { } // 디폴트 생성자
        public Header(byte[] bytes) // 생성자
        {
            MSGID = BitConverter.ToUInt32(bytes, 0);
            MSGTYPE = BitConverter.ToUInt32(bytes, 4);
            BODYLEN = BitConverter.ToUInt32(bytes, 8);
            FRAGMENTED = bytes[12];
            LASTMSG = bytes[13];
            SEQ = BitConverter.ToUInt16(bytes, 14);
            // System.BitConverter 클래스 : 기본 데이터 형식을 바이트의 배열로, 바이트의 배열을 기본 데이터 형식으로 변환합니다.
            /* System.BitConverter.ToInt32 메서드
               오버로드 ToInt32(Byte[], Int32) : 바이트 배열의 지정된 된 위치에 4 바이트에서 변환 하는 32 비트 부호 있는 정수를 반환 합니다.
               매개 변수 value Byte[] : 바이트 배열입니다.
                         startIndex Int32 : value내의 시작 위치입니다.
               반환 Int32 : startIndex에서 시작하고 4바이트로 형성된 32비트 부호 있는 정수입니다.*/
        }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[16];

            byte[] temp = BitConverter.GetBytes(MSGID);
            Array.Copy(temp, 0, bytes, 0, temp.Length);

            temp = BitConverter.GetBytes(MSGTYPE);
            Array.Copy(temp, 0, bytes, 4, temp.Length);

            temp = BitConverter.GetBytes(BODYLEN);
            Array.Copy(temp, 0, bytes, 8, temp.Length);

            bytes[12] = FRAGMENTED;
            bytes[13] = LASTMSG;

            temp = BitConverter.GetBytes(SEQ);
            Array.Copy(temp, 0, bytes, 14, temp.Length);

            return bytes;
        }

        public int GetSize()
        {
            return 16;
        }
    }
}
