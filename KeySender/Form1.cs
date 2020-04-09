using SnagFree.TrayApp.Core;
using System;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace KeySender {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private GlobalKeyboardHook _globalKeyboardHook;
        private void Form1_Load(object sender, EventArgs e) {
            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e) {
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyUp) {
                //detect a right-ctrl key-up
                if ((e.KeyboardData.HardwareScanCode == 29) && (e.KeyboardData.VirtualCode == 163)) {
                    IntPtr windowdHandle = NativeWin32.GetForegroundWindow();
                    //If the foreground window is this application (Key Sender) then ignore it.
                    if (!windowdHandle.Equals(this.Handle)) {
                        tmrSendKeys.Start();
                    }
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
         
        }

        private void SendText() {
            char[] specialChars = { '{', '}', '(', ')', '+', '^' };
            string str = richTextBox1.Text;

            foreach (char letter in str) {
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

        private void AboutToolstripButton_Click(object sender, EventArgs e) {
            
            string usageInfo = "Name: Key Sender\n" +
                               "Version: 1.0\n" +
                               "Author: Nikolay Avroniev\n\n" +
                               "Description: A simple application that sends individual keystrokes to an external textfield.\n\n" +
                               
                               "Usage:\n" +
                               "1. Type the text you need copied in the textbox field. \n" +
                               "2. Select a destination text field. \n" +
                               "3. Press \"Right-Ctrl\" button.";
           
            MessageBox.Show(usageInfo, "About", MessageBoxButtons.OK, MessageBoxIcon.None);
            
        }
    }
}

