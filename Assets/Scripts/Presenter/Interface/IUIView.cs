using System;
using UnityEngine;

namespace Presenter
{
    public interface IUIView
    {
        IObservable<Vector3> OnClickPositionAsObservable();
        IObservable<Vector3> OnClickRotationAsObservable();
        IObservable<Vector3> OnClickScaleAsObservable();
    }
}