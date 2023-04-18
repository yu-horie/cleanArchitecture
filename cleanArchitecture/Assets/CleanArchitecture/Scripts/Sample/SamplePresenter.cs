using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;

namespace CleanArchitecture
{
    public class SamplePresenter : ISamplePresenter
    {
        readonly ISampleView view;
        public IObservable<Unit> ButtonClickObservable { private set; get; }

        public SamplePresenter(ISampleView view)
        {
            this.view = view;
        }

        public void Bind()
        {
            ButtonClickObservable = view.SampleButton.OnClickAsObservable();
        }
    }

}
