/*
 * Copyright (C) 2016 Vinicius Rogério Araujo Silva
 * 
 * This file is part of RAMvader-LittleFighters2.
 * 
 * RAMvader-LittleFighters2 is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * RAMvader-LittleFighters2 is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with RAMvader-LittleFighters2. If not, see <http://www.gnu.org/licenses/>.
 */

/* This file keeps definitions for code elements which are part of the low-level features of the trainer. */
using RAMvader.CodeInjection;
using System;

namespace TrainerApp
{
	/// <summary>Identifiers for all cheats available in the trainer.</summary>
	public enum ECheat
	{
		/// <summary>Identifies the "Infinite HP" cheat.</summary>
		evCheatInfiniteHP,
	}





	/// <summary>Identifiers for all of the code caves injected into the game process' memory space,
	/// once the trainer gets attached to the game.</summary>
	public enum ECodeCave
	{
		/// <summary>Identifier for the "Infinite HP" code cave.</summary>
		[CodeCaveDefinition( 0x53, 0x51, 0x52, 0x8B, 0x1D, EVariable.evVarInfiniteHPTeamsBitmask, 0x31, 0xC9, 0x41, 0x31, 0xD2, 0x42, 0xD3, 0xE2, 0x85, 0xDA, 0x74, 0x13, 0x3B, 0x8E, 0x64, 0x03, 0x00, 0x00, 0x75, 0x0B, 0x68, 0xF4, 0x01, 0x00, 0x00, 0x8F, 0x86, 0xFC, 0x02, 0x00, 0x00, 0x41, 0x83, 0xF9, 0x06, 0x72, 0xDE, 0x31, 0xD2, 0x42, 0x85, 0xDA, 0x74, 0x14, 0x83, 0xBE, 0x64, 0x03, 0x00, 0x00, 0x0A, 0x72, 0x0B, 0x68, 0xF4, 0x01, 0x00, 0x00, 0x8F, 0x86, 0xFC, 0x02, 0x00, 0x00, 0x5A, 0x59, 0x5B, 0x39, 0x86, 0xFC, 0x02, 0x00, 0x00, 0xC3 )]
		evCodeCaveInfiniteHP,
	}





	/// <summary>Identifiers for all variables injected into the game process' memory space,
	/// once the trainer gets attached to the game.</summary>
	public enum EVariable
	{
		/// <summary>Identifies a variable which stores a bitmask where each bit specifies if the cheat is enabled or disabled for each team.</summary>
		[VariableDefinition( (UInt32) 0 )]
		evVarInfiniteHPTeamsBitmask,
	}
}