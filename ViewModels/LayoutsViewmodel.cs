using MyFirstMobileApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstMobileApp.ViewModels
{
    public class LayoutsViewModel : BaseViewModel
    {
        public LayoutsViewModel()
        {
            Title = TitleLayout.Title;

            TitleButtonStackLayout = TitleLayout.TitleButtonStackLayout;

            TitleButtonVerticalStack = TitleLayout.TitleButtonVerticalStack;

            TitleButtonHorizontalStack = TitleLayout.TitleButtonHorizontalStack;

            TitleButtonAbsoluteLayout = TitleLayout.TitleButtonAbsoluteLayout;
        }

        public string TitleButtonStackLayout { get; }
        public string TitleButtonVerticalStack { get; }
        public string TitleButtonHorizontalStack { get; }
        public string TitleButtonAbsoluteLayout { get; }
    }
}
