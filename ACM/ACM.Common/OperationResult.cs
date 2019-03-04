using System;
using System.Collections.Generic;

namespace ACM.Common
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public List<string> Messages { get; private set; }

        public OperationResult()
        {
            Messages = new List<string>();
            Success = true;
        }

        public void Add(string message)
        {
            Messages.Add(message);
        }
    }
}
