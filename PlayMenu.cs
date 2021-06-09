using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static CM0102_Starter_Kit.Helper;

namespace CM0102_Starter_Kit {
    partial class PlayMenu : HidableForm {
        public PlayMenu(MainMenu mainMenu) {
            this.mainMenu = mainMenu;
            this.SuspendLayout();
            InitialiseSharedControls("Choose Which Version To Play", 259, true);
            InitializeComponent();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected override List<Button> GetButtons() {
            return new List<Button> {
                this.cm0102_standard,
                this.cm0102_nick_patcher,
                this.cm89_standard,
                this.cm89_nick_patcher,
                this.cm93_standard,
                this.cm93_nick_patcher,
                this.cm3_standard,
                this.cm3_nick_patcher
            };
        }

        private void DisableButtons() {
            Database database = GetCurrentDatabase();
            foreach (Button button in GetButtons()) {
                button.Enabled = database.ButtonNames.Contains(button.Name);
            }
        }

        protected override void RefreshForm() {
            DisableButtons();
        }

        private static readonly Dictionary<string, string> ButtonExes = new Dictionary<string, string> {
            { "cm89_standard", Cm89 },
            { "cm89_nick_patcher", Cm89 },
            { "cm93_standard", Cm93 },
            { "cm93_nick_patcher", Cm93 },
            { "cm3_standard", Cm3 },
            { "cm3_nick_patcher", Cm3 },
        };

        private void RenameExes(Button button) {
            if (ButtonExes.TryGetValue(button.Name, out string exeFile)) {
                if (File.Exists(Cm0102Backup)) {
                    File.Move(Cm0102, exeFile);
                    File.Move(Cm0102Backup, Cm0102);
                } else {
                    File.Move(Cm0102, Cm0102Backup);
                    File.Move(exeFile, Cm0102);
                }
            }
        }

        private void PlayButton_Click(object sender, EventArgs e) {
            Button button = (Button) sender;
            ShowLoader();

            // Remove any temporary files that weren't removed since the last session
            FileInfo[] tmpFiles = new DirectoryInfo(GameFolder).GetFiles("*.tmp");
            if (tmpFiles.Length > 0) {
                foreach (FileInfo tmpFile in tmpFiles) {
                    File.Delete(tmpFile.FullName);
                }
            }
            FileInfo[] lngFiles = new DirectoryInfo(GameFolder).GetFiles("*.lng");
            if (lngFiles.Length > 0) {
                foreach (FileInfo lngFile in lngFiles) {
                    File.Delete(lngFile.FullName);
                }
            }

            RenameExes(button);
            bool useDefaultConfig = Regex.Match(button.Name, @"\w+_standard").Success;

            ProcessStartInfo playPsi = new ProcessStartInfo {
                WorkingDirectory = GameFolder,
                FileName = CmLoader,
                UseShellExecute = false,
                Arguments = useDefaultConfig ? CmLoaderConfig : CmLoaderCustomConfig
            };
            Process playProcess = Process.Start(playPsi);
            playProcess.WaitForExit();
            playProcess.Close();

            // The loader is a stub process for the game, so let's wait for the game to be closed
            Process[] mainPlayProcesses = Process.GetProcessesByName("cm0102");
            foreach (Process process in mainPlayProcesses) {
                process.WaitForExit();
                process.Close();
            }
            RenameExes(button);
            HideLoader();
            RefreshForm();
        }

        private void PlayMenu_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
