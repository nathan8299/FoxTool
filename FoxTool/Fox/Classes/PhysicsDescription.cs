using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class PhysicsDescription
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityLink Depends { get; set; }
        public FoxString PartName { get; set; }
        public FoxString BuildType { get; set; }
        public FoxFilePtr PhysicsFile { get; set; }
    }
}