﻿using ProtoBuf;
using VRage.ObjectBuilders;
using VRage.Data;
using VRage;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_AreaMarkerDefinition : MyObjectBuilder_DefinitionBase
    {
        [ProtoMember]
        public SerializableVector3 ColorHSV = new SerializableVector3(0.0f, 0.0f, 0.0f);

        [ProtoMember]
        [ModdableContentFile("mwm")]
        public string Model = null;

        [ProtoMember]
        [ModdableContentFile("dds")]
		public string ColorMetalTexture = null;

		[ProtoMember(4)]
		[ModdableContentFile("dds")]
		public string AddMapsTexture = null;

        [ProtoMember(5)]
        public SerializableVector3 MarkerPosition = new SerializableVector3(0.0f, 0.0f, 0.0f);
    }
}