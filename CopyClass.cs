using GrandiaStatEditor.Properties;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandiaStatEditor
{
    public class CopyClass
    {
        public static void CopyFileNewProject(string path, byte[] resource)
        {
            if (File.Exists(path))
            {
                var filename = Path.GetFileName(path);
                DialogResult resultmdatTargetFile = MessageBox.Show($"The {filename} file already exists, do you want to replace it?", "Confirmation", MessageBoxButtons.YesNo);
                if (resultmdatTargetFile == DialogResult.Yes)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));

                    Task t = Task.Run(() => File.WriteAllBytes(path, resource));
                    t.Wait();

                    if (filename.Equals("windt.bin"))
                    {
                        CreateBBGFile(path);
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                var filename = Path.GetFileName(path);

                Task t = Task.Run(() => File.WriteAllBytes(path, resource));
                t.Wait();

                if (filename.Equals("windt.bin"))
                {
                    CreateBBGFile(path);
                }

            }
        }

        public static bool CopyFileLoadProject(string path, byte[] resource, bool load)
        {
            if (!File.Exists(path) && load is true)
            {
                var filename = Path.GetFileName(path);
                DialogResult resultmdatTargetFile = MessageBox.Show($"The {filename} file not exists, do you want to create it?", "Confirmation", MessageBoxButtons.YesNo);
                if (resultmdatTargetFile == DialogResult.Yes)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));

                    Task t = Task.Run(() => File.WriteAllBytes(path, resource));
                    t.Wait();

                    if (filename.Equals("windt.bin"))
                    {
                        CreateBBGFile(path);
                    }
                }
                else
                {
                    load = false;
                }
            }
            return load;
        }

        private static void CreateBBGFile(string path)
        {
            var folderPath = Path.GetDirectoryName(path);
            folderPath = Path.Combine(folderPath, "..", "BATLE");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            PropertyInfo[] properties = typeof(Resources).GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (PropertyInfo property in properties)
            {
                if (property.Name.StartsWith("B") && int.TryParse(property.Name.Substring(1), out int num) && num >= 1 && num <= 125)
                {
                    byte[] fileContent = (byte[])property.GetValue(null, null);
                    string fileName = property.Name + ".BBG";
                    string targetFilePath = Path.Combine(folderPath, fileName);
                    File.WriteAllBytes(targetFilePath, fileContent);
                }
            }
        }
    }
}
