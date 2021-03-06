﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using Gibbed.Helpers;

namespace Gibbed.Borderlands.FileFormats.Save
{
    public class Echo
    {
        public string Name;
        public UInt32 Unknown1;
        public UInt32 Unknown2;

        public void Deserialize(SaveStream input)
        {
            this.Name = input.ReadString();
            this.Unknown1 = input.ReadValueU32();
            this.Unknown2 = input.ReadValueU32();
        }

        public void Serialize(SaveStream output)
        {
            output.WriteString(this.Name);
            output.WriteValueU32(this.Unknown1);
            output.WriteValueU32(this.Unknown2);
        }
    }
}
