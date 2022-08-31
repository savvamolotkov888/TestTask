using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;



[Serializable]
public class ParseXML : MonoBehaviour
{
    public List<Vector3> DotList = new List<Vector3>();

    void Awake()
    {
        ParseXml();
    }
    void ParseXml()
    {
        string filePath = Application.dataPath + "/Resources/Spline.xml";//расположение xml

        if (File.Exists(filePath))
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            XmlNodeList node = xmlDoc.SelectSingleNode("Сплайн").ChildNodes;
            Debug.Log("++Parsing Success++");

            // Обход узлов
            foreach (XmlElement Segment in node)
            {
                // Узел под элементом

                if (Segment.Name == "Сегмент")
                {
                    foreach (XmlElement element in Segment.ChildNodes)
                    {
                        #region Final coordinates
                        float X;
                        float Y;
                        float Z;
                        #endregion

                        var x = element.Attributes.GetNamedItem("x").InnerText;
                        var y = element.Attributes.GetNamedItem("y").InnerText;
                        var z = element.Attributes.GetNamedItem("z").InnerText;
                        //получение атрибута

                        CheckString.CheckForNull(x);
                        CheckString.CheckForNull(y);
                        CheckString.CheckForNull(z);


                        CheckString.CheckForDigital(x, out x);
                        CheckString.CheckForDigital(y, out y);
                        CheckString.CheckForDigital(z, out z);

                        try
                        {
                            X = float.Parse(x);
                            Y = float.Parse(y);
                            Z = float.Parse(z);

                            var DotPoz = new Vector3(X, Y, Z);
                            DotList.Add(DotPoz);

                            Debug.Log($"{element.Name}|{x}|{y}|{z}");
                        }
                        catch (FormatException)
                        {

                        }
                    }
                }
            }
        }
    }
}
