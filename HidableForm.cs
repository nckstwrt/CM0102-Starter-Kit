using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CM0102_Starter_Kit {
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<HidableForm, Form>))]
    abstract partial class HidableForm : Form {
        public HidableForm()
        {
            LoadFonts();
        }

        protected MainMenu mainMenu;
        protected abstract List<Button> GetButtons();

        protected virtual void RefreshForm() { }

        private void ToggleButtons(bool toggle) {
            exit.Enabled = toggle;
            back_button.Enabled = toggle;

            foreach (Button button in GetButtons()) {
                button.Enabled = toggle;
            }
        }

        protected void ShowLoader() {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.loader.Visible = true;
            ToggleButtons(false);
        }

        protected void HideLoader() {
            this.Cursor = System.Windows.Forms.Cursors.Default;
            ToggleButtons(true);
            this.loader.Visible = false;
        }

        private void RenderLoader(PaintEventArgs e) {
            StringFormat format = new StringFormat {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            };
            e.Graphics.DrawString("Please Wait...", new Font("Verdana", 18, FontStyle.Bold), Brushes.White, this.ClientRectangle, format);
        }

        private void Loader_Paint(object sender, PaintEventArgs e) {
            RenderLoader(e);
        }

        protected void DisplayMessage(string message) {
            using (new CentreMessageBox(this)) {
                MessageBox.Show(message);
            }
        }

        protected void ShowNewScreen(HidableForm newForm) {
            this.Hide();
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;
            newForm.Size = this.Size;
            newForm.RefreshForm();
            newForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e) {
            ShowNewScreen(mainMenu);
        }

        private void Exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Nick's wacky font code :)
        public static PrivateFontCollection pfcErasDemiBt = null;
        public static FontFamily ffErasDemiBt = null;
        public static PrivateFontCollection pfcHandelGo = null;
        public static FontFamily ffHandelGo = null;

        void LoadFonts()
        {
            if (pfcErasDemiBt == null)
            {
                pfcErasDemiBt = LoadFont("ErasDemiBT.ttf");
                ffErasDemiBt = pfcErasDemiBt.Families[0];
                pfcHandelGo = LoadFont("HandelGo.ttf");
                ffHandelGo = pfcHandelGo.Families[0];
            }
        }

        PrivateFontCollection LoadFont(string fontName)
        {
            var pfc = new PrivateFontCollection();

            var assembly = Assembly.GetExecutingAssembly();
            var resNames = assembly.GetManifestResourceNames();
            string resourceName = "";
            foreach (var r in resNames)
            {
                if (r.EndsWith(fontName))
                {
                    resourceName = r;
                    break;
                }
            }

            using (var fontStream = assembly.GetManifestResourceStream(resourceName))
            {
                // Copy font stream into a byte array
                var fontBytes = new byte[fontStream.Length];
                fontStream.Read(fontBytes, 0, fontBytes.Length);

                // Create unsafe memory block
                var newMemory = Marshal.AllocCoTaskMem(fontBytes.Length);

                // copy the bytes to the unsafe memory block
                Marshal.Copy(fontBytes, 0, newMemory, fontBytes.Length);
                pfc.AddMemoryFont(newMemory, fontBytes.Length);

                // Free the memory
                Marshal.FreeCoTaskMem(newMemory);
            }

            return pfc;
        }
    }

    public class AbstractControlDescriptionProvider<TAbstract, TBase> : TypeDescriptionProvider {
        public AbstractControlDescriptionProvider() : base(TypeDescriptor.GetProvider(typeof(TAbstract))) { }

        public override Type GetReflectionType(Type objectType, object instance) {
            if (objectType == typeof(TAbstract)) {
                return typeof(TBase);
            }
            return base.GetReflectionType(objectType, instance);
        }

        public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) {
            if (objectType == typeof(TAbstract)) {
                objectType = typeof(TBase);
            }
            return base.CreateInstance(provider, objectType, argTypes, args);
        }
    }
}

