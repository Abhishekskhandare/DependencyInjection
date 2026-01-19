namespace DependencyInjection.Services
{
	public class TransientService : ITransientService
	{
		public Guid Guid { get; } = Guid.NewGuid();
	}
}
