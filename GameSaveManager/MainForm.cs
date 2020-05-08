using GameSaveManager.Model;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSaveManager
{
    public partial class MainForm : Form
    {
        DirectoryInfo targetPath;

        public MainForm()
        {
            InitializeComponent();
        }

        private async Task Execute(Control control, Action action)
        {
            control.Enabled = false;
            await Task.Run(action);
            control.Enabled = true;
        }

        private ListViewItem CreateLVI(GameSave gs)
        {
            return new ListViewItem
            {
                Text = gs.Name,
                Tag = gs
            };
        }

        private void PrepareTarget(string target)
        {
            lvList.Items.Clear();
            lvList.Items.AddRange(Storage.GetList(target).Where(gs =>
            {
                bool exists = File.Exists(Manager.GetBFPath(target, gs.Name));
                if (!exists) { Storage.Remove(target, gs); }
                return exists;
            }).Select(CreateLVI).ToArray());
            chName.Width = lvList.ClientSize.Width;
        }

        private void HandleSelect(string target)
        {
            targetPath = new DirectoryInfo(target);
            PrepareTarget(target);
            scContent.Enabled = true;
        }

        private async void tbTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                scContent.Enabled = scContent.Panel2.Enabled = false;
                if (Directory.Exists(tbTarget.Text))
                {
                    await Execute(gbTarget, () => HandleSelect(tbTarget.Text));
                }
                else
                {
                    MessageBox.Show($"Path not exists :\n\"{tbTarget.Text}\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SelectTarget(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                HandleSelect(tbTarget.Text = fbd.SelectedPath);
            }
        }

        private void lvList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            scContent.Panel2.Enabled = lvList.SelectedItems.Count > 0;
            if (scContent.Panel2.Enabled)
            {
                GameSave gs = (GameSave)lvList.SelectedItems[0].Tag;
                tbName.Text = gs.Name;
                lblTime.Text = gs.Time;
                tbRemark.Text = gs.Remark;
            }
        }

        private async void btnBackup_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string name = $"{targetPath.Name}_{dt.ToString("yyyy-MM-dd_HH-mm-ss")}.zip";
            await Execute(btnBackup, () => Manager.Backup(targetPath.FullName, name));
            GameSave gs = new GameSave { Name = name, Time = dt.ToString("yyyy-MM-dd HH:mm:ss.fffffffK") };
            if (Storage.Add(targetPath.FullName, gs))
            {
                lvList.Items.Add(CreateLVI(gs));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GameSave gs = (GameSave)lvList.SelectedItems[0].Tag;
            gs.Name = tbName.Text;
            gs.Remark = tbRemark.Text.TV();
            Storage.Update(targetPath.FullName, gs);
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            GameSave gs = (GameSave)lvList.SelectedItems[0].Tag;
            if (targetPath.Exists)
            {
                targetPath.Delete(true);
            }
            await Execute(btnRestore, () => Manager.Restore(targetPath.FullName, gs.Name));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lvList.SelectedItems[0];
            GameSave gs = (GameSave)lvi.Tag;
            if (MessageBox.Show($"Confirm to delete :\n\"{gs.Name}\"", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                if (Storage.Remove(targetPath.FullName, gs))
                {
                    lvList.Items.Remove(lvi);
                }
            }
        }
    }
}
