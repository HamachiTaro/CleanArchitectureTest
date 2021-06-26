using System;
using Domain;
using UniRx;
using UnityEngine;
using Zenject;

namespace Presenter
{
    
    /// <summary>
    /// Presenterはデータ加工を目的にする？
    /// UIの各スライダーから受け取った値をVector3にまとめてUseCaseに渡す
    /// </summary>
    public class InputPresenter : IInputPresenter, IDisposable
    {
        private readonly IUIView _uiView;
        private readonly IGameView _gameView;
        
        /// <summary>
        /// uiから受け取ったPositionの各値をUseCaseのためにVector3にまとめる
        /// </summary>
        private readonly ReactiveProperty<Vector3> _positionValue = new ReactiveProperty<Vector3>();
        /// <summary>
        /// uiから受け取ったRotationの各値をUseCaseのためにVector3にまとめる
        /// </summary>
        private readonly ReactiveProperty<Vector3> _rotationValue = new ReactiveProperty<Vector3>();
        /// <summary>
        /// uiから受け取ったScaleの各値をUseCaseのためにVector3にまとめる
        /// </summary>
        private readonly ReactiveProperty<Vector3> _scaleValue = new ReactiveProperty<Vector3>();
        
        private readonly CompositeDisposable _disposable;
        
        [Inject]
        public InputPresenter(IUIView uiView, IGameView gameView)
        {
            Debug.Log("InputPresenter constructor");
            _uiView = uiView;
            _gameView = gameView;

            _disposable = new CompositeDisposable();

            _uiView.OnPositionXAsObservable()
                .Subscribe(x =>
                {
                    var pos = _positionValue.Value;
                    pos.x = x;
                    _positionValue.Value = pos;
                })
                .AddTo(_disposable);
            _uiView.OnPositionYAsObservable()
                .Subscribe(y =>
                {
                    var pos = _positionValue.Value;
                    pos.y = y;
                    _positionValue.Value = pos;
                })
                .AddTo(_disposable);
            _uiView.OnPositionZAsObservable()
                .Subscribe(z =>
                {
                    var pos = _positionValue.Value;
                    pos.z = z;
                    _positionValue.Value = pos;
                })
                .AddTo(_disposable);
            
            _uiView.OnRotationXAsObservable()
                .Subscribe(x =>
                {
                    var rotation = _rotationValue.Value;
                    rotation.x = x;
                    _rotationValue.Value = rotation;
                })
                .AddTo(_disposable);
            _uiView.OnRotationYAsObservable()
                .Subscribe(y =>
                {
                    var rotation = _rotationValue.Value;
                    rotation.y = y;
                    _rotationValue.Value = rotation;
                })
                .AddTo(_disposable);
            _uiView.OnRotationZAsObservable()
                .Subscribe(z =>
                {
                    var rotation = _rotationValue.Value;
                    rotation.z = z;
                    _rotationValue.Value = rotation;
                })
                .AddTo(_disposable);
            
            _uiView.OnScaleXAsObservable()
                .Subscribe(x =>
                {
                    var scale = _scaleValue.Value;
                    scale.x = x;
                    _scaleValue.Value = scale;
                })
                .AddTo(_disposable);
            _uiView.OnScaleYAsObservable()
                .Subscribe(y =>
                {
                    var scale = _scaleValue.Value;
                    scale.y = y;
                    _scaleValue.Value = scale;
                })
                .AddTo(_disposable);
            _uiView.OnScaleZAsObservable()
                .Subscribe(z =>
                {
                    var scale = _scaleValue.Value;
                    scale.z = z;
                    _scaleValue.Value = scale;
                })
                .AddTo(_disposable);
        }
        
        public void Dispose()
        {
            Debug.Log($"dispose : {this}");
            _positionValue?.Dispose();
            _disposable?.Dispose();
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
            return _positionValue;
        }

        public IObservable<Vector3> OnChangeRotationAsObservable()
        {
            return _rotationValue;
        }

        public IObservable<Vector3> OnChangeScaleAsObservable()
        {
            return _scaleValue;
        }
        
    }
}