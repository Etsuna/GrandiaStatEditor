using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace GrandiaStatEditor
{
    public class ImportToPSXImageClass
    {
        public static void ImportToPSXImage(string path, string imagePath, string cd)
        {
            byte[] exeFileBytes = Properties.Resources.psx_mode2_en;

            // Write the EXE file to a temporary location on the filesystem
            string tempPath = Path.GetTempFileName();
            File.WriteAllBytes(tempPath, exeFileBytes);

            // Use the EXE file like in the previous example
            string exeFile = tempPath;
            List<string> listToUse = new List<string>();

            switch (cd)
            {
                case "CD1":
                    listToUse = FileListCD1(path, imagePath);
                    break;
                case "CD2":
                    listToUse = FileListCD2(path, imagePath);
                    break;
                default:
                    break;
            }


            foreach(var argument in listToUse)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = exeFile,
                    Arguments = argument,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                };

                Console.WriteLine(argument);
               
                Process process = new Process
                {
                    
                    StartInfo = startInfo
                };
                
                process.Start();
                process.WaitForExit();

                string output = process.StandardOutput.ReadToEnd();
                Console.WriteLine(output);
            }
        }

        public static List<string> FileListCD1(string path, string imagePath)
        {
            return new List<string>()
            {
                $@"""{imagePath}"" \BATLE\B001.BBG ""{Path.Combine(path, "PS", "BATLE", "B001.BBG")}""",
                $@"""{imagePath}"" \BATLE\B002.BBG ""{Path.Combine(path, "PS", "BATLE", "B002.BBG")}""",
                $@"""{imagePath}"" \BATLE\B003.BBG ""{Path.Combine(path, "PS", "BATLE", "B003.BBG")}""",
                $@"""{imagePath}"" \BATLE\B004.BBG ""{Path.Combine(path, "PS", "BATLE", "B004.BBG")}""",
                $@"""{imagePath}"" \BATLE\B005.BBG ""{Path.Combine(path, "PS", "BATLE", "B005.BBG")}""",
                $@"""{imagePath}"" \BATLE\B006.BBG ""{Path.Combine(path, "PS", "BATLE", "B006.BBG")}""",
                $@"""{imagePath}"" \BATLE\B007.BBG ""{Path.Combine(path, "PS", "BATLE", "B007.BBG")}""",
                $@"""{imagePath}"" \BATLE\B008.BBG ""{Path.Combine(path, "PS", "BATLE", "B008.BBG")}""",
                $@"""{imagePath}"" \BATLE\B009.BBG ""{Path.Combine(path, "PS", "BATLE", "B009.BBG")}""",
                $@"""{imagePath}"" \BATLE\B010.BBG ""{Path.Combine(path, "PS", "BATLE", "B010.BBG")}""",
                $@"""{imagePath}"" \BATLE\B011.BBG ""{Path.Combine(path, "PS", "BATLE", "B011.BBG")}""",
                $@"""{imagePath}"" \BATLE\B012.BBG ""{Path.Combine(path, "PS", "BATLE", "B012.BBG")}""",
                $@"""{imagePath}"" \BATLE\B013.BBG ""{Path.Combine(path, "PS", "BATLE", "B013.BBG")}""",
                $@"""{imagePath}"" \BATLE\B014.BBG ""{Path.Combine(path, "PS", "BATLE", "B014.BBG")}""",
                $@"""{imagePath}"" \BATLE\B015.BBG ""{Path.Combine(path, "PS", "BATLE", "B015.BBG")}""",
                $@"""{imagePath}"" \BATLE\B018.BBG ""{Path.Combine(path, "PS", "BATLE", "B018.BBG")}""",
                $@"""{imagePath}"" \BATLE\B019.BBG ""{Path.Combine(path, "PS", "BATLE", "B019.BBG")}""",
                $@"""{imagePath}"" \BATLE\B020.BBG ""{Path.Combine(path, "PS", "BATLE", "B020.BBG")}""",
                $@"""{imagePath}"" \BATLE\B021.BBG ""{Path.Combine(path, "PS", "BATLE", "B021.BBG")}""",
                $@"""{imagePath}"" \BATLE\B022.BBG ""{Path.Combine(path, "PS", "BATLE", "B022.BBG")}""",
                $@"""{imagePath}"" \BATLE\B023.BBG ""{Path.Combine(path, "PS", "BATLE", "B023.BBG")}""",
                $@"""{imagePath}"" \BATLE\B024.BBG ""{Path.Combine(path, "PS", "BATLE", "B024.BBG")}""",
                $@"""{imagePath}"" \BATLE\B025.BBG ""{Path.Combine(path, "PS", "BATLE", "B025.BBG")}""",
                $@"""{imagePath}"" \BATLE\B027.BBG ""{Path.Combine(path, "PS", "BATLE", "B027.BBG")}""",
                $@"""{imagePath}"" \BATLE\B028.BBG ""{Path.Combine(path, "PS", "BATLE", "B028.BBG")}""",
                $@"""{imagePath}"" \BATLE\B029.BBG ""{Path.Combine(path, "PS", "BATLE", "B029.BBG")}""",
                $@"""{imagePath}"" \BATLE\B030.BBG ""{Path.Combine(path, "PS", "BATLE", "B030.BBG")}""",
                $@"""{imagePath}"" \BATLE\B031.BBG ""{Path.Combine(path, "PS", "BATLE", "B031.BBG")}""",
                $@"""{imagePath}"" \BATLE\B032.BBG ""{Path.Combine(path, "PS", "BATLE", "B032.BBG")}""",
                $@"""{imagePath}"" \BATLE\B033.BBG ""{Path.Combine(path, "PS", "BATLE", "B033.BBG")}""",
                $@"""{imagePath}"" \BATLE\B034.BBG ""{Path.Combine(path, "PS", "BATLE", "B034.BBG")}""",
                $@"""{imagePath}"" \BATLE\B035.BBG ""{Path.Combine(path, "PS", "BATLE", "B035.BBG")}""",
                $@"""{imagePath}"" \BATLE\B036.BBG ""{Path.Combine(path, "PS", "BATLE", "B036.BBG")}""",
                $@"""{imagePath}"" \BATLE\B037.BBG ""{Path.Combine(path, "PS", "BATLE", "B037.BBG")}""",
                $@"""{imagePath}"" \BATLE\B038.BBG ""{Path.Combine(path, "PS", "BATLE", "B038.BBG")}""",
                $@"""{imagePath}"" \BATLE\B094.BBG ""{Path.Combine(path, "PS", "BATLE", "B094.BBG")}""",
                $@"""{imagePath}"" \BATLE\B097.BBG ""{Path.Combine(path, "PS", "BATLE", "B097.BBG")}""",
                $@"""{imagePath}"" \BATLE\B098.BBG ""{Path.Combine(path, "PS", "BATLE", "B098.BBG")}""",
                $@"""{imagePath}"" \BATLE\B102.BBG ""{Path.Combine(path, "PS", "BATLE", "B102.BBG")}""",
                $@"""{imagePath}"" \BATLE\B120.BBG ""{Path.Combine(path, "PS", "BATLE", "B120.BBG")}""",
                $@"""{imagePath}"" \BATLE\B122.BBG ""{Path.Combine(path, "PS", "BATLE", "B122.BBG")}""",
                $@"""{imagePath}"" \BATLE\B123.BBG ""{Path.Combine(path, "PS", "BATLE", "B123.BBG")}""",
                $@"""{imagePath}"" \BATLE\M_DAT.BIN ""{Path.Combine(path, "PS", "BATLE", "M_DAT.BIN")}""",
                $@"""{imagePath}"" \FIELD\WINDT.BIN ""{Path.Combine(path, "PS", "FIELD", "WINDT.BIN")}""",
                $@"""{imagePath}"" \BIN\MCHAR.DAT ""{Path.Combine(path, "PS", "BIN", "MCHAR.DAT")}""",
            };
        }

        public static List<string> FileListCD2(string path, string imagePath)
        {
            return new List<string>()
            {
                $@"""{imagePath}"" \BATLE\B039.BBG ""{Path.Combine(path, "PS", "BATLE", "B039.BBG")}""",
                $@"""{imagePath}"" \BATLE\B040.BBG ""{Path.Combine(path, "PS", "BATLE", "B040.BBG")}""",
                $@"""{imagePath}"" \BATLE\B041.BBG ""{Path.Combine(path, "PS", "BATLE", "B041.BBG")}""",
                $@"""{imagePath}"" \BATLE\B042.BBG ""{Path.Combine(path, "PS", "BATLE", "B042.BBG")}""",
                $@"""{imagePath}"" \BATLE\B043.BBG ""{Path.Combine(path, "PS", "BATLE", "B043.BBG")}""",
                $@"""{imagePath}"" \BATLE\B044.BBG ""{Path.Combine(path, "PS", "BATLE", "B044.BBG")}""",
                $@"""{imagePath}"" \BATLE\B046.BBG ""{Path.Combine(path, "PS", "BATLE", "B046.BBG")}""",
                $@"""{imagePath}"" \BATLE\B047.BBG ""{Path.Combine(path, "PS", "BATLE", "B047.BBG")}""",
                $@"""{imagePath}"" \BATLE\B049.BBG ""{Path.Combine(path, "PS", "BATLE", "B049.BBG")}""",
                $@"""{imagePath}"" \BATLE\B050.BBG ""{Path.Combine(path, "PS", "BATLE", "B050.BBG")}""",
                $@"""{imagePath}"" \BATLE\B051.BBG ""{Path.Combine(path, "PS", "BATLE", "B051.BBG")}""",
                $@"""{imagePath}"" \BATLE\B052.BBG ""{Path.Combine(path, "PS", "BATLE", "B052.BBG")}""",
                $@"""{imagePath}"" \BATLE\B053.BBG ""{Path.Combine(path, "PS", "BATLE", "B053.BBG")}""",
                $@"""{imagePath}"" \BATLE\B054.BBG ""{Path.Combine(path, "PS", "BATLE", "B054.BBG")}""",
                $@"""{imagePath}"" \BATLE\B055.BBG ""{Path.Combine(path, "PS", "BATLE", "B055.BBG")}""",
                $@"""{imagePath}"" \BATLE\B056.BBG ""{Path.Combine(path, "PS", "BATLE", "B056.BBG")}""",
                $@"""{imagePath}"" \BATLE\B057.BBG ""{Path.Combine(path, "PS", "BATLE", "B057.BBG")}""",
                $@"""{imagePath}"" \BATLE\B058.BBG ""{Path.Combine(path, "PS", "BATLE", "B058.BBG")}""",
                $@"""{imagePath}"" \BATLE\B059.BBG ""{Path.Combine(path, "PS", "BATLE", "B059.BBG")}""",
                $@"""{imagePath}"" \BATLE\B060.BBG ""{Path.Combine(path, "PS", "BATLE", "B060.BBG")}""",
                $@"""{imagePath}"" \BATLE\B061.BBG ""{Path.Combine(path, "PS", "BATLE", "B061.BBG")}""",
                $@"""{imagePath}"" \BATLE\B062.BBG ""{Path.Combine(path, "PS", "BATLE", "B062.BBG")}""",
                $@"""{imagePath}"" \BATLE\B063.BBG ""{Path.Combine(path, "PS", "BATLE", "B063.BBG")}""",
                $@"""{imagePath}"" \BATLE\B064.BBG ""{Path.Combine(path, "PS", "BATLE", "B064.BBG")}""",
                $@"""{imagePath}"" \BATLE\B065.BBG ""{Path.Combine(path, "PS", "BATLE", "B065.BBG")}""",
                $@"""{imagePath}"" \BATLE\B066.BBG ""{Path.Combine(path, "PS", "BATLE", "B066.BBG")}""",
                $@"""{imagePath}"" \BATLE\B067.BBG ""{Path.Combine(path, "PS", "BATLE", "B067.BBG")}""",
                $@"""{imagePath}"" \BATLE\B068.BBG ""{Path.Combine(path, "PS", "BATLE", "B068.BBG")}""",
                $@"""{imagePath}"" \BATLE\B069.BBG ""{Path.Combine(path, "PS", "BATLE", "B069.BBG")}""",
                $@"""{imagePath}"" \BATLE\B070.BBG ""{Path.Combine(path, "PS", "BATLE", "B070.BBG")}""",
                $@"""{imagePath}"" \BATLE\B071.BBG ""{Path.Combine(path, "PS", "BATLE", "B071.BBG")}""",
                $@"""{imagePath}"" \BATLE\B072.BBG ""{Path.Combine(path, "PS", "BATLE", "B072.BBG")}""",
                $@"""{imagePath}"" \BATLE\B073.BBG ""{Path.Combine(path, "PS", "BATLE", "B073.BBG")}""",
                $@"""{imagePath}"" \BATLE\B074.BBG ""{Path.Combine(path, "PS", "BATLE", "B074.BBG")}""",
                $@"""{imagePath}"" \BATLE\B075.BBG ""{Path.Combine(path, "PS", "BATLE", "B075.BBG")}""",
                $@"""{imagePath}"" \BATLE\B076.BBG ""{Path.Combine(path, "PS", "BATLE", "B076.BBG")}""",
                $@"""{imagePath}"" \BATLE\B077.BBG ""{Path.Combine(path, "PS", "BATLE", "B077.BBG")}""",
                $@"""{imagePath}"" \BATLE\B078.BBG ""{Path.Combine(path, "PS", "BATLE", "B078.BBG")}""",
                $@"""{imagePath}"" \BATLE\B079.BBG ""{Path.Combine(path, "PS", "BATLE", "B079.BBG")}""",
                $@"""{imagePath}"" \BATLE\B080.BBG ""{Path.Combine(path, "PS", "BATLE", "B080.BBG")}""",
                $@"""{imagePath}"" \BATLE\B081.BBG ""{Path.Combine(path, "PS", "BATLE", "B081.BBG")}""",
                $@"""{imagePath}"" \BATLE\B082.BBG ""{Path.Combine(path, "PS", "BATLE", "B082.BBG")}""",
                $@"""{imagePath}"" \BATLE\B083.BBG ""{Path.Combine(path, "PS", "BATLE", "B083.BBG")}""",
                $@"""{imagePath}"" \BATLE\B084.BBG ""{Path.Combine(path, "PS", "BATLE", "B084.BBG")}""",
                $@"""{imagePath}"" \BATLE\B085.BBG ""{Path.Combine(path, "PS", "BATLE", "B085.BBG")}""",
                $@"""{imagePath}"" \BATLE\B086.BBG ""{Path.Combine(path, "PS", "BATLE", "B086.BBG")}""",
                $@"""{imagePath}"" \BATLE\B087.BBG ""{Path.Combine(path, "PS", "BATLE", "B087.BBG")}""",
                $@"""{imagePath}"" \BATLE\B088.BBG ""{Path.Combine(path, "PS", "BATLE", "B088.BBG")}""",
                $@"""{imagePath}"" \BATLE\B089.BBG ""{Path.Combine(path, "PS", "BATLE", "B089.BBG")}""",
                $@"""{imagePath}"" \BATLE\B090.BBG ""{Path.Combine(path, "PS", "BATLE", "B090.BBG")}""",
                $@"""{imagePath}"" \BATLE\B091.BBG ""{Path.Combine(path, "PS", "BATLE", "B091.BBG")}""",
                $@"""{imagePath}"" \BATLE\B092.BBG ""{Path.Combine(path, "PS", "BATLE", "B092.BBG")}""",
                $@"""{imagePath}"" \BATLE\B093.BBG ""{Path.Combine(path, "PS", "BATLE", "B093.BBG")}""",
                $@"""{imagePath}"" \BATLE\B101.BBG ""{Path.Combine(path, "PS", "BATLE", "B101.BBG")}""",
                $@"""{imagePath}"" \BATLE\B103.BBG ""{Path.Combine(path, "PS", "BATLE", "B103.BBG")}""",
                $@"""{imagePath}"" \BATLE\B104.BBG ""{Path.Combine(path, "PS", "BATLE", "B104.BBG")}""",
                $@"""{imagePath}"" \BATLE\B105.BBG ""{Path.Combine(path, "PS", "BATLE", "B105.BBG")}""",
                $@"""{imagePath}"" \BATLE\B106.BBG ""{Path.Combine(path, "PS", "BATLE", "B106.BBG")}""",
                $@"""{imagePath}"" \BATLE\B107.BBG ""{Path.Combine(path, "PS", "BATLE", "B107.BBG")}""",
                $@"""{imagePath}"" \BATLE\B109.BBG ""{Path.Combine(path, "PS", "BATLE", "B109.BBG")}""",
                $@"""{imagePath}"" \BATLE\B110.BBG ""{Path.Combine(path, "PS", "BATLE", "B110.BBG")}""",
                $@"""{imagePath}"" \BATLE\B111.BBG ""{Path.Combine(path, "PS", "BATLE", "B111.BBG")}""",
                $@"""{imagePath}"" \BATLE\B112.BBG ""{Path.Combine(path, "PS", "BATLE", "B112.BBG")}""",
                $@"""{imagePath}"" \BATLE\B113.BBG ""{Path.Combine(path, "PS", "BATLE", "B113.BBG")}""",
                $@"""{imagePath}"" \BATLE\B114.BBG ""{Path.Combine(path, "PS", "BATLE", "B114.BBG")}""",
                $@"""{imagePath}"" \BATLE\B115.BBG ""{Path.Combine(path, "PS", "BATLE", "B115.BBG")}""",
                $@"""{imagePath}"" \BATLE\B116.BBG ""{Path.Combine(path, "PS", "BATLE", "B116.BBG")}""",
                $@"""{imagePath}"" \BATLE\B117.BBG ""{Path.Combine(path, "PS", "BATLE", "B117.BBG")}""",
                $@"""{imagePath}"" \BATLE\B121.BBG ""{Path.Combine(path, "PS", "BATLE", "B121.BBG")}""",
                $@"""{imagePath}"" \BATLE\B124.BBG ""{Path.Combine(path, "PS", "BATLE", "B124.BBG")}""",
                $@"""{imagePath}"" \BATLE\B125.BBG ""{Path.Combine(path, "PS", "BATLE", "B125.BBG")}""",
                $@"""{imagePath}"" \BATLE\M_DAT.BIN ""{Path.Combine(path, "PS", "BATLE", "M_DAT.BIN")}""",
                $@"""{imagePath}"" \FIELD\WINDT.BIN ""{Path.Combine(path, "PS", "FIELD", "WINDT.BIN")}""",
                $@"""{imagePath}"" \BIN\MCHAR.DAT ""{Path.Combine(path, "PS", "BIN", "MCHAR.DAT")}""",
            };
        }
    }
}
