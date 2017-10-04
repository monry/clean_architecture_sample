using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CASample.Presentation.Presenter {

    // View と UseCase (というか Model ？) との橋渡し

    public class Game : CAFU.Presentation.Presenter {

        public void BackToTitle(PointerEventData pointerEventData) {
            // 戻る処理
            // これも UseCase にやらせるべきなのかな？
        }

        public void BounceBackBall(Collision2D collision) {
            // ボールがぶつかった処理
        }

    }

}