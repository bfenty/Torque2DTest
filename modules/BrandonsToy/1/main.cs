//BrandonsToy Main.cs
function BrandonsToy::create(%this)
{
	exec( "./scripts/BrandonScript.cs" );
	echo("@@@ BrandonToy Created");
	BrandonsToy.mySpriteSize = 5;
	addNumericOption("Sprite Size", 1, 10, 1, "setMySpriteSize", %this.mySpriteSize, true, "Determines the size of my Sprite");
	BrandonsToy.reset();
	
}

function BrandonsToy::destroy(%this)
{
	echo("@@@ BrandonToy Destroyed");
}

function BrandonsToy::reset(%this)
{
	echo("@@@ BrandonToy Reset");
	
	SandboxScene.clear();
	
	SandboxScene.setGravity(0, 0);
	
	%size = %this.mySpriteSize SPC %this.mySpriteSize;
	
	//Create Sprite
	%position = "0 0";
	%sprite = buildMySprite(%position, %size);
	
	//Add to scene
	SandboxScene.add(%sprite);
}

function BrandonsToy::setMySpriteSize(%this, %value)
{
	%this.mySpriteSize = %value;
}
