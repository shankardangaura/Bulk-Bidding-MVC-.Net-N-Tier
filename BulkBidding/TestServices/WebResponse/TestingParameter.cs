using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestServices.WebResponse
{
    public class TestingParameter
    {
        [DataMember]
        public int? integerValue { get; set; }
        [DataMember]
        public long? longValue { get; set; }
        [DataMember]
        public string stringValue { get; set; }
        [DataMember]
        public float? floatValue { get; set; }
        [DataMember]
        public double? doubleValue { get; set; }
        [DataMember]
        public decimal? decimalValue { get; set; }
        [DataMember]
        public DateTime? dateValue { get; set; }
        [DataMember]
        public object DTRGObject { get; set; }
        [DataMember]
        public System.Collections.Generic.List<string> listStr;
        [DataMember]
        public System.Collections.Generic.List<int> listIntegers;
        [DataMember]
        public System.Collections.Generic.List<double> listDouble;
        [DataMember]
        public byte[] buffer { get; set; }
        [DataMember]
        public int? bufferSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public TestingParameter() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oValue"></param>
        public TestingParameter(int? oValue)
        {
            integerValue = oValue;
        }
        public TestingParameter(long? oValue)
        {
            longValue = oValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oValue"></param>
        public TestingParameter(string oValue)
        {
            stringValue = oValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oValue"></param>
        public TestingParameter(double? oValue)
        {
            doubleValue = oValue;
        }
        public TestingParameter(decimal? oValue)
        {
            decimalValue = oValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oValue"></param>
        public TestingParameter(float? oValue)
        {
            doubleValue = (double)oValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oValue"></param>
        public TestingParameter(DateTime? oValue)
        {
            dateValue = oValue;
        }
        public TestingParameter(object oValue)
        {
            DTRGObject = oValue;
        }

    }
}

