using GrandiaReduxMaker.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GrandiaReduxMaker
{
    public partial class Form1 : Form
    {
        public static int ValueKey { get; set; }

        public static int CountInList { get; set; }

        public int Count { get; set; } = 0;

        public string SelectedFolder { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Text = char.ConvertFromUtf32(0x2190);
            button2.Text = char.ConvertFromUtf32(0x2192);
            button1.Enabled = false;
            button2.Enabled = false;

            LoadProjectDev();
        }

        private void EffectType_1_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMode(1);
        }

        private void EffectType_2_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMode(2);
        }
        private void EffectType_3_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMode(3);
        }
        private void EffectType_4_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMode(4);
        }
        private void EffectType_5_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeMode(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Count--;

            if (Count is 0)
            {
                button1.Enabled = false;
            }

            if (Count < CountInList)
            {
                button2.Enabled = true;
            }

            var res = EnemiesStats.EnemiesStatsDictionary.TakeWhile(k => k.Key != ValueKey).Last();
            UpdateValue(res);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Count++;

            if (Count > 0)
            {
                button1.Enabled = true;
            }

            if (Count >= CountInList - 1)
            {
                button2.Enabled = false;
            }

            var res = EnemiesStats.EnemiesStatsDictionary.SkipWhile(k => k.Key != ValueKey).Skip(1).FirstOrDefault();
            UpdateValue(res);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SetPosition_Click(object sender, EventArgs e)
        {
            string labelText = SetPosition.Text;
            Clipboard.SetText(labelText);
        }

        public void changeLabelText(string text)
        {
            this.SetPosition.Text = text;
        }

        public void SetForm(List<string> list, string groupeName, int xGroupPosition, int yGroupPosition)
        {
            var y = 0;
            var x = 10;

            // Create a group box for the stats and add it to the form
            GroupBox groupBox = new GroupBox();
            groupBox.Name = $"{groupeName}GroupBox";
            groupBox.Text = groupeName;
            groupBox.Location = new System.Drawing.Point(10 + xGroupPosition, 30 + yGroupPosition);
            groupBox.AutoSize = true;
            this.tabPage1.Controls.Add(groupBox);

            foreach (var item in list)
            {
                // Create labels and textboxes for the stats and add them to the stats group box
                Label label = new Label();
                label.Name = $"{item}Label";
                label.Text = item;
                label.Location = new System.Drawing.Point(10, 20 + y);
                label.Size = new System.Drawing.Size(100 - x, 20);
                groupBox.Controls.Add(label);

                if (item.Equals("Ext_Type") || item.Equals("ItemDrop1") || item.Equals("ItemDrop2") || item.Equals("CallID") || item.Equals("SkillID1") || item.Equals("SkillID2") || item.Equals("SkillID3") || item.Equals("SkillID4"))
                {
                    ComboBox comboBox = new ComboBox();
                    switch (item)
                    {
                        case "Ext_Type":
                            comboBox.DataSource = ComboBoxList.ExternalTypeList();
                            break;
                        case "ItemDrop1":
                        case "ItemDrop2":
                            comboBox.DataSource = ItemListClass.ItemDropList();
                            break;
                        case "CallID":
                            comboBox.DataSource = ComboBoxList.EnemieIDList();
                            break;
                        case "SkillID1":
                        case "SkillID2":
                        case "SkillID3":
                        case "SkillID4":
                            comboBox.DataSource = SkillClass.SkillList();
                            break;
                        default:
                            Console.WriteLine("Invalid selection.");
                            break;
                    }
                    comboBox.Name = $"{item}ComboBox";
                    comboBox.ValueMember = "Value";
                    comboBox.DisplayMember = "Text";
                    comboBox.Location = new System.Drawing.Point(100, 20 + y);
                    comboBox.Size = new System.Drawing.Size(100, 20);
                    groupBox.Controls.Add(comboBox);
                }
                else
                {
                    TextBox textBox = new TextBox();
                    switch (item)
                    {
                        case "ID":
                            textBox.Enabled = false;
                            break;
                        case "NameQuarter":
                            textBox.Enabled = false;
                            break;
                        case "NameFull":
                            textBox.Enabled = false;
                            break;
                        default:
                            Console.WriteLine("Invalid selection.");
                            break;
                    }
                    textBox.Name = $"{item}TextBox";
                    textBox.Location = new System.Drawing.Point(100, 20 + y);
                    textBox.Size = new System.Drawing.Size(100, 20);
                    groupBox.Controls.Add(textBox);
                }

                y += 30;
            }
        }

        public void SetAttackForm(List<string> list, string groupeName, int number, int xGroupPosition, int yGroupPosition)
        {
            var y = 0;
            var x = 10;

            // Create a group box for the stats and add it to the form
            GroupBox groupBox = new GroupBox();
            groupBox.Name = $"{groupeName}_{number}_GroupBox";
            groupBox.Text = groupeName;
            groupBox.Location = new System.Drawing.Point(10 + xGroupPosition, 30 + yGroupPosition);
            groupBox.AutoSize = true;
            this.tabPage1.Controls.Add(groupBox);

            foreach (var item in list)
            {
                // Create labels and textboxes for the stats and add them to the stats group box
                Label label = new Label();
                label.Name = $"{item}_{number}_Label";
                label.Text = item;
                label.Location = new System.Drawing.Point(10, 20 + y);
                label.Size = new System.Drawing.Size(100 - x, 20);
                groupBox.Controls.Add(label);

                if (item.Equals("Elemental") || item.Equals("Target") || item.Equals("EffectType") || item.Equals("StopMode") || item.Equals("Mode") || item.Equals("ExtType"))
                {
                    ComboBox comboBox = new ComboBox();
                    switch (item)
                    {
                        case "Elemental":
                            comboBox.DataSource = ComboBoxList.ElementalList();
                            break;
                        case "Target":
                            comboBox.DataSource = ComboBoxList.TargetList();
                            break;
                        case "EffectType":
                            comboBox.DataSource = ComboBoxList.EffectTypeList();
                            switch (number)
                            {
                                case 1:
                                    comboBox.SelectedIndexChanged += new EventHandler(EffectType_1_ComboBox_SelectedIndexChanged);
                                    break;
                                case 2:
                                    comboBox.SelectedIndexChanged += new EventHandler(EffectType_2_ComboBox_SelectedIndexChanged);
                                    break;
                                case 3:
                                    comboBox.SelectedIndexChanged += new EventHandler(EffectType_3_ComboBox_SelectedIndexChanged);
                                    break;
                                case 4:
                                    comboBox.SelectedIndexChanged += new EventHandler(EffectType_4_ComboBox_SelectedIndexChanged);
                                    break;
                                case 5:
                                    comboBox.SelectedIndexChanged += new EventHandler(EffectType_5_ComboBox_SelectedIndexChanged);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "StopMode":
                            comboBox.DataSource = ComboBoxList.StopModeList();
                            break;
                        case "Mode":
                            comboBox.DataSource = ModeClass.Mode0List();
                            break;
                        case "ExtType":
                            comboBox.DataSource = ComboBoxList.ExtTypeList();
                            break;
                        default:
                            Console.WriteLine("Invalid selection.");
                            break;
                    }

                    comboBox.Name = $"{item}_{number}_ComboBox";
                    comboBox.ValueMember = "Value";
                    comboBox.DisplayMember = "Text";
                    comboBox.Location = new System.Drawing.Point(100, 20 + y);
                    comboBox.Size = new System.Drawing.Size(100, 20);
                    groupBox.Controls.Add(comboBox);

                }
                else
                {
                    TextBox textBox = new TextBox();
                    switch (item)
                    {
                        case "AttackQuarter":
                            textBox.Enabled = false;
                            break;
                        case "AttackFull":
                            textBox.Enabled = false;
                            break;
                        default:
                            Console.WriteLine("Invalid selection.");
                            break;
                    }
                    textBox.Name = $"{item}_{number}_TextBox";
                    textBox.Location = new System.Drawing.Point(100, 20 + y);
                    textBox.Size = new System.Drawing.Size(100, 20);
                    groupBox.Controls.Add(textBox);

                }

                y += 30;
            }
        }

        public void UpdateValue(KeyValuePair<int, Dictionary<string, string>> FirstValue)
        {
            ValueKey = FirstValue.Key;
            changeLabelText(ValueKey.ToString());

            // Get the tabpage that contains the groups
            TabPage tabPage = tabControl1.TabPages[0];

            // Get all the controls in the tabpage
            List<Control> controls = tabPage.Controls.Cast<Control>().ToList();

            // Get the groupboxes in the tabpage
            List<GroupBox> groupBoxes = controls.OfType<GroupBox>().ToList();

            // Initialize a list to hold the textboxes
            List<TextBox> textBoxes = new List<TextBox>();
            List<ComboBox> comboBoxes = new List<ComboBox>();

            foreach (var value in FirstValue.Value)
            {
                // Get the textboxes in each groupbox
                foreach (GroupBox groupBox in groupBoxes)
                {
                    textBoxes.AddRange(groupBox.Controls.OfType<TextBox>());
                }

                // Get the comboboxes in each groupbox
                foreach (GroupBox groupBox in groupBoxes)
                {
                    comboBoxes.AddRange(groupBox.Controls.OfType<ComboBox>());
                }

                // Edit the text of the textboxes
                foreach (TextBox textBox in textBoxes)
                {
                    if (textBox.Name.Equals($"{value.Key}TextBox"))
                    {
                        textBox.Text = value.Value.ToString();

                        if (textBox.Name.Equals("IDTextBox"))
                        {
                            UpdateAttackValue(value.Value);
                        }
                    }
                }

                // Edit the text of the comboboxes
                foreach (ComboBox comboBox in comboBoxes)
                {
                    if (comboBox.Name.Equals($"{value.Key}ComboBox"))
                    {
                        var valueParse = int.Parse(value.Value);
                        comboBox.SelectedValue = valueParse;
                    }
                }
            }
        }

        public void UpdateAttackValue(string ID)
        {
            var effectTypeForMode = "";
            for (int i = 1; i < 6; i++)
            {
                var values = EnemiesStats.EnemiesAttacksDictionary.Where(kvp => kvp.Key.StartsWith($"{ID}_{i}")).FirstOrDefault().Value;

                // Get the tabpage that contains the groups
                TabPage tabPage = tabControl1.TabPages[0];

                // Get all the controls in the tabpage
                List<Control> controls = tabPage.Controls.Cast<Control>().ToList();

                // Get the groupboxes in the tabpage
                List<GroupBox> groupBoxes = controls.OfType<GroupBox>().ToList();

                // Initialize a list to hold the textboxes and comboboxes
                List<TextBox> textBoxes = new List<TextBox>();
                List<ComboBox> comboBoxes = new List<ComboBox>();

                // Get the textboxes in each groupbox
                foreach (GroupBox groupBox in groupBoxes)
                {
                    textBoxes.AddRange(groupBox.Controls.OfType<TextBox>());
                }

                // Get the comboboxes in each groupbox
                foreach (GroupBox groupBox in groupBoxes)
                {
                    comboBoxes.AddRange(groupBox.Controls.OfType<ComboBox>());
                }

                if (values != null)
                {
                    foreach (var value in values)
                    {
                        // Edit the text of the textboxes
                        foreach (TextBox textBox in textBoxes.Where(x => x.Name.Contains($"{value.Key}_")))
                        {
                            if (i is 1)
                            {
                                textBox.Clear();

                                if (textBox.Name.Equals($"{value.Key}_{i + 1}_TextBox"))
                                {
                                    textBox.Clear();
                                }
                                else if (textBox.Name.Equals($"{value.Key}_{i + 2}_TextBox"))
                                {
                                    textBox.Clear();
                                }
                                else if(textBox.Name.Equals($"{value.Key}_{i + 3}_TextBox"))
                                {
                                    textBox.Clear();
                                }
                                else if(textBox.Name.Equals($"{value.Key}_{i + 4}_TextBox"))
                                {
                                    textBox.Clear();
                                }
                            }

                            if (textBox.Name.Equals($"{value.Key}_{i}_TextBox"))
                            {
                                textBox.Text = value.Value.ToString();
                            }

                        }

                        // Edit the text of the comboboxes
                        foreach (ComboBox comboBox in comboBoxes.Where(x => x.Name.Contains($"{value.Key}_")))
                        {
                            if (i is 1)
                            {
                                comboBox.SelectedIndex = -1;

                                if (comboBox.Name.Equals($"{value.Key}_{i + 1}_ComboBox"))
                                {
                                    comboBox.SelectedIndex = -1;
                                }

                                if (comboBox.Name.Equals($"{value.Key}_{i + 2}_ComboBox"))
                                {
                                    comboBox.SelectedIndex = -1;
                                }

                                if (comboBox.Name.Equals($"{value.Key}_{i + 3}_ComboBox"))
                                {
                                    comboBox.SelectedIndex = -1;
                                }

                                if (comboBox.Name.Equals($"{value.Key}_{i + 4}_ComboBox"))
                                {
                                    comboBox.SelectedIndex = -1;
                                }
                            }

                            if (comboBox.Name.Equals($"EffectType_{i}_ComboBox"))
                            {
                                //keep Variable For Mode
                                effectTypeForMode = value.Value;
                                var valueParse = int.Parse(value.Value);
                                comboBox.SelectedValue = valueParse;
                            }
                            else if (comboBox.Name.Equals($"Mode_{i}_ComboBox"))
                            {
                                switch (effectTypeForMode)
                                {
                                    case "0":
                                        comboBox.DataSource = ModeClass.Mode0List();
                                        break;
                                    case "3":
                                        comboBox.DataSource = ModeClass.Mode3List();
                                        break;
                                    case "4":
                                        comboBox.DataSource = ModeClass.Mode4List();
                                        break;
                                    case "5":
                                        comboBox.DataSource = ModeClass.Mode5List();
                                        break;
                                    case "6":
                                        comboBox.DataSource = ModeClass.Mode6List();
                                        break;
                                    case "7":
                                        comboBox.DataSource = ModeClass.Mode7List();
                                        break;
                                    case "8":
                                        comboBox.DataSource = ModeClass.Mode8List();
                                        break;
                                    case "9":
                                        comboBox.DataSource = ModeClass.Mode9List();
                                        break;
                                    case "10":
                                        comboBox.DataSource = ModeClass.Mode10List();
                                        break;
                                    default:
                                        Console.WriteLine("Invalid selection.");
                                        break;
                                }
                                var valueParse = int.Parse(value.Value);
                                comboBox.SelectedValue = valueParse;
                            }

                            else if (comboBox.Name.Equals($"{value.Key}_{i}_ComboBox"))
                            {
                                var valueParse = int.Parse(value.Value);
                                comboBox.SelectedValue = valueParse;
                            }
                        }
                    }
                }
            }
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    SelectedFolder = dialog.SelectedPath;
                    var targetFile = Path.Combine(SelectedFolder, "M_DAT.BIN");
                    File.WriteAllBytes(targetFile, Resources.M_DAT);
                    FormToLoad();

                    EnemiesStats.ReadCharData(SelectedFolder);

                    CountInList = EnemiesStats.EnemiesStatsDictionary.Count();

                    var FirstValue = EnemiesStats.EnemiesStatsDictionary.FirstOrDefault();
                    UpdateValue(FirstValue);
                }
            }
        }

        public void FormToLoad()
        {
            button1.Enabled = false;
            button1.Text = char.ConvertFromUtf32(0x2190);
            button2.Text = char.ConvertFromUtf32(0x2192);
            button1.Enabled = true;
            button2.Enabled = true;

            //STATS
            var statsList = new List<string> { "NameQuarter", "NameFull", "ID", "LV", "HP", "STR", "VIT", "WIT", "AGI", "IpPower", "AttackCount", "AttackRange", "Walk" };
            var itemsList = new List<string> { "EXP", "GP", "GoldPourcent", "ItemDrop1", "ItemDrop1Pourcent", "ItemDrop2", "ItemDrop2Pourcent" };
            var ipKnock_Back = new List<string> { "AntiIp", "KBAttack", "AntiKB" };
            var magicsAndSkillsList = new List<string> { "MP1", "MP2", "MP3", "SP", "SkillID1", "SkillID2", "SkillID3", "SkillID4" };
            var AntiStatus = new List<string> { "MagicBlockResist", "MoveBlockResist", "PlagueResist", "PoisonResist", "ParalysisResist", "SleepResist", "ConfusionResist", "CriticalResist", "FireResist", "WaterResist", "WindResist", "EarthResist" };
            var ExtAttCak = new List<string> { "Ext_Atk", "Ext_Type", "Ext_Pourcent" };
            var AnotherSettings = new List<string> { "CallID", "CallNumber", "CallPourcent" };

            //ATTACKS
            var SpecialAttackName = new List<string> { "AttackQuarter", "AttackFull" };
            var AttackStatus = new List<string> { "Power", "IpPow", "Critical", "AtkWalk", "AtkRange", "KnockBack" };
            var AttackMode = new List<string> { "Target", "AreaRange", "StopMode", "EffectType", "Mode" };
            var AttackExtDamage = new List<string> { "ExtType", "ExtProb", "ExtPower" };
            var AttackElemental = new List<string> { "Elemental" };

            //STATS
            SetForm(statsList, "Status", 0, 0);
            SetForm(magicsAndSkillsList, "Magic / Skills", 0, 430);
            SetForm(itemsList, "Items", 210, 0);
            SetForm(ipKnock_Back, "IP & Knock_Back", 210, 250);
            SetForm(AntiStatus, "Resists", 210, 380);
            SetForm(AnotherSettings, "Another Settings", 420, 0);
            SetForm(ExtAttCak, "External Att Cak", 420, 130);

            var j = 0;
            
            //ATTACKS
            for (int i = 1; i < 6; i++)
            {
                SetAttackForm(SpecialAttackName, $"Special Attack Name {i}", i, 630 + j, 0);
                SetAttackForm(AttackStatus, $"Attack Status {i}", i, 630 + j, 110);
                SetAttackForm(AttackMode, $"Mode {i}", i, 630 + j, 330);
                SetAttackForm(AttackExtDamage, $"Ext Damage {i}", i, 630 + j, 520);
                SetAttackForm(AttackElemental, $"Elemental Attack {i}", i, 630 + j, 650);

                j = j + 210;
            }
        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProject();
        }

        private void LoadProject()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    SelectedFolder = dialog.SelectedPath;

                    var mdatFilePath = Path.Combine(SelectedFolder, "M_DAT.BIN");

                    if (!File.Exists(mdatFilePath))
                    {
                        MessageBox.Show("M_DAT.BIN not Found, Select a project folder or make a new one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    EnemiesStats.EnemiesStatsDictionary.Clear();
                    EnemiesStats.EnemiesAttacksDictionary.Clear();

                    Count = 0;

                    FormToLoad();
                    EnemiesStats.ReadCharData(SelectedFolder);

                    CountInList = EnemiesStats.EnemiesStatsDictionary.Count();


                    var FirstValue = EnemiesStats.EnemiesStatsDictionary.FirstOrDefault();
                    UpdateValue(FirstValue);
                }
            }
        }

        private void LoadProjectDev()
        {
            SelectedFolder = Path.Combine(@"D:\", "AAAAAA");

            var mdatFilePath = Path.Combine(SelectedFolder, "M_DAT.BIN");

            if (!File.Exists(mdatFilePath))
            {
                MessageBox.Show("M_DAT.BIN not Found, Select a project folder or make a new one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EnemiesStats.EnemiesStatsDictionary.Clear();
            EnemiesStats.EnemiesAttacksDictionary.Clear();

            Count = 0;

            FormToLoad();
            EnemiesStats.ReadCharData(SelectedFolder);

            CountInList = EnemiesStats.EnemiesStatsDictionary.Count();


            var FirstValue = EnemiesStats.EnemiesStatsDictionary.FirstOrDefault();
            UpdateValue(FirstValue);
        }

        public void ChangeMode(int i)
        {
            // Get the tabpage that contains the groups
            TabPage tabPage = tabControl1.TabPages[0];

            // Get all the controls in the tabpage
            List<Control> controls = tabPage.Controls.Cast<Control>().ToList();

            // Get the groupboxes in the tabpage
            List<GroupBox> groupBoxes = controls.OfType<GroupBox>().ToList();

            List<ComboBox> comboBoxes = new List<ComboBox>();

            foreach (GroupBox groupBox in groupBoxes)
            {
                comboBoxes.AddRange(groupBox.Controls.OfType<ComboBox>());
            }
            var effectTypeForMode = "";

            foreach (ComboBox comboBox in comboBoxes.Where(x => x.Name.Contains($"EffectType_{i}")))
            {
                if (comboBox.SelectedValue != null)
                {
                    effectTypeForMode = comboBox.SelectedValue.ToString();
                }
            }

            if (effectTypeForMode != null)
            {
                foreach (ComboBox comboBox in comboBoxes.Where(x => x.Name.StartsWith($"Mode_{i}")))
                {
                    switch (effectTypeForMode)
                    {
                        case "0":
                            comboBox.DataSource = ModeClass.Mode0List();
                            break;
                        case "3":
                            comboBox.DataSource = ModeClass.Mode3List();
                            break;
                        case "4":
                            comboBox.DataSource = ModeClass.Mode4List();
                            break;
                        case "5":
                            comboBox.DataSource = ModeClass.Mode5List();
                            break;
                        case "6":
                            comboBox.DataSource = ModeClass.Mode6List();
                            break;
                        case "7":
                            comboBox.DataSource = ModeClass.Mode7List();
                            break;
                        case "8":
                            comboBox.DataSource = ModeClass.Mode8List();
                            break;
                        case "9":
                            comboBox.DataSource = ModeClass.Mode9List();
                            break;
                        case "10":
                            comboBox.DataSource = ModeClass.Mode10List();
                            break;
                        default:
                            Console.WriteLine("Invalid selection.");
                            break;
                    }
                }
            }
        }
    }
}
