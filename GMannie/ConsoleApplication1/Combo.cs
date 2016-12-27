using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using static ConsoleApplication1.Program;
using static ConsoleApplication1.Menus;

namespace ConsoleApplication1
{
    internal class Combo
    {
        public static void ComboExecute()
        {
            var target = TargetSelector.GetTarget(Spells.Q.Range, DamageType.Magical);
            if (target == null || target.IsInvulnerable) return;
        }
    }
}
