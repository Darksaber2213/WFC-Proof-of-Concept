// A "Tile" is a data structure that contains information about a possible generative state of a Node in the Grid.
// The Tile contains keys that represent constraints on which possible Tiles it can neighbour.
// Each Tile also contains the bricks to build when the Grid has finished collapsing. TODO: Implement.

function Tile::constructor(%this, %constraintN, %constraintE, %constraintS, %constraintW, %constraintU, %constraintD)
{
	// Constraint keys. Usually represented as a single uppercause A-Z character.
	%this.constraintN = %constraintN;
	%this.constraintE = %constraintE;
	%this.constraintS = %constraintS;
	%this.constraintW = %constraintW;
	%this.constraintU = %constraintU;
	%this.constraintD = %constraintD;
}