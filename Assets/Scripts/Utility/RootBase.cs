using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CASample.Utility {

    /// <summary>
    /// View Root の基底クラス
    /// </summary>
    /// <remarks>TODO: namespace 深くする</remarks>
    /// <typeparam name="T">Root クラス</typeparam>
    public abstract class RootBase<T> : MonoBehaviour where T : RootBase<T> {

        private static T instance;

        public static T Instance {
            get {
                return instance;
            }
            private set {
                instance = value;
            }
        }

        protected abstract void OnInitialized();

        private void Awake() {
            Instance = (T)this;
        }

        private void OnDestroy() {
            Instance = null;
        }

    }
}

