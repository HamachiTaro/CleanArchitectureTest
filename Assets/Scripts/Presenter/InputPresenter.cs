using System;
using Domain;
using UnityEngine;
using Zenject;

namespace Presenter
{
    public class InputPresenter : IInputPresenter
    {
        private readonly IUIView _uiView;
        private readonly IGameView _gameView;
        
        [Inject]
        public InputPresenter(IUIView uiView, IGameView gameView)
        {
            Debug.Log("InputPresenter constructor");
            _uiView = uiView;
            _gameView = gameView;
        }
        
        public void ApplyPosition(Vector3 position)
        {
            _gameView.ChangePosition(0, position);
        }

        public void ApplyRotation(Vector3 rotation)
        {
            _gameView.ChangeRotation(0, rotation);
        }

        public void ApplyScale(Vector3 scale)
        {
            _gameView.ChangeScale(0, scale);
        }

        public IObservable<Vector3> OnChangePositionAsObservable()
        {
            return _uiView.OnClickPositionAsObservable();
        }

        public IObservable<Vector3> OnChangeRotationAsObservable()
        {
            return _uiView.OnClickRotationAsObservable();
        }

        public IObservable<Vector3> OnChangeScaleAsObservable()
        {
            return _uiView.OnClickScaleAsObservable();
        }
    }
}