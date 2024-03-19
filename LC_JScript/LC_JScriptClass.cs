

using BepInEx;
using BepInEx.Logging;
using HarmonyLib;


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LC_JScript
{

    [BepInPlugin(modGUID, modName, modVersion)]
    public class LC_JScriptClass : BaseUnityPlugin
    {
        // Mod Details
        private const string modGUID = "UnknownMod";
        private const string modName = "UnknownMod";
        private const string modVersion = "1.0.0.0";
        private readonly Harmony harmony = new Harmony(modGUID);
        public static ManualLogSource mls;
        private static LC_JScriptClass Instance;

        private string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        void Awake()
        {
            Instance = this;
            mls = BepInEx.Logging.Logger.CreateLogSource("UnknownMod");
            mls.LogInfo("(UnknownMod): Patching");
            harmony.PatchAll(typeof(LC_JScriptClass));
            
            mls.LogInfo("(UnknownModJS):");

            mls.LogInfo("Loaded! " + assemblyFolder);
        }

    }
    
}
