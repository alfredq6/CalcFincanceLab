using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public class Table3_Data : ITable_Data
    {
        private readonly BaseData m_Data;

        private List<DataValues> m_ProductA_SalesVolume_Values;
        private List<DataValues> m_ProductB_SalesVolume_Values;
        private List<DataValues> m_ProductA_BalanceAtTheEndOfTheYear_Values;
        private List<DataValues> m_ProductB_BalanceAtTheEndOfTheYear_Values;
        private List<DataValues> m_ProductA_BalanceAtTheBeginningOfTheYear_Values;
        private List<DataValues> m_ProductB_BalanceAtTheBeginningOfTheYear_Values;
        private List<DataValues> m_ProductA_Production_Values;
        private List<DataValues> m_ProductB_Production_Values;
        private List<DataValues> m_ProductA_PlannedCost_Values;
        private List<DataValues> m_ProductB_PlannedCost_Values;
        private List<DataValues> m_ProductA_ProductionPrice_Values;
        private List<DataValues> m_ProductB_ProductionPrice_Values;
        private List<DataValues> m_Result_Values;

        public Table3_Data(BaseData data)
        {
            m_Data = data;
        }

        public void ClearCachedData()
        {
            m_ProductA_SalesVolume_Values = null;
            m_ProductB_SalesVolume_Values = null;
            m_ProductA_BalanceAtTheEndOfTheYear_Values = null;
            m_ProductB_BalanceAtTheEndOfTheYear_Values = null;
            m_ProductA_BalanceAtTheBeginningOfTheYear_Values = null;
            m_ProductB_BalanceAtTheBeginningOfTheYear_Values = null;
            m_ProductA_Production_Values = null;
            m_ProductB_Production_Values = null;
            m_ProductA_PlannedCost_Values = null;
            m_ProductB_PlannedCost_Values = null;
            m_ProductA_ProductionPrice_Values = null;
            m_ProductB_ProductionPrice_Values = null;
            m_Result_Values = null;
        }

        public List<object[]> GetRows()
        {
            return new List<object[]>
            {
                new List<object>
                {
                    "Объем продаж А, шт. (№1)",
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
                    "Объем продаж В, шт. (№1)",
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
                    "Остаток на начало Продукта А, шт.",
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[0].PlannedValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[0].ActualValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[0].DeviationValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[1].PlannedValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[1].ActualValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[1].DeviationValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[2].PlannedValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[2].ActualValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[2].DeviationValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[3].PlannedValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[3].ActualValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[3].DeviationValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[4].PlannedValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[4].ActualValue,
                    ProductA_BalanceAtTheBeginningOfTheYear_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Остаток на начало Продукта B, шт.",
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[0].PlannedValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[0].ActualValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[0].DeviationValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[1].PlannedValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[1].ActualValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[1].DeviationValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[2].PlannedValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[2].ActualValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[2].DeviationValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[3].PlannedValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[3].ActualValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[3].DeviationValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[4].PlannedValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[4].ActualValue,
                    ProductB_BalanceAtTheBeginningOfTheYear_Values[4].DeviationValue
                }.ToArray(),

                 new List<object>
                {
                    "Остаток на конец Продукта А, шт.",
                    ProductA_BalanceAtTheEndOfTheYear_Values[0].PlannedValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[0].ActualValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[0].DeviationValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[1].PlannedValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[1].ActualValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[1].DeviationValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[2].PlannedValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[2].ActualValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[2].DeviationValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[3].PlannedValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[3].ActualValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[3].DeviationValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[4].PlannedValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[4].ActualValue,
                    ProductA_BalanceAtTheEndOfTheYear_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Остаток на конец Продукта В, шт.",
                    ProductB_BalanceAtTheEndOfTheYear_Values[0].PlannedValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[0].ActualValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[0].DeviationValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[1].PlannedValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[1].ActualValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[1].DeviationValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[2].PlannedValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[2].ActualValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[2].DeviationValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[3].PlannedValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[3].ActualValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[3].DeviationValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[4].PlannedValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[4].ActualValue,
                    ProductB_BalanceAtTheEndOfTheYear_Values[4].DeviationValue
                }.ToArray(),

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
                    "Объем производства Продукта В, шт.",
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
                    "Плановая себестоимость Продукта А, руб.",
                    ProductA_PlannedCost_Values[0].PlannedValue,
                    ProductA_PlannedCost_Values[0].ActualValue,
                    ProductA_PlannedCost_Values[0].DeviationValue,
                    ProductA_PlannedCost_Values[1].PlannedValue,
                    ProductA_PlannedCost_Values[1].ActualValue,
                    ProductA_PlannedCost_Values[1].DeviationValue,
                    ProductA_PlannedCost_Values[2].PlannedValue,
                    ProductA_PlannedCost_Values[2].ActualValue,
                    ProductA_PlannedCost_Values[2].DeviationValue,
                    ProductA_PlannedCost_Values[3].PlannedValue,
                    ProductA_PlannedCost_Values[3].ActualValue,
                    ProductA_PlannedCost_Values[3].DeviationValue,
                    ProductA_PlannedCost_Values[4].PlannedValue,
                    ProductA_PlannedCost_Values[4].ActualValue,
                    ProductA_PlannedCost_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Плановая себестоимость Продукта B, руб.",
                    ProductB_PlannedCost_Values[0].PlannedValue,
                    ProductB_PlannedCost_Values[0].ActualValue,
                    ProductB_PlannedCost_Values[0].DeviationValue,
                    ProductB_PlannedCost_Values[1].PlannedValue,
                    ProductB_PlannedCost_Values[1].ActualValue,
                    ProductB_PlannedCost_Values[1].DeviationValue,
                    ProductB_PlannedCost_Values[2].PlannedValue,
                    ProductB_PlannedCost_Values[2].ActualValue,
                    ProductB_PlannedCost_Values[2].DeviationValue,
                    ProductB_PlannedCost_Values[3].PlannedValue,
                    ProductB_PlannedCost_Values[3].ActualValue,
                    ProductB_PlannedCost_Values[3].DeviationValue,
                    ProductB_PlannedCost_Values[4].PlannedValue,
                    ProductB_PlannedCost_Values[4].ActualValue,
                    ProductB_PlannedCost_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Объем производства Продукта А, руб.",
                    ProductA_ProductionPrice_Values[0].PlannedValue,
                    ProductA_ProductionPrice_Values[0].ActualValue,
                    ProductA_ProductionPrice_Values[0].DeviationValue,
                    ProductA_ProductionPrice_Values[1].PlannedValue,
                    ProductA_ProductionPrice_Values[1].ActualValue,
                    ProductA_ProductionPrice_Values[1].DeviationValue,
                    ProductA_ProductionPrice_Values[2].PlannedValue,
                    ProductA_ProductionPrice_Values[2].ActualValue,
                    ProductA_ProductionPrice_Values[2].DeviationValue,
                    ProductA_ProductionPrice_Values[3].PlannedValue,
                    ProductA_ProductionPrice_Values[3].ActualValue,
                    ProductA_ProductionPrice_Values[3].DeviationValue,
                    ProductA_ProductionPrice_Values[4].PlannedValue,
                    ProductA_ProductionPrice_Values[4].ActualValue,
                    ProductA_ProductionPrice_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Объем производства Продукта В, руб.",
                    ProductB_ProductionPrice_Values[0].PlannedValue,
                    ProductB_ProductionPrice_Values[0].ActualValue,
                    ProductB_ProductionPrice_Values[0].DeviationValue,
                    ProductB_ProductionPrice_Values[1].PlannedValue,
                    ProductB_ProductionPrice_Values[1].ActualValue,
                    ProductB_ProductionPrice_Values[1].DeviationValue,
                    ProductB_ProductionPrice_Values[2].PlannedValue,
                    ProductB_ProductionPrice_Values[2].ActualValue,
                    ProductB_ProductionPrice_Values[2].DeviationValue,
                    ProductB_ProductionPrice_Values[3].PlannedValue,
                    ProductB_ProductionPrice_Values[3].ActualValue,
                    ProductB_ProductionPrice_Values[3].DeviationValue,
                    ProductB_ProductionPrice_Values[4].PlannedValue,
                    ProductB_ProductionPrice_Values[4].ActualValue,
                    ProductB_ProductionPrice_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "ИТОГО Объем производства, руб.",
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

        public List<DataValues> ProductA_BalanceAtTheEndOfTheYear_Values
        {
            get
            {
                if (m_ProductA_BalanceAtTheEndOfTheYear_Values != null)
                    return m_ProductA_BalanceAtTheEndOfTheYear_Values;

                var percents = m_Data.ProductA_InventoryPolicy / 100;
                var quaters = new List<DataValues> {
                    new DataValues(ProductA_SalesVolume_Values[0].PlannedValue * percents, ProductA_SalesVolume_Values[0].ActualValue * percents),
                    new DataValues(ProductA_SalesVolume_Values[1].PlannedValue * percents, ProductA_SalesVolume_Values[1].ActualValue * percents),
                    new DataValues(ProductA_SalesVolume_Values[2].PlannedValue * percents, ProductA_SalesVolume_Values[2].ActualValue * percents),
                    new DataValues(ProductA_SalesVolume_Values[3].PlannedValue * percents, ProductA_SalesVolume_Values[3].ActualValue * percents),
                };
                var year = new DataValues(quaters[3].PlannedValue, quaters[3].ActualValue);
                m_ProductA_BalanceAtTheEndOfTheYear_Values = new List<DataValues>(quaters) { year };
                return m_ProductA_BalanceAtTheEndOfTheYear_Values;
            }
        }

        public List<DataValues> ProductB_BalanceAtTheEndOfTheYear_Values
        {
            get
            {
                if (m_ProductB_BalanceAtTheEndOfTheYear_Values != null)
                    return m_ProductB_BalanceAtTheEndOfTheYear_Values;

                var percents = m_Data.ProductB_InventoryPolicy / 100;
                var quaters = new List<DataValues> {
                    new DataValues(ProductB_SalesVolume_Values[0].PlannedValue * percents, ProductB_SalesVolume_Values[0].ActualValue * percents),
                    new DataValues(ProductB_SalesVolume_Values[1].PlannedValue * percents, ProductB_SalesVolume_Values[1].ActualValue * percents),
                    new DataValues(ProductB_SalesVolume_Values[2].PlannedValue * percents, ProductB_SalesVolume_Values[2].ActualValue * percents),
                    new DataValues(ProductB_SalesVolume_Values[3].PlannedValue * percents, ProductB_SalesVolume_Values[3].ActualValue * percents),
                };
                var year = new DataValues(quaters[3].PlannedValue, quaters[3].ActualValue);
                m_ProductB_BalanceAtTheEndOfTheYear_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_BalanceAtTheEndOfTheYear_Values;
            }
        }

        public List<DataValues> ProductA_BalanceAtTheBeginningOfTheYear_Values
        {
            get
            {
                if (m_ProductA_BalanceAtTheBeginningOfTheYear_Values != null)
                    return m_ProductA_BalanceAtTheBeginningOfTheYear_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Data.ProductA_BalanceAtTheBeginningOfTheYear, m_Data.ProductA_BalanceAtTheBeginningOfTheYear),
                    new DataValues(ProductA_BalanceAtTheEndOfTheYear_Values[1].PlannedValue, ProductA_BalanceAtTheEndOfTheYear_Values[1].ActualValue),
                    new DataValues(ProductA_BalanceAtTheEndOfTheYear_Values[2].PlannedValue, ProductA_BalanceAtTheEndOfTheYear_Values[2].ActualValue),
                    new DataValues(ProductA_BalanceAtTheEndOfTheYear_Values[3].PlannedValue, ProductA_BalanceAtTheEndOfTheYear_Values[3].ActualValue),
                };
                var year = new DataValues(m_Data.ProductA_BalanceAtTheBeginningOfTheYear, m_Data.ProductA_BalanceAtTheBeginningOfTheYear);
                m_ProductA_BalanceAtTheBeginningOfTheYear_Values = new List<DataValues>(quaters) { year };
                return m_ProductA_BalanceAtTheBeginningOfTheYear_Values;
            }
        }

        public List<DataValues> ProductB_BalanceAtTheBeginningOfTheYear_Values
        {
            get
            {
                if (m_ProductB_BalanceAtTheBeginningOfTheYear_Values != null)
                    return m_ProductB_BalanceAtTheBeginningOfTheYear_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Data.ProductB_BalanceAtTheBeginningOfTheYear, m_Data.ProductB_BalanceAtTheBeginningOfTheYear),
                    new DataValues(ProductB_BalanceAtTheEndOfTheYear_Values[1].PlannedValue, ProductB_BalanceAtTheEndOfTheYear_Values[1].ActualValue),
                    new DataValues(ProductB_BalanceAtTheEndOfTheYear_Values[2].PlannedValue, ProductB_BalanceAtTheEndOfTheYear_Values[2].ActualValue),
                    new DataValues(ProductB_BalanceAtTheEndOfTheYear_Values[3].PlannedValue, ProductB_BalanceAtTheEndOfTheYear_Values[3].ActualValue),
                };
                var year = new DataValues(m_Data.ProductB_BalanceAtTheBeginningOfTheYear, m_Data.ProductB_BalanceAtTheBeginningOfTheYear);
                m_ProductB_BalanceAtTheBeginningOfTheYear_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_BalanceAtTheBeginningOfTheYear_Values;
            }
        }

        public List<DataValues> ProductA_Production_Values
        {
            get
            {
                if (m_ProductA_Production_Values != null)
                    return m_ProductA_Production_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        ProductA_SalesVolume_Values[0].PlannedValue - ProductA_BalanceAtTheBeginningOfTheYear_Values[0].PlannedValue + ProductA_BalanceAtTheEndOfTheYear_Values[0].PlannedValue,
                        ProductA_SalesVolume_Values[0].ActualValue - ProductA_BalanceAtTheBeginningOfTheYear_Values[0].ActualValue + ProductA_BalanceAtTheEndOfTheYear_Values[0].ActualValue),
                    new DataValues(
                        ProductA_SalesVolume_Values[1].PlannedValue - ProductA_BalanceAtTheBeginningOfTheYear_Values[1].PlannedValue + ProductA_BalanceAtTheEndOfTheYear_Values[1].PlannedValue,
                        ProductA_SalesVolume_Values[1].ActualValue - ProductA_BalanceAtTheBeginningOfTheYear_Values[1].ActualValue + ProductA_BalanceAtTheEndOfTheYear_Values[1].ActualValue),
                    new DataValues(
                        ProductA_SalesVolume_Values[2].PlannedValue - ProductA_BalanceAtTheBeginningOfTheYear_Values[2].PlannedValue + ProductA_BalanceAtTheEndOfTheYear_Values[2].PlannedValue,
                        ProductA_SalesVolume_Values[2].ActualValue - ProductA_BalanceAtTheBeginningOfTheYear_Values[2].ActualValue + ProductA_BalanceAtTheEndOfTheYear_Values[2].ActualValue),
                    new DataValues(
                        ProductA_SalesVolume_Values[3].PlannedValue - ProductA_BalanceAtTheBeginningOfTheYear_Values[3].PlannedValue + ProductA_BalanceAtTheEndOfTheYear_Values[3].PlannedValue,
                        ProductA_SalesVolume_Values[3].ActualValue - ProductA_BalanceAtTheBeginningOfTheYear_Values[3].ActualValue + ProductA_BalanceAtTheEndOfTheYear_Values[3].ActualValue),
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
                    new DataValues(
                        ProductB_SalesVolume_Values[0].PlannedValue - ProductB_BalanceAtTheBeginningOfTheYear_Values[0].PlannedValue + ProductB_BalanceAtTheEndOfTheYear_Values[0].PlannedValue,
                        ProductB_SalesVolume_Values[0].ActualValue - ProductB_BalanceAtTheBeginningOfTheYear_Values[0].ActualValue + ProductB_BalanceAtTheEndOfTheYear_Values[0].ActualValue),
                    new DataValues(
                        ProductB_SalesVolume_Values[1].PlannedValue - ProductB_BalanceAtTheBeginningOfTheYear_Values[1].PlannedValue + ProductB_BalanceAtTheEndOfTheYear_Values[1].PlannedValue,
                        ProductB_SalesVolume_Values[1].ActualValue - ProductB_BalanceAtTheBeginningOfTheYear_Values[1].ActualValue + ProductB_BalanceAtTheEndOfTheYear_Values[1].ActualValue),
                    new DataValues(
                        ProductB_SalesVolume_Values[2].PlannedValue - ProductB_BalanceAtTheBeginningOfTheYear_Values[2].PlannedValue + ProductB_BalanceAtTheEndOfTheYear_Values[2].PlannedValue,
                        ProductB_SalesVolume_Values[2].ActualValue - ProductB_BalanceAtTheBeginningOfTheYear_Values[2].ActualValue + ProductB_BalanceAtTheEndOfTheYear_Values[2].ActualValue),
                    new DataValues(
                        ProductB_SalesVolume_Values[3].PlannedValue - ProductB_BalanceAtTheBeginningOfTheYear_Values[3].PlannedValue + ProductB_BalanceAtTheEndOfTheYear_Values[3].PlannedValue,
                        ProductB_SalesVolume_Values[3].ActualValue - ProductB_BalanceAtTheBeginningOfTheYear_Values[3].ActualValue + ProductB_BalanceAtTheEndOfTheYear_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ProductB_Production_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_Production_Values;
            }
        }

        public List<DataValues> ProductA_PlannedCost_Values
        {
            get
            {
                if (m_ProductA_PlannedCost_Values != null)
                    return m_ProductA_PlannedCost_Values;

                var plannedValue = m_Data.ProductA_PlannedCost > 0
                    ? m_Data.ProductA_PlannedCost
                    : ((m_Data.ProductA_Material1ConsumptionRate * m_Data.PurchasePrice) + (m_Data.ProductA_Worker1ConsumptionRate * m_Data.HourlyWageRate));
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(plannedValue, actualValue);
                m_ProductA_PlannedCost_Values = new List<DataValues>(quaters) { year };
                return m_ProductA_PlannedCost_Values;
            }
        }

        public List<DataValues> ProductB_PlannedCost_Values
        {
            get
            {
                if (m_ProductB_PlannedCost_Values != null)
                    return m_ProductB_PlannedCost_Values;

                var plannedValue = m_Data.ProductB_PlannedCost > 0
                    ? m_Data.ProductB_PlannedCost
                    : ((m_Data.ProductB_Material1ConsumptionRate * m_Data.PurchasePrice) + (m_Data.ProductB_Worker1ConsumptionRate * m_Data.HourlyWageRate));
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(plannedValue, actualValue);
                m_ProductB_PlannedCost_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_PlannedCost_Values;
            }
        }

        public List<DataValues> ProductA_ProductionPrice_Values
        {
            get
            {
                if (m_ProductA_ProductionPrice_Values != null)
                    return m_ProductA_ProductionPrice_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        ProductA_Production_Values[0].PlannedValue * ProductA_PlannedCost_Values[0].PlannedValue,
                        ProductA_Production_Values[0].ActualValue * ProductA_PlannedCost_Values[0].ActualValue),
                    new DataValues(
                        ProductA_Production_Values[1].PlannedValue * ProductA_PlannedCost_Values[1].PlannedValue,
                        ProductA_Production_Values[1].ActualValue * ProductA_PlannedCost_Values[1].ActualValue),
                    new DataValues(
                        ProductA_Production_Values[2].PlannedValue * ProductA_PlannedCost_Values[2].PlannedValue,
                        ProductA_Production_Values[2].ActualValue * ProductA_PlannedCost_Values[2].ActualValue),
                    new DataValues(
                        ProductA_Production_Values[3].PlannedValue * ProductA_PlannedCost_Values[3].PlannedValue,
                        ProductA_Production_Values[3].ActualValue * ProductA_PlannedCost_Values[3].ActualValue),
                };
                var year = new DataValues(
                    ProductA_Production_Values[4].PlannedValue * ProductA_PlannedCost_Values[4].PlannedValue,
                    ProductA_Production_Values[4].ActualValue * ProductA_PlannedCost_Values[4].ActualValue);
                m_ProductA_ProductionPrice_Values = new List<DataValues>(quaters) { year };
                return m_ProductA_ProductionPrice_Values;
            }
        }

        public List<DataValues> ProductB_ProductionPrice_Values
        {
            get
            {
                if (m_ProductB_ProductionPrice_Values != null)
                    return m_ProductB_ProductionPrice_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        ProductB_Production_Values[0].PlannedValue * ProductB_PlannedCost_Values[0].PlannedValue,
                        ProductB_Production_Values[0].ActualValue * ProductB_PlannedCost_Values[0].ActualValue),
                    new DataValues(
                        ProductB_Production_Values[1].PlannedValue * ProductB_PlannedCost_Values[1].PlannedValue,
                        ProductB_Production_Values[1].ActualValue * ProductB_PlannedCost_Values[1].ActualValue),
                    new DataValues(
                        ProductB_Production_Values[2].PlannedValue * ProductB_PlannedCost_Values[2].PlannedValue,
                        ProductB_Production_Values[2].ActualValue * ProductB_PlannedCost_Values[2].ActualValue),
                    new DataValues(
                        ProductB_Production_Values[3].PlannedValue * ProductB_PlannedCost_Values[3].PlannedValue,
                        ProductB_Production_Values[3].ActualValue * ProductB_PlannedCost_Values[3].ActualValue),
                };
                var year = new DataValues(
                    ProductB_Production_Values[4].PlannedValue * ProductB_PlannedCost_Values[4].PlannedValue,
                    ProductB_Production_Values[4].ActualValue * ProductB_PlannedCost_Values[4].ActualValue);
                m_ProductB_ProductionPrice_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_ProductionPrice_Values;
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
                        ProductA_ProductionPrice_Values[0].PlannedValue + ProductB_ProductionPrice_Values[0].PlannedValue,
                        ProductA_ProductionPrice_Values[0].ActualValue + ProductB_ProductionPrice_Values[0].ActualValue),
                    new DataValues(
                        ProductA_ProductionPrice_Values[1].PlannedValue + ProductB_ProductionPrice_Values[1].PlannedValue,
                        ProductA_ProductionPrice_Values[1].ActualValue + ProductB_ProductionPrice_Values[1].ActualValue),
                    new DataValues(
                        ProductA_ProductionPrice_Values[2].PlannedValue + ProductB_ProductionPrice_Values[2].PlannedValue,
                        ProductA_ProductionPrice_Values[2].ActualValue + ProductB_ProductionPrice_Values[2].ActualValue),
                    new DataValues(
                        ProductA_ProductionPrice_Values[3].PlannedValue + ProductB_ProductionPrice_Values[3].PlannedValue,
                        ProductA_ProductionPrice_Values[3].ActualValue + ProductB_ProductionPrice_Values[3].ActualValue),
                };
                var year = new DataValues(
                    ProductA_ProductionPrice_Values[4].PlannedValue + ProductB_ProductionPrice_Values[4].PlannedValue,
                    ProductA_ProductionPrice_Values[4].ActualValue + ProductB_ProductionPrice_Values[4].ActualValue);
                m_Result_Values = new List<DataValues>(quaters) { year };
                return m_Result_Values;
            }
        }
    }
}
