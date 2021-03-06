﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UKFast.API.Client.ECloud.Models;
using UKFast.API.Client.ECloud.Models.Request;
using UKFast.API.Client.Models;
using UKFast.API.Client.Request;

namespace UKFast.API.Client.ECloud.Operations
{
    public class SolutionNetworkOperations<T> : ECloudOperations, ISolutionNetworkOperations<T> where T : Network
    {
        public SolutionNetworkOperations(IUKFastECloudClient client) : base(client) { }

        public async Task<IList<T>> GetSolutionNetworksAsync(int solutionID, ClientRequestParameters parameters = null)
        {
            return await this.Client.GetAllAsync((ClientRequestParameters funcParameters) => GetSolutionNetworksPaginatedAsync(solutionID, funcParameters), parameters);
        }

        public async Task<Paginated<T>> GetSolutionNetworksPaginatedAsync(int solutionID, ClientRequestParameters parameters = null)
        {
            if (solutionID < 1)
            {
                throw new Client.Exception.UKFastClientValidationException("Invalid solution id");
            }

            return await this.Client.GetPaginatedAsync<T>($"/ecloud/v1/solutions/{solutionID}/networks", parameters);
        }
    }
}
