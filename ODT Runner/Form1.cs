using System.Drawing;
using System.Windows.Forms;

namespace ODT_Runner
{
    public partial class FormODTRunner : Form
    {
        public FormODTRunner()
        {
            InitializeComponent();
        }

        private void btn_browseOdtList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_OdtList.Text = openFileDialog.FileName;
            }
        }

        private void SelectSCMPath()
        {
            string[] workspaces = Directory.GetDirectories("D:\\SCM");

            foreach (var ws in workspaces)
            {
                cb_scmPath.Items.Add(ws);
            }
        }

        private void UpdateSCMPath()
        {
            string level = "425";

            switch (cb_Level.Text)
            {
                case "R425":
                    level = "425";
                    break;

                case "R424":
                    level = "424";
                    break;

                case "R423":
                    level = "423";
                    break;

                case "R422":
                    level = "422";
                    break;

                case "R421":
                    level = "421";
                    break;
            }

            foreach (string ws in cb_scmPath.Items)
            {
                if(ws.Contains(level))
                {
                    cb_scmPath.Text = ws;
                    break;
                }

            }
           
        }

        private void FormODTRunner_Load(object sender, EventArgs e)
        {
            cb_Level.SelectedIndex = 0;
            tb_noOfOdts.Text = "4";
            lbl_noOfJobs.Enabled = false;
            tb_noOfOdts.Enabled = false;

            SelectSCMPath();
            UpdateSCMPath();
        }

        private void cb_OdtJobs_CheckStateChanged(object sender, EventArgs e)
        {
            if (cb_OdtJobs.CheckState == CheckState.Checked)
            {
                tb_noOfOdts.Text = "4";
                lbl_noOfJobs.Enabled = true;
                tb_noOfOdts.Enabled = true;
            }
            else
            {
                lbl_noOfJobs.Enabled = false;
                tb_noOfOdts.Enabled = false;
            }
        }

        private void tb_noOfOdts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cb_Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSCMPath();
        }

        private void btn_browseOutputPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    tb_outputPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void cb_withBsf_CheckStateChanged(object sender, EventArgs e)
        {
            cb_scmPath.Enabled = cb_withBsf.CheckState == CheckState.Checked ? false : true;
        }
    }
}