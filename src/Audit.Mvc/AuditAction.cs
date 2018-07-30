using System.Collections.Generic;
using Newtonsoft.Json;

namespace Audit.Mvc
{
    public class AuditAction
    {
        [JsonProperty(Order = -1, NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }
        [JsonProperty(Order = 0)]
        public string HttpMethod { get; set; }
        [JsonProperty(Order = 5)]
        public string ControllerName { get; set; }
        [JsonProperty(Order = 10)]
        public string ActionName { get; set; }
        [JsonProperty(Order = 12, NullValueHandling = NullValueHandling.Ignore)]
        public string ViewName { get; set; }
        [JsonProperty(Order = 12, NullValueHandling = NullValueHandling.Ignore)]
        public string ViewPath { get; set; }
        [JsonProperty(Order = 15)]
        public IDictionary<string, string> FormVariables { get; set; }
        [JsonProperty(Order = 20)]
        public IDictionary<string, object> ActionParameters { get; set; }
        [JsonProperty(Order = 22, NullValueHandling = NullValueHandling.Ignore)]
        public BodyContent RequestBody { get; set; }
        [JsonProperty(Order = 23, NullValueHandling = NullValueHandling.Ignore)]
        public BodyContent ResponseBody { get; set; }
        [JsonProperty(Order = 25)]
        public string UserName { get; set; }
        [JsonProperty(Order = 30)]
        public string RequestUrl { get; set; }
        [JsonProperty(Order = 35)]
        public string IpAddress { get; set; }
        [JsonProperty(Order = 40)]
        public string ResponseStatus { get; set; }
        [JsonProperty(Order = 45)]
        public int ResponseStatusCode { get; set; }
        [JsonProperty(Order = 50, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Headers { get; set; }
        [JsonProperty(Order = 55, NullValueHandling = NullValueHandling.Ignore)]
        public object Model { get; set; }
        [JsonProperty(Order = 60, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ModelStateValid { get; set; }
        [JsonProperty(Order = 65, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> ModelStateErrors { get; set; }
        [JsonProperty(Order = 70, NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectLocation { get; set; }
        [JsonProperty(Order = 999, NullValueHandling = NullValueHandling.Ignore)]
        public string Exception { get; set; }
    }
}