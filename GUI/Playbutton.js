#pragma strict

var playButton : Texture2D;
var playHover : Texture2D;

function Start () {

}

function OnMouseEnter () {

	guiTexture.texture = playHover;

}

function OnMouseExit () {

	guiTexture.texture = playButton;

}

function OnMouseDown () {

	Application.LoadLevel("Teh Wurld");

}