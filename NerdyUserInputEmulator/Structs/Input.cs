// Copyright (C) 2018 Sebastian Lühnen
//
//
// This file is part of NerdyUserInputEmulator.
// 
// NerdyUserInputEmulator is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// NerdyUserInputEmulator is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with NerdyUserInputEmulator. If not, see <http://www.gnu.org/licenses/>.
//
//
// Created By: Sebastian Lühnen
// Created On: 30.06.2018
// Last Edited On: 13.07.2018
// Language: C#
//
using System;
using System.Runtime.InteropServices;

using SCHREDDO.Nerdy.UserInput.Emulator.Enums;

namespace SCHREDDO.Nerdy.UserInput.Emulator.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct Input
    {
        internal uint type;
        internal InputUnion inputUnion;
        internal static int Size
        {
            get { return Marshal.SizeOf(typeof(Input)); }
        }
    }
}
