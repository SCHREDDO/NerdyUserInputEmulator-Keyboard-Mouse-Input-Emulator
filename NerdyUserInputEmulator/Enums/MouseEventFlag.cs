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

namespace SCHREDDO.Nerdy.UserInput.Emulator.Enums
{
    [Flags]
    internal enum MouseEventFlag : uint
    {
        ABSOLUTE = 0x8000,
        HWHEEL = 0x01000,
        MOVE = 0x0001,
        MOVE_NO_COALESCE = 0x2000,
        LEFT_DOWN = 0x0002,
        LEFT_UP = 0x0004,
        RIGHT_DOWN = 0x0008,
        RIGHT_UP = 0x0010,
        MIDDLE_DOWN = 0x0020,
        MIDDLE_UP = 0x0040,
        VIRTUAL_DESK = 0x4000,
        WHEEL = 0x0800,
        X_DOWN = 0x0080,
        X_UP = 0x0100
    }
}
