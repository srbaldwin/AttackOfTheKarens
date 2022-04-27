using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttackOfTheKarens.code {
  public class Karen {
    public int Row { get; set; }
    public int Col { get; set; }
    public bool isPresent;
    public PictureBox pic;

    public Karen(PictureBox pic) {
      this.pic = pic;
      this.isPresent = false;
    }
  }
}
