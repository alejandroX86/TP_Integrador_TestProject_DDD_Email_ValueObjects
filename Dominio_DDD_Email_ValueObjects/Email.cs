using System;
using System.Text.RegularExpressions;

namespace Dominio_DDD_Email_ValueObjects
{
    public class Email
    {
        private string valor;

        public Email(string valor)
        {
            this.debeContenerEmailValido(valor);
            this.valor = valor;
        }

        private void debeContenerEmailValido(string valor)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(pattern);
            if (!regex.IsMatch(valor))
            {
                throw new Exception("El email no es válido");
            }
        }

        public string Valor()
        {
            return this.valor;
        }
    }
}
