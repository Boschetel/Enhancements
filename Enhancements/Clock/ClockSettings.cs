﻿using UnityEngine;
using SiraUtil.Converters;
using System.Collections.Generic;
using IPA.Config.Stores.Attributes;
using IPA.Config.Stores.Converters;

namespace Enhancements.Clock
{
    public class ClockSettings
    {
        public virtual bool Enabled { get; set; } = true;

        public virtual bool ShowInGame { get; set; } = true;

        public virtual string Format { get; set; } = "h:mm tt";

        public virtual string Culture { get; set; } = "";

        public virtual string Font { get; set; } = "";

        public virtual float Size { get; set; } = 10f;

        public virtual float Opacity { get; set; } = 1f;

        [UseConverter(typeof(HexColorConverter))]
        public virtual Color Color { get; set; } = Color.white;

        [UseConverter(typeof(Vector3Converter))]
        public virtual Vector3 Position { get; set; } = new Vector3(0f, 2.8f, 2.45f);

        [UseConverter(typeof(Vector3Converter))]
        public virtual Vector3 Rotation { get; set; } = new Vector3(325f, 0f, 0f);

        [NonNullable]
        [UseConverter(typeof(ListConverter<string>))]
        public virtual List<string> Formats { get; set; } = new List<string>()
        {
            "h:mm tt",
            "h:mm:ss tt",
            "HH:mm",
            "HH:mm:ss",
            "dddd",
            "MMMM dd, yyyy | h:mm tt",
        };

        [Ignore]
        internal bool IsDirty { get; set; } = true;

        public void MarkDirty()
        {
            IsDirty = true;
        }
    }
}
