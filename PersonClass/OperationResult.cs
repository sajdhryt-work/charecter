using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class OperationResult
    {

        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public OperationResult(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public OperationResult(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public static OperationResult Failed (string message)
        {
            return new OperationResult(false, message);           
        }
        public static OperationResult Success()
        {
            return new OperationResult(true);
        }
    }
}
 