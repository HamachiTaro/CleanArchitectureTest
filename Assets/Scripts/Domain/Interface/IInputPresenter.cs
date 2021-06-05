using System;
using UnityEngine;

namespace Domain
{
    public interface IInputPresenter
    {
        /// <summary>
        /// GameObjectにPosition編集結果を渡す
        /// </summary>
        void ApplyPosition(Vector3 position);
        /// <summary>
        /// GameObjectにRotation編集結果を渡す
        /// </summary>
        void ApplyRotation(Vector3 rotation);
        /// <summary>
        /// GameObjectにScale編集結果を渡す
        /// </summary>
        void ApplyScale(Vector3 scale);
        IObservable<Vector3> OnChangePositionAsObservable();
        IObservable<Vector3> OnChangeRotationAsObservable();
        IObservable<Vector3> OnChangeScaleAsObservable();
    }
}