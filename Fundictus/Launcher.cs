using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Fundictus
{
    public partial class Launcher : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Launcher()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        /// <summary>
        /// Main Form Moveable code.
        /// </summary>
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void launchVindi()
        {
            string exeVindi = "vindictus.exe";
            string pathVindi = @"";

            ProcessStartInfo StartVindi = new ProcessStartInfo();
            StartVindi.WorkingDirectory = pathVindi;
            StartVindi.FileName = exeVindi;
            StartVindi.Arguments = "-stage";

            if (checkBox1.Checked)
            {
                System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

                t.Interval = 60000;
                t.Tick += new EventHandler(timer_Tick);
                t.Start();
            }

            if (checkBox2.Checked)
            {
                StartVindi.Arguments = "-steamclient";
            }

            Process Vindi = Process.Start(StartVindi);
        }
        private void timer_Tick (object sender, EventArgs e)
        {
            blackcipher();
        }
        private void blackcipher()
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("blackcipher.aes"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEditor_Click(object sender, EventArgs e)
        {
            cfgEditor OForm = new cfgEditor();
            OForm.Visible = true;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            GameOptions OForm = new GameOptions();
            OForm.Visible = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            launchVindi();
        }
        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void configEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cfgEditor OForm = new cfgEditor();
            OForm.Visible = true;
        }

        private void gameOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameOptions OForm = new GameOptions();
            OForm.Visible = true;
        }

        private void configDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathCFG = @"cfg";
            System.Diagnostics.Process.Start("explorer.exe", pathCFG);
        }
        private void editedConfigDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathCFG = @"edit";
            System.Diagnostics.Process.Start("explorer.exe", pathCFG);
        }
    }
}
