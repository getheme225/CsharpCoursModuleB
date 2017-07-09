using System;
using System.Xml.Serialization;

namespace PayBookModel
{
  
    public class Payement
   {    /// <summary>
        /// Имя Клиента
        /// </summary>
       public string Client { get; set; }
        /// <summary>
        /// Дата платежа
        /// </summary>
       public DateTime PayementDate { get; set; }
        /// <summary>
        /// Сумма платежа
        /// </summary>
       public double Amount { get; set; }
    }
}