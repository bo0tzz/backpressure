using BepInEx;
using BerryLoaderNS;

namespace Backpressure
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("BerryLoader")]
    class Plugin : BaseUnityPlugin
    {
        public static BepInEx.Logging.ManualLogSource L;

        private void Awake()
        {
            L = Logger;
            L.LogInfo("hello from Backpressure.Plugin.Awake");
        }
    }
}