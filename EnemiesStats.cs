using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GrandiaStatEditor
{
    public class EnemiesStats
    {
        public static Dictionary<int, Dictionary<string, string>> EnemiesStatsDictionary { get; set; } = new Dictionary<int, Dictionary<string, string>>();

        public static Dictionary<string, Dictionary<string, string>> EnemiesAttacksDictionary { get; set; } = new Dictionary<string, Dictionary<string, string>>();

        public static void ReadEnemiesData(string path)
        {
            string mdatFilePath = Path.Combine(path, "PC", "BATLE", "M_DAT.bin");

            var enemyListPosition = EnemyListClass.EnemyList();

            foreach (var enemyPosition in enemyListPosition)
            {
                var i = 1;
                //  entries for character starting data is not delimited
                var listStats = new Dictionary<string, string>();
                using (FileStream s = new FileStream(mdatFilePath, FileMode.Open))
                using (BinaryReader reader = new BinaryReader(s))
                {
                    reader.BaseStream.Position = enemyPosition;

                    var ID = reader.ReadByte();
                    var LV = reader.ReadByte();
                    var HP = reader.ReadInt16();
                    var STR = reader.ReadInt16();
                    var VIT = reader.ReadInt16();
                    var WIT = reader.ReadInt16();
                    var AGI = reader.ReadInt16();
                    var IpPower = reader.ReadInt16();
                    var EXP = reader.ReadInt16();
                    var GP = reader.ReadInt16();
                    var GoldPourcent = reader.ReadByte();
                    var Move = reader.ReadByte();
                    var ItemDrop1 = reader.ReadInt16();
                    var ItemDrop2 = reader.ReadInt16();
                    var ItemDrop1Pourcent = reader.ReadByte();
                    var ItemDrop2Pourcent = reader.ReadByte();
                    var MP1 = reader.ReadByte();
                    var MP2 = reader.ReadByte();
                    var MP3 = reader.ReadByte();
                    var SP = reader.ReadByte();
                    var SkillID1 = reader.ReadByte();
                    var SkillID2 = reader.ReadByte();
                    var SkillID3 = reader.ReadByte();
                    var SkillID4 = reader.ReadByte();
                    var AttackCount = reader.ReadByte();
                    var AttackRange = reader.ReadByte();
                    //Nibble
                    //Type : 2 = Sleep, 3 = Paralysie, 4 = Poison, 6 = Anti Spe, 8 = Random
                    var ExternalAttackAndType = reader.ReadByte();
                    var ExternalAttackPourcent = reader.ReadByte();
                    //Nibble
                    var UnknowAndKnockBackAttack = reader.ReadByte();
                    //Nibble
                    var AntiIpAndAntiKnockBack = reader.ReadByte();
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
                    var Size1 = reader.ReadInt16();
                    var Size2 = reader.ReadInt16();
                    var Unknow1 = reader.ReadByte();
                    //Nibble type : 1 = HUMAN/BEAST, 2 = 3 = BIRD, 4 = INSECT, 5 = PLANT, 6 = DEMON, 7 = SEA, 8 = NEBULOUS, 9 = DRAGON, A = GHOST, B = GAIA, C = BAT, D = SNAKE, E = F =
                    var UnknowAndType = reader.ReadByte();
                    var HideAct = reader.ReadByte();
                    var Unknow2 = reader.ReadInt16();
                    var Unknow3 = reader.ReadByte();
                    var CallID = reader.ReadByte();
                    var CallNumber = reader.ReadByte();
                    var CallPourcent = reader.ReadByte();
                    var IC = reader.ReadByte();
                    var IdNameDontCare = reader.ReadInt16();
                    var MonsterQuarter = reader.ReadBytes(10);
                    var MonsterFull = reader.ReadBytes(20);

                    //Try To Get Attacks into list With ID
                    var AttackByID = reader.ReadByte();
                    while(AttackByID == ID)
                    {
                        var listAttacks = new Dictionary<string, string>();

                        var MoveNumber = reader.ReadByte();
                        if(MoveNumber == i)
                        {
                            var Target = reader.ReadByte();
                            var NotSet1 = reader.ReadByte();
                            var IpPow = reader.ReadInt16();
                            var Power = reader.ReadInt16();
                            //Nibble
                            var UnknowAndKnockBack = reader.ReadByte();
                            var KnockBack = ByteConverterClass.GetNibble(UnknowAndKnockBack).Item2;
                            var AreaRange = reader.ReadByte();
                            //10 - Fire, 20 - Water, 40 - Wind, 50 - Thunder, 60 - Ice, 80 - Earth, 90 - Explosion, A0 - Forest
                            var Elemental = reader.ReadByte();
                            var AtkMove = reader.ReadByte();
                            var Critical = reader.ReadByte();
                            var EffectType = reader.ReadByte();
                            var Mode = reader.ReadByte();
                            var ExtType = reader.ReadByte();
                            var ExtProb = reader.ReadByte();
                            var ExtPower = reader.ReadByte();
                            var StopMode = reader.ReadByte();
                            var Unknow4 = reader.ReadByte();
                            var NotSet2 = reader.ReadByte();
                            var AtkRange = reader.ReadByte();
                            var AttackQuarter = reader.ReadBytes(10);
                            var AttackFull = reader.ReadBytes(20);
                            
                            listAttacks.Add($"Target", Target.ToString());
                            listAttacks.Add("NotSet1", NotSet1.ToString());
                            listAttacks.Add("IpPow", IpPow.ToString());
                            listAttacks.Add("Power", Power.ToString());
                            listAttacks.Add("UnknowAndKnockBack", UnknowAndKnockBack.ToString());
                            listAttacks.Add("KnockBack", KnockBack.ToString());
                            listAttacks.Add("AreaRange", AreaRange.ToString());
                            listAttacks.Add("Elemental", Elemental.ToString());
                            listAttacks.Add("AtkMove", AtkMove.ToString());
                            listAttacks.Add("Critical", Critical.ToString());
                            listAttacks.Add("EffectType", EffectType.ToString());
                            listAttacks.Add("Mode", Mode.ToString());
                            listAttacks.Add("ExtType", ExtType.ToString());
                            listAttacks.Add("ExtProb", ExtProb.ToString());
                            listAttacks.Add("ExtPower", ExtPower.ToString());
                            listAttacks.Add("StopMode", StopMode.ToString());
                            listAttacks.Add("Unknow4", Unknow4.ToString());
                            listAttacks.Add("NotSet2", NotSet2.ToString());
                            listAttacks.Add("AtkRange", AtkRange.ToString());
                            listAttacks.Add("AttackQuarter", Encoding.UTF8.GetString(AttackQuarter));
                            listAttacks.Add("AttackFull", Encoding.UTF8.GetString(AttackFull));

                            EnemiesAttacksDictionary.Add($"{AttackByID}_{MoveNumber}", listAttacks);
                            AttackByID = reader.ReadByte();
                            i++;
                        }
                    };

                    //Nibble Stats
                    var ExternalAttack = ByteConverterClass.GetNibble(ExternalAttackAndType).Item1;
                    var ExternalType = ByteConverterClass.GetNibble(ExternalAttackAndType).Item2;

                    var unknowKnockBack = ByteConverterClass.GetNibble(UnknowAndKnockBackAttack).Item1;
                    var knockBackAttack = ByteConverterClass.GetNibble(UnknowAndKnockBackAttack).Item2;

                    var AntiIp = ByteConverterClass.GetNibble(AntiIpAndAntiKnockBack).Item1;
                    var AntiKB = ByteConverterClass.GetNibble(AntiIpAndAntiKnockBack).Item2;

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

                    var UnknowType = ByteConverterClass.GetNibble(UnknowAndType).Item1;
                    var Type = ByteConverterClass.GetNibble(UnknowAndType).Item2;

                    //MakeList
                    listStats.Add("ID", ID.ToString());
                    listStats.Add("LV", LV.ToString());
                    listStats.Add("HP", HP.ToString());
                    listStats.Add("STR", STR.ToString());
                    listStats.Add("VIT", VIT.ToString());
                    listStats.Add("WIT", WIT.ToString());
                    listStats.Add("AGI", AGI.ToString());
                    listStats.Add("IpPower", IpPower.ToString());
                    listStats.Add("EXP", EXP.ToString());
                    listStats.Add("GP", GP.ToString());
                    listStats.Add("GoldPourcent", GoldPourcent.ToString());
                    listStats.Add("Move", Move.ToString());
                    listStats.Add("ItemDrop1", ItemDrop1.ToString());
                    listStats.Add("ItemDrop2", ItemDrop2.ToString());
                    listStats.Add("ItemDrop1Pourcent", ItemDrop1Pourcent.ToString());
                    listStats.Add("ItemDrop2Pourcent", ItemDrop2Pourcent.ToString());
                    listStats.Add("MP1", MP1.ToString());
                    listStats.Add("MP2", MP2.ToString());
                    listStats.Add("MP3", MP3.ToString());
                    listStats.Add("SP", SP.ToString());
                    listStats.Add("SkillID1", SkillID1.ToString());
                    listStats.Add("SkillID2", SkillID2.ToString());
                    listStats.Add("SkillID3", SkillID3.ToString());
                    listStats.Add("SkillID4", SkillID4.ToString());
                    listStats.Add("AttackCount", AttackCount.ToString());
                    listStats.Add("AttackRange", AttackRange.ToString());
                    listStats.Add("Ext_Atk", ExternalAttack.ToString());
                    listStats.Add("Ext_Type", ExternalType.ToString());
                    listStats.Add("Ext_Pourcent", ExternalAttackPourcent.ToString());
                    listStats.Add("KBAttack", knockBackAttack.ToString());
                    listStats.Add("AntiKB", AntiKB.ToString());
                    listStats.Add("AntiIp", AntiIp.ToString());
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
                    listStats.Add("HideAct", HideAct.ToString());
                    listStats.Add("CallID", CallID.ToString());
                    listStats.Add("CallNumber", CallNumber.ToString());
                    listStats.Add("CallPourcent", CallPourcent.ToString());
                    listStats.Add("NameQuarter", Encoding.UTF8.GetString(MonsterQuarter));
                    listStats.Add("NameFull", Encoding.UTF8.GetString(MonsterFull));

                    EnemiesStatsDictionary.Add(enemyPosition, listStats);
                }
            }
        }
    }
}
