using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CleanArchitecture
{
    public abstract class NewScriptableObjectFactory<T> : IScriptableObjectFactory<T> where T : ScriptableObject
    {
        static T instance = null;

        public T Create()
        {
            if (instance == null)
            {
                instance = ScriptableObject.CreateInstance<T>();
            }
            return instance;
        }

        public T CreateFrom(T origin)
        {
            instance = origin;
            return instance;
        }

        public void Destroy()
        {
            ScriptableObject.Destroy(instance);
            instance = null;
        }
    }
}