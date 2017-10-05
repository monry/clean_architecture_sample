using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace CASample.Presentation.View.Game {

    public class Ball : MonoBehaviour {

        private void Start() {
            ViewController.Instance.Presenter.SubjectForceToBall
                .Subscribe(
                    (velocity) => {
                        this.GetComponent<Rigidbody2D>().AddForce(velocity);
                    }
                );
        }

    }

}