using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalOptionalApp.Views.Component
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuickHelpItem : StackLayout
    {
        public QuickHelpItem()
        {
            InitializeComponent();
        }
    }
}