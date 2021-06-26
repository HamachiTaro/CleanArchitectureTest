using System;
using Presenter;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

namespace Detail
{
    /// <summary>
    /// positionは-5~5
    /// rotationは-180~180
    /// scaleは0~3
    /// </summary>
    public class UIView : MonoBehaviour, IUIView
    {
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
        
        private void Start()
        {
            
        }

        private void OnDestroy()
        {
            Debug.Log("destroy uiView");
        }

        public IObservable<Unit> OnClickLoadAsObservable()
        {
            return _loadButton.OnClickAsObservable();
        }

        public IObservable<Unit> OnClickSaveAsObservable()
        {
            return _saveButton.OnClickAsObservable();
        }
        
        public IObservable<float> OnPositionXAsObservable()
        {
            return _positionXSlider.OnValueChangedAsObservable();
        }

        public IObservable<float> OnPositionYAsObservable()
        {
            return _positionYSlider.OnValueChangedAsObservable();
        }

        public IObservable<float> OnPositionZAsObservable()
        {
            return _positionZSlider.OnValueChangedAsObservable();
        }

        public IObservable<float> OnRotationXAsObservable()
        {
            return _rotationXSlider.OnValueChangedAsObservable();
        }

        public IObservable<float> OnRotationYAsObservable()
        {
            return _rotationYSlider.OnValueChangedAsObservable();
        }

        public IObservable<float> OnRotationZAsObservable()
        {
            return _rotationZSlider.OnValueChangedAsObservable();
        }

        public IObservable<float> OnScaleXAsObservable()
        {
            return _scaleXSlider.OnValueChangedAsObservable();
        }

        public IObservable<float> OnScaleYAsObservable()
        {
            return _scaleYSlider.OnValueChangedAsObservable();
        }

        public IObservable<float> OnScaleZAsObservable()
        {
            return _scaleZSlider.OnValueChangedAsObservable();
        }

        public void ChangePosition(Vector3 position)
        {
            _positionXSlider.value = position.x;
            _positionYSlider.value = position.y;
            _positionZSlider.value = position.z;
        }

        public void ChangeRotation(Vector3 rotation)
        {
            _rotationXSlider.value = rotation.x;
            _rotationYSlider.value = rotation.y;
            _rotationZSlider.value = rotation.z;
        }

        public void ChangeScale(Vector3 scale)
        {
            _scaleXSlider.value = scale.x;
            _scaleYSlider.value = scale.y;
            _scaleZSlider.value = scale.z;
        }
    }
}