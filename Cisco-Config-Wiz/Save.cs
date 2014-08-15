//TODO: Add data parameter (string[]?)
//TODO: Save(...) x4

namespace Save
{
    class Xml
    {
        public static void Save(string outputPath)
        {
            throw new System.NotImplementedException("Save(String)");

            byte[] comma = { 0x2C };
            byte[] nl = { 0x0D, 0x0A };

            using (System.Xml.XmlWriter writer = System.Xml.XmlWriter.Create(outputPath))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Connections");

                // == Exemple ==
                //for (int i = 0; i < count; i++)
                //{
                //    writer.WriteStartElement("Connection");

                //    switch (pMode)
                //    {
                //        case eMode.LiveTcp:
                //            writer.WriteElementString("Local", FirstList[i]);
                //            writer.WriteElementString("Remote", SecondList[i]);
                //            writer.WriteElementString("State", ThirdList[i]);
                //            break;
                //        case eMode.TcpListeners:
                //            writer.WriteElementString("Address", FirstList[i]);
                //            writer.WriteElementString("AddressFamily", SecondList[i]);
                //            writer.WriteElementString("Port", ThirdList[i]);
                //            break;
                //        case eMode.UdpListeners:
                //            writer.WriteElementString("Address", FirstList[i]);
                //            writer.WriteElementString("AddressFamily", SecondList[i]);
                //            writer.WriteElementString("Port", ThirdList[i]);
                //            break;
                //        case eMode.UnicastAddresses:
                //            writer.WriteElementString("Address", FirstList[i]);
                //            writer.WriteElementString("Mask", SecondList[i]);
                //            writer.WriteElementString("DetectionState", ThirdList[i]);
                //            break;
                //    }

                //    writer.WriteEndElement();
                //}

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
        }

        public static void Save(System.IO.Stream stream)
        {
            throw new System.NotImplementedException("Save(Stream)");

            byte[] comma = { 0x2C };
            byte[] nl = { 0x0D, 0x0A };

            using (System.Xml.XmlWriter writer = System.Xml.XmlWriter.Create(stream))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Connections");
                
                // == Exemple == 
                //for (int i = 0; i < count; i++)
                //{
                //    writer.WriteStartElement("Connection");

                //    switch (pMode)
                //    {
                //        case eMode.LiveTcp:
                //            writer.WriteElementString("Local", FirstList[i]);
                //            writer.WriteElementString("Remote", SecondList[i]);
                //            writer.WriteElementString("State", ThirdList[i]);
                //            break;
                //        case eMode.TcpListeners:
                //            writer.WriteElementString("Address", FirstList[i]);
                //            writer.WriteElementString("AddressFamily", SecondList[i]);
                //            writer.WriteElementString("Port", ThirdList[i]);
                //            break;
                //        case eMode.UdpListeners:
                //            writer.WriteElementString("Address", FirstList[i]);
                //            writer.WriteElementString("AddressFamily", SecondList[i]);
                //            writer.WriteElementString("Port", ThirdList[i]);
                //            break;
                //        case eMode.UnicastAddresses:
                //            writer.WriteElementString("Address", FirstList[i]);
                //            writer.WriteElementString("Mask", SecondList[i]);
                //            writer.WriteElementString("DetectionState", ThirdList[i]);
                //            break;
                //    }

                //    writer.WriteEndElement();
                //}

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
        }
    }

    class Csv
    {
        public static void Save(string outputPath)
        {
            using (System.IO.FileStream fs = new System.IO.FileStream(outputPath, System.IO.FileMode.Create))
            {
                throw new System.NotImplementedException("Save(String)");

                byte[] comma = { 0x2C };
                byte[] nl = { 0x0D, 0x0A };

                // == Exemple ==
                //int count = FirstList.Length;
                //for (int i = 0; i < count; i++)
                //{
                //    byte[] first = System.Text.Encoding.UTF8.GetBytes(FirstList[i]);
                //    fs.Write(first, 0, first.Length);

                //    fs.Write(comma, 0, comma.Length);

                //    byte[] second = System.Text.Encoding.UTF8.GetBytes(SecondList[i]);
                //    fs.Write(second, 0, second.Length);

                //    fs.Write(comma, 0, comma.Length);

                //    byte[] third = System.Text.Encoding.UTF8.GetBytes(ThirdList[i]);
                //    fs.Write(third, 0, third.Length);

                //    fs.Write(comma, 0, comma.Length);
                //    fs.Write(nl, 0, nl.Length);
                //}

                fs.Close();
            }
        }

        public static void Save(System.IO.Stream stream)
        {
            throw new System.NotImplementedException("Save(String)");

            byte[] comma = { 0x2C }; //','
            byte[] nl = { 0x0D, 0x0A }; //"\r\n"

            // == Exemple ==
            //int count = FirstList.Length;
            //for (int i = 0; i < FirstList.Lenght; i++)
            //{
            //    byte[] first = System.Text.Encoding.UTF8.GetBytes(FirstList[i]);
            //    fs.Write(first, 0, first.Length);

            //    fs.Write(comma, 0, comma.Length);

            //    byte[] second = System.Text.Encoding.UTF8.GetBytes(SecondList[i]);
            //    fs.Write(second, 0, second.Length);

            //    fs.Write(comma, 0, comma.Length);

            //    byte[] third = System.Text.Encoding.UTF8.GetBytes(ThirdList[i]);
            //    fs.Write(third, 0, third.Length);

            //    fs.Write(comma, 0, comma.Length);
            //    fs.Write(nl, 0, nl.Length);
            //}

            stream.Close();
        }
    }
}
