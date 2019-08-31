using SchoolNetwork.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolNetwork.Forms
{
    internal partial class OffLineForm : Form
    {
        private Configuration config { get; set; }
        public OffLineForm(Configuration config)
        {
            InitializeComponent();
            this.config = config;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            config.CallMethod("Offline", new object[] { });
        }
    }
}
