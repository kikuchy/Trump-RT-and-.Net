Trump-RT-and-.Net
=================

Windows Store Application や、 .Net、Windows Phoneでの開発に使用できる、トランプを扱うライブラリ


特徴
----

このライブラリは、以下の機能を提供します。

- 扱いやすいカードモデル
- 初期化が簡単な山札（デッキ）モデル
- 高速に動作する手札モデル

特に、手札モデルは「ハートの3があれば出す」といった、スート（マーク）とランク（数字）を指定したカードの取得を高速に行うことができます。（トランプを2組以上混ぜていないならば、O(1)操作）

このライブラリを使えば、面倒なカードの実装を自分で行うことなく、すぐにトランプゲームの開発を始めることができます。

new BSD Lisence なので、有料で配布するアプリケーションにも組み込むことができます。


使用例
-------

	class Player
	{
		// プレイヤーは手札を持つ
		public Hand Cards = new Hand();
	}
	
	
	......
	
	
	Player[] players = {
		new Player(),
		new Player()
	};
	
	// 山札を用意する。これだけでシャッフル済みの山札が用意できる。
	CardDeck deck = new CardDeck(DeckInitType.Standerd);
	
	// プレイヤーに配る
	for(int i = 0; !deck.IsEmpty; i++)
	{
		players[i%2].Cards.Add(deck.TakeTopCard());
	}
	
	
	......
	
	
	Player p = players[0];
	Card c;
	// ハートの３があれば出したい
	if((c = p.Cards.TakeCardOf(Suit.Heart, Rank.Three)) != null)
	{
		trash.Add(c);
	}


# ライセンス

Copyright (c) 2012, Kikuchy All rights reserved.

このライブラリは、new BSD License の元で提供されます。
詳細は同梱の LICENSE ファイルを参照してください。