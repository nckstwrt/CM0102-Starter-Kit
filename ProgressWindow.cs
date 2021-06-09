using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CM0102_Starter_Kit {
    public partial class ProgressWindow : Form {
        public ProgressWindow(string labelText, int labelXLocation) {
            InitializeComponent();
            this.label.Text = labelText;
            this.label.Location = new System.Drawing.Point(labelXLocation, 7);
        }

        public void SetProgressPercentage(int percentage) {
            this.progressBar.Invoke((MethodInvoker) delegate {
                this.progressBar.Value = percentage;
            });
        }
    }
}
