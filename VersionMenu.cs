using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static CM0102_Starter_Kit.Helper;

namespace CM0102_Starter_Kit {
    partial class VersionMenu : HidableForm {
        public VersionMenu(MainMenu mainMenu) {
            this.mainMenu = mainMenu;
            this.SuspendLayout();
            InitialiseSharedControls("Data Updates", 355, true);
            InitializeComponent();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected override List<Button> GetButtons() {
            return new List<Button> {
                this.april_database,
                this.original_database,
                this.patched_database,
                this.march_database,
                this.november_database,
                this.luessenhoff_database,
                this.cm89_database,
                this.cm93_database,
                this.cm3_database,
                this.save_database,
                this.load_database
            };
        }

        private void UpdateConfigFiles(Database database) {
            string defaultConfig = Path.Combine(GameFolder, CmLoaderConfig);
            List<string> defaultLines = GetDefaultConfigFileLines(defaultConfig, database, false);
            WriteConfigFile(defaultLines, defaultConfig);

            string customConfig = Path.Combine(GameFolder, CmLoaderCustomConfig);
            List<string> customLines = GetDefaultConfigFileLines(customConfig, database, false);
            WriteConfigFile(customLines, customConfig);
        }

        private void CopyDataToGame(Database database) {
            if (database.DeleteDataFolder && DataFolderExists()) {
                Directory.Delete(DataFolder, true);
            }
            string dataZipFile = DataFolder + ".zip";
            File.WriteAllBytes(dataZipFile, database.ResourceFile);
            new FastZip().ExtractZip(dataZipFile, DataFolder, null);
            File.Delete(dataZipFile);
        }

        private void SwitchDatabase_Click(object sender, EventArgs e) {
            ProgressWindow progressWindow = new ProgressWindow("Loading selected database", 75);
            progressWindow.Show();
            progressWindow.Refresh();
            progressWindow.SetProgressPercentage(0);

            Button button = (Button) sender;
            Database database = Databases.Where(v => string.Equals(v.Name, button.Name)).FirstOrDefault();
            if (database.PrerequisiteDatabase != null) {
                CopyDataToGame(database.PrerequisiteDatabase);
                progressWindow.SetProgressPercentage(40);
            }
            CopyDataToGame(database);
            progressWindow.SetProgressPercentage(80);
            // Update the loader config files as switching between CM89, CM93 and anything else requires some changes
            UpdateConfigFiles(database);

            progressWindow.SetProgressPercentage(100);
            progressWindow.Close();
            DisplayMessage(database.Label + " database successfully loaded!");
        }

        private void SaveDatabase_Click(object sender, EventArgs e) {
            if (DataFolderExists()) {
                this.saveDatabaseDialog.ShowDialog();
            } else {
                DisplayMessage(SwitchUpdateMessage);
            }
        }

        private void SaveDatabaseDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            new FastZip().CreateZip(this.saveDatabaseDialog.FileName, DataFolder, true, null);
            DisplayMessage("Custom database successfully saved!");
        }

        private void LoadDatabase_Click(object sender, EventArgs e) {
            this.loadDatabaseDialog.ShowDialog();
        }

        private void LoadDatabaseDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            if (DataFolderExists()) {
                Directory.Delete(DataFolder, true);
            }
            new FastZip().ExtractZip(this.loadDatabaseDialog.FileName, DataFolder, null);
            DisplayMessage("Custom database successfully loaded!");
        }

        private void VersionMenu_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
