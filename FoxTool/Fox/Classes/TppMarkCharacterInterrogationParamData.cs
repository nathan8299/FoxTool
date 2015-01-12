using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppMarkCharacterInterrogationParamData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityLink TargetCharacters { get; set; }
        public FoxString TargetCharacterIds { get; set; }
        public FoxUInt8 Radius { get; set; }
        public FoxInt32 GoalType { get; set; }
    }
}