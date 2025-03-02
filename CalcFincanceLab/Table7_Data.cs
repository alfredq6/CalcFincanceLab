using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public class Table7_Data : ITable_Data
    {
        private readonly BaseData m_Data;
        private readonly Table4_Data m_Table4_Data;

        private List<DataValues> m_ProductA_Production_Values;
        private List<DataValues> m_ProductB_Production_Values;
        private List<DataValues> m_ProductA_Worker1ConsumptionRate_Values;
        private List<DataValues> m_ProductB_Worker1ConsumptionRate_Values;
        private List<DataValues> m_ProductA_LaborIntensityPerVolumeOfProduction_Values;
        private List<DataValues> m_ProductB_LaborIntensityPerVolumeOfProduction_Values;
        private List<DataValues> m_Result_LaborIntensityPerVolumeOfProduction_Values;

        public Table7_Data(BaseData data, Table4_Data table4_Data)
        {
            m_Data = data;
            m_Table4_Data = table4_Data;
        }

        public void ClearCachedData()
        {
            m_ProductA_Production_Values = null;
            m_ProductB_Production_Values = null;
            m_ProductA_Worker1ConsumptionRate_Values = null;
            m_ProductB_Worker1ConsumptionRate_Values = null;
            m_ProductA_LaborIntensityPerVolumeOfProduction_Values = null;
            m_ProductB_LaborIntensityPerVolumeOfProduction_Values = null;
            m_Result_LaborIntensityPerVolumeOfProduction_Values = null;
        }

        public List<object[]> GetRows()
        {
            return new List<object[]>
            {
                new List<object>
                {
                    "Объем производства Продукта А, шт.",
                    ProductA_Production_Values[0].PlannedValue,
                    ProductA_Production_Values[0].ActualValue,
                    ProductA_Production_Values[0].DeviationValue,
                    ProductA_Production_Values[1].PlannedValue,
                    ProductA_Production_Values[1].ActualValue,
                    ProductA_Production_Values[1].DeviationValue,
                    ProductA_Production_Values[2].PlannedValue,
                    ProductA_Production_Values[2].ActualValue,
                    ProductA_Production_Values[2].DeviationValue,
                    ProductA_Production_Values[3].PlannedValue,
                    ProductA_Production_Values[3].ActualValue,
                    ProductA_Production_Values[3].DeviationValue,
                    ProductA_Production_Values[4].PlannedValue,
                    ProductA_Production_Values[4].ActualValue,
                    ProductA_Production_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Объем производства Продукта B, шт.",
                    ProductB_Production_Values[0].PlannedValue,
                    ProductB_Production_Values[0].ActualValue,
                    ProductB_Production_Values[0].DeviationValue,
                    ProductB_Production_Values[1].PlannedValue,
                    ProductB_Production_Values[1].ActualValue,
                    ProductB_Production_Values[1].DeviationValue,
                    ProductB_Production_Values[2].PlannedValue,
                    ProductB_Production_Values[2].ActualValue,
                    ProductB_Production_Values[2].DeviationValue,
                    ProductB_Production_Values[3].PlannedValue,
                    ProductB_Production_Values[3].ActualValue,
                    ProductB_Production_Values[3].DeviationValue,
                    ProductB_Production_Values[4].PlannedValue,
                    ProductB_Production_Values[4].ActualValue,
                    ProductB_Production_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "трудоемкость для Продукта А, чел-ч.",
                    ProductA_Worker1ConsumptionRate_Values[0].PlannedValue,
                    ProductA_Worker1ConsumptionRate_Values[0].ActualValue,
                    ProductA_Worker1ConsumptionRate_Values[0].DeviationValue,
                    ProductA_Worker1ConsumptionRate_Values[1].PlannedValue,
                    ProductA_Worker1ConsumptionRate_Values[1].ActualValue,
                    ProductA_Worker1ConsumptionRate_Values[1].DeviationValue,
                    ProductA_Worker1ConsumptionRate_Values[2].PlannedValue,
                    ProductA_Worker1ConsumptionRate_Values[2].ActualValue,
                    ProductA_Worker1ConsumptionRate_Values[2].DeviationValue,
                    ProductA_Worker1ConsumptionRate_Values[3].PlannedValue,
                    ProductA_Worker1ConsumptionRate_Values[3].ActualValue,
                    ProductA_Worker1ConsumptionRate_Values[3].DeviationValue,
                    ProductA_Worker1ConsumptionRate_Values[4].PlannedValue,
                    ProductA_Worker1ConsumptionRate_Values[4].ActualValue,
                    ProductA_Worker1ConsumptionRate_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "трудоемкость для Продукта B, чел-ч.",
                    ProductB_Worker1ConsumptionRate_Values[0].PlannedValue,
                    ProductB_Worker1ConsumptionRate_Values[0].ActualValue,
                    ProductB_Worker1ConsumptionRate_Values[0].DeviationValue,
                    ProductB_Worker1ConsumptionRate_Values[1].PlannedValue,
                    ProductB_Worker1ConsumptionRate_Values[1].ActualValue,
                    ProductB_Worker1ConsumptionRate_Values[1].DeviationValue,
                    ProductB_Worker1ConsumptionRate_Values[2].PlannedValue,
                    ProductB_Worker1ConsumptionRate_Values[2].ActualValue,
                    ProductB_Worker1ConsumptionRate_Values[2].DeviationValue,
                    ProductB_Worker1ConsumptionRate_Values[3].PlannedValue,
                    ProductB_Worker1ConsumptionRate_Values[3].ActualValue,
                    ProductB_Worker1ConsumptionRate_Values[3].DeviationValue,
                    ProductB_Worker1ConsumptionRate_Values[4].PlannedValue,
                    ProductB_Worker1ConsumptionRate_Values[4].ActualValue,
                    ProductB_Worker1ConsumptionRate_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Трудоемкость на объем производства Продукта А, чел-ч.",
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[0].PlannedValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[0].ActualValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[0].DeviationValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[1].PlannedValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[1].ActualValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[1].DeviationValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[2].PlannedValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[2].ActualValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[2].DeviationValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[3].PlannedValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[3].ActualValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[3].DeviationValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[4].PlannedValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[4].ActualValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Трудоемкость на объем производства Продукта B, чел-ч.",
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[0].PlannedValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[0].ActualValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[0].DeviationValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[1].PlannedValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[1].ActualValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[1].DeviationValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[2].PlannedValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[2].ActualValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[2].DeviationValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[3].PlannedValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[3].ActualValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[3].DeviationValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[4].PlannedValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[4].ActualValue,
                    ProductB_LaborIntensityPerVolumeOfProduction_Values[4].DeviationValue
                }.ToArray(),

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
            };
        }

        public List<DataValues> ProductA_Production_Values
        {
            get
            {
                if (m_ProductA_Production_Values != null)
                    return m_ProductA_Production_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Table4_Data.ProductA_Production_Values[0].PlannedValue, m_Table4_Data.ProductA_Production_Values[0].ActualValue),
                    new DataValues(m_Table4_Data.ProductA_Production_Values[1].PlannedValue, m_Table4_Data.ProductA_Production_Values[1].ActualValue),
                    new DataValues(m_Table4_Data.ProductA_Production_Values[2].PlannedValue, m_Table4_Data.ProductA_Production_Values[2].ActualValue),
                    new DataValues(m_Table4_Data.ProductA_Production_Values[3].PlannedValue, m_Table4_Data.ProductA_Production_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ProductA_Production_Values = new List<DataValues>(quaters) { year };
                return m_ProductA_Production_Values;
            }
        }

        public List<DataValues> ProductB_Production_Values
        {
            get
            {
                if (m_ProductB_Production_Values != null)
                    return m_ProductB_Production_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Table4_Data.ProductB_Production_Values[0].PlannedValue, m_Table4_Data.ProductB_Production_Values[0].ActualValue),
                    new DataValues(m_Table4_Data.ProductB_Production_Values[1].PlannedValue, m_Table4_Data.ProductB_Production_Values[1].ActualValue),
                    new DataValues(m_Table4_Data.ProductB_Production_Values[2].PlannedValue, m_Table4_Data.ProductB_Production_Values[2].ActualValue),
                    new DataValues(m_Table4_Data.ProductB_Production_Values[3].PlannedValue, m_Table4_Data.ProductB_Production_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ProductB_Production_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_Production_Values;
            }
        }

        public List<DataValues> ProductA_Worker1ConsumptionRate_Values
        {
            get
            {
                if (m_ProductA_Worker1ConsumptionRate_Values != null)
                    return m_ProductA_Worker1ConsumptionRate_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Data.ProductA_Worker1ConsumptionRate, m_Data.ProductA_Worker1ConsumptionRate),
                    new DataValues(m_Data.ProductA_Worker1ConsumptionRate, m_Data.ProductA_Worker1ConsumptionRate),
                    new DataValues(m_Data.ProductA_Worker1ConsumptionRate, m_Data.ProductA_Worker1ConsumptionRate),
                    new DataValues(m_Data.ProductA_Worker1ConsumptionRate, m_Data.ProductA_Worker1ConsumptionRate),
                };
                var year = new DataValues(m_Data.ProductA_Worker1ConsumptionRate, m_Data.ProductA_Worker1ConsumptionRate);
                m_ProductA_Worker1ConsumptionRate_Values = new List<DataValues>(quaters) { year };
                return m_ProductA_Worker1ConsumptionRate_Values;
            }
        }

        public List<DataValues> ProductB_Worker1ConsumptionRate_Values
        {
            get
            {
                if (m_ProductB_Worker1ConsumptionRate_Values != null)
                    return m_ProductB_Worker1ConsumptionRate_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Data.ProductB_Worker1ConsumptionRate, m_Data.ProductB_Worker1ConsumptionRate),
                    new DataValues(m_Data.ProductB_Worker1ConsumptionRate, m_Data.ProductB_Worker1ConsumptionRate),
                    new DataValues(m_Data.ProductB_Worker1ConsumptionRate, m_Data.ProductB_Worker1ConsumptionRate),
                    new DataValues(m_Data.ProductB_Worker1ConsumptionRate, m_Data.ProductB_Worker1ConsumptionRate),
                };
                var year = new DataValues(m_Data.ProductB_Worker1ConsumptionRate, m_Data.ProductB_Worker1ConsumptionRate);
                m_ProductB_Worker1ConsumptionRate_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_Worker1ConsumptionRate_Values;
            }
        }

        public List<DataValues> ProductA_LaborIntensityPerVolumeOfProduction_Values
        {
            get
            {
                if (m_ProductA_LaborIntensityPerVolumeOfProduction_Values != null)
                    return m_ProductA_LaborIntensityPerVolumeOfProduction_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        ProductA_Production_Values[0].PlannedValue * ProductA_Worker1ConsumptionRate_Values[0].PlannedValue,
                        ProductA_Production_Values[0].ActualValue * ProductA_Worker1ConsumptionRate_Values[0].ActualValue),
                    new DataValues(
                        ProductA_Production_Values[1].PlannedValue * ProductA_Worker1ConsumptionRate_Values[1].PlannedValue,
                        ProductA_Production_Values[1].ActualValue * ProductA_Worker1ConsumptionRate_Values[1].ActualValue),
                    new DataValues(
                        ProductA_Production_Values[2].PlannedValue * ProductA_Worker1ConsumptionRate_Values[2].PlannedValue,
                        ProductA_Production_Values[2].ActualValue * ProductA_Worker1ConsumptionRate_Values[2].ActualValue),
                    new DataValues(
                        ProductA_Production_Values[3].PlannedValue * ProductA_Worker1ConsumptionRate_Values[3].PlannedValue,
                        ProductA_Production_Values[3].ActualValue * ProductA_Worker1ConsumptionRate_Values[3].ActualValue),
                };
                var year = new DataValues(
                    ProductA_Production_Values[4].PlannedValue * ProductA_Worker1ConsumptionRate_Values[4].PlannedValue,
                    ProductA_Production_Values[4].ActualValue * ProductA_Worker1ConsumptionRate_Values[4].ActualValue);
                m_ProductA_LaborIntensityPerVolumeOfProduction_Values = new List<DataValues>(quaters) { year };
                return m_ProductA_LaborIntensityPerVolumeOfProduction_Values;
            }
        }

        public List<DataValues> ProductB_LaborIntensityPerVolumeOfProduction_Values
        {
            get
            {
                if (m_ProductB_LaborIntensityPerVolumeOfProduction_Values != null)
                    return m_ProductB_LaborIntensityPerVolumeOfProduction_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        ProductB_Production_Values[0].PlannedValue * ProductB_Worker1ConsumptionRate_Values[0].PlannedValue,
                        ProductB_Production_Values[0].ActualValue * ProductB_Worker1ConsumptionRate_Values[0].ActualValue),
                    new DataValues(
                        ProductB_Production_Values[1].PlannedValue * ProductB_Worker1ConsumptionRate_Values[1].PlannedValue,
                        ProductB_Production_Values[1].ActualValue * ProductB_Worker1ConsumptionRate_Values[1].ActualValue),
                    new DataValues(
                        ProductB_Production_Values[2].PlannedValue * ProductB_Worker1ConsumptionRate_Values[2].PlannedValue,
                        ProductB_Production_Values[2].ActualValue * ProductB_Worker1ConsumptionRate_Values[2].ActualValue),
                    new DataValues(
                        ProductB_Production_Values[3].PlannedValue * ProductB_Worker1ConsumptionRate_Values[3].PlannedValue,
                        ProductB_Production_Values[3].ActualValue * ProductB_Worker1ConsumptionRate_Values[3].ActualValue),
                };
                var year = new DataValues(
                    ProductB_Production_Values[4].PlannedValue * ProductB_Worker1ConsumptionRate_Values[4].PlannedValue,
                    ProductB_Production_Values[4].ActualValue * ProductB_Worker1ConsumptionRate_Values[4].ActualValue);
                m_ProductB_LaborIntensityPerVolumeOfProduction_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_LaborIntensityPerVolumeOfProduction_Values;
            }
        }

        public List<DataValues> Result_LaborIntensityPerVolumeOfProduction_Values
        {
            get
            {
                if (m_Result_LaborIntensityPerVolumeOfProduction_Values != null)
                    return m_Result_LaborIntensityPerVolumeOfProduction_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        ProductA_LaborIntensityPerVolumeOfProduction_Values[0].PlannedValue + ProductB_LaborIntensityPerVolumeOfProduction_Values[0].PlannedValue,
                        ProductA_LaborIntensityPerVolumeOfProduction_Values[0].ActualValue + ProductB_LaborIntensityPerVolumeOfProduction_Values[0].ActualValue),
                    new DataValues(
                        ProductA_LaborIntensityPerVolumeOfProduction_Values[1].PlannedValue + ProductB_LaborIntensityPerVolumeOfProduction_Values[1].PlannedValue,
                        ProductA_LaborIntensityPerVolumeOfProduction_Values[1].ActualValue + ProductB_LaborIntensityPerVolumeOfProduction_Values[1].ActualValue),
                    new DataValues(
                        ProductA_LaborIntensityPerVolumeOfProduction_Values[2].PlannedValue + ProductB_LaborIntensityPerVolumeOfProduction_Values[2].PlannedValue,
                        ProductA_LaborIntensityPerVolumeOfProduction_Values[2].ActualValue + ProductB_LaborIntensityPerVolumeOfProduction_Values[2].ActualValue),
                    new DataValues(
                        ProductA_LaborIntensityPerVolumeOfProduction_Values[3].PlannedValue + ProductB_LaborIntensityPerVolumeOfProduction_Values[3].PlannedValue,
                        ProductA_LaborIntensityPerVolumeOfProduction_Values[3].ActualValue + ProductB_LaborIntensityPerVolumeOfProduction_Values[3].ActualValue),
                };
                var year = new DataValues(
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[4].PlannedValue + ProductB_LaborIntensityPerVolumeOfProduction_Values[4].PlannedValue,
                    ProductA_LaborIntensityPerVolumeOfProduction_Values[4].ActualValue + ProductB_LaborIntensityPerVolumeOfProduction_Values[4].ActualValue);
                m_Result_LaborIntensityPerVolumeOfProduction_Values = new List<DataValues>(quaters) { year };
                return m_Result_LaborIntensityPerVolumeOfProduction_Values;
            }
        }
    }
}
