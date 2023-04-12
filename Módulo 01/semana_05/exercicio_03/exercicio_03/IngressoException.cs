using System;
namespace exercicio_03
{
        public class IngressoException : Exception
        {
            public IngressoException(String msg) : base(msg)
            {
            }

            public IngressoException(String msg, Exception causa) : base(msg, causa)
            {
            }

            public IngressoException()
            {
            }
        }
}