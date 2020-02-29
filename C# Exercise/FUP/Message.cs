namespace FUP
{
    public class CONSTANTS
    {
        public const uint REQ_FILE_SEND = 0X01; // 파일 전송 요청
        public const uint REP_FILE_SEND = 0x02; // 파일 전송 요청에 대한 응답
        public const uint FILE_SEND_DATA = 0x03; // 파일 전송 데이터
        public const uint FILE_SEND_RES = 0x04; // 파일 수신 결과
        // System.UInt32 구조체 : 32비트 부호 없는 정수를 나타냅니다.

        public const byte NOT_FRAGMENTED = 0X00; // 메시지 분할 여부
        public const byte FRAGMENTED = 0X01;
        // System.Byte 구조체 : 부호 없는 8비트 정수를 나타냅니다.

        public const byte NOT_LASTMSG = 0X00; // 분할된 메시지가 마지막인지 여부
        public const byte LASTMSG = 0X01;

        public const byte ACCEPTED = 0X01; // 파일 전송 승인 여부
        public const byte DENIED = 0X00;

        public const byte FAIL = 0X00; // 파일 전송 성공 여부
        public const byte SUCCESS = 0X01;
    }

    public interface ISerializable
    {
        byte[] GetBytes();
        int GetSize();
    }

    public class Message : ISerializable
    {
        public Header Header { get; set; }
        public ISerializable Body { get; set; }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];

            Header.GetBytes().CopyTo(bytes, 0);
            Body.GetBytes().CopyTo(bytes, Header.GetSize());
            // System.Array.CopyTo 메서드 : 현재 1차원 배열의 모든 요소를 지정된 1차원 배열에 복사합니다.

            return bytes;
        }

        public int GetSize()
        {
            return Header.GetSize() + Body.GetSize();
            // Header.GetSize() = int 16;
        }
    }
}
