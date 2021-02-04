using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace businessCard
{
    public partial class İnfo : MetroFramework.Forms.MetroForm
    {
        public İnfo()
        {
            InitializeComponent();
        }

        private void İnfo_Load(object sender, EventArgs e)
        {

        }

        private void btn_insta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/angry.eye.code/");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/mahmutb48/");
        }

        private void btn_youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCF9-MdUUG7V9ulI96PVolVA");
        }
    }
}
