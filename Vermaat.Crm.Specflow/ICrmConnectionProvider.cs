﻿using Microsoft.Xrm.Sdk;

namespace Vermaat.Crm.Specflow
{
    public interface ICrmConnectionProvider
    {
        IOrganizationService CreateCrmConnection(CrmConnectionString connection);
    }
}