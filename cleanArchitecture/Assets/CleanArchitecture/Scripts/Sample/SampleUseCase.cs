using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;

namespace CleanArchitecture
{
    public class SampleUseCase : IUseCase
    {
        ISamplePresenter samplePresenter;
        ISampleRepository sampleRepository;
        CompositeDisposable disposables;

        public SampleUseCase(
            ISamplePresenter samplePresenter,
            ISampleRepository sampleRepository
            )
        {
            this.samplePresenter = samplePresenter;
            this.sampleRepository = sampleRepository;

            disposables = new CompositeDisposable();
        }

        public void Begin()
        {
            samplePresenter.Bind();

            //ボタンクリック
            samplePresenter
                .ButtonClickObservable
                .Subscribe(_ =>
                {
                    Debug.Log("click");
                }).AddTo(disposables);
        }

        public void Finish()
        {
            disposables.Clear();
        }
    }
}