using System.Collections.Generic;

namespace GrandiaReduxMaker
{
    public class ComboBoxList
    {
        public class ExternalType
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<ExternalType> ExternalTypeList()
        {
            var itemList = new List<ExternalType>()
            {
                new ExternalType() { Text = "None", Value = 0 },
                new ExternalType() { Text = "Sleep", Value = 2},
                new ExternalType() { Text = "Paralysis", Value = 3},
                new ExternalType() { Text = "Poison", Value = 4 },
                new ExternalType() { Text = "Anti Spe", Value = 6},
                new ExternalType() { Text = "Random", Value = 8 }
            };

            return itemList;
        }

        public class Elemental
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<Elemental> ElementalList()
        {
            var itemList = new List<Elemental>()
            {
                new Elemental() { Text = "None", Value = 0},
                new Elemental() { Text = "Fire", Value = 16 },
                new Elemental() { Text = "Water", Value = 32 },
                new Elemental() { Text = "Wind", Value = 64 },
                new Elemental() { Text = "Thunder", Value = 80 },
                new Elemental() { Text = "Ice", Value = 96 },
                new Elemental() { Text = "Earth", Value = 128 },
                new Elemental() { Text = "Explosion", Value = 144 },
                new Elemental() { Text = "Forest", Value = 160 }
            };

            return itemList;
        }

        public class EffectType
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<EffectType> EffectTypeList()
        {
            var itemList = new List<EffectType>()
            {
                new EffectType() { Text = "Heal", Value = 0},
                new EffectType() { Text = "Damage", Value = 3 },
                new EffectType() { Text = "Prob_Damage", Value = 4 },
                new EffectType() { Text = "Abnormal Status", Value = 5 },
                new EffectType() { Text = "Clear Status", Value = 6 },
                new EffectType() { Text = "Power Up/Down", Value = 7 },
                new EffectType() { Text = "Drain", Value = 8 },
                new EffectType() { Text = "Special", Value = 9 },
                new EffectType() { Text = "Monster Only Special", Value = 10 }
            };

            return itemList;
        }

        public class StopMode
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<StopMode> StopModeList()
        {
            var itemList = new List<StopMode>()
            {
                new StopMode() { Text = "Non Stop", Value = 0},
                new StopMode() { Text = "Motion", Value = 1},
            };

            return itemList;
        }

        public class Target
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }
        public static List<Target> TargetList()
        {
            var itemList = new List<Target>()
            {
                new Target() { Text = "NON / ME!", Value = 0},
                new Target() { Text = "PC / 1", Value = 17},
                new Target() { Text = "PC / AREA", Value = 18},
                new Target() { Text = "PC / ALL", Value = 19},
                new Target() { Text = "PC / ME", Value = 88},
                new Target() { Text = "PC / 1", Value = 89},
                new Target() { Text = "PC / AREA", Value = 90},
                new Target() { Text = "PC / ALL", Value = 91},
                new Target() { Text = "PC / (AREA)", Value = 94},
                new Target() { Text = "MC / ME!", Value = 104},
                new Target() { Text = "MC / ALL", Value = 107},
                new Target() { Text = "MC / ME!", Value = 123},
            };

            return itemList;
        }

        public class ExtType
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }
        public static List<ExtType> ExtTypeList()
        {
            var itemList = new List<ExtType>()
            {
                new ExtType() { Text = "Non", Value = 0},
                new ExtType() { Text = "Confuse", Value = 1},
                new ExtType() { Text = "Sleep", Value = 2},
                new ExtType() { Text = "Paralise", Value = 3},
                new ExtType() { Text = "Poison", Value = 4},
                new ExtType() { Text = "Disease", Value = 5},
                new ExtType() { Text = "Anti_Spe", Value = 6},
                new ExtType() { Text = "Anti_Mag", Value = 7},
                new ExtType() { Text = "Random1", Value = 8},
                new ExtType() { Text = "Random2", Value = 9},
                new ExtType() { Text = "Random3", Value = 10},
                new ExtType() { Text = "Random4", Value = 11},
                new ExtType() { Text = "Mag&Spe Lim", Value = 12},
                new ExtType() { Text = "IP_Wait", Value = 13},
                new ExtType() { Text = "Atk Down", Value = 14},
                new ExtType() { Text = "Def Down", Value = 15},
                new ExtType() { Text = "Wit Down", Value = 16},
                new ExtType() { Text = "Mov Down", Value = 17},
                new ExtType() { Text = "Max HP Down", Value = 18},
                new ExtType() { Text = "All Down", Value = 19},
                new ExtType() { Text = "All Reset", Value = 20},
            };

            return itemList;
        }


        public class EnemyID
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        public static List<EnemyID> EnemieIDList()
        {
            var itemList = new List<EnemyID>()
            {
                new EnemyID() { Value = 0, Text = "None" },
                new EnemyID() { Value = 1, Text = "Gaia Ape" },
                new EnemyID() { Value = 2, Text = "Gaia Horn" },
                new EnemyID() { Value = 3, Text = "Dragonoid" },
                new EnemyID() { Value = 4, Text = "Gaia Drago" },
                new EnemyID() { Value = 5, Text = "Dragon Knight" },
                new EnemyID() { Value = 6, Text = "Mountain Ape" },
                new EnemyID() { Value = 7, Text = "Yeti" },
                new EnemyID() { Value = 8, Text = "Black Beret" },
                new EnemyID() { Value = 9, Text = "Rock Man" },
                new EnemyID() { Value = 10, Text = "Magma Man" },
                new EnemyID() { Value = 11, Text = "Iron Giant" },
                new EnemyID() { Value = 12, Text = "Cactus Man" },
                new EnemyID() { Value = 13, Text = "Vanatos" },
                new EnemyID() { Value = 14, Text = "Gaia Man" },
                new EnemyID() { Value = 15, Text = "Medusa Dancer" },
                new EnemyID() { Value = 16, Text = "Lilith" },
                new EnemyID() { Value = 17, Text = "Naga Queen" },
                new EnemyID() { Value = 18, Text = "Hyena Man" },
                new EnemyID() { Value = 19, Text = "Wolfman" },
                new EnemyID() { Value = 20, Text = "Jackal" },
                new EnemyID() { Value = 21, Text = "Red Devil" },
                new EnemyID() { Value = 22, Text = "Blue Devil" },
                new EnemyID() { Value = 23, Text = "Nyalmot" },
                new EnemyID() { Value = 24, Text = "Pink Mage" },
                new EnemyID() { Value = 25, Text = "Shaman" },
                new EnemyID() { Value = 26, Text = "Layelah" },
                new EnemyID() { Value = 27, Text = "Pteranobone" },
                new EnemyID() { Value = 28, Text = "Bird Skull" },
                new EnemyID() { Value = 29, Text = "Skeleton" },
                new EnemyID() { Value = 30, Text = "Zombie" },
                new EnemyID() { Value = 31, Text = "Lich" },
                new EnemyID() { Value = 32, Text = "Gaia Zombie" },
                new EnemyID() { Value = 33, Text = "Warp Man" },
                new EnemyID() { Value = 34, Text = "Gaia Knight" },
                new EnemyID() { Value = 35, Text = "Spacetime Armor" },
                new EnemyID() { Value = 36, Text = "Ghostoid" },
                new EnemyID() { Value = 37, Text = "Vengeful Spirit" },
                new EnemyID() { Value = 38, Text = "Ghost" },
                new EnemyID() { Value = 39, Text = "Lost Soul" },
                new EnemyID() { Value = 40, Text = "Critter" },
                new EnemyID() { Value = 41, Text = "Will-O'-Wisp" },
                new EnemyID() { Value = 42, Text = "Hot Dog" },
                new EnemyID() { Value = 43, Text = "Fire Hound" },
                new EnemyID() { Value = 44, Text = "Cerberus" },
                new EnemyID() { Value = 45, Text = "Snow Boar" },
                new EnemyID() { Value = 46, Text = "King Horn" },
                new EnemyID() { Value = 47, Text = "Milda" },
                new EnemyID() { Value = 48, Text = "Glug Bird" },
                new EnemyID() { Value = 49, Text = "Thud Bird" },
                new EnemyID() { Value = 50, Text = "Flap Bird" },
                new EnemyID() { Value = 51, Text = "Sphytaros" },
                new EnemyID() { Value = 52, Text = "Sphynx" },
                new EnemyID() { Value = 53, Text = "Guardian" },
                new EnemyID() { Value = 54, Text = "Land Slug" },
                new EnemyID() { Value = 55, Text = "Huge Pupa" },
                new EnemyID() { Value = 56, Text = "Gaia Slug" },
                new EnemyID() { Value = 57, Text = "Gaia Devil" },
                new EnemyID() { Value = 58, Text = "Toad Demon" },
                new EnemyID() { Value = 59, Text = "Satan" },
                new EnemyID() { Value = 60, Text = "Baby Bat" },
                new EnemyID() { Value = 61, Text = "Vampire Bat" },
                new EnemyID() { Value = 62, Text = "Sonic Bat" },
                new EnemyID() { Value = 63, Text = "Magic Head" },
                new EnemyID() { Value = 64, Text = "Gaia Brain" },
                new EnemyID() { Value = 65, Text = "Brain Bat" },
                new EnemyID() { Value = 66, Text = "Clay Bird" },
                new EnemyID() { Value = 67, Text = "Rock Bird" },
                new EnemyID() { Value = 68, Text = "Emerald Bird" },
                new EnemyID() { Value = 69, Text = "Sweet Moth" },
                new EnemyID() { Value = 70, Text = "Dizzy Moth" },
                new EnemyID() { Value = 71, Text = "Giant Moth" },
                new EnemyID() { Value = 72, Text = "Plop Mold" },
                new EnemyID() { Value = 73, Text = "Mold Bird" },
                new EnemyID() { Value = 74, Text = "Gaia Mold" },
                new EnemyID() { Value = 75, Text = "Marna Bug" },
                new EnemyID() { Value = 76, Text = "Beetlebug" },
                new EnemyID() { Value = 77, Text = "Metal Beetle" },
                new EnemyID() { Value = 78, Text = "Zil Scorpion" },
                new EnemyID() { Value = 79, Text = "Scissorlock" },
                new EnemyID() { Value = 80, Text = "Gaia Demon" },
                new EnemyID() { Value = 81, Text = "Crimsona" },
                new EnemyID() { Value = 82, Text = "Lesser Crab" },
                new EnemyID() { Value = 83, Text = "Gaia Alien" },
                new EnemyID() { Value = 84, Text = "Spyder" },
                new EnemyID() { Value = 85, Text = "Black Widow" },
                new EnemyID() { Value = 86, Text = "Tarantula" },
                new EnemyID() { Value = 87, Text = "Ammonite" },
                new EnemyID() { Value = 88, Text = "Mad Snail" },
                new EnemyID() { Value = 89, Text = "Gaia Cyst" },
                new EnemyID() { Value = 90, Text = "Sea Jelly" },
                new EnemyID() { Value = 91, Text = "Mud Jelly" },
                new EnemyID() { Value = 93, Text = "Hermit Crab" },
                new EnemyID() { Value = 94, Text = "Scarab" },
                new EnemyID() { Value = 95, Text = "Gaia Cancer" },
                new EnemyID() { Value = 96, Text = "Sea Star" },
                new EnemyID() { Value = 97, Text = "Starfish" },
                new EnemyID() { Value = 98, Text = "Gaia Star" },
                new EnemyID() { Value = 99, Text = "Blue Kite" },
                new EnemyID() { Value = 100, Text = "Manta Ray" },
                new EnemyID() { Value = 101, Text = "Stingray" },
                new EnemyID() { Value = 102, Text = "Sand Diver" },
                new EnemyID() { Value = 103, Text = "Sand Man" },
                new EnemyID() { Value = 104, Text = "Gaia Scorpion" },
                new EnemyID() { Value = 105, Text = "Giant Centipede" },
                new EnemyID() { Value = 106, Text = "Inchworm" },
                new EnemyID() { Value = 107, Text = "Roadcrawler" },
                new EnemyID() { Value = 108, Text = "Spitting Cobra" },
                new EnemyID() { Value = 109, Text = "Pit Viper" },
                new EnemyID() { Value = 111, Text = "Sand Worm" },
                new EnemyID() { Value = 112, Text = "Sand Snake" },
                new EnemyID() { Value = 113, Text = "Gaia Snake" },
                new EnemyID() { Value = 114, Text = "Chameleon" },
                new EnemyID() { Value = 115, Text = "Alligator" },
                new EnemyID() { Value = 116, Text = "Salamadile" },
                new EnemyID() { Value = 117, Text = "Gill Newt" },
                new EnemyID() { Value = 118, Text = "Oopa-Loopa" },
                new EnemyID() { Value = 119, Text = "Gaia Fly" },
                new EnemyID() { Value = 120, Text = "Horned Toad" },
                new EnemyID() { Value = 121, Text = "Mad Frog" },
                new EnemyID() { Value = 122, Text = "Toad King" },
                new EnemyID() { Value = 123, Text = "Hippocamp" },
                new EnemyID() { Value = 124, Text = "Coelacanth" },
                new EnemyID() { Value = 125, Text = "Gaia Cactus" },
                new EnemyID() { Value = 126, Text = "Green Slime" },
                new EnemyID() { Value = 127, Text = "Purple Slime" },
                new EnemyID() { Value = 128, Text = "Red Slime" },
                new EnemyID() { Value = 129, Text = "Grim Haze" },
                new EnemyID() { Value = 130, Text = "Gas Cloud" },
                new EnemyID() { Value = 131, Text = "Mist Wraith" },
                new EnemyID() { Value = 132, Text = "Odd Bird" },
                new EnemyID() { Value = 133, Text = "Birdrake" },
                new EnemyID() { Value = 134, Text = "Dodo" },
                new EnemyID() { Value = 135, Text = "Slipple" },
                new EnemyID() { Value = 136, Text = "Gripple" },
                new EnemyID() { Value = 137, Text = "Stuttle" },
                new EnemyID() { Value = 138, Text = "Ent" },
                new EnemyID() { Value = 139, Text = "Mist Guard" },
                new EnemyID() { Value = 140, Text = "Killer Tree" },
                new EnemyID() { Value = 141, Text = "Private" },
                new EnemyID() { Value = 142, Text = "Sergeant" },
                new EnemyID() { Value = 143, Text = "Elite Officer" },
                new EnemyID() { Value = 144, Text = "Klepp Soldier" },
                new EnemyID() { Value = 145, Text = "Elite Klepp" },
                new EnemyID() { Value = 146, Text = "Klepp Knight" },
                new EnemyID() { Value = 147, Text = "Lizard Rider" },
                new EnemyID() { Value = 148, Text = "Mad Rider" },
                new EnemyID() { Value = 149, Text = "Klepp Rider" },
                new EnemyID() { Value = 150, Text = "Squid King" },
                new EnemyID() { Value = 151, Text = "Right Tentacle" },
                new EnemyID() { Value = 152, Text = "Left Tentacle" },
                new EnemyID() { Value = 153, Text = "Kraken" },
                new EnemyID() { Value = 154, Text = "Right Tentacle" },
                new EnemyID() { Value = 155, Text = "Left Tentacle" },
                new EnemyID() { Value = 156, Text = "Ganymede" },
                new EnemyID() { Value = 157, Text = "Ganymede" },
                new EnemyID() { Value = 159, Text = "Mad Turtle" },
                new EnemyID() { Value = 160, Text = "Mad Turtle" },
                new EnemyID() { Value = 161, Text = "Gaia Bird" },
                new EnemyID() { Value = 162, Text = "Gargoyle" },
                new EnemyID() { Value = 163, Text = "Gargoyle" },
                new EnemyID() { Value = 164, Text = "Madragon" },
                new EnemyID() { Value = 165, Text = "Madragon" },
                new EnemyID() { Value = 166, Text = "Skip" },
                new EnemyID() { Value = 167, Text = "Phantom Dragon" },
                new EnemyID() { Value = 168, Text = "Phantom Dragon" },
                new EnemyID() { Value = 170, Text = "Massacre Machine" },
                new EnemyID() { Value = 171, Text = "Eye" },
                new EnemyID() { Value = 172, Text = "Massacre Machine" },
                new EnemyID() { Value = 173, Text = "Eye" },
                new EnemyID() { Value = 174, Text = "Serpent" },
                new EnemyID() { Value = 175, Text = "Mean Head" },
                new EnemyID() { Value = 176, Text = "Hot Head" },
                new EnemyID() { Value = 177, Text = "Nice Head" },
                new EnemyID() { Value = 178, Text = "Bad Head" },
                new EnemyID() { Value = 179, Text = "Hydra" },
                new EnemyID() { Value = 180, Text = "Peril Head" },
                new EnemyID() { Value = 181, Text = "Hot Head" },
                new EnemyID() { Value = 182, Text = "Nice Head" },
                new EnemyID() { Value = 183, Text = "Awful Head" },
                new EnemyID() { Value = 184, Text = "Trent" },
                new EnemyID() { Value = 185, Text = "Arm" },
                new EnemyID() { Value = 186, Text = "Flower" },
                new EnemyID() { Value = 187, Text = "Gaia Trent" },
                new EnemyID() { Value = 188, Text = "Arm" },
                new EnemyID() { Value = 189, Text = "Flower" },
                new EnemyID() { Value = 190, Text = "Lord's Ghost" },
                new EnemyID() { Value = 191, Text = "Lord's Ghost" },
                new EnemyID() { Value = 192, Text = "Wand" },
                new EnemyID() { Value = 193, Text = "Mage King" },
                new EnemyID() { Value = 194, Text = "Mage King" },
                new EnemyID() { Value = 195, Text = "Wand" },
                new EnemyID() { Value = 196, Text = "Ruin Guard" },
                new EnemyID() { Value = 197, Text = "Ax" },
                new EnemyID() { Value = 198, Text = "Skip" },
                new EnemyID() { Value = 199, Text = "Boomerang" },
                new EnemyID() { Value = 200, Text = "Great Susano-o" },
                new EnemyID() { Value = 201, Text = "Ax" },
                new EnemyID() { Value = 202, Text = "Iron Ball" },
                new EnemyID() { Value = 204, Text = "Chang" },
                new EnemyID() { Value = 205, Text = "Gadwin" },
                new EnemyID() { Value = 206, Text = "Gadwin" },
                new EnemyID() { Value = 207, Text = "Kung Fu Master" },
                new EnemyID() { Value = 208, Text = "Mullen" },
                new EnemyID() { Value = 209, Text = "Saki" },
                new EnemyID() { Value = 210, Text = "Saki" },
                new EnemyID() { Value = 211, Text = "Mio" },
                new EnemyID() { Value = 212, Text = "Mio" },
                new EnemyID() { Value = 213, Text = "Nana" },
                new EnemyID() { Value = 214, Text = "Nana" },
                new EnemyID() { Value = 215, Text = "Grinwhale" },
                new EnemyID() { Value = 216, Text = "Lure" },
                new EnemyID() { Value = 217, Text = "Slug Fish" },
                new EnemyID() { Value = 218, Text = "Lure" },
                new EnemyID() { Value = 219, Text = "Baal" },
                new EnemyID() { Value = 220, Text = "Baal" },
                new EnemyID() { Value = 221, Text = "Gaia Tentacle" },
                new EnemyID() { Value = 222, Text = "Baal" },
                new EnemyID() { Value = 223, Text = "Gaia Tentacle" },
                new EnemyID() { Value = 224, Text = "Gaia Tentacle" },
                new EnemyID() { Value = 225, Text = "Gaia Battler" },
                new EnemyID() { Value = 226, Text = "Right Hand" },
                new EnemyID() { Value = 227, Text = "Left Hand" },
                new EnemyID() { Value = 228, Text = "Gaia Battler" },
                new EnemyID() { Value = 229, Text = "Right Hand" },
                new EnemyID() { Value = 230, Text = "Left Hand" },
                new EnemyID() { Value = 231, Text = "Gaia Battler" },
                new EnemyID() { Value = 232, Text = "Right Hand" },
                new EnemyID() { Value = 233, Text = "Left Hand" },
                new EnemyID() { Value = 234, Text = "Gaia Battler" },
                new EnemyID() { Value = 235, Text = "Right Hand" },
                new EnemyID() { Value = 236, Text = "Left Hand" },
                new EnemyID() { Value = 237, Text = "Gaia Core" },
                new EnemyID() { Value = 238, Text = "Mega Gaia" },
                new EnemyID() { Value = 240, Text = "Gaia Tentacle" },
                new EnemyID() { Value = 241, Text = "Evil Gaia" },
                new EnemyID() { Value = 244, Text = "Gaia Armor" },
                new EnemyID() { Value = 245, Text = "Eye" },
                new EnemyID() { Value = 246, Text = "Gaia Slime" },
                new EnemyID() { Value = 247, Text = "Combatant" },
                new EnemyID() { Value = 248, Text = "Gaia Tree" },
                new EnemyID() { Value = 249, Text = "Gaia Beetle" },
                new EnemyID() { Value = 250, Text = "Leviathan" },
                new EnemyID() { Value = 251, Text = "Right Tentacle" },
                new EnemyID() { Value = 252, Text = "Left Tentacle" },
                new EnemyID() { Value = 253, Text = "Orc" },
                new EnemyID() { Value = 254, Text = "Orc King" },
                new EnemyID() { Value = 255, Text = "Dom Orc" }
            };

            return itemList;
        }
    }
}
