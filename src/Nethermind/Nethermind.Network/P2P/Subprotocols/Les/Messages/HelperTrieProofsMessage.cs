//  Copyright (c) 2021 Demerzel Solutions Limited
//  This file is part of the Nethermind library.
// 
//  The Nethermind library is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  The Nethermind library is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Lesser General Public License for more details.
// 
//  You should have received a copy of the GNU Lesser General Public License
//  along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.

using Nethermind.Network.P2P.Messages;

namespace Nethermind.Network.P2P.Subprotocols.Les.Messages
{
    public class HelperTrieProofsMessage : P2PMessage
    {
        public override int PacketType { get; } = LesMessageCode.HelperTrieProofs;
        public override string Protocol { get; } = P2P.Protocol.Les;
        public long RequestId;
        public int BufferValue;

        public byte[][] ProofNodes;
        public byte[][] AuxiliaryData;

        public HelperTrieProofsMessage()
        {
        }

        public HelperTrieProofsMessage(byte[][] proofNodes, byte[][] auxiliaryData, long requestId, int bufferValue)
        {
            ProofNodes = proofNodes;
            AuxiliaryData = auxiliaryData;
            RequestId = requestId;
            BufferValue = bufferValue;
        }
    }
}
