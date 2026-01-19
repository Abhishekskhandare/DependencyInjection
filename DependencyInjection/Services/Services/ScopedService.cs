namespace DependencyInjection.Services
{
	public class ScopedService : IScopedService
	{
		public Guid Guid { get; } = Guid.NewGuid();
	}
}
