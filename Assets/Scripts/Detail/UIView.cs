using System;
using Presenter;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

namespace Detail
{
    public class UIView : MonoBehaviour, IUIView
    {
        [SerializeField] private Button _positionButton;
        [SerializeField] private Button _rotationButton;
        [SerializeField] private Button _scaleButton;

        [SerializeField] private Slider _positionXSlider;
        [SerializeField] private Slider _positionYSlider;
        [SerializeField] private Slider _positionZSlider;
        
        [SerializeField] private Slider _rotationXSlider;
        [SerializeField] private Slider _rotationYSlider;
        [SerializeField] private Slider _rotationZSlider;
        
        [SerializeField] private Slider _scaleXSlider;
        [SerializeField] private Slider _scaleYSlider;
        [SerializeField] private Slider _scaleZSlider;

        [SerializeField] private Button _loadButton;
        [SerializeField] private Button _saveButton;
        
        
        private Vector3 _position = Vector3.zero;
        private Vector3 _rotation = Vector3.zero;
        private Vector3 _scale = Vector3.one;
        
        private CompositeDisposable _disposable;
        
        private void Start()
        {
            _disposable = new CompositeDisposable();

            _positionXSlider.OnValueChangedAsObservable().Subscribe(val => _position.x = val).AddTo(_disposable);
            _positionYSlider.OnValueChangedAsObservable().Subscribe(val => _position.y = val).AddTo(_disposable);
            _positionZSlider.OnValueChangedAsObservable().Subscribe(val => _position.z = val).AddTo(_disposable);

            _rotationXSlider.OnValueChangedAsObservable().Subscribe(val => _rotation.x = val).AddTo(_disposable);
            _rotationYSlider.OnValueChangedAsObservable().Subscribe(val => _rotation.y = val).AddTo(_disposable);
            _rotationZSlider.OnValueChangedAsObservable().Subscribe(val => _rotation.z = val).AddTo(_disposable);
            
            _scaleXSlider.OnValueChangedAsObservable().Subscribe(val => _scale.x = val).AddTo(_disposable);
            _scaleYSlider.OnValueChangedAsObservable().Subscribe(val => _scale.y = val).AddTo(_disposable);
            _scaleZSlider.OnValueChangedAsObservable().Subscribe(val => _scale.z = val).AddTo(_disposable);
        }

        private void OnDestroy()
        {
            Debug.Log("destroy uiView");
            _disposable.Dispose();
        }

        public IObservable<Unit> OnClickLoadAsObservable()
        {
            return _loadButton.OnClickAsObservable();
        }

        public IObservable<Unit> OnClickSaveAsObservable()
        {
            return _saveButton.OnClickAsObservable();
        }

        public IObservable<Vector3> OnClickPositionAsObservable()
        {
            return _positionButton.OnClickAsObservable().Select(_ => _position);
        }

        public IObservable<Vector3> OnClickRotationAsObservable()
        {
            return _rotationButton.OnClickAsObservable().Select(_ => _rotation);
        }

        public IObservable<Vector3> OnClickScaleAsObservable()
        {
            return _scaleButton.OnClickAsObservable().Select(_ => _scale);
        }
    }
}