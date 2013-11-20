#pragma strict

var exitButton : Texture2D;
var exitHover : Texture2D;

function Start () {

}

function OnMouseEnter () {

	guiTexture.texture = exitHover;

}

function OnMouseExit () {

	guiTexture.texture = exitButton;

}

function OnMouseDown () {

	Application.Quit();

}