# CalamityModPTBR
Este mod fornece uma tradução não-oficial do Calamity Mod para o Português Brasileiro.

O mod está disponível no Navegador de Mods. Se você deseja baixar o arquivo por aqui, acesse a aba Releases e baixe a versão mais recente.

# Contribuindo para a tradução
Para contribuir com a tradução completa do mod do Calamity Mod, você deve primeiro fazer um fork deste repositório. Após criar o seu fork, verifique a lista de afazeres para o mod:

- [ ] Atualizar todo o conteúdo para estar de acordo com a atualização 1.5 do Calamity Mod (prioridade alta)
- [ ] Traduzir o resto das armas
- [ ] Traduzir efeitos e efeitos negativos
- [ ] Traduzir os projéteis

Escolha um destes e, em seguida, traduza-os deles em seu fork. Para adicionar a tradução de algo, basta escrever

- Para itens: ```Calamity.GetItem("<ID interno do item>").DisplayName.AddTranslation(GameCulture.Portuguese, "<tradução do item>");```
- Para NPCs: ```Calamity.GetNPC("<ID interno do NPC>").DisplayName.AddTranslation(GameCulture.Portuguese, "<tradução do NPC>");```
- Para efeitos e efeitos negativos: ```Calamity.GetBuff("<ID interno do efeito>").DisplayName.AddTranslation(GameCulture.Portuguese, "<tradução do efeito>");```
- Para projéteis: ```Calamity.GetProjectile("<ID interno do efeito>").DisplayName.AddTranslation(GameCulture.Portuguese, "<tradução do projétil>");```

no arquivo CalamityModPTBR.cs. Não se esqueça de organizar os itens pela ordem da wiki!

# Descobrindo o ID interno de um item

Para descobrir o ID interno de um item no tModLoader, pode-se fazer uso de vários mods. Aqui estão alguns exemplos:
- What Mod Is This From? (WMITF) - Permite que o ID interno do item seja exibido no lugar do nome do mod se a tecla "Display Technical Names" for pressionada.
- Localizer - Extrai o arquivo de localização do mod, fornecendo IDs internos de itens, NPCs, efeitos negativos e projéteis, seus nomes e suas descrições.

# Fazendo um pull request e um merge

Após editar tudo o que for necessário, você deve fazer um pull request. Com o seu pull request feito, pode levar um tempo para que a sua tradução seja analizada e adicionada no mod. Agradeço pela ajuda!

# Créditos

- Master Dong/Skyshadow - Criador do mod "Calamity mod Traduccion Español", me ajudou com código do mod.
- Tolsyak - Criador do mod "Calamity Mod French Translation", possui o seu mod de tradução como código aberto no Github.
