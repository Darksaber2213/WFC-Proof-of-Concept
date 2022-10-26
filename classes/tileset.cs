// A "Tileset" is a set of Tiles that the Grid uses to determine constraints to collapse the Nodes into definitive states.

function Tileset::constructor(%this, %tilesetName)
{
	%this.tileCount = 0;
	%this.loadTilesFromTilesetName(%tilesetName);
}

function Tileset::loadTilesFromTilesetName(%this, %tilesetName)
{
	%directory = $WFC::Root @ "/tilesets/" @ %tilesetName;
	%this.loadTilesFromDirectory(%directory);
}

function Tileset::loadTilesFromDirectory(%this, %directory)
{
	%reader = new FileObject();
	%pattern = %directory @ "/*.txt";
	echo("Loading tiles from directory pattern:\c1" SPC %pattern);
	
	for(%file = findFirstFile(%pattern); %file !$= ""; %file = findNextFile(%pattern))
	{
		echo("Loading tile from:\c1" SPC %file);
		%tileData = "";
		%reader.openForRead(%file);
		
		while(!%reader.isEOF())
		{
			%line = %reader.readLine();
			%tileData = %tileData NL %line;
		}
		
		%reader.close();
		%tileData = trim(%tileData);
		echo("\c0Read tile data:\c1" SPC fileName(%file) @ "\c0, contents:\c4" SPC %tileData);
		
		%this.tile[%this.tileCount++ - 1] = construct
		(
			Tile,
			getField(%tileData, 0),
			getField(%tileData, 1),
			getField(%tileData, 2),
			getField(%tileData, 3),
			getField(%tileData, 4),
			getField(%tileData, 5)
		);
	}
	
	%reader.delete();
}