using UnityEngine;
using Zenject;

namespace CleanArchitecture
{
    [DefaultExecutionOrder(999)]//mainはシーンの最後に実行したいので大きい値を取る
    public class Main : MonoBehaviour, ISceneMain
    {
        IUseCase sampleUseCase;

        [Inject]
        void ConstrucUseCases(
            ISamplePresenter samplePresenter,
            ISampleRepository sampleRepository
            )
        {
            sampleUseCase = new SampleUseCase
                (
                samplePresenter,
                sampleRepository
                );
        }

        void Awake()
        {
            sampleUseCase.Begin();
        }

        void OnDestroy()
        {
            sampleUseCase.Finish();
        }
    }
}