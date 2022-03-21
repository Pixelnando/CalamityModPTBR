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
			if (Main.player[Main.myPlayer].Calamity().deathCount <= 100)
			{ 
				Main.npcChatText = "Você falhou " + Main.player[Main.myPlayer].Calamity().deathCount + " vezes.";
			}
			else if (Main.player[Main.myPlayer].Calamity().deathCount > 100 && Main.player[Main.myPlayer].Calamity().deathCount <= 250)
            {
				Main.npcChatText = "Você falhou " + Main.player[Main.myPlayer].Calamity().deathCount + " vezes. Considere diminuir a dificuldade. Se você achou essa afirmação irritante, ótimo.";
			}
			else if (Main.player[Main.myPlayer].Calamity().deathCount > 250 && Main.player[Main.myPlayer].Calamity().deathCount <= 500)
			{
				Main.npcChatText = "Você falhou " + Main.player[Main.myPlayer].Calamity().deathCount + " vezes. Eu admiro a sua tenacidade. Continue assim, os seus inimigos estão acumulando uma grande contagem de eliminações!";
			}
			else if (Main.player[Main.myPlayer].Calamity().deathCount > 500 && Main.player[Main.myPlayer].Calamity().deathCount <= 1000)
			{
				Main.npcChatText = "Você falhou " + Main.player[Main.myPlayer].Calamity().deathCount + " vezes. A sua inabilidade de evitar de morrer ao mais básico dos ataques é surpreendente para mim.";
			}
			else if (Main.player[Main.myPlayer].Calamity().deathCount > 1000 && Main.player[Main.myPlayer].Calamity().deathCount <= 2500)
			{
				Main.npcChatText = "Você falhou " + Main.player[Main.myPlayer].Calamity().deathCount + " vezes. Diz-se que o Terrariano comum tem uma vida útil de 2 minutos ou menos. ...Bem, não realmente, mas sinto que você faria parte dessa estatística.";
			}
			else if (Main.player[Main.myPlayer].Calamity().deathCount > 2500 && Main.player[Main.myPlayer].Calamity().deathCount <= 5000)
			{
				Main.npcChatText = "Você falhou " + Main.player[Main.myPlayer].Calamity().deathCount + " vezes. Abençoe seu coração. Eu poderia esquivar melhor que você, mesmo se estivesse bêbada.";
			}
			else if (Main.player[Main.myPlayer].Calamity().deathCount > 5000 && Main.player[Main.myPlayer].Calamity().deathCount <= 10000)
			{
				Main.npcChatText = "Você falhou " + Main.player[Main.myPlayer].Calamity().deathCount + " vezes. Não tenho certeza do que dizer desta vez. Que você é ruim e deveria se sentir mal? Isso todos já sabem.";
			}
			else if (Main.player[Main.myPlayer].Calamity().deathCount > 10000)
			{
				Main.npcChatText = "Você falhou " + Main.player[Main.myPlayer].Calamity().deathCount + " vezes. Parabéns! Você agora é, oficialmente, o maior perdedor da história de Terraria! Quem foi o número dois? Sei lá.";
			}
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
				new string[2]{ "Draedon's style of confrontation is very... alien and hands-off. You may be more likely to fight any one of his mechs before taking him down.",
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

		string fabSpecialQuote = "You're all pretty good!";
		string[][] translatedChat = new string[][] {

			//Amidias, the Sea King
			new string[2]{
				"How much more has the world fallen to ruin? Even the Tyrant’s empire...",
				"O quão mais o mundo sucumbiu às ruínas? Até o império do Tirano..."
			},
			new string[2]{
				"Thank you for your service, my child, but I am afraid I am without a home now.",
				"Obrigado pelo seu serviço, meu filho, mas infelizmente estou sem casa agora."
			},
			new string[2]{
				"My home may have been destroyed and my people lost... But I will assist you to honor their memory.",
				"Meu lar pode ter sido destruída, e meu povo perdido... Mas eu vou ajudá-lo a honrar a sua memória."
			},
			new string[2]{
				"How odd it is, that your people leave the care of those yet to be born to the females. Our males carry the eggs until they hatch.",
				"Que estranho é que seu povo deixe os cuidados daqueles que ainda não nasceram para as fêmeas. Nossos machos carregam os ovos até que eles choquem."
			},
			new string[2]{
				"How can I survive on land? Ah, that is a secret. No, actually... I can breathe air like you!",
				"Como eu consigo sobreviver fora d'água? Ah, isso é segredo. Não, na verdade... eu posso respirar ar como você!"
			},
			new string[2]{
				"Ah, if only you could have seen the beauty of a kingdom submerged in water. The way the light refracted and shone over our coral homes...",
				"Ah, se você pudesse ter visto a beleza de um reino submerso na água. A maneira que a luz refratava e brilhava sobre nossas casas de coral..."
			},
			new string[2]{
				"There lurk horrifying creatures beyond the light of our homes. You should take care.",
				"Criaturas horríveis se escondem além da luz de nossas casas. Você deve tomar cuidado."
			},
			new string[2]{
				"My eyes are not well suited to bright lights after so many years of darkness. The peace of the night is welcome.",
				"Meus olhos não são bem adequados para luzes brilhantes depois de tantos anos de escuridão. A paz da noite é bem-vinda."
			},
			new string[2]{
				"Oh, me? I don't sleep, it's part of my nature.",
				"Ah, eu? Eu não durmo, faz parte da minha natureza."
			},
			new string[2]{
				"Since ancient times people have said that deities cause celestial events. Which one then, is the cause for these?",
				"Desde os tempos antigos, pessoas dizem que divindades causam eventos celestiais. Qual delas então, é a causa destes?"
			},
			new string[2]{
				"I'm never keen on these nights. They're so violent.",
				"Nunca estou entusiasmado nestas noites. Elas são tão violentas."
			},
			new string[2]{
				"Your presence is now known to a great many things. It is unlikely that they will be as friendly towards you as I have been.",
				"Sua presença agora é conhecida por muitas coisas. É improvável que elas sejam tão amigáveis com você quanto eu fui."
			},
			new string[2]{
				"Hm... The veil has fallen, and the world begins to show its true colors. I hope you will trek a righteous path, though even I am not sure what that may be.",
				"Hm... O véu caiu, e o mundo começa a mostrar suas verdadeiras cores. Espero que você trilhe um caminho justo, embora nem mesmo eu tenha certeza do que ele seja."
			},
			new string[2]{
				"These days, the night sky feels... just a little less oppressive now.",
				"Hoje em dia, o céu noturno parece... um pouco menos opressor agora."
			},
			new string[2]{
				"Some of these beings I had thought previously to be only legends. To see them in all their glory... what a macabre privilege.",
				"Alguns desses seres eu pensava anteriormente serem apenas lendas. Vê-los em toda a sua glória... que previlégio macabro."
			},
			new string[2]{
				"To see that Tyrant’s serpent free of its shackles. It gave me chills.",
				"Para ver a serpente do Tirano livre de suas algemas. Isso me deu arrepios."
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
				givenNames[5] + " asked if my nose could be used as a vuvuzela. What is a vuvuzela?",
				givenNames[5] + " perguntou se meu nariz poderia ser usado como uma vuvuzela. O que é uma vuvuzela?"
			},
			new string[2]{
				"Rumor has it " + givenNames[2] + " drinks to forget her troubled past.",
				"Rumores dizem que " + givenNames[2] + " bebe para esquecer seu passado conturbado."
			},
			new string[2]{
				"I must admit, the Witch's presence is unsettling to me. But so many years have passed, and she too has suffered much.",
				"Devo admitir, a presença da Bruxa é inquietante para mim. Mas tantos anos se passaram e ela também sofreu muito."
			},

			//Bandit
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
				"Eh you know how it goes; steal from the rich, give to the poor, but I do take a cut of the profit.",
				"É, você sabe como é; roubar dos ricos, e dar para os pobres, mas eu recebo uma parte do lucro."
			},
			new string[2]{
				"Snakes! Why does it always have to be snakes!",
				"Cobras! Por que sempre tem que ser cobras!"
			},
			new string[2]{
				"It's super nice you know, to just have everything you want. Some people never got that luxury.",
				"É muito legal, você sabe, ter tudo o que você quer. Algumas pessoas nunca tiveram esse luxo."
			},
			new string[2]{
				"It's not stealing! I'm just borrowing it until I die!",
				"Não é roubo! Só estou pegando emprestado até que eu morra!"
			},
			new string[2]{
				"Hm, the stars are too bright tonight. Makes sneaking around a little more difficult.",
				"Hm, as estrelas estão muito brilhantes esta noite, vai ser mais difícil me esconder."
			},
			new string[2]{
				"Hm, the stars are too bright tonight. Makes sneaking around a little more difficult.",
				"Você acha que aquelas estrelas que caem ocasionalmente fariam boas armas arremessáveis??"
			},
			new string[2]{
				"You think those stars that fall occasionally would make good throwing weapons?",
				"Você acha que aquelas estrelas que caem ocasionalmente fariam boas armas arremessáveis?"
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
				"Usually I only think of animals as food or target practice, but dragons are an exception.",
				"Normalmente, só penso nos animais como comida ou tiro ao alvo, mas os dragões são uma exceção."
			},
			new string[2]{
				"I also take food for currency.",
				"Eu também aceito comida como pagamento."
			},
			new string[2]{
				"I'd rather not be here. This place has bad vibes, y'know? It brings back some unpleasant memories.",
				"Prefiro não estar aqui. Este lugar tem uma energia ruim, sabe? Ele traz de volta algumas memórias desagradáveis."
			},
			new string[2]{
				"Wouldn't be the first time I used my friends' remains as weapons.",
				"Não seria a primeira vez que eu usei os restos mortais dos meus amigos como armas."
			},
			new string[2]{
				"All sorts of new weapons to be found and looted. Get to that, and I'll share some of my collection too!",
				"Todos os tipos de arms novas para serem encontrados e saqueados. Faça isso e eu compartilharei um pouco da minha coleção também!"
			},
			new string[2]{
				"There's so much scrap around this land with valuable parts to them. Makes you wonder who could afford to leave em all around.",
				"Há muita sucata ao redor desta terra com peças valiosas nelas. Quem será que poderia deixá-los por aí?"
			},
			new string[2]{
				"Crypts, tombs, dungeons, those're all just treasure troves to me. The dead are dead, they've got nothing to do with it.",
				"Criptas, tumbas, calabouços, todos estes são tesouros para mim. Os mortos estão mortos, eles não têm nada contra."
			},
			new string[2]{
				"If you find anything cool, make sure to drop by and show it to me, I promise I’ll keep my hands off it.",
				"Se você encontrar algo legal, não se esqueça de passar por aqui e mostrar pra mim, eu prometo que vou manter minhas mãos fora."
			},
			new string[2]{
				"If you find anything cool, make sure to drop by and show it to me, I promise I’ll keep my hands off it.",
				"Se você encontrar algo legal, não se esqueça de passar por aqui e mostrar pra mim, eu prometo que vou manter minhas mãos fora."
			},
			new string[2]{
				"So many new things to steal, I can’t think of where to start!",
				"Tantas coisas novas para roubar, não sei por onde começar!"
			},
			new string[2]{
				"If I end up angering some deities or whatever, would you mind taking the blame for me?",
				"Se eu acabar irritando algumas divindades ou algo do tipo, você se importaria de assumir a culpa por mim?"
			},
			new string[2]{
				"Oh man, did you rip that off a shark!? Now that's a weapon!",
				"Cara, você arrancou isso de um tubarão!? Isso que é uma arma de verdade!"
			},
			new string[2]{
				"Don't tell " + givenNames[3] + ", but I took some of his stuff and replaced it with Angel Statues.",
				"Não diga a " + givenNames[3] + ", mas eu peguei algumas das coisas dele e substituí por estátuas de anjo."
			},
			new string[2]{
				"Hey, hey, has Calamitas seriously moved in here with us? Why???",
				"Ei, ei! É sério que a Calamitas se mudou aqui com a gente? Por que??"
			},
			new string[2]{
				"Don't tell " + givenNames[0] + " that I was responsible for " + givenNames[1] + "'s injuries.",
				"Não diga a " + givenNames[0] + " que eu fui responsável pelas feridas de " + givenNames[1] + "."
			},
			new string[2]{
				"I learned never to steal " + givenNames[2] + "'s drinks. She doesn't appreciate me right now so I'll go back to hiding.",
				"Aprendi a nunca roubar as bebidas de " + givenNames[2] + ". Ela não gosta de mim agora, então vou voltar a me esconder."
			},

			//Drunk Princess
			new string[2]{
				"I could smell my vodka from MILES away!",
				"Eu podia sentir o cheiro da minha vodka a QUILÔMETROS de distância!"
			},
			new string[2]{
				"Have any spare rooms available? Preferably candle-lit with a hefty supply of booze?",
				"Tem algum quarto disponível? De preferência à luz de velas com uma boa quantidade de bebida?"
			},
			new string[2]{
				"I HATE WALMART! ...Anyway, what do you want this time?",
				"EU ODEIO O WALMART! ...Enfim, o que você quer desta vez?"
			},
			new string[2]{
				"Deals so good I'll [$$!$] myself! ...Sorry, just had a minor stroke!",
				"Promoções tão boas que eu até me [$$!$]! ...Desculpe, acabei de ter um pequeno derrame!"
			},
			new string[2]{
				"Did anyone ever tell you that large assets cause back pain? Well, they were right.",
				"Alguém já lhe disse que coisas grandes causam dor nas costas? Bem, eles estavam certos."
			},
			new string[2]{
				"Drink something that turns you into a magical flying unicorn so you can be just like me.",
				"Beba algo que te transforme em um unicórnio voador mágico para que você possa ser igual a mim."
			},
			new string[2]{
				"I'm literally balls drunk off my sass right now, what do you want?",
				"Estou literalmente tão bêbada para ser atrevida agora, o que você quer?"
			},
			new string[2]{
				"I'm either laughing because I'm drunk or because I've lost my mind, probably both.",
				"Ou estou rindo porque estou bêbada ou porque perdi a cabeça, provavelmente os dois."
			},
			new string[2]{
				"When I'm drunk I'm way happier... at least until the talking worms start to appear.",
				"Quando estou bêbada, eu fico muito mais feliz... pelo menos até que os vermes falantes comecem a aparecer."
			},
			new string[2]{
				"I should reprogram the whole mod, while drunk, then send it back to the testers.",
				"Eu devia reprogramar o mod inteiro, enquanto estou bêbada, e então enviar ele de volta para os testadores."
			},
			new string[2]{
				"A perfect night to light some candles, drink some wine and relax.",
				"Uma noite perfeita para acender algumas velas, beber um pouco de vinho e relaxar."
			},
			new string[2]{
				"Here's a challenge... take a shot for every time you've had to look at the wiki. Oh wait, you'd die.",
				"Aqui está um desafio... beba uma dose toda vez que você teve que consultar o wiki. Ah, espera, você morreria."
			},
			new string[2]{
				"Yes, everyone knows the mechworm is buggy. Well, not anymore, but still.",
				"Sim, todo mundo sabe que o vermecânico é bugado. Bem, ele não é mais, mas ainda sim."
			},
			new string[2]{
				"You lost or something? I don't mind company, but I'd rather be left alone at night.",
				"Você está perdido ou algo assim? Não me importo de ter compania, mas prefiro ficar sozinha à noite."
			},
			new string[2]{
				"You lost or something? I don't mind company, but I'd rather be left alone at night.",
				"Você está perdido ou algo assim? Não me importo de ter compania, mas prefiro ficar sozinha à noite."
			},
			new string[2]{
				"Are you sure you're 21? ...Alright, fine, but don't tell anyone I sold you these.",
				"Você tem certeza que tem mais de 18 anos? ...Tudo bem, mas não fala para ninguém que eu vendi isso pra você."
			},
			new string[2]{
				"I'm gonna make some Bloody Marys to relax, celery included. Want one?",
				"Vou preparar algumas Marias Sangrentas, incluindo aipo. Quer uma?"
			},
			new string[2]{
				"If you're too lazy to craft potions normally, try Blood Orbs. Blood is fuel, dumbass.",
				"Se você for muito preguiçoso para criar poções normalmente, experimente os Orbes de Sangue. Sangue é combustível, idiota."
			},
			new string[2]{
				"I'm trying to not be bitchy tonight, but it's hard when everyone else won't shut up.",
				"Estou tentando não ser chata esta noite, mas é difícil quando ninguém quer calar a boca."
			},
			new string[2]{
				"Sorry, I have no moral compass at the moment.",
				"Desculpe, eu não tenho um guia moral do momento."
			},
			new string[2]{
				"You'll always find me at parties where booze is involved... well, you'll always find BOOZE where I'M involved!",
				"Você sempre me encontrará em festas onde a bebida está envolvida... bem, você sempre encontrará BEBIDAS onde EU estiver envolvida."
			},
			new string[2]{
				"I'm melting! Put a stop to this inclement weather this instant before it ruins my hair!",
				"Eu estou derretendo! Ponha um fim a este tempo inclemente antes que ele estrague meu cabelo!"
			},
			new string[2]{
				"You should probably deal with those ayy lmaos before anything else, but whatever.",
				"Você provavelmente deveria lidar com esses ets bilu antes de qualquer coisa, mas tanto faz."
			},
			new string[2]{
				"Why are you talking to me right now? Shouldn't you be bumbling around and dying for my amusement?",
				"Por que você está falando comigo agora? Você não deveria estar se atrapalhando e morrendo para a minha diversão?"
			},
			new string[2]{
				"God I can't wait to smash some ice again! ...For drinks, of course.",
				"Meu Deus, eu mal posso esperar para bater no gelo de novo! ...Para bebidas, é claro."
			},
			new string[2]{
				"How could you murder such a beautiful creature!? ...The blue sexy one, not the obese cucumber.",
				"Como você pôde matar uma criatura tão linda!? ...A gostosa de azul, não o pepino obeso."
			},
			new string[2]{
				"I saw a ghost down by the old train tracks back at my homeland once, flailing wildly at the lily pads... frightening times those were.",
				"Uma vez, na minha terra natal, vi um fantasma perto dos trilhos do velho trem, se debatendo descontroladamente nas vitórias régias... que tempos assustadores."
			},
			new string[2]{
				"I hear it's amazing when the famous Devourer of Gods out in flap-jaw space, with the tuning fork, does a raw blink on Hara-kiri rock. I need scissors! 61!",
				"Ouvi dizer que é incrível quando o famoso Devorador de Deuses no espaço da mandíbula aberta, com o diapasão, pisca bruscamente na rocha Hara-kiri. Eu preciso de uma tesoura! 61!"
			},
			new string[2]{
				"Tell " + givenNames[8] + " to stop calling me. He's not wanted.",
				"Diga a " + givenNames[8] + " para parar de me ligar. Não estou interessada."
			},
			new string[2]{
				"I've had to tell baldie where my eyes are so many times that I've lost count.",
				"Tive que dizer para o carequinha onde os meus olhos estão tantas vezes que perdi a conta."
			},
			new string[2]{
				"I've had to tell baldie where my eyes are so many times that I've lost count.",
				"Tive que dizer para o carequinha onde os meus olhos estão tantas vezes que perdi a conta."
			},
			new string[2]{
				"My booze will always be better than " + givenNames[8] + "'s, and nobody can convince me otherwise.",
				"Minha bebida sempre será melhor do que a de " + givenNames[8] + ", e ninguém pode me convencer que não."
			},
			new string[2]{
				"You can't stop me from trying to move in with " + givenNames[6] + ".",
				"Você não pode me impedir de tentar morar com " + givenNames[6] + "."
			},
			new string[2]{
				"I love it when " + givenNames[6] + "'s hands get sticky from all that... wax.",
				"Eu adoro quando as mãos de " + givenNames[6] + " ficam pegajosas com toda aquela... cera."
			},
			new string[2]{
				givenNames[6] + " works wonders for my hair... among other things.",
				givenNames[6] + " faz maravilhas para o meu cabelo... entre outras coisas."
			},
			new string[2]{
				"Ever since " + givenNames[6] + " moved in I haven't been drinking as much... a strange but not unwelcome feeling.",
				"Desde que " + givenNames[6] + " se mudou, eu não tenho bebido tanto... uma sensação estranha, mas não indesejada."
			},
			new string[2]{
				"I should watch some movies with " + givenNames[6] + " tonight. You could come too, but only if you bring snacks for us.",
				"Eu devo assistir alguns filmes com " + givenNames[6] + " hoje à noite. Você poderia vir também, mas apenas se você trouxer lanches para nós."
			},
			new string[2]{
				"The abuse Calamitas went through is something I can hardly comprehend. I'd offer her a drink, but I don't think she'd enjoy it.",
				"O abuso que Calamitas sofreu é algo que eu mal consigo compreender. Eu ofereceria a ela uma bebida, mas eu não acho que ela gostaria."
			},
			new string[2]{
				"I never realized how well-endowed " + givenNames[7] + " was. It had to be the largest icicle I'd ever seen.",
				"Eu nunca percebi o quão bem dotado " + givenNames[7] + " era. Tinha que ser o maior gelão que eu já vi."
			},
			new string[2]{
				givenNames[6] + " helped me learn to accept my past. It's been rough, but I think I'm on the right track now.",
				givenNames[6] + " me ajudou a aprender a aceitar o meu passado. Tem sido difícil, mas eu acho que estou no caminho certo agora."
			},
			new string[2]{
				"Might go out for a jog later with " + givenNames[6] + ". Nice day for it.",
				"Talvez eu saia para correr com " + givenNames[6] + " mais tarde. É um bom dia para isso.",
			},
			new string[2]{
				"I drink to forget certain... things. What things, you might ask? Well, the point is to forget them, isn't it?",
				"Eu bebo para esquecer certas... coisas. Que coisas, você pergunta? Bem, a questão é esquecê-los, não é?",
			},
			new string[2]{
				"What a great day! Might just drink so much that I get poisoned again.",
				"Que dia ótimo! Talvez eu beba tanto que fique envenenada novamente."
			},
			new string[2]{
				"Ever wondered why the Moon Lord needed so many tentacles? Uh... on second thought, I won't answer that.",
				"Já se perguntou por que o Senhor da Lua precisava de tantos tentáculos? Hm... pensando bem, não irei responder."
			},
			new string[2]{
				"Oh yeah, now you're drinking the good stuff! Do you like it? I created the recipe by mixing fairy dust, crystals and other magical crap.",
				"Aí sim, agora você está bebendo uma das boas! Você gostou? Eu criei a receita misturando pó de fada, cristais e outras porcarias mágicas."
			},
			new string[2]{
				"The hell is that? Looks like something I'd carry around if I was 5 years old.",
				"O que diabos é isso? Parece algo que eu carregaria se eu tivesse 5 anos."
			},
			new string[2]{
				"Nice scales... is it hot in here or is it just me?",
				"Belas escamas... por acaso, está ficando quente aqui ou sou só eu?"
			},
			new string[2]{
				"So... you found my special bottle. Hope you enjoy it, I know I will.",
				"Então... você encontrou a minha garrafa especial. Espero que você se divirta, eu sei que eu vou."
			},
			new string[2]{
				"Be sure to dismount me once in a while, I get tired. And besides, I can't rip you off-I mean offer you excellent deals you won't find anywhere else if you're riding me 24/7.",
				"Certifique-se de desmontar-se de mim de vez em quando, eu fico cansada. E, além disso, não posso enganá-lo- quero dizer, oferecer excelentes promoções que você não econtrará em nenhum outro lugar se você estiver montando em mim 24 horas por dia."
			},
			new string[2]{
				"Before you ask, no, I do NOT have a heart on my butt while in human form. Don't question my transformation preferences!",
				"Antes que pergunte, não, eu NÃO tenho um coração na minha bunda enquanto estou minha forma humana. Não questione as minhas preferências de transformação!"
			},

			//Archmage
			new string[2]{
				"I deeply appreciate you rescuing me from being trapped within my frozen castle... It's been many, many years...",
				"Agradeço profundamente por você ter me resgatado de estar preso em meu castelo de gelo... Já se passaram anos, muitos anos..."
			},
			new string[2]{
				"I have not seen such a sky in decades. Who are you, to so brazenly march against that Tyrant?",
				"Faz décadas que não vejo tal céu. Quem é você, para marchar tão descaradamente contra aquele Tirano?"
			},
			new string[2]{
				"The tundra’s unnatural state is not all my doing. Decades ago, I came across it and amplified the climate with my magic.",
				"O estado não natural da tundra não é obra minha. Décadas atrás, eu me deparei com ela e ampliei o clima com minha magia."
			},
			new string[2]{
				"If you have a request, make it quick. I am in the process of weaving a spell, which requires great focus.",
				"Se você tem um pedido, faça-o rápido. Estou no processo de composição de um feitiço, o que requer grande concentração."
			},
			new string[2]{
				"You have the makings of a gifted mage. Tell me, what do you think of ice magic?",
				"Você tem as qualidades de um mago talentoso. Me diga, o que você acha da magia de gelo?"
			},
			new string[2]{
				"Flowers and the like don’t hold a candle to the beauty of intricately formed ice.",
				"Flores e coisas parecidas não se comparam à beleza do gelo intrincadamente formado."
			},
			new string[2]{
				"O sol bate forte sobre as minhas criações aqui. Se você me permitir, posso conjurar uma nevasca de vez em quando...",
				"The sun beats down harshly upon my creations here. If you would allow me to conjure a blizzard every now and then..."
			},
			new string[2]{
				"I must admit, I’m not quite used to this weather. It's far too warm for my tastes...",
				"Devo admitir, não estou muito acostumado com este clima. Está quente demais para o meu gosto..."
			},
			new string[2]{
				"Nightfall is a good time for practicing magic. We mages often rely on celestial bodies and their fragments to enhance our mana.",
				"O anoitecer é uma boa hora para praticar a magia. Nós, magos, dependemos muito de corpos celestes e seus fragmentos para aprimorar a nossa mana."
			},
			new string[2]{
				"Necromancy was never a field I found interesting. Why utilize the rotting corpses of people, when you could form far more elegant servants of ice?",
				"Necromancia nunca foi um campo que eu achei interessante. Por que utilizar cadáveres podres de pessoas, quando você pode formar lacaios de gelo muito mais elegantes?"
			},
			new string[2]{
				"Sometimes... I feel like all I'm good for during these events is making ice cubes and slushies.",
				"Às vezes... eu sinto que, durante esses eventos, eu sirvo apenas para fazer cubos de gelo e raspadinhas."
			},
			new string[2]{
				"If your blood were to thoroughly freeze, it would be quite fatal.",
				"Se o seu sangue congelasse completamente, seria fatal."
			},
			new string[2]{
				"The undead which roam tonight are still monsters of blood and guts, but they seem... fresher.",
				"Os mortos-vivos que vagam hoje à noite ainda são monstros de sangue e vísceras, mas eles parecem... mais frescos."
			},
			new string[2]{
				"The undead which roam tonight are still monsters of blood and guts, but they seem... fresher.",
				"Os mortos-vivos que vagam hoje à noite ainda são monstros de sangue e vísceras, mas eles parecem... mais frescos."
			},
			new string[2]{
				"It is shocking, to see you have come so far. I wish you the best of luck on your future endeavours.",
				"É chocante ver que você chegou tão longe. Eu desejo boa sorte para você em seus empreendimentos futuros."
			},
			new string[2]{
				"You, having bested so many beings, even deities, I wonder if I have anything left to offer you.",
				"Você, tendo superado tantos seres, até mesmo divindades, me pergunto se ainda tenho algo a te oferecer."
			},
			
			//Calamitas
			new string[2]{
				"I'm considering moving back to that old cave of mine.",
				"Estou pensando em voltar para minha velha caverna."
			},
			new string[2]{
				"I certainly can't return to the Tyrant's old dwellings now, have you got any places to stay?",
				"Certamente não posso voltar para as antigas habitações do Tirano agora, você tem algum lugar onde eu possa ficar?"
			},
			new string[2]{
				"I can't pay rent, but if you've got any dead relative you want me to try and... what? You don't?",
				"Eu não posso pagar aluguel, mas se você tiver algum parente morto que quer que eu tente... o quê? Você não quer?"
			},
			new string[2]{
				"One of these days, I was thinking of starting a garden with the flowers from the old capitol of hell. I love the smell of brimstone in the morning.",
				"Um dia desses, estava pensando em começar um jardim com as flores da antiga capital do inferno. Adoro o cheiro de enxofre pela manhã."
			},
			new string[2]{
				"I think I've settled comfortably, thank you very much.",
				"Acho que me acomodei confortavelmente, muito obrigada."
			},
			new string[2]{
				"Many seasons have gone by since I first met with the Tyrant, and only now did I break free. I wish I'd been stronger...",
				"Muitas estações se passaram desde que me encontrei com o Tirano, e só agora eu me libertei. Eu queria ter sido mais forte..."
			},
			new string[2]{
				"If you've got any curses you want dispelled... well I'm not your person.",
				"Se você tem alguma maldição que deseja dissipar... bem, eu não sou quem você procura."
			},
			new string[2]{
				"These undead are horrific, I can't stand to look at them. How could anyone be satisfied with such amateur work?",
				"Estes mortos-vivos são horríveis, eu não suporto olhar para eles. Como que alguém ficaria satisfeito com esse trabalho amador?"
			},
			new string[2]{
				"I don't think it's a stretch to say that astrology is utter nonsense... but it was a hobby of mine once.",
				"Não acho exagero dizer que astrologia é um absurdo total... mas já foi um hobby meu."
			},
			new string[2]{
				"Such an unnatural shade of red. Nothing like my brimstone flames.",
				"Um tom de vermelho tão pouco natural. Nada como minhas chamas de enxofre."
			},
			new string[2]{
				"I can't work with nights like these. The stars seem to have shrunk away in fear.",
				"Não posso trabalhar com noites como esta. As estrelas parecem ter encolhido de medo."
			},
			new string[2]{
				"If another person asks me if I can dance or not, I will light their hat on fire.",
				"Se outra pessoa me perguntar se eu sei dançar ou não, eu vou colocar fogo no chapéu dela."
			},
			new string[2]{
				"I cannot understand the Sea King. He does not seem to want me dead. That amount of compassion I just can't understand.",
				"Eu não consigo entender o Rei dos Mares. Ele parece não me querer morta. Essa quantidade de compaixão eu simplesmente não consigo entender."
			},
			new string[2]{
				"That frosty old man... even if you ignore our brands of magic and our old alliances, I doubt I'd ever get along with him.",
				"Aquele velhote gelado... mesmo que você ignore nossas marcas de magia e nossas antigas alianças, duvido que algum dia eu me daria bem com ele."
			},
			new string[2]{
				"I wonder if Cirrus ever feels cold given how revealing her dress is. Perhaps she should cover up a bit more.",
				"Eu me pergunto se Cirrus sente frio, dado o quão revelador o seu vestido é. Talvez ela devesse se cobrir um pouco mais."
			},
			new string[2]{
				"Mrrp is cringe.",
				"Mrrp é cringe."
			},

			//Vanilla NPCs
			//Angler
			new string[2]{
				"Someone tell " + givenNames[10] + " to quit trying to throw me out of town, it's not going to work.",
				"Alguém diga a " + givenNames[10] + " para parar de tentar me expulsar da cidade, não vai funcionar."
			},

			//Arms Dealer
			new string[2]{
				"That's the biggest moth I've ever seen for sure. You'd need one big gun to take one of those down.",
				"Essa é a maior mariposa que eu já vi, com certeza. Você precisará de uma grande arma para derrubar uma delas."
			},
			new string[2]{
				"Is it me or are your weapons getting bigger and bigger?",
				"É impressão minha ou suas armas estão ficando cada vez maiores?"
			},

			//Clothier
			new string[2]{
				"Houston, we've had a problem.",
				"Houston, temos um problema."
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
				"Não sei o que era aquela coisa, mas estou feliz que ela já foi."
			},

			//Cyborg
			new string[2]{
				"All these moments will be lost in time. Like tears...in the rain.",
				"Todos esses momentos se perderão com o tempo, como lágrimas... na chuva."
			},
			new string[2]{
				"Always shoot for the moon! It has clearly worked before.",
				"Sempre mire para a lua! Claramente já funcionou antes."
			},
			new string[2]{
				"Draedon? He's...a little 'high octane' if you know what I mean.",
				"Draedon? Ele... é meio 'sobrecarregado' se você entende o que quero dizer."
			},
			new string[2]{
				"Those oversized bugs terrorizing the jungle... Surely you of all people could shut them down!",
				"Esses insetos enormes aterrorizando a selva... Certamente você, de todas as pessoas, poderia encerrá-los!"
			},

			//Demolitionist
			new string[2]{
				"God Slayer Dynamite? Boy do I like the sound of that!",
				"Dinamite Assassina de Deuses? Cara, gostei do som disso!"
			},

			//Dryad
			new string[2]{
				"There's a dark solar energy emanating from the moths that appear during this time. Ah, the moths as you progress further get more powerful...hmm...what power was Yharon holding back?",
				"Há uma energia solar escura emanando das mariposas que aparecem durante esse período. Ah, as mariposas ficam mais poderosas à medida que você avança...hmm...que poder Yharon estava segurando?"
			},
			new string[2]{
				"That starborne illness sits upon this land like a blister. Do even more vile forces of corruption exist in worlds beyond?",
				"Essa doença transmitida pelas estrelas assenta nesta terra como uma bolha. Existem forças ainda mais vis da corrupção em outros mundos?"
			},
			new string[2]{
				"\u0093I'm not here for any reason! Just picking up mushrooms for uh, later use.",
				"\u0093Não estou aqui por nenhum motivo em específico! Só estou recolhendo cogumelos para, uh, usar mais tarde."
			},
			new string[2]{
				givenNames[2] + " put me up to this.",
				"Foi" + givenNames[2] + " quem me disse para fazer isso."
			},
			new string[2]{
				"My ancestor was lost here long ago. I must pay my respects to her.",
				"Minha ancestral foi perdida aqui há muito tempo. Devo prestar meus respeitos a ela."
			},

			//Dye Trader
			new string[2]{
				"Have you seen those gemstone creatures in the caverns? Their colors are simply breathtaking!",
				"Você já viu as criaturas de pedras preciosas nas cavernas? Suas cores são de tirar o fôlego!"
			},
			new string[2]{
				"Do you think " + givenNames[7] + " knows how to 'let it go?'",
				"Você acha que " + givenNames[7] + " diria 'livre estou?'"
			},

			//Goblin Tinkerer
			new string[2]{
				"Hey, is it just me or have my pockets gotten lighter ever since " + givenNames[11] + " arrived?",
				"Ei, é impressão minha ou os meus bolsos ficaram mais leves desde que " + givenNames[11] + " chegou?"
			},
			new string[2]{
				"You know...we haven't had an invasion in a while...",
				"Sabe...não tivemos uma invasão há um tempo..."
			},

			//Guide
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

			//Mechanic
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

			//Merchant
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

			//Nurse
			new string[2]{
				"Now is not the time!",
				"Agora não é hora!"
			},

			//Painter
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

			//Party Girl
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

			//Pirate
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

			//Skeleton Merchant
			new string[2]{
				"What'dya buyin'?",
				"Que que cê vai comprar?"
			},

			//Steampunker
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

			//Stylist
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

			//Tavernkeep
			new string[2]{
				"Care for a little Moonshine?",
				"Quer um pouquinho de álcool contrabandeado?"
			},
			new string[2]{
				"Sheesh, " + givenNames[2] + " is a little cruel, isn't she? I never claimed to be an expert on anything but ale!",
				"Caraamba, " + givenNames[2] + " é um pouco cruel, não acha? Nunca disse ser um especialista em nada além de cerveja!"
			},

			//Tax Collector
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

			//Travelling Merchant
			new string[2]{
				"Tell " + givenNames[2] + " I'll take up her offer and meet with her at the back of " + givenNames[3] + "'s house.",
				"Diga a " + givenNames[2] + " que eu aceitarei a sua oferta e me encontrarei com ela nos fundos da casa de " + givenNames[3] + "."
			},

			//Truffle
			new string[2]{
				"I don't feel very safe; I think there's pigs following me around and it frightens me.",
				"Não me sinto muito seguro; acho que tem porcos me seguindo por todo o lugar, e isso me deixa aterrorizado."
			},
			new string[2]{
				"Sometimes, " + givenNames[2] + " just looks at me funny and I'm not sure how I feel about that.",
				"Ás vezes, " + givenNames[2] + " olha para mim de um jeito engraçado e eu não tenho certeza de como eu me sinto sobre isso."
			},

			//Witch Doctor
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

			//Wizard
			new string[2]{
				"Space just got way too close for comfort.",
				"O espaço está perigosamente perto."
			},
			new string[2]{
				"I'd let " + givenNames[7] + " coldheart MY icicle.",
				"Eu deixaria " + givenNames[7] + " congelar o MEU gelo."
			},

		};
		bool found = false;
		int i = 0;
		if (chat.EndsWith(fabSpecialQuote))
		{
			chat = chat.Replace("Hey ", "Ei ").Replace(" and ", " e ").Replace(fabSpecialQuote, "Vocês são todos muito bons!");
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