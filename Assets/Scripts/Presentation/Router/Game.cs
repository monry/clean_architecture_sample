
using CAFU.Domain.Repository;
using UniRx;
using UnityEngine.SceneManagement;

namespace CASample.Presentation.Router {

    public class Game : CAFU.Presentation.RouterBase {

        public void LoadTitle() {
            Routing.Instance.Load("Title", LoadSceneMode.Single)
                .Subscribe(
                    (entity) => {

                    }
                );
        }

        public void LoadGameResult() {
            Routing.Instance.Load("Game_Result", LoadSceneMode.Additive)
                .Subscribe(
                    (entity) => {

                    }
                );
        }

    }

}
