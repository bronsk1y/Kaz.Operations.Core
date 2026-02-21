using System;

namespace Kaz.Operations.Core
{
    /// <summary>
    /// Ошибка возникающая при ошибочной попытке проверить пустую строку. 
    /// </summary>
    public class StringValidationException : Exception
    {
        /// <summary>
        /// Ошибка возникающая при ошибочной попытке проверить пустую строку. 
        /// </summary>
        public StringValidationException(string message) : base(message) { }
    }

    /// <summary>
    /// Ошибка возникающая при ошибочной попытке парсинга строкового предположения числа.
    /// </summary>
    public class NumericConvertationException : Exception
    {
        /// <summary>
        /// Ошибка возникающая при ошибочной попытке парсинга строкового предположения числа.
        /// </summary>
        public NumericConvertationException(string message) : base(message) { }
    }

}
