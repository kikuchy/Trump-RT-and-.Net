using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trump
{
    /// <summary>
    /// デッキをどんなデッキにして初期化するかを指定します。
    /// </summary>
    public enum DeckInitType
    {
        /// <summary>
        /// スペード、ハート、クラブ、ダイヤの4種とそれぞれ1～13までの、52枚のカードからなるデッキ。
        /// </summary>
        Standerd,

        /// <summary>
        /// ジョーカー1枚と、スペード、ハート、クラブ、ダイヤの4種とそれぞれ1～13までの、53枚のカードからなるデッキ。
        /// </summary>
        OneJoker,

        /// <summary>
        /// ジョーカー2枚と、スペード、ハート、クラブ、ダイヤの4種とそれぞれ1～13までの、54枚のカードからなるデッキ。
        /// </summary>
        TwoJokers,

        /// <summary>
        /// スペード、ハート、クラブ、ダイヤの4種とそれぞれ1～13までの、52枚のカードからなる未シャッフルのデッキ。
        /// </summary>
        StanderdAndNonShuffle
    }
}
