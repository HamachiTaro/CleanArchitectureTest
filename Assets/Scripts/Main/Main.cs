using Domain;
using Domain.UseCase;
using UniRx;
using UnityEngine;
using Zenject;

namespace Main
{
    public class Main : MonoBehaviour
    {
        [Inject] private IInputPresenter _inputPresenter;
        [Inject] private IIOButtonPresenter _ioButtonPresenter;
        [Inject] private ISaveDataRepository _saveDataRepository;
        
        private EditUseCase _editUseCase;
        private IOUseCase _ioUseCase;
        private CompositeDisposable _disposable;
        
        private void Start()
        {
            Debug.Log("Main Start");
            _disposable = new CompositeDisposable();
            _editUseCase = new EditUseCase(_disposable, _inputPresenter);
            _ioUseCase = new IOUseCase(_disposable, _saveDataRepository, _ioButtonPresenter);
        }

        private void OnDestroy()
        {
            _disposable.Dispose();
        }
    }
}