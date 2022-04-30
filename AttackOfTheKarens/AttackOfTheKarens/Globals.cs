using System.Collections.Generic;
using System.Windows.Forms;

namespace AttackOfTheKarens {
  public static class Globals {
    public static List<Form> openForms;

    static Globals() {
      openForms = new List<Form>(); 
    }

    public static void CloseAll() {
      for (int i = 0; i < openForms.Count; i++) {
        openForms[i].Close();
      }
    }
  }
}
