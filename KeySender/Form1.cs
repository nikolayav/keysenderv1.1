using SnagFree.TrayApp.Core;
using System;
using System.Text;
using System.Windows.Forms;


namespace KeySender {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;
        }

        string usageInfo =     "Name: Key Sender\n" +
                               "Version: 1.1\n" +
                               "Author: Nikolay Avroniev\n\n" +
                               "Description: A simple application that sends individual keystrokes to an external textfield.\n\n" +
                               "Usage:\n" +
                               "1. Copy text in your clipboard. \n" +
                               "2. Press \"Right-Ctrl\" button in a text field.";

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
            clipboardText = clipboardText.Replace("\r\n", "\r").Replace("\n", "\r");
            StringBuilder sb = new StringBuilder();

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
                    sb.Append("{" + letter.ToString() + "}");
                else
                    sb.Append(letter.ToString());
            }
            SendKeys.Send(sb.ToString());
            
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
            MessageBox.Show(usageInfo, "About", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}

