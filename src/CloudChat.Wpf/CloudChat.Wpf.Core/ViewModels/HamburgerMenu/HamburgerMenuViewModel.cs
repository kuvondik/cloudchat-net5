using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudChat.Wpf.Core.ViewModels
{
    public class HamburgerMenuViewModel : MvxViewModel
    {
        private bool _isMenuExtended;
        private MvxObservableCollection<IMvxViewModel> _contents;
        private IMvxViewModel _currentContent;
        private MvxObservableCollection<IMvxViewModel> _menuItems;
        private MvxObservableCollection<IMvxViewModel> _options;
     
        public bool IsMenuExtended 
        {
            get => _isMenuExtended;
            set 
            {
                SetProperty(ref _isMenuExtended, value);
            } 
        }
        public MvxObservableCollection<IMvxViewModel> Contents 
        { 
            get => _contents;
            set 
            {
                SetProperty(ref _contents, value);
            } 
        }
        public IMvxViewModel CurrentContent
        {
            get => _currentContent;
            set
            {
                SetProperty(ref _currentContent, value);
            }
        }
        public MvxObservableCollection<IMvxViewModel> MenuItems 
        {
            get => _menuItems;
            set 
            {
                SetProperty(ref _menuItems, value);
            }
        }
        public MvxObservableCollection<IMvxViewModel> Options
        {
            get => _options;
            set
            {
                SetProperty(ref _options, value);
            }
        }

        public HamburgerMenuViewModel()
        {

        }
    }
}
