﻿namespace SMServer.Packets
{
    [Serializable]
    internal class Character : IPacket
    {
        public const byte PacketId = 9;

        //typedef struct {
        //    byte data[16];
        //}uuid;

        //typedef struct {
        //    char magic[2];
        //    byte Hair; // A3 = leftmost hair, A7 = rightmost hair
        //    byte name_len;
        //    char name[name_len]; // TODO: Check how name affects packet
        //    char magic_char[4]; // Check if magic is 00 00 00 02
        //    byte is_male;
        //    byte num_uuids;
        //    uuid uuids[num_uuids];
        //    BigEndian();
        //    uint32 skin_id; // 0-4
        //    LittleEndian();
        //    char magic2[11];
        //}
        //SMPacket9 < optimize = false >;

        // Constructor
        public Character()
        {

        }

        public virtual void Serialize(BigEndianBinaryWriter writer)
        {
        }

        public virtual void Deserialize(BigEndianBinaryReader reader)
        {
            // packet has no additional data to deserialize
        }
    }
}
