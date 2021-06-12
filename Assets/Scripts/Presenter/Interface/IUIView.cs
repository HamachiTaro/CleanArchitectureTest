using System;
using UniRx;
using UnityEngine;

namespace Presenter
{
    public interface IUIView
    {
        IObservable<Unit> OnClickLoadAsObservable();
        IObservable<Unit> OnClickSaveAsObservable();

        IObservable<Vector3> OnClickPositionAsObservable();
        IObservable<Vector3> OnClickRotationAsObservable();
        IObservable<Vector3> OnClickScaleAsObservable();
    }
}