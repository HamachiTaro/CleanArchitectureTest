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
        
        private EditUseCase _editUseCase;
        private CompositeDisposable _disposable;
        
        private void Start()
        {
            Debug.Log("Main Start");
            _disposable = new CompositeDisposable();
            _editUseCase = new EditUseCase(_disposable, _inputPresenter);
        }
    }
}