﻿using System.Windows;

using DomainName.Application.ViewModels;

namespace DomainName.Presentation.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// Initializes an instance of the <see cref="MainWindow"/> class.
	/// </summary>
	/// <param name="viewModel">The view model instance to use.</param>
	public MainWindow(MainViewModel viewModel)
	{
		DataContext = viewModel;
		InitializeComponent();
	}
}
