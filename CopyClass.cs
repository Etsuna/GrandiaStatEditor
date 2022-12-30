using GrandiaStatEditor.Properties;
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
                    Task t = Task.Run(() => File.WriteAllBytes(path, resource));
                    t.Wait();
                }
            }
            else
            {
                Task t = Task.Run(() => File.WriteAllBytes(path, resource));
                t.Wait();
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
                    Task t = Task.Run(() => File.WriteAllBytes(path, resource));
                    t.Wait();
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
