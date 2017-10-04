using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace CASample.Presentation.View.Game {

    public class ReflectionBoard : MonoBehaviour {

        private void Start() {
            this.OnCollisionEnter2DAsObservable().Subscribe(ViewController.Instance.Presenter.BounceBackBall);
        }

    }

}