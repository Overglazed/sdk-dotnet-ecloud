﻿using UKFast.API.Client.ECloud.Operations;
using UKFast.API.Client.ECloud.Models;

namespace UKFast.API.Client.ECloud
{
    public interface IUKFastECloudClient : IUKFastClient
    {
        IVirtualMachineOperations<VirtualMachine> VirtualMachineOperations();
        IVirtualMachineTagOperations<Tag> VirtualMachineTagOperations();
        ISolutionOperations<Solution> SolutionOperations();
        ISolutionTemplateOperations<Template> SolutionTemplateOperations();
        ISolutionVirtualMachineOperations<VirtualMachine> SolutionVirtualMachineOperations();
        ISolutionHostOperations<Host> SolutionHostOperations();
        ISolutionDatastoreOperations<Datastore> SolutionDatastoreOperations();
        ISolutionSiteOperations<Site> SolutionSiteOperations();
        ISolutionNetworkOperations<Network> SolutionNetworkOperations();
        ISolutionFirewallOperations<Firewall> SolutionFirewallOperations();
        ISolutionTagOperations<Tag> SolutionTagOperations();
        ISiteOperations<Site> SiteOperations();
        IHostOperations<Host> HostOperations();
        IDatastoreOperations<Datastore> DatastoreOperations();
        IFirewallOperations<Firewall> FirewallOperations();
        IPodOperations<Pod> PodOperations();
        IPodApplianceOperations<Appliance> PodApplianceOperations();
        IPodTemplateOperations<Template> PodTemplateOperations();
        IApplianceOperations<Appliance> ApplianceOperations();
        IApplianceParameterOperations<ApplianceParameter> ApplianceParameterOperations();
        ICreditOperations<Credit> CreditOperations();
    }
}
