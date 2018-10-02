public var score : int;
public var scoretexture : Texture;
public var xPOS : int;
public var yPOS : int;
public var gwidth : int = 200;
public var gheight : int = 100; 
private var GUIFontStyle : GUIStyle = new GUIStyle(); 


//-----------------------------------------

function Start () {
	
	GUIFontStyle.fontSize = 60;
	GUIFontStyle.normal.textColor = Color(255, 255, 255);
	GUIFontStyle.alignment = TextAnchor.MiddleRight;
	
}

//-------------------------------------------------


function OnGUI () {

GUI.DrawTexture (Rect(xPOS,yPOS,gwidth,gheight ),scoretexture);
GUI.Label(Rect(xPOS+10,yPOS+10,gwidth-20,gheight-20 ),score.ToString(),GUIFontStyle);
	
}
