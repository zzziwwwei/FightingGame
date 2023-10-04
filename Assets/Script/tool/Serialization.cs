using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tool
{
    public class Serialization
    {
        public string Ser<T>(T Data)
        {
            string serializedData = JsonUtility.ToJson(Data);
            return serializedData;
        }
        public T Deser<T>(string data)
        {
            T deserializedData = JsonUtility.FromJson<T>(data);
            return deserializedData;
        }
    }
}