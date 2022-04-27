using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackOfTheKarens.code {
  public class Store {
    private Karen karen;

    public Store(Karen karen) {
      this.karen = karen;
    }

    public void ActivateTheKaren() {
      karen.isPresent = true;
      karen.pic.Visible = true;
      karen.pic.BringToFront();
    }
  }
}
