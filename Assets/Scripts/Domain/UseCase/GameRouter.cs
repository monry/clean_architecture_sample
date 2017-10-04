using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CAFU.Domain;
using CASample.Presentation.View.Game;
using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CASample.Domain.UseCase {

    /// <remarks>ルーティングの処理は特殊なので UseCase を拡張する</remarks>
    public class GameRouter : Router<Repository.Routing> {

        public void LoadTitle() {
            this.RepositoryRouting.Load("Title", LoadSceneMode.Single)
                .Subscribe(
                    (entity) => {

                    }
                );
        }

        public void LoadGameResult() {
            this.RepositoryRouting.Load("Game_Result", LoadSceneMode.Additive)
                .Subscribe(
                    (entity) => {

                    }
                );
        }

    }

}