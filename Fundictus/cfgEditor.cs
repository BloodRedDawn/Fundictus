using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Fundictus
{
    public partial class cfgEditor : Form
    {
        public cfgEditor()
        {
            InitializeComponent();
            LoadTab2();
        }
        private void LoadTab2()
        {
            string ConCmds = @"docs\NA_ConCommands.txt";
            string ConVars = @"docs\NA_ConVars.txt";
            string CostumeID = @"docs\player_costume.txt";

            StreamReader sr = new StreamReader(ConCmds);
            richTextBox13.Text = sr.ReadToEnd();
            sr.Close();

            StreamReader sr2 = new StreamReader(ConVars);
            richTextBox14.Text = sr2.ReadToEnd();
            sr.Close();

            StreamReader sr3 = new StreamReader(CostumeID);
            richTextBox15.Text = sr3.ReadToEnd();
            sr.Close();
        }
        private RichTextBox GetRichTextBox()
        {
            RichTextBox rtb = null;
            TabPage tp = tabControl1.SelectedTab;

            if (tp != null)
            {
                rtb = tp.Controls[0] as RichTextBox;
            }

            return rtb;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cfg = @"edit\config.cfg";
            string env = @"edit\config_env.cfg";
            string arisha = @"edit\config_arisha.cfg";
            string evy = @"edit\config_evy.cfg";
            string fiona = @"edit\config_fiona.cfg";
            string hurk = @"edit\config_hurk.cfg";
            string kay = @"edit\config_kay.cfg";
            string lynn = @"edit\config_lynn.cfg";
            string vella = @"edit\config_vella.cfg";
            string lethita = @"edit\config_lethita.cfg";
            string kalok = @"edit\config_kalok.cfg";
            string hagie = @"edit\config_hagie.cfg";
            string delia = @"edit\config_delia.cfg";

            File.SetAttributes(@"cfg\config_arisha.cfg", FileAttributes.Normal);
            File.SetAttributes(@"cfg\config_evy.cfg", FileAttributes.Normal);
            File.SetAttributes(@"cfg\config_fiona.cfg", FileAttributes.Normal);
            File.SetAttributes(@"cfg\config_hurk.cfg", FileAttributes.Normal);
            File.SetAttributes(@"cfg\config_kay.cfg", FileAttributes.Normal);
            File.SetAttributes(@"cfg\config_lynn.cfg", FileAttributes.Normal);
            File.SetAttributes(@"cfg\config_vella.cfg", FileAttributes.Normal);
            File.SetAttributes(@"cfg\config_lethita.cfg", FileAttributes.Normal);
            File.SetAttributes(@"cfg\config_kalok.cfg", FileAttributes.Normal);
            File.SetAttributes(@"cfg\config_hagie.cfg", FileAttributes.Normal);
            File.SetAttributes(@"cfg\config_delia.cfg", FileAttributes.Normal);
            
            File.Copy(@"cfg\config.cfg", @"edit\config.cfg", true);
            File.Copy(@"cfg\config_env.cfg", @"edit\config_env.cfg", true);
            File.Copy(@"cfg\config_arisha.cfg", @"edit\config_arisha.cfg", true);
            File.Copy(@"cfg\config_evy.cfg", @"edit\config_evy.cfg", true);
            File.Copy(@"cfg\config_fiona.cfg", @"edit\config_fiona.cfg", true);
            File.Copy(@"cfg\config_hurk.cfg", @"edit\config_hurk.cfg", true);
            File.Copy(@"cfg\config_kay.cfg", @"edit\config_kay.cfg", true);
            File.Copy(@"cfg\config_lynn.cfg", @"edit\config_lynn.cfg", true);
            File.Copy(@"cfg\config_vella.cfg", @"edit\config_vella.cfg", true);
            File.Copy(@"cfg\config_lethita.cfg", @"edit\config_lethita.cfg", true);
            File.Copy(@"cfg\config_kalok.cfg", @"edit\config_kalok.cfg", true);
            File.Copy(@"cfg\config_hagie.cfg", @"edit\config_hagie.cfg", true);
            File.Copy(@"cfg\config_delia.cfg", @"edit\config_delia.cfg", true);

            decryptConfig();
            decryptConfig_cfgenv();
            decryptConfig_arisha();
            decryptConfig_evy();
            decryptConfig_fiona();
            decryptConfig_hurk();
            decryptConfig_kay();
            decryptConfig_lynn();
            decryptConfig_vella();
            decryptConfig_lethita();
            decryptConfig_kalok();
            decryptConfig_hagie();
            decryptConfig_delia();

            StreamReader sr11 = new StreamReader(cfg);
            richTextBox11.Text = sr11.ReadToEnd();
            sr11.Close();

            StreamReader sr12 = new StreamReader(env);
            richTextBox12.Text = sr12.ReadToEnd();
            sr12.Close();

            StreamReader sr1 = new StreamReader(arisha);
            richTextBox1.Text = sr1.ReadToEnd();
            sr1.Close();

            StreamReader sr3 = new StreamReader(evy);
            richTextBox3.Text = sr3.ReadToEnd();
            sr3.Close();

            StreamReader sr4 = new StreamReader(fiona);
            richTextBox4.Text = sr4.ReadToEnd();
            sr4.Close();

            StreamReader sr5 = new StreamReader(kay);
            richTextBox5.Text = sr5.ReadToEnd();
            sr5.Close();

            StreamReader sr6 = new StreamReader(kalok);
            richTextBox6.Text = sr6.ReadToEnd();
            sr6.Close();

            StreamReader sr7 = new StreamReader(lethita);
            richTextBox7.Text = sr7.ReadToEnd();
            sr7.Close();

            StreamReader sr8 = new StreamReader(lynn);
            richTextBox8.Text = sr8.ReadToEnd();
            sr8.Close();

            StreamReader sr9 = new StreamReader(hagie);
            richTextBox9.Text = sr9.ReadToEnd();
            sr9.Close();

            StreamReader sr10 = new StreamReader(vella);
            richTextBox10.Text = sr10.ReadToEnd();
            sr10.Close();

            StreamReader sr13 = new StreamReader(hurk);
            richTextBox16.Text = sr13.ReadToEnd();
            sr13.Close();

            StreamReader sr2 = new StreamReader(delia);
            richTextBox2.Text = sr2.ReadToEnd();
            sr2.Close();
        }
        private void decryptConfig()
        {
            string exeConfigTool = "config.cmd";
            string pathConfigTool = @"edit";

            ProcessStartInfo StartConfigTool = new ProcessStartInfo();
            StartConfigTool.WorkingDirectory = pathConfigTool;
            StartConfigTool.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartConfigTool.FileName = exeConfigTool;
            var process = Process.Start(StartConfigTool);
            process.WaitForExit();
        }
        private void decryptConfig_cfgenv()
        {
            string exeConfigTool = "config.cmd";
            string pathConfigTool = @"edit";

            File.Copy(@"edit\config.cfg", @"edit\config.bck", true);
            File.Copy(@"edit\config_env.cfg", @"edit\config.cfg", true);

            ProcessStartInfo StartConfigTool = new ProcessStartInfo();
            StartConfigTool.WorkingDirectory = pathConfigTool;
            StartConfigTool.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartConfigTool.FileName = exeConfigTool;
            var process = Process.Start(StartConfigTool);
            process.WaitForExit();

            File.Copy(@"edit\config.cfg", @"edit\config_env.cfg", true);
            File.Copy(@"edit\config.bck", @"edit\config.cfg", true);
        }
        private void decryptConfig_arisha()
        {
            string exeConfigTool = "config.cmd";
            string pathConfigTool = @"edit";

            File.Copy(@"edit\config.cfg", @"edit\config.bck", true);
            File.Copy(@"edit\config_arisha.cfg", @"edit\config.cfg", true);

            ProcessStartInfo StartConfigTool = new ProcessStartInfo();
            StartConfigTool.WorkingDirectory = pathConfigTool;
            StartConfigTool.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartConfigTool.FileName = exeConfigTool;
            var process = Process.Start(StartConfigTool);
            process.WaitForExit();

            File.Copy(@"edit\config.cfg", @"edit\config_arisha.cfg", true);
            File.Copy(@"edit\config.bck", @"edit\config.cfg", true);
        }
        private void decryptConfig_evy()
        {
            string exeConfigTool = "config.cmd";
            string pathConfigTool = @"edit";

            File.Copy(@"edit\config.cfg", @"edit\config.bck", true);
            File.Copy(@"edit\config_evy.cfg", @"edit\config.cfg", true);

            ProcessStartInfo StartConfigTool = new ProcessStartInfo();
            StartConfigTool.WorkingDirectory = pathConfigTool;
            StartConfigTool.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartConfigTool.FileName = exeConfigTool;
            var process = Process.Start(StartConfigTool);
            process.WaitForExit();

            File.Copy(@"edit\config.cfg", @"edit\config_evy.cfg", true);
            File.Copy(@"edit\config.bck", @"edit\config.cfg", true);
        }
        private void decryptConfig_fiona()
        {
            string exeConfigTool = "config.cmd";
            string pathConfigTool = @"edit";

            File.Copy(@"edit\config.cfg", @"edit\config.bck", true);
            File.Copy(@"edit\config_fiona.cfg", @"edit\config.cfg", true);

            ProcessStartInfo StartConfigTool = new ProcessStartInfo();
            StartConfigTool.WorkingDirectory = pathConfigTool;
            StartConfigTool.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartConfigTool.FileName = exeConfigTool;
            var process = Process.Start(StartConfigTool);
            process.WaitForExit();

            File.Copy(@"edit\config.cfg", @"edit\config_fiona.cfg", true);
            File.Copy(@"edit\config.bck", @"edit\config.cfg", true);
        }
        private void decryptConfig_hurk()
        {
            string exeConfigTool = "config.cmd";
            string pathConfigTool = @"edit";

            File.Copy(@"edit\config.cfg", @"edit\config.bck", true);
            File.Copy(@"edit\config_hurk.cfg", @"edit\config.cfg", true);

            ProcessStartInfo StartConfigTool = new ProcessStartInfo();
            StartConfigTool.WorkingDirectory = pathConfigTool;
            StartConfigTool.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartConfigTool.FileName = exeConfigTool;
            var process = Process.Start(StartConfigTool);
            process.WaitForExit();

            File.Copy(@"edit\config.cfg", @"edit\config_hurk.cfg", true);
            File.Copy(@"edit\config.bck", @"edit\config.cfg", true);
        }
        private void decryptConfig_kay()
        {
            string exeConfigTool = "config.cmd";
            string pathConfigTool = @"edit";

            File.Copy(@"edit\config.cfg", @"edit\config.bck", true);
            File.Copy(@"edit\config_kay.cfg", @"edit\config.cfg", true);

            ProcessStartInfo StartConfigTool = new ProcessStartInfo();
            StartConfigTool.WorkingDirectory = pathConfigTool;
            StartConfigTool.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartConfigTool.FileName = exeConfigTool;
            var process = Process.Start(StartConfigTool);
            process.WaitForExit();

            File.Copy(@"edit\config.cfg", @"edit\config_kay.cfg", true);
            File.Copy(@"edit\config.bck", @"edit\config.cfg", true);
        }
        private void decryptConfig_lynn()
        {
            string exeConfigTool = "config.cmd";
            string pathConfigTool = @"edit";

            File.Copy(@"edit\config.cfg", @"edit\config.bck", true);
            File.Copy(@"edit\config_lynn.cfg", @"edit\config.cfg", true);

            ProcessStartInfo StartConfigTool = new ProcessStartInfo();
            StartConfigTool.WorkingDirectory = pathConfigTool;
            StartConfigTool.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartConfigTool.FileName = exeConfigTool;
            var process = Process.Start(StartConfigTool);
            process.WaitForExit();

            File.Copy(@"edit\config.cfg", @"edit\config_lynn.cfg", true);
            File.Copy(@"edit\config.bck", @"edit\config.cfg", true);
        }
        private void decryptConfig_vella()
        {
            string exeConfigTool = "config.cmd";
            string pathConfigTool = @"edit";

            File.Copy(@"edit\config.cfg", @"edit\config.bck", true);
            File.Copy(@"edit\config_vella.cfg", @"edit\config.cfg", true);

            ProcessStartInfo StartConfigTool = new ProcessStartInfo();
            StartConfigTool.WorkingDirectory = pathConfigTool;
            StartConfigTool.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartConfigTool.FileName = exeConfigTool;
            var process = Process.Start(StartConfigTool);
            process.WaitForExit();

            File.Copy(@"edit\config.cfg", @"edit\config_vella.cfg", true);
            File.Copy(@"edit\config.bck", @"edit\config.cfg", true);
        }
        private void decryptConfig_lethita()
        {
            string exeConfigTool = "config.cmd";
            string pathConfigTool = @"edit";

            File.Copy(@"edit\config.cfg", @"edit\config.bck", true);
            File.Copy(@"edit\config_lethita.cfg", @"edit\config.cfg", true);

            ProcessStartInfo StartConfigTool = new ProcessStartInfo();
            StartConfigTool.WorkingDirectory = pathConfigTool;
            StartConfigTool.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartConfigTool.FileName = exeConfigTool;
            var process = Process.Start(StartConfigTool);
            process.WaitForExit();

            File.Copy(@"edit\config.cfg", @"edit\config_lethita.cfg", true);
            File.Copy(@"edit\config.bck", @"edit\config.cfg", true);
        }
        private void decryptConfig_kalok()
        {
            string exeConfigTool = "config.cmd";
            string pathConfigTool = @"edit";

            File.Copy(@"edit\config.cfg", @"edit\config.bck", true);
            File.Copy(@"edit\config_kalok.cfg", @"edit\config.cfg", true);

            ProcessStartInfo StartConfigTool = new ProcessStartInfo();
            StartConfigTool.WorkingDirectory = pathConfigTool;
            StartConfigTool.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartConfigTool.FileName = exeConfigTool;
            var process = Process.Start(StartConfigTool);
            process.WaitForExit();

            File.Copy(@"edit\config.cfg", @"edit\config_kalok.cfg", true);
            File.Copy(@"edit\config.bck", @"edit\config.cfg", true);
        }
        private void decryptConfig_hagie()
        {
            string exeConfigTool = "config.cmd";
            string pathConfigTool = @"edit";

            File.Copy(@"edit\config.cfg", @"edit\config.bck", true);
            File.Copy(@"edit\config_hagie.cfg", @"edit\config.cfg", true);

            ProcessStartInfo StartConfigTool = new ProcessStartInfo();
            StartConfigTool.WorkingDirectory = pathConfigTool;
            StartConfigTool.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartConfigTool.FileName = exeConfigTool;
            var process = Process.Start(StartConfigTool);
            process.WaitForExit();

            File.Copy(@"edit\config.cfg", @"edit\config_hagie.cfg", true);
            File.Copy(@"edit\config.bck", @"edit\config.cfg", true);
        }
        private void decryptConfig_delia()
        {
            string exeConfigTool = "config.cmd";
            string pathConfigTool = @"edit";

            File.Copy(@"edit\config.cfg", @"edit\config.bck", true);
            File.Copy(@"edit\config_delia.cfg", @"edit\config.cfg", true);

            ProcessStartInfo StartConfigTool = new ProcessStartInfo();
            StartConfigTool.WorkingDirectory = pathConfigTool;
            StartConfigTool.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartConfigTool.FileName = exeConfigTool;
            var process = Process.Start(StartConfigTool);
            process.WaitForExit();

            File.Copy(@"edit\config.cfg", @"edit\config_delia.cfg", true);
            File.Copy(@"edit\config.bck", @"edit\config.cfg", true);
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cfg = @"edit\config.cfg";
            string env = @"edit\config_env.cfg";
            string arisha = @"edit\config_arisha.cfg";
            string evy = @"edit\config_evy.cfg";
            string fiona = @"edit\config_fiona.cfg";
            string hurk = @"edit\config_hurk.cfg";
            string kay = @"edit\config_kay.cfg";
            string lynn = @"edit\config_lynn.cfg";
            string vella = @"edit\config_vella.cfg";
            string lethita = @"edit\config_lethita.cfg";
            string kalok = @"edit\config_kalok.cfg";
            string hagie = @"edit\config_hagie.cfg";
            string delia = @"edit\config_delia.cfg";

            System.IO.StreamWriter sw11 = new System.IO.StreamWriter(cfg);
            sw11.Write(richTextBox11.Text);
            sw11.Close();

            System.IO.StreamWriter sw12 = new System.IO.StreamWriter(env);
            sw12.Write(richTextBox12.Text);
            sw12.Close();

            System.IO.StreamWriter sw1 = new System.IO.StreamWriter(arisha);
            sw1.Write(richTextBox1.Text);
            sw1.Close();

            System.IO.StreamWriter sw3 = new System.IO.StreamWriter(evy);
            sw3.Write(richTextBox3.Text);
            sw3.Close();

            System.IO.StreamWriter sw4 = new System.IO.StreamWriter(fiona);
            sw4.Write(richTextBox4.Text);
            sw4.Close();

            System.IO.StreamWriter sw5 = new System.IO.StreamWriter(kay);
            sw5.Write(richTextBox5.Text);
            sw5.Close();

            System.IO.StreamWriter sw6 = new System.IO.StreamWriter(kalok);
            sw6.Write(richTextBox6.Text);
            sw6.Close();

            System.IO.StreamWriter sw7 = new System.IO.StreamWriter(lethita);
            sw7.Write(richTextBox7.Text);
            sw7.Close();

            System.IO.StreamWriter sw8 = new System.IO.StreamWriter(lynn);
            sw8.Write(richTextBox8.Text);
            sw8.Close();

            System.IO.StreamWriter sw9 = new System.IO.StreamWriter(hagie);
            sw9.Write(richTextBox9.Text);
            sw9.Close();

            System.IO.StreamWriter sw10 = new System.IO.StreamWriter(vella);
            sw10.Write(richTextBox10.Text);
            sw10.Close();

            System.IO.StreamWriter sw13 = new System.IO.StreamWriter(hurk);
            sw13.Write(richTextBox16.Text);
            sw13.Close();

            System.IO.StreamWriter sw2 = new System.IO.StreamWriter(delia);
            sw2.Write(richTextBox2.Text);
            sw2.Close();

            decryptConfig();
            decryptConfig_cfgenv();
            decryptConfig_arisha();
            decryptConfig_evy();
            decryptConfig_fiona();
            decryptConfig_hurk();
            decryptConfig_kay();
            decryptConfig_lynn();
            decryptConfig_vella();
            decryptConfig_lethita();
            decryptConfig_kalok();
            decryptConfig_hagie();
            decryptConfig_delia();

            File.Copy(@"edit\config.cfg", @"cfg\config.cfg", true);
            File.Copy(@"edit\config_env.cfg", @"cfg\config_env.cfg", true);
            File.Copy(@"edit\config_arisha.cfg", @"cfg\config_arisha.cfg", true);
            File.Copy(@"edit\config_evy.cfg", @"cfg\config_evy.cfg", true);
            File.Copy(@"edit\config_fiona.cfg", @"cfg\config_fiona.cfg", true);
            File.Copy(@"edit\config_hurk.cfg", @"cfg\config_hurk.cfg", true);
            File.Copy(@"edit\config_kay.cfg", @"cfg\config_kay.cfg", true);
            File.Copy(@"edit\config_lynn.cfg", @"cfg\config_lynn.cfg", true);
            File.Copy(@"edit\config_vella.cfg", @"cfg\config_vella.cfg", true);
            File.Copy(@"edit\config_lethita.cfg", @"cfg\config_lethita.cfg", true);
            File.Copy(@"edit\config_kalok.cfg", @"cfg\config_kalok.cfg", true);
            File.Copy(@"edit\config_hagie.cfg", @"cfg\config_hagie.cfg", true);
            File.Copy(@"edit\config_delia.cfg", @"cfg\config_delia.cfg", true);

            File.SetAttributes(@"cfg\config_arisha.cfg", FileAttributes.ReadOnly);
            File.SetAttributes(@"cfg\config_evy.cfg", FileAttributes.ReadOnly);
            File.SetAttributes(@"cfg\config_fiona.cfg", FileAttributes.ReadOnly);
            File.SetAttributes(@"cfg\config_hurk.cfg", FileAttributes.ReadOnly);
            File.SetAttributes(@"cfg\config_kay.cfg", FileAttributes.ReadOnly);
            File.SetAttributes(@"cfg\config_lynn.cfg", FileAttributes.ReadOnly);
            File.SetAttributes(@"cfg\config_vella.cfg", FileAttributes.ReadOnly);
            File.SetAttributes(@"cfg\config_lethita.cfg", FileAttributes.ReadOnly);
            File.SetAttributes(@"cfg\config_kalok.cfg", FileAttributes.ReadOnly);
            File.SetAttributes(@"cfg\config_hagie.cfg", FileAttributes.ReadOnly);
            File.SetAttributes(@"cfg\config_delia.cfg", FileAttributes.ReadOnly);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().SelectAll();
        }

        private void highlightBtn_Click(object sender, EventArgs e)
        {
            int index = 0;
            String temp = GetRichTextBox().Text;
            GetRichTextBox().Text = "";
            GetRichTextBox().Text = temp;

            while (index < GetRichTextBox().Text.LastIndexOf(textBox1.Text))
            {
                GetRichTextBox().Find(textBox1.Text, index, GetRichTextBox().TextLength, RichTextBoxFinds.None);
                GetRichTextBox().SelectionBackColor = Color.Orange;
                index = GetRichTextBox().Text.IndexOf(textBox1.Text, index) + 1;
            }
        }

        private void loadBINDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///streamwriter for new lines in configs
        }
    }
}
