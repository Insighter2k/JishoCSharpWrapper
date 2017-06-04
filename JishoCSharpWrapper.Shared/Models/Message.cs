using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JishoCSharpWrapper.Shared.Models
{
    public class Message<T>
    {
        private T _result;
        public T Result => _result;

        internal void SetResult(T result)
        {
            _result = result;
        }
    }
}