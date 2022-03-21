using System;
using Terraria;
using CalamityMod;
using CalamityMod.Items;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Armor;
using CalamityMod.Items.Accessories.Vanity;
using CalamityMod.Items.Accessories.Wings;
using CalamityMod.Items.DifficultyItems;
using CalamityMod.Items.LoreItems;
using CalamityMod.Items.Placeables.Ores;
using CalamityMod.Items.Potions;
using CalamityMod.Items.SummonItems;
using CalamityMod.Items.Tools;
using CalamityMod.Items.Weapons.Melee;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Items.Weapons.Rogue;
using CalamityMod.Items.Weapons.Summon;
using CalamityMod.Items.DraedonMisc;
using CalamityMod.Items.Mounts;
using CalamityMod.Items.Weapons.DraedonsArsenal;
using CalamityMod.World;
using System.Collections.Generic;
using System.Linq;
using Terraria.ModLoader;

public class CalamityGlobalItemPTBR : GlobalItem
{

    public CalamityGlobalItemPTBR()
	{
	}

	public override void UpdateArmorSet(Player player, string set)
	{
		string hotkey = CalamityMod.CalamityMod.TarraHotKey.TooltipHotkeyString();

		if (set == "AerospecMagic")
		{
			player.setBonus = "5% de aumento na velocidade dos movimentos e chance de ataque mágico crítico\nSofrer mais de 25 de danos em um acerto fará com que penas teleguiadas caiam do céu\nPermite que você caia mais rapidamente e desativa o dano de queda";
		}
		else if (set == "AerospecRogue")
		{
			player.setBonus = "5% de aumento na velocidade dos movimentos e chance de ataque ladino crítico\nSofrer mais de 25 de danos em um acerto fará com que penas teleguiadas caiam do céu\nPermite que você caia mais rapidamente e desativa o dano de queda\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 100\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "AerospecMelee")
		{
			player.setBonus = "5% de aumento na velocidade dos movimentos e chance de ataque físico crítico\nSofrer mais de 25 de danos em um acerto fará com que penas teleguiadas caiam do céu\nPermite que você caia mais rapidamente e desativa o dano de queda\nA chance dos inimigos mirarem em você é maior";
		}
		else if (set == "AerospecSummon")
		{
			player.setBonus = "11% de aumento de dano por invocação e +1 lacaio máximo\nInvoca uma valquíria para te proteger\nSofrer mais de 25 de danos em um acerto fará com que penas teleguiadas caiam do céu\nPermite que você caia mais rapidamente e desativa o dano de queda";
		}
		else if (set == "AerospecRanged")
		{
			player.setBonus = "5% de aumento na velocidade dos movimentos e chance de ataque à distância crítico\nSofrer mais de 25 de danos em um acerto fará com que penas teleguiadas caiam do céu\nPermite que você caia mais rapidamente e desativa o dano de queda";
		}
		else if (set == "Astral")
		{
			player.setBonus = "25% de aumento na velocidade dos movimentos\n28% de aumento nos danos e 21% de aumento na chance de ataque crítico\nSempre que você acertar um inimigo criticamente, choverão estrelas caídas, sagradas e astrais\nEste efeito tem um tempo de recarga de 1 segundo antes que possa ser ativado novamente";
		}
		else if (set == "AtaxiaRanged")
		{
			player.setBonus = "5% de aumento nos danos por ataque à distância\nEfeito da poção infernal quando abaixo de 50% de vida\nVocê tem uma chance de 50% de atirar uma chama do caos teleguiada enquanto usando armas de ataque à distância\nVocê tem uma chance de 20% de emitir uma explosão ardente quando atingido";
		}
		else if (set == "AtaxiaMelee")
		{
			player.setBonus = "5% de aumento nos danos por ataque físico\nEfeito da poção infernal quando abaixo de 50% de vida\nAtaques e projéteis físicos fazem com que chamas do caos explodam ao atingir o inimigo\nVocê tem uma chance de 20% de emitir uma explosão ardente quando atingido";
		}
		else if (set == "AtaxiaSummon")
		{
			player.setBonus = "40% de aumento nos danos por invocação\nEfeito da poção infernal quando abaixo de 50% de vida\nInvoca um respiradouro hidrotérmico para protegê-lo\nVocê tem uma chance de 20% de emitir uma explosão ardente quando atingido";
		}
		else if (set == "AtaxiaRogue")
		{
			player.setBonus = "5% de aumento nos danos por ataque ladino\nEfeito da poção infernal quando abaixo de 50% de vida\nArmas ladinas têm 10% de chance de liberar uma rajada de chamas do caos ao redor do jogador que perseguem os inimigos quando usadas\nVocê tem uma chance de 20% de emitir uma explosão ardente quando atingido\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 110\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "AtaxiaMagic")
		{
			player.setBonus = "5% de aumento nos danos por ataque mágico\nEfeito da poção infernal quando abaixo de 50% de vida\nAtaques mágicos invocam orbes flamejantes que machucam e te curam no acerto\nVocê tem uma chance de 20% de emitir uma explosão ardente quando atingido";
		}
		else if (set == "AuricMelee")
		{
			player.setBonus = "Efeitos das armaduras de Estragão, Chamas Sangrentas, Assassino de Deuses e Silva\nTodos os projéteis invocam orbes áuricos de cura ao atingir o inimigo\nVelocidade de corrida máxima e aceleração aumentadas em 10%\nSeu dano por ataque físico é multiplicado baseado em quão alto sua vida está; com vida cheia este efeito está no máximo";
		}
		else if (set == "AuricRanged")
		{
			player.setBonus = "Efeitos das armaduras de Estragão, Chamas Sangrentas, Assassino de Deuses e Silva\nTodos os projéteis invocam orbes áuricos de cura ao atingir o inimigo\nVelocidade de corrida máxima e aceleração aumentadas em 10%";
		}
		else if (set == "AuricRogue")
		{
			player.setBonus = "Efeitos das armaduras de Estragão, Chamas Sangrentas, Assassino de Deuses e Silva\nTodos os projéteis invocam orbes áuricos de cura ao atingir o inimigo\nVelocidade de corrida máxima e aceleração aumentadas em 10%\nAcertos crícitos de armas ladinas causarão 1.25 vezes mais dano enquanto você está acima de 50% de vida\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 130\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "AuricSummon")
		{
			player.setBonus = "Efeitos das armaduras de Estragão, Chamas Sangrentas, Assassino de Deuses e Silva\nTodos os projéteis invocam orbes áuricos de cura ao atingir o inimigo\nVelocidade de corrida máxima e aceleração aumentadas em 10%\n+1 lacaio máximo e 120% de aumento nos danos por invocação";
		}
		else if (set == "AuricMagic")
		{
			player.setBonus = "Efeitos das armaduras de Estragão, Chamas Sangrentas, Assassino de Deuses e Silva\nTodos os projéteis invocam orbes áuricos de cura ao atingir o inimigo\nVelocidade de corrida máxima e aceleração aumentadas em 10%";
		}
		else if (set == "BloodflareRogue")
		{
			player.setBonus = "Aumenta muito a regeneração de vida\nInimigos com menos de 50% de vida têm uma chance de deixarem cair corações quando atingidos\nInimigos com mais de 50% de vida têm uma chance de deixarem cair estrelas de mana quando atingidos\nInimigos mortos durante uma Lua de Sangue têm uma chance muito maior de deixarem cair Orbes de Sangue na morte\nEstar acima de 80% de vida aumenta a sua defesa em 30 e chance de ataque ladino crítico em 5%\nEstar abaixo de 80% de vida aumenta o seu dano por ataque ladino em 10%\nAcertos críticos ladinos têm uma chance de 50% de te curar\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 120\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "BloodflareSummon")
		{
			player.setBonus = "55% de aumento no dano por lacaios\nAumenta muito a regeneração de vida\nInimigos com menos de 50% de vida têm uma chance de deixarem cair corações quando atingidos\nInimigos com mais de 50% de vida têm uma chance de deixarem cair estrelas de mana quando atingidos\nInimigos mortos durante uma Lua de Sangue têm uma chance muito maior de deixarem cair Orbes de Sangue na morte\nInvoca minas de Polterghast para circular em torno de você\nCom 90% de vida e acima, você recebe 10% de aumento nos danos por lacaios\nCom 50% de vida ou menos, você recebe 20 defesa e 3 regeneração de vida";
		}
		else if (set == "BloodflareRanged")
		{
			player.setBonus = "Aumenta muito a regeneração de vida\nInimigos com menos de 50% de vida têm uma chance de deixarem cair corações quando atingidos\nInimigos com mais de 50% de vida têm uma chance de deixarem cair estrelas de mana quando atingidos\nInimigos mortos durante uma Lua de Sangue têm uma chance muito maior de deixarem cair Orbes de Sangue na morte\nPressione " + hotkey + " para liberar as almas perdidas de polterghast para destruir seus inimigos\nEste efeito tem um tempo de recarga de 30 segundos\nArmas de ataque à distância têm uma chance de atirar orbes de explosão de sangue";
		}
		else if (set == "BloodflareMagic")
		{
			player.setBonus = "Aumenta muito a regeneração de vida\nInimigos com menos de 50% de vida têm uma chance de deixarem cair corações quando atingidos\nInimigos com mais de 50% de vida têm uma chance de deixarem cair estrelas de mana quando atingidos\nInimigos mortos durante uma Lua de Sangue têm uma chance muito maior de deixarem cair Orbes de Sangue na morte\nArmas de magia às vezes dispararão raios fantasmagóricos\nAcertos críticos mágicos causam explosões de chamas a cada 2 segundos";
		}
		else if (set == "BloodflareMelee")
		{
			player.setBonus = "Aumenta muito a regeneração de vida\nA chance dos inimigos mirarem em você é maior\nInimigos com menos de 50% de vida têm uma chance de deixarem cair corações quando atingidos\nInimigos com mais de 50% de vida têm uma chance de deixarem cair estrelas de mana quando atingidos\nInimigos mortos durante uma Lua de Sangue têm uma chance muito maior de deixarem cair Orbes de Sangue na morte\nAtaques físicos verdadeiros te curarão\nDepois de atingir um inimigo 15 vezes com ataques físicos verdadeiros, você entrará em um frenesi de sangue por cinco segundos\nDurante a frenesi, você receberá 25% de aumento nos danos por ataque físico e chance de ataque físico crítico e o dano recebido por contato será cortado pela metade\nEste efeito tem um tempo de recarga de 30 segundos";
		}
		else if (set == "Brimflame")
		{
			player.setBonus = "Fornece 15% de aumento nos danos e chance de acerto crítico mágico\nPressione " + hotkey + " para ativar um efeito de frenesi de chamas de enxofre\nDurante esse efeito, seu dano será aumentado significantemente\nNo entanto, isso vem ao custo de uma rápida perda de vida e nenhuma regeneração de mana\nO efeito pode ser desativado, no entanto, uma frenesi de chamas de enxofre tem um tempo de recarga de 30 segundos";
		}
		else if (set == "DaedalusMagic")
		{
			player.setBonus = "+5% de danos por magia\nVocê tem 10% de chance de absorver ataques físicos quando atingido\nSe você absorver um ataque, você é curado por 1/2 do dano do ataque";
		}
		else if (set == "DaedalusSummon")
		{
			player.setBonus = "+20% de danos por lacaio\nUm cristal de dédalo flutua acima de você para te proteger";
		}
		else if (set == "DaedalusMelee")
		{
			player.setBonus = "+5% de danos por ataque físico\nVocê tem 33% de chance de refletir projéteis de volta para os inimigos\nSe você refletir um projétil, você também é curado por 1/5 do dano do projétil";
		}
		else if (set == "DaedalusRanged")
		{
			player.setBonus = "+5% de danos por ataque à distância\nSer atingido faz com que você emita uma explosão de fragmentos de cristal";
		}
		else if (set == "DaedalusRogue")
		{
			player.setBonus = "+5% de danos por ataque ladino\nProjéteis ladinos disparam fragmentos de cristal conforme viajam\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 105\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "Demonshade")
		{
			player.setBonus = "100% de aumento nos danos por lacaios\nTodos os ataques infligem o efeito negativo chamas do demônio\nFeixes das sombras e foices demoníacas cairão dos céus quando você for atingido\nUm diabo vermelho amigável segue você\nPressione " + hotkey + " para enfurecer inimigos próximos com um feitiço de magia negra por 10 segundos\nIsto faz com que eles causem 25% a mais de dano, mas também sofram 125% a mais de dano";
		}
		else if (set == "DesertProwler")
		{
			player.setBonus = "Ataques à distância causam 1 dano plano a mais\nAtaques à distância críticos podem raramente gerar uma tempestade de areia";
		}
		else if (set == "FathomSwarmer")
		{
			player.setBonus = "10% de aumento nos danos por lacaios e +1 lacaio máximo\nOferece a habilidade de escalar paredes\n30% de aumento nos danos por lacaio quando submerso em líquidos\nFornece uma quantidade razoável de luz e reduz razoavelmente a perda de fôlego no abismo";
		}
		else if (set == "Fearmonger")
		{
			player.setBonus = "20% de aumento nos danos por lacaios e +2 lacaios máximos\nA redução de dano por lacaios enquanto segurando armas é reduzida\nImune a todas as formas de gelo e chamas\nTodos os ataques por lacaios fornecem regeneração de vida gigantesca\n15% de aumento na redução de danos durante a Lua de Abóbora e Lua Congelada\nEsta redução de danos extra ignora o limite comum";
		}
		else if (set == "ForbiddenCalam")
		{
			int stormMana = (int)(60f * player.manaCost);
			player.setBonus = "Pressione " + hotkey + " para invocar uma tempestade antiga na posição do cursor\nA tempestade antiga custa " + stormMana + " de mana e recebe benefícios de bônus de invocação e bônus ladinos\nAtaques furtivos ladinos invocam devoradores teleguiados ao atingir o inimigo\nAtaques ladinos e por invocação serão aumentados com base na estatística com o maior aumento\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 40\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		if (set == "GemTech")
		{
			player.setBonus = "Seis fragmentos de joias orbitam você ociosamente; uma para cada classe e uma joia base\nUma joia é perdida quando você sofre mais de 100 de dano em um único acerto. O tipo de joia perdida é o mesmo da classe anterior que você usou\nSe a mesma joia já foi perdida, a joia base é perdida\nQuando uma joia é perdida, ela se desprende e segue o inimigo ou chefe mais próximo, se houver algum, causando uma base de 40000 de dano\nAs joias têm um atraso de 30 segundos antes de aparecerem novamente\nA joia vermelha concede 130 de furtividade máxima, melhorias nas estatísticas ladinas, e torna a furtividade apenas consumível por armas ladinas\nA joia amarela fornece melhorias nas estatísticas físicas e faz com que ataques físicos liberem fragmentos no acerto com um tempo de recarga. Este tempo de recarga é mais curto para ataques físicos verdadeiros\nA joia verde fornece melhorias nas estatísticas de ataque à distância e faz com que dardos voem rapidamente em direção aos alvos quando são danificadas por um projétil de ataque à distância\nA joia azul concede 4 lacaios máximos adicionais, aumenta o dano por lacaios e reduz a penalidade para itens de invocador enquanto estiver segurando uma arma que não seja de invocador\nA joia violeta concede 100 de mana máxima adicional, melhorias nas estatísticas mágicas, e faz com que a mana regenere rapidamente ao segurar uma arma que não é de magia\nA joia base cor-de-rosa fornece 75 de defesa adicional, redução de danos adicional, melhor velocidade dos movimentos e dos pulos e 2 de regeneração de vida\nQuando todas as gemas existirem simultaneamente, acertar um alvo com qualquer arma fornece +2 de regeneração de vida por 8 segundos\nIsto é aumentado para +3 de regeneração de vida se uma arma de outra classe for usada durante esse período de 8 segundos por 2.5 segundos";
		}
		else if (set == "GodSlayerMelee")
		{
			player.setBonus = "Permite que você corra uma distância imensa em 8 direções\nPressione " + hotkey + " enquanto mantém pressionadas as teclas de movimento na direção que você quer correr\nInimigos que você atravessar sofrerão muito dano\nDurante a corrida, você fica imune à maioria dos efeitos negativos\nA corrida tem um tempo de recarga de 35 segundos\nA chance dos inimigos mirarem em você é maior\nSofrer mais de 80 de danos em um acerto fará com que você libere uma barragem de dardos assassinos de deuses que causam muito dano\nInimigos sofrem muito dano quando eles te atingem\nUm ataque que causaria 80 de danos ou menos terá o seu dano reduzido para 1";
		}
		else if (set == "GodSlayerRanged")
		{
			player.setBonus = "Permite que você corra uma distância imensa em 8 direções\nPressione " + hotkey + " enquanto mantém pressionadas as teclas de movimento na direção que você quer correr\nInimigos que você atravessar sofrerão muito dano\nDurante a corrida, você fica imune à maioria dos efeitos negativos\nA corrida tem um tempo de recarga de 35 segundos\nVocê dispara uma bala de estilhaços assassina de deuses enquanto dispara armas de ataque à distância a cada 2.5 segundos";
		}
		else if (set == "GodSlayerRogue")
		{
			player.setBonus = "Permite que você corra uma distância imensa em 8 direções\nPressione " + hotkey + " enquanto mantém pressionadas as teclas de movimento na direção que você quer correr\nInimigos que você atravessar sofrerão muito dano\nDurante a corrida, você fica imune à maioria dos efeitos negativos\nA corrida tem um tempo de recarga de 35 segundos\nQuando com vida máxima, todas as suas estatísticas ladinas são aumentadas em 10%\nSe você sofrer mais que 80 de danos em um acerto você receberá quadros de imunidade extra";
		}
		else if (set == "Mollusk")
		{
			player.setBonus = "Dois moluscos te auxiliarão no combate\n10% de aumento nos danos\nSua velocidade de movimento horizontal é reduzida";
		}
		else if (set == "OmegaBlue")
		{
			player.setBonus = "Aumenta a perfuração de blindagem em 15\n10% de aumento no dano e na chance de acerto crítico\nTentáculos de curto alcance sugam a vida do inimigo, curando você\nPressione " + hotkey + " para ativar a loucura abissal por 5 segundos\nA loucura abissal aumenta o dano, chance de acerto crítico, e agressividade/alcance dos tentáculos\nEste efeito tem um tempo de recarga de 25 segundos";
		}
		else if (set == "PlaguebringerSummon")
		{
			player.setBonus = "Fornece uma corrida da praga para colidir com inimigos e aflingí-los com a praga\nInvoca uma pequena portadora da peste para proteger você e empoderar lacaios próximos\n+3 lacaios máximos";
		}
		else if (set == "PlaguebringerRanged")
		{
			player.setBonus = "25% de redução no consumo de munição e 5% de aumento no tempo de vôo\nInimigos recebem 10% a mais de dano de projéteis de ataque à distância quando aflingidos pela Praga\nSer atingido faz com que cinzas da praga caiam dos céus\nPressione a tecla " + hotkey + " para se cegar por 5 segundos, mas aumentar o seu dano por ataque à distância considerávelmente\nEste efeito tem um tempo de recarga de 25 segundos.";
		}
		else if (set == "Prismatic")
		{
			player.setBonus = "+40 mana máxima e 15% de redução no consumo de mana\nAumenta a taxa de regeneração de mana\nPressione " + hotkey + " para liberar uma barragem de lasers da morte no cursor durante os próximos 5 segundos\nIsto tem um tempo de recarga de 30 segundos";
		}
		else if (set == "ReaverRogue")
		{
			player.setBonus = "Faz com que tesouros próximos brilhem\nAlcance de coleta de itens e posicionamento de blocos aumentado\nMinerar peças restaura o fôlego enquanto embaixo d'água\nInvoca um orbe ladrão para iluminar á área ao seu redor\nReduz a agressão dos inimigos, até mesmo no abismo\nFornece uma pequena quantidade de luz no abismo";
		}
		else if (set == "ReaverMelee")
		{
			player.setBonus = "+10 defesa e +3 regeneração de vida\nA chance dos inimigos mirarem em você é maior\nReduz a regeneração de vida perdida por efeitos negativos de dano com o tempo em 20%\nTodos os ataques têm uma pequena chance de roubar vida e acelerar a taxa de regeneração de vida\n20% de redução na velocidade dos movimentos e no tempo de voô\nO dano inimigo é refletido e invoca um espinho\nA Fúria do Ladrão tem uma chance de 255 de ativar quando você sofrer danos";
		}
		else if (set == "ReaverRanged")
		{
			player.setBonus = "Oferece imunidade ao dano de queda e permite o pulo automático\n10% de aumento no tempo de voô e velocidade horizontal da asa\nGanchos disparam e retraem 10% mais rápido2\nReduz o tempo de recarga de corridas";
		}
		else if (set == "ShroomiteCalam")
		{
			player.setBonus = "Furtividade à distância enquanto parado";
		}
		else if (set == "SilvaSummon")
		{
			player.setBonus = "65% de aumento nos danos por lacaios\nTodos os projéteis invocam esferas de folha que te curam ao atingir o inimigo\nVelocidade de corrida e aceleração máxima aumentada em 5%\nSe você for reduzido a 1 de vida, você não morrerá de nenhum dano adicional por 8 segundos\nEste efeito só pode ser ativado uma vez por vida\nInvoca um prisma de folha antigo para explodir seus inimigos com energia vital";
		}
		else if (set == "SilvaMagic")
		{
			player.setBonus = "Todos os projéteis invocam esferas de folha que te curam ao atingir o inimigo\nVelocidade de corrida e aceleração máxima aumentada em 5%\nSe você for reduzido a 1 de vida, você não morrerá de nenhum dano adicional por 8 segundos\nEste efeito só pode ser ativado uma vez por vida\nProjéteis mágicos que não podem perfurar inimigos irão ocasionalmente disparar rajadas potentes de energia da natureza";
		}
		else if (set == "SnowRuffian")
		{
			player.setBonus = "5% de aumento nos danos por ataque ladino\nVocê pode planar para negar danos de queda\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 50\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "StatigelMagic")
		{
			player.setBonus = "Quando você receber mais de 100 de dano em um acerto, você se torna imune a danos por um longo período de tempo\nFornece um pulo extra e aumenta a altura dos pulos\n12% de aumento na velocidade dos pulos";
		}
		else if (set == "StatigelRanged")
		{
			player.setBonus = "Quando você receber mais de 100 de dano em um acerto, você se torna imune a danos por um longo período de tempo\nFornece um pulo extra e aumenta a altura dos pulos\n12% de aumento na velocidade dos pulos";
		}
		else if (set == "StatigelMelee")
		{
			player.setBonus = "Quando você receber mais de 100 de dano em um acerto, você se torna imune a danos por um longo período de tempo\nFornece um pulo extra e aumenta a altura dos pulos\n12% de aumento na velocidade dos pulos";
		}
		else if (set == "StatigelSummon")
		{
			player.setBonus = "18% de aumento nos danos por lacaios e +1 lacaio máximo\nInvoca um mini deus geleia para lutar para você, o seu tipo depende do mal no seu mundo\nQuando você receber mais de 100 de dano em um acerto, você se torna imune a danos por um longo período de tempo\nFornece um pulo extra e aumenta a altura dos pulos\n12% de aumento na velocidade dos pulos";
		}
		else if (set == "StatigelRogue")
		{
			player.setBonus = "Quando você receber mais de 100 de dano em um acerto, você se torna imune a danos por um longo período de tempo\nFornece um pulo extra e aumenta a altura dos pulos\n12% de aumento na velocidade dos pulos\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 100\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "Sulfur")
		{
			player.setBonus = "Atacar e ser atacado por inimigos inflige veneno\nFornece um pulo adicional que invoca uma bolha sulfurosa\nFornece mobilidade aumentada embaixo d'água e reduz a severidade das águas sulfúricas\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 95\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "TarragonMelee")
		{
			player.setBonus = "Maior alcance de coleta de corações\nOs inimigos têm uma chance de deixar cair mais corações ao morrer\nVocê tem uma chance de 25% de regenerar vida ao receber danos\nPressione " + hotkey + " para se esconder em um manto de energia vital que reduz fortemente o dano por contato por 10 segundos\nEste efeito tem um tempo de recarga de 30 segundos";
		}
		else if (set == "TarragonRogue")
		{
			player.setBonus = "Reduz a taxa de surgimento de inimigos\nMaior alcance de coleta de corações\nOs inimigos têm uma chance de deixar cair mais corações ao morrer\nDepois de cada 25 acertos críticos ladinos, você ganhará 3 segundos de imunidade a danos\nEste efeito só pode ocorrer uma vez a cada 30 segundos\nEnquanto estiver sob os efeitos de um efeito negativo, você ganha 10% de aumento nos danos por ataque ladino\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 115\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "TarragonSummon")
		{
			player.setBonus = "50% de aumento nos danos por lacaios e +3 lacaios máximos\nReduz a taxa de surgimento de inimigos\nMaior alcance de coleta de corações\nOs inimigos têm uma chance de deixar cair mais corações ao morrer\nInvoca uma aura vital ao seu redor que causa danos aos inimigos próximos";
		}
		else if (set == "TarragonMagic")
		{
			player.setBonus = "Reduz a taxa de surgimento de inimigos\nMaior alcance de coleta de corações\nOs inimigos têm uma chance de deixar cair mais corações ao morrer\nEm cada quinto acerto crítico, você disparará uma tempestade de folhas\nProjéteis mágicos curam você ao atingir o inimigo\nA quantidade curada é baseada no dano do projétil";
		}
		else if (set == "TarragonRanged")
		{
			player.setBonus = "Reduz a taxa de surgimento de inimigos\nMaior alcance de coleta de corações\nOs inimigos têm uma chance de deixar cair mais corações ao morrer\nProjéteis de ataque à distância se dividem em energia vital teleguiada e folhas na morte";
		}
		else if (set == "TitanHeart")
		{
			player.setBonus = "15% de aumento nos danos por ataque ladino e no recuo\nAtaques furtivos causam o dobro do recuo e causam uma explosão astral\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 100\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "Umbraphile")
		{
			player.setBonus = "Armas ladinas têm uma chance de criar explosões no acerto\nAtaques furtivos sempre criam uma explosão\nPoções da Penumbra sempre acumulam furtividade com eficácia máxima\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 110\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "VictideRogue")
		{
			player.setBonus = "+3 regeneração de vida e 10% de aumento nos danos por ataque ladino enquanto submerso em líquidos\nAo usar qualquer arma, você tem uma chance de 10% de arremessar um projétil de concha que retorna para você\nEsta concha causa dano verdadeiro e não se beneficia de nenhuma classe de dano\nFornece maior mobilidade embaixo d´água e levemente reduz a perda de fôlego no abismo\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 90\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "VictideMelee")
		{
			player.setBonus = "+3 regeneração de vida e 10% de aumento nos danos por ataque físico enquanto submerso em líquidos\nAo usar qualquer arma, você tem uma chance de 10% de arremessar um projétil de concha que retorna para você\nEsta concha causa dano verdadeiro e não se beneficia de nenhuma classe de dano\nFornece maior mobilidade embaixo d´água e levemente reduz a perda de fôlego no abismo";
		}
		else if (set == "VictideSummon")
		{
			player.setBonus = "+3 regeneração de vida e 10% de aumento nos danos por lacaios enquanto submerso em líquidos\nInvoca um ouriço do mar para te proteger\nAo usar qualquer arma, você tem uma chance de 10% de arremessar um projétil de concha que retorna para você\nEsta concha causa dano verdadeiro e não se beneficia de nenhuma classe de dano\nFornece maior mobilidade embaixo d´água e levemente reduz a perda de fôlego no abismo\n+1 lacaio máximo";
		}
		else if (set == "VictideMagic")
		{
			player.setBonus = "+3 regeneração de vida e 10% de aumento nos danos por magia enquanto submerso em líquidos\nAo usar qualquer arma, você tem uma chance de 10% de arremessar um projétil de concha que retorna para você\nEsta concha causa dano verdadeiro e não se beneficia de nenhuma classe de dano\nFornece maior mobilidade embaixo d´água e levemente reduz a perda de fôlego no abismo";
		}
		else if (set == "VictideRanged")
		{
			player.setBonus = "+3 regeneração de vida e 10% de aumento nos danos por ataque à distância enquanto submerso em líquidos\nAo usar qualquer arma, você tem uma chance de 10% de arremessar um projétil de concha que retorna para você\nEsta concha causa dano verdadeiro e não se beneficia de nenhuma classe de dano\nFornece maior mobilidade embaixo d´água e levemente reduz a perda de fôlego no abismo";
		}
		else if (set == "WulfrumRanged")
		{
			player.setBonus = "+3 defesa\n+5 defesa quando abaixo de 50% de vida";
		}
		else if (set == "WulfrumMelee")
		{
			player.setBonus = "+3 defesa\n+5 defesa quando abaixo de 50% de vida";
		}
		else if (set == "WulfrumSummon")
		{
			player.setBonus = "+3 defesa e +1 lacaio máximo\n+5 defesa quando abaixo de 50% de vida";
		}
		else if (set == "WulfrumMagic")
		{
			player.setBonus = "+3 defesa\n+5 defesa quando abaixo de 50% de vida";
		}
		else if (set == "WulfrumRogue")
		{
			player.setBonus = "+3 defesa\n+5 defesa quando abaixo de 50% de vida\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 50\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "Xeroc")
		{
			player.setBonus = "	9% de aumento nos danos por ataque ladino e na velocidade dos projéteis ladinos\nProjéteis ladinos têm um efeito especial ao atingir o inimigo\nVocê será imbuído de ira e fúria cósmica quando você receber danos\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 115\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		
		else if (set == "Gladiator")
		{
			player.setBonus = "+3 defesa\n5% de aumento nos danos por ataque ladino e 10% de aumento na velocidade dos projéteis ladinos\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 70\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos";
		}
		else if (set == "Obsidian")
		{
			player.setBonus = "+2 defesa\n5% de aumento nos danos por ataque ladino e na chance de ataque ladino crítico\nOferece imunidade a blocos de fogo e imunidade temporária à lava\nFurtividade ladina se acumula enquanto não atacando e lentamente enquanto se movendo, até um máximo de 80\nDepois de acumular furtividade máxima, você será capaz de executar um Ataque Furtivo\nA furtividade ladina só reduz quando você ataca, ela não reduz enquanto se move\nQuanto maior for a sua furtividade ladina, maior o seu dano ladino, crítico, e velocidade dos movimentos" + (CalamityWorld.death ? "\nFornece proteção contra o calor no Modo Morte" : "");
		}
		else if (set == "Eskimo")
		{
			player.setBonus = "Todas as armas com tema de gelo recebem um aumento de 10% nos danos\nInimigos frios causarão dano por contato reduzido no jogador\nFornece imunidade contra aos efeitos negativos Queimadura de gelo e Estado glacial" + (CalamityWorld.death ? "\nFornece proteção contra o frio no Modo Morte" : "");
		}
	}

	public override string IsArmorSet(Item head, Item body, Item legs)
	{
		if (head.type == ModContent.ItemType<AerospecHat>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
		{
			return "AerospecMagic";
		}
		if (head.type == ModContent.ItemType<AerospecHeadgear>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
		{
			return "AerospecRogue";
		}
		if (head.type == ModContent.ItemType<AerospecHelm>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
		{
			return "AerospecMelee";
		}
		if (head.type == ModContent.ItemType<AerospecHelmet>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
		{
			return "AerospecSummon";
		}
		if (head.type == ModContent.ItemType<AerospecHood>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
		{
			return "AerospecRanged";
		}
		if (head.type == ModContent.ItemType<AstralHelm>() && body.type == ModContent.ItemType<AstralBreastplate>() && legs.type == ModContent.ItemType<AstralLeggings>())
		{
			return "Astral";
		}
		if (head.type == ModContent.ItemType<AtaxiaHeadgear>() && body.type == ModContent.ItemType<AtaxiaArmor>() && legs.type == ModContent.ItemType<AtaxiaSubligar>())
		{
			return "AtaxiaRanged";
		}
		if (head.type == ModContent.ItemType<AtaxiaHelm>() && body.type == ModContent.ItemType<AtaxiaArmor>() && legs.type == ModContent.ItemType<AtaxiaSubligar>())
		{
			return "AtaxiaMelee";
		}
		if (head.type == ModContent.ItemType<AtaxiaHelmet>() && body.type == ModContent.ItemType<AtaxiaArmor>() && legs.type == ModContent.ItemType<AtaxiaSubligar>())
		{
			return "AtaxiaSummon";
		}
		if (head.type == ModContent.ItemType<AtaxiaHood>() && body.type == ModContent.ItemType<AtaxiaArmor>() && legs.type == ModContent.ItemType<AtaxiaSubligar>())
		{
			return "AtaxiaRogue";
		}
		if (head.type == ModContent.ItemType<AtaxiaMask>() && body.type == ModContent.ItemType<AtaxiaArmor>() && legs.type == ModContent.ItemType<AtaxiaSubligar>())
		{
			return "AtaxiaMagic";
		}
		if (head.type == ModContent.ItemType<AuricTeslaHelm>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
		{
			return "AuricMelee";
		}
		if (head.type == ModContent.ItemType<AuricTeslaHoodedFacemask>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
		{
			return "AuricRanged";
		}
		if (head.type == ModContent.ItemType<AuricTeslaPlumedHelm>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
		{
			return "AuricRogue";
		}
		if (head.type == ModContent.ItemType<AuricTeslaSpaceHelmet>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
		{
			return "AuricSummon";
		}
		if (head.type == ModContent.ItemType<AuricTeslaWireHemmedVisage>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
		{
			return "AuricMagic";
		}
		if (head.type == ModContent.ItemType<BloodflareHelm>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareRogue";
		}
		if (head.type == ModContent.ItemType<BloodflareHelmet>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareSummon";
		}
		if (head.type == ModContent.ItemType<BloodflareHornedHelm>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareRanged";
		}
		if (head.type == ModContent.ItemType<BloodflareHornedMask>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareMagic";
		}
		if (head.type == ModContent.ItemType<BloodflareMask>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
		{
			return "BloodflareMelee";
		}
		if (head.type == ModContent.ItemType<BrimflameScowl>() && body.type == ModContent.ItemType<BrimflameRobes>() && legs.type == ModContent.ItemType<BrimflameBoots>())
		{
			return "Brimflame";
		}
		if (head.type == ModContent.ItemType<DaedalusHat>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusMagic";
		}
		if (head.type == ModContent.ItemType<DaedalusHeadgear>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusSummon";
		}
		if (head.type == ModContent.ItemType<DaedalusHelm>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusMelee";
		}
		if (head.type == ModContent.ItemType<DaedalusHelmet>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusRanged";
		}
		if (head.type == ModContent.ItemType<DaedalusVisor>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
		{
			return "DaedalusRogue";
		}
		if (head.type == ModContent.ItemType<DemonshadeHelm>() && body.type == ModContent.ItemType<DemonshadeBreastplate>() && legs.type == ModContent.ItemType<DemonshadeGreaves>())
		{
			return "Demonshade";
		}
		if (head.type == ModContent.ItemType<DesertProwlerHat>() && body.type == ModContent.ItemType<DesertProwlerShirt>() && legs.type == ModContent.ItemType<DesertProwlerPants>())
		{
			return "DesertProwler";
		}
		if (head.type == ModContent.ItemType<FathomSwarmerVisage>() && body.type == ModContent.ItemType<FathomSwarmerBreastplate>() && legs.type == ModContent.ItemType<FathomSwarmerBoots>())
		{
			return "FathomSwarmer";
		}
		if (head.type == ModContent.ItemType<FearmongerGreathelm>() && body.type == ModContent.ItemType<FearmongerPlateMail>() && legs.type == ModContent.ItemType<FearmongerGreaves>())
		{
			return "Fearmonger";
		}
		if (head.type == ModContent.ItemType<ForbiddenCirclet>() && body.type == 3777 && legs.type == 3778)
		{
			return "ForbiddenCalam";
		}
		if (head.type == ModContent.ItemType<GemTechHeadgear>() && body.type == ModContent.ItemType<GemTechBodyArmor>() && legs.type == ModContent.ItemType<GemTechSchynbaulds>())
		{
			return "GemTech";
		}
		if (head.type == ModContent.ItemType<GodSlayerHelm>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
		{
			return "GodSlayerMelee";
		}
		if (head.type == ModContent.ItemType<GodSlayerHelmet>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
		{
			return "GodSlayerRanged";
		}
		if (head.type == ModContent.ItemType<GodSlayerMask>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
		{
			return "GodSlayerRogue";
		}
		if (head.type == ModContent.ItemType<MolluskShellmet>() && body.type == ModContent.ItemType<MolluskShellplate>() && legs.type == ModContent.ItemType<MolluskShelleggings>())
		{
			return "Mollusk";
		}
		if (head.type == ModContent.ItemType<OmegaBlueHelmet>() && body.type == ModContent.ItemType<OmegaBlueChestplate>() && legs.type == ModContent.ItemType<OmegaBlueLeggings>())
		{
			return "OmegaBlue";
		}
		if (head.type == ModContent.ItemType<PlaguebringerVisor>() && body.type == ModContent.ItemType<PlaguebringerCarapace>() && legs.type == ModContent.ItemType<PlaguebringerPistons>())
		{
			return "PlaguebringerSummon";
		}
		if (head.type == ModContent.ItemType<PlagueReaperMask>() && body.type == ModContent.ItemType<PlaguebringerCarapace>() && legs.type == ModContent.ItemType<PlaguebringerPistons>())
		{
			return "PlaguebringerRanged";
		}
		if (head.type == ModContent.ItemType<PrismaticHelmet>() && body.type == ModContent.ItemType<PrismaticRegalia>() && legs.type == ModContent.ItemType<PrismaticGreaves>())
		{
			return "Prismatic";
		}
		if (head.type == ModContent.ItemType<ReaverHelm>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
		{
			return "ReaverMelee";
		}
		if (head.type == ModContent.ItemType<ReaverVisage>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
		{
			return "ReaverRanged";
		}
		if (head.type == ModContent.ItemType<ShroomiteVisage>() && body.type == 1549 && legs.type == 1550)
		{
			return "ShroomiteCalam";
		}
		if (head.type == ModContent.ItemType<SilvaHelmet>() && body.type == ModContent.ItemType<SilvaArmor>() && legs.type == ModContent.ItemType<SilvaLeggings>())
		{
			return "SilvaSummon";
		}
		if (head.type == ModContent.ItemType<SilvaMaskedCap>() && body.type == ModContent.ItemType<SilvaArmor>() && legs.type == ModContent.ItemType<SilvaLeggings>())
		{
			return "SilvaMagic";
		}
		if (head.type == ModContent.ItemType<SnowRuffianMask>() && body.type == ModContent.ItemType<SnowRuffianChestplate>() && legs.type == ModContent.ItemType<SnowRuffianGreaves>())
		{
			return "SnowRuffian";
		}
		if (head.type == ModContent.ItemType<StatigelCap>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelMagic";
		}
		if (head.type == ModContent.ItemType<StatigelHeadgear>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelRanged";
		}
		if (head.type == ModContent.ItemType<StatigelHelm>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelMelee";
		}
		if (head.type == ModContent.ItemType<StatigelHood>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelSummon";
		}
		if (head.type == ModContent.ItemType<StatigelMask>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
		{
			return "StatigelRogue";
		}
		if (head.type == ModContent.ItemType<SulfurHelmet>() && body.type == ModContent.ItemType<SulfurBreastplate>() && legs.type == ModContent.ItemType<SulfurLeggings>())
		{
			return "Sulfur";
		}
		if (head.type == ModContent.ItemType<TarragonHelm>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonMelee";
		}
		if (head.type == ModContent.ItemType<TarragonHelmet>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonRogue";
		}
		if (head.type == ModContent.ItemType<TarragonHornedHelm>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonSummon";
		}
		if (head.type == ModContent.ItemType<TarragonMask>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonMagic";
		}
		if (head.type == ModContent.ItemType<TarragonVisage>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
		{
			return "TarragonRanged";
		}
		if (head.type == ModContent.ItemType<TitanHeartMask>() && body.type == ModContent.ItemType<TitanHeartMantle>() && legs.type == ModContent.ItemType<TitanHeartBoots>())
		{
			return "TitanHeart";
		}
		if (head.type == ModContent.ItemType<UmbraphileHood>() && body.type == ModContent.ItemType<UmbraphileRegalia>() && legs.type == ModContent.ItemType<UmbraphileBoots>())
		{
			return "Umbraphile";
		}
		if (head.type == ModContent.ItemType<VictideHeadgear>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideLeggings>())
		{
			return "VictideRogue";
		}
		if (head.type == ModContent.ItemType<VictideHelm>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideLeggings>())
		{
			return "VictideMelee";
		}
		if (head.type == ModContent.ItemType<VictideHelmet>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideLeggings>())
		{
			return "VictideSummon";
		}
		if (head.type == ModContent.ItemType<VictideMask>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideLeggings>())
		{
			return "VictideMagic";
		}
		if (head.type == ModContent.ItemType<VictideVisage>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideLeggings>())
		{
			return "VictideRanged";
		}
		if (head.type == ModContent.ItemType<WulfrumHeadgear>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumRanged";
		}
		if (head.type == ModContent.ItemType<WulfrumHelm>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumMelee";
		}
		if (head.type == ModContent.ItemType<WulfrumHelmet>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumSummon";
		}
		if (head.type == ModContent.ItemType<WulfrumHood>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumMagic";
		}
		if (head.type == ModContent.ItemType<WulfrumMask>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumRogue";
		}
		if (head.type == ModContent.ItemType<XerocMask>() && body.type == ModContent.ItemType<XerocPlateMail>() && legs.type == ModContent.ItemType<XerocCuisses>())
		{
			return "Xeroc";
		}
		//Original Code from Calamity - May be unneccesary
		if (head.type == 89 && body.type == 80 && legs.type == 76)
		{
			return "Copper";
		}
		if (head.type == 687 && body.type == 688 && legs.type == 689)
		{
			return "Tin";
		}
		if ((head.type == 90 || head.type == 954) && body.type == 81 && legs.type == 77)
		{
			return "Iron";
		}
		if (head.type == 690 && body.type == 691 && legs.type == 692)
		{
			return "Lead";
		}
		if (head.type == 91 && body.type == 82 && legs.type == 78)
		{
			return "Silver";
		}
		if (head.type == 693 && body.type == 694 && legs.type == 695)
		{
			return "Tungsten";
		}
		if ((head.type == 92 || head.type == 955) && body.type == 83 && legs.type == 79)
		{
			return "Gold";
		}
		if (head.type == 696 && body.type == 697 && legs.type == 698)
		{
			return "Platinum";
		}
		if (head.type == 3187 && body.type == 3188 && legs.type == 3189)
		{
			return "Gladiator";
		}
		if (head.type == 3266 && body.type == 3267 && legs.type == 3268)
		{
			return "Obsidian";
		}
		if (head.type == 231 && body.type == 232 && legs.type == 233)
		{
			return "Molten";
		}
		if ((head.type == 803 || head.type == 978) && (body.type == 804 || body.type == 979) && (legs.type == 805 || legs.type == 980))
		{
			return "Eskimo";
		}
		if (head.type == 123 && body.type == 124 && legs.type == 125)
		{
			return "Meteor";
		}
		if (head.type == 736 && body.type == 737 && legs.type == 738)
		{
			return "Pearlwood";
		}
		return "";
	}
	public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
	{
		foreach (TooltipLine line in tooltips)
		{
			//Death Mode Tooltips

			if (CalamityWorld.death)
			{
				if (item.type == ModContent.ItemType<XerocMask>())
				{
					line.text = line.text.Replace("Temporary immunity to lava", "Imunidade temporária à lava");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<TarragonHelm>())
				{
					line.text = line.text.Replace("10% increased melee damage and critical strike chance", "10% de aumento nos danos por ataque físico e chance de ataque físico crítico");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<TarragonHornedHelm>())
				{
					line.text = line.text.Replace("5% increased damage reduction and +3 max minions", "5% de aumento na redução dos danos e +3 lacaios máximos");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<TarragonMask>())
				{
					line.text = line.text.Replace("5% increased damage reduction, +100 max mana, and 15% reduced mana usage", "5% de aumento na redução dos danos, +100 mana máxima e 15% de redução no consumo de mana");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<TarragonVisage>() || item.type == ModContent.ItemType<TarragonHelmet>())
				{
					line.text = line.text.Replace("5% increased damage reduction", "5% de aumento na redução dos danos");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<BloodflareHelm>())
				{
					line.text = line.text.Replace("10% increased rogue damage and critical strike chance, 15% increased movement speed", "10% de aumento nos danos por ataque ladino e chance de acerto crítico ladino, 15% de aumento na velocidade dos movimentos");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<BloodflareHelmet>())
				{
					line.text = line.text.Replace("+3 max minions", "+3 lacaios máximos");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<BloodflareHornedHelm>())
				{
					line.text = line.text.Replace("10% increased ranged damage and critical strike chance", "+10% de dégâts et de chances de coup critique à distance");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<BloodflareHornedMask>())
				{
					line.text = line.text.Replace("10% increased magic damage and critical strike chance, +100 max mana, and 17% reduced mana usage", "10% de aumento nos danos por magia e chance de acerto crítico mágico, +100 mana máxima, e 17% de redução no consumo de mana");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<BloodflareMask>())
				{
					line.text = line.text.Replace("10% increased melee damage and critical strike chance", "10% de aumento nos danos por ataque físico e chance de acerto crítico físico");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<AuricTeslaBodyArmor>())
				{
					line.text = line.text.Replace("You will freeze enemies near you when you are struck", "Você congelará os inimigos perto de você quando for atingido");
					line.text = line.text.Replace("Provides heat and cold protection in Death Mode", "Fornece proteção contra o frio e o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<AtaxiaMask>())
				{
					line.text = line.text.Replace("Temporary immunity to lava and immunity to fire damage", "+100 mana maximum, immunité temporaire à la lave, et immunité aux dégâts de feu");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<AtaxiaHeadgear>())
				{
					line.text = line.text.Replace("Reduces ammo usage by 25%, temporary immunity to lava, and immunity to fire damage", "Réduit la consommation de munitions de 25%, immunité temporaire à la lave, et immunité aux dégâts de feu");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<AtaxiaHood>() || item.type == ModContent.ItemType<AtaxiaHelmet>() || item.type == ModContent.ItemType<AtaxiaHelm>())
				{
					line.text = line.text.Replace("Temporary immunity to lava and immunity to fire damage", "Imunidade temporária à lava e imunidade a danos por fogo");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<SoulofCryogen>())
				{
					line.text = line.text.Replace("Icicles rain down as you fly", "Sincelos chovem enquatdo você voa");
					line.text = line.text.Replace("Provides heat and cold protection in Death Mode", "Fornece proteção contra o frio e o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<ElysianWings>())
				{
					line.text = line.text.Replace("Temporary immunity to lava and 40% increased movement speed", "Imunidade temporária à lava e 40% de aumento na velocidade dos movimentos");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<ElysianTracers>() || item.type == ModContent.ItemType<InfinityBoots>())
				{
					line.text = line.text.Replace("Temporary immunity to lava", "Imunidade temporária à lava");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<CelestialTracers>())
				{
					line.text = line.text.Replace("Being hit for over 200 damage will make you immune for an extended period of time", "Ser atingido por mais de 200 de danos o deixará imune por um longo período de tempo");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<Popo>())
				{
					line.text = line.text.Replace("Transforms the holder into a snowman", "Transforma o usuário em um boneco de neve");
					line.text = line.text.Replace("Provides heat and cold protection in Death Mode", "Fornece proteção contra o frio e o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<YharimsInsignia>())
				{
					line.text = line.text.Replace("Increased melee knockback", "Maior recuo do ataque físico");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<VoidofExtinction>())
				{
					line.text = line.text.Replace("Temporary immunity to lava, greatly reduces lava burn damage, and 25% increased damage while in lava", "Imunidade temporária à lava, reduz muito o dano causado pela lava, e 25% de aumento nos danos enquanto estiver na lava");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<TheCamper>())
				{
					line.text = line.text.Replace("Provides a small amount of light in the Abyss", "Fornece uma quantidade pequena de luz no Abismo");
					line.text = line.text.Replace("Provides cold protection in Death Mode", "Fornece proteção contra o frio no Modo Morte");
				}
				if (item.type == ModContent.ItemType<TheAmalgam>())
				{
					line.text = line.text.Replace("You have a damaging aura that envenoms nearby enemies and increased movement in liquids", "Você tem uma aura que machuca e envenena inimigos próximos e movimento melhorado em líquidos");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<Sponge>())
				{
					line.text = line.text.Replace("Enemy attacks will have part of their damage absorbed and used to heal you", "Ataques inimigos terão parte do dano absorvido e usado para curar você");
					line.text = line.text.Replace("Provides cold protection in Death Mode", "Fornece proteção contra o frio no Modo Morte");
				}
				if (item.type == ModContent.ItemType<PermafrostsConcoction>())
				{
					line.text = line.text.Replace("You are encased in an ice barrier for 3 seconds when revived", "Você é envolto em uma barreira de gelo por 3 segundos quando revivido");
					line.text = line.text.Replace("Provides heat and cold protection in Death Mode", "Fornece proteção contra o frio e o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<FrostFlare>())
				{
					line.text = line.text.Replace("Provides heat and cold protection in Death Mode", "Fornece proteção contra o frio e o calor no Modo Morte");
					line.text = line.text.Replace("Revengeance drop", "Espólio do modo Vingança");
				}
				if (item.type == ModContent.ItemType<FrostBarrier>())
				{
					line.text = line.text.Replace("You are immune to the chilled debuff", "Você é imune ao efeito negativo Resfriado");
					line.text = line.text.Replace("Provides heat and cold protection in Death Mode", "Fornece proteção contra o frio e o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<FrigidBulwark>())
				{
					line.text = line.text.Replace("The shell becomes more powerful when below 15% life and reduces damage even further", "O escudo se torna mais poderoso quando abaixo de 15% de vida e reduz o dano ainda mais");
					line.text = line.text.Replace("Provides heat and cold protection in Death Mode", "Fornece proteção contra o frio e o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<ElementalGauntlet>())
				{
					line.text = line.text.Replace("Maior recuo do ataque físico", "Maior recuo do ataque físico\nFornece proteção contra o frio e o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<BlazingCore>())
				{
					line.text = line.text.Replace("Provides a moderate amount of light in the abyss", "Fornece uma quantidade razoável de luz no Abismo");
					line.text = line.text.Replace("Provides heat and cold protection in Death Mode", "Fornece proteção contra o frio e o calor no Modo Morte");
				}
				if (item.type == ModContent.ItemType<AngelTreads>())
				{
					line.text = line.text.Replace("Temporary immunity to lava", "Imunidade temporária à lava");
					line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
				}

				if (item.type == ModContent.ItemType<AmbrosialAmpoule>())
				{
					line.text = line.text.Replace("Most bee/hornet enemies and projectiles do 75% damage to you", "A maioria dos inimigos e projéteis abelhas/vespas causam 75% de dano a você");
					line.text = line.text.Replace("Provides cold protection in Death Mode", "Fornece proteção contra o frio no Modo Morte");
				}
				if (item.type == ModContent.ItemType<PurifiedJam>())
				{
					line.text = line.text.Replace("Makes you immune to all damage and most debuffs for 5 seconds", "Torna você imune a todos os danos e à maioria dos efeitos negativos por 5 segundos");
				}
				if (item.type == ModContent.ItemType<ColdDivinity>())
				{
					line.text = line.text.Replace("Provides heat and cold protection in Death Mode when is use", "Fornece proteção contra o frio e o calor no Modo Morte quando em uso");
					line.text = line.text.Replace("Revengeance Drop", "Espólio do modo Vingança");
				}

			//Common Tooltips
			}
			if (item.type == ModContent.ItemType<AbandonedSlimeStaff>())
			{
				line.text = line.text.Replace("Holding this weapon grants", "Segurar esta arma fornece");
				line.text = line.text.Replace(" increased jump speed", " de aumento na velocidade dos pulos");
			}
			if (item.type == ModContent.ItemType<Eternity>())
			{
				line.text = line.text.Replace("There's pictures of ponies in the book", "Há fotos de pôneis no livro");
			}
			if (item.type == ModContent.ItemType<CosmicWorm>())
			{
				line.text = line.text.Replace("WARNING! Some sentinels have not been truly defeated yet and will spawn at full power during this fight!", "ATENÇÃO! Algumas sentinelas ainda não foram verdadeiramente derrotadas e surgirão com força total durante esta luta!");
				line.text = line.text.Replace("Not consumable", "Não consumível");
			}
			if (item.type == ModContent.ItemType<SunkenStew>())
			{
				line.text = line.text.Replace("Only gives 37 seconds of Potion Sickness", "Só dá 37 segundos de Enjoo por poção");
			}
			if (item.type == ModContent.ItemType<Revenge>())
			{
				line.text = line.text.Replace("Enables the Rage mechanic. When Rage is maxed press", "Ativa a mecânica da Fúria. Quando a Fúria estiver no máximo, pressione");
				line.text = line.text.Replace("to activate Rage Mode.", "para ativar o Modo Fúria.");
				line.text = line.text.Replace("Enables the Adrenaline mechanic. When Adrenaline is maxed press", "Ativa a mecânica da Adrenalina. Quando a Adrenalina estiver no máximo, pressione");
				line.text = line.text.Replace("to activate Adrenaline Mode.", "para ativar o modo Adrenalina.");
			}
			if (item.type == ModContent.ItemType<VitalJelly>())
			{
				string jumpAmtVJelly = Main.player[Main.myPlayer].autoJump ? "6" : "24";
				line.text = line.text.Replace(jumpAmtVJelly + "% increased jump speed", "+" + jumpAmtVJelly + "% de aumento na velocidade dos pulos");
			}
			if (item.type == ModContent.ItemType<SpectralVeil>())
			{
				string hotkeySpecVeil = CalamityMod.CalamityMod.SpectralVeilHotKey.TooltipHotkeyString();
				line.text = line.text.Replace("Press " + hotkeySpecVeil + " to consume 25% of your maximum stealth to perform a short range teleport and render you momentarily invulnerable", "Pressione " + hotkeySpecVeil + " para consumir 25% de sua furtividade máxima para criar um teletransporte de curto alcance e torná-lo momentaneamente invulnerável");
			}
			if (item.type == ModContent.ItemType<SandCloak>())
			{
				string hotkeySand = CalamityMod.CalamityMod.SandCloakHotkey.TooltipHotkeyString();
				line.text = line.text.Replace("Press " + hotkeySand + " to consume 25% of your maximum stealth to create a protective dust veil which provides +6 defense and +2 life regen", "Pressione " + hotkeySand + " para consumir 25% de sua furtividade máxima para criar um véu de poeira protetor que fornece +6 defesa e +2 regeneração de vida");
			}
			if (item.type == ModContent.ItemType<ProfanedSoulCrystal>())
			{
				line.text = line.text.Replace("The soul within this crystal has been defiled by the powerful magic of a supreme witch", "A alma dentro desse cristal foi contaminada pela poderosa magia de uma bruxa suprema");
				line.text = line.text.Replace("The soul within this crystal has been defiled by overwhelming energy waves from dangerous mechanations", "A alma dentro desse cristal foi contaminada pelas ondas de energia de maquinações");
				line.text = line.text.Replace("Merchants will reject a defiled soul such as this.", "Comerciantes rejeitarão uma alma como essa.");
				line.text = line.text.Replace("Transforms Magic attacks into a powerful splitting fireball for", "Transforma ataques mágicos em uma poderosa bola de fogo que se divide por");
				line.text = line.text.Replace("mana per cast", "mana por disparo");
			}
			if (item.type == ModContent.ItemType<PlaguedFuelPack>())
			{
				string plagueHotkey = CalamityMod.CalamityMod.PlaguePackHotKey.TooltipHotkeyString();
				line.text = line.text.Replace("Press " + plagueHotkey + " to consume 25% of your maximum stealth to perform a swift upwards/diagonal dash which leaves a trail of plagued clouds", "Pressione " + plagueHotkey + " para consumir 25% de sua furtividade máxima para executar uma corrida ascendente/diagonal rápida que deixa um rastro de nuvens da praga");
			}
			if (item.type == ModContent.ItemType<Nanotech>() || item.type == ModContent.ItemType<RaidersTalisman>())
			{
				line.text = line.text.Replace("Rogue Crit Level:", "Nível de Crítico Ladino:");
			}
			if (item.type == ModContent.ItemType<MomentumCapacitor>())
			{
				string hotkeyCapacitor = CalamityMod.CalamityMod.MomentumCapacitatorHotkey.TooltipHotkeyString();
				line.text = line.text.Replace("Press " + hotkeyCapacitor + " to consume 30% of your maximum stealth to create an energy field at the cursor position", "Pressione " + hotkeyCapacitor + " para consumir 30% de sua furtividade máxima para criar um campo de energia na posição do cursor");
			}
			if (item.type == ModContent.ItemType<GrandGelatin>())
			{
				string jumpAmtGelatin = Main.player[Main.myPlayer].autoJump ? "10" : "40";
				line.text = line.text.Replace(jumpAmtGelatin + "% increased jump speed", "+" + jumpAmtGelatin + "% de aumento na velocidade dos pulos");
			}
			if (item.type == ModContent.ItemType<CelestialJewel>())
			{
				string hotkeyCelestial = CalamityMod.CalamityMod.AstralTeleportHotKey.TooltipHotkeyString();
				line.text = line.text.Replace("Press " + hotkeyCelestial + " to teleport to a random location while no bosses are alive", "Pressione " + hotkeyCelestial + " para teleportar para um local aleatório enquanto nenhum chefe estiver vivo");
			}

			if (item.type == ModContent.ItemType<BlunderBooster>())
			{
				string hotkeyBlunder = CalamityMod.CalamityMod.PlaguePackHotKey.TooltipHotkeyString();
				line.text = line.text.Replace("Press " + hotkeyBlunder + " to consume 25% of your maximum stealth to perform a swift upwards/diagonal dash which leaves a trail of lightning bolts", "Pressione " + hotkeyBlunder + " para consumir 25% de sua furtividade máxima para executar uma corrida ascendente/diagonal rápida que deixa um rastro de relâmpagos");
			}

			if (item.type == ModContent.ItemType<AstralArcanum>())
			{
				string hotkeyArcanum = CalamityMod.CalamityMod.AstralArcanumUIHotkey.TooltipHotkeyString();
				line.text = line.text.Replace("Press " + hotkeyArcanum + " to toggle teleportation UI", "Pressione " + hotkeyArcanum + " para alternar a interface de teleportação");
			}

			if (item.type == ModContent.ItemType<AsgardianAegis>() || item.type == ModContent.ItemType<ElysianAegis>())
			{
				string hotkeyAsgard = CalamityMod.CalamityMod.AegisHotKey.TooltipHotkeyString();
				line.text = line.text.Replace("Press " + hotkeyAsgard + " to activate buffs to all damage, crit chance, and defense", "Pressione " + hotkeyAsgard + " para ativar reforços para todos os danos, chance de crítico e defesa");
			}

			if (item.type == ModContent.ItemType<AeroStone>())
			{
				string jumpAmt = Main.player[Main.myPlayer].autoJump ? "5" : "20";
				line.text = line.text.Replace("Increases movement speed by 10%, jump speed by " + jumpAmt + "%, and all damage by 3%", "Aumenta a velocidade dos movimentos em 10%, velocidade dos pulos em " + jumpAmt + "% e todos os danos em 3%");
			}

			if (item.type == ModContent.ItemType<NormalityRelocator>())
			{
				string hotkeyReloc = CalamityMod.CalamityMod.NormalityRelocatorHotKey.TooltipHotkeyString();
				line.text = line.text.Replace("Press " + hotkeyReloc + " to teleport to the position of the mouse", "Pressione " + hotkeyReloc + " para teleportar para a posição do mouse");
			}

			if (item.type == ModContent.ItemType<MagicLevelMeter>())
			{
				line.text = line.text.Replace("Tells you how high your magic proficiency is", "Diz a você o nível de sua proficiência com magia");
				line.text = line.text.Replace("While equipped you will gain magic proficiency faster", "Enquanto equipado, você ganhará proficiência com magia mais rápido");
				line.text = line.text.Replace("The higher your magic level the higher your magic damage, critical strike chance, and the lower your mana cost", "Quanto maior o seu nível de magia, maior o dano por magia, a chance de acerto crítico mágico e menor o custo de mana");
				line.text = line.text.Replace("Magic proficiency (max of 12500):", "Proficiência com magia (máx. 12500):");
				line.text = line.text.Replace("Magic level (max of 15):", "Nível de magia (máx. 15):");
				line.text = line.text.Replace("Magic damage increase:", "Aumento nos danos por magia:");
				line.text = line.text.Replace("Mana usage decrease:", "Redução no uso de mana:");
				line.text = line.text.Replace("Magic crit increase:", "Aumento na chance de acerto crítico mágico:");
			}
			if (item.type == ModContent.ItemType<MeleeLevelMeter>())
			{
				line.text = line.text.Replace("Tells you how high your melee proficiency is", "Diz a você o nível de sua proficiência física");
				line.text = line.text.Replace("While equipped you will gain melee proficiency faster", "Enquanto equipado, você ganhará proficiência física mais rápido");
				line.text = line.text.Replace("The higher your melee level the higher your melee damage, speed, and critical strike chance", "Quanto maior o seu nível físico, maior o dano por ataque físico, a velocidade do ataque físico, e a chance de acerto crítico físico");
				line.text = line.text.Replace("Melee proficiency (max of 12500):", "Proficiência física (máx. 12500):");
				line.text = line.text.Replace("Melee level (max of 15):", "Nível físico (máx. 15):");
				line.text = line.text.Replace("Melee damage increase:", "Aumento nos danos por ataque físico:");
				line.text = line.text.Replace("Melee speed increase:", "Aumento na velocidade do ataque físico:");
				line.text = line.text.Replace("Melee crit increase:", "Aumento na chance de acerto crítico físico:");
			}
			if (item.type == ModContent.ItemType<RangedLevelMeter>())
			{
				line.text = line.text.Replace("Tells you how high your ranged proficiency is", "Diz a você o nível de sua proficiência à distância");
				line.text = line.text.Replace("While equipped you will gain ranged proficiency faster", "Enquanto equipado, você ganhará proficiência à distância mais rápido");
				line.text = line.text.Replace("The higher your ranged level the higher your ranged damage, critical strike chance, and movement speed", "Quanto maior o seu nível à distância, maior o dano por ataque à distância, a chance de ataque crítico à distância, e a velocidade dos movimentos");
				line.text = line.text.Replace("Ranged proficiency (max of 12500):", "Proficiência à distância (máx. 12500):");
				line.text = line.text.Replace("Ranged level (max of 15):", "Nível à distância (máx. 15):");
				line.text = line.text.Replace("Ranged damage increase:", "Aumento nos danos por ataque à distância:");
				line.text = line.text.Replace("Movement speed increase:", "Aumento na velocidade dos movimentos:");
				line.text = line.text.Replace("Ranged crit increase:", "Aumento na chance de acerto crítico à distância:");
			}
			if (item.type == ModContent.ItemType<RogueLevelMeter>())
			{
				line.text = line.text.Replace("Tells you how high your rogue proficiency is", "Diz a você o nível de sua proficiência ladina");
				line.text = line.text.Replace("While equipped you will gain rogue proficiency faster", "Enquanto equipado, você ganhará proficiência ladina mais rápido");
				line.text = line.text.Replace("The higher your rogue level the higher your rogue damage, critical strike chance, and velocity", "Quanto maior o seu nível ladino, maior o dano por ataque ladino, a chance de acerto crítico ladino, e a velocidade dos projéteis");
				line.text = line.text.Replace("Rogue proficiency (max of 12500):", "Proficiência ladina (máx. 12500):");
				line.text = line.text.Replace("Rogue level (max of 15):", "Nível ladino (máx. 15):");
				line.text = line.text.Replace("Rogue damage increase:", "Aumento nos danos por ataque ladino:");
				line.text = line.text.Replace("Rogue velocity increase:", "Aumento na velocidade dos projéteis ladino:");
				line.text = line.text.Replace("Rogue crit increase:", "Aumento na chance de acerto crítico ladino:");
			}
			if (item.type == ModContent.ItemType<SummonLevelMeter>())
			{
				line.text = line.text.Replace("Tells you how high your summon proficiency is", "Diz a você o nível de sua proficiência com invocação");
				line.text = line.text.Replace("While equipped you will gain summon proficiency faster", "Enquanto equipado, você ganhará proficiência com invocação mais rápido");
				line.text = line.text.Replace("The higher your summon level the higher your minion damage, knockback, and slots", "Quanto maior o seu nível de invocação, maior o seu dano por lacaios, o recuo dos lacaios, e os espaços de lacaios");
				line.text = line.text.Replace("Summon proficiency (max of 12500):", "Proficiência com invocação (máx. 12500):");
				line.text = line.text.Replace("Summon level (max of 15):", "Nível de invocação (máx. 15):");
				line.text = line.text.Replace("Minion damage increase:", "Aumento nos danos por lacaios:");
				line.text = line.text.Replace("Minion knockback increase:", "Aumento no recuo dos lacaios:");
				line.text = line.text.Replace("Minion slot increase:", "Aumento no número de espaços de lacaios:");
			}
			if (item.type == ModContent.ItemType<StatMeter>())
			{
				line.text = line.text.Replace("Displays almost all player stats", "Exibe a maioria das estatísticas do jogador");
				line.text = line.text.Replace("Offensive stats displayed vary with held item", "As estatísticas ofensivas exibidas variam com a arma em mãos");
				line.text = line.text.Replace("Adrenaline Damage Boost:", "Reforço de danos no Modo Adrenalina:");
				line.text = line.text.Replace("Adrenaline DR Boost:", "Reforço na redução de danos no Modo Adrenalina:");
				line.text = line.text.Replace("Rage Damage Boost:", "Reforço de danos no Modo Fúria:");
				line.text = line.text.Replace("Melee Damage:", "Danos por ataque físico:");
				line.text = line.text.Replace("True Melee Damage:", "Danos por ataque físico verdadeiro:");
				line.text = line.text.Replace("True Danos por ataque físico:", "Danos por ataque físico verdadeiro:");
				line.text = line.text.Replace("Melee Crit Chance:", "Chance de acerto crítico físico:");
				line.text = line.text.Replace("Melee Speed Boost:", "Reforço na velocidade dos ataques físicos:");
				line.text = line.text.Replace("Ranged Damage:", "Danos por ataque à distância:");
				line.text = line.text.Replace("Ranged Crit Chance:", "Chance de acerto crítico à distância:");
				line.text = line.text.Replace("Ammo Consumption Chance:", "Chance do consumo de munição:");
				line.text = line.text.Replace("Magic Damage:", "Danos por magia:");
				line.text = line.text.Replace("Magic Crit Chance:", "Chance de acerto crítico mágico:");
				line.text = line.text.Replace("Mana Usage:", "Consumo de mana:");
				line.text = line.text.Replace("Mana Regen:", "Regeneração de mana:");
				line.text = line.text.Replace("Minion Damage:", "Dano por lacaios:");
				line.text = line.text.Replace("Minion Slots:", "Espaços de lacaio:");
				line.text = line.text.Replace("Rogue Damage:", "Danos por ataque ladino:");
				line.text = line.text.Replace("Rogue Crit Chance:", "Chance de acerto crítico ladino:");
				line.text = line.text.Replace("Rogue Velocity Boost:", "Reforço na velocidade dos projéteis ladinos:");
				line.text = line.text.Replace("Rogue Weapon Consumption Chance:", "Chance de consumir armas ladin:");
				line.text = line.text.Replace("Max Stealth:", "Furtividade máx:");
				line.text = line.text.Replace("Standing Regen:", "Regeneração de furtividade enquanto parado:");
				line.text = line.text.Replace("Moving Regen:", "Regeneração de furtividade enquanto se move:");
				line.text = line.text.Replace("Defense:", "Defesa");
				line.text = line.text.Replace("DR:", "Redução de danos:");
				line.text = line.text.Replace("Life Regen:", "Regeneração de vida:");
				line.text = line.text.Replace("Armor Penetration:", "Perfuração da blindagem:");
				line.text = line.text.Replace("Wing Flight Time:", "Tempo de voô:");
				line.text = line.text.Replace("seconds", "segundos");
				line.text = line.text.Replace("Jump Speed Boost:", "Reforço na velocidade dos pulos:");
				line.text = line.text.Replace("Movement Speed Boost:", "Reforço na velocidade dos movimentos:");
				line.text = line.text.Replace("Abyss/Cave Light Strength:", "Força da luz em cavernas/no Abismo:");
				line.text = line.text.Replace("Abyss Light Strength:", "Força da luz no Abismo:");
				line.text = line.text.Replace("Other Abyss stats are only displayed while in the Abyss", "Outras estatísticas do abismo são exibidas apenas enquanto estiver no abismo");
				line.text = line.text.Replace("Other Abyss Stats:", "Outras estatísticas do abismo:");
				line.text = line.text.Replace("Breath Lost Per Tick:", "Perda de fôlego por tique:");
				line.text = line.text.Replace("Breath Loss Rate:", "Taxa de perda de fôlego:");
				line.text = line.text.Replace("Life Lost Per Tick at Zero Breath:", "Vida perdida por tique quando sem fôlego:");
				line.text = line.text.Replace("Defense Lost:", "Defesa perdida:");
			}
			if (item.type == ModContent.ItemType<ExoThrone>())
			{
				string hotkeySpeedUp = CalamityMod.CalamityMod.ExoChairSpeedupHotkey.TooltipHotkeyString();
				string hotkeySlowDown = CalamityMod.CalamityMod.ExoChairSlowdownHotkey.TooltipHotkeyString();
				line.text = line.text.Replace("Hold " + hotkeySpeedUp + " while sitting in the throne to move much faster", "Segure " + hotkeySpeedUp + " enquanto está sentado no trono para se mover muito mais rápido");
				line.text = line.text.Replace("And hold " + hotkeySlowDown + " to move much slower", "E segure " + hotkeySlowDown + " para se mover muito mais devagar");
			}
			if (item.type == ModContent.ItemType<ShatteredCommunity>())
			{
				line.text = line.text.Replace("Current level:", "Nível Atual:");
				line.text = line.text.Replace("Rage Mode damage", "de dano no Modo Fúria");
				line.text = line.text.Replace("Progress to next level:", "Progresso para o próximo nível:");
				line.text = line.text.Replace("Total Rage Mode damage:", "Dano total no Modo Fúria:");
			}
			if (item.type == ModContent.ItemType<BiomeBlade>())
			{
				line.text = line.text.Replace("Main Attumenent :", "Sintonização Principal :");
				line.text = line.text.Replace("Secondary Attumenent :", "Sintonização Secundária :");
				line.text = line.text.Replace("Pure Clarity", "Claridade Pura");
				line.text = line.text.Replace("Biting Embrace", "Abraço Mordaz");
				line.text = line.text.Replace("Arid Grandeur", "Grandeza Árida");
				line.text = line.text.Replace("Decay's Retort", "Retorta da Decadência");
				line.text = line.text.Replace("Grovetender's Touch", "Toque do Guarda-florestal");
				line.text = line.text.Replace("None", "Nenhuma");
				line.text = line.text.Replace("Does nothing.. yet", "Não faz nada.. ainda");
				line.text = line.text.Replace("Fires a weak projectile that crushes enemy defenses", "Dispara um projétil fraco que esmaga as defesas inimigas");
				line.text = line.text.Replace("Perform a 3 strike combo with a glacial blade. The final strike freezes foes for a split second", "Execute um combo de 3 golpes com uma lâmina glacial. O golpe final congela os inimigos por uma fração de segundo");
				line.text = line.text.Replace("Conjures searing blades in front of you that get larger and stronger the more you hit enemies. The blades can also be used to bounce off tiles when in the air", "Conjura lâminas abrasadoras à sua frente que ficam maiores e mais fortes quanto mais você atinge os inimigos. As lâminas também podem ser usadas para rebater de peças quando no ar");
				line.text = line.text.Replace("Lunge forward using a ghostly rapier projection that leeches life off any struck foes. You also get bounced away from hit targets", "Invista para frente usando uma projeção fantasmagórica de florete que suga a vida de qualquer inimigo atingido. Você também rebate para longe de alvos atingidos");
				line.text = line.text.Replace("Throw out the blade using a vine whip. Striking enemies with the tip of the whip as it cracks guarantees a critical hit. The whip will also propel you towards struck tiles", "Lance a espada usando um chicote de vinha. Atingir inimigos com a ponta do chicote enquanto ele estala garante um acerto crítico. O chicote também te impulsionará para peças atingidas");
			}
			if (item.type == ModContent.ItemType<TrueBiomeBlade>())
			{
				line.text = line.text.Replace("Main Attumenent :", "Sintonização Principal :");
				line.text = line.text.Replace("Secondary Attumenent :", "Sintonização Secundária :");
				line.text = line.text.Replace("Pure Clarity", "Claridade Pura");
				line.text = line.text.Replace("Biting Embrace", "Abraço Mordaz");
				line.text = line.text.Replace("Arid Grandeur", "Grandeza Árida");
				line.text = line.text.Replace("Decay's Retort", "Retorta da Decadência");
				line.text = line.text.Replace("Grovetender's Touch", "Toque do Guarda-florestal");
				line.text = line.text.Replace("Heaven's Might", "Poder Celestial");
				line.text = line.text.Replace("Extant Abhorrence", "Aversão Subsistente");
				line.text = line.text.Replace("None", "Nenhuma");
				line.text = line.text.Replace("Does nothing.. yet", "Não faz nada.. ainda");
				line.text = line.text.Replace("Repairing the blade seems to have improved its attuning capacities", "Reparar a lâmina parece ter melhorado as suas capacidades de sintonização");
				line.text = line.text.Replace("Fires a weak projectile that crushes enemy defenses", "Dispara um projétil fraco que esmaga as defesas inimigas");
				line.text = line.text.Replace("Landing true melee hits places a sigil of purity over the enemy. Your projectiles home onto the marked foes", "Acertar golpes físicos verdadeiros coloca um sigilo de pureza sobre o inimigo. Seus projéteis seguem os inimigos marcados");
				line.text = line.text.Replace("Perform a 3 strike combo with a glacial blade. The final strike freezes foes for a split second", "Execute um combo de 3 golpes com uma lâmina glacial. O golpe final congela os inimigos por uma fração de segundo");
				line.text = line.text.Replace("Lingering glacial mist is released on each swing, dealing damage to enemies wandering into it", "Névoa glacial persistente é liberada em cada balanço, causando dano aos inimigos que vagam por ela");
				line.text = line.text.Replace("Conjures searing blades in front of you that get larger and stronger the more you hit enemies. The blades can also be used to bounce off tiles when in the air", "Conjura lâminas abrasadoras à sua frente que ficam maiores e mais fortes quanto mais você atinge os inimigos. As lâminas também podem ser usadas para rebater de peças quando no ar");
				line.text = line.text.Replace("Releasing the attack button after the blades are fully charged sends them hurtling forwards to shred your foes", "Soltar o botão de ataque depois que as lâminas estiverem totalmente carregadas as lança para frente para destruir seus inimigos");
				line.text = line.text.Replace("Lunge forward using a ghostly rapier projection that leeches life off any struck foes. You also get bounced away from hit targets", "Invista para frente usando uma projeção fantasmagórica de florete que suga a vida de qualquer inimigo atingido. Você também rebate para longe de alvos atingidos");
				line.text = line.text.Replace("Landing three strikes without touching the ground changes your next attack into an empowered dash thrust", "Acertar três golpes sem tocar no chão muda seu próximo ataque para um impulso fortalecido");
				line.text = line.text.Replace("Throw out the blade using a vine whip. Striking enemies with the tip of the whip as it cracks guarantees a critical hit. The whip will also propel you towards struck tiles", "Lance a espada usando um chicote de vinha. Atingir inimigos com a ponta do chicote enquanto ele estala garante um acerto crítico. O chicote também te impulsionará para peças atingidas");
				line.text = line.text.Replace("Spreading vines sprout from critical strikes. These vines can hit up to three targets", "Videiras que se espalham brotam de acertos críticos. Estas vinhas podem atingir até três alvos");
				line.text = line.text.Replace("Hold the attack button to charge a star-piercing lunge, release to unleash the devastating blow", "Segure o botão de ataque para carregar uma investida que perfura as estrelas, solte para liberar o golpe devastador");
				line.text = line.text.Replace("Striking the earth with the lunge will cause a massive impact which raises otherworldly monoliths", "Golpear a terra com a investida causará um impacto gigante que levanta monólitos sobrenaturais");
				line.text = line.text.Replace("Hold the attack button to swing the sword around you, accelerating over time", "Segure o botão de ataque para balançar a espada ao seu redor, acelerando com o tempo");
				line.text = line.text.Replace("Releasing the attack button hurls the sword towards your cursor. The sword then quickly returns to your hand", "Soltar o botão de ataque arremessa a espada na direção do seu cursor. A espada então rapidamente retorna à sua mão");
			}
			if (item.type == ModContent.ItemType<OmegaBiomeBlade>())
			{
				line.text = line.text.Replace("Active Attumenent :", "Sintonização Ativa :");
				line.text = line.text.Replace("Passive Attumenent :", "Sintonização Passiva :");
				line.text = line.text.Replace("Swordsmith's Pride", "Orgulho do Espadachim");
				line.text = line.text.Replace("Sanguine Fury", "Fúria Sanguínea");
				line.text = line.text.Replace("Lamentations of the Chained", "Lamentações dos Acorrentados");
				line.text = line.text.Replace("Mercurial Tides", "Marés Mercuriais");
				line.text = line.text.Replace("None", "Nenhuma");
				line.text = line.text.Replace("Does nothing.. yet", "Não faz nada.. ainda");
				line.text = line.text.Replace("It seems that upgrading the blade expanded the scope of the previous attunements", "Parece que melhorar a lâmina expandiu o escopo das sintonizações anteriores");
				line.text = line.text.Replace("Your secondary attunement can now provide passive bonuses", "A sua sintonização secundária agora pode fornecer efeitos passivos");
				line.text = line.text.Replace("Hold the attack button to swing the sword around you, accelerating over time. Sword beams are fired wildly while swinging", "Segure o botão de ataque para balançar a espada ao seu redor, acelerando com o tempo. Feixes de espada são disparados descontroladamente enquanto você gira");
				line.text = line.text.Replace("Releasing the attack button hurls the sword towards your cursor. Sword beams home onto enemies struck by the thrown sword", "Soltar o botão de ataque arremessa a espada na direção do cursor. Os feixes de espadas seguem os inimigos atingidos pela espada arremessada");
				line.text = line.text.Replace("All attacks have a chance to fire sword beams", "Todos os ataques têm uma chance de disparar um feixe de espada");
				line.text = line.text.Replace("Conjures molten blades in front of you that get larger and stronger the more you hit enemies. The blades can also be used to bounce off tiles when in the air", "Conjura lâminas derretidas à sua frente que ficam maiores e mais fortes quanto mais você atinge os inimigos. As lâminas também podem ser usadas para rebater de peças quando no ar");
				line.text = line.text.Replace("Releasing the attack button sends the charged blades hurtling forwards like a wheel. Attacking again immediately thereafter dashes to the wheel, shredding anything in the way", "Soltar o botão de ataque lança as lâminas carregadas como uma roda. Atacar novamente imediatamente depois te investe para a roda, destruíndo tudo no caminho");
				line.text = line.text.Replace("Striking enemies rarely steals a small amount of life", "Golpear inimigos raramente roubará uma pequena quantidade de vida");
				line.text = line.text.Replace("Hold the attack button to charge a heaven-shattering lunge, release to unleash the devastating blow. Shock waves are emitted as the sword charges up", "Segure o botão de ataque para carregar uma investida que perfura os céus, solte para liberar o golpe devastador. Ondas de choque são emitidas enquanto a espada está sendo carregada");
				line.text = line.text.Replace("Striking the earth with the lunge will cause a massive shock wave on impact which raises a flood of monoliths", "Golpear a terra com a investida causará uma onda de choque gigante no impacto que levanta uma enchente de monólitos");
				line.text = line.text.Replace("Periodically emit shock waves while attacking", "Periodicamente emite ondas de choque enquanto ataca");
				line.text = line.text.Replace("Lash out with a flurry of chained blades. Striking enemies with the tip of the blades guarantees a critical hit", "Ataque com uma enxurrada de lâminas acorrentadas. Atingir os inimigos com a ponta de lâminas garante um acerto crítico");
				line.text = line.text.Replace("Critical strikes send out extra phantom chains which latch onto multiple targets", "Acertos críticos enviam correntes extras que se prendem a vários alvos");
				line.text = line.text.Replace("An enchanted chain hook floats near you. Striking enemies makes the hook whirl around you, freezing enemies", "Um gancho de corrente encantado flutua perto de você. Atingir os inimigos faz o gancho girar em torno de você, congelando os inimigos");
			}
			if (item.type == ModContent.ItemType<FourSeasonsGalaxia>())
			{
				line.text = line.text.Replace("Active Attumenent :", "Sintonização Ativa :");
				line.text = line.text.Replace("Passive Blessing :", "Bênção Passiva :");
				line.text = line.text.Replace("Phoenix's Pride", "Orgulho da Fênix");
				line.text = line.text.Replace("Aries' Wrath", "Ira de Áries");
				line.text = line.text.Replace("Polaris' Gaze", "Olhar Polar");
				line.text = line.text.Replace("Andromeda's Stride", "Passo de Andrômeda");
				line.text = line.text.Replace("Capricorn's Blessing", "Bênção do Capricórnio");
				line.text = line.text.Replace("Cancer's Blessing", "Bênção de Câncer");
				line.text = line.text.Replace("Hold the attack button to swing Galaxia around you, accelerating over time. The swirling nebula constantly emits homing cosmic bolts", "Segure o botão de ataque para balançar Galaxia ao seu redor, acelerando com o tempo. A nébula rodopiante constantemente emite raios cósmicos teleguiados");
				line.text = line.text.Replace("Releasing the attack button hurls the sword towards your cursor alongside a burst of 6 gigantic cosmic bolts. The sword then quickly returns to your hand", "Soltar o botão de ataque arremessa a espada na direção do cursor junto de uma rajada de 6 raios cósmicos gigantescos. A espada então rapidamente retorna à sua mão");
				line.text = line.text.Replace("Throw Galaxia to your cursor, holding it in place with constellations. Galaxia follows your cursor, rapidly spinning to shred enemies", "Arremesse Galaxia para o seu cursor, segurando-a no lugar com constelações. Galaxia segue o seu cursor, rapidamente girando para destruir os inimigos");
				line.text = line.text.Replace("Striking enemies causes nebulous explosions which spawn homing cosmic bolts", "Golpear inimigos causa explosões nebulosas que invocam raios cósmicos teleguiados");
				line.text = line.text.Replace("Hold the attack button to channel the Northern Star's power into a tight vortex of galactic energies, bound by concentric rings of stars. The vortex powers up over time and when hitting enemies", "Segure o botão de ataque para canalizar o poder da Estrela do Norte em um vórtice apertado de energias galácticas, ligado por anéis concêntricos de estrelas. O vórtice aumenta ao longo do tempo e ao atingir os inimigos");
				line.text = line.text.Replace("Release the attack button to fire off the charged star. Attacking again immediately thereafter dashes to the star, emitting a nova of cosmic bolts", "Solte o botão de ataque para disparar a estrela carregada. Atacar novamente imediatamente depois te investe para a estrela, emitindo uma nova de raios cósmicos");
				line.text = line.text.Replace("Hold the attack button to charge a god-erasing lunge, release to unleash the devastating blow. Galaxia emits cosmic bolts while charging", "Segure o botão de ataque para carregar uma investida destruidora de deuses, solte para liberar o golpe devastador. Galaxia emite raios cósmicos enquanto carrega");
				line.text = line.text.Replace("Striking the earth with the lunge will cause a massive impact which summons an apocalyptic storm of cosmic energies", "Golpear a terra com a investida causará um impacto gigante que invoca uma tempestade apocalíptica de energias cósmicas");
				line.text = line.text.Replace("Periodically releases a ring of weakening stars around your cursor when attacking", "Periodicamente libera um anel de estrelas enfraquecedoras em volta do seu cursor enquanto ataca");
				line.text = line.text.Replace("The ring is repelled away from you at first, before slowing down over time", "O anel é repelido para longe de você no início, antes de desacelerar com o tempo");
				line.text = line.text.Replace("Periodically releases a ring of lifestealing stars around yourself when attacking", "Periodicamente libera um anel de estrelas que roubam vida ao seu redor enquanto ataca");
				line.text = line.text.Replace("The ring is attracted towards you at first, before slowing down over time", "O anel é atraído para você no início, antes de desacelerar com o tempo");
			}
			if (item.type == ModContent.ItemType<ArkoftheAncients>())
			{
				line.text = line.text.Replace("Using RMB will extend the Ark out in front of you. Hitting an enemy with it will parry them, granting you a small window of invulnerability", "Usar o BDM estenderá a Arca na sua frente. Acertar um inimigo com ela bloqueará ele, cocedendo a você uma pequena janela de invulnerabilidade");
				line.text = line.text.Replace("You can also parry projectiles and temporarily make them deal 100 less damage", "Você também pode bloquear projéteis e temporariamente fazê-los causar 100 a menos de dano");
				line.text = line.text.Replace("Parrying will empower the next 10 swings of the sword, boosting their damage and letting them throw projectiles out", "Bloquear fortalecerá os próximos 10 golpes da espada, aumentando seu dano e permitindo que eles arremessem projéteis");
			}
			if (item.type == ModContent.ItemType<TrueArkoftheAncients>())
			{
				line.text = line.text.Replace("Using RMB will extend the Ark out in front of you. Hitting an enemy with it will parry them, granting you a small window of invulnerability", "Usar o BDM estenderá a Arca na sua frente. Acertar um inimigo com ela bloqueará ele, cocedendo a você uma pequena janela de invulnerabilidade");
				line.text = line.text.Replace("You can also parry projectiles and temporarily make them deal 160 less damage", "Você também pode bloquear projéteis e temporariamente fazê-los causar 160 a menos de dano");
				line.text = line.text.Replace("Parrying will empower the next 10 swings of the sword, boosting their damage and letting them throw stronger projectiles", "Bloquear fortalecerá os próximos 10 golpes da espada, aumentando seu dano e permitindo que eles arremessem projéteis mais fortes");
				line.text = line.text.Replace("Using RMB and pressing up while the Ark is empowered will release all the charges in a powerful burst of energy", "Usar o BDM e pressionar para cima enquanto a Arca está fortalecida liberará todas as cargas em uma poderosa explosão de energia");
			}
			if (item.type == ModContent.ItemType<ArkoftheElements>())
			{
				line.text = line.text.Replace("Performs a combo of swings, throwing the blade out every 5 swings", "Executa uma combinação de golpes, jogando a lâmina a cada 5 golpes");
				line.text = line.text.Replace("Releasing the mouse while the blade is out will throw the second half towards it, making the scissors snap", "Soltar o mouse enquanto a lâmina ainda está fora lançará a segunda metade em direção a ela, fazendo a tesoura estalar");
				line.text = line.text.Replace("Snapping the scissors together increase their damage and empower your next two swings", "Estalar a tesoura aumenta o dano e fortalece seus próximos dois golpes");
				line.text = line.text.Replace("Using RMB will snip out the scissor blades in front of you", "Usar o BDM irá estalar as tesouras na sua frente");
				line.text = line.text.Replace("Hitting an enemy with it will parry them, granting you a small window of invulnerability", "Acertar um inimigo com ela bloqueará ele, cocedendo a você uma pequena janela de invulnerabilidade");
				line.text = line.text.Replace("You can also parry projectiles and temporarily make them deal 200 less damage", "Você também pode bloquear projéteis e temporariamente fazê-los causar 200 a menos de dano");
				line.text = line.text.Replace("Parrying will empower the next 10 swings of the sword, letting you use both blades at once", "Bloquear fortalecerá os próximos 10 golpes da espada, permitindo que você use as duâs lâminas ao mesmo tempo");
				line.text = line.text.Replace("Using RMB and pressing up while the Ark is empowered will throw the blades in front of you to provoke a Big Rip in spacetime, using up all your charges in the process", "Usar o BDM e pressionar para cima enquanto a Arca está fortalecida lançará as lâminas na sua frente para provocar um Grande Rasgo no espaço-tempo, usando todas as suas cargas no processo");
			}
			if (item.type == ModContent.ItemType<ArkoftheCosmos>())
			{
				line.text = line.text.Replace("Performs a combo of swings, alternating between narrow and wide swings and throwing the blade out every 5 swings", "Executa uma combinação de golpes, alternando entre golpes estreitos e largos e jogando a lâmina a cada 5 golpes");
				line.text = line.text.Replace("The thrown blade is held in place by constellations and will follow your cursor", "A lâmina arremessada é mantida no lugar por constelações e seguirá seu cursor.");
				line.text = line.text.Replace("Releasing the mouse while the blade is out will throw the second half towards it, making the scissors snap and explode into stars", "Soltar o mouse enquanto a lâmina ainda está fora lançará a segunda metade em direção a ela, fazendo a tesoura estalar e explodir em estrelas");
				line.text = line.text.Replace("Using RMB will snip out the scissor blades in front of you", "Usar o BDM irá estalar as tesouras na sua frente");
				line.text = line.text.Replace("Hitting an enemy with it will parry them, granting you a small window of invulnerability", "Acertar um inimigo com ela bloqueará ele, cocedendo a você uma pequena janela de invulnerabilidade");
				line.text = line.text.Replace("You can also parry projectiles and temporarily make them deal 200 less damage", "Você também pode bloquear projéteis e temporariamente fazê-los causar 200 a menos de dano");
				line.text = line.text.Replace("Parrying will empower the next 10 swings of the sword, letting you use both blades at once", "Bloquear fortalecerá os próximos 10 golpes da espada, permitindo que você use as duâs lâminas ao mesmo tempo");
				line.text = line.text.Replace("Using RMB and pressing up while the Ark is empowered will throw the blades in front of you to provoke a Big Rip in spacetime, using up all your charges in the process", "Usar o BDM e pressionar para cima enquanto a Arca está fortalecida lançará as lâminas na sua frente para provocar um Grande Rasgo no espaço-tempo, usando todas as suas cargas no processo");
				line.text = line.text.Replace("If more than half the charges were used up, you can dash across the rip by keeping the up key pressed down", "Se mais da metade das cargas foram usadas, você pode atravessar o rasgo mantendo a tecla para cima pressionada");
			}

			if (item.melee)
			{
				line.text = line.text.Replace("true melee damage", "danos por ataque físico verdadeiro");
			}
		
			//Global Item Modifications

			if (item.type >= 3930 && (item.Calamity()?.UsesCharge ?? false))
			{
				line.text = line.text.Replace("Current Charge:", "Carga Atual:");
			
			}
			if ((item.Calamity()?.UsesCharge ?? false) || item.type == ModContent.ItemType<AuricQuantumCoolingCell>() || item.type == ModContent.ItemType<PlasmaGrenade>())
			{
				line.text = line.text.Replace("You don't have sufficient knowledge to create this yet", "Você ainda não tem conhecimento suficiente para criar isso");
				line.text = line.text.Replace("A specific schematic must be deciphered first", "Uma esquemática específica deve ser decifrada primeiro");
			}


			if (item.Calamity().rogue)
			{
				line.text = line.text.Replace("de danos por arremesso", "de danos por ataque ladino");
				line.text = line.text.Replace("stealth strike damage", "de danos por ataque furtivo");

				if (item.prefix > 0 && line.Name == "ItemName")
				{
					line.text = line.text.Contains("Flawless") ? line.text.Replace("Flawless", "").Trim() + " (Perfeito)" : line.text;
					line.text = line.text.Contains("Pointy") ? line.text.Replace("Pointy", "").Trim() + " (Pontudo)" : line.text;
					line.text = line.text.Contains("Sharp") ? line.text.Replace("Sharp", "").Trim() + " (Afiado)" : line.text;
					line.text = line.text.Contains("Feathered") ? line.text.Replace("Feathered", "").Trim() + " (Penado)" : line.text;
					line.text = line.text.Contains("Sleek") ? line.text.Replace("Sleek", "").Trim() + " (Lustroso)" : line.text;
					line.text = line.text.Contains("Hefty") ? line.text.Replace("Hefty", "").Trim() + " (Robusto)" : line.text;
					line.text = line.text.Contains("Mighty") ? line.text.Replace("Mighty", "").Trim() + " (Poderoso)" : line.text;
					line.text = line.text.Contains("Glorious") ? line.text.Replace("Glorious", "").Trim() + " (Glorioso)" : line.text;
					line.text = line.text.Contains("Serrated") ? line.text.Replace("Serrated", "").Trim() + " (Serrado)" : line.text;
					line.text = line.text.Contains("Vicious") ? line.text.Replace("Vicious", "").Trim() + " (Vicioso)" : line.text;
					line.text = line.text.Contains("Lethal") ? line.text.Replace("Lethal", "").Trim() + " (Letal)" : line.text;
					line.text = line.text.Contains("Radical") ? line.text.Replace("Radical", "").Trim() + " (Radical)" : line.text;
					line.text = line.text.Contains("Blunt") ? line.text.Replace("Blunt", "").Trim() + " (Cego)" : line.text;
					line.text = line.text.Contains("Flimsy") ? line.text.Replace("Flimsy", "").Trim() + " (Frágil)" : line.text;
					line.text = line.text.Contains("Unbalanced") ? line.text.Replace("Unbalanced", "").Trim() + " (Desequilibrado)" : line.text;
					line.text = line.text.Contains("Atrocious") ? line.text.Replace("Atrocious", "").Trim() + " (Atroz)" : line.text;
				}

			}

			if (item.Calamity().AppliedEnchantment != null)
			{
				line.text = line.text.Contains("Aflame") ? line.text.Replace("Aflame", "").Trim() + " (Ardente)" : line.text;
				line.text = line.text.Replace("Lights enemies ablaze on hit but also causes the user to take damage over time when holding this item.", "Acende os inimigos em chamas ao atingí-los, mas também faz com que o usuário sofra danos ao longo do tempo ao segurar este item.");
				line.text = line.text.Contains("Ephemeral") ? line.text.Replace("Ephemeral", "").Trim() + " (Efêmero)" : line.text;
				line.text = line.text.Replace("Causes the damage output of this item to discharge from exhaustive use.", "Faz com que o dano deste item descarrege por uso exaustivo.");
				line.text = line.text.Replace("Its damage returns naturally when not being used. It starts off with more damage than it normally would have.", "O seu dano retorna ao normal enquanto ele não está em uso. Ele começa com mais dano do que ele normalmente teria.");
				line.text = line.text.Contains("Withering") ? line.text.Replace("Withering", "").Trim() + " (Esmaescente)" : line.text;
				line.text = line.text.Replace("When hurt, you heal a percentage of the damage taken based on how much accumulated damage you did overall beforehand, up to 100%. After this, you gain a damage boost while holding this item but also take exponential damage over time the longer you hold it.", "Ao sofrer danos, você será curado por uma porcentagem do dano sofrido baseado na quantidade de dano acumulado que você efetuou no geral anteriormente, até 100%. Depois disso, você ganha um aumento nos danos enquanto segura este item, mas também sofre danos exponenciais ao longo do tempo quanto mais tempo você o segurar.");
				line.text = line.text.Contains("Resentful") ? line.text.Replace("Resentful", "").Trim() + " (Rancoroso)" : line.text;
				line.text = line.text.Replace("Makes the damage of projectiles vary based on how far the hit target is from you. The farther, the more damage, and vice versa.", "Faz com que o dano dos projéteis varie de acordo com a distância do alvo atingido de você. Quanto mais longe, maior o dano, e vice versa.");
				line.text = line.text.Contains("Bloodthirsty") ? line.text.Replace("Bloodthirsty", "").Trim() + " (Sanguinário)" : line.text;
				line.text = line.text.Replace("Makes the damage of projectiles vary based on how far the hit target is from you. The closer, the more damage, and vice versa.", "Faz com que o dano dos projéteis varie de acordo com a distância do alvo atingido de você. Quanto mais perto, maior o dano, e vice versa.");
				line.text = line.text.Contains("Persecuted") ? line.text.Replace("Persecuted", "").Trim() + " (Perseguido)" : line.text;
				line.text = line.text.Replace("When attacked, or over time, demon portals appear near you.", "Quando atacado, ou ao longo do tempo, portais demoníacos aparecem perto de você.");
				line.text = line.text.Replace("If sufficiently damaged they are friendly; otherwise they attack you. They become angered if a portal is damaged.", "Se suficiente danificados, são amigáveis; caso contrário, eles atacam você. Eles ficam irritados se um portal for danificado.");
				line.text = line.text.Contains("Lecherous") ? line.text.Replace("Lecherous", "").Trim() + " (Lascivo)" : line.text;
				line.text = line.text.Replace("Spawns a resilient brimstone monster that stays between you and your mouse that interferes with your homing weapons. It releases a bunch of hearts on death.", "Invoca um monstro de enxofre resiliente que fica entre você e seu mouse que inferfere com suas armas teleguiadas. Ele libera muitos corações na morte.");
				line.text = line.text.Contains("Tainted") ? line.text.Replace("Tainted", "").Trim() + " (Manchado)" : line.text;
				line.text = line.text.Replace("Removes projectile shooting capabilities of this item. In exchange, two skeletal arms are released on use that slice at the mouse position.", "Remove a capacidade de disparo de projéteis deste item. Em troca, dois braços esqueléticos são liberados no uso que cortam na posição do mouse.");
				line.text = line.text.Contains("Oblatory") ? line.text.Replace("Oblatory", "").Trim() + " (Oblatório)" : line.text;
				line.text = line.text.Replace("Reduces mana cost and greatly increases damage but sometimes causes this item to use your life.", "Reduz o custo de mana e aumenta bastante os danos, mas faz com que este item às vezes use a sua vida.");
				line.text = line.text.Contains("Traitorous") ? line.text.Replace("Traitorous", "").Trim() + " (Traidor)" : line.text;
				line.text = line.text.Replace("Causes this item to sometimes release a monster that hurts both you and enemies when you have less than 50% mana.", "Faz com que este item às vezes libere um monstro que machuca você e os inimigos quando você tem menos de 50% de mana.");
				line.text = line.text.Contains("Indignant") ? line.text.Replace("Indignant", "").Trim() + " (Indignado)" : line.text;
				line.text = line.text.Replace("Summons demons that harm you but drop healing items on death on item usage.", "Invoca demônios que te machucam mas que deixam cair itens de cura na morte ao usar o item.");
				line.text = line.text.Contains("Hellbound") ? line.text.Replace("Hellbound", "").Trim() + " (Infernal)" : line.text;
				line.text = line.text.Replace("Causes minions to be created with a 40 second timer.", "Faz com que os lacaios sejam criados com uma duração de 40 segundos.");
				line.text = line.text.Replace("Once it runs out, they explode violently. Minions do more damage the longer they live and idly explode as well.", "Quando ela acabar, eles explodem violentamente. Os lacaios causam mais danos quanto mais tempo vivem e também explodem ociosamente.");

				//PARA COMPLETAR
			}

			if (item.Calamity().canFirePointBlankShots)
            {
				line.text = line.text.Replace("Does extra damage to enemies shot at point-blank range", "Causa dano extra aos inimigos atingidos à queima-roupa");
            }

			if (item.Calamity().devItem)
			{
				line.text = line.text.Replace("Developer Item", "Item de Desenvolvedor");
			}

			if (item.Calamity().donorItem)
			{
				line.text = line.text.Replace("Donor Item", "Item de Doador");
			}

			//Untranslatable items (probably a bug)
			if (line.Name == "ItemName")
			{
				line.text = line.text.Equals("Otherworldly Stone") ? line.text.Replace("Otherworldly Stone", "Pedra do Outro Mundo").Trim() : line.text;
				line.text = line.text.Equals("Monolith Amalgam") ? line.text.Replace("Monolith Amalgam", "Amálgamo de Monólito").Trim() : line.text;
				line.text = line.text.Equals("Effulgent Manipulator") ? line.text.Replace("Effulgent Manipulator", "Manipulador Refulgente").Trim() : line.text;
				line.text = line.text.Equals("Eutrophic Shelf") ? line.text.Replace("Eutrophic Shelf", "Prateleira Eutrófica").Trim() : line.text;
				line.text = line.text.Equals("Profaned Crucible") ? line.text.Replace("Profaned Crucible", "Cadinho Profano").Trim() : line.text;
			}

			if (item.accessory && !item.social && item.prefix > 0)
			{
				line.text = line.text.Contains("Quiet") ? line.text.Replace("Quiet", "").Trim() + " (Quieto)" : line.text;
				line.text = line.text.Contains("Cloaked") ? line.text.Replace("Cloaked", "").Trim() + " (Coberto)" : line.text;
				line.text = line.text.Contains("Camouflaged") ? line.text.Replace("Camouflaged", "").Trim() + " (Camuflado)" : line.text;
				line.text = line.text.Contains("Silent") ? line.text.Replace("Silent", "").Trim() + " (Silencioso)" : line.text;
				line.text = line.text.Replace("damage reduction", "de redução de danos");
				line.text = line.text.Replace("critical strike chance", "de chance de ataque crítico");
				line.text = line.text.Replace("defense", "defesa");
				line.text = line.text.Replace("stealth generation", "de geração de furtividade");

			}

			if (item.type == 1134)
			{
				line.text = line.text.Replace("Grants the Honey buff for 2 minutes", "Fornece o efeito Mel por 2 minutos");
			}
			if (item.type == 1326)
			{
				line.text = line.text.Replace("Teleportation is disabled while Chaos State is active", "O teleporte é desativado enquanto o Estado de caos está ativo");
			}
			if (item.type == 3032 || item.type == 205)
			{
				line.text = line.text.Replace("Cannot be used in the Abyss", "Não pode ser usado no Abismo");
			}
			if (item.type == 1183 || item.type == 3577)
			{
				line.text = line.text.Replace("Provides a large amount of light in the abyss", "Fornece uma grande quantidade de luz no abismo");
			}
			List<int> litlleLightInAbyss = new List<int>() { 3062, 115, 3043, 1861, 1303, 1860, 88 };
			List<int> moderateLightInAbyss = new List<int>() { 425, 3856, 298 };
			List<int> moderateBreathLossInAbyss = new List<int>() { 1861, 268, 3110 };
			List<int> greatBreathLossInAbyss = new List<int>() { 291, 497, 861 };

			if (litlleLightInAbyss.Contains(item.type))
			{
				line.text = line.text.Replace("Provides a small amount of light in the abyss", "Fornece uma pequena quantidade de luz no abismo");
			}
			if (moderateLightInAbyss.Contains(item.type))
			{
				line.text = line.text.Replace("Provides a moderate amount of light in the abyss", "Fornece uma quantidade razoável de luz no abismo");
			}
			if (moderateBreathLossInAbyss.Contains(item.type))
			{
				line.text = line.text.Replace("Moderately reduces breath loss in the abyss", "Reduz razoavelmente a perda de fôlego no abismo");
			}
			if (greatBreathLossInAbyss.Contains(item.type))
			{
				line.text = line.text.Replace("Greatly reduces breath loss in the abyss", "Reduz bastante a perda de fôlego no abismo");
			}
			if (item.type == 2359)
			{
				line.text = line.text.Replace("Makes you immune to the Chilled, Frozen, and Glacial State debuffs", "Torna você imune aos efeitos negativos Resfriado, Congelado e Estado Glacial");
				line.text = line.text.Replace("Provides cold protection in Death Mode", "Fornece proteção contra o frio no Modo Morte");
			}
			if (item.type == 1340)
			{
				line.text = line.text.Replace("Melee and rogue attacks inflict Venom on enemies", "Ataques físicos e ladinos envenenam os inimigos");
			}
			if (item.type == 1353)
			{
				line.text = line.text.Replace("Melee and rogue attacks inflict enemies with cursed flames", "Ataques físicos e ladinos fazem com que seus inimigos queimem com chamas amaldiçoadas");
			}
			if (item.type == 1354)
			{
				line.text = line.text.Replace("Melee and rogue attacks set enemies on fire", "Ataques físicos e ladinos incendeiam seus inimigos");
			}
			if (item.type == 1355)
			{
				line.text = line.text.Replace("Melee and rogue attacks make enemies drop more gold", "Ataques físicos e ladinos fazem com que seus inimigos deixem cair mais ouro");
			}
			if (item.type == 1356)
			{
				line.text = line.text.Replace("Melee and rogue attacks decrease enemy defense", "Ataques físicos e ladinos diminuem as defesas dos inimigos");
			}
			if (item.type == 1357)
			{
				line.text = line.text.Replace("Melee and rogue attacks confuse enemies", "Ataques físicos e ladinos confundem os inimigos");
			}
			if (item.type == 1358)
			{
				line.text = line.text.Replace("All attacks cause confetti to appear", "Todos os ataques fazem com que confetes apareçam");
			}
			if (item.type == 1359)
			{
				line.text = line.text.Replace("Melee and rogue attacks poison enemies", "Ataques físicos e ladinos envenenam os inimigos");
			}
			if (item.type == 3224)
			{
				line.text = line.text.Replace("Reduces damage taken by 10%", "Reduz os danos sofrido em 10%");
			}
			if (item.type == 536 || item.type == 897 || item.type == 936)
			{
				line.text = line.text.Replace("10% increased true melee damage", "10% de aumento no dano por ataque físico verdadeiro");
			}
			if (item.type == 1343)
			{
				line.text = line.text.Replace("14% increased melee damage and speed", "14% de aumento no dano e velocidade de ataques físicos");
				line.text = line.text.Replace("10% increased true melee damage", "10% de aumento no dano por ataque físico verdadeiro");
				line.text = line.text.Replace("Provides heat and cold protection in Death Mode", "Fornece proteção contra o calor e o frio no Modo Morte");
			}
			if (item.type == 1503)
			{
				line.text = line.text.Replace("20% decreased magic damage", "20% de redução no dano por magia");
			}
			if (item.type == 288)
			{
				line.text = line.text.Replace("Provides immunity to direct damage from touching lava", "Fornece imunidade a danos diretos de lava no contato");
				line.text = line.text.Replace("Provides temporary immunity to lava burn damage", "Fornece imunidade temporária aos danos de queimaduras da lava");
				line.text = line.text.Replace("Greatly increases lava immunity time regeneration", "Aumenta bastante a regeneração de tempo de imunidade à lava");
				line.text = line.text.Replace("Reduces lava burn damage", "Reduz os danos de queimaduras da lava");
				line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
			}
			if (item.type == 1323)
			{
				line.text = line.text.Replace("Reduced direct damage from touching lava", "Reduz os danos diretos por tocar na lava");
				line.text = line.text.Replace("Greatly reduces lava burn damage", "Reduz bastante os danos de queimaduras da lava");
				line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
			}
			if (item.type == 1322)
			{
				line.text = line.text.Replace("Provides heat and cold protection in Death Mode", "Fornece proteção contra o calor e o frio no Modo Morte");
			}
			if (item.type == 906 || item.type == 908)
			{
				line.text = line.text.Replace("Provides heat protection in Death Mode", "Fornece proteção contra o calor no Modo Morte");
			}
			if (item.type == 297)
			{
				line.text = line.text.Replace("Boosts certain stats when holding certain types of rogue weapons", "Reforça certas estatísticas quando você segura certos tipos de armas ladinas");
			}
			if (item.type == 2294)
			{
				line.text = line.text.Replace("Requires bait to catch fish", "Requer isca para pescar peixes");
				line.text = line.text.Replace("The line will never break", "A linha nunca quebrará");
			}
			if (item.type == 1294)
			{
				line.text = line.text.Replace("Capable of mining Lihzahrd Bricks and Scoria Ore", "Capaz de minerar tijolos lagharto e minério de escória");
			}
			if (item.type == 2786 || item.type == 2776 || item.type == 2781 || item.type == 3466)
			{
				line.text = line.text.Replace("Material", "Material");
				line.text = line.text.Replace("Can mine Uelibloom Ore located in the Jungle", "Pode minerar minério de casca florescente localizado na Selva");
			}
			if (item.type == 89 || item.type == 80 || item.type == 76)
			{
				line.text = line.text.Replace("Set Bonus: +2 defense and 15% increased mining speed", "Bônus Definido: +2 defesa e 15% de aumento na velocidade de mineração");
			}
			if (item.type == 123 || item.type == 124 || item.type == 125)
			{
				line.text = line.text.Replace("Set Bonus: Reduces the mana cost of the Space Gun by 50%", "Bônus Definido: Reduz o custo de mana da Arma Espacial em 50%");
			}
			if (item.type == 687 || item.type == 688 || item.type == 689)
			{
				line.text = line.text.Replace("Set Bonus: +2 defense and 15% increased mining speed", "Bônus Definido: +2 defesa e 15% de aumento na velocidade de mineração");
			}
			if (item.type == 954 || item.type == 90 || item.type == 81 || item.type == 77)
			{
				line.text = line.text.Replace("Set Bonus: +2 defense and 25% increased mining speed", "Bônus Definido: +2 defesa e 25% de aumento na velocidade de mineração");
			}
			if (item.type == 690 || item.type == 691 || item.type == 692)
			{
				line.text = line.text.Replace("Set Bonus: +3 defense and 20% increased mining speed", "Bônus Definido: +3 defesa e 20% de aumento na velocidade da mineração");
			}
			if (item.type == 91 || item.type == 82 || item.type == 78)
			{
				line.text = line.text.Replace("Set Bonus: +3 defense and 35% increased mining speed", "Bônus Definido: +3 defesa e 35% de aumento na velocidade da mineração");
			}
			if (item.type == 693 || item.type == 694 || item.type == 695)
			{
				line.text = line.text.Replace("Set Bonus: +3 defense and 30% increased mining speed", "Bônus Definido: +3 defesa e 30% de aumento na velocidade da mineração");
			}
			if (item.type == 955 || item.type == 92 || item.type == 83 || item.type == 79)
			{
				line.text = line.text.Replace("Set Bonus: +3 defense and 45% increased mining speed", "Bônus Definido: +3 defesa e 45% de aumento na velocidade da mineração");
			}
			if (item.type == 696 || item.type == 697 || item.type == 698)
			{
				line.text = line.text.Replace("Set Bonus: +4 defense and 40% increased mining speed", "Bônus Definido: +4 defesa e +40% de aumento na velocidade da mineração");
			}
			if ((item.type == 3776 || item.type == 3777 || item.type == 3778))
			{
				line.text = line.text.Replace("The minion damage nerf is reduced while wielding magic weapons", "A redução de danos de lacaios é diminuída ao segurar armas de magia");
			}
			if (item.type == 3187)
			{
				line.text = line.text.Replace("3 defense", "+3 defesa");
				line.text = line.text.Replace("3% increased rogue damage", "3% de aumento nos danos por ataque ladino");
			}
			if (item.type == 3188)
			{
				line.text = line.text.Replace("5 defense", "+5 defesa");
				line.text = line.text.Replace("3% increased rogue critical strike chance", "3% de chance de ataque ladino crítico");
			}
			if (item.type == 3189)
			{
				line.text = line.text.Replace("4 defense", "+4 defesa");
				line.text = line.text.Replace("3% increased rogue velocity", "3% de aumento na velocidade dos projéteis ladinos");
			}
			if (item.type == 3266)
			{
				line.text = line.text.Replace("4 defense", "+3 defesa");
				line.text = line.text.Replace("3% increased rogue damage", "3% de aumento no dano ladino");
			}
			if (item.type == 3267)
			{
				line.text = line.text.Replace("5 defense", "+5 defesa");
				line.text = line.text.Replace("3% increased rogue critical strike chance", "3% de aumento na chance de ataque ladino crítico");
			}
			if (item.type == 3268)
			{
				line.text = line.text.Replace("4 defense", "+4 defesa");
				line.text = line.text.Replace("3% increased rogue velocity", "3% de aumento na velocidade dos projéteis ladinos");
			}
			if (item.type == 231 || item.type == 232 || item.type == 233)
			{
				line.text.Replace("Set Bonus: 17% extra melee damage", "Bônus Definido: 17% de dano por ataque físico extra");
				line.text.Replace("20% extra true melee damage", "20% de dano por ataque físico verdadeiro extra");
				line.text.Replace("Grants immunity to fire blocks, and temporary immunity to lava", "Fornece imunidade a blocos de fogo, e imunidade temporária à lava");
				line.text.Replace("Provides heat and cold protection in Death Mode", "Fornece proteção contra o calor e o frio no Modo Morte");
			}
			if ((item.type == 684 || item.type == 685 || item.type == 686))
			{
				line.text.Replace("Provides heat and cold protection in Death Mode", "Fornece proteção contra o frio e o calor no Modo Morte");
			}
			if (item.type == 1321)
			{
				line.text = line.text.Replace("Increases arrow damage by 10% and greatly increases arrow speed", "Aumenta o dano das flechas em 10% e aumenta muito a velocidade das flechas");
			}
			if (item.type == 88)
			{
				line.text = line.text.Replace("Provides light when worn", "Emite luz quando usado");
			}
			if (item.type == 1921)
			{
				line.text = line.text.Replace("Provides immunity to chilling and freezing effects", "Fornece imunidade ao resfriamento e congelamento");
				line.text = line.text.Replace("Provides a regeneration boost while wearing the Eskimo armor", "Fornece um efeito de regeneração ao vestir a armadura de Esquimó");
				line.text = line.text.Replace("Provides cold protection in Death Mode", "Fornece proteção contra o frio no Modo Morte");
			}
			if (item.type == 560  || item.type == 361 || item.type == 560 || item.type == 1844 || item.type == 1958 || item.type == 2767 || item.type == 3601 || item.type == 1315)
			{
				line.text = line.text.Replace("Not consumable", "Não consumível");
			}
			if (item.type == 43)
			{
				line.text = line.text.Replace("Not consumable", "Não consumível");
				line.text = line.text.Replace("when used during nighttime", "quando usado durante a noite");
			}
			if (item.type == 1133)
			{
				line.text = line.text.Replace("Not consumable", "Não consumível");
				line.text = line.text.Replace("when used in the jungle", "quando usado na selva");
			}
			if (item.type == 1331)
			{
				line.text = line.text.Replace("Not consumable", "Não consumível");
				line.text = line.text.Replace("when used in the crimson", "quando usada no carmim");
			}
			if (item.type == 70)
			{
				line.text = line.text.Replace("Not consumable", "Não consumível");
				line.text = line.text.Replace("when used in the corruption", "quando usado na corrupção");
			}
			if (item.type == 1293)
			{
				line.text = line.text.Replace("Not consumable", "Não consumível");
				line.text = line.text.Replace("to summon the Golem", "para invocar o Golem");
			}
			if (item.type == 544 || item.type == 556 || item.type == 557)
			{
				line.text = line.text.Replace("Not consumable", "Não consumível");
				line.text = line.text.Replace("when used during nighttime", "quando usado durante a noite");
			}
			if (item.type == 2673)
			{
				line.text = line.text.Replace("Not consumable", "Não consumível");
				line.text = line.text.Replace("Summons Duke Fishron if used as bait in the ocean", "Invoca o Duque Peixe-dragão se usado como isca no oceano");
			}


			if (item.type == 3580 || item.type == 3582 || item.type == 3588 || item.type == 3592 || item.type == 3924 || item.type == 3928 || item.type == 3228 || item.type == 665 || item.type == 1583 || item.type == 1584 || item.type == 1585 || item.type == 1586)
			{
				line.text = line.text.Replace("Great for impersonating devs!", "Ótimo para fingir que é um desenvolvedor!");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
			}
			if (item.type == 748)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
			}
			if (item.type == 2609)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Good vertical speed", "Velocidade vertical boa");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
			}
			if (item.type == 493)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("+20 max life, +15 defense and +3 life regen", "+20 vida máxima, +15 defesa e +3 regeneração de vida");
			}
			if (item.type == 492)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("10% increased damage and critical strike chance", "10% de aumento nos danos e na chance de acerto crítico");
			}
			if (item.type == 749)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("+50 max mana, 5% decreased mana usage,", "+50 mana máxima, 5% de redução no consumo de mana,");
				line.text = line.text.Replace("10% increased magic damage and 5% increased magic critical strike chance", "10% de aumento nos danos por magia e 5% de aumento na chance de acerto crítico mágico");
			}
			if (item.type == 761)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("+80 max life", "+80 vida máxima");
			}
			if (item.type == 1515)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("Honey buff at all times", "Efeito do mel permanente");
			}
			if (item.type == 785)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("30% increased movement speed", "30% de aumento na velocidade dos movimentos");
				line.text = line.text.Replace("Most attacks have a chance to fire a feather on swing if Harpy Ring or Angel Treads are equipped", "A maioria dos ataques têm uma chance de disparar uma pena no balanço se o Anel de Harpia ou os Passos Angelicais estiverem equipados");
			}
			if (item.type == 786)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("15% increased movement speed, 12% increased ranged damage,", "15% de aumento na velocidade dos movimentos, 12% de aumento nos danos por ataque à distância,");
				line.text = line.text.Replace("16% increased ranged critical strike chance", "16% de aumento na chance de ataque crítico à distância");
				line.text = line.text.Replace("and +30 defense while wearing the Necro Armor", "e +30 defesa ao vestir a armadura Necrosada");
			}
			if (item.type == 821)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("10% increased melee damage", "10% de aumento nos danos por ataque físico");
				line.text = line.text.Replace("and 5% increased melee critical strike chance", "e 5% de aumento na chance de acerto crítico físico");
			}
			if (item.type == 822)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("2% increased melee and ranged damage", "2% de aumento nos danos por ataque físico e à distância");
				line.text = line.text.Replace("and 1% increased melee and ranged critical strike chance", "e 1% de aumento na chance de acerto crítico físico e à distância");
				line.text = line.text.Replace("while wearing the Frost Armor", "ao vestir a armadura Congelada");
			}
			if (item.type == 823)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("+10 defense and 5% increased damage reduction while wearing the Spectre Armor and Hood", "+10 defesa e 5% de aumento na redução de danos ao vestir a armadura de Espectro com o Capuz");
				line.text = line.text.Replace("+20 max mana, 5% increased magic damage and critical strike chance,", "+20 mana máx; 5% de aumento nos danos por magia e chance de acerto crítico mágico");
				line.text = line.text.Replace("and 5% decreased mana usage while wearing the Spectre Armor and Mask", "e 5% de redução no consumo de mana ao vestir a armadura de Espectro com a Máscara");
			}
			if (item.type == 2280)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("+15 defense and 10% increased damage reduction while wearing the Beetle Armor and Shell", "+15 defesa e 10% de aumento na redução dos danos ao vestir a armadura de Besouro com o Casco");
				line.text = line.text.Replace("10% increased melee damage and critical strike chance while wearing the Beetle Armor and Scale Mail", "10% de aumento nos danos físicos e na chance de acerto crítico físico ao vestir a armadura de Besouro com a Armadura de Malha");
			}
			if (item.type == 2494)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("Gills effect and you can move freely through liquids", "Efeito de guelras e você pode mover livremente através de líquidos");
				line.text = line.text.Replace("You fall faster while submerged in liquid", "Você cairá mais rápido enquanto submerso em líquidos");
				line.text = line.text.Replace("20% increased movement speed and 36% increased jump speed", "20% de aumento na velocidade dos movimentos e 36% de aumento na velocidade dos pulos");
			}
			if (item.type == 948)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("+8 defense, 10% increased movement speed,", "+8 defesa, 10% aumento na velocidade dos movimentos,");
				line.text = line.text.Replace("4% increased damage, and 2% increased critical strike chance", "4% de aumento nos danos, e 2% de aumento na chance de acerto crítico");
			}
			if (item.type == 1162)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("+10 defense, 10% increased damage reduction,", "+10 defesa, 10% de aumento na redução de danos,");
				line.text = line.text.Replace("and the Dryad's permanent blessing while wearing the Tiki Armor", "e a bênção permanente da Dríade ao vestir a armadura Tiki");
			}
			if (item.type == 1165)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("At night or during an eclipse, you will gain the following boosts:", "À noite ou durante um eclipse, você receberá os seguintes reforços:");
				line.text = line.text.Replace("10% increased movement speed, 20% increased jump speed,", "10% de aumento na velocidade dos movimentos, 20% de aumento na velocidade dos pulos,");
				line.text = line.text.Replace("+15 defense, 10% increased damage, and 5% increased critical strike chance", "+15 defesa, 10% de aumento na chance de acerto crítico");
			}
			if (item.type == 1797)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("5% increased damage and critical strike chance", "5% de aumento nos danos e na chance de acerto crítico");
			}
			if (item.type == 1830)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("Increased minion knockback and 5% increased minion damage while wearing the Spooky Armor", "Aumento no recuo dos lacaios e 5% de aumento nos danos por lacaios ao vestir a armadura Assustadora");
			}
			if (item.type == 1866)
			{
				line.text = line.text.Replace("Hold DOWN and JUMP to hover", "Segure PARA BAIXO e PULAR para levitar");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("10% increased damage to bows, guns, rocket launchers, and flamethrowers while wearing the Shroomite Armor", "10% de aumento nos danos por arcos, armas, lança-foguetes, e lança-chamas ao vestir a armadura de Cogumelita");
				line.text = line.text.Replace("Boosted weapon type depends on the Shroomite Helmet worn", "O tipo de arma reforçado depende no capacete de Cogumelita equipado");
			}
			if (item.type == 1871)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("+50 max life", "+50 vida máxima");
				line.text = line.text.Replace("Ornaments rain down as you fly", "Ornamentos chovem enquanto você voa");
			}
			if (item.type == 2770)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Average vertical speed", "Velocidade vertical mediana");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("+5 defense, 5% increased damage,", "+5 defesa, 5% de aumento nos danos,");
				line.text = line.text.Replace("10% increased movement speed and 24% increased jump speed", "10% de aumento na velocidade dos movimentos e 24% de aumento na velocidade dos pulos");
			}
			if (item.type == 3468)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Great vertical speed", "Velocidade vertical excelente");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("7% increased melee damage and 3% increased melee critical strike chance", "7% de aumento nos danos por ataque físico e 3% de aumento na chance de acerto crítico físico");
				line.text = line.text.Replace("while wearing the Solar Flare Armor", "ao vestir a armadura do Sol");
			}
			if (item.type == 3471)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Great vertical speed", "Velocidade vertical excelente");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("+1 max minion and 5% increased minion damage while wearing the Stardust Armor", "+1 lacaio máximo e 5% de aumento nos danos por lacaios ao vestir a armadura de Pó das Estrelas");
			}
			if (item.type == 3469)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Hold DOWN and JUMP to hover", "Segure PARA BAIXO e PULAR para levitar");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Good vertical speed", "Velocidade vertical boa");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("3% increased ranged damage and 7% increased ranged critical strike chance", "3% de aumento nos danos por ataque à distância e 7% de aumento na chance de acerto crítico à distância");
				line.text = line.text.Replace("while wearing the Vortex Armor", "ao vestir a armadura do Vórtice");
			}
			if (item.type == 3470)
			{
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Hold DOWN and JUMP to hover", "Segure PARA BAIXO e PULAR para levitar");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Good vertical speed", "Velocidade vertical boa");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
				line.text = line.text.Replace("+20 max mana, 5% increased magic damage and critical strike chance,", "+20 mana máx, 5% de aumento nos danos por magia e na chance de acerto crítico mágico,");
				line.text = line.text.Replace("and 5% decreased mana usage while wearing the Nebula Armor", "e 5% de redução no consumo de mana ao vestir a armadura de Nébula");
			}
			if (item.type == 3883)
			{
				line.text = line.text.Replace("Equipable", "Equipável");
				line.text = line.text.Replace("Allows flight and slow fall", "Permite o voo e desaceleração da queda");
				line.text = line.text.Replace("Hold DOWN and JUMP to hover", "Segure PARA BAIXO e PULAR para levitar");
				line.text = line.text.Replace("Horizontal speed", "Velocidade horizontal");
				line.text = line.text.Replace("Acceleration multiplier", "Multiplicador de aceleração");
				line.text = line.text.Replace("Good vertical speed", "Velocidade vertical boa");
				line.text = line.text.Replace("Flight time", "Tempo de voô");
			}
			//line.text = line.text.Replace("", "");
			List<int> grappins = new List<int>() { 84, 1236, 1237, 1238, 1239, 1240, 1241, 939, 1273, 2585, 2360, 185, 1800, 1915, 437, 3021, 3023, 3020, 3022, 2800, 1829, 1916, 3572, 3623 };
			if (grappins.Contains(item.type))
			{
				line.text = line.text.Replace("Equipable", "Equipável");
				line.text = line.text.Replace("Reach", "Alcance");
				line.text = line.text.Replace("tiles", "peças");
				line.text = line.text.Replace("Launch Velocity", "Velocidade de Lançamento");
				line.text = line.text.Replace("Reelback Velocity", "Velocidade de Retorno");
				line.text = line.text.Replace("Pull Velocity", "Velocidade de Tração");
			}
		}
	}
}