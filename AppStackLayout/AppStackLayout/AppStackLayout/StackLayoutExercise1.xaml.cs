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
	public partial class StackLayoutExercise1 : ContentPage
	{
		public StackLayoutExercise1 ()
		{
			InitializeComponent ();
		}

        private void ShowExercise2(object sender, EventArgs args)
        {
            App.Current.MainPage = new StackLayoutExercise2();
        }

    }
}