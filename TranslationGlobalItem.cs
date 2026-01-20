using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.Localization;

namespace CalamityModPTBR
{
    public class TranslationGlobalItem : GlobalItem
    {
        // Para strings hardcoded (temporário até os devs do calamity arrumarem)
        private static readonly Dictionary<string, string> CalamityTranslations =
            new()
            {
                // deletar no próximo update
                { "Does extra damage to enemies shot at point-blank range", "Causa dano adicional a inimigos atingidos à queima-roupa" },

                // Tags
                { "Donor Item", "Item de Doador" },
                { "Developer Item", "Item de Desenvolvedor" },

                // Vanilla wings
                { "Horizontal speed:", "Velocidade horizontal:" },
                { "Acceleration multiplier:", "Multiplicador de aceleração:" },
                { "Flight time:", "Tempo de voo:" },
                { "Bad vertical speed", "Velocidade vertical ruim" },
                { "Average vertical speed", "Velocidade vertical mediana" },
                { "Good vertical speed", "Velocidade vertical boa" },
                { "Great vertical speed", "Velocidade vertical ótima" },
                { "Excellent vertical speed", "Velocidade vertical excelente" },

                // Vanilla hooks
                { "Reach:", "Alcance:" },
                { " tiles", " peças" },
                { "Launch Velocity:", "Velocidade de disparo:" },
                { "Reelback Velocity:", "Velocidade de retorno:" },
                { "Pull Velocity:", "Velocidade de tração:" },

                // Boss summons
                { "when used during nighttime", "quando usado durante a noite" },
                { "when used in the Jungle", "quando usado na Selva" },
                { "when used in the Crimson", "quando usado no Carmim" },
                { "when used in the Snow or Ice biome", "quando usado no bioma de Neve ou de Gelo" },
                { "when used in the Hallow", "quando usado no Sagrado" },
                { "when used in the Corruption", "quando usado na Corrupção" },

                { "While equipped, summons Skeletron when the Clothier is killed during nighttime", "Enquanto equipado, matar o Alfaiate de noite invocará o Esqueletron" },
                { "Summons the Wall of Flesh if thrown into lava in the underworld while the Guide is alive", "Invoca a Parede de Carne se arremessado na lava no submundo enquanto o Guia está vivo" },
                { "to summon the Golem", "para invocar o Golem" },
                { "Summons Duke Fishron if used as bait in the Ocean", "Invoca o Duque Peixe-Dragão se for usado como isca no Oceano" },

                { "Enrages during the day", "Fica enfurecido durante o dia" },
                { "Enrages outside the Underground Jungle", "Fica enfurecida fora da Selva Subterrânea" },
                { "Enrages outside the Underground Crimson", "Fica enfurecido fora do Subterrâneo Carmim" },
                { "Enrages outside the Ocean", "Fica enfurecido fora do Oceano" },
                { "Enrages outside the Underground Corruption", "Fica enfurecido fora do Subterrâneo Corrompido" },
                { "Enrages outside the Jungle Temple", "Fica enfurecido fora do Templo da Selva" },
                { "Not consumable", "Não consumível" },

                // Modifiers
                { "% damage reduction", "% de redução dos danos" },

                // Misc items
                { "Demon Altars now drop Souls of Night instead of generating ores when destroyed", "Altares Demoníacos agora deixam Almas da Noite em vez de gerar minérios ao serem destruídos" },
                { "Hardmode ores now generate after defeating Mechanical Bosses for the first time", "Minérios do Modo Difícil agora são gerados após derrotar um chefe mecânico pela primeira vez" },
                { "Its fishing line will never break", "Sua linha de pesca nunca vai quebrar" },
                { "Life regen is increased by 0.5 HP/s when near a campfire", "A regeneração de vida é aumentada em 0,5 de vida por segundo enquanto estiver próximo de uma fogueira"},
                { "Teleportation is disabled while Chaos State is active", "O teletransporte é desativado enquanto o Estado do Caos está em ação"},
                { "Once placed you can right click the crystal to skip waves or increase the spawn rate of the invaders", "Ao ser posicionado, você pode clicar com o botão direito no cristal para pular ondas ou aumentar a taxa de surgimento dos invasores"},
                { "Throws a mixture of slime and sparkling crystals", "Lança uma mistura de geleia e cristais brilhantes"},

                // Wings
                { "Decreases enemy defense by 25% on hit", "Diminui a defesa do inimigo em 25% ao atingí-lo" },
                { "This effect lasts for 10 seconds", "Este efeito dura 10 segundos" },
                { "max life, +10 defense and", "de vida máxima, +10 de defesa e" },
                { "max mana, 5% decreased mana usage,", "de vida máxima, 5% de redução no custo de mana," },
                { "5% increased magic damage and magic critical strike chance", "5% de aumento nos danos por magia e na chance de acerto crítico mágico" },
                { "With Harpy Ring or Angel Treads equipped, most attacks sometimes launch feathers", "Com o Anel de Harpia ou Passos Angelicais equipados, a maioria dos ataques lançam penas periodicamente" },
                { "Halves flight time when taking a hit", "Reduz o tempo de voo na metade ao ser atingido"},
                { "% increased melee damage and critical strike chance", "% de aumento nos danos por ataque físico e na chance de acerto crítico físico" },
                { "% increased melee and ranged damage", "% de aumento no dano por ataque físico e à distância" },
                { "and 1% increased melee and ranged critical strike chance", "e 1% de aumento na chance de acerto crítico físico e à distância" },
                { "while wearing the Frost Armor", "enquanto veste a Armadura Congelada" },
                { "+10 defense and 5% increased damage reduction while wearing the Spectre Hood set", "+10 de defesa e 5% de aumento na redução dos danos enquanto veste o conjunto do Capuz Espectral" },
                { "5% increased magic damage and critical strike chance while wearing the Spectre Mask set", "5% de aumento nos danos por magia e na chance de acerto crítico mágico enquanto veste o conjunto da Máscara Espectral" },
                { "Ornaments rain down as you fly", "Faz chover ornamentos conforme você voa" },
                { "% increased weapon-type damage while wearing the Shroomite Armor", "% de aumento no dano por tipo de arma enquanto veste a Armadura de Cogumelita" },
                { "The weapon type boosted matches which Shroomite helmet is worn", "O tipo de arma reforçado segue o do capacete de Cogumelita equipado" },
                { "+10 defense and 5% increased damage reduction while wearing the Beetle Shell set", "+10 de defesa e 5% de aumento na redução dos danos enquanto veste o conjunto de Concha de Besouro" },
                { "5% increased melee damage and critical strike chance while wearing the Beetle Scale Mail set", "5% de aumento nos danos por ataque físico e na chance de acerto crítico físico enquanto veste o conjunto de Armadura de Malha de Besouro" },
                { "+5 defense and 5% increased damage", "+5 de defesa e 5% de aumento nos danos" },
                { "Increased minion knockback and 5% increased minion damage while wearing the Spooky Armor", "Os lacaios causam mais recuo e têm 5% de aumento no dano enquanto veste a Armadura Assustadora" },
                { "At night or during an eclipse, you will gain the following boosts:", "De noite ou durante um eclipse, você receberá os seguintes efeitos:"},
                { "7% increased damage and 3% increased critical strike chance", "7% de aumento nos danos e 3% de aumento na chance de acerto crítico"},
                { "Permanently gives the Honey buff", "Concede o efeito do Mel permanentemente"},
                { "+8 defense, 10% increased movement speed", "+8 de defesa, 10% de aumento na velocidade dos movimentos"},
                { "4% increased damage, and 2% increased critical strike chance", "4% de aumento nos danos e 2% de aumento na chance de acerto crítico"},
                { "+5 defense, 5% increased damage reduction,", "+5 de defesa, 5% de aumento na redução dos danos"},
                { "and permanent Dryad's Blessing while wearing the Tiki Armor", "e concede o efeito da Bênção da Dríade enquanto veste a Armadura de Tiki"},
                { "Gills effect and you can move freely through liquids", "Concede o efeito de Guelras e você pode se mover livremente nos líquidos"},
                { "You fall faster while submerged in liquid", "Você cai mais rápido quando está submerso em líquidos"},
                { "7% increased melee damage and 3% increased melee critical strike chance", "7% de aumento nos danos por ataque físico e 3% de aumento na chance de acerto crítico físico"},
                { "while wearing the Solar Flare Armor", "enquanto veste a Armadura das Chamas do Sol"},
                { "3% increased ranged damage and 7% increased ranged critical strike chance", "3% de aumento nos danos por ataque à distância e 7% de aumento na chance de acerto crítico a distância"},
                { "while wearing the Vortex Armor", "enquanto veste a Armadura do Vórtice"},
                { "+20 max mana, 5% increased magic damage and critical strike chance,", "+20 de mana máxima, 5% de aumento nos danos por magia e na chance de acerto crítico mágico"},
                { "and 5% decreased mana usage while wearing the Nebula Armor", "e 5% de redução no custo de mana enquanto veste a Armadura de Nébula"},
                { "10% increased minion damage while wearing the Stardust Armor", "10% de aumento nos danos por invocação enquanto veste a Armadura de Pó das Estrelas"},
                
                // Armor
                { "% increased minion and ranged damage", "% de aumento no dano por invocação e por ataque à distância" },
                { "and 20% chance to not consume ammo", "e 20% de chance de economizar munição" },
                { "% increased minion and melee damage", "% de aumento no dano por invocação e por ataque físico" },
                { "% increased melee and minion damage", "% de aumento no dano por invocação e por ataque físico" },
                { "% increased minion damage and melee critical strike chance", "% de aumento no dano por invocação e na chance de acerto crítico físico" },
                { "% increased minion damage and melee speed", "% de aumento no dano por invocação e na velocidade de ataque físico" },
                { "% increased minion damage and magic critical strike chance", "% de aumento no dano por invocação e na chance de acerto crítico mágico" },
                { "% increased minion damage and grants +", "% de aumento nos danos por invocação e concede regeneração de +" },
                { "% chance to not consume ammo", "% de chance de economia de munição" },
                { "Increases your max number of sentries by 1 and increases melee attack speed by", "Aumenta o número máximo de sentinelas em 1 e a velocidade de ataque físico em" },
                { "Increases your max number of sentries by 1 and grants +", "Aumenta o número máximo de sentinelas em 1 e concede regeneração de +" },
                { "Increases your max number of sentries by 2", "Aumenta o número máximo de sentinelas em 2" },

                // Weapons
                { "Heals you on hit", "Cura você ao atingir o inimigo" },
                { "Slows enemies on hit", "Desacelera os inimigos ao atingí-los"},
                { "Ignores 50% of enemy defense", "Ignora 50% da defesa do inimigo"},
                { "Ignores 100% of enemy defense", "Ignora 100% da defesa do inimigo"},
                { "Increases natural life regen on hit", "Aumenta a regeneração de vida natural ao atingir um inimigo"},
                { "Increases how frequently the Orichalcum set bonus triggers on hit", "Aumenta a frequência de ativação do bônus de conjunto de oricalco ao atingir o inimigo"},
                { "Deals increased damage to enemies with high knockback resistance", "Causa mais dano a inimigos com alta resistência a recuos"},
                { "Decreases enemy contact damage by 10% on hit", "Reduz o dano de contato do inimigo em 10% ao atingí-lo"},
                { "Slimed enemies take more damage from fire-based debuffs", "Inimigos cobertos de geleia sofrem mais dano de efeitos negativos de fogo"},
                { "This grants +1.5 HP/s life regen and accelerates natural life regen", "Isto concede regeneração de +1,5 de vida por segundo e acelera a regeneração natural de vida"},
                { "Life drain stacks based on the number of enemies being hit", "O roubo de vida é fortalecido de acordo com a quantidade de inimigos sendo atingidos"},
                { "Defeating enemies temporarily grants +3 HP/s life regen", "Derrotar inimigos temporariamente concederá regeneração de +3 de vida por segundo"},
                { "Inflicts Whispering Death on hit", "Inflige Morte Sussurante ao atingir o inimigo"},

                // Potions
                { "Slows falling speed", "Diminui a velocidade da queda"},
                { "Disables all airborne flight recovery", "Desativa todo tipo de regeneração de voo no ar"},
                { "20% increased arrow speed and 5% increased arrow damage", "20% de aumento na velocidade das flechas e 5% de aumento no dano das flechas"},
                { "Increases melee damage by 10% and reduces defense by 5%", "Aumenta o dano por ataque físico em 10% e reduz a defesa em 5%"},
                { "Counts as an alcohol for Alcohol Poisoning", "Conta como um álcool para o Envenenamento por Álcool"},
                { "Drinking more than 3 different alcohols might not end well with your liver", "Beber mais de 3 bebidas alcoólicas diferentes pode não fazer bem para seu fígado"},

                // Accessories
                { "Puts a shell around the owner when below 50% life that reduces damage by 15%", "Coloca uma barreira que reduz o dano sofrido em 15% ao redor do usuário quando estiver abaixo de 50% de vida" },
                { "Reduces the damage of the Nightwither and Holy Flames debuffs", "Reduz o dano causado pelos efeitos negativos Definhação Noctívora e Chamas Sagradas" },
                { "Reduces the damage of the Nightwither debuff", "Reduz o dano causado pelo efeito negativo Definhação Noctívora" },
                { "Reduces the damage of the Holy Flames debuff", "Reduz o dano causado pelo efeito negativo Chamas Sagradas" },
                { "Provides a regeneration boost while wearing the Snow armor", "Fornece um aumento na regeneração de vida enquanto veste a Armadura de Neve" },
                { "including Mighty Wind", "incluindo Vento Poderoso"},
                { "Increases arrow damage by 5% and greatly increases arrow speed", "Aumenta o dano das flechas em 5%"}, // Info. sobre velocidade removida para evitar repetição
                { "Increases arrow damage by 7% and greatly increases arrow speed", "Aumenta o dano das flechas em 7%"},
                { "and all arrows inflict Hellfire", "e todas as flechas infligem Fogo do Inferno"},
                { "does not stack with downgrades", "não acumula com versões anteriores"},
                { "and reduces the cooldown of healing potions by 25%", "e reduz o tempo de recarga das poções de cura em 25%"},
                { "Grants the ability to dodge attacks", "Dá uma chance de se esquivar de ataques"},
                { "Attacks that deal less than 5% of your max life in damage will not be dodged", "Ataques que causarem menos de 5% de sua vida máxima em dano não serão esquivados"},
                { "The dodge has a cooldown that ranges between 15 and 90 seconds depending on the dodged attack's damage", "A esquiva tem um tempo de recarga de entre 15 a 90 segundos dependendo do dano causado pelo ataque esquivado"},
                { "The cooldown is shared with all other dodges and reflects", "O tempo de recarga é compartilhado entre todos os desvios e reflexões"},
                { "Increase view range for guns", "Aumenta o alcance de visualização para armas"},
                { "Right click to zoom out", "Clique com o botão direito para afastar a visão"},
                { "to zoom out", "para afastar a visão"},
                { "The scope effect can be toggled with visibility", "O efeito da luneta pode ser alternado com a visiblidade"},
                { "7% increased ranged damage and critical strike chance", "7% de aumento nos danos por ataque à distância e na chance de acerto crítico à distância"},
                { "Allows the use of two yoyos at once", "Permite o uso de dois ioiôs ao mesmo tempo"},
                { "Secondary yoyos will do 50% less damage", "Os ioiôs secundários causarão a metade do dano"},
                { "Fairies can spawn at any time on the surface and spawn far more frequently", "Fadas podem surgir a qualquer momento na superfície e surgem com mais frequência"},
                { "Nearby fairies grant +2 HP/s life regen, 10 defense and 10% movement speed", "As fadas próximas concedem regeneração de +2 de vida por segundo, 10 de defesa e 10% de aumento na velocidade dos movimentos"},
                { "Fairies are immune to damage and will no longer flee", "Fadas são imunes a danos e não fugirão mais"},
                { "Multiplies all fire-based debuff damage by 1.25", "Multiplica o dano causado por efeitos negativos de fogo em 1,25"},
                { "All attacks light enemies on fire", "Todos os ataques incendeiam os inimigos"},
                { "Never get cold feet again", "Nunca mais seja o pé frio entre seus amigos"},
                { "Multiplies all fire-based debuff damage by 1.5", "Multiplica o dano causado por efeitos negativos de fogo em 1,5"},
                { "All attacks inflict Hellfire", "Todos os ataques infligem Fogo do Inferno"},
                { "Immunity to the On Fire! debuff", "Imune ao efeito negativo Em chamas!"},
                { "Increases wing flight time by 25%", "Aumenta o tempo de voo em 25%"},
                { "Increases movement and jump speed by 10% and acceleration by 1.1x", "Aumenta a velocidade dos movimentos e dos pulos em 10% e a aceleração em 1,1x"},

                // General
                { "Moderately reduces breath loss in the abyss", "Reduz razoavelmente a perda de fôlego no abismo" },
                { "Greatly reduces breath loss in the abyss", "Reduz bastante a perda de fôlego no abismo"},
                { "Provides a small amount of light in the abyss", "Fornece uma quantidade pequena de luz no abismo"},
                { "Provides a moderate amount of light in the abyss", "Fornece uma quantidade razoável de luz no abismo"},
                { "Provides a large amount of light in the abyss", "Fornece uma quantidade grande de luz no abismo"},
                { "Holding this item grants +", "Segurar este item fornece " },
                { "Grants +", "Concede regeneração de +" },
                { " HP/s life regeneration", " de vida por segundo" },
                { " when placed nearby", " quando posicionado por perto"},
                { " HP/s life regen", " de vida por segundo" },
                { "Increases maximum mana by", "Aumenta a mana máxima em" },
                { "Increases damage reduction by", "Aumenta a redução dos danos em" },
                { "% increased damage and critical strike chance", "% de aumento nos danos e na chance de acerto crítico" },
                { "% increased damage", "% de aumento nos danos" },
                { "% increased critical strike chance", "% de aumento na chance de acerto crítico" },
                { "% increased melee damage", "% de aumento nos danos por ataque físico"},
                { "% increased melee speed", "% de aumento na velocidade do ataque físico"},
                { "% increased magic damage", "% de aumento nos danos por magia"},
                { "% increased magic critical strike chance", "% de aumento na chance de acerto crítico mágico" },
                { "% reduced mana cost", "% de redução no custo de mana"},
                { "% increased movement speed", "% de aumento na velocidade dos movimentos" },
                { "% increased rogue damage", "% de aumento no dano por ataque ladino" },
                { "% increased rogue critical strike chance", "% de aumento na chance de acerto crítico ladino" },
                { "% increased rogue velocity", "% de aumento na velocidade ladina" },
                { "% increased true melee damage", "% de aumento no dano por ataque físico verdadeiro" },
                { "Max life increased by", "A vida máxima é aumentada em" },
                { "max life", "de vida máxima" },
                { "Increase defense by ", "Aumenta a defesa em "},
                { "Can mine Uelibloom Ore", "Pode minerar minério de ueliflor"},
                { "Can mine Scoria Ore located in the Abyss", "Pode minerar minério de escória encontrado no abismo"},
                { "Can mine Demonite, Crimtane, Meteorite, Sea Prisms and Sea Prism Crystals", "Pode minerar demonita, carminita, meteorito, prismas do mar e cristais de prisma do mar"},
                { "or Revengeance", "ou Vingança"},

                // Draedon items
                { "Current Charge:", "Carga atual:" },
                { "You don't have sufficient knowledge to create this yet", "Você ainda não possui conhecimento o suficiente para criar isto" },
                { "The Jungle schematic must be deciphered first", "A esquemática da Selva deve ser decifrada primeiro" },
                { "The Underworld schematic must be deciphered first", "A esquemática do Submundo deve ser decifrada primeiro" },
                { "The Ice biome schematic must be deciphered first", "A esquemática do bioma de Gelo deve ser decifrada primeiro" },
                { "The Planetoid schematic must be deciphered first", "A esquemática do Planetóide deve ser decifrada primeiro" }
            };

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Language.ActiveCulture.Name != "pt-BR")
                return;

            ReplaceTooltips(tooltips, CalamityTranslations);

            if (item.ModItem?.Mod?.Name != "CalamityMod")
                return;

            var config = ModContent.GetInstance<TranslationConfig>();

            if (config.mostrarNomeOriginal)
            {
                foreach (var line in tooltips)
                {
                    if (line.Mod == "Terraria" && line.Name == "ItemName")
                    {
                        string internalName = item.ModItem.Name;
                        line.Text = $"{line.Text} ({internalName})";
                        break;
                    }
                }
            }
        }

        private static void ReplaceTooltips(List<TooltipLine> tooltips, Dictionary<string, string> traducoes)
        {
            foreach (TooltipLine line in tooltips)
            {
                if (line.Mod != "CalamityMod" && line.Mod != "Terraria")
                    continue;

                foreach (var pair in traducoes)
                {
                    if (line.Text.Contains(pair.Key))
                    {
                        line.Text = line.Text.Replace(pair.Key, pair.Value);
                    }
                }
            }
        }

    }
}