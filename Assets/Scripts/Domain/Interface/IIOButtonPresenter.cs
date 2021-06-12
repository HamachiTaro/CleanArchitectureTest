using System;
using UniRx;

namespace Domain
{
    public interface IIOButtonPresenter
    {
        IObservable<Unit> OnClickSaveAsObservable();
        IObservable<Unit> OnClickLoadAsObservable();
    }
}