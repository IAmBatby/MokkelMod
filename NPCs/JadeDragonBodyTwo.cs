﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace MokkelMod.NPCs
{

    public class JadeDragonBodyTwo : ModNPC
    {
        public override void SetDefaults()
        {
            npc.displayName = "Jade Dragon";
            npc.noTileCollide = true;
            npc.name = "JadeDragonTwo";
            npc.width = 32;
            npc.height = 32;
            npc.aiStyle = 6;
            npc.netAlways = true;
            npc.damage = 40;
            npc.defense = 20;
            npc.lifeMax = 4000;
            npc.HitSound = SoundID.NPCHit7;
            npc.DeathSound = SoundID.NPCDeath8;
            npc.noGravity = true;
            npc.knockBackResist = 0f;
            npc.value = 10000f;
            npc.scale = 1f;
            npc.buffImmune[20] = true;
            npc.buffImmune[24] = true;
            npc.buffImmune[39] = true;
            npc.dontCountMe = true;
        }


        public override void AI()
        {

           
        }

    }

}
