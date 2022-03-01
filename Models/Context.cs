using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureAPIManagementPolicy.Models
{
    public class Context
    {
        public Api Api { get; set; }
        public Deployment Deployment { get; set; }
        public TimeSpan Elapsed { get; set; }
        public LastError LastError { get; set; }
        public Operation Operation { get; set; }
        public Product Product { get; set; }
        public Request Request { get; set; }
        public Guid RequestId { get; set; }
        public Response Response { get; set; }
        public Subscription Subscription { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Tracing { get; set; }
        public User User { get; set; }
        public IReadOnlyDictionary<string, object> Variables { get; set; }

        public void Trace(string message) { }
    }
}
