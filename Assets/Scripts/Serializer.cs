using System.IO;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UIElements;
using System;

public class Serializer : MonoBehaviour
{
    XmlSerializer serializer;
    XmlSerializer deserializer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void Serialize(object item, string path)
    {
        Type type = item.GetType();
        serializer = new XmlSerializer(type);
        StreamWriter writer = new StreamWriter(path);
        serializer.Serialize(writer.BaseStream, item);
        writer.Close();
    }

    public T Deserialize<T>(string path)
    {
        deserializer = new XmlSerializer(typeof(T));
        StreamReader reader = new StreamReader(path);
        T deserialized = (T)deserializer.Deserialize(reader.BaseStream);
        reader.Close();
        return deserialized;
    }
}
