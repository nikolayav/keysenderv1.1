using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMsgBox {
    public partial class CustomMessageBox : Form {
        public CustomMessageBox() {
            InitializeComponent();
        }

        public void Init (string version, string description, string usage, string author, string btnCancel, Image image) {
            this.vLabel.Text = version;
            this.descLabel.Text = description;
            this.usageLabel.Text = usage;
            this.authLabel.Text = author;
            this.button1.Text = btnCancel;
            this.pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
