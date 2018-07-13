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
using SCHREDDO.Nerdy.UserInput.Emulator.Structs;

namespace SCHREDDO.Nerdy.UserInput.Emulator
{
    public static class NerdyUserInputEmulator
    {
        public static void SendKeyboardInput(KeyName key)
        {
            Input[] inputs = { BuildKeyInput(key) };

            SendInput(1, inputs, Input.Size);
        }

        public static void SendKeyboardInput(KeyName[] keys)
        {
            Input[] inputs = new Input[keys.Length];

            for (int i = 0; i < keys.Length; i++)
            {
                inputs[i] = BuildKeyInput(keys[i]);
            }

            SendInput((uint)inputs.Length, inputs, Input.Size);
        }

        private static Input BuildKeyInput(KeyName key)
        {
            Input input = new Input();

            input.type = 1;
            input.inputUnion.keyInput.scanCodeShort = GetScanCodeShort(key);
            input.inputUnion.keyInput.keyEventFLag = KeyEventFlag.SCANCODE;

            return input;
        }

        private static ScanCodeShort GetScanCodeShort(KeyName key)
        {
            return (ScanCodeShort)System.Enum.Parse(typeof(ScanCodeShort), "SCS_" + key);
        }

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] Input[] pInputs, int cbSize);
    }
}
