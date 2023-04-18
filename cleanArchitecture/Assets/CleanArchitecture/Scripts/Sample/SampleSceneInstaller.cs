using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace CleanArchitecture
{
    public class SampleSceneInstaller : MainInstallerBase
    {
        [SerializeField] SampleView sampleView = default;

        public override void InstallBindings()
        {
            base.InstallBindings();
            var factory = new SampleDataStoreFactory();
            var dataStore = factory.Create();

            Container
                .Bind<ISamplePresenter>()
                .FromInstance(new SamplePresenter(sampleView))
                .AsCached()
                .IfNotBound();

            Container
                .Bind<ISampleRepository>()
                .FromInstance(new SampleRepository(dataStore))
                .AsCached()
                .IfNotBound();
        }
    }
}