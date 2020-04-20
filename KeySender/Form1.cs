using SnagFree.TrayApp.Core;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace KeySender {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;
        }

        private GlobalKeyboardHook _globalKeyboardHook;

        private void Form1_Load(object sender, EventArgs e) {
            this.Hide();
            this.ShowInTaskbar = false;
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.Visible = true;
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e) {
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyUp) {
                //detect a right-ctrl key-up
                if ((e.KeyboardData.HardwareScanCode == 29) && (e.KeyboardData.VirtualCode == 163)) {
                    tmrSendKeys.Start();
                }
            }
        }

        private void SendText() {

            string clipboardText;
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text)) {
                clipboardText = (String)iData.GetData(DataFormats.Text);
            } else {
                return;
            }

            // remove excess new lines
            clipboardText = clipboardText.Replace("\r\n\r\n", "\n").Replace("\r\n", "\n");
            
            char[] specialChars = { '{', '}', '(', ')', '+', '^' };

            foreach (char letter in clipboardText) {
                bool isSpecialChar = false;

                for (int i = 0; i < specialChars.Length; i++) {
                    if (letter == specialChars[i]) {
                        isSpecialChar = true;
                        break;
                    }
                }

                if (isSpecialChar)
                    SendKeys.Send("{" + letter.ToString() + "}");
                else
                    SendKeys.Send(letter.ToString());
            }    
        }

        private void tmrSendKeys_Tick(object sender, EventArgs e) {
            tmrSendKeys.Stop();
            SendText();
        }

        private void mnuExit_Click(object sender, EventArgs e) {
            notifyIcon1.Visible = false;
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e) {
            using (CustomMsgBox.CustomMessageBox infoMsg = new CustomMsgBox.CustomMessageBox()) {
                Image img = Properties.Resources.msgBoxImage.ToBitmap();
                infoMsg.Init("KeySender v1.1", "Auto-types from clipboard to any textfield", "1. Copy text to your clipboard\n2. Select a textfield\n3. Press Right-Ctrl button to auto-type the text", "Author: Nikolay Avroniev", "Close", img);
                infoMsg.ShowDialog(this);
            };
        }
    }
}

