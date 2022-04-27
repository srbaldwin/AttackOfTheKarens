using System.Drawing;

namespace AttackOfTheKarens {
  public static class MyExtensionMethods {
    public static Color Mult(this Color color, Color other) {
      double[] a = new double[] { color.A / 255.0, color.R / 255.0, color.G / 255.0, color.B / 255.0 };  
      double[] b = new double[] { other.A / 255.0, other.R / 255.0, other.G / 255.0, other.B / 255.0 };  
      double[] c = new double[] { a[0] * b[0], a[1] * b[1], a[2] * b[2], a[3] * b[3]};
      byte[] d = new byte[] { (byte)(c[0]*255), (byte)(c[1] * 255), (byte)(c[2] * 255), (byte)(c[3] * 255) };
      return Color.FromArgb(d[0], d[1], d[2], d[3]);
    }
    public static void Tint(this Image img, Color color) {
      Bitmap bmp = (Bitmap)img;
      for (int y = 0; y < bmp.Height; y++) {
        for (int x = 0; x < bmp.Width; x++) {
          bmp.SetPixel(x, y, bmp.GetPixel(x, y).Mult(color));
        }
      }
    }
  }
}
