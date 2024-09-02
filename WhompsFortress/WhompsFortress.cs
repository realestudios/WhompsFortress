using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Steamworks.Ugc;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using LethalLib;
using LethalLib.Modules;


namespace WhompsFortress
{

    [BepInPlugin(GUID, NAME, VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        const string GUID = "WhompsFortress";
        const string NAME = "WhompsFortress";
        const string VERSION = "1.1.0";

        public static Plugin instance;

        void Awake()
        {
            instance = this;

            string assetDir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "whompsfortressscrap");
            AssetBundle bundle = AssetBundle.LoadFromFile(assetDir);

            // Star scrap

            Item WFStarItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/WhompsFortress/Scrap/Star/WFStarItem.asset");
            LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(WFStarItem.spawnPrefab);
            LethalLib.Modules.Utilities.FixMixerGroups(WFStarItem.spawnPrefab);
            Items.RegisterScrap(WFStarItem, 20, Levels.LevelTypes.None);

            // Coin scrap

            Item WFCoinItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/WhompsFortress/Scrap/Coins/WFCoinItem.asset");
            LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(WFCoinItem.spawnPrefab);
            LethalLib.Modules.Utilities.FixMixerGroups(WFCoinItem.spawnPrefab);
            Items.RegisterScrap(WFCoinItem, 20, Levels.LevelTypes.None);

            // Red Coin Scrap

            Item WFRedCoinItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/WhompsFortress/Scrap/Coins/WFRedCoinItem.asset");
            LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(WFRedCoinItem.spawnPrefab);
            LethalLib.Modules.Utilities.FixMixerGroups(WFRedCoinItem.spawnPrefab);
            Items.RegisterScrap(WFRedCoinItem, 20, Levels.LevelTypes.None);

            // Blue Coin Scrap

            Item WFBlueCoinItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/WhompsFortress/Scrap/Coins/WFBlueCoinItem.asset");
            LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(WFBlueCoinItem.spawnPrefab);
            LethalLib.Modules.Utilities.FixMixerGroups(WFBlueCoinItem.spawnPrefab);
            Items.RegisterScrap(WFBlueCoinItem, 20, Levels.LevelTypes.None);

            // Koopa Shell Scrap

            Item WFShellItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/WhompsFortress/Scrap/Shell/WFShellItem.asset");
            LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(WFShellItem.spawnPrefab);
            LethalLib.Modules.Utilities.FixMixerGroups(WFShellItem.spawnPrefab);
            Items.RegisterScrap(WFShellItem, 20, Levels.LevelTypes.None);

            // ? Block Scrap

            Item WFQBlockItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/WhompsFortress/Scrap/Q_Block/WFQBlockItem.asset");
            LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(WFQBlockItem.spawnPrefab);
            LethalLib.Modules.Utilities.FixMixerGroups(WFQBlockItem.spawnPrefab);
            Items.RegisterScrap(WFQBlockItem, 20, Levels.LevelTypes.None);

            // Bob-Omb Scrap

            Item WFBobOmbItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/WhompsFortress/Scrap/bob-omb/WFBobOmbItem.asset");
            LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(WFBobOmbItem.spawnPrefab);
            LethalLib.Modules.Utilities.FixMixerGroups(WFBobOmbItem.spawnPrefab);
            Items.RegisterScrap(WFBobOmbItem, 20, Levels.LevelTypes.None);

            // Cap Scrap

            Item WFCapItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/WhompsFortress/Scrap/Cap/WFCapItem.asset");
            LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(WFCapItem.spawnPrefab);
            LethalLib.Modules.Utilities.FixMixerGroups(WFCapItem.spawnPrefab);
            Items.RegisterScrap(WFCapItem, 20, Levels.LevelTypes.None);

            // 1Up Scrap

            Item WFOneUpItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/WhompsFortress/Scrap/1Up/WFOneUpItem.asset");
            LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(WFOneUpItem.spawnPrefab);
            LethalLib.Modules.Utilities.FixMixerGroups(WFOneUpItem.spawnPrefab);
            Items.RegisterScrap(WFOneUpItem, 20, Levels.LevelTypes.None);

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), GUID);
            Logger.LogInfo("Loaded WhompsFortress Scrap");
        }
    }

    public class DropBlock : MonoBehaviour
    {
        [SerializeField] private Animator myAnimationController;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player")) ;
            myAnimationController.SetBool("DropBlock", true);

        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player")) ;
            myAnimationController.SetBool("DropBlock", false);

        }
    }

  

}
