# pd2lootfilter
TheIrateSeagoer's Project Diablo 2 Loot Filter

This filter is setup to cut down on a lot of the noise that occurs with drops during general gameplay, and increases quality of life while farming something like cows. As well as preserves the Sale color while in the trade window.

###
Upcoming changes include:
- Add prominent marking for early runeword bases for the upcoming season 2, until then 2+ socket items will show up past level 30
- Add things for late game shopping.


# Preview
![Vendor](https://i.imgur.com/6jAOh85.png)
![Crafting](https://i.imgur.com/DPjyl5D.png)
![Recipe](https://i.imgur.com/x9FOL7k.png)
![Items](https://i.imgur.com/3yCaMdV.png)
![Runewords](https://cdn.discordapp.com/attachments/771820538502971402/816863404601901096/unknown.png)
![Runeword](https://i.imgur.com/Buge5Yu.png)


# Quest Items
The only major change to quest items was including Wirt's Leg as a quest item in terms of style. It behaves like a quest item but drops with regular item qualities, so it gets specified within the quest items to prevent conflicts with other filter lines.

# Items
Common items include anything that isn't an equippable item.

### Gold 
Gold is setup to progressively hide piles as your level increases.
- Level 1 hides piles than than 100
- Level 10 hides piles less than 500
- Level 20 hides piles less than 1000
- Level 40 hides piles less than 2000
- Level 80 hides piles than than 4000

### Arrows and Bolts
These are hidden once the character reaches level 5.

### Potions
Potions all have their names changed to remove "Potion" in the majority of cases to reduce clutter. Mana Potions are prefixed with a blue @, Health Potions are prefixed with a red @, and Rejuv portions are prefixed with a Purple @
- Level 20 hides Stamina, Fulminating, Exploding, Oil, Strangling, Choking, Rancid 
- Level 30 hides Minor and Lesser for Health/Mana

### Scrolls/Tomes
Tomes retain their names, scrolls are renamed to "Town" and "Ident" and have white names.

### Gems
Chipped, Flawed, and regular gems have their color changed to dark green. Flawless and Perfect have their color changed to orange.
- Nightmare hides Chipped and Flawed
### Runes
Runes are setup so that the runes that spawn in normal retain their orange text, nightmare runes have their text changed to red, and hell runes have their text changed to purple.

# Gear
This is the largest source of noise while playing the game.
- Level 1 hides Inferior Quality Items, Normal Items with 1 socket, Superior Items with 0% Enchanced Damage/Defense
- Level 30 hides Normal Quality Items and Superior Items with no enchanced Defense/Damage

## Enchancements
  - All Items have their Arreat Summit Values as a description line. (This is setup to be dynamic, so you know exactly how many sockets on Larzuk you would receive at the maximum)
  - Ethereal Items are prefixed with [Eth]
  - Socketed Items are prefixed with [2os]
  - Ethereal+Socketed Items are prefixed with [Eth,3os]
  - Superior Quality Items are prefixed with [15/15/3] for weapons and [15/15] for armor
  - Normal/Magic/Rare Items will be suffixed with a MAX denoting it's highest defense value roll
  - For every $5000 of vendor value the item is suffixed with a $ (Example a 15,358 value item will be suffixed with $$$)
  - Magic / Rare that rolled sockets have a "NOT A RUNEWORD CANDIATE" warning attached" for the sleepy gamers
  - Upgrade Recipies for Rare/Unique Armors

### Unique Items
All unique items have notifications enabled by default.
### Set Items
All set items have notifications enabled by default.
