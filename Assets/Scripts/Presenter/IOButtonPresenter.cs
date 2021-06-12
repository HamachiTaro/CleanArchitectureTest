using System;
using Domain;
using UniRx;
using Zenject;

namespace Presenter
{
    public class IOButtonPresenter : IIOButtonPresenter
    {
        private readonly IUIView _uiView;

        [Inject]
        public IOButtonPresenter(IUIView uiView)
        {
            _uiView = uiView;
        }
        
        public IObservable<Unit> OnClickSaveAsObservable()
        {
            return _uiView.OnClickSaveAsObservable();
        }

        public IObservable<Unit> OnClickLoadAsObservable()
        {
            return _uiView.OnClickLoadAsObservable();
        }
    }
}