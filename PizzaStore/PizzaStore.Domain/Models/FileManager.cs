using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace PizzaStore.Domain.Models
{
    public class FileManager
    {
        private const string _path = @"data/pizza_store.xml";
        public Order Read()
        {
            var reader = new StreamReader(_path);
            var xml = new XmlSerializer(typeof(Order));

            return xml.Deserialize(reader) as Order;
             
        }
        public void Write(Order orders)
        {
            //create file
            //open the file with write permissions
            //load content to write
            //convert content to xml
            //write xml to file
            //close the file

            var writer = new StreamWriter(_path);
            var xml = new XmlSerializer(typeof(Order));

            xml.Serialize(writer, orders); //this did 'load the content', 'convert content', 'write', and close the file

        }   
    
    }

}