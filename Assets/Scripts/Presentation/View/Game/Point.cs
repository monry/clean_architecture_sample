using UnityEngine;
using UnityEngine.UI;

namespace CASample.Presentation.View.Game {

    public class Point : MonoBehaviour {

        [SerializeField]
        private Text label;

        private Text Label {
            get {
                return this.label;
            }
        }

        public void Refresh(Domain.Model.GameScore gameScore) {
            this.Label.text = string.Format("{0}", gameScore.Point);
        }

    }

}