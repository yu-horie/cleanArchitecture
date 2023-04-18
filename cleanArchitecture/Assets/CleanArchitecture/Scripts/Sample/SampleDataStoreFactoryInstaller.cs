using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace CleanArchitecture
{
    public class SampleDataStoreFactoryInstaller : MonoInstaller<SampleDataStoreFactoryInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<IScriptableObjectFactory<SampleDataStore>>()
                .FromInstance(new SampleDataStoreFactory())
                .AsSingle();
        }
    }
}