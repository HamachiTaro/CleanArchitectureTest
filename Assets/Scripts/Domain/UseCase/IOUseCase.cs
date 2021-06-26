using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;

namespace Domain.UseCase
{
    public class IOUseCase
    {

        private ISaveDataRepository _saveDataRepository;
        private IIOButtonPresenter _ioButtonPresenter;
        
        public IOUseCase(CompositeDisposable disposable, ISaveDataRepository saveDataRepository, IIOButtonPresenter ioButtonPresenter)
        {
            _saveDataRepository = saveDataRepository;
            _ioButtonPresenter = ioButtonPresenter;

            _ioButtonPresenter.OnClickLoadAsObservable()
                .Subscribe(_ => Debug.Log("load pressed"))
                .AddTo(disposable);

            _ioButtonPresenter.OnClickSaveAsObservable()
                .Subscribe(_ => Debug.Log("save pressed"))
                .AddTo(disposable);
        }
    }
}