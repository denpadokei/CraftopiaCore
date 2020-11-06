using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftopiaCore
{
    [BepInPlugin("com.github.denpadokei.CraftopiaCore", "CraftpiaCore", "0.0.0.1")]
    public class Plugin : BaseUnityPlugin
    {
        public static Plugin Instance { get; private set; }

        /// <summary>
        /// 最初に読み込まれます。
        /// </summary>
        void Awake()
        {
            Instance = this;
            DontDestroyOnLoad(this);

            UnityEngine.Debug.Log("Hello world!");
        }
    }
}
