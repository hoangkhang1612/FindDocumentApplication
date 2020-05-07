using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FindActress.Controls
{
    public class CustomContentPage : ContentPage
    {
        //public enum MenuButtonMode
        //{
        //    None,
        //    Search,
        //    Filter,
        //    More,
        //    Close,
        //    Setting,
        //    Text
        //}

        public static BindableProperty IsBackButtonEnabledProperty =
            BindableProperty.Create(nameof(IsBackButtonEnabled), typeof(bool), typeof(CustomContentPage), false);

        public static BindableProperty IsCenterBackVisibleProperty =
            BindableProperty.Create(nameof(IsCenterBackVisible), typeof(bool), typeof(CustomContentPage), true);

        public static BindableProperty IsLeftBackVisibleProperty =
            BindableProperty.Create(nameof(IsLeftBackVisible), typeof(bool), typeof(CustomContentPage), false);

        public static BindableProperty IsBackTitleVisibleProperty =
            BindableProperty.Create(nameof(IsBackTitleVisible), typeof(bool), typeof(CustomContentPage), false);

        public static BindableProperty PageBackTitleProperty =
            BindableProperty.Create(nameof(PageBackTitle), typeof(string), typeof(CustomContentPage), string.Empty);

        public static BindableProperty BackButtonTappedCommandProperty =
            BindableProperty.Create(nameof(BackButtonTappedCommand), typeof(ICommand), typeof(CustomContentPage), null);

        public static BindableProperty IsTitleVisibleProperty =
            BindableProperty.Create(nameof(IsTitleVisible), typeof(bool), typeof(CustomContentPage), false);

        public static BindableProperty PageTitleProperty =
            BindableProperty.Create(nameof(PageTitle), typeof(string), typeof(CustomContentPage), string.Empty);

        //public static BindableProperty IsLeftMenuButtonEnabledProperty =
        //    BindableProperty.Create(nameof(IsLeftMenuButtonEnabled), typeof(bool), typeof(CustomContentPage), false);

        //public static BindableProperty IsMenuButton1EnabledProperty =
        //    BindableProperty.Create(nameof(IsMenuButton1Enabled), typeof(bool), typeof(CustomContentPage), false);

        //public static BindableProperty MenuButton1IconProperty =
        //    BindableProperty.Create(nameof(MenuButton1Icon), typeof(string), typeof(CustomContentPage), string.Empty);

        //public static BindableProperty MenuButton1TappedCommandProperty =
        //    BindableProperty.Create(nameof(MenuButton1TappedCommand), typeof(ICommand), typeof(CustomContentPage), null);

        //public static BindableProperty IsMenuButton2EnabledProperty =
        //    BindableProperty.Create(nameof(IsMenuButton2Enabled), typeof(bool), typeof(CustomContentPage), false);

        //public static BindableProperty MenuButton2IconProperty =
        //    BindableProperty.Create(nameof(MenuButton2Icon), typeof(string), typeof(CustomContentPage), string.Empty);

        //public static BindableProperty MenuButton2TappedCommandProperty =
        //    BindableProperty.Create(nameof(MenuButton2TappedCommand), typeof(ICommand), typeof(CustomContentPage), null);

        //public static BindableProperty IsMenuButton3EnabledProperty =
        //    BindableProperty.Create(nameof(IsMenuButton3Enabled), typeof(bool), typeof(CustomContentPage), false);

        //public static BindableProperty MenuButton3TitleProperty =
        //    BindableProperty.Create(nameof(MenuButton3Title), typeof(string), typeof(CustomContentPage), string.Empty);

        //public static BindableProperty MenuButton3TappedCommandProperty =
        //    BindableProperty.Create(nameof(MenuButton3TappedCommand), typeof(ICommand), typeof(CustomContentPage), null);

        //public static BindableProperty AvatarTappedCommandProperty =
        //    BindableProperty.Create(nameof(AvatarTappedCommand), typeof(ICommand), typeof(CustomContentPage), null);

        //public static BindableProperty IsMenuButton4EnabledProperty =
        //    BindableProperty.Create(nameof(IsMenuButton4Enabled), typeof(bool), typeof(CustomContentPage), false);

        //public static BindableProperty MenuButton4IconProperty =
        //    BindableProperty.Create(nameof(MenuButton4Icon), typeof(string), typeof(CustomContentPage), string.Empty);

        //public static BindableProperty MenuButton4TappedCommandProperty =
        //    BindableProperty.Create(nameof(MenuButton4TappedCommand), typeof(ICommand), typeof(CustomContentPage), null);

        //public static BindableProperty IsSearchViewVisibleProperty =
        //    BindableProperty.Create(nameof(IsSearchViewVisible), typeof(bool), typeof(CustomContentPage), false);

        //public static BindableProperty SearchGoButtonTappedCommandProperty =
        //    BindableProperty.Create(nameof(SearchGoButtonTappedCommand), typeof(ICommand), typeof(CustomContentPage), null);

        //public static BindableProperty SearchTextChangedCommandProperty =
        //    BindableProperty.Create(nameof(SearchTextChangedCommand), typeof(ICommand), typeof(CustomContentPage), null);

        //public static BindableProperty SearchCancelButtonTappedCommandProperty =
        //    BindableProperty.Create(nameof(SearchCancelButtonTappedCommand), typeof(ICommand), typeof(CustomContentPage), null);

        //public static BindableProperty SearchTextProperty =
        //    BindableProperty.Create(nameof(SearchText), typeof(string), typeof(CustomContentPage), string.Empty);

        //public static BindableProperty IsFilterViewVisibleProperty =
        //    BindableProperty.Create(nameof(IsFilterViewVisible), typeof(bool), typeof(CustomContentPage), false);

        //public static BindableProperty FilterCancelButtonTappedCommandProperty =
        //    BindableProperty.Create(nameof(FilterCancelButtonTappedCommand), typeof(ICommand), typeof(CustomContentPage), null);

        //public static BindableProperty FilterApplyButtonTappedCommandProperty =
        //    BindableProperty.Create(nameof(FilterApplyButtonTappedCommand), typeof(ICommand), typeof(CustomContentPage), null);

        //public static BindableProperty FilterTitleProperty =
        //    BindableProperty.Create(nameof(FilterTitle), typeof(string), typeof(CustomContentPage), string.Empty);

        //public static BindableProperty IsProfileImageVisibleProperty =
        //    BindableProperty.Create(nameof(IsProfileImageVisible), typeof(bool), typeof(CustomContentPage), false);

        //public static BindableProperty ProfileImageProperty =
        //    BindableProperty.Create(nameof(ProfileImage), typeof(string), typeof(CustomContentPage), string.Empty);

        //private MenuButtonMode _menuButton1;

        //private MenuButtonMode _menuButton2;

        //private MenuButtonMode _menuButton3;

        //private MenuButtonMode _menuButton4;

        public CustomContentPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeProperties();
        }

        //public MenuButtonMode MenuButton1
        //{
        //    get => _menuButton1;
        //    set
        //    {
        //        _menuButton1 = value;

        //        switch (value)
        //        {
        //            case MenuButtonMode.None:
        //                IsMenuButton1Enabled = false;
        //                break;
        //            case MenuButtonMode.Search:
        //                IsMenuButton1Enabled = true;
        //                MenuButton1Icon = "ic_nav_search";
        //                break;
        //            case MenuButtonMode.More:
        //                IsMenuButton1Enabled = true;
        //                MenuButton1Icon = "ic_nav_more";
        //                break;
        //            case MenuButtonMode.Filter:
        //                IsMenuButton1Enabled = true;
        //                MenuButton1Icon = "ic_nav_filter";
        //                break;
        //            case MenuButtonMode.Close:
        //                IsMenuButton1Enabled = true;
        //                MenuButton1Icon = "ic_nav_cancel";
        //                break;
        //            case MenuButtonMode.Setting:
        //                IsMenuButton1Enabled = true;
        //                MenuButton1Icon = "ic_nav_setting";
        //                break;
        //        }
        //    }
        //}

        //public MenuButtonMode MenuButton2
        //{
        //    get => _menuButton2;
        //    set
        //    {
        //        _menuButton2 = value;

        //        switch (value)
        //        {
        //            case MenuButtonMode.None:
        //                IsMenuButton2Enabled = false;
        //                break;
        //            case MenuButtonMode.Search:
        //                IsMenuButton2Enabled = true;
        //                MenuButton2Icon = "ic_nav_search";
        //                break;
        //            case MenuButtonMode.Filter:
        //                IsMenuButton2Enabled = true;
        //                MenuButton2Icon = "ic_nav_filter";
        //                break;
        //            case MenuButtonMode.Setting:
        //                IsMenuButton2Enabled = true;
        //                MenuButton2Icon = "ic_nav_setting";
        //                break;
        //        }
        //    }
        //}

        //public MenuButtonMode MenuButton3
        //{
        //    get => _menuButton3;
        //    set
        //    {
        //        _menuButton3 = value;

        //        switch (value)
        //        {
        //            case MenuButtonMode.Text:
        //                IsMenuButton3Enabled = true;
        //                break;
        //            case MenuButtonMode.None:
        //            case MenuButtonMode.Search:
        //            case MenuButtonMode.Filter:
        //            case MenuButtonMode.Setting:
        //                IsMenuButton3Enabled = false;
        //                break;
        //        }
        //    }
        //}

        //public MenuButtonMode MenuButton4
        //{
        //    get => _menuButton4;
        //    set
        //    {
        //        _menuButton4 = value;

        //        switch (_menuButton4)
        //        {
        //            case MenuButtonMode.None:
        //                IsMenuButton4Enabled = false;
        //                break;
        //            case MenuButtonMode.Search:
        //                IsMenuButton4Enabled = true;
        //                MenuButton4Icon = "ic_nav_search";
        //                break;
        //            case MenuButtonMode.Filter:
        //                IsMenuButton4Enabled = true;
        //                MenuButton4Icon = "ic_nav_filter";
        //                break;
        //            case MenuButtonMode.More:
        //                IsMenuButton4Enabled = true;
        //                MenuButton4Icon = "ic_nav_more";
        //                break;
        //            case MenuButtonMode.Setting:
        //                IsMenuButton4Enabled = true;
        //                MenuButton4Icon = "ic_nav_setting";
        //                break;
        //        }

        //        IsLeftMenuButtonEnabled = _menuButton4 != MenuButtonMode.None && !IsBackButtonEnabled;
        //    }
        //}

        public bool IsBackButtonEnabled
        {
            get => (bool)GetValue(IsBackButtonEnabledProperty);
            set => SetValue(IsBackButtonEnabledProperty, value);
        }

        public bool IsCenterBackVisible
        {
            get => (bool)GetValue(IsCenterBackVisibleProperty);
            set => SetValue(IsCenterBackVisibleProperty, value);
        }

        public bool IsLeftBackVisible
        {
            get => (bool)GetValue(IsLeftBackVisibleProperty);
            set => SetValue(IsLeftBackVisibleProperty, value);
        }

        public bool IsBackTitleVisible
        {
            get => (bool)GetValue(IsBackTitleVisibleProperty);
            set => SetValue(IsBackTitleVisibleProperty, value);
        }

        public string PageBackTitle
        {
            get => (string)GetValue(PageBackTitleProperty);
            set
            {
                SetValue(PageBackTitleProperty, value);

                var isCenterBack = string.IsNullOrEmpty(value);

                IsCenterBackVisible = isCenterBack;
                IsLeftBackVisible = !isCenterBack;
                IsBackTitleVisible = !isCenterBack;
            }
        }

        public ICommand BackButtonTappedCommand
        {
            get => (ICommand)GetValue(BackButtonTappedCommandProperty);
            set => SetValue(BackButtonTappedCommandProperty, value);
        }

        public bool IsTitleVisible
        {
            get => (bool)GetValue(IsTitleVisibleProperty);
            set => SetValue(IsTitleVisibleProperty, value);
        }

        public string PageTitle
        {
            get => (string)GetValue(PageTitleProperty);
            set => SetValue(PageTitleProperty, value);
        }

        //public bool IsLeftMenuButtonEnabled
        //{
        //    get => (bool)GetValue(IsLeftMenuButtonEnabledProperty);
        //    set => SetValue(IsLeftMenuButtonEnabledProperty, value);
        //}

        //public bool IsMenuButton1Enabled
        //{
        //    get => (bool)GetValue(IsMenuButton1EnabledProperty);
        //    set => SetValue(IsMenuButton1EnabledProperty, value);
        //}

        //public string MenuButton1Icon
        //{
        //    get => (string)GetValue(MenuButton1IconProperty);
        //    set => SetValue(MenuButton1IconProperty, value);
        //}

        //public ICommand MenuButton1TappedCommand
        //{
        //    get => (ICommand)GetValue(MenuButton1TappedCommandProperty);
        //    set => SetValue(MenuButton1TappedCommandProperty, value);
        //}

        //public bool IsMenuButton2Enabled
        //{
        //    get => (bool)GetValue(IsMenuButton2EnabledProperty);
        //    set => SetValue(IsMenuButton2EnabledProperty, value);
        //}

        //public string MenuButton2Icon
        //{
        //    get => (string)GetValue(MenuButton2IconProperty);
        //    set => SetValue(MenuButton2IconProperty, value);
        //}

        //public ICommand MenuButton2TappedCommand
        //{
        //    get => (ICommand)GetValue(MenuButton2TappedCommandProperty);
        //    set => SetValue(MenuButton2TappedCommandProperty, value);
        //}

        //public bool IsMenuButton3Enabled
        //{
        //    get => (bool)GetValue(IsMenuButton3EnabledProperty);
        //    set => SetValue(IsMenuButton3EnabledProperty, value);
        //}

        //public string MenuButton3Title
        //{
        //    get => (string)GetValue(MenuButton3TitleProperty);
        //    set => SetValue(MenuButton3TitleProperty, value);
        //}

        //public ICommand MenuButton3TappedCommand
        //{
        //    get => (ICommand)GetValue(MenuButton3TappedCommandProperty);
        //    set => SetValue(MenuButton3TappedCommandProperty, value);
        //}

        //public ICommand AvatarTappedCommand
        //{
        //    get => (ICommand)GetValue(AvatarTappedCommandProperty);
        //    set => SetValue(AvatarTappedCommandProperty, value);
        //}

        //public bool IsMenuButton4Enabled
        //{
        //    get => (bool)GetValue(IsMenuButton4EnabledProperty);
        //    set => SetValue(IsMenuButton4EnabledProperty, value);
        //}

        //public string MenuButton4Icon
        //{
        //    get => (string)GetValue(MenuButton4IconProperty);
        //    set => SetValue(MenuButton4IconProperty, value);
        //}

        //public ICommand MenuButton4TappedCommand
        //{
        //    get => (ICommand)GetValue(MenuButton4TappedCommandProperty);
        //    set => SetValue(MenuButton4TappedCommandProperty, value);
        //}

        //public bool IsSearchViewVisible
        //{
        //    get => (bool)GetValue(IsSearchViewVisibleProperty);
        //    set => SetValue(IsSearchViewVisibleProperty, value);
        //}

        //public ICommand SearchGoButtonTappedCommand
        //{
        //    get => (ICommand)GetValue(SearchGoButtonTappedCommandProperty);
        //    set => SetValue(SearchGoButtonTappedCommandProperty, value);
        //}

        //public ICommand SearchTextChangedCommand
        //{
        //    get => (ICommand)GetValue(SearchTextChangedCommandProperty);
        //    set => SetValue(SearchTextChangedCommandProperty, value);
        //}

        //public ICommand SearchCancelButtonTappedCommand
        //{
        //    get => (ICommand)GetValue(SearchCancelButtonTappedCommandProperty);
        //    set => SetValue(SearchCancelButtonTappedCommandProperty, value);
        //}

        //public string SearchText
        //{
        //    get => (string)GetValue(SearchTextProperty);
        //    set => SetValue(SearchTextProperty, value);
        //}

        //public bool IsFilterViewVisible
        //{
        //    get => (bool)GetValue(IsFilterViewVisibleProperty);
        //    set => SetValue(IsFilterViewVisibleProperty, value);
        //}

        //public ICommand FilterCancelButtonTappedCommand
        //{
        //    get => (ICommand)GetValue(FilterCancelButtonTappedCommandProperty);
        //    set => SetValue(FilterCancelButtonTappedCommandProperty, value);
        //}

        //public ICommand FilterApplyButtonTappedCommand
        //{
        //    get => (ICommand)GetValue(FilterApplyButtonTappedCommandProperty);
        //    set => SetValue(FilterApplyButtonTappedCommandProperty, value);
        //}

        //public string FilterTitle
        //{
        //    get => (string)GetValue(FilterTitleProperty);
        //    set => SetValue(FilterTitleProperty, value);
        //}

        //public bool IsProfileImageVisible
        //{
        //    get => (bool)GetValue(IsProfileImageVisibleProperty);
        //    set => SetValue(IsProfileImageVisibleProperty, value);
        //}

        //public string ProfileImage
        //{
        //    get => (string)GetValue(ProfileImageProperty);
        //    set => SetValue(ProfileImageProperty, value);
        //}

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        public virtual void ReloadData()
        {
        }

        public void InitializeProperties()
        {
            // Setup the back button visibility.
            var navigation = Application.Current.MainPage?.Navigation;
            IsBackButtonEnabled = navigation != null && navigation.NavigationStack.Count > 0;
            BackButtonTappedCommand = new Command(BackButtonTapped);

            PageTitle = string.Empty;
            IsTitleVisible = false;
            //IsProfileImageVisible = false;

            // Setup back button text.
            PageBackTitle = string.Empty;

            // Setup Right button.
            //MenuButton1 = MenuButtonMode.None;
            //MenuButton1TappedCommand = new Command(MenuButton1Tapped);
            //MenuButton2 = MenuButtonMode.None;
            //MenuButton2TappedCommand = new Command(MenuButton2Tapped);
            //MenuButton3 = MenuButtonMode.None;
            //MenuButton3TappedCommand = new Command(MenuButton3Tapped);
            //AvatarTappedCommand = new Command(AvatarTapped);

            // Setup Left button.
            //MenuButton4 = MenuButtonMode.None;
            //MenuButton4TappedCommand = new Command(MenuButton4Tapped);
            //IsLeftMenuButtonEnabled = false;

            // Setup Search View
            //SearchGoButtonTappedCommand = new Command(SearchGoButtonTapped);
            //SearchTextChangedCommand = new Command(SearchTextChanged);
            //SearchCancelButtonTappedCommand = new Command(SearchCancelButtonTapped);

            //CloseSearchView();

            // Setup Filter View
            //FilterCancelButtonTappedCommand = new Command(FilterCancelButtonTapped);
            //FilterApplyButtonTappedCommand = new Command(FilterApplyButtonTapped);
            //FilterTitle = AppResources.PageTitleFilterBy;

            //CloseFilterView();
        }

        protected virtual void BackButtonTapped()
        {
            var navigation = Application.Current.MainPage.Navigation;
            if (navigation != null && navigation.NavigationStack.Count > 0) navigation.PopAsync();
        }

        //protected virtual void MenuButton1Tapped()
        //{
        //    OnMenuButtonTapped(MenuButton1);
        //}

        //protected virtual void MenuButton2Tapped()
        //{
        //    OnMenuButtonTapped(MenuButton2);
        //}

        //protected virtual void MenuButton3Tapped()
        //{
        //    OnMenuButtonTapped(MenuButton3);
        //}

        //protected virtual void AvatarTapped()
        //{
        //}

        //protected virtual void MenuButton4Tapped()
        //{
        //    OnMenuButtonTapped(MenuButton4);
        //}

        //protected virtual void SearchGoButtonTapped()
        //{
        //    SearchWithText(SearchText);
        //}

        //protected virtual void SearchTextChanged()
        //{
        //    SearchingWithText(SearchText);
        //}

        //protected virtual void SearchCancelButtonTapped()
        //{
        //    CloseSearchView();
        //}

        //protected virtual void SearchWithText(string text)
        //{
        //}

        //protected virtual void SearchingWithText(string text)
        //{
        //}

        //protected void OnMenuButtonTapped(MenuButtonMode mode)
        //{
        //    switch (mode)
        //    {
        //        case MenuButtonMode.Search:
        //            OpenSearchView();
        //            break;
        //        case MenuButtonMode.Filter:
        //            OpenFilterView();
        //            break;
        //    }
        //}

        //protected void CloseSearchView()
        //{
        //    IsSearchViewVisible = false;
        //    SearchText = string.Empty;
        //}

        //protected void OpenSearchView()
        //{
        //    IsSearchViewVisible = true;
        //}

        //protected virtual void FilterCancelButtonTapped()
        //{
        //    CloseFilterView();
        //}

        //protected virtual void FilterApplyButtonTapped()
        //{
        //    CloseFilterView();
        //}

        //protected void CloseFilterView()
        //{
        //    IsFilterViewVisible = false;
        //}

        //protected void OpenFilterView()
        //{
        //    IsFilterViewVisible = true;
        //}
    }
}
