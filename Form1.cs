using GrandiaReduxMaker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private void TextBox_Resist_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text) + 7;

            if (result < 0 || result > 14)
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between -7 to 7", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveButton.Enabled = true;
            textBox.BackColor = Color.White;
        }
        private void TextBox_0to3_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 3)
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 to 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to4_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 4)
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 to 4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to7_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 7)
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 to 7", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to99_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 99)
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 to 99", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to100_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 100)
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 to 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to255_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 255)
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 to 255", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to999_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 999)
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 to 999", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to9999_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 9999)
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 to 9999", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to12800_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 12800)
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 to 12800", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to32767_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 32767)
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 to 32767", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to65535_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 65535)
            {
                SaveButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 to 65535", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveButton.Enabled = true;
            textBox.BackColor = Color.White;
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
            groupBox.Location = new Point(10 + xGroupPosition, 30 + yGroupPosition);
            groupBox.AutoSize = true;
            this.tabPage1.Controls.Add(groupBox);

            foreach (var item in list)
            {
                // Create labels and textboxes for the stats and add them to the stats group box
                Label label = new Label();
                label.Name = $"{item}Label";
                label.Text = item;
                label.Location = new Point(10, 20 + y);
                label.Size = new Size(100 - x, 20);
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
                            break;
                    }
                    comboBox.Name = $"{item}ComboBox";
                    comboBox.ValueMember = "Value";
                    comboBox.DisplayMember = "Text";
                    comboBox.Location = new Point(100, 20 + y);
                    comboBox.Size = new Size(100, 20);
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
                        case "MagicBlockResist":
                        case "MoveBlockResist":
                        case "PlagueResist":
                        case "PoisonResist":
                        case "ParalysisResist":
                        case "SleepResist":
                        case "ConfusionResist":
                        case "CriticalResist":
                        case "FireResist":
                        case "WaterResist":
                        case "WindResist":
                        case "EarthResist":
                            textBox.TextChanged += new EventHandler(TextBox_Resist_TextChanged);
                            break;
                        case "AntiIp":
                            textBox.TextChanged += new EventHandler(TextBox_0to3_TextChanged);
                            break;
                        case "CallNumber":
                            textBox.TextChanged += new EventHandler(TextBox_0to4_TextChanged);
                            break;
                        case "KBAttack":
                        case "AntiKB":
                        case "Ext_Atk":
                            textBox.TextChanged += new EventHandler(TextBox_0to7_TextChanged);
                            break;
                        case "LV":
                        case "AttackCount":
                        case "MP1":
                        case "MP2":
                        case "MP3":
                            textBox.TextChanged += new EventHandler(TextBox_0to99_TextChanged);
                            break;
                        case "GoldPourcent":
                        case "ItemDrop1Pourcent":
                        case "ItemDrop2Pourcent":
                        case "Ext_Pourcent":
                        case "CallPourcent":
                            textBox.TextChanged += new EventHandler(TextBox_0to100_TextChanged);
                            break;
                        case "STR":
                        case "VIT":
                        case "WIT":
                        case "AGI":
                            textBox.TextChanged += new EventHandler(TextBox_0to999_TextChanged);
                            break;
                        case "AttackRange":
                        case "Walk":
                        case "SP":
                            textBox.TextChanged += new EventHandler(TextBox_0to255_TextChanged);
                            break;
                        case "HP":
                            textBox.TextChanged += new EventHandler(TextBox_0to9999_TextChanged);
                            break;
                        case "IpPower":
                            textBox.TextChanged += new EventHandler(TextBox_0to12800_TextChanged);
                            break;
                        
                        case "EXP":
                        case "GP":
                            textBox.TextChanged += new EventHandler(TextBox_0to65535_TextChanged);
                            break;
                        default:
                            break;
                    }
                    textBox.Name = $"{item}TextBox";
                    textBox.Location = new Point(100, 20 + y);
                    textBox.Size = new Size(100, 20);
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
            groupBox.Location = new Point(10 + xGroupPosition, 30 + yGroupPosition);
            groupBox.AutoSize = true;
            this.tabPage1.Controls.Add(groupBox);

            foreach (var item in list)
            {
                // Create labels and textboxes for the stats and add them to the stats group box
                Label label = new Label();
                label.Name = $"{item}_{number}_Label";
                label.Text = item;
                label.Location = new Point(10, 20 + y);
                label.Size = new Size(100 - x, 20);
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
                            break;
                    }

                    comboBox.Name = $"{item}_{number}_ComboBox";
                    comboBox.ValueMember = "Value";
                    comboBox.DisplayMember = "Text";
                    comboBox.Location = new Point(100, 20 + y);
                    comboBox.Size = new Size(100, 20);
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
                        case "KnockBack":
                        case "ExtPower":
                            textBox.TextChanged += new EventHandler(TextBox_0to7_TextChanged);
                            break;
                        case "Critical":
                        case "ExtProb":
                            textBox.TextChanged += new EventHandler(TextBox_0to100_TextChanged);
                            break;
                        case "AtkWalk":
                        case "AtkRange":
                        case "AreaRange":
                            textBox.TextChanged += new EventHandler(TextBox_0to255_TextChanged);
                            break;
                        case "IpPow":
                            textBox.TextChanged += new EventHandler(TextBox_0to12800_TextChanged);
                            break;
                        case "Power":
                            textBox.TextChanged += new EventHandler(TextBox_0to32767_TextChanged);
                            break;
                        default:
                            break;
                    }
                    textBox.Name = $"{item}_{number}_TextBox";
                    textBox.Location = new Point(100, 20 + y);
                    textBox.Size = new Size(100, 20);
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
            // Get the tabpage that contains the groups
            TabPage tabPage = tabControl1.TabPages[0];

            // Get all the controls in the tabpage
            List<Control> controls = tabPage.Controls.Cast<Control>().ToList();

            // Get the groupboxes in the tabpage
            List<GroupBox> groupBoxes = controls.OfType<GroupBox>().ToList();

            // Initialize a list to hold the textboxes and comboboxes
            List<TextBox> textBoxes = new List<TextBox>();
            List<ComboBox> comboBoxes = new List<ComboBox>();

            // Get the comboboxes in each groupbox
            foreach (GroupBox groupBox in groupBoxes.Where(x => x.Name.Contains("_GroupBox")))
            {
                comboBoxes.AddRange(groupBox.Controls.OfType<ComboBox>());
            }

            // Get the textboxes in each groupbox
            foreach (GroupBox groupBox in groupBoxes)
            {
                textBoxes.AddRange(groupBox.Controls.OfType<TextBox>().Where(x => x.Name.Contains("_TextBox")));
                comboBoxes.AddRange(groupBox.Controls.OfType<ComboBox>().Where(x => x.Name.Contains("_ComboBox")));
            }

            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedValue = -1;
                comboBox.Enabled = false;
            }

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
                textBox.Enabled = false;
                textBox.BackColor = Color.White;
            }

            var effectTypeForMode = "";
            for (int i = 1; i < 6; i++)
            {
                var values = EnemiesStats.EnemiesAttacksDictionary.Where(kvp => kvp.Key.StartsWith($"{ID}_{i}")).FirstOrDefault().Value;

                if (values != null)
                {
                    foreach (var value in values)
                    {
                        // Edit the text of the textboxes
                        foreach (TextBox textBox in textBoxes.Where(x => x.Name.Contains($"{value.Key}_")))
                        {
                            if (textBox.Name.Equals($"{value.Key}_{i}_TextBox"))
                            {
                                textBox.Text = value.Value.ToString();
                                if (textBox.Name.Contains("Attack"))
                                {
                                    textBox.Enabled = false;
                                }
                                else
                                {
                                    textBox.Enabled = true;
                                }
                            }
                        }

                        // Edit the text of the comboboxes
                        foreach (ComboBox comboBox in comboBoxes.Where(x => x.Name.Contains($"{value.Key}_")))
                        {
                            if (comboBox.Name.Equals($"EffectType_{i}_ComboBox"))
                            {
                                //keep Variable For Mode
                                effectTypeForMode = value.Value;
                                var valueParse = int.Parse(value.Value);
                                comboBox.SelectedValue = valueParse;
                                comboBox.Enabled = true;
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
                                        break;
                                }
                                var valueParse = int.Parse(value.Value);
                                comboBox.SelectedValue = valueParse;
                                comboBox.Enabled = true;
                            }

                            else if (comboBox.Name.Equals($"{value.Key}_{i}_ComboBox"))
                            {
                                var valueParse = int.Parse(value.Value);
                                comboBox.SelectedValue = valueParse;
                                comboBox.Enabled = true;
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
                            break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> GetValueToList = new Dictionary<string, string>();

            // Get the tabpage that contains the groups
            TabPage tabPage = tabControl1.TabPages[0];

            // Get all the controls in the tabpage
            List<Control> controls = tabPage.Controls.Cast<Control>().ToList();

            // Get the groupboxes in the tabpage
            List<GroupBox> groupBoxes = controls.OfType<GroupBox>().ToList();

            // Initialize a list to hold the textboxes
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

            var i = 0;
            // Edit the text of the textboxes
            foreach (TextBox textBoxe in textBoxes)
            {
                Console.WriteLine($"TextBox : {textBoxe.Name}, Value : {textBoxe.Text}");

                if (!string.IsNullOrWhiteSpace(textBoxe.Text))
                {
                    GetValueToList.Add(textBoxe.Name.Replace("_TextBox", "").Replace("TextBox", ""), textBoxe.Text);
                }
            }

            // Edit the text of the comboboxes
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.SelectedItem != null)
                {
                    GetValueToList.Add(comboBox.Name.Replace("_ComboBox", "").Replace("ComboBox", ""), comboBox.SelectedValue.ToString());
                }
            }

            using (FileStream stream = new FileStream(@"d:\AAAAAA\M_DAT2.BIN", FileMode.OpenOrCreate))
            {
                var ID = ByteConverterClass.IntToByte(GetValueToList["ID"]);

                stream.Seek(int.Parse(SetPosition.Text), SeekOrigin.Begin);
                stream.ReadByte();

                var LV = ByteConverterClass.IntToByte(GetValueToList["LV"]);
                stream.Write(LV, 0, LV.Length);

                var HP = ByteConverterClass.Int16ToBytes(GetValueToList["HP"]);
                stream.Write(HP, 0, HP.Length);

                var STR = ByteConverterClass.Int16ToBytes(GetValueToList["STR"]);
                stream.Write(STR, 0, STR.Length);

                var VIT = ByteConverterClass.Int16ToBytes(GetValueToList["VIT"]);
                stream.Write(VIT, 0, VIT.Length);

                var WIT = ByteConverterClass.Int16ToBytes(GetValueToList["WIT"]);
                stream.Write(WIT, 0, WIT.Length);

                var AGI = ByteConverterClass.Int16ToBytes(GetValueToList["AGI"]);
                stream.Write(AGI, 0, AGI.Length);

                var IpPower = ByteConverterClass.Int16ToBytes(GetValueToList["IpPower"]);
                stream.Write(IpPower, 0, IpPower.Length);

                var EXP = ByteConverterClass.Int16ToBytes(GetValueToList["EXP"]);
                stream.Write(EXP, 0, EXP.Length);

                var GP = ByteConverterClass.Int16ToBytes(GetValueToList["GP"]);
                stream.Write(GP, 0, GP.Length);

                var GoldPourcent = ByteConverterClass.IntToByte(GetValueToList["GoldPourcent"]);
                stream.Write(GoldPourcent, 0, GoldPourcent.Length);

                var Walk = ByteConverterClass.IntToByte(GetValueToList["Walk"]);
                stream.Write(Walk, 0, Walk.Length);

                var ItemDrop1 = ByteConverterClass.Int16ToBytes(GetValueToList["ItemDrop1"]);
                stream.Write(ItemDrop1, 0, ItemDrop1.Length);

                var ItemDrop2 = ByteConverterClass.Int16ToBytes(GetValueToList["ItemDrop2"]);
                stream.Write(ItemDrop2, 0, ItemDrop2.Length);

                var ItemDrop1Pourcent = ByteConverterClass.IntToByte(GetValueToList["ItemDrop1Pourcent"]);
                stream.Write(ItemDrop1Pourcent, 0, ItemDrop1Pourcent.Length);

                var ItemDrop2Pourcent = ByteConverterClass.IntToByte(GetValueToList["ItemDrop2Pourcent"]);
                stream.Write(ItemDrop2Pourcent, 0, ItemDrop2Pourcent.Length);

                var MP1 = ByteConverterClass.IntToByte(GetValueToList["MP1"]);
                stream.Write(MP1, 0, MP1.Length);

                var MP2 = ByteConverterClass.IntToByte(GetValueToList["MP2"]);
                stream.Write(MP2, 0, MP2.Length);

                var MP3 = ByteConverterClass.IntToByte(GetValueToList["MP3"]);
                stream.Write(MP3, 0, MP3.Length);

                var SP = ByteConverterClass.IntToByte(GetValueToList["SP"]);
                stream.Write(SP, 0, SP.Length);

                var SkillID1 = ByteConverterClass.IntToByte(GetValueToList["SkillID1"]);
                stream.Write(SkillID1, 0, SkillID1.Length);

                var SkillID2 = ByteConverterClass.IntToByte(GetValueToList["SkillID2"]);
                stream.Write(SkillID2, 0, SkillID2.Length);

                var SkillID3 = ByteConverterClass.IntToByte(GetValueToList["SkillID3"]);
                stream.Write(SkillID3, 0, SkillID3.Length);

                var SkillID4 = ByteConverterClass.IntToByte(GetValueToList["SkillID4"]);
                stream.Write(SkillID4, 0, SkillID4.Length);

                var AttackCount = ByteConverterClass.IntToByte(GetValueToList["AttackCount"]);
                stream.Write(AttackCount, 0, AttackCount.Length);

                var AttackRange = ByteConverterClass.IntToByte(GetValueToList["AttackRange"]);
                stream.Write(AttackRange, 0, AttackRange.Length);

                var ExternalAttackAndType = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(GetValueToList["Ext_Atk"], GetValueToList["Ext_Type"]).ToString());
                stream.Write(ExternalAttackAndType, 0, ExternalAttackAndType.Length);

                var Ext_Pourcent = ByteConverterClass.IntToByte(GetValueToList["Ext_Pourcent"]);
                stream.Write(Ext_Pourcent, 0, Ext_Pourcent.Length);

                var position = stream.Position;
                var tempRead = stream.ReadByte();
                var UnknowKnockBackAttack = ByteConverterClass.GetNibble((byte)tempRead).Item1;
                var UnknowAndKnockBackAttack = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(UnknowKnockBackAttack.ToString(), GetValueToList["KBAttack"]).ToString());
                stream.Seek(position, SeekOrigin.Begin);
                stream.Write(UnknowAndKnockBackAttack, 0, UnknowAndKnockBackAttack.Length);

                var AntiIpAndAntiKnockBack = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(GetValueToList["AntiIp"], GetValueToList["AntiKB"]).ToString());
                stream.Write(AntiIpAndAntiKnockBack, 0, AntiIpAndAntiKnockBack.Length);

                var MagicAndMoveBlockResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(GetValueToList["MagicBlockResist"], GetValueToList["MoveBlockResist"]).ToString());
                stream.Write(MagicAndMoveBlockResist, 0, MagicAndMoveBlockResist.Length);

                var PlagueAndPoisonResist = ByteConverterClass.IntToByte(ByteConverterClass.NibbleToByte(GetValueToList["PlagueResist"], GetValueToList["PoisonResist"]).ToString());
                stream.Write(PlagueAndPoisonResist, 0, PlagueAndPoisonResist.Length);
            }
        }
    }
}
