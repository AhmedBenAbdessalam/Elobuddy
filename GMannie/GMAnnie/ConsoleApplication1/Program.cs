using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu.Values;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += OnLoadingComplete;
        }

        public static void OnLoadingComplete(EventArgs args)
        {
            if (Player.Instance.Hero != Champion.Annie) return;
            Chat.Print("Welcome to grandmaster");
            Game.OnTick += OnTick;
            Menus.CreateMenu();
            Spells.InitializeSpells();
        }

        private static void OnTick(EventArgs args)
        {
            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Combo)) ComboExecute();
        }

        private static void ComboExecute()
        {
            throw new NotImplementedException();
        }
    }
}
