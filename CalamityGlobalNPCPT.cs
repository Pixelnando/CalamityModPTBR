using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using CalamityMod.Items.Weapons.Rogue;
using CalamityMod.NPCs.TownNPCs;
using CalamityMod.World;
using CalamityMod.CalPlayer;
using CalamityMod;
using System.Collections.Generic;

public class CalamityGlobalNPCPT : GlobalNPC
{
	public CalamityGlobalNPCPT()
	{

	}

	public override void OnChatButtonClicked(NPC npc, bool firstButton)
	{
		if (npc.type == ModContent.NPCType<FAP>() && !firstButton)
		{
			Main.npcChatText = "Você falhou " + Main.player[Main.myPlayer].Calamity().deathCount + " vezes.";
		}
		if (npc.type == ModContent.NPCType<THIEF>() && !firstButton)
		{
			int goblinIndex = NPC.FindFirstNPC(107);
			if (goblinIndex != -1)
			{
				NPC goblin = Main.npc[goblinIndex];
				Main.npcChatText = Main.npcChatText.Replace("Want in on a little secret? Since " + goblin.GivenName + " always gets so much cash from you, I've been stealing some of it as we go. I need you to keep quiet about it, so here.", "Quer saber um segredinho? Já que " + goblin.GivenName + " sempre tira muito dinheiro de você, venho roubando parte dele à medida que avançamos. Preciso que você fique calado sobre isso, então aqui está..");
				Main.npcChatText = Main.npcChatText.Replace("Hey, if government officials can get tax, why can't I? The heck do you mean that these two things are nothing alike?", "Ei, se os funcionários do governo podem receber impostos, por que eu não posso? Espera, você quer dizer que essas duas coisas não são nada parecidas?");
			}
			Main.npcChatText = Main.npcChatText.Replace("Sorry, I got nothing. Perhaps you could reforge something and come back later...", "Desculpe, estou de bolsos vazios. Talvez você possa forjar algo novamente e voltar mais tarde...");
		}
		if (npc.type == ModContent.NPCType<SEAHOE>() && !firstButton)
		{
			string[][] seahoeQuotes = new string[][]
			{
				new string[2]{ "Draedon's style of confrontation is very...alien and hands-off. You may be more likely to fight any one of his mechs before taking him down.",
					"O estilo de luta de Draedon é bem... estranho e relaxado. É bem provável que você lute contra uma de suas bestas mecânicas antes de derrotá-lo."},
				new string[2]{ "Lord Yharim possesses god-like strength. He may not even fight you at full power which is fortunate for you. His attacks may just kill you in one hit, so be careful.",
					"O Senhor Yharim possui um poder divino. É possível que ele lute contra você usando apenas uma parte de sua força total, o que é uma sorte para você. Os seus ataques podem matá-lo com apenas um golpe, então tome cuidado."},
				new string[2]{ "Pockets of ore have appeared once more in the land. This will allow you to create the most powerful weaponry and armor imagined!",
					"Veias de minérios apareceram mais uma vez nas terras. Isso permitirá que você crie os armamentos e as armaduras mais poderosas que você já imaginou!"},
				new string[2]{ "Ah, the dragon Yharon is fickle. You may find that he will refuse to use his full power unless you are strong enough to unleash the power of the Dark Sun.",
					"Ah, o dragão Yharon é inconstante. Ele se recusará a usar todo o seu poder, a menos que você seja forte o suficiente para liberar o poder do Sol Escuro."},
				new string[2]{ "The Devourer of Gods is extremely powerful. However, he is young, foolhardy, and very lazy. Perhaps if he had been given time to develop he would have turned into quite the threat.",
					"O Devorador de Deuses é extremamente poderoso. No entanto, ele é jovem, temerário e muito preguiçoso. Talvez, se ele tivesse tido tempo para se desenvolver, ele se tornaria uma ameaça maior."},
				new string[2]{ "With the cosmic steel you can fashion many of your weapons into much more powerful forms.",
					"Com o aço cósmico, você pode transformar suas armas em formas muito mais poderosas."},
				new string[2]{ "The Devourer of God's cosmic armor is unique in that it is capable of not only protecting his body from tearing itself apart when ripping through the fabric of space and time, but also allows him to control his powers.",
					"A armadura cósmica do Devorador de Deuses é única por ser capaz de não apenas proteger seu corpo de se dilacerar ao rasgar o tecido do espaço e do tempo, mas também permitir que ele controle seus poderes."},
				new string[2]{ "Ah...I can sense a powerful change in the weather. You may want to venture to the Sulphurous Seas once more during the rain to experience it.",
					"Ah... Posso sentir uma mudança poderosa no clima. Você pode querer visitar os Mares Sulfurosos mais uma vez durante a chuva para vivenciá-lo."},
				new string[2]{ "The Abyss holds many secrets revealed with time. Checking it out again may not be a bad idea.",
					"O Abismo guarda muitos segredos revelados com o tempo. Pode não ser uma má ideia explorá-lo novamente."},
				new string[2]{ "The Dungeon seems to be more active now. You may hear the faint whisperings of angry spirits who have not left to the Void...I would recommend searching there before taking on the Sentinels.",
					"O Calabouço parece estar mais ativo agora. É possível que você ouça os sussuros fracos de espíritos furiosos que não partiram para o Vazio... Eu recomendo que você procure lá antes de enfrentar as Sentinelas."},
				new string[2]{ "Ironic, is it not, that Statis was defeated by the very Sentinel his people fashioned their art of stealth from. Fate so often weaves cruel tales.",
					"Irônico, não é? Statis foi derrotado pela mesma Sentinela com o qual seu povo moldou a sua arte furtiva. O destino tece contos tão cruéis."},
				new string[2]{ "The Rune of Kos holds a significant portion of Providence's brand of magic, easily distinguishable from all others. Activating it in certain places would have some...risky consequences.",
					"A Runa de Kos contém uma porção significativa da marca de magia da Providência, facilmente distinguível de todas as outras. Ativá-la em certos lugares teria algumas... consequências arriscadas."},
				new string[2]{ "The stories have it that when Providence faced and defeated Yharim and his forces she lost a lot of energy and reverted to a more skeletal form. She's merely a fraction of the power she was before.",
					"As histórias dizem que quando a Providência enfrentou e derrotou Yharim e suas forças, ela perdeu muita energia e voltou a uma forma mais esquelética. Ela é apenas uma fração do poder que tinha antes."},
				new string[2]{ "Providence is as much the sun goddess as much as the Moon Lord is the moon god. They are two sides of the same coin, choosing to remain neutral amongst our petty squabbles.",
					"A Providência é tanto a deusa do sol quando o Senhor da Lua é o deus da lua. Eles são os dois lados da mesma moeda, optando por permanecer neutros em nossas disputas mesquinhas."},
				new string[2]{ "Touching Providence's offerings is usually a death wish. Shame that Yharim didn't think to just mess with her things to get her out of hiding.",
					"Tocar nas ofertas da Providência costuma ser um desejo de morte. Pena que Yharim não pensou em mexer nas coisas dela para tirá-la do esconderijo."},
				new string[2]{ "The Profaned Guardians will do anything to protect their goddess. Makes sense they would die for her since they can be revived just as quickly.",
					"Os Guardiões Profanos farão qualquer coisa para proteger a sua deusa. Faz sentido que eles morram para ela, já que eles podem ser revividos com a mesma rapidez."},
				new string[2]{ "Profaned creatures now lurk in the Hallow and in Hell. If you destroy enough and gather their essence together you shall be able to capture the attention of the Profaned Guardians.",
					"Criaturas profanas agora se escondem no Sagrado e no Inferno. Se você destruir o suficiente e reunir sua essência, você será capaz de chamar a atenção dos Guardiões Profanos."},
				new string[2]{ "Your adventure focuses to the jungle it seems. The Dragonfolly and its swarming offspring should be eliminated before their numbers spiral out of control.",
					"Sua aventura se concentra na selva, ao que parece. O Pássaro-dragão e sua prole infestante devem ser eliminados antes que seus números saiam de controle."},
				new string[2]{ "The plague was just one of the many experiments authorized by Yharim to raze towns to the ground. This is probably one of the few he shelved for being too terrible.",
					"A praga foi apenas um dos muitos experimentos autorizados por Yharim para arrasar cidades. Este é provavelmente um dos poucos que ele engavetou por ser muito terrível."},
				new string[2]{ "The Abyss has become far more active than before. You might be able to mine some of the volcanic rubble contained within.",
					"O Abismo se tornou muito mais ativo do que antes. Você pode ser capaz de extrair alguns dos escombros vulcânicos contidos nele."},
				new string[2]{ "The men at the front of the dungeon are performing a ritual to keep the Moon Lord contained in his prison. In order to gain Yharim's attention, however, you may need to defeat them.",
					"Os homens na frente do calabouço estão realizando um ritual para manter o Senhor da Lua contido em sua prisão. Para chamar a atenção de Yharim, no entanto, pode ser preciso derrotá-los."},
				new string[2]{ "When exploring the jungle temple be careful. You may not wish to disturb the Lihzard's idol, the Golem. It's quite the destructive force.",
					"Ao explorar o templo da selva, tenha cuidado. Você pode não querer perturbar o ídolo Lagharto, o Golem. Ele é uma força bastante destrutiva."},
				new string[2]{ "Be careful when defeating Plantera and the Golem. You might accidentally unleash a new threat in the jungle that needs to be quelled.",
					"Tenha cuidado ao derrotar a Plantera e o Golem. Você pode acidentalmente liberar uma nova ameaça na selva que precisa ser reprimida."},
				new string[2]{ "If you've gathered the souls used to power those automatons head once more to the jungle. You will find a powerful enemy to fight, which will unleash the full fervor of the jungle once defeated. Do not underestimate it!",
					"Se você reuniu as almas usadas para alimentar esses autômatos, vá mais uma vez para a selva. Você encontrará um inimigo poderoso para enfrentar, que irá liberar todo o fervor da selva uma vez derrotado. Não o subestime!"},
				new string[2]{ "The Brimstone Crags...Yharim despised that place, and did everything he could to raze it to the ground. It might explain a few things about him.",
					"Os Rochedos de Enxofre... Yharim desprezava aquele lugar e fez de tudo para destruí-lo. Isso pode explicar algumas coisas sobre ele."},
				new string[2]{ "If you take an idol down to the Brimstone Crags you might be able to see just what is lurking in the shadows.",
					"Se você levar um ídolo até o Rochedo de Enxofre, você poderá ver o que está se escondendo nas sombras."},
				new string[2]{ "Once those mechanical creations have been defeated you would do well to seek out the crippled clone of the witch, Calamitas. It might provide some useful weaponry.",
					"Uma vez que essas criações mecânicas tenham sido derrotadas, você faria bem em procurar o clone mal-feito da bruxa, Calamitas. Ela pode fornecer alguns armamentos úteis."},
				new string[2]{ "I would recommend saving some of your old items. You never know if you can engineer them into stronger weapons in the future.",
					"Eu recomendaria guardar alguns de seus itens antigos. Nunca se sabe se você pode transformá-los em armas mais fortes no futuro."},
				new string[2]{ "Have you heard of the story of Archmage Permafrost? Rumor has it he's been locked away in an icy prison by Lord Yharim. Perhaps you would be able to free him if Cryogen was destroyed.",
					"Você já ouviu falar da história do Arqui-mago Permafrost? Rumores dizem que ele foi trancado em uma prisão gelada pelo Senhor Yharim. Talvez você consiga libertá-lo se o Criogênio for destruído."},
				new string[2]{ "You will find more ores have been unlocked due to the magic sealing them away being dispelled. Some of them may require more than just the ore itself to create.",
					"Você descobrirá que mais minérios foram destravados devido à magia que os selava ter sido dissipada. Alguns deles podem exigir mais do que apenas o próprio minério para serem criados."},
				new string[2]{ "Throughout the world lie various structures left behind by Draedon. Archaic defenses may remain, but the goods inside may be worth your while.",
					"Em todo o mundo existem várias estruturas deixadas para trás por Draedon. As defesas arcaicas podem permanecer, mas os bens dentro podem baler a pena."},
				new string[2]{ "The Crimson used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.",
					"O Carmim costumava ser facilmente gerenciável e controlado pela natureza. No entanto, as guerras recentes e a poluição desequilibraram a balança."},
				new string[2]{ "The Corruption used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.",
					"A Corrupção costumava ser facilmente gerenciável e controlado pela natureza. No entanto, as guerras recentes e a poluição desequilibraram a balança."},
				new string[2]{ "The dungeon is a dark place. None of us know of its true purpose, however, the ancient Eidolist cultists used it for worship before Lord Yharim took it over.",
					"O calabouço é um lugar escuro. Nenhum de nós sabe de seu verdadeiro propósito, no entanto, os antigos cultistas Eidolistas o usavam para adoração antes do Senhor Yharim assumi-lo."},
				new string[2]{ "I'm assuming you've heard the legends that speak of the ninja, Statis? There are some who say that if you were able to defeat the gods which his clan once worshipped you would be able to harness some of his powers.",
					"Presumo que você já tenha ouvido as lendas que falam do ninja, Statis? Alguns dizem que, se você fosse capaz de derrotar os deuses que seu clã uma vez adorou, você seria capaz de controlar parte de seus poderes."},
				new string[2]{ "Scattered across the lands are shrines dedicated to the gods. You can take whatever is in them, but a few items you may not be able to use until much later.",
					"Espalhados pelas terras estão santuários dedicados aos deuses. Você pode pegar o que quer que esteja neles, mas alguns itens talvez não consiga usar até muito mais tarde."},
				new string[2]{ "Be careful what you attack in the Crimson. You might just unveil a greater threat than what was there before.",
					"Tenha cuidado com o que você ataca no Carmim. Você pode acabar relevando uma ameaça maior do que a que estava lá antes."},
				new string[2]{ "Be careful what you attack in the Corruption. You might just unveil a greater threat than what was there before.",
					"Tenha cuidado com o que você ataca na Corrupção. Você pode acabar relevando uma ameaça maior do que a que estava lá antes."},
				new string[2]{ "The Sulphurous Seas were created long ago, when Yharim's dungeon could no longer hold as many corpses as it needed to. Many of the bodies were dumped into the ocean. This, along with severe pollution from the heydays of Draedon's experiments have turned a paradise into a wasteland.",
					"Os Mares Sulfurosos foram criados há muito tempo, quando o calabouço de Yharim não podia mais conter tantos cadáveres quanto precisava. Muitos dos corpos foram jogados no oceano. Isso, junto com a poluição severa do apogeu dos experimentos de Draedon, transformou um paraíso em um deserto."},
				new string[2]{ "The Sulphurous Seas are dangerous. The toxic waters will burn your skin, but if you can brave them you will be able to reach the Abyss, where there are powerful weapons and dangers aplenty.",
					"Os Mares Sulfurosos são perigosos. As águas tóxicas queimarão a sua pele, mas se você puder enfrentá-las, você será capaz de alcançar o Abismo, onde xistem armas poderosas e perigos em abundância."},
				new string[2]{ "Ah yes, the Abyss. That trench is full of powerful creatures that could devour you in a heartbeat. I would explore the dungeon first.",
					"Ah sim, o Abismo. Aquela fossa está cheia de criaturas poderosas que podem devorá-lo em um piscar de olhos. Eu exploraria o calabouço primeiro."},
				new string[2]{ "Have you heard of the Brimstone Crags? It was once a grand kingdom, not too different from my own. However, it also met a similar fate. I would not advise going down there, unless you seek a painful death.",
					"Você já ouviu do Rochedo de Enxofre? Já foi um grande reino, não muito diferente do meu. No entanto, também teve um destino semelhante. Eu não aconselharia ir lá, a menos que você busque uma morte dolorosa."},
				new string[2]{ "There are rumors of ores that lay in latency. When you defeat certain bosses you will undo the ancient magic which conceals those materials.",
					"Existem rumores de minérios que estão em latência. Quando você derrota certos chefes, você desfaz a magia ancestral que esconde esses materiais."}
			};
			foreach (string[] chat in seahoeQuotes)
			{
				if (!chat[1].Equals(""))
				{
					Main.npcChatText = Main.npcChatText.Replace(chat[0], chat[1]);
				}
			}
		}
	}

	public override void GetChat(NPC npc, ref string chat)
	{
		int fapsol = NPC.FindFirstNPC(ModContent.NPCType<FAP>());
		int permadong = NPC.FindFirstNPC(ModContent.NPCType<DILF>());
		int seahorse = NPC.FindFirstNPC(ModContent.NPCType<SEAHOE>());
		int thief = NPC.FindFirstNPC(ModContent.NPCType<THIEF>());
		int dryad = NPC.FindFirstNPC(20);
		int angelstatue = NPC.FindFirstNPC(17);
		int armsDealerIndex = NPC.FindFirstNPC(19);
		int nurseIndex = NPC.FindFirstNPC(18);
		int tavernKeep = NPC.FindFirstNPC(550);
		int waifu = NPC.FindFirstNPC(353);
		int partyGirl = NPC.FindFirstNPC(208);
		int lilBitch = NPC.FindFirstNPC(369);

		/*
			Setting NPC names to avoid AOOB when evaluated at -1
			Maybe write a dedicated function someday because this is dirty
			Indexes -
			nurse : 0
			armsDealer : 1
			fapsol : 2
			merchant : 3
			lilBitch (probably angler): 4
			partyGirl : 5
			waifu (probably stylist) : 6
			permafrost : 7
			tavernkeep : 8
			dryad : 9
			amidias : 10
			thief : 11
		*/
		string[] givenNames = new string[12];
		for (int j = 0; j < givenNames.Length; j++)
		{
			givenNames[j] = "";
		}
		if (nurseIndex != -1)
		{
			givenNames[0] = Main.npc[nurseIndex].GivenName;
		}
		if (armsDealerIndex != -1)
		{
			givenNames[1] = Main.npc[armsDealerIndex].GivenName;
		}
		if (fapsol != -1)
		{
			givenNames[2] = Main.npc[fapsol].GivenName;
		}
		if (angelstatue != -1)
		{
			givenNames[3] = Main.npc[angelstatue].GivenName;
		}
		if (lilBitch != -1)
		{
			givenNames[4] = Main.npc[lilBitch].GivenName;
		}
		if (partyGirl != -1)
		{
			givenNames[5] = Main.npc[partyGirl].GivenName;
		}
		if (waifu != -1)
		{
			givenNames[6] = Main.npc[waifu].GivenName;
		}
		if (permadong != -1)
		{
			givenNames[7] = Main.npc[permadong].GivenName;
		}
		if (tavernKeep != -1)
		{
			givenNames[8] = Main.npc[tavernKeep].GivenName;
		}
		if (dryad != -1)
		{
			givenNames[9] = Main.npc[dryad].GivenName;
		}
		if (seahorse != -1)
		{
			givenNames[10] = Main.npc[seahorse].GivenName;
		}
		if (thief != -1)
		{
			givenNames[11] = Main.npc[thief].GivenName;
		}

		string fabSpecialQuote = "You're all pretty good! ...wait, who are you again?";
		string[][] translatedChat = new string[][] {
			new string[2]{
				"Could you be so kind as to, ah...check hell for me...? I left someone I kind of care about down there.",
				"Você poderia ter a gentileza de, ah... verificar o inferno para mim...? Eu deixei alguém meio importante para mim lá embaixo."
			},
			new string[2]{
				"I have this sudden shiver up my spine, like a meteor just fell and thousands of innocent creatures turned into monsters from the stars.",
				"Sinto um arrepio repentino pelo meu corpo, como se um meteoro tivesse acabado de cair e milhares de criaturas inocentes se transformassem em monstros das estrelas."
			},
			new string[2]{
				"The dungeon seems even more restless than usual, watch out for the powerful abominations stirring up in there.",
				"O calabouço parece ainda mais inquieto do que o normal. Tenha cuidado com as poderosas abominações que se agitam por lá."
			},
			new string[2]{
				"Seems like extinguishing that butterfly caused its life to seep into the hallowed areas, try taking a peek there and see what you can find!",
				"Parece que a extinção daquela borboleta fez com que sua vida se infiltrasse nas áreas sagradas. Tente dar uma olhada lá e ver o que você pode encontrar!"
			},
			new string[2]{
				"I've heard there is a portal of antimatter absorbing everything it can see in the dungeon, try using the Rune of Kos there!",
				"Ouvi dizer que há um portal de antimatéria absorvendo tudo o que consegue ver no calabouço. Tente usar a Runa de Kós lá!"
			},
			new string[2]{
				"I don't feel very safe; I think there's pigs following me around and it frightens me.",
				"Não me sinto muito seguro; acho que tem porcos me seguindo por todo o lugar, e isso me deixa aterrorizado."
			},
			new string[2]{
				"Sometimes, " + givenNames[2] + " just looks at me funny and I'm not sure how I feel about that.",
				"Ás vezes, " + givenNames[2] + " olha para mim de um jeito engraçado e eu não tenho certeza de como eu me sinto sobre isso."
			},
			new string[2]{
				"Someone tell " + givenNames[10] + " to quit trying to throw me out of town, it's not going to work.",
				"Alguém diga a " + givenNames[10] + " para parar de tentar me expulsar da cidade, não vai funcionar."
			},
			new string[2]{
				"Tell " + givenNames[2] + " I'll take up her offer and meet with her at the back of " + givenNames[3] + "'s house.",
				"Diga a " + givenNames[2] + " que eu aceitarei a sua oferta e me encontrarei com ela nos fundos da casa de " + givenNames[3] + "."
			},
			new string[2]{
				"What'dya buyin'?",
				"Que que você vai comprar?"
			},
			new string[2]{
				"My home here has an extensive history and a mysterious past. You'll find out quickly just how extensive it is...",
				"Meu lar aqui tem uma longa história e um passado misterioso. Você descobrirá rapidamente o quão extenso é..."
			},
			new string[2]{
				"I have unique items if you show me that you have bested the guardian of this jungle.",
				"Possuo itens únicos se você me mostrar que superou o guardião desta selva."
			},
			new string[2]{
				"This is as good a time as any to pick up the best ingredients for potions.",
				"É uma boa hora para recolher os melhores ingredientes para poções."
			},
			new string[2]{
				"I have a feeling we're going to have absolutely fantastic parties with " + givenNames[2] + " around!",
				"Tenho a sensação de que vamos ter festas absolutamente fantásticas com " + givenNames[2] + " por perto!"
			},
			new string[2]{
				"I think my light display is turning into an accidental bug zapper. At least the monsters are enjoying it.",
				"Acho que meu display de luzes está virando um mata-mosquitos acidental. Pelo menos os monstros estão gostando."
			},
			new string[2]{
				"Ooh! I love parties where everyone wears a scary costume!",
				"Ooh! Eu amo festas onde todos vestem fantasias assustadoras!"
			},
			new string[2]{
				"A little sickness isn't going to stop me from doing my work as an artist!",
				"Uma pequena doença não vao me impedir de fazer meu trabalho como artista!"
			},
			new string[2]{
				"There's a surprising art to this area. A sort of horrifying, eldritch feeling. It inspires me!",
				"Há uma arte surpreendente nesta área. Uma espécie de sensação horripilante e sobrenatural. Isso me inspira!"
			},
			new string[2]{
				"Think " + givenNames[7] + " would let me paint him like one of his French girls?!",
				"Você acha que " + givenNames[7] + " deixaria que eu pintasse ele como uma de suas garotas francesas?!"
			},
			new string[2]{
				"I'm not exactly suited for this cold weather. Still looks pretty, though.",
				"Não sou exatamente adequado para este clima frio. Ainda parece bonito, no entanto."
			},
			new string[2]{
				"I hate sand. It's coarse, and rough and gets in my paint.",
				"Eu odeio a areia. Ela é grossa e áspera e entra na minha tinta."
			},
			new string[2]{
				"Do you think unicorn blood could be used as a good pigment or resin? No I'm not going to find out myself.",
				"Você acha que sangue de unicórnio pode ser usado como um bom pigmento ou resina? Não, eu não vou descobrir sozinho."
			},
			new string[2]{
				"I can't work in this environment. All of my paint just floats off.",
				"Não posso trabalhar neste ambiente. Toda a minha tinta simplesmente sai flutuando."
			},
			new string[2]{
				"Painting the tortoises in a still life isn't going so well.",
				"Pintar as tartarugas em uma natureza morta não está indo muito bem."
			},
			new string[2]{
				"I can't paint a still life if the fruit grows legs and walks away.",
				"Não posso pintar uma natureza morta se a fruta cresce pernas e sai andando."
			},
			new string[2]{
				"On the canvas, things get heated around here all the time. Like the environment!",
				"Na tela, as coisas esquentam o tempo todo por aqui. Igual o ambiente!"
			},
			new string[2]{
				"Sorry, I'm all out of watercolors. They keep evaporating.",
				"Desculpe, estou sem aquarela. Ela continua evaporando."
			},
			new string[2]{
				"Roses, really? That's such an overrated thing to paint.",
				"Rosas, sério? Isso é uma coisa muito comum de se pintar."
			},
			new string[2]{
				"Fun fact! Sulphur was used as pigment once upon a time! Or was it Cinnabar?",
				"Você sabia que o enxofre já foi usado como pigmento? Ou era cinábrio?"
			},
			new string[2]{
				"Easiest landscape I've ever painted in my life.",
				"Esta foi a paisagem mais fácil que já pintei na minha vida."
			},
			new string[2]{
				"I'd let " + givenNames[7] + " coldheart MY icicle.",
				"Eu deixaria " + givenNames[7] + " congelar o MEU sincelo."
			},
			new string[2]{
				"Space just got way too close for comfort.",
				"O espaço está perigosamente perto."
			},
			new string[2]{
				"There's a dark solar energy emanating from the moths that appear during this time. Ah, the moths as you progress further get more powerful...hmm...what power was Yharon holding back?",
				"Há uma energia solar escura emanando das mariposas que aparecem durante esse período. Ah, as mariposas ficam mais poderosas à medida que você avança...hmm...que poder Yharon estava segurando?"
			},
			new string[2]{
				"That starborne illness sits upon this land like a blister. Do even more vile forces of corruption exist in worlds beyond?",
				"Essa doença transmitida pelas estrenas assenta nesta terra como uma bolha. Existem forças ainda mais vis da corrupção em outros mundos?"
			},
			new string[2]{
				givenNames[2] + " put me up to this.",
				"Foi" + givenNames[2] + " quem me disse para fazer isso."
			},
			new string[2]{
				"My ancestor was lost here long ago. I must pay my respects to her.",
				"Minha ancestral foi perdida aqui há muito tempo. Devo prestar meus respeitos a ela."
			},
			new string[2]{
				"\u0093I'm not here for any reason! Just picking up mushrooms for uh, later use.",
				"\u0093Não estou aqui por nenhum motivo em específico! Só estou recolhendo cogumelos para, uh, usar mais tarde."
			},
			new string[2]{
				"Please don't catch space lice. Or " + "Crimson" + " lice. Or just lice in general.",
				"Por favor, não pegue piolhos espaciais. Ou piolhos do carmim. Ou apenas piolhos em geral."
			},
			new string[2]{
				"Please don't catch space lice. Or " + "Corruption" + " lice. Or just lice in general.",
				"Por favor, não pegue piolhos espaciais. Ou piolhos da corrupção. Ou apenas piolhos em geral."
			},
			new string[2]{
				"Sometimes I catch " + givenNames[2] + " sneaking up from behind me.",
				"Às vezes eu pego " + givenNames[2] + " se esgueirando atrás de mim."
			},
			new string[2]{
				givenNames[2] + " is always trying to brighten my mood...even if, deep down, I know she's sad.",
				givenNames[2] + " está sempre tentando alegrar meu humor...mesmo que, no fundo, eu saiba que ela está triste."
			},
			new string[2]{
				"They look so cute and yet, I can feel their immense power just by being near them. What are you?",
				"Eles são tão fofos e, ainda assim, posso sentir o seu imenso poder apenas por estar perto deles. O que é você?"
			},
			new string[2]{
				"I hate to break it to you, but you don't have hair to cut or style, hun.",
				"Odeio te dizer isto, mas você não tem cabelo para cortar ou pentear, meu amor."
			},
			new string[2]{
				"Aww, they're so cute, do they have names?",
				"Aww, eles são tão fofos! Eles têm nomes?"
			},
			new string[2]{
				"Hey, is it just me or have my pockets gotten lighter ever since " + givenNames[11] + " arrived?",
				"Ei, é impressão minha ou os meus bolsos ficaram mais leves desde que " + givenNames[11] + " chegou?"
			},
			new string[2]{
				"You know...we haven't had an invasion in a while...",
				"Sabe...não tivemos uma invasão há um tempo..."
			},
			new string[2]{
				"That's the biggest moth I've ever seen for sure. You'd need one big gun to take one of those down.",
				"Essa é a maior mariposa que eu já vi, com certeza. Você precisará de uma grande arma para derrubar uma delas."
			},
			new string[2]{
				"Is it me or are your weapons getting bigger and bigger?",
				"É impressão minha ou suas armas estão ficando cada vez maiores?"
			},
			new string[2]{
				"Each night seems only more foreboding than the last. I feel unthinkable terrors are watching your every move.",
				"Cada noite parece apenas mais agourenta do que a anterior. Eu sinto que terrores impensáveis estão observando cada movimento seu."
			},
			new string[2]{
				"Are you daft?! Turn off those lamps!",
				"Você está maluco?! Desligue essas lâmpadas!"
			},
			new string[2]{
				"If this acid rain keeps up, there'll be a shortage of Dirt Blocks soon enough!",
				"Se essa chuva ácida continuar, logo haverá uma escassez de blocos de terra!"
			},
			new string[2]{
				"I happen to have several Angel Statues at the moment, a truely rare commodity. Want one?",
				"Por acaso, eu tenho várias estátuas de anjo no momento, uma mercadoria realmente rara. Quer uma?"
			},
			new string[2]{
				"The caverns have become increasingly dark as of late, so I stocked up on some special torches if you have the funds.",
				"As cavernas têm se tornado cada vez mais escuras ultimamente, então eu estoquei algumas tochas especiais, se você tiver dinheiro."
			},
			new string[2]{
				"What do you mean your traps aren't making the cut? Don't look at me!",
				"Como assim, as suas armadilhas não estão mais dando conta? Não olhe para mim!"
			},
			new string[2]{
				"Um...should my nightlight be on?",
				"Um...minha luz noturna deveria estar acesa?"
			},
			new string[2]{
				"Well, I like " + givenNames[2] + ", but I, ah...I have my eyes on someone else.",
				"Bem, eu gosto de " + givenNames[2] + ", mas eu , ah... eu estou de olho em outra pessoa."
			},
			new string[2]{
				"Maybe I should've waterproofed my gadgets... They're starting to corrode.",
				"Talvez eu devesse ter impermeabilizado meus dispositivos... Eles estão começando a corroer."
			},
			new string[2]{
				"Care for a little Moonshine?",
				"Quer um pouquinho de álcool contrabandeado?"
			},
			new string[2]{
				"Sheesh, " + givenNames[2] + " is a little cruel, isn't she? I never claimed to be an expert on anything but ale!",
				"Caraamba, " + givenNames[2] + " é um pouco cruel, não acha? Nunca disse ser um especialista em nada além de cerveja!"
			},
			new string[2]{
				"Aye, I've heard of a mythical creature in the oceans, singing with an alluring voice. Careful when yer fishin out there.",
				"Ei, ouvi boatos sobre uma criatura mítica nos oceanos, cantando com uma voz atraente. Cuidado quando estiver pescando por aí."
			},
			new string[2]{
				"I have to thank ye again for takin' care of that sea serpent. Or was that another one...",
				"Tenho que te agradecer novamente por cuidar daquela serpente marinha. Ou aquele era outro..."
			},
			new string[2]{
				"I remember legends about that " + givenNames[10] + ". He ain't quite how the stories make him out to be though.",
				"Lembro-me de lendas sobre " + givenNames[10] + ". Ele não é bem como as histórias o fazem parecer."
			},
			new string[2]{
				"Twenty-nine bottles of beer on the wall...",
				"Vinte e nove garrafas de cerveja na parede..."
			},
			new string[2]{
				"Now this is a scene that I can admire any time! I feel like something is watching me though.",
				"Essa sim é uma cena que posso admirar a qualquer momento! Eu sinto que algo está me observando, no entanto."
			},
			new string[2]{
				"It ain't much of a sight, but there's still life living in these waters.",
				"Não é grande espetáculo, mas ainda há vida vivendo nessas águas."
			},
			new string[2]{
				"Me ship might just sink from the acid alone.",
				"É possível que meu barco afunde apenas com o ácido."
			},
			new string[2]{
				"All these moments will be lost in time. Like tears...in the rain.",
				"Todos esses momentos se perderão com o tempo, como lágrimas... na chuva."
			},
			new string[2]{
				"Always shoot for the moon! It has clearly worked before.",
				"Sempre mire para a lua! Claramente funcionou antes."
			},
			new string[2]{
				"Draedon? He's...a little 'high octane' if you know what I mean.",
				"Draedon? Ele... é meio 'sobrecarregado' se você entende o que quero dizer."
			},
			new string[2]{
				"Those oversized bugs terrorizing the jungle... Surely you of all people could shut them down!",
				"Esses insetos enormes aterrorizando a selva... Certamente você, entre todas as pessoas, poderia encerrá-los!"
			},
			new string[2]{
				"Who you gonna call?",
				"Quem você vai chamar?"
			},
			new string[2]{
				"Those screams...I'm not sure why, but I feel like a nameless fear has awoken in my heart.",
				"Aqueles gritos... Não sei por que, mas sinto como se um medo sem nome tivesse despertado em meu coração."
			},
			new string[2]{
				"I can faintly hear ghostly shrieks from the dungeon...and not ones I'm familiar with at all. Just what is going on in there?",
				"Ouço vagamente gritos fantasmagóricos vindos da masmorra... e não aqueles que eu conheço. O que está acontecendo lá?"
			},
			new string[2]{
				"Whatever that thing was, I'm glad it's gone now.",
				"Não sei o que era aquela coisa, mas estou feliz que já tenha ido embora."
			},
			new string[2]{
				"Houston, we've had a problem.",
				"Houston, temos um problema."
			},
			new string[2]{
				"Just what is that contraption? It makes my Teleporters look like child's play!",
				"Mas o que é essa engenhoca? Ela faz meus teleportadores parecerem um brinquedo de criança!"
			},
			new string[2]{
				"Yep! I'm also considering being a space pirate now.",
				"Sim! Também estou considerando virar uma pirata espacial."
			},
			new string[2]{
				"Some of my machines are starting to go haywire thanks to this Astral Infection. I probably shouldn't have built them here",
				"Algumas máquinas minhas estão começando a enlouquecer graças à infecção astral. Eu provavelmente não devia ter construído elas aqui..."
			},
			new string[2]{
				"I'm sorry I really don't have any Unicorn proof tech here, you're on your own.",
				"Desculpe, não tenho nenhuma tecnologia à prova de unicórnios aqui. Você está por conta própria."
			},
			new string[2]{
				"Have you seen those gemstone creatures in the caverns? Their colors are simply breathtaking!",
				"Você já viu as criaturas de pedras preciosas nas cavernas? Suas cores são de tirar o fôlego!"
			},
			new string[2]{
				"Do you think " + givenNames[7] + " knows how to 'let it go?'",
				"Você acha que " + givenNames[7] + " diria 'livre estou?'"
			},
			new string[2]{
				"BAH! Doesn't seem like I'll ever be able to quarrel with the debts of the town again!",
				"Parece que nunca mais conseguirei combater as dívidas da cidade de novo!"
			},
			new string[2]{
				"Where and how are you getting all of this money?",
				"Onde e como você está conseguindo todo esse dinheiro?"
			},
			new string[2]{
				"Perhaps with all that time you've got you could check those old ruins? Certainly something of value in it for you!",
				"Talvez, com todo esse tempo livre que você tem, você poderia verificar aquelas velhas ruínas? Tenho certeza que haverá algo de valor para você!"
			},
			new string[2]{
				"Devourer of what, you said? Devourer of Funds, if its payroll is anything to go by!",
				"Devorador de quê? Fundos? Se é que seu pagamento é alguma coisa!"
			},
			new string[2]{
				"Goodness! That cane has swagger!",
				"Meu deus! Essa bengala tem estilo!"
			},
			new string[2]{
				"I deeply appreciate you rescuing me from being trapped within my frozen castle... It's been many, many years...",
				"Agradeço profundamente por você ter me resgatado de estar preso em meu castelo de gelo... Já se passaram anos, muitos anos..."
			},
			new string[2]{
				"Thank you for saving me...though now I admit I am without a home since mine got destroyed.",
				"Obrigado por me salvar... embora agora eu não possua uma casa, já que a minha foi destruída."
			},
			new string[2]{
				"I must admit...I am not quite used to this weather. It's too warm for my taste...",
				"Devo admitir... não estou muito acostumado com esse clima. Está quente demais para o meu gosto..."
			},
			new string[2]{
				"My dear! What is it you would like to talk about today?",
				"Querido! Sobre o que você gostaria de falar hoje?"
			},
			new string[2]{
				"Why...I don't have to worry about any time of the day! If it is hot...then I can use my ice magic to cool down!",
				"Bem... eu não preciso me preocupar com o tempo! Se estiver calor... então eu posso usar a minha magia de gelo para me esfriar!"
			},
			new string[2]{
				"I do usually prefer a spot of humidity for my ice magic. It likes to come out as steam when it's too hot and dry...",
				"Geralmente, eu prefiro um pouco de umidade para a minha magia de gelo. Ela gosta de sair como vapor quando está muito quente e seco..."
			},
			new string[2]{
				"Magic is a skill that must be learned and practiced! You seem to have an inherent talent for it at your age. I have spent all of my life honing it...",
				"A magia é uma habilidade que deve ser aprendida e praticada! Você parece ter um talento inerente para isso na sua idade. Passei toda a minha vida aprimorando-a..."
			},
			new string[2]{
				"Why ice magic, you ask? Well, my parents were both pyromaniacs...",
				"Por que a magia de gelo, você pergunta? Bem, meus pais eram ambos piromaníacos..."
			},
			new string[2]{
				"There be monsters lurking in the darkness. Most...unnatural monsters.",
				"Existem monstros à espreita na escuridão. Monstros... não naturais."
			},
			new string[2]{
				"You could break the icy stillness in the air tonight.",
				"Você poderia quebrar a quietude gelada no ar esta noite."
			},
			new string[2]{
				"Hmm...some would say that an unforeseen outside force is the root of the blood moon...",
				"Hmm... alguns diriam que uma força externa imprevista é a raiz da lua de sangue..."
			},
			new string[2]{
				"I was once the greatest Archmage of ice that ever hailed the lands. Whether or not that is still applicable, I am not sure...",
				"Eu já fui o maior Arquimago de gelo que já saudou as terras. Se isso ainda é aplicável ou não, não tenho certeza..."
			},
			new string[2]{
				"There used to be other Archmages of other elements. I wonder where they are now...if they are also alive...",
				"Costumava existir outros Arquimagos de outros elementos. Me pergunto onde eles estão agora...e se eles também estão vivos..."
			},
			new string[2]{
				"Oh...I wish I could tell you all about my life and the lessons I have learned, but it appears you have a great many things to do...",
				"Oh... eu gostaria de contar tudo sobre minha vida e as lições que aprendi, mas parece que você tem muitas coisas a fazer..."
			},
			new string[2]{
				"I assure you, I will do my best to act as the cool grandfather figure you always wanted.",
				"Eu garanto a você, farei o meu melhor para agir como o vovô legal que você sempre quis."
			},
			new string[2]{
				"Sometimes...I feel like all I'm good for during these events is making ice cubes and slushies.",
				"Às vezes... eu sinto que, durante esses eventos, eu sirvo apenas para fazer cubos de gelo e raspadinhas."
			},
			new string[2]{
				"Tread carefully, my friend... Now that the Moon Lord has been defeated, many powerful creatures will crawl out to challenge you...",
				"Tenha cuidado, meu amigo... Agora que o Senhor da Lua foi derrotado, muitas criaturas poderosas irão rastejar para desafiá-lo..."
			},
			new string[2]{
				"I feel the balance of nature tilting farther than ever before. Is it due to you, or because of the events leading to now...?",
				"Eu sinto o equilíbrio da natureza se inclinando mais do que nunca. Será que a culpa é sua, ou é por causa dos eventos que levaram até agora...?"
			},
			new string[2]{
				"I felt a sudden chill down my spine. I sense something dangerous stirring in the Abyss...",
				"Senti um arrepio repentino no meu corpo. Eu sinto algo perigoso se agitando no Abismo..."
			},
			new string[2]{
				"...Where is Lord Yharim? He must be up to something...",
				"...Onde está o Senhor Yharim? Ele deve estar tramando algo..."
			},
			new string[2]{
				"Yes, I am older than " + givenNames[9] + ". You can stop asking now...",
				"Sim, eu sou mais velho que " + givenNames[9] + ". Você pode parar de perguntar agora..."
			},
			new string[2]{
				"What an adorable tiny companion you have! Where in the world did you find such a...creature...? Actually, I'd rather not know.",
				"Que companheira adorável você tem! Onde no mundo você encontrou tal... criatura? Na verdade, prefiro não saber."
			},
			new string[2]{
				Main.player[Main.myPlayer].name + "...just between us, I think I forgot my soul in the ice castle. If you see it, please do let me know.",
				Main.player[Main.myPlayer].name + "...só entre nós, acho que esqueci minha alma no castelo de gelo. Se você a vir, por favor, me avise."
			},
			new string[2]{
				"It wouldn't be the first time something unknown and powerful dropped from the heavens...I would tread carefully if I were you...",
				"Não é a primeira vez que algo desconhecido e poderoso cai dos céus... Eu tomaria cuidado se fosse você..."
			},
			new string[2]{
				"Why are you talking to me right now? Either way, I expect you to turn in a perfect performance!",
				"Por que você está falando comigo agora? De qualquer forma, espero que você tenha uma performance perfeita!!"
			},
			new string[2]{
				"I could smell my vodka from MILES away!",
				"Eu podia sentir o cheiro da minha vodka a QUILÔMETROS de distância!"
			},
			new string[2]{
				"Have any spare rooms available? Preferably candle-lit with a hefty supply of booze.",
				"Tem algum quarto disponível? De preferência à luz de velas com uma boa quantidade de bebida."
			},
			new string[2]{
				"Hey, nice night! I'm gonna make some Bloody Marys, celery included. Want one?",
				"Ei, boa noite! Vou preparar algumas Marias Sangrentas, incluindo aipo. Quer uma?"
			},
			new string[2]{
				"More blood for the blood gods!",
				"Mais sangue para os deuses de sangue!"
			},
			new string[2]{
				"Everyone else is so rude tonight. If they don't get over it soon, I'll break down their doors and make them!",
				"Todo mundo está tão rude esta noite. Se eles não superarem logo, eu vou arrombar suas portas e irei fazê-los parar!"
			},
			new string[2]{
				"Being drunk, I have no moral compass atm.",
				"Estando bêbada, eu não tenho nenhum guia moral no momemnto."
			},
			new string[2]{
				"Nothard/10, if I fight bosses I wanna feel like screaming 'OH YES DADDY!' while I die repeatedly.",
				"Fácil/10, se eu lutar contra chefes, eu quero ter vontade de gritar 'AI PAI, PARA!' enquanto eu morro repetidamente."
			},
			new string[2]{
				"Like I always say, when you're drunk you can tolerate annoying people a lot more easily...",
				"Como eu sempre digo, quando você está bêbado, você consegue tolerar pessoas irritantes com muito mais facilidade..."
			},
			new string[2]{
				"I'm literally balls drunk off my sass right now.",
				"Estou literalmente tão bêbada para ser atrevida agora."
			},
			new string[2]{
				"I'm either laughing because I'm drunk or because I've lost my mind. Probably both.",
				"Ou estou rindo porque estou bêbada ou porque perdi a cabeça. Provavelmente os dois."
			},
			new string[2]{
				"When I'm drunk I'm way happier...at least until the talking worms start to appear.",
				"Quando estou bêbada, eu fico muito mais feliz... pelo menos até que os vermes falantes comecem a aparecer."
			},
			new string[2]{
				"I should reprogram the whole game while drunk and send it back to the testers.",
				"Eu devia reprogramar o jogo inteiro enquanto estou bêbada e enviar ele de volta para os testadores."
			},
			new string[2]{
				"What a great day, might just drink so much that I get poisoned again.",
				"Que dia ótimo. Talvez eu beba tanto que fique envenenada novamente."
			},
			new string[2]{
				"A perfect night...for alcohol! First drinks are on me!",
				"Uma noite perfeita... para o álcool! As primeiras bebidas são por minha conta!"
			},
			new string[2]{
				"Here's a challenge...take a drink whenever you get hit. Oh wait, you'd die.",
				"Aqui está um desafio... tome uma bebida sempre que for atingido. Ah, espera, você morreria."
			},
			new string[2]{
				"Well I was planning to light some candles in order to relax...ah well, time to code while drunk.",
				"Bem, eu estava planejando acender algumas velas para relaxar... bem, hora de fazer o código enquanto estou bêbada."
			},
			new string[2]{
				"Yes, everyone knows the mechworm is buggy. Well, not so much anymore, but still.",
				"Sim, todo mundo sabe que o vermecânico é bugado. Bem, nem tanto mais, mas ainda sim."
			},
			new string[2]{
				"That's west, " + Main.player[Main.myPlayer].name + ". You're fired again.",
				"Esse é o oeste, " + Main.player[Main.myPlayer].name + ". Você está demitido. De novo."
			},
			new string[2]{
				"Are you sure you're 21? ...alright, fine, but don't tell anyone I sold you this.",
				"Você tem certeza que tem mais de 18 anos? ...tudo bem, mas não diga a ninguém que lhe vendi isso."
			},
			new string[2]{
				"Drink something that turns you into a magical flying unicorn so you can be super gay.",
				"Beba algo que te transforme em um unicórnio voador mágico para que você possa ser super gay."
			},
			new string[2]{
				"Did anyone ever tell you that large assets cause back pain? Well, they were right.",
				"Alguém já lhe disse que grandes coisas causam dor nas costas? Bem, eles estavam certos."
			},
			new string[2]{
				"You'll always find me at parties where booze is involved...well, you'll always find booze where I'm involved.",
				"Você sempre me encontrará em festas onde a bebida está envolvida... bem, você sempre encontrará a bebida onde eu estiver envolvida."
			},
			new string[2]{
				"Shoot down the space invaders! Sexy time will be postponed if we are invaded by UFOs!",
				"Dispare nos invasores do espaço! O tempo safado será adiado se formos invadidos por OVNIs!"
			},
			new string[2]{
				"God I can't wait to beat on some ice again!",
				"Meu Deus, eu mal posso esperar para bater no gelo de novo!"
			},
			new string[2]{
				"The only things I'm attracted to are fish women, women, men who look like women and that's it.",
				"As únicas coisas que me atraem são mulheres peixes, mulheres, homens que se parecem com mulheres e só."
			},
			new string[2]{
				"I'll always be watching.",
				"Sempre estarei observando."
			},
			new string[2]{
				"Why did that weird monster need that many tentacles? ...actually, don't answer that.",
				"Por que aquele monstro estranho precisava de tantos tentáculos? ...na verdade, não responda."
			},
			new string[2]{
				"There's chemicals in the water...and they're turning the frogs gay!",
				"Há produtos químicos na água... e eles estão deixando os sapos gays!"
			},
			new string[2]{
				"I saw a ghost down by the old train tracks once, flailing wildly at the lily pads, those were the days.",
				"Uma vez, vi um fantasma perto dos trilhos do velho trem, agitando-se violentamente contra as vitórias régias. Eram bons tempos!"
			},
			new string[2]{
				"I hear it's amazing when the famous purple-stuffed worm out in flap-jaw space, with the tuning fork, does a raw blink on Hara-kiri rock. I need scissors! 61!",
				"Ouvi dizer que é incrível quando o famoso verme de pelúcia roxo no espaço da mandíbula aberta, com o diapasão, pisca bruscamente na rocha Hara-kiri. Eu preciso de uma tesoura! 61!"
			},
			new string[2]{
				"Tell " + givenNames[8] + " to stop calling me. He's not wanted.",
				"Diga a " + givenNames[8] + " para parar de me ligar. Não estou interessada."
			},
			new string[2]{
				"My booze will always be better than " + givenNames[8] + "'s, and nobody can convince me otherwise.",
				"Minha bebida sempre será melhor do que a de " + givenNames[8] + ", e ninguém pode me convencer que não."
			},
			new string[2]{
				"I never realized how well-endowed " + givenNames[7] + " was. It had to be the largest icicle I had ever seen.",
				"Eu nunca percebi o quão bem dotado " + givenNames[7] + " era. Tinha que ser o maior sincelo que eu já vi."
			},
			new string[2]{
				"You still can't stop me from trying to move in with " + givenNames[6] + ".",
				"Você não pode me impedir de tentar morar com " + givenNames[6] + "."
			},
			new string[2]{
				"I love it when " + givenNames[6] + "'s hands get sticky from all that...wax.",
				"Eu adoro quando as mãos de " + givenNames[6] + " ficam pegajosas com toda aquela... cera."
			},
			new string[2]{
				givenNames[6] + " works wonders for my hair...among other things.",
				givenNames[6] + " faz maravilhas para o meu cabelo... entre outras coisas."
			},
			new string[2]{
				"Ever since " + givenNames[6] + " moved in I haven't been drinking as much...it's a weird feeling.",
				"Desde que " + givenNames[6] + " se mudou, eu não tenho bebido tanto... é uma sensação estranha."
			},
			new string[2]{
				"Is that a toy? Looks like something I'd carry around if I was 5 years old.",
				"Isso é um brinquedo? Parece algo que eu carregaria se eu tivesse 5 anos."
			},
			new string[2]{
				"Nice scales...did it get hot in here?",
				"Belas escamas... por acaso, está ficando quente aqui?"
			},
			new string[2]{
				"Oh yeah, now you're drinking the good stuff! Do you like it? I created the recipe by mixing fairy dust, crystals and other magical crap.",
				"Aí sim, agora você está bebendo uma das boas! Você gostou? Eu criei a receita misturando pó de fada, cristais e outras porcarias mágicas."
			},
			new string[2]{
				"So...you're riding me, huh? That's not weird at all.",
				"Então... você está me montando, hein? Isso não é nem um pouco estranho."
			},
			new string[2]{
				"Are you coming on to me?",
				"Você está gozando comigo?"
			},
			new string[2]{
				"If I was a magical horse, I'd be out in space, swirling cocktails, as I watch space worms battle for my enjoyment.",
				"Se eu fosse um cavalo mágico, eu estaria no espaço, misturando coquetéis, enquanto observo os vermes espaciais batalharem para meu entretenimento."
			},
			new string[2]{
				"Is this...what the world is like now? It seems so much more lifeless than when I saw it before I disappeared.",
				"É assim... como o mundo é agora? Parece muito mais sem vida do que quando o vi antes de eu desaparecer."
			},
			new string[2]{
				"Thank you for your service, my child, but I am afraid I am without a home now.",
				"Obrigado pelo seu serviço, meu filho, mas infelizmente estou sem casa agora."
			},
			new string[2]{
				"My homeland may have dried up but the memories of my people still remain. I will not let them be in vain.",
				"Minha terra natal pode ter secado, mas as memórias de meu povo ainda permanecem. Não vou permitir que sejam em vão."
			},
			new string[2]{
				"There is a lot that you do not know about this world, specifically regarding the past. Much of it has been lost to history due to the many wars that plagued it.",
				"Há muito que você não conhece sobre este mundo, especificamente sobre o passado. Muito disso se perdeu na história devido às muitas guerras que o assolaram."
			},
			new string[2]{
				"How can I survive on land? Ah, that is a secret. No, actually...I can breathe air like you!",
				"Como eu consigo sobreviver fora d'água? Ah, isso é segredo. Não, na verdade... eu posso respirar ar como você!"
			},
			new string[2]{
				"Why do you ask if it's the males that carry the young? Don't your males carry their young?",
				"Por que você pergunta se são os machos que carregam os filhotes? Seus machos não carregam seus filhotes?"
			},
			new string[2]{
				"There be monsters lurking in the darkness. Most...unnatural monsters.",
				"Existem monstros à espreita na escuridão. Monstros... não naturais."
			},
			new string[2]{
				"Most creatures look up at the moon and admire it. I look up and fear it.",
				"A maioria das criaturas olha para a lua e a admira. Eu olho para cima e temo-a."
			},
			new string[2]{
				"Oh, me? I don't sleep, it's part of my nature.",
				"Ah, eu? Eu não durmo, faz parte da minha natureza."
			},
			new string[2]{
				givenNames[5] + " asked if my nose could be used as a vuvuzela. What is a vuvuzela?",
				givenNames[5] + " perguntou se meu nariz poderia ser usado como uma vuvuzela. O que é uma vuvuzela?"
			},
			new string[2]{
				"Meet me at " + givenNames[4] + "'s house at night. We're going to throw him to the Trashers.",
				"Encontre-me na casa de " + givenNames[4] + " à noite. Vamos jogá-lo para os crocodilos."
			},
			new string[2]{
				"Not sure how " + givenNames[4] + " has not been roasted and digested by now, hanging around the sulphuric seas for so long. Perhaps it got to his head.",
				"Não sei como " + givenNames[4] + " não foi torrado e digerido agora, estando perto dos mares sulfúricos por tanto tempo. Talvez tenha subido à cabeça dele."
			},
			new string[2]{
				"Rumor has it " + givenNames[2] + " drinks to forget her troubled past.",
				"Rumores dizem que " + givenNames[2] + " bebe para esquecer seu passado conturbado."
			},
			new string[2]{
				"I'm never keen on these nights. They're so violent.",
				"Nunca estou entusiasmado nessas noites. Elas são tão violentas."
			},
			new string[2]{
				"Ah, nice duds, my child!",
				"Ah, lindos insucessos, meu filho!"
			},
			new string[2]{
				"Shouldn't you be wearing a clam bra?",
				"Você não deveria estar usando um sutiã de conchas?"
			},
			new string[2]{
				"The balance between light and dark is tipping. Stay strong, my child.",
				"O equilíbrio entre a luz e a escuridão está caindo. Fique forte, meu filho."
			},
			new string[2]{
				"Ah, you are starting to realize just how complicated this world is now. You are learning the story of what became of him.",
				"Ah, você está começando a perceber o quão complicado este mundo é agora. Você está aprendendo a história do que aconteceu com ele."
			},
			new string[2]{
				"Do you ever get the feeling that something out there is watching you very carefully? Whatever it is, it's very small and sly, I think.",
				"Você já teve a sensação de que algo lá fora está te observando com muito cuidado? Seja o que for, é muito pequeno e astuto, eu acho."
			},
			new string[2]{
				"I must admit, I am quite shaken up now. Never would I have imagined that I would see one of the dark gods again. Not in this lifetime anyhow.",
				"Devo admitir que estou bastante abalado agora. Nunca teria imaginando que veria um dos deuses das trevas novamente. Não nesta vida de qualquer maneira."
			},
			new string[2]{
				"Times like this I wish my home was still in one piece instead of evaporated away. I don't blame the witch for anything, it's just...oh, never mind.",
				"Em momentos como este, gostaria que minha casa ainda estivesse inteira, em vez de ter evaporado. Eu não culpo a bruxa por nada, é só... ah, deixa pra lá."
			},
			new string[2]{
				"I suppose that witch was mistaken. Defeating the Ceaseless Void and the Devourer has not caused our world to collapse... but I would not lower my guard if I were you.",
				"Suponho que aquela bruxa estava enganada. Derrotar o Vazio Incessante e o Devorador não causou o colapso de nosso mundo... mas eu não baixaria a minha guarda se fosse você."
			},
			new string[2]{
				"Oy, watch where you're going or I might just use you for dart practice.",
				"Opa, presta atenção pra onde tá indo, ou posso acabar usando você como um alvo."
			},
			new string[2]{
				"Bet you'd look good as a pincushion, amiright?",
				"Aposto que você ficaria bem como um saco de pancadas, não acha?"
			},
			new string[2]{
				"Zombies don't dodge very well. Maybe you'll do a bit better.",
				"Os zumbis não conseguem desviar muito bem. Talvez você se saia um pouco melhor que eles."
			},
			new string[2]{
				"Hey, careful over there. I've rigged the place. One wrong step and you're going to get a knife in your forehead.",
				"Ei, cuidado aí, eu enchi o lugar de armadilhas. Um passo errado e você levará uma facada na testa."
			},
			new string[2]{
				"You know what's really cool? Watching the glint of throwing stars as they reflect the moon.",
				"Sabe o que é realmente legal? Observar o brilho das estrelas ninja refletindo a lua."
			},
			new string[2]{
				"You think those stars that fall occasionally would make good throwing weapons?",
				"Você acha que aquelas estrelas que caem ocasionalmente seriam boas armas de arremesso?"
			},
			new string[2]{
				"Statis' clan's got nothing on me. Mostly cause they're all dead.",
				"O clã de Statis não tem nada contra mim. Afinal, eles estão todos mortos."
			},
			new string[2]{
				"Where is my party hat? Well, I stole it of course.",
				"Onde está o meu chapéu de festa? Bem, eu roubei ele, é claro."
			},
			new string[2]{
				"The nice thing about maps is I can track anything that has fallen.",
				"A bom dos mapas é que eu posso rastrear qualquer coisa que caiu."
			},
			new string[2]{
				"Imagine how fast you could throw if you just had more hands.",
				"Imagine o quão rápido você poderia lançar se você tivesse mais mãos."
			},
			new string[2]{
				"I also take food for currency.",
				"Eu também aceito comida como pagamento."
			},
			new string[2]{
				"Usually I only think of animals as food or target practice, but dragons are an exception.",
				"Normalmente, só penso nos animais como comida ou tiro ao alvo, mas os dragões são uma exceção."
			},
			new string[2]{
				"Anything is a weapon if you throw it hard enough.",
				"Qualquer coisa pode ser uma arma se você jogá-la com força o suficiente."
			},
			new string[2]{
				"That's your chucking arm? You need to work out more.",
				"Esse é o seu braço de arremesso? Você precisa se exercitar mais."
			},
			new string[2]{
				"Listen here. It's all in the wrist, the wrist! Oh, forget it.",
				"Escuta aqui. É tudo no pulso, no pulso! Ah, esquece."
			},
			new string[2]{
				"I don't think Mom and Dad are proud of the job I have right now.",
				"Eu não acho que meus pais estejam orgulhosos do trabalho que eu tenho agora."
			},
			new string[2]{
				"Eh you know how it goes; steal from the rich, give to the poor. Of course, for a price.",
				"É, você sabe como é; roubar dos ricos, e dar para os pobres. Claro, por um preço."
			},
			new string[2]{
				"Want to hear about this one time I was stuck in a room with a rabid dog and a dead guy?",
				"Quer ouvir sobre a vez em que eu estava presa em um quarto com um cachorro raivoso e um cara morto?"
			},
			new string[2]{
				"Argh snakes. For some reason it's always snakes.",
				"Droga, cobras. Por algum motivo, são sempre cobras."
			},
			new string[2]{
				"Maybe I'm bitter. It's been a long time, so whatever. Just do a good job out there.",
				"Talvez eu esteja amarga. Já faz muito tempo, então tanto faz. Só faça um bom trabalho lá fora."
			},
			new string[2]{
				"It's not stealing! I'm just borrowing it until I die!",
				"Não é roubo! Eu só estou pegando emprestado até morrer!"
			},
			new string[2]{
				"Wouldn't be the first time I used my friends' remains as weapons.",
				"Não seria a primeira vez que eu usei os restos mortais dos meus amigos como armas."
			},
			new string[2]{
				"With all of this new stuff cropping up, looks like we got some easy loot and new items to craft up, eh? Well, YOU craft them, I'll steal em.",
				"Com todas essas coisas novas aparecendo, parece que temos alguns espólios fáceis e novos itens para criar, hein? Bem, VOCÊ os cria, eu vou só roubá-los."
			},
			new string[2]{
				"Draedon thinks he can build awesome machines, but he doesn't know how much crap I've stolen from him and sold by dismantling his drones.",
				"Draedon acha que pode construir máquinas incríveis, mas ele não sabe quanta porcaria eu roubei dele e vendi desmontando seus drones."
			},
			new string[2]{
				"Gramma always said never to invade ancient temples or you'll be cursed and die. Let's say both of us attest that is untrue. We're still alive. Somewhat.",
				"Vovó sempre disse pra nunca invadir templos antigos ou você será amaldiçoado e morrerá. Digamos que nós dois atestemos que isso não é verdade. Ainda estamos vivos. Mais ou menos."
			},
			new string[2]{
				"I heard that there's some really neat and awesome rogue items you can get. Show em to me if you ever get the time.",
				"Ouvi dizer que existem alguns itens assassinos realmente legais e incríveis que você pode pegar. Mostre eles para mim qualquer dia, se tiver tempo."
			},
			new string[2]{
				"Providence HATES it when you take her stuff. I learned that the hard way.",
				"A Providência ODEIA quando você pega as coisas dela. Eu aprendi isso da pior maneira."
			},
			new string[2]{
				"You think I can get away with looting from ghosts? It ain't like they can pick things up.",
				"Você acha que eu posso sair roubando fantasmas? Não é como se eles pudessem pegar as coisas."
			},
			new string[2]{
				"Oh man, did you rip that off a shark!? Now that's a weapon!",
				"Cara, você arrancou isso de um tubarão!? Isso que é uma arma de verdade!"
			},
			new string[2]{
				"I tried looting Storm Weaver's armor once. Before I could get a chunk of the stuff... well let's just say the bigger, fatter cosmic worm arrived and it didn't end well.",
				"Eu tentei saquear a armadura do Explorador da Tempestade uma vez. Antes que eu pudesse pegar um pedaço do material... bem, vamos apenas dizer que o verme cósmico maior e mais gordo chegou e não terminou bem."
			},
			new string[2]{
				"I'd rather not be here. This place has bad vibes, y'know? It brings back some unpleasant memories.",
				"Prefiro não estar aqui. Este lugar tem uma energia ruim, sabe? Ele traz de volta algumas memórias desagradáveis."
			},
			new string[2]{
				"Don't tell " + givenNames[3] + ", but I took some of his stuff and replaced it with Angel Statues.",
				"Não diga a " + givenNames[3] + ", mas eu peguei algumas das coisas dele e substituí por estátuas de anjo."
			},
			new string[2]{
				"I learned never to steal " + givenNames[2] + "'s drinks. She doesn't appreciate me right now so I'll go back to hiding.",
				"Aprendi a nunca roubar as bebidas de " + givenNames[2] + ". Ela não gosta de mim agora, então vou voltar a me esconder."
			},
			new string[2]{
				"Don't tell " + givenNames[0] + " that I was responsible for " + givenNames[1] + "'s injuries.",
				"Não diga a " + givenNames[0] + " que eu fui responsável pelas feridas de " + givenNames[1] + "."
			},
			new string[2]{
				"God Slayer Dynamite? Boy do I like the sound of that!",
				"Dinâmite Assassina de Deuses? Cara, gostei do som disso!"
			}
		};
		bool found = false;
		int i = 0;
		if (chat.EndsWith(fabSpecialQuote))
		{
			chat = chat.Replace("Hey ", "Ei ").Replace(" and ", " e ").Replace(fabSpecialQuote, "Vocês são todos muito bons! ...espera, quem é você mesmo?");
			found = true;
		}
		while (i < translatedChat.Length && !found)
		{
			if (chat.Equals(translatedChat[i][0]) && !translatedChat[i][1].Equals(""))
			{
				chat = translatedChat[i][1];
				found = true;
			}
			i++;
		}

	}
}