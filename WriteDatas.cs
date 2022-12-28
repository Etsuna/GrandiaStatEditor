using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandiaReduxMaker
{
    public class WriteDatas
    {
        public static void WriteMdat(string path, string setPosition, Dictionary<string, string> dataList)
        {
            var filePath = Path.Combine(path, "M_DAT.BIN");

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

                var Walk = ByteConverterClass.IntToByte(dataList["Walk"]);
                stream.Write(Walk, 0, Walk.Length);

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

                        var AtkWalk = ByteConverterClass.IntToByte(dataList[$"AtkWalk_{i}"]);
                        stream.Write(AtkWalk, 0, AtkWalk.Length);

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
                        i++;
                    }
                };
            }
        }
    }
}
