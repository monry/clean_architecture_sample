using System.Collections;
using System.Collections.Generic;
using CASample.Utility;
using UnityEngine;

namespace CASample.Presentation.View.Game {

    public class Root : RootBase<Root> {

        public Presenter.Game PresenterGame { get; set; }

        protected override void OnInitialized() {
            // ココで Presenter の初期化かな？
            // あと、キーボードイベントもココで受ける感じかな？
        }

    }

}