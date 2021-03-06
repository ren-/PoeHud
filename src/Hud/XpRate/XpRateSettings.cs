﻿using PoeHUD.Hud.Settings;
using SharpDX;

namespace PoeHUD.Hud.XpRate
{
    public sealed class XpRateSettings : SettingsBase
    {
        public XpRateSettings()
        {
            Enable = true;
            OnlyAreaName = false;
            ShowLatency = true;
            FontSize = new RangeNode<int>(16, 10, 20);
            BackgroundColor = new ColorBGRA(255, 255, 255, 255);
            AreaFontColor = new ColorBGRA(140, 200, 255, 255);
            XphFontColor = new ColorBGRA(220, 190, 130, 255);
            TimeLeftColor = new ColorBGRA(220, 190, 130, 255);
            FpsFontColor = new ColorBGRA(220, 190, 130, 255);
            TimerFontColor = new ColorBGRA(220, 190, 130, 255);
            LatencyFontColor = new ColorBGRA(220, 190, 130, 255);
            ShowXpReceiving = true;
            LevelPenalty = true;
            PartyPenalty = true;
        }
        public ToggleNode ShowLatency { get; set; }
        public ToggleNode OnlyAreaName { get; set; }
        public RangeNode<int> FontSize { get; set; }
        public ColorNode BackgroundColor { get; set; }
        public ColorNode AreaFontColor { get; set; }
        public ColorNode XphFontColor { get; set; }
        public ColorNode TimeLeftColor { get; set; }
        public ColorNode FpsFontColor { get; set; }
        public ColorNode TimerFontColor { get; set; }
        public ColorNode LatencyFontColor { get; set; }
        public ToggleNode ShowXpReceiving { get; set; }
        public ToggleNode LevelPenalty { get; set; }
        public ToggleNode PartyPenalty { get; set; }
    }
}