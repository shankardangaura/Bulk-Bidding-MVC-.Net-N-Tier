﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BulkRiddleCommonDS

{
    public class BRParameter
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
        public BRParameter() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oValue"></param>
        public BRParameter(int? oValue)
        {
            integerValue = oValue;
        }
        public BRParameter(long? oValue)
        {
            longValue = oValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oValue"></param>
        public BRParameter(string oValue)
        {
            stringValue = oValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oValue"></param>
        public BRParameter(double? oValue)
        {
            doubleValue = oValue;
        }
        public BRParameter(decimal? oValue)
        {
            decimalValue = oValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oValue"></param>
        public BRParameter(float? oValue)
        {
            doubleValue = (double)oValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oValue"></param>
        public BRParameter(DateTime? oValue)
        {
            dateValue = oValue;
        }
        public BRParameter(object oValue)
        {
            DTRGObject = oValue;
        }

    }
}

