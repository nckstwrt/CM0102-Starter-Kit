namespace CM0102_Starter_Kit {
    partial class HidableForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected void InitialiseSharedControls(string subTitleText, int subTitleXLocation, bool backButtonEnabled) {
            this.version_label = new System.Windows.Forms.Label();
            this.version_number = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.sidenav = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.title_bar = new System.Windows.Forms.PictureBox();
            this.subtitle = new System.Windows.Forms.Label();
            this.subtitle_bar = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.loader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sidenav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.title_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtitle_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            // 
            // version_label
            // 
            this.version_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.version_label.AutoSize = false;
            this.version_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.version_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.version_label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.version_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(16)))));
            this.version_label.Location = new System.Drawing.Point(9, 12);
            this.version_label.Margin = new System.Windows.Forms.Padding(0);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(79, 23);
            this.version_label.Text = "Version";
            this.version_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // version_number
            // 
            this.version_number.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.version_number.AutoSize = false;
            this.version_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.version_number.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.version_number.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.version_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(16)))));
            this.version_number.Location = new System.Drawing.Point(0, 35);
            this.version_number.Margin = new System.Windows.Forms.Padding(0);
            this.version_number.Name = "version_number";
            this.version_number.Size = new System.Drawing.Size(95, 100);
            this.version_number.Text = "1.2.2\r\n\r\n\r\nUpdated\r\nBy\r\nNick+Co";
            this.version_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(16)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(215)))), ((int)(((byte)(16)))));
            this.exit.Location = new System.Drawing.Point(9, 153);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(79, 50);
            this.exit.Text = "Exit Tool";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // sidenav
            // 
            this.sidenav.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sidenav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.sidenav.Location = new System.Drawing.Point(0, 0);
            this.sidenav.Margin = new System.Windows.Forms.Padding(0);
            this.sidenav.Name = "sidenav";
            this.sidenav.Size = new System.Drawing.Size(97, 600);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Red;
            this.title.Font = new System.Drawing.Font(HidableForm.ffHandelGo, 21F, System.Drawing.FontStyle.Regular);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.title.Location = new System.Drawing.Point(130, 24);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Text = "Championship Manager 2001/02 Starter Kit";
            // 
            // title_bar
            // 
            this.title_bar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title_bar.BackColor = System.Drawing.Color.Red;
            this.title_bar.Location = new System.Drawing.Point(107, 10);
            this.title_bar.Margin = new System.Windows.Forms.Padding(0);
            this.title_bar.Name = "title_bar";
            this.title_bar.Size = new System.Drawing.Size(683, 64);
            // 
            // subtitle
            // 
            this.subtitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subtitle.AutoSize = true;
            this.subtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.subtitle.Font = new System.Drawing.Font(HidableForm.ffHandelGo, 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.ForeColor = System.Drawing.Color.Yellow;
            this.subtitle.Location = new System.Drawing.Point(subTitleXLocation, 88);
            this.subtitle.Margin = new System.Windows.Forms.Padding(0);
            this.subtitle.Name = "subtitle";
            this.subtitle.Text = subTitleText;
            // 
            // subtitle_bar
            // 
            this.subtitle_bar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subtitle_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.subtitle_bar.Location = new System.Drawing.Point(107, 78);
            this.subtitle_bar.Margin = new System.Windows.Forms.Padding(0);
            this.subtitle_bar.Name = "subtitle_bar";
            this.subtitle_bar.Size = new System.Drawing.Size(683, 48);
            // 
            // back_button
            // 
            this.back_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.back_button.Enabled = backButtonEnabled;
            this.back_button.Font = new System.Drawing.Font("Savile ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(107, 555);
            this.back_button.Margin = new System.Windows.Forms.Padding(0);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(514, 37);
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // next_button
            // 
            this.next_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.next_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.next_button.Enabled = false;
            this.next_button.Font = new System.Drawing.Font("Savile ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.next_button.ForeColor = System.Drawing.Color.White;
            this.next_button.Location = new System.Drawing.Point(620, 555);
            this.next_button.Margin = new System.Windows.Forms.Padding(0);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(171, 37);
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = false;
            // 
            // loader
            // 
            this.loader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loader.Location = new System.Drawing.Point(0, 0);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(800, 600);
            this.loader.Visible = false;
            this.loader.Paint += new System.Windows.Forms.PaintEventHandler(this.Loader_Paint);
            // 
            // HidableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.version_number);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.sidenav);
            this.Controls.Add(this.title);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.subtitle_bar);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.next_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.logo;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jon Betts's CM 01/02 Starter Kit";
            ((System.ComponentModel.ISupportInitialize)(this.sidenav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.title_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtitle_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // HidableForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "HidableForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Label version_number;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox sidenav;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox title_bar;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.PictureBox subtitle_bar;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.PictureBox loader;
    }
}
