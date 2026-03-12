*SUBSTRATA --- Unity Project Folder Structure**

*Asset map & placeholder guide \| Project: Stratus (Unity 6)*

  ----------------------- ----------------------- -----------------------
  ✓ HAVE --- asset exists ⚠ PLACEHOLDER --- needs 📝 CODE ---
                          creation                scripts/configs

  ----------------------- ----------------------- -----------------------

**OVERVIEW --- What You Have**

  -----------------------------------------------------------------------
  📦 **\[FREE\] Mine Tileset \[HAVE\]** *← Mine tiles Depth 1-2 (16p &
  32p) + Robot Walk/Jump anims*

  📦 **Animated Chests \[HAVE\]** *← Treasure chest sprite with
  open/close animation*

  📦 **CozyTunes (Pro) \[HAVE\]** *← 12 music tracks + 8 atmospheric SFX*

  📦 **Effect and FX Pixel All Free \[HAVE\]** *← Pixel VFX frames ---
  sparks, hits, particles (Parts 1--15)*

  📦 **explosion pack 1 \[HAVE\]** *← explosion-a (7 frames) +
  explosion-b (12 frames)*
  -----------------------------------------------------------------------

**You still need (placeholder or download):**

-   Ore/pickup sprites --- Iron, Gold, Stone, Emerald, Sapphire, Dirt

-   Depth 3 hard/blue block tiles --- recolor Mine Tileset tiles blue

-   Special block sprites --- Boomstone, Fuel Regen block

-   Gameplay SFX --- drill hit, ore collect, fuel warning, dynamite,
    shockwave

-   UI art --- fuel bar, resource icons, skill tree nodes, HUD frame

-   Dynamite sprite + fuse animation

**FOLDER STRUCTURE**

*Keep 3rd-party packs untouched. All game content lives under
\_Substrata/ (underscore keeps it sorted to top).*

**Top Level --- Assets/**

  -----------------------------------------------------------------------
  📁 **Assets/**

  📁 **\_Substrata/** *← ALL your game content --- art, audio, scripts,
  prefabs*

  📁 **\[FREE\] Mine Tileset/ \[HAVE\]** *← Leave untouched*

  📁 **Animated Chests/ \[HAVE\]** *← Leave untouched*

  📁 **CozyTunes(Pro)/ \[HAVE\]** *← Leave untouched*

  📁 **Effect and FX Pixel All Free/ \[HAVE\]** *← Leave untouched*

  📁 **explosion pack 1/ \[HAVE\]** *← Leave untouched*
  -----------------------------------------------------------------------

**\_Substrata/Art/Tiles/**

  -----------------------------------------------------------------------
  📁 **Art/**

  📁 **Tiles/**

  📁 Depth1_Dirt/ **\[HAVE\]** *← Mine Tileset → 1_Mine_Tileset_1_16.png
  (slice into tiles)*

  📁 Depth2_Stone/ **\[HAVE\]** *← Mine Tileset → Mine_Tileset_1B_16.png
  (variant)*

  📁 Depth3_Hard/ **\[PLACEHOLDER\]** *← Recolor Depth2 tiles blue in any
  pixel editor (5 min)*

  📁 Backgrounds/ **\[HAVE\]** *← Mine Tileset →
  2_Mine_Tileset_1_Background + 3_Far_Background*

  📁 Special/

  🖼 Boomstone.png **\[PLACEHOLDER\]** *← Dark glowing stone --- paint
  over a Mine tile*

  🖼 Boomstone_Iron.png **\[PLACEHOLDER\]** *← Iron-tinted boomstone
  variant*

  🖼 FuelRegen_Block.png **\[PLACEHOLDER\]** *← Glowing canister --- paint
  over a Mine tile*
  -----------------------------------------------------------------------

**\_Substrata/Art/Ores/ + Player/**

  -----------------------------------------------------------------------
  📁 **Ores/**

  🖼 Ore_Iron.png **\[PLACEHOLDER\]** *← 16px pickup sprite*

  🖼 Ore_Gold.png **\[PLACEHOLDER\]** *← 16px pickup sprite*

  🖼 Ore_Stone.png **\[PLACEHOLDER\]** *← 16px pickup sprite*

  🖼 Ore_Emerald.png **\[PLACEHOLDER\]** *← 16px pickup sprite*

  🖼 Ore_Sapphire.png **\[PLACEHOLDER\]** *← 16px pickup sprite*

  🖼 Ore_Dirt.png **\[PLACEHOLDER\]** *← Dirt clump pickup*

  📁 **Player/**

  🖼 Robot_Walk_32p.png **\[HAVE\]** *← Mine Tileset →
  Anim_Robot_Walk1_v1.1_spritesheet.png*

  🖼 Robot_Jump_32p.png **\[HAVE\]** *← Mine Tileset →
  Anim_Robot_Jump1_v1.1_spritesheet.png*

  🖼 Robot_Drill.png **\[PLACEHOLDER\]** *← Use Walk frame 1 as temp
  drilling pose*

  🖼 Robot_Overdrive.png **\[PLACEHOLDER\]** *← Tint Walk spritesheet
  orange/red in editor*
  -----------------------------------------------------------------------

**\_Substrata/Art/Effects/ + Chests/ + UI/**

  -----------------------------------------------------------------------
  📁 **Effects/**

  📁 Explosions/ **\[HAVE\]** *← explosion pack 1 → explosion-1-a (7
  fr) + explosion-b (12 fr)*

  📁 Particles/ **\[HAVE\]** *← Effect and FX Pixel --- Parts 1--15, pick
  best fits for sparks/hits*

  📁 Shockwave/ **\[HAVE\]** *← Use ring/pulse frames from Effect FX for
  shockwave*

  📁 DrillSparks/ **\[HAVE\]** *← Use spark frames from Effect FX for
  drill contact*

  🖼 Dynamite.png **\[PLACEHOLDER\]** *← Tiny 16px TNT stick sprite*

  🖼 Dynamite_Fuse.png **\[PLACEHOLDER\]** *← Lit fuse variant*

  📁 **Chests/ \[HAVE\]** *← Animated Chests → Chests.png spritesheet*

  📁 **UI/**

  📁 HUD/

  🖼 FuelBar_BG.png **\[PLACEHOLDER\]** *← Bar background --- Unity UI
  rect works for prototyping*

  🖼 FuelBar_Fill.png **\[PLACEHOLDER\]** *← Green→red fill strip*

  🖼 FuelBar_Frame.png **\[PLACEHOLDER\]** *← Pixel border frame*

  🖼 Icon_Iron/Gold/Stone/Emerald/Sapphire.png **\[PLACEHOLDER\]** *← 16px
  resource icons × 5*

  🖼 Icon_Depth.png **\[PLACEHOLDER\]** *← Depth indicator icon*

  📁 SkillTree/

  🖼 Node_Locked.png **\[PLACEHOLDER\]** *← Greyed upgrade node --- simple
  circle is fine*

  🖼 Node_Available.png **\[PLACEHOLDER\]** *← Highlighted upgrade node*

  🖼 Node_Unlocked.png **\[PLACEHOLDER\]** *← Purchased node*

  🖼 Node_Connector.png **\[PLACEHOLDER\]** *← Line between nodes*

  📁 Menus/

  🖼 Button_Normal/Hover.png **\[PLACEHOLDER\]** *← Menu buttons ---
  9-slice rects*

  🖼 Panel_BG.png **\[PLACEHOLDER\]** *← Dark panel for skill tree and
  menus*
  -----------------------------------------------------------------------

**\_Substrata/Audio/**

  -----------------------------------------------------------------------
  📁 **Audio/**

  📁 **Music/ \[HAVE\]** *← Reference CozyTunes --- do NOT duplicate
  files, assign in AudioManager*

  🎵 Track_Surface **\[HAVE\]** *← → Floating Dream.ogg / Gentle
  Breeze.ogg*

  🎵 Track_Depth1 **\[HAVE\]** *← → Forgotten Biomes.ogg / Drifting
  Memories.ogg*

  🎵 Track_Depth2 **\[HAVE\]** *← → Strange Worlds.ogg / Polar
  Lights.ogg*

  🎵 Track_Depth3 **\[HAVE\]** *← → Golden Gleam.ogg / Whispering
  Woods.ogg*

  🎵 Track_SkillTree **\[HAVE\]** *← → Cuddle Clouds.ogg / Evening
  Harmony.ogg*

  📁 **SFX/**

  📁 Ambient/ **\[HAVE\]** *← CozyTunes SFX → alien remarks, phantom,
  presence behind, shadow, stalker, underwater world*

  📁 Gameplay/

  🔊 Drill_Hit.wav **\[PLACEHOLDER\]** *← Short thud --- freesound.org*

  🔊 Drill_Hit_Stone.wav **\[PLACEHOLDER\]** *← Harder impact for stone
  blocks*

  🔊 Ore_Collect.wav **\[PLACEHOLDER\]** *← Satisfying clink/chime*

  🔊 Fuel_Low.wav **\[PLACEHOLDER\]** *← Warning beep*

  🔊 Fuel_Empty.wav **\[PLACEHOLDER\]** *← Run-end sound*

  🔊 Dynamite_Throw.wav **\[PLACEHOLDER\]** *← Throw whoosh*

  🔊 Shockwave_Release.wav **\[PLACEHOLDER\]** *← Deep pulse/boom*

  🔊 Chest_Open.wav **\[PLACEHOLDER\]** *← Reward jingle*

  🔊 Upgrade_Buy.wav **\[PLACEHOLDER\]** *← Skill tree purchase click*

  🔊 Overdrive_Start.wav **\[PLACEHOLDER\]** *← Power-up whoosh*

  🔊 Boomstone_Explode.wav **\[PLACEHOLDER\]** *← Chain explosion ---
  pitch-shift an explosion SFX*
  -----------------------------------------------------------------------

**\_Substrata/Scripts/**

  -----------------------------------------------------------------------
  📁 **Scripts/**

  📁 **Core/ \[CODE\]**

  📄 GameManager.cs **\[CODE\]** *← Singleton --- manages game state, run
  start/end*

  📄 SaveSystem.cs **\[CODE\]** *← Persistent save for upgrades +
  resources*

  📄 AudioManager.cs **\[CODE\]** *← Plays music by depth, manages SFX
  pool*

  📄 ResourceInventory.cs **\[CODE\]** *← Tracks Iron, Gold, Stone,
  Emerald, Sapphire*

  📁 **Player/ \[CODE\]**

  📄 PlayerController.cs **\[CODE\]** *← RMB move, LMB drill/overdrive
  input*

  📄 DrillSystem.cs **\[CODE\]** *← Damage, hits/sec, radius, crit logic*

  📄 FuelSystem.cs **\[CODE\]** *← Fuel drain/refill, run-end trigger*

  📄 OverdriveSystem.cs **\[CODE\]** *← LMB hold → speed boost + dynamite
  rate up*

  📁 **Abilities/ \[CODE\]**

  📄 DynamiteAbility.cs **\[CODE\]** *← Throw every X drill hits, AoE
  damage*

  📄 ShockwaveAbility.cs **\[CODE\]** *← Periodic radial blast,
  upgradeable radius*

  📄 DroneSystem.cs **\[CODE\]** *← Automated mining drones (late
  upgrade)*

  📄 LaserSystem.cs **\[CODE\]** *← Laser beam, width / cooldown /
  piercing upgrades*

  📁 **World/ \[CODE\]**

  📄 WorldGenerator.cs **\[CODE\]** *← Procedural tile placement per run*

  📄 BlockData.cs **\[CODE\]** *← HP, type, depth zone, ore type per
  tile*

  📄 DepthManager.cs **\[CODE\]** *← Detects depth zone, triggers
  music/FX swap*

  📄 BoomstoneBlock.cs **\[CODE\]** *← Chain explosion logic on mine*

  📄 FuelRegenBlock.cs **\[CODE\]** *← Restore fuel when mined*

  📄 ChestSpawner.cs **\[CODE\]** *← Places chests at Depth 2+, handles
  rewards*

  📁 **Upgrades/ \[CODE\]**

  📄 UpgradeManager.cs **\[CODE\]** *← Reads UpgradeNodeSO, applies stat
  boosts persistently*

  📄 UpgradeNode.cs **\[CODE\]** *← Single node: resource cost, stat
  effect, prerequisites*

  📄 StatSystem.cs **\[CODE\]** *← Central stat store --- damage, speed,
  fuel, crit, etc.*

  📁 **UI/ \[CODE\]**

  📄 HUD.cs **\[CODE\]** *← Fuel bar, resource counts, depth indicator*

  📄 SkillTreeUI.cs **\[CODE\]** *← Render upgrade nodes, handle
  purchase*

  📄 DepthTransitionUI.cs **\[CODE\]** *← Depth 1→2→3 overlay transition*

  📁 **EasterEggs/ \[CODE\]** *← Hack Club + Ember refs --- Substrata
  originals*

  📄 HackClubBlock.cs **\[CODE\]** *← Rare block sporting Hack Club flag
  pattern*

  📄 EmberCrystal.cs **\[CODE\]** *← Ember-colored deep crystal with
  unique SFX + lore text*
  -----------------------------------------------------------------------

**\_Substrata/Prefabs/**

  -----------------------------------------------------------------------
  📁 **Prefabs/**

  📁 **Player/**

  ⬡ Player.prefab **\[CODE\]** *← Robot sprite + DrillSystem +
  FuelSystem + OverdriveSystem*

  📁 **Blocks/**

  ⬡ Block_Dirt.prefab **\[HAVE\]** *← Mine Tileset tile + BlockData
  component*

  ⬡ Block_Stone.prefab **\[HAVE\]** *← Mine Tileset variant tile +
  BlockData*

  ⬡ Block_Hard.prefab **\[PLACEHOLDER\]** *← Depth 3 --- placeholder
  recolored tile*

  ⬡ Block_Boomstone.prefab **\[PLACEHOLDER\]** *← Boomstone.png +
  BoomstoneBlock.cs*

  ⬡ Block_FuelRegen.prefab **\[PLACEHOLDER\]** *← FuelRegen_Block.png +
  FuelRegenBlock.cs*

  📁 **Effects/**

  ⬡ FX_Explosion.prefab **\[HAVE\]** *← explosion-1-a animated sprite (7
  frames)*

  ⬡ FX_Shockwave.prefab **\[HAVE\]** *← Ring pulse from Effect FX pack*

  ⬡ FX_DrillSparks.prefab **\[HAVE\]** *← Spark frames from Effect FX
  pack*

  ⬡ Dynamite.prefab **\[PLACEHOLDER\]** *← Dynamite.png + arc
  trajectory + explosion on land*

  📁 **World/**

  ⬡ Chest.prefab **\[HAVE\]** *← Animated Chests spritesheet +
  ChestSpawner.cs*

  ⬡ OrePickup.prefab **\[PLACEHOLDER\]** *← Ore sprite + circular trigger
  collider*
  -----------------------------------------------------------------------

**\_Substrata/ScriptableObjects/ + Animations/ + Scenes/**

  -----------------------------------------------------------------------
  📁 **ScriptableObjects/**

  📁 **Upgrades/ \[CODE\]** *← One .asset per upgrade node --- see full
  upgrade tree in design doc*

  📄 UP_DrillDamage.asset **\[CODE\]** *← cost, stat delta,
  prerequisites*

  📄 UP_HitsPerSecond.asset **\[CODE\]**

  📄 UP_TotalFuel.asset **\[CODE\]**

  📄 UP_Overdrive.asset **\[CODE\]**

  📄 UP_Dynamite.asset **\[CODE\]**

  📄 UP_Shockwave.asset **\[CODE\]**

  📄 \... (one per upgrade) **\[CODE\]** *← All 50+ upgrades from design
  doc*

  📁 **BlockTypes/ \[CODE\]**

  📄 BT_Dirt / BT_Stone / BT_Hard / BT_Boomstone.asset **\[CODE\]** *←
  HP, depth, drop table, ore spawn %*

  📁 **Animations/**

  📁 **Player/**

  🎞 Robot_Walk.anim **\[HAVE\]** *← Mine Tileset Walk spritesheet →
  slice + animate*

  🎞 Robot_Idle.anim **\[HAVE\]** *← Walk frame 0 held*

  🎞 Robot_Drill.anim **\[PLACEHOLDER\]** *← Drilling loop*

  🎞 Robot_Overdrive.anim **\[PLACEHOLDER\]** *← Fast drill variant, add
  orange tint via material*

  📁 **Effects/**

  🎞 Explosion_A.anim **\[HAVE\]** *← explosion-1-a 7 frames*

  🎞 Explosion_B.anim **\[HAVE\]** *← explosion-b 12 frames --- for
  Boomstone chain*

  🎞 Chest_Open.anim **\[HAVE\]** *← Animated Chests spritesheet*

  📁 **Scenes/**

  🎬 **MainMenu.unity \[CODE\]** *← Title screen --- start, maybe depth
  lore tease*

  🎬 **Game.unity \[CODE\]** *← Main play scene --- world + player +
  HUD + skill tree overlay*
  -----------------------------------------------------------------------

**COZYTUNES AUDIO ASSIGNMENT**

*Recommended track assignments for each game state.*

  ---------------- ---------------------- -------------------------------
  **Game State**   **Track**              **Why**

  Surface / Menu   Floating Dream         Light chill --- safe zone

  Surface alt      Gentle Breeze          Backup track

  Skill Tree       Cuddle Clouds          Calm reward feeling

  Skill Tree alt   Evening Harmony        Secondary option

  Depth 1          Forgotten Biomes       Adventure starts

  Depth 1 alt      Drifting Memories      Subtle mystery

  Depth 2          Strange Worlds         Tension builds

  Depth 2 alt      Polar Lights           Cold, darker

  Depth 3          Golden Gleam           Epic, final depth

  Depth 3 intense  Whispering Woods       Mystery and dread

  Ambient          Underwater World SFX   Background loop

  Depth 3 ambient  Phantom + Shadow SFX   Eerie lore depth

  HackClub Easter  Sunlight Through       Bright surprise
  Egg              Leaves                 
  ---------------- ---------------------- -------------------------------

**PLACEHOLDER PRIORITY ORDER**

Build MVP first --- tackle placeholders in this order to unblock coding:

  -----------------------------------------------------------------------
  1️⃣ **Ore pickup sprites \[PLACEHOLDER\]** *← Needed for DrillSystem +
  ResourceInventory to function*

  2️⃣ **Depth 3 hard tile \[PLACEHOLDER\]** *← Recolor Depth2 tile blue in
  any pixel editor --- 5 minutes*

  3️⃣ **Boomstone tile \[PLACEHOLDER\]** *← Recolor stone tile dark + add
  red glow dot*

  4️⃣ **Fuel bar UI \[PLACEHOLDER\]** *← Unity UI Image fill works as a
  prototype*

  5️⃣ **Dynamite sprite \[PLACEHOLDER\]** *← 8px TNT stick --- 2 min in
  Aseprite or similar*

  6️⃣ **Drill + collect SFX \[PLACEHOLDER\]** *← 3 sounds from
  freesound.org unblocks audio feedback*

  7️⃣ **Skill tree node sprites \[PLACEHOLDER\]** *← Simple circles work
  fine for prototyping*
  -----------------------------------------------------------------------

*💡 Unity built-in solid-color sprites work as placeholders for tiles
and UI. Don\'t block coding on missing art.*



DO NOT THAT I HAVE PROQUIRED ALL ASSESTS




https://store.steampowered.com/app/4333020/Diggin_Demo/

* Drill Hit Damage (0:39): Increases the damage dealt per drill hit, allowing you to break blocks faster.
* Total Fuel (0:49): Increases your total fuel capacity, allowing for longer mining sessions.
* Block Radius (0:57): Increases the number of blocks you can mine simultaneously.
* Drill Hits per Second (0:59): Increases how frequently your drill strikes.
* Movement Speed (1:30): Increases how fast you can move around the mine.
* Critical Hit Chance (3:01): Increases the chance for a drill hit to deal bonus damage.
* Fuel Preservation (3:41): Reduces the amount of fuel consumed while drilling.
* Hold for Overdrive (6:34): Enables a special mode when holding down the mouse button.
* Overdrive Energy (11:23): Increases the speed or duration of the overdrive ability.
* Release Quake (6:49): Periodically releases a powerful shockwave that damages surrounding blocks.
* Throw Dynamite (13:03): Periodically throws dynamite into the mine, causing explosive damage.
* Crit Damage (16:01): Increases the damage dealt by critical hits.
* Resource Multiplier (16:11): Provides a chance to triple the amount of resources gained from a block.
* Boom Stone (32:11): Special stone blocks that explode when mined, chain-reacting with other explosives.
Core & Battery Upgrades
* Battery 1: Adds a couple more seconds to the battery life (0:20).
* Battery 2: Further increases battery duration (3:02).
* Lantern Size: Increases the illumination radius (5:01, 31:31).
* Magnet: Increases the collection radius for dropped ores (30:05, 31:17).
Drill & Movement Upgrades
* Mining Speed: Increases how fast the drill destroys blocks (4:42).
* Mining Damage: Increases the damage dealt per hit to ore blocks (6:05, 36:55).
* Movement Speed: Increases base movement speed (4:48, 7:24).
* Overdrive Mode: A special mode that increases movement speed and refills battery (4:51, 5:11).
* Overdrive Speed: Increases movement speed specifically while in overdrive (10:08, 12:06).
* Overdrive Recharge: Reduces the cooldown for using overdrive (10:06, 12:06).
* Max Overdrive: Increases the duration or capacity of overdrive mode (17:11).
* Speed Boost: Increases speed when crystals explode near the drill (34:42).
Inventory & Capacity
* Capacity: Increases the total amount of ore the drill can hold before needing to return to the surface (2:33, 8:32, 16:55, 30:45, 49:57).
Automation & Combat (Drones & Lasers)
* Automated Mining Drones: Deploys drones that automatically mine blocks (13:32).
* Drone Critical Hit: Increases the chance for drones to deal critical damage (17:04).
* Drone Inventory: Allows drones to have their own inventory capacity (17:06, 26:56, 40:07).
* Additional Drones: Unlocks more mining drones to assist (17:06).
* Lasers: Deploys lasers that automatically damage blocks (28:13, 28:54).
* Laser Damage: Increases the damage dealt by lasers (29:21).
* Laser Cooldown: Reduces the downtime between laser attacks (36:55).
* Laser Width: Increases the area of effect for lasers (35:24, 36:55).
* Infinite Piercing: Allows lasers to pass through all blocks (44:43).
Resource & Spawning
* Emerald Spawning: Increases the rate at which emerald gems spawn (11:51, 26:35).
* Sapphire Spawning: Increases the rate at which sapphire gems spawn (26:35).
* Explosive Crystals: Spawns crystals that explode, destroying surrounding blocks (18:22, 19:22).
* Explosive Radius: Increases the damage radius of explosive crystals (34:46).
* Ore Spawn Rate: Increases the frequency of ore spawning (11:58, 42:10, 48:47).
Prestige & Value Upgrades
* Cell Value (Iron): Increases the money earned from selling iron (11:59, 26:46, 29:25).
* Cell Value (Emerald): Increases the money earned from selling emeralds (12:26, 30:00).
* Cell Value (Sapphire): Increases the money earned from selling sapphires (29:20).
* Cell Value (Gold): Increases the money earned from selling gold (43:44, 50:00).
* XP Gain: Increases the amount of experience points gained (36:58, 45:00, 48:47).
* Compass: Points out nearby crystals (33:34).

Based on the gameplay of Diggin shown in the video, a Minimum Viable Product (MVP) for a game like this would need to include the core loop of mining, selling resources, and upgrading. Here are the essential features for an MVP:
* Core Mining Mechanic (0:02 - 0:26): A basic grid-based world that you can drill into to collect resources.
* Drill Resource Management (0:24): A fuel system that limits how long you can mine before needing to return to the surface.
* Basic Inventory System (0:30): The ability to collect and hold resources like dirt or ore.
* Simple Upgrade Tree (0:34 - 1:05): A menu to spend gathered resources on fundamental improvements, such as:
   * Drill Damage to break blocks faster.
   * Total Fuel to stay underground longer.
   * Movement Speed to travel faster.
* Procedural or Static Digging Area (0:08): A defined area to dig down through with different block types.
Based on the gameplay, here is an explanation of the different depths encountered while mining in Diggin:
* Depth 1 (0:08): This is the initial surface layer of the meteor crater. It primarily consists of dirt blocks which are easy to break, allowing the player to quickly gather basic resources and fuel their early upgrades.
* Depth 2 (30:52): Upon breaking through deeper layers, the player reaches Depth 2. This area introduces tougher stone blocks and a new resource, gold, which is essential for higher-level upgrades (37:04). The player notes that they need to travel deeper to find treasure chests (30:32).
* Depth 3 (34:49): The final depth shown in the demo is Depth 3. This layer is significantly more difficult, requiring high-damage drilling or explosive chain reactions to break through the tough blue blocks (35:32). This is where the player attempts to uncover the mystery of the moles (31:53).
I will find assets shortly first as u can see i can ask gemini abt the yt vid since its directly intergrated using the new feature SOOOO



ASK AS MANY QUESTIONS AS U WANT ABOUT THIS GAME LIKE AS MANY AS POSSIBLE WHATEVER U WANT TO 

THE GAME NAME IS SUBSTRATA

02:16
 what do you got buggy the hedge moles movement speed don't really care drill hit i upgrade honestly dude i think you do it again i think you go all in let's let's make this thing start mining blocks a little faster i think that this is quite lovely

02:33
 and then i think we can think about increasing our fuel we're gonna finally get another resource here which i think is a pretty big win and i have to imagine that these these stone blocks on my left take a little harder to get through but i feel like you you gotta try now okay i got obliterated as soon as i tried to get those so that's good to know

02:55
 But I did get a little iron, which is exciting. Let's go with a gas increase. Let's go with a movement speed increase just because we have it. Critical hit chance. Crit me baby one more time. I suppose that's better than drill me baby one more time, which is where my head immediately went.

03:12
 That's like two bad sexual references in the first three minutes of this video. I Sincerely apologize. Okay We're going To this way and I'm going to get myself a little bit more I'm gonna call it iron. Okay, I'm gonna call it dirt and I'm gonna call it iron

03:33
 we're not ready for a stone life yet i mean we're just not ready for the stone life let's let's improve our our stuff fuel preserved whenever fuel is used it's a hybrid okay i feel like i'd rather just have like drill damage and then more gas and and we'll just keep going

03:56
 We need to go deeper, okay? I need to get deeper into this hole and truly start to see what we got going for us. I guess the correct thing to do at this point is don't even try to go through the hefty stuff. Let's just mine out the dirt. Get ourselves a huge dirt increase on this one. Okay.

04:23
 It's somewhat peaceful. It's like mining in Minecraft, man. Sometimes you just... You get that two-week Minecraft urge. And all you want to do... You don't even want to do, like, building or anything. You just want to go in. You just want to mine. I think that 5% drill hits per second is actually going to be a major upgrade for us. But I'm going to go drill damage twice. And my reasoning here is that we're now going to kill blocks in two hits...

04:52
 Which, for the record, I did not know going into that. I expected it to be like three. The fact that it's two is a beautiful day. But this is going to give me a ton of juice. And I can use this juice and leverage this juice to get a couple of insane upgrades on this one. And I'm going to tell you, I'm going to be an idiot. And I'm going to try to get this.

05:16
 it's not even close we should not try okay we we did try we should not have tried that's fine give me now i mean i'm gonna tell you drill hit damage that's a full 20 increase again another five fuel

05:35
 You're getting very close to actually getting enough iron. We can snag it here. I will say that our drill damage did not... We want to get to the point where we're one-shotting. And we're not quite there yet. But we'll get there, okay? We'll get there.

05:54
 And when we get there, we are going to witness the magic really start to happen. Because we're going to shred through this first layer. And then we have to start worrying about finding some kind of upgrade that lets me get through this stone. Because that is truly starting to seem like it's going to be a problem for me. Unless there is a path every time through it, but I'm going to tell you, it sure as heck does not look like it.

06:21
 so kill me 18 plus two iron i think you gotta do a drill hits per second um release a powerful quake periodically that sounds kind of fun and then we'll do a fuel reserve hold left mouse button to go into overdrive okay i do like that

06:42
 this may sound crazy i have like no desire to spend on increasing my block radius i feel like i'd rather try to go for this powerful shock i feel like that this is we're about to we're very close to getting our drill damage to be so high

07:02
 That we're one-shotting this dirt. And then we can roll into hitting the stone. And the stone's gonna... It's gonna be like friggin' Mick Jagger performing satisfaction live. Okay? The stones are going to be rolling. They are going to be absolutely rolling.

07:21
 I was in a school jazz band growing up when I was in seventh grade or something like that. I played piano, but I wasn't good enough at piano. I can play piano, but I typically play by ear. I can read sheet music, I just can't read it super well. And it's a skill that I never practice much, but I can play by ear pretty well. I'm gonna max this out, man.

07:51
 I think that this is our most important play. And then I'm going to do this. And we're going to hop back in. Oh, yeah. Oh, yeah. Now this is what we're freaking talking about. Get the damage going. But anyway, I couldn't really read sheet music. So when I joined the jazz band, they were like, look, we're not putting you on the keyboard because you can't read music, which I thought was lame because I could play piano. I just typically would play by ear. And just I had a... It wasn't that I was memorizing what I had to do, but it was more I...

08:21
 I just played with the sound of the music, right? And it's a skill that I got from my grandfather, because he could play both piano and guitar by ear. Guitar, I never really understood. I cannot sit down and play a guitar by ear. I can do it with a piano. I cannot do it with a guitar.

08:43
 I also, like, I have huge hands, okay? But I feel like a guitar just still does not fit in my hands. And I know that that's a really peculiar thing to say. Like, my hands are, they're really quite big. This sucks, by the way. We can at least break some of the stone, which is good. But I used a lot of my energy, and I did not want it to.

09:10
 okay keep keep this going i think that drill speed is a massive massive buff for us and i would like to probably prioritize using my resources on its moving forward

09:26
 Anyway, my story has digressed, uh, because we started talking about the stones. One of the songs we played was- was Satisfaction. And, uh, I was playing on a xylophone. It was actually- it's called a vibraphone, um, because the vibes are so great on it. That's not why it's called a vibraphone. Um...

09:45
 but i was playing on the on the vibraphone because it's kind of like uh a piano or a keyboard it's just i mean like it's still the same notes you just hit them with a little stick instead and i don't know why they trusted me with that instead of just like playing the song on the keyboard but anyway i would do the little like which is the beginning of satisfaction by the stones and i would play that on the vibraphone and it was like my

10:12
 my happy little solo that started the song it was quite lovely this has been uh story time with tyler it's a horrible story but i did perform it at the the rock and roll hall of fame which is pretty friggin cool okay it's pretty cool

10:28
 Anyway, in that time, we have gained quite a lot of resources. I would like to periodically release a powerful quake, so I am going to actually just save up for that. We have so much iron that I would really like to get that crazy ability. And just, like, see, because I feel like that's going to send me further down into the mines here.

10:55
 And that could really, really propel us into making some progress. Because right now, we are still technically at depth 1. And I have a feeling that there's more exciting things to see at depths below 1. I'm very sad that this did not go the way I wanted it to. Okay, 41 puts me at 72. I'm going to tell you, brother. I mean, I do like the idea of going into overdrive.

11:22
 Okay, I want to know what happens when I go into overdrive, and then more overdrive energy. Okay. Yeah, I'm all in on that. More fuel is also sick, but let's figure out what the heck overdrive is. So far, I have no clue. I feel like that nothing has changed. Oh, overdrive is slowly increasing. Okay. I see that on the left now.

11:51
 I'm excited to go into maximum overdrive in a second. This is going to go freaking crazy, man. Maximum overdrive, just like the Cleveland Cavaliers after trading for James Harden. Am I right, gamers? None of you care about basketball. My brain has been like eat, sleep, work, NBA trade news over the last 48 hours. I don't know why I didn't go into overdrive or maybe I was in overdrive and I just didn't realize it.

12:24
 okay i have to i i have to let go and then i use the overdrive okay i will say that that is not at all what it said it said hold down to overdrive but i have to unhold down to use the overdrive which is fine i mean now we know now we know

12:46
 So like here, I'm gonna overdrive. Yeah, man. That works. It's interesting, at least. Whether or not it's a good survey, we'll say in the future.

13:01
 83. I'm going to wait for Quake, boy, man. Periodically throw Dynama in the air. I'm going to take, though. I'm going to take because that's pretty fun. I do like that. I want my Quake, though. We're going to go Quake.

13:16
 Now, periodically throw dynamite in the air. How periodic are we talking? Right now, okay. I'm not sure that that did that much damage, but maybe we can make the dynamite better. Here comes the dynamite. And boom goes the frickin' dynamite, honestly. Okay. And then... Do a little one of these. I mean, that went surprisingly okay. Into another one of these. Okay, this is definitely the deepest that we've gotten.

13:45
 And we're still friggin' going, man. Ooh, a new resource. There's no shot that I can collect that. And I certainly cannot. Send me back digging. We're gonna do one more nice round here.

14:03
 And then we're going to... Okay, this is the worst dynamite that has ever been thrown. Then we're going to get our shockwave mine through. That went so well, to be honest with you. And now the dynamite, I'm going to tell you, it's the ideal scenario. Because it's going to be right inside of us. That came out a little strange. I feel like that, unfortunately, we're right back to the innuendos again.

14:33
 The dynamite gets put into... I was about to say it gets put into the hole. The dynamite goes into the mine that we're currently in. Okay, release a periodical shockwave. Take it. And then we can make that shockwave more damage if we want to. I think that throw the dynamite every 10 drill hits. I will say that I feel like this is... Right now it's at 10, but I can upgrade it to go to 9. Is that the play here? Okay.

15:01
 Probably. Let's...

15:05
 increase our damage max that out let's increase our fuel and get that going overdrive i just don't think i care about let's let's increase our radius to attempt to i guess i can i can increase the width of our terrain which is very interesting let's let's dig okay our our vision is is slightly higher we'll slowly open up a little bit more space here

15:33
 dynamite flowing yeah that did a lot of damage actually did i increase the damage of the explosion i feel like i didn't and yet i feel like that that went kind of crazy and right there i feel like it went kind of crazy am i am i tripping maybe maybe the dynamite scales with my damage and i'm now one-shotting some stuff okay

16:00
 I mean, you're just kind of going for it. I will say that I do not think that I will be mining any of those blocks, but that went okay. Minable terrain will increase. 5% chance to triple any resource. We'll take that too. We can go with some critical hits. I think that maxing out fuel is probably a good idea. And then we'll continue to do dynamites a little sooner.

16:28
 Oh, you know what, man? It's the shockwave that we're doing. That's the shockwave. The shockwave is really good, man. That's really good. I'm a big fan of that. That's actually... That is very, very nice. I would like you to do it again right here while I'm still standing by a couple of these blocks. Yeah, that's fine.

16:58
 I think you're doing nice things for me. Any chance that I can sneak in and grab this gold? The answer to that is just like, absolute hell no. Give me the last fuel. Give me more fuel preservation. Max out the speed. Get me a crit chance.

17:17
 And then we slowly are going to work our way down. Special stone blocks that explode when mined. Boomstone. I do like Boomstone. Plus one stone gained from all sources of stone. Okay, it's the greatest upgrade ever. We need to beeline for that. So I need to come out of this with 150 big ones.

17:38
 And that is easier said than done, to be honest. But we will see what we can do. This is so peaceful, man. I love games where nothing happens. That's not an insult to the developer. I just like games where I can very peacefully just vibe.

17:58
 And I just, I like watching the number go up. I do. I used to not be a fan of watching the number go up. In my old age, I'm watching the number go up now. I always talk about, I don't play games on my phone. The only games that I have had installed on my phone are like the chess app. I have Super Auto Pets on there. I have a couple like Sudoku apps. Mainly I'm like 150 years old is what I'm getting at.

18:28
 Is this a new resource? I would really like to grab this gold. I think that is, in fact, a new resource. But I recently installed an actual incremental idle game on my phone called... I don't know what it's called. It's some kind of farm game. It's just like menus, man. There's barely any pictures on it. And it's lovely. It is lovely to have a game where absolutely nothing happens, man.

18:58
 we need more games where nothing happens okay i think it's a good idea to increase or buff our i mean i think we should buff our dynamite explosion we have to do this though so i'm gonna start with throwing dynamite more often we're gonna increase our critical hit damage since that's using the gold resource that i now have

19:21
 and then this also does that drill hit damage in overdrive sure and then i'm going to save my sweet money here because we need to get a plus one stone for every stone that that is a it's just a massive play for us

19:39
 it's basically double all your resources that's when you award it like that it's the greatest upgrade that you can do and unfortunately we still have a lot of things that are stone adjacent so we we have to we have to go all in on this plan

19:55
 take me take me it's a beautiful beautiful play i don't know how he collects those from afar because that's not really how real life works but i'm glad that he uh he can reach over to the other side of the mine nowhere near him and grab the resources it does make my life slightly easier okay overdrive send it and then i'm gonna tell you we ain't getting through this block i don't know how we get through that block but it ain't happening now

20:21
 150. Banger. We're in. Special stone blocks that regenerate fuel when mined. Plus one iron gain from all sources. A lot of good stuff here. A lot of good stuff. Throw more dynamite. And then fuel preserved whenever fuel is used. It just makes that better. I think we're going to go mineable terrain and then we'll start working the rest. Because now we got tons of space and we're getting double the amount of resources.

20:51
 And then really, like, the big next step, man, is I gotta somehow get more damage in this sucker. Because I gotta somehow...

21:04
 i gotta somehow be in a position you know what overdrive friggin send me um i gotta be in a position where i can get through the mysterious blue block so i gotta i gotta get some some extra damage flowing so we can make that happen this is gonna be a great shockwave man oh yeah oh yeah this is this is like generational wealth that we're coming out of here

21:30
 I'm gonna be putting stone into my 401k at this rate, man. The damn Oren P500 is about to go to the moon. I'm ready. I am ready. I can't go through that block, man. I know I can't, so don't even try. 264 is the greatest turn of all time. Okay. Total fuel, that's a huge upgrade. Drill hit damage is what we need. Is what we need.

22:01
 Special stone blocks that explode is also what we need. I'm increasing this. I'm increasing this. I understand that I should not have done any of those. But it's fine. And then I'm going to do this. And I'm going to hit you with one of those. And I'm going to hit you with one of these. And I'm going to go digging. And the idea here is... We now have... A 10% chance, I think is what it was. A 10% chance to get like...

22:30
 six resources from one is that how that would work because i'm getting two from each right now and then it's a multiplication by three seems wildly okay to me is is what we're gonna call it i i feel like that we can we can come out of that pretty happy i also would like to be in this general area when this bomb goes off in a second shockwave it was fine

23:00
 Probably not the greatest shockwave we've ever had, but it got the job done. A lot of you are going to say, Tyler, your mining pattern is extremely inefficient. I don't disagree with that, okay? Believe it or not, this thing is not the easiest to control. I know it looks like I probably can just move him to the left and be fine. It's not that simple. I think we want to increase drill damage. Shockwave damage is also sick, um...

23:29
 oh wait a minute i can increase this again yeah that's that's definitely the right play overdrive energy i actually like genuinely cannot be bothered we'll go this fuel preservation and then obviously we're gonna try to do this again you're gonna get 216 again so that will be uh very worth it

23:52
 And then we're going to be sitting pretty, bro. We're going to be sitting pretty. Our next big step is obviously we go with the extra damage. That's going to explode. I love that, man. I love that.

24:06
 Damage is also, we're one-shotting iron dirt blocks now. Is that accurate? Eh, not quite, but it's still pretty good, okay? It's still pretty good. Dynamite's still flowing. This is probably like one of our better mining paths here. So I'm chill with that.

24:31
 Get me over here, do a little overdrive. I love the overdrive through the hard stone. Just feels like that I'm accomplishing something. I don't have to wait for the slow-ass boy to clear. I just bust through like the Kool-Aid man. It's pretty good for me. Now, I'm going to die shortly, but this has to be our best one yet.

24:56
 453 okay give me even more shockwave damage goes up dynamite explosion damage goes up uh there is a big old treasure chest on there and i would like to know what the hell that was we'll find out momentarily okay

25:17
 the shockwave did good i will say that the dynamite is still like kinda ass i've been afraid to say it but the dynamite is is really not very good if we if we want to make things happen i need the dynamite to do better good shockwave please it was fine it was fine

25:40
 We're gonna be okay. We're gonna be okay. Mainly because it's a game where I can kind of just take my time doing whatever and nothing matters, which is beautiful. I can move slow. I can make bad choices. You can yell at me in the comment section. But you know what, man? It's 9.30 at night. After this, I'm gonna go make a cup of tea and then lay on the couch watching bad 90s TV shows. Probably have a cookie or something. And I'm gonna move on with my life. It's gonna be very, very nice.

26:11
 But right now, I'm just having a good mine. I'm just mining. I'm enjoying life. 652. Treasure chest. Plus one dynamite thrown. I have to find this underground. Okay. Okay. Fair enough. Fair enough. More fuel. I think it's probably time. Increasing the dynamite explosion radius literally almost doubled is pretty good. Drill damage. It's time. I guess more fuel will wait.

26:40
 And then I'll take this. And I'm going digging. Okay. The drill damage now means that we bust through iron lads completely fine. I just tossed dynamite into nowhere. Which is a... That's a tough one. Good dynamite. You know what? The dynamite is better than before. It's better than before.

27:07
 sure dynamite i would have liked you to grab those couple of blocks right there but if you want to live your life go for it dynamite yeah fine whatever put me in overdrive let me let me freaking rip

27:22
 I feel like we are going to come out of this in the, like, 700 range. Although, I don't know, to be honest with you. This is not one of my better ones. Because now we're deep in the damn trenches down here. I just need more fuel. I think the priority has to be fuel here. 620. Another 22. What is this? Overdrive energy regenerated per second goes up.

27:49
 Give me, give me total gas, man. I just multiplied it by a lot. Shockwave radius going to the moon, fuel preservation, iron gain from all sources. I mean, this, this is, we, we actually just, like, quadrupled our amount of fuel. Which tells me that I could probably just, like, slowly mine out the entire place going left to right. Or I can try to bust through the blue.

28:20
 That sounds far more fun than what I'm doing. So let's try to bust through a blue block. Let's just try to go as deep as possible, okay? Oh, look, it's the treasure chest. That works. I did not expect to just, like, find that for what it's worth. I expected that to take, like, far longer for me to get there. But we take those. I mean, that's a beautiful situation for me.

28:50
 Do you think that I can actually mine these blue blocks? I can. They do give me some stone. Just not a lot, it looks like. I can go fairly deep, man. I mean, we're sending it. I'm just going to see how deep we can go. This is technically officially depth 2.

29:13
 I don't know if I get more resources from these deeper blocks. I mean, that sure looks like a depth frickin' three block now. And this looks like it's potentially a explosive block. I mean, I'm gonna try to hit this. I'm losing fuel rapidly. Okay, 820, that's fun. We found this, which is more dynamite thrown. I love that a lot.

29:41
 Shockwave radius goes up is very exciting. Shockwave damage maxing out. Special stone blocks that regenerate fuel. Have more of them spawn. We definitely want to increase the boomstone rate as well. Let's not do what we did on the last one. Because we can...

30:00
 Play this very, very nicely. More dynamite being thrown, which is going to explode out this whole area. We're going to come out of this with thousands, potentially, of stone. I think that this is potentially a... We're talking... I think we're talking 2,000 minimum stone at the end of this. I know that that sounds insane...

30:29
 But I genuinely think that that's what we're talking about here. Because we now just have... We haven't even used, like, a fifth of our fuel. This is a lovely position to be in. We're going to be deep into Depth 2. We're going to be probably into Depth 3 as well. I'm still going to avoid blue blocks because we don't go through them very easily.

30:59
 But the dynamite is, the one-two punch is freaking sick now. And we're having ourselves a hardy mine, and the hardy mine is working better than I could have ever imagined this hardy mine work. This is where I probably should have started to not dig straight down. I just get greedy, okay? I get greedy. It's fun to dig down.

31:28
 I've been taught from a young age in Minecraft, you never dig straight down. But in games like this, I'm going to tell you, my ass wants to, I want to just dig straight down. I mean, this is how you find the secret sauce, is down here, man. They're hiding the Krabby Patty formula deep in this mine. To be fair, the game does say, can I uncover what happened to the moles that came before me? How am I going to find what happened to the moles that came before me if I don't go freaking deep underground, man?

31:58
 This is what it's all about. 1540. That's so much. Special iron blocks that give 5 iron when mine sounds fun. Boomstone explosion. We need to dig even wider. Boomstone spawn rate.

32:13
 Let's do it again. Then make the explosion bigger. And then make them spawn all over the place. And now you're going to be booming all over. Then give me more explosions. Some regen overdrive. A little extra fuel. That's now maxed.

32:30
 Let's go digging. We now got boomstone freaking all over the place, man. And that's going to be a slight problem because the dynamite is going to hit that and then it's going to explode and it's going to chain. There's boomstone all over the freaking place now, man. This is this is going to it's going to get insane. It's going to get insane.

32:53
 Start booming, brother. Start booming. I'm all in. And the dynamite damage going up, we're already seeing it pay dividends. Get a little overdrive poppin'. The best part is that overdrive then works with the dynamite, so we end up getting a ton of dynamite throws every time we overdrive.

33:17
 It's a lovely situation. I really wanted to kill that boomstone piece. If I wait here, to be fair, we probably could hit that with a shockwave, but it too late now. It too late now. I'm not going to worry too much about it. Just play this very chill. You're still not even half through your fuel, man.

33:41
 I feel like we are about to go the deepest we've ever gone. I already think that we've probably collected the most stone that we've ever collected. And we're going to go deeper than we've ever gone now.

33:57
 I think that we may see depth for here. Because this is... I don't know. Maybe I'm exaggerating. Maybe I'm being a little bit of an exaggerator. But it's pretty good. It's pretty good. You're coming out with a lot of gold as well. You're just getting a lot of resources.

34:19
 You got a little bit of everything. You got the iron, you got the stone. We're running out of things to buy in the tree, to be honest. So I'm very peculiar. It's not the right word. I'm very peculiar, but I'm very curious to see what comes next. 1884, 88, and another 8 gold.

34:42
 Fuel stone seems important. We'll max that out. Might as well max this out. Drill hit damage. I think going to max is good. Buff this to its full potential. Iron gain from all resources. I mean, brother, we only have these three things left to buy. I feel like that we're... I'm going to be like one-shotting. I'm one-shotting the regular stone.

35:08
 That's really dangerous, man. That's really dangerous. And now we're getting fuel back. I think that I'm going to just walk down to the bottom. In fact, I think I'm going to just try to go down to the bottom. I feel like this is what dreams are made of, man. We just gotta ascend it now. We'll let the explosions happen. I mean, we're going through the blue blocks in two hits now.

35:37
 So, that seems pretty good to me. You got Boomstone that's booming doing stuff. Let's try to go as deep as we can possibly go, man. You still got so much fuel left in the tank. I do think that there is something to be said for we should probably... Come on, hit the thingy. Ah, you didn't hit it. We should be trying to get back a little bit of fuel from the fuel canisters.

36:09
 But otherwise, I mean, go freaking deep, man. I'm the wide receiver. I guess I'm the quarterback. You're the wide receiver. Let's freaking go as deep as we can go. We're still... It's not the fastest. It is not the fastest.

36:32
 And we probably did not do this the most efficiently. We actually found no gold there. Okay, max out this. Grab this. Max out this. This is the only thing we got left. Boomstone explosion. Everything else we have, man. Okay. I gotta find some gold. That's really... We're on a hunt for gold. The rest of our resources actually do not matter at this time.

37:01
 Boomstone, gold. Thank you. That was, is this, it's a big iron mine. Okay, yeah. Everything is freaking so, it's so boomy, brother. It's so boomy. There's also so much iron. I feel like every block is iron right now.

37:22
 Overdrive is mainly good. You use Overdrive on blue blocks. It doesn't destroy them, and you just end up getting 1 billion pieces of dynamite to spawn from it. And it's kinda sick, I'm not gonna lie. It is extraordinarily fun. Okay. I need you to go over here, my guy. Explode that. And then I need you to grab this gold ray here.

37:49
 Took a little bit to defeat it, but we're in. Okay. Come over here. We're going to grab a little juicy fuel. 85. I mean, now I'm just like... I barely even care about going as deep as I can. I just want to max out the tech tree, man. We're right there. Although, I'm going to tell you that we have a legitimate path through here. Because a double boom right here... Well...

38:18
 Wasn't perfect. Let's... Let's see if I can... I mean, this sucker just won't move, man. He just won't move. Okay. 400 is insane there. We are going to increase this twice. I have nothing else to spend, man. I got nothing else to spend. I just want to... I just want to experience happiness.

38:40
 I do have to try to get this okay well okay okay okay I would like to be able to collect the gold please thank you very much I would like to be able to collect gold it's the only thing that I really have left in the tank you keep tossing me around like a rag doll snag the gold take me down snag some more gold please

39:07
 Great work. That was so much freaking gold. I think we'll be able to max it out, man. This is looking more our speed. And if this opens up another bit of tech tree, man, I mean, I got the resources to take care of business. Wow, that took 900 years for some odd reason. I don't know why that one took so long. Grab you, please.

39:37
 Thank you very much. I'm always going to grab the giant iron vein, man. You can't turn down like that giant chunk of iron. This is still a little spicy.

39:53
 I feel like there's gotta be something at the bottom of this, man. There's gotta be something. Okay. Come over here, Boomstone Explosion. Thanks for playing the demo! We really hope you enjoyed it. If you did, make sure to wishlist Diggin' on Steam. I am gonna wishlist Diggin' on Steam. In fact, it's already wishlisted for me on Steam. You guys can check this one out, though. Link in the description down below. Interested to see what they do with the rest of the game here. How do they continue to expand, innovate...

40:23
 add new features that i've never seen in an incremental game before i'm excited to see check it out link in the description down below thanks so much for watching as always liking the video much appreciate i'll see you guys later have a good one bye

IM GONA PREFACE THIS BY SAYING THIS WILL BE AN EXACT COPY OF DIGGIN
THE GAME IS CALLED SUBSTRATA

give me all details of the game
Based on the gameplay shown in the video, Diggin is a mining-themed incremental game where players drill into a meteor crater to collect resources, unlock upgrades, and discover cosmic treasures. The goal is to delve deeper into the earth, uncovering the story of the moles that came before (0:02 - 1:05).
Here are the key details and mechanics:
* Core Loop: Players use a drill to break blocks of dirt, stone, and special resources. Collected resources (like iron, gold, and stone) are used in a skill tree to upgrade drilling capabilities for deeper dives (1:05 - 2:00).
* Procedural Generation: The maps appear to be procedurally generated, featuring randomized distributions of different types of ores and rock structures in each run (3:26, 32:32).
* Game Mechanics:
   * Drilling: Players control a drill to clear blocks. Upgrades include increasing drill hit damage, drill hits per second, and block mining radius (0:44 - 1:03, 3:03).
   * Fuel & Energy: Drilling consumes fuel (or gas), limiting how long a run lasts (0:24, 0:54). Players can upgrade their total fuel capacity and fuel preservation (0:50, 6:35).
   * Special Blocks & Hazards: Deeper layers introduce boom stone that explodes when mined, helping to clear large areas (23:18, 32:01), and special blocks that regenerate fuel (22:00, 35:58).
   * Dynamite: Players can unlock the ability to periodically throw dynamite to destroy surrounding blocks (6:30, 13:05, 32:03).
   * Shockwaves: A periodic shockwave ability can be upgraded to damage blocks over a wider area (6:29, 13:16).
   * Overdrive: A temporary boost mode that increases drill speed and damage, typically activated by holding the mouse button (6:35, 12:45).
   * Resources: Players collect dirt, iron, gold, and stone. These are used to buy upgrades from the skill tree (1:05, 2:57, 13:52).
* Depth System: The game features different depth levels. Deeper levels contain harder blocks and more valuable resources, but require significantly stronger upgrades to penetrate (3:36, 30:52, 36:00).
What makes deeper layers different? Just harder blocks, or new mechanics too?
Deeper layers in Diggin introduce both harder blocks and new mechanics to challenge the player (32:55-33:15):
* Harder Blocks: As you go deeper, you encounter harder stone blocks that require more drill damage to break (3:26, 30:52).
* New Mechanics & Special Blocks:
   * Boom Stone: Special stone blocks that explode when mined, helping to clear surrounding blocks (23:18, 32:01).
   * Regenerating Fuel Blocks: Specific blocks that restore fuel when mined, allowing for longer runs (22:00, 35:58).
   * Increased Resource Density: Deeper layers contain more valuable resources, such as gold and large iron veins (36:00, 39:35).
* 
Is the map procedurally generated every run or hand-designed?
Based on the gameplay, the maps appear to be procedurally generated rather than hand-designed. The layout of the crater changes between runs, as evidenced by the different distribution of ores, stone, and special blocks like "boom stone" (32:32) in different mining attempts (3:26, 32:43). The game focuses on drilling through these randomized layers to reach deeper, more valuable resources.s there a prestige/reset system?
Based on the gameplay in the video, there is no mentioned prestige or reset system. The player focuses on unlocking the entire skill tree during a single, continuous progression session by gathering resources and spending them on permanent upgrades to drill deeper (35:10 - 36:00).Do upgrades persist between runs or reset each run (roguelite vs incremental)?
Based on the gameplay, Diggin functions like an incremental/idle game where upgrades persist between runs. The player earns resources during a mining run, and upon returning to the surface, they use those resources to permanently improve their capabilities in a skill tree (0:33-0:55, 36:35-37:00). These upgrades, such as increased drill damage, total fuel, and mining speed, remain active for all subsequent mining attempts (19:02-19:28).Is there a sell mechanic (go to surface, sell, spend on upgrades) or is it all one menu?
Based on the video, it is all one menu. The player accesses a skill tree directly to purchase upgrades using resources gathered while mining, rather than traveling back to a surface location to sell items first (0:34).Are resources just currency for upgrades or do different resources unlock different upgrade branches?
Resources serve as both currency for upgrades and as specific requirements to unlock different upgrade branches in the skill tree (0:36). Here is how they function based on the gameplay:
* Iron & Dirt (Basic Resources): Primarily used for general upgrades like drill damage and fuel capacity (0:49, 1:28).
* Gold (Advanced Resource): Required specifically for higher-tier upgrades, such as increasing critical hit damage (17:15, 36:50).
* Structural Requirements: Certain powerful upgrades, like the ability to gain bonus stone (19:25) or unlock special stone block capabilities (35:10), require large amounts of a specific resource to purchase the node, effectively gating progression behind that resource.Do resources auto-collect when nearby or do you have to physically walk over them?  
Based on the gameplay in the video, resources do not automatically move to you, but they do have a large collection radius, allowing you to collect them from a short distance away without physically touching them (20:01 - 20:10). The character appears to 'reach' over and grab the resources from nearby blocks (20:05).Is the drill automatic when you move into blocks, or do you manually click to mine?
Based on the gameplay, the drilling is automatic once you hold down the mouse button to move into or stay near blocks. The player does not need to click repeatedly for every single block.
   * Automatic Drilling: When the player moves into or stops next to a block, the drill begins operating automatically (0:24-0:28).
   * Movement Controls: The player can move by holding down the right mouse button to guide the character toward blocks (1:39-1:41).
   * Overdrive Mode: Holding down the left mouse button activates overdrive, causing the drill to function automatically at a faster rate (6:33-6:39).What's the narrative hook? Diggin has "uncover what happened to the moles before you" whats the story
Based on the gameplay and provided description, the narrative hook in Diggin is centered around exploring the depths of a meteor crater to uncover what happened to the moles that came before you (0:15 - 0:18). As you drill deeper, the game hints at a mystery regarding your predecessors, encouraging you to reach lower depths—like Depth 3 (34:49)—in search of clues and cosmic treasures to piece together their story.Based on the gameplay, here is an explanation of the different depths encountered while mining in Diggin:
      * Depth 1 (0:08): This is the initial surface layer of the meteor crater. It primarily consists of dirt blocks which are easy to break, allowing the player to quickly gather basic resources and fuel their early upgrades.
      * Depth 2 (30:52): Upon breaking through deeper layers, the player reaches Depth 2. This area introduces tougher stone blocks and a new resource, gold, which is essential for higher-level upgrades (37:04). The player notes that they need to travel deeper to find treasure chests (30:32).
      * Depth 3 (34:49): The final depth shown in the demo is Depth 3. This layer is significantly more difficult, requiring high-damage drilling or explosive chain reactions to break through the tough blue blocks (35:32). This is where the player attempts to uncover the mystery of the moles (31:53).





      