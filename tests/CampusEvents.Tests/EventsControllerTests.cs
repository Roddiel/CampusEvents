using CampusEvents.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace CampusEvents.Tests;

public class EventsControllerTests
{
	[Fact]
	public void Index_ReturnsViewWithExpectedTemporaryTitle()
	{
		// Arrange: provide a simple logger without starting a web server.
		var controller = new EventsController(NullLogger<EventsController>.Instance);

		// Act: invoke the controller action directly.
		var result = controller.Index();

		// Assert: inspect the action result and its model.
		var view = Assert.IsType<ViewResult>(result);
		var title = Assert.IsType<string>(view.Model);
		Assert.Equal("Student Research Showcase", title);
	}
}
