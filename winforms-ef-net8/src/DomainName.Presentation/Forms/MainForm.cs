﻿using DomainName.Application.Abstractions.Presentation.Services;
using DomainName.Application.ViewModels;

using Microsoft.Extensions.DependencyInjection;

using WinFormsApp = System.Windows.Forms.Application;

namespace DomainName.Presentation.Forms;

/// <summary>
/// The main form class.
/// </summary>
public partial class MainForm : Form
{
	private readonly INavigationService _navigationService;
	private readonly MainViewModel _mainViewModel;
	private readonly IServiceProvider _serviceProvider;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainForm"/> class.
	/// </summary>
	/// <param name="navigationService">The navigation service instance to use.</param>
	/// <param name="mainViewModel">The main view model instance to use.</param>
	/// <param name="serviceProvider">The service provider instance to use.</param>
	public MainForm(INavigationService navigationService, MainViewModel mainViewModel, IServiceProvider serviceProvider)
	{
		InitializeComponent();

		Text = $"{mainViewModel.ApplicationName} - {mainViewModel.EnvironmentName}";

		_navigationService = navigationService;
		_mainViewModel = mainViewModel;
		_serviceProvider = serviceProvider;

		_navigationService.PropertyChanging += (s, e) => OnCurrentFormChanging();
		_navigationService.PropertyChanged += (s, e) => OnCurrentFormChanged();

		mainStatusStrip.Items.Add(new ToolStripStatusLabel($"User: {_mainViewModel.CurrentUser}"));
	}

	private void OnCurrentFormChanged()
	{
		if (_navigationService.CurrentForm is not null)
			mainPanel.Controls.Add(_navigationService.CurrentForm);
	}

	private void OnCurrentFormChanging()
	{
		if (_navigationService.CurrentForm is not null)
			mainPanel.Controls.Remove(_navigationService.CurrentForm);
	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => WinFormsApp.Exit();

	private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		AboutForm aboutForm = _serviceProvider.GetRequiredService<AboutForm>();
		aboutForm.ShowDialog(this);
	}

	private void todosToolStripMenuItem_Click(object sender, EventArgs e)
		=> _navigationService.NavigateTo<TodoForm>();
}
