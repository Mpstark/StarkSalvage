using BattleTech.Save;
using Harmony;

// ReSharper disable InconsistentNaming

namespace SalvageOperations.Patches
{
    // maybe not needed TODO check it out
    [HarmonyPatch(typeof(GameInstanceSave), "PostDeserialization")]
    public class GameInstanceSave_PostDeserialization_Patch
    {
        public static void Postfix()
        {
            Main.BuiltMechNames.Clear();
            Main.TriggeredVariant = null;
        }
    }
}
