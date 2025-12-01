using DomainName.Application.Abstractions.Application.Services;
using DomainName.Domain.Events.Presentation;

namespace DomainName.Presentation.Forms;

/// <summary>
/// The first form of the application.
/// </summary>
public partial class FirstForm : Form
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FirstForm"/> class.
	/// </summary>
	/// <param name="eventService">The event service to publish events.</param>
	public FirstForm(IEventService eventService)
	{
		InitializeComponent();
		FirstFormLabel.Text = nameof(FirstForm);

		eventService.Publish(new StatusChangedEvent($"{nameof(FirstForm)} initialized."));
	}
}
