﻿using Imgeneus.Network.Data;

namespace Imgeneus.Network.Packets.Game
{
    public struct UsedNonTargetSkillPacket : IDeserializedPacket
    {
        public byte Number { get; }

        public int TargetId { get; }

        public UsedNonTargetSkillPacket(IPacketStream packet)
        {
            Number = packet.Read<byte>();
            TargetId = packet.Read<int>();
        }
    }
}
