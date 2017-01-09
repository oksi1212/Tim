using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    class Packet
    {
        public byte[] Body { get; set; }
        private int bodyLength;
        private int BodyLength
        {
            get
            { 
                return this.bodyLength = bodyLength;
             }
            set
            {
                    if (value > 26000)
                        this.bodyLength = value;
            }
        }

        public byte[] Head { get; set; }
        private static int headLength;
        private static int HeadLength
        {
            get{
             return headLength = 32; 
            }
        }
           
        public int Sourse { get; set; }//откуда
        public int Destination { get; set; } //куда
        public int Time { get; set; }

        public Packet GetPacket()
        {
            Random random = new Random();
            Packet packet = new Packet();
            packet.Head = new byte[HeadLength];
            random.NextBytes(packet.Head);
            packet.Body = new byte[BodyLength];
            random.NextBytes(packet.Body);
            return packet;
        }
    }
}
