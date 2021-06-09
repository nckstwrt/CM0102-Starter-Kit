
namespace CM0102_Starter_Kit {
    partial class NickPatcherMenu {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.starting_year_label = new System.Windows.Forms.Label();
            this.starting_year = new System.Windows.Forms.NumericUpDown();
            this.game_speed_label = new System.Windows.Forms.Label();
            this.game_speed = new System.Windows.Forms.ComboBox();
            this.currency_inflation_label = new System.Windows.Forms.Label();
            this.currency_inflation = new System.Windows.Forms.NumericUpDown();
            this.coloured_attributes = new System.Windows.Forms.CheckBox();
            this.resolution = new System.Windows.Forms.CheckBox();
            this.work_permits = new System.Windows.Forms.CheckBox();
            this.non_public_bids = new System.Windows.Forms.CheckBox();
            this.seven_substitutes = new System.Windows.Forms.CheckBox();
            this.unprotected_contracts = new System.Windows.Forms.CheckBox();
            this.foreign_player_limit = new System.Windows.Forms.CheckBox();
            this.regen_fixes = new System.Windows.Forms.CheckBox();
            this.force_all_players = new System.Windows.Forms.CheckBox();
            this.tapani_regen = new System.Windows.Forms.CheckBox();
            this.uncap = new System.Windows.Forms.CheckBox();
            this.misc_patches = new System.Windows.Forms.CheckBox();
            this.protection_patches = new System.Windows.Forms.CheckBox();
            this.apply = new System.Windows.Forms.Button();
            this.transparent_panel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.starting_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currency_inflation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transparent_panel)).BeginInit();
            // 
            // starting_year_label
            // 
            this.starting_year_label.AutoSize = true;
            this.starting_year_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.starting_year_label.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.starting_year_label.ForeColor = System.Drawing.Color.White;
            this.starting_year_label.Location = new System.Drawing.Point(122, 125);
            this.starting_year_label.Name = "starting_year_label";
            this.starting_year_label.Size = new System.Drawing.Size(122, 21);
            this.starting_year_label.Text = "Starting Year";
            // 
            // starting_year
            // 
            this.starting_year.BackColor = System.Drawing.SystemColors.Window;
            this.starting_year.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 9F, System.Drawing.FontStyle.Bold);
            this.starting_year.Location = new System.Drawing.Point(323, 125);
            this.starting_year.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.starting_year.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.starting_year.Name = "starting_year";
            this.starting_year.ReadOnly = true;
            this.starting_year.Size = new System.Drawing.Size(100, 22);
            this.starting_year.TabStop = false;
            this.starting_year.Value = new decimal(new int[] {
            2001,
            0,
            0,
            0});
            // 
            // game_speed_label
            // 
            this.game_speed_label.AutoSize = true;
            this.game_speed_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.game_speed_label.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.game_speed_label.ForeColor = System.Drawing.Color.White;
            this.game_speed_label.Location = new System.Drawing.Point(122, 173);
            this.game_speed_label.Name = "game_speed_label";
            this.game_speed_label.Size = new System.Drawing.Size(116, 21);
            this.game_speed_label.Text = "Game Speed";
            // 
            // game_speed
            // 
            this.game_speed.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 9F, System.Drawing.FontStyle.Bold);
            this.game_speed.FormattingEnabled = true;
            this.game_speed.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x20",
            "x50",
            "x100",
            "x200"});
            this.game_speed.Location = new System.Drawing.Point(323, 173);
            this.game_speed.Name = "game_speed";
            this.game_speed.Size = new System.Drawing.Size(101, 23);
            this.game_speed.TabStop = false;
            this.game_speed.Text = "x4";
            // 
            // currency_inflation_label
            // 
            this.currency_inflation_label.AutoSize = true;
            this.currency_inflation_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.currency_inflation_label.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.currency_inflation_label.ForeColor = System.Drawing.Color.White;
            this.currency_inflation_label.Location = new System.Drawing.Point(122, 224);
            this.currency_inflation_label.Name = "currency_inflation_label";
            this.currency_inflation_label.Size = new System.Drawing.Size(158, 21);
            this.currency_inflation_label.Text = "Currency Inflation";
            // 
            // currency_inflation
            // 
            this.currency_inflation.BackColor = System.Drawing.SystemColors.Window;
            this.currency_inflation.DecimalPlaces = 2;
            this.currency_inflation.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 9F, System.Drawing.FontStyle.Bold);
            this.currency_inflation.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.currency_inflation.Location = new System.Drawing.Point(323, 224);
            this.currency_inflation.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.currency_inflation.Name = "currency_inflation";
            this.currency_inflation.ReadOnly = true;
            this.currency_inflation.Size = new System.Drawing.Size(101, 22);
            this.currency_inflation.TabStop = false;
            this.currency_inflation.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // coloured_attributes
            // 
            this.coloured_attributes.AutoSize = true;
            this.coloured_attributes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.coloured_attributes.Checked = true;
            this.coloured_attributes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.coloured_attributes.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.coloured_attributes.ForeColor = System.Drawing.Color.White;
            this.coloured_attributes.Location = new System.Drawing.Point(122, 274);
            this.coloured_attributes.Name = "coloured_attributes";
            this.coloured_attributes.Size = new System.Drawing.Size(194, 25);
            this.coloured_attributes.TabStop = false;
            this.coloured_attributes.Text = "Coloured Attributes";
            this.coloured_attributes.UseVisualStyleBackColor = false;
            // 
            // resolution
            // 
            this.resolution.AutoSize = true;
            this.resolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resolution.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.resolution.ForeColor = System.Drawing.Color.White;
            this.resolution.Location = new System.Drawing.Point(122, 323);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(301, 25);
            this.resolution.TabStop = false;
            this.resolution.Text = "Change Resolution to 1200x800";
            this.resolution.UseVisualStyleBackColor = false;
            // 
            // work_permits
            // 
            this.work_permits.AutoSize = true;
            this.work_permits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.work_permits.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.work_permits.ForeColor = System.Drawing.Color.White;
            this.work_permits.Location = new System.Drawing.Point(472, 125);
            this.work_permits.Name = "work_permits";
            this.work_permits.Size = new System.Drawing.Size(170, 25);
            this.work_permits.TabStop = false;
            this.work_permits.Text = "No Work Permits";
            this.work_permits.UseVisualStyleBackColor = false;
            // 
            // non_public_bids
            // 
            this.non_public_bids.AutoSize = true;
            this.non_public_bids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.non_public_bids.Checked = true;
            this.non_public_bids.CheckState = System.Windows.Forms.CheckState.Checked;
            this.non_public_bids.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.non_public_bids.ForeColor = System.Drawing.Color.White;
            this.non_public_bids.Location = new System.Drawing.Point(472, 172);
            this.non_public_bids.Name = "non_public_bids";
            this.non_public_bids.Size = new System.Drawing.Size(208, 25);
            this.non_public_bids.TabStop = false;
            this.non_public_bids.Text = "Hide Non-Public Bids";
            this.non_public_bids.UseVisualStyleBackColor = false;
            // 
            // seven_substitutes
            // 
            this.seven_substitutes.AutoSize = true;
            this.seven_substitutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seven_substitutes.Checked = true;
            this.seven_substitutes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.seven_substitutes.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.seven_substitutes.ForeColor = System.Drawing.Color.White;
            this.seven_substitutes.Location = new System.Drawing.Point(472, 220);
            this.seven_substitutes.Name = "seven_substitutes";
            this.seven_substitutes.Size = new System.Drawing.Size(242, 25);
            this.seven_substitutes.TabStop = false;
            this.seven_substitutes.Text = "Increase To 7 Substitutes";
            this.seven_substitutes.UseVisualStyleBackColor = false;
            // 
            // unprotected_contracts
            // 
            this.unprotected_contracts.AutoSize = true;
            this.unprotected_contracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.unprotected_contracts.Checked = true;
            this.unprotected_contracts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.unprotected_contracts.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.unprotected_contracts.ForeColor = System.Drawing.Color.White;
            this.unprotected_contracts.Location = new System.Drawing.Point(472, 274);
            this.unprotected_contracts.Name = "unprotected_contracts";
            this.unprotected_contracts.Size = new System.Drawing.Size(288, 25);
            this.unprotected_contracts.TabStop = false;
            this.unprotected_contracts.Text = "Disable Unprotected Contracts";
            this.unprotected_contracts.UseVisualStyleBackColor = false;
            // 
            // foreign_player_limit
            // 
            this.foreign_player_limit.AutoSize = true;
            this.foreign_player_limit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.foreign_player_limit.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.foreign_player_limit.ForeColor = System.Drawing.Color.White;
            this.foreign_player_limit.Location = new System.Drawing.Point(472, 323);
            this.foreign_player_limit.Name = "foreign_player_limit";
            this.foreign_player_limit.Size = new System.Drawing.Size(301, 25);
            this.foreign_player_limit.TabStop = false;
            this.foreign_player_limit.Text = "Remove All Foreign Player Limits";
            this.foreign_player_limit.UseVisualStyleBackColor = false;
            // 
            // regen_fixes
            // 
            this.regen_fixes.AutoSize = true;
            this.regen_fixes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.regen_fixes.Checked = true;
            this.regen_fixes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.regen_fixes.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.regen_fixes.ForeColor = System.Drawing.Color.White;
            this.regen_fixes.Location = new System.Drawing.Point(122, 368);
            this.regen_fixes.Name = "regen_fixes";
            this.regen_fixes.Size = new System.Drawing.Size(130, 25);
            this.regen_fixes.TabStop = false;
            this.regen_fixes.Text = "Regen Fixes";
            this.regen_fixes.UseVisualStyleBackColor = false;
            // 
            // force_all_players
            // 
            this.force_all_players.AutoSize = true;
            this.force_all_players.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.force_all_players.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.force_all_players.ForeColor = System.Drawing.Color.White;
            this.force_all_players.Location = new System.Drawing.Point(472, 368);
            this.force_all_players.Name = "force_all_players";
            this.force_all_players.Size = new System.Drawing.Size(163, 25);
            this.force_all_players.TabStop = false;
            this.force_all_players.Text = "Load All Players";
            this.force_all_players.UseVisualStyleBackColor = false;
            // 
            // tapani_regen
            // 
            this.tapani_regen.AutoSize = true;
            this.tapani_regen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tapani_regen.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.tapani_regen.ForeColor = System.Drawing.Color.White;
            this.tapani_regen.Location = new System.Drawing.Point(122, 414);
            this.tapani_regen.Name = "tapani_regen";
            this.tapani_regen.Size = new System.Drawing.Size(187, 25);
            this.tapani_regen.TabStop = false;
            this.tapani_regen.Text = "Tapani Regen Code";
            this.tapani_regen.UseVisualStyleBackColor = false;
            // 
            // uncap
            // 
            this.uncap.AutoSize = true;
            this.uncap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uncap.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.uncap.ForeColor = System.Drawing.Color.White;
            this.uncap.Location = new System.Drawing.Point(472, 414);
            this.uncap.Name = "uncap";
            this.uncap.Size = new System.Drawing.Size(125, 25);
            this.uncap.TabStop = false;
            this.uncap.Text = "Uncap 20\'s";
            this.uncap.UseVisualStyleBackColor = false;
            // 
            // misc_patches
            // 
            this.misc_patches.AutoSize = true;
            this.misc_patches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.misc_patches.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.misc_patches.ForeColor = System.Drawing.Color.White;
            this.misc_patches.Location = new System.Drawing.Point(122, 460);
            this.misc_patches.Name = "misc_patches";
            this.misc_patches.Size = new System.Drawing.Size(259, 25);
            this.misc_patches.TabStop = false;
            this.misc_patches.Text = "Use Miscellaneous Patches";
            this.misc_patches.UseVisualStyleBackColor = false;
            // 
            // protection_patches
            this.protection_patches.AutoSize = true;
            this.protection_patches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.protection_patches.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12.75F, System.Drawing.FontStyle.Bold);
            this.protection_patches.ForeColor = System.Drawing.Color.White;
            this.protection_patches.Location = new System.Drawing.Point(472, 460);
            this.protection_patches.Name = "protection_patches";
            this.protection_patches.Size = new System.Drawing.Size(242, 25);
            this.protection_patches.TabStop = false;
            this.protection_patches.Text = "Apply Protection Patches";
            this.protection_patches.UseVisualStyleBackColor = false;
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(173)))));
            this.apply.FlatAppearance.BorderSize = 2;
            this.apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Font = new System.Drawing.Font(HidableForm.ffErasDemiBt, 12F, System.Drawing.FontStyle.Bold);
            this.apply.ForeColor = System.Drawing.Color.White;
            this.apply.Location = new System.Drawing.Point(409, 507);
            this.apply.Margin = new System.Windows.Forms.Padding(0);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(93, 30);
            this.apply.TabStop = false;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // transparent_panel
            // 
            this.transparent_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.transparent_panel.Location = new System.Drawing.Point(107, 120);
            this.transparent_panel.Name = "transparent_panel";
            this.transparent_panel.Size = new System.Drawing.Size(683, 372);
            this.transparent_panel.TabStop = false;
            // 
            // NickPatcherMenu
            // 
            this.BackgroundImage = Properties.Resources.ruud;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.starting_year_label);
            this.Controls.Add(this.starting_year);
            this.Controls.Add(this.game_speed_label);
            this.Controls.Add(this.game_speed);
            this.Controls.Add(this.currency_inflation_label);
            this.Controls.Add(this.currency_inflation);
            this.Controls.Add(this.coloured_attributes);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.work_permits);
            this.Controls.Add(this.non_public_bids);
            this.Controls.Add(this.seven_substitutes);
            this.Controls.Add(this.unprotected_contracts);
            this.Controls.Add(this.foreign_player_limit);
            this.Controls.Add(this.uncap);
            this.Controls.Add(this.tapani_regen);
            this.Controls.Add(this.force_all_players);
            this.Controls.Add(this.regen_fixes);
            this.Controls.Add(this.misc_patches);
            this.Controls.Add(this.protection_patches);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.transparent_panel);
            this.Name = "NickPatcherMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NickPatcherMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.starting_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currency_inflation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transparent_panel)).EndInit();
        }

        #endregion
        private System.Windows.Forms.Label starting_year_label;
        private System.Windows.Forms.NumericUpDown starting_year;
        private System.Windows.Forms.Label game_speed_label;
        private System.Windows.Forms.ComboBox game_speed;
        private System.Windows.Forms.Label currency_inflation_label;
        private System.Windows.Forms.NumericUpDown currency_inflation;
        private System.Windows.Forms.CheckBox coloured_attributes;
        private System.Windows.Forms.CheckBox resolution;
        private System.Windows.Forms.CheckBox work_permits;
        private System.Windows.Forms.CheckBox non_public_bids;
        private System.Windows.Forms.CheckBox seven_substitutes;
        private System.Windows.Forms.CheckBox unprotected_contracts;
        private System.Windows.Forms.CheckBox foreign_player_limit;
        private System.Windows.Forms.CheckBox regen_fixes;
        private System.Windows.Forms.CheckBox force_all_players;
        private System.Windows.Forms.CheckBox tapani_regen;
        private System.Windows.Forms.CheckBox uncap;
        private System.Windows.Forms.CheckBox misc_patches;
        private System.Windows.Forms.CheckBox protection_patches;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.PictureBox transparent_panel;
    }
}

