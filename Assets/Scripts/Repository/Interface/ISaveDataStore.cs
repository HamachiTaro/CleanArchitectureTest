using Cysharp.Threading.Tasks;

namespace Repository.Interface
{
    public interface ISaveDataStore
    {
        UniTask SaveAsync();
        UniTask LoadAsync();
    }
}