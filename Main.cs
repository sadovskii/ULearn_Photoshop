using MyPhotoshop.Filters;
using System;
using System.Windows.Forms;
using MyPhotoshop.Filters.Parameters;

namespace MyPhotoshop
{
	class MainClass
	{
        [STAThread]
		public static void Main (string[] args)
		{
			var window=new MainWindow();

			window.AddFilter (new PixelFilter<LighteningParameters>(
                "����������/����������",
                (pixel, parameters) => pixel * parameters.Coefficient));

            window.AddFilter(new PixelFilter<EmptyParameters>(
                "������� ������", 
                (pixel, parameters) => pixel.Grayscale()));

            Application.Run (window);
		}
	}
}
