using Bunit;
using Microsoft.Extensions.DependencyInjection;
using IgApplication.Pages;

namespace TestIgApplication
{
	[Collection("IgApplication")]
	public class TestMaster_View
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Master_View>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
