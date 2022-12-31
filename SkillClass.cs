using System.Collections.Generic;

namespace GrandiaStatEditor
{
    public class SkillClass
    {
        public class Skill
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<Skill> SkillList()
        {
            var itemList = new List<Skill>()
            {
                new Skill() { Text = "NONE", Value = 0 },
                new Skill() { Text = "DEF-LOSS", Value = 1 },
                new Skill() { Text = "TREMOR", Value = 2 },
                new Skill() { Text = "GRAVITY", Value = 3 },
                new Skill() { Text = "QUAKE", Value = 4 },
                new Skill() { Text = "HEAL", Value = 5 },
                new Skill() { Text = "ALHEAL", Value = 6 },
                new Skill() { Text = "SNOOZE", Value = 7 },
                new Skill() { Text = "HEALER", Value = 8 },
                new Skill() { Text = "ALHEALER", Value = 9 },
                new Skill() { Text = "ALHEALER+", Value = 10 },
                new Skill() { Text = "RESSURECT", Value = 11 },
                new Skill() { Text = "BURN", Value = 12 },
                new Skill() { Text = "BURNFLAME", Value = 13 },
                new Skill() { Text = "BURNSTRYK", Value = 14 },
                new Skill() { Text = "BURNFLARE", Value = 15 },
                new Skill() { Text = "FIREBURNR", Value = 16 },
                new Skill() { Text = "HOWL", Value = 17 },
                new Skill() { Text = "RUNNER", Value = 18 },
                new Skill() { Text = "HOWLSLASH", Value = 19 },
                new Skill() { Text = "LACOSTA", Value = 20 },
                new Skill() { Text = "SHHHH", Value = 21 },
                new Skill() { Text = "HOWLNADO", Value = 22 },
                new Skill() { Text = "POIZN", Value = 23 },
                new Skill() { Text = "CURE", Value = 24 },
                new Skill() { Text = "STRAM", Value = 25 },
                new Skill() { Text = "CRAZE", Value = 26 },
                new Skill() { Text = "REFRESH", Value = 27 },
                new Skill() { Text = "SPEEDY", Value = 28 },
                new Skill() { Text = "HALVAH", Value = 29 },
                new Skill() { Text = "BOOM!", Value = 30 },
                new Skill() { Text = "WOW!", Value = 31 },
                new Skill() { Text = "METEOR STKR", Value = 32 },
                new Skill() { Text = "BOOM-POW!", Value = 33 },
                new Skill() { Text = "BA-BOOM!", Value = 34 },
                new Skill() { Text = "CRACKLE", Value = 35 },
                new Skill() { Text = "FREEZE!", Value = 36 },
                new Skill() { Text = "COLD", Value = 37 },
                new Skill() { Text = "FIORA", Value = 38 },
                new Skill() { Text = "CRACKLING", Value = 39 },
                new Skill() { Text = "ZAP!", Value = 40 },
                new Skill() { Text = "GADZAP", Value = 41 },
                new Skill() { Text = "ZAP ALL", Value = 42 },
                new Skill() { Text = "DRAGON ZAP", Value = 43 },
                new Skill() { Text = "MAGIC ART", Value = 44 },
                new Skill() { Text = "STR SYMPHONY", Value = 45 },
                new Skill() { Text = "ENCLOSE", Value = 46 },
                new Skill() { Text = "TIME GATE", Value = 47 },
                new Skill() { Text = "LIFE TREE", Value = 48 },
                new Skill() { Text = "WORLD END", Value = 49 },
                new Skill() { Text = "V-SLASH", Value = 50 },
                new Skill() { Text = "W-BREAK", Value = 51 },
                new Skill() { Text = "SHOCKWAVE", Value = 52 },
                new Skill() { Text = "MIDAIR CUT", Value = 53 },
                new Skill() { Text = "IMMORTALAURA", Value = 54 },
                new Skill() { Text = "ICE SLASH", Value = 55 },
                new Skill() { Text = "LOTUS CUT", Value = 56 },
                new Skill() { Text = "THOR CUT", Value = 57 },
                new Skill() { Text = "DRAGON CUT", Value = 58 },
                new Skill() { Text = "H&E CUT", Value = 59 },
                new Skill() { Text = "KNIFE HURL", Value = 60 },
                new Skill() { Text = "RANDOMHURL", Value = 61 },
                new Skill() { Text = "PARA WHIP", Value = 62 },
                new Skill() { Text = "FIRE WHIP", Value = 63 },
                new Skill() { Text = "ZAP! WHIP", Value = 64 },
                new Skill() { Text = "FIRE AWAY", Value = 65 },
                new Skill() { Text = "ROUNDWHACK", Value = 66 },
                new Skill() { Text = "PUFFY FIRE", Value = 67 },
                new Skill() { Text = "YAWN", Value = 68 },
                new Skill() { Text = "PUFFY KICK", Value = 69 },
                new Skill() { Text = "RAHRAHCHEER", Value = 70 },
                new Skill() { Text = "FIGHT CHEER", Value = 71 },
                new Skill() { Text = "ERUPT CUT", Value = 72 },
                new Skill() { Text = "FLY DRAG CUT", Value = 73 },
                new Skill() { Text = "DRAGON CUT", Value = 74 },
                new Skill() { Text = "MIST HIDE", Value = 75 },
                new Skill() { Text = "DOPPELGANG", Value = 76 },
                new Skill() { Text = "DEATHSWORD", Value = 77 },
                new Skill() { Text = "MISSILE", Value = 78 },
                new Skill() { Text = "FIREBALL", Value = 79 },
                new Skill() { Text = "SIDETHROW", Value = 80 },
                new Skill() { Text = "DISCUTTER", Value = 81 },
                new Skill() { Text = "DEMON BALL", Value = 82 },
                new Skill() { Text = "NEO D BALL", Value = 83 },
                new Skill() { Text = "SPLITTER", Value = 84 },
                new Skill() { Text = "HOME RUN", Value = 85 },
                new Skill() { Text = "RAGE", Value = 86 },
                new Skill() { Text = "MILDA KICK", Value = 87 },
                new Skill() { Text = "MILDA HIT", Value = 88 },
                new Skill() { Text = "MILDA HIT2", Value = 89 },
                new Skill() { Text = "MOGAY SHOT", Value = 90 },
                new Skill() { Text = "MOGAY BOMB", Value = 91 },
                new Skill() { Text = "MOGAY HYPO", Value = 92 },
                new Skill() { Text = "POWER UP", Value = 93 },
                new Skill() { Text = "PICKPOCKET", Value = 94 },
                new Skill() { Text = "REDSHOCK", Value = 95 },
                new Skill() { Text = "ENCHDANCE", Value = 96 },
                new Skill() { Text = "PROTECTION", Value = 97 },
                new Skill() { Text = "SANCTUARY", Value = 98 },
                new Skill() { Text = "DIGGIN", Value = 99 }

            };

            return itemList;
        }
    }
}
