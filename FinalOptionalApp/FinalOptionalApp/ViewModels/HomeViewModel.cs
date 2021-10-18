using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;
using Prism.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using FinalOptionalApp.Models;

namespace FinalOptionalApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<MusicItem> MusicItems { get; }

        public QuickHelpItem BreatheQuickItem { get; set; }
        public QuickHelpItem SleepQuickItem { get; set; }
        public QuickHelpItem AnxietyQuickItem { get; set; }
        public QuickHelpItem StressQuickItem { get; set; }
        public QuickHelpItem PenguinQuickItem { get; set; }


        private ICommand SelectedMusicItemCommand { get; }

        private MusicItem _selectedMusicItem;

        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            SelectedMusicItemCommand = new DelegateCommand(OnSelectedItem);

            BreatheQuickItem = new QuickHelpItem("breathe_image.png", "Breathe");
            SleepQuickItem = new QuickHelpItem("meditation_icon.png", "Sleep");
            AnxietyQuickItem = new QuickHelpItem("anxiety_image.png", "Anxiety");
            StressQuickItem = new QuickHelpItem("stress_image.png", "Stress");
            PenguinQuickItem = new QuickHelpItem("penguin_icon.jpg", "Penguin");

            MusicItems = new ObservableCollection<MusicItem>
            {
                new MusicItem("penguin_icon.jpg","Raining Sidewalk","Penguins (order Sphenisciformes /sfɪˈnɪsɪfɔːrmiːz/, family Spheniscidae /sfɪˈnɪsɪdiː/) are a group of aquatic flightless birds. They live almost exclusively in the southern hemisphere: only one species, the Galápagos penguin, is found north of the Equator. Highly adapted for life in the water, penguins have countershaded dark and white plumage and flippers for swimming. Most penguins feed on krill, fish, squid and other forms of sea life which they catch while swimming underwater. They spend roughly half of their lives on land and the other half in the sea.",5),
                new MusicItem("penguin_icon.jpg","Spring Morning","Penguins (order Sphenisciformes /sfɪˈnɪsɪfɔːrmiːz/, family Spheniscidae /sfɪˈnɪsɪdiː/) are a group of aquatic flightless birds. They live almost exclusively in the southern hemisphere: only one species, the Galápagos penguin, is found north of the Equator. Highly adapted for life in the water, penguins have countershaded dark and white plumage and flippers for swimming. Most penguins feed on krill, fish, squid and other forms of sea life which they catch while swimming underwater. They spend roughly half of their lives on land and the other half in the sea.",7),
                new MusicItem("penguin_icon.jpg","First Step","Penguins (order Sphenisciformes /sfɪˈnɪsɪfɔːrmiːz/, family Spheniscidae /sfɪˈnɪsɪdiː/) are a group of aquatic flightless birds. They live almost exclusively in the southern hemisphere: only one species, the Galápagos penguin, is found north of the Equator. Highly adapted for life in the water, penguins have countershaded dark and white plumage and flippers for swimming. Most penguins feed on krill, fish, squid and other forms of sea life which they catch while swimming underwater. They spend roughly half of their lives on land and the other half in the sea.",30),
                new MusicItem("penguin_icon.jpg","Penguins","Penguins (order Sphenisciformes /sfɪˈnɪsɪfɔːrmiːz/, family Spheniscidae /sfɪˈnɪsɪdiː/) are a group of aquatic flightless birds. They live almost exclusively in the southern hemisphere: only one species, the Galápagos penguin, is found north of the Equator. Highly adapted for life in the water, penguins have countershaded dark and white plumage and flippers for swimming. Most penguins feed on krill, fish, squid and other forms of sea life which they catch while swimming underwater. They spend roughly half of their lives on land and the other half in the sea.",26),
            };
        }
        private async void OnSelectedItem()
        {
            var parameter = new NavigationParameters();
            parameter.Add("SelectedMusicItem", SelectedMusicItem);
            await NavigationService.NavigateAsync(Navigation.Detail, parameter);
        }
        public MusicItem SelectedMusicItem
        {
            get
            {
                return _selectedMusicItem;
            }
            set
            {
                _selectedMusicItem = value;
                if (_selectedMusicItem != null)
                {
                    SelectedMusicItemCommand.Execute(_selectedMusicItem);
                }
                SelectedMusicItem = null;
            }
        }
    }
}
