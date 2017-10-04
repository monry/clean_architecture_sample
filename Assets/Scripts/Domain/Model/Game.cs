using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CASample.Domain.Model {

    public class Game {

        // View で使うためのデータを定義するだけ
        // Entity を貰って自身のプロパティにセットする感じ
        //

    }

    /// <summary>
    /// 右上に表示する時間とスコア
    /// </summary>
    public class GameStatus {

        public int Time { get; set; }

        public int Score { get; set; }

        public GameStatus(int time, int score) {
            this.Time = time;
            this.Score = score;
        }

    }

}

