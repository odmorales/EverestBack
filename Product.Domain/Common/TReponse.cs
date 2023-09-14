using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.Common
{
    public class TReponse<T>
    {
        public TReponse(T objet)
        {
            this.Error = false;
            this.Objet = objet;
        }
        public TReponse(string message)
        {
            this.Error = true;
            this.Message = message;
        }
        public bool Error { get; set; }
        public string? Message { get; set; }
        public T? Objet { get; set; }
    }
}
