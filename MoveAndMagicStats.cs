using System.Collections.Generic;
using System.IO;

namespace GrandiaStatEditor
{
    public class MoveAndMagicStats
    {
        public static Dictionary<string, Dictionary<string, string>> MoveAndStatDictionary { get; set; } = new Dictionary<string, Dictionary<string, string>>();

        public static void ReadMoveAndMagicData(string path)
        {
            string windtFilePath = Path.Combine(path, "windt.bin");

            long position = 0x8D08;
            using (FileStream s = new FileStream(windtFilePath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(s))
            {
                reader.BaseStream.Position = position;

                foreach (var moveAndMagic in MoveAndMagicListClass.MoveAndMagicsList())
                {
                    var listStats = new Dictionary<string, string>();
                    
                    var ID = reader.ReadByte();
                    var ID2 = reader.ReadByte();
                    var MP = reader.ReadInt16();
                    var CastSpeed = reader.ReadInt16();
                    var IpPower = reader.ReadInt16();
                    var Power = reader.ReadInt16();
                    var Target = reader.ReadByte();
                    var ExtCom = reader.ReadByte();
                    var Xp = reader.ReadByte();
                    var AreaRange = reader.ReadByte();
                    var Elemental = reader.ReadByte();
                    var Weapon = reader.ReadByte();
                    var Walk = reader.ReadByte();
                    var CriticalPourcent = reader.ReadByte();
                    var EffectType = reader.ReadByte();
                    var Mode = reader.ReadByte();
                    var AnimationMove = reader.ReadByte();
                    var OutType = reader.ReadByte();
                    var IC = reader.ReadByte();
                    var Unknow = reader.ReadByte();

                    listStats.Add("MP", MP.ToString());
                    listStats.Add("CastSpeed", CastSpeed.ToString());
                    listStats.Add("IpPower", IpPower.ToString());
                    listStats.Add("Power", Power.ToString());
                    listStats.Add("Target", Target.ToString());
                    listStats.Add("Xp", Xp.ToString());
                    listStats.Add("AreaRange", AreaRange.ToString());
                    listStats.Add("Elemental", Elemental.ToString());
                    listStats.Add("Walk", Walk.ToString());
                    listStats.Add("CriticalPourcent", CriticalPourcent.ToString());
                    listStats.Add("EffectType", EffectType.ToString());
                    listStats.Add("Mode", Mode.ToString());

                    MoveAndStatDictionary.Add(moveAndMagic.Text, listStats);
                };
            }

        }

    }
}
