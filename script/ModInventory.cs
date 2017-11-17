using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using CanvasUtils;

namespace ModInventory{

	public enum MoveDirection{
		UP,
		RIGHT,
		DOWN,
		LEFT
	}

	public class InvItem{
		public string n;
		public Vector2 position;
		public Vector2 rectSize;
		public Func<MoveDirection, string, InvItem> onMove;
		public Func<string, string, Sprite> getSprite;

		public Action<string, string> onSelect;
		public Action<string, string> onSubmit;

		public bool enabled;

		public string v;
		/*
		 * name to check against in function, and to search for
		 * position on screen to display, relative to centre of screen,
		 * size of image to display,
		 * function to run when you attempt to move whilst having this item selected, returns the item you want to select,
		 * funciton that sends the name of the item and the variable you set, expects the sprite you want it to render,
		 * name of the variable you want to lookup in playerData ( or anywhere else you control it
		 */
		public InvItem( string name, Vector2 pos, Vector2 size, Func<MoveDirection, string, InvItem> moved, Func<string, string, Sprite> loadSprite, Action<string, string> sel, Action<string, string> submit, string variable, bool enable ){
			n = name;
			position = pos;
			rectSize = size;
			onMove = moved;
			getSprite = loadSprite;

			onSelect = sel;
			onSubmit = submit;

			v = variable;
			enabled = enable;
		}

	}

	public abstract class PaneHandler : MonoBehaviour {

		public static GameObject invCanvas;
		public static GameObject menuGroup;
		public static PaneHandler firstPane;

		public PaneHandler prevPane;
		public PaneHandler nextPane;

		public Sprite paneSprite;

		public static InvItem paneLeft;
		public static InvItem paneRight;

		public List<InvItem> invItems;
		public InvItem selected;

		public GameObject rootPanel;

		public bool enabled;

		public int startPos;
		public int endPos;
		public static float duration = 0.75f;
		public float startTime = 0f;

		public string paneTitle;

		public string sName;
		public bool preInit;
		abstract public void PreInit ();
		abstract public void Init ();

		public void Start(){
			setUp ();
		}

		public void setUp(){

			if (invCanvas == null) {
				enabled = true;
				firstPane = this;
				firstPane.nextPane = this;
				firstPane.prevPane = this;
				CanvasUtil.createFonts ();
				invCanvas = CanvasUtil.createCanvas (RenderMode.ScreenSpaceOverlay, new Vector2 (1920, 1080));
				invCanvas.name = "Canvas";
				menuGroup = CanvasUtil.createBasePanel (invCanvas, new CanvasUtil.RectData (new Vector2 (0, 0), new Vector2 (0, 0), new Vector2 (0, 0), new Vector2 (1, 1)));
				menuGroup.name = "Menu";
				menuGroup.AddComponent<CanvasGroup> ();

				paneLeft = new InvItem ("PaneLeft", new Vector2 (-900, 0), new Vector2 (58, 133), internalMove, internalLoad, internalSelect, internalSubmit, "", true);
				paneRight = new InvItem ("PaneRight", new Vector2 (900, 0), new Vector2 (58, 133), internalMove, internalLoad, internalSelect, internalSubmit, "", true);
				GameObject paneL = CanvasUtil.createImagePanel (invCanvas, paneLeft.getSprite (paneLeft.n, paneLeft.v), new CanvasUtil.RectData (paneLeft.rectSize, paneLeft.position));
				paneL.name = paneLeft.n;
				GameObject paneR = CanvasUtil.createImagePanel (invCanvas, paneRight.getSprite (paneRight.n, paneRight.v), new CanvasUtil.RectData (paneRight.rectSize, paneRight.position));
				paneR.name = paneRight.n;
				paneR.transform.localScale = new Vector3 (-1, 1, 1);
			} else {
				enabled = false;
			}

			if (!preInit) {
				//insert at end of list
				prevPane = firstPane.prevPane;
				prevPane.nextPane = this;
				firstPane.prevPane = this;
				nextPane = firstPane;

				rootPanel = CanvasUtil.createBasePanel(menuGroup, new CanvasUtil.RectData (new Vector2 (0, 0), new Vector2 (0, 0)));
				//rootPanel.SetActive (tr);

				PreInit ();
				preInit = true;
			}

			invItems = new List<InvItem> ();
			Init ();

			foreach (InvItem item in invItems) {
				CanvasUtil.createImagePanel (rootPanel, item.getSprite (item.n, item.v), new CanvasUtil.RectData (item.rectSize, item.position)).name = item.n;
			}

			selected = invItems [0];

		}

		protected InvItem findItemByName(string name){
			foreach (InvItem i in invItems) {
				if (i.n == name)
					return i;
			}
			return null;
		}

		private InvItem internalMove(MoveDirection md, string name){
			if (name == "PaneLeft") {
				if (md == MoveDirection.LEFT) {
					if (prevPane != this) {
						prevPane.slideIn (MoveDirection.LEFT);
						slideOut (MoveDirection.LEFT);
					}
				}
				if (md == MoveDirection.RIGHT) {
					return invItems [0];
				}
				return paneLeft;
			}
			if (name == "PaneRight") {
				if (md == MoveDirection.RIGHT) {
					if (nextPane != this) {
						nextPane.slideIn (MoveDirection.RIGHT);
						slideOut (MoveDirection.RIGHT);
					}
				}
				if (md == MoveDirection.LEFT) {
					return invItems [invItems.Count-1];
				}
				return paneRight;
			}
			return invItems [0];
		}

		private Sprite internalLoad(string name, string var){
			if (name == "PaneLeft" || name == "PaneRight")
				return paneSprite;
			return CanvasUtil.nullSprite ();
		}

		//Send this pane off the screen in the direction passed in
		private void slideOut( MoveDirection md ){
			startTime = Time.realtimeSinceStartup;
			enabled = false;
			if (md == MoveDirection.LEFT)
				endPos = -1920;
			else
				endPos = 1920;
			startPos = 0;
		}

		private void slideIn( MoveDirection md ){
			startTime = Time.realtimeSinceStartup;
			enabled = true;
			if (md == MoveDirection.LEFT)
				startPos = 1920;
			else
				startPos = -1920;
			endPos = 0;
			
		}

		private void internalSelect(string n, string v){
		}

		private void internalSubmit(string n, string v){
			if( name == "PaneLeft" ){
				if (prevPane != this) {
					prevPane.slideIn (MoveDirection.LEFT);
					slideOut (MoveDirection.LEFT);
				}
			}
			if (name == "PaneRight") {
				if (nextPane != this) {
					nextPane.slideIn (MoveDirection.RIGHT);
					slideOut (MoveDirection.RIGHT);
				}
			}
		}

		public void Update(){
			if (Time.realtimeSinceStartup - startTime < duration) {
				rootPanel.transform.localPosition = new Vector2 (Mathf.Lerp (startPos, endPos, (Time.realtimeSinceStartup - startTime) / duration), 0);
			} else {
				if (enabled) {
					rootPanel.transform.localPosition = new Vector2 (0, 0);
					if (Input.GetKeyDown (KeyCode.RightArrow))
						selected = selected.onMove (MoveDirection.RIGHT, selected.n);
					if (Input.GetKeyDown (KeyCode.LeftArrow))
						selected = selected.onMove (MoveDirection.LEFT, selected.n);
					if (Input.GetKeyDown (KeyCode.UpArrow))
						selected = selected.onMove (MoveDirection.UP, selected.n);
					if (Input.GetKeyDown (KeyCode.DownArrow))
						selected = selected.onMove (MoveDirection.DOWN, selected.n);
					if (Input.GetKeyDown (KeyCode.A))
						selected.onSubmit (selected.n, selected.v);
				} else {
					rootPanel.transform.localPosition = new Vector2 (1920, 0);
				}
			}

			sName = selected.n;
		}

	}
}
