using Cysharp.Threading.Tasks;
using Domain;
using Repository.Interface;
using UnityEngine;
using Zenject;

namespace Repository
{
    public class SaveDataRepository : ISaveDataRepository
    {
        private readonly ISaveDataStore _saveDataStore;
        
        [Inject]
        public SaveDataRepository(ISaveDataStore saveDataStore)
        {
            Debug.Log("SaveDataRepository");
            _saveDataStore = saveDataStore;
        }
        
        public UniTask SaveAsync()
        {
            return _saveDataStore.SaveAsync();
        }

        public UniTask LoadAsync()
        {
            return _saveDataStore.LoadAsync();
        }
    }
}