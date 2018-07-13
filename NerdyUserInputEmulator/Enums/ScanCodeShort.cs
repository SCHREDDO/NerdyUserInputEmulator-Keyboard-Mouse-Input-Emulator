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
    internal enum ScanCodeShort : short
    {
        SCS_L_BUTTON = 0,
        SCS_R_BUTTON = 0,
        SCS_CANCEL = 70,
        SCS_M_BUTTON = 0,
        SCS_X_BUTTON_1 = 0,
        SCS_X_BUTTON_2 = 0,
        SCS_BACK = 14,
        SCS_TAB = 15,
        SCS_CLEAR = 76,
        SCS_RETURN = 28,
        SCS_SHIFT = 42,
        SCS_CONTROL = 29,
        SCS_MENU = 56,
        SCS_PAUSE = 0,
        SCS_CAPITAL = 58,
        SCS_KANA = 0,
        SCS_HANGUEL = 0,
        SCS_HANGUL = 0,
        SCS_JUNJA = 0,
        SCS_FINAL = 0,
        SCS_HANJA = 0,
        SCS_KANJI = 0,
        SCS_ESCAPE = 1,
        SCS_CONVERT = 0,
        SCS_NONCONVERT = 0,
        SCS_ACCEPT = 0,
        SCS_MODECHANGE = 0,
        SCS_SPACE = 57,
        SCS_PRIOR = 73,
        SCS_NEXT = 81,
        SCS_END = 79,
        SCS_HOME = 71,
        SCS_LEFT = 75,
        SCS_UP = 72,
        SCS_RIGHT = 77,
        SCS_DOWN = 80,
        SCS_SELECT = 0,
        SCS_PRINT = 0,
        SCS_EXECUTE = 0,
        SCS_SNAPSHOT = 84,
        SCS_INSERT = 82,
        SCS_DELETE = 83,
        SCS_HELP = 99,
        SCS_KEY_0 = 11,
        SCS_KEY_1 = 2,
        SCS_KEY_2 = 3,
        SCS_KEY_3 = 4,
        SCS_KEY_4 = 5,
        SCS_KEY_5 = 6,
        SCS_KEY_6 = 7,
        SCS_KEY_7 = 8,
        SCS_KEY_8 = 9,
        SCS_KEY_9 = 10,
        SCS_KEY_A = 30,
        SCS_KEY_B = 48,
        SCS_KEY_C = 46,
        SCS_KEY_D = 32,
        SCS_KEY_E = 18,
        SCS_KEY_F = 33,
        SCS_KEY_G = 34,
        SCS_KEY_H = 35,
        SCS_KEY_I = 23,
        SCS_KEY_J = 36,
        SCS_KEY_K = 37,
        SCS_KEY_L = 38,
        SCS_KEY_M = 50,
        SCS_KEY_N = 49,
        SCS_KEY_O = 24,
        SCS_KEY_P = 25,
        SCS_KEY_Q = 16,
        SCS_KEY_R = 19,
        SCS_KEY_S = 31,
        SCS_KEY_T = 20,
        SCS_KEY_U = 22,
        SCS_KEY_V = 47,
        SCS_KEY_W = 17,
        SCS_KEY_X = 45,
        SCS_KEY_Y = 21,
        SCS_KEY_Z = 44,
        SCS_LWIN = 91,
        SCS_RWIN = 92,
        SCS_APPS = 93,
        SCS_SLEEP = 95,
        SCS_NUMPAD0 = 82,
        SCS_NUMPAD1 = 79,
        SCS_NUMPAD2 = 80,
        SCS_NUMPAD3 = 81,
        SCS_NUMPAD4 = 75,
        SCS_NUMPAD5 = 76,
        SCS_NUMPAD6 = 77,
        SCS_NUMPAD7 = 71,
        SCS_NUMPAD8 = 72,
        SCS_NUMPAD9 = 73,
        SCS_MULTIPLY = 55,
        SCS_ADD = 78,
        SCS_SEPARATOR = 0,
        SCS_SUBTRACT = 74,
        SCS_DECIMAL = 83,
        SCS_DIVIDE = 53,
        SCS_F1 = 59,
        SCS_F2 = 60,
        SCS_F3 = 61,
        SCS_F4 = 62,
        SCS_F5 = 63,
        SCS_F6 = 64,
        SCS_F7 = 65,
        SCS_F8 = 66,
        SCS_F9 = 67,
        SCS_F10 = 68,
        SCS_F11 = 87,
        SCS_F12 = 88,
        SCS_F13 = 100,
        SCS_F14 = 101,
        SCS_F15 = 102,
        SCS_F16 = 103,
        SCS_F17 = 104,
        SCS_F18 = 105,
        SCS_F19 = 106,
        SCS_F20 = 107,
        SCS_F21 = 108,
        SCS_F22 = 109,
        SCS_F23 = 110,
        SCS_F24 = 118,
        SCS_NUMLOCK = 69,
        SCS_SCROLL = 70,
        SCS_LSHIFT = 42,
        SCS_RSHIFT = 54,
        SCS_LCONTROL = 29,
        SCS_RCONTROL = 29,
        SCS_LMENU = 56,
        SCS_RMENU = 56,
        SCS_BROWSER_BACK = 106,
        SCS_BROWSER_FORWARD = 105,
        SCS_BROWSER_REFRESH = 103,
        SCS_BROWSER_STOP = 104,
        SCS_BROWSER_SEARCH = 101,
        SCS_BROWSER_FAVORITES = 102,
        SCS_BROWSER_HOME = 50,
        SCS_VOLUME_MUTE = 32,
        SCS_VOLUME_DOWN = 46,
        SCS_VOLUME_UP = 48,
        SCS_MEDIA_NEXT_TRACK = 25,
        SCS_MEDIA_PREV_TRACK = 16,
        SCS_MEDIA_STOP = 36,
        SCS_MEDIA_PLAY_PAUSE = 34,
        SCS_LAUNCH_MAIL = 108,
        SCS_LAUNCH_MEDIA_SELECT = 109,
        SCS_LAUNCH_APP1 = 107,
        SCS_LAUNCH_APP2 = 33,
        SCS_OEM_1 = 39,
        SCS_OEM_PLUS = 13,
        SCS_OEM_COMMA = 51,
        SCS_OEM_MINUS = 12,
        SCS_OEM_PERIOD = 52,
        SCS_OEM_2 = 53,
        SCS_OEM_3 = 41,
        SCS_OEM_4 = 26,
        SCS_OEM_5 = 43,
        SCS_OEM_6 = 27,
        SCS_OEM_7 = 40,
        SCS_OEM_8 = 0,
        SCS_OEM_102 = 86,
        SCS_PROCESSKEY = 0,
        SCS_PACKET = 0,
        SCS_ATTN = 0,
        SCS_CRSEL = 0,
        SCS_EXSEL = 0,
        SCS_EREOF = 93,
        SCS_PLAY = 0,
        SCS_ZOOM = 98,
        SCS_NONAME = 0,
        SCS_PA1 = 0,
        SCS_OEM_CLEAR = 0
    }
}
