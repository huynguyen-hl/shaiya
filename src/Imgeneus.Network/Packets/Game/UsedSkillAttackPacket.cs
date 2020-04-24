﻿using Imgeneus.Network.Data;

namespace Imgeneus.Network.Packets.Game
{
    public struct UsedSkillAttackPacket : IDeserializedPacket
    {
        public byte Number { get; }

        public int TargetId { get; }

        public UsedSkillAttackPacket(IPacketStream packet)
        {
            Number = packet.Read<byte>();
            TargetId = packet.Read<int>();
        }
    }
}
