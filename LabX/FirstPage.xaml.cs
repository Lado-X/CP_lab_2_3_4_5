using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace LabXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Label1.Text = Entry1.Text;
        }
    }
}
