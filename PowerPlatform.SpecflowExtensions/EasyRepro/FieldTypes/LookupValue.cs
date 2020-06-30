﻿using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlatform.SpecflowExtensions.EasyRepro.FieldTypes
{
    internal class LookupValue
    {
        public LookupValue(EntityReference value)
        {
            Value = value;
        }

        public EntityReference Value { get; }

        public LookupItem ToLookupItem(AttributeMetadata metadata)
        {
            return new LookupItem { Name = metadata.LogicalName, Value = Value?.Name };
        }
    }
}
