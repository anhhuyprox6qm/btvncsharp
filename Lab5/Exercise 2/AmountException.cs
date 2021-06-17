using System;

namespace Lab5.Exercise_2
{
    public class AmountException: Exception
    {
        private string _personName;
        private string _message;
        public AmountException()
        {
        }
        public AmountException(string message, string personName)
        {
            this._message = message;
            this._personName = personName;
            PrintError();
        }
        private void PrintError()
        {
            Console.WriteLine($"Amount exception with person test {_personName}, {_message}");
        }
    }
}