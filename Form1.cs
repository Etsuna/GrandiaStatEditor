using GrandiaStatEditor.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GrandiaStatEditor
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
            tabControl1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = char.ConvertFromUtf32(0x2190);
            button2.Text = char.ConvertFromUtf32(0x2192);
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void NewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show($"Create a new project at this location : {dialog.SelectedPath}?", "Confirmation", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        SelectedFolder = dialog.SelectedPath;
                        var mdatTargetFile = Path.Combine(SelectedFolder, "M_DAT.BIN");
                        var mcharTargetFile = Path.Combine(SelectedFolder, "mchar.dat");
                        var windtTargetFile = Path.Combine(SelectedFolder, "windt.bin");

                        CopyClass.CopyFileNewProject(mdatTargetFile, Resources.M_DAT);
                        CopyClass.CopyFileNewProject(mcharTargetFile, Resources.mchar);
                        CopyClass.CopyFileNewProject(windtTargetFile, Resources.windt);

                        tabControl1.Visible = true;

                        ClearData();

                        Count = 0;
                        CountInList = 0;

                        ReadData();

                        CountInList = EnemiesStats.EnemiesStatsDictionary.Count();

                        var FirstValue = EnemiesStats.EnemiesStatsDictionary.FirstOrDefault();
                        FormToLoad();
                        UpdateValue(FirstValue);
                    }
                }
            }
        }

        private void LoadProject()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show($"Load project at this location : {dialog.SelectedPath}?", "Confirmation", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {

                        SelectedFolder = dialog.SelectedPath;

                        var mdatTargetFile = Path.Combine(SelectedFolder, "M_DAT.BIN");
                        var mcharTargetFile = Path.Combine(SelectedFolder, "mchar.dat");
                        var windtTargetFile = Path.Combine(SelectedFolder, "windt.bin");
                        var load = true;

                        load = CopyClass.CopyFileLoadProject(mdatTargetFile, Resources.M_DAT, load);
                        load = CopyClass.CopyFileLoadProject(mcharTargetFile, Resources.mchar, load);
                        load = CopyClass.CopyFileLoadProject(windtTargetFile, Resources.windt, load);

                        if (load)
                        {
                            tabControl1.Visible = true;
                            ClearData();

                            Count = 0;
                            CountInList = 0;

                            ReadData();
                            FormToLoad();

                            CountInList = EnemiesStats.EnemiesStatsDictionary.Count();

                            var FirstValue = EnemiesStats.EnemiesStatsDictionary.FirstOrDefault();
                            UpdateValue(FirstValue);
                        }
                    }
                }
            }
        }

        public void ReadData()
        {
            EnemiesStats.ReadEnemiesData(SelectedFolder);
            CharactersStats.ReadCharatersData(SelectedFolder);
            MoveAndMagicStats.ReadMoveAndMagicData(SelectedFolder);
            MoveRequirementStats.ReadMoveRequirementData(SelectedFolder);
        }

        public static void ClearData()
        {
            EnemiesStats.EnemiesStatsDictionary.Clear();
            EnemiesStats.EnemiesAttacksDictionary.Clear();
            CharactersStats.CharactersDictionary.Clear();
            MoveAndMagicStats.MoveAndStatDictionary.Clear();
            MoveRequirementStats.MoveRequirementDictionary.Clear();
        }

        public void FormToLoad()
        {
            button1.Enabled = false;
            button1.Text = char.ConvertFromUtf32(0x2190);
            button2.Text = char.ConvertFromUtf32(0x2192);
            button2.Enabled = true;

            //STATS
            var statsList = new List<string> { "NameQuarter", "NameFull", "ID", "LV", "HP", "STR", "VIT", "WIT", "AGI", "IpPower", "AttackCount", "AttackRange", "Move" };
            var itemsList = new List<string> { "EXP", "GP", "GoldPourcent", "ItemDrop1", "ItemDrop1Pourcent", "ItemDrop2", "ItemDrop2Pourcent" };
            var ipKnock_Back = new List<string> { "AntiIp", "KBAttack", "AntiKB" };
            var magicsAndSkillsList = new List<string> { "MP1", "MP2", "MP3", "SP", "SkillID1", "SkillID2", "SkillID3", "SkillID4" };
            var AntiStatus = new List<string> { "MagicBlockResist", "MoveBlockResist", "PlagueResist", "PoisonResist", "ParalysisResist", "SleepResist", "ConfusionResist", "CriticalResist", "FireResist", "WaterResist", "WindResist", "EarthResist" };
            var ExtAttCak = new List<string> { "Ext_Atk", "Ext_Type", "Ext_Pourcent" };
            var AnotherSettings = new List<string> { "CallID", "CallNumber", "CallPourcent" };

            //ATTACKS
            var SpecialAttackName = new List<string> { "AttackQuarter", "AttackFull" };
            var AttackStatus = new List<string> { "Power", "IpPow", "Critical", "AtkMove", "AtkRange", "KnockBack" };
            var AttackMode = new List<string> { "Target", "AreaRange", "StopMode", "EffectType", "Mode" };
            var AttackExtDamage = new List<string> { "ExtType", "ExtProb", "ExtPower" };
            var AttackElemental = new List<string> { "Elemental" };

            //STATS
            SetEnemyForm(statsList, "Status", 0, 0);
            SetEnemyForm(magicsAndSkillsList, "Magic / Skills", 0, 430);
            SetEnemyForm(itemsList, "Items", 210, 0);
            SetEnemyForm(ipKnock_Back, "IP & Knock_Back", 210, 250);
            SetEnemyForm(AntiStatus, "Resists", 210, 380);
            SetEnemyForm(AnotherSettings, "Another Settings", 420, 0);
            SetEnemyForm(ExtAttCak, "External Att Cak", 420, 130);

            var j = 0;

            //ATTACKS
            for (int i = 1; i < 6; i++)
            {
                SetEnemyAttackForm(SpecialAttackName, $"Special Attack Name {i}", i, 630 + j, 0);
                SetEnemyAttackForm(AttackStatus, $"Attack Status {i}", i, 630 + j, 110);
                SetEnemyAttackForm(AttackMode, $"Mode {i}", i, 630 + j, 330);
                SetEnemyAttackForm(AttackExtDamage, $"Ext Damage {i}", i, 630 + j, 520);
                SetEnemyAttackForm(AttackElemental, $"Elemental Attack {i}", i, 630 + j, 650);

                j = j + 210;
            }

            SetCharacterForm();
            SetMoveAndMagicForm();
            SetMoveRequirementForm();
        }

        public void SetEnemyForm(List<string> list, string groupeName, int xGroupPosition, int yGroupPosition)
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
                        case "Move":
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
                    textBox.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
                    groupBox.Controls.Add(textBox);
                }

                y += 30;
            }
        }

        public void SetEnemyAttackForm(List<string> list, string groupeName, int number, int xGroupPosition, int yGroupPosition)
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
                            comboBox.Enabled = false;
                            break;
                        case "EffectType":
                            comboBox.DataSource = ComboBoxList.EffectTypeList();
                            comboBox.SelectedIndexChanged += (sender, e) => EffectType_Attack_ComboBox_SelectedIndexChanged(sender, e, number);
                            break;
                        case "StopMode":
                            comboBox.DataSource = ComboBoxList.StopModeList();
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
                        case "AtkMove":
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
                    textBox.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
                    groupBox.Controls.Add(textBox);

                }

                y += 30;
            }
        }

        public void SetCharacterForm()
        {
            var x = 10;

            foreach (var value in CharactersStats.CharactersDictionary.Keys)
            {
                var y = 0;

                GroupBox groupBox = new GroupBox();
                groupBox.Name = $"{value}GroupBox";
                groupBox.Text = value;
                groupBox.Location = new Point(10 + x, 30);
                groupBox.AutoSize = true;
                this.tabPage2.Controls.Add(groupBox);

                Dictionary<string, string> innerDictionary = CharactersStats.CharactersDictionary[value];

                foreach (var item in innerDictionary)
                {
                    Label label = new Label();
                    label.Name = $"{item.Key}Label";
                    label.Text = item.Key;
                    label.Location = new Point(10, 20 + y);
                    label.Size = new Size(80, 20);
                    groupBox.Controls.Add(label);

                    if (item.Key.Equals("Weapon") || item.Key.Equals("Shield") || item.Key.Equals("Armor") || item.Key.Equals("Helmet") || item.Key.Equals("Footwear") || item.Key.Equals("Accessory") || item.Key.Contains("Item"))
                    {
                        ComboBox comboBox = new ComboBox();
                        switch (item.Key)
                        {
                            case "Weapon":
                            case "Shield":
                            case "Armor":
                            case "Helmet":
                            case "Footwear":
                            case "Accessory":
                            case "Item1":
                            case "Item2":
                            case "Item3":
                            case "Item4":
                            case "Item5":
                            case "Item6":
                            case "Item7":
                            case "Item8":
                            case "Item9":
                            case "Item10":
                            case "Item11":
                            case "Item12":
                                comboBox.DataSource = ItemListClass.ItemDropList();
                                break;
                            default:
                                break;
                        }
                        comboBox.Name = $"{item.Key}ComboBox";
                        comboBox.ValueMember = "Value";
                        comboBox.DisplayMember = "Text";
                        comboBox.Location = new Point(100, 20 + y);
                        comboBox.Size = new Size(100, 20);
                        groupBox.Controls.Add(comboBox);
                        comboBox.CreateControl();
                        comboBox.SelectedValue = int.Parse(item.Value);
                    }
                    else
                    {
                        TextBox textBox = new TextBox();
                        switch (item.Key)
                        {
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
                            case "Critical":
                            case "Combo":
                                textBox.TextChanged += new EventHandler(TextBox_0to15_TextChanged);
                                break;
                            case "LV":
                            case "FireExp":
                            case "WaterExp":
                            case "WindExp":
                            case "EarthExp":
                            case "Weapon1Exp":
                            case "Weapon2Exp":
                            case "Weapon3Exp":
                            case "Weapon4Exp":
                            case "MaxMP1":
                            case "MaxMP2":
                            case "MaxMP3":
                            case "CurrentMP1":
                            case "CurrentMP2":
                            case "CurrentMP3":
                            case "Weapon1Level":
                            case "Weapon2Level":
                            case "Weapon3Level":
                            case "Weapon4Level":
                            case "FireLevel":
                            case "WaterLevel":
                            case "WindLevel":
                            case "EarthLevel":
                                textBox.TextChanged += new EventHandler(TextBox_0to99_TextChanged);
                                break;
                            case "HP":
                            case "STR":
                            case "VIT":
                            case "WIT":
                            case "AGI":
                            case "SP":
                                textBox.TextChanged += new EventHandler(TextBox_0to999_TextChanged);
                                break;
                            case "AttackRange":
                            case "Move":
                                textBox.TextChanged += new EventHandler(TextBox_0to255_TextChanged);
                                break;
                            case "EXP":
                                textBox.TextChanged += new EventHandler(TextBox_0to4294967295_TextChanged);
                                break;
                            case "NextEXP":
                                textBox.TextChanged += new EventHandler(TextBox_0to65535_TextChanged);
                                break;
                            default:
                                break;
                        }
                        textBox.Name = $"{item.Key}TextBox";
                        textBox.Text = item.Value;
                        textBox.Location = new Point(100, 20 + y);
                        textBox.Size = new Size(100, 20);
                        textBox.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
                        groupBox.Controls.Add(textBox);
                    }
                    y += 30;
                }
                x += 210;
            }
        }

        public void SetMoveAndMagicForm()
        {
            var x = 10;
            var y2 = 0;
            var count = 0;

            foreach (var value in MoveAndMagicStats.MoveAndStatDictionary.Keys)
            {
                var y = 0;

                GroupBox groupBox = new GroupBox();
                groupBox.Name = $"{value}GroupBox";
                groupBox.Text = value;
                groupBox.Location = new Point(10 + x, 30 + y2);
                groupBox.AutoSize = true;
                this.tabPage3.Controls.Add(groupBox);

                var effectTypeForMode = "";

                Dictionary<string, string> innerDictionary = MoveAndMagicStats.MoveAndStatDictionary[value];

                foreach (var item in innerDictionary)
                {

                    Label label = new Label();
                    label.Name = $"{item.Key}Label";
                    label.Text = item.Key;
                    label.Location = new Point(10, 20 + y);
                    label.Size = new Size(80, 20);
                    groupBox.Controls.Add(label);

                    if (item.Key.Equals("Target") || item.Key.Equals("Elemental") || item.Key.Equals("EffectType") || item.Key.Equals("Mode"))
                    {
                        ComboBox comboBox = new ComboBox();
                        switch (item.Key)
                        {
                            case "Target":
                                comboBox.DataSource = ComboBoxList.TargetList();
                                comboBox.Enabled = false;
                                break;
                            case "Elemental":
                                comboBox.DataSource = ComboBoxList.ElementalList();
                                break;
                            case "EffectType":
                                effectTypeForMode = item.Value;
                                comboBox.DataSource = ComboBoxList.EffectTypeList();
                                comboBox.SelectedIndexChanged += (sender, e) => EffectType_MagicAndMove_ComboBox_SelectedIndexChanged(sender, e, value);
                                break;
                            case "Mode":
                                switch (effectTypeForMode)
                                {
                                    case "0":
                                        comboBox.DataSource = ModeClass.Mode0List();
                                        break;
                                    case "1":
                                        comboBox.DataSource = ModeClass.Mode1List();
                                        break;
                                    case "2":
                                        comboBox.DataSource = ModeClass.Mode2List();
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
                                break;
                            default:
                                break;
                        }
                        comboBox.Name = $"{value}_{item.Key}ComboBox";
                        comboBox.ValueMember = "Value";
                        comboBox.DisplayMember = "Text";
                        comboBox.Location = new Point(100, 20 + y);
                        comboBox.Size = new Size(100, 20);
                        groupBox.Controls.Add(comboBox);
                        comboBox.CreateControl();
                        comboBox.SelectedValue = int.Parse(item.Value);
                    }
                    else
                    {
                        TextBox textBox = new TextBox();
                        switch(item.Key)
                        {
                            case "Power":
                                textBox.TextChanged += new EventHandler(TextBox_Minus7to999_TextChanged);
                                break;
                            case "XP":
                            case "Move":
                                textBox.TextChanged += new EventHandler(TextBox_0to99_TextChanged);
                                break;
                            case "MP_SP":
                            case "CriticalPourcent":
                                textBox.TextChanged += new EventHandler(TextBox_0to100_TextChanged);
                                break;
                            case "CastSpeed":
                            case "AreaRange":
                                textBox.TextChanged += new EventHandler(TextBox_0to255_TextChanged);
                                break;
                            case "IpPower":
                                textBox.TextChanged += new EventHandler(TextBox_0to12800_TextChanged);
                                break;
                            default:
                                break;
                        }
                        textBox.Name = $"{item.Key}TextBox";
                        textBox.Text = item.Value;
                        textBox.Location = new Point(100, 20 + y);
                        textBox.Size = new Size(100, 20);
                        textBox.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
                        groupBox.Controls.Add(textBox);
                    }

                    y += 30;
                }
                count++;

                if (count == 2)
                {
                    x += 210;
                    y2 = 0;
                    count = 0;
                }
                else
                {
                    y2 = 400;
                }

            }
        }

        public void SetMoveRequirementForm()
        {
            var x = 10;
            var y2 = 0;
            var count = 0;

            foreach (var value in MoveRequirementStats.MoveRequirementDictionary.Keys)
            {
                var y = 0;

                GroupBox groupBox = new GroupBox();
                groupBox.Name = $"{value}GroupBox";
                groupBox.Text = value;
                groupBox.Location = new Point(10 + x, 30 + y2);
                groupBox.AutoSize = true;
                this.tabPage4.Controls.Add(groupBox);

                Dictionary<string, string> innerDictionary = MoveRequirementStats.MoveRequirementDictionary[value];

                foreach (var item in innerDictionary)
                {
                    Label label = new Label();
                    label.Name = $"{item.Key}Label";
                    label.Text = item.Key;
                    label.Location = new Point(10, 20 + y);
                    label.Size = new Size(80, 20);
                    groupBox.Controls.Add(label);

                    TextBox textBox = new TextBox();
                    textBox.Name = $"{item.Key}TextBox";
                    textBox.Text = item.Value;
                    textBox.Location = new Point(100, 20 + y);
                    textBox.Size = new Size(100, 20);
                    textBox.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
                    groupBox.Controls.Add(textBox);

                    y += 30;
                }
                count++;

                if (count == 3)
                {
                    x += 210;
                    y2 = 0;
                    count = 0;
                }
                else
                {
                    y2 += 250;
                }

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
                                    case "1":
                                        comboBox.DataSource = ModeClass.Mode1List();
                                        break;
                                    case "2":
                                        comboBox.DataSource = ModeClass.Mode2List();
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

        public void ChangeModeAttack(int i)
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
                        case "1":
                            comboBox.DataSource = ModeClass.Mode1List();
                            break;
                        case "2":
                            comboBox.DataSource = ModeClass.Mode2List();
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

        public void ChangeModeMagicAndMove(string name)
        {
            // Get the tabpage that contains the groups
            TabPage tabPage = tabControl1.TabPages[2];

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

            foreach (ComboBox comboBox in comboBoxes.Where(x => x.Name.Contains($"{name}_EffectType")))
            {
                if (comboBox.SelectedValue != null)
                {
                    effectTypeForMode = comboBox.SelectedValue.ToString();
                }
            }

            if (effectTypeForMode != null)
            {
                foreach (ComboBox comboBox in comboBoxes.Where(x => x.Name.StartsWith($"{name}_Mode")))
                {
                    switch (effectTypeForMode)
                    {
                        case "0":
                            comboBox.DataSource = ModeClass.Mode0List();
                            break;
                        case "1":
                            comboBox.DataSource = ModeClass.Mode1List();
                            break;
                        case "2":
                            comboBox.DataSource = ModeClass.Mode2List();
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

        private void SaveEnemyButton_Click(object sender, EventArgs e)
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
                comboBoxes.AddRange(groupBox.Controls.OfType<ComboBox>());

            }

            // Edit the text of the textboxes
            foreach (TextBox textBox in textBoxes)
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    GetValueToList.Add(textBox.Name.Replace("_TextBox", "").Replace("TextBox", ""), textBox.Text);
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

            WriteDatas.WriteMdat(SelectedFolder, SetPosition.Text, GetValueToList);
        }

        private void SaveTeamButton_Click(object sender, EventArgs e)
        {
            // Get the tabpage that contains the groups
            TabPage tabPage = tabControl1.TabPages[1];

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
                comboBoxes.AddRange(groupBox.Controls.OfType<ComboBox>());

                foreach (TextBox textBoxe in textBoxes)
                {
                    var groupKey = groupBox.Name.Replace("GroupBox", "");
                    var itemKey = textBoxe.Name.Replace("TextBox", "");
                    var ItemValue = textBoxe.Text.Replace("TextBox", "");

                    if (CharactersStats.CharactersDictionary.TryGetValue(groupKey, out Dictionary<string, string> innerDict))
                    {
                        if (innerDict.TryGetValue(itemKey, out string value))
                        {
                            // Update the value for the key "innerKey" in the inner dictionary
                            innerDict[itemKey] = ItemValue;
                        }
                    }
                }

                foreach (ComboBox comboBox in comboBoxes)
                {
                    var groupKey = groupBox.Name.Replace("GroupBox", "");
                    var itemKey = comboBox.Name.Replace("ComboBox", "");
                    var ItemValue = comboBox.SelectedValue.ToString().Replace("ComboBox", "");

                    if (CharactersStats.CharactersDictionary.TryGetValue(groupKey, out Dictionary<string, string> innerDict))
                    {
                        if (innerDict.TryGetValue(itemKey, out string value))
                        {
                            // Update the value for the key "innerKey" in the inner dictionary
                            innerDict[itemKey] = ItemValue;
                        }
                    }
                }

                WriteDatas.WriteMchar(SelectedFolder);
            }
        }

        private void SaveMoveAndMagicButton_Click(object sender, EventArgs e)
        {
            // Get the tabpage that contains the groups
            TabPage tabPage = tabControl1.TabPages[2];

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
                comboBoxes.AddRange(groupBox.Controls.OfType<ComboBox>());

                foreach (TextBox textBoxe in textBoxes)
                {
                    var groupKey = groupBox.Name.Replace("GroupBox", "");
                    var itemKey = textBoxe.Name.Replace("TextBox", "");
                    var ItemValue = textBoxe.Text.Replace("TextBox", "");

                    if (MoveAndMagicStats.MoveAndStatDictionary.TryGetValue(groupKey, out Dictionary<string, string> innerDict))
                    {
                        if (innerDict.TryGetValue(itemKey, out string value))
                        {
                            // Update the value for the key "innerKey" in the inner dictionary
                            innerDict[itemKey] = ItemValue;
                        }
                    }
                }

                foreach (ComboBox comboBox in comboBoxes)
                {
                    var groupKey = groupBox.Name.Replace("GroupBox", "");
                    var itemKey = comboBox.Name.Replace("ComboBox", "").Replace($"{groupKey}_", "");
                    var ItemValue = comboBox.SelectedValue.ToString().Replace("ComboBox", "");

                    if (MoveAndMagicStats.MoveAndStatDictionary.TryGetValue(groupKey, out Dictionary<string, string> innerDict))
                    {
                        if (innerDict.TryGetValue(itemKey, out string value))
                        {
                            // Update the value for the key "innerKey" in the inner dictionary
                            innerDict[itemKey] = ItemValue;
                        }
                    }
                }

                WriteDatas.WriteWindt(SelectedFolder);
            }
        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProject();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Etsuna. V0.1Beta", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EffectType_Attack_ComboBox_SelectedIndexChanged(object sender, EventArgs e, int number)
        {
            ChangeModeAttack(number);
        }
       

        private void EffectType_MagicAndMove_ComboBox_SelectedIndexChanged(object sender, EventArgs e, string name)
        {
            ChangeModeMagicAndMove(name);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void TextBox_Resist_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text) + 7;

            if (result < 0 || result > 14)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between -7 and 7", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_Minus7to999_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < -7 || result > 999)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between -7 and 999", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to3_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 3)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 and 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to4_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 4)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 and 4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to7_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 7)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 and 7", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to15_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 15)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 and 15", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to99_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 99)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 and 99", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to100_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 100)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 and 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to255_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 255)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 and 255", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to999_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 999)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 and 999", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to9999_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 9999)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 and 9999", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to12800_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 12800)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 and 12800", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to32767_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 32767)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 and 32767", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to65535_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = int.Parse(textBox.Text);

            if (result < 0 || result > 65535)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 and 65535", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveEnemyButton.Enabled = true;
            SaveTeamButton.Enabled = true;
            textBox.BackColor = Color.White;
        }

        private void TextBox_0to4294967295_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("-") || string.IsNullOrWhiteSpace(textBox.Text))
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                return;
            }
            var result = Int64.Parse(textBox.Text);

            if (result < 0 || result > 4294967295)
            {
                SaveEnemyButton.Enabled = false;
                SaveTeamButton.Enabled = false;
                textBox.BackColor = Color.Red;
                MessageBox.Show($"This value must be between 0 and 4294967295", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SaveEnemyButton.Enabled = true;
                SaveTeamButton.Enabled = true;
                textBox.BackColor = Color.White;
            }
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

        
    }
}
