using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChowderApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomPage : TabbedPage
    {
        public HomPage ()
        {
            InitializeComponent();
        }
    }
}