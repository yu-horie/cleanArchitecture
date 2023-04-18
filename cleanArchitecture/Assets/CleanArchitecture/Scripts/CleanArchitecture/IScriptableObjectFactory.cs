using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CleanArchitecture
{
    public interface IScriptableObjectFactory<T> where T : ScriptableObject
    {
        T Create();
        T CreateFrom(T origin);
        void Destroy();
    }
}
