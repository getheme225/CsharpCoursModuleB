using System;
using System.Xml.Serialization;

namespace PayBookModel
{
  
    public class Payement
   {    /// <summary>
        /// ��� �������
        /// </summary>
       public string Client { get; set; }
        /// <summary>
        /// ���� �������
        /// </summary>
       public DateTime PayementDate { get; set; }
        /// <summary>
        /// ����� �������
        /// </summary>
       public double Amount { get; set; }
    }
}