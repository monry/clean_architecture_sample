using UniRx;
using UniRx.Triggers;
using UnityEngine.EventSystems;

namespace CASample.Presentation.View.Game {

    public class ButtonBack : UIBehaviour {

        protected override void Start() {
            this.OnPointerUpAsObservable().Subscribe(ViewController.Instance.Presenter.BackToTitle);
        }

    }

}