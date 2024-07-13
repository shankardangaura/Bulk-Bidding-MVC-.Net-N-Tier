using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkRiddleCommonDS
{
    public class BRWebRequestDataProvider
    {
        public BRWebRequestDataProvider()
        {

        }

        public BRWebResponse GetResponse(BRWebRequest request)
        {
            BRWebResponse _response = new BRWebResponse();

            //Dictionary<string,DTRGParameter> _param = request.Param;

            //switch (request.MethodName)
            //{
            //    case "GetPatientDataSetByPatientName":
            //        DTRG.DALLAR.patient.PatientEntry _patientEntry = new DALLAR.patient.PatientEntry();
            //        _patientEntry.GetPatientDataSetByPatientName("");
            //        break;  
            //}

            return _response;
        }
    }
}
