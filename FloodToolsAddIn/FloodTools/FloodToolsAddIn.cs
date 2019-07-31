using Tricentis.TCCore.Persistency;
using Tricentis.TCCore.Persistency.AddInManager;

namespace Tricentis.TCAddIns.FloodTools
{
    public class FloodToolsAddIn : TCAddIn
    {
        public override string UniqueName => "Flood Element";
        public override string DisplayedName => "Flood Element";

        public static readonly TaskGroup AddInTaskGroup = new TaskGroup("Flood Element", true);

        public static readonly TaskCategory AddInTaskCategory = new TaskCategory("Flood Element");

    }
}
