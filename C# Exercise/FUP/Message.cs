using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FUP
{
    public class CONSTANTS
    {
        public const uint REQ_FILE_SEND = 0X01;
        public const uint REP_FILE_SEND = 0x02;
        public const uint FILE_SEND_DATA = 0x03;
        public const uint FILE_SEND_RES = 0x04;

        public const byte NOT_FRAGMENTED = 0X00;
        public const byte FRAGMENTED = 0X01;

        public const byte NOT_LASTMSG = 0X00;
        public const byte LASTMSG = 0X01;

        public const byte ACCEPTED = 0X01;
        public const byte DENIED = 0X00;

        public const byte FAIL = 0X00;
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

        public byte [] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];

            Header.GetBytes().CopyTo(bytes, 0);
            Body.GetBytes().CopyTo(bytes, Header.GetSize());

            return bytes;
        }

        public int GetSize()
        {
            return Header.GetSize() + Body.GetSize();
        }
    }
}