using System.Collections.Generic;
using System.IO;

namespace GrandiaStatEditor
{
    public class WriteDatas
    {
        public static void WriteMdat(string path, string setPosition, Dictionary<string, string> dataList)
        {
            var filePath = Path.Combine(path, "BATLE", "M_DAT.BIN");

            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                var IDCheck = int.Parse(dataList["ID"]);
                var ID = ByteConverterClass.IntToByte(dataList["ID"]);

                stream.Seek(int.Parse(setPosition), SeekOrigin.Begin);
                stream.ReadByte();

                var LV = ByteConverterClass.IntToByte(dataList["LV"]);
                stream.Write(LV, 0, LV.Length);

                var HP = ByteConverterClass.Int16ToBytes(dataList["HP"]);
                stream.Write(HP, 0, HP.Length);

                var STR = ByteConverterClass.Int16ToBytes(dataList["STR"]);
                stream.Write(STR, 0, STR.Length);

                var VIT = ByteConverterClass.Int16ToBytes(dataList["VIT"]);
                stream.Write(VIT, 0, VIT.Length);

                var WIT = ByteConverterClass.Int16ToBytes(dataList["WIT"]);
                stream.Write(WIT, 0, WIT.Length);

                var AGI = ByteConverterClass.Int16ToBytes(dataList["AGI"]);
                stream.Write(AGI, 0, AGI.Length);

                var IpPower = ByteConverterClass.Int16ToBytes(dataList["IpPower"]);
                stream.Write(IpPower, 0, IpPower.Length);

                var EXP = ByteConverterClass.Int16ToBytes(dataList["EXP"]);
                stream.Write(EXP, 0, EXP.Length);

                var GP = ByteConverterClass.Int16ToBytes(dataList["GP"]);
                stream.Write(GP, 0, GP.Length);

                var GoldPourcent = ByteConverterClass.IntToByte(dataList["GoldPourcent"]);
                stream.Write(GoldPourcent, 0, GoldPourcent.Length);

                var Move = ByteConverterClass.IntToByte(dataList["Move"]);
                stream.Write(Move, 0, Move.Length);

                var ItemDrop1 = ByteConverterClass.Int16ToBytes(dataList["ItemDrop1"]);
                stream.Write(ItemDrop1, 0, ItemDrop1.Length);

                var ItemDrop2 = ByteConverterClass.Int16ToBytes(dataList["ItemDrop2"]);
                stream.Write(ItemDrop2, 0, ItemDrop2.Length);

                var ItemDrop1Pourcent = ByteConverterClass.IntToByte(dataList["ItemDrop1Pourcent"]);
                stream.Write(ItemDrop1Pourcent, 0, ItemDrop1Pourcent.Length);

                var ItemDrop2Pourcent = ByteConverterClass.IntToByte(dataList["ItemDrop2Pourcent"]);
                stream.Write(ItemDrop2Pourcent, 0, ItemDrop2Pourcent.Length);

                var MP1 = ByteConverterClass.IntToByte(dataList["MP1"]);
                stream.Write(MP1, 0, MP1.Length);

                var MP2 = ByteConverterClass.IntToByte(dataList["MP2"]);
                stream.Write(MP2, 0, MP2.Length);

                var MP3 = ByteConverterClass.IntToByte(dataList["MP3"]);
                stream.Write(MP3, 0, MP3.Length);

                var SP = ByteConverterClass.IntToByte(dataList["SP"]);
                stream.Write(SP, 0, SP.Length);

                var SkillID1 = ByteConverterClass.IntToByte(dataList["SkillID1"]);
                stream.Write(SkillID1, 0, SkillID1.Length);

                var SkillID2 = ByteConverterClass.IntToByte(dataList["SkillID2"]);
                stream.Write(SkillID2, 0, SkillID2.Length);

                var SkillID3 = ByteConverterClass.IntToByte(dataList["SkillID3"]);
                stream.Write(SkillID3, 0, SkillID3.Length);

                var SkillID4 = ByteConverterClass.IntToByte(dataList["SkillID4"]);
                stream.Write(SkillID4, 0, SkillID4.Length);

                var AttackCount = ByteConverterClass.IntToByte(dataList["AttackCount"]);
                stream.Write(AttackCount, 0, AttackCount.Length);

                var AttackRange = ByteConverterClass.IntToByte(dataList["AttackRange"]);
                stream.Write(AttackRange, 0, AttackRange.Length);

                var ExternalAttackAndType = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(dataList["Ext_Atk"], dataList["Ext_Type"]).ToString());
                stream.Write(ExternalAttackAndType, 0, ExternalAttackAndType.Length);

                var Ext_Pourcent = ByteConverterClass.IntToByte(dataList["Ext_Pourcent"]);
                stream.Write(Ext_Pourcent, 0, Ext_Pourcent.Length);

                var position = stream.Position;
                var tempRead = stream.ReadByte();
                var UnknowKnockBackAttack = ByteConverterClass.GetNibble((byte)tempRead).Item1;
                var UnknowAndKnockBackAttack = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(UnknowKnockBackAttack.ToString(), dataList["KBAttack"]).ToString());
                stream.Seek(position, SeekOrigin.Begin);
                stream.Write(UnknowAndKnockBackAttack, 0, UnknowAndKnockBackAttack.Length);

                var AntiIpAndAntiKnockBack = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(dataList["AntiIp"], dataList["AntiKB"]).ToString());
                stream.Write(AntiIpAndAntiKnockBack, 0, AntiIpAndAntiKnockBack.Length);

                var MagicAndMoveBlockResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(ByteConverterClass.AddSeven(dataList["MagicBlockResist"]), ByteConverterClass.AddSeven(dataList["MoveBlockResist"])).ToString());
                stream.Write(MagicAndMoveBlockResist, 0, MagicAndMoveBlockResist.Length);

                var PlagueAndPoisonResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(ByteConverterClass.AddSeven(dataList["PlagueResist"]), ByteConverterClass.AddSeven(dataList["PoisonResist"])).ToString());
                stream.Write(PlagueAndPoisonResist, 0, PlagueAndPoisonResist.Length);

                var ParalysisAndSleepResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(ByteConverterClass.AddSeven(dataList["ParalysisResist"]), ByteConverterClass.AddSeven(dataList["SleepResist"])).ToString());
                stream.Write(ParalysisAndSleepResist, 0, ParalysisAndSleepResist.Length);

                var ConfusionAndCriticalResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(ByteConverterClass.AddSeven(dataList["ConfusionResist"]), ByteConverterClass.AddSeven(dataList["CriticalResist"])).ToString());
                stream.Write(ConfusionAndCriticalResist, 0, ConfusionAndCriticalResist.Length);

                var FireAndWaterResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(ByteConverterClass.AddSeven(dataList["FireResist"]), ByteConverterClass.AddSeven(dataList["WaterResist"])).ToString());
                stream.Write(FireAndWaterResist, 0, FireAndWaterResist.Length);

                var WindAndEarthResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(ByteConverterClass.AddSeven(dataList["WindResist"]), ByteConverterClass.AddSeven(dataList["EarthResist"])).ToString());
                stream.Write(WindAndEarthResist, 0, WindAndEarthResist.Length);

                //Size 1
                stream.ReadByte();
                stream.ReadByte();
                //Size 2
                stream.ReadByte();
                stream.ReadByte();
                //Unknow1
                stream.ReadByte();
                //UnknowAndType
                stream.ReadByte();
                //HideAct Replace by stream.ReadByte();
                /*var HideAct = ByteConverterClass.IntToByte(dataList["HideAct"]);
                stream.Write(HideAct, 0, HideAct.Length);*/
                stream.ReadByte();

                //Unknow2
                stream.ReadByte();
                stream.ReadByte();
                //Unknow3
                stream.ReadByte();

                var CallId = ByteConverterClass.IntToByte(dataList["CallID"]);
                stream.Write(CallId, 0, CallId.Length);

                var CallNumber = ByteConverterClass.IntToByte(dataList["CallNumber"]);
                stream.Write(CallNumber, 0, CallNumber.Length);

                var CallPourcent = ByteConverterClass.IntToByte(dataList["CallPourcent"]);
                stream.Write(CallPourcent, 0, CallPourcent.Length);

                //IC
                stream.ReadByte();
                //IdNameDontCare
                stream.ReadByte();
                stream.ReadByte();
                //MonsterQuarter
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                //MonsterFull
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();

                //ListUpdate
                foreach (var data in dataList)
                {
                    if (EnemiesStats.EnemiesStatsDictionary.TryGetValue(int.Parse(setPosition), out Dictionary<string, string> innerDict))
                    {
                        if (innerDict.TryGetValue(data.Key, out string value))
                        {
                            // Update the value for the key "innerKey" in the inner dictionary
                            innerDict[data.Key] = data.Value;
                        }
                    }
                }

                var i = 1;
                var AttackByID = stream.ReadByte();
                while (AttackByID == IDCheck)
                {
                    var MoveNumber = stream.ReadByte();
                    if (MoveNumber == i)
                    {
                        var Target = ByteConverterClass.IntToByte(dataList[$"Target_{i}"]);
                        stream.Write(Target, 0, Target.Length);

                        //NotSet1
                        stream.ReadByte();

                        var IpPow = ByteConverterClass.Int16ToBytes(dataList[$"IpPow_{i}"]);
                        stream.Write(IpPow, 0, IpPow.Length);

                        var Power = ByteConverterClass.Int16ToBytes(dataList[$"Power_{i}"]);
                        stream.Write(Power, 0, Power.Length);

                        position = stream.Position;
                        tempRead = stream.ReadByte();
                        var UnknowKnockBack = ByteConverterClass.GetNibble((byte)tempRead).Item1;
                        var UnknowAndKnockBack = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(UnknowKnockBack.ToString(), dataList[$"KnockBack_{i}"]).ToString());
                        stream.Seek(position, SeekOrigin.Begin);
                        stream.Write(UnknowAndKnockBack, 0, UnknowAndKnockBack.Length);

                        var AreaRange = ByteConverterClass.IntToByte(dataList[$"AreaRange_{i}"]);
                        stream.Write(AreaRange, 0, AreaRange.Length);

                        var Elemental = ByteConverterClass.IntToByte(dataList[$"Elemental_{i}"]);
                        stream.Write(Elemental, 0, Elemental.Length);

                        var AtkMove = ByteConverterClass.IntToByte(dataList[$"AtkMove_{i}"]);
                        stream.Write(AtkMove, 0, AtkMove.Length);

                        var Critical = ByteConverterClass.IntToByte(dataList[$"Critical_{i}"]);
                        stream.Write(Critical, 0, Critical.Length);

                        var EffectType = ByteConverterClass.IntToByte(dataList[$"EffectType_{i}"]);
                        stream.Write(EffectType, 0, EffectType.Length);

                        var Mode = ByteConverterClass.IntToByte(dataList[$"Mode_{i}"]);
                        stream.Write(Mode, 0, Mode.Length);

                        var ExtType = ByteConverterClass.IntToByte(dataList[$"ExtType_{i}"]);
                        stream.Write(ExtType, 0, ExtType.Length);

                        var ExtProb = ByteConverterClass.IntToByte(dataList[$"ExtProb_{i}"]);
                        stream.Write(ExtProb, 0, ExtProb.Length);

                        var ExtPower = ByteConverterClass.IntToByte(dataList[$"ExtPower_{i}"]);
                        stream.Write(ExtPower, 0, ExtPower.Length);

                        var StopMode = ByteConverterClass.IntToByte(dataList[$"StopMode_{i}"]);
                        stream.Write(StopMode, 0, StopMode.Length);

                        //Unknow4
                        stream.ReadByte();
                        //NotSet2
                        stream.ReadByte();

                        var AtkRange = ByteConverterClass.IntToByte(dataList[$"AtkRange_{i}"]);
                        stream.Write(AtkRange, 0, AtkRange.Length);

                        //AttackQuarter
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        //AttackFull
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();
                        stream.ReadByte();

                        AttackByID = stream.ReadByte();

                        //ListUpdate
                        foreach (var data in dataList)
                        {
                            if (EnemiesStats.EnemiesAttacksDictionary.TryGetValue($"{IDCheck}_{i}", out Dictionary<string, string> innerDict))
                            {
                                if (innerDict.TryGetValue(data.Key.Replace($"_{i}", ""), out string value))
                                {
                                    // Update the value for the key "innerKey" in the inner dictionary
                                    innerDict[data.Key.Replace($"_{i}", "")] = data.Value;
                                }
                            }
                        }

                        i++;
                    }
                };
            }
        }

        public static void WriteMchar(string path)
        {
            var filePath = Path.Combine(path, "BIN", "mchar.dat");
            long position = 0x08;

            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                stream.Seek(position, SeekOrigin.Begin);

                foreach (var value in CharactersStats.CharactersDictionary.Keys)
                {
                    Dictionary<string, string> innerDictionary = CharactersStats.CharactersDictionary[value];

                    var EXP = ByteConverterClass.Int32ToBytes(innerDictionary["EXP"]);
                    stream.Write(EXP, 0, EXP.Length);

                    var NextEXP = ByteConverterClass.Int16ToBytes(innerDictionary["NextEXP"]);
                    stream.Write(NextEXP, 0, NextEXP.Length);

                    var LV = ByteConverterClass.IntToByte(innerDictionary["LV"]);
                    stream.Write(LV, 0, LV.Length);

                    var CrititalCombo = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(innerDictionary["Critical"], innerDictionary["Combo"]).ToString());
                    stream.Write(CrititalCombo, 0, CrititalCombo.Length);

                    var HP = ByteConverterClass.Int16ToBytes(innerDictionary["HP"]);
                    stream.Write(HP, 0, HP.Length);

                    var STR = ByteConverterClass.Int16ToBytes(innerDictionary["STR"]);
                    stream.Write(STR, 0, STR.Length);

                    var VIT = ByteConverterClass.Int16ToBytes(innerDictionary["VIT"]);
                    stream.Write(VIT, 0, VIT.Length);

                    var WIT = ByteConverterClass.Int16ToBytes(innerDictionary["WIT"]);
                    stream.Write(WIT, 0, VIT.Length);

                    var AGI = ByteConverterClass.Int16ToBytes(innerDictionary["AGI"]);
                    stream.Write(AGI, 0, AGI.Length);

                    var SP = ByteConverterClass.Int16ToBytes(innerDictionary["SP"]);
                    stream.Write(SP, 0, SP.Length);

                    var FireExp = ByteConverterClass.Int16ToBytes(innerDictionary["FireExp"]);
                    stream.Write(FireExp, 0, FireExp.Length);

                    var WaterExp = ByteConverterClass.Int16ToBytes(innerDictionary["WaterExp"]);
                    stream.Write(WaterExp, 0, WaterExp.Length);

                    var WindExp = ByteConverterClass.Int16ToBytes(innerDictionary["WindExp"]);
                    stream.Write(WindExp, 0, WindExp.Length);

                    var EarthExp = ByteConverterClass.Int16ToBytes(innerDictionary["EarthExp"]);
                    stream.Write(EarthExp, 0, EarthExp.Length);

                    var Weapon1Exp = ByteConverterClass.Int16ToBytes(innerDictionary["Weapon1Exp"]);
                    stream.Write(Weapon1Exp, 0, Weapon1Exp.Length);

                    var Weapon2Exp = ByteConverterClass.Int16ToBytes(innerDictionary["Weapon2Exp"]);
                    stream.Write(Weapon2Exp, 0, Weapon2Exp.Length);

                    var Weapon3Exp = ByteConverterClass.Int16ToBytes(innerDictionary["Weapon3Exp"]);
                    stream.Write(Weapon3Exp, 0, Weapon3Exp.Length);

                    var Weapon4Exp = ByteConverterClass.Int16ToBytes(innerDictionary["Weapon4Exp"]);
                    stream.Write(Weapon4Exp, 0, Weapon4Exp.Length);

                    var FireLevel = ByteConverterClass.IntToByte(innerDictionary["FireLevel"]);
                    stream.Write(FireLevel, 0, FireLevel.Length);

                    var WaterLevel = ByteConverterClass.IntToByte(innerDictionary["WaterLevel"]);
                    stream.Write(WaterLevel, 0, WaterLevel.Length);

                    var WindLevel = ByteConverterClass.IntToByte(innerDictionary["WindLevel"]);
                    stream.Write(WindLevel, 0, WindLevel.Length);

                    var EarthLevel = ByteConverterClass.IntToByte(innerDictionary["EarthLevel"]);
                    stream.Write(EarthLevel, 0, EarthLevel.Length);

                    var Weapon1Level = ByteConverterClass.IntToByte(innerDictionary["Weapon1Level"]);
                    stream.Write(Weapon1Level, 0, Weapon1Level.Length);

                    var Weapon2Level = ByteConverterClass.IntToByte(innerDictionary["Weapon2Level"]);
                    stream.Write(Weapon2Level, 0, Weapon2Level.Length);

                    var Weapon3Level = ByteConverterClass.IntToByte(innerDictionary["Weapon3Level"]);
                    stream.Write(Weapon3Level, 0, Weapon3Level.Length);

                    var Weapon4Level = ByteConverterClass.IntToByte(innerDictionary["Weapon4Level"]);
                    stream.Write(Weapon4Level, 0, Weapon4Level.Length);

                    var CurrentMP1 = ByteConverterClass.IntToByte(innerDictionary["CurrentMP1"]);
                    stream.Write(CurrentMP1, 0, CurrentMP1.Length);

                    var MaxMP1 = ByteConverterClass.IntToByte(innerDictionary["MaxMP1"]);
                    stream.Write(MaxMP1, 0, MaxMP1.Length);

                    var CurrentMP2 = ByteConverterClass.IntToByte(innerDictionary["CurrentMP2"]);
                    stream.Write(CurrentMP2, 0, CurrentMP2.Length);

                    var MaxMP2 = ByteConverterClass.IntToByte(innerDictionary["MaxMP2"]);
                    stream.Write(MaxMP2, 0, MaxMP2.Length);

                    var CurrentMP3 = ByteConverterClass.IntToByte(innerDictionary["CurrentMP3"]);
                    stream.Write(CurrentMP3, 0, CurrentMP3.Length);

                    var MaxMP3 = ByteConverterClass.IntToByte(innerDictionary["MaxMP3"]);
                    stream.Write(MaxMP3, 0, MaxMP3.Length);

                    var MagicAndMoveBlockResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(ByteConverterClass.AddSeven(innerDictionary["MagicBlockResist"]), ByteConverterClass.AddSeven(innerDictionary["MoveBlockResist"])).ToString());
                    stream.Write(MagicAndMoveBlockResist, 0, MagicAndMoveBlockResist.Length);

                    var PlagueAndPoisonResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(ByteConverterClass.AddSeven(innerDictionary["PlagueResist"]), ByteConverterClass.AddSeven(innerDictionary["PoisonResist"])).ToString());
                    stream.Write(PlagueAndPoisonResist, 0, PlagueAndPoisonResist.Length);

                    var ParalysisAndSleepResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(ByteConverterClass.AddSeven(innerDictionary["ParalysisResist"]), ByteConverterClass.AddSeven(innerDictionary["SleepResist"])).ToString());
                    stream.Write(ParalysisAndSleepResist, 0, ParalysisAndSleepResist.Length);

                    var ConfusionAndCriticalResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(ByteConverterClass.AddSeven(innerDictionary["ConfusionResist"]), ByteConverterClass.AddSeven(innerDictionary["CriticalResist"])).ToString());
                    stream.Write(ConfusionAndCriticalResist, 0, ConfusionAndCriticalResist.Length);

                    var FireAndWaterResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(ByteConverterClass.AddSeven(innerDictionary["FireResist"]), ByteConverterClass.AddSeven(innerDictionary["WaterResist"])).ToString());
                    stream.Write(FireAndWaterResist, 0, FireAndWaterResist.Length);

                    var WindAndEarthResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(ByteConverterClass.AddSeven(innerDictionary["WindResist"]), ByteConverterClass.AddSeven(innerDictionary["EarthResist"])).ToString());
                    stream.Write(WindAndEarthResist, 0, WindAndEarthResist.Length);

                    var Weapon = ByteConverterClass.Int16ToBytes(innerDictionary["Weapon"]);
                    stream.Write(Weapon, 0, Weapon.Length);

                    var Shield = ByteConverterClass.Int16ToBytes(innerDictionary["Shield"]);
                    stream.Write(Shield, 0, Shield.Length);

                    var Armor = ByteConverterClass.Int16ToBytes(innerDictionary["Armor"]);
                    stream.Write(Armor, 0, Armor.Length);

                    var Helmet = ByteConverterClass.Int16ToBytes(innerDictionary["Helmet"]);
                    stream.Write(Helmet, 0, Helmet.Length);

                    var Footwear = ByteConverterClass.Int16ToBytes(innerDictionary["Footwear"]);
                    stream.Write(Footwear, 0, Footwear.Length);

                    var Accessory = ByteConverterClass.Int16ToBytes(innerDictionary["Accessory"]);
                    stream.Write(Accessory, 0, Accessory.Length);

                    var Item1 = ByteConverterClass.Int16ToBytes(innerDictionary["Item1"]);
                    stream.Write(Item1, 0, Item1.Length);

                    var Item2 = ByteConverterClass.Int16ToBytes(innerDictionary["Item2"]);
                    stream.Write(Item2, 0, Item2.Length);

                    var Item3 = ByteConverterClass.Int16ToBytes(innerDictionary["Item3"]);
                    stream.Write(Item3, 0, Item3.Length);

                    var Item4 = ByteConverterClass.Int16ToBytes(innerDictionary["Item4"]);
                    stream.Write(Item4, 0, Item1.Length);

                    var Item5 = ByteConverterClass.Int16ToBytes(innerDictionary["Item5"]);
                    stream.Write(Item5, 0, Item1.Length);

                    var Item6 = ByteConverterClass.Int16ToBytes(innerDictionary["Item6"]);
                    stream.Write(Item6, 0, Item6.Length);

                    var Item7 = ByteConverterClass.Int16ToBytes(innerDictionary["Item7"]);
                    stream.Write(Item7, 0, Item7.Length);

                    var Item8 = ByteConverterClass.Int16ToBytes(innerDictionary["Item8"]);
                    stream.Write(Item8, 0, Item8.Length);

                    var Item9 = ByteConverterClass.Int16ToBytes(innerDictionary["Item9"]);
                    stream.Write(Item9, 0, Item9.Length);

                    var Item10 = ByteConverterClass.Int16ToBytes(innerDictionary["Item10"]);
                    stream.Write(Item10, 0, Item10.Length);

                    var Item11 = ByteConverterClass.Int16ToBytes(innerDictionary["Item11"]);
                    stream.Write(Item11, 0, Item11.Length);

                    var Item12 = ByteConverterClass.Int16ToBytes(innerDictionary["Item12"]);
                    stream.Write(Item12, 0, Item12.Length);

                    stream.ReadByte();
                    stream.ReadByte();
                    stream.ReadByte();
                    stream.ReadByte();
                }
            };
        }

        public static void WriteWindt(string path)
        {
            var filePath = Path.Combine(path, "FIELD", "windt.bin");
            long position = 0x8D08;

            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                stream.Seek(position, SeekOrigin.Begin);
                WindtDataWrite(stream);
            };
        }

        public static void WriteBBG(string path)
        {
            var filePath = Path.Combine(path, "BATLE");
            foreach (string file in Directory.GetFiles(filePath, "*.bbg"))
            {
                byte[] searchSequence = new byte[] { 0x00, 0x18, 0x00, 0x00, 0x00, 0x18, 0x0C, 0x00, 0x00, 0xB0, 0x14, 0x00, 0x00, 0x30, 0x18, 0x00, 0x00, 0x14, 0x50, 0x00, 0x00, 0x10, 0x56, 0x00, 0x00 };

                using (FileStream stream = new FileStream(file, FileMode.Open))
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    long position = 0;
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        byte b = reader.ReadByte();
                        if (b == searchSequence[position])
                        {
                            position++;
                            if (position == searchSequence.Length)
                            {
                                // Sequence found
                                long endPosition = reader.BaseStream.Position;

                                // Write new data to file
                                stream.Seek(endPosition, SeekOrigin.Begin);
                                WindtDataWrite(stream);
                                break;
                            }
                        }
                        else
                        {
                            position = 0;
                        }
                    }
                }
            }
        }

        public static void WriteWindt2(string path)
        {
            var filePath = Path.Combine(path, "FIELD", "windt.bin");
            long position = 0x990F;

            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                stream.Seek(position, SeekOrigin.Begin);
                Windt2DataWrite(stream);
            };
        }

        

        public static void WriteBBG2(string path)
        {
            var filePath = Path.Combine(path, "BATLE");
            foreach (string file in Directory.GetFiles(filePath, "*.bbg"))
            {
                byte[] searchSequence = new byte[] { 0x64, 0x00, 0x64, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

                using (FileStream stream = new FileStream(file, FileMode.Open))
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    long position = 0;
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        byte b = reader.ReadByte();
                        if (b == searchSequence[position])
                        {
                            position++;
                            if (position == searchSequence.Length)
                            {
                                // Sequence found
                                long endPosition = reader.BaseStream.Position;

                                // Write new data to file
                                stream.Seek(endPosition, SeekOrigin.Begin);
                                Windt2DataWrite(stream);
                                break;
                            }
                        }
                        else
                        {
                            position = 0;
                        }
                    }
                }

            }
        }

        private static void WindtDataWrite(FileStream stream)
        {
            foreach (var value in MoveAndMagicStats.MoveAndStatDictionary.Keys)
            {
                Dictionary<string, string> innerDictionary = MoveAndMagicStats.MoveAndStatDictionary[value];

                stream.ReadByte();
                stream.ReadByte();

                var MP_SP = ByteConverterClass.Int16ToBytes(innerDictionary["MP_SP"]);
                stream.Write(MP_SP, 0, MP_SP.Length);

                var CastSpeed = ByteConverterClass.Int16ToBytes(innerDictionary["CastSpeed"]);
                stream.Write(CastSpeed, 0, CastSpeed.Length);

                var IpPower = ByteConverterClass.Int16ToBytes(innerDictionary["IpPower"]);
                stream.Write(IpPower, 0, IpPower.Length);

                var Power = ByteConverterClass.Int16ToBytes(innerDictionary["Power"]);
                stream.Write(Power, 0, Power.Length);

                var Target = ByteConverterClass.IntToByte(innerDictionary["Target"]);
                stream.Write(Target, 0, Target.Length);

                stream.ReadByte();

                var XP = ByteConverterClass.IntToByte(innerDictionary["XP"]);
                stream.Write(XP, 0, XP.Length);

                var AreaRange = ByteConverterClass.IntToByte(innerDictionary["AreaRange"]);
                stream.Write(AreaRange, 0, AreaRange.Length);

                var Elemental = ByteConverterClass.IntToByte(innerDictionary["Elemental"]);
                stream.Write(Elemental, 0, Elemental.Length);

                stream.ReadByte();

                var Move = ByteConverterClass.IntToByte(innerDictionary["Move"]);
                stream.Write(Move, 0, Move.Length);

                var CriticalPourcent = ByteConverterClass.IntToByte(innerDictionary["CriticalPourcent"]);
                stream.Write(CriticalPourcent, 0, CriticalPourcent.Length);

                var EffectType = ByteConverterClass.IntToByte(innerDictionary["EffectType"]);
                stream.Write(EffectType, 0, EffectType.Length);

                var Mode = ByteConverterClass.IntToByte(innerDictionary["Mode"]);
                stream.Write(Mode, 0, Mode.Length);

                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
                stream.ReadByte();
            }
        }

        private static void Windt2DataWrite(FileStream stream)
        {
            foreach (var value in MoveAndMagicStats.MoveAndStatDictionary.Keys)
            {
                Dictionary<string, string> innerDictionary = MoveRequirementStats.MoveRequirementDictionary[value];

                var Requirement1 = ByteConverterClass.IntToByte(innerDictionary["Requirement1"]);
                stream.Write(Requirement1, 0, Requirement1.Length);

                var LV1 = ByteConverterClass.IntToByte(innerDictionary["LV1"]);
                stream.Write(LV1, 0, LV1.Length);

                var Requirement2 = ByteConverterClass.IntToByte(innerDictionary["Requirement2"]);
                stream.Write(Requirement2, 0, Requirement2.Length);

                var LV2 = ByteConverterClass.IntToByte(innerDictionary["LV2"]);
                stream.Write(LV2, 0, LV2.Length);

                var Requirement3 = ByteConverterClass.IntToByte(innerDictionary["Requirement3"]);
                stream.Write(Requirement3, 0, Requirement3.Length);

                var LV3 = ByteConverterClass.IntToByte(innerDictionary["LV3"]);
                stream.Write(LV3, 0, LV3.Length);

                var Who = ByteConverterClass.IntToByte(innerDictionary["Who"]);
                stream.Write(Who, 0, Who.Length);
            }
        }
    }
}
