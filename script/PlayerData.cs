using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
	// Token: 0x060023FD RID: 9213 RVA: 0x000D36D8 File Offset: 0x000D18D8
	private Dictionary<string, PlayerData.MapBools> InitMapBools()
	{
		Dictionary<string, PlayerData.MapBools> dictionary = new Dictionary<string, PlayerData.MapBools>();
		dictionary.Add("Town", PlayerData.MapBools.MapDirtmouth);
		dictionary.Add("Tutorial_01", PlayerData.MapBools.MapDirtmouth);
		dictionary.Add("Abyss_03", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_04", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_05", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_06_Core", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_06_Core_b", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_08", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_09", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_10", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_12", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_16", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_17", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_18", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_18_b", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_19", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_20", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_21", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Abyss_22", PlayerData.MapBools.MapAbyss);
		dictionary.Add("Crossroads_49b", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_01", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_02", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_03", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_04", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_05", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_05b", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_06", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_09", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_17", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_18", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_18_b", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_23", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_24", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_25", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_27", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_28", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_29", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_30", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_31", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_31_top", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_31_top_2", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins1_32", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_01", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_03", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_04", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_05", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_06", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_07", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_07_left", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_07_right", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_08", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_09", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_10_b", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_11", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_11_b", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins2_Watcher_Room", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins_Bathhouse", PlayerData.MapBools.MapCity);
		dictionary.Add("Ruins_Elevator", PlayerData.MapBools.MapCity);
		dictionary.Add("Cliffs_01", PlayerData.MapBools.MapCliffs);
		dictionary.Add("Cliffs_01_b", PlayerData.MapBools.MapCliffs);
		dictionary.Add("Cliffs_02", PlayerData.MapBools.MapCliffs);
		dictionary.Add("Cliffs_02_b", PlayerData.MapBools.MapCliffs);
		dictionary.Add("Cliffs_04", PlayerData.MapBools.MapCliffs);
		dictionary.Add("Cliffs_05", PlayerData.MapBools.MapCliffs);
		dictionary.Add("Cliffs_06", PlayerData.MapBools.MapCliffs);
		dictionary.Add("Cliffs_06_b", PlayerData.MapBools.MapCliffs);
		dictionary.Add("Fungus1_28", PlayerData.MapBools.MapCliffs);
		dictionary.Add("Fungus1_28_b", PlayerData.MapBools.MapCliffs);
		dictionary.Add("Crossroads_01", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_02", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_03", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_04", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_05", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_06", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_07", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_08", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_09", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_10", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_11_alt", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_12", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_13", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_14", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_15", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_16", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_18", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_19", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_21", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_22", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_25", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_27", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_30", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_31", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_33", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_35", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_36", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_37", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_38", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_39", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_40", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_42", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_43", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_45", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_46", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_47", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_48", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_49", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Crossroads_52", PlayerData.MapBools.MapCrossroads);
		dictionary.Add("Mines_01", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_02", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_03", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_04", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_05", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_06", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_07", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_10", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_11", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_13", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_16", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_17", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_18", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_19", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_20", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_20_b", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_23", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_24", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_25", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_28", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_28_b", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_29", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_30", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_31", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_32", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_34", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_36", PlayerData.MapBools.MapMines);
		dictionary.Add("Mines_37", PlayerData.MapBools.MapMines);
		dictionary.Add("Abyss_03_b", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_01b", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_02", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_03", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_09", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_10", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_14", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_16", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_17", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_26", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_26_b", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_30", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_30_b", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_31", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_32", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_33", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_34", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_35", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_36", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_37", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_38", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_39", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_40", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_41", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_41_b", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_42", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_44", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Deepnest_44_b", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Fungus2_25", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Room_Mask_maker", PlayerData.MapBools.MapDeepnest);
		dictionary.Add("Fungus3_01", PlayerData.MapBools.MapFogCanyon);
		dictionary.Add("Fungus3_02", PlayerData.MapBools.MapFogCanyon);
		dictionary.Add("Fungus3_03", PlayerData.MapBools.MapFogCanyon);
		dictionary.Add("Fungus3_24", PlayerData.MapBools.MapFogCanyon);
		dictionary.Add("Fungus3_25", PlayerData.MapBools.MapFogCanyon);
		dictionary.Add("Fungus3_25b", PlayerData.MapBools.MapFogCanyon);
		dictionary.Add("Fungus3_26", PlayerData.MapBools.MapFogCanyon);
		dictionary.Add("Fungus3_27", PlayerData.MapBools.MapFogCanyon);
		dictionary.Add("Fungus3_28", PlayerData.MapBools.MapFogCanyon);
		dictionary.Add("Fungus3_30", PlayerData.MapBools.MapFogCanyon);
		dictionary.Add("Fungus3_35", PlayerData.MapBools.MapFogCanyon);
		dictionary.Add("Fungus3_44", PlayerData.MapBools.MapFogCanyon);
		dictionary.Add("Fungus3_47", PlayerData.MapBools.MapFogCanyon);
		dictionary.Add("Deepnest_01", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_01", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_02", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_03", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_04", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_05", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_06", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_07", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_08", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_09", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_10", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_11", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_12", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_13", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_14", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_14_b", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_14_c", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_15", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_17", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_18", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_19", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_20", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_21", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_23", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_26", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_28", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_29", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_30", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_31", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_32", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_29_b", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_33", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus2_34", PlayerData.MapBools.MapFungalWastes);
		dictionary.Add("Fungus1_01", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_01b", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_02", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_03", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_04", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_05", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_06", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_07", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_08", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_09", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_09_b", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_10", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_11", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_12", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_13", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_14", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_14_b", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_15", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_16_alt", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_17", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_19", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_20_v02", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_21", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_22", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_25", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_26", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_29", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_30", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_31", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_32", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_34", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_37", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Fungus1_Slug", PlayerData.MapBools.MapGreenpath);
		dictionary.Add("Abyss_03_c", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_01", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_02", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_02b", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_03", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_04", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_06", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_07", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_08", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_09", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_09_b", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_10", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_11", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_12", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_13", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_14", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_15", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_16", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_18", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_Hornet", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_East_Hornet_b", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Hive_01", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Hive_02", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Hive_03", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Hive_03_b", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Hive_04", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Hive_04_b", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Hive_05", PlayerData.MapBools.MapOutskirts);
		dictionary.Add("Deepnest_43", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Deepnest_43_b", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus1_23", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus1_24", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_04", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_05", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_08", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_10", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_11", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_13", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_21", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_22", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_22_b", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_23", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_23_b", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_34", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_39", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_40", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_48", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_48_bot", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_48_left", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_48_top", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_49", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Fungus3_50", PlayerData.MapBools.MapRoyalGardens);
		dictionary.Add("Crossroads_46b", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("Crossroads_50", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("RestingGrounds_02", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("RestingGrounds_04", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("RestingGrounds_05", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("RestingGrounds_06", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("RestingGrounds_08", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("RestingGrounds_09", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("RestingGrounds_10_b", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("RestingGrounds_10_c", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("RestingGrounds_10_d", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("RestingGrounds_12", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("RestingGrounds_17", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("Ruins2_10", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("RestingGrounds_10", PlayerData.MapBools.MapRestingGrounds);
		dictionary.Add("Abyss_01", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Abyss_02", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_01", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_02", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_02b", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_03", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_04", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_04_part_b", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_04b", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_05", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_06", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_07", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_08", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_09", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_12", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_13", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_14", PlayerData.MapBools.MapWaterways);
		dictionary.Add("Waterways_15", PlayerData.MapBools.MapWaterways);
		return dictionary;
	}

	// Token: 0x060023FE RID: 9214 RVA: 0x000D46BC File Offset: 0x000D28BC
	private bool HasMapForScene(string sceneName)
	{
		if (this.mapZoneBools == null)
		{
			this.mapZoneBools = this.InitMapBools();
		}
		if (!this.mapZoneBools.ContainsKey(sceneName))
		{
			return true;
		}
		switch (this.mapZoneBools[sceneName])
		{
		case PlayerData.MapBools.MapDirtmouth:
			return this.mapDirtmouth;
		case PlayerData.MapBools.MapCrossroads:
			return this.mapCrossroads;
		case PlayerData.MapBools.MapGreenpath:
			return this.mapGreenpath;
		case PlayerData.MapBools.MapFogCanyon:
			return this.mapFogCanyon;
		case PlayerData.MapBools.MapRoyalGardens:
			return this.mapRoyalGardens;
		case PlayerData.MapBools.MapFungalWastes:
			return this.mapFungalWastes;
		case PlayerData.MapBools.MapCity:
			return this.mapCity;
		case PlayerData.MapBools.MapWaterways:
			return this.mapWaterways;
		case PlayerData.MapBools.MapMines:
			return this.mapMines;
		case PlayerData.MapBools.MapDeepnest:
			return this.mapDeepnest;
		case PlayerData.MapBools.MapCliffs:
			return this.mapCliffs;
		case PlayerData.MapBools.MapOutskirts:
			return this.mapOutskirts;
		case PlayerData.MapBools.MapRestingGrounds:
			return this.mapRestingGrounds;
		case PlayerData.MapBools.MapAbyss:
			return this.mapAbyss;
		default:
			return false;
		}
	}

	// Token: 0x06002401 RID: 9217 RVA: 0x0001ABA4 File Offset: 0x00018DA4
	public void PrintStory()
	{
		Debug.Log("combining player story");
		this.playerStoryOutput = string.Join(",", this.playerStory.ToArray());
	}

	// Token: 0x06002402 RID: 9218 RVA: 0x0001ABCB File Offset: 0x00018DCB
	public void Reset()
	{
		this.SetupNewPlayerData();
	}

	// Token: 0x06002403 RID: 9219 RVA: 0x000D47A8 File Offset: 0x000D29A8
	public bool UpdateGameMap()
	{
		bool result = false;
		if (this.hasQuill)
		{
			foreach (string text in this.scenesVisited)
			{
				if (!this.scenesMapped.Contains(text) && this.HasMapForScene(text))
				{
					this.scenesMapped.Add(text);
					result = true;
				}
			}
		}
		return result;
	}

	// Token: 0x06002404 RID: 9220 RVA: 0x000D4834 File Offset: 0x000D2A34
	public void CheckAllMaps()
	{
		if (this.mapCrossroads && this.mapGreenpath && this.mapFogCanyon && this.mapRoyalGardens && this.mapFungalWastes && this.mapCity && this.mapWaterways && this.mapMines && this.mapDeepnest && this.mapCliffs && this.mapOutskirts && this.mapRestingGrounds && this.mapAbyss)
		{
			this.corniferAtHome = true;
		}
	}

	// Token: 0x06002405 RID: 9221 RVA: 0x000D48D8 File Offset: 0x000D2AD8
	public void SetBool(string boolName, bool value)
	{
		FieldInfo field = base.GetType().GetField(boolName);
		if (field != null)
		{
			field.SetValue(this, value);
		}
		else
		{
			Debug.Log("PlayerData: Could not find field named " + boolName + ", check variable name exists and FSM variable string is correct.");
		}
	}

	// Token: 0x06002406 RID: 9222 RVA: 0x000D4924 File Offset: 0x000D2B24
	public void SetInt(string intName, int value)
	{
		FieldInfo field = base.GetType().GetField(intName);
		if (field != null)
		{
			field.SetValue(this, value);
		}
		else
		{
			Debug.Log("PlayerData: Could not find field named " + intName + ", check variable name exists and FSM variable string is correct.");
		}
	}

	// Token: 0x06002407 RID: 9223 RVA: 0x000D4970 File Offset: 0x000D2B70
	public void IncrementInt(string intName)
	{
		FieldInfo field = base.GetType().GetField(intName);
		if (field != null)
		{
			int num = (int)field.GetValue(this);
			field.SetValue(this, num + 1);
		}
		else
		{
			Debug.Log("PlayerData: Could not find field named " + intName + ", check variable name exists and FSM variable string is correct.");
		}
	}

	// Token: 0x06002408 RID: 9224 RVA: 0x000D49D0 File Offset: 0x000D2BD0
	public void IntAdd(string intName, int amount)
	{
		FieldInfo field = base.GetType().GetField(intName);
		if (field != null)
		{
			int num = (int)field.GetValue(this);
			field.SetValue(this, num + amount);
		}
		else
		{
			Debug.Log("PlayerData: Could not find field named " + intName + ", check variable name exists and FSM variable string is correct.");
		}
	}

	// Token: 0x06002409 RID: 9225 RVA: 0x000D4A30 File Offset: 0x000D2C30
	public void SetFloat(string floatName, float value)
	{
		FieldInfo field = base.GetType().GetField(floatName);
		if (field != null)
		{
			field.SetValue(this, value);
		}
		else
		{
			Debug.Log("PlayerData: Could not find field named " + floatName + ", check variable name exists and FSM variable string is correct.");
		}
	}

	// Token: 0x0600240A RID: 9226 RVA: 0x000D4A7C File Offset: 0x000D2C7C
	public void DecrementInt(string intName)
	{
		FieldInfo field = base.GetType().GetField(intName);
		if (field != null)
		{
			int num = (int)field.GetValue(this);
			field.SetValue(this, num - 1);
		}
	}

	// Token: 0x0600240B RID: 9227 RVA: 0x000D4AC8 File Offset: 0x000D2CC8
	public bool GetBool(string boolName)
	{
		if (string.IsNullOrEmpty(boolName))
		{
			return false;
		}
		FieldInfo field = base.GetType().GetField(boolName);
		if (field != null)
		{
			return (bool)field.GetValue(this);
		}
		Debug.Log("PlayerData: Could not find bool named " + boolName + " in PlayerData");
		return false;
	}

	// Token: 0x0600240C RID: 9228 RVA: 0x000D4B1C File Offset: 0x000D2D1C
	public int GetInt(string intName)
	{
		if (string.IsNullOrEmpty(intName))
		{
			Debug.LogError("PlayerData: Int with an EMPTY name requested.");
			return -9999;
		}
		FieldInfo field = base.GetType().GetField(intName);
		if (field != null)
		{
			return (int)field.GetValue(this);
		}
		Debug.LogError("PlayerData: Could not find int named " + intName + " in PlayerData");
		return -9999;
	}

	// Token: 0x0600240D RID: 9229 RVA: 0x000D4B84 File Offset: 0x000D2D84
	public float GetFloat(string floatName)
	{
		if (string.IsNullOrEmpty(floatName))
		{
			Debug.LogError("PlayerData: Float with an EMPTY name requested.");
			return -9999f;
		}
		FieldInfo field = base.GetType().GetField(floatName);
		if (field != null)
		{
			return (float)field.GetValue(this);
		}
		Debug.LogError("PlayerData: Could not find int named " + floatName + " in PlayerData");
		return -9999f;
	}

	// Token: 0x0600240E RID: 9230 RVA: 0x000D4BEC File Offset: 0x000D2DEC
	public string GetString(string stringName)
	{
		if (string.IsNullOrEmpty(stringName))
		{
			Debug.LogError("PlayerData: String with an EMPTY name requested.");
			return " ";
		}
		FieldInfo field = base.GetType().GetField(stringName);
		if (field != null)
		{
			return (string)field.GetValue(this);
		}
		Debug.LogError("PlayerData: Could not find string named " + stringName + " in PlayerData");
		return " ";
	}

	// Token: 0x0600240F RID: 9231 RVA: 0x000D4C54 File Offset: 0x000D2E54
	public void SetString(string stringName, string value)
	{
		FieldInfo field = base.GetType().GetField(stringName);
		if (field != null)
		{
			field.SetValue(this, value);
		}
		else
		{
			Debug.Log("PlayerData: Could not find field named " + stringName + ", check variable name exists and FSM variable string is correct.");
		}
	}

	// Token: 0x06002410 RID: 9232 RVA: 0x000D4C9C File Offset: 0x000D2E9C
	public void SetVector3(string vectorName, Vector3 value)
	{
		FieldInfo field = base.GetType().GetField(vectorName);
		if (field != null)
		{
			field.SetValue(this, value);
		}
		else
		{
			Debug.Log("PlayerData: Could not find field named " + vectorName + ", check variable name exists and FSM variable string is correct.");
		}
	}

	// Token: 0x06002411 RID: 9233 RVA: 0x000D4CE8 File Offset: 0x000D2EE8
	public Vector3 GetVector3(string vectorName)
	{
		FieldInfo field = base.GetType().GetField(vectorName);
		if (field != null)
		{
			return (Vector3)field.GetValue(this);
		}
		Debug.LogError("PlayerData: Could not find string named " + vectorName + " in PlayerData");
		return Vector3.zero;
	}

	// Token: 0x06002412 RID: 9234 RVA: 0x0001ABD3 File Offset: 0x00018DD3
	public void AddHealth(int amount)
	{
		if (this.health + amount >= this.maxHealth)
		{
			this.health = this.maxHealth;
		}
		else
		{
			this.health += amount;
		}
	}

	// Token: 0x06002413 RID: 9235 RVA: 0x000D4D34 File Offset: 0x000D2F34
	public void TakeHealth(int amount)
	{
		if (this.healthBlue > 0)
		{
			this.damagedBlue = true;
			this.healthBlue -= amount;
			if (this.healthBlue < 0)
			{
				this.health += this.healthBlue;
			}
		}
		else
		{
			this.damagedBlue = false;
			if (this.health - amount <= 0)
			{
				this.health = 0;
			}
			else
			{
				this.health -= amount;
			}
		}
	}

	// Token: 0x06002414 RID: 9236 RVA: 0x0001AC07 File Offset: 0x00018E07
	public void MaxHealth()
	{
		this.prevHealth = this.health;
		this.health = this.maxHealth;
		this.blockerHits = 4;
		this.UpdateBlueHealth();
	}

	// Token: 0x06002415 RID: 9237 RVA: 0x000D4DB8 File Offset: 0x000D2FB8
	public void AddToMaxHealth(int amount)
	{
		this.maxHealthBase += amount;
		if (!this.equippedCharm_27)
		{
			this.maxHealth += amount;
		}
		this.prevHealth = this.health;
		this.health = this.maxHealth;
		if (this.maxHealthBase == this.maxHealthCap)
		{
			this.heartPieceMax = true;
		}
	}

	// Token: 0x06002416 RID: 9238 RVA: 0x0001AC2E File Offset: 0x00018E2E
	public void UpdateBlueHealth()
	{
		this.healthBlue = 0;
		if (this.equippedCharm_8)
		{
			this.healthBlue += 2;
		}
		if (this.equippedCharm_9)
		{
			this.healthBlue += 4;
		}
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x0001AC69 File Offset: 0x00018E69
	public void AddGeo(int amount)
	{
		this.geo += amount;
		if (this.geo > 9999999)
		{
			this.geo = 9999999;
		}
	}

	// Token: 0x06002418 RID: 9240 RVA: 0x0001AC94 File Offset: 0x00018E94
	public void TakeGeo(int amount)
	{
		this.geo -= amount;
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x0001ACA4 File Offset: 0x00018EA4
	public bool WouldDie(int damage)
	{
		return this.health - damage <= 0;
	}

	// Token: 0x0600241A RID: 9242 RVA: 0x000D4E24 File Offset: 0x000D3024
	public void AddMPCharge(int amount)
	{
		if (this.MPCharge + amount > this.maxMP)
		{
			if (this.MPReserve < this.MPReserveMax)
			{
				this.MPReserve += amount - (this.maxMP - this.MPCharge);
				if (this.MPReserve > this.MPReserveMax)
				{
					this.MPReserve = this.MPReserveMax;
				}
			}
			this.MPCharge = this.maxMP;
		}
		else
		{
			this.MPCharge += amount;
		}
	}

	// Token: 0x0600241B RID: 9243 RVA: 0x0001ACB7 File Offset: 0x00018EB7
	public void TakeMP(int amount)
	{
		if (amount <= this.MPCharge)
		{
			this.MPCharge -= amount;
			if (this.MPCharge < 0)
			{
				this.MPCharge = 0;
			}
		}
		else
		{
			this.MPCharge = 0;
		}
	}

	// Token: 0x0600241C RID: 9244 RVA: 0x0001ACF2 File Offset: 0x00018EF2
	public void TakeReserveMP(int amount)
	{
		this.MPReserve -= amount;
		if (this.MPReserve < 0)
		{
			this.MPReserve = 0;
		}
	}

	// Token: 0x0600241D RID: 9245 RVA: 0x0001AD15 File Offset: 0x00018F15
	public void ClearMP()
	{
		this.MPCharge = 0;
		this.MPReserve = 0;
	}

	// Token: 0x0600241E RID: 9246 RVA: 0x0001AD25 File Offset: 0x00018F25
	public void AddToMaxMPReserve(int amount)
	{
		this.MPReserveMax += amount;
		if (this.MPReserveMax == this.MPReserveCap)
		{
			this.vesselFragmentMax = true;
		}
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x0001AD4D File Offset: 0x00018F4D
	public void StartSoulLimiter()
	{
		this.soulLimited = true;
		this.maxMP = 66;
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x0001AD5E File Offset: 0x00018F5E
	public void EndSoulLimiter()
	{
		this.soulLimited = false;
		this.maxMP = 100;
	}

	// Token: 0x06002421 RID: 9249 RVA: 0x0001AD6F File Offset: 0x00018F6F
	public void EquipCharm(int charmNum)
	{
		this.equippedCharms.Add(charmNum);
	}

	// Token: 0x06002422 RID: 9250 RVA: 0x0001AD7D File Offset: 0x00018F7D
	public void UnequipCharm(int charmNum)
	{
		this.equippedCharms.RemoveAt(this.equippedCharms.IndexOf(charmNum));
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x000D4EB0 File Offset: 0x000D30B0
	public void CalculateNotchesUsed()
	{
		int num = 0;
		if (this.equippedCharm_1)
		{
			num += this.charmCost_1;
		}
		if (this.equippedCharm_2)
		{
			num += this.charmCost_2;
		}
		if (this.equippedCharm_3)
		{
			num += this.charmCost_3;
		}
		if (this.equippedCharm_4)
		{
			num += this.charmCost_4;
		}
		if (this.equippedCharm_5)
		{
			num += this.charmCost_5;
		}
		if (this.equippedCharm_6)
		{
			num += this.charmCost_6;
		}
		if (this.equippedCharm_7)
		{
			num += this.charmCost_7;
		}
		if (this.equippedCharm_8)
		{
			num += this.charmCost_8;
		}
		if (this.equippedCharm_9)
		{
			num += this.charmCost_9;
		}
		if (this.equippedCharm_10)
		{
			num += this.charmCost_10;
		}
		if (this.equippedCharm_11)
		{
			num += this.charmCost_11;
		}
		if (this.equippedCharm_12)
		{
			num += this.charmCost_12;
		}
		if (this.equippedCharm_13)
		{
			num += this.charmCost_13;
		}
		if (this.equippedCharm_14)
		{
			num += this.charmCost_14;
		}
		if (this.equippedCharm_15)
		{
			num += this.charmCost_15;
		}
		if (this.equippedCharm_16)
		{
			num += this.charmCost_16;
		}
		if (this.equippedCharm_17)
		{
			num += this.charmCost_17;
		}
		if (this.equippedCharm_18)
		{
			num += this.charmCost_18;
		}
		if (this.equippedCharm_19)
		{
			num += this.charmCost_19;
		}
		if (this.equippedCharm_20)
		{
			num += this.charmCost_20;
		}
		if (this.equippedCharm_21)
		{
			num += this.charmCost_21;
		}
		if (this.equippedCharm_22)
		{
			num += this.charmCost_22;
		}
		if (this.equippedCharm_23)
		{
			num += this.charmCost_23;
		}
		if (this.equippedCharm_24)
		{
			num += this.charmCost_24;
		}
		if (this.equippedCharm_25)
		{
			num += this.charmCost_25;
		}
		if (this.equippedCharm_26)
		{
			num += this.charmCost_26;
		}
		if (this.equippedCharm_27)
		{
			num += this.charmCost_27;
		}
		if (this.equippedCharm_28)
		{
			num += this.charmCost_28;
		}
		if (this.equippedCharm_29)
		{
			num += this.charmCost_29;
		}
		if (this.equippedCharm_30)
		{
			num += this.charmCost_30;
		}
		if (this.equippedCharm_31)
		{
			num += this.charmCost_31;
		}
		if (this.equippedCharm_32)
		{
			num += this.charmCost_32;
		}
		if (this.equippedCharm_33)
		{
			num += this.charmCost_33;
		}
		if (this.equippedCharm_34)
		{
			num += this.charmCost_34;
		}
		if (this.equippedCharm_35)
		{
			num += this.charmCost_35;
		}
		if (this.equippedCharm_36)
		{
			num += this.charmCost_36;
		}
		if (this.equippedCharm_37)
		{
			num += this.charmCost_37;
		}
		if (this.equippedCharm_38)
		{
			num += this.charmCost_38;
		}
		if (this.equippedCharm_39)
		{
			num += this.charmCost_39;
		}
		if (this.equippedCharm_40)
		{
			num += this.charmCost_40;
		}
		this.charmSlotsFilled = num;
	}

	// Token: 0x06002425 RID: 9253 RVA: 0x0001ADBE File Offset: 0x00018FBE
	public void SetBenchRespawn(string spawnMarker, string sceneName, bool facingRight)
	{
		this.respawnMarkerName = spawnMarker;
		this.respawnScene = sceneName;
		this.respawnFacingRight = facingRight;
	}

	// Token: 0x06002426 RID: 9254 RVA: 0x0001ADD5 File Offset: 0x00018FD5
	public void SetBenchRespawn(string spawnMarker, string sceneName, int spawnType, bool facingRight)
	{
		this.respawnMarkerName = spawnMarker;
		this.respawnScene = sceneName;
		this.respawnType = spawnType;
		this.respawnFacingRight = facingRight;
	}
		
	// Token: 0x06002428 RID: 9256 RVA: 0x0001AE13 File Offset: 0x00019013
	public void SetHazardRespawn(Vector3 position, bool facingRight)
	{
		this.hazardRespawnLocation = position;
		this.hazardRespawnFacingRight = facingRight;
	}

	// Token: 0x06002429 RID: 9257 RVA: 0x000D51E8 File Offset: 0x000D33E8
	public void CountGameCompletion()
	{
		this.completionPercentage = 0f;
		this.CountCharms();
		this.completionPercentage += (float)this.charmsOwned;
		if (this.killedFalseKnight)
		{
			this.completionPercentage += 1f;
		}
		if (this.hornet1Defeated)
		{
			this.completionPercentage += 1f;
		}
		if (this.hornetOutskirtsDefeated)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedMantisLord)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedMageLord)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedDungDefender)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedBlackKnight)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedInfectedKnight)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedMimicSpider)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedMegaJellyfish)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedTraitorLord)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedJarCollector)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedBigFly)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedMawlek)
		{
			this.completionPercentage += 1f;
		}
		if (this.colosseumBronzeCompleted)
		{
			this.completionPercentage += 1f;
		}
		if (this.colosseumSilverCompleted)
		{
			this.completionPercentage += 1f;
		}
		if (this.colosseumGoldCompleted)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostAladar)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostHu)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostXero)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostMarkoth)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostNoEyes)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostMarmu)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGhostGalien)
		{
			this.completionPercentage += 1f;
		}
		this.completionPercentage += (float)this.fireballLevel;
		this.completionPercentage += (float)this.quakeLevel;
		this.completionPercentage += (float)this.screamLevel;
		if (this.hasCyclone)
		{
			this.completionPercentage += 1f;
		}
		if (this.hasDashSlash)
		{
			this.completionPercentage += 1f;
		}
		if (this.hasUpwardSlash)
		{
			this.completionPercentage += 1f;
		}
		if (this.hasDash)
		{
			this.completionPercentage += 2f;
		}
		if (this.hasWalljump)
		{
			this.completionPercentage += 2f;
		}
		if (this.hasDoubleJump)
		{
			this.completionPercentage += 2f;
		}
		if (this.hasAcidArmour)
		{
			this.completionPercentage += 2f;
		}
		if (this.hasSuperDash)
		{
			this.completionPercentage += 2f;
		}
		if (this.hasShadowDash)
		{
			this.completionPercentage += 2f;
		}
		if (this.hasKingsBrand)
		{
			this.completionPercentage += 2f;
		}
		if (this.lurienDefeated)
		{
			this.completionPercentage += 1f;
		}
		if (this.hegemolDefeated)
		{
			this.completionPercentage += 1f;
		}
		if (this.monomonDefeated)
		{
			this.completionPercentage += 1f;
		}
		if (this.hasDreamNail)
		{
			this.completionPercentage += 1f;
		}
		if (this.dreamNailUpgraded)
		{
			this.completionPercentage += 1f;
		}
		if (this.mothDeparted)
		{
			this.completionPercentage += 1f;
		}
		this.completionPercentage += (float)this.nailSmithUpgrades;
		this.completionPercentage += (float)(this.maxHealthBase - 5);
		int mpreserveMax = this.MPReserveMax;
		if (mpreserveMax != 33)
		{
			if (mpreserveMax != 66)
			{
				if (mpreserveMax == 99)
				{
					this.completionPercentage += 3f;
				}
			}
			else
			{
				this.completionPercentage += 2f;
			}
		}
		else
		{
			this.completionPercentage += 1f;
		}
		if (this.killedGrimm)
		{
			this.completionPercentage += 1f;
		}
		if (this.killedNightmareGrimm || this.destroyedNightmareLantern)
		{
			this.completionPercentage += 1f;
		}
	}

	// Token: 0x0600242A RID: 9258 RVA: 0x000D57B8 File Offset: 0x000D39B8
	public void CountCharms()
	{
		this.charmsOwned = 0;
		if (this.gotCharm_1)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_2)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_3)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_4)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_5)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_6)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_7)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_8)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_9)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_10)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_11)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_12)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_13)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_14)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_15)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_16)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_17)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_18)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_19)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_20)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_21)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_22)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_23)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_24)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_25)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_26)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_27)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_28)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_29)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_30)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_31)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_32)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_33)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_34)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_35)
		{
			this.charmsOwned++;
		}
		if (this.royalCharmState > 2)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_37)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_38)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_39)
		{
			this.charmsOwned++;
		}
		if (this.gotCharm_40)
		{
			this.charmsOwned++;
		}
	}

	// Token: 0x0600242B RID: 9259 RVA: 0x000D5BB8 File Offset: 0x000D3DB8
	public void CountJournalEntries()
	{
		this.journalEntriesCompleted = 0;
		this.journalNotesCompleted = 0;
		this.journalEntriesTotal = 143;
		if (this.killedCrawler)
		{
			this.journalEntriesCompleted += 2;
		}
		if (this.killedBuzzer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBouncer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedClimber)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedHopper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedWorm)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSpitter)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedHatcher)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedHatchling)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieRunner)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieHornhead)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieLeaper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieBarger)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieShield)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieGuard)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBigBuzzer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBigFly)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMawlek)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFalseKnight)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedRoller)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBlocker)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedPrayerSlug)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMenderBug)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedMossmanRunner)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMossmanShaker)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMosquito)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBlobFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFungifiedZombie)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedPlantShooter)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMossCharger)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMegaMossCharger)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSnapperTrap)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMossKnight)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGrassHopper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedAcidFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedAcidWalker)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMossFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMossKnightFat)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMossWalker)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedInfectedKnight)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedLazyFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZapBug)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedJellyfish)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedJellyCrawler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMegaJellyfish)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFungoonBaby)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMushroomTurret)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMantis)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMushroomRoller)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMushroomBrawler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMushroomBaby)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMantisFlyerChild)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFungusFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFungCrawler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMantisLord)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBlackKnight)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMage)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMageKnight)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedRoyalDandy)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedRoyalCoward)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedRoyalPlumper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFlyingSentrySword)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFlyingSentryJavelin)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSentry)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSentryFat)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMageBlob)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGreatShieldZombie)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedJarCollector)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMageBalloon)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMageLord)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGorgeousHusk)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFlipHopper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFlukeman)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedInflater)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFlukefly)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedFlukeMother)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedDungDefender)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedCrystalCrawler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedCrystalFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedLaserBug)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBeamMiner)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieMiner)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMegaBeamMiner)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMinesCrawler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedAngryBuzzer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBurstingBouncer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBurstingZombie)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSpittingZombie)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBabyCentipede)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBigCentipede)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedCentipedeHatcher)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedLesserMawlek)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSlashSpider)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSpiderCorpse)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedShootSpider)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMiniSpider)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSpiderFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMimicSpider)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBeeHatchling)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBeeStinger)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBigBee)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedBlowFly)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedCeilingDropper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGiantHopper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGrubMimic)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMawlekTurret)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedOrangeScuttler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedHealthScuttler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedPigeon)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZombieHive)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedHornet)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedAbyssCrawler)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSuperSpitter)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedSibling)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedAbyssTendril)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedPalaceFly)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedEggSac)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMummy)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedOrangeBalloon)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedHeavyMantis)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedTraitorLord)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedMantisHeavyFlyer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGardenZombie)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedRoyalGuard)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedWhiteRoyal)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedOblobble)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedZote)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedBlobble)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColMosquito)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColRoller)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColFlyingSentry)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColMiner)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColShield)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColWorm)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedColHopper)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedElectricMage)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedLobsterLancer)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostAladar)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostXero)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostHu)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostMarmu)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostNoEyes)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostMarkoth)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedGhostGalien)
		{
			this.journalEntriesCompleted++;
		}
		if (this.killedWhiteDefender)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedGreyPrince)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedZotelingBuzzer)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedZotelingHopper)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedZotelingBalloon)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedHollowKnight)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedFinalBoss)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedFlameBearerSmall)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedFlameBearerMed)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedFlameBearerLarge)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedGrimm)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killedNightmareGrimm)
		{
			this.journalEntriesCompleted++;
			this.journalEntriesTotal++;
		}
		if (this.killsCrawler == 0)
		{
			this.journalNotesCompleted += 2;
		}
		if (this.killsBuzzer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBouncer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsClimber == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHopper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsWorm == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSpitter == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHatcher == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHatchling == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieRunner == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieHornhead == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieLeaper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieBarger == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieShield == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieGuard == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBigBuzzer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBigFly == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMawlek == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFalseKnight == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsRoller == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBlocker == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsPrayerSlug == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMenderBug == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossmanRunner == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossmanShaker == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMosquito == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBlobFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFungifiedZombie == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsPlantShooter == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossCharger == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMegaMossCharger == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSnapperTrap == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossKnight == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGrassHopper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsAcidFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsAcidWalker == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossKnightFat == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMossWalker == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsInfectedKnight == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsLazyFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZapBug == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsJellyfish == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsJellyCrawler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMegaJellyfish == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFungoonBaby == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMushroomTurret == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMantis == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMushroomRoller == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMushroomBrawler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMushroomBaby == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMantisFlyerChild == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFungusFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFungCrawler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMantisLord == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBlackKnight == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMage == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMageKnight == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsRoyalDandy == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsRoyalCoward == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsRoyalPlumper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFlyingSentrySword == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFlyingSentryJavelin == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSentry == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSentryFat == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMageBlob == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGreatShieldZombie == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsJarCollector == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMageBalloon == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMageLord == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGorgeousHusk == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFlipHopper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFlukeman == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsInflater == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFlukefly == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFlukeMother == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsDungDefender == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsCrystalCrawler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsCrystalFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsLaserBug == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBeamMiner == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieMiner == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMegaBeamMiner == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMinesCrawler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsAngryBuzzer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBurstingBouncer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBurstingZombie == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSpittingZombie == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBabyCentipede == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBigCentipede == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsCentipedeHatcher == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsLesserMawlek == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSlashSpider == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSpiderCorpse == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsShootSpider == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMiniSpider == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSpiderFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMimicSpider == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBeeHatchling == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBeeStinger == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBigBee == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBlowFly == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsCeilingDropper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGiantHopper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGrubMimic == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMawlekTurret == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsOrangeScuttler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHealthScuttler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsPigeon == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZombieHive == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHornet == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsAbyssCrawler == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSuperSpitter == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsSibling == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsAbyssTendril == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsPalaceFly == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsEggSac == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMummy == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsOrangeBalloon == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHeavyMantis == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsTraitorLord == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsMantisHeavyFlyer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGardenZombie == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsRoyalGuard == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsWhiteRoyal == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsOblobble == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsZote == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsBlobble == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColMosquito == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColRoller == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColFlyingSentry == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColMiner == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColShield == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColWorm == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsColHopper == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsElectricMage == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsLobsterLancer == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostAladar == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostXero == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostHu == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostMarmu == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostNoEyes == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostMarkoth == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsGhostGalien == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedWhiteDefender)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedGreyPrince)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedZotelingBuzzer)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedZotelingHopper)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedZotelingBalloon)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsHollowKnight == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killsFinalBoss == 0)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedFlameBearerSmall)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedFlameBearerMed)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedFlameBearerLarge)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedGrimm)
		{
			this.journalNotesCompleted++;
		}
		if (this.killedNightmareGrimm)
		{
			this.journalNotesCompleted++;
		}
	}

	// Token: 0x0600242C RID: 9260 RVA: 0x000D7B1C File Offset: 0x000D5D1C
	private void SetupNewPlayerData()
	{
		this.openingCreditsPlayed = false;
		this.playTime = 0f;
		this.completionPercent = 0f;
		this.permadeathMode = 0;
		this.version = "1.2.2.1";
		this.health = 5;
		this.maxHealth = 5;
		this.maxHealthBase = 5;
		this.healthBlue = 0;
		this.joniHealthBlue = 0;
		this.damagedBlue = false;
		this.heartPieces = 0;
		this.heartPieceCollected = false;
		this.maxHealthCap = 9;
		this.heartPieceMax = false;
		this.prevHealth = this.health;
		this.blockerHits = 4;
		this.firstGeo = false;
		this.geo = 0;
		this.maxMP = 99;
		this.MPCharge = 0;
		this.MPReserve = 0;
		this.MPReserveMax = 0;
		this.soulLimited = false;
		this.focusMP_amount = 33;
		this.vesselFragments = 0;
		this.vesselFragmentCollected = false;
		this.MPReserveCap = 99;
		this.vesselFragmentMax = false;
		this.atBench = false;
		this.respawnScene = "Tutorial_01";
		this.respawnMarkerName = "Death Respawn Marker";
		this.respawnType = 0;
		this.respawnFacingRight = false;
		this.hazardRespawnFacingRight = false;
		this.shadeScene = "None";
		this.shadeMapZone = string.Empty;
		this.shadePositionX = 0f;
		this.shadePositionY = 0f;
		this.shadeHealth = 0;
		this.shadeMP = 0;
		this.shadeFireballLevel = 0;
		this.shadeQuakeLevel = 0;
		this.shadeScreamLevel = 0;
		this.shadeSpecialType = 0;
		this.shadeMapPos = new Vector3(0f, 0f, 0f);
		this.dreamgateMapPos = new Vector3(0f, 0f, 0f);
		this.geoPool = 0;
		this.nailDamage = 5;
		this.nailRange = 0;
		this.beamDamage = 0;
		this.canDash = false;
		this.canBackDash = false;
		this.canWallJump = false;
		this.canSuperDash = false;
		this.canShadowDash = false;
		this.hasSpell = false;
		this.fireballLevel = 0;
		this.quakeLevel = 0;
		this.screamLevel = 0;
		this.hasNailArt = false;
		this.hasCyclone = false;
		this.hasDashSlash = false;
		this.hasUpwardSlash = false;
		this.hasAllNailArts = false;
		this.hasDreamNail = false;
		this.hasDreamGate = false;
		this.dreamNailUpgraded = false;
		this.dreamOrbs = 0;
		this.dreamOrbsSpent = 0;
		this.dreamGateScene = string.Empty;
		this.dreamGateX = 0f;
		this.dreamGateY = 0f;
		this.hasDash = false;
		this.hasWalljump = false;
		this.hasSuperDash = false;
		this.hasShadowDash = false;
		this.hasAcidArmour = false;
		this.hasDoubleJump = false;
		this.hasLantern = false;
		this.hasTramPass = false;
		this.hasQuill = false;
		this.hasCityKey = false;
		this.hasSlykey = false;
		this.gaveSlykey = false;
		this.hasWhiteKey = false;
		this.usedWhiteKey = false;
		this.hasMenderKey = false;
		this.hasWaterwaysKey = false;
		this.hasSpaKey = false;
		this.hasLoveKey = false;
		this.hasKingsBrand = false;
		this.hasXunFlower = false;
		this.ghostCoins = 0;
		this.ore = 0;
		this.foundGhostCoin = false;
		this.trinket1 = 0;
		this.foundTrinket1 = false;
		this.trinket2 = 0;
		this.foundTrinket2 = false;
		this.trinket3 = 0;
		this.foundTrinket3 = false;
		this.trinket4 = 0;
		this.foundTrinket4 = false;
		this.noTrinket1 = false;
		this.noTrinket2 = false;
		this.noTrinket3 = false;
		this.noTrinket4 = false;
		this.soldTrinket1 = 0;
		this.soldTrinket2 = 0;
		this.soldTrinket3 = 0;
		this.soldTrinket4 = 0;
		this.simpleKeys = 0;
		this.rancidEggs = 0;
		this.notchShroomOgres = false;
		this.notchFogCanyon = false;
		this.gMap_doorX = 0f;
		this.gMap_doorY = 0f;
		this.gMap_doorScene = string.Empty;
		this.gMap_doorMapZone = string.Empty;
		this.gMap_doorOriginOffsetX = 0f;
		this.gMap_doorOriginOffsetY = 0f;
		this.gMap_doorSceneWidth = 0f;
		this.gMap_doorSceneHeight = 0f;
		this.guardiansDefeated = 0;
		this.lurienDefeated = false;
		this.hegemolDefeated = false;
		this.monomonDefeated = false;
		this.maskBrokenLurien = false;
		this.maskBrokenHegemol = false;
		this.maskBrokenMonomon = false;
		this.maskToBreak = 0;
		this.elderbug = 0;
		this.metElderbug = false;
		this.elderbugReintro = false;
		this.elderbugHistory = 0;
		this.elderbugHistory1 = false;
		this.elderbugHistory2 = false;
		this.elderbugHistory3 = false;
		this.elderbugSpeechSly = false;
		this.elderbugSpeechStation = false;
		this.elderbugSpeechEggTemple = false;
		this.elderbugSpeechMapShop = false;
		this.elderbugSpeechBretta = false;
		this.elderbugSpeechJiji = false;
		this.elderbugSpeechMinesLift = false;
		this.elderbugSpeechKingsPass = false;
		this.elderbugSpeechInfectedCrossroads = false;
		this.elderbugSpeechFinalBossDoor = false;
		this.elderbugRequestedFlower = false;
		this.elderbugGaveFlower = false;
		this.metQuirrel = false;
		this.quirrelEggTemple = 0;
		this.quirrelLeftEggTemple = false;
		this.quirrelSlugShrine = 0;
		this.quirrelRuins = 0;
		this.quirrelMines = 0;
		this.quirrelLeftStation = false;
		this.quirrelCityEncountered = false;
		this.quirrelCityLeft = false;
		this.quirrelMinesEncountered = false;
		this.quirrelMinesLeft = false;
		this.visitedDeepnestSpa = false;
		this.quirrelSpaReady = false;
		this.quirrelSpaEncountered = false;
		this.quirrelArchiveEncountered = false;
		this.quirrelEpilogueCompleted = false;
		this.quirrelMantisEncountered = false;
		this.enteredMantisLordArea = false;
		this.metRelicDealer = false;
		this.metRelicDealerShop = false;
		this.marmOutside = false;
		this.marmOutsideConvo = false;
		this.marmConvo1 = false;
		this.marmConvo2 = false;
		this.marmConvo3 = false;
		this.marmConvoNailsmith = false;
		this.cornifer = 0;
		this.metCornifer = false;
		this.corniferIntroduced = false;
		this.corniferAtHome = false;
		this.corn_crossroadsEncountered = false;
		this.corn_crossroadsLeft = false;
		this.corn_greenpathEncountered = false;
		this.corn_greenpathLeft = false;
		this.corn_fogCanyonEncountered = false;
		this.corn_fogCanyonLeft = false;
		this.corn_fungalWastesEncountered = false;
		this.corn_fungalWastesLeft = false;
		this.corn_cityEncountered = false;
		this.corn_cityLeft = false;
		this.corn_waterwaysEncountered = false;
		this.corn_waterwaysLeft = false;
		this.corn_minesEncountered = false;
		this.corn_minesLeft = false;
		this.corn_cliffsEncountered = false;
		this.corn_cliffsLeft = false;
		this.corn_deepnestEncountered = false;
		this.corn_deepnestLeft = false;
		this.corn_deepnestMet1 = false;
		this.corn_deepnestMet2 = false;
		this.corn_outskirtsEncountered = false;
		this.corn_outskirtsLeft = false;
		this.corn_royalGardensEncountered = false;
		this.corn_royalGardensLeft = false;
		this.corn_abyssEncountered = false;
		this.corn_abyssLeft = false;
		this.metIselda = false;
		this.iseldaCorniferHomeConvo = false;
		this.iseldaConvo1 = false;
		this.brettaRescued = false;
		this.brettaPosition = 0;
		this.brettaState = 0;
		this.brettaSeenBench = false;
		this.brettaSeenBed = false;
		this.brettaSeenBenchDiary = false;
		this.brettaSeenBedDiary = false;
		this.brettaLeftTown = false;
		this.slyRescued = false;
		this.slyBeta = false;
		this.metSlyShop = false;
		this.gotSlyCharm = false;
		this.slyShellFrag1 = false;
		this.slyShellFrag2 = false;
		this.slyShellFrag3 = false;
		this.slyShellFrag4 = false;
		this.slyVesselFrag1 = false;
		this.slyVesselFrag2 = false;
		this.slyVesselFrag3 = false;
		this.slyVesselFrag4 = false;
		this.slyNotch1 = false;
		this.slyNotch2 = false;
		this.slySimpleKey = false;
		this.slyRancidEgg = false;
		this.slyConvoNailArt = false;
		this.slyConvoMapper = false;
		this.slyConvoNailHoned = false;
		this.jijiDoorUnlocked = false;
		this.jijiMet = false;
		this.jijiShadeOffered = false;
		this.jijiShadeCharmConvo = false;
		this.metJinn = false;
		this.jinnConvo1 = false;
		this.jinnConvo2 = false;
		this.jinnConvo3 = false;
		this.jinnConvoKingBrand = false;
		this.jinnConvoShadeCharm = false;
		this.jinnEggsSold = 0;
		this.zote = 0;
		this.zoteDead = false;
		this.zoteDeathPos = 0;
		this.zoteRescuedBuzzer = false;
		this.zoteSpokenCity = false;
		this.zoteLeftCity = false;
		this.zoteRescuedDeepnest = false;
		this.zoteDefeated = false;
		this.zoteTrappedDeepnest = false;
		this.zoteSpokenColosseum = false;
		this.zotePrecept = 1;
		this.zoteTownConvo = 0;
		this.shaman = 0;
		this.shamanScreamConvo = false;
		this.shamanQuakeConvo = false;
		this.shamanFireball2Convo = false;
		this.shamanScream2Convo = false;
		this.shamanQuake2Convo = false;
		this.metMiner = false;
		this.miner = 0;
		this.minerEarly = 0;
		this.hornetGreenpath = 0;
		this.hornetFung = 0;
		this.hornet_f19 = false;
		this.hornetFountainEncounter = false;
		this.hornetCityBridge_ready = false;
		this.hornetCityBridge_completed = false;
		this.hornetAbyssEncounter = false;
		this.hornetDenEncounter = false;
		this.metMoth = false;
		this.ignoredMoth = false;
		this.gladeDoorOpened = false;
		this.mothDeparted = false;
		this.completedRGDreamPlant = false;
		this.dreamReward1 = false;
		this.dreamReward2 = false;
		this.dreamReward3 = false;
		this.dreamReward4 = false;
		this.dreamReward5 = false;
		this.dreamReward5b = false;
		this.dreamReward6 = false;
		this.dreamReward7 = false;
		this.dreamReward8 = false;
		this.dreamReward9 = false;
		this.dreamMothConvo1 = false;
		this.bankerAccountPurchased = false;
		this.metBanker = false;
		this.bankerBalance = 0;
		this.bankerDeclined = false;
		this.bankerTheftCheck = false;
		this.bankerTheft = 0;
		this.bankerSpaMet = false;
		this.metGiraffe = false;
		this.metCharmSlug = false;
		this.salubraNotch1 = false;
		this.salubraNotch2 = false;
		this.salubraNotch3 = false;
		this.salubraNotch4 = false;
		this.salubraBlessing = false;
		this.salubraConvoCombo = false;
		this.salubraConvoOvercharm = false;
		this.salubraConvoTruth = false;
		this.cultistTransformed = false;
		this.metNailsmith = false;
		this.honedNail = false;
		this.nailSmithUpgrades = 0;
		this.nailsmithCliff = false;
		this.nailsmithKilled = false;
		this.nailsmithSpared = false;
		this.nailsmithKillSpeech = false;
		this.nailsmithSheo = false;
		this.nailsmithConvoArt = false;
		this.metNailmasterMato = false;
		this.metNailmasterSheo = false;
		this.metNailmasterOro = false;
		this.matoConvoSheo = false;
		this.matoConvoOro = false;
		this.matoConvoSly = false;
		this.sheoConvoMato = false;
		this.sheoConvoOro = false;
		this.sheoConvoSly = false;
		this.sheoConvoNailsmith = false;
		this.oroConvoSheo = false;
		this.oroConvoMato = false;
		this.oroConvoSly = false;
		this.hunterRoared = false;
		this.metHunter = false;
		this.hunterRewardOffered = false;
		this.huntersMarkOffered = false;
		this.hasHuntersMark = false;
		this.metLegEater = false;
		this.paidLegEater = false;
		this.refusedLegEater = false;
		this.legEaterBrokenConvo = false;
		this.legEaterDungConvo = false;
		this.legEaterInfectedCrossroadConvo = false;
		this.legEaterBoughtConvo = false;
		this.legEaterConvo1 = false;
		this.legEaterConvo2 = false;
		this.legEaterConvo3 = false;
		this.legEaterGoldConvo = false;
		this.legEaterLeft = false;
		this.tukMet = false;
		this.tukEggPrice = 0;
		this.tukDungEgg = false;
		this.metEmilitia = false;
		this.emilitiaKingsBrandConvo = false;
		this.metCloth = false;
		this.clothEnteredTramRoom = false;
		this.savedCloth = false;
		this.clothEncounteredQueensGarden = false;
		this.clothKilled = false;
		this.clothInTown = false;
		this.clothLeftTown = false;
		this.clothGhostSpoken = false;
		this.bigCatHitTail = false;
		this.bigCatHitTailConvo = false;
		this.bigCatMeet = false;
		this.bigCatTalk1 = false;
		this.bigCatTalk2 = false;
		this.bigCatTalk3 = false;
		this.bigCatKingsBrandConvo = false;
		this.bigCatShadeConvo = false;
		this.tisoEncounteredTown = false;
		this.tisoEncounteredBench = false;
		this.tisoEncounteredLake = false;
		this.tisoEncounteredColosseum = false;
		this.tisoShieldConvo = false;
		this.tisoDead = false;
		this.mossCultist = 0;
		this.maskmakerMet = false;
		this.maskmakerConvo1 = false;
		this.maskmakerConvo2 = false;
		this.maskmakerUnmasked1 = false;
		this.maskmakerUnmasked2 = false;
		this.maskmakerShadowDash = false;
		this.maskmakerKingsBrand = false;
		this.dungDefenderConvo1 = false;
		this.dungDefenderConvo2 = false;
		this.dungDefenderConvo3 = false;
		this.dungDefenderCharmConvo = false;
		this.dungDefenderIsmaConvo = false;
		this.midwifeMet = false;
		this.midwifeConvo1 = false;
		this.midwifeConvo2 = false;
		this.metQueen = false;
		this.queenTalk1 = false;
		this.queenTalk2 = false;
		this.queenDung1 = false;
		this.queenDung2 = false;
		this.queenHornet = false;
		this.queenTalkExtra = false;
		this.gotQueenFragment = false;
		this.gotKingFragment = false;
		this.metXun = false;
		this.xunFlowerBroken = false;
		this.xunFlowerBrokeTimes = 0;
		this.xunFlowerGiven = false;
		this.xunRewardGiven = false;
		this.xunFailedConvo1 = false;
		this.xunFailedConvo2 = true;
		this.menderState = 0;
		this.menderSignBroken = false;
		this.allBelieverTabletsDestroyed = false;
		this.mrMushroomState = 0;
		this.openedMapperShop = false;
		this.openedSlyShop = false;
		this.metStag = false;
		this.travelling = false;
		this.stagPosition = -1;
		this.stationsOpened = 0;
		this.stagConvoTram = false;
		this.stagConvoTiso = false;
		this.stagRemember1 = false;
		this.stagRemember2 = false;
		this.stagRemember3 = false;
		this.stagEggInspected = false;
		this.stagHopeConvo = false;
		this.nextScene = string.Empty;
		this.littleFoolMet = false;
		this.ranAway = false;
		this.seenColosseumTitle = false;
		this.colosseumBronzeOpened = false;
		this.colosseumBronzeCompleted = false;
		this.colosseumSilverOpened = false;
		this.colosseumSilverCompleted = false;
		this.colosseumGoldOpened = false;
		this.colosseumGoldCompleted = false;
		this.openedTown = true;
		this.openedTownBuilding = false;
		this.openedCrossroads = false;
		this.openedGreenpath = false;
		this.openedFungalWastes = false;
		this.openedRuins1 = false;
		this.openedRuins2 = false;
		this.openedRoyalGardens = false;
		this.openedRestingGrounds = false;
		this.openedDeepnest = false;
		this.openedStagNest = false;
		this.openedHiddenStation = false;
		this.dreamReturnScene = "Dream_NailCollection";
		this.charmSlots = 3;
		this.charmSlotsFilled = 0;
		this.hasCharm = false;
		this.equippedCharms = new List<int>();
		this.charmBenchMsg = false;
		this.charmsOwned = 0;
		this.canOvercharm = false;
		this.overcharmed = false;
		this.gotCharm_1 = false;
		this.equippedCharm_1 = false;
		this.charmCost_1 = 1;
		this.newCharm_1 = true;
		this.gotCharm_2 = false;
		this.equippedCharm_2 = false;
		this.charmCost_2 = 1;
		this.newCharm_2 = true;
		this.gotCharm_3 = false;
		this.equippedCharm_3 = false;
		this.charmCost_3 = 1;
		this.newCharm_3 = true;
		this.gotCharm_4 = false;
		this.equippedCharm_4 = false;
		this.charmCost_4 = 2;
		this.newCharm_4 = true;
		this.gotCharm_5 = false;
		this.equippedCharm_5 = false;
		this.charmCost_5 = 2;
		this.newCharm_5 = true;
		this.gotCharm_6 = false;
		this.equippedCharm_6 = false;
		this.charmCost_6 = 2;
		this.newCharm_6 = true;
		this.gotCharm_7 = false;
		this.equippedCharm_7 = false;
		this.charmCost_7 = 3;
		this.newCharm_7 = true;
		this.gotCharm_8 = false;
		this.equippedCharm_8 = false;
		this.charmCost_8 = 2;
		this.newCharm_8 = true;
		this.gotCharm_9 = false;
		this.equippedCharm_9 = false;
		this.charmCost_9 = 3;
		this.newCharm_9 = true;
		this.gotCharm_10 = false;
		this.equippedCharm_10 = false;
		this.charmCost_10 = 1;
		this.newCharm_10 = true;
		this.gotCharm_11 = false;
		this.equippedCharm_11 = false;
		this.charmCost_11 = 2;
		this.newCharm_11 = true;
		this.gotCharm_12 = false;
		this.equippedCharm_12 = false;
		this.charmCost_12 = 1;
		this.newCharm_12 = true;
		this.gotCharm_13 = false;
		this.equippedCharm_13 = false;
		this.charmCost_13 = 3;
		this.newCharm_13 = true;
		this.gotCharm_14 = false;
		this.equippedCharm_14 = false;
		this.charmCost_14 = 1;
		this.newCharm_14 = true;
		this.gotCharm_15 = false;
		this.equippedCharm_15 = false;
		this.charmCost_15 = 2;
		this.newCharm_15 = true;
		this.gotCharm_16 = false;
		this.equippedCharm_16 = false;
		this.charmCost_16 = 2;
		this.newCharm_16 = true;
		this.gotCharm_17 = false;
		this.equippedCharm_17 = false;
		this.charmCost_17 = 1;
		this.newCharm_17 = true;
		this.gotCharm_18 = false;
		this.equippedCharm_18 = false;
		this.charmCost_18 = 2;
		this.newCharm_18 = true;
		this.gotCharm_19 = false;
		this.equippedCharm_19 = false;
		this.charmCost_19 = 3;
		this.newCharm_19 = true;
		this.gotCharm_20 = false;
		this.equippedCharm_20 = false;
		this.charmCost_20 = 2;
		this.newCharm_20 = true;
		this.gotCharm_21 = false;
		this.equippedCharm_21 = false;
		this.charmCost_21 = 4;
		this.newCharm_21 = true;
		this.gotCharm_22 = false;
		this.equippedCharm_22 = false;
		this.charmCost_22 = 2;
		this.newCharm_22 = true;
		this.gotCharm_23 = false;
		this.equippedCharm_23 = false;
		this.brokenCharm_23 = false;
		this.charmCost_23 = 2;
		this.newCharm_23 = true;
		this.gotCharm_24 = false;
		this.equippedCharm_24 = false;
		this.brokenCharm_24 = false;
		this.charmCost_24 = 2;
		this.newCharm_24 = true;
		this.gotCharm_25 = false;
		this.equippedCharm_25 = false;
		this.brokenCharm_25 = false;
		this.charmCost_25 = 3;
		this.newCharm_25 = true;
		this.gotCharm_26 = false;
		this.equippedCharm_26 = false;
		this.charmCost_26 = 1;
		this.newCharm_26 = true;
		this.gotCharm_27 = false;
		this.equippedCharm_27 = false;
		this.charmCost_27 = 4;
		this.newCharm_27 = true;
		this.gotCharm_28 = false;
		this.equippedCharm_28 = false;
		this.charmCost_28 = 2;
		this.newCharm_28 = true;
		this.gotCharm_29 = false;
		this.equippedCharm_29 = false;
		this.charmCost_29 = 4;
		this.newCharm_29 = true;
		this.gotCharm_30 = false;
		this.equippedCharm_30 = false;
		this.charmCost_30 = 1;
		this.newCharm_30 = true;
		this.gotCharm_31 = false;
		this.equippedCharm_31 = false;
		this.charmCost_31 = 2;
		this.newCharm_31 = true;
		this.gotCharm_32 = false;
		this.equippedCharm_32 = false;
		this.charmCost_32 = 3;
		this.newCharm_32 = true;
		this.gotCharm_33 = false;
		this.equippedCharm_33 = false;
		this.charmCost_33 = 2;
		this.newCharm_33 = true;
		this.gotCharm_34 = false;
		this.equippedCharm_34 = false;
		this.charmCost_34 = 4;
		this.newCharm_34 = true;
		this.gotCharm_35 = false;
		this.equippedCharm_35 = false;
		this.charmCost_35 = 3;
		this.newCharm_35 = true;
		this.gotCharm_36 = false;
		this.equippedCharm_36 = false;
		this.charmCost_36 = 0;
		this.newCharm_36 = true;
		this.gotCharm_37 = false;
		this.equippedCharm_37 = false;
		this.charmCost_37 = 1;
		this.newCharm_37 = false;
		this.gotCharm_38 = false;
		this.equippedCharm_38 = false;
		this.charmCost_38 = 3;
		this.newCharm_38 = false;
		this.gotCharm_39 = false;
		this.equippedCharm_39 = false;
		this.charmCost_39 = 2;
		this.newCharm_39 = false;
		this.gotCharm_40 = false;
		this.equippedCharm_40 = false;
		this.charmCost_40 = 2;
		this.newCharm_40 = false;
		this.fragileHealth_unbreakable = false;
		this.fragileGreed_unbreakable = false;
		this.fragileStrength_unbreakable = false;
		this.royalCharmState = 0;
		this.hasJournal = false;
		this.lastJournalItem = 0;
		this.killedDummy = false;
		this.killsDummy = 0;
		this.newDataDummy = false;
		this.seenJournalMsg = false;
		this.seenHunterMsg = false;
		this.fillJournal = false;
		this.journalEntriesCompleted = 0;
		this.journalNotesCompleted = 0;
		this.journalEntriesTotal = 0;
		this.killedCrawler = true;
		this.killsCrawler = 0;
		this.newDataCrawler = false;
		this.killedBuzzer = false;
		this.killsBuzzer = 45;
		this.newDataBuzzer = false;
		this.killedBouncer = false;
		this.killsBouncer = 30;
		this.newDataBouncer = false;
		this.killedClimber = false;
		this.killsClimber = 30;
		this.newDataClimber = false;
		this.killedHopper = false;
		this.killsHopper = 30;
		this.newDataHopper = false;
		this.killedWorm = false;
		this.killsWorm = 10;
		this.newDataWorm = false;
		this.killedSpitter = false;
		this.killsSpitter = 20;
		this.newDataSpitter = false;
		this.killedHatcher = false;
		this.killsHatcher = 15;
		this.newDataHatcher = false;
		this.killedHatchling = false;
		this.killsHatchling = 30;
		this.newDataHatchling = false;
		this.killedZombieRunner = false;
		this.killsZombieRunner = 35;
		this.newDataZombieRunner = false;
		this.killedZombieHornhead = false;
		this.killsZombieHornhead = 35;
		this.newDataZombieHornhead = false;
		this.killedZombieLeaper = false;
		this.killsZombieLeaper = 35;
		this.newDataZombieLeaper = false;
		this.killedZombieBarger = false;
		this.killsZombieBarger = 35;
		this.newDataZombieBarger = false;
		this.killedZombieShield = false;
		this.killsZombieShield = 25;
		this.newDataZombieShield = false;
		this.killedZombieGuard = false;
		this.killsZombieGuard = 10;
		this.newDataZombieGuard = false;
		this.killedBigBuzzer = false;
		this.killsBigBuzzer = 2;
		this.newDataBigBuzzer = false;
		this.killedBigFly = false;
		this.killsBigFly = 3;
		this.newDataBigFly = false;
		this.killedMawlek = false;
		this.killsMawlek = 1;
		this.newDataMawlek = false;
		this.killedFalseKnight = false;
		this.killsFalseKnight = 1;
		this.newDataFalseKnight = false;
		this.killedRoller = false;
		this.killsRoller = 20;
		this.newDataRoller = false;
		this.killedBlocker = false;
		this.killsBlocker = 1;
		this.newDataBlocker = false;
		this.killedPrayerSlug = false;
		this.killsPrayerSlug = 2;
		this.newDataPrayerSlug = false;
		this.killedMenderBug = false;
		this.killsMenderBug = 1;
		this.newDataMenderBug = false;
		this.killedMossmanRunner = false;
		this.killsMossmanRunner = 25;
		this.newDataMossmanRunner = false;
		this.killedMossmanShaker = false;
		this.killsMossmanShaker = 25;
		this.newDataMossmanShaker = false;
		this.killedMosquito = false;
		this.killsMosquito = 30;
		this.newDataMosquito = false;
		this.killedBlobFlyer = false;
		this.killsBlobFlyer = 20;
		this.newDataBlobFlyer = false;
		this.killedFungifiedZombie = false;
		this.killsFungifiedZombie = 10;
		this.newDataFungifiedZombie = false;
		this.killedPlantShooter = false;
		this.killsPlantShooter = 15;
		this.newDataPlantShooter = false;
		this.killedMossCharger = false;
		this.killsMossCharger = 15;
		this.newDataMossCharger = false;
		this.killedMegaMossCharger = false;
		this.killsMegaMossCharger = 1;
		this.newDataMegaMossCharger = false;
		this.killedSnapperTrap = false;
		this.killsSnapperTrap = 15;
		this.newDataSnapperTrap = false;
		this.killedMossKnight = false;
		this.killsMossKnight = 10;
		this.newDataMossKnight = false;
		this.killedGrassHopper = false;
		this.killsGrassHopper = 15;
		this.newDataGrassHopper = false;
		this.killedAcidFlyer = false;
		this.killsAcidFlyer = 8;
		this.newDataAcidFlyer = false;
		this.killedAcidWalker = false;
		this.killsAcidWalker = 8;
		this.newDataAcidWalker = false;
		this.killedMossFlyer = false;
		this.killsMossFlyer = 30;
		this.newDataMossFlyer = false;
		this.killedMossKnightFat = false;
		this.killsMossKnightFat = 10;
		this.newDataMossKnightFat = false;
		this.killedMossWalker = false;
		this.killsMossWalker = 35;
		this.newDataMossWalker = false;
		this.killedInfectedKnight = false;
		this.killsInfectedKnight = 1;
		this.newDataInfectedKnight = false;
		this.killedLazyFlyer = false;
		this.killsLazyFlyer = 1;
		this.newDataLazyFlyer = false;
		this.killedZapBug = false;
		this.killsZapBug = 1;
		this.newDataZapBug = false;
		this.killedJellyfish = false;
		this.killsJellyfish = 12;
		this.newDataJellyfish = false;
		this.killedJellyCrawler = false;
		this.killsJellyCrawler = 25;
		this.newDataJellyCrawler = false;
		this.killedMegaJellyfish = false;
		this.killsMegaJellyfish = 1;
		this.newDataMegaJellyfish = false;
		this.killedFungoonBaby = false;
		this.killsFungoonBaby = 35;
		this.newDataFungoonBaby = false;
		this.killedMushroomTurret = false;
		this.killsMushroomTurret = 20;
		this.newDataMushroomTurret = false;
		this.killedMantis = false;
		this.killsMantis = 25;
		this.newDataMantis = false;
		this.killedMushroomRoller = false;
		this.killsMushroomRoller = 30;
		this.newDataMushroomRoller = false;
		this.killedMushroomBrawler = false;
		this.killsMushroomBrawler = 8;
		this.newDataMushroomBrawler = false;
		this.killedMushroomBaby = false;
		this.killsMushroomBaby = 20;
		this.newDataMushroomBaby = false;
		this.killedMantisFlyerChild = false;
		this.killsMantisFlyerChild = 25;
		this.newDataMantisFlyerChild = false;
		this.killedFungusFlyer = false;
		this.killsFungusFlyer = 20;
		this.newDataFungusFlyer = false;
		this.killedFungCrawler = false;
		this.killsFungCrawler = 15;
		this.newDataFungCrawler = false;
		this.killedMantisLord = false;
		this.killsMantisLord = 1;
		this.newDataMantisLord = false;
		this.killedBlackKnight = false;
		this.killsBlackKnight = 10;
		this.newDataBlackKnight = false;
		this.killedElectricMage = false;
		this.killsElectricMage = 6;
		this.newDataElectricMage = false;
		this.killedMage = false;
		this.killsMage = 20;
		this.newDataMage = false;
		this.killedMageKnight = false;
		this.killsMageKnight = 2;
		this.newDataMageKnight = false;
		this.killedRoyalDandy = false;
		this.killsRoyalDandy = 25;
		this.newDataRoyalDandy = false;
		this.killedRoyalCoward = false;
		this.killsRoyalCoward = 25;
		this.newDataRoyalCoward = false;
		this.killedRoyalPlumper = false;
		this.killsRoyalPlumper = 25;
		this.newDataRoyalPlumper = false;
		this.killedFlyingSentrySword = false;
		this.killsFlyingSentrySword = 35;
		this.newDataFlyingSentrySword = false;
		this.killedFlyingSentryJavelin = false;
		this.killsFlyingSentryJavelin = 30;
		this.newDataFlyingSentryJavelin = false;
		this.killedSentry = false;
		this.killsSentry = 30;
		this.newDataSentry = false;
		this.killedSentryFat = false;
		this.killsSentryFat = 20;
		this.newDataSentryFat = false;
		this.killedMageBlob = false;
		this.killsMageBlob = 25;
		this.newDataMageBlob = false;
		this.killedGreatShieldZombie = false;
		this.killsGreatShieldZombie = 10;
		this.newDataGreatShieldZombie = false;
		this.killedJarCollector = false;
		this.killsJarCollector = 1;
		this.newDataJarCollector = false;
		this.killedMageBalloon = false;
		this.killsMageBalloon = 15;
		this.newDataMageBalloon = false;
		this.killedMageLord = false;
		this.killsMageLord = 1;
		this.newDataMageLord = false;
		this.killedGorgeousHusk = false;
		this.killsGorgeousHusk = 1;
		this.newDataGorgeousHusk = false;
		this.killedFlipHopper = false;
		this.killsFlipHopper = 20;
		this.newDataFlipHopper = false;
		this.killedFlukeman = false;
		this.killsFlukeman = 20;
		this.newDataFlukeman = false;
		this.killedInflater = false;
		this.killsInflater = 20;
		this.newDataInflater = false;
		this.killedFlukefly = false;
		this.killsFlukefly = 15;
		this.newDataFlukefly = false;
		this.killedFlukeMother = false;
		this.killsFlukeMother = 1;
		this.newDataFlukeMother = false;
		this.killedDungDefender = false;
		this.killsDungDefender = 1;
		this.newDataDungDefender = false;
		this.killedCrystalCrawler = false;
		this.killsCrystalCrawler = 15;
		this.newDataCrystalCrawler = false;
		this.killedCrystalFlyer = false;
		this.killsCrystalFlyer = 20;
		this.newDataCrystalFlyer = false;
		this.killedLaserBug = false;
		this.killsLaserBug = 15;
		this.newDataLaserBug = false;
		this.killedBeamMiner = false;
		this.killsBeamMiner = 15;
		this.newDataBeamMiner = false;
		this.killedZombieMiner = false;
		this.killsZombieMiner = 20;
		this.newDataZombieMiner = false;
		this.killedMegaBeamMiner = false;
		this.killsMegaBeamMiner = 2;
		this.newDataMegaBeamMiner = false;
		this.killedMinesCrawler = false;
		this.killsMinesCrawler = 15;
		this.newDataMinesCrawler = false;
		this.killedAngryBuzzer = false;
		this.killsAngryBuzzer = 15;
		this.newDataAngryBuzzer = false;
		this.killedBurstingBouncer = false;
		this.killsBurstingBouncer = 15;
		this.newDataBurstingBouncer = false;
		this.killedBurstingZombie = false;
		this.killsBurstingZombie = 15;
		this.newDataBurstingZombie = false;
		this.killedSpittingZombie = false;
		this.killsSpittingZombie = 15;
		this.newDataSpittingZombie = false;
		this.killedBabyCentipede = false;
		this.killsBabyCentipede = 35;
		this.newDataBabyCentipede = false;
		this.killedBigCentipede = false;
		this.killsBigCentipede = 10;
		this.newDataBigCentipede = false;
		this.killedCentipedeHatcher = false;
		this.killsCentipedeHatcher = 15;
		this.newDataCentipedeHatcher = false;
		this.killedLesserMawlek = false;
		this.killsLesserMawlek = 10;
		this.newDataLesserMawlek = false;
		this.killedSlashSpider = false;
		this.killsSlashSpider = 15;
		this.newDataSlashSpider = false;
		this.killedSpiderCorpse = false;
		this.killsSpiderCorpse = 20;
		this.newDataSpiderCorpse = false;
		this.killedShootSpider = false;
		this.killsShootSpider = 20;
		this.newDataShootSpider = false;
		this.killedMiniSpider = false;
		this.killsMiniSpider = 25;
		this.newDataMiniSpider = false;
		this.killedSpiderFlyer = false;
		this.killsSpiderFlyer = 20;
		this.newDataSpiderFlyer = false;
		this.killedMimicSpider = false;
		this.killsMimicSpider = 1;
		this.newDataMimicSpider = false;
		this.killedBeeHatchling = false;
		this.killsBeeHatchling = 30;
		this.newDataBeeHatchling = false;
		this.killedBeeStinger = false;
		this.killsBeeStinger = 15;
		this.newDataBeeStinger = false;
		this.killedBigBee = false;
		this.killsBigBee = 12;
		this.newDataBigBee = false;
		this.killedBlowFly = false;
		this.killsBlowFly = 20;
		this.newDataBlowFly = false;
		this.killedCeilingDropper = false;
		this.killsCeilingDropper = 15;
		this.newDataCeilingDropper = false;
		this.killedGiantHopper = false;
		this.killsGiantHopper = 10;
		this.newDataGiantHopper = false;
		this.killedGrubMimic = false;
		this.killsGrubMimic = 5;
		this.newDataGrubMimic = false;
		this.killedMawlekTurret = false;
		this.killsMawlekTurret = 10;
		this.newDataMawlekTurret = false;
		this.killedOrangeScuttler = false;
		this.killsOrangeScuttler = 20;
		this.newDataOrangeScuttler = false;
		this.killedHealthScuttler = false;
		this.killsHealthScuttler = 10;
		this.newDataHealthScuttler = false;
		this.killedPigeon = false;
		this.killsPigeon = 15;
		this.newDataPigeon = false;
		this.killedZombieHive = false;
		this.killsZombieHive = 10;
		this.newDataZombieHive = false;
		this.killedDreamGuard = false;
		this.killsDreamGuard = 20;
		this.newDataDreamGuard = false;
		this.killedHornet = false;
		this.killsHornet = 2;
		this.newDataHornet = false;
		this.killedAbyssCrawler = false;
		this.killsAbyssCrawler = 20;
		this.newDataAbyssCrawler = false;
		this.killedSuperSpitter = false;
		this.killsSuperSpitter = 25;
		this.newDataSuperSpitter = false;
		this.killedSibling = false;
		this.killsSibling = 35;
		this.newDataSibling = false;
		this.killedPalaceFly = false;
		this.killsPalaceFly = 10;
		this.newDataPalaceFly = false;
		this.killedEggSac = false;
		this.killsEggSac = 5;
		this.newDataEggSac = false;
		this.killedMummy = false;
		this.killsMummy = 10;
		this.newDataMummy = false;
		this.killedOrangeBalloon = false;
		this.killsOrangeBalloon = 10;
		this.newDataOrangeBalloon = false;
		this.killedAbyssTendril = false;
		this.killsAbyssTendril = 10;
		this.newDataAbyssTendril = false;
		this.killedHeavyMantis = false;
		this.killsHeavyMantis = 15;
		this.newDataHeavyMantis = false;
		this.killedTraitorLord = false;
		this.killsTraitorLord = 1;
		this.newDataTraitorLord = false;
		this.killedMantisHeavyFlyer = false;
		this.killsMantisHeavyFlyer = 20;
		this.newDataMantisHeavyFlyer = false;
		this.killedGardenZombie = false;
		this.killsGardenZombie = 20;
		this.newDataGardenZombie = false;
		this.killedRoyalGuard = false;
		this.killsRoyalGuard = 2;
		this.newDataRoyalGuard = false;
		this.killedWhiteRoyal = false;
		this.killsWhiteRoyal = 10;
		this.newDataWhiteRoyal = false;
		this.killedOblobble = false;
		this.killsOblobble = 3;
		this.newDataOblobble = false;
		this.killedZote = false;
		this.killsZote = 1;
		this.newDataZote = false;
		this.killedBlobble = false;
		this.killsBlobble = 15;
		this.newDataBlobble = false;
		this.killedColMosquito = false;
		this.killsColMosquito = 15;
		this.newDataColMosquito = false;
		this.killedColRoller = false;
		this.killsColRoller = 20;
		this.newDataColRoller = false;
		this.killedColFlyingSentry = false;
		this.killsColFlyingSentry = 25;
		this.newDataColFlyingSentry = false;
		this.killedColMiner = false;
		this.killsColMiner = 25;
		this.newDataColMiner = false;
		this.killedColShield = false;
		this.killsColShield = 25;
		this.newDataColShield = false;
		this.killedColWorm = false;
		this.killsColWorm = 20;
		this.newDataColWorm = false;
		this.killedColHopper = false;
		this.killsColHopper = 15;
		this.newDataColHopper = false;
		this.killedLobsterLancer = false;
		this.killsLobsterLancer = 1;
		this.newDataLobsterLancer = false;
		this.killedGhostAladar = false;
		this.killsGhostAladar = 1;
		this.newDataGhostAladar = false;
		this.killedGhostXero = false;
		this.killsGhostXero = 1;
		this.newDataGhostXero = false;
		this.killedGhostHu = false;
		this.killsGhostHu = 1;
		this.newDataGhostHu = false;
		this.killedGhostMarmu = false;
		this.killsGhostMarmu = 1;
		this.newDataGhostMarmu = false;
		this.killedGhostNoEyes = false;
		this.killsGhostNoEyes = 1;
		this.newDataGhostNoEyes = false;
		this.killedGhostMarkoth = false;
		this.killsGhostMarkoth = 1;
		this.newDataGhostMarkoth = false;
		this.killedGhostGalien = false;
		this.killsGhostGalien = 1;
		this.newDataGhostGalien = false;
		this.killedWhiteDefender = false;
		this.killsWhiteDefender = 1;
		this.newDataWhiteDefender = false;
		this.killedGreyPrince = false;
		this.killsGreyPrince = 1;
		this.newDataGreyPrince = false;
		this.killedZotelingBalloon = false;
		this.killsZotelingBalloon = 1;
		this.newDataZotelingBalloon = false;
		this.killedZotelingHopper = false;
		this.killsZotelingHopper = 1;
		this.newDataZotelingHopper = false;
		this.killedZotelingBuzzer = false;
		this.killsZotelingBuzzer = 1;
		this.newDataZotelingBuzzer = false;
		this.killedHollowKnight = false;
		this.killsHollowKnight = 1;
		this.newDataHollowKnight = false;
		this.killedFinalBoss = false;
		this.killsFinalBoss = 1;
		this.newDataFinalBoss = false;
		this.killedHunterMark = false;
		this.killsHunterMark = 1;
		this.newDataHunterMark = false;
		this.killedFlameBearerSmall = false;
		this.killsFlameBearerSmall = 3;
		this.newDataFlameBearerSmall = false;
		this.killedFlameBearerMed = false;
		this.killsFlameBearerMed = 4;
		this.newDataFlameBearerMed = false;
		this.killedFlameBearerLarge = false;
		this.killsFlameBearerLarge = 5;
		this.newDataFlameBearerLarge = false;
		this.killedGrimm = false;
		this.killsGrimm = 1;
		this.newDataGrimm = false;
		this.killedNightmareGrimm = false;
		this.killsNightmareGrimm = 1;
		this.newDataNightmareGrimm = false;
		this.killedBindingSeal = false;
		this.killsBindingSeal = 1;
		this.newDataBindingSeal = false;
		this.grubsCollected = 0;
		this.grubRewards = 0;
		this.finalGrubRewardCollected = false;
		this.fatGrubKing = false;
		this.falseKnightDefeated = false;
		this.falseKnightDreamDefeated = false;
		this.falseKnightOrbsCollected = false;
		this.mawlekDefeated = false;
		this.giantBuzzerDefeated = false;
		this.giantFlyDefeated = false;
		this.blocker1Defeated = false;
		this.blocker2Defeated = false;
		this.hornet1Defeated = false;
		this.collectorDefeated = false;
		this.hornetOutskirtsDefeated = false;
		this.mageLordDreamDefeated = false;
		this.mageLordOrbsCollected = false;
		this.infectedKnightDreamDefeated = false;
		this.infectedKnightOrbsCollected = false;
		this.whiteDefenderDefeated = false;
		this.whiteDefenderOrbsCollected = false;
		this.whiteDefenderDefeats = 0;
		this.greyPrinceDefeats = 0;
		this.greyPrinceDefeated = false;
		this.greyPrinceOrbsCollected = false;
		this.aladarSlugDefeated = 0;
		this.xeroDefeated = 0;
		this.elderHuDefeated = 0;
		this.mumCaterpillarDefeated = 0;
		this.noEyesDefeated = 0;
		this.markothDefeated = 0;
		this.galienDefeated = 0;
		this.XERO_encountered = false;
		this.ALADAR_encountered = false;
		this.HU_encountered = false;
		this.MUMCAT_encountered = false;
		this.NOEYES_encountered = false;
		this.MARKOTH_encountered = false;
		this.GALIEN_encountered = false;
		this.xeroPinned = false;
		this.aladarPinned = false;
		this.huPinned = false;
		this.mumCaterpillarPinned = false;
		this.noEyesPinned = false;
		this.markothPinned = false;
		this.galienPinned = false;
		this.currentInvPane = 0;
		this.showGeoUI = false;
		this.showHealthUI = false;
		this.promptFocus = false;
		this.seenFocusTablet = false;
		this.seenDreamNailPrompt = false;
		this.isFirstGame = true;
		this.enteredTutorialFirstTime = false;
		this.isInvincible = false;
		this.infiniteAirJump = false;
		this.hazardRespawnLocation = Vector3.zero;
		this.currentArea = 0;
		this.visitedDirtmouth = false;
		this.visitedCrossroads = false;
		this.visitedGreenpath = false;
		this.visitedFungus = false;
		this.visitedHive = false;
		this.visitedCrossroadsInfected = false;
		this.visitedRuins = false;
		this.visitedMines = false;
		this.visitedRoyalGardens = false;
		this.visitedFogCanyon = false;
		this.visitedDeepnest = false;
		this.visitedRestingGrounds = false;
		this.visitedWaterways = false;
		this.visitedAbyss = false;
		this.visitedOutskirts = false;
		this.visitedWhitePalace = false;
		this.visitedCliffs = false;
		this.visitedAbyssLower = false;
		this.visitedMines10 = false;
		this.scenesVisited = new List<string>();
		this.scenesMapped = new List<string>();
		this.scenesMapped.Add("Cinematic_Stag_travel");
		this.scenesMapped.Add("Room_Town_Stag_Station");
		this.scenesMapped.Add("Room_Charm_Shop");
		this.scenesMapped.Add("Room_Mender_House");
		this.scenesMapped.Add("Room_mapper");
		this.scenesMapped.Add("Room_nailmaster");
		this.scenesMapped.Add("Room_nailmaster_02");
		this.scenesMapped.Add("Room_nailmaster_03");
		this.scenesMapped.Add("Room_shop");
		this.scenesMapped.Add("Room_nailsmith");
		this.scenesMapped.Add("Room_temple");
		this.scenesMapped.Add("Room_ruinhouse");
		this.scenesMapped.Add("Room_Mansion");
		this.scenesMapped.Add("Room_Tram");
		this.scenesMapped.Add("Room_Tram_RG");
		this.scenesMapped.Add("Room_Bretta");
		this.scenesMapped.Add("Room_Fungus_Shaman");
		this.scenesMapped.Add("Room_Ouiji");
		this.scenesMapped.Add("Room_Jinn");
		this.scenesMapped.Add("Room_Colosseum_01");
		this.scenesMapped.Add("Room_Colosseum_02");
		this.scenesMapped.Add("Room_Colosseum_03");
		this.scenesMapped.Add("Room_Colosseum_Bronze");
		this.scenesMapped.Add("Room_Colosseum_Silver");
		this.scenesMapped.Add("Room_Colosseum_Gold");
		this.scenesMapped.Add("Room_Slug_Shrine");
		this.scenesMapped.Add("Crossroads_ShamanTemple");
		this.scenesMapped.Add("Ruins_House_01");
		this.scenesMapped.Add("Ruins_House_02");
		this.scenesMapped.Add("Ruins_House_03");
		this.scenesMapped.Add("Fungus1_35");
		this.scenesMapped.Add("Fungus1_36");
		this.scenesMapped.Add("Fungus3_archive");
		this.scenesMapped.Add("Fungus3_archive_02");
		this.scenesMapped.Add("Cliffs_03");
		this.scenesMapped.Add("RestingGrounds_07");
		this.scenesMapped.Add("Deepnest_45_v02");
		this.scenesMapped.Add("Deepnest_Spider_Town");
		this.scenesMapped.Add("Room_spider_small");
		this.scenesMapped.Add("Room_Wyrm");
		this.scenesMapped.Add("Abyss_Lighthouse_room");
		this.scenesMapped.Add("Room_Queen");
		this.scenesMapped.Add("White_Palace_01");
		this.scenesMapped.Add("White_Palace_02");
		this.scenesMapped.Add("White_Palace_03_hub");
		this.scenesMapped.Add("White_Palace_04");
		this.scenesMapped.Add("White_Palace_05");
		this.scenesMapped.Add("White_Palace_06");
		this.scenesMapped.Add("White_Palace_07");
		this.scenesMapped.Add("White_Palace_08");
		this.scenesMapped.Add("White_Palace_09");
		this.scenesMapped.Add("White_Palace_11");
		this.scenesMapped.Add("White_Palace_12");
		this.scenesMapped.Add("White_Palace_13");
		this.scenesMapped.Add("White_Palace_14");
		this.scenesMapped.Add("White_Palace_15");
		this.scenesMapped.Add("White_Palace_16");
		this.scenesMapped.Add("Dream_Nailcollection");
		this.scenesMapped.Add("Dream_01_False_Knight");
		this.scenesMapped.Add("Dream_03_Infected_Knight");
		this.scenesMapped.Add("Dream_02_Mage_Lord");
		this.scenesMapped.Add("Dream_Guardian");
		this.scenesMapped.Add("Dream_Guardian_Hegemol");
		this.scenesMapped.Add("Dream_Guardian_Lurien");
		this.scenesMapped.Add("Dream_Guardian_Monomon");
		this.scenesMapped.Add("Cutscene_Boss_Door");
		this.scenesMapped.Add("Dream_Backer_Shrine");
		this.scenesMapped.Add("Dream_Room_Believer_Shrine");
		this.scenesMapped.Add("Dream_Abyss");
		this.scenesMapped.Add("Dream_Final_Boss");
		this.scenesMapped.Add("Room_Final_Boss_Atrium");
		this.scenesMapped.Add("Room_Final_Boss_Core");
		this.scenesMapped.Add("Cinematic_Ending_A");
		this.scenesMapped.Add("Cinematic_Ending_B");
		this.scenesMapped.Add("Cinematic_Ending_C");
		this.scenesMapped.Add("End_Credits");
		this.scenesMapped.Add("Cinematic_MrMushroom");
		this.scenesMapped.Add("End_Game_Completion");
		this.scenesMapped.Add("PermaDeath");
		this.scenesMapped.Add("PermaDeath_Unlock");
		this.scenesMapped.Add("Deepnest_East_17");
		this.scenesEncounteredBench = new List<string>();
		this.scenesEncounteredCocoon = new List<string>();
		this.scenesGrubRescued = new List<string>();
		this.scenesFlameCollected = new List<string>();
		this.scenesEncounteredDreamPlant = new List<string>();
		this.scenesEncounteredDreamPlantC = new List<string>();
		this.hasMap = false;
		this.mapAllRooms = false;
		this.atMapPrompt = false;
		this.mapDirtmouth = true;
		this.mapCrossroads = false;
		this.mapGreenpath = false;
		this.mapFogCanyon = false;
		this.mapRoyalGardens = false;
		this.mapFungalWastes = false;
		this.mapCity = false;
		this.mapWaterways = false;
		this.mapMines = false;
		this.mapDeepnest = false;
		this.mapCliffs = false;
		this.mapOutskirts = false;
		this.mapRestingGrounds = false;
		this.mapAbyss = false;
		this.hasPin = false;
		this.hasPinBench = false;
		this.hasPinCocoon = false;
		this.hasPinDreamPlant = false;
		this.hasPinGuardian = false;
		this.hasPinBlackEgg = false;
		this.hasPinShop = false;
		this.hasPinSpa = false;
		this.hasPinStag = false;
		this.hasPinTram = false;
		this.hasPinGhost = false;
		this.hasPinGrub = false;
		this.environmentType = 0;
		this.previousDarkness = 0;
		this.openedTramLower = false;
		this.openedTramRestingGrounds = false;
		this.tramLowerPosition = 0;
		this.tramRestingGroundsPosition = 0;
		this.mineLiftOpened = false;
		this.menderDoorOpened = false;
		this.vesselFragStagNest = false;
		this.shamanPillar = false;
		this.crossroadsMawlekWall = false;
		this.eggTempleVisited = false;
		this.crossroadsInfected = false;
		this.falseKnightFirstPlop = false;
		this.falseKnightWallRepaired = false;
		this.falseKnightWallBroken = false;
		this.falseKnightGhostDeparted = false;
		this.spaBugsEncountered = false;
		this.hornheadVinePlat = false;
		this.infectedKnightEncountered = false;
		this.megaMossChargerEncountered = false;
		this.megaMossChargerDefeated = false;
		this.dreamerScene1 = false;
		this.slugEncounterComplete = false;
		this.defeatedDoubleBlockers = false;
		this.oneWayArchive = false;
		this.defeatedMegaJelly = false;
		this.summonedMonomon = false;
		this.sawWoundedQuirrel = false;
		this.encounteredMegaJelly = false;
		this.defeatedMantisLords = false;
		this.encounteredGatekeeper = false;
		this.deepnestWall = false;
		this.queensStationNonDisplay = false;
		this.cityBridge1 = false;
		this.cityBridge2 = false;
		this.cityLift1 = false;
		this.cityLift1_isUp = false;
		this.liftArrival = false;
		this.openedMageDoor_v2 = false;
		this.brokenMageWindow = false;
		this.brokenMageWindowGlass = false;
		this.mageLordEncountered = false;
		this.mageLordEncountered_2 = false;
		this.mageLordDefeated = false;
		this.ruins1_5_tripleDoor = false;
		this.openedWaterwaysManhole = false;
		this.openedCityGate = false;
		this.cityGateClosed = false;
		this.bathHouseOpened = false;
		this.bathHouseWall = false;
		this.cityLift2 = true;
		this.cityLift2_isUp = false;
		this.city2_sewerDoor = false;
		this.openedLoveDoor = false;
		this.watcherChandelier = false;
		this.completedQuakeArea = false;
		this.kingsStationNonDisplay = false;
		this.tollBenchCity = false;
		this.waterwaysGate = false;
		this.defeatedDungDefender = false;
		this.dungDefenderEncounterReady = false;
		this.flukeMotherEncountered = false;
		this.flukeMotherDefeated = false;
		this.waterwaysAcidDrained = false;
		this.dungDefenderWallBroken = false;
		this.dungDefenderSleeping = false;
		this.defeatedMegaBeamMiner = false;
		this.defeatedMegaBeamMiner2 = false;
		this.brokeMinersWall = false;
		this.encounteredMimicSpider = false;
		this.steppedBeyondBridge = false;
		this.deepnestBridgeCollapsed = false;
		this.spiderCapture = false;
		this.openedRestingGrounds02 = false;
		this.restingGroundsCryptWall = false;
		this.dreamNailConvo = false;
		this.gladeGhostsKilled = 0;
		this.openedGardensStagStation = false;
		this.extendedGramophone = false;
		this.tollBenchQueensGardens = false;
		this.blizzardEnded = false;
		this.encounteredHornet = false;
		this.savedByHornet = false;
		this.outskirtsWall = false;
		this.abyssGateOpened = false;
		this.abyssLighthouse = false;
		this.blueVineDoor = false;
		this.gotShadeCharm = false;
		this.tollBenchAbyss = false;
		this.fountainGeo = 0;
		this.fountainVesselSummoned = false;
		this.openedBlackEggPath = false;
		this.enteredDreamWorld = false;
		this.duskKnightDefeated = false;
		this.whitePalaceOrb_1 = false;
		this.whitePalaceOrb_2 = false;
		this.whitePalaceOrb_3 = false;
		this.whitePalace05_lever = false;
		this.whitePalaceMidWarp = false;
		this.whitePalaceSecretRoomVisited = false;
		this.tramOpenedDeepnest = false;
		this.tramOpenedCrossroads = false;
		this.openedBlackEggDoor = false;
		this.unchainedHollowKnight = false;
		this.flamesCollected = 0;
		this.flamesRequired = 3;
		this.nightmareLanternAppeared = false;
		this.nightmareLanternLit = false;
		this.troupeInTown = false;
		this.divineInTown = false;
		this.grimmChildLevel = 1;
		this.elderbugConvoGrimm = false;
		this.slyConvoGrimm = false;
		this.iseldaConvoGrimm = false;
		this.midwifeWeaverlingConvo = false;
		this.metGrimm = false;
		this.foughtGrimm = false;
		this.metBrum = false;
		this.defeatedNightmareGrimm = false;
		this.grimmchildAwoken = false;
		this.gotBrummsFlame = false;
		this.brummBrokeBrazier = false;
		this.destroyedNightmareLantern = false;
		this.gotGrimmNotch = false;
		this.nymmInTown = false;
		this.nymmSpoken = false;
		this.elderbugNymmConvo = false;
		this.slyNymmConvo = false;
		this.iseldaNymmConvo = false;
		this.elderbugTroupeLeftConvo = false;
		this.jijiGrimmConvo = false;
		this.nymmMissedEggOpen = false;
		this.elderbugBrettaLeft = false;
		this.metDivine = false;
		this.divineFinalConvo = false;
		this.gaveFragileHeart = false;
		this.gaveFragileGreed = false;
		this.gaveFragileStrength = false;
		this.pooedFragileHeart = false;
		this.pooedFragileGreed = false;
		this.pooedFragileStrength = false;
		this.divineEatenConvos = 0;
		this.completionPercentage = 0f;
		this.unlockedCompletionRate = false;
		this.disablePause = false;
		this.backerCredits = false;
		this.mapKeyPref = 0;
		this.playerStory = new List<string>();
		this.betaEnd = false;
	}

	// Token: 0x040026B3 RID: 9907
	public string version;

	// Token: 0x040026B4 RID: 9908
	public int profileID;

	// Token: 0x040026B5 RID: 9909
	public float playTime;

	// Token: 0x040026B6 RID: 9910
	public float completionPercent;

	// Token: 0x040026B7 RID: 9911
	public bool openingCreditsPlayed;

	// Token: 0x040026B8 RID: 9912
	public int permadeathMode;

	// Token: 0x040026B9 RID: 9913
	public int health;

	// Token: 0x040026BA RID: 9914
	public int maxHealth;

	// Token: 0x040026BB RID: 9915
	public int maxHealthBase;

	// Token: 0x040026BC RID: 9916
	public int healthBlue;

	// Token: 0x040026BD RID: 9917
	public int joniHealthBlue;

	// Token: 0x040026BE RID: 9918
	public bool damagedBlue;

	// Token: 0x040026BF RID: 9919
	public int heartPieces;

	// Token: 0x040026C0 RID: 9920
	public bool heartPieceCollected;

	// Token: 0x040026C1 RID: 9921
	public int maxHealthCap;

	// Token: 0x040026C2 RID: 9922
	public bool heartPieceMax;

	// Token: 0x040026C3 RID: 9923
	public int prevHealth;

	// Token: 0x040026C4 RID: 9924
	public int blockerHits;

	// Token: 0x040026C5 RID: 9925
	public bool firstGeo;

	// Token: 0x040026C6 RID: 9926
	public int geo;

	// Token: 0x040026C7 RID: 9927
	public int maxMP;

	// Token: 0x040026C8 RID: 9928
	public int MPCharge;

	// Token: 0x040026C9 RID: 9929
	public int MPReserve;

	// Token: 0x040026CA RID: 9930
	public int MPReserveMax;

	// Token: 0x040026CB RID: 9931
	public bool soulLimited;

	// Token: 0x040026CC RID: 9932
	public int vesselFragments;

	// Token: 0x040026CD RID: 9933
	public bool vesselFragmentCollected;

	// Token: 0x040026CE RID: 9934
	public int MPReserveCap;

	// Token: 0x040026CF RID: 9935
	public bool vesselFragmentMax;

	// Token: 0x040026D0 RID: 9936
	public int focusMP_amount;

	// Token: 0x040026D1 RID: 9937
	public bool atBench;

	// Token: 0x040026D2 RID: 9938
	public string respawnScene;

	// Token: 0x040026D4 RID: 9940
	public string respawnMarkerName;

	// Token: 0x040026D5 RID: 9941
	public int respawnType;

	// Token: 0x040026D6 RID: 9942
	public bool respawnFacingRight;

	// Token: 0x040026D7 RID: 9943
	[NonSerialized]
	public Vector3 hazardRespawnLocation;

	// Token: 0x040026D8 RID: 9944
	public bool hazardRespawnFacingRight;

	// Token: 0x040026D9 RID: 9945
	public string shadeScene;

	// Token: 0x040026DA RID: 9946
	public string shadeMapZone;

	// Token: 0x040026DB RID: 9947
	public float shadePositionX;

	// Token: 0x040026DC RID: 9948
	public float shadePositionY;

	// Token: 0x040026DD RID: 9949
	public int shadeHealth;

	// Token: 0x040026DE RID: 9950
	public int shadeMP;

	// Token: 0x040026DF RID: 9951
	public int shadeFireballLevel;

	// Token: 0x040026E0 RID: 9952
	public int shadeQuakeLevel;

	// Token: 0x040026E1 RID: 9953
	public int shadeScreamLevel;

	// Token: 0x040026E2 RID: 9954
	public int shadeSpecialType;

	// Token: 0x040026E3 RID: 9955
	public Vector3 shadeMapPos;

	// Token: 0x040026E4 RID: 9956
	public Vector3 dreamgateMapPos;

	// Token: 0x040026E5 RID: 9957
	public int geoPool;

	// Token: 0x040026E6 RID: 9958
	public int nailDamage;

	// Token: 0x040026E7 RID: 9959
	public int nailRange;

	// Token: 0x040026E8 RID: 9960
	public int beamDamage;

	// Token: 0x040026E9 RID: 9961
	public bool canDash;

	// Token: 0x040026EA RID: 9962
	public bool canBackDash;

	// Token: 0x040026EB RID: 9963
	public bool canWallJump;

	// Token: 0x040026EC RID: 9964
	public bool canSuperDash;

	// Token: 0x040026ED RID: 9965
	public bool canShadowDash;

	// Token: 0x040026EE RID: 9966
	public bool hasSpell;

	// Token: 0x040026EF RID: 9967
	public int fireballLevel;

	// Token: 0x040026F0 RID: 9968
	public int quakeLevel;

	// Token: 0x040026F1 RID: 9969
	public int screamLevel;

	// Token: 0x040026F2 RID: 9970
	public bool hasNailArt;

	// Token: 0x040026F3 RID: 9971
	public bool hasCyclone;

	// Token: 0x040026F4 RID: 9972
	public bool hasDashSlash;

	// Token: 0x040026F5 RID: 9973
	public bool hasUpwardSlash;

	// Token: 0x040026F6 RID: 9974
	public bool hasAllNailArts;

	// Token: 0x040026F7 RID: 9975
	public bool hasDreamNail;

	// Token: 0x040026F8 RID: 9976
	public bool hasDreamGate;

	// Token: 0x040026F9 RID: 9977
	public bool dreamNailUpgraded;

	// Token: 0x040026FA RID: 9978
	public int dreamOrbs;

	// Token: 0x040026FB RID: 9979
	public int dreamOrbsSpent;

	// Token: 0x040026FC RID: 9980
	public string dreamGateScene;

	// Token: 0x040026FD RID: 9981
	public float dreamGateX;

	// Token: 0x040026FE RID: 9982
	public float dreamGateY;

	// Token: 0x040026FF RID: 9983
	public bool hasDash;

	// Token: 0x04002700 RID: 9984
	public bool hasWalljump;

	// Token: 0x04002701 RID: 9985
	public bool hasSuperDash;

	// Token: 0x04002702 RID: 9986
	public bool hasShadowDash;

	// Token: 0x04002703 RID: 9987
	public bool hasAcidArmour;

	// Token: 0x04002704 RID: 9988
	public bool hasDoubleJump;

	// Token: 0x04002705 RID: 9989
	public bool hasLantern;

	// Token: 0x04002706 RID: 9990
	public bool hasTramPass;

	// Token: 0x04002707 RID: 9991
	public bool hasQuill;

	// Token: 0x04002708 RID: 9992
	public bool hasCityKey;

	// Token: 0x04002709 RID: 9993
	public bool hasSlykey;

	// Token: 0x0400270A RID: 9994
	public bool gaveSlykey;

	// Token: 0x0400270B RID: 9995
	public bool hasWhiteKey;

	// Token: 0x0400270C RID: 9996
	public bool usedWhiteKey;

	// Token: 0x0400270D RID: 9997
	public bool hasMenderKey;

	// Token: 0x0400270E RID: 9998
	public bool hasWaterwaysKey;

	// Token: 0x0400270F RID: 9999
	public bool hasSpaKey;

	// Token: 0x04002710 RID: 10000
	public bool hasLoveKey;

	// Token: 0x04002711 RID: 10001
	public bool hasKingsBrand;

	// Token: 0x04002712 RID: 10002
	public bool hasXunFlower;

	// Token: 0x04002713 RID: 10003
	public int ghostCoins;

	// Token: 0x04002714 RID: 10004
	public int ore;

	// Token: 0x04002715 RID: 10005
	public bool foundGhostCoin;

	// Token: 0x04002716 RID: 10006
	public int trinket1;

	// Token: 0x04002717 RID: 10007
	public bool foundTrinket1;

	// Token: 0x04002718 RID: 10008
	public int trinket2;

	// Token: 0x04002719 RID: 10009
	public bool foundTrinket2;

	// Token: 0x0400271A RID: 10010
	public int trinket3;

	// Token: 0x0400271B RID: 10011
	public bool foundTrinket3;

	// Token: 0x0400271C RID: 10012
	public int trinket4;

	// Token: 0x0400271D RID: 10013
	public bool foundTrinket4;

	// Token: 0x0400271E RID: 10014
	public bool noTrinket1;

	// Token: 0x0400271F RID: 10015
	public bool noTrinket2;

	// Token: 0x04002720 RID: 10016
	public bool noTrinket3;

	// Token: 0x04002721 RID: 10017
	public bool noTrinket4;

	// Token: 0x04002722 RID: 10018
	public int soldTrinket1;

	// Token: 0x04002723 RID: 10019
	public int soldTrinket2;

	// Token: 0x04002724 RID: 10020
	public int soldTrinket3;

	// Token: 0x04002725 RID: 10021
	public int soldTrinket4;

	// Token: 0x04002726 RID: 10022
	public int simpleKeys;

	// Token: 0x04002727 RID: 10023
	public int rancidEggs;

	// Token: 0x04002728 RID: 10024
	public bool notchShroomOgres;

	// Token: 0x04002729 RID: 10025
	public bool notchFogCanyon;

	// Token: 0x0400272A RID: 10026
	public float gMap_doorX;

	// Token: 0x0400272B RID: 10027
	public float gMap_doorY;

	// Token: 0x0400272C RID: 10028
	public string gMap_doorScene;

	// Token: 0x0400272D RID: 10029
	public string gMap_doorMapZone;

	// Token: 0x0400272E RID: 10030
	public float gMap_doorOriginOffsetX;

	// Token: 0x0400272F RID: 10031
	public float gMap_doorOriginOffsetY;

	// Token: 0x04002730 RID: 10032
	public float gMap_doorSceneWidth;

	// Token: 0x04002731 RID: 10033
	public float gMap_doorSceneHeight;

	// Token: 0x04002732 RID: 10034
	public int guardiansDefeated;

	// Token: 0x04002733 RID: 10035
	public bool lurienDefeated;

	// Token: 0x04002734 RID: 10036
	public bool hegemolDefeated;

	// Token: 0x04002735 RID: 10037
	public bool monomonDefeated;

	// Token: 0x04002736 RID: 10038
	public bool maskBrokenLurien;

	// Token: 0x04002737 RID: 10039
	public bool maskBrokenHegemol;

	// Token: 0x04002738 RID: 10040
	public bool maskBrokenMonomon;

	// Token: 0x04002739 RID: 10041
	public int maskToBreak;

	// Token: 0x0400273A RID: 10042
	public int elderbug;

	// Token: 0x0400273B RID: 10043
	public bool metElderbug;

	// Token: 0x0400273C RID: 10044
	public bool elderbugReintro;

	// Token: 0x0400273D RID: 10045
	public int elderbugHistory;

	// Token: 0x0400273E RID: 10046
	public bool elderbugHistory1;

	// Token: 0x0400273F RID: 10047
	public bool elderbugHistory2;

	// Token: 0x04002740 RID: 10048
	public bool elderbugHistory3;

	// Token: 0x04002741 RID: 10049
	public bool elderbugSpeechSly;

	// Token: 0x04002742 RID: 10050
	public bool elderbugSpeechStation;

	// Token: 0x04002743 RID: 10051
	public bool elderbugSpeechEggTemple;

	// Token: 0x04002744 RID: 10052
	public bool elderbugSpeechMapShop;

	// Token: 0x04002745 RID: 10053
	public bool elderbugSpeechBretta;

	// Token: 0x04002746 RID: 10054
	public bool elderbugSpeechJiji;

	// Token: 0x04002747 RID: 10055
	public bool elderbugSpeechMinesLift;

	// Token: 0x04002748 RID: 10056
	public bool elderbugSpeechKingsPass;

	// Token: 0x04002749 RID: 10057
	public bool elderbugSpeechInfectedCrossroads;

	// Token: 0x0400274A RID: 10058
	public bool elderbugSpeechFinalBossDoor;

	// Token: 0x0400274B RID: 10059
	public bool elderbugRequestedFlower;

	// Token: 0x0400274C RID: 10060
	public bool elderbugGaveFlower;

	// Token: 0x0400274D RID: 10061
	public bool metQuirrel;

	// Token: 0x0400274E RID: 10062
	public int quirrelEggTemple;

	// Token: 0x0400274F RID: 10063
	public int quirrelSlugShrine;

	// Token: 0x04002750 RID: 10064
	public int quirrelRuins;

	// Token: 0x04002751 RID: 10065
	public int quirrelMines;

	// Token: 0x04002752 RID: 10066
	public bool quirrelLeftStation;

	// Token: 0x04002753 RID: 10067
	public bool quirrelLeftEggTemple;

	// Token: 0x04002754 RID: 10068
	public bool quirrelCityEncountered;

	// Token: 0x04002755 RID: 10069
	public bool quirrelCityLeft;

	// Token: 0x04002756 RID: 10070
	public bool quirrelMinesEncountered;

	// Token: 0x04002757 RID: 10071
	public bool quirrelMinesLeft;

	// Token: 0x04002758 RID: 10072
	public bool quirrelMantisEncountered;

	// Token: 0x04002759 RID: 10073
	public bool enteredMantisLordArea;

	// Token: 0x0400275A RID: 10074
	public bool visitedDeepnestSpa;

	// Token: 0x0400275B RID: 10075
	public bool quirrelSpaReady;

	// Token: 0x0400275C RID: 10076
	public bool quirrelSpaEncountered;

	// Token: 0x0400275D RID: 10077
	public bool quirrelArchiveEncountered;

	// Token: 0x0400275E RID: 10078
	public bool quirrelEpilogueCompleted;

	// Token: 0x0400275F RID: 10079
	public bool metRelicDealer;

	// Token: 0x04002760 RID: 10080
	public bool metRelicDealerShop;

	// Token: 0x04002761 RID: 10081
	public bool marmOutside;

	// Token: 0x04002762 RID: 10082
	public bool marmOutsideConvo;

	// Token: 0x04002763 RID: 10083
	public bool marmConvo1;

	// Token: 0x04002764 RID: 10084
	public bool marmConvo2;

	// Token: 0x04002765 RID: 10085
	public bool marmConvo3;

	// Token: 0x04002766 RID: 10086
	public bool marmConvoNailsmith;

	// Token: 0x04002767 RID: 10087
	public int cornifer;

	// Token: 0x04002768 RID: 10088
	public bool metCornifer;

	// Token: 0x04002769 RID: 10089
	public bool corniferIntroduced;

	// Token: 0x0400276A RID: 10090
	public bool corniferAtHome;

	// Token: 0x0400276B RID: 10091
	public bool corn_crossroadsEncountered;

	// Token: 0x0400276C RID: 10092
	public bool corn_crossroadsLeft;

	// Token: 0x0400276D RID: 10093
	public bool corn_greenpathEncountered;

	// Token: 0x0400276E RID: 10094
	public bool corn_greenpathLeft;

	// Token: 0x0400276F RID: 10095
	public bool corn_fogCanyonEncountered;

	// Token: 0x04002770 RID: 10096
	public bool corn_fogCanyonLeft;

	// Token: 0x04002771 RID: 10097
	public bool corn_fungalWastesEncountered;

	// Token: 0x04002772 RID: 10098
	public bool corn_fungalWastesLeft;

	// Token: 0x04002773 RID: 10099
	public bool corn_cityEncountered;

	// Token: 0x04002774 RID: 10100
	public bool corn_cityLeft;

	// Token: 0x04002775 RID: 10101
	public bool corn_waterwaysEncountered;

	// Token: 0x04002776 RID: 10102
	public bool corn_waterwaysLeft;

	// Token: 0x04002777 RID: 10103
	public bool corn_minesEncountered;

	// Token: 0x04002778 RID: 10104
	public bool corn_minesLeft;

	// Token: 0x04002779 RID: 10105
	public bool corn_cliffsEncountered;

	// Token: 0x0400277A RID: 10106
	public bool corn_cliffsLeft;

	// Token: 0x0400277B RID: 10107
	public bool corn_deepnestEncountered;

	// Token: 0x0400277C RID: 10108
	public bool corn_deepnestLeft;

	// Token: 0x0400277D RID: 10109
	public bool corn_deepnestMet1;

	// Token: 0x0400277E RID: 10110
	public bool corn_deepnestMet2;

	// Token: 0x0400277F RID: 10111
	public bool corn_outskirtsEncountered;

	// Token: 0x04002780 RID: 10112
	public bool corn_outskirtsLeft;

	// Token: 0x04002781 RID: 10113
	public bool corn_royalGardensEncountered;

	// Token: 0x04002782 RID: 10114
	public bool corn_royalGardensLeft;

	// Token: 0x04002783 RID: 10115
	public bool corn_abyssEncountered;

	// Token: 0x04002784 RID: 10116
	public bool corn_abyssLeft;

	// Token: 0x04002785 RID: 10117
	public bool metIselda;

	// Token: 0x04002786 RID: 10118
	public bool iseldaCorniferHomeConvo;

	// Token: 0x04002787 RID: 10119
	public bool iseldaConvo1;

	// Token: 0x04002788 RID: 10120
	public bool brettaRescued;

	// Token: 0x04002789 RID: 10121
	public int brettaPosition;

	// Token: 0x0400278A RID: 10122
	public int brettaState;

	// Token: 0x0400278B RID: 10123
	public bool brettaSeenBench;

	// Token: 0x0400278C RID: 10124
	public bool brettaSeenBed;

	// Token: 0x0400278D RID: 10125
	public bool brettaSeenBenchDiary;

	// Token: 0x0400278E RID: 10126
	public bool brettaSeenBedDiary;

	// Token: 0x0400278F RID: 10127
	public bool brettaLeftTown;

	// Token: 0x04002790 RID: 10128
	public bool slyRescued;

	// Token: 0x04002791 RID: 10129
	public bool slyBeta;

	// Token: 0x04002792 RID: 10130
	public bool metSlyShop;

	// Token: 0x04002793 RID: 10131
	public bool gotSlyCharm;

	// Token: 0x04002794 RID: 10132
	public bool slyShellFrag1;

	// Token: 0x04002795 RID: 10133
	public bool slyShellFrag2;

	// Token: 0x04002796 RID: 10134
	public bool slyShellFrag3;

	// Token: 0x04002797 RID: 10135
	public bool slyShellFrag4;

	// Token: 0x04002798 RID: 10136
	public bool slyVesselFrag1;

	// Token: 0x04002799 RID: 10137
	public bool slyVesselFrag2;

	// Token: 0x0400279A RID: 10138
	public bool slyVesselFrag3;

	// Token: 0x0400279B RID: 10139
	public bool slyVesselFrag4;

	// Token: 0x0400279C RID: 10140
	public bool slyNotch1;

	// Token: 0x0400279D RID: 10141
	public bool slyNotch2;

	// Token: 0x0400279E RID: 10142
	public bool slySimpleKey;

	// Token: 0x0400279F RID: 10143
	public bool slyRancidEgg;

	// Token: 0x040027A0 RID: 10144
	public bool slyConvoNailArt;

	// Token: 0x040027A1 RID: 10145
	public bool slyConvoMapper;

	// Token: 0x040027A2 RID: 10146
	public bool slyConvoNailHoned;

	// Token: 0x040027A3 RID: 10147
	public bool jijiDoorUnlocked;

	// Token: 0x040027A4 RID: 10148
	public bool jijiMet;

	// Token: 0x040027A5 RID: 10149
	public bool jijiShadeOffered;

	// Token: 0x040027A6 RID: 10150
	public bool jijiShadeCharmConvo;

	// Token: 0x040027A7 RID: 10151
	public bool metJinn;

	// Token: 0x040027A8 RID: 10152
	public bool jinnConvo1;

	// Token: 0x040027A9 RID: 10153
	public bool jinnConvo2;

	// Token: 0x040027AA RID: 10154
	public bool jinnConvo3;

	// Token: 0x040027AB RID: 10155
	public bool jinnConvoKingBrand;

	// Token: 0x040027AC RID: 10156
	public bool jinnConvoShadeCharm;

	// Token: 0x040027AD RID: 10157
	public int jinnEggsSold;

	// Token: 0x040027AE RID: 10158
	public int zote;

	// Token: 0x040027AF RID: 10159
	public bool zoteRescuedBuzzer;

	// Token: 0x040027B0 RID: 10160
	public bool zoteDead;

	// Token: 0x040027B1 RID: 10161
	public int zoteDeathPos;

	// Token: 0x040027B2 RID: 10162
	public bool zoteSpokenCity;

	// Token: 0x040027B3 RID: 10163
	public bool zoteLeftCity;

	// Token: 0x040027B4 RID: 10164
	public bool zoteTrappedDeepnest;

	// Token: 0x040027B5 RID: 10165
	public bool zoteRescuedDeepnest;

	// Token: 0x040027B6 RID: 10166
	public bool zoteDefeated;

	// Token: 0x040027B7 RID: 10167
	public bool zoteSpokenColosseum;

	// Token: 0x040027B8 RID: 10168
	public int zotePrecept;

	// Token: 0x040027B9 RID: 10169
	public int zoteTownConvo;

	// Token: 0x040027BA RID: 10170
	public int shaman;

	// Token: 0x040027BB RID: 10171
	public bool shamanScreamConvo;

	// Token: 0x040027BC RID: 10172
	public bool shamanQuakeConvo;

	// Token: 0x040027BD RID: 10173
	public bool shamanFireball2Convo;

	// Token: 0x040027BE RID: 10174
	public bool shamanScream2Convo;

	// Token: 0x040027BF RID: 10175
	public bool shamanQuake2Convo;

	// Token: 0x040027C0 RID: 10176
	public bool metMiner;

	// Token: 0x040027C1 RID: 10177
	public int miner;

	// Token: 0x040027C2 RID: 10178
	public int minerEarly;

	// Token: 0x040027C3 RID: 10179
	public int hornetGreenpath;

	// Token: 0x040027C4 RID: 10180
	public int hornetFung;

	// Token: 0x040027C5 RID: 10181
	public bool hornet_f19;

	// Token: 0x040027C6 RID: 10182
	public bool hornetFountainEncounter;

	// Token: 0x040027C7 RID: 10183
	public bool hornetCityBridge_ready;

	// Token: 0x040027C8 RID: 10184
	public bool hornetCityBridge_completed;

	// Token: 0x040027C9 RID: 10185
	public bool hornetAbyssEncounter;

	// Token: 0x040027CA RID: 10186
	public bool hornetDenEncounter;

	// Token: 0x040027CB RID: 10187
	public bool metMoth;

	// Token: 0x040027CC RID: 10188
	public bool ignoredMoth;

	// Token: 0x040027CD RID: 10189
	public bool gladeDoorOpened;

	// Token: 0x040027CE RID: 10190
	public bool mothDeparted;

	// Token: 0x040027CF RID: 10191
	public bool completedRGDreamPlant;

	// Token: 0x040027D0 RID: 10192
	public bool dreamReward1;

	// Token: 0x040027D1 RID: 10193
	public bool dreamReward2;

	// Token: 0x040027D2 RID: 10194
	public bool dreamReward3;

	// Token: 0x040027D3 RID: 10195
	public bool dreamReward4;

	// Token: 0x040027D4 RID: 10196
	public bool dreamReward5;

	// Token: 0x040027D5 RID: 10197
	public bool dreamReward5b;

	// Token: 0x040027D6 RID: 10198
	public bool dreamReward6;

	// Token: 0x040027D7 RID: 10199
	public bool dreamReward7;

	// Token: 0x040027D8 RID: 10200
	public bool dreamReward8;

	// Token: 0x040027D9 RID: 10201
	public bool dreamReward9;

	// Token: 0x040027DA RID: 10202
	public bool dreamMothConvo1;

	// Token: 0x040027DB RID: 10203
	public bool bankerAccountPurchased;

	// Token: 0x040027DC RID: 10204
	public bool metBanker;

	// Token: 0x040027DD RID: 10205
	public int bankerBalance;

	// Token: 0x040027DE RID: 10206
	public bool bankerDeclined;

	// Token: 0x040027DF RID: 10207
	public bool bankerTheftCheck;

	// Token: 0x040027E0 RID: 10208
	public int bankerTheft;

	// Token: 0x040027E1 RID: 10209
	public bool bankerSpaMet;

	// Token: 0x040027E2 RID: 10210
	public bool metGiraffe;

	// Token: 0x040027E3 RID: 10211
	public bool metCharmSlug;

	// Token: 0x040027E4 RID: 10212
	public bool salubraNotch1;

	// Token: 0x040027E5 RID: 10213
	public bool salubraNotch2;

	// Token: 0x040027E6 RID: 10214
	public bool salubraNotch3;

	// Token: 0x040027E7 RID: 10215
	public bool salubraNotch4;

	// Token: 0x040027E8 RID: 10216
	public bool salubraBlessing;

	// Token: 0x040027E9 RID: 10217
	public bool salubraConvoCombo;

	// Token: 0x040027EA RID: 10218
	public bool salubraConvoOvercharm;

	// Token: 0x040027EB RID: 10219
	public bool salubraConvoTruth;

	// Token: 0x040027EC RID: 10220
	public bool cultistTransformed;

	// Token: 0x040027ED RID: 10221
	public bool metNailsmith;

	// Token: 0x040027EE RID: 10222
	public int nailSmithUpgrades;

	// Token: 0x040027EF RID: 10223
	public bool honedNail;

	// Token: 0x040027F0 RID: 10224
	public bool nailsmithCliff;

	// Token: 0x040027F1 RID: 10225
	public bool nailsmithKilled;

	// Token: 0x040027F2 RID: 10226
	public bool nailsmithSpared;

	// Token: 0x040027F3 RID: 10227
	public bool nailsmithKillSpeech;

	// Token: 0x040027F4 RID: 10228
	public bool nailsmithSheo;

	// Token: 0x040027F5 RID: 10229
	public bool nailsmithConvoArt;

	// Token: 0x040027F6 RID: 10230
	public bool metNailmasterMato;

	// Token: 0x040027F7 RID: 10231
	public bool metNailmasterSheo;

	// Token: 0x040027F8 RID: 10232
	public bool metNailmasterOro;

	// Token: 0x040027F9 RID: 10233
	public bool matoConvoSheo;

	// Token: 0x040027FA RID: 10234
	public bool matoConvoOro;

	// Token: 0x040027FB RID: 10235
	public bool matoConvoSly;

	// Token: 0x040027FC RID: 10236
	public bool sheoConvoMato;

	// Token: 0x040027FD RID: 10237
	public bool sheoConvoOro;

	// Token: 0x040027FE RID: 10238
	public bool sheoConvoSly;

	// Token: 0x040027FF RID: 10239
	public bool sheoConvoNailsmith;

	// Token: 0x04002800 RID: 10240
	public bool oroConvoSheo;

	// Token: 0x04002801 RID: 10241
	public bool oroConvoMato;

	// Token: 0x04002802 RID: 10242
	public bool oroConvoSly;

	// Token: 0x04002803 RID: 10243
	public bool hunterRoared;

	// Token: 0x04002804 RID: 10244
	public bool metHunter;

	// Token: 0x04002805 RID: 10245
	public bool hunterRewardOffered;

	// Token: 0x04002806 RID: 10246
	public bool huntersMarkOffered;

	// Token: 0x04002807 RID: 10247
	public bool hasHuntersMark;

	// Token: 0x04002808 RID: 10248
	public bool metLegEater;

	// Token: 0x04002809 RID: 10249
	public bool paidLegEater;

	// Token: 0x0400280A RID: 10250
	public bool refusedLegEater;

	// Token: 0x0400280B RID: 10251
	public bool legEaterConvo1;

	// Token: 0x0400280C RID: 10252
	public bool legEaterConvo2;

	// Token: 0x0400280D RID: 10253
	public bool legEaterConvo3;

	// Token: 0x0400280E RID: 10254
	public bool legEaterBrokenConvo;

	// Token: 0x0400280F RID: 10255
	public bool legEaterDungConvo;

	// Token: 0x04002810 RID: 10256
	public bool legEaterInfectedCrossroadConvo;

	// Token: 0x04002811 RID: 10257
	public bool legEaterBoughtConvo;

	// Token: 0x04002812 RID: 10258
	public bool legEaterGoldConvo;

	// Token: 0x04002813 RID: 10259
	public bool legEaterLeft;

	// Token: 0x04002814 RID: 10260
	public bool tukMet;

	// Token: 0x04002815 RID: 10261
	public int tukEggPrice;

	// Token: 0x04002816 RID: 10262
	public bool tukDungEgg;

	// Token: 0x04002817 RID: 10263
	public bool metEmilitia;

	// Token: 0x04002818 RID: 10264
	public bool emilitiaKingsBrandConvo;

	// Token: 0x04002819 RID: 10265
	public bool metCloth;

	// Token: 0x0400281A RID: 10266
	public bool clothEnteredTramRoom;

	// Token: 0x0400281B RID: 10267
	public bool savedCloth;

	// Token: 0x0400281C RID: 10268
	public bool clothEncounteredQueensGarden;

	// Token: 0x0400281D RID: 10269
	public bool clothKilled;

	// Token: 0x0400281E RID: 10270
	public bool clothInTown;

	// Token: 0x0400281F RID: 10271
	public bool clothLeftTown;

	// Token: 0x04002820 RID: 10272
	public bool clothGhostSpoken;

	// Token: 0x04002821 RID: 10273
	public bool bigCatHitTail;

	// Token: 0x04002822 RID: 10274
	public bool bigCatHitTailConvo;

	// Token: 0x04002823 RID: 10275
	public bool bigCatMeet;

	// Token: 0x04002824 RID: 10276
	public bool bigCatTalk1;

	// Token: 0x04002825 RID: 10277
	public bool bigCatTalk2;

	// Token: 0x04002826 RID: 10278
	public bool bigCatTalk3;

	// Token: 0x04002827 RID: 10279
	public bool bigCatKingsBrandConvo;

	// Token: 0x04002828 RID: 10280
	public bool bigCatShadeConvo;

	// Token: 0x04002829 RID: 10281
	public bool tisoEncounteredTown;

	// Token: 0x0400282A RID: 10282
	public bool tisoEncounteredBench;

	// Token: 0x0400282B RID: 10283
	public bool tisoEncounteredLake;

	// Token: 0x0400282C RID: 10284
	public bool tisoEncounteredColosseum;

	// Token: 0x0400282D RID: 10285
	public bool tisoDead;

	// Token: 0x0400282E RID: 10286
	public bool tisoShieldConvo;

	// Token: 0x0400282F RID: 10287
	public int mossCultist;

	// Token: 0x04002830 RID: 10288
	public bool maskmakerMet;

	// Token: 0x04002831 RID: 10289
	public bool maskmakerConvo1;

	// Token: 0x04002832 RID: 10290
	public bool maskmakerConvo2;

	// Token: 0x04002833 RID: 10291
	public bool maskmakerUnmasked1;

	// Token: 0x04002834 RID: 10292
	public bool maskmakerUnmasked2;

	// Token: 0x04002835 RID: 10293
	public bool maskmakerShadowDash;

	// Token: 0x04002836 RID: 10294
	public bool maskmakerKingsBrand;

	// Token: 0x04002837 RID: 10295
	public bool dungDefenderConvo1;

	// Token: 0x04002838 RID: 10296
	public bool dungDefenderConvo2;

	// Token: 0x04002839 RID: 10297
	public bool dungDefenderConvo3;

	// Token: 0x0400283A RID: 10298
	public bool dungDefenderCharmConvo;

	// Token: 0x0400283B RID: 10299
	public bool dungDefenderIsmaConvo;

	// Token: 0x0400283C RID: 10300
	public bool midwifeMet;

	// Token: 0x0400283D RID: 10301
	public bool midwifeConvo1;

	// Token: 0x0400283E RID: 10302
	public bool midwifeConvo2;

	// Token: 0x0400283F RID: 10303
	public bool metQueen;

	// Token: 0x04002840 RID: 10304
	public bool queenTalk1;

	// Token: 0x04002841 RID: 10305
	public bool queenTalk2;

	// Token: 0x04002842 RID: 10306
	public bool queenDung1;

	// Token: 0x04002843 RID: 10307
	public bool queenDung2;

	// Token: 0x04002844 RID: 10308
	public bool queenHornet;

	// Token: 0x04002845 RID: 10309
	public bool queenTalkExtra;

	// Token: 0x04002846 RID: 10310
	public bool gotQueenFragment;

	// Token: 0x04002847 RID: 10311
	public bool queenConvo_grimm1;

	// Token: 0x04002848 RID: 10312
	public bool queenConvo_grimm2;

	// Token: 0x04002849 RID: 10313
	public bool gotKingFragment;

	// Token: 0x0400284A RID: 10314
	public bool metXun;

	// Token: 0x0400284B RID: 10315
	public bool xunFailedConvo1;

	// Token: 0x0400284C RID: 10316
	public bool xunFailedConvo2;

	// Token: 0x0400284D RID: 10317
	public bool xunFlowerBroken;

	// Token: 0x0400284E RID: 10318
	public int xunFlowerBrokeTimes;

	// Token: 0x0400284F RID: 10319
	public bool xunFlowerGiven;

	// Token: 0x04002850 RID: 10320
	public bool xunRewardGiven;

	// Token: 0x04002851 RID: 10321
	public int menderState;

	// Token: 0x04002852 RID: 10322
	public bool menderSignBroken;

	// Token: 0x04002853 RID: 10323
	public bool allBelieverTabletsDestroyed;

	// Token: 0x04002854 RID: 10324
	public int mrMushroomState;

	// Token: 0x04002855 RID: 10325
	public bool openedMapperShop;

	// Token: 0x04002856 RID: 10326
	public bool openedSlyShop;

	// Token: 0x04002857 RID: 10327
	public bool metStag;

	// Token: 0x04002858 RID: 10328
	public bool travelling;

	// Token: 0x04002859 RID: 10329
	public int stagPosition;

	// Token: 0x0400285A RID: 10330
	public int stationsOpened;

	// Token: 0x0400285B RID: 10331
	public bool stagConvoTram;

	// Token: 0x0400285C RID: 10332
	public bool stagConvoTiso;

	// Token: 0x0400285D RID: 10333
	public bool stagRemember1;

	// Token: 0x0400285E RID: 10334
	public bool stagRemember2;

	// Token: 0x0400285F RID: 10335
	public bool stagRemember3;

	// Token: 0x04002860 RID: 10336
	public bool stagEggInspected;

	// Token: 0x04002861 RID: 10337
	public bool stagHopeConvo;

	// Token: 0x04002862 RID: 10338
	public string nextScene;

	// Token: 0x04002863 RID: 10339
	public bool littleFoolMet;

	// Token: 0x04002864 RID: 10340
	public bool ranAway;

	// Token: 0x04002865 RID: 10341
	public bool seenColosseumTitle;

	// Token: 0x04002866 RID: 10342
	public bool colosseumBronzeOpened;

	// Token: 0x04002867 RID: 10343
	public bool colosseumBronzeCompleted;

	// Token: 0x04002868 RID: 10344
	public bool colosseumSilverOpened;

	// Token: 0x04002869 RID: 10345
	public bool colosseumSilverCompleted;

	// Token: 0x0400286A RID: 10346
	public bool colosseumGoldOpened;

	// Token: 0x0400286B RID: 10347
	public bool colosseumGoldCompleted;

	// Token: 0x0400286C RID: 10348
	public bool openedTown;

	// Token: 0x0400286D RID: 10349
	public bool openedTownBuilding;

	// Token: 0x0400286E RID: 10350
	public bool openedCrossroads;

	// Token: 0x0400286F RID: 10351
	public bool openedGreenpath;

	// Token: 0x04002870 RID: 10352
	public bool openedRuins1;

	// Token: 0x04002871 RID: 10353
	public bool openedRuins2;

	// Token: 0x04002872 RID: 10354
	public bool openedFungalWastes;

	// Token: 0x04002873 RID: 10355
	public bool openedRoyalGardens;

	// Token: 0x04002874 RID: 10356
	public bool openedRestingGrounds;

	// Token: 0x04002875 RID: 10357
	public bool openedDeepnest;

	// Token: 0x04002876 RID: 10358
	public bool openedStagNest;

	// Token: 0x04002877 RID: 10359
	public bool openedHiddenStation;

	// Token: 0x04002878 RID: 10360
	public string dreamReturnScene;

	// Token: 0x04002879 RID: 10361
	public int charmSlots;

	// Token: 0x0400287A RID: 10362
	public int charmSlotsFilled;

	// Token: 0x0400287B RID: 10363
	public bool hasCharm;

	// Token: 0x0400287C RID: 10364
	public List<int> equippedCharms;

	// Token: 0x0400287D RID: 10365
	public bool charmBenchMsg;

	// Token: 0x0400287E RID: 10366
	public int charmsOwned;

	// Token: 0x0400287F RID: 10367
	public bool canOvercharm;

	// Token: 0x04002880 RID: 10368
	public bool overcharmed;

	// Token: 0x04002881 RID: 10369
	public bool gotCharm_1;

	// Token: 0x04002882 RID: 10370
	public bool equippedCharm_1;

	// Token: 0x04002883 RID: 10371
	public int charmCost_1;

	// Token: 0x04002884 RID: 10372
	public bool newCharm_1;

	// Token: 0x04002885 RID: 10373
	public bool gotCharm_2;

	// Token: 0x04002886 RID: 10374
	public bool equippedCharm_2;

	// Token: 0x04002887 RID: 10375
	public int charmCost_2;

	// Token: 0x04002888 RID: 10376
	public bool newCharm_2;

	// Token: 0x04002889 RID: 10377
	public bool gotCharm_3;

	// Token: 0x0400288A RID: 10378
	public bool equippedCharm_3;

	// Token: 0x0400288B RID: 10379
	public int charmCost_3;

	// Token: 0x0400288C RID: 10380
	public bool newCharm_3;

	// Token: 0x0400288D RID: 10381
	public bool gotCharm_4;

	// Token: 0x0400288E RID: 10382
	public bool equippedCharm_4;

	// Token: 0x0400288F RID: 10383
	public int charmCost_4;

	// Token: 0x04002890 RID: 10384
	public bool newCharm_4;

	// Token: 0x04002891 RID: 10385
	public bool gotCharm_5;

	// Token: 0x04002892 RID: 10386
	public bool equippedCharm_5;

	// Token: 0x04002893 RID: 10387
	public int charmCost_5;

	// Token: 0x04002894 RID: 10388
	public bool newCharm_5;

	// Token: 0x04002895 RID: 10389
	public bool gotCharm_6;

	// Token: 0x04002896 RID: 10390
	public bool equippedCharm_6;

	// Token: 0x04002897 RID: 10391
	public int charmCost_6;

	// Token: 0x04002898 RID: 10392
	public bool newCharm_6;

	// Token: 0x04002899 RID: 10393
	public bool gotCharm_7;

	// Token: 0x0400289A RID: 10394
	public bool equippedCharm_7;

	// Token: 0x0400289B RID: 10395
	public int charmCost_7;

	// Token: 0x0400289C RID: 10396
	public bool newCharm_7;

	// Token: 0x0400289D RID: 10397
	public bool gotCharm_8;

	// Token: 0x0400289E RID: 10398
	public bool equippedCharm_8;

	// Token: 0x0400289F RID: 10399
	public int charmCost_8;

	// Token: 0x040028A0 RID: 10400
	public bool newCharm_8;

	// Token: 0x040028A1 RID: 10401
	public bool gotCharm_9;

	// Token: 0x040028A2 RID: 10402
	public bool equippedCharm_9;

	// Token: 0x040028A3 RID: 10403
	public int charmCost_9;

	// Token: 0x040028A4 RID: 10404
	public bool newCharm_9;

	// Token: 0x040028A5 RID: 10405
	public bool gotCharm_10;

	// Token: 0x040028A6 RID: 10406
	public bool equippedCharm_10;

	// Token: 0x040028A7 RID: 10407
	public int charmCost_10;

	// Token: 0x040028A8 RID: 10408
	public bool newCharm_10;

	// Token: 0x040028A9 RID: 10409
	public bool gotCharm_11;

	// Token: 0x040028AA RID: 10410
	public bool equippedCharm_11;

	// Token: 0x040028AB RID: 10411
	public int charmCost_11;

	// Token: 0x040028AC RID: 10412
	public bool newCharm_11;

	// Token: 0x040028AD RID: 10413
	public bool gotCharm_12;

	// Token: 0x040028AE RID: 10414
	public bool equippedCharm_12;

	// Token: 0x040028AF RID: 10415
	public int charmCost_12;

	// Token: 0x040028B0 RID: 10416
	public bool newCharm_12;

	// Token: 0x040028B1 RID: 10417
	public bool gotCharm_13;

	// Token: 0x040028B2 RID: 10418
	public bool equippedCharm_13;

	// Token: 0x040028B3 RID: 10419
	public int charmCost_13;

	// Token: 0x040028B4 RID: 10420
	public bool newCharm_13;

	// Token: 0x040028B5 RID: 10421
	public bool gotCharm_14;

	// Token: 0x040028B6 RID: 10422
	public bool equippedCharm_14;

	// Token: 0x040028B7 RID: 10423
	public int charmCost_14;

	// Token: 0x040028B8 RID: 10424
	public bool newCharm_14;

	// Token: 0x040028B9 RID: 10425
	public bool gotCharm_15;

	// Token: 0x040028BA RID: 10426
	public bool equippedCharm_15;

	// Token: 0x040028BB RID: 10427
	public int charmCost_15;

	// Token: 0x040028BC RID: 10428
	public bool newCharm_15;

	// Token: 0x040028BD RID: 10429
	public bool gotCharm_16;

	// Token: 0x040028BE RID: 10430
	public bool equippedCharm_16;

	// Token: 0x040028BF RID: 10431
	public int charmCost_16;

	// Token: 0x040028C0 RID: 10432
	public bool newCharm_16;

	// Token: 0x040028C1 RID: 10433
	public bool gotCharm_17;

	// Token: 0x040028C2 RID: 10434
	public bool equippedCharm_17;

	// Token: 0x040028C3 RID: 10435
	public int charmCost_17;

	// Token: 0x040028C4 RID: 10436
	public bool newCharm_17;

	// Token: 0x040028C5 RID: 10437
	public bool gotCharm_18;

	// Token: 0x040028C6 RID: 10438
	public bool equippedCharm_18;

	// Token: 0x040028C7 RID: 10439
	public int charmCost_18;

	// Token: 0x040028C8 RID: 10440
	public bool newCharm_18;

	// Token: 0x040028C9 RID: 10441
	public bool gotCharm_19;

	// Token: 0x040028CA RID: 10442
	public bool equippedCharm_19;

	// Token: 0x040028CB RID: 10443
	public int charmCost_19;

	// Token: 0x040028CC RID: 10444
	public bool newCharm_19;

	// Token: 0x040028CD RID: 10445
	public bool gotCharm_20;

	// Token: 0x040028CE RID: 10446
	public bool equippedCharm_20;

	// Token: 0x040028CF RID: 10447
	public int charmCost_20;

	// Token: 0x040028D0 RID: 10448
	public bool newCharm_20;

	// Token: 0x040028D1 RID: 10449
	public bool gotCharm_21;

	// Token: 0x040028D2 RID: 10450
	public bool equippedCharm_21;

	// Token: 0x040028D3 RID: 10451
	public int charmCost_21;

	// Token: 0x040028D4 RID: 10452
	public bool newCharm_21;

	// Token: 0x040028D5 RID: 10453
	public bool gotCharm_22;

	// Token: 0x040028D6 RID: 10454
	public bool equippedCharm_22;

	// Token: 0x040028D7 RID: 10455
	public int charmCost_22;

	// Token: 0x040028D8 RID: 10456
	public bool newCharm_22;

	// Token: 0x040028D9 RID: 10457
	public bool gotCharm_23;

	// Token: 0x040028DA RID: 10458
	public bool equippedCharm_23;

	// Token: 0x040028DB RID: 10459
	public bool brokenCharm_23;

	// Token: 0x040028DC RID: 10460
	public int charmCost_23;

	// Token: 0x040028DD RID: 10461
	public bool newCharm_23;

	// Token: 0x040028DE RID: 10462
	public bool gotCharm_24;

	// Token: 0x040028DF RID: 10463
	public bool equippedCharm_24;

	// Token: 0x040028E0 RID: 10464
	public bool brokenCharm_24;

	// Token: 0x040028E1 RID: 10465
	public int charmCost_24;

	// Token: 0x040028E2 RID: 10466
	public bool newCharm_24;

	// Token: 0x040028E3 RID: 10467
	public bool gotCharm_25;

	// Token: 0x040028E4 RID: 10468
	public bool equippedCharm_25;

	// Token: 0x040028E5 RID: 10469
	public bool brokenCharm_25;

	// Token: 0x040028E6 RID: 10470
	public int charmCost_25;

	// Token: 0x040028E7 RID: 10471
	public bool newCharm_25;

	// Token: 0x040028E8 RID: 10472
	public bool gotCharm_26;

	// Token: 0x040028E9 RID: 10473
	public bool equippedCharm_26;

	// Token: 0x040028EA RID: 10474
	public int charmCost_26;

	// Token: 0x040028EB RID: 10475
	public bool newCharm_26;

	// Token: 0x040028EC RID: 10476
	public bool gotCharm_27;

	// Token: 0x040028ED RID: 10477
	public bool equippedCharm_27;

	// Token: 0x040028EE RID: 10478
	public int charmCost_27;

	// Token: 0x040028EF RID: 10479
	public bool newCharm_27;

	// Token: 0x040028F0 RID: 10480
	public bool gotCharm_28;

	// Token: 0x040028F1 RID: 10481
	public bool equippedCharm_28;

	// Token: 0x040028F2 RID: 10482
	public int charmCost_28;

	// Token: 0x040028F3 RID: 10483
	public bool newCharm_28;

	// Token: 0x040028F4 RID: 10484
	public bool gotCharm_29;

	// Token: 0x040028F5 RID: 10485
	public bool equippedCharm_29;

	// Token: 0x040028F6 RID: 10486
	public int charmCost_29;

	// Token: 0x040028F7 RID: 10487
	public bool newCharm_29;

	// Token: 0x040028F8 RID: 10488
	public bool gotCharm_30;

	// Token: 0x040028F9 RID: 10489
	public bool equippedCharm_30;

	// Token: 0x040028FA RID: 10490
	public int charmCost_30;

	// Token: 0x040028FB RID: 10491
	public bool newCharm_30;

	// Token: 0x040028FC RID: 10492
	public bool gotCharm_31;

	// Token: 0x040028FD RID: 10493
	public bool equippedCharm_31;

	// Token: 0x040028FE RID: 10494
	public int charmCost_31;

	// Token: 0x040028FF RID: 10495
	public bool newCharm_31;

	// Token: 0x04002900 RID: 10496
	public bool gotCharm_32;

	// Token: 0x04002901 RID: 10497
	public bool equippedCharm_32;

	// Token: 0x04002902 RID: 10498
	public int charmCost_32;

	// Token: 0x04002903 RID: 10499
	public bool newCharm_32;

	// Token: 0x04002904 RID: 10500
	public bool gotCharm_33;

	// Token: 0x04002905 RID: 10501
	public bool equippedCharm_33;

	// Token: 0x04002906 RID: 10502
	public int charmCost_33;

	// Token: 0x04002907 RID: 10503
	public bool newCharm_33;

	// Token: 0x04002908 RID: 10504
	public bool gotCharm_34;

	// Token: 0x04002909 RID: 10505
	public bool equippedCharm_34;

	// Token: 0x0400290A RID: 10506
	public int charmCost_34;

	// Token: 0x0400290B RID: 10507
	public bool newCharm_34;

	// Token: 0x0400290C RID: 10508
	public bool gotCharm_35;

	// Token: 0x0400290D RID: 10509
	public bool equippedCharm_35;

	// Token: 0x0400290E RID: 10510
	public int charmCost_35;

	// Token: 0x0400290F RID: 10511
	public bool newCharm_35;

	// Token: 0x04002910 RID: 10512
	public bool gotCharm_36;

	// Token: 0x04002911 RID: 10513
	public bool equippedCharm_36;

	// Token: 0x04002912 RID: 10514
	public int charmCost_36;

	// Token: 0x04002913 RID: 10515
	public bool newCharm_36;

	// Token: 0x04002914 RID: 10516
	public bool gotCharm_37;

	// Token: 0x04002915 RID: 10517
	public bool equippedCharm_37;

	// Token: 0x04002916 RID: 10518
	public int charmCost_37;

	// Token: 0x04002917 RID: 10519
	public bool newCharm_37;

	// Token: 0x04002918 RID: 10520
	public bool gotCharm_38;

	// Token: 0x04002919 RID: 10521
	public bool equippedCharm_38;

	// Token: 0x0400291A RID: 10522
	public int charmCost_38;

	// Token: 0x0400291B RID: 10523
	public bool newCharm_38;

	// Token: 0x0400291C RID: 10524
	public bool gotCharm_39;

	// Token: 0x0400291D RID: 10525
	public bool equippedCharm_39;

	// Token: 0x0400291E RID: 10526
	public int charmCost_39;

	// Token: 0x0400291F RID: 10527
	public bool newCharm_39;

	// Token: 0x04002920 RID: 10528
	public bool gotCharm_40;

	// Token: 0x04002921 RID: 10529
	public bool equippedCharm_40;

	// Token: 0x04002922 RID: 10530
	public int charmCost_40;

	// Token: 0x04002923 RID: 10531
	public bool newCharm_40;

	// Token: 0x04002924 RID: 10532
	public bool fragileHealth_unbreakable;

	// Token: 0x04002925 RID: 10533
	public bool fragileGreed_unbreakable;

	// Token: 0x04002926 RID: 10534
	public bool fragileStrength_unbreakable;

	// Token: 0x04002927 RID: 10535
	public int royalCharmState;

	// Token: 0x04002928 RID: 10536
	public bool hasJournal;

	// Token: 0x04002929 RID: 10537
	public int lastJournalItem;

	// Token: 0x0400292A RID: 10538
	public bool killedDummy;

	// Token: 0x0400292B RID: 10539
	public int killsDummy;

	// Token: 0x0400292C RID: 10540
	public bool newDataDummy;

	// Token: 0x0400292D RID: 10541
	public bool seenJournalMsg;

	// Token: 0x0400292E RID: 10542
	public bool seenHunterMsg;

	// Token: 0x0400292F RID: 10543
	public bool fillJournal;

	// Token: 0x04002930 RID: 10544
	public int journalEntriesCompleted;

	// Token: 0x04002931 RID: 10545
	public int journalNotesCompleted;

	// Token: 0x04002932 RID: 10546
	public int journalEntriesTotal;

	// Token: 0x04002933 RID: 10547
	public bool killedCrawler;

	// Token: 0x04002934 RID: 10548
	public int killsCrawler;

	// Token: 0x04002935 RID: 10549
	public bool newDataCrawler;

	// Token: 0x04002936 RID: 10550
	public bool killedBuzzer;

	// Token: 0x04002937 RID: 10551
	public int killsBuzzer;

	// Token: 0x04002938 RID: 10552
	public bool newDataBuzzer;

	// Token: 0x04002939 RID: 10553
	public bool killedBouncer;

	// Token: 0x0400293A RID: 10554
	public int killsBouncer;

	// Token: 0x0400293B RID: 10555
	public bool newDataBouncer;

	// Token: 0x0400293C RID: 10556
	public bool killedClimber;

	// Token: 0x0400293D RID: 10557
	public int killsClimber;

	// Token: 0x0400293E RID: 10558
	public bool newDataClimber;

	// Token: 0x0400293F RID: 10559
	public bool killedHopper;

	// Token: 0x04002940 RID: 10560
	public int killsHopper;

	// Token: 0x04002941 RID: 10561
	public bool newDataHopper;

	// Token: 0x04002942 RID: 10562
	public bool killedWorm;

	// Token: 0x04002943 RID: 10563
	public int killsWorm;

	// Token: 0x04002944 RID: 10564
	public bool newDataWorm;

	// Token: 0x04002945 RID: 10565
	public bool killedSpitter;

	// Token: 0x04002946 RID: 10566
	public int killsSpitter;

	// Token: 0x04002947 RID: 10567
	public bool newDataSpitter;

	// Token: 0x04002948 RID: 10568
	public bool killedHatcher;

	// Token: 0x04002949 RID: 10569
	public int killsHatcher;

	// Token: 0x0400294A RID: 10570
	public bool newDataHatcher;

	// Token: 0x0400294B RID: 10571
	public bool killedHatchling;

	// Token: 0x0400294C RID: 10572
	public int killsHatchling;

	// Token: 0x0400294D RID: 10573
	public bool newDataHatchling;

	// Token: 0x0400294E RID: 10574
	public bool killedZombieRunner;

	// Token: 0x0400294F RID: 10575
	public int killsZombieRunner;

	// Token: 0x04002950 RID: 10576
	public bool newDataZombieRunner;

	// Token: 0x04002951 RID: 10577
	public bool killedZombieHornhead;

	// Token: 0x04002952 RID: 10578
	public int killsZombieHornhead;

	// Token: 0x04002953 RID: 10579
	public bool newDataZombieHornhead;

	// Token: 0x04002954 RID: 10580
	public bool killedZombieLeaper;

	// Token: 0x04002955 RID: 10581
	public int killsZombieLeaper;

	// Token: 0x04002956 RID: 10582
	public bool newDataZombieLeaper;

	// Token: 0x04002957 RID: 10583
	public bool killedZombieBarger;

	// Token: 0x04002958 RID: 10584
	public int killsZombieBarger;

	// Token: 0x04002959 RID: 10585
	public bool newDataZombieBarger;

	// Token: 0x0400295A RID: 10586
	public bool killedZombieShield;

	// Token: 0x0400295B RID: 10587
	public int killsZombieShield;

	// Token: 0x0400295C RID: 10588
	public bool newDataZombieShield;

	// Token: 0x0400295D RID: 10589
	public bool killedZombieGuard;

	// Token: 0x0400295E RID: 10590
	public int killsZombieGuard;

	// Token: 0x0400295F RID: 10591
	public bool newDataZombieGuard;

	// Token: 0x04002960 RID: 10592
	public bool killedBigBuzzer;

	// Token: 0x04002961 RID: 10593
	public int killsBigBuzzer;

	// Token: 0x04002962 RID: 10594
	public bool newDataBigBuzzer;

	// Token: 0x04002963 RID: 10595
	public bool killedBigFly;

	// Token: 0x04002964 RID: 10596
	public int killsBigFly;

	// Token: 0x04002965 RID: 10597
	public bool newDataBigFly;

	// Token: 0x04002966 RID: 10598
	public bool killedMawlek;

	// Token: 0x04002967 RID: 10599
	public int killsMawlek;

	// Token: 0x04002968 RID: 10600
	public bool newDataMawlek;

	// Token: 0x04002969 RID: 10601
	public bool killedFalseKnight;

	// Token: 0x0400296A RID: 10602
	public int killsFalseKnight;

	// Token: 0x0400296B RID: 10603
	public bool newDataFalseKnight;

	// Token: 0x0400296C RID: 10604
	public bool killedRoller;

	// Token: 0x0400296D RID: 10605
	public int killsRoller;

	// Token: 0x0400296E RID: 10606
	public bool newDataRoller;

	// Token: 0x0400296F RID: 10607
	public bool killedBlocker;

	// Token: 0x04002970 RID: 10608
	public int killsBlocker;

	// Token: 0x04002971 RID: 10609
	public bool newDataBlocker;

	// Token: 0x04002972 RID: 10610
	public bool killedPrayerSlug;

	// Token: 0x04002973 RID: 10611
	public int killsPrayerSlug;

	// Token: 0x04002974 RID: 10612
	public bool newDataPrayerSlug;

	// Token: 0x04002975 RID: 10613
	public bool killedMenderBug;

	// Token: 0x04002976 RID: 10614
	public int killsMenderBug;

	// Token: 0x04002977 RID: 10615
	public bool newDataMenderBug;

	// Token: 0x04002978 RID: 10616
	public bool killedMossmanRunner;

	// Token: 0x04002979 RID: 10617
	public int killsMossmanRunner;

	// Token: 0x0400297A RID: 10618
	public bool newDataMossmanRunner;

	// Token: 0x0400297B RID: 10619
	public bool killedMossmanShaker;

	// Token: 0x0400297C RID: 10620
	public int killsMossmanShaker;

	// Token: 0x0400297D RID: 10621
	public bool newDataMossmanShaker;

	// Token: 0x0400297E RID: 10622
	public bool killedMosquito;

	// Token: 0x0400297F RID: 10623
	public int killsMosquito;

	// Token: 0x04002980 RID: 10624
	public bool newDataMosquito;

	// Token: 0x04002981 RID: 10625
	public bool killedBlobFlyer;

	// Token: 0x04002982 RID: 10626
	public int killsBlobFlyer;

	// Token: 0x04002983 RID: 10627
	public bool newDataBlobFlyer;

	// Token: 0x04002984 RID: 10628
	public bool killedFungifiedZombie;

	// Token: 0x04002985 RID: 10629
	public int killsFungifiedZombie;

	// Token: 0x04002986 RID: 10630
	public bool newDataFungifiedZombie;

	// Token: 0x04002987 RID: 10631
	public bool killedPlantShooter;

	// Token: 0x04002988 RID: 10632
	public int killsPlantShooter;

	// Token: 0x04002989 RID: 10633
	public bool newDataPlantShooter;

	// Token: 0x0400298A RID: 10634
	public bool killedMossCharger;

	// Token: 0x0400298B RID: 10635
	public int killsMossCharger;

	// Token: 0x0400298C RID: 10636
	public bool newDataMossCharger;

	// Token: 0x0400298D RID: 10637
	public bool killedMegaMossCharger;

	// Token: 0x0400298E RID: 10638
	public int killsMegaMossCharger;

	// Token: 0x0400298F RID: 10639
	public bool newDataMegaMossCharger;

	// Token: 0x04002990 RID: 10640
	public bool killedSnapperTrap;

	// Token: 0x04002991 RID: 10641
	public int killsSnapperTrap;

	// Token: 0x04002992 RID: 10642
	public bool newDataSnapperTrap;

	// Token: 0x04002993 RID: 10643
	public bool killedMossKnight;

	// Token: 0x04002994 RID: 10644
	public int killsMossKnight;

	// Token: 0x04002995 RID: 10645
	public bool newDataMossKnight;

	// Token: 0x04002996 RID: 10646
	public bool killedGrassHopper;

	// Token: 0x04002997 RID: 10647
	public int killsGrassHopper;

	// Token: 0x04002998 RID: 10648
	public bool newDataGrassHopper;

	// Token: 0x04002999 RID: 10649
	public bool killedAcidFlyer;

	// Token: 0x0400299A RID: 10650
	public int killsAcidFlyer;

	// Token: 0x0400299B RID: 10651
	public bool newDataAcidFlyer;

	// Token: 0x0400299C RID: 10652
	public bool killedAcidWalker;

	// Token: 0x0400299D RID: 10653
	public int killsAcidWalker;

	// Token: 0x0400299E RID: 10654
	public bool newDataAcidWalker;

	// Token: 0x0400299F RID: 10655
	public bool killedMossFlyer;

	// Token: 0x040029A0 RID: 10656
	public int killsMossFlyer;

	// Token: 0x040029A1 RID: 10657
	public bool newDataMossFlyer;

	// Token: 0x040029A2 RID: 10658
	public bool killedMossKnightFat;

	// Token: 0x040029A3 RID: 10659
	public int killsMossKnightFat;

	// Token: 0x040029A4 RID: 10660
	public bool newDataMossKnightFat;

	// Token: 0x040029A5 RID: 10661
	public bool killedMossWalker;

	// Token: 0x040029A6 RID: 10662
	public int killsMossWalker;

	// Token: 0x040029A7 RID: 10663
	public bool newDataMossWalker;

	// Token: 0x040029A8 RID: 10664
	public bool killedInfectedKnight;

	// Token: 0x040029A9 RID: 10665
	public int killsInfectedKnight;

	// Token: 0x040029AA RID: 10666
	public bool newDataInfectedKnight;

	// Token: 0x040029AB RID: 10667
	public bool killedLazyFlyer;

	// Token: 0x040029AC RID: 10668
	public int killsLazyFlyer;

	// Token: 0x040029AD RID: 10669
	public bool newDataLazyFlyer;

	// Token: 0x040029AE RID: 10670
	public bool killedZapBug;

	// Token: 0x040029AF RID: 10671
	public int killsZapBug;

	// Token: 0x040029B0 RID: 10672
	public bool newDataZapBug;

	// Token: 0x040029B1 RID: 10673
	public bool killedJellyfish;

	// Token: 0x040029B2 RID: 10674
	public int killsJellyfish;

	// Token: 0x040029B3 RID: 10675
	public bool newDataJellyfish;

	// Token: 0x040029B4 RID: 10676
	public bool killedJellyCrawler;

	// Token: 0x040029B5 RID: 10677
	public int killsJellyCrawler;

	// Token: 0x040029B6 RID: 10678
	public bool newDataJellyCrawler;

	// Token: 0x040029B7 RID: 10679
	public bool killedMegaJellyfish;

	// Token: 0x040029B8 RID: 10680
	public int killsMegaJellyfish;

	// Token: 0x040029B9 RID: 10681
	public bool newDataMegaJellyfish;

	// Token: 0x040029BA RID: 10682
	public bool killedFungoonBaby;

	// Token: 0x040029BB RID: 10683
	public int killsFungoonBaby;

	// Token: 0x040029BC RID: 10684
	public bool newDataFungoonBaby;

	// Token: 0x040029BD RID: 10685
	public bool killedMushroomTurret;

	// Token: 0x040029BE RID: 10686
	public int killsMushroomTurret;

	// Token: 0x040029BF RID: 10687
	public bool newDataMushroomTurret;

	// Token: 0x040029C0 RID: 10688
	public bool killedMantis;

	// Token: 0x040029C1 RID: 10689
	public int killsMantis;

	// Token: 0x040029C2 RID: 10690
	public bool newDataMantis;

	// Token: 0x040029C3 RID: 10691
	public bool killedMushroomRoller;

	// Token: 0x040029C4 RID: 10692
	public int killsMushroomRoller;

	// Token: 0x040029C5 RID: 10693
	public bool newDataMushroomRoller;

	// Token: 0x040029C6 RID: 10694
	public bool killedMushroomBrawler;

	// Token: 0x040029C7 RID: 10695
	public int killsMushroomBrawler;

	// Token: 0x040029C8 RID: 10696
	public bool newDataMushroomBrawler;

	// Token: 0x040029C9 RID: 10697
	public bool killedMushroomBaby;

	// Token: 0x040029CA RID: 10698
	public int killsMushroomBaby;

	// Token: 0x040029CB RID: 10699
	public bool newDataMushroomBaby;

	// Token: 0x040029CC RID: 10700
	public bool killedMantisFlyerChild;

	// Token: 0x040029CD RID: 10701
	public int killsMantisFlyerChild;

	// Token: 0x040029CE RID: 10702
	public bool newDataMantisFlyerChild;

	// Token: 0x040029CF RID: 10703
	public bool killedFungusFlyer;

	// Token: 0x040029D0 RID: 10704
	public int killsFungusFlyer;

	// Token: 0x040029D1 RID: 10705
	public bool newDataFungusFlyer;

	// Token: 0x040029D2 RID: 10706
	public bool killedFungCrawler;

	// Token: 0x040029D3 RID: 10707
	public int killsFungCrawler;

	// Token: 0x040029D4 RID: 10708
	public bool newDataFungCrawler;

	// Token: 0x040029D5 RID: 10709
	public bool killedMantisLord;

	// Token: 0x040029D6 RID: 10710
	public int killsMantisLord;

	// Token: 0x040029D7 RID: 10711
	public bool newDataMantisLord;

	// Token: 0x040029D8 RID: 10712
	public bool killedBlackKnight;

	// Token: 0x040029D9 RID: 10713
	public int killsBlackKnight;

	// Token: 0x040029DA RID: 10714
	public bool newDataBlackKnight;

	// Token: 0x040029DB RID: 10715
	public bool killedElectricMage;

	// Token: 0x040029DC RID: 10716
	public int killsElectricMage;

	// Token: 0x040029DD RID: 10717
	public bool newDataElectricMage;

	// Token: 0x040029DE RID: 10718
	public bool killedMage;

	// Token: 0x040029DF RID: 10719
	public int killsMage;

	// Token: 0x040029E0 RID: 10720
	public bool newDataMage;

	// Token: 0x040029E1 RID: 10721
	public bool killedMageKnight;

	// Token: 0x040029E2 RID: 10722
	public int killsMageKnight;

	// Token: 0x040029E3 RID: 10723
	public bool newDataMageKnight;

	// Token: 0x040029E4 RID: 10724
	public bool killedRoyalDandy;

	// Token: 0x040029E5 RID: 10725
	public int killsRoyalDandy;

	// Token: 0x040029E6 RID: 10726
	public bool newDataRoyalDandy;

	// Token: 0x040029E7 RID: 10727
	public bool killedRoyalCoward;

	// Token: 0x040029E8 RID: 10728
	public int killsRoyalCoward;

	// Token: 0x040029E9 RID: 10729
	public bool newDataRoyalCoward;

	// Token: 0x040029EA RID: 10730
	public bool killedRoyalPlumper;

	// Token: 0x040029EB RID: 10731
	public int killsRoyalPlumper;

	// Token: 0x040029EC RID: 10732
	public bool newDataRoyalPlumper;

	// Token: 0x040029ED RID: 10733
	public bool killedFlyingSentrySword;

	// Token: 0x040029EE RID: 10734
	public int killsFlyingSentrySword;

	// Token: 0x040029EF RID: 10735
	public bool newDataFlyingSentrySword;

	// Token: 0x040029F0 RID: 10736
	public bool killedFlyingSentryJavelin;

	// Token: 0x040029F1 RID: 10737
	public int killsFlyingSentryJavelin;

	// Token: 0x040029F2 RID: 10738
	public bool newDataFlyingSentryJavelin;

	// Token: 0x040029F3 RID: 10739
	public bool killedSentry;

	// Token: 0x040029F4 RID: 10740
	public int killsSentry;

	// Token: 0x040029F5 RID: 10741
	public bool newDataSentry;

	// Token: 0x040029F6 RID: 10742
	public bool killedSentryFat;

	// Token: 0x040029F7 RID: 10743
	public int killsSentryFat;

	// Token: 0x040029F8 RID: 10744
	public bool newDataSentryFat;

	// Token: 0x040029F9 RID: 10745
	public bool killedMageBlob;

	// Token: 0x040029FA RID: 10746
	public int killsMageBlob;

	// Token: 0x040029FB RID: 10747
	public bool newDataMageBlob;

	// Token: 0x040029FC RID: 10748
	public bool killedGreatShieldZombie;

	// Token: 0x040029FD RID: 10749
	public int killsGreatShieldZombie;

	// Token: 0x040029FE RID: 10750
	public bool newDataGreatShieldZombie;

	// Token: 0x040029FF RID: 10751
	public bool killedJarCollector;

	// Token: 0x04002A00 RID: 10752
	public int killsJarCollector;

	// Token: 0x04002A01 RID: 10753
	public bool newDataJarCollector;

	// Token: 0x04002A02 RID: 10754
	public bool killedMageBalloon;

	// Token: 0x04002A03 RID: 10755
	public int killsMageBalloon;

	// Token: 0x04002A04 RID: 10756
	public bool newDataMageBalloon;

	// Token: 0x04002A05 RID: 10757
	public bool killedMageLord;

	// Token: 0x04002A06 RID: 10758
	public int killsMageLord;

	// Token: 0x04002A07 RID: 10759
	public bool newDataMageLord;

	// Token: 0x04002A08 RID: 10760
	public bool killedGorgeousHusk;

	// Token: 0x04002A09 RID: 10761
	public int killsGorgeousHusk;

	// Token: 0x04002A0A RID: 10762
	public bool newDataGorgeousHusk;

	// Token: 0x04002A0B RID: 10763
	public bool killedFlipHopper;

	// Token: 0x04002A0C RID: 10764
	public int killsFlipHopper;

	// Token: 0x04002A0D RID: 10765
	public bool newDataFlipHopper;

	// Token: 0x04002A0E RID: 10766
	public bool killedFlukeman;

	// Token: 0x04002A0F RID: 10767
	public int killsFlukeman;

	// Token: 0x04002A10 RID: 10768
	public bool newDataFlukeman;

	// Token: 0x04002A11 RID: 10769
	public bool killedInflater;

	// Token: 0x04002A12 RID: 10770
	public int killsInflater;

	// Token: 0x04002A13 RID: 10771
	public bool newDataInflater;

	// Token: 0x04002A14 RID: 10772
	public bool killedFlukefly;

	// Token: 0x04002A15 RID: 10773
	public int killsFlukefly;

	// Token: 0x04002A16 RID: 10774
	public bool newDataFlukefly;

	// Token: 0x04002A17 RID: 10775
	public bool killedFlukeMother;

	// Token: 0x04002A18 RID: 10776
	public int killsFlukeMother;

	// Token: 0x04002A19 RID: 10777
	public bool newDataFlukeMother;

	// Token: 0x04002A1A RID: 10778
	public bool killedDungDefender;

	// Token: 0x04002A1B RID: 10779
	public int killsDungDefender;

	// Token: 0x04002A1C RID: 10780
	public bool newDataDungDefender;

	// Token: 0x04002A1D RID: 10781
	public bool killedCrystalCrawler;

	// Token: 0x04002A1E RID: 10782
	public int killsCrystalCrawler;

	// Token: 0x04002A1F RID: 10783
	public bool newDataCrystalCrawler;

	// Token: 0x04002A20 RID: 10784
	public bool killedCrystalFlyer;

	// Token: 0x04002A21 RID: 10785
	public int killsCrystalFlyer;

	// Token: 0x04002A22 RID: 10786
	public bool newDataCrystalFlyer;

	// Token: 0x04002A23 RID: 10787
	public bool killedLaserBug;

	// Token: 0x04002A24 RID: 10788
	public int killsLaserBug;

	// Token: 0x04002A25 RID: 10789
	public bool newDataLaserBug;

	// Token: 0x04002A26 RID: 10790
	public bool killedBeamMiner;

	// Token: 0x04002A27 RID: 10791
	public int killsBeamMiner;

	// Token: 0x04002A28 RID: 10792
	public bool newDataBeamMiner;

	// Token: 0x04002A29 RID: 10793
	public bool killedZombieMiner;

	// Token: 0x04002A2A RID: 10794
	public int killsZombieMiner;

	// Token: 0x04002A2B RID: 10795
	public bool newDataZombieMiner;

	// Token: 0x04002A2C RID: 10796
	public bool killedMegaBeamMiner;

	// Token: 0x04002A2D RID: 10797
	public int killsMegaBeamMiner;

	// Token: 0x04002A2E RID: 10798
	public bool newDataMegaBeamMiner;

	// Token: 0x04002A2F RID: 10799
	public bool killedMinesCrawler;

	// Token: 0x04002A30 RID: 10800
	public int killsMinesCrawler;

	// Token: 0x04002A31 RID: 10801
	public bool newDataMinesCrawler;

	// Token: 0x04002A32 RID: 10802
	public bool killedAngryBuzzer;

	// Token: 0x04002A33 RID: 10803
	public int killsAngryBuzzer;

	// Token: 0x04002A34 RID: 10804
	public bool newDataAngryBuzzer;

	// Token: 0x04002A35 RID: 10805
	public bool killedBurstingBouncer;

	// Token: 0x04002A36 RID: 10806
	public int killsBurstingBouncer;

	// Token: 0x04002A37 RID: 10807
	public bool newDataBurstingBouncer;

	// Token: 0x04002A38 RID: 10808
	public bool killedBurstingZombie;

	// Token: 0x04002A39 RID: 10809
	public int killsBurstingZombie;

	// Token: 0x04002A3A RID: 10810
	public bool newDataBurstingZombie;

	// Token: 0x04002A3B RID: 10811
	public bool killedSpittingZombie;

	// Token: 0x04002A3C RID: 10812
	public int killsSpittingZombie;

	// Token: 0x04002A3D RID: 10813
	public bool newDataSpittingZombie;

	// Token: 0x04002A3E RID: 10814
	public bool killedBabyCentipede;

	// Token: 0x04002A3F RID: 10815
	public int killsBabyCentipede;

	// Token: 0x04002A40 RID: 10816
	public bool newDataBabyCentipede;

	// Token: 0x04002A41 RID: 10817
	public bool killedBigCentipede;

	// Token: 0x04002A42 RID: 10818
	public int killsBigCentipede;

	// Token: 0x04002A43 RID: 10819
	public bool newDataBigCentipede;

	// Token: 0x04002A44 RID: 10820
	public bool killedCentipedeHatcher;

	// Token: 0x04002A45 RID: 10821
	public int killsCentipedeHatcher;

	// Token: 0x04002A46 RID: 10822
	public bool newDataCentipedeHatcher;

	// Token: 0x04002A47 RID: 10823
	public bool killedLesserMawlek;

	// Token: 0x04002A48 RID: 10824
	public int killsLesserMawlek;

	// Token: 0x04002A49 RID: 10825
	public bool newDataLesserMawlek;

	// Token: 0x04002A4A RID: 10826
	public bool killedSlashSpider;

	// Token: 0x04002A4B RID: 10827
	public int killsSlashSpider;

	// Token: 0x04002A4C RID: 10828
	public bool newDataSlashSpider;

	// Token: 0x04002A4D RID: 10829
	public bool killedSpiderCorpse;

	// Token: 0x04002A4E RID: 10830
	public int killsSpiderCorpse;

	// Token: 0x04002A4F RID: 10831
	public bool newDataSpiderCorpse;

	// Token: 0x04002A50 RID: 10832
	public bool killedShootSpider;

	// Token: 0x04002A51 RID: 10833
	public int killsShootSpider;

	// Token: 0x04002A52 RID: 10834
	public bool newDataShootSpider;

	// Token: 0x04002A53 RID: 10835
	public bool killedMiniSpider;

	// Token: 0x04002A54 RID: 10836
	public int killsMiniSpider;

	// Token: 0x04002A55 RID: 10837
	public bool newDataMiniSpider;

	// Token: 0x04002A56 RID: 10838
	public bool killedSpiderFlyer;

	// Token: 0x04002A57 RID: 10839
	public int killsSpiderFlyer;

	// Token: 0x04002A58 RID: 10840
	public bool newDataSpiderFlyer;

	// Token: 0x04002A59 RID: 10841
	public bool killedMimicSpider;

	// Token: 0x04002A5A RID: 10842
	public int killsMimicSpider;

	// Token: 0x04002A5B RID: 10843
	public bool newDataMimicSpider;

	// Token: 0x04002A5C RID: 10844
	public bool killedBeeHatchling;

	// Token: 0x04002A5D RID: 10845
	public int killsBeeHatchling;

	// Token: 0x04002A5E RID: 10846
	public bool newDataBeeHatchling;

	// Token: 0x04002A5F RID: 10847
	public bool killedBeeStinger;

	// Token: 0x04002A60 RID: 10848
	public int killsBeeStinger;

	// Token: 0x04002A61 RID: 10849
	public bool newDataBeeStinger;

	// Token: 0x04002A62 RID: 10850
	public bool killedBigBee;

	// Token: 0x04002A63 RID: 10851
	public int killsBigBee;

	// Token: 0x04002A64 RID: 10852
	public bool newDataBigBee;

	// Token: 0x04002A65 RID: 10853
	public bool killedBlowFly;

	// Token: 0x04002A66 RID: 10854
	public int killsBlowFly;

	// Token: 0x04002A67 RID: 10855
	public bool newDataBlowFly;

	// Token: 0x04002A68 RID: 10856
	public bool killedCeilingDropper;

	// Token: 0x04002A69 RID: 10857
	public int killsCeilingDropper;

	// Token: 0x04002A6A RID: 10858
	public bool newDataCeilingDropper;

	// Token: 0x04002A6B RID: 10859
	public bool killedGiantHopper;

	// Token: 0x04002A6C RID: 10860
	public int killsGiantHopper;

	// Token: 0x04002A6D RID: 10861
	public bool newDataGiantHopper;

	// Token: 0x04002A6E RID: 10862
	public bool killedGrubMimic;

	// Token: 0x04002A6F RID: 10863
	public int killsGrubMimic;

	// Token: 0x04002A70 RID: 10864
	public bool newDataGrubMimic;

	// Token: 0x04002A71 RID: 10865
	public bool killedMawlekTurret;

	// Token: 0x04002A72 RID: 10866
	public int killsMawlekTurret;

	// Token: 0x04002A73 RID: 10867
	public bool newDataMawlekTurret;

	// Token: 0x04002A74 RID: 10868
	public bool killedOrangeScuttler;

	// Token: 0x04002A75 RID: 10869
	public int killsOrangeScuttler;

	// Token: 0x04002A76 RID: 10870
	public bool newDataOrangeScuttler;

	// Token: 0x04002A77 RID: 10871
	public bool killedHealthScuttler;

	// Token: 0x04002A78 RID: 10872
	public int killsHealthScuttler;

	// Token: 0x04002A79 RID: 10873
	public bool newDataHealthScuttler;

	// Token: 0x04002A7A RID: 10874
	public bool killedPigeon;

	// Token: 0x04002A7B RID: 10875
	public int killsPigeon;

	// Token: 0x04002A7C RID: 10876
	public bool newDataPigeon;

	// Token: 0x04002A7D RID: 10877
	public bool killedZombieHive;

	// Token: 0x04002A7E RID: 10878
	public int killsZombieHive;

	// Token: 0x04002A7F RID: 10879
	public bool newDataZombieHive;

	// Token: 0x04002A80 RID: 10880
	public bool killedDreamGuard;

	// Token: 0x04002A81 RID: 10881
	public int killsDreamGuard;

	// Token: 0x04002A82 RID: 10882
	public bool newDataDreamGuard;

	// Token: 0x04002A83 RID: 10883
	public bool killedHornet;

	// Token: 0x04002A84 RID: 10884
	public int killsHornet;

	// Token: 0x04002A85 RID: 10885
	public bool newDataHornet;

	// Token: 0x04002A86 RID: 10886
	public bool killedAbyssCrawler;

	// Token: 0x04002A87 RID: 10887
	public int killsAbyssCrawler;

	// Token: 0x04002A88 RID: 10888
	public bool newDataAbyssCrawler;

	// Token: 0x04002A89 RID: 10889
	public bool killedSuperSpitter;

	// Token: 0x04002A8A RID: 10890
	public int killsSuperSpitter;

	// Token: 0x04002A8B RID: 10891
	public bool newDataSuperSpitter;

	// Token: 0x04002A8C RID: 10892
	public bool killedSibling;

	// Token: 0x04002A8D RID: 10893
	public int killsSibling;

	// Token: 0x04002A8E RID: 10894
	public bool newDataSibling;

	// Token: 0x04002A8F RID: 10895
	public bool killedPalaceFly;

	// Token: 0x04002A90 RID: 10896
	public int killsPalaceFly;

	// Token: 0x04002A91 RID: 10897
	public bool newDataPalaceFly;

	// Token: 0x04002A92 RID: 10898
	public bool killedEggSac;

	// Token: 0x04002A93 RID: 10899
	public int killsEggSac;

	// Token: 0x04002A94 RID: 10900
	public bool newDataEggSac;

	// Token: 0x04002A95 RID: 10901
	public bool killedMummy;

	// Token: 0x04002A96 RID: 10902
	public int killsMummy;

	// Token: 0x04002A97 RID: 10903
	public bool newDataMummy;

	// Token: 0x04002A98 RID: 10904
	public bool killedOrangeBalloon;

	// Token: 0x04002A99 RID: 10905
	public int killsOrangeBalloon;

	// Token: 0x04002A9A RID: 10906
	public bool newDataOrangeBalloon;

	// Token: 0x04002A9B RID: 10907
	public bool killedAbyssTendril;

	// Token: 0x04002A9C RID: 10908
	public int killsAbyssTendril;

	// Token: 0x04002A9D RID: 10909
	public bool newDataAbyssTendril;

	// Token: 0x04002A9E RID: 10910
	public bool killedHeavyMantis;

	// Token: 0x04002A9F RID: 10911
	public int killsHeavyMantis;

	// Token: 0x04002AA0 RID: 10912
	public bool newDataHeavyMantis;

	// Token: 0x04002AA1 RID: 10913
	public bool killedTraitorLord;

	// Token: 0x04002AA2 RID: 10914
	public int killsTraitorLord;

	// Token: 0x04002AA3 RID: 10915
	public bool newDataTraitorLord;

	// Token: 0x04002AA4 RID: 10916
	public bool killedMantisHeavyFlyer;

	// Token: 0x04002AA5 RID: 10917
	public int killsMantisHeavyFlyer;

	// Token: 0x04002AA6 RID: 10918
	public bool newDataMantisHeavyFlyer;

	// Token: 0x04002AA7 RID: 10919
	public bool killedGardenZombie;

	// Token: 0x04002AA8 RID: 10920
	public int killsGardenZombie;

	// Token: 0x04002AA9 RID: 10921
	public bool newDataGardenZombie;

	// Token: 0x04002AAA RID: 10922
	public bool killedRoyalGuard;

	// Token: 0x04002AAB RID: 10923
	public int killsRoyalGuard;

	// Token: 0x04002AAC RID: 10924
	public bool newDataRoyalGuard;

	// Token: 0x04002AAD RID: 10925
	public bool killedWhiteRoyal;

	// Token: 0x04002AAE RID: 10926
	public int killsWhiteRoyal;

	// Token: 0x04002AAF RID: 10927
	public bool newDataWhiteRoyal;

	// Token: 0x04002AB0 RID: 10928
	public bool openedPalaceGrounds;

	// Token: 0x04002AB1 RID: 10929
	public bool killedOblobble;

	// Token: 0x04002AB2 RID: 10930
	public int killsOblobble;

	// Token: 0x04002AB3 RID: 10931
	public bool newDataOblobble;

	// Token: 0x04002AB4 RID: 10932
	public bool killedZote;

	// Token: 0x04002AB5 RID: 10933
	public int killsZote;

	// Token: 0x04002AB6 RID: 10934
	public bool newDataZote;

	// Token: 0x04002AB7 RID: 10935
	public bool killedBlobble;

	// Token: 0x04002AB8 RID: 10936
	public int killsBlobble;

	// Token: 0x04002AB9 RID: 10937
	public bool newDataBlobble;

	// Token: 0x04002ABA RID: 10938
	public bool killedColMosquito;

	// Token: 0x04002ABB RID: 10939
	public int killsColMosquito;

	// Token: 0x04002ABC RID: 10940
	public bool newDataColMosquito;

	// Token: 0x04002ABD RID: 10941
	public bool killedColRoller;

	// Token: 0x04002ABE RID: 10942
	public int killsColRoller;

	// Token: 0x04002ABF RID: 10943
	public bool newDataColRoller;

	// Token: 0x04002AC0 RID: 10944
	public bool killedColFlyingSentry;

	// Token: 0x04002AC1 RID: 10945
	public int killsColFlyingSentry;

	// Token: 0x04002AC2 RID: 10946
	public bool newDataColFlyingSentry;

	// Token: 0x04002AC3 RID: 10947
	public bool killedColMiner;

	// Token: 0x04002AC4 RID: 10948
	public int killsColMiner;

	// Token: 0x04002AC5 RID: 10949
	public bool newDataColMiner;

	// Token: 0x04002AC6 RID: 10950
	public bool killedColShield;

	// Token: 0x04002AC7 RID: 10951
	public int killsColShield;

	// Token: 0x04002AC8 RID: 10952
	public bool newDataColShield;

	// Token: 0x04002AC9 RID: 10953
	public bool killedColWorm;

	// Token: 0x04002ACA RID: 10954
	public int killsColWorm;

	// Token: 0x04002ACB RID: 10955
	public bool newDataColWorm;

	// Token: 0x04002ACC RID: 10956
	public bool killedColHopper;

	// Token: 0x04002ACD RID: 10957
	public int killsColHopper;

	// Token: 0x04002ACE RID: 10958
	public bool newDataColHopper;

	// Token: 0x04002ACF RID: 10959
	public bool killedLobsterLancer;

	// Token: 0x04002AD0 RID: 10960
	public int killsLobsterLancer;

	// Token: 0x04002AD1 RID: 10961
	public bool newDataLobsterLancer;

	// Token: 0x04002AD2 RID: 10962
	public bool killedGhostAladar;

	// Token: 0x04002AD3 RID: 10963
	public int killsGhostAladar;

	// Token: 0x04002AD4 RID: 10964
	public bool newDataGhostAladar;

	// Token: 0x04002AD5 RID: 10965
	public bool killedGhostXero;

	// Token: 0x04002AD6 RID: 10966
	public int killsGhostXero;

	// Token: 0x04002AD7 RID: 10967
	public bool newDataGhostXero;

	// Token: 0x04002AD8 RID: 10968
	public bool killedGhostHu;

	// Token: 0x04002AD9 RID: 10969
	public int killsGhostHu;

	// Token: 0x04002ADA RID: 10970
	public bool newDataGhostHu;

	// Token: 0x04002ADB RID: 10971
	public bool killedGhostMarmu;

	// Token: 0x04002ADC RID: 10972
	public int killsGhostMarmu;

	// Token: 0x04002ADD RID: 10973
	public bool newDataGhostMarmu;

	// Token: 0x04002ADE RID: 10974
	public bool killedGhostNoEyes;

	// Token: 0x04002ADF RID: 10975
	public int killsGhostNoEyes;

	// Token: 0x04002AE0 RID: 10976
	public bool newDataGhostNoEyes;

	// Token: 0x04002AE1 RID: 10977
	public bool killedGhostMarkoth;

	// Token: 0x04002AE2 RID: 10978
	public int killsGhostMarkoth;

	// Token: 0x04002AE3 RID: 10979
	public bool newDataGhostMarkoth;

	// Token: 0x04002AE4 RID: 10980
	public bool killedGhostGalien;

	// Token: 0x04002AE5 RID: 10981
	public int killsGhostGalien;

	// Token: 0x04002AE6 RID: 10982
	public bool newDataGhostGalien;

	// Token: 0x04002AE7 RID: 10983
	public bool killedWhiteDefender;

	// Token: 0x04002AE8 RID: 10984
	public int killsWhiteDefender;

	// Token: 0x04002AE9 RID: 10985
	public bool newDataWhiteDefender;

	// Token: 0x04002AEA RID: 10986
	public bool killedGreyPrince;

	// Token: 0x04002AEB RID: 10987
	public int killsGreyPrince;

	// Token: 0x04002AEC RID: 10988
	public bool newDataGreyPrince;

	// Token: 0x04002AED RID: 10989
	public bool killedZotelingBalloon;

	// Token: 0x04002AEE RID: 10990
	public int killsZotelingBalloon;

	// Token: 0x04002AEF RID: 10991
	public bool newDataZotelingBalloon;

	// Token: 0x04002AF0 RID: 10992
	public bool killedZotelingHopper;

	// Token: 0x04002AF1 RID: 10993
	public int killsZotelingHopper;

	// Token: 0x04002AF2 RID: 10994
	public bool newDataZotelingHopper;

	// Token: 0x04002AF3 RID: 10995
	public bool killedZotelingBuzzer;

	// Token: 0x04002AF4 RID: 10996
	public int killsZotelingBuzzer;

	// Token: 0x04002AF5 RID: 10997
	public bool newDataZotelingBuzzer;

	// Token: 0x04002AF6 RID: 10998
	public bool killedHollowKnight;

	// Token: 0x04002AF7 RID: 10999
	public int killsHollowKnight;

	// Token: 0x04002AF8 RID: 11000
	public bool newDataHollowKnight;

	// Token: 0x04002AF9 RID: 11001
	public bool killedFinalBoss;

	// Token: 0x04002AFA RID: 11002
	public int killsFinalBoss;

	// Token: 0x04002AFB RID: 11003
	public bool newDataFinalBoss;

	// Token: 0x04002AFC RID: 11004
	public bool killedHunterMark;

	// Token: 0x04002AFD RID: 11005
	public int killsHunterMark;

	// Token: 0x04002AFE RID: 11006
	public bool newDataHunterMark;

	// Token: 0x04002AFF RID: 11007
	public bool killedFlameBearerSmall;

	// Token: 0x04002B00 RID: 11008
	public int killsFlameBearerSmall;

	// Token: 0x04002B01 RID: 11009
	public bool newDataFlameBearerSmall;

	// Token: 0x04002B02 RID: 11010
	public bool killedFlameBearerMed;

	// Token: 0x04002B03 RID: 11011
	public int killsFlameBearerMed;

	// Token: 0x04002B04 RID: 11012
	public bool newDataFlameBearerMed;

	// Token: 0x04002B05 RID: 11013
	public bool killedFlameBearerLarge;

	// Token: 0x04002B06 RID: 11014
	public int killsFlameBearerLarge;

	// Token: 0x04002B07 RID: 11015
	public bool newDataFlameBearerLarge;

	// Token: 0x04002B08 RID: 11016
	public bool killedGrimm;

	// Token: 0x04002B09 RID: 11017
	public int killsGrimm;

	// Token: 0x04002B0A RID: 11018
	public bool newDataGrimm;

	// Token: 0x04002B0B RID: 11019
	public bool killedNightmareGrimm;

	// Token: 0x04002B0C RID: 11020
	public int killsNightmareGrimm;

	// Token: 0x04002B0D RID: 11021
	public bool newDataNightmareGrimm;

	// Token: 0x04002B0E RID: 11022
	public bool killedBindingSeal;

	// Token: 0x04002B0F RID: 11023
	public int killsBindingSeal;

	// Token: 0x04002B10 RID: 11024
	public bool newDataBindingSeal;

	// Token: 0x04002B11 RID: 11025
	public int grubsCollected;

	// Token: 0x04002B12 RID: 11026
	public int grubRewards;

	// Token: 0x04002B13 RID: 11027
	public bool finalGrubRewardCollected;

	// Token: 0x04002B14 RID: 11028
	public bool fatGrubKing;

	// Token: 0x04002B15 RID: 11029
	public bool falseKnightDefeated;

	// Token: 0x04002B16 RID: 11030
	public bool falseKnightDreamDefeated;

	// Token: 0x04002B17 RID: 11031
	public bool falseKnightOrbsCollected;

	// Token: 0x04002B18 RID: 11032
	public bool mawlekDefeated;

	// Token: 0x04002B19 RID: 11033
	public bool giantBuzzerDefeated;

	// Token: 0x04002B1A RID: 11034
	public bool giantFlyDefeated;

	// Token: 0x04002B1B RID: 11035
	public bool blocker1Defeated;

	// Token: 0x04002B1C RID: 11036
	public bool blocker2Defeated;

	// Token: 0x04002B1D RID: 11037
	public bool hornet1Defeated;

	// Token: 0x04002B1E RID: 11038
	public bool collectorDefeated;

	// Token: 0x04002B1F RID: 11039
	public bool hornetOutskirtsDefeated;

	// Token: 0x04002B20 RID: 11040
	public bool mageLordDreamDefeated;

	// Token: 0x04002B21 RID: 11041
	public bool mageLordOrbsCollected;

	// Token: 0x04002B22 RID: 11042
	public bool infectedKnightDreamDefeated;

	// Token: 0x04002B23 RID: 11043
	public bool infectedKnightOrbsCollected;

	// Token: 0x04002B24 RID: 11044
	public bool whiteDefenderDefeated;

	// Token: 0x04002B25 RID: 11045
	public bool whiteDefenderOrbsCollected;

	// Token: 0x04002B26 RID: 11046
	public int whiteDefenderDefeats;

	// Token: 0x04002B27 RID: 11047
	public int greyPrinceDefeats;

	// Token: 0x04002B28 RID: 11048
	public bool greyPrinceDefeated;

	// Token: 0x04002B29 RID: 11049
	public bool greyPrinceOrbsCollected;

	// Token: 0x04002B2A RID: 11050
	public int aladarSlugDefeated;

	// Token: 0x04002B2B RID: 11051
	public int xeroDefeated;

	// Token: 0x04002B2C RID: 11052
	public int elderHuDefeated;

	// Token: 0x04002B2D RID: 11053
	public int mumCaterpillarDefeated;

	// Token: 0x04002B2E RID: 11054
	public int noEyesDefeated;

	// Token: 0x04002B2F RID: 11055
	public int markothDefeated;

	// Token: 0x04002B30 RID: 11056
	public int galienDefeated;

	// Token: 0x04002B31 RID: 11057
	public bool XERO_encountered;

	// Token: 0x04002B32 RID: 11058
	public bool ALADAR_encountered;

	// Token: 0x04002B33 RID: 11059
	public bool HU_encountered;

	// Token: 0x04002B34 RID: 11060
	public bool MUMCAT_encountered;

	// Token: 0x04002B35 RID: 11061
	public bool NOEYES_encountered;

	// Token: 0x04002B36 RID: 11062
	public bool MARKOTH_encountered;

	// Token: 0x04002B37 RID: 11063
	public bool GALIEN_encountered;

	// Token: 0x04002B38 RID: 11064
	public bool xeroPinned;

	// Token: 0x04002B39 RID: 11065
	public bool aladarPinned;

	// Token: 0x04002B3A RID: 11066
	public bool huPinned;

	// Token: 0x04002B3B RID: 11067
	public bool mumCaterpillarPinned;

	// Token: 0x04002B3C RID: 11068
	public bool noEyesPinned;

	// Token: 0x04002B3D RID: 11069
	public bool markothPinned;

	// Token: 0x04002B3E RID: 11070
	public bool galienPinned;

	// Token: 0x04002B3F RID: 11071
	public int currentInvPane;

	// Token: 0x04002B40 RID: 11072
	public bool showGeoUI;

	// Token: 0x04002B41 RID: 11073
	public bool showHealthUI;

	// Token: 0x04002B42 RID: 11074
	public bool promptFocus;

	// Token: 0x04002B43 RID: 11075
	public bool seenFocusTablet;

	// Token: 0x04002B44 RID: 11076
	public bool seenDreamNailPrompt;

	// Token: 0x04002B45 RID: 11077
	public bool isFirstGame;

	// Token: 0x04002B46 RID: 11078
	public bool enteredTutorialFirstTime;

	// Token: 0x04002B47 RID: 11079
	public bool isInvincible;

	// Token: 0x04002B48 RID: 11080
	public bool infiniteAirJump;

	// Token: 0x04002B49 RID: 11081
	public bool invinciTest;

	// Token: 0x04002B4A RID: 11082
	public int currentArea;

	// Token: 0x04002B4B RID: 11083
	public bool visitedDirtmouth;

	// Token: 0x04002B4C RID: 11084
	public bool visitedCrossroads;

	// Token: 0x04002B4D RID: 11085
	public bool visitedGreenpath;

	// Token: 0x04002B4E RID: 11086
	public bool visitedFungus;

	// Token: 0x04002B4F RID: 11087
	public bool visitedHive;

	// Token: 0x04002B50 RID: 11088
	public bool visitedCrossroadsInfected;

	// Token: 0x04002B51 RID: 11089
	public bool visitedRuins;

	// Token: 0x04002B52 RID: 11090
	public bool visitedMines;

	// Token: 0x04002B53 RID: 11091
	public bool visitedRoyalGardens;

	// Token: 0x04002B54 RID: 11092
	public bool visitedFogCanyon;

	// Token: 0x04002B55 RID: 11093
	public bool visitedDeepnest;

	// Token: 0x04002B56 RID: 11094
	public bool visitedRestingGrounds;

	// Token: 0x04002B57 RID: 11095
	public bool visitedWaterways;

	// Token: 0x04002B58 RID: 11096
	public bool visitedAbyss;

	// Token: 0x04002B59 RID: 11097
	public bool visitedOutskirts;

	// Token: 0x04002B5A RID: 11098
	public bool visitedWhitePalace;

	// Token: 0x04002B5B RID: 11099
	public bool visitedCliffs;

	// Token: 0x04002B5C RID: 11100
	public bool visitedAbyssLower;

	// Token: 0x04002B5D RID: 11101
	public bool visitedMines10;

	// Token: 0x04002B5E RID: 11102
	public List<string> scenesVisited;

	// Token: 0x04002B5F RID: 11103
	public List<string> scenesMapped;

	// Token: 0x04002B60 RID: 11104
	public List<string> scenesEncounteredBench;

	// Token: 0x04002B61 RID: 11105
	public List<string> scenesGrubRescued;

	// Token: 0x04002B62 RID: 11106
	public List<string> scenesFlameCollected;

	// Token: 0x04002B63 RID: 11107
	public List<string> scenesEncounteredCocoon;

	// Token: 0x04002B64 RID: 11108
	public List<string> scenesEncounteredDreamPlant;

	// Token: 0x04002B65 RID: 11109
	public List<string> scenesEncounteredDreamPlantC;

	// Token: 0x04002B66 RID: 11110
	public bool hasMap;

	// Token: 0x04002B67 RID: 11111
	public bool mapAllRooms;

	// Token: 0x04002B68 RID: 11112
	public bool atMapPrompt;

	// Token: 0x04002B69 RID: 11113
	public bool mapDirtmouth;

	// Token: 0x04002B6A RID: 11114
	public bool mapCrossroads;

	// Token: 0x04002B6B RID: 11115
	public bool mapGreenpath;

	// Token: 0x04002B6C RID: 11116
	public bool mapFogCanyon;

	// Token: 0x04002B6D RID: 11117
	public bool mapRoyalGardens;

	// Token: 0x04002B6E RID: 11118
	public bool mapFungalWastes;

	// Token: 0x04002B6F RID: 11119
	public bool mapCity;

	// Token: 0x04002B70 RID: 11120
	public bool mapWaterways;

	// Token: 0x04002B71 RID: 11121
	public bool mapMines;

	// Token: 0x04002B72 RID: 11122
	public bool mapDeepnest;

	// Token: 0x04002B73 RID: 11123
	public bool mapCliffs;

	// Token: 0x04002B74 RID: 11124
	public bool mapOutskirts;

	// Token: 0x04002B75 RID: 11125
	public bool mapRestingGrounds;

	// Token: 0x04002B76 RID: 11126
	public bool mapAbyss;

	// Token: 0x04002B77 RID: 11127
	private Dictionary<string, PlayerData.MapBools> mapZoneBools;

	// Token: 0x04002B78 RID: 11128
	public bool hasPin;

	// Token: 0x04002B79 RID: 11129
	public bool hasPinBench;

	// Token: 0x04002B7A RID: 11130
	public bool hasPinCocoon;

	// Token: 0x04002B7B RID: 11131
	public bool hasPinDreamPlant;

	// Token: 0x04002B7C RID: 11132
	public bool hasPinGuardian;

	// Token: 0x04002B7D RID: 11133
	public bool hasPinBlackEgg;

	// Token: 0x04002B7E RID: 11134
	public bool hasPinShop;

	// Token: 0x04002B7F RID: 11135
	public bool hasPinSpa;

	// Token: 0x04002B80 RID: 11136
	public bool hasPinStag;

	// Token: 0x04002B81 RID: 11137
	public bool hasPinTram;

	// Token: 0x04002B82 RID: 11138
	public bool hasPinGhost;

	// Token: 0x04002B83 RID: 11139
	public bool hasPinGrub;

	// Token: 0x04002B84 RID: 11140
	public int environmentType;

	// Token: 0x04002B85 RID: 11141
	public int environmentTypeDefault;

	// Token: 0x04002B86 RID: 11142
	public int previousDarkness;

	// Token: 0x04002B87 RID: 11143
	public bool openedTramLower;

	// Token: 0x04002B88 RID: 11144
	public bool openedTramRestingGrounds;

	// Token: 0x04002B89 RID: 11145
	public int tramLowerPosition;

	// Token: 0x04002B8A RID: 11146
	public int tramRestingGroundsPosition;

	// Token: 0x04002B8B RID: 11147
	public bool mineLiftOpened;

	// Token: 0x04002B8C RID: 11148
	public bool menderDoorOpened;

	// Token: 0x04002B8D RID: 11149
	public bool vesselFragStagNest;

	// Token: 0x04002B8E RID: 11150
	public bool shamanPillar;

	// Token: 0x04002B8F RID: 11151
	public bool crossroadsMawlekWall;

	// Token: 0x04002B90 RID: 11152
	public bool eggTempleVisited;

	// Token: 0x04002B91 RID: 11153
	public bool crossroadsInfected;

	// Token: 0x04002B92 RID: 11154
	public bool falseKnightFirstPlop;

	// Token: 0x04002B93 RID: 11155
	public bool falseKnightWallRepaired;

	// Token: 0x04002B94 RID: 11156
	public bool falseKnightWallBroken;

	// Token: 0x04002B95 RID: 11157
	public bool falseKnightGhostDeparted;

	// Token: 0x04002B96 RID: 11158
	public bool spaBugsEncountered;

	// Token: 0x04002B97 RID: 11159
	public bool hornheadVinePlat;

	// Token: 0x04002B98 RID: 11160
	public bool infectedKnightEncountered;

	// Token: 0x04002B99 RID: 11161
	public bool megaMossChargerEncountered;

	// Token: 0x04002B9A RID: 11162
	public bool megaMossChargerDefeated;

	// Token: 0x04002B9B RID: 11163
	public bool dreamerScene1;

	// Token: 0x04002B9C RID: 11164
	public bool slugEncounterComplete;

	// Token: 0x04002B9D RID: 11165
	public bool defeatedDoubleBlockers;

	// Token: 0x04002B9E RID: 11166
	public bool oneWayArchive;

	// Token: 0x04002B9F RID: 11167
	public bool defeatedMegaJelly;

	// Token: 0x04002BA0 RID: 11168
	public bool summonedMonomon;

	// Token: 0x04002BA1 RID: 11169
	public bool sawWoundedQuirrel;

	// Token: 0x04002BA2 RID: 11170
	public bool encounteredMegaJelly;

	// Token: 0x04002BA3 RID: 11171
	public bool defeatedMantisLords;

	// Token: 0x04002BA4 RID: 11172
	public bool encounteredGatekeeper;

	// Token: 0x04002BA5 RID: 11173
	public bool deepnestWall;

	// Token: 0x04002BA6 RID: 11174
	public bool queensStationNonDisplay;

	// Token: 0x04002BA7 RID: 11175
	public bool cityBridge1;

	// Token: 0x04002BA8 RID: 11176
	public bool cityBridge2;

	// Token: 0x04002BA9 RID: 11177
	public bool cityLift1;

	// Token: 0x04002BAA RID: 11178
	public bool cityLift1_isUp;

	// Token: 0x04002BAB RID: 11179
	public bool liftArrival;

	// Token: 0x04002BAC RID: 11180
	public bool openedMageDoor;

	// Token: 0x04002BAD RID: 11181
	public bool openedMageDoor_v2;

	// Token: 0x04002BAE RID: 11182
	public bool brokenMageWindow;

	// Token: 0x04002BAF RID: 11183
	public bool brokenMageWindowGlass;

	// Token: 0x04002BB0 RID: 11184
	public bool mageLordEncountered;

	// Token: 0x04002BB1 RID: 11185
	public bool mageLordEncountered_2;

	// Token: 0x04002BB2 RID: 11186
	public bool mageLordDefeated;

	// Token: 0x04002BB3 RID: 11187
	public bool ruins1_5_tripleDoor;

	// Token: 0x04002BB4 RID: 11188
	public bool openedCityGate;

	// Token: 0x04002BB5 RID: 11189
	public bool cityGateClosed;

	// Token: 0x04002BB6 RID: 11190
	public bool bathHouseOpened;

	// Token: 0x04002BB7 RID: 11191
	public bool bathHouseWall;

	// Token: 0x04002BB8 RID: 11192
	public bool cityLift2;

	// Token: 0x04002BB9 RID: 11193
	public bool cityLift2_isUp;

	// Token: 0x04002BBA RID: 11194
	public bool city2_sewerDoor;

	// Token: 0x04002BBB RID: 11195
	public bool openedLoveDoor;

	// Token: 0x04002BBC RID: 11196
	public bool watcherChandelier;

	// Token: 0x04002BBD RID: 11197
	public bool completedQuakeArea;

	// Token: 0x04002BBE RID: 11198
	public bool kingsStationNonDisplay;

	// Token: 0x04002BBF RID: 11199
	public bool tollBenchCity;

	// Token: 0x04002BC0 RID: 11200
	public bool waterwaysGate;

	// Token: 0x04002BC1 RID: 11201
	public bool defeatedDungDefender;

	// Token: 0x04002BC2 RID: 11202
	public bool dungDefenderEncounterReady;

	// Token: 0x04002BC3 RID: 11203
	public bool flukeMotherEncountered;

	// Token: 0x04002BC4 RID: 11204
	public bool flukeMotherDefeated;

	// Token: 0x04002BC5 RID: 11205
	public bool openedWaterwaysManhole;

	// Token: 0x04002BC6 RID: 11206
	public bool waterwaysAcidDrained;

	// Token: 0x04002BC7 RID: 11207
	public bool dungDefenderWallBroken;

	// Token: 0x04002BC8 RID: 11208
	public bool dungDefenderSleeping;

	// Token: 0x04002BC9 RID: 11209
	public bool defeatedMegaBeamMiner;

	// Token: 0x04002BCA RID: 11210
	public bool defeatedMegaBeamMiner2;

	// Token: 0x04002BCB RID: 11211
	public bool brokeMinersWall;

	// Token: 0x04002BCC RID: 11212
	public bool encounteredMimicSpider;

	// Token: 0x04002BCD RID: 11213
	public bool steppedBeyondBridge;

	// Token: 0x04002BCE RID: 11214
	public bool deepnestBridgeCollapsed;

	// Token: 0x04002BCF RID: 11215
	public bool spiderCapture;

	// Token: 0x04002BD0 RID: 11216
	public bool openedRestingGrounds02;

	// Token: 0x04002BD1 RID: 11217
	public bool restingGroundsCryptWall;

	// Token: 0x04002BD2 RID: 11218
	public bool dreamNailConvo;

	// Token: 0x04002BD3 RID: 11219
	public int gladeGhostsKilled;

	// Token: 0x04002BD4 RID: 11220
	public bool openedGardensStagStation;

	// Token: 0x04002BD5 RID: 11221
	public bool extendedGramophone;

	// Token: 0x04002BD6 RID: 11222
	public bool tollBenchQueensGardens;

	// Token: 0x04002BD7 RID: 11223
	public bool blizzardEnded;

	// Token: 0x04002BD8 RID: 11224
	public bool encounteredHornet;

	// Token: 0x04002BD9 RID: 11225
	public bool savedByHornet;

	// Token: 0x04002BDA RID: 11226
	public bool outskirtsWall;

	// Token: 0x04002BDB RID: 11227
	public bool abyssGateOpened;

	// Token: 0x04002BDC RID: 11228
	public bool abyssLighthouse;

	// Token: 0x04002BDD RID: 11229
	public bool blueVineDoor;

	// Token: 0x04002BDE RID: 11230
	public bool gotShadeCharm;

	// Token: 0x04002BDF RID: 11231
	public bool tollBenchAbyss;

	// Token: 0x04002BE0 RID: 11232
	public int fountainGeo;

	// Token: 0x04002BE1 RID: 11233
	public bool fountainVesselSummoned;

	// Token: 0x04002BE2 RID: 11234
	public bool openedBlackEggPath;

	// Token: 0x04002BE3 RID: 11235
	public bool enteredDreamWorld;

	// Token: 0x04002BE4 RID: 11236
	public bool duskKnightDefeated;

	// Token: 0x04002BE5 RID: 11237
	public bool whitePalaceOrb_1;

	// Token: 0x04002BE6 RID: 11238
	public bool whitePalaceOrb_2;

	// Token: 0x04002BE7 RID: 11239
	public bool whitePalaceOrb_3;

	// Token: 0x04002BE8 RID: 11240
	public bool whitePalace05_lever;

	// Token: 0x04002BE9 RID: 11241
	public bool whitePalaceMidWarp;

	// Token: 0x04002BEA RID: 11242
	public bool whitePalaceSecretRoomVisited;

	// Token: 0x04002BEB RID: 11243
	public bool tramOpenedDeepnest;

	// Token: 0x04002BEC RID: 11244
	public bool tramOpenedCrossroads;

	// Token: 0x04002BED RID: 11245
	public bool openedBlackEggDoor;

	// Token: 0x04002BEE RID: 11246
	public bool unchainedHollowKnight;

	// Token: 0x04002BEF RID: 11247
	public int flamesCollected;

	// Token: 0x04002BF0 RID: 11248
	public int flamesRequired;

	// Token: 0x04002BF1 RID: 11249
	public bool nightmareLanternAppeared;

	// Token: 0x04002BF2 RID: 11250
	public bool nightmareLanternLit;

	// Token: 0x04002BF3 RID: 11251
	public bool troupeInTown;

	// Token: 0x04002BF4 RID: 11252
	public bool divineInTown;

	// Token: 0x04002BF5 RID: 11253
	public int grimmChildLevel;

	// Token: 0x04002BF6 RID: 11254
	public bool elderbugConvoGrimm;

	// Token: 0x04002BF7 RID: 11255
	public bool slyConvoGrimm;

	// Token: 0x04002BF8 RID: 11256
	public bool iseldaConvoGrimm;

	// Token: 0x04002BF9 RID: 11257
	public bool midwifeWeaverlingConvo;

	// Token: 0x04002BFA RID: 11258
	public bool metGrimm;

	// Token: 0x04002BFB RID: 11259
	public bool foughtGrimm;

	// Token: 0x04002BFC RID: 11260
	public bool metBrum;

	// Token: 0x04002BFD RID: 11261
	public bool defeatedNightmareGrimm;

	// Token: 0x04002BFE RID: 11262
	public bool grimmchildAwoken;

	// Token: 0x04002BFF RID: 11263
	public bool gotBrummsFlame;

	// Token: 0x04002C00 RID: 11264
	public bool brummBrokeBrazier;

	// Token: 0x04002C01 RID: 11265
	public bool destroyedNightmareLantern;

	// Token: 0x04002C02 RID: 11266
	public bool gotGrimmNotch;

	// Token: 0x04002C03 RID: 11267
	public bool nymmInTown;

	// Token: 0x04002C04 RID: 11268
	public bool nymmSpoken;

	// Token: 0x04002C05 RID: 11269
	public bool nymmCharmConvo;

	// Token: 0x04002C06 RID: 11270
	public bool nymmFinalConvo;

	// Token: 0x04002C07 RID: 11271
	public bool elderbugNymmConvo;

	// Token: 0x04002C08 RID: 11272
	public bool slyNymmConvo;

	// Token: 0x04002C09 RID: 11273
	public bool iseldaNymmConvo;

	// Token: 0x04002C0A RID: 11274
	public bool nymmMissedEggOpen;

	// Token: 0x04002C0B RID: 11275
	public bool elderbugTroupeLeftConvo;

	// Token: 0x04002C0C RID: 11276
	public bool elderbugBrettaLeft;

	// Token: 0x04002C0D RID: 11277
	public bool jijiGrimmConvo;

	// Token: 0x04002C0E RID: 11278
	public bool metDivine;

	// Token: 0x04002C0F RID: 11279
	public bool divineFinalConvo;

	// Token: 0x04002C10 RID: 11280
	public bool gaveFragileHeart;

	// Token: 0x04002C11 RID: 11281
	public bool gaveFragileGreed;

	// Token: 0x04002C12 RID: 11282
	public bool gaveFragileStrength;

	// Token: 0x04002C13 RID: 11283
	public int divineEatenConvos;

	// Token: 0x04002C14 RID: 11284
	public bool pooedFragileHeart;

	// Token: 0x04002C15 RID: 11285
	public bool pooedFragileGreed;

	// Token: 0x04002C16 RID: 11286
	public bool pooedFragileStrength;

	// Token: 0x04002C17 RID: 11287
	public float completionPercentage;

	// Token: 0x04002C18 RID: 11288
	public bool disablePause;

	// Token: 0x04002C19 RID: 11289
	public bool backerCredits;

	// Token: 0x04002C1A RID: 11290
	public bool unlockedCompletionRate;

	// Token: 0x04002C1B RID: 11291
	public int mapKeyPref;

	// Token: 0x04002C1C RID: 11292
	public List<string> playerStory;

	// Token: 0x04002C1D RID: 11293
	public string playerStoryOutput;

	// Token: 0x04002C1E RID: 11294
	public bool betaEnd;

	// Token: 0x04002C1F RID: 11295
	public bool newDatTraitorLord;

	// Token: 0x04002C20 RID: 11296
	private static PlayerData _instance;

	// Token: 0x02000797 RID: 1943
	private enum MapBools
	{
		// Token: 0x04002C22 RID: 11298
		MapDirtmouth,
		// Token: 0x04002C23 RID: 11299
		MapCrossroads,
		// Token: 0x04002C24 RID: 11300
		MapGreenpath,
		// Token: 0x04002C25 RID: 11301
		MapFogCanyon,
		// Token: 0x04002C26 RID: 11302
		MapRoyalGardens,
		// Token: 0x04002C27 RID: 11303
		MapFungalWastes,
		// Token: 0x04002C28 RID: 11304
		MapCity,
		// Token: 0x04002C29 RID: 11305
		MapWaterways,
		// Token: 0x04002C2A RID: 11306
		MapMines,
		// Token: 0x04002C2B RID: 11307
		MapDeepnest,
		// Token: 0x04002C2C RID: 11308
		MapCliffs,
		// Token: 0x04002C2D RID: 11309
		MapOutskirts,
		// Token: 0x04002C2E RID: 11310
		MapRestingGrounds,
		// Token: 0x04002C2F RID: 11311
		MapAbyss
	}
}
