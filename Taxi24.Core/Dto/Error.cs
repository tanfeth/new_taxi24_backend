using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Dto
{
    public class Error
    {
        public bool Success { get; set; }
        public string ExceptionMessage { get; set; }
        public string ErrorMessage { get; set; }

        public Error SetError(string exceptionMessage, string errorMessage = null)
        {
            this.Success = false;
            this.ExceptionMessage = exceptionMessage;
            this.ErrorMessage = errorMessage ?? exceptionMessage;

            return this;
        }


        public string ToJsonString()
        {
            var res = JsonConvert.SerializeObject(new
            {
                Success = this.Success,
                ErrorMessage = this.ErrorMessage ?? "",
                ExceptionMessage = this.ExceptionMessage ?? ""
            });
            return  res.Replace(",", "\\002C");
        }
    }
}
