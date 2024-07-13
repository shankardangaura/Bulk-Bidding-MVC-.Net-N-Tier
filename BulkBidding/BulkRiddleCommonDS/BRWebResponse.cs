using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BulkRiddleCommonDS

{
    [DataContract]
    public class BRWebResponse
    {
       
        [DataMember]
        public BRParameter ResultValue { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public bool? bPass { get; set; }

        [DataMember]
        public string ErrorCode { get; set; }
    }
}
