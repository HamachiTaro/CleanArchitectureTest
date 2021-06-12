using Cysharp.Threading.Tasks;

namespace Domain
{
    public interface ISaveDataRepository
    {
        UniTask SaveAsync();
        UniTask LoadAsync();
    }
}