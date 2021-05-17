#pragma strict

/*Create an image in your photo editor that when placed on top of your image
would give you the vignette look you want. Begin with a transparent image and 
darken the corners might be a place to start. Import the image into Unity. 
Several import settings will work, but start with a) Texture type = advanced 
b) Generate Mip Maps=off c) Format=RGBA 32 bit)
fStartVig is the field of view when the first hint of a vignette will 
appear. FMaxVig is the field of view where the vignette will be 
completely displayed.
*/


var texVignette : Texture;

//fStartVig is the field of view when the first hint of a vignette will appear
var fStartVig : float = 40.0;

//MaxVig is the field of view where the vignette will be completely displayed.
var fMaxVig : float = 10.0;
 
function OnGUI()
{
	var fAlpha : float;
	var fFOV = Camera.main.fieldOfView;
	if (fFOV < fStartVig)
	{
		if (fFOV < fMaxVig)
		{
			fAlpha = 1.0;
		}
		else
		{
			fAlpha = (fStartVig - fFOV) / (fStartVig - fMaxVig);
		}
			//Black color
			GUI.color = Color(0f, 0f, 0f, fAlpha);
			
			GUI.DrawTexture (Rect (0, 0, Screen.width, Screen.height),texVignette);
 
	}
} 