using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace CalamityModPTBR
{
    public class TranslationConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("$Mods.CalamityModPTBR.Configs.TranslationConfig.Header")]
        [LabelKey("$Mods.CalamityModPTBR.Configs.TranslationConfig.MostrarNomeOriginal.Label")]
        [TooltipKey("$Mods.CalamityModPTBR.Configs.TranslationConfig.MostrarNomeOriginal.Tooltip")]
        [DefaultValue(false)]
        public bool mostrarNomeOriginal;
    }
}
