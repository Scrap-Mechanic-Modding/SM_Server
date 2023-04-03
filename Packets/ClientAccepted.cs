﻿using System.IO;

namespace SMServer.Packets
{
    internal class ClientAccepted : IPacket
    {
        public static readonly byte Id = 5;

        // Constructor
        public ClientAccepted()
        {
        }

        public override byte[] Serialize()
        {
            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream))
            {
                writer.Write(Id);
                return stream.ToArray();
            }
        }

        protected override void Deserialize(BinaryReader reader)
        {
            // ClientAccepted packet has no additional data to deserialize
        }
    }
}
