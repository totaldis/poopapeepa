using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.domain
{
    public class StatusResponse
    {
        public bool Status { get; set; }
        public int RecordsAffected { get; set; }
        public string Message { get; set; }
        public Object OperationId { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionInnerMessage { get; set; }

        public static StatusResponse CreateFromException(string message, Exception ex)
        {
            StatusResponse status = new StatusResponse
            {
                Status = false,
                Message = message,
                OperationId = null
            };
            if (ex != null)
            {
                status.ExceptionMessage = ex.Message;
                status.ExceptionInnerMessage = (ex.InnerException == null) ? null : ex.InnerException.Message;
            }
            return status;
        }
    }
}
