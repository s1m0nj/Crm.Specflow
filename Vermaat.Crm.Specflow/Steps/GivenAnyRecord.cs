using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Vermaat.Crm.Specflow.Steps
{
    [Binding]
    public class GivenAnyRecord
    {
        [Given(@"Given a '(.*)' named ([^\s]+) with the following parameters")]
        public void GivenAnyRecordWithParams(string record, string alias, Table parameters)
        {

        }
    }
}
