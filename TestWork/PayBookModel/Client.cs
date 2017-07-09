using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PayBookModel
{
    [XmlRoot("Client")]
    public class Client
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("Payements")]
        public ICollection<Payement> Payements { get; set; }
    }
}
