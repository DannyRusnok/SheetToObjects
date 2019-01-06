﻿using SheetToObjects.Examples.Models;
using SheetToObjects.Lib.FluentConfiguration;

namespace SheetToObjects.Examples.SheetToObjectConfigs
{
    public class EpicTrackingConfig : SheetToObjectConfig
    {
        public EpicTrackingConfig()
        {
            CreateMap<EpicTracking>(x => x
                .MapColumn(column => column.WithColumnLetter("A").MapTo(m => m.SprintNumber))
                .MapColumn(column => column.WithColumnLetter("B").MapTo(m => m.SprintName))
                .MapColumn(column => column.WithColumnLetter("C").MapTo(m => m.StoryPointsCompleted))
                .MapColumn(column => column.WithColumnLetter("D").MapTo(m => m.TotalCompleted))
                .MapColumn(column => column.WithColumnLetter("E").MapTo(m => m.ForecastNormal))
                .MapColumn(column => column.WithColumnLetter("F").MapTo(m => m.ForecastHigh))
                .MapColumn(column => column.WithColumnLetter("G").MapTo(m => m.ForecastLow))
                .MapColumn(column => column.WithColumnLetter("H").MapTo(m => m.Scope)));
        }
    }
}
