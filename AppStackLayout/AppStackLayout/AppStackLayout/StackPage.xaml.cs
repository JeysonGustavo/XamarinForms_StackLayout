using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppStackLayout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackPage : ContentPage
	{
		public StackPage ()
		{
			InitializeComponent ();

            //criando Stack Layout pelo C#
            var layout = new StackLayout
            {
                Spacing = 40,
                Padding = new Thickness(0, 20, 0, 0),
                Orientation = StackOrientation.Horizontal
            };

            layout.Children.Add(new Label { Text = "Label 1" });
            layout.Children.Add(new Label { Text = "Label 2" });
            layout.Children.Add(new Label { Text = "Label 3" });

            Content = layout;
		}
	}
}