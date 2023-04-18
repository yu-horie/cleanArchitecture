using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace CleanArchitecture
{
    public interface ISamplePresenter : IPresenter
    {
        void Bind();
        IObservable<Unit> ButtonClickObservable { get; }
    }
}