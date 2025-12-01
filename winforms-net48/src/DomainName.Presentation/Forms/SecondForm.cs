using DomainName.Application.Abstractions.Application.Services;
using DomainName.Domain.Events.Presentation;

namespace DomainName.Presentation.Forms;

/// <summary>
/// the second form of the application.
/// </summary>
public partial class SecondForm : Form
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SecondForm"/> class.
	/// </summary>
	/// <param name="eventService">The event service to publish events.</param>
	public SecondForm(IEventService eventService)
	{
		InitializeComponent();
		SecondFormLabel.Text = nameof(SecondForm);

		eventService.Publish(new StatusChangedEvent($"{nameof(SecondForm)} initialized."));
	}
}
