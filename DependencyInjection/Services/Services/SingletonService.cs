namespace DependencyInjection.Services
{
	public class SingletonService : ISingletonService
	{
		public Guid Guid { get; } = Guid.NewGuid();
	}
}
