using System.Collections.Generic;
using System.IO;

namespace GrandiaStatEditor
{
    public class MoveRequirementStats
    {
        public static Dictionary<string, Dictionary<string, string>> MoveRequirementDictionary { get; set; } = new Dictionary<string, Dictionary<string, string>>();

        public static void ReadMoveRequirementData(string path)
        {
            string windtFilePath = Path.Combine(path, "PC", "FIELD", "windt.bin");

            long position = 0x990F;
            using (FileStream s = new FileStream(windtFilePath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(s))
            {
                reader.BaseStream.Position = position;

                foreach (var moveAndMagic in MoveAndMagicListClass.MoveAndMagicsList())
                {
                    var listStats = new Dictionary<string, string>();
                    
                    var Requirement1 = reader.ReadByte();
                    var LV1 = reader.ReadByte();
                    var Requirement2 = reader.ReadByte();
                    var LV2 = reader.ReadByte();
                    var Requirement3 = reader.ReadByte();
                    var LV3 = reader.ReadByte();
                    var Who= reader.ReadByte();

                    listStats.Add("Requirement1", Requirement1.ToString());
                    listStats.Add("LV1", LV1.ToString());
                    listStats.Add("Requirement2", Requirement2.ToString());
                    listStats.Add("LV2", LV2.ToString());
                    listStats.Add("Requirement3", Requirement3.ToString());
                    listStats.Add("LV3", LV3.ToString());
                    listStats.Add("Who", Who.ToString());

                    MoveRequirementDictionary.Add(moveAndMagic.Text, listStats);
                };
            }
        }
    }
}
