
using CAFU.Domain.Repository;
using CASample.Domain.Repository;
using CASample.Domain.UseCase;
using UniRx;
using UnityEngine.SceneManagement;

namespace CASample.Presentation.Router {

    public class Title : CAFU.Presentation.RouterBase {

        public void LoadGame() {
            Routing.Instance.Load("Game", LoadSceneMode.Single)
                .Subscribe(
                    (entity) => {
                        var useCase = new GamePlay() {
                            RepositoryScore = Score.Instance,
                        };
                        var presenter = new Presentation.Presenter.Game();
//                        modelScene.ViewController.Inject(presenter, this);
                    }
                );
        }

    }

}