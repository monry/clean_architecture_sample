using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CASample.Presentation.View.Game {

    public class ButtonBack : UIBehaviour {

        protected override void Start() {
            this.OnPointerUpAsObservable().Subscribe(Root.Instance.PresenterGame.OnPointerUpButtonBack);
        }

    }

}