$WFC::Root = filePath($Con::File);

exec($WFC::Root @ "/constructors.cs");
exec($WFC::Root @ "/classes/tile.cs");
exec($WFC::Root @ "/classes/tileset.cs");
exec($WFC::Root @ "/classes/node.cs");
exec($WFC::Root @ "/classes/grid.cs");