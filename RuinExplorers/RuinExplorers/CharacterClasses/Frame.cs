﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuinExplorers.CharacterClasses
{
    /// <summary>
    /// A frame is part a character
    /// It contains an array of invidivual parts [16] and a name
    /// </summary>
    public class Frame
    {
        Part[] parts;
        public string Name;

        public Frame()
        {
            parts = new Part[16];
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = new Part();
            }
            Name = String.Empty; 
        }

        public Part[] Parts
        {
            get { return parts; }
        }
    }
}
