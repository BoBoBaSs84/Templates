using DomainName.Domain.Entities;

namespace DomainName.Infrastructure.Extensions;

internal static class QueryableExtensions
{
	internal static IQueryable<ExampleEntity> FilterByLastName(this IQueryable<ExampleEntity> query, string? lastName)
		=> lastName is not null ? query.Where(x => x.LastName.Contains(lastName)) : query;

	internal static IQueryable<ExampleEntity> FilterByFirstName(this IQueryable<ExampleEntity> query, string? firstName)
		=> firstName is not null ? query.Where(x => x.FirstName.Contains(firstName)) : query;

	internal static IQueryable<ExampleEntity> FilterByAge(this IQueryable<ExampleEntity> query, int? age)
		=> age.HasValue ? query.Where(x => x.Age == age.Value) : query;
}
