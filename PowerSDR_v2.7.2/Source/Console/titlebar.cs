﻿//=================================================================
// titlebar.cs
//=================================================================
// PowerSDR is a C# implementation of a Software Defined Radio.
// Copyright (C) 2004-2012  FlexRadio Systems
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// You may contact us via email at: gpl@flexradio.com.
// Paper mail may be sent to: 
//    FlexRadio Systems
//    4616 W. Howard Lane  Suite 1-150
//    Austin, TX 78728
//    USA
//=================================================================

using System;
using System.Diagnostics;
using System.Reflection;

namespace PowerSDR
{
    class TitleBar
    {
        public const string BUILT_BY = "Built by WA1GON (StarGate)";

        public const string VERSION_SUFFIX = " Base + StarGate Mods"; // Make this "" for production


        public static string GetString()
        {
            string version = GetVerNum();
            string s = "FlexRadio Systems™  PowerSDR™";

            s += "  v" + version;
            if (VERSION_SUFFIX != "") s += " " + VERSION_SUFFIX;

            if (BUILT_BY != "") s += "   " + BUILT_BY;

            return s;
        }

        // returns the PowerSDR version number in "a.b.c" format
        public static string GetVerNum()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion.Substring(0, fvi.FileVersion.LastIndexOf("."));
        }
    }
}