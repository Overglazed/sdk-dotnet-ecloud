﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Collections.Generic;
using System.Threading.Tasks;
using UKFast.API.Client.ECloud.Models;
using UKFast.API.Client.ECloud.Models.Request;
using UKFast.API.Client.ECloud.Operations;
using UKFast.API.Client.Exception;
using UKFast.API.Client.Models;

namespace UKFast.API.Client.ECloud.Operations.Tests
{
    [TestClass]
    public class CreditOperationsTests
    {
        [TestMethod]
        public async Task GetCreditsAsync_ExpectedResult()
        {
            IUKFastECloudClient client = Substitute.For<IUKFastECloudClient>();

            client.GetAllAsync(Arg.Any<UKFastClient.GetPaginatedAsyncFunc<Credit>>(), null).Returns(Task.Run<IList<Credit>>(() =>
            {
                return new List<Credit>()
                {
                    new Credit(),
                    new Credit()
                };
            }));

            var ops = new CreditOperations<Credit>(client);
            var credits = await ops.GetCreditsAsync();

            Assert.AreEqual(2, credits.Count);
        }

        [TestMethod]
        public async Task GetCreditsPaginatedAsync_ExpectedClientCall()
        {
            IUKFastECloudClient client = Substitute.For<IUKFastECloudClient>();

            client.GetPaginatedAsync<Credit>("/ecloud/v1/credits").Returns(Task.Run(() =>
            {
                return new Paginated<Credit>(client, "/ecloud/v1/credits", null, new Response.ClientResponse<System.Collections.Generic.IList<Credit>>()
                {
                    Body = new Response.ClientResponseBody<System.Collections.Generic.IList<Credit>>()
                    {
                        Data = new List<Credit>()
                        {
                            new Credit(),
                            new Credit()
                        }
                    }
                });
            }));

            var ops = new CreditOperations<Credit>(client);
            var paginated = await ops.GetCreditsPaginatedAsync();

            Assert.AreEqual(2, paginated.Items.Count);
        }
    }
}
