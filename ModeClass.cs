using System.Collections.Generic;

namespace GrandiaStatEditor
{
    //Link with EffectTypeList()
    public class ModeClass
    {
        public class Mode0
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<Mode0> Mode0List()
        {
            var itemList = new List<Mode0>()
            {
                new Mode0() { Text = "Heal", Value = 0},
                new Mode0() { Text = "Restore", Value = 1},
                new Mode0() { Text = "Restore&HP_Heal", Value = 2},
                new Mode0() { Text = "Restore SP", Value = 3},
            };

            return itemList;
        }

        public class Mode1
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<Mode1> Mode1List()
        {
            var itemList = new List<Mode1>()
            {
                new Mode1() { Text = "Error", Value = 0},
                new Mode1() { Text = "Error", Value = 1},
            };

            return itemList;
        }

        public class Mode2
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<Mode2> Mode2List()
        {
            var itemList = new List<Mode2>()
            {
                new Mode2() { Text = "Error", Value = 0},
            };

            return itemList;
        }

        public class Mode3
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<Mode3> Mode3List()
        {
            var itemList = new List<Mode3>()
            {
                new Mode3() { Text = "Normal", Value = 0},
                new Mode3() { Text = "Magic", Value = 1},
                new Mode3() { Text = "Normal&Magic", Value = 2},
                new Mode3() { Text = "Paralyse", Value = 4 },
            };

            return itemList;
        }

        public class Mode4
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<Mode4> Mode4List()
        {
            var itemList = new List<Mode4>()
            {
                new Mode4() { Text = "Dead_Prob", Value = 0},
            };

            return itemList;
        }

        public class Mode5
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<Mode5> Mode5List()
        {
            var itemList = new List<Mode5>()
            {
                new Mode5() { Text = "Confuse", Value = 1},
                new Mode5() { Text = "Sleep", Value = 2},
                new Mode5() { Text = "Paralyse", Value = 3},
                new Mode5() { Text = "Poison", Value = 4},
                new Mode5() { Text = "Disease", Value = 5},
                new Mode5() { Text = "Anti_special", Value = 6},
                new Mode5() { Text = "Anti_magic", Value = 7},
                new Mode5() { Text = "Random1", Value = 8},
                new Mode5() { Text = "Random2", Value = 9},
                new Mode5() { Text = "Random3", Value = 10},
                new Mode5() { Text = "Random4", Value = 11},
                new Mode5() { Text = "Mag&Spe Lim", Value = 12},
            };

            return itemList;
        }

        public class Mode6
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<Mode6> Mode6List()
        {
            var itemList = new List<Mode6>()
            {
                new Mode6() { Text = "Confuse", Value = 1},
                new Mode6() { Text = "Sleep", Value = 2},
                new Mode6() { Text = "Paralyse", Value = 3},
                new Mode6() { Text = "Poison", Value = 4},
                new Mode6() { Text = "Disease", Value = 5},
                new Mode6() { Text = "Anti_Special", Value = 6},
                new Mode6() { Text = "Anti_Magic", Value = 7},
                new Mode6() { Text = "All_Status", Value = 8},
            };

            return itemList;
        }

        public class Mode7
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<Mode7> Mode7List()
        {
            var itemList = new List<Mode7>()
            {
                new Mode7() { Text = "Attack", Value = 0},
                new Mode7() { Text = "Defense", Value = 1},
                new Mode7() { Text = "Wit", Value = 2},
                new Mode7() { Text = "Agi", Value = 3},
                new Mode7() { Text = "Max_Up", Value = 4},
                new Mode7() { Text = "All Power", Value = 5},
                new Mode7() { Text = "All Reset", Value = 6},

            };

            return itemList;
        }

        public class Mode8
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<Mode8> Mode8List()
        {
            var itemList = new List<Mode8>()
            {
                new Mode8() { Text = "HP", Value = 0},
                new Mode8() { Text = "MP", Value = 1},
            };

            return itemList;
        }

        public class Mode9
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<Mode9> Mode9List()
        {
            var itemList = new List<Mode9>()
            {
                new Mode9() { Text = "IP Wait", Value = 0},
                new Mode9() { Text = "10 Tries To Steal", Value = 2},
                new Mode9() { Text = "Vacume PC/MC", Value = 5},
                new Mode9() { Text = "Temp Def", Value = 6},
                new Mode9() { Text = "Warps Self", Value = 7},
                new Mode9() { Text = "Block All Atk", Value = 8},
            };

            return itemList;
        }

        public class Mode10
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<Mode10> Mode10List()
        {
            var itemList = new List<Mode10>()
            {
                new Mode10() { Text = "Call Monster", Value = 0},
            };

            return itemList;
        }
    }
}
