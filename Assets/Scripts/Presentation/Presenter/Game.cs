using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CASample.Presentation.Presenter {

    // View と UseCase (というか Model ？) との橋渡し

    public class Game {

        public void OnPointerUpButtonBack(PointerEventData pointerEventData) {
            // 戻る処理
            // これも UseCase にやらせるべきなのかな？
        }

        public void OnCollisionEnter2DReflectionBoard(Collision2D collision) {
            // 多分ボールがぶつかった処理
        }

    }

}