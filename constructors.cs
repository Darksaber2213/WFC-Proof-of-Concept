function construct(%class, %arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10, %arg11, %arg12, %arg13, %arg14, %arg15, %arg16, %arg17)
{
	%object = new ScriptObject(%class @ "@" @ sha1(%class @ $Sim::Time))
	{
		class = %class;
	};
	%object.constructor(%arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10, %arg11, %arg12, %arg13, %arg14, %arg15, %arg16, %arg17);
	return %object;
}

function inherit(%class, %super, %arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10, %arg11, %arg12, %arg13, %arg14, %arg15, %arg16)
{
	%object = new ScriptObject(%class @ "@" @ sha1(%class @ %super @ $Sim::Time))
	{
		class = %class;
		superClass = %super;
	};
	%object.constructor(%arg0, %arg1, %arg2, %arg3, %arg4, %arg5, %arg6, %arg7, %arg8, %arg9, %arg10, %arg11, %arg12, %arg13, %arg14, %arg15, %arg16);
	return %object;
}