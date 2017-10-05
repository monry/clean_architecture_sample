using System;
using CAFU.Data;
using UnityEngine;

namespace CASample.Data.Entity {

    // 1行分の Row を表現するようなクラス
    // ActiveRecord が相当するか？

    [Serializable]
    public class Score : IEntity {

        [SerializeField]
        private int point;
        public int Point {
            get {
                return this.point;
            }
            set {
                this.point = value;
            }
        }

    }

}

