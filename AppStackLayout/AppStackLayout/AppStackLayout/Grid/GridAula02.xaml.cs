using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppStackLayout.Grid
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridAula02 : ContentPage
	{
		public GridAula02 ()
		{
			InitializeComponent ();

            // Criar Grid via C#

            /*
            var grid = new Xamarin.Forms.Grid
            {
                RowSpacing = 20,
                ColumnSpacing = 20
            };

            var label = new Label { Text = "Label 1" };
            grid.Children.Add(label, 0, 0);
            Xamarin.Forms.Grid.SetRowSpan(label, 2);
            Xamarin.Forms.Grid.SetColumnSpan(label, 2);
            Xamarin.Forms.Grid.SetRow(label, 0);
            Xamarin.Forms.Grid.SetColumn(label, 0);

            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(100, GridUnitType.Absolute)
            });

            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(2, GridUnitType.Star)
            });

            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(1, GridUnitType.Auto)
            });

            */

        }
	}
}