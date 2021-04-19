using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masterdata_integration.models.customer
{
    public class Error
    {
        public string message { get; set; }
        public int code { get; set; }
        public string orderNo { get; set; }
        public Error(int _code, string _message, string _orderNo)
        {
            message = _message;
            code = _code;
            orderNo = _orderNo;
        }
    }
}
