Trump-RT-and-.Net
=================

Windows Store Application ��A .Net�AWindows Phone�ł̊J���Ɏg�p�ł���A�g�����v���������C�u����


����
----

���̃��C�u�����́A�ȉ��̋@�\��񋟂��܂��B

- �����₷���J�[�h���f��
- ���������ȒP�ȎR�D�i�f�b�L�j���f��
- �����ɓ��삷���D���f��

���ɁA��D���f���́u�n�[�g��3������Ώo���v�Ƃ������A�X�[�g�i�}�[�N�j�ƃ����N�i�����j���w�肵���J�[�h�̎擾�������ɍs�����Ƃ��ł��܂��B�i�g�����v��2�g�ȏ㍬���Ă��Ȃ��Ȃ�΁AO(1)����j

���̃��C�u�������g���΁A�ʓ|�ȃJ�[�h�̎����������ōs�����ƂȂ��A�����Ƀg�����v�Q�[���̊J�����n�߂邱�Ƃ��ł��܂��B

new BSD Lisence �Ȃ̂ŁA�L���Ŕz�z����A�v���P�[�V�����ɂ��g�ݍ��ނ��Ƃ��ł��܂��B


�g�p��
-------

	class Player
	{
		// �v���C���[�͎�D������
		public Hand Cards = new Hand();
	}
	
	
	......
	
	
	Player[] players = {
		new Player(),
		new Player()
	};
	
	// �R�D��p�ӂ���B���ꂾ���ŃV���b�t���ς݂̎R�D���p�ӂł���B
	CardDeck deck = new CardDeck(DeckInitType.Standerd);
	
	// �v���C���[�ɔz��
	for(int i = 0; !deck.IsEmpty; i++)
	{
		players[i%2].Cards.Add(deck.TakeTopCard());
	}
	
	
	......
	
	
	Player p = players[0];
	Card c;
	// �n�[�g�̂R������Ώo������
	if((c = p.Cards.TakeCardOf(Suit.Heart, Rank.Three)) != null)
	{
		trash.Add(c);
	}


# ���C�Z���X

Copyright (c) 2012, Kikuchy All rights reserved.

���̃��C�u�����́Anew BSD License �̌��Œ񋟂���܂��B
�ڍׂ͓����� LICENSE �t�@�C�����Q�Ƃ��Ă��������B