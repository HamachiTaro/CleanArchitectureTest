using System;
using UniRx;
using UnityEngine;

namespace Presenter
{
    public interface IUIView
    {
        IObservable<Unit> OnClickLoadAsObservable();
        IObservable<Unit> OnClickSaveAsObservable();
        
        IObservable<float> OnPositionXAsObservable();
        IObservable<float> OnPositionYAsObservable();
        IObservable<float> OnPositionZAsObservable();
        
        IObservable<float> OnRotationXAsObservable();
        IObservable<float> OnRotationYAsObservable();
        IObservable<float> OnRotationZAsObservable();
        
        IObservable<float> OnScaleXAsObservable();
        IObservable<float> OnScaleYAsObservable();
        IObservable<float> OnScaleZAsObservable();
        
        void ChangePosition(Vector3 position);
        void ChangeRotation(Vector3 rotation);
        void ChangeScale(Vector3 scale);
    }
}