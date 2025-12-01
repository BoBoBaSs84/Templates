using DomainName.Application.Abstractions.Application.Services;
using DomainName.Domain.Events.Presentation;

namespace DomainName.Presentation.Forms;

/// <summary>
/// The third form of the application.
/// </summary>
public partial class ThirdForm : Form
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ThirdForm"/> class.
	/// </summary>
	/// <param name="eventService">The event service to publish and subscribe to events.</param>
	public ThirdForm(IEventService eventService)
	{
		InitializeComponent();
		ThirdFormLabel.Text = nameof(ThirdForm);

		eventService.Publish(new StatusChangedEvent($"{nameof(ThirdForm)} initialized.."));
	}
}
