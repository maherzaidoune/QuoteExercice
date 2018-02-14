using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuoteExercice
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class quote : ContentPage
	{
        byte index = 0;
        String[] quoteList = {
            "Programming is the art of algorithm design and the craft of debugging errant code.",
            "Most good programmers do programming not because they expect to get paid or get adulation by the public, but because it is fun to program.",
            "Everyday life is like programming, I guess. If you love something you can put beauty into it.",
            "Successful weight loss takes programming, not willpower.",
            "'Programming' is a four-letter word.",
            "There was something amazingly enticing about programming."
        };
		public quote ()
		{
			InitializeComponent ();
            label.Text = quoteList[0];
            slide.Value = 0.5;
        }
        void onClicked(object sender, EventArgs e)
        {
            ++index;
            if (index == 6)
                index = 0;
            label.Text = quoteList[index];
        }
        void onValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.FontSize =  e.NewValue * 50 + 5;
        }
    }
}