using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trump
{
    /// <summary>
    /// トランプのスート(マーク)を表します
    /// </summary>
    public enum Suit
    {
        /// <summary>
        /// トランプのジョーカーを表します
        /// </summary>
        Joker = 0,

        /// <summary>
        /// トランプのハートを表します
        /// </summary>
        Heart = 1,

        /// <summary>
        /// トランプのスペードを表します
        /// </summary>
        Spade = 2,

        /// <summary>
        /// トランプのダイヤを表します
        /// </summary>
        Diamond = 3,

        /// <summary>
        /// トランプのクラブを表します
        /// </summary>
        Club = 4
    }
}
