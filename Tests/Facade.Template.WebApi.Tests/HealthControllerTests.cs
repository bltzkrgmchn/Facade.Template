#pragma warning disable 1591

using FakeItEasy;
using FluentAssertions;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Net;
using System.Threading;

namespace Facade.Template.WebApi.Tests
{
    public class HealthControllerTests
    {
        [Test]
        [Description("Запрос статуса службы должен завершаться успешно.")]
        public void CanCheckHealth()
        {
            HealthController sut = new HealthController();
            StatusCodeResult result = sut.Get().GetAwaiter().GetResult() as StatusCodeResult;

            result.Should().NotBe(null);
            result.StatusCode.Should().Be((int)HttpStatusCode.OK);
        }
    }
}

#pragma warning restore 1591