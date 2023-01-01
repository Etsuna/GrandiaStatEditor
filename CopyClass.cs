using System.IO;
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

                    if(filename.Equals("windt.bin"))
                    {
                        var folderPath = Path.GetDirectoryName(path);
                        folderPath = Path.Combine("..", "BATLE");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        foreach (string file in Directory.GetFiles("Resources", "*.bbg"))
                        {
                            File.Copy(file, Path.Combine(folderPath, Path.GetFileName(file)), true);
                        }
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
                    var folderPath = Path.GetDirectoryName(path);
                    folderPath = Path.Combine(folderPath, "..", "BATLE");
                    if(!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    foreach (string file in Directory.GetFiles("Resources", "*.bbg"))
                    {
                        File.Copy(file, Path.Combine(folderPath, Path.GetFileName(file)), true);
                    }
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
                        var folderPath = Path.GetDirectoryName(path);
                        folderPath = Path.Combine("..", "BATLE");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        foreach (string file in Directory.GetFiles("Resources", "*.bbg"))
                        {
                            File.Copy(file, Path.Combine(folderPath, Path.GetFileName(file)), true);
                        }
                    }
                }
                else
                {
                    load = false;
                }
            }
            return load;
        }
    }
}
