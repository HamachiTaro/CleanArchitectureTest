using Cysharp.Threading.Tasks;
using Repository.Interface;
using UnityEngine;

namespace Data
{
    public class JsonDataStore : ISaveDataStore
    {

        public JsonDataStore()
        {
            Debug.Log("constructor. json data store");
        }
        
        public UniTask SaveAsync()
        {
            throw new System.NotImplementedException();
        }

        public UniTask LoadAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}