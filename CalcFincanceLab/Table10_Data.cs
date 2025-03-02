using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public class Table10_Data : ITable_Data
    {
        private readonly BaseData m_Data;
        private readonly Table8_Data m_Table8_Data;

        private List<DataValues> m_ElectricityForGeneralEconomicPurposes_Values;
        private List<DataValues> m_TelephoneInternet_Values;
        private List<DataValues> m_Salary_Values;
        private List<DataValues> m_DeductionsForSalary_Values;
        private List<DataValues> m_Result_Values;

        public Table10_Data(BaseData data, Table8_Data table8_Data)
        {
            m_Data = data;
            m_Table8_Data = table8_Data;
        }

        public void ClearCachedData()
        {
            m_ElectricityForGeneralEconomicPurposes_Values = null;
            m_TelephoneInternet_Values = null;
            m_Salary_Values = null;
            m_DeductionsForSalary_Values = null;
            m_Result_Values = null;
        }

        public List<object[]> GetRows()
        {
            return new List<object[]>
            {
                new List<object>
                {
                    "Электроэнергия на общехозяйственные цели",
                    ElectricityForGeneralEconomicPurposes_Values[0].PlannedValue,
                    ElectricityForGeneralEconomicPurposes_Values[0].ActualValue,
                    ElectricityForGeneralEconomicPurposes_Values[0].DeviationValue,
                    ElectricityForGeneralEconomicPurposes_Values[1].PlannedValue,
                    ElectricityForGeneralEconomicPurposes_Values[1].ActualValue,
                    ElectricityForGeneralEconomicPurposes_Values[1].DeviationValue,
                    ElectricityForGeneralEconomicPurposes_Values[2].PlannedValue,
                    ElectricityForGeneralEconomicPurposes_Values[2].ActualValue,
                    ElectricityForGeneralEconomicPurposes_Values[2].DeviationValue,
                    ElectricityForGeneralEconomicPurposes_Values[3].PlannedValue,
                    ElectricityForGeneralEconomicPurposes_Values[3].ActualValue,
                    ElectricityForGeneralEconomicPurposes_Values[3].DeviationValue,
                    ElectricityForGeneralEconomicPurposes_Values[4].PlannedValue,
                    ElectricityForGeneralEconomicPurposes_Values[4].ActualValue,
                    ElectricityForGeneralEconomicPurposes_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Телефон, Интернет",
                    TelephoneInternet_Values[0].PlannedValue,
                    TelephoneInternet_Values[0].ActualValue,
                    TelephoneInternet_Values[0].DeviationValue,
                    TelephoneInternet_Values[1].PlannedValue,
                    TelephoneInternet_Values[1].ActualValue,
                    TelephoneInternet_Values[1].DeviationValue,
                    TelephoneInternet_Values[2].PlannedValue,
                    TelephoneInternet_Values[2].ActualValue,
                    TelephoneInternet_Values[2].DeviationValue,
                    TelephoneInternet_Values[3].PlannedValue,
                    TelephoneInternet_Values[3].ActualValue,
                    TelephoneInternet_Values[3].DeviationValue,
                    TelephoneInternet_Values[4].PlannedValue,
                    TelephoneInternet_Values[4].ActualValue,
                    TelephoneInternet_Values[4].DeviationValue
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
                    "ИТОГО, руб.",
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

        public List<DataValues> ElectricityForGeneralEconomicPurposes_Values
        {
            get
            {
                if (m_ElectricityForGeneralEconomicPurposes_Values != null)
                    return m_ElectricityForGeneralEconomicPurposes_Values;

                var plannedValue = m_Data.ElectricityForGeneralEconomicPurposes / 4;
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ElectricityForGeneralEconomicPurposes_Values = new List<DataValues>(quaters) { year };
                return m_ElectricityForGeneralEconomicPurposes_Values;
            }
        }

        public List<DataValues> TelephoneInternet_Values
        {
            get
            {
                if (m_TelephoneInternet_Values != null)
                    return m_TelephoneInternet_Values;

                var plannedValue = m_Data.TelephoneInternet / 4;
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_TelephoneInternet_Values = new List<DataValues>(quaters) { year };
                return m_TelephoneInternet_Values;
            }
        }

        public List<DataValues> Salary_Values
        {
            get
            {
                if (m_Salary_Values != null)
                    return m_Salary_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Table8_Data.Salary_Values[0].PlannedValue, m_Table8_Data.Salary_Values[0].ActualValue),
                    new DataValues(m_Table8_Data.Salary_Values[1].PlannedValue, m_Table8_Data.Salary_Values[1].ActualValue),
                    new DataValues(m_Table8_Data.Salary_Values[2].PlannedValue, m_Table8_Data.Salary_Values[2].ActualValue),
                    new DataValues(m_Table8_Data.Salary_Values[3].PlannedValue, m_Table8_Data.Salary_Values[3].ActualValue),
                };
                var year = new DataValues(m_Table8_Data.Salary_Values[4].PlannedValue, m_Table8_Data.Salary_Values[4].ActualValue);
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

                var quaters = new List<DataValues> {
                    new DataValues(m_Table8_Data.DeductionsForSalary_Values[0].PlannedValue, m_Table8_Data.DeductionsForSalary_Values[0].ActualValue),
                    new DataValues(m_Table8_Data.DeductionsForSalary_Values[1].PlannedValue, m_Table8_Data.DeductionsForSalary_Values[1].ActualValue),
                    new DataValues(m_Table8_Data.DeductionsForSalary_Values[2].PlannedValue, m_Table8_Data.DeductionsForSalary_Values[2].ActualValue),
                    new DataValues(m_Table8_Data.DeductionsForSalary_Values[3].PlannedValue, m_Table8_Data.DeductionsForSalary_Values[3].ActualValue),
                };
                var year = new DataValues(m_Table8_Data.DeductionsForSalary_Values[4].PlannedValue, m_Table8_Data.DeductionsForSalary_Values[4].ActualValue);
                m_DeductionsForSalary_Values = new List<DataValues>(quaters) { year };
                return m_DeductionsForSalary_Values;
            }
        }

        public List<DataValues> Result_Values
        {
            get
            {
                if (m_Result_Values != null)
                    return m_Result_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        ElectricityForGeneralEconomicPurposes_Values[0].PlannedValue + TelephoneInternet_Values[0].PlannedValue + Salary_Values[0].PlannedValue + DeductionsForSalary_Values[0].PlannedValue,
                        ElectricityForGeneralEconomicPurposes_Values[0].ActualValue + TelephoneInternet_Values[0].ActualValue + Salary_Values[0].ActualValue + DeductionsForSalary_Values[0].ActualValue),
                    new DataValues(
                        ElectricityForGeneralEconomicPurposes_Values[1].PlannedValue + TelephoneInternet_Values[1].PlannedValue + Salary_Values[1].PlannedValue + DeductionsForSalary_Values[1].PlannedValue,
                        ElectricityForGeneralEconomicPurposes_Values[1].ActualValue + TelephoneInternet_Values[1].ActualValue + Salary_Values[1].ActualValue + DeductionsForSalary_Values[1].ActualValue),
                    new DataValues(
                        ElectricityForGeneralEconomicPurposes_Values[2].PlannedValue + TelephoneInternet_Values[2].PlannedValue + Salary_Values[2].PlannedValue + DeductionsForSalary_Values[2].PlannedValue,
                        ElectricityForGeneralEconomicPurposes_Values[2].ActualValue + TelephoneInternet_Values[2].ActualValue + Salary_Values[2].ActualValue + DeductionsForSalary_Values[2].ActualValue),
                    new DataValues(
                        ElectricityForGeneralEconomicPurposes_Values[3].PlannedValue + TelephoneInternet_Values[3].PlannedValue + Salary_Values[3].PlannedValue + DeductionsForSalary_Values[3].PlannedValue,
                        ElectricityForGeneralEconomicPurposes_Values[3].ActualValue + TelephoneInternet_Values[3].ActualValue + Salary_Values[3].ActualValue + DeductionsForSalary_Values[3].ActualValue),
                };
                var year = new DataValues(
                    ElectricityForGeneralEconomicPurposes_Values[4].PlannedValue + TelephoneInternet_Values[4].PlannedValue + Salary_Values[4].PlannedValue + DeductionsForSalary_Values[4].PlannedValue,
                    ElectricityForGeneralEconomicPurposes_Values[4].ActualValue + TelephoneInternet_Values[4].ActualValue + Salary_Values[4].ActualValue + DeductionsForSalary_Values[4].ActualValue);
                m_Result_Values = new List<DataValues>(quaters) { year };
                return m_Result_Values;
            }
        }
    }
}
