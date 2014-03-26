function buildMySprite(%position, %size)
{
	%sprite = new Sprite();
	%sprite.Position = %position;
	%sprite.Size = %size;
	
	%sprite.Image = "ToyAssets:football";
	
	%sprite.setBodyType("static");
	
	return %sprite;
}
