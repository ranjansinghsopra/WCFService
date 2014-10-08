using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel.Security.Tokens;
using System.Text;
using System.Threading.Tasks;

namespace EvalService.Library
{
    [DataContract]
    public class Ticket
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string RaisedBy { get; set; }

        [DataMember]
        public DateTime RaisedAt { get; set; }
    }
}
