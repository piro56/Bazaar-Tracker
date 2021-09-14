using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bazaar_Console_Edition
{
    class BazaarItems
    {
        public static List<Item> allItems = new List<Item>();
        public void initializeItems()
        {
            //Farming Section
            Item e_bread = new Item("ENCHANTED_BREAD");
            e_bread.addComponent("WHEAT", 60);
            allItems.Add(e_bread);

            Item e_hay_block = new Item("ENCHANTED_HAY_BLOCK");
            e_hay_block.addComponent("HAY_BLOCK", 144);
            allItems.Add(e_hay_block);

            Item e_carrot = new Item("ENCHANTED_CARROT");
            e_carrot.addComponent("CARROT_ITEM", 160);
            allItems.Add(e_carrot);

            Item e_carrot_on_a_stick = new Item("ENCHANTED_CARROT_STICK");
            e_carrot_on_a_stick.addComponent("ENCHANTED_CARROT", 64);
            allItems.Add(e_carrot_on_a_stick);

            Item e_golden_carrot = new Item("ENCHANTED_GOLDEN_CARROT");
            e_golden_carrot.addComponent("ENCHANTED_CARROT", 128);
            e_golden_carrot.addComponent("GOLD_INGOT", 32);
            e_golden_carrot.addComponent("CARROT_ITEM", 32);
            allItems.Add(e_golden_carrot);

            Item e_potato = new Item("ENCHANTED_POTATO");
            e_potato.addComponent("POTATO_ITEM", 160);
            allItems.Add(e_potato);

            Item e_baked_potato = new Item("ENCHANTED_BAKED_POTATO");
            e_baked_potato.addComponent("ENCHANTED_POTATO", 160);
            allItems.Add(e_baked_potato);

            Item e_pumpkin = new Item("ENCHANTED_PUMPKIN");
            e_pumpkin.addComponent("PUMPKIN", 160);
            allItems.Add(e_pumpkin);

            Item e_melon = new Item("ENCHANTED_MELON");
            e_melon.addComponent("MELON", 160);
            allItems.Add(e_melon);

            Item e_glistening_melon = new Item("ENCHANTED_GLISTERING_MELON");
            e_glistening_melon.addComponent("MELON", 256);
            e_glistening_melon.addComponent("GOLD_INGOT", 228);
            allItems.Add(e_glistening_melon);

            Item e_melon_block = new Item("ENCHANTED_MELON_BLOCK");
            e_melon_block.addComponent("ENCHANTED_MELON", 160);
            allItems.Add(e_melon_block);

            Item e_red_mushroom = new Item("ENCHANTED_RED_MUSHROOM");
            e_red_mushroom.addComponent("RED_MUSHROOM", 160);
            allItems.Add(e_red_mushroom);

            Item e_brown_mushroom = new Item("ENCHANTED_BROWN_MUSHROOM");
            e_brown_mushroom.addComponent("BROWN_MUSHROOM", 160);
            allItems.Add(e_brown_mushroom);

            Item e_huge_mushroom_1 = new Item("ENCHANTED_HUGE_MUSHROOM_1");
            e_huge_mushroom_1.addComponent("HUGE_MUSHROOM_1", 576);
            allItems.Add(e_huge_mushroom_1);

            Item e_huge_mushroom_2 = new Item("ENCHANTED_HUGE_MUSHROOM_2");
            e_huge_mushroom_2.addComponent("HUGE_MUSHROOM_2", 576);
            allItems.Add(e_huge_mushroom_2);

            Item e_cocoa = new Item("ENCHANTED_COCOA");
            e_cocoa.addComponent("INK_SACK:3", 160);
            allItems.Add(e_cocoa);

            Item e_cookie = new Item("ENCHANTED_COOKIE");
            e_cookie.addComponent("ENCHANTED_COCOA", 128);
            e_cookie.addComponent("WHEAT", 32);
            allItems.Add(e_cookie);

            Item e_cactus = new Item("ENCHANTED_CACTUS");
            e_cactus.addComponent("ENCHANTED_CACTUS_GREEN", 160);
            allItems.Add(e_cactus);

            Item e_sugar = new Item("ENCHANTED_SUGAR");
            e_sugar.addComponent("SUGAR_CANE", 160);
            allItems.Add(e_sugar);

            Item e_paper = new Item("ENCHANTED_PAPER");
            e_paper.addComponent("SUGAR_CANE", 192);
            allItems.Add(e_paper);

            Item e_sugar_cane = new Item("ENCHANTED_SUGAR_CANE");
            e_sugar_cane.addComponent("ENCHANTED_SUGAR", 160);
            allItems.Add(e_sugar_cane);

            Item e_feather = new Item("ENCHANTED_FEATHER");
            e_feather.addComponent("FEATHER", 160);
            allItems.Add(e_feather);

            Item e_leather = new Item("ENCHANTED_LEATHER");
            e_leather.addComponent("LEATHER", 576);
            allItems.Add(e_leather);

            Item e_raw_beef = new Item("ENCHANTED_RAW_BEEF");
            e_raw_beef.addComponent("RAW_BEEF", 160);
            allItems.Add(e_raw_beef);

            Item e_pork = new Item("ENCHANTED_PORK");
            e_pork.addComponent("PORK", 160);
            allItems.Add(e_pork);

            Item e_grilled_pork = new Item("ENCHANTED_GRILLED_PORK");
            e_grilled_pork.addComponent("ENCHANTED_PORK", 160);
            allItems.Add(e_grilled_pork);

            Item e_raw_chicken = new Item("ENCHANTED_RAW_CHICKEN");
            e_raw_chicken.addComponent("RAW_CHICKEN", 160);
            allItems.Add(e_raw_chicken);

            Item e_cake = new Item("ENCHANTED_CAKE");
            e_cake.addComponent("ENCHANTED_SUGAR", 2);
            e_cake.addComponent("ENCHANTED_EGG", 1);
            e_cake.addComponent("WHEAT", 3);
            e_cake.addComponent("IRON_INGOT", 9);
            allItems.Add(e_cake);

            Item super_egg = new Item("SUPER_EGG");
            super_egg.addComponent("ENCHANTED_EGG", 144);
            allItems.Add(super_egg);

            Item e_mutton = new Item("ENCHANTED_MUTTON");
            e_mutton.addComponent("MUTTON", 160);
            allItems.Add(e_mutton);

            Item e_cooked_mutton = new Item("ENCHANTED_COOKED_MUTTON");
            e_cooked_mutton.addComponent("ENCHANTED_MUTTON", 160);
            allItems.Add(e_cooked_mutton);

            Item e_rabbit_foot = new Item("ENCHANTED_RABBIT_FOOT");
            e_rabbit_foot.addComponent("RABBIT_FOOT", 160);
            allItems.Add(e_rabbit_foot);

            Item e_rabbit_hide = new Item("ENCHANTED_RABBIT_HIDE");
            e_rabbit_hide.addComponent("RABBIT_HIDE", 576);
            allItems.Add(e_rabbit_hide);

            Item e_rabbit = new Item("ENCHANTED_RABBIT");
            e_rabbit.addComponent("RABBIT", 160);
            allItems.Add(e_rabbit);

            Item e_nether_stalk = new Item("ENCHANTED_NETHER_STALK");
            e_nether_stalk.addComponent("NETHER_STALK", 160);
            allItems.Add(e_nether_stalk);

            // FARMING SECTION END
            // MINING TIME BOIS.

            Item e_cobblestone = new Item("ENCHANTED_COBBLESTONE");
            e_cobblestone.addComponent("COBBLESTONE", 160);
            allItems.Add(e_cobblestone);

            Item e_coal = new Item("ENCHANTED_COAL");
            e_coal.addComponent("COAL", 160);
            allItems.Add(e_coal);

            Item e_coal_block = new Item("ENCHANTED_COAL_BLOCK");
            e_coal_block.addComponent("ENCHANTED_COAL", 160);
            allItems.Add(e_coal_block);

            Item e_charcoal = new Item("ENCHANTED_CHARCOAL");
            e_charcoal.addComponent("COAL", 128);
            e_charcoal.addComponent("LOG", 32);
            allItems.Add(e_charcoal);

            Item e_iron = new Item("ENCHANTED_IRON");
            e_iron.addComponent("IRON_INGOT", 160);
            allItems.Add(e_iron);

            Item e_iron_block = new Item("ENCHANTED_IRON_BLOCK");
            e_iron_block.addComponent("ENCHANTED_IRON", 160);
            allItems.Add(e_iron_block);

            Item e_gold = new Item("ENCHANTED_GOLD");
            e_gold.addComponent("GOLD_INGOT", 160);
            allItems.Add(e_gold);

            Item e_gold_block = new Item("ENCHANTED_GOLD_BLOCK");
            e_gold_block.addComponent("ENCHANTED_GOLD", 160);
            allItems.Add(e_gold_block);

            Item e_diamond = new Item("ENCHANTED_DIAMOND");
            e_diamond.addComponent("DIAMOND", 160);
            allItems.Add(e_diamond);

            Item e_diamond_block = new Item("ENCHANTED_DIAMOND_BLOCK");
            e_diamond_block.addComponent("ENCHANTED_DIAMOND", 160);
            allItems.Add(e_diamond_block);

            Item e_lapis_lazuli = new Item("ENCHANTED_LAPIS_LAZULI");
            e_lapis_lazuli.addComponent("INK_SACK:4", 160);
            allItems.Add(e_lapis_lazuli);

            Item e_lapis_lazuli_block = new Item("ENCHANTED_LAPIS_LAZULI_BLOCK");
            e_lapis_lazuli_block.addComponent("ENCHANTED_LAPIS_LAZULI", 160);
            allItems.Add(e_lapis_lazuli_block);

            Item e_emerald = new Item("ENCHANTED_EMERALD");
            e_emerald.addComponent("EMERALD", 160);
            allItems.Add(e_emerald);

            Item e_emerald_block = new Item("ENCHANTED_EMERALD_BLOCK");
            e_emerald_block.addComponent("ENCHANTED_EMERALD", 160);
            allItems.Add(e_emerald_block);

            Item e_redstone = new Item("ENCHANTED_REDSTONE");
            e_redstone.addComponent("REDSTONE", 160);
            allItems.Add(e_redstone);

            Item e_redstone_block = new Item("ENCHANTED_REDSTONE_BLOCK");
            e_redstone_block.addComponent("ENCHANTED_REDSTONE", 160);
            allItems.Add(e_redstone_block);

            Item e_quartz = new Item("ENCHANTED_QUARTZ");
            e_quartz.addComponent("QUARTZ", 160);
            allItems.Add(e_quartz);

            //Item e_quartz_block = new Item("ENCHANTED_QUARTZ_BLOCK");
            //e_quartz_block.addComponent("ENCHANTED_QUARTZ", 160);
            //allItems.Add(e_quartz_block);

            Item e_obsidian = new Item("ENCHANTED_OBSIDIAN");
            e_obsidian.addComponent("OBSIDIAN", 160);
            allItems.Add(e_obsidian);

            Item e_glowstone_dust = new Item("ENCHANTED_GLOWSTONE_DUST");
            e_glowstone_dust.addComponent("GLOWSTONE_DUST", 160);
            allItems.Add(e_glowstone_dust);

            Item e_glowstone = new Item("ENCHANTED_GLOWSTONE");
            e_glowstone.addComponent("ENCHANTED_GLOWSTONE_DUST", 160);
            allItems.Add(e_glowstone);

            Item e_flint = new Item("ENCHANTED_FLINT");
            e_flint.addComponent("FLINT", 160);
            allItems.Add(e_flint);

            Item packed_ice = new Item("PACKED_ICE");
            packed_ice.addComponent("ICE", 9);
            allItems.Add(packed_ice);

            Item e_ice = new Item("ENCHANTED_ICE");
            e_ice.addComponent("ICE", 160);
            allItems.Add(e_ice);

            Item e_packed_ice = new Item("ENCHANTED_PACKED_ICE");
            e_packed_ice.addComponent("ENCHANTED_ICE", 160);
            allItems.Add(e_packed_ice);

            Item e_sand = new Item("ENCHANTED_SAND");
            e_sand.addComponent("SAND", 160);
            allItems.Add(e_sand);

            Item e_endstone = new Item("ENCHANTED_ENDSTONE");
            e_endstone.addComponent("ENDER_STONE", 160);
            allItems.Add(e_endstone);

            // END MINING, ADD SNOW LATER
            // BEGIN COMBAT !

            Item e_rotten_flesh = new Item("ENCHANTED_ROTTEN_FLESH");
            e_rotten_flesh.addComponent("ROTTEN_FLESH", 160);
            allItems.Add(e_rotten_flesh);

            Item e_bone = new Item("ENCHANTED_BONE");
            e_bone.addComponent("BONE", 160);
            allItems.Add(e_bone);

            Item e_string = new Item("ENCHANTED_STRING");
            e_string.addComponent("STRING", 192);
            allItems.Add(e_string);

            Item e_spider_eye = new Item("ENCHANTED_SPIDER_EYE");
            e_spider_eye.addComponent("SPIDER_EYE", 160);
            allItems.Add(e_spider_eye);

            Item e_fermented_spider_eye = new Item("ENCHANTED_FERMENTED_SPIDER_EYE");
            e_fermented_spider_eye.addComponent("ENCHANTED_SPIDER_EYE", 64);
            e_fermented_spider_eye.addComponent("BROWN_MUSHROOM", 64);
            e_fermented_spider_eye.addComponent("SUGAR_CANE", 64);
            allItems.Add(e_fermented_spider_eye);

            Item e_gunpowder = new Item("ENCHANTED_GUNPOWDER");
            e_gunpowder.addComponent("SULPHUR", 160);
            allItems.Add(e_gunpowder);

            Item e_firework_rocket = new Item("ENCHANTED_FIREWORK_ROCKET");
            e_firework_rocket.addComponent("ENCHANTED_GUNPOWDER", 64);
            e_firework_rocket.addComponent("SUGAR_CANE", 16);
            allItems.Add(e_firework_rocket);

            Item e_ender_pearl = new Item("ENCHANTED_ENDER_PEARL");
            e_ender_pearl.addComponent("ENDER_PEARL", 20);
            allItems.Add(e_ender_pearl);

            Item e_eye_of_ender = new Item("ENCHANTED_EYE_OF_ENDER");
            e_eye_of_ender.addComponent("ENCHANTED_ENDER_PEARL", 16);
            e_eye_of_ender.addComponent("BLAZE_ROD", 32);
            allItems.Add(e_eye_of_ender);

            Item e_ghast_tear = new Item("ENCHANTED_GHAST_TEAR");
            e_ghast_tear.addComponent("GHAST_TEAR", 5);
            allItems.Add(e_ghast_tear);

            Item e_slime_ball = new Item("ENCHANTED_SLIME_BALL");
            e_slime_ball.addComponent("SLIME_BALL", 160);
            allItems.Add(e_slime_ball);

            Item e_slime_block = new Item("ENCHANTED_SLIME_BLOCK");
            e_slime_block.addComponent("ENCHANTED_SLIME_BALL", 160);
            allItems.Add(e_slime_block);

            Item e_blaze_powder = new Item("ENCHANTED_BLAZE_POWDER");
            e_blaze_powder.addComponent("BLAZE_ROD", 160);
            allItems.Add(e_blaze_powder);

            Item e_blaze_rod = new Item("ENCHANTED_BLAZE_POWDER");
            e_blaze_rod.addComponent("ENCHANTED_BLAZE_POWDER", 160);
            allItems.Add(e_blaze_rod);

            Item e_magma_cream = new Item("ENCHANTED_MAGMA_CREAM");
            e_magma_cream.addComponent("MAGMA_CREAM", 160);
            allItems.Add(e_magma_cream);

            //END COMBAT 
            // BEGIN WOOD AND FISHES

            Item e_oak_log = new Item("ENCHANTED_OAK_LOG");
            e_oak_log.addComponent("LOG", 160);
            allItems.Add(e_oak_log);

            Item e_spruce_log = new Item("ENCHANTED_SPRUCE_LOG");
            e_spruce_log.addComponent("LOG:1", 160);
            allItems.Add(e_spruce_log);

            Item e_birch_log = new Item("ENCHANTED_BIRCH_LOG");
            e_birch_log.addComponent("LOG:2", 160);
            allItems.Add(e_birch_log);

            Item e_dark_oak_log = new Item("ENCHANTED_DARK_OAK_LOG");
            e_dark_oak_log.addComponent("LOG_2:1", 160);
            allItems.Add(e_dark_oak_log);

            Item e_acacia_log = new Item("ENCHANTED_ACACIA_LOG");
            e_acacia_log.addComponent("LOG_2", 160);
            allItems.Add(e_acacia_log);

            Item e_jungle_log = new Item("ENCHANTED_JUNGLE_LOG");
            e_jungle_log.addComponent("LOG:3", 160);
            allItems.Add(e_jungle_log);

            Item e_raw_fish = new Item("ENCHANTED_RAW_FISH");
            e_raw_fish.addComponent("RAW_FISH", 160);
            allItems.Add(e_raw_fish);

            Item e_cooked_fish = new Item("ENCHANTED_COOKED_FISH");
            e_cooked_fish.addComponent("ENCHANTED_RAW_FISH", 160);
            allItems.Add(e_cooked_fish);

            Item e_raw_salmon = new Item("ENCHANTED_RAW_SALMON");
            e_raw_salmon.addComponent("RAW_FISH:1", 160);
            allItems.Add(e_raw_salmon);

            Item e_cooked_salmon = new Item("ENCHANTED_COOKED_SALMON");
            e_cooked_salmon.addComponent("ENCHANTED_RAW_SALMON", 160);
            allItems.Add(e_cooked_salmon);

            Item e_clownfish = new Item("ENCHANTED_CLOWNFISH");
            e_clownfish.addComponent("RAW_FISH:2", 160);
            allItems.Add(e_clownfish);

            Item e_pufferfish = new Item("ENCHANTED_PUFFERFISH");
            e_pufferfish.addComponent("RAW_FISH:3", 160);
            allItems.Add(e_pufferfish);

            Item e_prismarine_shard = new Item("ENCHANTED_PRISMARINE_SHARD");
            e_prismarine_shard.addComponent("PRISMARINE_SHARD", 80);
            allItems.Add(e_prismarine_shard);

            Item e_prismarine_crystals = new Item("ENCHANTED_PRISMARINE_CRYSTALS");
            e_prismarine_crystals.addComponent("PRISMARINE_CRYSTALS", 80);
            allItems.Add(e_prismarine_crystals);

            Item e_clay_ball = new Item("ENCHANTED_CLAY_BALL");
            e_clay_ball.addComponent("CLAY_BALL", 160);
            allItems.Add(e_clay_ball);

            Item e_water_lily = new Item("ENCHANTED_WATER_LILY");
            e_water_lily.addComponent("WATER_LILY", 160);
            allItems.Add(e_water_lily);

            Item e_ink_sack = new Item("ENCHANTED_INK_SACK");
            e_ink_sack.addComponent("INK_SACK", 80);
            allItems.Add(e_ink_sack);

            Item e_sponge = new Item("ENCHANTED_SPONGE");
            e_sponge.addComponent("SPONGE", 40);
            allItems.Add(e_sponge);

            Item e_wet_sponge = new Item("ENCHANTED_WET_SPONGE");
            e_wet_sponge.addComponent("ENCHANTED_SPONGE", 40);
            allItems.Add(e_wet_sponge);
        }
        public static Dictionary<Item, double> getInstantProfit()
        {
            Dictionary<Item, double> itemValues = new Dictionary<Item, double>();
            for (int i = 0; i < allItems.Count; i++)
            {
                itemValues.Add(allItems[i], allItems[i].InstantProfits());
            }
            // Orders Item Values based on values
            itemValues = itemValues.OrderByDescending(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            return itemValues;
        }
        public static Dictionary<Item, double> getGradualProfit()
        {
            Dictionary<Item, double> itemValues = new Dictionary<Item, double>();
            for (int i = 0; i < allItems.Count; i++)
            {
                itemValues.Add(allItems[i], allItems[i].GradualToGradualProfits());
            }
            itemValues = itemValues.OrderByDescending(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            return itemValues;
        }

        public static Dictionary<Item, double> getGradualtoInstantProfit()
        {
            Dictionary<Item, double> itemValues = new Dictionary<Item, double>();
            for (int i = 0; i < allItems.Count; i++)
            {
                itemValues.Add(allItems[i], allItems[i].GradualToInstantProfits());
            }
            itemValues = itemValues.OrderByDescending(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            return itemValues;
        }
        public static Dictionary<Item, double> getInstanttoGradualProfit()
        {
            Dictionary<Item, double> itemValues = new Dictionary<Item, double>();
            for (int i = 0; i < allItems.Count; i++)
            {
                itemValues.Add(allItems[i], allItems[i].InstantToGradualProfits());
            }
            itemValues = itemValues.OrderByDescending(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            return itemValues;
        }
    }
}
