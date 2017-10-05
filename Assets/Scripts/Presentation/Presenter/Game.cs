using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CASample.Presentation.Presenter {

    // View と UseCase (というか Model ？) との橋渡し

    public class Game : CAFU.Presentation.PresenterBase {

        public Subject<Vector2> SubjectForceToBall = new Subject<Vector2>();

        public Domain.UseCase.GamePlay UseCaseGamePlay { get; set; }

        public void BackToTitle(PointerEventData pointerEventData) {
            // 戻る処理
            // これも UseCase にやらせるべきなのかな？
        }

        public void BounceBackBall(Collision2D collision) {
            this.UseCaseGamePlay.BounceBackBall();
        }

        public void AddForceToBall(Vector2 velocity) {
            this.SubjectForceToBall.OnNext(velocity);
        }

    }

}