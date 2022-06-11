using System;
using Xunit;

namespace Server.Tests.Fixtures
{
	// ReSharper disable once ClassNeverInstantiated.Global
	public class LoadWorldFixture : IDisposable
	{
		public LoadWorldFixture()
		{
			Misc.MapDefinitions.Configure();
			World.Load();
		}

		public void Dispose() { }
	}
}
