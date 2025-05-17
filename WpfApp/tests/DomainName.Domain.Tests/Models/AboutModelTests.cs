﻿using DomainName.Domain.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainName.Domain.Tests.Models;

[TestClass]
public sealed class AboutModelTests
{
	[TestMethod]
	public void AboutModelConstructorTest()
	{
		AboutModel? model;

		model = new AboutModel();

		Assert.IsNotNull(model);
		Assert.IsNotNull(model.Title);
		Assert.IsNotNull(model.Version);
		Assert.IsNotNull(model.Comments);
		Assert.IsNotNull(model.Company);
		Assert.IsNotNull(model.Copyright);
		Assert.IsNotNull(model.FrameworkName);
		Assert.IsNotNull(model.Repository);
	}
}
