using System.Collections.Generic;
using System.IO;

namespace GrandiaStatEditor
{
    public class CharactersStats
    {

        public static Dictionary<string, Dictionary<string, string>> CharactersDictionary { get; set; } = new Dictionary<string, Dictionary<string, string>>();

        public static void ReadCharatersData(string path)
        {
            string mcharFilePath = Path.Combine(path,"BIN", "mchar.dat");

            List<string> charatersList = new List<string>() { "JUSTIN", "FEENA", "SUE", "GADWIN", "RAPP", "MILDA", "GUIDO", "LIETE" };

            long position = 0x08;

            foreach (var charater in charatersList)
            {
                var listStats = new Dictionary<string, string>();
                using (FileStream s = new FileStream(mcharFilePath, FileMode.Open))
                using (BinaryReader reader = new BinaryReader(s))
                {
                    reader.BaseStream.Position = position;
                    var EXP = reader.ReadInt32();
                    var NextEXP = reader.ReadInt16();
                    var LV = reader.ReadByte();
                    //NIBBLE
                    var CrititalCombo = reader.ReadByte();
                    var HP = reader.ReadInt16();
                    var STR = reader.ReadInt16();
                    var VIT = reader.ReadInt16();
                    var WIT = reader.ReadInt16();
                    var AGI = reader.ReadInt16();
                    var SP = reader.ReadInt16();
                    var FireExp = reader.ReadInt16();
                    var WaterExp = reader.ReadInt16();
                    var WindExp = reader.ReadInt16();
                    var EarthExp = reader.ReadInt16();
                    var Weapon1Exp = reader.ReadInt16();
                    var Weapon2Exp = reader.ReadInt16();
                    var Weapon3Exp = reader.ReadInt16();
                    var Weapon4Exp = reader.ReadInt16();
                    var FireLevel = reader.ReadByte();
                    var WaterLevel = reader.ReadByte();
                    var WindLevel = reader.ReadByte();
                    var EarthLevel = reader.ReadByte();
                    var Weapon1Level = reader.ReadByte();
                    var Weapon2Level = reader.ReadByte();
                    var Weapon3Level = reader.ReadByte();
                    var Weapon4Level = reader.ReadByte();
                    var CurrentMP1 = reader.ReadByte();
                    var MaxMP1 = reader.ReadByte();
                    var CurrentMP2 = reader.ReadByte();
                    var MaxMP2 = reader.ReadByte(); 
                    var CurrentMP3 = reader.ReadByte();
                    var MaxMP3 = reader.ReadByte();
                    //Nibble
                    var MagicAndMoveBlockResist = reader.ReadByte();
                    //Nibble
                    var PlagueAndPoisonResist = reader.ReadByte();
                    //Nibble
                    var ParalysisAndSleepResist = reader.ReadByte();
                    //Nibble
                    var ConfusionAndCriticalResist = reader.ReadByte();
                    //Nibble
                    var FireAndWaterResist = reader.ReadByte();
                    //Nibble
                    var WindAndEarthResist = reader.ReadByte();
                    var Weapon = reader.ReadInt16();
                    var Shield = reader.ReadInt16();
                    var Armor = reader.ReadInt16();
                    var Helmet = reader.ReadInt16();
                    var Footwear = reader.ReadInt16();
                    var Accessory = reader.ReadInt16();
                    var Item1 = reader.ReadInt16();
                    var Item2 = reader.ReadInt16();
                    var Item3 = reader.ReadInt16();
                    var Item4 = reader.ReadInt16();
                    var Item5 = reader.ReadInt16();
                    var Item6 = reader.ReadInt16();
                    var Item7 = reader.ReadInt16();
                    var Item8 = reader.ReadInt16();
                    var Item9 = reader.ReadInt16();
                    var Item10 = reader.ReadInt16();
                    var Item11 = reader.ReadInt16();
                    var Item12 = reader.ReadInt16();
                    var Unknow2 = reader.ReadInt32();

                    var Critical = ByteConverterClass.GetNibble(CrititalCombo).Item1;
                    var Combo = ByteConverterClass.GetNibble(CrititalCombo).Item2;

                    var MagicBlockResist = ByteConverterClass.GetNibble(MagicAndMoveBlockResist).Item1 - 7;
                    var MoveBlockResist = ByteConverterClass.GetNibble(MagicAndMoveBlockResist).Item2 - 7;

                    var PlagueResist = ByteConverterClass.GetNibble(PlagueAndPoisonResist).Item1 - 7;
                    var PoisonResist = ByteConverterClass.GetNibble(PlagueAndPoisonResist).Item2 - 7;

                    var ParalysisResist = ByteConverterClass.GetNibble(ParalysisAndSleepResist).Item1 - 7;
                    var SleepResist = ByteConverterClass.GetNibble(ParalysisAndSleepResist).Item2 - 7;

                    var ConfusionResist = ByteConverterClass.GetNibble(ConfusionAndCriticalResist).Item1 - 7;
                    var CriticalResist = ByteConverterClass.GetNibble(ConfusionAndCriticalResist).Item2 - 7;

                    var FireResist = ByteConverterClass.GetNibble(FireAndWaterResist).Item1 - 7;
                    var WaterResist = ByteConverterClass.GetNibble(FireAndWaterResist).Item2 - 7;

                    var WindResist = ByteConverterClass.GetNibble(WindAndEarthResist).Item1 - 7;
                    var EarthResist = ByteConverterClass.GetNibble(WindAndEarthResist).Item2 - 7;

                    listStats.Add("EXP", EXP.ToString());
                    listStats.Add("NextEXP", NextEXP.ToString());
                    listStats.Add("LV", LV.ToString());
                    listStats.Add("Critical", Critical.ToString());
                    listStats.Add("Combo", Combo.ToString());
                    listStats.Add("HP", HP.ToString());
                    listStats.Add("STR", STR.ToString());
                    listStats.Add("VIT", VIT.ToString());
                    listStats.Add("WIT", WIT.ToString());
                    listStats.Add("AGI", AGI.ToString());
                    listStats.Add("SP", SP.ToString());
                    listStats.Add("FireExp", FireExp.ToString());
                    listStats.Add("WaterExp", WaterExp.ToString());
                    listStats.Add("WindExp", WindExp.ToString());
                    listStats.Add("EarthExp", EarthExp.ToString());
                    listStats.Add("Weapon1Exp", Weapon1Exp.ToString());
                    listStats.Add("Weapon2Exp", Weapon2Exp.ToString());
                    listStats.Add("Weapon3Exp", Weapon3Exp.ToString());
                    listStats.Add("Weapon4Exp", Weapon4Exp.ToString());
                    listStats.Add("FireLevel", FireLevel.ToString());
                    listStats.Add("WaterLevel", WaterLevel.ToString());
                    listStats.Add("WindLevel", WindLevel.ToString());
                    listStats.Add("EarthLevel", EarthLevel.ToString());
                    listStats.Add("Weapon1Level", Weapon1Level.ToString());
                    listStats.Add("Weapon2Level", Weapon2Level.ToString());
                    listStats.Add("Weapon3Level", Weapon3Level.ToString());
                    listStats.Add("Weapon4Level", Weapon4Level.ToString());
                    listStats.Add("CurrentMP1", CurrentMP1.ToString());
                    listStats.Add("MaxMP1", MaxMP1.ToString());
                    listStats.Add("CurrentMP2", CurrentMP2.ToString());
                    listStats.Add("MaxMP2", MaxMP2.ToString());
                    listStats.Add("CurrentMP3", CurrentMP3.ToString());
                    listStats.Add("MaxMP3", MaxMP3.ToString());
                    listStats.Add("MagicBlockResist", MagicBlockResist.ToString());
                    listStats.Add("MoveBlockResist", MoveBlockResist.ToString());
                    listStats.Add("PlagueResist", PlagueResist.ToString());
                    listStats.Add("PoisonResist", PoisonResist.ToString());
                    listStats.Add("ParalysisResist", ParalysisResist.ToString());
                    listStats.Add("SleepResist", SleepResist.ToString());
                    listStats.Add("ConfusionResist", ConfusionResist.ToString());
                    listStats.Add("CriticalResist", CriticalResist.ToString());
                    listStats.Add("FireResist", FireResist.ToString());
                    listStats.Add("WaterResist", WaterResist.ToString());
                    listStats.Add("WindResist", WindResist.ToString());
                    listStats.Add("EarthResist", EarthResist.ToString());
                    listStats.Add("Weapon", Weapon.ToString());
                    listStats.Add("Shield", Shield.ToString());
                    listStats.Add("Armor", Armor.ToString());
                    listStats.Add("Helmet", Helmet.ToString());
                    listStats.Add("Footwear", Footwear.ToString());
                    listStats.Add("Accessory", Accessory.ToString());
                    listStats.Add("Item1", Item1.ToString());
                    listStats.Add("Item2", Item2.ToString());
                    listStats.Add("Item3", Item3.ToString());
                    listStats.Add("Item4", Item4.ToString());
                    listStats.Add("Item5", Item5.ToString());
                    listStats.Add("Item6", Item6.ToString());
                    listStats.Add("Item7", Item7.ToString());
                    listStats.Add("Item8", Item8.ToString());
                    listStats.Add("Item9", Item9.ToString());
                    listStats.Add("Item10", Item10.ToString());
                    listStats.Add("Item11", Item11.ToString());
                    listStats.Add("Item12", Item12.ToString());

                    CharactersDictionary.Add(charater, listStats);

                    position = reader.BaseStream.Position;
                }
            }
        }

    }
}
