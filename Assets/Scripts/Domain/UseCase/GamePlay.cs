using System.Collections;
using System.Collections.Generic;
using CAFU.Domain;
using UnityEngine;

namespace CASample.Domain.UseCase {

    public class GamePlay : IUseCase {

        public Repository.Score RepositoryScore { get; set; }

        public Presentation.Presenter.Game PresenterGame { get; set; }

        public void BounceBackBall() {
            this.PresenterGame.AddForceToBall(Vector2.up);
        }

    }

}

