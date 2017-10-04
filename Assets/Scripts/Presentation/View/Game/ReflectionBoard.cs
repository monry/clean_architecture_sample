using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace CASample.Presentation.View.Game {

    public class ReflectionBoard : MonoBehaviour {

        private void Start() {
            this.OnCollisionEnter2DAsObservable().Subscribe(Root.Instance.PresenterGame.OnCollisionEnter2DReflectionBoard);
        }

    }

}