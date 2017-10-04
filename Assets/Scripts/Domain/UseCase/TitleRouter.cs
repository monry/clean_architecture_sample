using System.Collections;
using System.Collections.Generic;
using CAFU.Domain;
using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CASample.Domain.UseCase {

    public class TitleRouter : Router<Repository.Routing> {

        public void LoadGame() {
            this.RepositoryRouting.Load("Game", LoadSceneMode.Single)
                .Subscribe(
                    (entity) => {
                        Model.Scene modelScene = new Translator.Scene().Translate(entity);
                        var useCase = new UseCase.GamePlay() {
                            RepositoryScore = Repository.Score.Instance,
                        };
                        var presenter = new Presentation.Presenter.Game();
                        modelScene.ViewController.Inject(presenter, this);
                    }
                );
        }

    }

}