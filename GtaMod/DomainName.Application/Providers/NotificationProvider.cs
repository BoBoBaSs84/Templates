using System.Diagnostics.CodeAnalysis;

using BB84.SourceGenerators.Attributes;

using DomainName.Application.Abstractions.Application.Providers;

using GTA.UI;

namespace DomainName.Application.Providers;

/// <summary>
/// Represents a provider for sending notifications to the user.
/// </summary>
[ExcludeFromCodeCoverage]
[GenerateAbstraction(typeof(Notification), typeof(INotificationProvider), typeof(NotificationProvider))]
internal sealed partial class NotificationProvider : INotificationProvider
{ }
