using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public class Table8_Data : ITable_Data
    {
        private readonly BaseData m_Data;
        private readonly Table7_Data m_Table7_Data;

        private List<DataValues> m_Result_LaborIntensityPerVolumeOfProduction_Values;
        private List<DataValues> m_HourlyWageRate_Values;
        private List<DataValues> m_Salary_Values;
        private List<DataValues> m_DeductionsForSalary_Values;
        private List<DataValues> m_ResultLaborCosts_Values;

        public Table8_Data(BaseData data, Table7_Data table7_Data)
        {
            m_Data = data;
            m_Table7_Data = table7_Data;
        }

        public void ClearCachedData()
        {
            m_Result_LaborIntensityPerVolumeOfProduction_Values = null;
            m_HourlyWageRate_Values = null;
            m_Salary_Values = null;
            m_DeductionsForSalary_Values = null;
            m_ResultLaborCosts_Values = null;
        }

        public List<object[]> GetRows()
        {
            return new List<object[]>
            {
                new List<object>
                {
                    "Итого Трудоемкость на объем производства, чел-ч.",
                    Result_LaborIntensityPerVolumeOfProduction_Values[0].PlannedValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[0].ActualValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[0].DeviationValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[1].PlannedValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[1].ActualValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[1].DeviationValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[2].PlannedValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[2].ActualValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[2].DeviationValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[3].PlannedValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[3].ActualValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[3].DeviationValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[4].PlannedValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[4].ActualValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Часовая тарифная ставка, руб.",
                    HourlyWageRate_Values[0].PlannedValue,
                    HourlyWageRate_Values[0].ActualValue,
                    HourlyWageRate_Values[0].DeviationValue,
                    HourlyWageRate_Values[1].PlannedValue,
                    HourlyWageRate_Values[1].ActualValue,
                    HourlyWageRate_Values[1].DeviationValue,
                    HourlyWageRate_Values[2].PlannedValue,
                    HourlyWageRate_Values[2].ActualValue,
                    HourlyWageRate_Values[2].DeviationValue,
                    HourlyWageRate_Values[3].PlannedValue,
                    HourlyWageRate_Values[3].ActualValue,
                    HourlyWageRate_Values[3].DeviationValue,
                    HourlyWageRate_Values[4].PlannedValue,
                    HourlyWageRate_Values[4].ActualValue,
                    HourlyWageRate_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Заработная плата, руб.",
                    Salary_Values[0].PlannedValue,
                    Salary_Values[0].ActualValue,
                    Salary_Values[0].DeviationValue,
                    Salary_Values[1].PlannedValue,
                    Salary_Values[1].ActualValue,
                    Salary_Values[1].DeviationValue,
                    Salary_Values[2].PlannedValue,
                    Salary_Values[2].ActualValue,
                    Salary_Values[2].DeviationValue,
                    Salary_Values[3].PlannedValue,
                    Salary_Values[3].ActualValue,
                    Salary_Values[3].DeviationValue,
                    Salary_Values[4].PlannedValue,
                    Salary_Values[4].ActualValue,
                    Salary_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Отчисления на заработную плату, руб.",
                    DeductionsForSalary_Values[0].PlannedValue,
                    DeductionsForSalary_Values[0].ActualValue,
                    DeductionsForSalary_Values[0].DeviationValue,
                    DeductionsForSalary_Values[1].PlannedValue,
                    DeductionsForSalary_Values[1].ActualValue,
                    DeductionsForSalary_Values[1].DeviationValue,
                    DeductionsForSalary_Values[2].PlannedValue,
                    DeductionsForSalary_Values[2].ActualValue,
                    DeductionsForSalary_Values[2].DeviationValue,
                    DeductionsForSalary_Values[3].PlannedValue,
                    DeductionsForSalary_Values[3].ActualValue,
                    DeductionsForSalary_Values[3].DeviationValue,
                    DeductionsForSalary_Values[4].PlannedValue,
                    DeductionsForSalary_Values[4].ActualValue,
                    DeductionsForSalary_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "ИТОГО Расходы на оплату труда, руб.",
                    ResultLaborCosts_Values[0].PlannedValue,
                    ResultLaborCosts_Values[0].ActualValue,
                    ResultLaborCosts_Values[0].DeviationValue,
                    ResultLaborCosts_Values[1].PlannedValue,
                    ResultLaborCosts_Values[1].ActualValue,
                    ResultLaborCosts_Values[1].DeviationValue,
                    ResultLaborCosts_Values[2].PlannedValue,
                    ResultLaborCosts_Values[2].ActualValue,
                    ResultLaborCosts_Values[2].DeviationValue,
                    ResultLaborCosts_Values[3].PlannedValue,
                    ResultLaborCosts_Values[3].ActualValue,
                    ResultLaborCosts_Values[3].DeviationValue,
                    ResultLaborCosts_Values[4].PlannedValue,
                    ResultLaborCosts_Values[4].ActualValue,
                    ResultLaborCosts_Values[4].DeviationValue
                }.ToArray(),
            };
        }

        public List<DataValues> Result_LaborIntensityPerVolumeOfProduction_Values
        {
            get
            {
                if (m_Result_LaborIntensityPerVolumeOfProduction_Values != null)
                    return m_Result_LaborIntensityPerVolumeOfProduction_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Table7_Data.Result_LaborIntensityPerVolumeOfProduction_Values[0].PlannedValue, m_Table7_Data.Result_LaborIntensityPerVolumeOfProduction_Values[0].ActualValue),
                    new DataValues(m_Table7_Data.Result_LaborIntensityPerVolumeOfProduction_Values[1].PlannedValue, m_Table7_Data.Result_LaborIntensityPerVolumeOfProduction_Values[1].ActualValue),
                    new DataValues(m_Table7_Data.Result_LaborIntensityPerVolumeOfProduction_Values[2].PlannedValue, m_Table7_Data.Result_LaborIntensityPerVolumeOfProduction_Values[2].ActualValue),
                    new DataValues(m_Table7_Data.Result_LaborIntensityPerVolumeOfProduction_Values[3].PlannedValue, m_Table7_Data.Result_LaborIntensityPerVolumeOfProduction_Values[3].ActualValue),
                };
                var year = new DataValues(m_Table7_Data.Result_LaborIntensityPerVolumeOfProduction_Values[4].PlannedValue, m_Table7_Data.Result_LaborIntensityPerVolumeOfProduction_Values[4].ActualValue);
                m_Result_LaborIntensityPerVolumeOfProduction_Values = new List<DataValues>(quaters) { year };
                return m_Result_LaborIntensityPerVolumeOfProduction_Values;
            }
        }

        public List<DataValues> HourlyWageRate_Values
        {
            get
            {
                if (m_HourlyWageRate_Values != null)
                    return m_HourlyWageRate_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Data.HourlyWageRate, m_Data.HourlyWageRate),
                    new DataValues(m_Data.HourlyWageRate, m_Data.HourlyWageRate),
                    new DataValues(m_Data.HourlyWageRate, m_Data.HourlyWageRate),
                    new DataValues(m_Data.HourlyWageRate, m_Data.HourlyWageRate),
                };
                var year = new DataValues(m_Data.HourlyWageRate, m_Data.HourlyWageRate);
                m_HourlyWageRate_Values = new List<DataValues>(quaters) { year };
                return m_HourlyWageRate_Values;
            }
        }

        public List<DataValues> Salary_Values
        {
            get
            {
                if (m_Salary_Values != null)
                    return m_Salary_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        Result_LaborIntensityPerVolumeOfProduction_Values[0].PlannedValue * HourlyWageRate_Values[0].PlannedValue,
                        Result_LaborIntensityPerVolumeOfProduction_Values[0].ActualValue * HourlyWageRate_Values[0].ActualValue),
                    new DataValues(
                        Result_LaborIntensityPerVolumeOfProduction_Values[1].PlannedValue * HourlyWageRate_Values[1].PlannedValue,
                        Result_LaborIntensityPerVolumeOfProduction_Values[1].ActualValue * HourlyWageRate_Values[1].ActualValue),
                    new DataValues(
                        Result_LaborIntensityPerVolumeOfProduction_Values[2].PlannedValue * HourlyWageRate_Values[2].PlannedValue,
                        Result_LaborIntensityPerVolumeOfProduction_Values[2].ActualValue * HourlyWageRate_Values[2].ActualValue),
                    new DataValues(
                        Result_LaborIntensityPerVolumeOfProduction_Values[3].PlannedValue * HourlyWageRate_Values[3].PlannedValue,
                        Result_LaborIntensityPerVolumeOfProduction_Values[3].ActualValue * HourlyWageRate_Values[3].ActualValue),
                };
                var year = new DataValues(
                    Result_LaborIntensityPerVolumeOfProduction_Values[4].PlannedValue * HourlyWageRate_Values[4].PlannedValue,
                    Result_LaborIntensityPerVolumeOfProduction_Values[4].ActualValue * HourlyWageRate_Values[4].ActualValue);
                m_Salary_Values = new List<DataValues>(quaters) { year };
                return m_Salary_Values;
            }
        }

        public List<DataValues> DeductionsForSalary_Values
        {
            get
            {
                if (m_DeductionsForSalary_Values != null)
                    return m_DeductionsForSalary_Values;

                var percents = m_Data.SSFContributions / 100;
                var quaters = new List<DataValues> {
                    new DataValues(
                        Salary_Values[0].PlannedValue * percents,
                        Salary_Values[0].ActualValue * percents),
                    new DataValues(
                        Salary_Values[1].PlannedValue * percents,
                        Salary_Values[1].ActualValue * percents),
                    new DataValues(
                        Salary_Values[2].PlannedValue * percents,
                        Salary_Values[2].ActualValue * percents),
                    new DataValues(
                        Salary_Values[3].PlannedValue * percents,
                        Salary_Values[3].ActualValue * percents),
                };
                var year = new DataValues(
                    Salary_Values[4].PlannedValue * percents,
                    Salary_Values[4].ActualValue * percents);
                m_DeductionsForSalary_Values = new List<DataValues>(quaters) { year };
                return m_DeductionsForSalary_Values;
            }
        }

        public List<DataValues> ResultLaborCosts_Values
        {
            get
            {
                if (m_ResultLaborCosts_Values != null)
                    return m_ResultLaborCosts_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        Salary_Values[0].PlannedValue + DeductionsForSalary_Values[0].PlannedValue,
                        Salary_Values[0].ActualValue + DeductionsForSalary_Values[0].ActualValue),
                    new DataValues(
                        Salary_Values[1].PlannedValue + DeductionsForSalary_Values[1].PlannedValue,
                        Salary_Values[1].ActualValue + DeductionsForSalary_Values[1].ActualValue),
                    new DataValues(
                        Salary_Values[2].PlannedValue + DeductionsForSalary_Values[2].PlannedValue,
                        Salary_Values[2].ActualValue + DeductionsForSalary_Values[2].ActualValue),
                    new DataValues(
                        Salary_Values[3].PlannedValue + DeductionsForSalary_Values[3].PlannedValue,
                        Salary_Values[3].ActualValue + DeductionsForSalary_Values[3].ActualValue),
                };
                var year = new DataValues(
                    Salary_Values[4].PlannedValue + DeductionsForSalary_Values[4].PlannedValue,
                    Salary_Values[4].ActualValue + DeductionsForSalary_Values[4].ActualValue);
                m_ResultLaborCosts_Values = new List<DataValues>(quaters) { year };
                return m_ResultLaborCosts_Values;
            }
        }
    }
}
