using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_C37.Exceptions {

    internal class AmountGreaterThanZeroException : Exception {

        public decimal Amount { get; set; }

        public AmountGreaterThanZeroException() : base() { }

        public AmountGreaterThanZeroException(string message) : base(message) { }

        public AmountGreaterThanZeroException (string message, Exception innerException) 
            : base(message, innerException) { }
    }
}
