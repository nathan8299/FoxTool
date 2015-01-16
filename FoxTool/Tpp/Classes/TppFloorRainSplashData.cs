using System.Collections.Generic;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class TppFloorRainSplashData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr VfxFile { get; set; }
        public Dictionary<string, FoxString> MaterialSoundList { get; set; }
    }
}