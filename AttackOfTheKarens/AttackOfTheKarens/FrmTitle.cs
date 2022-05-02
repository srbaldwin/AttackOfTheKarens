using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttackOfTheKarens {
  public partial class FrmTitle : Form {
    SoundPlayer? player;
    public FrmTitle() {
      InitializeComponent();
    }

    private void FrmTitle_Load(object sender, EventArgs e) {
      Globals.openForms.Add(this);
      player = new SoundPlayer();
      player.SoundLocation = "data/karen music.wav";
      player.PlayLooping();
    }

    private void btnStart_Click(object sender, EventArgs e) {
      player?.Stop();
      FrmMall frmMall = new FrmMall();
      frmMall.Show();
      this.Hide();
    }

    private void FrmTitle_FormClosed(object sender, FormClosedEventArgs e) {
      Globals.openForms.Remove(this);
      Globals.CloseAll();
    }
  }
}
