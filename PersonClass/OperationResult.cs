using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class OperationResult
    {

        public bool IsSuccess { get;private set; }
        public string Message { get;private set; }

        protected OperationResult(bool isSuccess, string message)
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
    class OperationResult<T> : OperationResult
    {
        public T Data { get; set; }

        private OperationResult(bool isSuccess, string message , T data) : base(isSuccess, message) 
        {
            Data = data;
        }
        public static OperationResult<T> Failed(string message)
        {
            return new OperationResult<T>(false, message,default);
        }
        public static OperationResult<T> Success(T data)
        {
            return new OperationResult<T>(true,"",data);
        }

    }
}
 