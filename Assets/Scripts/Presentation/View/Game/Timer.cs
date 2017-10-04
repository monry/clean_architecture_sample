using UnityEngine;
using UnityEngine.UI;

namespace CASample.Presentation.View.Game {

    public class Timer : MonoBehaviour {

        [SerializeField]
        private Text label;

        private Text Label {
            get {
                return this.label;
            }
        }

        public void Refresh(Domain.Model.GameStatus gameStatus) {
            this.Label.text = string.Format("{0}", gameStatus.Time);
        }

    }

}