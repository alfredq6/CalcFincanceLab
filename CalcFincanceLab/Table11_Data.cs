using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public class Table11_Data : ITable_Data
    {
        private readonly BaseData m_Data;

        public Table11_Data(BaseData data)
        {
            m_Data = data;
        }

        public List<object[]> GetRows()
        {
            return new List<object[]>
            {
                new List<object>
                {
                    "Реклама",
                    Advertising_Values[0].PlannedValue,
                    Advertising_Values[0].ActualValue,
                    Advertising_Values[0].DeviationValue,
                    Advertising_Values[1].PlannedValue,
                    Advertising_Values[1].ActualValue,
                    Advertising_Values[1].DeviationValue,
                    Advertising_Values[2].PlannedValue,
                    Advertising_Values[2].ActualValue,
                    Advertising_Values[2].DeviationValue,
                    Advertising_Values[3].PlannedValue,
                    Advertising_Values[3].ActualValue,
                    Advertising_Values[3].DeviationValue,
                    Advertising_Values[4].PlannedValue,
                    Advertising_Values[4].ActualValue,
                    Advertising_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Расходы на упаковку",
                    PackagingCosts_Values[0].PlannedValue,
                    PackagingCosts_Values[0].ActualValue,
                    PackagingCosts_Values[0].DeviationValue,
                    PackagingCosts_Values[1].PlannedValue,
                    PackagingCosts_Values[1].ActualValue,
                    PackagingCosts_Values[1].DeviationValue,
                    PackagingCosts_Values[2].PlannedValue,
                    PackagingCosts_Values[2].ActualValue,
                    PackagingCosts_Values[2].DeviationValue,
                    PackagingCosts_Values[3].PlannedValue,
                    PackagingCosts_Values[3].ActualValue,
                    PackagingCosts_Values[3].DeviationValue,
                    PackagingCosts_Values[4].PlannedValue,
                    PackagingCosts_Values[4].ActualValue,
                    PackagingCosts_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Командировочные расходы",
                    TravelExpenses_Values[0].PlannedValue,
                    TravelExpenses_Values[0].ActualValue,
                    TravelExpenses_Values[0].DeviationValue,
                    TravelExpenses_Values[1].PlannedValue,
                    TravelExpenses_Values[1].ActualValue,
                    TravelExpenses_Values[1].DeviationValue,
                    TravelExpenses_Values[2].PlannedValue,
                    TravelExpenses_Values[2].ActualValue,
                    TravelExpenses_Values[2].DeviationValue,
                    TravelExpenses_Values[3].PlannedValue,
                    TravelExpenses_Values[3].ActualValue,
                    TravelExpenses_Values[3].DeviationValue,
                    TravelExpenses_Values[4].PlannedValue,
                    TravelExpenses_Values[4].ActualValue,
                    TravelExpenses_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "ИТОГО , руб.",
                    Result_Values[0].PlannedValue,
                    Result_Values[0].ActualValue,
                    Result_Values[0].DeviationValue,
                    Result_Values[1].PlannedValue,
                    Result_Values[1].ActualValue,
                    Result_Values[1].DeviationValue,
                    Result_Values[2].PlannedValue,
                    Result_Values[2].ActualValue,
                    Result_Values[2].DeviationValue,
                    Result_Values[3].PlannedValue,
                    Result_Values[3].ActualValue,
                    Result_Values[3].DeviationValue,
                    Result_Values[4].PlannedValue,
                    Result_Values[4].ActualValue,
                    Result_Values[4].DeviationValue
                }.ToArray(),
            };
        }


        public List<DataValues> Advertising_Values
        {
            get
            {
                var plannedValue = m_Data.Advertising / 4;
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                return new List<DataValues>(quaters) { year };
            }
        }

        public List<DataValues> PackagingCosts_Values
        {
            get
            {
                var plannedValue = m_Data.PackagingCosts / 4;
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                return new List<DataValues>(quaters) { year };
            }
        }

        public List<DataValues> TravelExpenses_Values
        {
            get
            {
                var plannedValue = m_Data.TravelExpenses / 4;
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                return new List<DataValues>(quaters) { year };
            }
        }

        public List<DataValues> Result_Values
        {
            get
            {
                var quaters = new List<DataValues> {
                    new DataValues(
                        Advertising_Values[0].PlannedValue + PackagingCosts_Values[0].PlannedValue + TravelExpenses_Values[0].PlannedValue,
                        Advertising_Values[0].ActualValue + PackagingCosts_Values[0].ActualValue + TravelExpenses_Values[0].ActualValue),
                    new DataValues(
                        Advertising_Values[1].PlannedValue + PackagingCosts_Values[1].PlannedValue + TravelExpenses_Values[1].PlannedValue,
                        Advertising_Values[1].ActualValue + PackagingCosts_Values[1].ActualValue + TravelExpenses_Values[1].ActualValue),
                    new DataValues(
                        Advertising_Values[2].PlannedValue + PackagingCosts_Values[2].PlannedValue + TravelExpenses_Values[2].PlannedValue,
                        Advertising_Values[2].ActualValue + PackagingCosts_Values[2].ActualValue + TravelExpenses_Values[2].ActualValue),
                    new DataValues(
                        Advertising_Values[3].PlannedValue + PackagingCosts_Values[3].PlannedValue + TravelExpenses_Values[3].PlannedValue,
                        Advertising_Values[3].ActualValue + PackagingCosts_Values[3].ActualValue + TravelExpenses_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                return new List<DataValues>(quaters) { year };
            }
        }
    }
}
