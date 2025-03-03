﻿namespace CalcFincanceLab
{
    public class DataValues
    {
        public double PlannedValue { get; set; }
        public double ActualValue { get; set; }
        public double DeviationValue => ActualValue - PlannedValue;

        public DataValues(double plannedValue, double actualValue)
        {
            PlannedValue = plannedValue < 0 ? 0 : plannedValue;
            ActualValue = actualValue < 0 ? 0 : actualValue;
        }
    }
}
