using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static CM0102_Starter_Kit.Helper;

namespace CM0102_Starter_Kit {
    partial class AndroidMenu : HidableForm {
        public AndroidMenu(MainMenu mainMenu) {
            this.mainMenu = mainMenu;
            this.SuspendLayout();
            InitialiseSharedControls("Android Setup Instructions", 270, true);
            InitializeComponent();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
 
        protected override List<Button> GetButtons() {
            return new List<Button> {
                this.generate_files
            };
        }

        private void CopyFolder(string folderName) {
            string newFolder = Path.Combine(ExagearFolder, folderName);
            if (Directory.Exists(newFolder)) {
                Directory.Delete(newFolder, true);
                Thread.Sleep(2000);
            }
            if (!Directory.Exists(newFolder)) {
                Directory.CreateDirectory(newFolder);
                Thread.Sleep(2000);

                string originalFolder = Path.Combine(GameFolder, folderName);
                FileInfo[] files = new DirectoryInfo(originalFolder).GetFiles();
                if (files.Length > 0) {
                    foreach (FileInfo file in files) {
                        File.Copy(file.FullName, Path.Combine(newFolder, file.Name), true);
                    }
                }
            }
        }

        private void GenerateFiles_Click(object sender, EventArgs e) {
            ProgressWindow progressWindow = new ProgressWindow("Generating files for Android", 75);
            progressWindow.Show();
            progressWindow.Refresh();
            progressWindow.SetProgressPercentage(0);

            Database database = GetCurrentDatabase(); 
            // Copy correct CM exe file across
            File.Copy(database.ExeFile, Path.Combine(ExagearFolder, Cm0102Exe), true);
            // Copy CM loader exe file across
            File.Copy(CmLoader, Path.Combine(ExagearFolder, CmLoaderExe), true);
            progressWindow.SetProgressPercentage(5);

            // Copy correct CM loader config file across
            string androidConfigFile = Path.Combine(ExagearFolder, CmLoaderAndroidConfig);
            string configFile = CmLoaderConfig;
            bool copyPatchesFolder = false;

            if (this.nick_patcher.Checked) {
                configFile = CmLoaderCustomConfig;
                copyPatchesFolder = true;
            }
            File.Copy(Path.Combine(GameFolder, configFile), androidConfigFile, true);
            progressWindow.SetProgressPercentage(10);

            // We need to ensure certain patches are not applied to the Android version, even if they were selected
            List<string> defaultLines = GetDefaultConfigFileLines(androidConfigFile, database, true);
            WriteConfigFile(defaultLines, androidConfigFile);
            progressWindow.SetProgressPercentage(15);

            // Only copy Patches folder across if the user wants to use Nick's Patcher - otherwise just create an empty folder
            if (copyPatchesFolder) {
                CopyFolder(PatchesFolderName);
            } else {
                string newPatchesFolder = Path.Combine(ExagearFolder, PatchesFolderName);
                if (Directory.Exists(newPatchesFolder)) {
                    Directory.Delete(newPatchesFolder, true);
                }
                Directory.CreateDirectory(newPatchesFolder);
            }
            progressWindow.SetProgressPercentage(25);
            // Copy generic folders across
            CopyFolder(DataFolderName);
            progressWindow.SetProgressPercentage(45);
            CopyFolder(PicturesFolderName);
            progressWindow.SetProgressPercentage(65);
            CopyFolder(SoundsFolderName);
            progressWindow.SetProgressPercentage(85);
            Thread.Sleep(2000);

            if (this.android_11.Checked) {
                File.Copy(Path.Combine(OptionalPatchesFolder, Android11Patch), Path.Combine(Path.Combine(ExagearFolder, PatchesFolderName), Android11Patch));
            }
            progressWindow.SetProgressPercentage(100);
            progressWindow.Close();
            DisplayMessage("Files successfully generated!");
        }

        private void AndroidMenu_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
