using System.Collections.Generic;
using FoxTool.Fox.Types.Structs;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class SoundAreaGroup
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxUInt32 Priority { get; set; }
        public FoxEntityPtr Parameter { get; set; }
        public FoxEntityLink Members { get; set; }
        public List<FoxEntityLink> Edges { get; set; }
    }
}