using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BulkRiddleCommonDS
{
    public class BRWebRequest
    {
        [DataContract]
        public class TestWebRequest //: IDisposable
        {
            // Track whether Dispose has been called.
            private bool disposed = false;

            private Dictionary<string, BRParameter> _oParams = new Dictionary<string, BRParameter>();

            //[DataMember]
            //public RequestProvider rProvider { get; set; }


            [DataMember]
            public string sMethod { get; set; }

            [DataMember]
            public string sConnectionID { get; set; }
            [DataMember]
            public string authenticationCode { get; set; }

            [DataMember]
            public Dictionary<string, BRParameter> oParams
            {
                get { return _oParams; }
                set { _oParams = value; }
            }



            // Track whether Dispose has been called.
            // private bool disposed = false;

            /// <summary>
            /// 
            /// </summary>
            //public DTRGWebRequest()
            //{
            //}

            /// <summary>
            /// 
            /// </summary>
            /// <param name="aHost"></param>
            //public DTRGWebRequest(RequestProvider aProvider)
            //{
            //    rProvider = aProvider;
            //}

            /// <summary>
            /// 
            /// </summary>
            /// <param name="aHost"></param>
            /// <param name="aAction"></param>
            //public DTRGWebRequest(RequestProvider aProvider, string aMethod)
            //{
            //    rProvider = aProvider;
            //    sMethod = aMethod;
            //}

            /// <summary>
            /// 
            /// </summary>
            /// <param name="aHost"></param>
            /// <param name="aMethod"></param>
            /// <param name="aConnectionID"></param>
            //public DTRGWebRequest(RequestProvider aProvider, string aMethod, string aConnectionID)
            //{
            //    rProvider = aProvider;
            //    sMethod = aMethod;
            //    sConnectionID = aConnectionID;
            //}

            /// <summary>
            /// 
            /// </summary>
            /// <param name="aHost"></param>
            /// <param name="aAction"></param>
            /// <param name="aParams"></param>

            //public DTRGWebRequest(RequestProvider aProvider, string aMethod, Dictionary<string, DTRGParameter> aParams)
            //{
            //    rProvider = aProvider;
            //    sMethod = aMethod;
            //    oParams = aParams;

            //}


            //public void Dispose()
            //{
            //    Dispose(true);
            //    // This object will be cleaned up by the Dispose method.
            //    // Therefore, you should call GC.SupressFinalize to
            //    // take this object off the finalization queue
            //    // and prevent finalization code for this object
            //    // from executing a second time.
            //    GC.SuppressFinalize(this);
            //}

            /// <summary>
            /// Clean Up
            /// </summary>
            //public void Dispose(bool disposing)
            //{
            //    // Check to see if Dispose has already been called.
            //    if (!this.disposed)
            //    {
            //        oParams.Clear();
            //        oParams = null;
            //    }
            //    this.disposed = true;
            //}

        }
    }
}
