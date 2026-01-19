using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
	[ApiController]
	public class DIController : ControllerBase
	{
		#region private variables

		private readonly ITransientService _transient1;
		private readonly ITransientService _transient2;

		private readonly IScopedService _scoped1;
		private readonly IScopedService _scoped2;

		private readonly ISingletonService _singleton1;
		private readonly ISingletonService _singleton2;
		#endregion
		public DIController( ITransientService transient1, ITransientService transient2, IScopedService scoped1, IScopedService scoped2, ISingletonService singleton1, ISingletonService singleton2)
		{
			_transient1 = transient1;
			_transient2 = transient2;
			_scoped1 = scoped1;
			_scoped2 = scoped2;
			_singleton1 = singleton1;
			_singleton2 = singleton2;
		}

		[HttpGet]
		[Route("scope1")]
		public IActionResult Get()
		{
			return Ok(new
			{
				Transient1 = _transient1.Guid,
				Transient2 = _transient2.Guid,

				Scoped1 = _scoped1.Guid,
				Scoped2 = _scoped2.Guid,

				Singleton1 = _singleton1.Guid,
				Singleton2 = _singleton2.Guid
			});
		}

		[HttpGet]
		[Route("scope2")]
		public IActionResult Getscope2()
		{
			return Ok(new
			{
				Transient1 = _transient1.Guid,
				Transient2 = _transient2.Guid,

				Scoped1 = _scoped1.Guid,
				Scoped2 = _scoped2.Guid,

				Singleton1 = _singleton1.Guid,
				Singleton2 = _singleton2.Guid
			});
		}
	}
}
