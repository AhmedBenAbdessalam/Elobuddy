using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;

namespace ConsoleApplication1
{
    internal class Spells
    {
        public static Spell.Targeted Q;
        public static Spell.Skillshot W;
        public static Spell.Active E;
        public static Spell.Skillshot R;

        public static void InitializeSpells()
        {
            Q = new Spell.Targeted(SpellSlot.Q ,625);
            W = new Spell.Skillshot(SpellSlot.W, 600, SkillShotType.Cone);
            E = new Spell.Active(SpellSlot.E);
            R = new Spell.Skillshot(SpellSlot.R, 600, SkillShotType.Circular);
        }
    }
}
