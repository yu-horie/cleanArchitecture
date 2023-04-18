using System;
using System.Collections;
using System.Collections.Generic;

namespace CleanArchitecture
{
    public interface IUseCase
    {
        void Begin();
        void Finish();
    }

    public static class IEnumerableIUseCaseEx
    {
        public static void ForEachBegin(this IEnumerable<IUseCase> usecases)
        {
            if (usecases != null)
            {
                foreach (var uc in usecases)
                {
                    uc.Begin();
                }
            }
        }

        public static void ForEachFinish(this IEnumerable<IUseCase> usecases)
        {
            if (usecases != null)
            {
                foreach (var uc in usecases)
                {
                    uc.Finish();
                }
            }
        }
    }
}
