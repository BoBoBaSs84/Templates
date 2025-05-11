using System.Windows.Forms;

using DomainName.Application.ViewModels;
using DomainName.Domain.Models;
using DomainName.Presentation.Forms;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

namespace DomainName.Presentation.Tests.Forms;

[TestClass]
public sealed class AboutFormTests : UnitTestBase
{
	[TestMethod]
	public void ConstructorShouldSetFieldsCorrectly()
	{
		Mock<AboutModel> modelMock = new Mock<AboutModel>()
			.SetupAllProperties();
		AboutViewModel viewModel = new(modelMock.Object);

		using AboutForm form = new(viewModel);

		Assert.AreEqual(viewModel.Model.Title, ((Label)GetNonPublicField(form, "titleLabelValue")).Text);
		Assert.AreEqual(viewModel.Model.Version, ((Label)GetNonPublicField(form, "versionLabelValue")).Text);
		Assert.AreEqual(viewModel.Model.Company, ((Label)GetNonPublicField(form, "companyLabelValue")).Text);
		Assert.AreEqual(viewModel.Model.Copyright, ((Label)GetNonPublicField(form, "copyrightLabelValue")).Text);
		Assert.AreEqual(viewModel.Model.FrameworkName, ((Label)GetNonPublicField(form, "frameworkLabelValue")).Text);
		Assert.AreEqual(viewModel.Model.Repository, ((Label)GetNonPublicField(form, "repositoryLabelValue")).Text);
		Assert.AreEqual(viewModel.Model.Comments, ((Label)GetNonPublicField(form, "descriptionLabelValue")).Text);
	}
}
