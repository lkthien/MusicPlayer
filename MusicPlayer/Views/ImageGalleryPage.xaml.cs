﻿using System;

using MusicPlayer.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MusicPlayer.Views
{
    public sealed partial class ImageGalleryPage : Page
    {
        private ImageGalleryViewModel ViewModel
        {
            get { return ViewModelLocator.Current.ImageGalleryViewModel; }
        }

        public ImageGalleryPage()
        {
            InitializeComponent();
            Loaded += ImageGalleryPage_Loaded;
        }

        private async void ImageGalleryPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync();
        }
    }
}
