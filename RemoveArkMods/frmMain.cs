using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Principal;

namespace RemoveArkMods
{
    public sealed partial class frmMain : Form
    {
        private string _arkInstallDir = "";
        private bool _isValidModId = false;
        private bool _isValidArkDir = false;

        private string _delFolder1 = "";
        private string _delFile = "";
        private string _delFolder2 = "";

        public frmMain()
        {
            InitializeComponent();
            if (IsUserAdministrator())
            {
                Text = @"Delete ARK mod (Administrator)";
            }
        }

        public bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException ex)
            {
                isAdmin = false;
            }
            catch (Exception ex)
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        private void btnArkInstallDir_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdArkInstallDir.ShowDialog();
            if (result == DialogResult.OK)
            {
                _arkInstallDir = fbdArkInstallDir.SelectedPath;
                lblArkInstallDir.Text = _arkInstallDir;
                if (!IsArkDirCorrect())
                {
                    MessageBox.Show(this, @"Choosen ARK install directory is not correct!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private bool IsArkDirCorrect()
        {
            DirectoryInfo di = new DirectoryInfo(_arkInstallDir);
            di.EnumerateDirectories();
            if (di.Parent != null && di.Parent.ToString() == "common")
            {
                if (di.Parent.Parent != null && di.Parent.Parent.ToString() == "steamapps")
                {
                    _isValidArkDir = true;
                    btnDeleteMod.Enabled = IsAllValid();
                    SetInformation(!IsAllValid());
                }
                else _isValidArkDir = false;
            }
            return _isValidArkDir;
        }

        private bool IsAllValid()
        {
            return _isValidArkDir && _isValidModId;
        }

        private string GetModNameFromSteam(string modid)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri("http://steamcommunity.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/html"));

                var response = client.GetAsync($"sharedfiles/filedetails/?id={modid}").Result;
                if (response.IsSuccessStatusCode)
                {
                    using (var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result))
                    {
                        var tempHtml = reader.ReadToEnd();
                        int start = tempHtml.IndexOf("<title>", StringComparison.Ordinal) + 24;
                        int len = tempHtml.IndexOf("</title>", StringComparison.Ordinal) - start;

                        return tempHtml.Substring(start, len).Replace("&amp;", "&").Replace(": Error", " Error: Hidden, deleted mod");
                    }
                }
                else
                {
                    return "error";
                    //throw new System.Net.WebException("Something went wrong with getting the modname for " + modid);
                }
            }
        }

        private void txtModId_TextChanged(object sender, EventArgs e)
        {
            if (txtModId.Text.Length >= 9)
            {
                string temp = GetModNameFromSteam(txtModId.Text);
                if (temp.ToLower().Contains("error")) return;
                lblModSteamInfo.Text = $@"Steam mod info: {temp}";
                _isValidModId = true;
                btnDeleteMod.Enabled = IsAllValid();
                SetInformation(!IsAllValid());
            }
            else
            {
                _isValidModId = false;
                btnDeleteMod.Enabled = IsAllValid();
                SetInformation(!IsAllValid());
                lblModSteamInfo.Text = @"Steam mod info:";
            } 
        }

        private void SetInformation(bool reset)
        {
            if (reset)
            {
                lblInfo.Text = @"Information:";
            }
            else
            {
                var di = new DirectoryInfo(_arkInstallDir);
                _delFolder1 = $"{di.FullName}\\ShooterGame\\Content\\Mods\\{txtModId.Text}";
                _delFile = $"{di.FullName}\\ShooterGame\\Content\\Mods\\{txtModId.Text}.mod";
                _delFolder2 = $"{di.Parent.Parent.FullName}\\workshop\\content\\346110\\{txtModId.Text}";
                lblInfo.Text = $"Information:\nTo be deleted...\n{_delFolder1}\n{_delFile}\n{_delFolder2}";
            }
        }

        private void DeletedReset()
        {
            string temp = $"Information: \n\n All folders/files for mod {txtModId.Text} is now deleted.";
            txtModId.Text = "";
            lblInfo.Text = temp;
        }

        private void btnDeleteMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(_delFolder1)) Directory.Delete(_delFolder1, true);
                if (File.Exists(_delFile)) File.Delete(_delFile);
                if (Directory.Exists(_delFolder2)) Directory.Delete(_delFolder2, true);
                DeletedReset();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n\n{ex.InnerException}");
            }
            
        }
    }
}
