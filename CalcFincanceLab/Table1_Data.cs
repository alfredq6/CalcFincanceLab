using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public class Table1_Data : ITable_Data
    {
        private readonly BaseData m_Data;

        private List<DataValues> m_ProductA_SalesVolume_Values;
        private List<DataValues> m_ProductB_SalesVolume_Values;
        private List<DataValues> m_ProductA_Price_Values;
        private List<DataValues> m_ProductB_Price_Values;
        private List<DataValues> m_ProductA_SalesVolumePrice_Values;
        private List<DataValues> m_ProductB_SalesVolumePrice_Values;
        private List<DataValues> m_Result_SalesVolumePrice_Values;

        public Table1_Data(BaseData data)
        {
            m_Data = data;
        }

        public void ClearCachedData()
        {
            m_ProductA_SalesVolume_Values = null;
            m_ProductA_SalesVolume_Values = null;
            m_ProductA_Price_Values = null;
            m_ProductB_Price_Values = null;
            m_ProductA_SalesVolumePrice_Values = null;
            m_ProductB_SalesVolumePrice_Values = null;
            m_Result_SalesVolumePrice_Values = null;
        }

        public List<object[]> GetRows()
        {
            return new List<object[]>
            {
                new List<object>
                {
                    "Объем продаж А, шт.",
                    ProductA_SalesVolume_Values[0].PlannedValue,
                    ProductA_SalesVolume_Values[0].ActualValue,
                    ProductA_SalesVolume_Values[0].DeviationValue,
                    ProductA_SalesVolume_Values[1].PlannedValue,
                    ProductA_SalesVolume_Values[1].ActualValue,
                    ProductA_SalesVolume_Values[1].DeviationValue,
                    ProductA_SalesVolume_Values[2].PlannedValue,
                    ProductA_SalesVolume_Values[2].ActualValue,
                    ProductA_SalesVolume_Values[2].DeviationValue,
                    ProductA_SalesVolume_Values[3].PlannedValue,
                    ProductA_SalesVolume_Values[3].ActualValue,
                    ProductA_SalesVolume_Values[3].DeviationValue,
                    ProductA_SalesVolume_Values[4].PlannedValue,
                    ProductA_SalesVolume_Values[4].ActualValue,
                    ProductA_SalesVolume_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Объем продаж B, шт.",
                    ProductB_SalesVolume_Values[0].PlannedValue,
                    ProductB_SalesVolume_Values[0].ActualValue,
                    ProductB_SalesVolume_Values[0].DeviationValue,
                    ProductB_SalesVolume_Values[1].PlannedValue,
                    ProductB_SalesVolume_Values[1].ActualValue,
                    ProductB_SalesVolume_Values[1].DeviationValue,
                    ProductB_SalesVolume_Values[2].PlannedValue,
                    ProductB_SalesVolume_Values[2].ActualValue,
                    ProductB_SalesVolume_Values[2].DeviationValue,
                    ProductB_SalesVolume_Values[3].PlannedValue,
                    ProductB_SalesVolume_Values[3].ActualValue,
                    ProductB_SalesVolume_Values[3].DeviationValue,
                    ProductB_SalesVolume_Values[4].PlannedValue,
                    ProductB_SalesVolume_Values[4].ActualValue,
                    ProductB_SalesVolume_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "цена А, шт.",
                    ProductA_Price_Values[0].PlannedValue,
                    ProductA_Price_Values[0].ActualValue,
                    ProductA_Price_Values[0].DeviationValue,
                    ProductA_Price_Values[1].PlannedValue,
                    ProductA_Price_Values[1].ActualValue,
                    ProductA_Price_Values[1].DeviationValue,
                    ProductA_Price_Values[2].PlannedValue,
                    ProductA_Price_Values[2].ActualValue,
                    ProductA_Price_Values[2].DeviationValue,
                    ProductA_Price_Values[3].PlannedValue,
                    ProductA_Price_Values[3].ActualValue,
                    ProductA_Price_Values[3].DeviationValue,
                    ProductA_Price_Values[4].PlannedValue,
                    ProductA_Price_Values[4].ActualValue,
                    ProductA_Price_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "цена B, шт.",
                    ProductB_Price_Values[0].PlannedValue,
                    ProductB_Price_Values[0].ActualValue,
                    ProductB_Price_Values[0].DeviationValue,
                    ProductB_Price_Values[1].PlannedValue,
                    ProductB_Price_Values[1].ActualValue,
                    ProductB_Price_Values[1].DeviationValue,
                    ProductB_Price_Values[2].PlannedValue,
                    ProductB_Price_Values[2].ActualValue,
                    ProductB_Price_Values[2].DeviationValue,
                    ProductB_Price_Values[3].PlannedValue,
                    ProductB_Price_Values[3].ActualValue,
                    ProductB_Price_Values[3].DeviationValue,
                    ProductB_Price_Values[4].PlannedValue,
                    ProductB_Price_Values[4].ActualValue,
                    ProductB_Price_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Объем продаж А, руб.",
                    ProductA_SalesVolumePrice_Values[0].PlannedValue,
                    ProductA_SalesVolumePrice_Values[0].ActualValue,
                    ProductA_SalesVolumePrice_Values[0].DeviationValue,
                    ProductA_SalesVolumePrice_Values[1].PlannedValue,
                    ProductA_SalesVolumePrice_Values[1].ActualValue,
                    ProductA_SalesVolumePrice_Values[1].DeviationValue,
                    ProductA_SalesVolumePrice_Values[2].PlannedValue,
                    ProductA_SalesVolumePrice_Values[2].ActualValue,
                    ProductA_SalesVolumePrice_Values[2].DeviationValue,
                    ProductA_SalesVolumePrice_Values[3].PlannedValue,
                    ProductA_SalesVolumePrice_Values[3].ActualValue,
                    ProductA_SalesVolumePrice_Values[3].DeviationValue,
                    ProductA_SalesVolumePrice_Values[4].PlannedValue,
                    ProductA_SalesVolumePrice_Values[4].ActualValue,
                    ProductA_SalesVolumePrice_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Объем продаж B, руб.",
                    ProductB_SalesVolumePrice_Values[0].PlannedValue,
                    ProductB_SalesVolumePrice_Values[0].ActualValue,
                    ProductB_SalesVolumePrice_Values[0].DeviationValue,
                    ProductB_SalesVolumePrice_Values[1].PlannedValue,
                    ProductB_SalesVolumePrice_Values[1].ActualValue,
                    ProductB_SalesVolumePrice_Values[1].DeviationValue,
                    ProductB_SalesVolumePrice_Values[2].PlannedValue,
                    ProductB_SalesVolumePrice_Values[2].ActualValue,
                    ProductB_SalesVolumePrice_Values[2].DeviationValue,
                    ProductB_SalesVolumePrice_Values[3].PlannedValue,
                    ProductB_SalesVolumePrice_Values[3].ActualValue,
                    ProductB_SalesVolumePrice_Values[3].DeviationValue,
                    ProductB_SalesVolumePrice_Values[4].PlannedValue,
                    ProductB_SalesVolumePrice_Values[4].ActualValue,
                    ProductB_SalesVolumePrice_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "ИТОГО объем продаж, руб.",
                    Result_SalesVolumePrice_Values[0].PlannedValue,
                    Result_SalesVolumePrice_Values[0].ActualValue,
                    Result_SalesVolumePrice_Values[0].DeviationValue,
                    Result_SalesVolumePrice_Values[1].PlannedValue,
                    Result_SalesVolumePrice_Values[1].ActualValue,
                    Result_SalesVolumePrice_Values[1].DeviationValue,
                    Result_SalesVolumePrice_Values[2].PlannedValue,
                    Result_SalesVolumePrice_Values[2].ActualValue,
                    Result_SalesVolumePrice_Values[2].DeviationValue,
                    Result_SalesVolumePrice_Values[3].PlannedValue,
                    Result_SalesVolumePrice_Values[3].ActualValue,
                    Result_SalesVolumePrice_Values[3].DeviationValue,
                    Result_SalesVolumePrice_Values[4].PlannedValue,
                    Result_SalesVolumePrice_Values[4].ActualValue,
                    Result_SalesVolumePrice_Values[4].DeviationValue
                }.ToArray(),
            };
        }

        public List<DataValues> ProductA_SalesVolume_Values
        {
            get
            {
                if (m_ProductA_SalesVolume_Values != null)
                    return m_ProductA_SalesVolume_Values;

                var plannedValue = m_Data.ProductA_SalesVolume / 4;
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ProductA_SalesVolume_Values = new List<DataValues>(quaters) { year };
                return m_ProductA_SalesVolume_Values;
            }
        }

        public List<DataValues> ProductB_SalesVolume_Values
        {
            get
            {
                if (m_ProductB_SalesVolume_Values != null)
                    return m_ProductB_SalesVolume_Values;

                var plannedValue = m_Data.ProductB_SalesVolume / 4;
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ProductB_SalesVolume_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_SalesVolume_Values;
            }
        }

        public List<DataValues> ProductA_Price_Values
        {
            get
            {
                if (m_ProductA_Price_Values != null)
                    return m_ProductA_Price_Values;

                var plannedValue = m_Data.ProductA_SellingPrice;
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ProductA_Price_Values = new List<DataValues>(quaters) { year };
                return m_ProductA_Price_Values;
            }
        }

        public List<DataValues> ProductB_Price_Values
        {
            get
            {
                if (m_ProductB_Price_Values != null)
                    return m_ProductB_Price_Values;

                var plannedValue = m_Data.ProductB_SellingPrice;
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ProductB_Price_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_Price_Values;
            }
        }

        public List<DataValues> ProductA_SalesVolumePrice_Values
        {
            get
            {
                if (m_ProductA_SalesVolumePrice_Values != null)
                    return m_ProductA_SalesVolumePrice_Values;

                var salesVolumeValues = ProductA_SalesVolume_Values;
                var priceValues = ProductA_Price_Values;
                var quaters = new List<DataValues> {
                    new DataValues(salesVolumeValues[0].PlannedValue * priceValues[0].PlannedValue, salesVolumeValues[0].ActualValue * priceValues[0].ActualValue),
                    new DataValues(salesVolumeValues[1].PlannedValue * priceValues[1].PlannedValue, salesVolumeValues[1].ActualValue * priceValues[1].ActualValue),
                    new DataValues(salesVolumeValues[2].PlannedValue * priceValues[2].PlannedValue, salesVolumeValues[2].ActualValue * priceValues[2].ActualValue),
                    new DataValues(salesVolumeValues[3].PlannedValue * priceValues[3].PlannedValue, salesVolumeValues[3].ActualValue * priceValues[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ProductA_SalesVolumePrice_Values = new List<DataValues>(quaters) { year };
                return m_ProductA_SalesVolumePrice_Values;
            }
        }

        public List<DataValues> ProductB_SalesVolumePrice_Values
        {
            get
            {
                if (m_ProductB_SalesVolumePrice_Values != null)
                    return m_ProductB_SalesVolumePrice_Values;

                var salesVolumeValues = ProductB_SalesVolume_Values;
                var priceValues = ProductB_Price_Values;
                var quaters = new List<DataValues> {
                    new DataValues(salesVolumeValues[0].PlannedValue * priceValues[0].PlannedValue, salesVolumeValues[0].ActualValue * priceValues[0].ActualValue),
                    new DataValues(salesVolumeValues[1].PlannedValue * priceValues[1].PlannedValue, salesVolumeValues[1].ActualValue * priceValues[1].ActualValue),
                    new DataValues(salesVolumeValues[2].PlannedValue * priceValues[2].PlannedValue, salesVolumeValues[2].ActualValue * priceValues[2].ActualValue),
                    new DataValues(salesVolumeValues[3].PlannedValue * priceValues[3].PlannedValue, salesVolumeValues[3].ActualValue * priceValues[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ProductB_SalesVolumePrice_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_SalesVolumePrice_Values;
            }
        }

        public List<DataValues> Result_SalesVolumePrice_Values
        {
            get
            {
                if (m_Result_SalesVolumePrice_Values != null)
                    return m_Result_SalesVolumePrice_Values;

                var productASales = ProductA_SalesVolumePrice_Values;
                var productBSales = ProductB_SalesVolumePrice_Values;
                var quaters = new List<DataValues> {
                    new DataValues(productASales[0].PlannedValue + productBSales[0].PlannedValue, productASales[0].ActualValue + productBSales[0].ActualValue),
                    new DataValues(productASales[1].PlannedValue + productBSales[1].PlannedValue, productASales[1].ActualValue + productBSales[1].ActualValue),
                    new DataValues(productASales[2].PlannedValue + productBSales[2].PlannedValue, productASales[2].ActualValue + productBSales[2].ActualValue),
                    new DataValues(productASales[3].PlannedValue + productBSales[3].PlannedValue, productASales[3].ActualValue + productBSales[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_Result_SalesVolumePrice_Values = new List<DataValues>(quaters) { year };
                return m_Result_SalesVolumePrice_Values;
            }
        }

    }
}
