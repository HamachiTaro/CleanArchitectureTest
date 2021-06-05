using UniRx;
using UnityEngine;

namespace Domain.UseCase
{
    public class EditUseCase
    {
        private CompositeDisposable _disposable;
        
        public EditUseCase(CompositeDisposable disposable, IInputPresenter inputPresenter)
        {
            _disposable = disposable;
            
            inputPresenter.OnChangePositionAsObservable()
                .Subscribe(x =>
                {
                    Debug.Log($"new position: {x}");
                    inputPresenter.ApplyPosition(x);
                })
                .AddTo(_disposable);

            inputPresenter.OnChangeRotationAsObservable()
                .Subscribe(x =>
                {
                    Debug.Log($"new rotation: {x}");
                    inputPresenter.ApplyRotation(x);
                })
                .AddTo(_disposable);

            inputPresenter.OnChangeScaleAsObservable()
                .Subscribe(x =>
                {
                    Debug.Log($"new scale: {x}");
                    inputPresenter.ApplyScale(x);
                })
                .AddTo(_disposable);
        }
    }
}