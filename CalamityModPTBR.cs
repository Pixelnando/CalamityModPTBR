using Terraria.ModLoader;
using Terraria.Localization;
using CalamityMod;

namespace CalamityModPTBR
{
    public class CalamityModPTBR : Mod
    {
        public CalamityModPTBR() { }

        public override void PostSetupContent()
        {
            if (ModLoader.GetMod("CalamityMod") != null)
            {
                Mod Calamity = ModLoader.GetMod("CalamityMod");
                if (Calamity != null)
                {
                    string[][] localizations = new string[][]
                    {
                    new string[3]{"SkyOreText","The ground is glittering with cyan light.","O solo brilha com uma luz ciana."},
                    new string[3]{"IceOreText","The ice caves are crackling with frigid energy.","As cavernas de gelo estão estalando com energia frígida."},
                    new string[3]{"PlantOreText","Energized plant matter has formed in the underground.","Matéria vegetal energizada foi formada no subsolo."},
                    new string[3]{"TreeOreText","Fossilized tree bark is bursting through the jungle's mud.","Cascas de árvores fossilizadas estão rompendo a lama da selva."},
                    new string[3]{"AuricOreText","A godly aura has blessed the world's caverns.","Uma aura divina abençoou as cavernas do mundo."},
                    new string[3]{"FutureOreText","A cold and dark energy has materialized in space.","Uma energia fria e escura se materializou no espaço."},
                    new string[3]{"UglyBossText","The Sunken Sea trembles...","O Mar Profundo treme..."},
                    new string[3]{"SteelSkullBossText","A blood red inferno lingers in the night...","Um inferno vermelho de sangue perdura na noite..."},
                    new string[3]{"BrimmyBossText","A protective spell has been lifted from the crags! You can now mine Charred Ore.","Um feitiço de proteção foi retirado dos rochedos! Você agora pode minerar Minério Carbonizado."},
                    new string[3]{"WetWormBossText","The sulphuric sky darkens...","O céu sulfúrico escurece..."},
                    new string[3]{"PlantBossText","The ocean depths are trembling.","As profundezas do oceano estão tremendo."},
                    new string[3]{"BabyBossText","A plague has befallen the Jungle.","Uma praga caiu na Selva."},
                    new string[3]{"MoonBossText","The profaned flame blazes fiercely!","A chama profana arde ferozmente!"},
                    new string[3]{"MoonBossText2","Cosmic terrors are watching...","Terrores cósmicos estão observando..."},
                    new string[3]{"MoonBossText3","The bloody moon beckons...","A lua de sangue chama por você..."},
                    new string[3]{"PlagueBossText","PLAGUE NUKE BARRAGE ARMED, PREPARING FOR LAUNCH!!!","BARRAGEM NUCLEAR DE PRAGA ARMADA, PREPARAR PARA O LANÇAMENTO!!!"},
                    new string[3]{"PlagueBossText2","MISSILES LAUNCHED, TARGETING ROUTINE INITIATED!!!","MÍSSEIS LANÇADOS, ROTINA DE PERSEGUIÇÃO INICIADA!!!"},
                    new string[3]{"ProfanedBossText","The air is burning...","O ar está queimando..."},
                    new string[3]{"ProfanedBossText2","Shrieks are echoing from the dungeon.","Gritos penetrantes ecoam no cabalouço."},
                    new string[3]{"ProfanedBossText3","The calamitous beings have been inundated with bloodstone.","As criaturas calamitosas foram inundadas com pedra sangrenta."},
                    new string[3]{"ProfanedBossText4","The Profaned Goddess has recognised your devotion to purity!","A Deusa Profana reconheceu a sua devoção à puridade!"},
                    new string[3]{"GhostBossText","The abyssal spirits have been disturbed.","Os espíritos abissais foram perturbados."},
                    new string[3]{"GhostBossText2","Wails echo through the dilapidated dungeon halls...","Lamentos ecoam pelos corredores do calabouço arruinado..."},
                    new string[3]{"GhostBossText3","Long-dead prisoners seek their zealous revenge...","Prisioneiros mortos há muito tempo buscam sua vingança zelosa..."},
                    new string[3]{"GhostBossText4","The souls released stir the acidic storms...","As almas liberadas agitam as tempestades ácidas..."},
                    new string[3]{"SCalSummonText", "Do you enjoy going through hell?", "Você gosta de passar pelo inferno?"},
                    new string[3]{"SCalStartText", "You should have just died...", "Você devia ter apenas morrido..."},
                    new string[3]{"SCalBH2Text", "It wasn't too long ago you barely managed to defeat my doppelganger. Quite the failure, wasn't it?", "Não faz muito tempo desde que você mal conseguiu derrotar meu clone. Um grande fracasso, não é?"},
                    new string[3]{"SCalBH3Text", "You've harnessed great power, but you wield it for no one but yourself.", "Você conquistou um grande poder, mas não o exerce para ninguém além de si mesmo."},
                    new string[3]{"SCalBrothersText", "Would you like to meet my family? Horrible, isn't it?", "Você gostaria de conhecer a minha família? Horrível, não é?"},
                    new string[3]{"SCalPhase2Text", "You will suffer greatly.", "Você vai sofrer muito."},
                    new string[3]{"SCalBH4Text", "It's absurd to even think of trying to get away. As long as you live, you will suffer.", "É um absurdo pensar em tentar fugir. Enquanto você estiver vivo, você sofrerá."},
                    new string[3]{"SCalSeekerRingText", "An upstart who recklessly stole and killed their way to power. I wonder, who does that remind me of...?", "Um arrivista que imprudentemente roubou e matou muitos pelo poder. Eu me pergunto, quem isso me lembra...?"},
                    new string[3]{"SCalBH5Text", "You have no stake in this battle. No one gave you any say in this matter!", "Esta batalha não é de seu interesse. Ninguém lhe permitiu dar sua opinião sobre este assunto!"},
                    new string[3]{"SCalSepulcher2Text", "Once the dust has settled and only one remains, if it is you, what value will this have had?!", "Quando tudo se acalmar e só sobrar um de nós, se for você, que valor isto terá tido?!"},
                    new string[3]{"SCalDesparationText1", "Just stop!", "Simplesmente pare!"},
                    new string[3]{"SCalDesparationText2", "I have no future if I lose here.", "Eu não tenho um futuro se eu perder aqui."},
                    new string[3]{"SCalDesparationText3", "Once you have bested me, you will only have one path forward.", "Depois de me superar, você terá apenas um caminho a seguir."},
                    new string[3]{"SCalDesparationText4", "And that path... also has no future.", "E esse caminho... também não tem futuro."},
                    new string[3]{"SCalAcceptanceText1", "Even if he has thrown all else away, his power remains.", "Mesmo que ele tenha jogado tudo fora, seu poder permanece."},
                    new string[3]{"SCalAcceptanceText2", "I have no more energy left to resent him, or you...", "Eu não tenho mais energia para ficar ressentida com ele, ou com você..."},
                    new string[3]{"SCalAcceptanceText3", "It will all be in your hands now.", "Tudo estará em suas mãos agora."},
                    new string[3]{"SCalSummonTextRematch", "If you’re looking for some fourth-degree burns, you’ve got the right person.", "Se você está procurando por queimaduras de quarto grau, você encontrou a pessoa certa."},
                    new string[3]{"SCalStartTextRematch", "When the time comes, would you like to join my creation?", "Quando chegar a hora, você gostaria de se juntar à minha criação?"},
                    new string[3]{"SCalBH2TextRematch", "You’ll still have to work hard for this victory.", "Você ainda terá que se esforçar para esta vitória."},
                    new string[3]{"SCalBH3TextRematch", "I haven’t had such an interesting target dummy to test my magic on in a long time.", "Faz muito tempo que eu não tenho um boneco de treinamento tão interessante para testar minha magia."},
                    new string[3]{"SCalBrothersTextRematch", "Empty shells of their former selves. I doubt even a scrap of their spirits remain.", "Eles são apenas carcaças de seu antigo eu. Duvido que até mesmo um fragmento de seus espíritos permaneça." },
                    new string[3]{"SCalPhase2TextRematch", "Here we go again.", "Aqui vamos nós, novamente."},
                    new string[3]{"SCalBH4TextRematch", "I wonder if you’ve seen these in your nightmares since our first battle?", "Eu me pergunto se você já viu isso em seus pesadelos desde nossa primeira batalha."},
                    new string[3]{"SCalSeekerRingTextRematch", "Your skill hasn't faltered in the least.", "Sua habilidade não esmoreceu nem um pouco."},
                    new string[3]{"SCalBH5TextRematch", "Isn't this exciting?", "Não é emocionante?"},
                    new string[3]{"SCalSepulcher2TextRematch", "Here comes the crawling tomb, one last time.", "Lá vem a tumba rastejante, uma última vez."},
                    new string[3]{"SCalDesparationText1Rematch", "A terrific display, I concede this match to you.", "Uma exibição fantástica, admito esta partida para você."},
                    new string[3]{"SCalDesparationText2Rematch", "No doubt you will face enemies stronger than I.", "Sem dúvida, você enfrentará inimigos mais fortes do que eu."},
                    new string[3]{"SCalDesparationText3Rematch", "I trust you will not make the same mistakes he did.", "Espero que você não comita os mesmos erros que ele."},
                    new string[3]{"SCalDesparationText4Rematch", "I can’t imagine what your future holds now.", "Não consigo imaginar o que o seu futuro reserva para você agora."},
                    new string[3]{"SCalFunnyCheatText", "Go to hell.","Vá para o inferno."},
                    new string[3]{"EdgyBossText","Don't get cocky, kid!","Não fique convencido, pirralho!"},
                    new string[3]{"EdgyBossText2","You think...you can butcher...ME!?","Você acha... que pode... ME EXTERMINAR!?"},
                    new string[3]{"EdgyBossText3","A fatal mistake!","Um erro fatal!"},
                    new string[3]{"EdgyBossText4","Good luck recovering from that!","Boa sorte se recuperando disso!"},
                    new string[3]{"EdgyBossText5","Delicious...","Delicioso..."},
                    new string[3]{"EdgyBossText6","Did that hurt?","Doeu?"},
                    new string[3]{"EdgyBossText7","Nothing personal, kid.","Nada pessoal, pirralho."},
                    new string[3]{"EdgyBossText8","Are you honestly that bad at dodging?","Você é tão ruim assim em se esquivar?"},
                    new string[3]{"EdgyBossText9","Of all my segments to get hit by...","De todos os meus segmentos, você foi atingido por..."},
                    new string[3]{"EdgyBossText10","It's not over yet, kid!","Não acabou ainda, pirralho!"},
                    new string[3]{"EdgyBossText11","A GOD DOES NOT FEAR DEATH!","UM DEUS NÃO TEME A MORTE!"},
                    new string[3]{"EdgyBossText12","You are no god...but I shall feast upon your essence regardless!","Você não é nenhum deus... mas irei me banquetear com a sua essência mesmo assim!"},
                    new string[3]{"DoGBossText","The frigid moon shimmers brightly.","A lua frígida brilha intensamente."},
                    new string[3]{"DoGBossText2","The harvest moon glows eerily.","A lua da colheita brilha sinistramente."},
                    new string[3]{"AstralText","A star has fallen from the heavens!","Uma estrela caiu do céu!"},
                    new string[3]{"AureusBossText","The astral enemies have been empowered!","Os inimigos astrais foram empoderados!"},
                    new string[3]{"AureusBossText2","A faint ethereal click can be heard from the dungeon.","Um leve clique etéreo pode ser ouvido no calabouço."},
                    new string[3]{"AstralBossText","The seal of the stars has been broken! You can now mine Astral Ore.","O selo das estrelas foi quebrado! Você agora pode minerar Minério Astral."},
                    new string[3]{"DeusText","A star-spawned horror tunnels through the astral infection.","Um terror gerado pelas estrelas escava pela infecção astral."},
                    new string[3]{"DeusAltarRejectNightText","The god of the stars rejects your offering. The ritual can only be performed at night.","O deus das estrelas rejeita sua oferta. O ritual só pode ser realizado à noite."},
                    new string[3]{"CalamitasBossText", "You underestimate my power...", "Você subestimou meu poder..."},
                    new string[3]{"CalamitasBossText2","The brothers have been reborn!","Os irmãos renasceram!"},
                    new string[3]{"CalamitasBossText3","Impressive child, most impressive...","Impressionante, criança, muito impressionante..."},
                    new string[3]{"SandSharkText","Something stirs in the warm desert sands...","Algo se agita nas quentes areias do deserto..."},
                    new string[3]{"SandSharkText2","An enormous apex predator approaches...","Um predador ápice se aproxima..."},
                    new string[3]{"SandSharkText3","The desert sand shifts intensely!","A areia do deserto se move intensamente!"},
                    new string[3]{"CryogenBossText","Cryogen is derping out!","Criogênio está ficando louco!"},
                    new string[3]{"DraedonIntroductionText1", "I have waited long for this moment.", "Eu esperei muito por este momento."},
                    new string[3]{"DraedonIntroductionText2", "Your nature fascinates me, for I do not understand it.", "Sua natureza me fascina, pois não a entendo."},
                    new string[3]{"DraedonIntroductionText3", "You will face my creations which have surpassed gods.", "Você enfrentará minhas criações que ultrapassaram os deuses."},
                    new string[3]{"DraedonIntroductionText4", "And you will show me your disposition through battle.", "E você me mostrará a sua disposição através da batalha."},
                    new string[3]{"DraedonIntroductionText5", "Now, choose.", "Agora, escolha."},
                    new string[3]{"DraedonExoPhase1Text1", "Designs improved with time and knowledge are the essence of my work.", "Designs aprimorados com o tempo e o conhecimento são a essência do meu trabalho."},
                    new string[3]{"DraedonExoPhase1Text2", "Through no other method can I approach perfection.", "Por nenhum outro método posso chegar à perfeição."},
                    new string[3]{"DraedonExoPhase2Text1", "Your performance falls neatly within the margins of error.", "Seu desempenho cai perfeitamente dentro das margens de erro."},
                    new string[3]{"DraedonExoPhase2Text2", "That is quite satisfactory. We will proceed to the next phase of testing.", "Isso é muito satisfatório. Avançaremos para a próxima fase de testes."},
                    new string[3]{"DraedonExoPhase3Text1", "Ever since I was alerted to your presence, I have processed your battles in order to make my machines stronger.", "Desde que fui alertado de sua presença, processei suas batalhas para tornar minhas máquinas mais fortes."},
                    new string[3]{"DraedonExoPhase3Text2", "Even now, I monitor your actions. Nothing should escape the bounds of my calculations.", "Mesmo agora, em monitoro as suas ações. Nada deve escapar dos limites dos meus cálculos."},
                    new string[3]{"DraedonExoPhase4Text1", "Curious. Very curious.", "Curioso. Muito curioso."},
                    new string[3]{"DraedonExoPhase4Text2", "You progress steadily against more difficult challenges.", "Você progride constantemente contra desafios cada vez mais difíceis."},
                    new string[3]{"DraedonExoPhase5Text1", "Your nature remains unknown to me. This will not do.", "Sua natureza permanece desconhecida para mim. Isso não é o suficiente."},
                    new string[3]{"DraedonExoPhase5Text2", "...I sought perfection. Fate must favor irony, for that must have been my first mistake.", "...Eu busquei a perfeição. O destino deve favorecer a ironia, pois esse deve ter sido o meu primeiro erro."},
                    new string[3]{"DraedonExoPhase6Text1", "Absurd.", "Absurdo."},
                    new string[3]{"DraedonExoPhase6Text2", "I will no longer let my calculations impede my observation of this battle.", "Não vou mais permitir que meus cálculos impeçam a minha observação desta batalha."},
                    new string[3]{"DraedonExoPhase6Text3", "I shall show you the full fury of my final machine.", "Vou mostrar a você toda a fúria de minha máquina final."},
                    new string[3]{"DraedonAresEnrageText", "How foolish. You cannot escape.", "Que tolice. Você não pode escapar."},
                    new string[3]{"DraedonResummonText", "Make your choice.", "Faça a sua escolha."},
                    new string[3]{"DraedonEndText1", "An unknown factor-a catalyst is what you are.", "Um fator desconhecido -  um catalisador é o que você é."},
                    new string[3]{"DraedonEndText2", "Nearly as alien as I, to this land and its history.", "Quase tão alienígena quanto eu, a esta terra e sua história."},
                    new string[3]{"DraedonEndText3", "...Excuse my introspection. I must gather my thoughts after that display.", "...Desculpe minha introspecção. Devo organizar meus pensamentos após essa exibição."},
                    new string[3]{"DraedonEndText4", "This land has become stale and stiff with blood that has been spilled until now.", "Esta terra se tornou obsoleta e rígida com o sangue que foi derramado até agora."},
                    new string[3]{"DraedonEndText5", "You have also spilled blood, but it may be enough to usher a new age... Of what, I do not know. But it is something I am eager to see.", "Você também derramou sangue, mas pode ser o suficiente para começar uma nova era... Do quê, eu não sei. Mas é algo que estou ansioso para ver."},
                    new string[3]{"DraedonEndText6", "Now. You wish to reach the Tyrant. I cannot assist you in that.", "Então, você deseja alcançar o Tirano. Eu não posso te ajudar nisso."},
                    new string[3]{"DraedonEndText7", "But you have managed before. You will find a way eventually.", "Mas você conseguiu antes. Você encontrará um caminho eventualmente."},
                    new string[3]{"DraedonEndText8", "I must acknowledge your triumph, but I will return now to my machinery.", "Devo reconhecer o seu triunfo, mas voltarei agora ao meu maquinário."},
                    new string[3]{"DraedonEndKillAttemptText", "...Quite unnecessary.", "...Isso foi totalmente desnecessário."},
                    new string[3]{"HardmodeOreTier1Text", "Your world has been blessed with Cobalt and Palladium!", "Seu mundo foi abençoado com o Cobalto e o Paládio!"},
                    new string[3]{"HardmodeOreTier2Text", "Your world has been blessed with Mythril and Orichalcum!", "Seu mundo foi abençoado com o Mithril e o Oricalco!"},
                    new string[3]{"HardmodeOreTier3Text", "Your world has been blessed with Adamantite and Titanium!", "Seu mundo foi abençoado com a Adamantina e o Titânio!"},
                    new string[3]{"HardmodeOreTier4Text", "The hallow has been blessed with consecrated stone!", "O sagrado foi abençoado com pedra consagrada!"},
                    new string[3]{"BloodMoonText","The Blood Moon is rising...","A Lua de Sangue está subindo..."},
                    new string[3]{"DargonBossText","The dark sun awaits.","O sol escuro te espera."},
                    new string[3]{"DargonBossText2","My dragon deems you an unworthy opponent. You must acquire the power of the dark sun to witness his true power.","Meu dragão considera você um oponente indigno. Você deve adquirir o poder do sol escuro para testemunhar o seu verdadeiro poder."},
                    new string[3]{"RevengeText","Revengeance is active.","A Vingança foi ativada."},
                    new string[3]{"RevengeText2","Revengeance is not active.","A Vingança foi desativada."},
                    new string[3]{"DeathText","Death is active, enjoy the fun.","A Morte foi ativada, divirta-se."},
                    new string[3]{"DeathText2","Death is not active, not fun enough for you?","A Morte foi desativada. Não é divertido o suficiente para você?"},
                    new string[3]{"MaliceText", "Malice is active; witness the horror!", "A Malícia foi ativada; testemunhe o terror!"},
                    new string[3]{"MaliceText2", "Malice is not active.", "A Malícia foi desativada."},
                    new string[3]{"ArmageddonText","Bosses will now kill you instantly.","Chefes agora irão matá-lo instantaneamente."},
                    new string[3]{"ArmageddonText2","Bosses will no longer kill you instantly.","Chefes não vão mais matá-lo instantaneamente."},
                    new string[3]{"ArmageddonDodgeDisable", "All of your dodges are now disabled.", "Todas as suas esquivas foram desativadas."},
                    new string[3]{"ArmageddonDodgeEnable", "All of your dodges are now re-enabled.", "Todas as suas esquivas foram reativadas."},
                    new string[3]{"DefiledText","Your soul is mine...","Sua alma é minha..."},
                    new string[3]{"DefiledText2","Your soul is yours once more...","Sua alma é sua novamente..."},
                    new string[3]{"IronHeartText","Iron Heart is active, healing is disabled.","O Coração de Ferro foi ativado, a cura foi desativada."},
                    new string[3]{"IronHeartText2","Iron Heart is not active, healing is restored.","O Coração de Ferro foi desativado, a cura foi restaurada."},
                    new string[3]{"ChangingTheRules","You cannot change the rules now.","Você não pode alterar as regras agora."},
                    new string[3]{"FlameText","The air is getting warmer around you.","O ar está ficando mais quente ao seu redor."},
                    new string[3]{"BossRushStartText","Hmm? Ah, another contender. Very well, may the ritual commence!","Hmm? Ah, outro candidato. Muito bem, que o ritual comece!"},
                    new string[3]{"BossRushTierOneEndText","Hmm? Oh, you're still alive. Unexpected, but don't get complacent just yet.","Hmm? Oh, você ainda está vivo. Inesperado, mas não fique complacente ainda."},
                    new string[3]{"BossRushTierTwoEndText","Hmm? Persistent aren't you? Perhaps you have some hope of prosperity, unlike past challengers.","Hmm? Persistente, não é? Talvez você tenha alguma esperança de prosperidade, ao contrário dos desafiantes anteriores."},
                    new string[3]{"BossRushTierThreeEndText","Hmm? Your perseverance is truly a trait to behold. You've come further than even the demigods in such a short time.","Hmm? Sua perseverança é realmente uma característica a ser observada. Você foi mais longe do que até mesmo os semideuses em tão pouco tempo."},
                    new string[3]{"BossRushTierThreeEndText2","May your skills remain sharp for the last challenges.","Que suas habilidades permaneçam afiadas para os últimos desafios."},
                    new string[3]{"BossRushTierFourEndText","Hmm? So you've made it to the final tier, a remarkable feat enviable by even the mightiest of the gods.","Hmm? Então você chegou no nível final, um feito notável, invejável até mesmo pelo mais poderoso dos deuses."},
                    new string[3]{"BossRushTierFourEndText2","Go forth and conquer 'til the ritual's end!","Vá em frente e conquiste até o fim do ritual!"},
                    new string[3]{"BossRushTierFiveEndText","Hmm? You expected a reward beyond this mere pebble? Patience, the true reward will become apparent in time...","Hmm? Você esperava uma recompensa além desta simples rocha? Paciência, a verdadeira recompensa se tornará aparente com o tempo..."},
                    new string[3]{"BossSpawnText","Something is approaching...","Algo está se aproximando..."},
                    new string[3]{"MeleeLevelUp","Melee weapon proficiency level up!","Proficiência em armas físicas aumentada!"},
                    new string[3]{"MeleeLevelUpFinal","Melee weapon proficiency maxed out!","Proficiência em armas físicas chegou ao máximo!"},
                    new string[3]{"RangedLevelUp","Ranged weapon proficiency level up!","Proficiência em armas à distância aumentada!"},
                    new string[3]{"RangedLevelUpFinal","Ranged weapon proficiency maxed out!","Proficiência em armas à distância chegou ao máximo!"},
                    new string[3]{"MagicLevelUp","Magic weapon proficiency level up!","Proficiência em armas de magia aumentada!"},
                    new string[3]{"MagicLevelUpFinal","Magic weapon proficiency maxed out!","Proficiência em armas de magia chegou ao máximo!"},
                    new string[3]{"SummonLevelUp","Summoner weapon proficiency level up!","Proficiência em armas de invocação aumentada!"},
                    new string[3]{"SummonLevelUpFinal","Summoner weapon proficiency maxed out!","Proficiência em armas de invocação chegou ao máximo!"},
                    new string[3]{"RogueLevelUp","Rogue weapon proficiency level up!","Proficiência em armas ladinas aumentada!"},
                    new string[3]{"RogueLevelUpFinal","Rogue weapon proficiency maxed out!","Proficiência em armas ladinas chegou ao máximo!"},
                    new string[3]{"OpenSunkenSea","The depths of the underground desert are rumbling...","As profundezas do deserto subterrâneo estão estrondeando..."},
                    new string[3]{"SandstormTrigger","The desert wind is blowing furiously!","O vento do deserto está soprando furiosamente!"},
                    new string[3]{"ThirdSageBlessingText","You have been blessed by the Third Sage!","Você foi abençoado pelo Terceiro Sábio!"},
                    new string[3]{"ThirdSageBlessingText2","The Third Sage has rescinded its blessing...","O Terceiro Sábio rescindiu a sua bênção..."},
                    new string[3]{"AprilFools","The LORDE is approaching...","O LORDE está se aproximando..."},
                    new string[3]{"AprilFools2","A boomer awaits...","Um boomer aguarda..."},
                    new string[3]{"AcidRainStart","A toxic downpour falls over the wasteland seas!","Uma chuva tóxica cai sobre os mares devastados!"},
                    new string[3]{"AcidRainEnd","The sulphuric skies begin to clear...","Os céus sulfúricos começam a clarear..."}
                    };

                    /// Accessories
                    // Movement
                    Calamity.GetItem("AbyssalDivingGear").DisplayName.AddTranslation(GameCulture.Portuguese, "Equipamento de Mergulho Abissal");
                    Calamity.GetItem("AbyssalDivingGear").Tooltip.AddTranslation(GameCulture.Portuguese, "Reduz o dano causado pela pressão do abismo enquanto sem fôlego\nRemove o efeito de sangramento causado pelo abismo\nOferece a capacidade de nadar e aumenta consideravelmente o fôlego embaixo d\u0027água\nFornece luz debaixo d\u0027água e maior mobilidade no gelo\nFornece uma quantidade razoável de luz no abismo\nReduz bastante a perda de fôlego no abismo");
                    Calamity.GetItem("AeroStone").DisplayName.AddTranslation(GameCulture.Portuguese, "Rocha Aérea");
                    Calamity.GetItem("AeroStone").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma das relíquias antigas\nAumenta o tempo de voô, velocidade dos movimentos em 10% e velocidade dos pulos em 10%");
                    Calamity.GetItem("AngelTreads").DisplayName.AddTranslation(GameCulture.Portuguese, "Passos Angelicais");
                    Calamity.GetItem("AngelTreads").Tooltip.AddTranslation(GameCulture.Portuguese, "Velocidade extrema!\n36% de aumento na aceleração de corrida\nMaior tempo de voô\nMaior mobilidade no gelo\nPermite andar sobre a água e a lava\nImunidade temporária à lava");
                    Calamity.GetItem("AquaticEmblem").DisplayName.AddTranslation(GameCulture.Portuguese, "Emblema Aquático");
                    Calamity.GetItem("AquaticEmblem").Tooltip.AddTranslation(GameCulture.Portuguese, "A maioria dos inimigos do oceano tornam-se amigáveis e fornece respiração embaixo d'água\nEstar debaixo d'água aumenta lentamente sua defesa ao longo do tempo, mas também diminui a sua velocidade de movimento\nO impulso de defesa e a redução da velocidade de movimento desaparecem lentamente fora d\u0027água\nO impulso máximo de defesa é 50, a redução máxima da velocidade de movimento é 10%\nFornece uma quantidade pequena de luz no abismo\nReduz razoavelmente a perda de fôlego no abismo");
                    Calamity.GetItem("AureateWings").DisplayName.AddTranslation(GameCulture.Portuguese, "Reforço Áureo");
                    Calamity.GetItem("AureateWings").Tooltip.AddTranslation(GameCulture.Portuguese, "Velocidade máxima com estilo!\nVelocidade horizontal: 8\nMultiplicador de aceleração: 1.5\nVelocidade vertical boa\nTempo de voô: 80\n10% de aumento na velocidade dos movimentos ao vestir a Armadura do Ladrão");
                    Calamity.GetItem("CelestialTracers").DisplayName.AddTranslation(GameCulture.Portuguese, "Rastreadores Celestiais");
                    Calamity.GetItem("CelestialTracers").Tooltip.AddTranslation(GameCulture.Portuguese, "Levando a velocidade AO ALÉM!\nConta como asas\nVelocidade horizontal: 12\nMultiplicador de aceleração: 3\nVelocidade vertical excelente\nTempo de voô: 280\n50% de aumento na aceleração de corrida\nMaior mobilidade no gelo\nPermite andar sobre a água e a lava\nImunidade temporária à lava\nSer atingido por mais de 200 de dano o deixará imune por um longo período de tempo");
                    Calamity.GetItem("DrewsWings").DisplayName.AddTranslation(GameCulture.Portuguese, "Asas de Drew");
                    Calamity.GetItem("DrewsWings").Tooltip.AddTranslation(GameCulture.Portuguese, "Absolutamente fabulosas\nVelocidade horizontal: 12\nMultiplicador de aceleração: 3\nVelocidade vertical excelente\nTempo de voô: 361");
                    Calamity.GetItem("ElysianTracers").DisplayName.AddTranslation(GameCulture.Portuguese, "Rastreadores do Elísio");
                    Calamity.GetItem("ElysianTracers").Tooltip.AddTranslation(GameCulture.Portuguese, "Velocidade ridícula!\nConta como asas\nVelocidade horizontal: 10.5\nMultiplicador de aceleração: 2.75\nVelocidade vertical ótima\nTempo de voô: 180\n36% de aumento na aceleração de corrida\nMaior mobilidade no gelo\nPermite andar sobre a água e a lava\nImunidade temporária à lava");
                    Calamity.GetItem("ElysianWings").DisplayName.AddTranslation(GameCulture.Portuguese, "Asas do Elísio");
                    Calamity.GetItem("ElysianWings").Tooltip.AddTranslation(GameCulture.Portuguese, "Abençoadas pela Chama Profana\nVelocidade horizontal: 9.75\nMultiplicador de aceleração: 2.7\nVelocidade vertical ótima\nTempo de voô: 240\nImunidade temporária à lava e 15% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("XerocWings").DisplayName.AddTranslation(GameCulture.Portuguese, "Asas do Êxodo");
                    Calamity.GetItem("XerocWings").Tooltip.AddTranslation(GameCulture.Portuguese, "Pulsando com um batimento cardíaco alienígena\nVelocidade horizontal: 9\nMultiplicador de aceleração: 2.5\nVelocidade vertical boa\nTempo de voô: 180\n5% de aumento nos danos por ataques ladinos e na chance de ataque crítico ao vestir a Armadura Empírica");
                    Calamity.GetItem("GiantShell").DisplayName.AddTranslation(GameCulture.Portuguese, "Casco Gigante");
                    Calamity.GetItem("GiantShell").Tooltip.AddTranslation(GameCulture.Portuguese, "15% de redução na velocidade dos movimentos\nSofrer um golpe fará você se mover muito rápido por um curto período de tempo");
                    Calamity.GetItem("DiscordianWings").DisplayName.AddTranslation(GameCulture.Portuguese, "Manto Hadal");
                    Calamity.GetItem("DiscordianWings").Tooltip.AddTranslation(GameCulture.Portuguese, "Alimentado pela fúria das profundezas\nVelocidade horizontal: 7.75\nMultiplicador de aceleração: 1.5\nVelocidade vertical mediana\nTempo de voô: 180\n5% de aumento nos danos ao vestir a Armadura Hidrotérmica");
                    Calamity.GetItem("HadarianWings").DisplayName.AddTranslation(GameCulture.Portuguese, "Asas Hadarianas");
                    Calamity.GetItem("HadarianWings").Tooltip.AddTranslation(GameCulture.Portuguese, "Alimentado pela Infecção Astral\nSegure para baixo para flutuar durante o voô, estendendo muito a duração do voô\nVelocidade horizontal: 9\nMultiplicador de aceleração: 1.75\nVelocidade vertical boa\nTempo de voô: 120\n10% de aumento na velocidade dos movimentos e na velocidade dos pulos ao vestir a Armadura Astral");
                    Calamity.GetItem("HarpyRing").DisplayName.AddTranslation(GameCulture.Portuguese, "Anel de Harpia");
                    Calamity.GetItem("HarpyRing").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento na velocidade dos movimentos\nAumenta o tempo máximo de voô em 25% ");
                    Calamity.GetItem("IronBoots").DisplayName.AddTranslation(GameCulture.Portuguese, "Botas de Ferro");
                    Calamity.GetItem("IronBoots").Tooltip.AddTranslation(GameCulture.Portuguese, "Permite que você caia mais rápido em líquidos");
                    Calamity.GetItem("MOAB").DisplayName.AddTranslation(GameCulture.Portuguese, "MOAB");
                    Calamity.GetItem("MOAB").Tooltip.AddTranslation(GameCulture.Portuguese, "A mãe de todos os balões\nConta como asas\nVelocidade horizontal: 6.5\nMultiplicador de aceleração: 1\nVelocidade vertical boa\nTempo de voô: 75\n10% de aumento na velocidade dos pulos e permite o pulo automático\nConcede ao jogador saltos no ar de nuvem, nevasca e tempestade de areia");
                    Calamity.GetItem("OceanCrest").DisplayName.AddTranslation(GameCulture.Portuguese, "Crista do Oceano");
                    Calamity.GetItem("OceanCrest").Tooltip.AddTranslation(GameCulture.Portuguese, "A maioria dos inimigos do oceano tornam-se amigáveis e fornece respiração embaixo d'água");
                    Calamity.GetItem("InfinityBoots").DisplayName.AddTranslation(GameCulture.Portuguese, "Rastreadores Serafim");
                    Calamity.GetItem("InfinityBoots").Tooltip.AddTranslation(GameCulture.Portuguese, "Velocidade ridícula!\nConta como asas\nVelocidade horizontal: 9\nMultiplicador de aceleração: 2.5\nVelocidade vertical boa\nTempo de voô: 140\n24% de aumento na aceleração de corrida\nMaior mobilidade no gelo\nPermite andar sobre a água e a lava\nImunidade temporária à lava");
                    Calamity.GetItem("SilvaWings").DisplayName.AddTranslation(GameCulture.Portuguese, "Asas de Silva");
                    Calamity.GetItem("SilvaWings").Tooltip.AddTranslation(GameCulture.Portuguese, "As mais puras da natureza\nVelocidade horizontal: 11\nMultiplicador de aceleração: 2.8\nVelocidade vertical excelente\nTempo de voô: 270\nO revivimento Silva cura você até a metade da vida ao usar a armadura de Silva");
                    Calamity.GetItem("SkylineWings").DisplayName.AddTranslation(GameCulture.Portuguese, "Asas do Horizonte");
                    Calamity.GetItem("SkylineWings").Tooltip.AddTranslation(GameCulture.Portuguese, "Velocidade horizontal: 6.25\nMultiplicador de aceleração: 1\nVelocidade vertical mediana\nTempo de voô: 80\n10% de aumento na velocidade dos pulos ao vestir a armadura Aérea");
                    Calamity.GetItem("SoulofCryogen").DisplayName.AddTranslation(GameCulture.Portuguese, "Alma do Criogênio");
                    Calamity.GetItem("SoulofCryogen").Tooltip.AddTranslation(GameCulture.Portuguese, "A magia do antigo castelo de gelo é sua\nConta como asas\nVelocidade horizontal: 6.25\nMultiplicador de aceleração: 1\nVelocidade vertical mediana\nTempo de voô: 120\n7% de aumento em todos os danos\nTodos os ataques físicos e projéteis causam queimadura de gelo\nGelo chove enquanto você voa");
                    Calamity.GetItem("StarlightWings").DisplayName.AddTranslation(GameCulture.Portuguese, "Asas da Luz Estelar");
                    Calamity.GetItem("StarlightWings").Tooltip.AddTranslation(GameCulture.Portuguese, "Asas do Rouxinol\nVelocidade horizontal: 7.5\nMultiplicador de aceleração: 1\nVelocidade vertical mediana\nTempo de voô: 150\n5% de aumento nos danos e na chance de ataque crítico ao vestir a Armadura de Dédalo");
                    Calamity.GetItem("StatisNinjaBelt").DisplayName.AddTranslation(GameCulture.Portuguese, "Cinto Ninja de Statis");
                    Calamity.GetItem("StatisNinjaBelt").Tooltip.AddTranslation(GameCulture.Portuguese, "12% de aumento na velocidade dos pulos e permite saltos constantes\nAumenta a resistência a danos por queda em 35 blocos\nPode escalar paredes, correr, e esquivar de ataques\nO desvio tem um tempo de recarga de 90 segundos\nEste tempo de recarga é compartilhado com todos os outros desvios e reflexos");
                    Calamity.GetItem("StatisBeltOfCurses").DisplayName.AddTranslation(GameCulture.Portuguese, "Faixa do Vazio de Statis");
                    Calamity.GetItem("StatisBeltOfCurses").Tooltip.AddTranslation(GameCulture.Portuguese, "12% de aumento na velocidade dos pulos e permite saltos constantes\nFornece imunidade ao dano de queda\nPode escalar paredes, correr, e esquivar de ataques\nO desvio tem um tempo de recarga de 90 segundos\nEste tempo de recarga é compartilhado com todos os outros desvios e reflexos\nUm rastro de foices teleguiadas é deixado ao correr");
                    Calamity.GetItem("TarragonWings").DisplayName.AddTranslation(GameCulture.Portuguese, "Asas de Estragão");
                    Calamity.GetItem("TarragonWings").Tooltip.AddTranslation(GameCulture.Portuguese, "Nascido da selva\nVelocidade horizontal: 9.5\nMultiplicador de aceleração: 2.5\nVelocidade vertical ótima\nTempo de voô: 250\n+15 defesa e +2 regeneração de vida ao vestir a Armadura de Estragão");
                    Calamity.GetItem("VitalJelly").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia Vital");
                    Calamity.GetItem("VitalJelly").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento na velocidade dos movimentos e na velocidade dos pulos");

                    // Restorative
                    Calamity.GetItem("BloodPact").DisplayName.AddTranslation(GameCulture.Portuguese, "Pacto Sanguíneo");
                    Calamity.GetItem("BloodPact").Tooltip.AddTranslation(GameCulture.Portuguese, "Dobra sua vida máxima\nPermite que você seja criticamente acertado 25% das vezes\nApós um acerto crítico, você ganha vários efeitos por dez segundos\nQuaisquer poções de cura consumidas durante este período curam 50% a mais de vida");
                    Calamity.GetItem("BloodflareCore").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo das Chamas Sangrentas");
                    Calamity.GetItem("BloodflareCore").Tooltip.AddTranslation(GameCulture.Portuguese, "Você perde até metade de sua defesa após sofrer danos\nA defesa perdida se regenera com o tempo\nVocê ganha 1 de vida para cada 1 defesa ganha enquanto ela regenera");
                    Calamity.GetItem("GrandGelatin").DisplayName.AddTranslation(GameCulture.Portuguese, "Grande Gelatina");
                    Calamity.GetItem("GrandGelatin").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento na velocidade dos movimentos e na velocidade dos pulos\n+20 vida e mana máxima\nFicar parado aumenta a regeneração de vida e mana");
                    Calamity.GetItem("LifeJelly").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia da Vida");
                    Calamity.GetItem("LifeJelly").Tooltip.AddTranslation(GameCulture.Portuguese, "+20 vida máxima\nFicar parado aumenta a regeneração de vida");
                    Calamity.GetItem("ManaJelly").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia de Mana");
                    Calamity.GetItem("ManaJelly").Tooltip.AddTranslation(GameCulture.Portuguese, "+20 mana máxima\nFicar parado aumenta a regeneração de mana");
                    Calamity.GetItem("RadiantOoze").DisplayName.AddTranslation(GameCulture.Portuguese, "Lodo Radiante");
                    Calamity.GetItem("RadiantOoze").Tooltip.AddTranslation(GameCulture.Portuguese, "Você emite luz e regenera vida mais rapidamente à noite");

                    // Combat
                    // Offensive
                    Calamity.GetItem("AbyssalAmulet").DisplayName.AddTranslation(GameCulture.Portuguese, "Amuleto Abissal");
                    Calamity.GetItem("AbyssalAmulet").Tooltip.AddTranslation(GameCulture.Portuguese, "Ataques causam o efeito negativo Pressão das profundezas\nOferece imunidade ao efeito Pressão das profundezas\nEnquanto estiver no abismo, você ganha 10% de aumento na vida máxima");
                    Calamity.GetItem("AbyssalMirror").DisplayName.AddTranslation(GameCulture.Portuguese, "Espelho Abissal");
                    Calamity.GetItem("AbyssalMirror").Tooltip.AddTranslation(GameCulture.Portuguese, "A luz não atinge as profundezas do oceano\nReduz a agressão dos inimigos significantemente, até mesmo no abismo\nFurtividade gera 30% mais rápido enquanto parado e 20% mais rápido enquanto se move\nConcede a capacidade de se esquivar de ataques, liberando uma nuvem de fluido lumenil que danifica e atordoa os inimigos próximos\nEsquivar-se de um ataque concece muita furtividade mas tem um tempo de recarga de 90 segundos\nEste tempo de recarga é compartilhado com todos os outros desvios e reflexos");
                    Calamity.GetItem("AmalgamatedBrain").DisplayName.AddTranslation(GameCulture.Portuguese, "Cérebro Amalgamado");
                    Calamity.GetItem("AmalgamatedBrain").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos\nSombra cai quando você é atingido\nVocê confundirá os inimigos próximos após ser atingido");
                    Calamity.GetItem("AmidiasPendant").DisplayName.AddTranslation(GameCulture.Portuguese, "Pingente de Amidias");
                    Calamity.GetItem("AmidiasPendant").Tooltip.AddTranslation(GameCulture.Portuguese, "Fragmentos que podem brevemente atordoar os inimigos choverão periodicamente");
                    Calamity.GetItem("AngelicAlliance").DisplayName.AddTranslation(GameCulture.Portuguese, "Aliança Angelical");
                    Calamity.GetItem("AngelicAlliance").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoque a força dos céus para fortalecer seus ataques e lacaios\nCoragem, Iluminação, Bem-aventurança. Unidos no Julgamento\n+2 lacaios máximos, 15% de aumento nos danos por invocação e 8% de aumento no dano de todas as outras classes\nA regeneração de vida é aumentada enquanto pulando\nEsta linha é modificada no código abaixo. Se você consegue ler isto, alguém provavelmente fez algo de errado (foi o Ben)\nEnquanto estiver sob os efeitos da Bênção Divina, para cada lacaio que você tiver, um arcanjo será invocado para ajudá-lo no combate\nCada anjo invocado irá curar você instantaneamente por dois de vida\nTodos os ataques de lacaios infligem Fogo banidor e você recebe um aumento constante de vida de quatro de vida por segundo\nEste efeito tem um tempo de recarga de 1 minuto");
                    Calamity.GetItem("DaedalusEmblem").DisplayName.AddTranslation(GameCulture.Portuguese, "Emblema de Artemis");
                    Calamity.GetItem("DaedalusEmblem").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por ataque à distância, 5% de aumento na chance de acerto crítico à distância, e 20% de redução no consumo de munição\n5 de aumento na defesa, 2 de aumento na regeneração de vida, e 15% de aumento na velocidade da picareta");
                    Calamity.GetItem("BadgeofBravery").DisplayName.AddTranslation(GameCulture.Portuguese, "Insígnia da Bravura");
                    Calamity.GetItem("BadgeofBravery").Tooltip.AddTranslation(GameCulture.Portuguese, "15% de aumento na velocidade do ataque físico\nAumenta os danos por ataque físico e crítico físico em 5%\n+5 de perfuração de blindagem");
                    Calamity.GetItem("BloodstainedGlove").DisplayName.AddTranslation(GameCulture.Portuguese, "Luva Manchada de Sangue");
                    Calamity.GetItem("BloodstainedGlove").Tooltip.AddTranslation(GameCulture.Portuguese, "Ataques furtivos têm +10 perfuração de blindagem e curam 1 de vida");
                    Calamity.GetItem("BloodyWormScarf").DisplayName.AddTranslation(GameCulture.Portuguese, "Cachecol de Verme Sangrento");
                    Calamity.GetItem("BloodyWormScarf").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento na redução dos danos e estatísticas físicas aumentadas");
                    Calamity.GetItem("BloodyWormTooth").DisplayName.AddTranslation(GameCulture.Portuguese, "Dente de Verme Sangrento");
                    Calamity.GetItem("BloodyWormTooth").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento na redução dos danos e estatísticas físicas aumentadas\n10% de aumento na redução dos danos e estatísticas físicas quando abaixo de 50% de vida");
                    Calamity.GetItem("BlunderBooster").DisplayName.AddTranslation(GameCulture.Portuguese, "Reforço da Enganação");
                    Calamity.GetItem("BlunderBooster").Tooltip.AddTranslation(GameCulture.Portuguese, "12% de aumento nos danos por ataques ladinos e 15% de aumento na velocidade dos projéteis ladinos\nFurtividade gera 10% mais rápido\nInvoca uma aura de relâmpago vermelha para cercar o jogador e eletrificar os inimigos próximos\nLINHA DA DICA AQUI");
                    Calamity.GetItem("Calamity").DisplayName.AddTranslation(GameCulture.Portuguese, "Calamidade");
                    Calamity.GetItem("Calamity").Tooltip.AddTranslation(GameCulture.Portuguese, "Incendeia o seu cursor com as chamas da Bruxa, invocando um sigilo ao seu redor\nInimigos que tocam no sigilo recebem danos imensos e são infligidos com o Feitiço de Vulnerabilidade\nEquipe em um espaço social para alterar o cursor sem causar danos");
                    Calamity.GetItem("ChaosStone").DisplayName.AddTranslation(GameCulture.Portuguese, "Rocha do Caos");
                    Calamity.GetItem("ChaosStone").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma das relíquias antigas\nEnjoo por mana por poções de mana é substituído por Queimadura por mana\nQueimadura por mana causa danos ao longo do tempo em relação à intensidade do efeito negativo");
                    Calamity.GetItem("CoinofDeceit").DisplayName.AddTranslation(GameCulture.Portuguese, "Moeda do Engano");
                    Calamity.GetItem("CoinofDeceit").Tooltip.AddTranslation(GameCulture.Portuguese, "Ataques furtivos gastam apenas 75% de sua furtividade máxima\n6% de aumento na chance de ataque ladino crítico");
                    Calamity.GetItem("CorrosiveSpine").DisplayName.AddTranslation(GameCulture.Portuguese, "Coluna Corrosiva");
                    Calamity.GetItem("CorrosiveSpine").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento na velocidade dos movimentos\nTodas as armas ladinas causam veneno e geram nuvens ao atingir o inimigo\nVocê libera várias nuvens para todos os lados ao sofrer danos");
                    Calamity.GetItem("CounterScarf").DisplayName.AddTranslation(GameCulture.Portuguese, "Cachecol do Contra Ataque");
                    Calamity.GetItem("CounterScarf").Tooltip.AddTranslation(GameCulture.Portuguese, "Acertos físicos verdadeiros causam 10% a mais de dano\nPermite correr; correr em um ataque fará com que você se desvie dele\nDepois de um desvio bem-sucedido, você deve esperar 15 segundos antes de poder desviar novamente\nEste tempo de recarga será duas vezes mais longo se você possuir Estado de caos\nEnquanto estiver recarregando, o Estado de caos durará duas vezes mais");
                    Calamity.GetItem("DaawnlightSpiritOrigin").DisplayName.AddTranslation(GameCulture.Portuguese, "Origem do Espírito de Daawnlight");
                    Calamity.GetItem("DaawnlightSpiritOrigin").Tooltip.AddTranslation(GameCulture.Portuguese, "Todos os inimigos e chefes próximos são marcados com alvos\nAtaques à distância que atingem um alvo sempre acertam criticamente e causam danos enormes\nQuando um alvo é atingido, ele desaparece e um novo aparece em outro lugar\nExplosões ou projéteis grandes não podem atingir os alvos\nConverte todos os aumentos de chance de acerto crítico à distância em dano de acerto crítico extra\nTodas as armas de ataque à distância causarão ainda mais danos por ataque crítico quanto mais lentas elas são\nInvoca um espírito heróico de outro mundo se a visibilidade do acessório estiver ativada\n'Uma vertente de um cosmos perdido permanece, esperando por seu mestre'");
                    Calamity.GetItem("DarkGodsSheath").DisplayName.AddTranslation(GameCulture.Portuguese, "Bainha do Deus das Trevas");
                    Calamity.GetItem("DarkGodsSheath").Tooltip.AddTranslation(GameCulture.Portuguese, "+20 furtividade máxima\nA regeneração furtiva móvel acelera se você não estiver atacando\nAtaques furtivos têm 100% de chance de acerto crítico\nAtaques furtivos gastam apenas 50% de sua furtividade máxima\n6% de aumento nos danos por ataques ladinos, e 6% de aumento na chance de ataque ladino crítico");
                    Calamity.GetItem("DarkSunRing").DisplayName.AddTranslation(GameCulture.Portuguese, "Anel do Sol Escuro");
                    Calamity.GetItem("DarkSunRing").Tooltip.AddTranslation(GameCulture.Portuguese, "Contém o poder do sol escuro\n12% de aumento nos danos e na velocidade do ataque físico\n+1 regeneração de vida, 15% de aumento na velocidade da picareta, e +2 lacaios máximos\nAumenta o recuo dos lacaios\nDurante o dia, o jogador tem +3 regeneração de vida\nDurante a noite o jogador tem +15 de defesa\nAmbos os bônus são concedidos durante um eclipse");
                    Calamity.GetItem("DimensionalSoulArtifact").DisplayName.AddTranslation(GameCulture.Portuguese, "Artefato da Alma Dimensional");
                    Calamity.GetItem("DimensionalSoulArtifact").Tooltip.AddTranslation(GameCulture.Portuguese, "Poder\nAumenta todos os danos em 25%, mas a que custo?\nAumenta todos os danos recebidos em 15% ");
                    Calamity.GetItem("DraedonsHeart").DisplayName.AddTranslation(GameCulture.Portuguese, "Coração de Draedon");
                    Calamity.GetItem("DraedonsHeart").Tooltip.AddTranslation(GameCulture.Portuguese, "Reduz a quantidade de dano de defesa recebido em 50%\nFicar parado regenera a sua vida rapidamente, reduz o seu dano por 50% e aumenta a sua defesa em 75%\nNanomáquinas, filho");
                    Calamity.GetItem("DragonScales").DisplayName.AddTranslation(GameCulture.Portuguese, "Escamas de Dragão");
                    Calamity.GetItem("DragonScales").Tooltip.AddTranslation(GameCulture.Portuguese, "Apenas um dragão vivo contém um verdadeiro tesouro\nProjéteis ladinos criam bolas de fogo lentas enquanto viajam\nAtaques furtivos criam infernados na morte\n10% de aumento na velocidade máxima e na aceleração");
                    Calamity.GetItem("DynamoStemCells").DisplayName.AddTranslation(GameCulture.Portuguese, "Dínamo de Células-tronco");
                    Calamity.GetItem("DynamoStemCells").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento na velocidade dos movimentos\nArmas de ataque à distância têm a chance de atirar pequenos voadores");
                    Calamity.GetItem("EclipseMirror").DisplayName.AddTranslation(GameCulture.Portuguese, "Espelho do Eclipse");
                    Calamity.GetItem("EclipseMirror").Tooltip.AddTranslation(GameCulture.Portuguese, "Seu reflexo não mostra nada além de escuridão\n+20 furtividade máxima\n6% de aumento nos danos por ataques ladinos, e 6% de aumento na chance de ataque ladino crítico\nReduz vastamente a agressão dos inimigos, até mesmo no abismo\nFurtividade gera 20% mais rápido enquanto parado\nA generação furtiva móvel acelera exponencialmente se você não estiver atacando\nAtaques furtivos têm 100% de chance de acerto crítico\nAtaques furtivos gastam apenas 50% de sua furtividade máxima\nConcede a capacidade de se esquivar de ataques em uma explosão de luz do sol escuro que inflige danos extremos em uma ampla área\nEsquivar-se de um ataque concece furtividade cheia mas tem um tempo de recarga de 90 segundos\nEste tempo de recarga é compartilhado com todos os outros desvios e reflexos");
                    Calamity.GetItem("EldritchSoulArtifact").DisplayName.AddTranslation(GameCulture.Portuguese, "Artefato da Alma Sobrenatural");
                    Calamity.GetItem("EldritchSoulArtifact").Tooltip.AddTranslation(GameCulture.Portuguese, "Sabedoria\nAumenta a velocidade do ataque físico em 10%, velocidade à distância em 25%, dano ladino em 15%, lacaios máximos em 2, e reduz o custo de mana em 15%");
                    Calamity.GetItem("ElectriciansGlove").DisplayName.AddTranslation(GameCulture.Portuguese, "Luva do Eletricista");
                    Calamity.GetItem("ElectriciansGlove").Tooltip.AddTranslation(GameCulture.Portuguese, "Os ataques furtivos invocam faíscas ao atingir o inimigo\nAtaques furtivos têm +20 perfuração da blindagem, causam 10% a mais de dano, e curam 1 de vida");
                    Calamity.GetItem("ElementalGauntlet").DisplayName.AddTranslation(GameCulture.Portuguese, "Manopla Elemental");
                    Calamity.GetItem("ElementalGauntlet").Tooltip.AddTranslation(GameCulture.Portuguese, "Ataques e projéteis físicos causam a maioria dos efeitos negativos\n15% de aumento na velocidade de ataque físico, no dano, e 5% de aumento na chance de acerto crítico em ataque físico\n20% de aumento nos danos por ataques físicos verdadeiros\nImunidade temporária à lava\nMaior recuo do ataque físico");
                    Calamity.GetItem("ElementalQuiver").DisplayName.AddTranslation(GameCulture.Portuguese, "Aljava Elementar");
                    Calamity.GetItem("ElementalQuiver").Tooltip.AddTranslation(GameCulture.Portuguese, "15% de aumento nos danos por ataque à distância, 5% de aumento na chance de acerto crítico à distância, e 20% de redução no consumo de munição\n5 de aumento na defesa, 2 de aumento na regeneração de vida, e 15% de aumento na velocidade da picareta\nAumenta muito a velocidade das flechas e concece 20% de chance de não consumir flechas");
                    Calamity.GetItem("EtherealExtorter").DisplayName.AddTranslation(GameCulture.Portuguese, "Extorsor Etéreo");
                    Calamity.GetItem("EtherealExtorter").Tooltip.AddTranslation(GameCulture.Portuguese, "Projéteis ladinos explodem em almas teleguiadas na morte\n10% de aumento no danos por ataque ladino e +10 furtividade máxima, no entanto regeneração de vida diminuída");
                    Calamity.GetItem("EtherealTalisman").DisplayName.AddTranslation(GameCulture.Portuguese, "Talismã Etéreo");
                    Calamity.GetItem("EtherealTalisman").Tooltip.AddTranslation(GameCulture.Portuguese, "15% de aumento nos danos por magia, 5% de aumento na chance de acerto crítico mágico, e 10% de redução no consumo de mana\n+150 mana máxima\nAumenta o alcance de coleta das estrelas de mana\nVocê utiliza poções de mana automaticamente quando necessário se a visiblidade estiver ligada");
                    Calamity.GetItem("EvasionScarf").DisplayName.AddTranslation(GameCulture.Portuguese, "Cachecol da Evasão");
                    Calamity.GetItem("EvasionScarf").Tooltip.AddTranslation(GameCulture.Portuguese, "Acertos físicos verdadeiros causam 15% a mais de dano\nPermite correr; correr em um ataque fará com que você se desvie dele\nDepois de um desvio bem-sucedido, você deve esperar 13 segundos antes de poder desviar novamente\nEste tempo de recarga será 50 por cento mais longo se você possuir Estado de caos\nEnquanto estiver recarregando, o Estado de caos durará 50 por cento mais");
                    Calamity.GetItem("FeatherCrown").DisplayName.AddTranslation(GameCulture.Portuguese, "Coroa de Penas");
                    Calamity.GetItem("FeatherCrown").Tooltip.AddTranslation(GameCulture.Portuguese, "15% de aumento na velocidade dos projéteis ladinos\nAtaques furtivos fazem com que penas caiam dos céus ao atingir um inimigo");
                    Calamity.GetItem("FilthyGlove").DisplayName.AddTranslation(GameCulture.Portuguese, "Luva Suja");
                    Calamity.GetItem("FilthyGlove").Tooltip.AddTranslation(GameCulture.Portuguese, "Ataques furtivos têm +10 perfuração da blindagem e causam 10% a mais de dano");
                    Calamity.GetItem("FrostFlare").DisplayName.AddTranslation(GameCulture.Portuguese, "Chama Congelada");
                    Calamity.GetItem("FrostFlare").Tooltip.AddTranslation(GameCulture.Portuguese, "Todos os ataques físicos e projéteis causam queimadura de gelo\nImunidade a queimadura de gelo, resfriado, e congelado\nEstar acima de 75% de vida concede ao jogador 10% de aumento nos danos\nEstar abaixo de 25% de vida concede ao jogador 10 de defesa e 15% de velocidade dos movimentos máxima e aceleração\nGrants resistance against cold attacks");
                    Calamity.GetItem("FungalSymbiote").DisplayName.AddTranslation(GameCulture.Portuguese, "Simbionte Fúngico");
                    Calamity.GetItem("FungalSymbiote").Tooltip.AddTranslation(GameCulture.Portuguese, "Várias armas físicas emitem cogumelos em alcance físico verdadeiro\nAcertos físicos verdadeiros causam 15% a mais de dano");
                    Calamity.GetItem("Gehenna").DisplayName.AddTranslation(GameCulture.Portuguese, "Geena");
                    Calamity.GetItem("Gehenna").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança bolas de fogo de enxofre do céu ocasionalmente");
                    Calamity.GetItem("GladiatorsLocket").DisplayName.AddTranslation(GameCulture.Portuguese, "Medalhão do Gladiador");
                    Calamity.GetItem("GladiatorsLocket").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca dois espíritos espada para proteger você");
                    Calamity.GetItem("GloveOfPrecision").DisplayName.AddTranslation(GameCulture.Portuguese, "Luva da Precisão");
                    Calamity.GetItem("GloveOfPrecision").Tooltip.AddTranslation(GameCulture.Portuguese, "Diminui a velocidade de ataques ladinos em 20% mas aumenta o dano e crítico em 12% e velocidade do projétil em 25%");
                    Calamity.GetItem("GloveOfRecklessness").DisplayName.AddTranslation(GameCulture.Portuguese, "Luva da Imprudência");
                    Calamity.GetItem("GloveOfRecklessness").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a velocidade de ataques ladinos em 20% mas diminui o dano em 10%\nAdiciona imprecisão a armas ladinas");
                    Calamity.GetItem("GodlySoulArtifact").DisplayName.AddTranslation(GameCulture.Portuguese, "Artefato da Alma Sagrada");
                    Calamity.GetItem("GodlySoulArtifact").Tooltip.AddTranslation(GameCulture.Portuguese, "Lealdade\nPara cada Filho de Yharon que você tem invocado, você ganha 1 espaço de lacaio");
                    Calamity.GetItem("HallowedRune").DisplayName.AddTranslation(GameCulture.Portuguese, "Runa Consagrada");
                    Calamity.GetItem("HallowedRune").Tooltip.AddTranslation(GameCulture.Portuguese, "Sempre que seus lacaios atingirem um inimigo, você ganhará um bônus aleatório, isto não acumula com as versões inferiores\nEstes bônus irão aumentar sua defesa, seu dano por invocação ou regeneração de vida por um tempo\nSe você tiver o reforço ofensivo, os inimigos atingidos por lacaios \u00e0s vezes serão atingidos por estrelas");
                    Calamity.GetItem("HeartofDarkness").DisplayName.AddTranslation(GameCulture.Portuguese, "Coração da Escuridão");
                    Calamity.GetItem("HeartofDarkness").Tooltip.AddTranslation(GameCulture.Portuguese, "Você fanha fúria com o tempo\nFúria não desaparece gradualmente quando fora do combate\nEspólio do modo Vingança");
                    Calamity.GetItem("InkBomb").DisplayName.AddTranslation(GameCulture.Portuguese, "Bomba de Tinta");
                    Calamity.GetItem("InkBomb").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança várias bombas de tinta quando acertado que explodem em uma nuvem de tinta que confunde\nGanhe bastante furtividade ao ser atingido\nEste efeito tem um tempo de recarga de 20 segundos antes que possa ocorrer novamente");
                    Calamity.GetItem("JellyChargedBattery").DisplayName.AddTranslation(GameCulture.Portuguese, "Bateria Carregada de Geleia");
                    Calamity.GetItem("JellyChargedBattery").Tooltip.AddTranslation(GameCulture.Portuguese, "+1 lacaio máximo e 7% nos danos por lacaios\nAtaques de lacaios geram orbes de energia e infligem Eletrizado");
                    Calamity.GetItem("LeviathanAmbergris").DisplayName.AddTranslation(GameCulture.Portuguese, "Âmbar Cinzento do Leviathan");
                    Calamity.GetItem("LeviathanAmbergris").Tooltip.AddTranslation(GameCulture.Portuguese, "Você deixa água do mar venenosa enquanto se move\n30% de aumento na velocidade dos movimentos, 10% de aumento em todos os danos, e mais 20 de defesa quando submerso em líquidos\nSe você for danificado enquanto submerso em líquidos, você ganhará uma aura que machuca por um curto período de tempo\nEstar fora de líquidos aumenta todos os danos em 5% e a redução dos danos em 5%");
                    Calamity.GetItem("LumenousAmulet").DisplayName.AddTranslation(GameCulture.Portuguese, "Amuleto Lumíneo");
                    Calamity.GetItem("LumenousAmulet").Tooltip.AddTranslation(GameCulture.Portuguese, "Ataques causam o efeito negativo Pressão das profundezas\nFornece imunidaed ao efeito negativo Pressão das profundezas\nEnquanto estiver no abismo, você ganha 25% de aumento na vida máxima\nFornece uma quantidade razoável de luz no Abismo");
                    Calamity.GetItem("LuxorsGift").DisplayName.AddTranslation(GameCulture.Portuguese, "Presente de Luxor");
                    Calamity.GetItem("LuxorsGift").Tooltip.AddTranslation(GameCulture.Portuguese, "Armas disparam projéteis únicos com base no tipo de dano que elas têm\nAlgumas armas não podem receber este bônus");
                    Calamity.GetItem("ManaOverloader").DisplayName.AddTranslation(GameCulture.Portuguese, "Polarizador de Mana");
                    Calamity.GetItem("ManaOverloader").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta o máximo de mana em 50 e dano por magia em 6%\nRegeneração de vida diminuída em 3 se a mana estiver acima de 50% de seu máximo\nConcede cura espectral, a quantidade de cura aumenta com a sua mana\nA cura só funciona enquanto segura uma arma mágica\nQuanto mais mana você tem, mais você é curado");
                    Calamity.GetItem("MirageMirror").DisplayName.AddTranslation(GameCulture.Portuguese, "Espelho da Miragem");
                    Calamity.GetItem("MirageMirror").Tooltip.AddTranslation(GameCulture.Portuguese, "Curve a luz ao seu redor\nReduz a agressão dos inimigos fora do abismo\nFurtividade gera 30% mais rápido enquanto parado e 20% mais rápido enquanto se move");
                    Calamity.GetItem("MomentumCapacitor").DisplayName.AddTranslation(GameCulture.Portuguese, "Capacitor de Impulso");
                    Calamity.GetItem("MomentumCapacitor").Tooltip.AddTranslation(GameCulture.Portuguese, "LINHA DA DICA AQUI\nProjéteis ladinos que entram no campo obtêm uma aceleração constante e 15% de aumento nos danos\nEste reforço só pode acontecer a um projétil uma vez\nSó pode haver um campo");
                    Calamity.GetItem("MoonstoneCrown").DisplayName.AddTranslation(GameCulture.Portuguese, "Coroa da Rocha Lunar");
                    Calamity.GetItem("MoonstoneCrown").Tooltip.AddTranslation(GameCulture.Portuguese, "15% de aumento na velocidade dos projéteis ladinos\nAtaques furtivos invocam chamas da lua ao atingir um inimigo\nProjéteis ladinos muito ocasionalmente invocam sigilos da lua atrás deles");
                    Calamity.GetItem("Nanotech").DisplayName.AddTranslation(GameCulture.Portuguese, "Nanotecnologia");
                    Calamity.GetItem("Nanotech").Tooltip.AddTranslation(GameCulture.Portuguese, "Projéteis ladinos criam nanolâminas enquanto viajam\nAtaques furtivos invocam nanofeixes e faíscas ao atingir inimigos\nAtaques furtivos têm +20 perfuração de blindagem, causam 5% a mais de dano, e curam 1 de vida\n12% de aumento nos danos por ataques ladinos e 15% de aumento na velocidade de projéteis ladinos\nSempre que você acertar um ataque crítico no inimigo com uma arma ladina, seu dano por ataque ladino aumenta\nEste efeito pode acumular até 150 vezes\nO aumento de dano por ataque ladino máximo é 15%\nEsta linha é modificada abaixo");
                    Calamity.GetItem("NebulousCore").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo Nebuloso");
                    Calamity.GetItem("NebulousCore").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos\nInvoca estrelas de nébula flutuantes para te proteger\nVocê sobreviverá a um ataque que teria te matado e será curado em 100 HP\nEste efeito tem um tempo de recarga de 90 segundos");
                    Calamity.GetItem("NecklaceofVexation").DisplayName.AddTranslation(GameCulture.Portuguese, "Colar do Vexame");
                    Calamity.GetItem("NecklaceofVexation").Tooltip.AddTranslation(GameCulture.Portuguese, "Vingança\n20% de aumento nos danos quando abaixo de 50% de vida\nTodos os ataques causam Inferno amaldiçoado e Peçonha ao vestir a Armadura do Ladrão");
                    Calamity.GetItem("NuclearRod").DisplayName.AddTranslation(GameCulture.Portuguese, "Bastão Nuclear");
                    Calamity.GetItem("NuclearRod").Tooltip.AddTranslation(GameCulture.Portuguese, "Lacaios liberam uma aura irradiada ao atingir o inimigo\n+1 lacaio máximo");
                    Calamity.GetItem("Nucleogenesis").DisplayName.AddTranslation(GameCulture.Portuguese, "Nucleogênese");
                    Calamity.GetItem("Nucleogenesis").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta o máximo de lacaios em 4, isto não acumula com as versões inferiores\n15% de aumento nos danos por lacaios\nMaior recuo dos lacaios\nOs lacaios infligem uma variedade de efeitos negativos\nOs lacaios geram faíscas que causam dano ao atingir o inimigo");
                    Calamity.GetItem("OccultSkullCrown").DisplayName.AddTranslation(GameCulture.Portuguese, "Coroa do Crânio Oculto");
                    Calamity.GetItem("OccultSkullCrown").Tooltip.AddTranslation(GameCulture.Portuguese, "Apenas um tolo vestiria isso...\nVocê ganha fúria constantemente ao longo do tempo e a fúria não desaparece quando está fora do combate\nConverte certos efeitos negativos em positivos e estende suas durações\nEfeitos negativos afetados: Trevas, Apagão, Confuso, Lento, Fraco, Armadura quebrada,\nTrituração de armadura, Clivagem de guerra, Resfriado, Ichor and Obstruído\nSofrer um golpe faz com que você perca apenas metade de sua adrenalina máxima, em vez de perder ela completamente\nAumenta a sua velocidade dos movimentos e aceleração máxima em 5%\nTambém pode ser usado como um elmo\nItem do modo Vingança");
                    Calamity.GetItem("OldDie").DisplayName.AddTranslation(GameCulture.Portuguese, "Dado Velho");
                    Calamity.GetItem("OldDie").Tooltip.AddTranslation(GameCulture.Portuguese, "Para sua sorte, a maldição não afeta você. Na maioria.\nAumenta a aleatoriedade do dano dos ataques");
                    Calamity.GetItem("DukeScales").DisplayName.AddTranslation(GameCulture.Portuguese, "Escamas do Velho Duque");
                    Calamity.GetItem("DukeScales").Tooltip.AddTranslation(GameCulture.Portuguese, "Enquanto sob os efeitos de um efeito negativo que o danifica, você ganha 10% de aumento nos danos e 5% crítico\nPara cada 25% de vida perdida, você ganha 6% de aumento no dano e 3% crítico\nIsso atingirá o seu máximo em 18% de aumento nos danos e 9% crítico quando abaixo de 25% de vida\nImunidade a envenenado, peçonha, e envenenamento sulfúrico");
                    Calamity.GetItem("PhantomicArtifact").DisplayName.AddTranslation(GameCulture.Portuguese, "Artefato Fantasma");
                    Calamity.GetItem("PhantomicArtifact").Tooltip.AddTranslation(GameCulture.Portuguese, "Sempre que seus lacaios atingirem um inimigo, você ganhará um efeito fantasma, isso não acumula com versões anteriores do acessório\nEsses bônus irão aumentar sua defesa, seu dano por invocação ou regeneração de vida por um tempo\nSe você tiver o efeito ofensivo, os inimigos atingidos por lacaios terão uma chance de serem atingidos por facas fantasmas\nSe você tiver o efeito regenerativo, um coração fantasma ocasionalmente se materializará, concedendo regeneração massiva de vida\nSe você tiver o efeito defensivo, um baluarte fantasma absorverá 20% do dano do próximo projétil que atingir o baluarte, quebrando-o");
                    Calamity.GetItem("PlagueHive").DisplayName.AddTranslation(GameCulture.Portuguese, "Colmeia da Praga");
                    Calamity.GetItem("PlagueHive").Tooltip.AddTranslation(GameCulture.Portuguese, "O poder de suas abelhas e vespas rivalizará com o próprio Senhor da Lua\nTodos os ataques infligem o efeito negativo Praga\nLibera abelhas que infligem a praga quando sofrer danos\nProjéteis invocam caçadores da praga ao atingir inimigos");
                    Calamity.GetItem("PlaguedFuelPack").DisplayName.AddTranslation(GameCulture.Portuguese, "Pacote de Combustível Infestado");
                    Calamity.GetItem("PlaguedFuelPack").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento nos danos por ataques ladinos e 15% de aumento na velocidade dos projéteis ladinos\nFurtividade regenera 10% mais rápido\nLINHA DA DICA AQUI");
                    Calamity.GetItem("PsychoticAmulet").DisplayName.AddTranslation(GameCulture.Portuguese, "Amuleto Psicótico");
                    Calamity.GetItem("PsychoticAmulet").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta o dano por ataque ladino e dano por ataque à distância e chance de acerto crítico em 5%\nConcede um grande impulso a essas estatísticas se você não estiver se movendo");
                    Calamity.GetItem("RaidersTalisman").DisplayName.AddTranslation(GameCulture.Portuguese, "Talismã do Corsário");
                    Calamity.GetItem("RaidersTalisman").Tooltip.AddTranslation(GameCulture.Portuguese, "Sempre que você acertar um ataque crítico no inimigo com uma arma ladina, seu dano por ataque ladino aumenta\nEsse efeito pode acumular até 150 vezes\nO aumento de dano por ataque ladino máximo é 15%\nEsta linha é modificada abaixo");
                    Calamity.GetItem("ReaperToothNecklace").DisplayName.AddTranslation(GameCulture.Portuguese, "Colar do Dente Ceifeiro");
                    Calamity.GetItem("ReaperToothNecklace").Tooltip.AddTranslation(GameCulture.Portuguese, "Um troféu terrível do predador supremo\n10% de aumento nos danos\nAumenta a perfuração de blindagem em 15");
                    Calamity.GetItem("RogueEmblem").DisplayName.AddTranslation(GameCulture.Portuguese, "Emblema do Ladino");
                    Calamity.GetItem("RogueEmblem").Tooltip.AddTranslation(GameCulture.Portuguese, "15% de aumento nos danos por ataques ladinos");
                    Calamity.GetItem("RottenBrain").DisplayName.AddTranslation(GameCulture.Portuguese, "Cérebro Apodrecido");
                    Calamity.GetItem("RottenBrain").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos quando abaixo de 75% de vida\n5% de redução na velocidade dos movimentos quando abaixo de 50% de vida\nSombra cai quando você é atingido");
                    Calamity.GetItem("RottenDogtooth").DisplayName.AddTranslation(GameCulture.Portuguese, "Dente de Cachorro Apodrecido");
                    Calamity.GetItem("RottenDogtooth").Tooltip.AddTranslation(GameCulture.Portuguese, "Faz com que ataques furtivos inflijam Esmagamento de armadura, causem 10% a mais de dano e custem 1 unidade a menos de furtividade.");
                    Calamity.GetItem("RuinMedallion").DisplayName.AddTranslation(GameCulture.Portuguese, "Medalhão da Ruína");
                    Calamity.GetItem("RuinMedallion").Tooltip.AddTranslation(GameCulture.Portuguese, "Ataques furtivos gastam apenas 50% de sua furtividade máxima\n6% de aumento nos danos por ataques ladinos, e 6% de aumento na chance de acerto crítico ladino");
                    Calamity.GetItem("RustyMedallion").DisplayName.AddTranslation(GameCulture.Portuguese, "Medalhão Enferrujado");
                    Calamity.GetItem("RustyMedallion").Tooltip.AddTranslation(GameCulture.Portuguese, "Faz com que armas de ataque à distância \u00e0s vezes liberem gotas de ácido do céu");
                    Calamity.GetItem("SandCloak").DisplayName.AddTranslation(GameCulture.Portuguese, "Capa de Areia");
                    Calamity.GetItem("SandCloak").Tooltip.AddTranslation(GameCulture.Portuguese, "+1 defesa e 5% de aumento na velocidade dos movimentos\nLINHA DA DICA AQUI\nEsse efeito tem um tempo de recarga de 30 segundos antes que possa ser usado novamente");
                    Calamity.GetItem("SandSharkToothNecklace").DisplayName.AddTranslation(GameCulture.Portuguese, "Colar do Dente de Tubarão de Areia");
                    Calamity.GetItem("SandSharkToothNecklace").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a perfuração de blindagem em 10\n6% de aumento nos danos");
                    Calamity.GetItem("ScuttlersJewel").DisplayName.AddTranslation(GameCulture.Portuguese, "Joia do Fugitivo");
                    Calamity.GetItem("ScuttlersJewel").Tooltip.AddTranslation(GameCulture.Portuguese, "Projéteis ladinos furtivos geram um espinho de joia quando destruídos");
                    Calamity.GetItem("ShatteredCommunity").DisplayName.AddTranslation(GameCulture.Portuguese, "Comunidade Despedaçada");
                    Calamity.GetItem("ShatteredCommunity").Tooltip.AddTranslation(GameCulture.Portuguese, "Arruinada por um ódio desconhecido, ela ainda contém o poder da Comunidade (pelo menos, a maior parte dela)...\nVocê gera fúria com o tempo e a fúria não desaparece fora do combate\nSofrer danos fornece fúria, este efeito não é prejudicado por suas estatísticas defensivas\nEnquanto o Modo Fúria está ativado, sofrer danos fornece apenas a metade da quantidade de fúria\nCause danos com o Modo Fúria para fortalecer ainda mais sua ira\n");
                    Calamity.GetItem("SigilofCalamitas").DisplayName.AddTranslation(GameCulture.Portuguese, "Sigilo de Calamitas");
                    Calamity.GetItem("SigilofCalamitas").Tooltip.AddTranslation(GameCulture.Portuguese, "15% de aumento nos danos por magia e 10% de redução no consumo de mana\n+100 mana máxima\nAumenta o alcance de coleta das estrelas de mana");
                    Calamity.GetItem("SilencingSheath").DisplayName.AddTranslation(GameCulture.Portuguese, "Bainha Silenciadora");
                    Calamity.GetItem("SilencingSheath").Tooltip.AddTranslation(GameCulture.Portuguese, "+20 furtividade máxima\nFurtividade gera 15% mais rápido");
                    Calamity.GetItem("SpectralVeil").DisplayName.AddTranslation(GameCulture.Portuguese, "Véu Espectral");
                    Calamity.GetItem("SpectralVeil").Tooltip.AddTranslation(GameCulture.Portuguese, "O interior da capa está cheio de dentes...\nLINHA DA DICA AQUI\nSe você se esquivar de algo enquanto estiver invulnerável, você ganha furtividade cheia instantaneamente\nO teletransporte é desativado enquanto Estado de caos está ativo\nFornece 10% de aumento na velocidade dos movimentos\nFurtividade regenera 20% mais rápido enquanto andando");
                    Calamity.GetItem("SpiritGenerator").DisplayName.AddTranslation(GameCulture.Portuguese, "Glifo Espiritual");
                    Calamity.GetItem("SpiritGenerator").Tooltip.AddTranslation(GameCulture.Portuguese, "Sempre que seus lacaios atingirem um inimigo, você ganhará um bônus aleatório\nEstes bônus irão aumentar sua defesa, seu dano por invocação ou regeneração de vida por um tempo");
                    Calamity.GetItem("StarTaintedGenerator").DisplayName.AddTranslation(GameCulture.Portuguese, "Gerador Estrelado");
                    Calamity.GetItem("StarTaintedGenerator").Tooltip.AddTranslation(GameCulture.Portuguese, "+2 lacaios máximos, isto não acumula com versões anteriores\n7%de aumento nos danos por lacaios\nAtaques de lacaios geram explosões astrais e infligem vários efeitos negativos");
                    Calamity.GetItem("StarbusterCore").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo da Explosão Estelar");
                    Calamity.GetItem("StarbusterCore").Tooltip.AddTranslation(GameCulture.Portuguese, "Invocações lançam uma explosão astral ao atingir o inimigo\n+1 lacaio máximo");
                    Calamity.GetItem("StatisBlessing").DisplayName.AddTranslation(GameCulture.Portuguese, "Bênção de Statis");
                    Calamity.GetItem("StatisBlessing").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta o máximo de lacaios em 2 e 10% de aumento nos danos por lacaios\nMaior recuo dos lacaios\nLacaios infligem chamas profanas ao atingir um inimigo");
                    Calamity.GetItem("StatisCurse").DisplayName.AddTranslation(GameCulture.Portuguese, "Maldição de Statis");
                    Calamity.GetItem("StatisCurse").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta o máximo de lacaios em 3, isto não acumula com versões anteriores\n10% de aumento nos danos por lacaios\nMaior recuo dos lacaios\nLacaios infligem chamas profanas e chamas das sombras ao atingir um inimigo");
                    Calamity.GetItem("TheAmalgam").DisplayName.AddTranslation(GameCulture.Portuguese, "O Amálgama");
                    Calamity.GetItem("TheAmalgam").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a duração de efeitos de poções em 100% e efeitos de poções permanecem ativos mesmo depois que você morrer\n15% de aumento nos danos\nSombra chove quando você é atingido\nInimigos próximos receberão uma variedade de efeitos negativos quando você for atingido");
                    Calamity.GetItem("TheBee").DisplayName.AddTranslation(GameCulture.Portuguese, "A Abelha");
                    Calamity.GetItem("TheBee").Tooltip.AddTranslation(GameCulture.Portuguese, "Faz com que estrelas caiam e libera abelhas quando sofrer dano\nQuando em vida total, seu dano é aumentado com base em sua redução dos danos\nDanos sofridos com vida cheia serão cortados pela metade\nIsso possui um tempo de recarga de 10 segundos");
                    Calamity.GetItem("TheFirstShadowflame").DisplayName.AddTranslation(GameCulture.Portuguese, "A Primeira Chama das Sombras");
                    Calamity.GetItem("TheFirstShadowflame").Tooltip.AddTranslation(GameCulture.Portuguese, "Diz-se que, no passado, Prometeus desceu dos céus para conceder fogo ao homem.\nSe isso fosse verdade, então certamente seriam os demônios do inferno que teriam surgido de baixo para fazer o mesmo.\nLacaios infligem chama das sombras nos inimigos.");
                    Calamity.GetItem("ThiefsDime").DisplayName.AddTranslation(GameCulture.Portuguese, "Centavo do Ladrão");
                    Calamity.GetItem("ThiefsDime").Tooltip.AddTranslation(GameCulture.Portuguese, "Esses piratas não sabem nada sobre ganhar dinheiro\nInvoca uma moeda que gira em torno de você e rouba dinheiro dos inimigos");
                    Calamity.GetItem("ToxicHeart").DisplayName.AddTranslation(GameCulture.Portuguese, "Coração Tóxico");
                    Calamity.GetItem("ToxicHeart").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca uma aura de praga que machuca ao redor do jogador para destruir os inimigos próximos\nTorna você imune ao efeito negativo Praga");
                    Calamity.GetItem("UnstablePrism").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo de Granito Instável");
                    Calamity.GetItem("UnstablePrism").Tooltip.AddTranslation(GameCulture.Portuguese, "Três faíscas são liberadas em ataques críticos");
                    Calamity.GetItem("VampiricTalisman").DisplayName.AddTranslation(GameCulture.Portuguese, "Talismã Vampírico");
                    Calamity.GetItem("VampiricTalisman").Tooltip.AddTranslation(GameCulture.Portuguese, "Projéteis ladinos roubam vida dos inimigos em acertos críticos\n12% de aumento nos danos por ataques ladinos");
                    Calamity.GetItem("VeneratedLocket").DisplayName.AddTranslation(GameCulture.Portuguese, "Medalhão Venerado");
                    Calamity.GetItem("VeneratedLocket").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por ataques ladinos\nUsar uma arma ladina invoca uma cópia do projétil que cai do céu\nAtaques furtivos fazem com que um leque circular em busca de facas de cosmilita seja lançado\nVocê nunca estará sozinho, não importa onde você vá");
                    Calamity.GetItem("CalamityRing").DisplayName.AddTranslation(GameCulture.Portuguese, "Vazio da Calamidade");
                    Calamity.GetItem("CalamityRing").Tooltip.AddTranslation(GameCulture.Portuguese, "Amaldiçoado? Reduz a redução dos danos em 10%\n15% de aumento em todos os danos\nFogo de enxofre chove enquanto a invencibilidade está ativa");
                    Calamity.GetItem("VoidofExtinction").DisplayName.AddTranslation(GameCulture.Portuguese, "Vazio da Extinção");
                    Calamity.GetItem("VoidofExtinction").Tooltip.AddTranslation(GameCulture.Portuguese, "Não mais amaldiçoado\nLança bolas de fogo de enxofre do céu ocasionalmente\n15% de aumento em todos os danos\nFogo de enxofre chove enquanto a invencibilidade está ativa\nImunidade temporária à lava, reduz muito o dano causado pela lava, e 25% de aumento nos danos enquanto estiver na lava");
                    Calamity.GetItem("VoltaicJelly").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia Voltaica");
                    Calamity.GetItem("VoltaicJelly").Tooltip.AddTranslation(GameCulture.Portuguese, "+1 lacaio máximo\nAtaques de lacaios infligem Eletrizado");
                    Calamity.GetItem("SamuraiBadge").DisplayName.AddTranslation(GameCulture.Portuguese, "Estandarte de Guerra do Sol");
                    Calamity.GetItem("SamuraiBadge").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta o dano por ataques físicos, ataques físicos verdadeiros e velocidade do ataque físico quanto mais perto você está dos inimigos\nO reforço máximo é 20% de aumento nos danos por ataques físicos, ataques físicos verdadeiros e velocidade do ataque físico");
                    Calamity.GetItem("WulfrumBattery").DisplayName.AddTranslation(GameCulture.Portuguese, "Bateria de Vulfrânio");
                    Calamity.GetItem("WulfrumBattery").Tooltip.AddTranslation(GameCulture.Portuguese, "7% de aumento nos danos por lacaios");
                    Calamity.GetItem("YharimsGift").DisplayName.AddTranslation(GameCulture.Portuguese, "Presente de Yharim");
                    Calamity.GetItem("YharimsGift").Tooltip.AddTranslation(GameCulture.Portuguese, "O poder de um deus pulsa dentro desse artefato\nMeteoros em chamas chovem quando a invencibilidade está ativa\nPó de dragão explosivo é deixado para trás enquanto você se move\nDefesa aumentada em 30 e dano aumentado em 15%");
                    Calamity.GetItem("YharimsInsignia").DisplayName.AddTranslation(GameCulture.Portuguese, "Insígnia de Yharim");
                    Calamity.GetItem("YharimsInsignia").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos quando abaixo de 50% de vida\n10% de aumento na velocidade do ataque físico\n10% de aumento nos danos por ataques físicos e ataques físicos verdadeiros\nAtaques físicos causam fogo sagrado\nImunidade temporária à lava\nMaior recuo do ataque físico");

                    //Defensive
                    Calamity.GetItem("Abaddon").DisplayName.AddTranslation(GameCulture.Portuguese, "Abaddon");
                    Calamity.GetItem("Abaddon").Tooltip.AddTranslation(GameCulture.Portuguese, "Reduz o dano causado pelo efeito negativo Chamas de enxofre e fornece imunidade à Lava abrasadora");
                    Calamity.GetItem("AbyssalDivingSuit").DisplayName.AddTranslation(GameCulture.Portuguese, "Traje de Mergulho Abissal");
                    Calamity.GetItem("AbyssalDivingSuit").Tooltip.AddTranslation(GameCulture.Portuguese, "Transforma o jogador em um mergulhador com armadura\nAumenta a velocidade dos movimentos e a aceleração enquanto debaixo d\u0027água mas você se move lentamente fora d\u0027água\nAs placas blindadas dos trajes reduzem o dano recebido em 15%\nAs placas só sofrerão danos se o dano recebido for maior que 50\nDepois que o traje tiver sofrido muitos danos, suas placas blindadas levarão 3 minutos para se regenerar\nReduz o dano causado pela pressão do abismo enquanto sem fôlego\nRemove o efeito de sangramento causado pelo abismo em todas as camadas, exceto a mais profunda\nOferece a capacidade de nadar um aumento enorme no tempo embaixo d'água\nFornece luz debaixo d\u0027água e maior mobilidade no gelo\nFornece uma quantidade razoável de luz no abismo\nReduz bastante a perda de fôlego no abismo\nReduz a capacidade das criaturas de detectá-lo no abismo\nReduz a redução da defesa que o abismo causa\nPermite que você caia mais rápido em líquidos");
                    Calamity.GetItem("Affliction").DisplayName.AddTranslation(GameCulture.Portuguese, "Aflição");
                    Calamity.GetItem("Affliction").Tooltip.AddTranslation(GameCulture.Portuguese, "Dá a você e todos os outros jogadores no seu time +1 regeneração de vida\n+10% vida máxima, 7% redução dos danos, 10 defesa, e 10% de aumento nos danos");
                    Calamity.GetItem("AlchemicalFlask").DisplayName.AddTranslation(GameCulture.Portuguese, "Frasco Alquímico");
                    Calamity.GetItem("AlchemicalFlask").Tooltip.AddTranslation(GameCulture.Portuguese, "Todos os ataques infligem a praga\nProjéteis invocam caçadores da praga ao acertar inimigos");
                    Calamity.GetItem("AmbrosialAmpoule").DisplayName.AddTranslation(GameCulture.Portuguese, "Ampola Ambrosial");
                    Calamity.GetItem("AmbrosialAmpoule").Tooltip.AddTranslation(GameCulture.Portuguese, "Você emite luz\n7% de aumento na redução dos danos e aumento da regeneração de vida\nImune a veneno, resfriado, e queimadura de gelo");
                    Calamity.GetItem("AmidiasSpark").DisplayName.AddTranslation(GameCulture.Portuguese, "Faíscas de Amidias");
                    Calamity.GetItem("AmidiasSpark").Tooltip.AddTranslation(GameCulture.Portuguese, "Sofrer danos libera uma explosão de faíscas");
                    Calamity.GetItem("AnechoicPlating").DisplayName.AddTranslation(GameCulture.Portuguese, "Revestimento Anecóico");
                    Calamity.GetItem("AnechoicPlating").Tooltip.AddTranslation(GameCulture.Portuguese, "Reduz a capacidade das criaturas de detectá-lo no abismo\nReduz a redução da defesa que o abismo causa");
                    Calamity.GetItem("SirensHeart").DisplayName.AddTranslation(GameCulture.Portuguese, "Coração Aquático");
                    Calamity.GetItem("SirensHeart").Tooltip.AddTranslation(GameCulture.Portuguese, "Transforma o jogador em um elemental de água\nIr para debaixo d\u0027água te dá um efeito\nReduz bastante a perda de fôlego e fornece uma quantidade pequena de luz no abismo\nInimigos ficam congelados quando te tocam\nVocê tem uma camada de gelo ao seu redor que absorve 20% dos danos, mas se quebra após um acerto\nApós 30 segundos, o escudo de gelo irá se regenerar\nUau, você pode nadar agora!\nA maioria desses efeitos só ficam ativos depois que o Esqueletron for derrotado");
                    Calamity.GetItem("AsgardsValor").DisplayName.AddTranslation(GameCulture.Portuguese, "Valor de Asgard");
                    Calamity.GetItem("AsgardsValor").Tooltip.AddTranslation(GameCulture.Portuguese, "Oferece imunidade a blocos de fogo e a recuos\nImune a maioria dos efeitos negativos e reduz o dano causado pelo efeito negativo Chamas de enxofre\n+16 de defesa enquanto submerso em líquidos\n+20 vida máxima\nConcede uma corrida sagrada que pode ser usada para colidir-se com os inimigos");
                    Calamity.GetItem("AsgardianAegis").DisplayName.AddTranslation(GameCulture.Portuguese, "Égide Asgardiana");
                    Calamity.GetItem("AsgardianAegis").Tooltip.AddTranslation(GameCulture.Portuguese, "Oferece imunidade a blocos de fogo e a recuos\nImune a maioria dos efeitos negativos\n+40 vida máxima e maior regeneração de vida\nConcede uma corrida de chamas sagradas suprema\nPode ser usado para colidir-se com inimigos\nLINHA DA DICA AQUI\nAtivar esse efeito irá reduzir sua velocidade de movimento e aumentar a agressão inimiga\n+20 de defesa enquanto submerso em líquidos");
                    Calamity.GetItem("AstralArcanum").DisplayName.AddTranslation(GameCulture.Portuguese, "Arcano Astral");
                    Calamity.GetItem("AstralArcanum").Tooltip.AddTranslation(GameCulture.Portuguese, "Sofrer danos derrubará estrelas astrais do céu\nFornece imunidade ao efeito negativo da infecção astral\nVocê reflete projéteis quando eles o atingem\nProjéteis refletidos não causam danos a você\nEste reflexo tem um tempo de recarga de 90 segundos que é compartilhado com todos os outros desvios e reflexos\nAumenta a regeneração de vida, mesmo sob os efeitos de um efeito negativo que o danifica\nEnquanto estiver sob os efeitos de um efeito negativo que o danifica, você ganhará 20 de defesa\nLINHA DA DICA AQUI");
                    Calamity.GetItem("BlazingCore").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo Ardente");
                    Calamity.GetItem("BlazingCore").Tooltip.AddTranslation(GameCulture.Portuguese, "O núcleo abrasador da deusa profana\n10% de redução dos danos\nSer atingido cria um sol em miniatura que perdura, causando danos aos inimigos próximos\nO sol lentamente arrastará inimigos para dentro dele\nApenas um sol pode estar ativo por vez\nFornece uma quantidade razoável de luz no Abismo");
                    Calamity.GetItem("BloomStone").DisplayName.AddTranslation(GameCulture.Portuguese, "Rocha do Desabrocho");
                    Calamity.GetItem("BloomStone").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma das relíquias antigas\nVocê regenera vida rapidamente no chão\nEste efeito funciona melhor durante o dia\nFlores crescem se você estiver pisando em grama\nPlantas de tinturas aleatórias crescerão ao pisar em terra sem grama");
                    Calamity.GetItem("CelestialJewel").DisplayName.AddTranslation(GameCulture.Portuguese, "Joia Celestial");
                    Calamity.GetItem("CelestialJewel").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a regeneração de vida, mesmo sob os efeitos de um efeito negativo que o danifica\nEnquanto estiver sob os efeitos de um efeito negativo que o danifica, você ganhará 15 de defesa\nLINHA DA DICA AQUI");
                    Calamity.GetItem("CoreOfTheBloodGod").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo do Deus do Sangue");
                    Calamity.GetItem("CoreOfTheBloodGod").Tooltip.AddTranslation(GameCulture.Portuguese, "8% de aumento nos danos e na redução dos danos\nAumenta a sua vida máxima em 10%\nPoções de cura são 15% mais eficazes\nReduz os danos de contato dos inimigos pela metade\nQuando você sofrer danos de contato, esse efeito tem um tempo de recarga de 20 segundos");
                    Calamity.GetItem("CorruptFlask").DisplayName.AddTranslation(GameCulture.Portuguese, "Frasco Corrompido");
                    Calamity.GetItem("CorruptFlask").Tooltip.AddTranslation(GameCulture.Portuguese, "7% de aumento na redução dos danos e +3 defesa enquanto na corrupção");
                    Calamity.GetItem("CrawCarapace").DisplayName.AddTranslation(GameCulture.Portuguese, "Carapaça de Caranguejo");
                    Calamity.GetItem("CrawCarapace").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento na redução dos danos\nInimigos sofrem danos quando te atacam");
                    Calamity.GetItem("CrimsonFlask").DisplayName.AddTranslation(GameCulture.Portuguese, "Frasco de Carmim");
                    Calamity.GetItem("CrimsonFlask").Tooltip.AddTranslation(GameCulture.Portuguese, "7% de aumento na redução dos danos e +3 defesa enquanto no carmim");
                    Calamity.GetItem("CrownJewel").DisplayName.AddTranslation(GameCulture.Portuguese, "Joia da Coroa");
                    Calamity.GetItem("CrownJewel").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a regeneração de vida, mesmo sob os efeitos de um efeito negativo que o danifica\nEnquanto estiver sob os efeitos de um efeito negativo que o danifica, você ganhará 10 de defesa");
                    Calamity.GetItem("CryoStone").DisplayName.AddTranslation(GameCulture.Portuguese, "Rocha do Gelo");
                    Calamity.GetItem("CryoStone").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma das relíquias antigas\nCria um escudo de gelo ao seu redor que causa danos e deixa os inimigos lentos ao entrar em contato");
                    Calamity.GetItem("DeepDiver").DisplayName.AddTranslation(GameCulture.Portuguese, "Mergulhador das Profundezas");
                    Calamity.GetItem("DeepDiver").Tooltip.AddTranslation(GameCulture.Portuguese, "15% de aumento nos danos, velocidade dos movimentos e +15 defesa quando debaixo d\u0027água\nEnquanto debaixo d\u0027água, você ganha a capacidade de correr grandes distâncias");
                    Calamity.GetItem("DeificAmulet").DisplayName.AddTranslation(GameCulture.Portuguese, "Amuleto Sagrado");
                    Calamity.GetItem("DeificAmulet").Tooltip.AddTranslation(GameCulture.Portuguese, "Faz com que estrelas caiam e aumenta o tempo de imunidade quando sofrer danos\nReduz o tempo de recarga das poções de cura");
                    Calamity.GetItem("DepthCharm").DisplayName.AddTranslation(GameCulture.Portuguese, "Amuleto das Profundezas");
                    Calamity.GetItem("DepthCharm").Tooltip.AddTranslation(GameCulture.Portuguese, "Reduz o dano causado pela pressão do abismo enquanto sem fôlego\nRemove o efeito de sangramento causado pelas camadas superiores do abismo");
                    Calamity.GetItem("WifeinaBottle").DisplayName.AddTranslation(GameCulture.Portuguese, "Elemental na Garrafa");
                    Calamity.GetItem("WifeinaBottle").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um elemental de areia para lutar por você");
                    Calamity.GetItem("ElysianAegis").DisplayName.AddTranslation(GameCulture.Portuguese, "Égide do Elísio");
                    Calamity.GetItem("ElysianAegis").Tooltip.AddTranslation(GameCulture.Portuguese, "Abençoado pela Chama Profana\nOferece imunidade a blocos de fogo, recuos e Chamas sagradas\n+30 vida máxima\nConcede uma corrida de chamas sagradas suprema\nPode ser usado para colidir-se com inimigos\nLINHA DA DICA AQUI\nAtivar esse efeito irá reduzir sua velocidade de movimento e aumentar a agressão inimiga");
                    Calamity.GetItem("EyeoftheStorm").DisplayName.AddTranslation(GameCulture.Portuguese, "Olho da Tempestade");
                    Calamity.GetItem("EyeoftheStorm").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um elemental das nuvens para lutar por você");
                    Calamity.GetItem("FabledTortoiseShell").DisplayName.AddTranslation(GameCulture.Portuguese, "Casco da Língua de Chamas");
                    Calamity.GetItem("FabledTortoiseShell").Tooltip.AddTranslation(GameCulture.Portuguese, "50% de redução na velocidade dos movimentos\nInimigos sofrem danos quando te atacam\nVocê se move mais rapidamente e perde 18 defesa por 3 segundos se você sofrer danos\nImunidade temporária à lava");
                    Calamity.GetItem("FleshTotem").DisplayName.AddTranslation(GameCulture.Portuguese, "Totem de Carne");
                    Calamity.GetItem("FleshTotem").Tooltip.AddTranslation(GameCulture.Portuguese, "Reduz os danos de contato dos inimigos pela metade\nQuando você sofrer danos de contato, este efeito tem um tempo de recarga de 20 segundos");
                    Calamity.GetItem("FrigidBulwark").DisplayName.AddTranslation(GameCulture.Portuguese, "Baluarte Frígido");
                    Calamity.GetItem("FrigidBulwark").Tooltip.AddTranslation(GameCulture.Portuguese, "Absorve 25% do dano causado aos jogadores de sua equipe\nApenas ativo acima de 25% de vida\nOferece imunidade a recuos\nColoca um escudo em volta do proprietário quando abaixo de 50% de vida que reduz os danos\nO escudo se torna mais poderoso quando abaixo de 15% de vida e reduz o dano ainda mais");
                    Calamity.GetItem("FrostBarrier").DisplayName.AddTranslation(GameCulture.Portuguese, "Barreira Congelada");
                    Calamity.GetItem("FrostBarrier").Tooltip.AddTranslation(GameCulture.Portuguese, "Você congelará os inimigos perto de você quando for atingido\nVocê é imune ao efeito negativo Resfriado");
                    Calamity.GetItem("FungalCarapace").DisplayName.AddTranslation(GameCulture.Portuguese, "Carapaça Fúngica");
                    Calamity.GetItem("FungalCarapace").Tooltip.AddTranslation(GameCulture.Portuguese, "Você emite uma explosão de esporos de cogumelo quando atingido");
                    Calamity.GetItem("FungalClump").DisplayName.AddTranslation(GameCulture.Portuguese, "Aglomerado de Fungos");
                    Calamity.GetItem("FungalClump").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um aglomerado de fungos para lutar por você\nO aglomerado se agarra aos inimigos e rouba a vida deles para você");
                    Calamity.GetItem("GiantPearl").DisplayName.AddTranslation(GameCulture.Portuguese, "Pérola Gigante");
                    Calamity.GetItem("GiantPearl").Tooltip.AddTranslation(GameCulture.Portuguese, "Você tem uma aura de luz ao seu redor\nInimigos dentro da aura ficam mais lentos\nNão funciona enquanto um chefe estiver vivo\nFornece uma quantidade pequena de luz no abismo");
                    Calamity.GetItem("GiantTortoiseShell").DisplayName.AddTranslation(GameCulture.Portuguese, "Casco de Tartaruga Gigante");
                    Calamity.GetItem("GiantTortoiseShell").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de redução na velocidade dos movimentos\nInimigos sofrem danos quando te atacam");
                    Calamity.GetItem("GravistarSabaton").DisplayName.AddTranslation(GameCulture.Portuguese, "Sapato da Gravidade Estelar");
                    Calamity.GetItem("GravistarSabaton").Tooltip.AddTranslation(GameCulture.Portuguese, "Pressione a tecla PARA BAIXO para aumentar a sua velocidade de queda por 5 segundos\nIsso tem um tempo de recarga de 8 segundos\nAcertar o solo com maior velocidade de queda causará uma explosão astral");
                    Calamity.GetItem("HeartoftheElements").DisplayName.AddTranslation(GameCulture.Portuguese, "Coração dos Elementos");
                    Calamity.GetItem("HeartoftheElements").Tooltip.AddTranslation(GameCulture.Portuguese, "O coração do mundo\nInvoca todos os elementais para te proteger");
                    Calamity.GetItem("HideofAstrumDeus").DisplayName.AddTranslation(GameCulture.Portuguese, "Pele de Astrum Deus");
                    Calamity.GetItem("HideofAstrumDeus").Tooltip.AddTranslation(GameCulture.Portuguese, "Sofrer danos, ou infligir um ataque físico verdadeiro, derrubará uma quantidade imensa de estrelas astrais do céu\nSofrer danos aumentará o dano por ataque físico verdadeiro em 50%\nA duração do reforço é baseada na quantidade de dano que você sofreu, quanto maior o dano, mais longo será o reforço\nFornece imunidade aos efeitos negativos da infecção astral, inferno amaldiçoado, em chamas e queimadura de gelo\nInimigos sofrem danos quando te atacam e são infligidos com o efeito negativo da infecção astral");
                    Calamity.GetItem("HoneyDew").DisplayName.AddTranslation(GameCulture.Portuguese, "Melada");
                    Calamity.GetItem("HoneyDew").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento na redução dos danos, +5 defesa, e aumento de regeneração de vida enquanto na Selva\nImune a Veneno e Peçonha\nRegeneração de vida semelhante ao mel sem penalidade de velocidade\nA maioria dos inimigos e projéteis abelhas/vespas causam 75% de dano a você");
                    Calamity.GetItem("HowlsHeart").DisplayName.AddTranslation(GameCulture.Portuguese, "Coração de Howl");
                    Calamity.GetItem("HowlsHeart").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca Howl para lutar por você, Calcifer para iluminar o seu caminho, e Cabeça de Nabo para seguir você por aí");
                    Calamity.GetItem("Laudanum").DisplayName.AddTranslation(GameCulture.Portuguese, "Láudano");
                    Calamity.GetItem("Laudanum").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte certos efeitos negativos em positivos e estende suas durações\nEfeitos negativos afetados: Trevas, Apagão, Confuso, Lento, Fraco, Armadura quebrada,\nTrituração de armadura, Clivagem de guerra, Resfriado, Ichor and Obstruído\nEspólio do modo Vingança");
                    Calamity.GetItem("LeadCore").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo de Chumbo");
                    Calamity.GetItem("LeadCore").Tooltip.AddTranslation(GameCulture.Portuguese, "Oferece imunidade ao efeito negativo Irradiado");
                    Calamity.GetItem("LivingDew").DisplayName.AddTranslation(GameCulture.Portuguese, "Orvalho Vivo");
                    Calamity.GetItem("LivingDew").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento na redução dos danos, +5 defesa, e aumento de regeneração de vida enquanto na Selva\nImune a venenos");
                    Calamity.GetItem("MutatedTruffle").DisplayName.AddTranslation(GameCulture.Portuguese, "Trufa Mutada");
                    Calamity.GetItem("MutatedTruffle").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um pequeno Velho Duque para lutar por você\nQuando abaixo de 50% de vida, ele se moverá muito mais rapidamente");
                    Calamity.GetItem("OrnateShield").DisplayName.AddTranslation(GameCulture.Portuguese, "Escudo Ornamentado");
                    Calamity.GetItem("OrnateShield").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumento na redução dos danos e vida ao vestir a armadura de Dédalo\nFornece uma corrida de gelo que congela os inimigos");
                    Calamity.GetItem("LureofEnthrallment").DisplayName.AddTranslation(GameCulture.Portuguese, "Pérola do Encantamento");
                    Calamity.GetItem("LureofEnthrallment").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um elemental de água para lutar por você\nO elemental fica acima de você, atirando lanças de água, névoa de gelo e claves agudas nos inimigos próximos");
                    Calamity.GetItem("PermafrostsConcoction").DisplayName.AddTranslation(GameCulture.Portuguese, "Mistura de Permafrost");
                    Calamity.GetItem("PermafrostsConcoction").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a mana máxima em 50 e reduz o custo de mana em 15%\nAumenta a regeneraçáo de vida conforme a vida diminui\nAumenta a regeneraçáo de vida quando afetado por Veneno, Em chamas, ou Chamas de enxofre\nVocê sobreviverá a danos fatais e reviverá com 30% de vida em um tempo de recarga de 3 minutos\nVocê é envolto em uma barreira de gelo por 3 segundos quando revivido");
                    Calamity.GetItem("ProfanedSoulArtifact").DisplayName.AddTranslation(GameCulture.Portuguese, "Artefato da Alma Profana");
                    Calamity.GetItem("ProfanedSoulArtifact").Tooltip.AddTranslation(GameCulture.Portuguese, "Puridade\nInvoca um guardião curador que cura uma certa quantidade de vida a cada poucos segundos\nInvoca um guardião defensivo se você tiver pelo menos 10 vagas de lacaio, o que aumenta a sua velocidade dos movimentos e a sua resistência a danos\nInvoca um guardião ofensivo se você estiver usando o conjunto invocador de estragão (ou mais forte), que aumenta o dano de invocação e as vagas de lacaios\nSe você for atingido, a maioria dos seus efeitos desaparecerão por 5 segundos");
                    Calamity.GetItem("ProfanedSoulCrystal").DisplayName.AddTranslation(GameCulture.Portuguese, "Cristal da Alma Profana");
                    Calamity.GetItem("ProfanedSoulCrystal").Tooltip.AddTranslation(GameCulture.Portuguese, "Transforma você em um emissário da deusa profana\nRequer 10 espaços de lacaio para fornecer os seguintes efeitos\nTodas as armas não-invocadoras são convertidas em variações invocadoras poderosas\nCair abaixo de 50% de vida irá fortalecer esses ataques\n[c/f05a5a:Transforma ataques físicos em uma barragem de lanças]\n[c/3a83e4:Transforma ataques mágicos em uma poderosa bola de fogo que se divide]\n[c/85e092:Transforma ataques à distância em uma barragem de bolas de fogo e meteoros]\n[c/e97451:Transforma ataques ladinos em um espiral cristalino mortal]\nInvoca e fortalece os pequenos profanos para lutar junto de você\nVocê não é mais afetado pelo cansaço quando atingido\nFornece efeitos dependendo da hora do dia\nFornece proteção contra o calor e o frio no Modo Morte\nPensando bem, foi uma vida bem chata\n[c/FFBF49:Portanto, devemos queimar tudo no nome da puridade]");
                    Calamity.GetItem("RampartofDeities").DisplayName.AddTranslation(GameCulture.Portuguese, "Muralha das Divindades");
                    Calamity.GetItem("RampartofDeities").Tooltip.AddTranslation(GameCulture.Portuguese, "Faz com que estrelas caiam e aumenta o tempo de imunidade quando sofrer danos\nReduz o tempo de recarga das poções de cura\nAbsorve 25% do dano causado aos jogadores de sua equipe\nEste efeito é apenas ativo acima de 25% de vida\nOferece imunidade a recuos\nColoca um escudo em volta do proprietário quando abaixo de 50% de vida que reduz os danos\nO escudo se torna mais poderoso quando abaixo de 15% de vida e reduz o dano ainda mais");
                    Calamity.GetItem("WifeinaBottlewithBoobs").DisplayName.AddTranslation(GameCulture.Portuguese, "Elemental Raro na Garrafa");
                    Calamity.GetItem("WifeinaBottlewithBoobs").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um elemental de areia para te curar\n;D");
                    Calamity.GetItem("Regenator").DisplayName.AddTranslation(GameCulture.Portuguese, "Regenador");
                    Calamity.GetItem("Regenator").Tooltip.AddTranslation(GameCulture.Portuguese, "Reduz a sua vida máxima em 50% mas aumenta bastante a regeneração de vida");
                    Calamity.GetItem("RoseStone").DisplayName.AddTranslation(GameCulture.Portuguese, "Rocha da Rosa");
                    Calamity.GetItem("RoseStone").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma das relíquias antigas\nInvoca um elemental de enxofre para te proteger");
                    Calamity.GetItem("RoverDrive").DisplayName.AddTranslation(GameCulture.Portuguese, "Rover Drive");
                    Calamity.GetItem("RoverDrive").Tooltip.AddTranslation(GameCulture.Portuguese, "Ativa um escudo protetor que concede 10 defesa por 10 segundos\nO escudo então se dissipa e recarrega por 20 segundos antes de ser reativado");
                    Calamity.GetItem("SeaShell").DisplayName.AddTranslation(GameCulture.Portuguese, "Concha do Mar");
                    Calamity.GetItem("SeaShell").Tooltip.AddTranslation(GameCulture.Portuguese, "Maior defesa e redução dos danos quando submerso em líquidos\nMaior velocidade dos movimento quando submerso em líquidos");
                    Calamity.GetItem("ShieldoftheOcean").DisplayName.AddTranslation(GameCulture.Portuguese, "Escudo do Oceano");
                    Calamity.GetItem("ShieldoftheOcean").Tooltip.AddTranslation(GameCulture.Portuguese, "Maior defesa em 5 quando submerso em líquidos\nAumenta a velocidade dos movimentos e regeneração de vida ao vestir a armadura de Vimaré");
                    Calamity.GetItem("StressPills").DisplayName.AddTranslation(GameCulture.Portuguese, "Pílulas de Estresse");
                    Calamity.GetItem("StressPills").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a sua defesa em 4 e velocidade dos movimentos máxima em 5%\nReceber um golpe faz com que você perca apenas metade de sua adrenalina máxima, em vez de perder ela completamente\nEspólio do modo Vingança");
                    Calamity.GetItem("TheAbsorber").DisplayName.AddTranslation(GameCulture.Portuguese, "O Absorvedor");
                    Calamity.GetItem("TheAbsorber").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento na velocidade dos movimentos e na velocidade dos pulos\n+20 vida e mana máxima\nFicar parado aumenta a regeneração de vida e mana\nMaior defesa, velocidade dos movimentos e redução dos danos quando submerso em líquidos\nInimigos sofrem danos quando te atacam\nVocê emite uma explosão de esporos de cogumelo e faíscas quando atingido\n10% de aumento na redução dos danos\n5% do dano de ataques inimigos é absorvido e convertido em cura");
                    Calamity.GetItem("TheCamper").DisplayName.AddTranslation(GameCulture.Portuguese, "O Campista");
                    Calamity.GetItem("TheCamper").Tooltip.AddTranslation(GameCulture.Portuguese, "No descanso, podemos encontrar a vitória.\nVocê causa 90% menos de dano a menos que esteja estacionário\nFicar parado concede efeito(s) dependendo da arma que você está segurando\nFicar parado fornece uma aura que machuca ao seu redor\nEnquanto se move, você regenera vida como se estivesse parado\nFornece uma quantidade pequena de luz no Abismo");
                    Calamity.GetItem("TheCommunity").DisplayName.AddTranslation(GameCulture.Portuguese, "A Comunidade");
                    Calamity.GetItem("TheCommunity").Tooltip.AddTranslation(GameCulture.Portuguese, "O coração (da maioria) da comunidade do Terraria\nComeça com reforços fracos para todas as suas estatísticas\nOs reforços de estatísticas tornam-se mais poderosos conforme você avança\nReduz os efeitos de dano ao longo do tempo de efeitos negativos que o danificam infligidos a você\nAumenta seu tempo máximo de voô em 15%\nObrigado a todos os meus apoiadores que tornaram este mod uma realidade");
                    Calamity.GetItem("TheEvolution").DisplayName.AddTranslation(GameCulture.Portuguese, "A Evolução");
                    Calamity.GetItem("TheEvolution").Tooltip.AddTranslation(GameCulture.Portuguese, "Você reflete projéteis quando eles o atingem\nProjéteis refletidos não causam danos a você\nEste reflexo tem um tempo de recarga de 120 segundos que é compartilhado com todos os outros desvios e reflexos\nSe este efeito for ativado, você recebe um reforço de regeneração de vida por 5 segundos\nSe o mesmo tipo de projétil inimigo o atingir novamente, você resistirá ao dano em 15%");
                    Calamity.GetItem("Sponge").DisplayName.AddTranslation(GameCulture.Portuguese, "A Esponja");
                    Calamity.GetItem("Sponge").Tooltip.AddTranslation(GameCulture.Portuguese, "15% de aumento na redução dos danos\n+30 vida e mana máxima\n5% de aumento na velocidade dos movimentos e velocidade dos pulos\nFicar parado aumenta a regeneração de vida e mana\nInimigos sofrem danos quando te atacam\nVocê emite uma explosão de esporos de cogumelo e faíscas quando atingido\n6.25% do dano de ataques inimigos é absorvido e convertido em cura");
                    Calamity.GetItem("TheTransformer").DisplayName.AddTranslation(GameCulture.Portuguese, "O Transformador");
                    Calamity.GetItem("TheTransformer").Tooltip.AddTranslation(GameCulture.Portuguese, "Sofrer danos libera uma explosão de faíscas\nImune a Eletrizado e você resiste a todos os danos de projéteis e inimigos elétricos\nProjéteis inimigos causam metade do dano a você e são refletidas de volta para o inimigo em 800% do dano original");
                    Calamity.GetItem("TrinketofChi").DisplayName.AddTranslation(GameCulture.Portuguese, "Amuleto de Chi");
                    Calamity.GetItem("TrinketofChi").Tooltip.AddTranslation(GameCulture.Portuguese, "Após 1 segundo de ficar parado e não atacar você ganha um efeito\nO efeito aumenta seu dano em 50% e diminui o dano recebido em 15%\nO efeito é desativado se você mover ou atacar uma vez");
                    Calamity.GetItem("UrsaSergeant").DisplayName.AddTranslation(GameCulture.Portuguese, "Ursa Sargento");
                    Calamity.GetItem("UrsaSergeant").Tooltip.AddTranslation(GameCulture.Portuguese, "+20 defesa mas 35% de redução na velocidade dos movimentos\nImune a Infecção astral e Mordida Feroz\nAumento na regeneração de vida quando você estiver com vida baixa");

                    //Mining
                    Calamity.GetItem("AncientFossil").DisplayName.AddTranslation(GameCulture.Portuguese, "Fóssil Antigo");
                    Calamity.GetItem("AncientFossil").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a velocidade da picareta em 15% enquanto no subterrâneo");
                    Calamity.GetItem("ArchaicPowder").DisplayName.AddTranslation(GameCulture.Portuguese, "Pó Arcaico");
                    Calamity.GetItem("ArchaicPowder").Tooltip.AddTranslation(GameCulture.Portuguese, "20% de aumento na velocidade de mineração, 5% de redução dos danos, e +10 defesa enquanto no subterrâneo ou no submundo");
                    Calamity.GetItem("ChaosAmulet").DisplayName.AddTranslation(GameCulture.Portuguese, "Amuleto do Caos");
                    Calamity.GetItem("ChaosAmulet").Tooltip.AddTranslation(GameCulture.Portuguese, "Efeito espeleólogo e aumento na regeneração de vida");

                    //Fishing
                    Calamity.GetItem("AlluringBait").DisplayName.AddTranslation(GameCulture.Portuguese, "Isca Encantadora");
                    Calamity.GetItem("AlluringBait").Tooltip.AddTranslation(GameCulture.Portuguese, "30 de aumento no poder de pescaria durante o dia\n45 de aumento no poder de pescaria durante a noite\n60 de aumento no poder de pescaria durante um eclipse solar\nAumenta bastante a chance de pescar peixes que são ingredientes de poção");
                    Calamity.GetItem("EnchantedPearl").DisplayName.AddTranslation(GameCulture.Portuguese, "Pérola Encantada");
                    Calamity.GetItem("EnchantedPearl").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a habilidade de pesca\nAumenta a chance de pescar caixotes");
                    Calamity.GetItem("SupremeBaitTackleBoxFishingStation").DisplayName.AddTranslation(GameCulture.Portuguese, "Estação de Pesca com Caixa de Equipamento de Isca Suprema");
                    Calamity.GetItem("SupremeBaitTackleBoxFishingStation").Tooltip.AddTranslation(GameCulture.Portuguese, "O acessório de pesca supremo\nAumenta a habilidade de pesca em 80\nA linha de pesca nunca quebra e diminui as chances de consumo de iscas\nAumenta a chance de pescar caixotes\nEfeito da poção Sonar");

                    //Miscellaneous
                    Calamity.GetItem("MagicLevelMeter").DisplayName.AddTranslation(GameCulture.Portuguese, "Medidor de Nível Mágico");
                    Calamity.GetItem("MeleeLevelMeter").DisplayName.AddTranslation(GameCulture.Portuguese, "Medidor de Nível Físico");
                    Calamity.GetItem("RangedLevelMeter").DisplayName.AddTranslation(GameCulture.Portuguese, "Medidor de Nível Á Distância");
                    Calamity.GetItem("RogueLevelMeter").DisplayName.AddTranslation(GameCulture.Portuguese, "Medidor de Nível Ladino");
                    Calamity.GetItem("SummonLevelMeter").DisplayName.AddTranslation(GameCulture.Portuguese, "Medidor de Nível Invocador");
                    Calamity.GetItem("CheatTestThing").DisplayName.AddTranslation(GameCulture.Portuguese, "lul");
                    Calamity.GetItem("CheatTestThing").Tooltip.AddTranslation(GameCulture.Portuguese, "Mata você instantaneamente...\nMas talvez...?");
                    Calamity.GetItem("Popo").DisplayName.AddTranslation(GameCulture.Portuguese, "Cachecol e Chapéu Mágico");
                    Calamity.GetItem("Popo").Tooltip.AddTranslation(GameCulture.Portuguese, "Não deixe os demônios roubarem o seu nariz\nTransforma o usuário em um boneco de neve");

                    ///Ammo
                    //Arrows
                    Calamity.GetItem("ArcticArrow").DisplayName.AddTranslation(GameCulture.Portuguese, "Flecha Ártica");
                    Calamity.GetItem("ArcticArrow").Tooltip.AddTranslation(GameCulture.Portuguese, "Congela os inimigos por um curto período de tempo");
                    Calamity.GetItem("BloodfireArrow").DisplayName.AddTranslation(GameCulture.Portuguese, "Flecha do Fogo Sangrento");
                    Calamity.GetItem("BloodfireArrow").Tooltip.AddTranslation(GameCulture.Portuguese, "Cura você uma pequena quantidade quando atinge o inimigo");
                    Calamity.GetItem("ElysianArrow").DisplayName.AddTranslation(GameCulture.Portuguese, "Flecha do Elísio");
                    Calamity.GetItem("ElysianArrow").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca meteoros do céu na morte");
                    Calamity.GetItem("IcicleArrow").DisplayName.AddTranslation(GameCulture.Portuguese, "Flecha de Gelo");
                    Calamity.GetItem("IcicleArrow").Tooltip.AddTranslation(GameCulture.Portuguese, "Se quebra em fragmentos no impacto");
                    Calamity.GetItem("NapalmArrow").DisplayName.AddTranslation(GameCulture.Portuguese, "Flecha de Napalm");
                    Calamity.GetItem("NapalmArrow").Tooltip.AddTranslation(GameCulture.Portuguese, "Explode em estilhaços de fogo");
                    Calamity.GetItem("TerraArrow").DisplayName.AddTranslation(GameCulture.Portuguese, "Flecha da Terra");
                    Calamity.GetItem("TerraArrow").Tooltip.AddTranslation(GameCulture.Portuguese, "Viaja incrivelmente rápido e explode em mais flechas quando atinge uma determinada velocidade");
                    Calamity.GetItem("VanquisherArrow").DisplayName.AddTranslation(GameCulture.Portuguese, "Flecha do Vencedor");
                    Calamity.GetItem("VanquisherArrow").Tooltip.AddTranslation(GameCulture.Portuguese, "Perfura peças\nGera flechas teleguiadas extras enquanto viaja");

                    //Bullets
                    Calamity.GetItem("AccelerationBullet").DisplayName.AddTranslation(GameCulture.Portuguese, "Tiro de Aceleração");
                    Calamity.GetItem("AccelerationBullet").Tooltip.AddTranslation(GameCulture.Portuguese, "Ganha velocidade com o tempo");
                    Calamity.GetItem("AcidBullet").DisplayName.AddTranslation(GameCulture.Portuguese, "Tiro Ácido");
                    Calamity.GetItem("AcidBullet").Tooltip.AddTranslation(GameCulture.Portuguese, "Explode em ácido que inflige a praga\nCausa mais dano quanto maior for a defesa do alvo");
                    Calamity.GetItem("BloodfireBullet").DisplayName.AddTranslation(GameCulture.Portuguese, "Projétil de Fogo Sangrento");
                    Calamity.GetItem("BloodfireBullet").Tooltip.AddTranslation(GameCulture.Portuguese, "Acelera a sua regeneração de vida ao entrar em contato\nCausa dano bônus com base em sua regeneração de vida atual");
                    Calamity.GetItem("EnhancedNanoRound").DisplayName.AddTranslation(GameCulture.Portuguese, "Nano-Tiro Melhorado");
                    Calamity.GetItem("EnhancedNanoRound").Tooltip.AddTranslation(GameCulture.Portuguese, "Confunde os inimigos e libera uma nuvem de nanobôs quando os inimigos morrem");
                    Calamity.GetItem("FlashBullet").DisplayName.AddTranslation(GameCulture.Portuguese, "Tiro Brilhante");
                    Calamity.GetItem("FlashBullet").Tooltip.AddTranslation(GameCulture.Portuguese, "Emite uma explosão contundente que confunde os inimigos em uma grande área por um curto período de tempo");
                    Calamity.GetItem("GodSlayerSlug").DisplayName.AddTranslation(GameCulture.Portuguese, "Bala Assassina de Deuses");
                    Calamity.GetItem("GodSlayerSlug").Tooltip.AddTranslation(GameCulture.Portuguese, "Munição pesada com perfuração ilimitada que dilacera o espaço-tempo\nDepois que uma bala acerta, se ela atingir uma parede ou ficar sem alvos para perfurar,\nela se dobra para trás através do espaço e sobrecarrega, explodindo com o impacto");
                    Calamity.GetItem("HolyFireBullet").DisplayName.AddTranslation(GameCulture.Portuguese, "Projétil do Fogo Sagrado");
                    Calamity.GetItem("HolyFireBullet").Tooltip.AddTranslation(GameCulture.Portuguese, "Balas sagradas explosivas");
                    Calamity.GetItem("HyperiusBullet").DisplayName.AddTranslation(GameCulture.Portuguese, "Projétil de Hipério");
                    Calamity.GetItem("HyperiusBullet").Tooltip.AddTranslation(GameCulture.Portuguese, "Seus inimigos podem ter um momento ruim\nGera projéteis adicionais ao atingir inimigos");
                    Calamity.GetItem("IcyBullet").DisplayName.AddTranslation(GameCulture.Portuguese, "Projétil Gelado");
                    Calamity.GetItem("IcyBullet").Tooltip.AddTranslation(GameCulture.Portuguese, "Pode acertar até três vezes\nSe quebra em pedaços de gelo no impacto");
                    Calamity.GetItem("MortarRound").DisplayName.AddTranslation(GameCulture.Portuguese, "Tiro de Morteiro");
                    Calamity.GetItem("MortarRound").Tooltip.AddTranslation(GameCulture.Portuguese, "Grande raio de impacto. Destrói peças\nUsado por armas normais");
                    Calamity.GetItem("RubberMortarRound").DisplayName.AddTranslation(GameCulture.Portuguese, "Tiro de Morteiro de Borracha");
                    Calamity.GetItem("RubberMortarRound").Tooltip.AddTranslation(GameCulture.Portuguese, "Grande raio de impacto\nDestrói peças a cada ricochete\nUsado por armas normais");
                    Calamity.GetItem("SuperballBullet").DisplayName.AddTranslation(GameCulture.Portuguese, "Projétil da Superbola");
                    Calamity.GetItem("SuperballBullet").Tooltip.AddTranslation(GameCulture.Portuguese, "Ricocheteia em velocidades extremas");
                    Calamity.GetItem("TerraBullet").DisplayName.AddTranslation(GameCulture.Portuguese, "Projétil da Terra");
                    Calamity.GetItem("TerraBullet").Tooltip.AddTranslation(GameCulture.Portuguese, "Explode e se divide em fragmentos de terra teleguiados na morte");
                    Calamity.GetItem("VeriumBullet").DisplayName.AddTranslation(GameCulture.Portuguese, "Projétil de Vério");
                    Calamity.GetItem("VeriumBullet").Tooltip.AddTranslation(GameCulture.Portuguese, "Não há como fugir!\nTeleguia depois de acertar um inimigo");

                    //Other
                    Calamity.GetItem("BloodRune").DisplayName.AddTranslation(GameCulture.Portuguese, "Runa do Sangue");
                    Calamity.GetItem("BloodRune").Tooltip.AddTranslation(GameCulture.Portuguese, "Usado com a Barragem de Gelo\nEncontrado em algum tipo de paisagem rúnica");
                    Calamity.GetItem("ExplosiveShells").DisplayName.AddTranslation(GameCulture.Portuguese, "Cartucho de Espingarda Explosivo");
                    Calamity.GetItem("GrenadeRounds").DisplayName.AddTranslation(GameCulture.Portuguese, "Cartucho de Granada");
                    Calamity.GetItem("MagnumRounds").DisplayName.AddTranslation(GameCulture.Portuguese, "Tiro de Magnum");

                    //Ammo used by tools
                    Calamity.GetItem("AstralSolution").DisplayName.AddTranslation(GameCulture.Portuguese, "Solução Astral");
                    Calamity.GetItem("AstralSolution").Tooltip.AddTranslation(GameCulture.Portuguese, "Utilizado pelo Limpaminador\nEspalha a Infecção Astral");

                    //Bait
                    Calamity.GetItem("ArcturusAstroidean").DisplayName.AddTranslation(GameCulture.Portuguese, "Arcturo Astroideano");
                    Calamity.GetItem("ArcturusAstroidean").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta o poder de pescaria se usado na Infecção Astral ou no Mar Sulfuroso");
                    Calamity.GetItem("BloodwormItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Verme de Sangue");
                    Calamity.GetItem("TwinklerItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Inseto Cintilante");

                    ////Armor
                    Calamity.GetItem("WulfrumHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo de Vulfrânio");
                    Calamity.GetItem("WulfrumHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por ataques físicos");
                    Calamity.GetItem("WulfrumHeadgear").DisplayName.AddTranslation(GameCulture.Portuguese, "Capacete de Vulfrânio");
                    Calamity.GetItem("WulfrumHeadgear").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por ataque à distância");
                    Calamity.GetItem("WulfrumHood").DisplayName.AddTranslation(GameCulture.Portuguese, "Protetor Facial de Vulfrânio");
                    Calamity.GetItem("WulfrumHood").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por magia");
                    Calamity.GetItem("WulfrumHelmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Casco de Vulfrânio");
                    Calamity.GetItem("WulfrumHelmet").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por lacaios");
                    Calamity.GetItem("WulfrumMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Vulfrânio");
                    Calamity.GetItem("WulfrumMask").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por ataques ladinos");
                    Calamity.GetItem("WulfrumArmor").DisplayName.AddTranslation(GameCulture.Portuguese, "Armadura de Vulfrânio");
                    Calamity.GetItem("WulfrumArmor").Tooltip.AddTranslation(GameCulture.Portuguese, "3% de aumento na chance de acerto crítico");
                    Calamity.GetItem("WulfrumLeggings").DisplayName.AddTranslation(GameCulture.Portuguese, "Calças de Vulfrânio");
                    Calamity.GetItem("WulfrumLeggings").Tooltip.AddTranslation(GameCulture.Portuguese, "Velocidade dos movimentos aumentada em 5%");
                    Calamity.GetItem("SnowRuffianMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Rufião das Neves");
                    Calamity.GetItem("SnowRuffianMask").Tooltip.AddTranslation(GameCulture.Portuguese, "2% de aumento nos danos por ataques ladinos");
                    Calamity.GetItem("SnowRuffianChestplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Peitoral do Rufião das Neves");
                    Calamity.GetItem("SnowRuffianChestplate").Tooltip.AddTranslation(GameCulture.Portuguese, "3% de aumento na chance de ataque ladino crítico");
                    Calamity.GetItem("SnowRuffianGreaves").DisplayName.AddTranslation(GameCulture.Portuguese, "Grevas do Rufião das Neves");
                    Calamity.GetItem("SnowRuffianGreaves").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("DesertProwlerHat").DisplayName.AddTranslation(GameCulture.Portuguese, "Chapéu do Gatuno do Deserto");
                    Calamity.GetItem("DesertProwlerHat").Tooltip.AddTranslation(GameCulture.Portuguese, "4% de aumento na chance de ataque à distância crítico e 20% de chance de não consumir munição");
                    Calamity.GetItem("DesertProwlerShirt").DisplayName.AddTranslation(GameCulture.Portuguese, "Camisa do Gatuno do Deserto");
                    Calamity.GetItem("DesertProwlerShirt").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento na chance de ataque à distância crítico");
                    Calamity.GetItem("DesertProwlerPants").DisplayName.AddTranslation(GameCulture.Portuguese, "Calça do Gatuno do Deserto");
                    Calamity.GetItem("DesertProwlerPants").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento na velocidade dos movimentos e imunidade ao efeito negativo Vento Poderoso");
                    Calamity.GetItem("VictideHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo de Vimaré");
                    Calamity.GetItem("VictideHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento nos danos por ataques físicos");
                    Calamity.GetItem("VictideVisage").DisplayName.AddTranslation(GameCulture.Portuguese, "Protetor Facial de Vimaré");
                    Calamity.GetItem("VictideVisage").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento nos danos por ataque à distância");
                    Calamity.GetItem("VictideMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Vimaré");
                    Calamity.GetItem("VictideMask").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento nos danos por magia");
                    Calamity.GetItem("VictideHelmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Casco de Vimaré");
                    Calamity.GetItem("VictideHelmet").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por lacaios");
                    Calamity.GetItem("VictideHeadgear").DisplayName.AddTranslation(GameCulture.Portuguese, "Capacete de Vimaré");
                    Calamity.GetItem("VictideHeadgear").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento nos danos por ataques ladinos");
                    Calamity.GetItem("VictideBreastplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Peitoral de Vimaré");
                    Calamity.GetItem("VictideBreastplate").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento na redução dos danos e chance de acerto crítico\n+5 defesa e 10% de aumento nos danos enquanto submerso em líquidos");
                    Calamity.GetItem("VictideLeggings").DisplayName.AddTranslation(GameCulture.Portuguese, "Calças de Vimaré");
                    Calamity.GetItem("VictideLeggings").Tooltip.AddTranslation(GameCulture.Portuguese, "Velocidade dos movimentos aumentada em 8%\nVelocidade dos movimentos aumentada em 30% enquanto submerso em líquidos");
                    Calamity.GetItem("SulfurHelmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo Sulfúrico");
                    Calamity.GetItem("SulfurHelmet").Tooltip.AddTranslation(GameCulture.Portuguese, "4% de aumento nos danos por ataques ladinos\n2% de aumento na chance de acerto ladino crítico\nPermite respirar embaixo d'água");
                    Calamity.GetItem("SulfurBreastplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Peitoral Sulfúrico");
                    Calamity.GetItem("SulfurBreastplate").Tooltip.AddTranslation(GameCulture.Portuguese, "8% de danos por ataques ladinos e 5% de chance de ataque crítico");
                    Calamity.GetItem("SulfurLeggings").DisplayName.AddTranslation(GameCulture.Portuguese, "Calças Sulfúricas");
                    Calamity.GetItem("SulfurLeggings").Tooltip.AddTranslation(GameCulture.Portuguese, "Velocidade dos movimentos aumentada em 10%\nVelocidade dos movimentos aumentada em 35% enquanto em líquidos");
                    Calamity.GetItem("AerospecHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo Aéreo");
                    Calamity.GetItem("AerospecHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "8% de aumento nos danos por ataques físicos");
                    Calamity.GetItem("AerospecHood").DisplayName.AddTranslation(GameCulture.Portuguese, "Capuz Aéreo");
                    Calamity.GetItem("AerospecHood").Tooltip.AddTranslation(GameCulture.Portuguese, "8% de aumento nos danos por ataque à distância");
                    Calamity.GetItem("AerospecHat").DisplayName.AddTranslation(GameCulture.Portuguese, "Chapéu Aéreo");
                    Calamity.GetItem("AerospecHat").Tooltip.AddTranslation(GameCulture.Portuguese, "8% de aumento nos danos por magia e +20 mana máxima");
                    Calamity.GetItem("AerospecHelmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Casco Aéreo");
                    Calamity.GetItem("AerospecHelmet").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento na velocidade dos movimentos e dano por lacaios");
                    Calamity.GetItem("AerospecHeadgear").DisplayName.AddTranslation(GameCulture.Portuguese, "Capacete Aéreo");
                    Calamity.GetItem("AerospecHeadgear").Tooltip.AddTranslation(GameCulture.Portuguese, "8% de aumento nos danos por ataques ladinos e 5% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("AerospecBreastplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Peitoral Aéreo");
                    Calamity.GetItem("AerospecBreastplate").Tooltip.AddTranslation(GameCulture.Portuguese, "3% de aumento na chance de acerto crítico");
                    Calamity.GetItem("AerospecLeggings").DisplayName.AddTranslation(GameCulture.Portuguese, "Calças Aéreas");
                    Calamity.GetItem("AerospecLeggings").Tooltip.AddTranslation(GameCulture.Portuguese, "12% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("StatigelHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo de Statigel");
                    Calamity.GetItem("StatigelHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento no dano por ataque físico e na velocidade de ataque físico\n7% de aumento na chance de ataque físico crítico");
                    Calamity.GetItem("StatigelHeadgear").DisplayName.AddTranslation(GameCulture.Portuguese, "Capacete de Statigel");
                    Calamity.GetItem("StatigelHeadgear").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por ataque à distância\n7% de aumento na chance de ataque à distância crítico");
                    Calamity.GetItem("StatigelCap").DisplayName.AddTranslation(GameCulture.Portuguese, "Boné de Statigel");
                    Calamity.GetItem("StatigelCap").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por magia e 10% de redução no custo de mana\n7% de aumento na chance de ataque mágico crítico e +30 mana máxima");
                    Calamity.GetItem("StatigelHood").DisplayName.AddTranslation(GameCulture.Portuguese, "Capuz de Statigel");
                    Calamity.GetItem("StatigelHood").Tooltip.AddTranslation(GameCulture.Portuguese, "Maior recuo dos lacaios");
                    Calamity.GetItem("StatigelMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Statigel");
                    Calamity.GetItem("StatigelMask").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos assasinos e 34% de chance de não consumir itens arremessados\n7% de aumento na chance de ataque ladino crítico e 12% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("StatigelArmor").DisplayName.AddTranslation(GameCulture.Portuguese, "Armadura de Statigel");
                    Calamity.GetItem("StatigelArmor").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento na chance de acerto crítico");
                    Calamity.GetItem("StatigelGreaves").DisplayName.AddTranslation(GameCulture.Portuguese, "Grevas de Statigel");
                    Calamity.GetItem("StatigelGreaves").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento nos danos e na velocidade dos movimentos");
                    Calamity.GetItem("MolluskShellmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo-concha de Molusco");
                    Calamity.GetItem("MolluskShellmet").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento nos danos e 4% de aumento na chance de acerto crítico\nVocê pode se mover livremente em líquidos");
                    Calamity.GetItem("MolluskShellplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Peitoral-concha de Molusco");
                    Calamity.GetItem("MolluskShellplate").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos e 6% de aumento na chance de acerto crítico\n15% de redução na velocidade dos movimentos");
                    Calamity.GetItem("MolluskShelleggings").DisplayName.AddTranslation(GameCulture.Portuguese, "Calças-concha de Molusco");
                    Calamity.GetItem("MolluskShelleggings").Tooltip.AddTranslation(GameCulture.Portuguese, "12% de aumento nos danos e 4% de aumento na chance de acerto crítico\n7% de redução na velocidade dos movimentos");
                    Calamity.GetItem("TitanHeartMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Coração do Titã");
                    Calamity.GetItem("TitanHeartMask").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento no dano e recuo ladino\nArmas ladinas espalham a infecção astral");
                    Calamity.GetItem("TitanHeartMantle").DisplayName.AddTranslation(GameCulture.Portuguese, "Manto do Coração do Titã");
                    Calamity.GetItem("TitanHeartMantle").Tooltip.AddTranslation(GameCulture.Portuguese, "45% de chance de não consumir itens ladinos\n5% de aumento no recuo ladino mas 15% de redução na velocidade de tiro ladina");
                    Calamity.GetItem("TitanHeartBoots").DisplayName.AddTranslation(GameCulture.Portuguese, "Botas do Coração do Titã");
                    Calamity.GetItem("TitanHeartBoots").Tooltip.AddTranslation(GameCulture.Portuguese, "4% de aumento nos danos assasinos, 10% de aumento na velocidade de projéteis ladinos, e 5% de aumento no recuo ladino");
                    Calamity.GetItem("DaedalusHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo de Dédalo");
                    Calamity.GetItem("DaedalusHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por ataque físico e na chance de ataque crítico\n10% de aumento na velocidade do ataque físico e do movimento");
                    Calamity.GetItem("DaedalusHelmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Capacete de Dédalo");
                    Calamity.GetItem("DaedalusHelmet").Tooltip.AddTranslation(GameCulture.Portuguese, "13% de aumento nos danos por ataque à distância e 7% de aumento na chance de ataque à distância crítico\nReduz o custo de munição em 20%");
                    Calamity.GetItem("DaedalusHat").DisplayName.AddTranslation(GameCulture.Portuguese, "Capuz de Dédalo");
                    Calamity.GetItem("DaedalusHat").Tooltip.AddTranslation(GameCulture.Portuguese, "13% de aumento nos danos por magia e 7% de aumento na chance de acerto crítico mágico\n10% de redução no uso de mana e +60 mana máxima");
                    Calamity.GetItem("DaedalusHeadgear").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Dédalo");
                    Calamity.GetItem("DaedalusHeadgear").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento nos danos por lacaios");
                    Calamity.GetItem("DaedalusVisor").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara Facial de Dédalo");
                    Calamity.GetItem("DaedalusVisor").Tooltip.AddTranslation(GameCulture.Portuguese, "13% de aumento nos danos por ataques ladinos e 7% de aumento na chance de ataque ladino crítico, aumenta a velocidade de projéteis ladinos em 15%\n17% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("DaedalusBreastplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Peitoral de Dédalo");
                    Calamity.GetItem("DaedalusBreastplate").Tooltip.AddTranslation(GameCulture.Portuguese, "3% de aumento nos danos e na chance de ataque crítico");
                    Calamity.GetItem("DaedalusLeggings").DisplayName.AddTranslation(GameCulture.Portuguese, "Calças de Dédalo");
                    Calamity.GetItem("DaedalusLeggings").Tooltip.AddTranslation(GameCulture.Portuguese, "3% de aumento na chance de acerto crítico\n10% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("BrimflameScowl").DisplayName.AddTranslation(GameCulture.Portuguese, "Capuz de Chamas de Enxofre");
                    Calamity.GetItem("BrimflameScowl").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento nos danos por magia e na chance de acerto crítico\nAumenta a mana máxima em 70 e reduz o uso de mana em 10%\nImunidade a Em chamas! Chamas de enxofre, e Queimadura de gelo");
                    Calamity.GetItem("BrimflameRobes").DisplayName.AddTranslation(GameCulture.Portuguese, "Roupão de Chamas de Enxofre");
                    Calamity.GetItem("BrimflameRobes").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento nos danos por magia e na chance de acerto crítico\nOferece efeitos da rosa de obsidiana");
                    Calamity.GetItem("BrimflameBoots").DisplayName.AddTranslation(GameCulture.Portuguese, "Botas de Chamas de Enxofre");
                    Calamity.GetItem("BrimflameBoots").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento nos danos por magia\n5% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("FathomSwarmerVisage").DisplayName.AddTranslation(GameCulture.Portuguese, "Protetor Facial do Enxame das Profundezas");
                    Calamity.GetItem("FathomSwarmerVisage").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento nos danos por lacaios\nFornece respiração e luz embaixo d\u0027água");
                    Calamity.GetItem("FathomSwarmerBreastplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Peitoral do Enxame das Profundezas");
                    Calamity.GetItem("FathomSwarmerBreastplate").Tooltip.AddTranslation(GameCulture.Portuguese, "6% de aumento na redução dos danos\n6% de aumento nos danos por lacaios\nDefesa e regeneração de vida aumentadas quando submerso em líquidos\nReduz a perda de defesa dentro do Abismo");
                    Calamity.GetItem("FathomSwarmerBoots").DisplayName.AddTranslation(GameCulture.Portuguese, "Botas do Enxame das Profundezas");
                    Calamity.GetItem("FathomSwarmerBoots").Tooltip.AddTranslation(GameCulture.Portuguese, "4% de aumento nos danos por lacaios\nOferece a capacidade de nadar\nA velocidade dos movimentos é aumentada em 40% enquanto submerso em líquidos");
                    Calamity.GetItem("UmbraphileHood").DisplayName.AddTranslation(GameCulture.Portuguese, "Capuz de Umbrafile");
                    Calamity.GetItem("UmbraphileHood").Tooltip.AddTranslation(GameCulture.Portuguese, "8% de aumento nos danos por ataques ladinos e 10% de aumento na velocidade de projéteis ladinos");
                    Calamity.GetItem("UmbraphileRegalia").DisplayName.AddTranslation(GameCulture.Portuguese, "Regalia de Umbrafile");
                    Calamity.GetItem("UmbraphileRegalia").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por ataques assasinos e 10% de aumento no crítico ladino");
                    Calamity.GetItem("UmbraphileBoots").DisplayName.AddTranslation(GameCulture.Portuguese, "Botas de Umbrafile");
                    Calamity.GetItem("UmbraphileBoots").Tooltip.AddTranslation(GameCulture.Portuguese, "9% de aumento nos danos por ataques ladinos e 6% de aumento no crítico ladino\n30% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("ReaverHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo do Ladrão");
                    Calamity.GetItem("ReaverHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "15% de aumento na redução dos danos mas 30% de redução nos danos\n+50 vida máxima\nRegenera um ponto de vida passivamente a cada segundo");
                    Calamity.GetItem("ReaverVisage").DisplayName.AddTranslation(GameCulture.Portuguese, "Protetor Facial do Ladrão");
                    Calamity.GetItem("ReaverVisage").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento na velocidade dos pulos e 25% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("ReaverHeadgear").DisplayName.AddTranslation(GameCulture.Portuguese, "Capacete do Ladrão");
                    Calamity.GetItem("ReaverHeadgear").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento na velocidade da picareta e 20% de aumento na velocidade do posicionamento de blocos/paredes\nImunidade temporária à lava e pode mover-se livremente em líquidos");
                    Calamity.GetItem("ReaverScaleMail").DisplayName.AddTranslation(GameCulture.Portuguese, "Armadura de Malha do Ladrão");
                    Calamity.GetItem("ReaverScaleMail").Tooltip.AddTranslation(GameCulture.Portuguese, "9% de aumento nos danos e 4% de aumento na chance de acerto crítico\n+20 vida máxima");
                    Calamity.GetItem("ReaverCuisses").DisplayName.AddTranslation(GameCulture.Portuguese, "Grevas do Ladrão");
                    Calamity.GetItem("ReaverCuisses").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento na chance de acerto crítico\n12% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("AtaxiaHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo Hidrotérmico");
                    Calamity.GetItem("AtaxiaHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "12% de aumento nos danos por ataques físicos e 10% de aumento na chance de ataque físico crítico\n12% de aumento na velocidade dos movimentos e do ataque físico\nAtaques físicos infligem Em chamas\nImunidade temporária à lava e imunidade a dano de fogo");
                    Calamity.GetItem("AtaxiaHeadgear").DisplayName.AddTranslation(GameCulture.Portuguese, "Capacete Hidrotérmico");
                    Calamity.GetItem("AtaxiaHeadgear").Tooltip.AddTranslation(GameCulture.Portuguese, "12% de aumento nos danos por ataque à distância e 10% de aumento na chance de ataque à distância crítico\nReduz o custo de munição em 25%, imunidade temporária à lava, e imunidade a dano de fogo");
                    Calamity.GetItem("AtaxiaMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara Hidrotérmica");
                    Calamity.GetItem("AtaxiaMask").Tooltip.AddTranslation(GameCulture.Portuguese, "12% de aumento nos danos por magia, +100 mana máxima, e 10% na chance de ataque mágico crítico\nImunidade temporária à lava e imunidade a dano de fogo");
                    Calamity.GetItem("AtaxiaHelmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Casco Hidrotérmico");
                    Calamity.GetItem("AtaxiaHelmet").Tooltip.AddTranslation(GameCulture.Portuguese, "5% de aumento nos danos por invocação e maior recuo dos lacaios\nImunidade temporária à lava e imunidade a dano de fogo");
                    Calamity.GetItem("AtaxiaHood").DisplayName.AddTranslation(GameCulture.Portuguese, "Capuz Hidrotérmico");
                    Calamity.GetItem("AtaxiaHood").Tooltip.AddTranslation(GameCulture.Portuguese, "12% de aumento nos danos por ataques ladinos e 10% de aumento na chance de acerto crítico ladino\n50% de chance de não consumir itens ladinos e 15% de aumento na velocidade dos movimentos\nImunidade temporária à lava e imunidade a dano de fogo");
                    Calamity.GetItem("AtaxiaArmor").DisplayName.AddTranslation(GameCulture.Portuguese, "Armadura Hidrotérmica");
                    Calamity.GetItem("AtaxiaArmor").Tooltip.AddTranslation(GameCulture.Portuguese, "+20 vida máxima\n8% de aumento nos danos e 4% de aumento na chance de acerto crítico");
                    Calamity.GetItem("AtaxiaSubligar").DisplayName.AddTranslation(GameCulture.Portuguese, "Subligar Hidrotérmico");
                    Calamity.GetItem("AtaxiaSubligar").Tooltip.AddTranslation(GameCulture.Portuguese, "3% de aumento na chance de acerto crítico\n15% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("PlagueReaperMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Ceifador da Praga");
                    Calamity.GetItem("PlagueReaperMask").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por ataque à distância e 8% de aumento na chance de ataque à distância crítico");
                    Calamity.GetItem("PlagueReaperVest").DisplayName.AddTranslation(GameCulture.Portuguese, "Colete do Ceifador da Praga");
                    Calamity.GetItem("PlagueReaperVest").Tooltip.AddTranslation(GameCulture.Portuguese, "Reduz o dano causado em você pela praga\n15% de aumento nos danos por ataque à distância e 5% de aumento na chance de ataque à distância crítico");
                    Calamity.GetItem("PlagueReaperStriders").DisplayName.AddTranslation(GameCulture.Portuguese, "Botas do Ceifador da Praga");
                    Calamity.GetItem("PlagueReaperStriders").Tooltip.AddTranslation(GameCulture.Portuguese, "3% de aumento na chance de acerto crítico à distância\n15% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("PlaguebringerVisor").DisplayName.AddTranslation(GameCulture.Portuguese, "Viseira do Portador da Peste");
                    Calamity.GetItem("PlaguebringerVisor").Tooltip.AddTranslation(GameCulture.Portuguese, "15% de aumento nos danos por lacaios\n+20 vida máxima");
                    Calamity.GetItem("PlaguebringerCarapace").DisplayName.AddTranslation(GameCulture.Portuguese, "Carapaça do Portador da Peste");
                    Calamity.GetItem("PlaguebringerCarapace").Tooltip.AddTranslation(GameCulture.Portuguese, "Reduz o dano causado em você pela praga\n12% de aumento nos danos por lacaios\nAbelhas amigáveis infligem a praga");
                    Calamity.GetItem("PlaguebringerPistons").DisplayName.AddTranslation(GameCulture.Portuguese, "Pistões do Portador da Peste");
                    Calamity.GetItem("PlaguebringerPistons").Tooltip.AddTranslation(GameCulture.Portuguese, "13% de aumento nos danos por lacaios e 15% de aumento na velocidade dos movimentos\nVocê cultiva flores na grama abaixo de você, com chance de cultivar plantas de tintura aleatórias em terra sem grama\nVocê invoca abelhas enquanto corre");
                    Calamity.GetItem("AstralHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo Astral");
                    Calamity.GetItem("AstralHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "Detecção de perigos");
                    Calamity.GetItem("AstralBreastplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Peitoral Astral");
                    Calamity.GetItem("AstralBreastplate").Tooltip.AddTranslation(GameCulture.Portuguese, "+80 mana máxima e +20 vida máxima\nDetecção de criaturas");
                    Calamity.GetItem("AstralLeggings").DisplayName.AddTranslation(GameCulture.Portuguese, "Calças Astrais");
                    Calamity.GetItem("AstralLeggings").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento na velocidade dos movimentos\nDetecção de tesouros e minérios");
                    Calamity.GetItem("XerocMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara Empírica");
                    Calamity.GetItem("XerocMask").Tooltip.AddTranslation(GameCulture.Portuguese, "Ira do cosmos\n11% de aumento nos danos por ataques ladinos e na chance de ataque crítico, 20% de aumento na velocidade dos movimentos\nImunidade temporária à lava");
                    Calamity.GetItem("XerocPlateMail").DisplayName.AddTranslation(GameCulture.Portuguese, "Manto Empírico");
                    Calamity.GetItem("XerocPlateMail").Tooltip.AddTranslation(GameCulture.Portuguese, "Armadura do cosmos\n+20 vida máxima\n7% de aumento nos danos por ataques ladinos e na chance de ataque crítico");
                    Calamity.GetItem("XerocCuisses").DisplayName.AddTranslation(GameCulture.Portuguese, "Grevas Empíricas");
                    Calamity.GetItem("XerocCuisses").Tooltip.AddTranslation(GameCulture.Portuguese, "Velocidade do cosmos\n5% de aumento nos danos por ataques ladinos e na chance de ataque crítico\n20% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("TarragonHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo de Estragão");
                    Calamity.GetItem("TarragonHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "Elmo do discípulo dos anciões\nImunidade temporária à lava\nVocê pode se mover livremente em líquidos\n5% de aumento na redução dos danos\n10% de aumento nos danos por ataque físico e na chance de ataque crítico");
                    Calamity.GetItem("TarragonVisage").DisplayName.AddTranslation(GameCulture.Portuguese, "Protetor Facial de Estragão");
                    Calamity.GetItem("TarragonVisage").Tooltip.AddTranslation(GameCulture.Portuguese, "Imunidade temporária à lava\nVocê pode se mover livremente em líquidos\n10% de aumento nos danos por ataque à distância e na chance de ataque crítico\n5% de aumento na redução dos danos");
                    Calamity.GetItem("TarragonMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Estragão");
                    Calamity.GetItem("TarragonMask").Tooltip.AddTranslation(GameCulture.Portuguese, "Imunidade temporária à lava\nVocê pode se mover livremente em líquidos\n20% de aumento nos danos por magia e 10% de aumento na chance de ataque crítico mágico\n5% de aumento na redução dos danos, +100 mana máxima, e 15% de redução no consumo de mana");
                    Calamity.GetItem("TarragonHornedHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo com Chifres de Estragão");
                    Calamity.GetItem("TarragonHornedHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "Imunidade temporária à lava\nVocê pode se mover livremente em líquidos\n5% de aumento na redução dos danos e nos danos por lacaios");
                    Calamity.GetItem("TarragonHelmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Casco de Estragão");
                    Calamity.GetItem("TarragonHelmet").Tooltip.AddTranslation(GameCulture.Portuguese, "Imunidade temporária à lava\nVocê pode se mover livremente em líquidos e 12% de aumento na velocidade dos movimentos\n10% de aumento nos danos por ataque ladino e na chance de ataque crítico\n5% de aumento na redução dos danos");
                    Calamity.GetItem("TarragonBreastplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Peitoral de Estragão");
                    Calamity.GetItem("TarragonBreastplate").Tooltip.AddTranslation(GameCulture.Portuguese, "Peitoral do exilador\n10% de aumento nos danos e 5% de aumento na chance de acerto crítico\n+2 regeneração de vida e +40 vida máxima");
                    Calamity.GetItem("TarragonLeggings").DisplayName.AddTranslation(GameCulture.Portuguese, "Calça de Estragão");
                    Calamity.GetItem("TarragonLeggings").Tooltip.AddTranslation(GameCulture.Portuguese, "Calças de um explorador fabuloso\n15% de aumento na velocidade dos movimentos\n6% de aumento nos danos e na chance de ataque crítico");
                    Calamity.GetItem("PrismaticHelmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo Prismático");
                    Calamity.GetItem("PrismaticHelmet").Tooltip.AddTranslation(GameCulture.Portuguese, "18% de aumento nos danos por magia e 12% de aumento no crítico mágico\n20% de redução dos danos não mágicos\nInimigos com menos de 500 de vida não causam danos\nIsto não ocorre enquanto um chefe estiver vivo");
                    Calamity.GetItem("PrismaticRegalia").DisplayName.AddTranslation(GameCulture.Portuguese, "Regalia Prismática");
                    Calamity.GetItem("PrismaticRegalia").Tooltip.AddTranslation(GameCulture.Portuguese, "12% de aumento nos danos por magia e 15% de aumento no crítico mágico\n20% de redução dos danos não mágicos\n+20 vida máxima e +40 mana máxima\nAtaques mágicos ocasionalmente disparam um par de foguetes teleguiados");
                    Calamity.GetItem("PrismaticGreaves").DisplayName.AddTranslation(GameCulture.Portuguese, "Grevas Prismáticas");
                    Calamity.GetItem("PrismaticGreaves").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por magia e 12% de aumento no crítico mágico\n20% de redução dos danos não mágicos\n10% de aumento no tempo de voô e 2% de aumento na velocidade dos pulos");
                    Calamity.GetItem("BloodflareMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Carneiro de Chamas Sangrentas");
                    Calamity.GetItem("BloodflareMask").Tooltip.AddTranslation(GameCulture.Portuguese, "Você pode se mover livremente em líquidos e possui imunidade temporária à lava\n10% de aumento nos danos por ataque físico e na chance de ataque crítico");
                    Calamity.GetItem("BloodflareHornedHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo com Chifres de Chamas Sangrentas");
                    Calamity.GetItem("BloodflareHornedHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "Você pode se mover livremente em líquidos e possui imunidade temporária à lava\n10% de aumento nos danos por ataque à distância e na chance de ataque crítico");
                    Calamity.GetItem("BloodflareHornedMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Capuz da Hidra de Chamas Sangrentas");
                    Calamity.GetItem("BloodflareHornedMask").Tooltip.AddTranslation(GameCulture.Portuguese, "Você pode se mover livremente em líquidos e possui imunidade temporária à lava\n20% de aumento nos danos por magia, 10% de aumento na chance de acerto crítico mágico, +100 mana máxima e 17% de redução no consumo de mana");
                    Calamity.GetItem("BloodflareHelmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo da Serpe de Chamas Sangrentas");
                    Calamity.GetItem("BloodflareHelmet").Tooltip.AddTranslation(GameCulture.Portuguese, "Você pode se mover livremente em líquidos e possui imunidade temporária à lava\n5% de aumento nos danos por lacaios");
                    Calamity.GetItem("BloodflareHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Demônio de Chamas Sangrentas");
                    Calamity.GetItem("BloodflareHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "Você pode se mover livremente em líquidos e possui imunidade temporária à lava\n10% de aumento no dano por ataques ladinos e na chance de acerto crítico, 15% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("BloodflareBodyArmor").DisplayName.AddTranslation(GameCulture.Portuguese, "Armadura Corporal de Chamas Sangrentas");
                    Calamity.GetItem("BloodflareBodyArmor").Tooltip.AddTranslation(GameCulture.Portuguese, "12% de aumento nos danos e 8% de aumento na chance de acerto crítico\nVocê regenera vida rapidamente e ganha +30 defesa enquanto está na lava\n+40 vida máxima");
                    Calamity.GetItem("BloodflareCuisses").DisplayName.AddTranslation(GameCulture.Portuguese, "Grevas de Chamas Sangrentas");
                    Calamity.GetItem("BloodflareCuisses").Tooltip.AddTranslation(GameCulture.Portuguese, "17% de aumento na velocidade dos movimentos, 10% de aumento nos danos e 7% de aumento na chance de acerto crítico");
                    Calamity.GetItem("OmegaBlueHelmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo Ômega Azul");
                    Calamity.GetItem("OmegaBlueHelmet").Tooltip.AddTranslation(GameCulture.Portuguese, "Você pode se mover livremente em líquidos\n12% de aumento nos danos e 8% de aumento na chance de acerto crítico\n+2 lacaios máximos");
                    Calamity.GetItem("OmegaBlueChestplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Peitoral Ômega Azul");
                    Calamity.GetItem("OmegaBlueChestplate").Tooltip.AddTranslation(GameCulture.Portuguese, "12% de aumento nos danos e 8% de aumento na chance de acerto crítico\nSeus ataques infligem Pressão das profundezas\nSem regeneração de vida positiva");
                    Calamity.GetItem("OmegaBlueLeggings").DisplayName.AddTranslation(GameCulture.Portuguese, "Tentáculos Ômega Azuis");
                    Calamity.GetItem("OmegaBlueLeggings").Tooltip.AddTranslation(GameCulture.Portuguese, "20% de aumento na velocidade dos movimentos\n12% de aumento nos danos e 8% de aumento na chance de acerto crítico");
                    Calamity.GetItem("GodSlayerHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Grande Elmo com Chifres do Assassino de Deuses");
                    Calamity.GetItem("GodSlayerHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "14% de aumento nos danos por ataque físico e na chance de ataque crítico");
                    Calamity.GetItem("GodSlayerHelmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Capacete do Assassino de Deuses");
                    Calamity.GetItem("GodSlayerHelmet").Tooltip.AddTranslation(GameCulture.Portuguese, "14% de aumento nos danos por ataque à distância e na chance de ataque crítico");
                    Calamity.GetItem("GodSlayerVisage").DisplayName.AddTranslation(GameCulture.Portuguese, "Protetor Facial do Assassino de Deuses");
                    Calamity.GetItem("GodSlayerHornedHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo com Chifres do Assassino de Deuses");
                    Calamity.GetItem("GodSlayerMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Assassino de Deuses");
                    Calamity.GetItem("GodSlayerMask").Tooltip.AddTranslation(GameCulture.Portuguese, "14% de aumento nos danos por ataque ladino e na chance de ataque crítico, 18% de aumento na velocidade dos movimentos");
                    Calamity.GetItem("GodSlayerChestplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Peitoral do Assassino de Deuses");
                    Calamity.GetItem("GodSlayerChestplate").Tooltip.AddTranslation(GameCulture.Portuguese, "+60 vida máxima\nInimigos sofrem danos quando te acertam\n11% de aumento na velocidade dos movimentos e 6% de aumento na chance de acerto crítico");
                    Calamity.GetItem("GodSlayerLeggings").DisplayName.AddTranslation(GameCulture.Portuguese, "Calça do Assassino de Deuses");
                    Calamity.GetItem("GodSlayerLeggings").Tooltip.AddTranslation(GameCulture.Portuguese, "18% de aumento na velocidade dos movimentos\n10% de aumento no dano e 6% de aumento na chance de acerto crítico");
                    Calamity.GetItem("FearmongerGreathelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Grande Elmo Amedrontador");
                    Calamity.GetItem("FearmongerGreathelm").Tooltip.AddTranslation(GameCulture.Portuguese, "Puro terror irradia de seus olhos\n+60 mana máxima e 10% de redução no consumo de mana\n10% de aumento nos danos por lacaios");
                    Calamity.GetItem("FearmongerPlateMail").DisplayName.AddTranslation(GameCulture.Portuguese, "Armadura de Placas Amedrontadoras");
                    Calamity.GetItem("FearmongerPlateMail").Tooltip.AddTranslation(GameCulture.Portuguese, "+100 vida máxima e 8% de aumento na redução dos danos\n5% de aumento nos danos e na chance de ataque crítico");
                    Calamity.GetItem("FearmongerGreaves").DisplayName.AddTranslation(GameCulture.Portuguese, "Grevas Amedrontadoras");
                    Calamity.GetItem("FearmongerGreaves").Tooltip.AddTranslation(GameCulture.Portuguese, "6% de aumento nos danos\n50% de aumento no recuo dos lacaios\n10% de aumento na velocidade dos movimentos\nSofrer danos faz com que você se mova muito rápido por um curto período de tempo");
                    Calamity.GetItem("GemTechHeadgear").DisplayName.AddTranslation(GameCulture.Portuguese, "Capacete da Tecnologia das Joias");
                    Calamity.GetItem("GemTechHeadgear").Tooltip.AddTranslation(GameCulture.Portuguese, "O Diabo disse: Deleite-se com sua vitória; Você ganhou sua condenação. Arrume suas coisas e vá embora.");
                    Calamity.GetItem("GemTechBodyArmor").DisplayName.AddTranslation(GameCulture.Portuguese, "Armadura Corporal da Tecnologia das Joias");
                    Calamity.GetItem("GemTechBodyArmor").Tooltip.AddTranslation(GameCulture.Portuguese, "Você afundou o suficiente para eu o alcançar.");
                    Calamity.GetItem("GemTechBodyArmor").Tooltip.AddTranslation(GameCulture.Portuguese, "Você afundou o suficiente para eu o alcançar.");
                    Calamity.GetItem("GemTechSchynbaulds").DisplayName.AddTranslation(GameCulture.Portuguese, "Cobre-canela da Tecnologia das Joias");
                    Calamity.GetItem("GemTechSchynbaulds").Tooltip.AddTranslation(GameCulture.Portuguese, "Se eles te machucam, chute-os.");
                    Calamity.GetItem("SilvaHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo de Silva");
                    Calamity.GetItem("SilvaHornedHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo com Chifres de Silva");
                    Calamity.GetItem("SilvaMaskedCap").DisplayName.AddTranslation(GameCulture.Portuguese, "Boné Mascarado de Silva");
                    Calamity.GetItem("SilvaMaskedCap").Tooltip.AddTranslation(GameCulture.Portuguese, "23% de aumento nos danos por magia e 13% de aumento na chance de ataque crítico mágico\n+100 mana máxima e 19% de redução no consumo de mana");
                    Calamity.GetItem("SilvaHelmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Capuz com Chifres de Silva");
                    Calamity.GetItem("SilvaHelmet").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por lacaios");
                    Calamity.GetItem("SilvaMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Silva");
                    Calamity.GetItem("SilvaArmor").DisplayName.AddTranslation(GameCulture.Portuguese, "Armadura de Silva");
                    Calamity.GetItem("SilvaArmor").Tooltip.AddTranslation(GameCulture.Portuguese, "+80 vida máxima\n12% de aumento nos danos e 8% de aumento na chance de ataque crítico\nOferece imunidade ao efeito Irradiado");
                    Calamity.GetItem("SilvaLeggings").DisplayName.AddTranslation(GameCulture.Portuguese, "Calça de Silva");
                    Calamity.GetItem("SilvaLeggings").Tooltip.AddTranslation(GameCulture.Portuguese, "19% de aumento na velocidade dos movimentos\n12% de aumento nos danos e 7% de aumento na chance de ataque crítico");
                    Calamity.GetItem("AuricTeslaHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo Real de Tesla Áurica");
                    Calamity.GetItem("AuricTeslaHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "20% de aumento nos danos por ataque físico e na chance de ataque crítico\nFicar parado aumenta todos os danos e a chance de acerto crítico");
                    Calamity.GetItem("AuricTeslaHoodedFacemask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara Facial Encapuzada de Tesla Áurica");
                    Calamity.GetItem("AuricTeslaHoodedFacemask").Tooltip.AddTranslation(GameCulture.Portuguese, "30% de aumento nos danos por ataque à distância e na chance de ataque crítico\nFicar parado aumenta todos os danos e a chance de acerto crítico");
                    Calamity.GetItem("AuricTeslaWireHemmedVisage").DisplayName.AddTranslation(GameCulture.Portuguese, "Protetor Facial com Arames de Tesla Áurica");
                    Calamity.GetItem("AuricTeslaWireHemmedVisage").Tooltip.AddTranslation(GameCulture.Portuguese, "30% de aumento nos danos por magia e 20% de aumento na chance de ataque crítico mágico, +100 mana máxima, e 20% de redução no consumo de mana\nFicar parado aumenta todos os danos e a chance de acerto crítico");
                    Calamity.GetItem("AuricTeslaSpaceHelmet").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo Espacial de Tesla Áurica");
                    Calamity.GetItem("AuricTeslaSpaceHelmet").Tooltip.AddTranslation(GameCulture.Portuguese, "15% de aumento nos danos por lacaios\nFicar parado aumenta todos os danos e a chance de acerto crítico");
                    Calamity.GetItem("AuricTeslaPlumedHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo Emplumado de Tesla Áurica");
                    Calamity.GetItem("AuricTeslaPlumedHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "20% de aumento nos danos por ataques ladinos, na chance de ataque crítico e na velocidade dos movimentos\nFicar parado aumenta todos os danos e a chance de acerto crítico");
                    Calamity.GetItem("AuricTeslaBodyArmor").DisplayName.AddTranslation(GameCulture.Portuguese, "Armadura Corporal de Tesla Áurica");
                    Calamity.GetItem("AuricTeslaBodyArmor").Tooltip.AddTranslation(GameCulture.Portuguese, "+100 vida máxima\n8% de aumento nos danos e 5% de aumento na chance de ataque crítico\nVocê congelará os inimigos perto de você quando for atingido");
                    Calamity.GetItem("AuricTeslaCuisses").DisplayName.AddTranslation(GameCulture.Portuguese, "Grevas de Tesla Áurica");
                    Calamity.GetItem("AuricTeslaCuisses").Tooltip.AddTranslation(GameCulture.Portuguese, "20% de aumento na velocidade dos movimentos\n12% de aumento nos danos e 5% de aumento na chance de ataque crítico\nEfeito do tapete mágico");
                    Calamity.GetItem("DemonshadeHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo das Sombras do Demônio");
                    Calamity.GetItem("DemonshadeHelm").Tooltip.AddTranslation(GameCulture.Portuguese, "30% de aumento nos danos e 15% de aumento na chance de acerto crítico");
                    Calamity.GetItem("DemonshadeBreastplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Peitoral das Sombras do Demônio");
                    Calamity.GetItem("DemonshadeBreastplate").Tooltip.AddTranslation(GameCulture.Portuguese, "20% de aumento na velocidade do ataque físico, 15% de aumento no dano e na chance de acerto crítico\nInimigos recebem danos ímpios quando tocam em você\nAumenta a vida e mana máxima em 200\nFicar parado permite que você absorva as sombras e aumente sua regeneração de vida");
                    Calamity.GetItem("DemonshadeGreaves").DisplayName.AddTranslation(GameCulture.Portuguese, "Grevas das Sombras do Demônio");
                    Calamity.GetItem("DemonshadeGreaves").Tooltip.AddTranslation(GameCulture.Portuguese, "Velocidade das sombras");

                    //Miscellaneous
                    Calamity.GetItem("ForbiddenCirclet").DisplayName.AddTranslation(GameCulture.Portuguese, "Argola Proibída");
                    Calamity.GetItem("ForbiddenCirclet").Tooltip.AddTranslation(GameCulture.Portuguese, "10% de aumento nos danos por invocação e 15% de aumento na velocidade dos projéteis ladinos");
                    Calamity.GetItem("ShroomiteVisage").DisplayName.AddTranslation(GameCulture.Portuguese, "Protetor Facial de Cogumelita");
                    Calamity.GetItem("ShroomiteVisage").Tooltip.AddTranslation(GameCulture.Portuguese, "25% de aumento nos danos por ataque à distância para lança-chamas");

                    //Vanity items
                    //Vanity pieces
                    Calamity.GetItem("ApronOfAffection").DisplayName.AddTranslation(GameCulture.Portuguese, "Avental de Carinho de Ás");
                    Calamity.GetItem("ApronOfAffection").Tooltip.AddTranslation(GameCulture.Portuguese, "Ótimo para abraçar pessoas");
                    Calamity.GetItem("AshenHorns").DisplayName.AddTranslation(GameCulture.Portuguese, "Chifres Cinzentos");
                    Calamity.GetItem("CirrusDress").DisplayName.AddTranslation(GameCulture.Portuguese, "Vestido de Cirrus");
                    Calamity.GetItem("CirrusDress").Tooltip.AddTranslation(GameCulture.Portuguese, "Aqui, isto deve ajudá-lo a beber tanto álcool quanto quiser!\n5% de aumento nos danos por magia e na chance de acerto crítico mágico\nVocê se sente gostosão...");

                    //Vanity sets
                    Calamity.GetItem("AncientGodSlayerHelm").DisplayName.AddTranslation(GameCulture.Portuguese, "Elmo do Assassino de Deuses Antigo");
                    Calamity.GetItem("AncientGodSlayerChestplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Peitoral do Assassino de Deuses Antigo");
                    Calamity.GetItem("AncientGodSlayerLeggings").DisplayName.AddTranslation(GameCulture.Portuguese, "Calça do Assassino de Deuses Antigo");
                    Calamity.GetItem("SCalMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Capuz Calamitoso");
                    Calamity.GetItem("SCalRobes").DisplayName.AddTranslation(GameCulture.Portuguese, "Roupão Calamitoso");
                    Calamity.GetItem("SCalBoots").DisplayName.AddTranslation(GameCulture.Portuguese, "Botas Calamitosas");
                    Calamity.GetItem("CalamityHood").DisplayName.AddTranslation(GameCulture.Portuguese, "Capuz da Calamidade");
                    Calamity.GetItem("CalamityRobes").DisplayName.AddTranslation(GameCulture.Portuguese, "Roupão da Calamidade");

                    //Boss Masks
                    Calamity.GetItem("AnahitaMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Anahita");
                    Calamity.GetItem("ApolloMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Apolo");
                    Calamity.GetItem("AquaticScourgeMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara da Praga Aquática");
                    Calamity.GetItem("AresMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Ares");
                    Calamity.GetItem("ArtemisMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Ártemis");
                    Calamity.GetItem("AureusMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Astrum Aureus");
                    Calamity.GetItem("AstrumDeusMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Astrum Deus");
                    Calamity.GetItem("BrimstoneWaifuMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Elemental de Enxofre");
                    Calamity.GetItem("CalamitasMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara da Calamitas");
                    Calamity.GetItem("CeaselessVoidMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Vazio Incessante");
                    Calamity.GetItem("CrabulonMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Crabulon");
                    Calamity.GetItem("CryogenMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Criogênio");
                    Calamity.GetItem("DesertScourgeMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara da Praga do Deserto");
                    Calamity.GetItem("DevourerofGodsMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Devorador de Deuses");
                    Calamity.GetItem("DraedonMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Draedon");
                    Calamity.GetItem("BumblefuckMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Dragonfolly");
                    Calamity.GetItem("HiveMindMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara da Colmeia Mental");
                    Calamity.GetItem("LeviathanMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara da Leviathan");
                    Calamity.GetItem("OldDukeMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Velho Duque");
                    Calamity.GetItem("PerforatorMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Perfurador");
                    Calamity.GetItem("PlaguebringerGoliathMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara da Portadora da Peste Gigante");
                    Calamity.GetItem("PolterghastMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Polterghast");
                    Calamity.GetItem("ProfanedGuardianMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Guardião Profano");
                    Calamity.GetItem("ProvidenceMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara da Providência");
                    Calamity.GetItem("RavagerMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Devastador");
                    Calamity.GetItem("SignusMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara de Signus");
                    Calamity.GetItem("SlimeGodMask2").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Deus Geleia");
                    Calamity.GetItem("SlimeGodMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Deus Geleia");
                    Calamity.GetItem("StormWeaverMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Explorador da Tempestade");
                    Calamity.GetItem("ThanatosMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Thánatos");
                    Calamity.GetItem("YharonMask").DisplayName.AddTranslation(GameCulture.Portuguese, "Máscara do Yharon");

                    ///Blocks
                    //Naturally Occuring Blocks
                    //Soils
                    Calamity.GetItem("EutrophicSand").DisplayName.AddTranslation(GameCulture.Portuguese, "Areia Eutrófica");
                    Calamity.GetItem("EutrophicSandWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Areia Eutrófica Insegura");
                    Calamity.GetItem("EutrophicSandWallSafe").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Areia Eutrófica");
                    Calamity.GetItem("Navystone").DisplayName.AddTranslation(GameCulture.Portuguese, "Pedra Marinha");
                    Calamity.GetItem("NavystoneWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Pedra Marinha Insegura");
                    Calamity.GetItem("NavystoneWallSafe").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Pedra Marinha");
                    Calamity.GetItem("BrimstoneSlag").DisplayName.AddTranslation(GameCulture.Portuguese, "Escória de Enxofre");
                    Calamity.GetItem("BrimstoneSlagWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Escória de Enxofre");
                    Calamity.GetItem("HardenedSulphurousSandstone").DisplayName.AddTranslation(GameCulture.Portuguese, "Arenito Sulfuroso Endurecido");
                    Calamity.GetItem("HardenedSulphurousSandstoneWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Arenito Sulfuroso Endurecido");
                    Calamity.GetItem("SulphurousSand").DisplayName.AddTranslation(GameCulture.Portuguese, "Areia Sulfurosa");
                    Calamity.GetItem("SulphurousSandWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Areia Sulfurosa");
                    Calamity.GetItem("SulphurousSandstone").DisplayName.AddTranslation(GameCulture.Portuguese, "Arenito Sulfuroso");
                    Calamity.GetItem("SulphurousSandstoneWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Arenito Sulfuroso");
                    Calamity.GetItem("AbyssGravel").DisplayName.AddTranslation(GameCulture.Portuguese, "Cascalho do Abismo");
                    Calamity.GetItem("AbyssGravelWallItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Cascalho do Abismo");
                    Calamity.GetItem("Voidstone").DisplayName.AddTranslation(GameCulture.Portuguese, "Pedra do Vazio");
                    Calamity.GetItem("VoidstoneWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Pedra do Vazio");
                    Calamity.GetItem("PlantyMush").DisplayName.AddTranslation(GameCulture.Portuguese, "Polpa de Planta");
                    Calamity.GetItem("Tenebris").DisplayName.AddTranslation(GameCulture.Portuguese, "Tenebris");
                    Calamity.GetItem("AstralDirt").DisplayName.AddTranslation(GameCulture.Portuguese, "Terra Astral");
                    Calamity.GetItem("AstralDirtWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Terra Astral");
                    Calamity.GetItem("AstralStone").DisplayName.AddTranslation(GameCulture.Portuguese, "Pedra Astral");
                    Calamity.GetItem("AstralStoneWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Pedra Astral");
                    Calamity.GetItem("AstralSand").DisplayName.AddTranslation(GameCulture.Portuguese, "Areia Astral");
                    Calamity.GetItem("HardenedAstralSand").DisplayName.AddTranslation(GameCulture.Portuguese, "Areia Astral Endurecida");
                    Calamity.GetItem("HardenedAstralSandWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Areia Astral Endurecida");
                    Calamity.GetItem("AstralSandstone").DisplayName.AddTranslation(GameCulture.Portuguese, "Arenito Astral");
                    Calamity.GetItem("AstralSandstoneWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Arenito Astral");
                    Calamity.GetItem("AstralIce").DisplayName.AddTranslation(GameCulture.Portuguese, "Gelo Astral");
                    Calamity.GetItem("AstralIceWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Gelo Astral");
                    Calamity.GetItem("AstralClay").DisplayName.AddTranslation(GameCulture.Portuguese, "Argila Astral");
                    Calamity.GetItem("AstralSnow").DisplayName.AddTranslation(GameCulture.Portuguese, "Neve Astral");
                    Calamity.GetItem("AstralSnowWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Neve Astral");
                    Calamity.GetItem("AstralFossil").DisplayName.AddTranslation(GameCulture.Portuguese, "Restos Celestes");
                    Calamity.GetItem("AstralFossilWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Restos Celestes");
                    Calamity.GetItem("AstralSilt").DisplayName.AddTranslation(GameCulture.Portuguese, "Escória de Nova");
                    Calamity.GetItem("AstralGrassWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Grama Astral");

                    //Ore Blocks
                    Calamity.GetItem("SeaPrism").DisplayName.AddTranslation(GameCulture.Portuguese, "Prisma do Mar");
                    Calamity.GetItem("AerialiteOre").DisplayName.AddTranslation(GameCulture.Portuguese, "Minério de Aerealita");
                    Calamity.GetItem("CryonicOre").DisplayName.AddTranslation(GameCulture.Portuguese, "Minério Criônico");
                    Calamity.GetItem("HallowedOre").DisplayName.AddTranslation(GameCulture.Portuguese, "Minério Consagrado");
                    Calamity.GetItem("PerennialOre").DisplayName.AddTranslation(GameCulture.Portuguese, "Minério de Perene");
                    Calamity.GetItem("CharredOre").DisplayName.AddTranslation(GameCulture.Portuguese, "Minério Carbonizado");
                    Calamity.GetItem("ChaoticOre").DisplayName.AddTranslation(GameCulture.Portuguese, "Minério de Escória");
                    Calamity.GetItem("AstralOre").DisplayName.AddTranslation(GameCulture.Portuguese, "Minério Astral");
                    Calamity.GetItem("ExodiumClusterOre").DisplayName.AddTranslation(GameCulture.Portuguese, "Aglomerado de Exódio");
                    Calamity.GetItem("ExodiumClusterOre").Tooltip.AddTranslation(GameCulture.Portuguese, "Um aglomerado frio do grande desconhecido.");
                    Calamity.GetItem("UelibloomOre").DisplayName.AddTranslation(GameCulture.Portuguese, "Minério de Casca Florescente");
                    Calamity.GetItem("AuricOre").DisplayName.AddTranslation(GameCulture.Portuguese, "Minério Áurico");

                    //Other
                    Calamity.GetItem("PrismShard").DisplayName.AddTranslation(GameCulture.Portuguese, "Fragmento de Prisma");
                    Calamity.GetItem("Lumenite").DisplayName.AddTranslation(GameCulture.Portuguese, "Lumenil");
                    Calamity.GetItem("AstralMonolith").DisplayName.AddTranslation(GameCulture.Portuguese, "Monólito Astral");
                    Calamity.GetItem("AstralMonolithWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Monólito Astral");

                    //Crafted Blocks and Bricks
                    Calamity.GetItem("SmoothAbyssGravel").DisplayName.AddTranslation(GameCulture.Portuguese, "Cascalho do Abismo Liso");
                    Calamity.GetItem("SmoothAbyssGravelWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Cascalho do Abismo Liso");
                    Calamity.GetItem("SmoothBrimstoneSlag").DisplayName.AddTranslation(GameCulture.Portuguese, "Escória de Enxofre Lisa");
                    Calamity.GetItem("SmoothBrimstoneSlagWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Escória de Enxofre Lisa");
                    Calamity.GetItem("SmoothNavystone").DisplayName.AddTranslation(GameCulture.Portuguese, "Pedra Marinha Lisa");
                    Calamity.GetItem("SmoothNavystoneWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Pedra Marinha Lisa");
                    Calamity.GetItem("AshenSlab").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa Cinzenta");
                    Calamity.GetItem("AshenSlabWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Placa Cinzenta");
                    Calamity.GetItem("LaboratoryPlating").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa de Laboratório");
                    Calamity.GetItem("LaboratoryPlatingWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Placas de Laboratório");
                    Calamity.GetItem("LaboratoryPlatePillar").DisplayName.AddTranslation(GameCulture.Portuguese, "Pilar de Placas de Laboratório");
                    Calamity.GetItem("LaboratoryPlateBeam").DisplayName.AddTranslation(GameCulture.Portuguese, "Viga de Placas de Laboratório");
                    Calamity.GetItem("LaboratoryPanels").DisplayName.AddTranslation(GameCulture.Portuguese, "Painéis de Laboratório");
                    Calamity.GetItem("LaboratoryPanelWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Painel de Laboratório");
                    Calamity.GetItem("HazardChevronPanels").DisplayName.AddTranslation(GameCulture.Portuguese, "Painéis de Divisa de Perigo");
                    Calamity.GetItem("HazardChevronWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Divisa de Perigo");
                    Calamity.GetItem("RustedPlating").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa Enferrujada");
                    Calamity.GetItem("RustedPlatingWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Placas Enferrujadas");
                    Calamity.GetItem("RustedPlatePillar").DisplayName.AddTranslation(GameCulture.Portuguese, "Pilar de Placas Enferrujadas");
                    Calamity.GetItem("RustedPlateBeam").DisplayName.AddTranslation(GameCulture.Portuguese, "Viga de Placas Enferrujadas");
                    Calamity.GetItem("RustedPipes").DisplayName.AddTranslation(GameCulture.Portuguese, "Canos Enferrujados");
                    Calamity.GetItem("LaboratoryPipePlating").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa de Canos do Laboratório");
                    Calamity.GetItem("SmoothVoidstone").DisplayName.AddTranslation(GameCulture.Portuguese, "Pedra do Vazio Lisa");
                    Calamity.GetItem("SmoothVoidstoneWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Pedra do Vazio Lisa");
                    Calamity.GetItem("VoidstoneSlab").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa de Pedra do Vazio");
                    Calamity.GetItem("VoidstoneSlabWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Placas de Pedra do Vazio");
                    Calamity.GetItem("AerialiteBrick").DisplayName.AddTranslation(GameCulture.Portuguese, "Tijolo de Aerealita");
                    Calamity.GetItem("AerialiteBrickWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Tijolos de Aerealita");
                    Calamity.GetItem("StatigelBlock").DisplayName.AddTranslation(GameCulture.Portuguese, "Bloco de Statigel");
                    Calamity.GetItem("StatigelWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Statigel");
                    Calamity.GetItem("CryonicBrick").DisplayName.AddTranslation(GameCulture.Portuguese, "Tijolo Criônico");
                    Calamity.GetItem("CryonicBrickWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Tijolos Criônicos");
                    Calamity.GetItem("PerennialBrick").DisplayName.AddTranslation(GameCulture.Portuguese, "Tijolo de Perene");
                    Calamity.GetItem("PerennialBrickWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Tijolos de Perene");
                    Calamity.GetItem("AstralBrick").DisplayName.AddTranslation(GameCulture.Portuguese, "Tijolo Astral");
                    Calamity.GetItem("AstralBrickWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Tijolos Astrais");
                    Calamity.GetItem("ChaoticBrick").DisplayName.AddTranslation(GameCulture.Portuguese, "Tijolo Caótico");
                    Calamity.GetItem("ChaoticBrickWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Tijolos Caóticos");
                    Calamity.GetItem("PlaguedPlate").DisplayName.AddTranslation(GameCulture.Portuguese, "Tijolo de Contenção Infestado");
                    Calamity.GetItem("PlaguedPlateWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Contenção Infestado");
                    Calamity.GetItem("UelibloomBrick").DisplayName.AddTranslation(GameCulture.Portuguese, "Tijolo de Casca Florescente");
                    Calamity.GetItem("UelibloomBrickWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Tijolos de Cascas Florescentes");
                    Calamity.GetItem("Chaosplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa do Caos");
                    Calamity.GetItem("Chaosplate").Tooltip.AddTranslation(GameCulture.Portuguese, "Ressoa com energia sobrenatural.");
                    Calamity.GetItem("ChaosplateWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Placas do Caos");
                    Calamity.GetItem("Cinderplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa das Cinzas");
                    Calamity.GetItem("Cinderplate").Tooltip.AddTranslation(GameCulture.Portuguese, "Ressoa com energia sobrenatural.");
                    Calamity.GetItem("CinderplateWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Placas das Cinzas");
                    Calamity.GetItem("Elumplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa de Eleum");
                    Calamity.GetItem("Elumplate").Tooltip.AddTranslation(GameCulture.Portuguese, "Ressoa com energia sobrenatural.");
                    Calamity.GetItem("ElumplateWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Placas de Eleum");
                    Calamity.GetItem("Navyplate").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa Marinha");
                    Calamity.GetItem("Navyplate").Tooltip.AddTranslation(GameCulture.Portuguese, "Ressoa com energia sobrenatural.");
                    Calamity.GetItem("NavyplateWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Placas Marinhas");
                    Calamity.GetItem("PlagueContainmentCells").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa da Praga");
                    Calamity.GetItem("PlagueContainmentCells").Tooltip.AddTranslation(GameCulture.Portuguese, "Ressoa com energia sobrenatural.");
                    Calamity.GetItem("PlagueContainmentCellsWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Placas da Praga");
                    Calamity.GetItem("ProfanedRock").DisplayName.AddTranslation(GameCulture.Portuguese, "Rocha Profana");
                    Calamity.GetItem("ProfanedRockWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Rochas Profanas");
                    Calamity.GetItem("ProfanedSlab").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa Profana");
                    Calamity.GetItem("ProfanedSlabWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Placas Profanas");
                    Calamity.GetItem("ProfanedCrystal").DisplayName.AddTranslation(GameCulture.Portuguese, "Cristal Profano");
                    Calamity.GetItem("ProfanedCrystalWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Cristais Profanos");
                    Calamity.GetItem("RunicProfanedBrick").DisplayName.AddTranslation(GameCulture.Portuguese, "Tijolo Profano Rúnico");
                    Calamity.GetItem("RunicProfanedBrickWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Tijolos Profanos Rúnicos");
                    Calamity.GetItem("StratusBricks").DisplayName.AddTranslation(GameCulture.Portuguese, "Tijolo de Stratus");
                    Calamity.GetItem("StratusWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Stratus");
                    Calamity.GetItem("OccultStone").DisplayName.AddTranslation(GameCulture.Portuguese, "Pedra do Outro Mundo");
                    Calamity.GetItem("OccultStoneWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Pedra do Outro Mundo");
                    Calamity.GetItem("CosmiliteBrick").DisplayName.AddTranslation(GameCulture.Portuguese, "Tijolo de Cosmilita");
                    Calamity.GetItem("CosmiliteBrickWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Tijolos de Cosmilita");
                    Calamity.GetItem("SilvaCrystal").DisplayName.AddTranslation(GameCulture.Portuguese, "Cristal de Silva");
                    Calamity.GetItem("SilvaWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Silva");
                    Calamity.GetItem("BlueBrickWallUnsafe").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Tijolos Azuis Insegura");
                    Calamity.GetItem("BlueSlabWallUnsafe").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Placas Azuis Insegura");
                    Calamity.GetItem("BlueTiledWallUnsafe").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Lajes Azuis Insegura");
                    Calamity.GetItem("GreenBrickWallUnsafe").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Tijolos Verdes Insegura");
                    Calamity.GetItem("GreenSlabWallUnsafe").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Placas Verdes Insegura");
                    Calamity.GetItem("GreenTiledWallUnsafe").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Lajes Verdes Insegura");
                    Calamity.GetItem("PinkBrickWallUnsafe").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Tijolos Cor-de-rosa Insegura");
                    Calamity.GetItem("PinkSlabWallUnsafe").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Placas Cor-de-rosa Insegura");
                    Calamity.GetItem("PinkTiledWallUnsafe").DisplayName.AddTranslation(GameCulture.Portuguese, "Parede de Lajes Cor-de-rosa Insegura");

                    ///Crafting materials
                    //Bars
                    Calamity.GetItem("VictideBar").DisplayName.AddTranslation(GameCulture.Portuguese, "Barra de Vimaré");
                    Calamity.GetItem("AerialiteBar").DisplayName.AddTranslation(GameCulture.Portuguese, "Barra de Aerealita");
                    Calamity.GetItem("VerstaltiteBar").DisplayName.AddTranslation(GameCulture.Portuguese, "Barra Criônica");
                    Calamity.GetItem("DraedonBar").DisplayName.AddTranslation(GameCulture.Portuguese, "Barra de Perene");
                    Calamity.GetItem("CruptixBar").DisplayName.AddTranslation(GameCulture.Portuguese, "Barra de Escória");
                    Calamity.GetItem("CruptixBar").Tooltip.AddTranslation(GameCulture.Portuguese, "A fumaça parece quente");
                    Calamity.GetItem("AstralBar").DisplayName.AddTranslation(GameCulture.Portuguese, "Barra Astral");
                    Calamity.GetItem("UeliaceBar").DisplayName.AddTranslation(GameCulture.Portuguese, "Barra de Casca Florescente");
                    Calamity.GetItem("CosmiliteBar").DisplayName.AddTranslation(GameCulture.Portuguese, "Barra de Cosmilita");
                    Calamity.GetItem("CosmiliteBar").Tooltip.AddTranslation(GameCulture.Portuguese, "Um pedaço de aço cósmico altamente resistente");
                    Calamity.GetItem("AuricBar").DisplayName.AddTranslation(GameCulture.Portuguese, "Barra Áurica");
                    Calamity.GetItem("AuricBar").Tooltip.AddTranslation(GameCulture.Portuguese, "Poder divino emana do metal");
                    Calamity.GetItem("ShadowspecBar").DisplayName.AddTranslation(GameCulture.Portuguese, "Barra Sombria");
                    Calamity.GetItem("ShadowspecBar").Tooltip.AddTranslation(GameCulture.Portuguese, "Um metal preto vil, tão horrendo e poderoso que desafia qualquer explicação");

                    //Fish
                    Calamity.GetItem("AldebaranAlewife").DisplayName.AddTranslation(GameCulture.Portuguese, "Alosa Cinzenta de Aldebarã");
                    Calamity.GetItem("AldebaranAlewife").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma entidade estrelada na forma de um peixe");
                    Calamity.GetItem("BrimstoneFish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe de Enxofre");
                    Calamity.GetItem("BrimstoneFish").Tooltip.AddTranslation(GameCulture.Portuguese, "O fogo é um ser vivo");
                    Calamity.GetItem("CoastalDemonfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-demônio Costeiro");
                    Calamity.GetItem("CoastalDemonfish").Tooltip.AddTranslation(GameCulture.Portuguese, "Os chifres colocam uma maldição sobre aqueles que o tocam");
                    Calamity.GetItem("CoralskinFoolfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-lixa da Pele de Coral");
                    Calamity.GetItem("CoralskinFoolfish").Tooltip.AddTranslation(GameCulture.Portuguese, "A camuflagem é uma das melhores defesas da natureza");
                    Calamity.GetItem("CragBullhead").DisplayName.AddTranslation(GameCulture.Portuguese, "Cabeça-de-touro do Rochedo");
                    Calamity.GetItem("CragBullhead").Tooltip.AddTranslation(GameCulture.Portuguese, "Suas escamas são escaldantes");
                    Calamity.GetItem("PrismaticGuppy").DisplayName.AddTranslation(GameCulture.Portuguese, "Guppy Prismático");
                    Calamity.GetItem("PrismaticGuppy").Tooltip.AddTranslation(GameCulture.Portuguese, "Jogá-los em um aquário seria uma loucura");
                    Calamity.GetItem("ProcyonidPrawn").DisplayName.AddTranslation(GameCulture.Portuguese, "Camarão Procionídeo");
                    Calamity.GetItem("ScarredAngelfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-anjo Cicatrizado");
                    Calamity.GetItem("ScarredAngelfish").Tooltip.AddTranslation(GameCulture.Portuguese, "A marca de um anjo caído");
                    Calamity.GetItem("Shadowfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-sombra");
                    Calamity.GetItem("Shadowfish").Tooltip.AddTranslation(GameCulture.Portuguese, "A escuridão se espalha");
                    Calamity.GetItem("SunkenSailfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-vela Afundado");
                    Calamity.GetItem("SunkenSailfish").Tooltip.AddTranslation(GameCulture.Portuguese, "Correndo a 60 milhas por hora");
                    Calamity.GetItem("TwinklingPollox").DisplayName.AddTranslation(GameCulture.Portuguese, "Pólox Cintilante");
                    Calamity.GetItem("TwinklingPollox").Tooltip.AddTranslation(GameCulture.Portuguese, "Suas escamas brilham como cristais");

                    //Enemy drops
                    Calamity.GetItem("AncientBoneDust").DisplayName.AddTranslation(GameCulture.Portuguese, "Pó de Osso Antigo");
                    Calamity.GetItem("EbonianGel").DisplayName.AddTranslation(GameCulture.Portuguese, "Gel Estragado");
                    Calamity.GetItem("BloodOrb").DisplayName.AddTranslation(GameCulture.Portuguese, "Orbe de Sangue");
                    Calamity.GetItem("BloodSample").DisplayName.AddTranslation(GameCulture.Portuguese, "Amostra de Sangue");
                    Calamity.GetItem("DemonicBoneAsh").DisplayName.AddTranslation(GameCulture.Portuguese, "Cinzas de Osso Demoníaco");
                    Calamity.GetItem("DesertFeather").DisplayName.AddTranslation(GameCulture.Portuguese, "Pena do Deserto");
                    Calamity.GetItem("DubiousPlating").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa Dúbia");
                    Calamity.GetItem("EnergyCore").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo de Energia");
                    Calamity.GetItem("EnergyCore").Tooltip.AddTranslation(GameCulture.Portuguese, "Ele pulsa com energia");
                    Calamity.GetItem("MurkyPaste").DisplayName.AddTranslation(GameCulture.Portuguese, "Pasta Turva");
                    Calamity.GetItem("MysteriousCircuitry").DisplayName.AddTranslation(GameCulture.Portuguese, "Circuito Misterioso");
                    Calamity.GetItem("PurifiedGel").DisplayName.AddTranslation(GameCulture.Portuguese, "Gel Purificado");
                    Calamity.GetItem("StormlionMandible").DisplayName.AddTranslation(GameCulture.Portuguese, "Mandíbula de Formiga-trovão");
                    Calamity.GetItem("SulfuricScale").DisplayName.AddTranslation(GameCulture.Portuguese, "Escama Sulfúrica");
                    Calamity.GetItem("TrueShadowScale").DisplayName.AddTranslation(GameCulture.Portuguese, "Matéria Apodrecida");
                    Calamity.GetItem("VictoryShard").DisplayName.AddTranslation(GameCulture.Portuguese, "Fragmento da Vitória");
                    Calamity.GetItem("WulfrumShard").DisplayName.AddTranslation(GameCulture.Portuguese, "Sucata de Metal Vulfrânio");
                    Calamity.GetItem("CalamityDust").DisplayName.AddTranslation(GameCulture.Portuguese, "Cinzas da Calamidade");
                    Calamity.GetItem("AstralJelly").DisplayName.AddTranslation(GameCulture.Portuguese, "Célula de Aureus");
                    Calamity.GetItem("AstralJelly").Tooltip.AddTranslation(GameCulture.Portuguese, "Oferece um aumento na regeneração de mana e poder mágico");
                    Calamity.GetItem("BeetleJuice").DisplayName.AddTranslation(GameCulture.Portuguese, "Suco de Besouro");
                    Calamity.GetItem("BlightedLens").DisplayName.AddTranslation(GameCulture.Portuguese, "Lente Manchada");
                    Calamity.GetItem("DepthCells").DisplayName.AddTranslation(GameCulture.Portuguese, "Células das Profundezas");
                    Calamity.GetItem("DepthCells").Tooltip.AddTranslation(GameCulture.Portuguese, "As células de criaturas abissais");
                    Calamity.GetItem("EssenceofChaos").DisplayName.AddTranslation(GameCulture.Portuguese, "Essência do Caos");
                    Calamity.GetItem("EssenceofChaos").Tooltip.AddTranslation(GameCulture.Portuguese, "A essência das criaturas caóticas");
                    Calamity.GetItem("EssenceofEleum").DisplayName.AddTranslation(GameCulture.Portuguese, "Essência de Eleum");
                    Calamity.GetItem("EssenceofEleum").Tooltip.AddTranslation(GameCulture.Portuguese, "A essência das criaturas frias");
                    Calamity.GetItem("EssenceofCinder").DisplayName.AddTranslation(GameCulture.Portuguese, "Essência do Sol");
                    Calamity.GetItem("EssenceofCinder").Tooltip.AddTranslation(GameCulture.Portuguese, "A essência das criaturas do céu, luz e tempestade");
                    Calamity.GetItem("GrandScale").DisplayName.AddTranslation(GameCulture.Portuguese, "Grande Escama");
                    Calamity.GetItem("GrandScale").Tooltip.AddTranslation(GameCulture.Portuguese, "A grande escala de um predador ápice");
                    Calamity.GetItem("HadarianMembrane").DisplayName.AddTranslation(GameCulture.Portuguese, "Membrana Hadariana");
                    Calamity.GetItem("HadarianMembrane").Tooltip.AddTranslation(GameCulture.Portuguese, "A membrana das asas de uma criatura astral");
                    Calamity.GetItem("InfectedArmorPlating").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa de Armadura Infectada");
                    Calamity.GetItem("LivingShard").DisplayName.AddTranslation(GameCulture.Portuguese, "Fragmento da Vida");
                    Calamity.GetItem("MeldBlob").DisplayName.AddTranslation(GameCulture.Portuguese, "Fusão de Partículas");
                    Calamity.GetItem("MolluskHusk").DisplayName.AddTranslation(GameCulture.Portuguese, "Casca de Molusco");
                    Calamity.GetItem("MolluskHusk").Tooltip.AddTranslation(GameCulture.Portuguese, "Os restos de um molusco");
                    Calamity.GetItem("PlagueCellCluster").DisplayName.AddTranslation(GameCulture.Portuguese, "Vasilha de Células da Praga");
                    Calamity.GetItem("SolarVeil").DisplayName.AddTranslation(GameCulture.Portuguese, "Manto Solar");
                    Calamity.GetItem("SolarVeil").Tooltip.AddTranslation(GameCulture.Portuguese, "A luz solar não consegue penetrar o tecido deste pano");
                    Calamity.GetItem("Stardust").DisplayName.AddTranslation(GameCulture.Portuguese, "Pó Estelar");
                    Calamity.GetItem("TitanHeart").DisplayName.AddTranslation(GameCulture.Portuguese, "Coração do Titã");
                    Calamity.GetItem("TitanHeart").Tooltip.AddTranslation(GameCulture.Portuguese, "Também usado no Sinalizador Astral");
                    Calamity.GetItem("TrapperBulb").DisplayName.AddTranslation(GameCulture.Portuguese, "Bulbo de Planta Carnívora");
                    Calamity.GetItem("ArmoredShell").DisplayName.AddTranslation(GameCulture.Portuguese, "Casco Blindado");
                    Calamity.GetItem("Bloodstone").DisplayName.AddTranslation(GameCulture.Portuguese, "Pedra Sangrenta");
                    Calamity.GetItem("CalamitousEssence").DisplayName.AddTranslation(GameCulture.Portuguese, "Cinzas da Aniquilação");
                    Calamity.GetItem("CalamitousEssence").Tooltip.AddTranslation(GameCulture.Portuguese, "A essência fumegante da ira da Bruxa");
                    Calamity.GetItem("DarkPlasma").DisplayName.AddTranslation(GameCulture.Portuguese, "Plasma Escuro");
                    Calamity.GetItem("DarksunFragment").DisplayName.AddTranslation(GameCulture.Portuguese, "Fragmento do Sol Escuro");
                    Calamity.GetItem("DarksunFragment").Tooltip.AddTranslation(GameCulture.Portuguese, "Um fragmento de energia lunar e solar");
                    Calamity.GetItem("DivineGeode").DisplayName.AddTranslation(GameCulture.Portuguese, "Geodo Sagrado");
                    Calamity.GetItem("DivineGeode").Tooltip.AddTranslation(GameCulture.Portuguese, "Um pedaço de energia sagrada cristalizada");
                    Calamity.GetItem("EffulgentFeather").DisplayName.AddTranslation(GameCulture.Portuguese, "Pena Refulgente");
                    Calamity.GetItem("EffulgentFeather").Tooltip.AddTranslation(GameCulture.Portuguese, "Ela vibra com energia fofa e dourada");
                    Calamity.GetItem("EndothermicEnergy").DisplayName.AddTranslation(GameCulture.Portuguese, "Energia Endotérmica");
                    Calamity.GetItem("EndothermicEnergy").Tooltip.AddTranslation(GameCulture.Portuguese, "Ótimo para prevenir insolações");
                    Calamity.GetItem("ExoPrism").DisplayName.AddTranslation(GameCulture.Portuguese, "Exo Prisma");
                    Calamity.GetItem("ExoPrism").Tooltip.AddTranslation(GameCulture.Portuguese, "Energias fractais brilham em sua superfície");
                    Calamity.GetItem("NightmareFuel").DisplayName.AddTranslation(GameCulture.Portuguese, "Combustível de Pesadelos");
                    Calamity.GetItem("NightmareFuel").Tooltip.AddTranslation(GameCulture.Portuguese, "Pode drenar sua sanidade");
                    Calamity.GetItem("Phantoplasm").DisplayName.AddTranslation(GameCulture.Portuguese, "Fantoplasma");
                    Calamity.GetItem("RuinousSoul").DisplayName.AddTranslation(GameCulture.Portuguese, "Alma Ruinosa");
                    Calamity.GetItem("RuinousSoul").Tooltip.AddTranslation(GameCulture.Portuguese, "Um fragmento do passado distante");
                    Calamity.GetItem("ReaperTooth").DisplayName.AddTranslation(GameCulture.Portuguese, "Dente Ceifeiro");
                    Calamity.GetItem("ReaperTooth").Tooltip.AddTranslation(GameCulture.Portuguese, "Afiado o suficiente para cortar diamantes");
                    Calamity.GetItem("TwistingNether").DisplayName.AddTranslation(GameCulture.Portuguese, "Torção do Inferno");
                    Calamity.GetItem("UnholyEssence").DisplayName.AddTranslation(GameCulture.Portuguese, "Essência Profana");
                    Calamity.GetItem("UnholyEssence").Tooltip.AddTranslation(GameCulture.Portuguese, "A essência das criaturas profanas");
                    Calamity.GetItem("HellcasterFragment").DisplayName.AddTranslation(GameCulture.Portuguese, "Fragmento da Alma de Yharon");
                    Calamity.GetItem("HellcasterFragment").Tooltip.AddTranslation(GameCulture.Portuguese, "Um fragmento de uma alma divina");
                    Calamity.GetItem("AscendantSpiritEssence").DisplayName.AddTranslation(GameCulture.Portuguese, "Essência do Espírito Ascendente");
                    Calamity.GetItem("AscendantSpiritEssence").Tooltip.AddTranslation(GameCulture.Portuguese, "Um catalisador do mais alto calibre formado pela fusão de almas poderosas");
                    Calamity.GetItem("BloodstoneCore").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo de Pedra Sangrenta");
                    Calamity.GetItem("CoreofCalamity").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo da Calamidade");
                    Calamity.GetItem("CoreofChaos").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo do Caos");
                    Calamity.GetItem("CoreofEleum").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo de Eleum");
                    Calamity.GetItem("CoreofCinder").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo do Sol");
                    Calamity.GetItem("GalacticaSingularity").DisplayName.AddTranslation(GameCulture.Portuguese, "Singularidade Galáctica");
                    Calamity.GetItem("GalacticaSingularity").Tooltip.AddTranslation(GameCulture.Portuguese, "Um fragmento do cosmos");
                    Calamity.GetItem("BarofLife").DisplayName.AddTranslation(GameCulture.Portuguese, "Liga da Vida");
                    Calamity.GetItem("MeldiateBar").DisplayName.AddTranslation(GameCulture.Portuguese, "Construção de Fusão");
                    Calamity.GetItem("MiracleMatter").DisplayName.AddTranslation(GameCulture.Portuguese, "Matéria Milagrosa");
                    Calamity.GetItem("MiracleMatter").Tooltip.AddTranslation(GameCulture.Portuguese, "Sua forma amorfa contém potencial incalculável\nUma é necessária para cada arma Exo");
                    Calamity.GetItem("MysteriousMechanism").DisplayName.AddTranslation(GameCulture.Portuguese, "Mecanismo de Procura de Laboratórios");
                    Calamity.GetItem("MysteriousMechanism").Tooltip.AddTranslation(GameCulture.Portuguese, "Usado como uma base para tecnologia de teleguiação especializada");
                    Calamity.GetItem("UnholyCore").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo Profano");

                    //Dyes
                    Calamity.GetItem("AerialiteDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura de Aerealita");
                    Calamity.GetItem("AstralBlueDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura Azul Astral");
                    Calamity.GetItem("AstralDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura de Carne Astral");
                    Calamity.GetItem("AstralOrangeDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura Laranja Astral");
                    Calamity.GetItem("AstralSwirlDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura do Redemoinho Astral");
                    Calamity.GetItem("AuricDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura Áurica");
                    Calamity.GetItem("BloodflareDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura das Chamas Sangrentas");
                    Calamity.GetItem("BlueCosmicFlameDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura das Chamas Cósmicas Azuis");
                    Calamity.GetItem("BlueStatigelDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura de Statigel Azul");
                    Calamity.GetItem("BrimflameDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura das Chamas de Enxofre");
                    Calamity.GetItem("CalamitousDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura Calamitosa");
                    Calamity.GetItem("CeaselessDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura Incessante");
                    Calamity.GetItem("CosmiliteDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura de Cosmilita");
                    Calamity.GetItem("CryonicDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura Criônica");
                    Calamity.GetItem("DefiledFlameDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura de Chamas Profanas");
                    Calamity.GetItem("DragonSoulDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura da Alma do Dragão");
                    Calamity.GetItem("ElementalDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura Elemental");
                    Calamity.GetItem("EndothermicDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura Endotérmica");
                    Calamity.GetItem("ExoDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura Exo");
                    Calamity.GetItem("NightmareDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura de Pesadelos");
                    Calamity.GetItem("PhantoplasmDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura de Fantoplasma");
                    Calamity.GetItem("PinkCosmicFlameDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura das Chamas Cósmicas Rosas");
                    Calamity.GetItem("PinkStatigelDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura de Statigel Rosa");
                    Calamity.GetItem("ProfanedFlameDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura das Chamas Profanas");
                    Calamity.GetItem("AstralBlueDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura Azul Astral");
                    Calamity.GetItem("ProfanedMoonlightDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura do Luar Profano");
                    Calamity.GetItem("ReaverDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura do Ladrão");
                    Calamity.GetItem("SlimeGodDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura do Deus Geleia");
                    Calamity.GetItem("ShadowspecDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura Sombria");
                    Calamity.GetItem("StratusDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura de Stratus");
                    Calamity.GetItem("SwirlingCosmicFlameDye").DisplayName.AddTranslation(GameCulture.Portuguese, "Tintura do Redemoinho de Chamas Cósmicas");

                    ///Enemies
                    //Pre-Hardmode
                    Calamity.GetNPC("LeviathanStart").DisplayName.AddTranslation(GameCulture.Portuguese, "???");
                    Calamity.GetNPC("AeroSlime").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia Aérea");
                    Calamity.GetNPC("AngryDog").DisplayName.AddTranslation(GameCulture.Portuguese, "Cachorro Furioso");
                    Calamity.GetNPC("CrawlerAmber").DisplayName.AddTranslation(GameCulture.Portuguese, "Rastejador de Âmbar");
                    Calamity.GetNPC("CrawlerAmethyst").DisplayName.AddTranslation(GameCulture.Portuguese, "Rastejador de Ametista");
                    Calamity.GetNPC("AquaticParasite").DisplayName.AddTranslation(GameCulture.Portuguese, "Parasita Aquático");
                    Calamity.GetNPC("AquaticSeekerHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Caçador Aquático");
                    Calamity.GetNPC("AquaticSeekerBody").DisplayName.AddTranslation(GameCulture.Portuguese, "Caçador Aquático");
                    Calamity.GetNPC("AquaticSeekerTail").DisplayName.AddTranslation(GameCulture.Portuguese, "Caçador Aquático");
                    Calamity.GetNPC("AquaticUrchin").DisplayName.AddTranslation(GameCulture.Portuguese, "Ouriço Aquático");
                    Calamity.GetNPC("BoxJellyfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Água-viva Cúbica");
                    Calamity.GetNPC("CalamityEye").DisplayName.AddTranslation(GameCulture.Portuguese, "Olho da Calamidade");
                    Calamity.GetNPC("Catfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-gato");
                    Calamity.GetNPC("Clam").DisplayName.AddTranslation(GameCulture.Portuguese, "Ostra");
                    Calamity.GetNPC("Cnidrion").DisplayName.AddTranslation(GameCulture.Portuguese, "Cnidrion");
                    Calamity.GetNPC("CosmicElemental").DisplayName.AddTranslation(GameCulture.Portuguese, "Elemental Cósmico");
                    Calamity.GetNPC("CrimulanBlightSlime").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia da Praga do Carmim");
                    Calamity.GetNPC("Cuttlefish").DisplayName.AddTranslation(GameCulture.Portuguese, "Choco");
                    Calamity.GetNPC("CrawlerDiamond").DisplayName.AddTranslation(GameCulture.Portuguese, "Rastejador de Diamante");
                    Calamity.GetNPC("DespairStone").DisplayName.AddTranslation(GameCulture.Portuguese, "Pedra do Desespero");
                    Calamity.GetNPC("DevilFish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe do Diabo");
                    Calamity.GetNPC("DevilFishAlt").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe do Diabo");
                    Calamity.GetNPC("EbonianBlightSlime").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia da Praga da Corrupção");
                    Calamity.GetNPC("CrawlerEmerald").DisplayName.AddTranslation(GameCulture.Portuguese, "Rastejador de Esmeralda");
                    Calamity.GetNPC("EutrophicRay").DisplayName.AddTranslation(GameCulture.Portuguese, "Arraia Eutrófica");
                    Calamity.GetNPC("Flounder").DisplayName.AddTranslation(GameCulture.Portuguese, "Linguado");
                    Calamity.GetNPC("Frogfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-rã");
                    Calamity.GetNPC("GhostBell").DisplayName.AddTranslation(GameCulture.Portuguese, "Sino Fantasma");
                    Calamity.GetNPC("GiantSquid").DisplayName.AddTranslation(GameCulture.Portuguese, "Lula Gigante");
                    Calamity.GetNPC("Gnasher").DisplayName.AddTranslation(GameCulture.Portuguese, "Rangedor");
                    Calamity.GetNPC("HiveCyst").DisplayName.AddTranslation(GameCulture.Portuguese, "Cisto de Colmeia");
                    Calamity.GetNPC("MantisShrimp").DisplayName.AddTranslation(GameCulture.Portuguese, "Camarão Louva-a-deus");
                    Calamity.GetNPC("MorayEel").DisplayName.AddTranslation(GameCulture.Portuguese, "Moreia");
                    Calamity.GetNPC("PerforatorCyst").DisplayName.AddTranslation(GameCulture.Portuguese, "Cisto do Perfurador");
                    Calamity.GetNPC("Rotdog").DisplayName.AddTranslation(GameCulture.Portuguese, "Cachorro-podre");
                    Calamity.GetNPC("PrismTurtle").DisplayName.AddTranslation(GameCulture.Portuguese, "Casco de Prisma");
                    Calamity.GetNPC("CrawlerRuby").DisplayName.AddTranslation(GameCulture.Portuguese, "Rastejador de Rubi");
                    Calamity.GetNPC("CrawlerSapphire").DisplayName.AddTranslation(GameCulture.Portuguese, "Rastejador de Safira");
                    Calamity.GetNPC("Scryllar").DisplayName.AddTranslation(GameCulture.Portuguese, "Crilar");
                    Calamity.GetNPC("ScryllarRage").DisplayName.AddTranslation(GameCulture.Portuguese, "Crilar");
                    Calamity.GetNPC("SeaFloaty").DisplayName.AddTranslation(GameCulture.Portuguese, "Flutuante do Mar");
                    Calamity.GetNPC("SeaUrchin").DisplayName.AddTranslation(GameCulture.Portuguese, "Ouriço-do-mar");
                    Calamity.GetNPC("SoulSlurper").DisplayName.AddTranslation(GameCulture.Portuguese, "Sugador de Almas");
                    Calamity.GetNPC("StormlionCharger").DisplayName.AddTranslation(GameCulture.Portuguese, "Formiga-trovão");
                    Calamity.GetNPC("Sunskater").DisplayName.AddTranslation(GameCulture.Portuguese, "Patinador do Sol");
                    Calamity.GetNPC("CrawlerTopaz").DisplayName.AddTranslation(GameCulture.Portuguese, "Rastejador de Topázio");
                    Calamity.GetNPC("ToxicMinnow").DisplayName.AddTranslation(GameCulture.Portuguese, "Vairão Tóxico");
                    Calamity.GetNPC("Trasher").DisplayName.AddTranslation(GameCulture.Portuguese, "Crocodilo Sulfúrico");
                    Calamity.GetNPC("Viperfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-víbora");
                    Calamity.GetNPC("WulfrumDrone").DisplayName.AddTranslation(GameCulture.Portuguese, "Drone de Vulfrânio");
                    Calamity.GetNPC("WulfrumGyrator").DisplayName.AddTranslation(GameCulture.Portuguese, "Girador de Vulfrânio");
                    Calamity.GetNPC("WulfrumHovercraft").DisplayName.AddTranslation(GameCulture.Portuguese, "Aerodeslizador de Vulfrânio");
                    Calamity.GetNPC("WulfrumPylon").DisplayName.AddTranslation(GameCulture.Portuguese, "Pilar de Vulfrânio");
                    Calamity.GetNPC("WulfrumRover").DisplayName.AddTranslation(GameCulture.Portuguese, "Rover de Vulfrânio");

                    //Hardmode
                    Calamity.GetNPC("AnthozoanCrab").DisplayName.AddTranslation(GameCulture.Portuguese, "Caranguejo Antozoário");
                    Calamity.GetNPC("AquaticAberration").DisplayName.AddTranslation(GameCulture.Portuguese, "Aberração Aquática");
                    Calamity.GetNPC("Aries").DisplayName.AddTranslation(GameCulture.Portuguese, "Áries");
                    Calamity.GetNPC("AstralachneaGround").DisplayName.AddTranslation(GameCulture.Portuguese, "Astralacneia");
                    Calamity.GetNPC("AstralachneaWall").DisplayName.AddTranslation(GameCulture.Portuguese, "Astralacneia");
                    Calamity.GetNPC("AstralProbe").DisplayName.AddTranslation(GameCulture.Portuguese, "Sonda Astral");
                    Calamity.GetNPC("AstralSlime").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia Astral");
                    Calamity.GetNPC("Atlas").DisplayName.AddTranslation(GameCulture.Portuguese, "Atlas");
                    Calamity.GetNPC("BelchingCoral").DisplayName.AddTranslation(GameCulture.Portuguese, "Coral Arrotante");
                    Calamity.GetNPC("BigSightseer").DisplayName.AddTranslation(GameCulture.Portuguese, "Avistador Grande");
                    Calamity.GetNPC("Bohldohr").DisplayName.AddTranslation(GameCulture.Portuguese, "Rohchedo");
                    Calamity.GetNPC("BlightedEye").DisplayName.AddTranslation(GameCulture.Portuguese, "Olho Manchado");
                    Calamity.GetNPC("BlindedAngler").DisplayName.AddTranslation(GameCulture.Portuguese, "Tamboril Cego");
                    Calamity.GetNPC("CharredSlime").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia Carbonizada");
                    Calamity.GetNPC("Cryon").DisplayName.AddTranslation(GameCulture.Portuguese, "Crion");
                    Calamity.GetNPC("CryoSlime").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia Criônica");
                    Calamity.GetNPC("CrawlerCrystal").DisplayName.AddTranslation(GameCulture.Portuguese, "Rastejador de Cristal");
                    Calamity.GetNPC("CultistAssassin").DisplayName.AddTranslation(GameCulture.Portuguese, "Assassino Cultista");
                    Calamity.GetNPC("Eidolist").DisplayName.AddTranslation(GameCulture.Portuguese, "Eidolista");
                    Calamity.GetNPC("FusionFeeder").DisplayName.AddTranslation(GameCulture.Portuguese, "Alimentador de Fusão");
                    Calamity.GetNPC("GulperEelHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Enguia Devoradora");
                    Calamity.GetNPC("GulperEelBody").DisplayName.AddTranslation(GameCulture.Portuguese, "Enguia Devoradora");
                    Calamity.GetNPC("GulperEelBodyAlt").DisplayName.AddTranslation(GameCulture.Portuguese, "Enguia Devoradora");
                    Calamity.GetNPC("GulperEelTail").DisplayName.AddTranslation(GameCulture.Portuguese, "Enguia Devoradora");
                    Calamity.GetNPC("Hadarian").DisplayName.AddTranslation(GameCulture.Portuguese, "Hadariano");
                    Calamity.GetNPC("HeatSpirit").DisplayName.AddTranslation(GameCulture.Portuguese, "Espírito do Calor");
                    Calamity.GetNPC("Hive").DisplayName.AddTranslation(GameCulture.Portuguese, "Colmeia");
                    Calamity.GetNPC("Hiveling").DisplayName.AddTranslation(GameCulture.Portuguese, "Colmeinha");
                    Calamity.GetNPC("IceClasper").DisplayName.AddTranslation(GameCulture.Portuguese, "Clásper de Gelo");
                    Calamity.GetNPC("Laserfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-laser");
                    Calamity.GetNPC("LuminousCorvina").DisplayName.AddTranslation(GameCulture.Portuguese, "Corvina Luminosa");
                    Calamity.GetNPC("Mantis").DisplayName.AddTranslation(GameCulture.Portuguese, "Louva-a-deus");
                    Calamity.GetNPC("PlaguedFlyingFox").DisplayName.AddTranslation(GameCulture.Portuguese, "Derretedor");
                    Calamity.GetNPC("MirageJelly").DisplayName.AddTranslation(GameCulture.Portuguese, "Água-viva da Miragem");
                    Calamity.GetNPC("Nova").DisplayName.AddTranslation(GameCulture.Portuguese, "Nova");
                    Calamity.GetNPC("OarfishHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-remo");
                    Calamity.GetNPC("OarfishBody").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-remo");
                    Calamity.GetNPC("OarfishTail").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-remo");
                    Calamity.GetNPC("OverloadedSoldier").DisplayName.AddTranslation(GameCulture.Portuguese, "Soldado Sobrecarregado");
                    Calamity.GetNPC("Parasea").DisplayName.AddTranslation(GameCulture.Portuguese, "Paramar");
                    Calamity.GetNPC("PerennialSlime").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia de Perene");
                    Calamity.GetNPC("PlaguedJungleSlime").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia Pestilenta");
                    Calamity.GetNPC("PhantomDebris").DisplayName.AddTranslation(GameCulture.Portuguese, "Detrito Fantasma");
                    Calamity.GetNPC("PlaguedTortoise").DisplayName.AddTranslation(GameCulture.Portuguese, "Casco da Praga");
                    Calamity.GetNPC("SandTortoise").DisplayName.AddTranslation(GameCulture.Portuguese, "Tartaruga de Areia");
                    Calamity.GetNPC("SeaSerpent1").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente do Mar");
                    Calamity.GetNPC("SeaSerpent2").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente do Mar");
                    Calamity.GetNPC("SeaSerpent3").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente do Mar");
                    Calamity.GetNPC("SeaSerpent4").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente do Mar");
                    Calamity.GetNPC("SeaSerpent5").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente do Mar");
                    Calamity.GetNPC("ShockstormShuttle").DisplayName.AddTranslation(GameCulture.Portuguese, "Nave Espacial da Tempestade de Choques");
                    Calamity.GetNPC("SmallSightseer").DisplayName.AddTranslation(GameCulture.Portuguese, "Avistador Pequeno");
                    Calamity.GetNPC("StellarCulex").DisplayName.AddTranslation(GameCulture.Portuguese, "Culex Estelar");
                    Calamity.GetNPC("SunBat").DisplayName.AddTranslation(GameCulture.Portuguese, "Morcego do Sol");
                    Calamity.GetNPC("PlaguedDerpling").DisplayName.AddTranslation(GameCulture.Portuguese, "Viruling");

                    //Post-Moon Lord
                    Calamity.GetNPC("Bloatfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Baiacu-inchado");
                    Calamity.GetNPC("BobbitWormHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Verme Bobbit");
                    Calamity.GetNPC("BobbitWormSegment").DisplayName.AddTranslation(GameCulture.Portuguese, "Verme Bobbit");
                    Calamity.GetNPC("BloomSlime").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia Florescente");
                    Calamity.GetNPC("ChaoticPuffer").DisplayName.AddTranslation(GameCulture.Portuguese, "Baiacu Caótico");
                    Calamity.GetNPC("WildBumblefuck").DisplayName.AddTranslation(GameCulture.Portuguese, "Voador Dracônico");
                    Calamity.GetNPC("Bumblefuck2").DisplayName.AddTranslation(GameCulture.Portuguese, "Voador Dracônico");
                    Calamity.GetNPC("ImpiousImmolator").DisplayName.AddTranslation(GameCulture.Portuguese, "Imolador Ímpio");
                    Calamity.GetNPC("PhantomSpirit").DisplayName.AddTranslation(GameCulture.Portuguese, "Espírito Fantasma");
                    Calamity.GetNPC("PhantomSpiritS").DisplayName.AddTranslation(GameCulture.Portuguese, "Espírito Fantasma");
                    Calamity.GetNPC("PhantomSpiritM").DisplayName.AddTranslation(GameCulture.Portuguese, "Espírito Fantasma");
                    Calamity.GetNPC("PhantomSpiritL").DisplayName.AddTranslation(GameCulture.Portuguese, "Espírito Fantasma");
                    Calamity.GetNPC("ProfanedEnergyBody").DisplayName.AddTranslation(GameCulture.Portuguese, "Energia Profana");
                    Calamity.GetNPC("ProfanedEnergyLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Energia Profana");
                    Calamity.GetNPC("ScornEater").DisplayName.AddTranslation(GameCulture.Portuguese, "Devorador de Desprezos");

                    //Minibosses
                    Calamity.GetNPC("ArmoredDiggerHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Cavador Blindado");
                    Calamity.GetNPC("ArmoredDiggerBody").DisplayName.AddTranslation(GameCulture.Portuguese, "Cavador Blindado");
                    Calamity.GetNPC("ArmoredDiggerTail").DisplayName.AddTranslation(GameCulture.Portuguese, "Cavador Blindado");
                    Calamity.GetNPC("ColossalSquid").DisplayName.AddTranslation(GameCulture.Portuguese, "Lula Colossal");
                    Calamity.GetNPC("Horse").DisplayName.AddTranslation(GameCulture.Portuguese, "Elemental de Terra");
                    Calamity.GetNPC("EidolonWyrmHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente Eidolon");
                    Calamity.GetNPC("EidolonWyrmBody").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente Eidolon");
                    Calamity.GetNPC("EidolonWyrmBodyAlt").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente Eidolon");
                    Calamity.GetNPC("EidolonWyrmTail").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente Eidolon");
                    Calamity.GetNPC("EidolonWyrmHeadHuge").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente Eidolon Adulta");
                    Calamity.GetNPC("EidolonWyrmBodyHuge").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente Eidolon Adulta");
                    Calamity.GetNPC("EidolonWyrmBodyAltHuge").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente Eidolon Adulta");
                    Calamity.GetNPC("EidolonWyrmTailHuge").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente Eidolon Adulta");
                    Calamity.GetNPC("GiantClam").DisplayName.AddTranslation(GameCulture.Portuguese, "Ostra Gigante");
                    Calamity.GetNPC("Mauler").DisplayName.AddTranslation(GameCulture.Portuguese, "Malhador");
                    Calamity.GetNPC("PlaguebringerShade").DisplayName.AddTranslation(GameCulture.Portuguese, "Portadora da Peste");
                    Calamity.GetNPC("Reaper").DisplayName.AddTranslation(GameCulture.Portuguese, "Tubarão Ceifeiro");

                    //Events
                    Calamity.GetNPC("FearlessGoldfishWarrior").DisplayName.AddTranslation(GameCulture.Portuguese, "Guerreiro Peixe-dourado Destemido");
                    Calamity.GetNPC("ThiccWaifu").DisplayName.AddTranslation(GameCulture.Portuguese, "Elemental da Nuvem");
                    Calamity.GetNPC("GreatSandShark").DisplayName.AddTranslation(GameCulture.Portuguese, "Grande Tubarão de Areia");
                    Calamity.GetNPC("AcidEel").DisplayName.AddTranslation(GameCulture.Portuguese, "Enguia Ácida");
                    Calamity.GetNPC("NuclearToad").DisplayName.AddTranslation(GameCulture.Portuguese, "Sapo Nuclear");
                    Calamity.GetNPC("Radiator").DisplayName.AddTranslation(GameCulture.Portuguese, "Radiador");
                    Calamity.GetNPC("EidolonWyrmHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Serpente Eidolon");
                    Calamity.GetNPC("Skyfin").DisplayName.AddTranslation(GameCulture.Portuguese, "Barbatana-do-céu");
                    Calamity.GetNPC("WaterLeech").DisplayName.AddTranslation(GameCulture.Portuguese, "Sanguessuga d'água");
                    Calamity.GetNPC("FlakCrab").DisplayName.AddTranslation(GameCulture.Portuguese, "Caranguejo Flak");
                    Calamity.GetNPC("IrradiatedSlime").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia Irradiada");
                    Calamity.GetNPC("Orthocera").DisplayName.AddTranslation(GameCulture.Portuguese, "Ortocera");
                    Calamity.GetNPC("SulfurousSkater").DisplayName.AddTranslation(GameCulture.Portuguese, "Patinador Sulfúrico");
                    Calamity.GetNPC("Trilobite").DisplayName.AddTranslation(GameCulture.Portuguese, "Trilobita");
                    Calamity.GetNPC("CragmawMire").DisplayName.AddTranslation(GameCulture.Portuguese, "Rochedo de Lama");
                    Calamity.GetNPC("GammaSlime").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia Gama");
                    Calamity.GetNPC("NuclearTerror").DisplayName.AddTranslation(GameCulture.Portuguese, "Terror Nuclear");

                    //Bosses
                    Calamity.GetNPC("AquaticScourgeHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Praga Aquática");
                    Calamity.GetNPC("AquaticScourgeBody").DisplayName.AddTranslation(GameCulture.Portuguese, "Praga Aquática");
                    Calamity.GetNPC("AquaticScourgeBodyAlt").DisplayName.AddTranslation(GameCulture.Portuguese, "Praga Aquática");
                    Calamity.GetNPC("AquaticScourgeTail").DisplayName.AddTranslation(GameCulture.Portuguese, "Praga Aquática");
                    Calamity.GetNPC("AstrumAureus").DisplayName.AddTranslation(GameCulture.Portuguese, "Astrum Aureus");
                    Calamity.GetNPC("AstrumDeusHeadSpectral").DisplayName.AddTranslation(GameCulture.Portuguese, "Astrum Deus");
                    Calamity.GetNPC("AstrumDeusBodySpectral").DisplayName.AddTranslation(GameCulture.Portuguese, "Astrum Deus");
                    Calamity.GetNPC("AstrumDeusTailSpectral").DisplayName.AddTranslation(GameCulture.Portuguese, "Astrum Deus");
                    Calamity.GetNPC("BrimstoneElemental").DisplayName.AddTranslation(GameCulture.Portuguese, "Elemental de Enxofre");
                    Calamity.GetNPC("CalamitasRun3").DisplayName.AddTranslation(GameCulture.Portuguese, "Calamitas");
                    Calamity.GetNPC("CeaselessVoid").DisplayName.AddTranslation(GameCulture.Portuguese, "Vazio Incessante");
                    Calamity.GetNPC("CrabulonIdle").DisplayName.AddTranslation(GameCulture.Portuguese, "Crabulon");
                    Calamity.GetNPC("Cryogen").DisplayName.AddTranslation(GameCulture.Portuguese, "Criogênio");
                    Calamity.GetNPC("CryogenIce").DisplayName.AddTranslation(GameCulture.Portuguese, "Escudo do Criogênio");
                    Calamity.GetNPC("DesertScourgeHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Praga do Deserto");
                    Calamity.GetNPC("DesertScourgeBody").DisplayName.AddTranslation(GameCulture.Portuguese, "Praga do Deserto");
                    Calamity.GetNPC("DesertScourgeTail").DisplayName.AddTranslation(GameCulture.Portuguese, "Praga do Deserto");
                    Calamity.GetNPC("DevourerofGodsHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Devorador de Deuses");
                    Calamity.GetNPC("DevourerofGodsBody").DisplayName.AddTranslation(GameCulture.Portuguese, "Devorador de Deuses");
                    Calamity.GetNPC("DevourerofGodsTail").DisplayName.AddTranslation(GameCulture.Portuguese, "Devorador de Deuses");
                    Calamity.GetNPC("Draedon").DisplayName.AddTranslation(GameCulture.Portuguese, "Draedon");
                    Calamity.GetNPC("Bumblefuck").DisplayName.AddTranslation(GameCulture.Portuguese, "Dragonfolly");
                    Calamity.GetNPC("HiveMind").DisplayName.AddTranslation(GameCulture.Portuguese, "A Colmeia Mental");
                    Calamity.GetNPC("Yharon").DisplayName.AddTranslation(GameCulture.Portuguese, "Yharon, o Dragão da Selva");
                    Calamity.GetNPC("Leviathan").DisplayName.AddTranslation(GameCulture.Portuguese, "A Leviathan");
                    Calamity.GetNPC("Siren").DisplayName.AddTranslation(GameCulture.Portuguese, "Anahita");
                    Calamity.GetNPC("SirenIce").DisplayName.AddTranslation(GameCulture.Portuguese, "Escudo de Gelo");
                    Calamity.GetNPC("OldDuke").DisplayName.AddTranslation(GameCulture.Portuguese, "Velho Duque");
                    Calamity.GetNPC("PerforatorHive").DisplayName.AddTranslation(GameCulture.Portuguese, "Colmeia dos Perfuradores");
                    Calamity.GetNPC("PerforatorHeadSmall").DisplayName.AddTranslation(GameCulture.Portuguese, "O Perfurador");
                    Calamity.GetNPC("PerforatorBodySmall").DisplayName.AddTranslation(GameCulture.Portuguese, "O Perfurador");
                    Calamity.GetNPC("PerforatorTailSmall").DisplayName.AddTranslation(GameCulture.Portuguese, "O Perfurador");
                    Calamity.GetNPC("PerforatorHeadMedium").DisplayName.AddTranslation(GameCulture.Portuguese, "O Perfurador");
                    Calamity.GetNPC("PerforatorBodyMedium").DisplayName.AddTranslation(GameCulture.Portuguese, "O Perfurador");
                    Calamity.GetNPC("PerforatorTailMedium").DisplayName.AddTranslation(GameCulture.Portuguese, "O Perfurador");
                    Calamity.GetNPC("PerforatorHeadLarge").DisplayName.AddTranslation(GameCulture.Portuguese, "O Perfurador");
                    Calamity.GetNPC("PerforatorBodyLarge").DisplayName.AddTranslation(GameCulture.Portuguese, "O Perfurador");
                    Calamity.GetNPC("PerforatorTailLarge").DisplayName.AddTranslation(GameCulture.Portuguese, "O Perfurador");
                    Calamity.GetNPC("PlaguebringerGoliath").DisplayName.AddTranslation(GameCulture.Portuguese, "Portadora da Peste Gigante");
                    Calamity.GetNPC("Polterghast").DisplayName.AddTranslation(GameCulture.Portuguese, "Polterghast");
                    Calamity.GetNPC("PolterghastHook").DisplayName.AddTranslation(GameCulture.Portuguese, "Gancho do Polterghast");
                    Calamity.GetNPC("PolterPhantom").DisplayName.AddTranslation(GameCulture.Portuguese, "Polterghast");
                    Calamity.GetNPC("ProfanedGuardianBoss").DisplayName.AddTranslation(GameCulture.Portuguese, "Guardião Profano");
                    Calamity.GetNPC("ProfanedGuardianBoss2").DisplayName.AddTranslation(GameCulture.Portuguese, "Guardião Profano");
                    Calamity.GetNPC("ProfanedGuardianBoss3").DisplayName.AddTranslation(GameCulture.Portuguese, "Guardião Profano");
                    Calamity.GetNPC("Providence").DisplayName.AddTranslation(GameCulture.Portuguese, "Providência, a Deusa Profana");
                    Calamity.GetNPC("ProvSpawnOffense").DisplayName.AddTranslation(GameCulture.Portuguese, "Um Guardião Profano");
                    Calamity.GetNPC("ProvSpawnDefense").DisplayName.AddTranslation(GameCulture.Portuguese, "Um Guardião Profano");
                    Calamity.GetNPC("ProvSpawnHealer").DisplayName.AddTranslation(GameCulture.Portuguese, "Um Guardião Profano");
                    Calamity.GetNPC("RavagerBody").DisplayName.AddTranslation(GameCulture.Portuguese, "Devastador");
                    Calamity.GetNPC("RavagerHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Devastador");
                    Calamity.GetNPC("RavagerHead2").DisplayName.AddTranslation(GameCulture.Portuguese, "Devastador");
                    Calamity.GetNPC("RavagerLegLeft").DisplayName.AddTranslation(GameCulture.Portuguese, "Devastador");
                    Calamity.GetNPC("RavagerLegRight").DisplayName.AddTranslation(GameCulture.Portuguese, "Devastador");
                    Calamity.GetNPC("RavagerClawLeft").DisplayName.AddTranslation(GameCulture.Portuguese, "Devastador");
                    Calamity.GetNPC("RavagerClawRight").DisplayName.AddTranslation(GameCulture.Portuguese, "Devastador");
                    Calamity.GetNPC("Signus").DisplayName.AddTranslation(GameCulture.Portuguese, "Signus, Emissário do Devorador");
                    Calamity.GetNPC("ProvSpawnOffense").DisplayName.AddTranslation(GameCulture.Portuguese, "Um Guardião Profano");
                    Calamity.GetNPC("SlimeGodCore").DisplayName.AddTranslation(GameCulture.Portuguese, "O Deus Geleia");
                    Calamity.GetNPC("SlimeGod").DisplayName.AddTranslation(GameCulture.Portuguese, "Deus Geleia do Ébano");
                    Calamity.GetNPC("SlimeGodRun").DisplayName.AddTranslation(GameCulture.Portuguese, "Deus Geleia de Carmim");
                    Calamity.GetNPC("SlimeGodSplit").DisplayName.AddTranslation(GameCulture.Portuguese, "Deus Geleia do Ébano");
                    Calamity.GetNPC("SlimeGodRunSplit").DisplayName.AddTranslation(GameCulture.Portuguese, "Deus Geleia de Carmim");
                    Calamity.GetNPC("StormWeaverHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Explorador da Tempestade");
                    Calamity.GetNPC("StormWeaverBody").DisplayName.AddTranslation(GameCulture.Portuguese, "Explorador da Tempestade");
                    Calamity.GetNPC("StormWeaverTail").DisplayName.AddTranslation(GameCulture.Portuguese, "Explorador da Tempestade");
                    Calamity.GetNPC("SupremeCalamitas").DisplayName.AddTranslation(GameCulture.Portuguese, "Calamitas Suprema");

                    //Boss Servants
                    Calamity.GetNPC("DesertNuisanceHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Um Incômodo do Deserto");
                    Calamity.GetNPC("DesertNuisanceBody").DisplayName.AddTranslation(GameCulture.Portuguese, "Um Incômodo do Deserto");
                    Calamity.GetNPC("DesertNuisanceTail").DisplayName.AddTranslation(GameCulture.Portuguese, "Um Incômodo do Deserto");
                    Calamity.GetNPC("IceMass").DisplayName.AddTranslation(GameCulture.Portuguese, "Espírito da Aurora");
                    Calamity.GetNPC("AureusSpawn").DisplayName.AddTranslation(GameCulture.Portuguese, "Invocação de Aureus");
                    Calamity.GetNPC("Brimling").DisplayName.AddTranslation(GameCulture.Portuguese, "Brimling");
                    Calamity.GetNPC("CalamitasRun").DisplayName.AddTranslation(GameCulture.Portuguese, "Cataclismo");
                    Calamity.GetNPC("CalamitasRun2").DisplayName.AddTranslation(GameCulture.Portuguese, "Catástrofe");
                    Calamity.GetNPC("SlimeSpawnCorrupt").DisplayName.AddTranslation(GameCulture.Portuguese, "Invocação de Geleia Corrompida");
                    Calamity.GetNPC("SlimeSpawnCorrupt2").DisplayName.AddTranslation(GameCulture.Portuguese, "Invocação de Geleia Corrompida");
                    Calamity.GetNPC("DevourerofGodsHead2").DisplayName.AddTranslation(GameCulture.Portuguese, "Guardião Cósmico");
                    Calamity.GetNPC("DevourerofGodsBody2").DisplayName.AddTranslation(GameCulture.Portuguese, "Guardião Cósmico");
                    Calamity.GetNPC("DevourerofGodsTail2").DisplayName.AddTranslation(GameCulture.Portuguese, "Guardião Cósmico");
                    Calamity.GetNPC("CosmicLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna Cósmica");
                    Calamity.GetNPC("SignusBomb").DisplayName.AddTranslation(GameCulture.Portuguese, "Mina Cósmica");
                    Calamity.GetNPC("CrabShroom").DisplayName.AddTranslation(GameCulture.Portuguese, "Cogumelo Caranguejo");
                    Calamity.GetNPC("SlimeSpawnCrimson").DisplayName.AddTranslation(GameCulture.Portuguese, "Invocação de Geleia de Carmim");
                    Calamity.GetNPC("KingSlimeJewel").DisplayName.AddTranslation(GameCulture.Portuguese, "Joia da Coroa");
                    Calamity.GetNPC("Cryocore").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo Criogênico");
                    Calamity.GetNPC("Cryocore2").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo Criogênico");
                    Calamity.GetNPC("DankCreeper").DisplayName.AddTranslation(GameCulture.Portuguese, "Creeper Nojento");
                    Calamity.GetNPC("DarkEnergy").DisplayName.AddTranslation(GameCulture.Portuguese, "Energia Sombria");
                    Calamity.GetNPC("DarkHeart").DisplayName.AddTranslation(GameCulture.Portuguese, "Coração Sombrio");
                    Calamity.GetNPC("FlamePillar").DisplayName.AddTranslation(GameCulture.Portuguese, "Coluna de Chamas");
                    Calamity.GetNPC("HiveBlob").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolha da Colmeia");
                    Calamity.GetNPC("HiveBlob2").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolha da Colmeia");
                    Calamity.GetNPC("PhantomFuckYou").DisplayName.AddTranslation(GameCulture.Portuguese, "Fantasma");
                    Calamity.GetNPC("PlagueHomingMissile").DisplayName.AddTranslation(GameCulture.Portuguese, "Míssil Teleguiado da Praga");
                    Calamity.GetNPC("PlagueMine").DisplayName.AddTranslation(GameCulture.Portuguese, "Mina da Praga");
                    Calamity.GetNPC("RockPillar").DisplayName.AddTranslation(GameCulture.Portuguese, "Coluna de Pedra");
                    Calamity.GetNPC("SCalWormHead").DisplayName.AddTranslation(GameCulture.Portuguese, "Sepulcro");
                    Calamity.GetNPC("SCalWormBody").DisplayName.AddTranslation(GameCulture.Portuguese, "Sepulcro");
                    Calamity.GetNPC("SCalWormBodyWeak").DisplayName.AddTranslation(GameCulture.Portuguese, "Coração de Enxofre");
                    Calamity.GetNPC("SCalWormTail").DisplayName.AddTranslation(GameCulture.Portuguese, "Sepulcro");
                    Calamity.GetNPC("SoulSeeker").DisplayName.AddTranslation(GameCulture.Portuguese, "Caçador de Almas");
                    Calamity.GetNPC("SoulSeekerSupreme").DisplayName.AddTranslation(GameCulture.Portuguese, "Caçador de Almas");
                    Calamity.GetNPC("SlimeSpawnCrimson2").DisplayName.AddTranslation(GameCulture.Portuguese, "Invocação de Geleia de Carmim com Espinhos");
                    Calamity.GetNPC("OldDukeSharkron").DisplayName.AddTranslation(GameCulture.Portuguese, "Tubarão-dragão Sulfuroso");
                    Calamity.GetNPC("SupremeCataclysm").DisplayName.AddTranslation(GameCulture.Portuguese, "Cataclismo");
                    Calamity.GetNPC("SupremeCatastrophe").DisplayName.AddTranslation(GameCulture.Portuguese, "Catástrofe");
                    Calamity.GetNPC("OldDukeToothBall").DisplayName.AddTranslation(GameCulture.Portuguese, "Bola de Dente");
                    Calamity.GetNPC("AresBody").DisplayName.AddTranslation(GameCulture.Portuguese, "XF-09 Ares");
                    Calamity.GetNPC("AresGaussNuke").DisplayName.AddTranslation(GameCulture.Portuguese, "Bomba Nuclear Gauss do XF-09 Ares");
                    Calamity.GetNPC("AresLaserCannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão Laser do XF-09 Ares");
                    Calamity.GetNPC("AresPlasmaFlamethrower").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão de Plasma do XF-09 Ares");
                    Calamity.GetNPC("AresTeslaCannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão Tesla do XF-09 Ares");
                    Calamity.GetNPC("ThanatosHead").DisplayName.AddTranslation(GameCulture.Portuguese, "XM-05 Thánatos");
                    Calamity.GetNPC("ThanatosBody1").DisplayName.AddTranslation(GameCulture.Portuguese, "XM-05 Thánatos");
                    Calamity.GetNPC("ThanatosBody2").DisplayName.AddTranslation(GameCulture.Portuguese, "XM-05 Thánatos");
                    Calamity.GetNPC("ThanatosTail").DisplayName.AddTranslation(GameCulture.Portuguese, "XM-05 Thánatos");
                    Calamity.GetNPC("Artemis").DisplayName.AddTranslation(GameCulture.Portuguese, "XS-01 Ártemis");
                    Calamity.GetNPC("Apollo").DisplayName.AddTranslation(GameCulture.Portuguese, "XS-03 Apolo");

                    //Misc
                    Calamity.GetNPC("MicrobialCluster").DisplayName.AddTranslation(GameCulture.Portuguese, "Aglomerado de Micróbios");

                    //NPCs
                    Calamity.GetNPC("SEAHOE").DisplayName.AddTranslation(GameCulture.Portuguese, "Rei dos Mares");
                    Calamity.GetNPC("THIEF").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandida");
                    Calamity.GetNPC("FAP").DisplayName.AddTranslation(GameCulture.Portuguese, "Princesa Bêbada");
                    Calamity.GetNPC("DILF").DisplayName.AddTranslation(GameCulture.Portuguese, "Arqui-mago");
                    Calamity.GetNPC("WITCH").DisplayName.AddTranslation(GameCulture.Portuguese, "Bruxa de Enxofre");

                    //Critters
                    //Terrestrial
                    Calamity.GetNPC("FlakBaby").DisplayName.AddTranslation(GameCulture.Portuguese, "Caranguejo Flak Bebê");
                    Calamity.GetNPC("BloodwormNormal").DisplayName.AddTranslation(GameCulture.Portuguese, "Verme de Sangue");
                    Calamity.GetNPC("BloodwormFleeing").DisplayName.AddTranslation(GameCulture.Portuguese, "Verme de Sangue");
                    Calamity.GetNPC("Piggy").DisplayName.AddTranslation(GameCulture.Portuguese, "Porquinho");
                    Calamity.GetNPC("RepairUnitCritter").DisplayName.AddTranslation(GameCulture.Portuguese, "Unidade de Reparo");
                    Calamity.GetNPC("Twinkler").DisplayName.AddTranslation(GameCulture.Portuguese, "Inseto Cintilante");

                    //Aquatic
                    Calamity.GetNPC("GhostBellSmall").DisplayName.AddTranslation(GameCulture.Portuguese, "Sino Fantasma Bebê");
                    Calamity.GetNPC("SeaMinnow").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixinho do Mar");

                    //Other
                    Calamity.GetNPC("LecherousOrb").DisplayName.AddTranslation(GameCulture.Portuguese, "Orbe Lascivo");
                    Calamity.GetNPC("DemonPortal").DisplayName.AddTranslation(GameCulture.Portuguese, "Portal Demoníaco");
                    Calamity.GetNPC("CalamitasEnchantDemon").DisplayName.AddTranslation(GameCulture.Portuguese, "Demônio");

                    ///Furniture
                    //Crafting stations
                    Calamity.GetItem("AncientAltar").DisplayName.AddTranslation(GameCulture.Portuguese, "Altar Antigo");
                    Calamity.GetItem("AncientAltar").Tooltip.AddTranslation(GameCulture.Portuguese, "Usado para criação especial");
                    Calamity.GetItem("AshenAltar").DisplayName.AddTranslation(GameCulture.Portuguese, "Altar Cinzento");
                    Calamity.GetItem("AshenAltar").Tooltip.AddTranslation(GameCulture.Portuguese, "Usado para criação especial");
                    Calamity.GetItem("BotanicPlanter").DisplayName.AddTranslation(GameCulture.Portuguese, "Plantador Botânico");
                    Calamity.GetItem("BotanicPlanter").Tooltip.AddTranslation(GameCulture.Portuguese, "Usado para criação especial");
                    Calamity.GetItem("CosmicAnvilItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Bigorna Cósmica");
                    Calamity.GetItem("CosmicAnvilItem").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma bigorna de outro mundo capaz de resistir às pressões do colapso estelar\nTambém funciona como todos os níveis anteriores de bigorna");
                    Calamity.GetItem("DraedonsForge").DisplayName.AddTranslation(GameCulture.Portuguese, "Forja de Draedon");
                    Calamity.GetItem("DraedonsForge").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma nanoforja de rede de plasma alimentada por Exo energias ilimitadas\nFunciona como todas as principais estações de criação simultaneamente");
                    Calamity.GetItem("SilvaBasin").DisplayName.AddTranslation(GameCulture.Portuguese, "Manipulador Refulgente");
                    Calamity.GetItem("SilvaBasin").Tooltip.AddTranslation(GameCulture.Portuguese, "Usado para criação especial");
                    Calamity.GetItem("EutrophicCrafting").DisplayName.AddTranslation(GameCulture.Portuguese, "Prateleira Eutrófica");
                    Calamity.GetItem("EutrophicCrafting").Tooltip.AddTranslation(GameCulture.Portuguese, "Usado para criação especial");
                    Calamity.GetItem("MonolithCrafting").DisplayName.AddTranslation(GameCulture.Portuguese, "Monólito Amálgamo");
                    Calamity.GetItem("MonolithCrafting").Tooltip.AddTranslation(GameCulture.Portuguese, "Usado para criação especial");
                    Calamity.GetItem("PlagueInfuser").DisplayName.AddTranslation(GameCulture.Portuguese, "Infusor da Praga");
                    Calamity.GetItem("PlagueInfuser").Tooltip.AddTranslation(GameCulture.Portuguese, "Usado para criação especial");
                    Calamity.GetItem("ProfanedBasin").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadinho Profano");
                    Calamity.GetItem("ProfanedBasin").Tooltip.AddTranslation(GameCulture.Portuguese, "Usado para criação especial");
                    Calamity.GetItem("StaticRefiner").DisplayName.AddTranslation(GameCulture.Portuguese, "Refinador Estático");
                    Calamity.GetItem("StaticRefiner").Tooltip.AddTranslation(GameCulture.Portuguese, "Usado para criação especial");
                    Calamity.GetItem("VoidCondenser").DisplayName.AddTranslation(GameCulture.Portuguese, "Condensador do Vazio");
                    Calamity.GetItem("VoidCondenser").Tooltip.AddTranslation(GameCulture.Portuguese, "Usado para criação especial");


                    //Light sources
                    //Basins
                    Calamity.GetItem("AncientBasin").DisplayName.AddTranslation(GameCulture.Portuguese, "Bacia Cinzenta");
                    Calamity.GetItem("ProfanedBasin").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadinho Profano");
                    Calamity.GetItem("AshenBasin").DisplayName.AddTranslation(GameCulture.Portuguese, "Bacia Cinzenta");
                    Calamity.GetItem("CosmiliteBasin").DisplayName.AddTranslation(GameCulture.Portuguese, "Bacia de Cosmilita");
                    Calamity.GetItem("SilvaBasin").DisplayName.AddTranslation(GameCulture.Portuguese, "Manipulador Refulgente");
                    Calamity.GetItem("PlaguedPlateBasin").DisplayName.AddTranslation(GameCulture.Portuguese, "'Cama' Infestada Quebrada");

                    //Candles
                    Calamity.GetItem("StratusCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela de Stratus");
                    Calamity.GetItem("AshenCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela Cinzenta");
                    Calamity.GetItem("BotanicCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela Botânica");
                    Calamity.GetItem("CosmiliteCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela de Cosmilita");
                    Calamity.GetItem("OccultCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela do Outro Mundo");
                    Calamity.GetItem("SilvaCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela de Silva");
                    Calamity.GetItem("EutrophicCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela Eutrófica");
                    Calamity.GetItem("MonolithCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela de Monólito");
                    Calamity.GetItem("PlaguedPlateCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela Infestada");
                    Calamity.GetItem("ProfanedCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela Profana");
                    Calamity.GetItem("StatigelCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela de Statigel");
                    Calamity.GetItem("AbyssCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela do Abismo");
                    Calamity.GetItem("VoidCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela do Vazio");
                    Calamity.GetItem("ChaosCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela do Caos");
                    Calamity.GetItem("ChaosCandle").Tooltip.AddTranslation(GameCulture.Portuguese, "A mera presença desta vela enfurece os inimigos ao redor drasticamente");
                    Calamity.GetItem("TranquilityCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela da Tranquilidade");
                    Calamity.GetItem("TranquilityCandle").Tooltip.AddTranslation(GameCulture.Portuguese, "A mera presença desta vela acalma os inimigos ao redor drasticamente");
                    Calamity.GetItem("PurpleCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela Resiliente");
                    Calamity.GetItem("PurpleCandle").Tooltip.AddTranslation(GameCulture.Portuguese, "Quando colocada, a defesa dos jogadores próximos bloqueia 5% a mais de dano\n'Nem a chuva nem o vento podem apagar sua chama imortal'");
                    Calamity.GetItem("YellowCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela Vingativa");
                    Calamity.GetItem("YellowCandle").Tooltip.AddTranslation(GameCulture.Portuguese, "Quando colocada, os inimigos próximos recebem 5% a mais de dano.\nEste dano extra ignora a redução de dano e defesa do inimigo\n'Seu brilho de ódio cintila com a ira'");
                    Calamity.GetItem("PinkCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela Vigorosa");
                    Calamity.GetItem("PinkCandle").Tooltip.AddTranslation(GameCulture.Portuguese, "Quando colocada, os jogadores próximos regeneram 0,4% de sua vida máxima por segundo\nEsta regeneração está com força total mesmo enquanto se move e ignora os limites do Modo Vingança\n'Sua luz brilhante enche de esperança os que estão por perto'");
                    Calamity.GetItem("BlueCandle").DisplayName.AddTranslation(GameCulture.Portuguese, "Vela da Leveza");
                    Calamity.GetItem("BlueCandle").Tooltip.AddTranslation(GameCulture.Portuguese, "Quando colocada, os jogadores próximos ganham 15% de velocidade dos movimentos, 10% de tempo de asas e 5% de aceleração\n'A chama flutuante parece elevar o seu próprio espírito'");

                    //Chandeliers
                    Calamity.GetItem("AncientChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre Antigo");
                    Calamity.GetItem("StratusChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre de Stratus");
                    Calamity.GetItem("AshenChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre Cinzento");
                    Calamity.GetItem("BotanicChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre Botânico");
                    Calamity.GetItem("CosmiliteChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre de Cosmilita");
                    Calamity.GetItem("OccultChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre do Outro Mundo");
                    Calamity.GetItem("SilvaChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre de Silva");
                    Calamity.GetItem("EutrophicChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre Eutrófico");
                    Calamity.GetItem("MonolithChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre de Monólito");
                    Calamity.GetItem("PlaguedPlateChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre Infestado");
                    Calamity.GetItem("ProfanedChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre Profano");
                    Calamity.GetItem("StatigelChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre de Statigel");
                    Calamity.GetItem("AbyssChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre do Abismo");
                    Calamity.GetItem("VoidChandelier").DisplayName.AddTranslation(GameCulture.Portuguese, "Lustre Antigo");

                    //Candelabra
                    Calamity.GetItem("StratusCandelabra").DisplayName.AddTranslation(GameCulture.Portuguese, "Candelabro de Stratus");
                    Calamity.GetItem("AshenCandelabra").DisplayName.AddTranslation(GameCulture.Portuguese, "Candelabro Cinzento");
                    Calamity.GetItem("BotanicCandelabra").DisplayName.AddTranslation(GameCulture.Portuguese, "Candelabro Botânico");
                    Calamity.GetItem("CosmiliteCandelabra").DisplayName.AddTranslation(GameCulture.Portuguese, "Candelabro de Cosmilita");
                    Calamity.GetItem("OccultCandelabra").DisplayName.AddTranslation(GameCulture.Portuguese, "Candelabro do Outro Mundo");
                    Calamity.GetItem("SilvaCandelabra").DisplayName.AddTranslation(GameCulture.Portuguese, "Candelabro de Silva");
                    Calamity.GetItem("EutrophicCandelabra").DisplayName.AddTranslation(GameCulture.Portuguese, "Candelabro Eutrófico");
                    Calamity.GetItem("MonolithCandelabra").DisplayName.AddTranslation(GameCulture.Portuguese, "Candelabro de Monólito");
                    Calamity.GetItem("PlaguedPlateCandelabra").DisplayName.AddTranslation(GameCulture.Portuguese, "Candelabro Infestado");
                    Calamity.GetItem("ProfanedCandelabra").DisplayName.AddTranslation(GameCulture.Portuguese, "Candelabro Profano");
                    Calamity.GetItem("StatigelCandelabra").DisplayName.AddTranslation(GameCulture.Portuguese, "Candelabro de Statigel");
                    Calamity.GetItem("AbyssCandelabra").DisplayName.AddTranslation(GameCulture.Portuguese, "Candelabro do Abismo");
                    Calamity.GetItem("VoidCandelabra").DisplayName.AddTranslation(GameCulture.Portuguese, "Candelabro do Vazio");

                    //Lamps
                    Calamity.GetItem("AncientLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada Antiga");
                    Calamity.GetItem("StratusLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada de Stratus");
                    Calamity.GetItem("AshenLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada Cinzenta");
                    Calamity.GetItem("BotanicLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada Botânica");
                    Calamity.GetItem("CosmiliteLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada de Cosmilita");
                    Calamity.GetItem("OccultLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada do Outro Mundo");
                    Calamity.GetItem("SilvaLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada de Silva");
                    Calamity.GetItem("EutrophicLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada Eutrófica");
                    Calamity.GetItem("MonolithLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada de Monólito");
                    Calamity.GetItem("PlaguedPlateLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada Infestada");
                    Calamity.GetItem("ProfanedLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada Profana");
                    Calamity.GetItem("StatigelLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada de Statigel");
                    Calamity.GetItem("AbyssLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada do Abismo");
                    Calamity.GetItem("VoidLamp").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmpada do Vazio");

                    //Lanterns
                    Calamity.GetItem("AncientLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna Antiga");
                    Calamity.GetItem("StratusLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna de Stratus");
                    Calamity.GetItem("AshenLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna Cinzenta");
                    Calamity.GetItem("BotanicLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna Botânica");
                    Calamity.GetItem("TwinklerInABottle").DisplayName.AddTranslation(GameCulture.Portuguese, "Inceto Cintilante na Garrafa");
                    Calamity.GetItem("CosmiliteLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna Cosmilita");
                    Calamity.GetItem("OccultLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna do Outro Mundo");
                    Calamity.GetItem("SilvaLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna de Silva");
                    Calamity.GetItem("EutrophicLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna Eutrófica");
                    Calamity.GetItem("MonolithLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna de Monólito");
                    Calamity.GetItem("PlaguedPlateLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna Infestada");
                    Calamity.GetItem("ProfanedLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna Profana");
                    Calamity.GetItem("StatigelLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna de Statigel");
                    Calamity.GetItem("AbyssLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna do Abismo");
                    Calamity.GetItem("VoidLantern").DisplayName.AddTranslation(GameCulture.Portuguese, "Lanterna do Vazio");

                    //Sconce
                    Calamity.GetItem("CosmiliteSconce").DisplayName.AddTranslation(GameCulture.Portuguese, "Arandela de Cosmilita");

                    //Torch
                    Calamity.GetItem("AbyssTorch").DisplayName.AddTranslation(GameCulture.Portuguese, "Tocha do Abismo");

                    //Storage
                    //Chest
                    //Natural Chests
                    Calamity.GetItem("AstralChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú Astral");

                    //Crafted Chests
                    Calamity.GetItem("StratusChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú de Stratus");
                    Calamity.GetItem("AshenChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú Cinzento");
                    Calamity.GetItem("BotanicChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú Botânico");
                    Calamity.GetItem("CosmiliteChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú de Cosmilita");
                    Calamity.GetItem("OccultChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú do Outro Mundo");
                    Calamity.GetItem("SilvaChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú de Silva");
                    Calamity.GetItem("EutrophicChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú Eutrófico");
                    Calamity.GetItem("AgedSecurityChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú de Segurança Velho");
                    Calamity.GetItem("RustyChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú Enferrujado");
                    Calamity.GetItem("SecurityChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú de Segurança");
                    Calamity.GetItem("MonolithChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú de Monólito");
                    Calamity.GetItem("PlaguedPlateChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú Infestado");
                    Calamity.GetItem("ProfanedChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú Profano");
                    Calamity.GetItem("StatigelChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú de Statigel");
                    Calamity.GetItem("AbyssChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú do Abismo");
                    Calamity.GetItem("VoidChest").DisplayName.AddTranslation(GameCulture.Portuguese, "Baú do Vazio");

                    //Functional
                    Calamity.GetItem("SCalAltarItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Altar Amaldiçoado");
                    Calamity.GetItem("SCalAltarItem").Tooltip.AddTranslation(GameCulture.Portuguese, "Ofereça Cinzas da Calamidade neste altar para invocar a Bruxa\nFazer isso criará uma arena quadrada de blocos, com o altar em seu centro\nDurante a batalha, a coleta de corações cura pela metade do normal");
                    Calamity.GetItem("AstralBeaconItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Sinalizador Astral");
                    Calamity.GetItem("AstralBeaconItem").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca Astrum Deus em troca de oferendas específicas");

                    //Banner
                    Calamity.GetItem("AcidEelBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Enguia Ácida");
                    Calamity.GetItem("AeroSlimeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Geleia Aérea");
                    Calamity.GetItem("AmberCrawlerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Rastejador de Âmbar");
                    Calamity.GetItem("AmethystCrawlerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Rastejador de Ametista");
                    Calamity.GetItem("AngryDogBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Cachorro Furioso");
                    Calamity.GetItem("AquaticParasiteBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Parasita Aquático");
                    Calamity.GetItem("AquaticSeekerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Caçador Aquático");
                    Calamity.GetItem("AquaticUrchinBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Ouriço Aquático");
                    Calamity.GetItem("BoxJellyfishBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Água-viva Cúbica");
                    Calamity.GetItem("CalamityEyeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Olho da Calamidade");
                    Calamity.GetItem("CatfishBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Peixe-gato");
                    Calamity.GetItem("ClamBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Ostra");
                    Calamity.GetItem("CnidrionBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Cnidrion");
                    Calamity.GetItem("CosmicElementalBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Elemental Cósmico");
                    Calamity.GetItem("CrimulanBlightSlimeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Geleia da Praga do Carmim");
                    Calamity.GetItem("CuttlefishBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Choco");
                    Calamity.GetItem("DespairStoneBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Pedra do Desespero");
                    Calamity.GetItem("DevilFishBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Peixe do Diabo");
                    Calamity.GetItem("DiamondCrawlerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Rastejador de Diamante");
                    Calamity.GetItem("EbonianBlightSlimeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Geleia da Praga da Corrupção");
                    Calamity.GetItem("EmeraldCrawlerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Rastejador de Esmeralda");
                    Calamity.GetItem("EutrophicRayBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Arraia Eutrófica");
                    Calamity.GetItem("FearlessGoldfishWarriorBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Guerreiro Peixe-dourado Destemido");
                    Calamity.GetItem("FlakBabyBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Caranguejo Flak Bebê");
                    Calamity.GetItem("FlounderBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Linguado");
                    Calamity.GetItem("FrogfishBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Peixe-rã");
                    Calamity.GetItem("GiantClamBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Ostra Gigante");
                    Calamity.GetItem("GhostBellBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Sino Fantasma");
                    Calamity.GetItem("GhostBellSmallBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Sino Fantasma Bebê");
                    Calamity.GetItem("GnasherBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Rangedor");
                    Calamity.GetItem("IrradiatedSlimeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Geleia Irradiada");
                    Calamity.GetItem("MantisShrimpBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Camarão Louva-a-deus");
                    Calamity.GetItem("MorayEelBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Moreia");
                    Calamity.GetItem("NuclearToadBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Sapo Nuclear");
                    Calamity.GetItem("PiggyBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Porquinho");
                    Calamity.GetItem("PitbullBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Cachorro-podre");
                    Calamity.GetItem("PrismTurtleBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Casco de Prisma");
                    Calamity.GetItem("RadiatorBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Radiador");
                    Calamity.GetItem("RubyCrawlerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Rastejador de Rubi");
                    Calamity.GetItem("SapphireCrawlerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Rastejador de Safira");
                    Calamity.GetItem("ScryllarBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Crilar");
                    Calamity.GetItem("SeaFloatyBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Flutuante do Mar");
                    Calamity.GetItem("SeaMinnowBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Peixinho do Mar");
                    Calamity.GetItem("SeaUrchinBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Ouriço-do-mar");
                    Calamity.GetItem("SkyfinBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Barbatana-do-céu");
                    Calamity.GetItem("SoulSlurperBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Sugador de Almas");
                    Calamity.GetItem("StormlionBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Formiga-trovão");
                    Calamity.GetItem("SunskaterBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Patinador do Sol");
                    Calamity.GetItem("TopazCrawlerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Rastejador de Topázio");
                    Calamity.GetItem("ToxicMinnowBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Vairão Tóxico");
                    Calamity.GetItem("TrasherBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Crocodilo Sulfúrico");
                    Calamity.GetItem("ViperfishBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Peixe-víbora");
                    Calamity.GetItem("WaterLeechBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Sanguessuga d'água");
                    Calamity.GetItem("WulfrumDroneBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Drone de Vulfrânio");
                    Calamity.GetItem("WulfrumGyratorBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Girador de Vulfrânio");
                    Calamity.GetItem("WulfrumHovercraftBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Aerodeslizador de Vulfrânio");
                    Calamity.GetItem("WulfrumPylonBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Pilar de Vulfrânio");
                    Calamity.GetItem("WulfrumRoverBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Rover de Vulfrânio");

                    //Hardmode
                    Calamity.GetItem("AnthozoanCrabBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Caranguejo Antozoário");
                    Calamity.GetItem("AquaticAberrationBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Aberração Aquática");
                    Calamity.GetItem("AriesBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Aries");
                    Calamity.GetItem("ArmoredDiggerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Cavador Blindado");
                    Calamity.GetItem("AstralachneaBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Astralacneia");
                    Calamity.GetItem("AstralProbeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Sonda Astral");
                    Calamity.GetItem("AstralSlimeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Geleia Astral");
                    Calamity.GetItem("AtlasBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Atlas");
                    Calamity.GetItem("BelchingCoralBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Coral Arrotante");
                    Calamity.GetItem("BigSightseerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Avistador Grande");
                    Calamity.GetItem("BlightedEyeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Olho Manchado");
                    Calamity.GetItem("BlindedAnglerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Tamboril Cego");
                    Calamity.GetItem("BOHLDOHRBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Rohchedo");
                    Calamity.GetItem("CharredSlimeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Geleia Carbonizada");
                    Calamity.GetItem("CloudElementalBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Elemental da Nuvem");
                    Calamity.GetItem("CryonBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Crion");
                    Calamity.GetItem("CryoSlimeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Geleia Criônica");
                    Calamity.GetItem("CrystalCrawlerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Rastejador de Cristal");
                    Calamity.GetItem("CultistAssassinBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Ladino Cultista");
                    Calamity.GetItem("EarthElementalBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Elemental de Terra");
                    Calamity.GetItem("EidolistBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Eidolista");
                    Calamity.GetItem("FlakCrabBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Caranguejo Flak");
                    Calamity.GetItem("FusionFeederBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Alimentador de Fusão");
                    Calamity.GetItem("GiantSquidBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Lula Gigante");
                    Calamity.GetItem("GreatSandSharkBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Grande Tubarão de Areia");
                    Calamity.GetItem("GulperEelBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Enguia Devoradora");
                    Calamity.GetItem("HadarianBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Hadariano");
                    Calamity.GetItem("HeatSpiritBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Espírito do Calor");
                    Calamity.GetItem("HiveBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Colmeia");
                    Calamity.GetItem("IceClasperBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Clásper de Gelo");
                    Calamity.GetItem("LaserfishBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Peixe-laser");
                    Calamity.GetItem("LuminousCorvinaBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Corvina Luminosa");
                    Calamity.GetItem("MantisBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Louva-a-deus");
                    Calamity.GetItem("MelterBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Derretedor");
                    Calamity.GetItem("MirageJellyBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Água-viva da Miragem");
                    Calamity.GetItem("NovaBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Nova");
                    Calamity.GetItem("OarfishBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Peixe-remo");
                    Calamity.GetItem("OrthoceraBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Ortocera");
                    Calamity.GetItem("OverloadedSoldierBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Soldado Sobrecarregado");
                    Calamity.GetItem("ParaseaBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Paramar");
                    Calamity.GetItem("PerennialSlimeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Geleia de Perene");
                    Calamity.GetItem("PestilentSlimeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Geleia Pestilenta");
                    Calamity.GetItem("PhantomDebrisBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Detrito Fantasma");
                    Calamity.GetItem("PlaguebringerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Portadora da Peste");
                    Calamity.GetItem("PlagueshellBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Casco da Praga");
                    Calamity.GetItem("SandTortoiseBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Tartaruga de Areia");
                    Calamity.GetItem("SeaSerpentBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Serpente do Mar");
                    Calamity.GetItem("ShockstormShuttleBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Nave Espacial da Tempestade de Choques");
                    Calamity.GetItem("SmallSightseerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Avistador Pequeno");
                    Calamity.GetItem("StellarCulexBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Culex Estelar");
                    Calamity.GetItem("SulfurousSkaterBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Patinador Sulfúrico");
                    Calamity.GetItem("SunBatBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Morcego do Sol");
                    Calamity.GetItem("TrilobiteBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Trilobita");
                    Calamity.GetItem("VirulingBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Viruling");

                    //Post-Moon Lord
                    Calamity.GetItem("BloatfishBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Baiacu-inchado");
                    Calamity.GetItem("BloomSlimeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Geleia Florescente");
                    Calamity.GetItem("BobbitWormBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Verme Bobbit");
                    Calamity.GetItem("ChaoticPufferBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Baiacu Caótico");
                    Calamity.GetItem("ColossalSquidBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Lula Colossal");
                    Calamity.GetItem("EidolonWyrmJuvenileBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Serpente Eidolon Juvenil");
                    Calamity.GetItem("GammaSlimeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Geleia Gama");
                    Calamity.GetItem("ImpiousImmolatorBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Imolador Ímpio");
                    Calamity.GetItem("MaulerBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Malhador");
                    Calamity.GetItem("PhantomSpiritBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Espírito Fantasma");
                    Calamity.GetItem("ProfanedEnergyBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Energia Profana");
                    Calamity.GetItem("ReaperSharkBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Tubarão Ceifeiro");
                    Calamity.GetItem("ScornEaterBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira do Devorador de Desprezos");

                    //Unobtainable
                    Calamity.GetItem("WulfrumSlimeBanner").DisplayName.AddTranslation(GameCulture.Portuguese, "Bandeira da Geleia de Vulfrânio");

                    //Beds
                    Calamity.GetItem("AncientBed").DisplayName.AddTranslation(GameCulture.Portuguese, "Cama Antiga");
                    Calamity.GetItem("StratusBed").DisplayName.AddTranslation(GameCulture.Portuguese, "Cama de Stratus");
                    Calamity.GetItem("AshenBed").DisplayName.AddTranslation(GameCulture.Portuguese, "Cama Cinzenta");
                    Calamity.GetItem("BotanicBed").DisplayName.AddTranslation(GameCulture.Portuguese, "Cama Botânica");
                    Calamity.GetItem("CosmiliteBed").DisplayName.AddTranslation(GameCulture.Portuguese, "Cama de Cosmilita");
                    Calamity.GetItem("OccultBed").DisplayName.AddTranslation(GameCulture.Portuguese, "Cama do Outro Mundo");
                    Calamity.GetItem("SilvaBed").DisplayName.AddTranslation(GameCulture.Portuguese, "Cama de Silva");
                    Calamity.GetItem("EutrophicBed").DisplayName.AddTranslation(GameCulture.Portuguese, "Cama Eutrófica");
                    Calamity.GetItem("MonolithBed").DisplayName.AddTranslation(GameCulture.Portuguese, "Cama de Monólito");
                    Calamity.GetItem("PlaguedPlateBed").DisplayName.AddTranslation(GameCulture.Portuguese, "'Cama' Infestada");
                    Calamity.GetItem("StatigelBed").DisplayName.AddTranslation(GameCulture.Portuguese, "Cama de Statigel");
                    Calamity.GetItem("AbyssBed").DisplayName.AddTranslation(GameCulture.Portuguese, "Cama do Abismo");
                    Calamity.GetItem("VoidBed").DisplayName.AddTranslation(GameCulture.Portuguese, "Cama do Vazio");

                    Calamity.GetItem("CodebreakerBase").DisplayName.AddTranslation(GameCulture.Portuguese, "Base do Decifrador");
                    //Components
                    Calamity.GetItem("AdvancedDisplay").DisplayName.AddTranslation(GameCulture.Portuguese, "Monitor Avançado");
                    Calamity.GetItem("AdvancedDisplay").Tooltip.AddTranslation(GameCulture.Portuguese, "Pode ser colocado no Decifrador");
                    Calamity.GetItem("AuricQuantumCoolingCell").DisplayName.AddTranslation(GameCulture.Portuguese, "Célula de Resfriamento Quântico Áurico");
                    Calamity.GetItem("AuricQuantumCoolingCell").Tooltip.AddTranslation(GameCulture.Portuguese, "Pode ser colocado no Decifrador, completando-o\nA conclusão do Decifrador permite que você faça contato com seu criador original\nTentar fazer isso pode ter consequências terríveis");
                    Calamity.GetItem("DecryptionComputer").DisplayName.AddTranslation(GameCulture.Portuguese, "Computador de Descriptografia");
                    Calamity.GetItem("DecryptionComputer").Tooltip.AddTranslation(GameCulture.Portuguese, "Pode ser colocado no Decifrador\nPermite que você descriptografe esquemas avançados\nIsso permite que você aprenda como criar coisas novas");
                    Calamity.GetItem("LongRangedSensorArray").DisplayName.AddTranslation(GameCulture.Portuguese, "Matriz de Sensores de Longo Alcance");
                    Calamity.GetItem("LongRangedSensorArray").Tooltip.AddTranslation(GameCulture.Portuguese, "Pode ser colocado no Decifrador");
                    Calamity.GetItem("VoltageRegulationSystem").DisplayName.AddTranslation(GameCulture.Portuguese, "Sistema de Regulação de Voltagem");
                    Calamity.GetItem("VoltageRegulationSystem").Tooltip.AddTranslation(GameCulture.Portuguese, "Pode ser colocado no Decifrador");
                    Calamity.GetItem("EncryptedSchematicSunkenSea").DisplayName.AddTranslation(GameCulture.Portuguese, "Esquemática");
                    Calamity.GetItem("EncryptedSchematicSunkenSea").Tooltip.AddTranslation(GameCulture.Portuguese, "Diagramas detalhados de vários dispositivos e armas dançam na tela holográfica.\nO armamento que forneço aos trabalhadores dos laboratórios é fraco. Pouco adequado para a batalha.\nNo entanto, eles são suficientes para a autodefesa contra quaisquer mecanismos de laboratório ou criações que possam ter se tornado fora de controle.\nAdendo: para aqueles que se consideram poderosos, procure nos limites superiores da atmosfera deste planeta uma estrutura semelhante à dos mares profundos.\nEu saberei no final se você é digno de lutar contra minhas criações.\nRecolher este item ou segurá-lo no seu inventário permanentemente desbloqueará novas receitas");
                    Calamity.GetItem("EncryptedSchematicPlanetoid").DisplayName.AddTranslation(GameCulture.Portuguese, "Esquemática Criptografada");
                    Calamity.GetItem("EncryptedSchematicPlanetoid").Tooltip.AddTranslation(GameCulture.Portuguese, "Requer um Decifrador com um computador de descriptografia básico para descriptografar");
                    Calamity.GetItem("EncryptedSchematicJungle").DisplayName.AddTranslation(GameCulture.Portuguese, "Esquemática Criptografada");
                    Calamity.GetItem("EncryptedSchematicJungle").Tooltip.AddTranslation(GameCulture.Portuguese, "Requer um Decifrador com um sensor de longo alcance bem ajustado para descriptografar");
                    Calamity.GetItem("EncryptedSchematicHell").DisplayName.AddTranslation(GameCulture.Portuguese, "Esquemática Criptografada");
                    Calamity.GetItem("EncryptedSchematicHell").Tooltip.AddTranslation(GameCulture.Portuguese, "Requer um Decifrador com um monitor sofisticado para descriptografar");
                    Calamity.GetItem("EncryptedSchematicIce").DisplayName.AddTranslation(GameCulture.Portuguese, "Esquemática Criptografada");
                    Calamity.GetItem("EncryptedSchematicIce").Tooltip.AddTranslation(GameCulture.Portuguese, "Requer um Decifrador com um sistema de regulação de voltagem complexo para descriptografar");

                    //Door
                    Calamity.GetItem("AncientDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta Antiga");
                    Calamity.GetItem("StratusDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta de Stratus");
                    Calamity.GetItem("AshenDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta Cinzenta");
                    Calamity.GetItem("BotanicDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta Botânica");
                    Calamity.GetItem("CosmiliteDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta de Cosmilita");
                    Calamity.GetItem("OccultDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta do Outro Mundo");
                    Calamity.GetItem("SilvaDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta de Silva");
                    Calamity.GetItem("EutrophicDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta Eutrófica");
                    Calamity.GetItem("AgedLaboratoryDoorItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta de Laboratório Velha");
                    Calamity.GetItem("LaboratoryDoorItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta de Laboratório");
                    Calamity.GetItem("MonolithDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta de Monólito");
                    Calamity.GetItem("PlaguedPlateDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta Infestada");
                    Calamity.GetItem("ProfanedDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta Profana");
                    Calamity.GetItem("StatigelDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta de Statigel");
                    Calamity.GetItem("AbyssDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta do Abismo");
                    Calamity.GetItem("VoidDoor").DisplayName.AddTranslation(GameCulture.Portuguese, "Porta do Vazio");

                    //Dressers
                    Calamity.GetItem("AncientDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda Antiga");
                    Calamity.GetItem("StratusDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda de Stratus");
                    Calamity.GetItem("AshenDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda Cinzenta");
                    Calamity.GetItem("BotanicDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda Botânica");
                    Calamity.GetItem("CosmiliteDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda de Cosmilita");
                    Calamity.GetItem("OccultDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda do Outro Mundo");
                    Calamity.GetItem("SilvaDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda de Silva");
                    Calamity.GetItem("EutrophicDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda Eutrófica");
                    Calamity.GetItem("MonolithDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda de Monólito");
                    Calamity.GetItem("PlaguedPlateDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda Infestada");
                    Calamity.GetItem("ProfanedDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda Profana");
                    Calamity.GetItem("StatigelDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda de Statigel");
                    Calamity.GetItem("AbyssDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda do Abismo");
                    Calamity.GetItem("VoidDresser").DisplayName.AddTranslation(GameCulture.Portuguese, "Cômoda do Vazio");

                    //Effigies
                    Calamity.GetItem("CorruptionEffigy").DisplayName.AddTranslation(GameCulture.Portuguese, "Efígie da Corrupção");
                    Calamity.GetItem("CorruptionEffigy").Tooltip.AddTranslation(GameCulture.Portuguese, "Quando posicionado, os jogadores próximos têm sua velocidade dos movimentos aumentada em 15% e chance crítica em 10%\nJogadores próximos também sofrem uma redução de 20% na sua redução de danos");
                    Calamity.GetItem("CrimsonEffigy").DisplayName.AddTranslation(GameCulture.Portuguese, "Efígie de Carmim");
                    Calamity.GetItem("CrimsonEffigy").Tooltip.AddTranslation(GameCulture.Portuguese, "Quando posicionado, os jogadores próximos têm seus danos aumentados em 15% e sua defesa aumentada em 10\nJogadores próximos também sofrem uma redução de 20% na sua vida máxima");
                    Calamity.GetItem("EffigyOfDecay").DisplayName.AddTranslation(GameCulture.Portuguese, "Efígie da Decadência");
                    Calamity.GetItem("EffigyOfDecay").Tooltip.AddTranslation(GameCulture.Portuguese, "Quando posicionado, os jogadores próximos podem respirar debaixo d'água\nEsse efeito não funciona no abismo\nJogadore próximos também são imunes ao envenenamento sulfúrico");

                    //Grandfather Clocks
                    Calamity.GetItem("AncientMonolith").DisplayName.AddTranslation(GameCulture.Portuguese, "Monólito Antigo");
                    Calamity.GetItem("StratusClock").DisplayName.AddTranslation(GameCulture.Portuguese, "Relógio de Stratus");
                    Calamity.GetItem("AshenMonolith").DisplayName.AddTranslation(GameCulture.Portuguese, "Monólito Cinzento");
                    Calamity.GetItem("BotanicClock").DisplayName.AddTranslation(GameCulture.Portuguese, "Relógio Botânico");
                    Calamity.GetItem("CosmiliteClock").DisplayName.AddTranslation(GameCulture.Portuguese, "Relógio de Cosmilita");
                    Calamity.GetItem("OccultClock").DisplayName.AddTranslation(GameCulture.Portuguese, "Relógio do Outro Mundo");
                    Calamity.GetItem("SilvaClock").DisplayName.AddTranslation(GameCulture.Portuguese, "Relógio de Silva");
                    Calamity.GetItem("EutrophicClock").DisplayName.AddTranslation(GameCulture.Portuguese, "Relógio Eutrófico");
                    Calamity.GetItem("MonolithClock").DisplayName.AddTranslation(GameCulture.Portuguese, "Relógio de Monólito");
                    Calamity.GetItem("PlaguedPlateClock").DisplayName.AddTranslation(GameCulture.Portuguese, "Relógio Infestado");
                    Calamity.GetItem("ProfanedClock").DisplayName.AddTranslation(GameCulture.Portuguese, "Relógio Profano");
                    Calamity.GetItem("StatigelClock").DisplayName.AddTranslation(GameCulture.Portuguese, "Relógio de Statigel");
                    Calamity.GetItem("AbyssClock").DisplayName.AddTranslation(GameCulture.Portuguese, "Relógio do Abismo");
                    Calamity.GetItem("VoidClock").DisplayName.AddTranslation(GameCulture.Portuguese, "Relógio do Vazio");

                    //Platforms
                    Calamity.GetItem("ProfanedPlatform").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma Profana");
                    Calamity.GetItem("StratusPlatform").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma de Stratus");
                    Calamity.GetItem("StratusStarPlatformItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma da Estrela de Stratus");
                    Calamity.GetItem("AshenPlatform").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma Cinzenta");
                    Calamity.GetItem("BotanicPlatform").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma Botânica");
                    Calamity.GetItem("LaboratoryShelf").DisplayName.AddTranslation(GameCulture.Portuguese, "Prateleira de Laboratório");
                    Calamity.GetItem("MonolithPlatform").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma de Monólito");
                    Calamity.GetItem("RustedShelf").DisplayName.AddTranslation(GameCulture.Portuguese, "Prateleira Enferrujada");
                    Calamity.GetItem("CosmilitePlatform").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma de Cosmilita");
                    Calamity.GetItem("OccultPlatform").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma do Outro Mundo");
                    Calamity.GetItem("SilvaPlatform").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma de Silva");
                    Calamity.GetItem("EutrophicPlatform").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma Eutrófica");
                    Calamity.GetItem("PlaguedPlatePlatform").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma Infestada");
                    Calamity.GetItem("StatigelPlatform").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma de Statigel");
                    Calamity.GetItem("SmoothAbyssGravelPlatform").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma de Cascalho do Abismo Liso");
                    Calamity.GetItem("SmoothVoidstonePlatform").DisplayName.AddTranslation(GameCulture.Portuguese, "Plataforma de Pedra do Vazio Lisa");

                    //Sinks
                    Calamity.GetItem("AncientSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia Antiga");
                    Calamity.GetItem("AncientSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de lava");
                    Calamity.GetItem("StratusSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia de Stratus");
                    Calamity.GetItem("StratusSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de água");
                    Calamity.GetItem("AshenSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia Cinzenta");
                    Calamity.GetItem("AshenSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de lava");
                    Calamity.GetItem("BotanicSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia Botânica");
                    Calamity.GetItem("BotanicSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de mel");
                    Calamity.GetItem("CosmiliteSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia de Cosmilita");
                    Calamity.GetItem("CosmiliteSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de água");
                    Calamity.GetItem("OccultSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia do Outro Mundo");
                    Calamity.GetItem("OccultSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de água");
                    Calamity.GetItem("SilvaSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia de Silva");
                    Calamity.GetItem("SilvaSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de água");
                    Calamity.GetItem("EutrophicSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia Eutrófica");
                    Calamity.GetItem("EutrophicSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de água");
                    Calamity.GetItem("MonolithSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia de Monólito");
                    Calamity.GetItem("MonolithSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de água");
                    Calamity.GetItem("PlaguedPlateSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia Infestada");
                    Calamity.GetItem("PlaguedPlateSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de água");
                    Calamity.GetItem("ProfanedSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia Profana");
                    Calamity.GetItem("ProfanedSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de lava");
                    Calamity.GetItem("StatigelSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia de Statigel");
                    Calamity.GetItem("StratusSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de água");
                    Calamity.GetItem("AbyssSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia do Abismo");
                    Calamity.GetItem("AbyssSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de água");
                    Calamity.GetItem("VoidSink").DisplayName.AddTranslation(GameCulture.Portuguese, "Pia do Vazio");
                    Calamity.GetItem("VoidSink").Tooltip.AddTranslation(GameCulture.Portuguese, "Conta como uma fonte de água");

                    //Water Fountains
                    Calamity.GetItem("AbyssFountainItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Fonte de Água do Abismo");
                    Calamity.GetItem("AstralFountainItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Fonte de Água Astral");
                    Calamity.GetItem("SulphurousFountainItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Fonte de Água Sulfúrica");
                    Calamity.GetItem("SunkenSeaFountain").DisplayName.AddTranslation(GameCulture.Portuguese, "Fonte de Água Profunda");

                    //Decorative
                    //Bathtubs
                    Calamity.GetItem("AncientBath").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira Antiga");
                    Calamity.GetItem("StratusBathtub").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira de Status");
                    Calamity.GetItem("AshenBath").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira Cinzenta");
                    Calamity.GetItem("BotanicBathtub").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira Botânica");
                    Calamity.GetItem("CosmiliteBath").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira de Cosmilita");
                    Calamity.GetItem("OccultBathtub").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira de Outro Mundo");
                    Calamity.GetItem("SilvaBathtub").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira de Silva");
                    Calamity.GetItem("EutrophicBathtub").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira Eutrófica");
                    Calamity.GetItem("MonolithBathtub").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira de Monólito");
                    Calamity.GetItem("PlaguedPlateBathtub").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira Infestada");
                    Calamity.GetItem("ProfanedBath").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira Profana");
                    Calamity.GetItem("StatigelBath").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira de Statigel");
                    Calamity.GetItem("AbyssBath").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira do Abismo");
                    Calamity.GetItem("VoidBath").DisplayName.AddTranslation(GameCulture.Portuguese, "Banheira do Vazio");

                    //Cages
                    Calamity.GetItem("BabyFlakHermitCage").DisplayName.AddTranslation(GameCulture.Portuguese, "Gaiola do Eremita Flak Bebê");
                    Calamity.GetItem("BabyGhostBellJar").DisplayName.AddTranslation(GameCulture.Portuguese, "Sino Fantasma Bebê Engarrafado");
                    Calamity.GetItem("PiggyCage").DisplayName.AddTranslation(GameCulture.Portuguese, "Gaiola do Porquinho");
                    Calamity.GetItem("SeaMinnowJar").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixinho do Mar Engarrafado");

                    //Chairs
                    Calamity.GetItem("AncientChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira Antiga");
                    Calamity.GetItem("OccultChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira do Outro Mundo");
                    Calamity.GetItem("StratusChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira de Stratus");
                    Calamity.GetItem("AshenChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira Cinzenta");
                    Calamity.GetItem("BotanicChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira Botânica");
                    Calamity.GetItem("CosmiliteChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira de Cosmilita");
                    Calamity.GetItem("ThaumaticChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira Taumática");
                    Calamity.GetItem("ThaumaticChair").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma das melhores criações de Chloe");
                    Calamity.GetItem("SilvaChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira de Silva");
                    Calamity.GetItem("EutrophicChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira Eutrófica");
                    Calamity.GetItem("MonolithChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira de Monólito");
                    Calamity.GetItem("PlaguedPlateChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira Infestada");
                    Calamity.GetItem("ProfanedChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira Profana");
                    Calamity.GetItem("StatigelChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira de Statigel");
                    Calamity.GetItem("AbyssChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira do Abismo");
                    Calamity.GetItem("VoidChair").DisplayName.AddTranslation(GameCulture.Portuguese, "Cadeira do Vazio");

                    //Crates
                    Calamity.GetItem("AbyssalCrate").DisplayName.AddTranslation(GameCulture.Portuguese, "Caixote Abissal");
                    Calamity.GetItem("AstralCrate").DisplayName.AddTranslation(GameCulture.Portuguese, "Caixote Astral");
                    Calamity.GetItem("BrimstoneCrate").DisplayName.AddTranslation(GameCulture.Portuguese, "Caixote de Enxofre");
                    Calamity.GetItem("SunkenCrate").DisplayName.AddTranslation(GameCulture.Portuguese, "Caixote Profundo");

                    //Living Fire Blocks
                    Calamity.GetItem("LivingBrimstoneFireBlock").DisplayName.AddTranslation(GameCulture.Portuguese, "Bloco de Fogo Vivo de Enxofre");
                    Calamity.GetItem("LivingGodSlayerFireBlock").DisplayName.AddTranslation(GameCulture.Portuguese, "Bloco de Fogo Vivo do Assassino de Deuses");
                    Calamity.GetItem("LivingHolyFireBlock").DisplayName.AddTranslation(GameCulture.Portuguese, "Bloco de Fogo Vivo Sagrado");

                    //Pianos
                    Calamity.GetItem("AncientPiano").DisplayName.AddTranslation(GameCulture.Portuguese, "Piano Antigo");
                    Calamity.GetItem("StratusPiano").DisplayName.AddTranslation(GameCulture.Portuguese, "Piano de Stratus");
                    Calamity.GetItem("AshenPiano").DisplayName.AddTranslation(GameCulture.Portuguese, "Piano Cinzento");
                    Calamity.GetItem("BotanicPiano").DisplayName.AddTranslation(GameCulture.Portuguese, "Piano Botânico");
                    Calamity.GetItem("CosmilitePiano").DisplayName.AddTranslation(GameCulture.Portuguese, "Piano de Cosmilita");
                    Calamity.GetItem("OccultPiano").DisplayName.AddTranslation(GameCulture.Portuguese, "Piano do Outro Mundo");
                    Calamity.GetItem("SilvaPiano").DisplayName.AddTranslation(GameCulture.Portuguese, "Piano de Silva");
                    Calamity.GetItem("EutrophicPiano").DisplayName.AddTranslation(GameCulture.Portuguese, "Piano Eutrófico");
                    Calamity.GetItem("PlaguedPlatePiano").DisplayName.AddTranslation(GameCulture.Portuguese, "Piano Infestado");
                    Calamity.GetItem("ProfanedPiano").DisplayName.AddTranslation(GameCulture.Portuguese, "Piano Profano");
                    Calamity.GetItem("StatigelPiano").DisplayName.AddTranslation(GameCulture.Portuguese, "Piano de Statigel");
                    Calamity.GetItem("AbyssPiano").DisplayName.AddTranslation(GameCulture.Portuguese, "Piano do Abismo");
                    Calamity.GetItem("VoidPiano").DisplayName.AddTranslation(GameCulture.Portuguese, "Piano do Vazio");

                    //Sofas
                    Calamity.GetItem("AncientSofa").DisplayName.AddTranslation(GameCulture.Portuguese, "Sofá Antigo");
                    Calamity.GetItem("StratusSofa").DisplayName.AddTranslation(GameCulture.Portuguese, "Sofá de Stratus");
                    Calamity.GetItem("AshenSofa").DisplayName.AddTranslation(GameCulture.Portuguese, "Sofá Cinzento");
                    Calamity.GetItem("BotanicBench").DisplayName.AddTranslation(GameCulture.Portuguese, "Banco Antigo");
                    Calamity.GetItem("CosmiliteSofa").DisplayName.AddTranslation(GameCulture.Portuguese, "Sofá de Cosmilita");
                    Calamity.GetItem("OccultSofa").DisplayName.AddTranslation(GameCulture.Portuguese, "Sofá do Outro Mundo");
                    Calamity.GetItem("SilvaBench").DisplayName.AddTranslation(GameCulture.Portuguese, "Banco de Silva");
                    Calamity.GetItem("EutrophicBench").DisplayName.AddTranslation(GameCulture.Portuguese, "Banco Eutrófico");
                    Calamity.GetItem("MonolithBench").DisplayName.AddTranslation(GameCulture.Portuguese, "Banco de Monólito");
                    Calamity.GetItem("PlaguedPlateSofa").DisplayName.AddTranslation(GameCulture.Portuguese, "Sofá Infestado");
                    Calamity.GetItem("ProfanedBench").DisplayName.AddTranslation(GameCulture.Portuguese, "Banco Profano");
                    Calamity.GetItem("StatigelSofa").DisplayName.AddTranslation(GameCulture.Portuguese, "Sofá de Statigel");
                    Calamity.GetItem("AbyssSofa").DisplayName.AddTranslation(GameCulture.Portuguese, "Sofá do Abismo");
                    Calamity.GetItem("VoidSofa").DisplayName.AddTranslation(GameCulture.Portuguese, "Sofá do Vazio");

                    //Tables
                    Calamity.GetItem("AncientTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa Antiga");
                    Calamity.GetItem("StratusTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa de Stratus");
                    Calamity.GetItem("AshenTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa Cinzenta");
                    Calamity.GetItem("BotanicTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa Antiga");
                    Calamity.GetItem("CosmiliteTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa de Cosmilita");
                    Calamity.GetItem("OccultTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa do Outro Mundo");
                    Calamity.GetItem("SilvaTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa de Silva");
                    Calamity.GetItem("EutrophicTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa Eutrófica");
                    Calamity.GetItem("MonolithTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa de Monólito");
                    Calamity.GetItem("PlaguedPlateTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa Infestada");
                    Calamity.GetItem("ProfanedTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa Profana");
                    Calamity.GetItem("StatigelTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa de Statigel");
                    Calamity.GetItem("AbyssTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa do Abismo");
                    Calamity.GetItem("VoidTable").DisplayName.AddTranslation(GameCulture.Portuguese, "Mesa do Vazio");

                    //Toilets
                    Calamity.GetItem("AuricToilet").DisplayName.AddTranslation(GameCulture.Portuguese, "Privada Áurica");
                    Calamity.GetItem("AuricToilet").Tooltip.AddTranslation(GameCulture.Portuguese, "Isso foi usado pelos deuses");

                    //Trophies
                    //Pre-Hardmode
                    Calamity.GetItem("DesertScourgeTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu da Praga do Deserto");
                    Calamity.GetItem("CrabulonTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Crabulon");
                    Calamity.GetItem("HiveMindTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu da Colmeia Mental");
                    Calamity.GetItem("PerforatorTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Perfurador");
                    Calamity.GetItem("SlimeGodTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu da Praga do Deserto");

                    //Hardmode
                    Calamity.GetItem("CryogenTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Criogênio");
                    Calamity.GetItem("BrimstoneElementalTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Elemental de Enxofre");
                    Calamity.GetItem("AquaticScourgeTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu da Praga Aquática");
                    Calamity.GetItem("CalamitasTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu da Calamitas");
                    Calamity.GetItem("CataclysmTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Cataclismo");
                    Calamity.GetItem("CatastropheTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Catástrofe");
                    Calamity.GetItem("AnahitaTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu da Anahita");
                    Calamity.GetItem("LeviathanTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu da Leviathan");
                    Calamity.GetItem("AstrageldonTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Astrum Aureus");
                    Calamity.GetItem("PlaguebringerGoliathTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu da Portadora da Peste Gigante");
                    Calamity.GetItem("RavagerTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Devastador");
                    Calamity.GetItem("AstrumDeusTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Astrum Deus");

                    //Post-Moon Lord
                    Calamity.GetItem("ProfanedGuardianTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Guardião Profano");
                    Calamity.GetItem("BumblebirbTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Dragonfolly");
                    Calamity.GetItem("ProvidenceTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu da Providência");
                    Calamity.GetItem("CeaselessVoidTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Vazio Incessante");
                    Calamity.GetItem("WeaverTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Explorador da Tempestade");
                    Calamity.GetItem("SignusTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Signus");
                    Calamity.GetItem("PolterghastTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Polterghast");
                    Calamity.GetItem("OldDukeTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Velho Duque");
                    Calamity.GetItem("DevourerofGodsTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Devorador de Deuses");
                    Calamity.GetItem("YharonTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Yharon");
                    Calamity.GetItem("ApolloTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Apolo");
                    Calamity.GetItem("ArtemisTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu da Ártemis");
                    Calamity.GetItem("AresTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Ares");
                    Calamity.GetItem("ThanatosTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu do Thánatos");
                    Calamity.GetItem("SupremeCalamitasTrophy").DisplayName.AddTranslation(GameCulture.Portuguese, "Troféu da Calamitas Suprema");

                    //Laboratory furniture
                    Calamity.GetItem("AgedLaboratoryConsoleItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Console de Laboratório Velho");
                    Calamity.GetItem("AgedLaboratoryContainmentBoxItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Caixa de Contenção de Laboratório Velha");
                    Calamity.GetItem("AgedLaboratoryDisplayItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Display de Laboratório Velho");
                    Calamity.GetItem("AgedLaboratoryElectricPanelItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Painel Elétrico de Laboratório Velho");
                    Calamity.GetItem("AgedLaboratoryScreenItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Tela de Laboratório Velha");
                    Calamity.GetItem("AgedLaboratoryServerItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Servidor de Laboratório Velho");
                    Calamity.GetItem("AgedLaboratoryTerminalItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Terminal de Laboratório Velho");
                    Calamity.GetItem("AgedReinforcedCrateItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Caixa Reforçada Velha");
                    Calamity.GetItem("LaboratoryConsoleItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Console de Laboratório");
                    Calamity.GetItem("LaboratoryContainmentBoxItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Caixa de Contenção de Laboratório");
                    Calamity.GetItem("LaboratoryDisplayItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Display de Laboratório");
                    Calamity.GetItem("LaboratoryElectricPanelItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Painel Elétrico de Laboratório");
                    Calamity.GetItem("LaboratoryScreenItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Tela de Laboratório");
                    Calamity.GetItem("LaboratoryServerItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Servidor de Laboratório");
                    Calamity.GetItem("LaboratoryTerminalItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Terminal de Laboratório");
                    Calamity.GetItem("ReinforcedCrateItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Caixa Reforçada");
                    Calamity.GetItem("ChargingStationItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Estação de Carregamento");
                    Calamity.GetItem("ChargingStationItem").Tooltip.AddTranslation(GameCulture.Portuguese, "Carrega itens do Arsenal de Draedon usando Baterias\nColoque um item junto com as Baterias na Estação de Carregamento para carregar o item");
                    Calamity.GetItem("PowerCellFactoryItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Fábrica de Baterias");
                    Calamity.GetItem("PowerCellFactoryItem").Tooltip.AddTranslation(GameCulture.Portuguese, "Produz Baterias de Draedon ao longo do tempo\nUma bateria é produzida a cada 15 segundos");

                    ///Misc
                    //Summon
                    Calamity.GetItem("Abomination").DisplayName.AddTranslation(GameCulture.Portuguese, "Abombinação");
                    Calamity.GetItem("Abomination").Tooltip.AddTranslation(GameCulture.Portuguese, "Chama a abominação aérea da selva\nInvoca a Portadora da Peste Gigante");
                    Calamity.GetItem("AridArtifact").DisplayName.AddTranslation(GameCulture.Portuguese, "Artefato Árido");
                    Calamity.GetItem("AridArtifact").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca uma tempestade de areia\nA tempestade de areia acontecerá logo após este item ser usado");
                    Calamity.GetItem("AstralChunk").DisplayName.AddTranslation(GameCulture.Portuguese, "Pedaço Astral");
                    Calamity.GetItem("AstralChunk").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca o Astrum Aureus");
                    Calamity.GetItem("BloodIdol").DisplayName.AddTranslation(GameCulture.Portuguese, "Relíquia de Sangue");
                    Calamity.GetItem("BloodIdol").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um lua de sangue");
                    Calamity.GetItem("BloodyWormFood").DisplayName.AddTranslation(GameCulture.Portuguese, "Comida de Verme Sangrenta");
                    Calamity.GetItem("BloodyWormFood").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca a Colmeia dos Perfuradores");
                    Calamity.GetItem("CausticTear").DisplayName.AddTranslation(GameCulture.Portuguese, "Lágrima Cáustica");
                    Calamity.GetItem("CausticTear").Tooltip.AddTranslation(GameCulture.Portuguese, "Causa uma chuva ácida no Mar Sulfuroso\nNão consumível");
                    Calamity.GetItem("CharredIdol").DisplayName.AddTranslation(GameCulture.Portuguese, "Ídolo Carbonizado");
                    Calamity.GetItem("CharredIdol").Tooltip.AddTranslation(GameCulture.Portuguese, "Use no Rochedo de Enxofre por sua própria conta e risco\nInvoca o Elemental de Enxofre\nO chefe enfurece fora de sua casa no rochedo");
                    Calamity.GetItem("CosmicWorm").DisplayName.AddTranslation(GameCulture.Portuguese, "Verme Cósmico");
                    Calamity.GetItem("CosmicWorm").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca o Devorador de Deuses");
                    Calamity.GetItem("CryoKey").DisplayName.AddTranslation(GameCulture.Portuguese, "Chave Criônica");
                    Calamity.GetItem("CryoKey").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca o Criogênio\nO chefe enfurece fora da tundra de neve");
                    Calamity.GetItem("AncientMedallion").DisplayName.AddTranslation(GameCulture.Portuguese, "Apito da Morte");
                    Calamity.GetItem("AncientMedallion").Tooltip.AddTranslation(GameCulture.Portuguese, "Um apito do templo muito antigo\nInvoca o Devastador");
                    Calamity.GetItem("DecapoditaSprout").DisplayName.AddTranslation(GameCulture.Portuguese, "Broto de Decapodita");
                    Calamity.GetItem("DecapoditaSprout").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca o Crabulon");
                    Calamity.GetItem("DriedSeafood").DisplayName.AddTranslation(GameCulture.Portuguese, "Medalhão do Deserto");
                    Calamity.GetItem("DriedSeafood").Tooltip.AddTranslation(GameCulture.Portuguese, "A areia do deserto se agita...\nInvoca a Praga do Deserto");
                    Calamity.GetItem("DraedonsRemote").DisplayName.AddTranslation(GameCulture.Portuguese, "Controle Remoto de Draedon");
                    Calamity.GetItem("DraedonsRemote").Tooltip.AddTranslation(GameCulture.Portuguese, "Caos...");
                    Calamity.GetItem("ChickenEgg").DisplayName.AddTranslation(GameCulture.Portuguese, "Ovo de Dragão da Selva");
                    Calamity.GetItem("ChickenEgg").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca o guardião leal do rei tirano\nEle anseia pela selva\nNão consumível");
                    Calamity.GetItem("MartianDistressBeacon").DisplayName.AddTranslation(GameCulture.Portuguese, "Sinalizador de Socorro Marciano");
                    Calamity.GetItem("MartianDistressBeacon").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca a Loucura de Marte");
                    Calamity.GetItem("EidolonTablet").DisplayName.AddTranslation(GameCulture.Portuguese, "Placa de Eidolon");
                    Calamity.GetItem("BirbPheromones").DisplayName.AddTranslation(GameCulture.Portuguese, "Fermônios Exóticos");
                    Calamity.GetItem("BirbPheromones").Tooltip.AddTranslation(GameCulture.Portuguese, "Atrai o experimento dracônico falhado");
                    Calamity.GetItem("BlightedEyeball").DisplayName.AddTranslation(GameCulture.Portuguese, "Olho da Desolação");
                    Calamity.GetItem("BlightedEyeball").Tooltip.AddTranslation(GameCulture.Portuguese, "Esta noite vai ser horrível...\nInvoca a Calamitas\nNão consumível");
                    Calamity.GetItem("EyeofExtinction").DisplayName.AddTranslation(GameCulture.Portuguese, "Urna Ceremonial");
                    Calamity.GetItem("EyeofExtinction").Tooltip.AddTranslation(GameCulture.Portuguese, "Use no Altar Amaldiçoado para invocar a Calamitas Suprema\nNão consumível");
                    Calamity.GetItem("NecroplasmicBeacon").DisplayName.AddTranslation(GameCulture.Portuguese, "Sinalizador Necroplasmático");
                    Calamity.GetItem("NecroplasmicBeacon").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca o Polterghast\nNão consumível");
                    Calamity.GetItem("OldPowerCell").DisplayName.AddTranslation(GameCulture.Portuguese, "Bateria Antiga");
                    Calamity.GetItem("OldPowerCell").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca o antigo golem quando usado no Templo");
                    Calamity.GetItem("OverloadedSludge").DisplayName.AddTranslation(GameCulture.Portuguese, "Lama Sobrecarregada");
                    Calamity.GetItem("OverloadedSludge").Tooltip.AddTranslation(GameCulture.Portuguese, "Parece corrompido\nInvoca o Deus Geleia");
                    Calamity.GetItem("BulbofDoom").DisplayName.AddTranslation(GameCulture.Portuguese, "Bulbo Portável");
                    Calamity.GetItem("BulbofDoom").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca a Plantera");
                    Calamity.GetItem("ProfanedCoreUnlimited").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo Profano");
                    Calamity.GetItem("ProfanedCoreUnlimited").Tooltip.AddTranslation(GameCulture.Portuguese, "O núcleo da chama profana\nInvoca a Providência\nDeve ser usado durante o dia\nNão consumível");
                    Calamity.GetItem("ProfanedShard").DisplayName.AddTranslation(GameCulture.Portuguese, "Fragmento Profano");
                    Calamity.GetItem("ProfanedShard").Tooltip.AddTranslation(GameCulture.Portuguese, "Um fragmento da chama profana\nInvoca os Guardiões Profanos\nSó pode ser usado durante o dia");
                    Calamity.GetItem("RuneofCos").DisplayName.AddTranslation(GameCulture.Portuguese, "Runa de Kos");
                    Calamity.GetItem("RuneofCos").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma relíquia da chama profana\nContém o poder caçado pelas sentinelas do devorador cósmico\nQuando usada em certas áreas do mundo, elas serão libertadas\nNão consumível");
                    Calamity.GetItem("SandstormsCore").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo da Tempestade de Areia");
                    Calamity.GetItem("SandstormsCore").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca o Grande Tubarão de Areia");
                    Calamity.GetItem("Seafood").DisplayName.AddTranslation(GameCulture.Portuguese, "Frutos do Mar");
                    Calamity.GetItem("Seafood").Tooltip.AddTranslation(GameCulture.Portuguese, "A areia sulfúrica se agita...\nInvoca a Praga Aquática");
                    Calamity.GetItem("Starcore").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo Estelar");
                    Calamity.GetItem("Starcore").Tooltip.AddTranslation(GameCulture.Portuguese, "Que as estrelas guiem o seu caminho\nInvoca o Astrum Deus no Sinalizador Astral, mas não é consumido.");
                    Calamity.GetItem("SuperDummy").DisplayName.AddTranslation(GameCulture.Portuguese, "Super Boneco");
                    Calamity.GetItem("SuperDummy").Tooltip.AddTranslation(GameCulture.Portuguese, "Cria um super boneco\nRegenera 1 milhão de vida por segundo\nNão morrerá ao receber dano ao longo do tempo de efeitos negativos\nClique com o botão direito para matar todos os super bonecos");
                    Calamity.GetItem("Teratoma").DisplayName.AddTranslation(GameCulture.Portuguese, "Teratoma");
                    Calamity.GetItem("Teratoma").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca a Colmeia Mental");
                    Calamity.GetItem("BossRush").DisplayName.AddTranslation(GameCulture.Portuguese, "Terminus");
                    Calamity.GetItem("BossRush").Tooltip.AddTranslation(GameCulture.Portuguese, "Um artefato ritualístico, que se acredita ter trazido O Fim muitos milênios atrás\nSelado no abismo, longe daqueles que procuram fazer mau uso dele\nAtiva o Modo Corrida de Chefes, usá-lo novamente desativará o Modo Corrida de Chefes\nDurante a Corrida de Chefes, todos os fios e dispositivos com fio serão desativados");
                    Calamity.GetItem("TorrentialTear").DisplayName.AddTranslation(GameCulture.Portuguese, "Lágrima Torrencial");
                    Calamity.GetItem("TorrentialTear").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca a chuva.\nA chuva começará um tempo depois que este item for usado.\nSe usado enquanto está chovendo, a chuva irá parar depois de um tempo.\nNo Modo Morte, usar este item enquanto está chovendo reduizrá a quantidade de tempo que a chuva dura\na um minuto; no entanto, não mais baixo, e isso fará com que a chuva fique violenta naquele minuto.");

                    //Grab bags
                    Calamity.GetItem("AbyssalTreasure").DisplayName.AddTranslation(GameCulture.Portuguese, "Tesouro Abissal");
                    Calamity.GetItem("BleachedAnglingKit").DisplayName.AddTranslation(GameCulture.Portuguese, "Kit de Pesca Branqueado");
                    Calamity.GetItem("BleachedAnglingKit").Tooltip.AddTranslation(GameCulture.Portuguese, "Tem a chance de conter vários equipamentos de pesca\nClique com o botão direito para abrir");
                    Calamity.GetItem("ChaoticFish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe Caótico");
                    Calamity.GetItem("ChaoticFish").Tooltip.AddTranslation(GameCulture.Portuguese, "Os chifres colocam uma maldição sobre aqueles que o tocam\nClique com o botão direito para extrair essências");
                    Calamity.GetItem("FishofEleum").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe de Eleum");
                    Calamity.GetItem("FishofEleum").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique com o botão direito para extrair essências");
                    Calamity.GetItem("FishofFlight").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe do Voô");
                    Calamity.GetItem("FishofFlight").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique com o botão direito para extrair almas");
                    Calamity.GetItem("FishofLight").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe da Luz");
                    Calamity.GetItem("FishofLight").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique com o botão direito para extrair almas");
                    Calamity.GetItem("FishofNight").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe da Noite");
                    Calamity.GetItem("FishofNight").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique com o botão direito para extrair almas");
                    Calamity.GetItem("GlimmeringGemfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-gema Cintilante");
                    Calamity.GetItem("GlimmeringGemfish").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique com o botão direito para extrair gemas");
                    Calamity.GetItem("StarterBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa de Iniciante");
                    Calamity.GetItem("SandyAnglingKit").DisplayName.AddTranslation(GameCulture.Portuguese, "Kit de Pesca Arenoso");
                    Calamity.GetItem("SandyAnglingKit").Tooltip.AddTranslation(GameCulture.Portuguese, "Tem a chance de conter vários equipamentos de pesca\nClique com o botão direito para abrir");
                    Calamity.GetItem("StuffedFish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe Recheado");
                    Calamity.GetItem("StuffedFish").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique com o botão direito para extrair ervas e sementes");
                    Calamity.GetItem("SulphuricTreasure").DisplayName.AddTranslation(GameCulture.Portuguese, "Tesouro Sulfúrico");
                    Calamity.GetItem("SunbeamFish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe do Raio de Sol");
                    Calamity.GetItem("SunbeamFish").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique com o botão direito para extrair essências");

                    //Treasure Bags
                    Calamity.GetItem("DesertScourgeBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("CrabulonBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("HiveMindBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("PerforatorBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("SlimeGodBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("CryogenBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("AquaticScourgeBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("BrimstoneWaifuBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("CalamitasBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("LeviathanBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("AstrageldonBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("PlaguebringerGoliathBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("RavagerBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("AstrumDeusBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("BumblebirbBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("ProvidenceBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("CeaselessVoidBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("SignusBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("StormWeaverBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("PolterghastBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("OldDukeBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("DevourerofGodsBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("YharonBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("DraedonTreasureBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Bolsa do Tesouro");
                    Calamity.GetItem("SCalBag").DisplayName.AddTranslation(GameCulture.Portuguese, "Caixa do Tesouro");
                    Calamity.GetItem("Xerocodile").DisplayName.AddTranslation(GameCulture.Portuguese, "Xerocodilo");
                    Calamity.GetItem("Xerocodile").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique com o botão direito para extrair orbes de sangue");

                    //Fishing drops
                    Calamity.GetItem("CharredLasher").DisplayName.AddTranslation(GameCulture.Portuguese, "Lasher Carbonizado");
                    Calamity.GetItem("CharredLasher").Tooltip.AddTranslation(GameCulture.Portuguese, "Este peixe elusivo é uma mercadoria valiosa");
                    Calamity.GetItem("GreenwaveLoach").DisplayName.AddTranslation(GameCulture.Portuguese, "Botia da Onda Verde");
                    Calamity.GetItem("GreenwaveLoach").Tooltip.AddTranslation(GameCulture.Portuguese, "Um peixe ameaçado de extinção que é altamente valorizado no mercado");

                    //Other
                    //Lore items
                    Calamity.GetItem("KnowledgeKingSlime").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia Rei");
                    Calamity.GetItem("KnowledgeKingSlime").Tooltip.AddTranslation(GameCulture.Portuguese, "Apenas um tolo seria pego por essa desculpa lamentável de caçador.\nInfelizmente, nosso mundo não tem falta deles.");
                    Calamity.GetItem("KnowledgeDesertScourge").DisplayName.AddTranslation(GameCulture.Portuguese, "A Praga do Deserto");
                    Calamity.GetItem("KnowledgeDesertScourge").Tooltip.AddTranslation(GameCulture.Portuguese, "O grande verme do mar parece ter sobrevivido ao calor extremo o até mesmo se adaptado a ele.\nO que costumava ser uma besta majestosa nadando pela água agora se tornou uma casca seca e\nglutona, constantemente em busca voraz pela sua próxima refeição.");
                    Calamity.GetItem("KnowledgeEyeofCthulhu").DisplayName.AddTranslation(GameCulture.Portuguese, "O Olho de Cthulhu");
                    Calamity.GetItem("KnowledgeEyeofCthulhu").Tooltip.AddTranslation(GameCulture.Portuguese, "Aquele olho... que peculiar.\nEu senti ele te observando mais intensamente conforme você ficava mais forte.");
                    Calamity.GetItem("KnowledgeCrabulon").DisplayName.AddTranslation(GameCulture.Portuguese, "Crabulon");
                    Calamity.GetItem("KnowledgeCrabulon").Tooltip.AddTranslation(GameCulture.Portuguese, "Um caranguejo e seus cogumelos, uma história de amor.\nÉ interessante como as criaturas podem se adaptar a certas circunstâncias.");
                    Calamity.GetItem("KnowledgeCrimson").DisplayName.AddTranslation(GameCulture.Portuguese, "O Carmim");
                    Calamity.GetItem("KnowledgeCrimson").Tooltip.AddTranslation(GameCulture.Portuguese, "Este inferno sangrento, gerado a partir de uma massa informe que caiu das estrelas eras atrás.\nAgora é o lar de muitas criaturas horríveis, geradas a partir do sangue que bombeia e órgãos oscilantes profundos.");
                    Calamity.GetItem("KnowledgeCorruption").DisplayName.AddTranslation(GameCulture.Portuguese, "A Corrupção");
                    Calamity.GetItem("KnowledgeCorruption").Tooltip.AddTranslation(GameCulture.Portuguese, "A paisagem apodrecida e em permanente deterioração de vidas infectadas, causada por um micróbio mortal há muito tempo.\nHá rumores de que o micróbio foi criado por meio da experimentação de uma raça morta há muito tempo, anterior aos Terrarianos.");
                    Calamity.GetItem("KnowledgeBrainofCthulhu").DisplayName.AddTranslation(GameCulture.Portuguese, "O Cérebro de Cthulhu");
                    Calamity.GetItem("KnowledgeBrainofCthulhu").Tooltip.AddTranslation(GameCulture.Portuguese, "Um olho, e agora um cérebro.\nMuito provavelmente outra abominação gerada desta massa incipiente de carne.");
                    Calamity.GetItem("KnowledgeEaterofWorlds").DisplayName.AddTranslation(GameCulture.Portuguese, "O Devorador de Mundos");
                    Calamity.GetItem("KnowledgeEaterofWorlds").Tooltip.AddTranslation(GameCulture.Portuguese, "Talvez fosse apenas um verme gigante infectado pelo micróbio, que teve séculos para alimentar e desenvolver seu corpo purulento.\nParece provável, dadas as origens deste lugar.");
                    Calamity.GetItem("KnowledgePerforators").DisplayName.AddTranslation(GameCulture.Portuguese, "Os Perfuradores e a sua Colmeia");
                    Calamity.GetItem("KnowledgePerforators").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma abominação de carne, osso e orgãos misturados, infestados principalmente por vermes sugadores de sangue.\nOs pedaços que sobraram do cérebro devem ter sido absorvidos pelo carmim e reconstituídos nele.");
                    Calamity.GetItem("KnowledgeHiveMind").DisplayName.AddTranslation(GameCulture.Portuguese, "A Colmeia Mental");
                    Calamity.GetItem("KnowledgeHiveMind").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma colmeia de carne infectada por micróbios agrupados.\nNão acredito que matá-la diminuirá a corrupção aqui.");
                    Calamity.GetItem("KnowledgeQueenBee").DisplayName.AddTranslation(GameCulture.Portuguese, "Abelha Rainha");
                    Calamity.GetItem("KnowledgeQueenBee").Tooltip.AddTranslation(GameCulture.Portuguese, "Por mais rude que sejam os insetos gigantes, eles podem ser úteis em certas situações... dada a capacidade de controlá-los.");
                    Calamity.GetItem("KnowledgeSkeletron").DisplayName.AddTranslation(GameCulture.Portuguese, "Esqueletron");
                    Calamity.GetItem("KnowledgeSkeletron").Tooltip.AddTranslation(GameCulture.Portuguese, "Diz-se que a maldição afeta apenas os idosos.\nDepois de serem afligidos, eles se tornam um recipiente imortal para um antigo demônio do submundo.");
                    Calamity.GetItem("KnowledgeSlimeGod").DisplayName.AddTranslation(GameCulture.Portuguese, "O Deus Geleia");
                    Calamity.GetItem("KnowledgeSlimeGod").Tooltip.AddTranslation(GameCulture.Portuguese, "É uma distorção, um dos terrores biológicos mais ameaçadores já criados.\nSe esta criatura pudesse combinar todas as geleias do planeta, ela se tornaria quase imparável.");
                    Calamity.GetItem("KnowledgeUnderworld").DisplayName.AddTranslation(GameCulture.Portuguese, "O Submundo");
                    Calamity.GetItem("KnowledgeUnderworld").Tooltip.AddTranslation(GameCulture.Portuguese, "Essas torres de obsidiana e de pedra infernal já foram o lar de milhares de... 'pessoas'.\nInfelizmente para elas, elas foram distorcidas por seus demônios internos até que não pudessem mais ser salvas.");
                    Calamity.GetItem("KnowledgeWallofFlesh").DisplayName.AddTranslation(GameCulture.Portuguese, "A Parede de Carne");
                    Calamity.GetItem("KnowledgeWallofFlesh").Tooltip.AddTranslation(GameCulture.Portuguese, "Vejo que o dever foi completo.\nA amálgama profana de carne e ódio foi derrotada.\nPrepare-se para enfrentar os terrores que se escondem nos lugares claros e escuros deste mundo.");
                    Calamity.GetItem("KnowledgeCryogen").DisplayName.AddTranslation(GameCulture.Portuguese, "Criogênio");
                    Calamity.GetItem("KnowledgeCryogen").Tooltip.AddTranslation(GameCulture.Portuguese, "A prisão do arquimago.\nNão tenho certeza se ele ficou mais fraco ao longo das décadas de prisão.");
                    Calamity.GetItem("KnowledgeMechs").DisplayName.AddTranslation(GameCulture.Portuguese, "Os Trio Mecânico");
                    Calamity.GetItem("KnowledgeMechs").Tooltip.AddTranslation(GameCulture.Portuguese, "Vejo que você despertou os velhos brinquedos de Draedon.\nFerramentas antes úteis que se transformaram em feras selvagens quando suas IAs ficaram loucas, um erro que Draedon não conseguiu corrigir a tempo.");
                    Calamity.GetItem("KnowledgeTwins").DisplayName.AddTranslation(GameCulture.Portuguese, "Os Gêmeos");
                    Calamity.GetItem("KnowledgeTwins").Tooltip.AddTranslation(GameCulture.Portuguese, "Os observadores biomecânicos da noite, originalmente criados como segurança usando as almas extraídas de olhos humanos.\nEssas criaturas não pertenciam a este mundo, é melhor estar livre delas.");
                    Calamity.GetItem("KnowledgeBrimstoneCrag").DisplayName.AddTranslation(GameCulture.Portuguese, "Rochedo de Enxofre");
                    Calamity.GetItem("KnowledgeBrimstoneCrag").Tooltip.AddTranslation(GameCulture.Portuguese, "Ah...este lugar.\nO cheiro de promessas quebradas, dor e morte eventual está pesado no ar...");
                    Calamity.GetItem("KnowledgeBrimstoneElemental").DisplayName.AddTranslation(GameCulture.Portuguese, "Elemental de Enxofre");
                    Calamity.GetItem("KnowledgeBrimstoneElemental").Tooltip.AddTranslation(GameCulture.Portuguese, "O mais poderoso dos elementais, empenhado em se vingar do inferno sangrento que destruiu sua casa.\nFinalmente colocada para descansar, ela não sofrerá mais com a dor causada pela morte de seu povo.");
                    Calamity.GetItem("KnowledgeDestroyer").DisplayName.AddTranslation(GameCulture.Portuguese, "O Destruidor");
                    Calamity.GetItem("KnowledgeDestroyer").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma máquina trazida à vida pelas poderosas almas de guerreiros e construída para escavar enormes túneis em planetas para coletar recursos.\nPoderia ter se mostrado útil se Draedon não tivesse uma obsessão em transformar tudo em uma ferramenta de destruição.");
                    Calamity.GetItem("KnowledgeAquaticScourge").DisplayName.AddTranslation(GameCulture.Portuguese, "Praga Aquática");
                    Calamity.GetItem("KnowledgeAquaticScourge").Tooltip.AddTranslation(GameCulture.Portuguese, "Um horror nascido da poluição e da fome insaciável; baseado apenas no tamanho, este era apenas um jovem.\nEssas criaturas praga são os maiores predadores aquáticos e muito raramente frequentam essas águas rasas.");
                    Calamity.GetItem("KnowledgeSulphurSea").DisplayName.AddTranslation(GameCulture.Portuguese, "Mar Sulfuroso");
                    Calamity.GetItem("KnowledgeSulphurSea").Tooltip.AddTranslation(GameCulture.Portuguese, "Lembro-me das ondas serenas e da brisa límpida.\nA amargura da minha juventude há muito diminuiu, mas é tarde demais. Nunca devo repetir um erro como este novamente.");
                    Calamity.GetItem("KnowledgeSkeletronPrime").DisplayName.AddTranslation(GameCulture.Portuguese, "Esqueletron Alfa");
                    Calamity.GetItem("KnowledgeSkeletronPrime").Tooltip.AddTranslation(GameCulture.Portuguese, "Que engenhoca boba e sem sentido para algo criado com a essência do puro terror.\nDraedon obviamente tomou várias liberdades com seu design... Não estou impressionado.");
                    Calamity.GetItem("KnowledgeCalamitasClone").DisplayName.AddTranslation(GameCulture.Portuguese, "Clone da Calamitas");
                    Calamity.GetItem("KnowledgeCalamitasClone").Tooltip.AddTranslation(GameCulture.Portuguese, "Você é realmente mais forte do que eu pensava.\nEmbora o inferno sangrento ainda perdure, observando seu progresso.");
                    Calamity.GetItem("KnowledgePlantera").DisplayName.AddTranslation(GameCulture.Portuguese, "Plantera");
                    Calamity.GetItem("KnowledgePlantera").Tooltip.AddTranslation(GameCulture.Portuguese, "Parabéns, você matou uma planta.\nEla Foi usada como um recipiente para abrigar os espíritos daqueles infelizes o suficiente para encontrar o caminho até aqui.\nDesejo-lhe sorte ao lidar com as consequências.");
                    Calamity.GetItem("KnowledgeOcean").DisplayName.AddTranslation(GameCulture.Portuguese, "O Oceano");
                    Calamity.GetItem("KnowledgeOcean").Tooltip.AddTranslation(GameCulture.Portuguese, "Tome cuidado para não perturbar as águas profundas deste mundo.\nVocê pode despertar algo mais assustador do que a própria morte.\nMarque este item como favorito para evitar que o misterioso elemental da água apareça.");
                    Calamity.GetItem("KnowledgeLeviathanandSiren").DisplayName.AddTranslation(GameCulture.Portuguese, "Leviathan e Anahita");
                    Calamity.GetItem("KnowledgeLeviathanandSiren").Tooltip.AddTranslation(GameCulture.Portuguese, "Um estranho par de criaturas; um buscando companhia e o outro, sustento.\nTalvez, dois desajustados genéticos expulsos de suas casas que encontraram conforto em ajudar um ao outro.");
                    Calamity.GetItem("KnowledgeAstrumAureus").DisplayName.AddTranslation(GameCulture.Portuguese, "Astrum Aureus");
                    Calamity.GetItem("KnowledgeAstrumAureus").Tooltip.AddTranslation(GameCulture.Portuguese, "Um ciborgue titânico infectado por uma doença das estrelas expelido da barriga de um antigo deus.\nA destruição desta criatura não impedirá a propagação da doença.");
                    Calamity.GetItem("KnowledgeGolem").DisplayName.AddTranslation(GameCulture.Portuguese, "Golem");
                    Calamity.GetItem("KnowledgeGolem").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma construção primitiva.\nAdmiro a raça lagharto por sua engenhosidade, embora encontrar fé em um ídolo tão imperfeito invariavelmente levaria à sua queda.");
                    Calamity.GetItem("KnowledgePlaguebringerGoliath").DisplayName.AddTranslation(GameCulture.Portuguese, "A Portadora da Peste Gigante");
                    Calamity.GetItem("KnowledgePlaguebringerGoliath").Tooltip.AddTranslation(GameCulture.Portuguese, "Um amálgama terrível de aço, carne e infecção, capaz de destruir uma civilização inteira em apenas um ataque.\nSua barragem nuclear de praga pode deixar uma área inteira inabitável por meses. Uma pena que tenha chegado a isso, mas a praga deve ser contida.");
                    Calamity.GetItem("KnowledgeDukeFishron").DisplayName.AddTranslation(GameCulture.Portuguese, "Duque Peixe-dragão");
                    Calamity.GetItem("KnowledgeDukeFishron").Tooltip.AddTranslation(GameCulture.Portuguese, "O terror mutante do mar já foi o companheiro de confiança de um velho rei; ele o domesticou usando sua guloseima favorita.\nHá muito tempo, a criatura voôu em desespero do inferno sangrento e furioso que consumia sua casa, finalmente encontrando seu caminho para o oceano.");
                    Calamity.GetItem("KnowledgeRavager").DisplayName.AddTranslation(GameCulture.Portuguese, "Devastador");
                    Calamity.GetItem("KnowledgeRavager").Tooltip.AddTranslation(GameCulture.Portuguese, "O golem de carne construído usando necromancia torcida durante o tempo de minha conquista para conter minhas forças imparáveis.\nSeus criadores foram massacrados por ele momentos após sua concepção. É melhor que tenha sido destruído.");
                    Calamity.GetItem("KnowledgeLunaticCultist").DisplayName.AddTranslation(GameCulture.Portuguese, "Cultista Lunático");
                    Calamity.GetItem("KnowledgeLunaticCultist").Tooltip.AddTranslation(GameCulture.Portuguese, "O talentoso que encerrou minha grande convocação há muito tempo com seus pdoeres sobrenaturais sobre o arcano.\nAlguém que uma vez desprezei tanto por suas ações está agora... falecido, seu ritual de selamento desfeito... prepare-se para o fim.\nSua desgraça certa aproxima-se...");
                    Calamity.GetItem("KnowledgeBloodMoon").DisplayName.AddTranslation(GameCulture.Portuguese, "A Lua Vermelha");
                    Calamity.GetItem("KnowledgeBloodMoon").Tooltip.AddTranslation(GameCulture.Portuguese, "Há muito tempo, temíamos a luz da lua vermelha.\nMuitos enlouqueceram, outros morreram, mas poucos foram abençoados com uma riqueza de compreensão cósmica.");
                    Calamity.GetItem("KnowledgeAstralInfection").DisplayName.AddTranslation(GameCulture.Portuguese, "Infecção Astral");
                    Calamity.GetItem("KnowledgeAstralInfection").Tooltip.AddTranslation(GameCulture.Portuguese, "Esta paisagem dos sonhos distorcida, cercada por pilares não naturais sob um céu escuro e nebuloso.\nA lei natural foi quebrada. O que você fará?");
                    Calamity.GetItem("KnowledgeAstrumDeus").DisplayName.AddTranslation(GameCulture.Portuguese, "Astrum Deus");
                    Calamity.GetItem("KnowledgeAstrumDeus").Tooltip.AddTranslation(GameCulture.Portuguese, "Deus das estrelas e o maior recipiente para a Infecção Astral.\nEmbora derrubado de seu lugar entre as estrelas, seus remanescentes ganharam força, com o objetivo de ocupar seu lugar de direito no cosmos mais uma vez.");
                    Calamity.GetItem("KnowledgeMoonLord").DisplayName.AddTranslation(GameCulture.Portuguese, "Senhor da Lua");
                    Calamity.GetItem("KnowledgeMoonLord").Tooltip.AddTranslation(GameCulture.Portuguese, "Que desperdício.\nSe tivesse sido totalmente restaurado, teria sido uma força para ser vista, mas o que você lutou foi uma concha vazia.\nNo entanto, isso não diminui o imenso potencial encerrado nele, liberado após sua morte.");
                    Calamity.GetItem("KnowledgeProfanedGuardians").DisplayName.AddTranslation(GameCulture.Portuguese, "Os Guardiões Profanos");
                    Calamity.GetItem("KnowledgeProfanedGuardians").Tooltip.AddTranslation(GameCulture.Portuguese, "Os sempre-rejuvenescedores guardiões da chama profana.\nMuito parecido com uma fênix das cinzas, suas mortes são simplesmente uma parte de seu ciclo de vida.\nMuitas vezes minhas forças tiveram que destruir esses seres em busca da Deusa Profana.");
                    Calamity.GetItem("KnowledgeBumblebirb").DisplayName.AddTranslation(GameCulture.Portuguese, "O Dragonfolly");
                    Calamity.GetItem("KnowledgeBumblebirb").Tooltip.AddTranslation(GameCulture.Portuguese, "Um fracasso da ambição científica distorcida; parece que nossa arrogância com relação à vida mostrou-se mais uma vez nos resultados.\nOriginalmente planejado para ser um clone do Dragão da Selva, eles foram deixados vagando pela selva, atacando qualquer coisa em seu caminho.");
                    Calamity.GetItem("KnowledgeProvidence").DisplayName.AddTranslation(GameCulture.Portuguese, "Providência, a Deusa Profana");
                    Calamity.GetItem("KnowledgeProvidence").Tooltip.AddTranslation(GameCulture.Portuguese, "Um núcleo cercado por pedra e fogo, uma origem simples e um objetivo simples.\nO que seria de nós se ela não tivesse sido derrotada é um conceito assustador a considerar.");
                    Calamity.GetItem("KnowledgeSentinels").DisplayName.AddTranslation(GameCulture.Portuguese, "As Sentinelas do Devorador");
                    Calamity.GetItem("KnowledgeSentinels").Tooltip.AddTranslation(GameCulture.Portuguese, "Signus. O Vazio. O Explorador.\nCada um representa uma das maiores esferas de influência do Devorador.\nMatá-los provavelmente invocou sua raiva e te marcou como um alvo para destruição.");
                    Calamity.GetItem("KnowledgePolterghast").DisplayName.AddTranslation(GameCulture.Portuguese, "Polterghast");
                    Calamity.GetItem("KnowledgePolterghast").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma criatura nascida do ódio e da raiva, formada por inúmeras almas humanas com toda a sua energia inteiramente dedicada a consumir os outros.\nParece um desperdício ter uma fonte tão potente de poder devastando sem pensar por esses corredores vazios.");
                    Calamity.GetItem("KnowledgeOldDuke").DisplayName.AddTranslation(GameCulture.Portuguese, "Velho Duque");
                    Calamity.GetItem("KnowledgeOldDuke").Tooltip.AddTranslation(GameCulture.Portuguese, "Estranho, descobrir que o terror mutante dos mares não foi o único em sua biologia única.\nTalvez eu tenha me enganado ao classificar a criatura apenas por sua relação com os porcos-dragões.");
                    Calamity.GetItem("KnowledgeDevourerofGods").DisplayName.AddTranslation(GameCulture.Portuguese, "O Devorador de Deuses");
                    Calamity.GetItem("KnowledgeDevourerofGods").Tooltip.AddTranslation(GameCulture.Portuguese, "O poder desta serpente de assimilar as habilidades e energia daqueles que consumiu é único em quase todo o cosmos conhecido, exceto para seus irmãos menores.\nEu logo teria eliminado-o como uma ameaça se ele tivesse mais tempo e mais criaturas para devorar.");
                    Calamity.GetItem("KnowledgeYharon").DisplayName.AddTranslation(GameCulture.Portuguese, "Yharon, o Dragão da Selva");
                    Calamity.GetItem("KnowledgeYharon").Tooltip.AddTranslation(GameCulture.Portuguese, "Eu não seria capaz de suportar um mundo sem meu fiel companheiro ao meu lado.\nFelizmente, o destino vai permitir que seja um mundo que nunca terei que ver, para melhor ou para pior.");
                    Calamity.GetItem("KnowledgeExoMechs").DisplayName.AddTranslation(GameCulture.Portuguese, "O Trio Exo Mecânico");
                    Calamity.GetItem("KnowledgeExoMechs").Tooltip.AddTranslation(GameCulture.Portuguese, "Os frutos da habilidade magistral e otimização, criados apenas com o objetivo de destruir.\nNo entanto, no final, eles conseguiram pouco mais do que os designs originais dos quais foram derivados.");
                    Calamity.GetItem("KnowledgeCalamitas").DisplayName.AddTranslation(GameCulture.Portuguese, "Calamitas");
                    Calamity.GetItem("KnowledgeCalamitas").Tooltip.AddTranslation(GameCulture.Portuguese, "A bruxa incomparável. Talvez a única entre meus companheiros que me deu motivos para dúvidas.\nAgora que você a derrotou, seu destino está claro.\nVenha agora, enfrente-me.");
                    Calamity.GetItem("PowerCell").DisplayName.AddTranslation(GameCulture.Portuguese, "Bateria de Draedon");
                    Calamity.GetItem("PowerCell").Tooltip.AddTranslation(GameCulture.Portuguese, "Usado para carregar o armamento de Draedon em uma Estação de Carregamento\nTambém pode ser processado no Extrator para peças extras");

                    //Draedon's Logs
                    Calamity.GetItem("DraedonsLogSnowBiome").DisplayName.AddTranslation(GameCulture.Portuguese, "Registro de Draedon - A Devastação Congelada");
                    Calamity.GetItem("DraedonsLogSnowBiome").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique para ver seu conteúdo");
                    Calamity.GetItem("DraedonsLogJungle").DisplayName.AddTranslation(GameCulture.Portuguese, "Registro de Draedon - A Selva e a Praga");
                    Calamity.GetItem("DraedonsLogJungle").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique para ver seu conteúdo");
                    Calamity.GetItem("DraedonsLogSunkenSea").DisplayName.AddTranslation(GameCulture.Portuguese, "Registro de Draedon - Estudo na Vida Aquática Profunda");
                    Calamity.GetItem("DraedonsLogSunkenSea").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique para ver seu conteúdo");
                    Calamity.GetItem("DraedonsLogPlanetoid").DisplayName.AddTranslation(GameCulture.Portuguese, "Registro de Draedon - Espaço");
                    Calamity.GetItem("DraedonsLogPlanetoid").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique para ver seu conteúdo");
                    Calamity.GetItem("DraedonsLogHell").DisplayName.AddTranslation(GameCulture.Portuguese, "Registro de Draedon - Inferno");
                    Calamity.GetItem("DraedonsLogHell").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique para ver seu conteúdo");
                    Calamity.GetItem("OddMushroom").DisplayName.AddTranslation(GameCulture.Portuguese, "Cogumelo Estranho");
                    Calamity.GetItem("OddMushroom").Tooltip.AddTranslation(GameCulture.Portuguese, "Alucinante");
                    Calamity.GetItem("Rock").DisplayName.AddTranslation(GameCulture.Portuguese, "Rocha");
                    Calamity.GetItem("Rock").Tooltip.AddTranslation(GameCulture.Portuguese, "O primeiro objeto que Xeroc criou");

                    //Minecarts
                    Calamity.GetItem("DoGCart").DisplayName.AddTranslation(GameCulture.Portuguese, "A Vagoneta dos Deuses");

                    ///Mounts
                    //Pre-Hardmode
                    Calamity.GetItem("OnyxExcavatorKey").DisplayName.AddTranslation(GameCulture.Portuguese, "Chave da Escavadeira de Ônix");
                    Calamity.GetItem("OnyxExcavatorKey").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca uma broca para perfurar o mundo para que você possa destruir toda a geração de mundo pura\ncom total desconsideração por todas as criaturas que habitam essas terras. Tenho certeza que a EPA\ne a PETA gostariam de ter uma palavra com você depois.\nO poder da destruição aumenta com a picareta de maior potência em seu inventário");
                    Calamity.GetItem("TundraLeash").DisplayName.AddTranslation(GameCulture.Portuguese, "Coleira da Tundra");
                    Calamity.GetItem("TundraLeash").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um cachorro furioso que pode ser montado");

                    //Post-Moon Lord
                    Calamity.GetItem("Brimrose").DisplayName.AddTranslation(GameCulture.Portuguese, "Rosa de Enxofre");
                    Calamity.GetItem("Brimrose").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca uma rosa de enxofre que pode ser montada");
                    Calamity.GetItem("BirdSeed").DisplayName.AddTranslation(GameCulture.Portuguese, "Comida de Bobos");
                    Calamity.GetItem("BirdSeed").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca uma monstruosidade");
                    Calamity.GetItem("SquishyBeanMount").DisplayName.AddTranslation(GameCulture.Portuguese, "Jujuba Suspeita");
                    Calamity.GetItem("SquishyBeanMount").Tooltip.AddTranslation(GameCulture.Portuguese, "JUJUBA");
                    Calamity.GetItem("Fabsol").DisplayName.AddTranslation(GameCulture.Portuguese, "Espírito da Princesa na Garrafa");
                    Calamity.GetItem("Fabsol").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca o espírito de Cirrus, a Princesa Bêbada, em sua forma de alicórnio\nMontar nela irá transformar Cirrus, desmontar irá transformá-la de volta.");
                    Calamity.GetItem("GazeOfCrysthamyr").DisplayName.AddTranslation(GameCulture.Portuguese, "Olhar de Crysthamyr");
                    Calamity.GetItem("GazeOfCrysthamyr").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um dragão das sombras");
                    Calamity.GetItem("ExoThrone").DisplayName.AddTranslation(GameCulture.Portuguese, "Exo Caixa");
                    Calamity.GetItem("ExoThrone").Tooltip.AddTranslation(GameCulture.Portuguese, "Materializa um Exo trono bem aconchegante e extremamente ágil\nSubstituído\nSubstituído também\nUm gamer confortável é um gamer perigoso");

                    ///Pets
                    Calamity.GetItem("ForgottenDragonEgg").DisplayName.AddTranslation(GameCulture.Portuguese, "Ovo de Dragão Esquecido");
                    Calamity.GetItem("ForgottenDragonEgg").Tooltip.AddTranslation(GameCulture.Portuguese, "Chama Akato, o filho de Yharon, para o seu lado");
                    Calamity.GetItem("AstrophageItem").DisplayName.AddTranslation(GameCulture.Portuguese, "Astrófago");
                    Calamity.GetItem("AstrophageItem").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um astrófago para seguir você por aí");
                    Calamity.GetItem("BearEye").DisplayName.AddTranslation(GameCulture.Portuguese, "Olho de Bear");
                    Calamity.GetItem("BearEye").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um anjo guardião de estimação");
                    Calamity.GetItem("CharredRelic").DisplayName.AddTranslation(GameCulture.Portuguese, "Relíquia Carbonizada");
                    Calamity.GetItem("CharredRelic").Tooltip.AddTranslation(GameCulture.Portuguese, "Contém uma pequena de quantidade de enxofre");
                    Calamity.GetItem("CosmicPlushie").DisplayName.AddTranslation(GameCulture.Portuguese, "Bichinho de Pelúcia Cósmico");
                    Calamity.GetItem("CosmicPlushie").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca o devorador do cosmos...?\nObjetos pontudos possivelmente incluídos\nSuprime diabos vermelhos amigáveis");
                    Calamity.GetItem("TrashmanTrashcan").DisplayName.AddTranslation(GameCulture.Portuguese, "Lata de Lixo");
                    Calamity.GetItem("TrashmanTrashcan").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca o homem lixo");
                    Calamity.GetItem("RotomRemote").DisplayName.AddTranslation(GameCulture.Portuguese, "Otomer Triboluminescente");
                    Calamity.GetItem("RotomRemote").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um encrenqueiro elétrico\nUma pequena nota está anexada:\nObrigado, Aloe! Muito apreciado de Ben");
                    Calamity.GetItem("GeyserShell").DisplayName.AddTranslation(GameCulture.Portuguese, "Concha de Gêiser");
                    Calamity.GetItem("GeyserShell").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um pequeno eremita flak");
                    Calamity.GetItem("FoxDrive").DisplayName.AddTranslation(GameCulture.Portuguese, "Drive de Raposa");
                    Calamity.GetItem("FoxDrive").Tooltip.AddTranslation(GameCulture.Portuguese, "'Contém 1 arquivo nele'\n'Raposa.cs'");
                    Calamity.GetItem("PrimroseKeepsake").DisplayName.AddTranslation(GameCulture.Portuguese, "Prímula da Lembrança");
                    Calamity.GetItem("PrimroseKeepsake").Tooltip.AddTranslation(GameCulture.Portuguese, "Eles acabaram de...");
                    Calamity.GetItem("RomajedaOrchid").DisplayName.AddTranslation(GameCulture.Portuguese, "Orquídea Romajeda");
                    Calamity.GetItem("RomajedaOrchid").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um amigo nunca esquecido");
                    Calamity.GetItem("JoyfulHeart").DisplayName.AddTranslation(GameCulture.Portuguese, "Coração Alegre");
                    Calamity.GetItem("JoyfulHeart").Tooltip.AddTranslation(GameCulture.Portuguese, "Está estranhamente quente. Atrai o proibido.");
                    Calamity.GetItem("Levi").DisplayName.AddTranslation(GameCulture.Portuguese, "Levi");
                    Calamity.GetItem("Levi").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca uma Leviathan bebê de estimação");
                    Calamity.GetItem("PineapplePet").DisplayName.AddTranslation(GameCulture.Portuguese, "Abacaxi");
                    Calamity.GetItem("PineapplePet").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um abacaxi");
                    Calamity.GetItem("PlagueCaller").DisplayName.AddTranslation(GameCulture.Portuguese, "Chamador da Praga");
                    Calamity.GetItem("PlagueCaller").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca uma Portadora da Peste bebê de estimação");
                    Calamity.GetItem("BloodyVein").DisplayName.AddTranslation(GameCulture.Portuguese, "Veia Sangrenta");
                    Calamity.GetItem("BloodyVein").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca uma pilha de carne amalgamada");
                    Calamity.GetItem("RottingEyeball").DisplayName.AddTranslation(GameCulture.Portuguese, "Olho Apodrecido");
                    Calamity.GetItem("RottingEyeball").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um conglomerado corrompido");
                    Calamity.GetItem("McNuggets").DisplayName.AddTranslation(GameCulture.Portuguese, "Chicken McNuggets");
                    Calamity.GetItem("McNuggets").Tooltip.AddTranslation(GameCulture.Portuguese, "Estes chicken nuggets não são pra você comer!");
                    Calamity.GetItem("BrimstoneJewel").DisplayName.AddTranslation(GameCulture.Portuguese, "Joia de Enxofre");
                    Calamity.GetItem("BrimstoneJewel").Tooltip.AddTranslation(GameCulture.Portuguese, "A recompensa final por derrotar tal besta...\nQuem diria que ela seria tão fofa!");
                    Calamity.GetItem("IbarakiBox").DisplayName.AddTranslation(GameCulture.Portuguese, "Caixa dos Cem Medicamentos do Eremita");
                    Calamity.GetItem("IbarakiBox").Tooltip.AddTranslation(GameCulture.Portuguese, "Enquanto o gelo derrete na primaveira\nE as ondas lavam o cabelo do velho musgo...\nObrigado, adeus.\nInvoca o Terceiro Sábio\nUse o item com o botão direito do mouse na hotbar para alternar a bênção do Terceiro Sábio.\nCom a bênção, o jogador irá nascer com vida cheia ao invés da metade.");

                    //Light Pets
                    Calamity.GetItem("ChromaticOrb").DisplayName.AddTranslation(GameCulture.Portuguese, "Orbe Cromático");
                    Calamity.GetItem("ChromaticOrb").Tooltip.AddTranslation(GameCulture.Portuguese, "Brilha calorosamente na sua mão\nInvoca um antigo dragão leve de estimação que destaca os inimigos e as fontes de perigo próximas\nFornece uma pequena quantidade de luz no abismo");
                    Calamity.GetItem("SparksSummon").DisplayName.AddTranslation(GameCulture.Portuguese, "Borboleta Encantada");
                    Calamity.GetItem("SparksSummon").Tooltip.AddTranslation(GameCulture.Portuguese, "Alimente-o com borboletas para mantê-lo forte!\nInvoca uma misteriosa libélula leve de estimação\nFornece uma pequena quantidade de luz no abismo");
                    Calamity.GetItem("LittleLight").DisplayName.AddTranslation(GameCulture.Portuguese, "Luzinha");
                    Calamity.GetItem("LittleLight").Tooltip.AddTranslation(GameCulture.Portuguese, "Ela está procurando por você há muito tempo.\nInvoca uma pequena construção que o segue e fornece uma grande quantidade de luz\nFornece uma grande quantidade de luz no abismo");
                    Calamity.GetItem("RadiatingCrystal").DisplayName.AddTranslation(GameCulture.Portuguese, "Cristal Radiante");
                    Calamity.GetItem("RadiatingCrystal").Tooltip.AddTranslation(GameCulture.Portuguese, "O cristal contém traços de holoturina\nInvoca um radiador leve de estimação\nFornece uma pequena quantidade de luz no abismo");
                    Calamity.GetItem("RustedJingleBell").DisplayName.AddTranslation(GameCulture.Portuguese, "Sino Enferrujado");
                    Calamity.GetItem("RustedJingleBell").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um sino fantasma bebê leve de estimação\nFornece uma quantidade razoável de luz enquanto debaixo d'água");
                    Calamity.GetItem("StrangeOrb").DisplayName.AddTranslation(GameCulture.Portuguese, "Orbe Estranho");
                    Calamity.GetItem("StrangeOrb").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um Espírito do Oceano leve em miniatura de estimação\nFornece uma grande quantidade de luz enquanto debaixo d'água");


                    ///Potions
                    //Recovery Potions
                    Calamity.GetItem("Bloodfin").DisplayName.AddTranslation(GameCulture.Portuguese, "Barbatanas de Sangue");
                    Calamity.GetItem("Bloodfin").Tooltip.AddTranslation(GameCulture.Portuguese, "As maravilhas da angiogênese\nConcede um efeito que aumenta a regeneração de vida por 10 segundos\nO reforço na regeneraçãod e vida é mais forte se estiver abaixo de 75% de vida");
                    Calamity.GetItem("SupremeHealingPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção de Cura Suprema");
                    Calamity.GetItem("OmegaHealingPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção de Cura ômega");
                    Calamity.GetItem("SunkenStew").DisplayName.AddTranslation(GameCulture.Portuguese, "Ensopado Hadal");
                    Calamity.GetItem("SunkenStew").Tooltip.AddTranslation(GameCulture.Portuguese, "Só dá 50 segundos de Enjoo por poção\nFornece Bem alimentado\n60 minuto(s) de duração");
                    Calamity.GetItem("SupremeManaPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção de Mana");
                    Calamity.GetItem("Baguette").DisplayName.AddTranslation(GameCulture.Portuguese, "Baguete");
                    Calamity.GetItem("Baguette").Tooltip.AddTranslation(GameCulture.Portuguese, "Pequenas melhorias em todas as estatísticas\nMelhora os efeitos do Vinho Tinto\n[c/FCE391:je suis Monte]");
                    Calamity.GetItem("DeliciousMeat").DisplayName.AddTranslation(GameCulture.Portuguese, "Carne Deliciosa");
                    Calamity.GetItem("DeliciousMeat").Tooltip.AddTranslation(GameCulture.Portuguese, "Pequenas melhorias em todas as estatísticas\n'Muito, muito deliciosa'");
                    Calamity.GetItem("AnechoicCoating").DisplayName.AddTranslation(GameCulture.Portuguese, "Cobertura Anecóica");
                    Calamity.GetItem("AnechoicCoating").Tooltip.AddTranslation(GameCulture.Portuguese, "Reduz a capacidade das criaturas de detectá-lo no abismo");
                    Calamity.GetItem("AstralInjection").DisplayName.AddTranslation(GameCulture.Portuguese, "Injeção Astral");
                    Calamity.GetItem("AstralInjection").Tooltip.AddTranslation(GameCulture.Portuguese, "Te dá enjoo por mana e te machuca ao ser usada, mas você regenera mana extremamente rápido, mesmo enquanto se move ou lança feitiços");
                    Calamity.GetItem("BoundingPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção Saltitante");
                    Calamity.GetItem("BoundingPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Fornece 10% de aumento na velocidade dos pulos, 25 blocos a mais de resistência ao dano de queda, e um aumento na altura dos pulos");
                    Calamity.GetItem("CalamitasBrew").DisplayName.AddTranslation(GameCulture.Portuguese, "Bebida da Calamitas");
                    Calamity.GetItem("CalamitasBrew").Tooltip.AddTranslation(GameCulture.Portuguese, "Adiciona chamas abissais à seus projéteis físicos e ataques físicos\nAumenta a sua velocidade dos movimentos em 15%");
                    Calamity.GetItem("CalciumPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção do Cálcio");
                    Calamity.GetItem("CalciumPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Oferece imunidade ao dano de queda");
                    Calamity.GetItem("CeaselessHungerPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção da Fome Incessante");
                    Calamity.GetItem("CeaselessHungerPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Faz você sugar todos os itens no mundo");
                    Calamity.GetItem("CrumblingPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção do Desmoronamento");
                    Calamity.GetItem("CrumblingPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a chance de acerto crítico físico e ladino em 5%\nAtaques físicos e ladinos quebram a armadura do inimigo");
                    Calamity.GetItem("DraconicElixir").DisplayName.AddTranslation(GameCulture.Portuguese, "Elixir Dracônico");
                    Calamity.GetItem("DraconicElixir").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta bastante o tempo de voô das asas e velocidade e aumenta a defesa em 16\nA invincibilidade de silva cura você até a metade da vida quando ativada\nSe você ativar a cura acima, você não pode beber esta poção novamente por 60 segundos e você recebe 30 segundos de enjoo por poção");
                    Calamity.GetItem("GravityNormalizerPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção Normalizadora de Gravidade");
                    Calamity.GetItem("GravityNormalizerPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Desativa a baixa gravidade do espaço e concece imunidade ao efeito negativo distorcido");
                    Calamity.GetItem("HolyWrathPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção da Ira Sagrada");
                    Calamity.GetItem("HolyWrathPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta os danos em 12% e aumenta a velocidade dos movimentos e de voô horizontal em 5%\nAtaques infligem fogo sagrado\nEnquanto o efeito desta poção está ativo, o efeito da Poção da Ira é desabilitado");
                    Calamity.GetItem("PenumbraPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção da Penumbra");
                    Calamity.GetItem("PenumbraPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "A furtividade ladina gera 15% mais rápido enquanto você se move\nDurante a noite, a furtividade também gera 15% mais rápido enquanto parado\nDurante um eclipse, ambos os reforços aumentam para 20%");
                    Calamity.GetItem("PhotosynthesisPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção da Fotossíntese");
                    Calamity.GetItem("PhotosynthesisPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Você regenera vida rapidamente enquanto parado, este efeito é cinco vezes mais forte durante o dia\nCorações derrubados curam mais vida");
                    Calamity.GetItem("ProfanedRagePotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção da Raiva Profana");
                    Calamity.GetItem("ProfanedRagePotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a chance de acerto crítico em 12%e aumenta a velocidade dos movimentos e de voô horizontal em 5%\nNo Modo Vingança, você ganha mais raiva quando atingido\nEnquanto o efeito desta poção está ativo, o efeito da Poção da Raiva é desabilitado");
                    Calamity.GetItem("PurifiedJam").DisplayName.AddTranslation(GameCulture.Portuguese, "Geleia Purificada");
                    Calamity.GetItem("PurifiedJam").Tooltip.AddTranslation(GameCulture.Portuguese, "Torna você imune a todos os danos e à maioria dos efeitos negativos por 10 segundos\nCausa enjoo por poção no consumo\nNão pode ser consumida enquanto o enjoo por poção está ativo");
                    Calamity.GetItem("RevivifyPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção da Revivificação");
                    Calamity.GetItem("RevivifyPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Faz com que ataques inimigos curem você por uma fração de seu dano");
                    Calamity.GetItem("ShatteringPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção do Despedaçamento");
                    Calamity.GetItem("ShatteringPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta o dano por ataques físicos e ladinos e chance de acerto crítico físico e ladino em 8%\nAtaques físicos e ladinos quebram a armadura do inimigo\nEnquanto o efeito desta poção está ativo, o efeito da Poção do Desmoronamento é desabilitado");
                    Calamity.GetItem("ShadowPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção das Sombras");
                    Calamity.GetItem("ShadowPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Faz com que o jogador desapareça enquanto não ataca\nSegurar diferentes tipos de armas ladinas fornece reforços ao jogador\nDiferentes tipos de armas ladinas geram projéteis diferentes ao atingir o inimigo\nGeração de furtividade aumentada em 10%");
                    Calamity.GetItem("SoaringPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção Crescente");
                    Calamity.GetItem("SoaringPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta o tempo de voô e velocidade de voô horizontal em 10%\nRestaura uma fração do seu tempo de voô das asas depois de um ataque físico verdadeiro\nA quantidade de tempo de voô restaurado escala com as suas estatísticas físicas e velocidade de balanço da arma");
                    Calamity.GetItem("SulphurskinPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção da Pele de Enxofre");
                    Calamity.GetItem("SulphurskinPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Reduz os efeitos das águas sulfúricas");
                    Calamity.GetItem("TeslaPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção Tesla");
                    Calamity.GetItem("TeslaPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca uma aura de eletricidade que eletrifica e deixa os inimigos mais lentos\nA lentidão não funciona em chefes\nReduz a duração do efeito negativo Eletrizado");
                    Calamity.GetItem("TitanScalePotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção da Escama do Titã");
                    Calamity.GetItem("TitanScalePotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta o recuo, defesa em 5, e redução dos danos em 5%\nAumenta a defesa em 25 e redução dos danos em 10% por alguns segundos depois de um ataque físico verdadeiro");
                    Calamity.GetItem("TriumphPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção do Triunfo");
                    Calamity.GetItem("TriumphPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Dano por contato dos inimigos reduzido, quanto menor a vida do inimigo, mais ele é reduzido");
                    Calamity.GetItem("ZenPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção Zen");
                    Calamity.GetItem("ZenPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Diminui enormemente a taxa de surgimento dos inimigos");
                    Calamity.GetItem("ZergPotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção Zerg");
                    Calamity.GetItem("ZergPotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta enormemente a taxa de surgimento dos inimigos");
                    Calamity.GetItem("CadencePotion").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção da Cadência");
                    Calamity.GetItem("CadencePotion").Tooltip.AddTranslation(GameCulture.Portuguese, "Fornece o efeito de cadência que reduz a agressividade dos inimigos\nAumenta a regeneração de vida e aumenta a vida máxima em 25%\nAumenta o alcance de coleta de corações\nEnquanto o efeito desta poção está ativo, o efeito da Poção de Regeneração e da Poção de Força-vital é desabilitado");
                    Calamity.GetItem("PotionofOmniscience").DisplayName.AddTranslation(GameCulture.Portuguese, "Poção da Onisciência");
                    Calamity.GetItem("PotionofOmniscience").Tooltip.AddTranslation(GameCulture.Portuguese, "Destaca criaturas, projéteis inimigos,\nfontes de perigo e tesouro próximo");
                    Calamity.GetItem("YharimsStimulants").DisplayName.AddTranslation(GameCulture.Portuguese, "Estimulantes de Yharim");
                    Calamity.GetItem("YharimsStimulants").Tooltip.AddTranslation(GameCulture.Portuguese, "Oferece reforços decentes para TODAS as estatísticas ofensivas e defensivas");

                    //Drunk Princess' Drinks
                    Calamity.GetItem("BloodyMary").DisplayName.AddTranslation(GameCulture.Portuguese, "Maria Sangrenta");
                    Calamity.GetItem("BloodyMary").Tooltip.AddTranslation(GameCulture.Portuguese, "Extremamente picante e sangrento!\nAumenta o dano, velocidade dos movimentos e a velocidade do ataque físico em 15% e chance de acerto crítico em 7% durante uma Lua de Sangue\nReduz a regeneração de vida em 2 e defesa em 6");
                    Calamity.GetItem("CaribbeanRum").DisplayName.AddTranslation(GameCulture.Portuguese, "Rum Caribenho");
                    Calamity.GetItem("CaribbeanRum").Tooltip.AddTranslation(GameCulture.Portuguese, "Cadê o rum?\nAumenta a regeneração de vida em 2 e a velocidade dos movimentos e tempo de voô de asa em 20%\nDeixa você mais leve e reduz a defesa em 12");
                    Calamity.GetItem("CinnamonRoll").DisplayName.AddTranslation(GameCulture.Portuguese, "Rolo de Canela");
                    Calamity.GetItem("CinnamonRoll").Tooltip.AddTranslation(GameCulture.Portuguese, "Um uísque de canela com um ótimo sabor e um toque de vaca-preta\nAumenta a taxa de regeneração de mana e todos os danos de armas baseadas em fogo em 15%\nArmas de chamas amaldiçoadas, chamas das sombras, inferno do assassino de deuses, chamas de enxofre e queimadura de gelo não receberão este benefício\nA arma deve ser mais relacionada ao fogo do que qualquer outra coisa\nReduz a defesa em 12");
                    Calamity.GetItem("Everclear").DisplayName.AddTranslation(GameCulture.Portuguese, "Everclear");
                    Calamity.GetItem("Everclear").Tooltip.AddTranslation(GameCulture.Portuguese, "Esta é a bebida mais potente que eu tenho, tome cuidado com ela\nAumenta o dano em 25%\nReduz a regeneração de vida em 10 e a defesa em 40");
                    Calamity.GetItem("EvergreenGin").DisplayName.AddTranslation(GameCulture.Portuguese, "Gim Perene");
                    Calamity.GetItem("EvergreenGin").Tooltip.AddTranslation(GameCulture.Portuguese, "Tem gosto de árvore de Natal, se você consegue imaginar\nAumenta o dano de armas baseadas na natureza em 15% e a redução dos danos em 5%\nReduz a regeneração de vida em 1");
                    Calamity.GetItem("FabsolsVodka").DisplayName.AddTranslation(GameCulture.Portuguese, "Vodka de Fabsol");
                    Calamity.GetItem("FabsolsVodka").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta todas as estatísticas de dano em 8% mas reduz a defesa em 20\nAumenta o tempo de imunidade depois de ser atacado\nEste licor mágico é muito procurado por quem tem um paladar requintado");
                    Calamity.GetItem("Fireball").DisplayName.AddTranslation(GameCulture.Portuguese, "Bola de Fogo");
                    Calamity.GetItem("Fireball").Tooltip.AddTranslation(GameCulture.Portuguese, "Um uísque de canela com um ótimo sabor\nAumenta todos os danos de armas baseadas em fogo em 15%\nArmas de chamas amaldiçoadas, chamas das sombras, inferno do assassino de deuses, chamas de enxofre e queimadura de gelo não receberão este benefício\nA arma deve ser mais relacionada ao fogo do que qualquer outra coisa\nReduz a regeneração de vida em 1");
                    Calamity.GetItem("GrapeBeer").DisplayName.AddTranslation(GameCulture.Portuguese, "Cerveja de Uva");
                    Calamity.GetItem("GrapeBeer").Tooltip.AddTranslation(GameCulture.Portuguese, "Esta porcaria é horrível, mas você pode gostar\nReduz a defesa em 2 e a velocidade dos movimentos em 5%");
                    Calamity.GetItem("Margarita").DisplayName.AddTranslation(GameCulture.Portuguese, "Margarita");
                    Calamity.GetItem("Margarita").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma das melhores bebidas já criadas, aproveite enquanto pode\nReduz a duração da maioria dos efeitos negativos\nReduz a defesa em 6 e a regeneração de vida em 1\n3 minuto(s) de duração");
                    Calamity.GetItem("Moonshine").DisplayName.AddTranslation(GameCulture.Portuguese, "Moonshine");
                    Calamity.GetItem("Moonshine").Tooltip.AddTranslation(GameCulture.Portuguese, "Esta coisa é muito forte, mas tenho certeza que você aguenta\nAumenta a defesa em 10 e a redução dos danos em 5%\nReduz a regeneração de vida em 1");
                    Calamity.GetItem("MoscowMule").DisplayName.AddTranslation(GameCulture.Portuguese, "Mula de Moscou");
                    Calamity.GetItem("MoscowMule").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma vez eu ouvi que a caneca de cobre pode ser tóxica e eu disse 'olha aqui cara, eu já tô me envenenando'\nAumenta o dano e recuo em 9% e chance de acerto crítico em 3%\nReduz a regeneração de vida em 2");
                    Calamity.GetItem("RedWine").DisplayName.AddTranslation(GameCulture.Portuguese, "Vinho Tinto");
                    Calamity.GetItem("RedWine").Tooltip.AddTranslation(GameCulture.Portuguese, "Muito seco para o meu gosto\nReduz a regeneração de vida em 1");
                    Calamity.GetItem("Rum").DisplayName.AddTranslation(GameCulture.Portuguese, "Rum");
                    Calamity.GetItem("Rum").Tooltip.AddTranslation(GameCulture.Portuguese, "Doce e potente, do jeitinho que eu gosto\nAumenta a regeneração de vida em 2 e a velocidade dos movimentos em 10%\nReduz a defesa em 8");
                    Calamity.GetItem("Screwdriver").DisplayName.AddTranslation(GameCulture.Portuguese, "Chave de Fenda");
                    Calamity.GetItem("Screwdriver").Tooltip.AddTranslation(GameCulture.Portuguese, "Você tem um parafuso solto?\nAumenta o dano de projéteis perfurantes em 10%\nReduz a regeneração de vida em 1");
                    Calamity.GetItem("StarBeamRye").DisplayName.AddTranslation(GameCulture.Portuguese, "Centeio de Feixe Estelar");
                    Calamity.GetItem("StarBeamRye").Tooltip.AddTranslation(GameCulture.Portuguese, "Feito de algumas coisas que eu encontrei perto da queda do Meteoro Astral, não se preocupe, é seguro, confie em mim\nAumenta a mana máxima em 50, dano mágico em 8%,\ne reduz o uso de mana em 10%\nReduz a defesa em 6 e regeneração de vida em 1");
                    Calamity.GetItem("Tequila").DisplayName.AddTranslation(GameCulture.Portuguese, "Tequila");
                    Calamity.GetItem("Tequila").Tooltip.AddTranslation(GameCulture.Portuguese, "Ótimo para preparar bebidas durante o dia\nAumenta o dano, redução dos danos e recuo em 3%, chance de acerto crítico em 2%, e defesa em 5 durante o dia\nReduz a regeneração de vida em 1");
                    Calamity.GetItem("TequilaSunrise").DisplayName.AddTranslation(GameCulture.Portuguese, "Tequila do Nascer do Sol");
                    Calamity.GetItem("TequilaSunrise").Tooltip.AddTranslation(GameCulture.Portuguese, "A melhor bebida que eu já tomei\nAumenta o dano, redução dos danos e recuo em 7%, chance de acerto crítico em 3% e defesa em 15 durante o dia\nReduz a regeneração de vida em 1");
                    Calamity.GetItem("Vodka").DisplayName.AddTranslation(GameCulture.Portuguese, "Vodka");
                    Calamity.GetItem("Vodka").Tooltip.AddTranslation(GameCulture.Portuguese, "O álcool número um para a criação de ótimas bebidas mistas\nAumenta o dano em 6% e a chance de acerto crítico em 2%\nReduz a regeneração de vida em 1 e a defesa em 4");
                    Calamity.GetItem("Whiskey").DisplayName.AddTranslation(GameCulture.Portuguese, "Uísque");
                    Calamity.GetItem("Whiskey").Tooltip.AddTranslation(GameCulture.Portuguese, "A sensação de queimação torna-o mais saboroso\nAumenta o dano e recuo em 4% e a chance de acerto crítico em 2%\nReduz a defesa em 8");
                    Calamity.GetItem("WhiteWine").DisplayName.AddTranslation(GameCulture.Portuguese, "Vinho Branco");
                    Calamity.GetItem("WhiteWine").Tooltip.AddTranslation(GameCulture.Portuguese, "Eu bebi um barril cheio disso em uma noite uma vez, eu não conseguia lembrar de quem eu era no dia seguinte\nAumenta o dano mágico em 10%\nReduz a defesa em 6 e a regeneração de vida em 1");

                    //Permanent Power-ups
                    //Health Upgrades
                    Calamity.GetItem("BloodOrange").DisplayName.AddTranslation(GameCulture.Portuguese, "Laranja de Sangue");
                    Calamity.GetItem("BloodOrange").Tooltip.AddTranslation(GameCulture.Portuguese, "Tem um sabor nitidamente doce e um aroma forte\nAumenta a vida máxima permanentemente em 25\nSó pode ser usada se a quantidade máxima de frutas da vida foi consumida");
                    Calamity.GetItem("MiracleFruit").DisplayName.AddTranslation(GameCulture.Portuguese, "Fruta do Milagre");
                    Calamity.GetItem("MiracleFruit").Tooltip.AddTranslation(GameCulture.Portuguese, "Refrescante e fria, com um gostinho de menta\nAumenta a vida máxima permanentemente em 25\nSó pode ser usada se a quantidade máxima de frutas da vida foi consumida");
                    Calamity.GetItem("Elderberry").DisplayName.AddTranslation(GameCulture.Portuguese, "Sabugueiro");
                    Calamity.GetItem("Elderberry").Tooltip.AddTranslation(GameCulture.Portuguese, "Um sabor picante e ácido com um toque de terra\nAumenta a vida máxima permanentemente em 25\nSó pode ser usado se a quantidade máxima de frutas da vida foi consumida");
                    Calamity.GetItem("Dragonfruit").DisplayName.AddTranslation(GameCulture.Portuguese, "Fruta-do-dragão");
                    Calamity.GetItem("Dragonfruit").Tooltip.AddTranslation(GameCulture.Portuguese, "Embora um tanto insípido, o sabor que pode ser descrito é diferente de qualquer outro experienciado\nAumenta a vida máxima permanentemente em 25\nSó pode ser usada se a quantidade máxima de frutas da vida foi consumida");

                    //Mana Upgrades
                    Calamity.GetItem("EnchantedStarfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Estrela-do-mar Encantada");
                    Calamity.GetItem("EnchantedStarfish").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a mana máxima permanentemente em 20");
                    Calamity.GetItem("CometShard").DisplayName.AddTranslation(GameCulture.Portuguese, "Fragmento de Cometa");
                    Calamity.GetItem("CometShard").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a mana máxima permanentemente em 50");
                    Calamity.GetItem("EtherealCore").DisplayName.AddTranslation(GameCulture.Portuguese, "Núcleo Etéreo");
                    Calamity.GetItem("EtherealCore").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a mana máxima permanentemente em 50");
                    Calamity.GetItem("PhantomHeart").DisplayName.AddTranslation(GameCulture.Portuguese, "Coração Fantasma");
                    Calamity.GetItem("PhantomHeart").Tooltip.AddTranslation(GameCulture.Portuguese, "Aumenta a mana máxima permanentemente em 50");

                    //Rage Mode Upgrades
                    Calamity.GetItem("MushroomPlasmaRoot").DisplayName.AddTranslation(GameCulture.Portuguese, "Raiz de Plasma de Cogumelo");
                    Calamity.GetItem("MushroomPlasmaRoot").Tooltip.AddTranslation(GameCulture.Portuguese, "Permanentemente faz o Modo Fúria causar 15% a mais de dano\nEspólio do modo Vingança");
                    Calamity.GetItem("InfernalBlood").DisplayName.AddTranslation(GameCulture.Portuguese, "Sangue Infernal");
                    Calamity.GetItem("InfernalBlood").Tooltip.AddTranslation(GameCulture.Portuguese, "Permanentemente faz o Modo Fúria causar 15% a mais de dano\nEspólio do modo Vingança");
                    Calamity.GetItem("RedLightningContainer").DisplayName.AddTranslation(GameCulture.Portuguese, "Recipiente de Relâmpago Vermelho");
                    Calamity.GetItem("RedLightningContainer").Tooltip.AddTranslation(GameCulture.Portuguese, "Permanentemente faz o Modo Fúria causar 15% a mais de dano\nEspólio do modo Vingança");

                    //Adrenaline Mode Upgrades
                    Calamity.GetItem("ElectrolyteGelPack").DisplayName.AddTranslation(GameCulture.Portuguese, "Pacote de Gel Eletrólito");
                    Calamity.GetItem("ElectrolyteGelPack").Tooltip.AddTranslation(GameCulture.Portuguese, "Permanentemente aumenta o dano e a redução dos danos do Modo Adrenalina em 15% e 5% respectivamente\nEspólio do modo Vingança");
                    Calamity.GetItem("StarlightFuelCell").DisplayName.AddTranslation(GameCulture.Portuguese, "Célula de Combustível da Luz das Estrelas");
                    Calamity.GetItem("StarlightFuelCell").Tooltip.AddTranslation(GameCulture.Portuguese, "Permanentemente aumenta o dano e a redução dos danos do Modo Adrenalina em 15% e 5% respectivamente\nEspólio do modo Vingança");
                    Calamity.GetItem("Ectoheart").DisplayName.AddTranslation(GameCulture.Portuguese, "Ectocoração");
                    Calamity.GetItem("Ectoheart").Tooltip.AddTranslation(GameCulture.Portuguese, "Permanentemente aumenta o dano e a redução dos danos do Modo Adrenalina em 15% e 5% respectivamente\nEspólio do modo Vingança");

                    //Other Upgrades
                    Calamity.GetItem("MLGRune2").DisplayName.AddTranslation(GameCulture.Portuguese, "Cebola Celestial");
                    Calamity.GetItem("MLGRune2").Tooltip.AddTranslation(GameCulture.Portuguese, "Poder alienígena pulsa dentro de suas camadas\nConsumí-la faz algo que não pode ser revertido");

                    //Tools
                    //Multi-use tools
                    Calamity.GetItem("MarniteObliterator").DisplayName.AddTranslation(GameCulture.Portuguese, "Obliterador de Marnito");
                    Calamity.GetItem("ReefclawHamaxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Martelo-machado da Garra do Recife");
                    Calamity.GetItem("AerialHamaxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Martelo-machado Aéreo");
                    Calamity.GetItem("FlamebeakHampick").DisplayName.AddTranslation(GameCulture.Portuguese, "Picareta-martelo Sísmica");
                    Calamity.GetItem("FlamebeakHampick").Tooltip.AddTranslation(GameCulture.Portuguese, "Capaz de minerar tijolos lagharto\nClique com o botão esquerdo para usar como uma picareta\nClique com o botão direito para usar como um martelo");
                    Calamity.GetItem("AstralHamaxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Martelo-machado Astral");

                    //Pickaxes
                    Calamity.GetItem("Spadefish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-pá");
                    Calamity.GetItem("Spadefish").Tooltip.AddTranslation(GameCulture.Portuguese, "Como que um peixe pode ser usado para cavar?\nAlgumas perguntas devem ser deixadas sem resposta.");
                    Calamity.GetItem("WulfrumPickaxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Picareta de Vulfrânio");
                    Calamity.GetItem("GreatbayPickaxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Picareta da Grande Baía");
                    Calamity.GetItem("GreatbayPickaxe").Tooltip.AddTranslation(GameCulture.Portuguese, "Pode minerar meteorito");
                    Calamity.GetItem("SkyfringePickaxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Picareta da Margem dos Céus");
                    Calamity.GetItem("SkyfringePickaxe").Tooltip.AddTranslation(GameCulture.Portuguese, "Permite a mineração de pedras infernais");
                    Calamity.GetItem("Gelpick").DisplayName.AddTranslation(GameCulture.Portuguese, "Gelcareta");
                    Calamity.GetItem("ShardlightPickaxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Picareta do Fragmento da Luz");
                    Calamity.GetItem("BeastialPickaxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Picareta Bestial");
                    Calamity.GetItem("AstralPickaxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Picareta Astral");
                    Calamity.GetItem("GallantPickaxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Picareta do Gênese");
                    Calamity.GetItem("GallantPickaxe").Tooltip.AddTranslation(GameCulture.Portuguese, "Pode minerar minério florescente");
                    Calamity.GetItem("BlossomPickaxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Picareta Floral");
                    Calamity.GetItem("BlossomPickaxe").Tooltip.AddTranslation(GameCulture.Portuguese, "Pode minerar minério áurico");
                    Calamity.GetItem("CrystylCrusher").DisplayName.AddTranslation(GameCulture.Portuguese, "Trituradora Cristalina");
                    Calamity.GetItem("CrystylCrusher").Tooltip.AddTranslation(GameCulture.Portuguese, "Tenho que cavar mais rápido, tenho que cavar mais profundo\nClique com o botão direito para balançar normalmente");

                    //Axes
                    Calamity.GetItem("WulfrumAxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Machado de Vulfrânio");
                    Calamity.GetItem("BerserkerWaraxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Machado de Guerra Furioso");
                    Calamity.GetItem("ChaoswarpedSlashaxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Truncador Tectônico");

                    //Hammers
                    Calamity.GetItem("WulfrumHammer").DisplayName.AddTranslation(GameCulture.Portuguese, "Martelo de Vulfrânio");
                    Calamity.GetItem("AbyssalWarhammer").DisplayName.AddTranslation(GameCulture.Portuguese, "Martelo de Guerra Abissal");
                    Calamity.GetItem("HydraulicVoltCrasher").DisplayName.AddTranslation(GameCulture.Portuguese, "Esmagador de Tensão Hidráulica");
                    Calamity.GetItem("HydraulicVoltCrasher").Tooltip.AddTranslation(GameCulture.Portuguese, "Bom pra estampar placas de metal e fundi-las instantaneamente, bem como esmagar inimigos.\nUma britadeira eletricamente carregada que choca todos os inimigos próximos no acerto");

                    //Hooks
                    Calamity.GetItem("SerpentsBite").DisplayName.AddTranslation(GameCulture.Portuguese, "Mordida da Serpente");
                    Calamity.GetItem("SerpentsBite").Tooltip.AddTranslation(GameCulture.Portuguese, "Alcance: 28.125\nVelocidade de Lançamento: 18\nVelocidade de Tração: 14");
                    Calamity.GetItem("BobbitHook").DisplayName.AddTranslation(GameCulture.Portuguese, "Gancho Bobbit");
                    Calamity.GetItem("BobbitHook").Tooltip.AddTranslation(GameCulture.Portuguese, "Retrai ao atingir uma peça com velocidades extremas\nAlcance: 40\nVelocidade de Lançamento: 25\nVelocidade de Tração: 28");

                    //Fishing Poles
                    Calamity.GetItem("WulfrumRod").DisplayName.AddTranslation(GameCulture.Portuguese, "Vara de Pescar de Vulfrânio");
                    Calamity.GetItem("WulfrumRod").Tooltip.AddTranslation(GameCulture.Portuguese, "Isso quase não funciona, mas é melhor do que nada.");
                    Calamity.GetItem("NavyFishingRod").DisplayName.AddTranslation(GameCulture.Portuguese, "Vara de Pescar Marinha");
                    Calamity.GetItem("NavyFishingRod").Tooltip.AddTranslation(GameCulture.Portuguese, "Enquanto segurada, eletrifrica lentamente os inimigos próximos.\nO mar é uma cidade.\nLogo abaixo estão rodovias, avenidas, ruas e rotatórias movimentadas com o tráfego submarino.");
                    Calamity.GetItem("HeronRod").DisplayName.AddTranslation(GameCulture.Portuguese, "Vara da Garça");
                    Calamity.GetItem("HeronRod").Tooltip.AddTranslation(GameCulture.Portuguese, "Maior poder de pesca no espaço.\nUma cabeça e um bico silenciosos lançaram-se para baixo e arrancaram-no pela cabeça,\ne o bico engoliu o peixinho enquanto sua cauda balançava freneticamente.");
                    Calamity.GetItem("SlurperPole").DisplayName.AddTranslation(GameCulture.Portuguese, "Vara Mastigadora");
                    Calamity.GetItem("SlurperPole").Tooltip.AddTranslation(GameCulture.Portuguese, "Pode pescar na lava.\nÉ a lava ardente da alma que tem uma fornalha dentro--um vulcão de dor e tristeza.");
                    Calamity.GetItem("VerstaltiteFishingRod").DisplayName.AddTranslation(GameCulture.Portuguese, "Vara de Pescar de Verstaltita");
                    Calamity.GetItem("VerstaltiteFishingRod").Tooltip.AddTranslation(GameCulture.Portuguese, "Maior poder de pesca na tundra.\nAs qualidades prismáticas da liga antiga são perfeitas para atrair peixes.");
                    Calamity.GetItem("FeralDoubleRod").DisplayName.AddTranslation(GameCulture.Portuguese, "Vara Dupla Selvagem");
                    Calamity.GetItem("FeralDoubleRod").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara duas linhas de uma vez.\nAssim como você domesticou o monstro da selva, agora você pode domar os peixes no mar.");
                    Calamity.GetItem("ChaoticSpreadRod").DisplayName.AddTranslation(GameCulture.Portuguese, "Carretel da Fractura");
                    Calamity.GetItem("ChaoticSpreadRod").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara de três a cinco linhas de uma vez. Pode pescar na lava.\nO campo de batalha é um cenário de caos constante.\nO vencedor será aquele que controlar esse caos, tanto a vara quanto os peixes.");
                    Calamity.GetItem("EarlyBloomRod").DisplayName.AddTranslation(GameCulture.Portuguese, "Vara do Florescer");
                    Calamity.GetItem("EarlyBloomRod").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara seis linhas de uma vez. A linha nunca quebra.\nO pássaro que madruga pega a minhoca.");
                    Calamity.GetItem("TheDevourerofCods").DisplayName.AddTranslation(GameCulture.Portuguese, "O Devorador de Peixes");
                    Calamity.GetItem("TheDevourerofCods").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara dez linhas de uma vez. A linha nunca quebra e pode pescar na lava.\nO devorador já foi apenas um Devorador de Cardumes.");

                    //Other
                    Calamity.GetItem("BallAndChain").DisplayName.AddTranslation(GameCulture.Portuguese, "Bola e Corrente");
                    Calamity.GetItem("BallAndChain").Tooltip.AddTranslation(GameCulture.Portuguese, "Que pesado...\nMarque este item como favorito para desabilitar quaisquer corridas concedidas por equipamentos.");
                    Calamity.GetItem("RelicOfConvergence").DisplayName.AddTranslation(GameCulture.Portuguese, "Relíquia da Convergência");
                    Calamity.GetItem("RelicOfConvergence").Tooltip.AddTranslation(GameCulture.Portuguese, "Cria um cristal profano que carrega poder\nSegurar o cristal deixa o jogador mais lento\nNo final de sua vida, o cristal cura o jogador");
                    Calamity.GetItem("RelicOfResilience").DisplayName.AddTranslation(GameCulture.Portuguese, "Relíquia da Resiliência");
                    Calamity.GetItem("RelicOfResilience").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca um baluarte na posição do mouse\nO baluarte é morto por inimigos e todos os projéteis.\nAo morrer, o baluarte explode em uma explosão rotativa de fragmentos\nSe um inimigo estiver na área dos fragmentos, seu próximo ataque será muito mais fraco. Este efeito tem um tempo de recarga\nDepois de um tempo, os fragmentos se juntam para reformar o baluarte original.\nEssa reforma só pode acontecer 3 vezes.\nVocê ganha um pequeno tempo de recarga ao invocar um novo baluarte.\nSe um baluarte já existe, usar este item irá realocá-lo");

                    //Informative
                    Calamity.GetItem("BrimstoneLocus").DisplayName.AddTranslation(GameCulture.Portuguese, "Vidente de Enxofre");
                    Calamity.GetItem("BrimstoneLocus").Tooltip.AddTranslation(GameCulture.Portuguese, "Não só posso aprimorar seu equipamento com magia potente, como também posso extrair a verdadeira força\ne elevar algumas de suas armas a formas inteiramente novas\nEsses itens são revelados enquanto este item está em seu inventário");
                    Calamity.GetItem("CyanSeekingMechanism").DisplayName.AddTranslation(GameCulture.Portuguese, "Mecanismo de Procura Ciano");
                    Calamity.GetItem("CyanSeekingMechanism").Tooltip.AddTranslation(GameCulture.Portuguese, "Move-se rapidamente em direção a um laboratório nas profundezas do deserto");
                    Calamity.GetItem("GreenSeekingMechanism").DisplayName.AddTranslation(GameCulture.Portuguese, "Mecanismo de Procura Verde");
                    Calamity.GetItem("GreenSeekingMechanism").Tooltip.AddTranslation(GameCulture.Portuguese, "Move-se rapidamente em direção a um laboratório dentro da selva");
                    Calamity.GetItem("PurpleSeekingMechanism").DisplayName.AddTranslation(GameCulture.Portuguese, "Mecanismo de Procura Roxo");
                    Calamity.GetItem("PurpleSeekingMechanism").Tooltip.AddTranslation(GameCulture.Portuguese, "Move-se rapidamente em direção a um laboratório no céu");
                    Calamity.GetItem("RedSeekingMechanism").DisplayName.AddTranslation(GameCulture.Portuguese, "Mecanismo de Procura Vermelho");
                    Calamity.GetItem("RedSeekingMechanism").Tooltip.AddTranslation(GameCulture.Portuguese, "Move-se rapidamente em direção a um laboratório dentro do submundo");
                    Calamity.GetItem("YellowSeekingMechanism").DisplayName.AddTranslation(GameCulture.Portuguese, "Mecanismo de Procura Amarelo");
                    Calamity.GetItem("YellowSeekingMechanism").Tooltip.AddTranslation(GameCulture.Portuguese, "Move-se rapidamente em direção a um laboratório dentro das cavernas congeladas");
                    Calamity.GetItem("StatMeter").DisplayName.AddTranslation(GameCulture.Portuguese, "Medidor de Estatísticas");

                    //Spawn Blockers

                    Calamity.GetItem("AntiCystOintment").DisplayName.AddTranslation(GameCulture.Portuguese, "Pomada Anti-Cistos");
                    Calamity.GetItem("AntiCystOintment").Tooltip.AddTranslation(GameCulture.Portuguese, "Marque este item como favorito para evitar que cistos de perfurador surjam perto de você");
                    Calamity.GetItem("AntiTumorOintment").DisplayName.AddTranslation(GameCulture.Portuguese, "Pomada Anti-Tumores");
                    Calamity.GetItem("AntiTumorOintment").Tooltip.AddTranslation(GameCulture.Portuguese, "Marque este item como favorito para evitar que cistos de colmeia surjam perto de você");
                    Calamity.GetItem("BleachBall").DisplayName.AddTranslation(GameCulture.Portuguese, "Bola de Alvejante");
                    Calamity.GetItem("BleachBall").Tooltip.AddTranslation(GameCulture.Portuguese, "Marque este item como favorito para evitar que a Praga Aquática surja naturalmente perto de você");
                    Calamity.GetItem("BrokenWaterFilter").DisplayName.AddTranslation(GameCulture.Portuguese, "Filtro de Água Quebrado");
                    Calamity.GetItem("BrokenWaterFilter").Tooltip.AddTranslation(GameCulture.Portuguese, "Marque este item como favorito para desabilitar invocações de Chuvas Ácidas naturais");
                    Calamity.GetItem("SirenproofEarMuffs").DisplayName.AddTranslation(GameCulture.Portuguese, "Protetor de Ouvido Anti-Sereias");
                    Calamity.GetItem("SirenproofEarMuffs").Tooltip.AddTranslation(GameCulture.Portuguese, "Marque este item como favorito para evitar que Anahita surja perto de você");
                    Calamity.GetItem("VoodooDemonVoodooDoll").DisplayName.AddTranslation(GameCulture.Portuguese, "Boneco de Vodu do Demônio Vodu");
                    Calamity.GetItem("VoodooDemonVoodooDoll").Tooltip.AddTranslation(GameCulture.Portuguese, "Marque este item como favorito para evitar que demônios vodu surjam perto de você");

                    //Teleportation
                    Calamity.GetItem("NormalityRelocator").DisplayName.AddTranslation(GameCulture.Portuguese, "Realocador de Normalidade");
                    Calamity.GetItem("NormalityRelocator").Tooltip.AddTranslation(GameCulture.Portuguese, "Estarei lá em um piscar de olhos\nEsta linha é modificada abaixo\nA teleportação é desabilitada enquanto o Estado de caos está ativo\nAumenta a velocidade do movimento e da queda em 10%\nFunciona enquanto no inventário");

                    //Time
                    Calamity.GetItem("Cosmolight").DisplayName.AddTranslation(GameCulture.Portuguese, "Luz Cósmica");
                    Calamity.GetItem("Cosmolight").Tooltip.AddTranslation(GameCulture.Portuguese, "Muda a noite para o dia e vice-versa");

                    //Mechanics
                    Calamity.GetItem("Death").DisplayName.AddTranslation(GameCulture.Portuguese, "Morte");
                    Calamity.GetItem("Death").Tooltip.AddTranslation(GameCulture.Portuguese, "Ativa/desativa o Modo Morte, só pode ser usado no Modo Vingança.\nTodos os efeitos do Modo Vingança estão ativos, incluindo os seguintes:\nPermite que certos chefes surjam naturalmente, dependendo de em qual bioma você está.\nCertos biomas e eventos têm efeitos climáticos adicionais.\nOs efeitos de lava letal estão sempre ativos.\nAumenta o dano inimigo em 15%.\nAumenta muito as taxas de surgimento de inimigos durante a lua de sangue.\nTorna o abismo mais perigoso de navegar.\nCertos inimigos e projéteis que não são de chefes causam entre 6% a 15% a mais de dano\nEnfraquece o efeito do roubo de vida um pouco mais.\nA enfermeira não te cura mais enquanto um chefe está vivo.\nDano de defesa é aumentado em 2.5%.\nAumenta o dano causado em 50% para vários efeitos negativos e todos os álcoois que reduzem a regeneração de vida.\nAltera as IAs dos chefes e algumas IAs de inimigos um pouco mais.\nAumenta o dano de todos os chefes um pouco mais.");                    
                    Calamity.GetItem("Malice").DisplayName.AddTranslation(GameCulture.Portuguese, "Malícia");
                    Calamity.GetItem("Malice").Tooltip.AddTranslation(GameCulture.Portuguese, "Ativa/desativa o Modo Malícia.\n[c/c01818:Este modo é subjetivo, jogue como quiser, não espere viver.]\n[c/c01818:Este modo pretende ser um modo de revanche de chefes, no entanto, os chefes ainda são possíveis quando enfrentados no nível correto.]\nEnquanto ativado, os chefes irão deixar cair itens de Desafio e de Desafio Lendário.\nEnfraquece muito a efetividade do roubo de vida.\nEnfraquece a efetividade do bônus definido da Armadura de Titânio, isto não combina com o Modo Vingança.\nA Enfermeira não o cura mais enquanto um chefe está vivo.\nDano de defesa é 5% mais alto que no Modo Morte.\nAumenta o dano causado por 50% para vários efeitos negativos e todos os álcoois que reduzem a regeneração de vida.\nTodos os lacaios de chefes não soltam mais corações.\nDá a todos os chefes uma nova IA enfurecida e permite que eles deixem cair itens especiais.\nChefes e seus projéteis causam 35% a mais de dano.\nA maioria dos chefes entrará em fases posteriores mais cedo se a luta durar muito tempo.\nAumenta a velocidade da maioria dos projéteis de chefes em 25%, isto é aumentado para 35% durante a Corrida de Chefes.\nA RD reativa em chefes está sempre ativada fora da Corrida de Chefes e é aumentada em 50%");
                    Calamity.GetItem("Revenge").DisplayName.AddTranslation(GameCulture.Portuguese, "Vingança");
                    Calamity.GetItem("Revenge").Tooltip.AddTranslation(GameCulture.Portuguese, "Ativa/desativa o Modo Vingança, só pode ser usado no Modo Perito.\nDICA DA FÚRIA AQUI\nVocê ganha Fúria quando está perto de inimigos ou usando itens especiais.\nDICA DA ADRENALINA AQUI\nVocê ganha Adrenalina sempre que um chefe está vivo. Ser atingido reduz a adrenalina de volta a 0.\nTodos os inimigos deixam cair 50% a mais de dinheiro e surgem 15% mais frequentemente\nCertos inimigos e projéteis que não são de chefes causam entre 10% e 25% a mais de dano.\nFaz com que certos inimigos bloqueiem o roubo de vida e enfraquece a eficácia do roubo de vida.\nEnfraquece a eficácia do bônus do conjunto da Armadura de Titânio.\nO dano de defesa é aumentado em 2.5%.\nOs lacaios dos chefes não soltam mais corações.\nAltera todas as IAs de chefe e algumas IAs de inimigo.\nAumenta a vida e o dano de todos os chefes.\nA maioria dos chefes entrará em fases posteriores mais cedo se a luta durar muito tempo.");

                    ///Weapons
                    //Melee weapons
                    //Swords
                    //Pre-hardmode
                    Calamity.GetItem("Basher").DisplayName.AddTranslation(GameCulture.Portuguese, "Batedor");
                    Calamity.GetItem("Basher").Tooltip.AddTranslation(GameCulture.Portuguese, "Inflige irradiação ao atingir o inimigo");
                    Calamity.GetItem("BiomeBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina do Bioma Quebrada");
                    Calamity.GetItem("BiomeBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "FUNCTION_DESC\nSegure o BDM enquanto está parado em terreno plano para sintonizar a arma com os poderes do bioma em sua volta\nCaso contrário, usar o BDM alterna entre a sintonização atual e uma extra armazenada\nMain attunement : None\nSecondary attunement: None\n");
                    Calamity.GetItem("BladecrestOathsword").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina da Crista do Juramento");
                    Calamity.GetItem("BladecrestOathsword").Tooltip.AddTranslation(GameCulture.Portuguese, "Espada de um antigo lorde demônio\nDispara uma foice de sangue");
                    Calamity.GetItem("BloodyEdge").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina Sangrenta");
                    Calamity.GetItem("BloodyEdge").Tooltip.AddTranslation(GameCulture.Portuguese, "Chance de curar o jogador ao atingir o inimigo");
                    Calamity.GetItem("BurntSienna").DisplayName.AddTranslation(GameCulture.Portuguese, "Sienna Queimada");
                    Calamity.GetItem("BurntSienna").Tooltip.AddTranslation(GameCulture.Portuguese, "Faz com que os inimigos explodam em projéteis de cura na morte");
                    Calamity.GetItem("Carnage").DisplayName.AddTranslation(GameCulture.Portuguese, "Carnificina");
                    Calamity.GetItem("Carnage").Tooltip.AddTranslation(GameCulture.Portuguese, "Inimigos explodem em sangue teleguiado na morte");
                    Calamity.GetItem("CausticEdge").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina Cáustica");
                    Calamity.GetItem("CausticEdge").Tooltip.AddTranslation(GameCulture.Portuguese, "Inflige veneno e peçonha ao atingir o inimigo");
                    Calamity.GetItem("CorruptedCrusherBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina Trituradora Corrompida");
                    Calamity.GetItem("CorruptedCrusherBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Inflige inferno amaldiçoado e acertos críticos reduzem a defesa do inimigo");
                    Calamity.GetItem("CrimsonCrusherBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina Trituradora de Carmim");
                    Calamity.GetItem("CrimsonCrusherBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Inflige ichor e acertos críticos reduzem o dano de contato dos inimigos");
                    Calamity.GetItem("DepthBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Triturador das Profundezas");
                    Calamity.GetItem("DepthBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Acertar inimigos infligirá o efeito negativo Pressão das profundezas\nQuanto mais baixa for a defesa dos inimigos, mais dano eles recebem desse efeito negativo");
                    Calamity.GetItem("FellerofEvergreens").DisplayName.AddTranslation(GameCulture.Portuguese, "Derruba-árvores");
                    Calamity.GetItem("GaussDagger").DisplayName.AddTranslation(GameCulture.Portuguese, "Adaga de Gauss");
                    Calamity.GetItem("GaussDagger").Tooltip.AddTranslation(GameCulture.Portuguese, "Cortar inimigos causa uma formação de um fluxo de energia na área, atacando-os com forças turbulentas.\nAtaques repetidos envolvem os inimigos em um fluxo magnético");
                    Calamity.GetItem("GeliticBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Espada Gelítica");
                    Calamity.GetItem("GeliticBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma onda de gel que desacelera ao atingir o inimigo");
                    Calamity.GetItem("MandibleClaws").DisplayName.AddTranslation(GameCulture.Portuguese, "Garras de Mandíbula");
                    Calamity.GetItem("MycelialClaws").DisplayName.AddTranslation(GameCulture.Portuguese, "Garras Miceliais");
                    Calamity.GetItem("OldLordOathsword").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina do Juramento do Velho Senhor");
                    Calamity.GetItem("OldLordOathsword").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma relíquia do antigo submundo\nAtaques críticos causam explosões de lava");
                    Calamity.GetItem("PerfectDark").DisplayName.AddTranslation(GameCulture.Portuguese, "Escuridão Perfeita");
                    Calamity.GetItem("PerfectDark").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma bola vil que gruda nas peças e explode");
                    Calamity.GetItem("RedtideSword").DisplayName.AddTranslation(GameCulture.Portuguese, "Espada da Maré Vermelha");
                    Calamity.GetItem("RedtideSword").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança redemoinhos de curto alcance");
                    Calamity.GetItem("SeashineSword").DisplayName.AddTranslation(GameCulture.Portuguese, "Espada do Brilho dos Mares");
                    Calamity.GetItem("SeashineSword").Tooltip.AddTranslation(GameCulture.Portuguese, "Atira um feixe de espada d\u0027água");
                    Calamity.GetItem("TeardropCleaver").DisplayName.AddTranslation(GameCulture.Portuguese, "Cortador de Lágrimas");
                    Calamity.GetItem("TeardropCleaver").Tooltip.AddTranslation(GameCulture.Portuguese, "Faz seus inimigos chorarem");
                    Calamity.GetItem("VeinBurster").DisplayName.AddTranslation(GameCulture.Portuguese, "Estourador de Veias");
                    Calamity.GetItem("VeinBurster").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma bola de sangue que gruda nas peças e explode");
                    Calamity.GetItem("Waraxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Machado de Guerra");
                    Calamity.GetItem("Waraxe").Tooltip.AddTranslation(GameCulture.Portuguese, "Ataques críticos cortam a armadura inimiga, reduzindo a defesa em 15 e a proteção em 25%");
                    Calamity.GetItem("Warblade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina de Guerra");
                    Calamity.GetItem("Warblade").Tooltip.AddTranslation(GameCulture.Portuguese, "Ataques críticos cortam a armadura inimiga, reduzindo a defesa em 15 e a proteção em 25%");
                    Calamity.GetItem("WindBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina do Vento");
                    Calamity.GetItem("WindBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara ciclones que sugam os inimigos");
                    Calamity.GetItem("WulfrumBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina de Vulfrânio");

                    //Hardmode

                    Calamity.GetItem("AbsoluteZero").DisplayName.AddTranslation(GameCulture.Portuguese, "Zero Absoluto");
                    Calamity.GetItem("AbsoluteZero").Tooltip.AddTranslation(GameCulture.Portuguese, "Lâmina de gelo antiga imbuída com a magia do Arquimago de Gelo\nDispara cristais de gelo escuros\nA lâmina cria explosões de gelo em acertos diretos");

                    Calamity.GetItem("AbyssBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina do Abismo");
                    Calamity.GetItem("AbyssBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara tridentes de curto alcance\nAcertar inimigos infligirá o efeito negativo Pressão das profundezas\nQuanto mais baixa a defesa dos inimigos, mais dano eles recebem desse efeito negativo");

                    Calamity.GetItem("AegisBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina Égide");
                    Calamity.GetItem("AegisBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Espólio Lendário\nAtacar um inimigo com a lâmina causa uma erupção terrestre\nClique com o botão direito para disparar um raio égide");

                    Calamity.GetItem("Aftershock").DisplayName.AddTranslation(GameCulture.Portuguese, "Pós-choque");
                    Calamity.GetItem("Aftershock").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca rochedos do céu ao atingir o inimigo");

                    Calamity.GetItem("AnarchyBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina da Anarquia");
                    Calamity.GetItem("AnarchyBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Quanto menor for a sua vida, mais danos esta lâmina causa\nSeus acertos irão gerar uma grande explosão\nSe você estiver com menos de 50% de vida, seus acertos têm a chance de matar inimigos normais instantaneamente");

                    Calamity.GetItem("ArkoftheAncients").DisplayName.AddTranslation(GameCulture.Portuguese, "Arca Fraturada");
                    Calamity.GetItem("ArkoftheAncients").Tooltip.AddTranslation(GameCulture.Portuguese, "Esta linha é definida em ModifyTooltips\nUma lâmina desgastada e enferrujada uma vez empunhada contra o mal deste mundo, pronta para ser usada mais uma vez");

                    Calamity.GetItem("AstralBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina Astral");
                    Calamity.GetItem("AstralBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Causa mais dano quanto mais vida resta do inimigo");

                    Calamity.GetItem("AstralScythe").DisplayName.AddTranslation(GameCulture.Portuguese, "Foice Astral");
                    Calamity.GetItem("AstralScythe").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um anel de foice que acelera com o tempo");

                    Calamity.GetItem("Avalanche").DisplayName.AddTranslation(GameCulture.Portuguese, "Avalanche");
                    Calamity.GetItem("Avalanche").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca bombas de gelo que explodem após 2 segundos em fragmentos de gelo no acerto");

                    Calamity.GetItem("PurityAxe").DisplayName.AddTranslation(GameCulture.Portuguese, "Machado da Pureza");
                    Calamity.GetItem("PurityAxe").Tooltip.AddTranslation(GameCulture.Portuguese, "Clique com o botão esquerdo para usar como ferramenta\nClique com o botão direito para purificar o mal");

                    Calamity.GetItem("BalefulHarvester").DisplayName.AddTranslation(GameCulture.Portuguese, "Ceifeiro Sinistro");
                    Calamity.GetItem("BalefulHarvester").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara crânios que se dividem em orbes de fogo teleguiados na morte");

                    Calamity.GetItem("BladeofEnmity").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina da Antipatia");

                    Calamity.GetItem("Brimlash").DisplayName.AddTranslation(GameCulture.Portuguese, "Corte de Enxofre");
                    Calamity.GetItem("Brimlash").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um raio de enxofre que explode em mais raios na morte");

                    Calamity.GetItem("BrimlashBuster").DisplayName.AddTranslation(GameCulture.Portuguese, "Ruptura de Enxofre");
                    Calamity.GetItem("BrimlashBuster").Tooltip.AddTranslation(GameCulture.Portuguese, "50% de chance de causar o triplo de dano ao atingir o inimigo\nDispara um raio de enxofre que explode em mais raios na morte");

                    Calamity.GetItem("ProfanedSword").DisplayName.AddTranslation(GameCulture.Portuguese, "Espada de Enxofre");
                    Calamity.GetItem("ProfanedSword").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca gêiseres de enxofre no acerto\nClique com o botão direito para lançar como um dardo que explode no acerto");

                    Calamity.GetItem("BrinyBaron").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina Salgada");
                    Calamity.GetItem("BrinyBaron").Tooltip.AddTranslation(GameCulture.Portuguese, "Espólio Lendário\nAtacar um inimigo com a lâmina faz com que um tufão salgado apareça\nClique com o botão direito para disparar uma lâmina de água de vento cortante");

                    Calamity.GetItem("CatastropheClaymore").DisplayName.AddTranslation(GameCulture.Portuguese, "Claymore Catastrófica");
                    Calamity.GetItem("CatastropheClaymore").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara raios de energia explosivos");

                    Calamity.GetItem("CelestialClaymore").DisplayName.AddTranslation(GameCulture.Portuguese, "Claymore Celestial");
                    Calamity.GetItem("CelestialClaymore").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca chamas de energia cósmica perto do jogador que geram grandes explosões");

                    Calamity.GetItem("CometQuasher").DisplayName.AddTranslation(GameCulture.Portuguese, "Esmagador de Cometas");
                    Calamity.GetItem("CometQuasher").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca uma chuva de meteoros do céu ao atingir o inimigo");

                    Calamity.GetItem("CrystalBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina de Cristal");
                    Calamity.GetItem("CrystalBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara nuvens lentas de pó de cristal");

                    Calamity.GetItem("DarklightGreatsword").DisplayName.AddTranslation(GameCulture.Portuguese, "Espada Larga da Luz Escura");
                    Calamity.GetItem("DarklightGreatsword").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara lâminas de luz negra que se dividem na morte");

                    Calamity.GetItem("XerocsGreatsword").DisplayName.AddTranslation(GameCulture.Portuguese, "Claymore Entrópica");
                    Calamity.GetItem("XerocsGreatsword").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma série de bolas de plasma teleguiadas");

                    Calamity.GetItem("EutrophicScimitar").DisplayName.AddTranslation(GameCulture.Portuguese, "Cimitarra Eutrófica");
                    Calamity.GetItem("EutrophicScimitar").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um feixe quando balançada que atordoa os inimigos");

                    Calamity.GetItem("EvilSmasher").DisplayName.AddTranslation(GameCulture.Portuguese, "Esmagador Malígno");
                    Calamity.GetItem("EvilSmasher").Tooltip.AddTranslation(GameCulture.Portuguese, "MAl! eSMagAR o mAL! EsmAga...DOR!\nPara cada inimigo que você matar, este martelo ganha um bônus em suas estatísticas\nEstes bônus acumulam até que um limite é atingido\nO acúmulo de bônus será redefinido se você selecionar um item diferente\nO acúmulo de bônus será reduzido em 1 toda vez que você for atingido");

                    Calamity.GetItem("FeralthornClaymore").DisplayName.AddTranslation(GameCulture.Portuguese, "Claymore de Espinhos Selvagens");
                    Calamity.GetItem("FeralthornClaymore").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca espinhos ao atingir o inimigo");

                    Calamity.GetItem("FlarefrostBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina Quente-fria");
                    Calamity.GetItem("FlarefrostBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um orbe quente-frio teleguiado");

                    Calamity.GetItem("Floodtide").DisplayName.AddTranslation(GameCulture.Portuguese, "Maré Inundante");
                    Calamity.GetItem("Floodtide").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara tubarões, porque tubarões são fantásticos!");

                    Calamity.GetItem("ForbiddenOathblade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina do Juramento Proibído");
                    Calamity.GetItem("ForbiddenOathblade").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma foice demoníaca e acertos críticos causam explosões de chamas das sombras");

                    Calamity.GetItem("ForsakenSaber").DisplayName.AddTranslation(GameCulture.Portuguese, "Sabre Abandonado");
                    Calamity.GetItem("ForsakenSaber").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma lâmina de areia que altera a sua velocidade à medida que viaja");

                    Calamity.GetItem("FulgurationHalberd").DisplayName.AddTranslation(GameCulture.Portuguese, "Alabarda da Fulguração");
                    Calamity.GetItem("FulgurationHalberd").Tooltip.AddTranslation(GameCulture.Portuguese, "Inflige sangue ardente ao atingir o inimigo\nClique com o botão direito para usar como lança");

                    Calamity.GetItem("GlacialCrusher").DisplayName.AddTranslation(GameCulture.Portuguese, "Triturador Glacial");
                    Calamity.GetItem("GlacialCrusher").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara projéteis de gelo muito lentos que ganham força à medida que viajam e congelam os inimigos\nOs inimigos ficam congelados por mais tempo quanto mais longe o projétil viaja\nAtaques físicos verdadeiros causam danos tremendos aos inimigos congelados\nInimigos que não podem ser congelados recebem dano aumentado");

                    Calamity.GetItem("GrandGuardian").DisplayName.AddTranslation(GameCulture.Portuguese, "Grande Guardião");
                    Calamity.GetItem("GrandGuardian").Tooltip.AddTranslation(GameCulture.Portuguese, "Tem uma chance de diminuir a defesa do inimigo em 15 ao atingi-lo\nSe a defesa do inimigo for 0 ou inferior, seus ataques irão te curar\nAtacar os inimigos causa uma grande explosão\nAtacar inimigos que têm menos que metade da vida fará com que você solte raios de arco-íris\nInimigos geram orbes de cura na morte");

                    Calamity.GetItem("Greentide").DisplayName.AddTranslation(GameCulture.Portuguese, "Maré-verde");
                    Calamity.GetItem("Greentide").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca dentes do céu no acerto");

                    Calamity.GetItem("HellfireFlamberge").DisplayName.AddTranslation(GameCulture.Portuguese, "Flamberge do Fogo Infernal");
                    Calamity.GetItem("HellfireFlamberge").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma série de bolas de fogo vulcânicas");

                    Calamity.GetItem("Hellkite").DisplayName.AddTranslation(GameCulture.Portuguese, "Espada do Fogo Cruel");
                    Calamity.GetItem("Hellkite").Tooltip.AddTranslation(GameCulture.Portuguese, "Contém o poder de um dragão antigo\nInvoca explosões de gêiser de chamas ao atingir o inimigo");

                    Calamity.GetItem("InfernaCutter").DisplayName.AddTranslation(GameCulture.Portuguese, "Cortador Infernal");
                    Calamity.GetItem("InfernaCutter").Tooltip.AddTranslation(GameCulture.Portuguese, "Ataques críticos com a lâmina causam pequenas explosões\nGera uma série de pequenas faíscas quando balançado");

                    Calamity.GetItem("MajesticGuard").DisplayName.AddTranslation(GameCulture.Portuguese, "Guarda Majestosa");
                    Calamity.GetItem("MajesticGuard").Tooltip.AddTranslation(GameCulture.Portuguese, "Tem uma chance de diminuir a defesa do inimigo em 10 ao atingi-lo\nSe a defesa do inimigo for 0 ou inferior, seus ataques irão te curar");

                    Calamity.GetItem("MantisClaws").DisplayName.AddTranslation(GameCulture.Portuguese, "Garras de Louva-a-deus");
                    Calamity.GetItem("MantisClaws").Tooltip.AddTranslation(GameCulture.Portuguese, "Explode ao atingir o inimigo");

                    Calamity.GetItem("Mariana").DisplayName.AddTranslation(GameCulture.Portuguese, "Mariana");
                    Calamity.GetItem("Mariana").Tooltip.AddTranslation(GameCulture.Portuguese, "Tropical e mortal\nInimigos explodem em orbes de água na morte");

                    Calamity.GetItem("Omniblade").DisplayName.AddTranslation(GameCulture.Portuguese, "Omnilâmina");
                    Calamity.GetItem("Omniblade").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma lâmina antiga forjada pelo lendário Omnir");

                    Calamity.GetItem("PhoenixBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina da Fênix");
                    Calamity.GetItem("PhoenixBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Inimigos explodem e emitem chamas curativas na morte");

                    Calamity.GetItem("Roxcalibur").DisplayName.AddTranslation(GameCulture.Portuguese, "Roxcalibur");
                    Calamity.GetItem("Roxcalibur").Tooltip.AddTranslation(GameCulture.Portuguese, "Você não conseguia tirá-la da rocha, então você levou a rocha junto\nUma entidade de carne infernal detém a chave para o poder desta arma\nClique com o botão esquerdo para atirar vários fragmentos de rocha\nClique com o botão direito para mergulhar para baixo e quicar nos inimigos\nMergulhar em blocos cria uma onda de choque");

                    Calamity.GetItem("SoulHarvester").DisplayName.AddTranslation(GameCulture.Portuguese, "Ceifador de Almas");
                    Calamity.GetItem("SoulHarvester").Tooltip.AddTranslation(GameCulture.Portuguese, "Atira uma foice de alma\nInimigos explodem quando com a vida baixa, espalhando a praga");

                    Calamity.GetItem("StormRuler").DisplayName.AddTranslation(GameCulture.Portuguese, "Imperador das Tempestades");
                    Calamity.GetItem("StormRuler").Tooltip.AddTranslation(GameCulture.Portuguese, "Apenas uma tempestade pode derrubar um grande bosque\nDispara feixes que geram tornados na morte\nOs tornados sugam os inimigos");

                    Calamity.GetItem("StormSaber").DisplayName.AddTranslation(GameCulture.Portuguese, "Sabre das Tempestades");
                    Calamity.GetItem("StormSaber").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara dois feixes de tempestade\nUm da lâmina e um do céu");

                    Calamity.GetItem("TemporalFloeSword").DisplayName.AddTranslation(GameCulture.Portuguese, "Espada do Iceberg Temporal");
                    Calamity.GetItem("TemporalFloeSword").Tooltip.AddTranslation(GameCulture.Portuguese, "O homem do gelo se aproxima...\nDispara um feixe de espada congelado que se divide em mais dois feixes\nA direção dos feixes depende do tempo de jogo");

                    Calamity.GetItem("Terracotta").DisplayName.AddTranslation(GameCulture.Portuguese, "Terra-cota");
                    Calamity.GetItem("Terracotta").Tooltip.AddTranslation(GameCulture.Portuguese, "Faz com que os inimigos explodam em projéteis de cura na morte\nInimigos explodem na morte");

                    Calamity.GetItem("TerraEdge").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina Terrestre");
                    Calamity.GetItem("TerraEdge").Tooltip.AddTranslation(GameCulture.Portuguese, "Cura o jogador ao atingir o inimigo\nDispara um feixe que inflige ichor por um curto período de tempo");
                   

                    Calamity.GetItem("Terratomere").DisplayName.AddTranslation(GameCulture.Portuguese, "Terratomere");
                    Calamity.GetItem("Terratomere").Tooltip.AddTranslation(GameCulture.Portuguese, "Ligado à essência do Terraria\nCura o jogador em ataques físicos verdadeiros\nDispara uma barragem de raios teleguiados que congelam os inimigos");

                    Calamity.GetItem("TitanArm").DisplayName.AddTranslation(GameCulture.Portuguese, "Braço de Titã");
                    Calamity.GetItem("TitanArm").Tooltip.AddTranslation(GameCulture.Portuguese, "Ponteiro do Dar um Tapa, só que melhor");

                    Calamity.GetItem("Trinity").DisplayName.AddTranslation(GameCulture.Portuguese, "Trinidade");
                    Calamity.GetItem("Trinity").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma série de raios de energia");

                    Calamity.GetItem("TrueArkoftheAncients").DisplayName.AddTranslation(GameCulture.Portuguese, "Arca dos Anciões");
                    Calamity.GetItem("TrueArkoftheAncients").Tooltip.AddTranslation(GameCulture.Portuguese, "Esta linha é definida em ModifyTooltips\nUma lâmina celestial forjada para acabar com todo o mal");

                    Calamity.GetItem("TrueBiomeBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina do Bioma");
                    Calamity.GetItem("TrueBiomeBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "FUNCTION_DESC\nFUNCTION_EXTRA\nSegure o BDM enquanto está parado em terreno plano para sintonizar a arma com os poderes do bioma em sua volta\nCaso contrário, usar o BDM alterna entre a sintonização atual e uma extra armazenada\nMain attunement : None\nSecondary attunement: None\n");

                    Calamity.GetItem("TrueBloodyEdge").DisplayName.AddTranslation(GameCulture.Portuguese, "Verdadeira Lâmina Sangrenta");
                    Calamity.GetItem("TrueBloodyEdge").Tooltip.AddTranslation(GameCulture.Portuguese, "Chance de curar o jogador ao atingir o inimigo\nDispara uma lâmina sangrenta");

                    Calamity.GetItem("TrueCausticEdge").DisplayName.AddTranslation(GameCulture.Portuguese, "Verdadeira Lâmina Cáustica");
                    Calamity.GetItem("TrueCausticEdge").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um feixe cáustico saltitante");

                    Calamity.GetItem("TrueForbiddenOathblade").DisplayName.AddTranslation(GameCulture.Portuguese, "Verdadeira Espada do Juramento Proibído");
                    Calamity.GetItem("TrueForbiddenOathblade").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma série de foices demoníacas e acertos críticos causam explosões de chamas das sombras");

                    Calamity.GetItem("TyrantYharimsUltisword").DisplayName.AddTranslation(GameCulture.Portuguese, "Ultiespada do Tirano Yharim");
                    Calamity.GetItem("TyrantYharimsUltisword").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara lâminas flamejantes teleguiadas\nDá ao jogador o efeito da fúria do tirano ao atingir o inimigo\nEsse efeito aumenta o dano por ataques físicos em 30% e a chance de ataque físico crítico em 10%");

                    Calamity.GetItem("UltimusCleaver").DisplayName.AddTranslation(GameCulture.Portuguese, "Cortador Ultimus");
                    Calamity.GetItem("UltimusCleaver").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança faíscas teleguiadas que machucam e explode ao atingir o inimigo");

                    Calamity.GetItem("VirulentKatana").DisplayName.AddTranslation(GameCulture.Portuguese, "Virulência");
                    Calamity.GetItem("VirulentKatana").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma nuvem da praga");

                    //Post-Moon Lord

                    Calamity.GetItem("Animus").DisplayName.AddTranslation(GameCulture.Portuguese, "Animus");
                    Calamity.GetItem("Animus").Tooltip.AddTranslation(GameCulture.Portuguese, "O seu dano será aleatório ao atingir o inimigo");

                    Calamity.GetItem("AquaticDissolution").DisplayName.AddTranslation(GameCulture.Portuguese, "Dissolução Aquática");
                    Calamity.GetItem("AquaticDissolution").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara lanças baleeiras do céu que saltam nas peças");

                    Calamity.GetItem("ArkoftheCosmos").DisplayName.AddTranslation(GameCulture.Portuguese, "Arca do Cosmos");
                    Calamity.GetItem("ArkoftheCosmos").Tooltip.AddTranslation(GameCulture.Portuguese, "Esta linha é definida em ModifyTooltips\nEsta linha também é definida em ModifyTooltips\nEsta linha também é definida em ModifyTooltips\nA culminação física de sua jornada, capaz de rasgar deuses em pedaços");

                    Calamity.GetItem("ArkoftheElements").DisplayName.AddTranslation(GameCulture.Portuguese, "Arca dos Elementos");
                    Calamity.GetItem("ArkoftheElements").Tooltip.AddTranslation(GameCulture.Portuguese, "Esta linha é definida em ModifyTooltips\nEsta linha também é definida em ModifyTooltips\nEsta linha também é definida em ModifyTooltips\nUm par de lâminas celestial infundido com a essência de Terraria, poderoso o suficiente para cortar o tecido da realidade");

                    Calamity.GetItem("Ataraxia").DisplayName.AddTranslation(GameCulture.Portuguese, "Ataraxia");
                    Calamity.GetItem("Ataraxia").Tooltip.AddTranslation(GameCulture.Portuguese, "Equanimidade");

                    Calamity.GetItem("TheBurningSky").DisplayName.AddTranslation(GameCulture.Portuguese, "O Céu Flamejante");
                    Calamity.GetItem("TheBurningSky").Tooltip.AddTranslation(GameCulture.Portuguese, "Segure a lâmina aos céus, e testemunhe o Armagedom");

                    Calamity.GetItem("Devastation").DisplayName.AddTranslation(GameCulture.Portuguese, "Devastação");
                    Calamity.GetItem("Devastation").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara explosões galácticas");

                    Calamity.GetItem("DevilsDevastation").DisplayName.AddTranslation(GameCulture.Portuguese, "Devastação do Diabo");
                    Calamity.GetItem("DevilsDevastation").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma série de foices demoníacas\nTridentes emergem do submundo para espetar seus inimigos\nAcertos críticos causam explosões de chamas das sombras");

                    Calamity.GetItem("DraconicDestruction").DisplayName.AddTranslation(GameCulture.Portuguese, "Destruição Dracônica");
                    Calamity.GetItem("DraconicDestruction").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um feixe de espada dracônico que explode em feixes adicionais\nFeixes adicionais voam para cima e para baixo para destruir os inimigos");

                    Calamity.GetItem("DragonRage").DisplayName.AddTranslation(GameCulture.Portuguese, "Raiva do Dragão");
                    Calamity.GetItem("DragonRage").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma série de cinco ondas de fogo");

                    Calamity.GetItem("Earth").DisplayName.AddTranslation(GameCulture.Portuguese, "Terra");
                    Calamity.GetItem("Earth").Tooltip.AddTranslation(GameCulture.Portuguese, "Tem uma chance de diminuir a defesa do inimigo em 50 ao atingi-lo\nSeus ataques vão te curar bastante\nChove meteoros RGB que explodem em mais meteoros após um curto período de tempo ao atingir o inimigo\nMeteoros de gelo congelam os inimigos\nMeteoros de chamas explodem\nMeteoros verdes germa orbes de cura");

                    Calamity.GetItem("ElementalExcalibur").DisplayName.AddTranslation(GameCulture.Portuguese, "Excalibur Elemental");
                    Calamity.GetItem("ElementalExcalibur").Tooltip.AddTranslation(GameCulture.Portuguese, "Congela os inimigos e cura o jogador no acerto\nDispara feixes de arco-íris que mudam seu comportamento com base em sua cor\nClique com o botão direito para ataque físico verdadeiro");

                    Calamity.GetItem("TheEnforcer").DisplayName.AddTranslation(GameCulture.Portuguese, "O Enforçador");
                    Calamity.GetItem("TheEnforcer").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma explosão de chamas da essência e gera chamas da essência ao atingir o inimigo");

                    Calamity.GetItem("EssenceFlayer").DisplayName.AddTranslation(GameCulture.Portuguese, "Esfolador de Essências");
                    Calamity.GetItem("EssenceFlayer").Tooltip.AddTranslation(GameCulture.Portuguese, "Atira uma foice de essência que gera espíritos de cura ao matar o inimigo");

                    Calamity.GetItem("Excelsus").DisplayName.AddTranslation(GameCulture.Portuguese, "Excelsus");
                    Calamity.GetItem("Excelsus").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma série de lâminas giratórias\nInvoca fontes de laser no acerto");

                    Calamity.GetItem("DraedonsExoblade").DisplayName.AddTranslation(GameCulture.Portuguese, "Exolâmina");
                    Calamity.GetItem("DraedonsExoblade").Tooltip.AddTranslation(GameCulture.Portuguese, "Lâmina antiga do especialista em armas e armaduras de Yharim, Draedon\nDispara um feixe exo que é teleguiado no jogador e explode\nAtacar um inimigo com a lâmina faz com que vários cometas disparem\nTodos os ataques congelam brevemente qualquer inimigo atingido\nInimigos atingidos com a vida muito baixa explodem em energia congelada e congelam os inimigos próximos\nQuanto menor a sua vida, mais dano essa lâmina causa e cura o jogador ao atingir o inimigo");

                    Calamity.GetItem("GaelsGreatsword").DisplayName.AddTranslation(GameCulture.Portuguese, "Espada Larga de Gael");
                    Calamity.GetItem("GaelsGreatsword").Tooltip.AddTranslation(GameCulture.Portuguese, "Passe para cá, essa coisa.\nSua alma sombria.\nO primeiro balanço dispara crânios teleguiados\nO segundo balanço atira um crânio gigante e poderoso\nO terceiro balanço não tem projéteis\nGera fúria constantemente quando em uso\nVocê deixa trilhas de sangue explosivas ao balançar quando abaixo de 50% de vida\nSubstitui o Modo Fúria com uma barragem enorme de crânios");

                    Calamity.GetItem("GalacticaBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina de Galactus");
                    Calamity.GetItem("GalacticaBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Forjada com a fúria do caos nuclear\nLança uma barragem de cometas do céu");

                    Calamity.GetItem("FourSeasonsGalaxia").DisplayName.AddTranslation(GameCulture.Portuguese, "Galaxia");
                    Calamity.GetItem("FourSeasonsGalaxia").Tooltip.AddTranslation(GameCulture.Portuguese, "FUNCTION_DESC\nFUNCTION_EXTRA\nFUNCTION_PASSIVE\nMelhorar a espada permitiu que ela se liberte de seus limites terrenos. Agora você tem acesso a todas as sintonizações o tempo todo!\nUse o BDM para alternar a sintonização da espada para frente ou para trás, dependendo da posição do cursor\nActive Attunement : None\nPassive Blessing : None\n");

                    Calamity.GetItem("Grax").DisplayName.AddTranslation(GameCulture.Portuguese, "Grax");
                    Calamity.GetItem("Grax").Tooltip.AddTranslation(GameCulture.Portuguese, "Atingir um inimigo aumentará bastante as suas estatísticas de defesa e ataque físico por um curto período de tempo");

                    Calamity.GetItem("GreatswordofBlah").DisplayName.AddTranslation(GameCulture.Portuguese, "Grande Espada Larga de Blah");
                    Calamity.GetItem("GreatswordofBlah").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma espada branca pálida de uma terra esquecida\nVocê pode ouvir sussurros fracos, mas reconfortantes, emanando da lâmina\n\u0027Não importa onde você esteja, você nunca está sozinho\nEu estarei sempre ao seu lado, meu senhor\u0027\nDispara uma lâmina de arco-íris que emite chuvas de arco-íris na morte por um tempo");

                    Calamity.GetItem("GreatswordofJudgement").DisplayName.AddTranslation(GameCulture.Portuguese, "Grande Espada do Julgamento");
                    Calamity.GetItem("GreatswordofJudgement").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma espada branca pálida de uma terra esquecida\nVocê pode ouvir sussurros fracos, mas reconfortantes, emanando da lâmina\n\u0027Não importa onde você esteja, você nunca está sozinho\nEu estarei sempre ao seu lado, meu senhor\u0027\nDispara um orbe branco que emite chuva branca na morte por um tempo");

                    Calamity.GetItem("HolyCollider").DisplayName.AddTranslation(GameCulture.Portuguese, "Colisor Sagrado");
                    Calamity.GetItem("HolyCollider").Tooltip.AddTranslation(GameCulture.Portuguese, "Atacar os inimigos fará com que eles explodam em fogo sagrado");

                    Calamity.GetItem("TheLastMourning").DisplayName.AddTranslation(GameCulture.Portuguese, "A Última Manhã");
                    Calamity.GetItem("TheLastMourning").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca abóboras flamejantes e crânios da manhã que se dividem em orbes de fogo ao atingir o inimigo");

                    Calamity.GetItem("LifefruitScythe").DisplayName.AddTranslation(GameCulture.Portuguese, "Foice de Caça-à-vida");
                    Calamity.GetItem("LifefruitScythe").Tooltip.AddTranslation(GameCulture.Portuguese, "Cura o jogador ao atingir o inimigo");

                    Calamity.GetItem("LionHeart").DisplayName.AddTranslation(GameCulture.Portuguese, "Coração de Leão");
                    Calamity.GetItem("LionHeart").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca uma explosão de energia ao atingir o inimigo\nClique com o botão direito para invocar um escudo de energia por alguns segundos que corta todas as fontes de dano pela metade\nIsso tem um tempo de recarga de 45 segundos");

                    Calamity.GetItem("MirrorBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina Espelhada");
                    Calamity.GetItem("MirrorBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "A quantidade de dano de contato que um inimigo causa é adicionada ao dano dessa arma\nVocê deve atingir um inimigo com a lâmina para ativar esse efeito");

                    Calamity.GetItem("TheMutilator").DisplayName.AddTranslation(GameCulture.Portuguese, "O Mutilador");
                    Calamity.GetItem("TheMutilator").Tooltip.AddTranslation(GameCulture.Portuguese, "Atacar um inimigo com menos de 20% de vida ativará uma explosão de sangue\nExplosões de sangue fazem cair corações que podem ser pegos para te curar");

                    Calamity.GetItem("NeptunesBounty").DisplayName.AddTranslation(GameCulture.Portuguese, "Remuneração de Netuno");
                    Calamity.GetItem("NeptunesBounty").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um tridente que faz chover tridentes adicionais enquanto viaja\nAcertar inimigos infligirá o efeito negativo Pressão das profundezas\nQuanto mais baixa a defesa dos inimigos, mais dano eles recebem desse efeito negativo");

                    Calamity.GetItem("OmegaBiomeBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Verdadeira Lâmina do Bioma");
                    Calamity.GetItem("OmegaBiomeBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "FUNCTION_DESC\nFUNCTION_EXTRA\nFUNCTION_PASSIVE\nSegurar o BDM por 2 segundos sintoniza a arma com os poderes do bioma em sua volta\nUsar o BDM por um período de tempo mais curto alterna as suas sintonizações ativas e passivas\nActive attunement : None\nPassive attunement: None\n");

                    Calamity.GetItem("PlagueKeeper").DisplayName.AddTranslation(GameCulture.Portuguese, "Guardião da Peste");
                    Calamity.GetItem("PlagueKeeper").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma nuvem de praga e abelhas");

                    Calamity.GetItem("PrismaticBreaker").DisplayName.AddTranslation(GameCulture.Portuguese, "Destruidor Prismático");
                    Calamity.GetItem("PrismaticBreaker").Tooltip.AddTranslation(GameCulture.Portuguese, "Parece pertencer a uma certa garota mágica. Irradia uma intensa energia cósmica.\nDispare para carregar um poderoso laser arco-íris\nClique com o botão direito para balançar a espada e disparar ondas arco-íris\nA espada recebe reforços por dano por ataque físico e dano por ataque a distância");

                    Calamity.GetItem("RedSun").DisplayName.AddTranslation(GameCulture.Portuguese, "Sol Vermelho");
                    Calamity.GetItem("RedSun").Tooltip.AddTranslation(GameCulture.Portuguese, "Sobre o paraíso\nLança uma barragem de erupções solares do céu");

                    Calamity.GetItem("SolsticeClaymore").DisplayName.AddTranslation(GameCulture.Portuguese, "Claymore do Solstício");
                    Calamity.GetItem("SolsticeClaymore").Tooltip.AddTranslation(GameCulture.Portuguese, "Muda a cor do projétil com base na época do ano\nInflige Queimado pelo Sol durante o dia e Decomposição noturna durante a noite");

                    Calamity.GetItem("SoulEdge").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina das Almas");
                    Calamity.GetItem("SoulEdge").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara as almas medonhas dos habitantes do abismo há muito falecidos");

                    Calamity.GetItem("StellarStriker").DisplayName.AddTranslation(GameCulture.Portuguese, "Atacante Estelar");
                    Calamity.GetItem("StellarStriker").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca uma série de chamas lunares do céu ao atingir o inimigo");

                    Calamity.GetItem("Swordsplosion").DisplayName.AddTranslation(GameCulture.Portuguese, "Espadexplosão");
                    Calamity.GetItem("Swordsplosion").Tooltip.AddTranslation(GameCulture.Portuguese, "Barragem de espadas");

                    Calamity.GetItem("TerrorBlade").DisplayName.AddTranslation(GameCulture.Portuguese, "Lâmina do Terror");
                    Calamity.GetItem("TerrorBlade").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um feixe de terror que salta em peças\nEm cada salto, ele emite uma explosão");

                    Calamity.GetItem("TrueTyrantYharimsUltisword").DisplayName.AddTranslation(GameCulture.Portuguese, "Verdadeira Ultiespada do Tirano");
                    Calamity.GetItem("TrueTyrantYharimsUltisword").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara lâminas ardentes, hiper e de luz solar\nDá ao jogador o efeito da fúria do tirano ao atingir o inimigo\nEsse efeito aumenta o dano por ataques físicos em 30% e a chance de ataque físico crítico em 10%");

                    //Shortswords
                    //Pre-Hardmode

                    Calamity.GetItem("AncientShiv").DisplayName.AddTranslation(GameCulture.Portuguese, "Faca Antiga");
                    Calamity.GetItem("AncientShiv").Tooltip.AddTranslation(GameCulture.Portuguese, "Inimigos liberam uma nuvem de aura azul na morte");

                    Calamity.GetItem("AquaticDischarge").DisplayName.AddTranslation(GameCulture.Portuguese, "Descarga Aquática");
                    Calamity.GetItem("AquaticDischarge").Tooltip.AddTranslation(GameCulture.Portuguese, "Inimigos liberam faíscas elétricas na morte");

                    Calamity.GetItem("BloodyRupture").DisplayName.AddTranslation(GameCulture.Portuguese, "Ruptura Sangrenta");
                    Calamity.GetItem("BloodyRupture").Tooltip.AddTranslation(GameCulture.Portuguese, "Inimigos liberam orbes de sangue teleguiados na morte");

                    Calamity.GetItem("EutrophicShank").DisplayName.AddTranslation(GameCulture.Portuguese, "Haste Eutrófica");
                    Calamity.GetItem("EutrophicShank").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara faíscas elétricas");

                    Calamity.GetItem("FlameburstShortsword").DisplayName.AddTranslation(GameCulture.Portuguese, "Espada Curta da Erupção");
                    Calamity.GetItem("FlameburstShortsword").Tooltip.AddTranslation(GameCulture.Portuguese, "Inimigos explodem ao serem atingidos quando estiverem abaixo da metade da vida");

                    Calamity.GetItem("LeechingDagger").DisplayName.AddTranslation(GameCulture.Portuguese, "Adaga Sanguessuga");
                    Calamity.GetItem("LeechingDagger").Tooltip.AddTranslation(GameCulture.Portuguese, "Inimigos liberam orbes sanguessuga na morte");

                    Calamity.GetItem("NightsStabber").DisplayName.AddTranslation(GameCulture.Portuguese, "Facada Noturna");
                    Calamity.GetItem("NightsStabber").Tooltip.AddTranslation(GameCulture.Portuguese, "Não subestime o poder das faquinhas\nInimigos liberam energia negra teleguiada na morte");

                    Calamity.GetItem("SporeKnife").DisplayName.AddTranslation(GameCulture.Portuguese, "Faca de Esporos");
                    Calamity.GetItem("SporeKnife").Tooltip.AddTranslation(GameCulture.Portuguese, "Inimigos liberam nuvens de esporos na morte");

                    //Hardmode

                    Calamity.GetItem("ColdheartIcicle").DisplayName.AddTranslation(GameCulture.Portuguese, "Gelo do Coração Frio");
                    Calamity.GetItem("ColdheartIcicle").Tooltip.AddTranslation(GameCulture.Portuguese, "Drena uma porcentagem da vida do inimigo ao atingi-lo\nNão pode infligir acertos críticos");

                    Calamity.GetItem("ExcaliburShortsword").DisplayName.AddTranslation(GameCulture.Portuguese, "Excalibur Curta");
                    Calamity.GetItem("ExcaliburShortsword").Tooltip.AddTranslation(GameCulture.Portuguese, "Não subestime o poder das espadas curtas");

                    Calamity.GetItem("Lucrecia").DisplayName.AddTranslation(GameCulture.Portuguese, "Lucrecia");
                    Calamity.GetItem("Lucrecia").Tooltip.AddTranslation(GameCulture.Portuguese, "Delicadeza\nAtacar um inimigo te deixará imune por um curto período de tempo\nUsar essa arma drena a sua vida\nDispara uma cadeia de DNA");

                    Calamity.GetItem("SubmarineShocker").DisplayName.AddTranslation(GameCulture.Portuguese, "Eletrocutador Submersível");
                    Calamity.GetItem("SubmarineShocker").Tooltip.AddTranslation(GameCulture.Portuguese, "Inimigos liberam faíscas elétricas ao serem atingidos");

                    Calamity.GetItem("TerraShiv").DisplayName.AddTranslation(GameCulture.Portuguese, "Faca da Terra");
                    Calamity.GetItem("TerraShiv").Tooltip.AddTranslation(GameCulture.Portuguese, "Não subestime o poder das facas");

                    Calamity.GetItem("TrueExcaliburShortsword").DisplayName.AddTranslation(GameCulture.Portuguese, "Verdadeira Excalibur Curta");
                    Calamity.GetItem("TrueExcaliburShortsword").Tooltip.AddTranslation(GameCulture.Portuguese, "Não subestime o poder das espadas curtas");

                    Calamity.GetItem("TrueNightsStabber").DisplayName.AddTranslation(GameCulture.Portuguese, "Verdadeira Facada Noturna");
                    Calamity.GetItem("TrueNightsStabber").Tooltip.AddTranslation(GameCulture.Portuguese, "Não subestime o poder das faquinhas");

                    //Post-Moon Lord

                    Calamity.GetItem("CosmicShiv").DisplayName.AddTranslation(GameCulture.Portuguese, "Faca Cósmica");
                    Calamity.GetItem("CosmicShiv").Tooltip.AddTranslation(GameCulture.Portuguese, "Definitivamente, não subestime o poder das facas\nDispara um feixe cósmico que segue os inimigos\nAo atingir um inimigo, uma barragem de objetos fora da tela atingem o inimigo, e também chovem estrelas");

                    Calamity.GetItem("ElementalShortsword").DisplayName.AddTranslation(GameCulture.Portuguese, "Faca Elemental");
                    Calamity.GetItem("ElementalShortsword").Tooltip.AddTranslation(GameCulture.Portuguese, "Não subestime o poder das facas\nDispara um orbe de arco-íris que gera facas em vários locais");

                    Calamity.GetItem("ExoGladius").DisplayName.AddTranslation(GameCulture.Portuguese, "Exo Gladius");
                    Calamity.GetItem("ExoGladius").Tooltip.AddTranslation(GameCulture.Portuguese, "Não subestime o poder do irmão mais novo da Exolâmina\nAtacar o inimigo com a lâmina te deixa imune por um curto período de tempo e invoca cometas do céu\nDispara um orbe arco-íris que invoca feixes de espada ao atingir o inimigo");

                    Calamity.GetItem("GalileoGladius").DisplayName.AddTranslation(GameCulture.Portuguese, "Galileo Gladius");
                    Calamity.GetItem("GalileoGladius").Tooltip.AddTranslation(GameCulture.Portuguese, "Não subestime o poder das pequenas espadas espaciais\nDispara uma lua crescente teleguiada\nInvoca planetóides ao atingir o inimigo");

                    //Yoyos
                    //Pre-Hardmode

                    Calamity.GetItem("AirSpinner").DisplayName.AddTranslation(GameCulture.Portuguese, "Rotação Aérea");
                    Calamity.GetItem("AirSpinner").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara penas quando os inimigos estão próximos\nUm ioiô muito ágil");

                    Calamity.GetItem("Aorta").DisplayName.AddTranslation(GameCulture.Portuguese, "Aorta");
                    Calamity.GetItem("Aorta").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara sangue teleguiado quando os inimigos estão próximos\nUm ioiô excepcionalmente ágil");

                    Calamity.GetItem("Cnidarian").DisplayName.AddTranslation(GameCulture.Portuguese, "Cnidariano");
                    Calamity.GetItem("Cnidarian").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma concha do mar quando os inimigos estão próximos\nUm ioiô muito ágil");

                    Calamity.GetItem("TheGodsGambit").DisplayName.AddTranslation(GameCulture.Portuguese, "Tática dos Deuses");
                    Calamity.GetItem("TheGodsGambit").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um fluxo de geleia quando os inimigos estão próximos\nUm ioiô muito ágil");

                    Calamity.GetItem("Whirlpool").DisplayName.AddTranslation(GameCulture.Portuguese, "Correnteza");
                    Calamity.GetItem("Whirlpool").Tooltip.AddTranslation(GameCulture.Portuguese, "Espalha uma espiral de fluxos d'água em direções aleatórias\nUm ioiô muito ágil");

                    //Hardmode

                    Calamity.GetItem("Chaotrix").DisplayName.AddTranslation(GameCulture.Portuguese, "Linha de Colapso");
                    Calamity.GetItem("Chaotrix").Tooltip.AddTranslation(GameCulture.Portuguese, "Explode ao atingir o inimigo\nUm ioiô muito ágil");

                    Calamity.GetItem("TheMicrowave").DisplayName.AddTranslation(GameCulture.Portuguese, "O Microondas");
                    Calamity.GetItem("TheMicrowave").Tooltip.AddTranslation(GameCulture.Portuguese, "Frita os inimigos próximos com radiação\nUm ioiô muito ágil\nCozinhando ao estilo Infecção Astral");

                    Calamity.GetItem("TheEyeofCalamitas").DisplayName.AddTranslation(GameCulture.Portuguese, "Oblívio");
                    Calamity.GetItem("TheEyeofCalamitas").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara lasers de enxofre quando os inimigos estão próximos\nUm ioiô muito ágil");

                    Calamity.GetItem("ThePlaguebringer").DisplayName.AddTranslation(GameCulture.Portuguese, "Pandemia");
                    Calamity.GetItem("ThePlaguebringer").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara caçadores da praga quando os inimigos estão próximos\nUm ioiô muito ágil");

                    Calamity.GetItem("Quagmire").DisplayName.AddTranslation(GameCulture.Portuguese, "Pântano");
                    Calamity.GetItem("Quagmire").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara nuvens de esporo");

                    Calamity.GetItem("Shimmerspark").DisplayName.AddTranslation(GameCulture.Portuguese, "Faísca Cintilante");
                    Calamity.GetItem("Shimmerspark").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara estrelas quando os inimigos estão próximos\nUm ioiô muito ágil");

                    Calamity.GetItem("SulphurousGrabber").DisplayName.AddTranslation(GameCulture.Portuguese, "Agarrador Sulfuroso");
                    Calamity.GetItem("SulphurousGrabber").Tooltip.AddTranslation(GameCulture.Portuguese, "Ocasionalmente libera um anel de bolhas coloridas\nO ioiô fica mais forte depois de tocar em uma bolha verde\nUm ioiô muito ágil");

                    Calamity.GetItem("YinYo").DisplayName.AddTranslation(GameCulture.Portuguese, "Yin-Iô");
                    Calamity.GetItem("YinYo").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara fragmentos claros ou escuros quando os inimigos estão próximos\nOs fragmentos voam para frente e para trás\nUm ioiô muito ágil");

                    //Post-Moon Lord

                    Calamity.GetItem("Azathoth").DisplayName.AddTranslation(GameCulture.Portuguese, "Azathoth");
                    Calamity.GetItem("Azathoth").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara orbes cósmicos que atingem os inimigos próximos com lasers\nUm ioiô muito ágil\nDestrua o universo num piscar de olhos");

                    Calamity.GetItem("Lacerator").DisplayName.AddTranslation(GameCulture.Portuguese, "Dilacerador");
                    Calamity.GetItem("Lacerator").Tooltip.AddTranslation(GameCulture.Portuguese, "Inimigos que forem atingidos pelo ioiô terão suas vidas drenadas\nUm ioiô muito ágil\nAlguém achou que essa arma seria viável contra o DdD uma vez lol");

                    Calamity.GetItem("TheObliterator").DisplayName.AddTranslation(GameCulture.Portuguese, "O Obliterador");
                    Calamity.GetItem("TheObliterator").Tooltip.AddTranslation(GameCulture.Portuguese, "Destrói os inimigos próximos com lasers mortais\nUm ioiô excepcionalmente ágil");

                    Calamity.GetItem("Oracle").DisplayName.AddTranslation(GameCulture.Portuguese, "O Oráculo");
                    Calamity.GetItem("Oracle").Tooltip.AddTranslation(GameCulture.Portuguese, "Olhe para o passado, o presente, o futuro... e as circunstâncias de sua morte inevitável\nEmite uma aura de relâmpago vermelho que carrega ao atingir o inimigo\nDispara orbes áuricos quando supercarregado\nUm ioiô excepcionalmente ágil");

                    Calamity.GetItem("SolarFlare").DisplayName.AddTranslation(GameCulture.Portuguese, "Erupção Solar");
                    Calamity.GetItem("SolarFlare").Tooltip.AddTranslation(GameCulture.Portuguese, "Emite grandes explosões sagradas no acerto\nUm ioiô muito ágil");

                    Calamity.GetItem("Verdant").DisplayName.AddTranslation(GameCulture.Portuguese, "Verdejante");
                    Calamity.GetItem("Verdant").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara folhas de cristal quando os inimigos estão próximos\nUm ioiô muito ágil");

                    //Spears
                    //Pre-Hardmode

                    Calamity.GetItem("AmidiasTrident").DisplayName.AddTranslation(GameCulture.Portuguese, "Tridente de Amidias");
                    Calamity.GetItem("AmidiasTrident").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara redemoinhos teleguiados");

                    Calamity.GetItem("GoldplumeSpear").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança de Pluma Dourada");
                    Calamity.GetItem("GoldplumeSpear").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara penas que caem");

                    Calamity.GetItem("MarniteSpear").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança de Marnito");

                    Calamity.GetItem("SausageMaker").DisplayName.AddTranslation(GameCulture.Portuguese, "Fazedor de Salsichas");
                    Calamity.GetItem("SausageMaker").Tooltip.AddTranslation(GameCulture.Portuguese, "Espalha sangue teleguiado no acerto");

                    Calamity.GetItem("UrchinSpear").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança de Ouriço-do-mar");
                    Calamity.GetItem("UrchinSpear").Tooltip.AddTranslation(GameCulture.Portuguese, "Envenena inimigos e dispara ferrões de curto alcance");

                    Calamity.GetItem("YateveoBloom").DisplayName.AddTranslation(GameCulture.Portuguese, "Flor Yateveo");
                    Calamity.GetItem("YateveoBloom").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma síntese da flora da selva\nLança um poderoso mangual de rosa\nClique com o botão direito para atacar com uma lança de flores");

                    //Hardmode

                    Calamity.GetItem("AstralPike").DisplayName.AddTranslation(GameCulture.Portuguese, "Pique Astral");
                    Calamity.GetItem("AstralPike").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca barragens de estrelas astrais em acertos críticos");

                    Calamity.GetItem("Brimlance").DisplayName.AddTranslation(GameCulture.Portuguese, "Enxolança");
                    Calamity.GetItem("Brimlance").Tooltip.AddTranslation(GameCulture.Portuguese, "Inimigos mortos pela lança explodem em chamas de enxofre");

                    Calamity.GetItem("DiseasedPike").DisplayName.AddTranslation(GameCulture.Portuguese, "Pique Infectado");
                    Calamity.GetItem("DiseasedPike").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara caçadores da praga no acerto");

                    Calamity.GetItem("EarthenPike").DisplayName.AddTranslation(GameCulture.Portuguese, "Pique Terrestre");
                    Calamity.GetItem("EarthenPike").Tooltip.AddTranslation(GameCulture.Portuguese, "Esmaga a defesa do inimigo\nEspalha fragmentos de fóssil no uso");

                    Calamity.GetItem("GalvanizingGlaive").DisplayName.AddTranslation(GameCulture.Portuguese, "Gládio de Galvanização");
                    Calamity.GetItem("GalvanizingGlaive").Tooltip.AddTranslation(GameCulture.Portuguese, "Seu uso como ferramenta é separar rapidamente um único objeto em dois. Esse também é o seu uso como uma arma.\nBalança uma lança que envolve os inimigos atingidos em um campo de energia\nQuando termina de balançar, a lança descarrega um pulso extra de energia\nCausa mais dano contra inimigos com defesa alta");

                    Calamity.GetItem("HellionFlowerSpear").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança da Grande Flora");
                    Calamity.GetItem("HellionFlowerSpear").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma ponta de lança de flores\nInvoca pétalas do céu em acertos críticos");

                    Calamity.GetItem("StarnightLance").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança da Luz da Noite");
                    Calamity.GetItem("StarnightLance").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um feixe da luz da noite");

                    Calamity.GetItem("TenebreusTides").DisplayName.AddTranslation(GameCulture.Portuguese, "Maré Tenebrosa");
                    Calamity.GetItem("TenebreusTides").Tooltip.AddTranslation(GameCulture.Portuguese, "Inundatio ex Laminis\nAtira uma lança d'agua que perfura os inimigos e o terreno\nAtacar inimigos invoca lâminas e lanças líquidas para atacar o inimigo atingido");

                    Calamity.GetItem("TerraLance").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança da Terra");
                    Calamity.GetItem("TerraLance").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um feixe de lança");

                    Calamity.GetItem("ExsanguinationLance").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança de Vulcanite");
                    Calamity.GetItem("ExsanguinationLance").Tooltip.AddTranslation(GameCulture.Portuguese, "Explode ao atingir inimigos e invoca chamas teleguiadas em acertos críticos");

                    //Post-Moon Lord

                    Calamity.GetItem("BansheeHook").DisplayName.AddTranslation(GameCulture.Portuguese, "Gancho das Almas Penadas");
                    Calamity.GetItem("BansheeHook").Tooltip.AddTranslation(GameCulture.Portuguese, "Balança um gancho de almas penadas que dispara lâminas e explode no acerto");

                    Calamity.GetItem("SpatialLance").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança Elemental");
                    Calamity.GetItem("SpatialLance").Tooltip.AddTranslation(GameCulture.Portuguese, "Separe o cosmos!\nDispara um feixe de lança que se divide várias vezes enquanto viaja");

                    Calamity.GetItem("GildedProboscis").DisplayName.AddTranslation(GameCulture.Portuguese, "Probóscide Dourada");
                    Calamity.GetItem("GildedProboscis").Tooltip.AddTranslation(GameCulture.Portuguese, "Ignora quadros de imunidade\nCura o jogador no acerto");

                    Calamity.GetItem("InsidiousImpaler").DisplayName.AddTranslation(GameCulture.Portuguese, "Empalador Insidioso");
                    Calamity.GetItem("InsidiousImpaler").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um arpão que gruda nos inimigos e explode");

                    Calamity.GetItem("Nadir").DisplayName.AddTranslation(GameCulture.Portuguese, "Nadir");
                    Calamity.GetItem("Nadir").Tooltip.AddTranslation(GameCulture.Portuguese, "Atira essências vazias que esfolam os inimigos próximos com tentáculos\nIgnora quadros de imunidade\n'O abismo te observou por tempo o suficiente. Agora ele fala, e não fala baixinho.'");

                    Calamity.GetItem("StreamGouge").DisplayName.AddTranslation(GameCulture.Portuguese, "Fluxo de Fissuras");
                    Calamity.GetItem("StreamGouge").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um clone de lança de essência\nIgnora quadros de imunidade");

                    //Boomerangs

                    Calamity.GetItem("TruePaladinsHammerMelee").DisplayName.AddTranslation(GameCulture.Portuguese, "Martelo do Paladino Caído");
                    Calamity.GetItem("TruePaladinsHammerMelee").Tooltip.AddTranslation(GameCulture.Portuguese, "Explode ao atingir o inimigo");

                    Calamity.GetItem("MangroveChakram").DisplayName.AddTranslation(GameCulture.Portuguese, "Chakram dos Mangues");

                    Calamity.GetItem("PwnagehammerMelee").DisplayName.AddTranslation(GameCulture.Portuguese, "Pwnagehammer");
                    Calamity.GetItem("PwnagehammerMelee").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança um martelo pesado afetado pela gravidade que cria uma forte explosão de energia sagrada quando atinge algo\nHá uma chance de 20 por cento do martelo seguir o inimigo\nOs martelos teleguiados invocam um martelo espectral adicional no acerto e garantem um acerto crítico");

                    //Post-Moon Lord

                    Calamity.GetItem("GalaxySmasherMelee").DisplayName.AddTranslation(GameCulture.Portuguese, "Esmagador de Galáxias");
                    Calamity.GetItem("GalaxySmasherMelee").Tooltip.AddTranslation(GameCulture.Portuguese, "Explode e invoca lasers da morte ao atingir o inimigo");

                    Calamity.GetItem("StellarContemptMelee").DisplayName.AddTranslation(GameCulture.Portuguese, "Desprezo Estelar");
                    Calamity.GetItem("StellarContemptMelee").Tooltip.AddTranslation(GameCulture.Portuguese, "Chamas da lua chovem ao atingir o inimigo");

                    Calamity.GetItem("DivineHatchet").DisplayName.AddTranslation(GameCulture.Portuguese, "Buscador de Chamas");
                    Calamity.GetItem("DivineHatchet").Tooltip.AddTranslation(GameCulture.Portuguese, "Que seus inimigos queimem no inferno pelos pecados que cometeram\nLança um bumerangue sagrado que busca até três inimigos antes de retornar ao jogador");

                    Calamity.GetItem("TriactisTruePaladinianMageHammerofMightMelee").DisplayName.AddTranslation(GameCulture.Portuguese, "Verdadeiro Mago-Martelo Paladiano do Poder de Triactis");
                    Calamity.GetItem("TriactisTruePaladinianMageHammerofMightMelee").Tooltip.AddTranslation(GameCulture.Portuguese, "Explode ao atingir o inimigo");

                    //Flails
                    //Pre-Hardmode

                    Calamity.GetItem("BallOFugu").DisplayName.AddTranslation(GameCulture.Portuguese, "Pelota de Baiacu");
                    Calamity.GetItem("BallOFugu").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança um peixe que cospe espinhos teleguiados");

                    Calamity.GetItem("UrchinFlail").DisplayName.AddTranslation(GameCulture.Portuguese, "Mangual de Ouriço-do-mar");
                    Calamity.GetItem("UrchinFlail").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança uma bola de ouriço, que atira um espinho ao entrar em contato com um inimigo");

                    //Hardmode

                    Calamity.GetItem("ClamCrusher").DisplayName.AddTranslation(GameCulture.Portuguese, "Esmagador de Ostras");
                    Calamity.GetItem("ClamCrusher").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança uma ostra enorme que atordoa os inimigos por um curto período de tempo\nComeça a ser afetado pela gravidade e causa muito mais danos depois de estar no ar por um tempo");

                    Calamity.GetItem("Nebulash").DisplayName.AddTranslation(GameCulture.Portuguese, "Chicote de Nébula");
                    Calamity.GetItem("Nebulash").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma espada de chicote que emite explosões de partículas no acerto");

                    Calamity.GetItem("Tumbleweed").DisplayName.AddTranslation(GameCulture.Portuguese, "Erva-daninha");
                    Calamity.GetItem("Tumbleweed").Tooltip.AddTranslation(GameCulture.Portuguese, "Libera uma erva daninha rolante no acerto");

                    //Post-Moon Lord

                    Calamity.GetItem("CosmicDischarge").DisplayName.AddTranslation(GameCulture.Portuguese, "Descarga Cósmica");
                    Calamity.GetItem("CosmicDischarge").Tooltip.AddTranslation(GameCulture.Portuguese, "Atingir um inimigo com o chicote causa explosões glaciais e concede ao jogador o efeito de congelamento cósmico\nEste efeito dá ao jogador maior regeneração de vida enquanto fica parado e congela os inimigos perto do jogador");

                    Calamity.GetItem("CrescentMoon").DisplayName.AddTranslation(GameCulture.Portuguese, "Lua Crescente");
                    Calamity.GetItem("CrescentMoon").Tooltip.AddTranslation(GameCulture.Portuguese, "As pessoas queriam a lua, então vamos trazer a lua para elas.\nDispara uma espada de chicote que invoca luas crescentes teleguiadas");

                    Calamity.GetItem("DragonPow").DisplayName.AddTranslation(GameCulture.Portuguese, "Poder do Dragão");
                    Calamity.GetItem("DragonPow").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma cabeça de dragão que libera faíscas dracônicas\nInvoca uma barragem de pétalas e cachoeiras ao atingir o inimigo");

                    Calamity.GetItem("Mourningstar").DisplayName.AddTranslation(GameCulture.Portuguese, "Estrela-da-manhã");
                    Calamity.GetItem("Mourningstar").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança duas espadas de chicote solares que explodem no acerto");

                    Calamity.GetItem("PulseDragon").DisplayName.AddTranslation(GameCulture.Portuguese, "Dragão de Pulso");
                    Calamity.GetItem("PulseDragon").Tooltip.AddTranslation(GameCulture.Portuguese, "Manguais resistentes, cada um contendo um poderoso gerador que é ativado no lançamento.\nLança duas cabeças de dragão que emitem campos elétricos\nEspecialmente eficaz contra alvos inorgânicos");

                    Calamity.GetItem("RemsRevenge").DisplayName.AddTranslation(GameCulture.Portuguese, "Vingança de Rem");
                    Calamity.GetItem("RemsRevenge").Tooltip.AddTranslation(GameCulture.Portuguese, "Empunhada pelo lutador mais poderoso.\nInvoca explosões de sangue e reduz a defesa do inimigo no acerto");

                    Calamity.GetItem("SpineOfThanatos").DisplayName.AddTranslation(GameCulture.Portuguese, "Coluna de Thánatos");
                    Calamity.GetItem("SpineOfThanatos").Tooltip.AddTranslation(GameCulture.Portuguese, "Libera 3 chicotes metálicos rápidos para fora\nQuando os três colidirem, um prisma de luz é disparado para fora\nSe um inimigo estiver dentro da linha de visão dos chicotes na colisão, a luz dispersará em direção a ele");

                    //Other
                    //Pre-Hardmode

                    Calamity.GetItem("MonstrousKnives").DisplayName.AddTranslation(GameCulture.Portuguese, "Facas Monstruosas");
                    Calamity.GetItem("MonstrousKnives").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança uma série de facas que podem curar o usuário");

                    //Hardmode

                    Calamity.GetItem("Bonebreaker").DisplayName.AddTranslation(GameCulture.Portuguese, "Quebra-ossos");
                    Calamity.GetItem("Bonebreaker").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara dardos que grudam nos inimigos antes de explodir em estilhaços");

                    Calamity.GetItem("TyphonsGreed").DisplayName.AddTranslation(GameCulture.Portuguese, "Ganância de Typhon");
                    Calamity.GetItem("TyphonsGreed").Tooltip.AddTranslation(GameCulture.Portuguese, "Invoca espíritos d'água durante o uso");

                    //Post-Moon Lord

                    Calamity.GetItem("DevilsSunrise").DisplayName.AddTranslation(GameCulture.Portuguese, "Nascer do Sol do Diabo");
                    Calamity.GetItem("DevilsSunrise").Tooltip.AddTranslation(GameCulture.Portuguese, "Bolas? Pequenas.");

                    Calamity.GetItem("EmpyreanKnives").DisplayName.AddTranslation(GameCulture.Portuguese, "Facas Empíricas");
                    Calamity.GetItem("EmpyreanKnives").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança uma série de facas que podem curar o usuário");

                    Calamity.GetItem("RoyalKnivesMelee").DisplayName.AddTranslation(GameCulture.Portuguese, "Facas Ilustres");
                    Calamity.GetItem("RoyalKnivesMelee").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança uma série de facas teleguiadas que podem curar o usuário");

                    Calamity.GetItem("Murasama").DisplayName.AddTranslation(GameCulture.Portuguese, "Murasama");
                    Calamity.GetItem("Murasama").Tooltip.AddTranslation(GameCulture.Portuguese, "Haverá sangue!\nBloqueado por ID e nível de força. Prove sua força ou tenha o ID de usuário correto para empunhar esta espada.");

                    Calamity.GetItem("Phaseslayer").DisplayName.AddTranslation(GameCulture.Portuguese, "Cortador de Fase");
                    Calamity.GetItem("Phaseslayer").Tooltip.AddTranslation(GameCulture.Portuguese, "Um protótipo bruto da lâmina Murasama, é formado inteiramente a partir da energia do laser.\nEmpunhe uma lâmina laser colossal que é controlada pelo cursor\nBalanços mais rápidos causam mais danos e liberam raios de espada\nQuando com carga baixa, a lâmina é menor e mais fraca\nCausa menos dano contra inimigos com alta defesa");

                    Calamity.GetItem("PhosphorescentGauntlet").DisplayName.AddTranslation(GameCulture.Portuguese, "Manopla Fosforescente");
                    Calamity.GetItem("PhosphorescentGauntlet").Tooltip.AddTranslation(GameCulture.Portuguese, "Libera golpes sulfurosos rápidos\nAo usar, você avança na direção do mouse\nNa colisão, você é empurrado para trás");

                    Calamity.GetItem("PhotonRipper").DisplayName.AddTranslation(GameCulture.Portuguese, "Estripador de Fótons");
                    Calamity.GetItem("PhotonRipper").Tooltip.AddTranslation(GameCulture.Portuguese, "Projeta um fluxo direcionado de dentes de luz dura em velocidade ulta alta\nEsta arma e seus projéteis funcionam como uma motoserra");

                    Calamity.GetItem("ScourgeoftheCosmos").DisplayName.AddTranslation(GameCulture.Portuguese, "Tormento dos Cosmos");
                    Calamity.GetItem("ScourgeoftheCosmos").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança um tormento cósmico saltitante que emite pequenos tormentos cósmicos teleguiados na morte e ao atingir peças");

                    Calamity.GetItem("Violence").DisplayName.AddTranslation(GameCulture.Portuguese, "Violência");
                    Calamity.GetItem("Violence").Tooltip.AddTranslation(GameCulture.Portuguese, "Libera um garfo flamejante que fica perto do mouse e destrói os inimigos");

                    //Ranged weapons
                    //Bows
                    //Pre-Hardmode

                    Calamity.GetItem("Barinade").DisplayName.AddTranslation(GameCulture.Portuguese, "Barinada");
                    Calamity.GetItem("Barinade").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte flechas de madeira em flechas de raios elétricos que explodem");

                    Calamity.GetItem("Galeforce").DisplayName.AddTranslation(GameCulture.Portuguese, "Força do Vendaval");
                    Calamity.GetItem("Galeforce").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma barragem de penas fracas");

                    Calamity.GetItem("Goobow").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco Gosmento");
                    Calamity.GetItem("Goobow").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara dois jatos de geleia");

                    Calamity.GetItem("LunarianBow").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco Lunariano");
                    Calamity.GetItem("LunarianBow").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara duas flechas de uma vez\nConverte flechas de madeira em raios de energia deslizantes");

                    Calamity.GetItem("MandibleBow").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco de Mandíbula");

                    Calamity.GetItem("Seabow").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco dos Mares");
                    Calamity.GetItem("Seabow").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara jatos d'água lentos");

                    Calamity.GetItem("Shellshooter").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança-conchas");
                    Calamity.GetItem("Shellshooter").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte flechas de madeira em conchas lentas e poderosas");

                    Calamity.GetItem("Toxibow").DisplayName.AddTranslation(GameCulture.Portuguese, "Tóxiarco");
                    Calamity.GetItem("Toxibow").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte flechas de madeira em flechas lentas que ocasionalmente infligem envenenamento sulfúrico");

                    Calamity.GetItem("WulfrumBow").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco de Vulfrânio");

                    //Hardmode

                    Calamity.GetItem("AstralRepeater").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco Astral");
                    Calamity.GetItem("AstralRepeater").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma sequência de três flechas");

                    Calamity.GetItem("TheBallista").DisplayName.AddTranslation(GameCulture.Portuguese, "A Balista");
                    Calamity.GetItem("TheBallista").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte flechas de madeira em grandes flechas que esmagam a blindagem do inimigo e quebram em fragmentos na morte");

                    Calamity.GetItem("Barinautical").DisplayName.AddTranslation(GameCulture.Portuguese, "Barináutico");
                    Calamity.GetItem("Barinautical").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte flechas de madeira em linhas de 3 flechas de raios elétricos que explodem");

                    Calamity.GetItem("BlossomFlux").DisplayName.AddTranslation(GameCulture.Portuguese, "Fluxo Floral");
                    Calamity.GetItem("BlossomFlux").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um jato de folhas\nClique com o botão direito para disparar um orbe de esporos que explode em uma núvem de gas de esporos");

                    Calamity.GetItem("BrimstoneFury").DisplayName.AddTranslation(GameCulture.Portuguese, "Fúria de Enxofre");
                    Calamity.GetItem("BrimstoneFury").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte flechas de madeira em 3 raios de enxofre espalhados");

                    Calamity.GetItem("GreatbowofTurmoil").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco Continental");
                    Calamity.GetItem("GreatbowofTurmoil").Tooltip.AddTranslation(GameCulture.Portuguese, "Flechas de madeira são acendidas com fogo\nDispara 3 flechas de uma vez\nDispara 2 flechas adicionais amaldiçoadas, de fogo do inferno, ou de ichor");

                    Calamity.GetItem("CorrodedCaustibow").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco Cáustico Corroído");
                    Calamity.GetItem("CorrodedCaustibow").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte flechas de madeira em conchas lentas e poderosas que trilham uma aura irradiada");

                    Calamity.GetItem("CosmicBolter").DisplayName.AddTranslation(GameCulture.Portuguese, "Raio Cósmico");
                    Calamity.GetItem("CosmicBolter").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara três flechas de uma vez\nConverte flechas de madeira em raios de energia deslizantes");

                    Calamity.GetItem("DarkechoGreatbow").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco do Eco Escuro");
                    Calamity.GetItem("DarkechoGreatbow").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara duas flechas de uma vez\nDispara um dardo de cristal adicional");

                    Calamity.GetItem("EffluviumBow").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco do Eflúvio");
                    Calamity.GetItem("EffluviumBow").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara duas flechas de uma vez\nConverte flechas de madeira em flechas da névoa");

                    Calamity.GetItem("EternalBlizzard").DisplayName.AddTranslation(GameCulture.Portuguese, "Nevasca Eterna");
                    Calamity.GetItem("EternalBlizzard").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma flecha de gelo adicional que se estilhaça no impacto");

                    Calamity.GetItem("FlarewingBow").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco de Asas Ardentes");
                    Calamity.GetItem("FlarewingBow").Tooltip.AddTranslation(GameCulture.Portuguese, "Atira 5 flechas espalhadas\nFlechas de madeira são convertidas em morcegos de obsidiana saltitantes");

                    Calamity.GetItem("Malevolence").DisplayName.AddTranslation(GameCulture.Portuguese, "Malevolência");
                    Calamity.GetItem("Malevolence").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara duas flechas de uma vez\nConverte flechas de madeira em flechas da praga que explodem em abelhas na morte");

                    Calamity.GetItem("MarksmanBow").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco do Atirador");
                    Calamity.GetItem("MarksmanBow").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara três flechas de uma vez\nFlechas de madeira são convertidas em flechas do Jester");

                    //Post-Moon Lord

                    Calamity.GetItem("Alluvion").DisplayName.AddTranslation(GameCulture.Portuguese, "Alúvio");
                    Calamity.GetItem("Alluvion").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte flechas de madeira em tubarões, flechas torrenciais e de tufão\nDispara uma torrente de seis flechas de uma vez");

                    Calamity.GetItem("ArterialAssault").DisplayName.AddTranslation(GameCulture.Portuguese, "Assalto Arterial");
                    Calamity.GetItem("ArterialAssault").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma corrente de 5 flechas do céu\nFlechas de madeira são convertidas em flechas de fogo sangrento teleguiadas");

                    Calamity.GetItem("AstrealDefeat").DisplayName.AddTranslation(GameCulture.Portuguese, "Derrota Astral");
                    Calamity.GetItem("AstrealDefeat").Tooltip.AddTranslation(GameCulture.Portuguese, "Arco etéreo da mãe do rei tirano\nA mãe desencorajou fortemente atos de violência ao longo de sua vida\nNo entanto, ela manteu este arco por perto, para proteger sua família em tempos de grande desastre\nTodas as flechas são convertidas em Flechas Astrais que emitem chamas enquanto caminham");

                    Calamity.GetItem("ClockworkBow").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco Relógio");
                    Calamity.GetItem("ClockworkBow").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma tempestade de flechas em direções aleatórias\nTodas as flechas disparadas atravessarão os blocos");

                    Calamity.GetItem("Contagion").DisplayName.AddTranslation(GameCulture.Portuguese, "Contágio");
                    Calamity.GetItem("Contagion").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara flechas de contágio que deixam orbes explosivos para trás enquanto caminham");

                    Calamity.GetItem("DaemonsFlame").DisplayName.AddTranslation(GameCulture.Portuguese, "Chama de Daemon");
                    Calamity.GetItem("DaemonsFlame").Tooltip.AddTranslation(GameCulture.Portuguese, "Atira bolas de fogo de daemon junto de 4 flechas normais");

                    Calamity.GetItem("Deathwind").DisplayName.AddTranslation(GameCulture.Portuguese, "Vento da Morte");
                    Calamity.GetItem("Deathwind").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara 4 flechas espalhadas\nFlechas de madeira são convertidas em flechas da nébula");

                    Calamity.GetItem("Drataliornus").DisplayName.AddTranslation(GameCulture.Portuguese, "Drataliornus");
                    Calamity.GetItem("Drataliornus").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um fluxo crescente de bolas de fogo.\nBolas de fogo fazem chover meteoros, deixam um trilho de poeira de dragão, e lançam raios adicionais na velocidade máxima.\nSofrer danos enquanto dispara irá interrompê-lo e reduzirá o seu tempo de voo da asa.\nClique com o botão direito para disparar duas barragens devastadoras de cinco bolas de fogo fortalecidas.\n'Só não seja atingido'");

                    Calamity.GetItem("HeavenlyGale").DisplayName.AddTranslation(GameCulture.Portuguese, "Vendaval Celestial");
                    Calamity.GetItem("HeavenlyGale").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte flechas de madeira em barragens de 5 exo flechas aleatórias\nFlechas exo verdes explodem em tornados\nFlechas exo azuis explodem em barragens de flechas teleguiadas\nFlechas exo laranjas explodem em chamas\nFlechas exo verde-azuladas atravessam infinitamente e ignoram quadros de imunidade\nQualquer flecha que não sejam flechas de madeira causarão 1.25x de dano\n66% de de chance de não consumir munição");

                    Calamity.GetItem("Monsoon").DisplayName.AddTranslation(GameCulture.Portuguese, "Monção");
                    Calamity.GetItem("Monsoon").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara 5 flechas espalhadas\nFlechas de madeira são convertidas em flechas de tufão e tubarões");

                    Calamity.GetItem("NettlelineGreatbow").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco das Videiras");
                    Calamity.GetItem("NettlelineGreatbow").Tooltip.AddTranslation(GameCulture.Portuguese, "Atira 4 flechas de uma vez\nDispara 2 flechas de veneno ou clorofita adicionais");

                    Calamity.GetItem("Phangasm").DisplayName.AddTranslation(GameCulture.Portuguese, "Fangasma");
                    Calamity.GetItem("Phangasm").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara 5 flechas espalhadas e emite flechas fantasmas ao atingir o inimigo");

                    Calamity.GetItem("PlanetaryAnnihilation").DisplayName.AddTranslation(GameCulture.Portuguese, "Aniquilação Planetária");
                    Calamity.GetItem("PlanetaryAnnihilation").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma tempestade de 7 flechas do céu\nFlechas de madeira são convertidas em raios de energia teleguiados");

                    Calamity.GetItem("TheStorm").DisplayName.AddTranslation(GameCulture.Portuguese, "A Tempestade");
                    Calamity.GetItem("TheStorm").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara flechas espalhadas do céu\nConverte flechas de madeira em relâmpagos");

                    Calamity.GetItem("TelluricGlare").DisplayName.AddTranslation(GameCulture.Portuguese, "Olhar Telúrico");
                    Calamity.GetItem("TelluricGlare").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara rajadas de quatro flechas radiantes colossais que podem atravessar paredes");

                    Calamity.GetItem("Ultima").DisplayName.AddTranslation(GameCulture.Portuguese, "Ultima");
                    Calamity.GetItem("Ultima").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança um fluxo contínuo de raios de plasma\nCom o tempo, os raios são substituídos por lasers poderosos\nOs raios se transformam em feixes sólidos enquanto você continua atirando\n90% de chance de não consumir munição");

                    //Repeaters
                    //Hardmode
                    Calamity.GetItem("Arbalest").DisplayName.AddTranslation(GameCulture.Portuguese, "Arabaleta");
                    Calamity.GetItem("Arbalest").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma rajada de 10 flechas de alta velocidade\nAs flechas começam pequenas e crescem em tamanho com fogo contínuo\nO dano, espalhamento e do recuo da flecha aumentam com o tamanho da flecha");

                    Calamity.GetItem("BladedgeGreatbow").DisplayName.AddTranslation(GameCulture.Portuguese, "Arco da Borda da Lâmina");
                    Calamity.GetItem("BladedgeGreatbow").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara 4 flechas de uma vez\nDispara 2 folhas adicionais");

                    Calamity.GetItem("Impaler").DisplayName.AddTranslation(GameCulture.Portuguese, "Empalador");
                    Calamity.GetItem("Impaler").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara estacas explosivas e flamejantes\nMata instantaneamente vampiros e morcegos vampiros");

                    Calamity.GetItem("RaidersGlory").DisplayName.AddTranslation(GameCulture.Portuguese, "Glória do Corsário");
                    Calamity.GetItem("RaidersGlory").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara flechas de ichor com velocidade aumentada\nEstas flechas também fazem com que os inimigos deixem cair mais dinheiro");

                    Calamity.GetItem("Condemnation").DisplayName.AddTranslation(GameCulture.Portuguese, "Condenação");
                    Calamity.GetItem("Condemnation").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara poderosos raios escarlates de magias odiosas\nSegure o botão esquerdo para carregar até oito raios para uma poderosa rajada de disparos\nSegure o botão direito para usar o repetidor de modo totalmente automático");

                    //Guns
                    //Pre-Hardmode
                    Calamity.GetItem("Archerfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-arqueiro");
                    Calamity.GetItem("Archerfish").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em correntes de água");

                    Calamity.GetItem("BulletFilledShotgun").DisplayName.AddTranslation(GameCulture.Portuguese, "Espingarda Cheia de Balas");
                    Calamity.GetItem("BulletFilledShotgun").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara projéteis saltitantes em várias direções\nConsome cinco projéteis por uso\nMira? O que é isso?");

                    Calamity.GetItem("Eviscerator").DisplayName.AddTranslation(GameCulture.Portuguese, "Eviscerador");
                    Calamity.GetItem("Eviscerator").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em coágulos sanguíneos lentos");

                    Calamity.GetItem("Fungicide").DisplayName.AddTranslation(GameCulture.Portuguese, "Fungicídio");
                    Calamity.GetItem("Fungicide").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em tiros de fungos que se dividem na morte");

                    Calamity.GetItem("GunkShot").DisplayName.AddTranslation(GameCulture.Portuguese, "Tiro de Gosma");
                    Calamity.GetItem("GunkShot").Tooltip.AddTranslation(GameCulture.Portuguese, "Atira projéteis em várias direções");

                    Calamity.GetItem("MarniteRifleSpear").DisplayName.AddTranslation(GameCulture.Portuguese, "Baioneta de Marnito");
                    Calamity.GetItem("MarniteRifleSpear").Tooltip.AddTranslation(GameCulture.Portuguese, "A arma causa danos aos inimigos que a tocam");

                    Calamity.GetItem("OpalStriker").DisplayName.AddTranslation(GameCulture.Portuguese, "Atirador de Opala");
                    Calamity.GetItem("OpalStriker").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma linha de ataques de opala");

                    //Hardmode
                    Calamity.GetItem("Animosity").DisplayName.AddTranslation(GameCulture.Portuguese, "Animosidade");
                    Calamity.GetItem("Animosity").Tooltip.AddTranslation(GameCulture.Portuguese, "50% de chance de não consumir munição\nDispara um poderoso tiro de longo alcance\nClique com o botão direito para disparar uma rajada de projéteis");

                    Calamity.GetItem("AstralBlaster").DisplayName.AddTranslation(GameCulture.Portuguese, "Detonador Astral");
                    Calamity.GetItem("AstralBlaster").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em tiros astrais teleguiados");

                    Calamity.GetItem("Butcher").DisplayName.AddTranslation(GameCulture.Portuguese, "Açougueiro");
                    Calamity.GetItem("Butcher").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara mais rápido e com mais precisão quanto mais tempo você segurar o gatilho");

                    Calamity.GetItem("ClamorRifle").DisplayName.AddTranslation(GameCulture.Portuguese, "Rifle do Clamor");
                    Calamity.GetItem("ClamorRifle").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em raios de energia teleguiados");

                    Calamity.GetItem("ClockGatlignum").DisplayName.AddTranslation(GameCulture.Portuguese, "Magnum do Jacaré Relógio");
                    Calamity.GetItem("ClockGatlignum").Tooltip.AddTranslation(GameCulture.Portuguese, "33% de chance de não consumir munição\nConverte bolas de mosquete em linhas de 3 projéteis de alta velocidade");

                    Calamity.GetItem("TrueConferenceCall").DisplayName.AddTranslation(GameCulture.Portuguese, "Chamada de Conferência");
                    Calamity.GetItem("TrueConferenceCall").Tooltip.AddTranslation(GameCulture.Portuguese, "@everyone");

                    Calamity.GetItem("CursedCapper").DisplayName.AddTranslation(GameCulture.Portuguese, "Finalizador Amaldiçoado");
                    Calamity.GetItem("CursedCapper").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara projéteis amaldiçoados");

                    Calamity.GetItem("FrostbiteBlaster").DisplayName.AddTranslation(GameCulture.Portuguese, "Detonador da Queimadura Fria");
                    Calamity.GetItem("FrostbiteBlaster").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara 6 projéteis espalhados\nConverte bolas de mosquete em gelo");

                    Calamity.GetItem("Hellborn").DisplayName.AddTranslation(GameCulture.Portuguese, "Nascimento Infernal");
                    Calamity.GetItem("Hellborn").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara 3 projéteis espalhados\nConverte bolas de mosquete em projéteis explosivos\nInimigos que tocam a arma enquanto ela está sendo atirada ativam uma explosão gigante\nApós a explosão, esta arma ganha um aumento gigante ao seu dano, taxa de disparo e recuo por 10 segundos\nEstes bônus de estatísticas decaem lentamente ao longo do tempo");

                    Calamity.GetItem("Helstorm").DisplayName.AddTranslation(GameCulture.Portuguese, "Tempestade Infernal");
                    Calamity.GetItem("Helstorm").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara dois projéteis de uma vez\nA arma também causa danos aos inimigos que a tocam");

                    Calamity.GetItem("MagnaStriker").DisplayName.AddTranslation(GameCulture.Portuguese, "Atirador de Magna");
                    Calamity.GetItem("MagnaStriker").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma série de ataques de opala e magna");

                    Calamity.GetItem("Megalodon").DisplayName.AddTranslation(GameCulture.Portuguese, "Megalodon");
                    Calamity.GetItem("Megalodon").Tooltip.AddTranslation(GameCulture.Portuguese, "50% de chance de não consumir munição");

                    Calamity.GetItem("Needler").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança-agulhas");
                    Calamity.GetItem("Needler").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em agulhas que grudam nos inimigos e explodem");

                    Calamity.GetItem("P90").DisplayName.AddTranslation(GameCulture.Portuguese, "P90");
                    Calamity.GetItem("P90").Tooltip.AddTranslation(GameCulture.Portuguese, "33% de chande de não consumir munição\nÉ uma mangueira de projéteis");

                    Calamity.GetItem("PestilentDefiler").DisplayName.AddTranslation(GameCulture.Portuguese, "Profanador Pestilento");
                    Calamity.GetItem("PestilentDefiler").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em tiros da praga que explodem e se separam na morte");

                    Calamity.GetItem("ProporsePistol").DisplayName.AddTranslation(GameCulture.Portuguese, "Pistola do Propósito");
                    Calamity.GetItem("ProporsePistol").Tooltip.AddTranslation(GameCulture.Portuguese, "Pistola do Propósito");

                    Calamity.GetItem("RealmRavager").DisplayName.AddTranslation(GameCulture.Portuguese, "Devastador de Reinos");
                    Calamity.GetItem("RealmRavager").Tooltip.AddTranslation(GameCulture.Portuguese, "Atira uma rajada de 3 a 4 projéteis\nConverte bolas de mosquete em projéteis explosivos");

                    Calamity.GetItem("Shroomer").DisplayName.AddTranslation(GameCulture.Portuguese, "Cogumelador");
                    Calamity.GetItem("Shroomer").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara projéteis e um cogumelo teleguiado extremamente poderoso");

                    Calamity.GetItem("SlagMagnum").DisplayName.AddTranslation(GameCulture.Portuguese, "Magnum da Escória");
                    Calamity.GetItem("SlagMagnum").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em fragmentos de fóssil que se dividem em fragmentos adicionais na morte");

                    Calamity.GetItem("SpectreRifle").DisplayName.AddTranslation(GameCulture.Portuguese, "Rifle Espectral");
                    Calamity.GetItem("SpectreRifle").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em almas teleguiadas poderosas");

                    Calamity.GetItem("TitaniumRailgun").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão à Laser de Titânio");
                    Calamity.GetItem("TitaniumRailgun").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um laser");

                    Calamity.GetItem("Vortexpopper").DisplayName.AddTranslation(GameCulture.Portuguese, "Vortexpopper");
                    Calamity.GetItem("Vortexpopper").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara bolhas para todos os lados que estouram em projéteis");

                    //Post-Moon Lord

                    Calamity.GetItem("AcesHigh").DisplayName.AddTranslation(GameCulture.Portuguese, "Ás Alto");
                    Calamity.GetItem("AcesHigh").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma linha de cartas com vários efeitos baseados no tipo da carta\nCopas fornecem roubo de vida. Espadas atravessam os inimigos e ignoram quadros de imunidade.\nOuros explodem. Paus se dividem em três.");

                    Calamity.GetItem("AngelicShotgun").DisplayName.AddTranslation(GameCulture.Portuguese, "Espingarda Angelical");
                    Calamity.GetItem("AngelicShotgun").Tooltip.AddTranslation(GameCulture.Portuguese, "Cada tiro lança um raio radiante de luz sagrada do céu\nConverte bolas de mosquete em projéteis iluminados\nLutando até vencer a guerra");

                    Calamity.GetItem("AMR").DisplayName.AddTranslation(GameCulture.Portuguese, "Rifle Anti-material");
                    Calamity.GetItem("AMR").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em tiros de sniper de calibre .50 que destroem a defesa e a RD do inimigo\nSe você atingir um ataque crítico no alvo, uma segunda barragem de balas será disparada");

                    Calamity.GetItem("Auralis").DisplayName.AddTranslation(GameCulture.Portuguese, "Auralis");
                    Calamity.GetItem("Auralis").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um projétil brilhante de alta velocidade que inflige efeitos negativos debilitantes\nClique com o botão direito para afastar\nFicar parado fornece bônus de dano crescentes em até 25%\nFicar parado por 5 ou mais segundos usando a habilidade de mira invocará uma aurora\nA aurora reduz o dano do próximo projétil atingido em 100\nEste efeito dura até 20 segundos e tem um tempo de recarga de 30 segundos\n50% de chance de não consumir munição");

                    Calamity.GetItem("ClaretCannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão de Clarete");
                    Calamity.GetItem("ClaretCannon").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em linhas de 3 lágrimas sangrentas que drenam a vida do inimigo");

                    Calamity.GetItem("Interfacer").DisplayName.AddTranslation(GameCulture.Portuguese, "Disseminador");
                    Calamity.GetItem("Interfacer").Tooltip.AddTranslation(GameCulture.Portuguese, "50% de chance de não consumir munição\nDispara uma série de projéteis da arma, de cima, e de baixo");

                    Calamity.GetItem("DodusHandcannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão de Mão de Dodu");
                    Calamity.GetItem("DodusHandcannon").Tooltip.AddTranslation(GameCulture.Portuguese, "O poder da noz está em suas mãos\nDispara cascas de amendoim altamente explosivas, literalmente");

                    Calamity.GetItem("DragonsBreath").DisplayName.AddTranslation(GameCulture.Portuguese, "Sopro do Dragão");
                    Calamity.GetItem("DragonsBreath").Tooltip.AddTranslation(GameCulture.Portuguese, "O clique com o botão esquerdo dispara em rajadas de dois tiros\nO primeiro tiro é um disparo espalhado de 6 projéteis normais\nO segundo tiro é um disparo menos espalhado de 6 tiros de Sopro do Dragão\nO clique com o botão direito dispara de modo totalmente automático e mistura os projéteis aleatoriamente, mas causa 20% menos dano\nEsta arma não tem aleatoriedade em seu padrão de espalhamento\n66% de chance de não consumir munição");

                    Calamity.GetItem("FetidEmesis").DisplayName.AddTranslation(GameCulture.Portuguese, "Vomição Fétida");
                    Calamity.GetItem("FetidEmesis").Tooltip.AddTranslation(GameCulture.Portuguese, "Tem uma chance de liberar pedaços podres em vez de projéteis");

                    Calamity.GetItem("GoldenEagle").DisplayName.AddTranslation(GameCulture.Portuguese, "Águia Dourada");
                    Calamity.GetItem("GoldenEagle").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara 5 projéteis de uma vez");

                    Calamity.GetItem("HalibutCannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão Halibute");
                    Calamity.GetItem("HalibutCannon").Tooltip.AddTranslation(GameCulture.Portuguese, "Sim, ainda é superpoderoso");

                    Calamity.GetItem("Infinity").DisplayName.AddTranslation(GameCulture.Portuguese, "Infinito");
                    Calamity.GetItem("Infinity").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma barragem de raios de energia que se dividem e rebatem nas paredes\nClique com o botão direito para disparar uma barragem de projéteis normais\nEles dizem que o infinito não tem fim, mas você o segura em suas mãos");

                    Calamity.GetItem("TheJailor").DisplayName.AddTranslation(GameCulture.Portuguese, "O Carcereiro");
                    Calamity.GetItem("TheJailor").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara minas elétricas para fora que se conectam umas às outras através de arcos");

                    Calamity.GetItem("Karasawa").DisplayName.AddTranslation(GameCulture.Portuguese, "Karasawa");
                    Calamity.GetItem("Karasawa").Tooltip.AddTranslation(GameCulture.Portuguese, "...Isso é pesado... muito pesado.");

                    Calamity.GetItem("Minigun").DisplayName.AddTranslation(GameCulture.Portuguese, "Minigun");
                    Calamity.GetItem("Minigun").Tooltip.AddTranslation(GameCulture.Portuguese, "80% de chance de não consumir munição");

                    Calamity.GetItem("OnyxChainBlaster").DisplayName.AddTranslation(GameCulture.Portuguese, "Detonador Sequencial de Ônix");
                    Calamity.GetItem("OnyxChainBlaster").Tooltip.AddTranslation(GameCulture.Portuguese, "50% de chance de não consumir munição\nDispara projéteis em várias direções e um fragmento de ônix");

                    Calamity.GetItem("Onyxia").DisplayName.AddTranslation(GameCulture.Portuguese, "Oníxia");
                    Calamity.GetItem("Onyxia").Tooltip.AddTranslation(GameCulture.Portuguese, "50% de chance de não consumir munição\nDispara uma tempestade de projéteis e fragmentos de ônix");

                    Calamity.GetItem("PearlGod").DisplayName.AddTranslation(GameCulture.Portuguese, "Deus Pérola");
                    Calamity.GetItem("PearlGod").Tooltip.AddTranslation(GameCulture.Portuguese, "A sua vida é minha...\nDispara tiros de explosão de choque que emitem explosões enormes e roubam a vida do inimigo, bem como projéteis adicionais\nCada sétimo tiro dispara uma explosão de choque enorme");

                    Calamity.GetItem("PrideHuntersPlanarRipper").DisplayName.AddTranslation(GameCulture.Portuguese, "Eviscerador Planar do Caçador Orgulhoso");
                    Calamity.GetItem("PrideHuntersPlanarRipper").Tooltip.AddTranslation(GameCulture.Portuguese, "Cada quarto tiro causa 135% de dano\nConverte bolas de mosquete em relâmpagos\nOs relâmpagos viajam extremamente rápido e explodem na morte dos inimigos\nOs acertos críticos dos relâmpagos concedem um reforço de velocidade ao jogador que pode pode ser combinado\nIsso se acumula até 20 porcento de velocidade dos movimentos e aceleração bônus\nO reforço será redefinido se o jogador segurar um item diferente\n33% de chance de não consumir munição");

                    Calamity.GetItem("RubicoPrime").DisplayName.AddTranslation(GameCulture.Portuguese, "Rubico Alfa");
                    Calamity.GetItem("RubicoPrime").Tooltip.AddTranslation(GameCulture.Portuguese, "Sniper semiautomática que dispara em rajadas de 5 segundos\nDispara tiros de impacto que têm um multiplicador de crítico aumentado e causam dano adicional a alvos inorgânicos");

                    Calamity.GetItem("SDFMG").DisplayName.AddTranslation(GameCulture.Portuguese, "MDFE");
                    Calamity.GetItem("SDFMG").Tooltip.AddTranslation(GameCulture.Portuguese, "Veio dos cantos de Terraria\n50% de chance de não consumir munição");

                    Calamity.GetItem("Seadragon").DisplayName.AddTranslation(GameCulture.Portuguese, "Dragão dos Mares");
                    Calamity.GetItem("Seadragon").Tooltip.AddTranslation(GameCulture.Portuguese, "50% de chance de não consumir munição\nTem a chance de disparar foguetes teleguiados que explodem em fragmentos de fogo na morte");

                    Calamity.GetItem("Shredder").DisplayName.AddTranslation(GameCulture.Portuguese, "Despedaçador");
                    Calamity.GetItem("Shredder").Tooltip.AddTranslation(GameCulture.Portuguese, "O mito, a lenda, a arma que faz os frames cair mais que qualquer outra\nDispara uma barragem de raios de energia que se dividem e rebatem\nClique com o botão direito para disparar uma barragem de projéteis normais");

                    Calamity.GetItem("SomaPrime").DisplayName.AddTranslation(GameCulture.Portuguese, "Soma Alfa");
                    Calamity.GetItem("SomaPrime").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em tiros de alta velocidade extremamente poderosos que infligem um efeito negativo de sangramento poderoso");

                    Calamity.GetItem("Spyker").DisplayName.AddTranslation(GameCulture.Portuguese, "Espinhador");
                    Calamity.GetItem("Spyker").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em espinhos que grudam nos inimigos, peças e explodem em estilhaços");

                    Calamity.GetItem("StormDragoon").DisplayName.AddTranslation(GameCulture.Portuguese, "Dragão da Tempestade");
                    Calamity.GetItem("StormDragoon").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma rajada de balas\n90% de chance de não consumir munição");

                    Calamity.GetItem("SurgeDriver").DisplayName.AddTranslation(GameCulture.Portuguese, "Condutor de Correntes");
                    Calamity.GetItem("SurgeDriver").Tooltip.AddTranslation(GameCulture.Portuguese, "Cliques com botão esquerdo liberam um raio laser que explode em colisão\nCliques com o botão direito liberam uma barragem de raios laser que liberam energia teleguiada ao atingir o inimigo");

                    Calamity.GetItem("Svantechnical").DisplayName.AddTranslation(GameCulture.Portuguese, "Svantécnico");
                    Calamity.GetItem("Svantechnical").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara várias barragens de projéteis\nClique com o botão direito para afastar");

                    Calamity.GetItem("TyrannysEnd").DisplayName.AddTranslation(GameCulture.Portuguese, "Fim da Tirania");
                    Calamity.GetItem("TyrannysEnd").Tooltip.AddTranslation(GameCulture.Portuguese, "Perfure o coração até mesmo do inimigo mais fortemente blindado\nDispara um tiro de sniper de calibre .70 que ignora a defesa e RD\nOs tiros marcam os inimigos para a morte e invocam uma rajada de balas adicionais em acertos críticos");

                    Calamity.GetItem("UniversalGenesis").DisplayName.AddTranslation(GameCulture.Portuguese, "Gênese Universal");
                    Calamity.GetItem("UniversalGenesis").Tooltip.AddTranslation(GameCulture.Portuguese, "Deixe o céu estrelado cair sobre seus inimigos\nDispara projéteis em várias direções da arma e uma enxurrada de estrelas para chover no cursor\nConverte bolas de mosquete em tiros chamadores de estrelas que invocam estrelas adicionais ao atingir o inimigo\n50% de chance de não consumir munição");

                    Calamity.GetItem("Megafleet").DisplayName.AddTranslation(GameCulture.Portuguese, "Dragão do Vazio");
                    Calamity.GetItem("Megafleet").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara tiros do vazio que explodem");

                    //Launchers
                    //Hardmode
                    Calamity.GetItem("TheHive").DisplayName.AddTranslation(GameCulture.Portuguese, "A Colmeia");
                    Calamity.GetItem("TheHive").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança uma variedade de foguetes que explodem em abelhas na morte");

                    Calamity.GetItem("MineralMortar").DisplayName.AddTranslation(GameCulture.Portuguese, "Morteiro Mineral");
                    Calamity.GetItem("MineralMortar").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma bomba de ônix que explode em tubarões de areia na morte");

                    Calamity.GetItem("Scorpion").DisplayName.AddTranslation(GameCulture.Portuguese, "Scorpio");
                    Calamity.GetItem("Scorpion").Tooltip.AddTranslation(GameCulture.Portuguese, "BOOM\nClique com o botão direito para disparar uma bomba nuclear");

                    //Post-Moon Lord
                    Calamity.GetItem("BlissfulBombardier").DisplayName.AddTranslation(GameCulture.Portuguese, "Bombardeiro Alegre");
                    Calamity.GetItem("BlissfulBombardier").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara foguetes flamejantes");

                    Calamity.GetItem("ChickenCannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão de Galinhas");
                    Calamity.GetItem("ChickenCannon").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara foguetes de galinha flamejantes que criam explosões incendiárias enormes\nClique com o botão direito para detonar todos os foguetes no ar");

                    Calamity.GetItem("HandheldTank").DisplayName.AddTranslation(GameCulture.Portuguese, "Tanque Portátil");

                    Calamity.GetItem("MagnomalyCannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão da Magnomalia");
                    Calamity.GetItem("MagnomalyCannon").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança um poderoso foguete exo para destruir tudo\nOs foguetes são cercados por uma aura de dano invisível e se dividem em feixes de dano no acerto\n66% de chance de não consumir munição");

                    Calamity.GetItem("ScorchedEarth").DisplayName.AddTranslation(GameCulture.Portuguese, "Terra Arrasada");
                    Calamity.GetItem("ScorchedEarth").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma rajada de quatro foguetes movidos a ar que explodem em bombas de fragmentação\nCada rajada consome dois foguetes cada\nQueima seus alvos e os reduz a cinzas finas");

                    Calamity.GetItem("ThePack").DisplayName.AddTranslation(GameCulture.Portuguese, "O Bando");
                    Calamity.GetItem("ThePack").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara grandes foguetes teleguiados que explodem em mais minifoguetes teleguiados quando há inimigos por perto");

                    //Flamethrowers
                    //Pre-Hardmode
                    Calamity.GetItem("DragoonDrizzlefish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-garoa do Dragão");
                    Calamity.GetItem("DragoonDrizzlefish").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara bolas de fogo espalhadas imprecisamente\nO saco de enxofre parece conter combustível\nA vingança é um prato que se serve queimando");

                    Calamity.GetItem("OverloadedBlaster").DisplayName.AddTranslation(GameCulture.Portuguese, "Detonador Sobrecarregado");
                    Calamity.GetItem("OverloadedBlaster").Tooltip.AddTranslation(GameCulture.Portuguese, "33% de chance de não consumir gel\nDispara uma grande quantidade de geleia saltitante em várias direções");

                    Calamity.GetItem("Shadethrower").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança-sombras");
                    Calamity.GetItem("Shadethrower").Tooltip.AddTranslation(GameCulture.Portuguese, "66% de chance de não consumir gel");

                    Calamity.GetItem("SparkSpreader").DisplayName.AddTranslation(GameCulture.Portuguese, "Espalha-faíscas");
                    Calamity.GetItem("SparkSpreader").Tooltip.AddTranslation(GameCulture.Portuguese, "70% de chance de não consumir gel");

                    //Hardmode

                    Calamity.GetItem("AuroraBlazer").DisplayName.AddTranslation(GameCulture.Portuguese, "Incendiário de Aurora");
                    Calamity.GetItem("AuroraBlazer").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança chamas astrais que viajam em padrões em forma de estrela\n60% de chance de não consumir gel");

                    Calamity.GetItem("MepheticSprayer").DisplayName.AddTranslation(GameCulture.Portuguese, "Espalhador da Praga");

                    Calamity.GetItem("BrimstoneFlameblaster").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança-chamas de Enxofre");
                    Calamity.GetItem("BrimstoneFlameblaster").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara bolas de fogo de enxofre saltitantes");

                    Calamity.GetItem("TheEmpyrean").DisplayName.AddTranslation(GameCulture.Portuguese, "Fole de Deus");
                    Calamity.GetItem("TheEmpyrean").Tooltip.AddTranslation(GameCulture.Portuguese, "70% de chance de não consumir gel");

                    Calamity.GetItem("BrimstoneFlamesprayer").DisplayName.AddTranslation(GameCulture.Portuguese, "Sopro do Caos");

                    Calamity.GetItem("Meowthrower").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança-gatos");
                    Calamity.GetItem("Meowthrower").Tooltip.AddTranslation(GameCulture.Portuguese, "50% de chance de não consumir gel\nDispara chamas azuis e rosas que emitem miaus ao atingir o inimigo");

                    Calamity.GetItem("TerraFlameburster").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança-chamas da Terra");
                    Calamity.GetItem("TerraFlameburster").Tooltip.AddTranslation(GameCulture.Portuguese, "80% de chance de não consumir gel");

                    Calamity.GetItem("BloodBoiler").DisplayName.AddTranslation(GameCulture.Portuguese, "Caldeira de Sangue");
                    Calamity.GetItem("BloodBoiler").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um fluxo de fogo de sangue que rouba vida\nUsa sua vida como munição\n25% de chance de não consumir munição");

                    Calamity.GetItem("CleansingBlaze").DisplayName.AddTranslation(GameCulture.Portuguese, "Chamas da Purificação");
                    Calamity.GetItem("CleansingBlaze").Tooltip.AddTranslation(GameCulture.Portuguese, "90% de chance de não consumir gel");

                    Calamity.GetItem("ElementalEruption").DisplayName.AddTranslation(GameCulture.Portuguese, "Erupção Elemental");
                    Calamity.GetItem("ElementalEruption").Tooltip.AddTranslation(GameCulture.Portuguese, "90% de chance de não consumir gel\nDispara chamas arco-íris em várias direções");

                    Calamity.GetItem("HalleysInferno").DisplayName.AddTranslation(GameCulture.Portuguese, "Inferno de Halley");
                    Calamity.GetItem("HalleysInferno").Tooltip.AddTranslation(GameCulture.Portuguese, "Halley chegou antes do esperado\nDispara um cometa flamejante\n50% de chance de não consumir gel\nClique com o botão direito para afastar");

                    Calamity.GetItem("Photoviscerator").DisplayName.AddTranslation(GameCulture.Portuguese, "Fotoviscerador");
                    Calamity.GetItem("Photoviscerator").Tooltip.AddTranslation(GameCulture.Portuguese, "90% de chance de não consumir gel\nDispara um fluxo de chamas exo e luz que explodem em faíscas teleguiadas\nClique com o botão direito para disparar chamas teleguiadas que grudam nos inimigos e os incineram");

                    Calamity.GetItem("PristineFury").DisplayName.AddTranslation(GameCulture.Portuguese, "Fúria Pura");
                    Calamity.GetItem("PristineFury").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma hélice intensa de chamas que explodem em uma coluna de fogo\nClique com o botão direito para disparar uma nuvem de chamas persistentes de curto alcance");

                    //Others
                    //Pre-Hardmode

                    Calamity.GetItem("AquashardShotgun").DisplayName.AddTranslation(GameCulture.Portuguese, "Espingarda do Fragmento d'água");
                    Calamity.GetItem("AquashardShotgun").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em fragmentos d'água que se dividem ao atingir um inimigo");

                    Calamity.GetItem("CoralCannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão de Corais");
                    Calamity.GetItem("CoralCannon").Tooltip.AddTranslation(GameCulture.Portuguese, "Tem uma chance de disparar um coral grande que atordoa os inimigos");

                    Calamity.GetItem("FirestormCannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão da Tempestade de Fogo");
                    Calamity.GetItem("FirestormCannon").Tooltip.AddTranslation(GameCulture.Portuguese, "70% de chance de não consumir munição\nClique com o botão direito para disparar sinalizadores em várias direções");

                    Calamity.GetItem("FlurrystormCannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão da Nevasca");
                    Calamity.GetItem("FlurrystormCannon").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma corrente de bolas de neve que fica mais rápida com o tempo\nTem uma chance de também atirar um pedaço de gelo que se despedaça em fragmentos\n50% de chance de não consumir bolas de neve");

                    Calamity.GetItem("Pumpler").DisplayName.AddTranslation(GameCulture.Portuguese, "Atirabóbora");
                    Calamity.GetItem("Pumpler").Tooltip.AddTranslation(GameCulture.Portuguese, "33% de chance de não consumir munição\nClique com o botão direito para disparar uma abóbora explosiva");

                    Calamity.GetItem("StormSurge").DisplayName.AddTranslation(GameCulture.Portuguese, "Onda da Tempestade");
                    Calamity.GetItem("StormSurge").Tooltip.AddTranslation(GameCulture.Portuguese, "Tema a tempestade\nNão consume munição");

                    Calamity.GetItem("Taser").DisplayName.AddTranslation(GameCulture.Portuguese, "Taser");
                    Calamity.GetItem("Taser").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma arma elétrica simples e lenta, destinada apenas a guardas de baixo escalão\nDispara um gancho que se prende nos inimigos e os eletrocuta antes de retornar");

                    //Hardmode

                    Calamity.GetItem("BarracudaGun").DisplayName.AddTranslation(GameCulture.Portuguese, "Arma de Barracudas");
                    Calamity.GetItem("BarracudaGun").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara duas barracudas que grudam nos inimigos");

                    Calamity.GetItem("ChargedDartRifle").DisplayName.AddTranslation(GameCulture.Portuguese, "Lança-dardos Carregado");
                    Calamity.GetItem("ChargedDartRifle").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara dardos e uma explosão de energia que se divide em várias direções, estilo espingarda\nClique com o botão direito para disparar uma explosão de energia saltitante mais poderosa");

                    Calamity.GetItem("Dualpoon").DisplayName.AddTranslation(GameCulture.Portuguese, "Arpão Duplo");
                    Calamity.GetItem("Dualpoon").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança dois arpões");

                    Calamity.GetItem("FlakKraken").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão do Kraken");
                    Calamity.GetItem("FlakKraken").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um retículo de energia que se torna mais poderoso ao longo do tempo");

                    Calamity.GetItem("FlakToxicannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão Tóxico");
                    Calamity.GetItem("FlakToxicannon").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara tiros inclinados na direção do cursor\nSó pode ser disparado em uma direção de cone acima do jogador\nRequer QI alto");

                    Calamity.GetItem("GaussRifle").DisplayName.AddTranslation(GameCulture.Portuguese, "Rifle de Gauss");
                    Calamity.GetItem("GaussRifle").Tooltip.AddTranslation(GameCulture.Portuguese, "Uma arma grande e lenta, a força concussiva de seus projéteis faz bem em eliminar grandes grupos\nDispara uma explosão devastadora de alta velocidade com recuo absurdo");

                    Calamity.GetItem("Leviatitan").DisplayName.AddTranslation(GameCulture.Portuguese, "Leviatitã");
                    Calamity.GetItem("Leviatitan").Tooltip.AddTranslation(GameCulture.Portuguese, "Converte bolas de mosquete em rajadas de água tóxicas e normais");

                    Calamity.GetItem("MatterModulator").DisplayName.AddTranslation(GameCulture.Portuguese, "Modulador de Matéria");
                    Calamity.GetItem("MatterModulator").Tooltip.AddTranslation(GameCulture.Portuguese, "Usando massa extra obtida da colisão com materiais sólidos, ele causa dano extra\nDispara uma explosão de matéria instável que causa dano significativo após atingir uma peça\nAntes de atingir uma peça, a matéria perfura infinitamente, mas causa pouco dano");

                    Calamity.GetItem("NullificationRifle").DisplayName.AddTranslation(GameCulture.Portuguese, "Pistola da Anulação");
                    Calamity.GetItem("NullificationRifle").Tooltip.AddTranslation(GameCulture.Portuguese, "É anulável ou não? Vamos descobrir!\nDispara um projétil nulo rápido que distorce as estatísticas de NPCs");

                    Calamity.GetItem("PolarisParrotfish").DisplayName.AddTranslation(GameCulture.Portuguese, "Peixe-papagaio Polar");
                    Calamity.GetItem("PolarisParrotfish").Tooltip.AddTranslation(GameCulture.Portuguese, "Ele carrega a marca da Estrela do Norte\nProjéteis atingidos concedem efeitos à arma e o jogador\nOs efeitos são removidos ao ser atingido");

                    Calamity.GetItem("SandstormGun").DisplayName.AddTranslation(GameCulture.Portuguese, "Tempestade de Areia");
                    Calamity.GetItem("SandstormGun").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara projéteis de areia que explodem e retardam os inimigos no acerto\n50% de chance de não consumir areia");

                    Calamity.GetItem("SeasSearing").DisplayName.AddTranslation(GameCulture.Portuguese, "Abrasador dos Mares");
                    Calamity.GetItem("SeasSearing").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma série de bolhas invocando uma chuva de bolhas no acerto\nClique com o botão direito para disparar um jato d'água maior e mais lento que invoca uma tromba d'água");

                    Calamity.GetItem("SpectralstormCannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão da Tempestade Espectral");
                    Calamity.GetItem("SpectralstormCannon").Tooltip.AddTranslation(GameCulture.Portuguese, "70% de chance de não consumir sinalizadores\nDispara uma tempestade de almas e sinalizadores perdidos");

                    Calamity.GetItem("PaintballBlaster").DisplayName.AddTranslation(GameCulture.Portuguese, "Detonador Veloz");
                    Calamity.GetItem("PaintballBlaster").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma série de tiros de tinta");

                    Calamity.GetItem("StarCannonEX").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão de Estrelas X");
                    Calamity.GetItem("StarCannonEX").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma mistura de estrelas normais, da fúria e astrais");

                    Calamity.GetItem("StarSputter").DisplayName.AddTranslation(GameCulture.Portuguese, "Crepitar Estelar");
                    Calamity.GetItem("StarSputter").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma cadeira de cometas\nDispara um cometa maior e mais forte a cada 4 tiros\nOlhe para as estrelas para uma galáxia muito, muito distante");

                    Calamity.GetItem("StellarCannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão Estelar");
                    Calamity.GetItem("StellarCannon").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança um cristal astral explosivo");

                    Calamity.GetItem("Triploon").DisplayName.AddTranslation(GameCulture.Portuguese, "Arpão Triplo");
                    Calamity.GetItem("Triploon").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança três arpões");

                    //Post-Mood Lord

                    Calamity.GetItem("AethersWhisper").DisplayName.AddTranslation(GameCulture.Portuguese, "Sussurro do Éter");
                    Calamity.GetItem("AethersWhisper").Tooltip.AddTranslation(GameCulture.Portuguese, "Inflige chama das sombras de longa duração e se divide ao atingir peças\nOs projéteis ganham dano à medida que viajam\nClique com o botão direito para mudar de dano por magia para dano por ataque à distância\nO clique com o botão direito não consome mana");

                    Calamity.GetItem("ElementalBlaster").DisplayName.AddTranslation(GameCulture.Portuguese, "Detonador Elemental");
                    Calamity.GetItem("ElementalBlaster").Tooltip.AddTranslation(GameCulture.Portuguese, "Não consume munição\nDispara uma tempestade de explosões arco-íris");

                    Calamity.GetItem("LaserRifle").DisplayName.AddTranslation(GameCulture.Portuguese, "Rifle à Laser Pesado");
                    Calamity.GetItem("LaserRifle").Tooltip.AddTranslation(GameCulture.Portuguese, "Arma laser usada por unidades de infantaria pesada no exército de Yharim");

                    Calamity.GetItem("MolecularManipulator").DisplayName.AddTranslation(GameCulture.Portuguese, "Manipulador Molecular");
                    Calamity.GetItem("MolecularManipulator").Tooltip.AddTranslation(GameCulture.Portuguese, "É anulável ou não? Vamos descobrir!\nDispara um projétil nulo rápido que distorce as estatísticas de NPCs");

                    Calamity.GetItem("Norfleet").DisplayName.AddTranslation(GameCulture.Portuguese, "Norfleet");
                    Calamity.GetItem("Norfleet").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispare tudo!");

                    Calamity.GetItem("PrismaticBreaker").DisplayName.AddTranslation(GameCulture.Portuguese, "Destruidor Prismático");
                    Calamity.GetItem("PrismaticBreaker").Tooltip.AddTranslation(GameCulture.Portuguese, "Parece pertencer a uma certa garota mágica. Irradia com intensa energia cósmica\nDispare para carregar um poderoso laser arco-íris\nClique com o botão direito para balançar a espada e disparar ondas coloridas de arco-íris\nA espada é reforçada por dano por ataque físico e à distância");

                    Calamity.GetItem("PulseRifle").DisplayName.AddTranslation(GameCulture.Portuguese, "Rifle de Pulso");
                    Calamity.GetItem("PulseRifle").Tooltip.AddTranslation(GameCulture.Portuguese, "O antigo rifle de pulso de Draedon, usado em emergências para criações que se revoltaram contra ele \nQuando o pulso atinge um alvo, ele se curva para outro alvo próximo");

                    Calamity.GetItem("SepticSkewer").DisplayName.AddTranslation(GameCulture.Portuguese, "Espeto Séptico");
                    Calamity.GetItem("SepticSkewer").Tooltip.AddTranslation(GameCulture.Portuguese, "Lança um arpão pontiagudo infestado de toxinas\nLibera bactérias ao retornar para o jogador");

                    Calamity.GetItem("Starfleet").DisplayName.AddTranslation(GameCulture.Portuguese, "Frota Estelar");
                    Calamity.GetItem("Starfleet").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara explosões de plasma em várias direções");

                    Calamity.GetItem("StarfleetMK2").DisplayName.AddTranslation(GameCulture.Portuguese, "Armada Estelar");
                    Calamity.GetItem("StarfleetMK2").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara uma enxurrada de estrelas e explosões de plasma");

                    Calamity.GetItem("SulphuricAcidCannon").DisplayName.AddTranslation(GameCulture.Portuguese, "Canhão de Ácido Sulfúrico");
                    Calamity.GetItem("SulphuricAcidCannon").Tooltip.AddTranslation(GameCulture.Portuguese, "Dispara um tiro acídico que gruda nos inimigos e os dissolve");

                    foreach (string[] loc in localizations)
                    {
                        ModTranslation text = Calamity.CreateTranslation(loc[0]);
                        text.AddTranslation(GameCulture.English, loc[1]);
                        text.AddTranslation(GameCulture.Portuguese, loc[2]);
                        text.SetDefault(loc[1]);
                        ModContent.GetInstance<CalamityMod.CalamityMod>().AddTranslation(text);
                    }
                }
            }
        }
    }
}
