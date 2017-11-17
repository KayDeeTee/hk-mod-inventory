using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ModInventory;

public class Inventory : PaneHandler {

	public PlayerData pd;

	public Sprite[] healthSprite;
	public Sprite[] vesselSprite;
	public Sprite[] nailSprite;

	public Sprite[] fireballSprite;
	public Sprite[] quakeSprite;
	public Sprite[] screamSprite;

	public Sprite spellBG;
	public Sprite soulSprite;
	public override void PreInit(){
		//load sprites here
	}

	public override void Init(){
		invItems.Add( new InvItem("HP", new Vector2(-745,220), new Vector2(395,376), dirPress, getSprite, onSelect, onSubmit, "heartPieces", true) );
		invItems.Add( new InvItem("mpbg", new Vector2(-582,221f), new Vector2(140,140), null, getSprite, null, null, "", true) );
		invItems.Add( new InvItem("MP", new Vector2(-580,225), new Vector2(102,102), dirPress, getSprite, onSelect, onSubmit, "vesselFragments", true) );
		invItems.Add( new InvItem("NAIL", new Vector2(-750,-145), new Vector2(100,370), dirPress, getSprite, onSelect, onSubmit, "nailSmithUpgrades", true) );

		invItems.Add( new InvItem("SOUL", new Vector2(-480,-20), new Vector2(200,200), dirPress, getSprite, onSelect, onSubmit, "", true) );

		invItems.Add( new InvItem("bg", new Vector2(-107-480,62.5f-20), new Vector2(80,80), null, getSprite, null, null, "", true) );
		invItems.Add( new InvItem("bg", new Vector2(108-480,62.5f-20), new Vector2(80,80), null, getSprite, null, null, "", true) );
		invItems.Add( new InvItem("bg", new Vector2(0-480,-124-20), new Vector2(80,80), null, getSprite, null, null, "", true) );

		invItems.Add( new InvItem("FIREBALL", new Vector2(-107-480,62.5f-20), new Vector2(119,119), dirPress, getSprite, onSelect, onSubmit, "fireballLevel", true) );
		invItems.Add( new InvItem("QUAKE", new Vector2(108-480,62.5f-20), new Vector2(93,93), dirPress, getSprite, onSelect, onSubmit, "quakeLevel", true) );
		invItems.Add( new InvItem("SCREAM", new Vector2(0-480,-124-20), new Vector2(106,106), dirPress, getSprite, onSelect, onSubmit, "screamLevel", true) );


	}

	public InvItem dirPress(MoveDirection md, string itemName){
		switch (itemName) {
		case "HP":
			if (md == MoveDirection.UP) return findItemByName("HP");
			if (md == MoveDirection.RIGHT) return findItemByName ("MP");
			if (md == MoveDirection.DOWN) return findItemByName ("NAIL");
			if (md == MoveDirection.LEFT) return paneLeft;
			break;
		case "MP":
			if (md == MoveDirection.LEFT) return findItemByName ("HP");
			if (md == MoveDirection.DOWN) return pd.GetInt ("fireballLevel") > 0 ? findItemByName ("FIREBALL") : findItemByName ("SOUL");
			break;
		default: return invItems [0];
		}
		return invItems [0];
	}

	public Sprite getSprite(string itemName, string varName){
		int x = 0;
		switch (itemName) {
		case "HP": return healthSprite[ pd.GetInt(varName) ];
		case "MP": return vesselSprite[ pd.GetInt(varName) ];
		case "NAIL": return nailSprite[ pd.GetInt(varName) ];
		case "FIREBALL":
			x = pd.GetInt (varName);
			if (x == 0)
				return CanvasUtils.CanvasUtil.nullSprite ();
			return fireballSprite [x-1];
		case "QUAKE":
			x = pd.GetInt (varName);
			if (x == 0)
				return CanvasUtils.CanvasUtil.nullSprite ();
			return quakeSprite [x-1];
		case "SCREAM":
			x = pd.GetInt (varName);
			if (x == 0)
				return CanvasUtils.CanvasUtil.nullSprite ();
			return screamSprite [x-1];
		case "mpbg": return vesselSprite [0];
		case "bg": return spellBG;
		case "SOUL": return soulSprite;			
		default: return CanvasUtils.CanvasUtil.nullSprite ();
		}
	}

	public void onSelect(string n, string v){
	}

	public void onSubmit(string n, string v){
	}
}
