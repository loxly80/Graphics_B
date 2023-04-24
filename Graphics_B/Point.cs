using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Graphics_B
{
  public class Point
  {
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
      X = x;
      Y = y;
    }

    public void AddToCanvas(Canvas canvas)
    {
      Ellipse ellipse = new Ellipse();
      ellipse.Width = 8;
      ellipse.Height = 8;
      ellipse.Fill = Brushes.Black;
      Canvas.SetLeft(ellipse,X - 4);
      Canvas.SetTop(ellipse,Y - 4);
      canvas.Children.Add(ellipse);
    }
  }
}
