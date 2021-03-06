﻿using ProtoBuf;
using VRage.ObjectBuilders;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_Trigger : MyObjectBuilder_Base
    {
        [ProtoMember]
        public bool IsTrue;
        [ProtoMember]
        public string Message;
    }
}
