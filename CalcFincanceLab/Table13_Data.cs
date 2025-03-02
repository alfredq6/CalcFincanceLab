using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public class Table13_Data : ITable_Data
    {
        private readonly BaseData m_Data;
        private readonly Table1_Data m_Table1_Data;
        private readonly Table7_Data m_Table7_Data;
        private readonly Table10_Data m_Table10_Data;
        private readonly Table11_Data m_Table11_Data;
        private readonly Table12_Data m_Table12_Data;

        private List<DataValues> m_Revenue_Values;
        private List<DataValues> m_SalesCost_Values;
        private List<DataValues> m_ManagementExpenses_Values;
        private List<DataValues> m_CommercialExpenses_Values;
        private List<DataValues> m_Profit_Values;

        public Table13_Data(BaseData data, Table1_Data table1_Data, Table7_Data table7_Data, Table10_Data table10_Data, Table11_Data table11_Data, Table12_Data table12_Data)
        {
            m_Data = data;
            m_Table1_Data = table1_Data;
            m_Table7_Data = table7_Data;
            m_Table10_Data = table10_Data;
            m_Table11_Data = table11_Data;
            m_Table12_Data = table12_Data;
        }

        public void ClearCachedData()
        {
            m_Revenue_Values = null;
            m_SalesCost_Values = null;
            m_ManagementExpenses_Values = null;
            m_CommercialExpenses_Values = null;
            m_Profit_Values = null;
        }

        public List<object[]> GetRows()
        {
            return new List<object[]>
            {
                new List<object>
                {
                    "Выручка, руб.",
                    Revenue_Values[0].PlannedValue,
                    Revenue_Values[0].ActualValue,
                    Revenue_Values[0].DeviationValue,
                    Revenue_Values[1].PlannedValue,
                    Revenue_Values[1].ActualValue,
                    Revenue_Values[1].DeviationValue,
                    Revenue_Values[2].PlannedValue,
                    Revenue_Values[2].ActualValue,
                    Revenue_Values[2].DeviationValue,
                    Revenue_Values[3].PlannedValue,
                    Revenue_Values[3].ActualValue,
                    Revenue_Values[3].DeviationValue,
                    Revenue_Values[4].PlannedValue,
                    Revenue_Values[4].ActualValue,
                    Revenue_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Себестоимость продаж, руб.",
                    SalesCost_Values[0].PlannedValue,
                    SalesCost_Values[0].ActualValue,
                    SalesCost_Values[0].DeviationValue,
                    SalesCost_Values[1].PlannedValue,
                    SalesCost_Values[1].ActualValue,
                    SalesCost_Values[1].DeviationValue,
                    SalesCost_Values[2].PlannedValue,
                    SalesCost_Values[2].ActualValue,
                    SalesCost_Values[2].DeviationValue,
                    SalesCost_Values[3].PlannedValue,
                    SalesCost_Values[3].ActualValue,
                    SalesCost_Values[3].DeviationValue,
                    SalesCost_Values[4].PlannedValue,
                    SalesCost_Values[4].ActualValue,
                    SalesCost_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Управленческие расходы, руб.",
                    ManagementExpenses_Values[0].PlannedValue,
                    ManagementExpenses_Values[0].ActualValue,
                    ManagementExpenses_Values[0].DeviationValue,
                    ManagementExpenses_Values[1].PlannedValue,
                    ManagementExpenses_Values[1].ActualValue,
                    ManagementExpenses_Values[1].DeviationValue,
                    ManagementExpenses_Values[2].PlannedValue,
                    ManagementExpenses_Values[2].ActualValue,
                    ManagementExpenses_Values[2].DeviationValue,
                    ManagementExpenses_Values[3].PlannedValue,
                    ManagementExpenses_Values[3].ActualValue,
                    ManagementExpenses_Values[3].DeviationValue,
                    ManagementExpenses_Values[4].PlannedValue,
                    ManagementExpenses_Values[4].ActualValue,
                    ManagementExpenses_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Коммерческие расходы, руб.",
                    CommercialExpenses_Values[0].PlannedValue,
                    CommercialExpenses_Values[0].ActualValue,
                    CommercialExpenses_Values[0].DeviationValue,
                    CommercialExpenses_Values[1].PlannedValue,
                    CommercialExpenses_Values[1].ActualValue,
                    CommercialExpenses_Values[1].DeviationValue,
                    CommercialExpenses_Values[2].PlannedValue,
                    CommercialExpenses_Values[2].ActualValue,
                    CommercialExpenses_Values[2].DeviationValue,
                    CommercialExpenses_Values[3].PlannedValue,
                    CommercialExpenses_Values[3].ActualValue,
                    CommercialExpenses_Values[3].DeviationValue,
                    CommercialExpenses_Values[4].PlannedValue,
                    CommercialExpenses_Values[4].ActualValue,
                    CommercialExpenses_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Прибыль, руб.",
                    Profit_Values[0].PlannedValue,
                    Profit_Values[0].ActualValue,
                    Profit_Values[0].DeviationValue,
                    Profit_Values[1].PlannedValue,
                    Profit_Values[1].ActualValue,
                    Profit_Values[1].DeviationValue,
                    Profit_Values[2].PlannedValue,
                    Profit_Values[2].ActualValue,
                    Profit_Values[2].DeviationValue,
                    Profit_Values[3].PlannedValue,
                    Profit_Values[3].ActualValue,
                    Profit_Values[3].DeviationValue,
                    Profit_Values[4].PlannedValue,
                    Profit_Values[4].ActualValue,
                    Profit_Values[4].DeviationValue
                }.ToArray(),
            };
        }

        public List<DataValues> Revenue_Values
        {
            get
            {
                if (m_Revenue_Values != null)
                    return m_Revenue_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Table1_Data.Result_SalesVolumePrice_Values[0].PlannedValue, m_Table1_Data.Result_SalesVolumePrice_Values[0].ActualValue),
                    new DataValues(m_Table1_Data.Result_SalesVolumePrice_Values[1].PlannedValue, m_Table1_Data.Result_SalesVolumePrice_Values[1].ActualValue),
                    new DataValues(m_Table1_Data.Result_SalesVolumePrice_Values[2].PlannedValue, m_Table1_Data.Result_SalesVolumePrice_Values[2].ActualValue),
                    new DataValues(m_Table1_Data.Result_SalesVolumePrice_Values[3].PlannedValue, m_Table1_Data.Result_SalesVolumePrice_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_Revenue_Values = new List<DataValues>(quaters) { year };
                return m_Revenue_Values;
            }
        }

        public List<DataValues> SalesCost_Values
        {
            get
            {
                if (m_SalesCost_Values != null)
                    return m_SalesCost_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        (m_Table7_Data.ProductA_Production_Values[0].PlannedValue / (m_Table7_Data.ProductA_Production_Values[4].PlannedValue + m_Table7_Data.ProductB_Production_Values[4].PlannedValue) * m_Table12_Data.ProductsProductionCosts_Values[0])
                        + (m_Table7_Data.ProductB_Production_Values[0].PlannedValue / (m_Table7_Data.ProductA_Production_Values[4].PlannedValue + m_Table7_Data.ProductB_Production_Values[4].PlannedValue) * m_Table12_Data.ProductsProductionCosts_Values[1]),
                        (m_Table7_Data.ProductA_Production_Values[0].ActualValue / m_Table12_Data.ProductsProductions_Values[2] * m_Table12_Data.ProductsProductionCosts_Values[0])
                        + (m_Table7_Data.ProductB_Production_Values[0].ActualValue / m_Table12_Data.ProductsProductions_Values[2] * m_Table12_Data.ProductsProductionCosts_Values[1])),
                    new DataValues(
                        (m_Table7_Data.ProductA_Production_Values[1].PlannedValue / (m_Table7_Data.ProductA_Production_Values[4].PlannedValue + m_Table7_Data.ProductB_Production_Values[4].PlannedValue) * m_Table12_Data.ProductsProductionCosts_Values[0])
                        + (m_Table7_Data.ProductB_Production_Values[1].PlannedValue / (m_Table7_Data.ProductA_Production_Values[4].PlannedValue + m_Table7_Data.ProductB_Production_Values[4].PlannedValue) * m_Table12_Data.ProductsProductionCosts_Values[1]),
                        (m_Table7_Data.ProductA_Production_Values[1].ActualValue / m_Table12_Data.ProductsProductions_Values[2] * m_Table12_Data.ProductsProductionCosts_Values[0])
                        + (m_Table7_Data.ProductB_Production_Values[1].ActualValue / m_Table12_Data.ProductsProductions_Values[2] * m_Table12_Data.ProductsProductionCosts_Values[1])),
                    new DataValues(
                        (m_Table7_Data.ProductA_Production_Values[2].PlannedValue / (m_Table7_Data.ProductA_Production_Values[4].PlannedValue + m_Table7_Data.ProductB_Production_Values[4].PlannedValue) * m_Table12_Data.ProductsProductionCosts_Values[0])
                        + (m_Table7_Data.ProductB_Production_Values[2].PlannedValue / (m_Table7_Data.ProductA_Production_Values[4].PlannedValue + m_Table7_Data.ProductB_Production_Values[4].PlannedValue) * m_Table12_Data.ProductsProductionCosts_Values[1]),
                        (m_Table7_Data.ProductA_Production_Values[2].ActualValue / m_Table12_Data.ProductsProductions_Values[2] * m_Table12_Data.ProductsProductionCosts_Values[0])
                        + (m_Table7_Data.ProductB_Production_Values[2].ActualValue / m_Table12_Data.ProductsProductions_Values[2] * m_Table12_Data.ProductsProductionCosts_Values[1])),
                    new DataValues(
                        (m_Table7_Data.ProductA_Production_Values[3].PlannedValue / (m_Table7_Data.ProductA_Production_Values[4].PlannedValue + m_Table7_Data.ProductB_Production_Values[4].PlannedValue) * m_Table12_Data.ProductsProductionCosts_Values[0])
                        + (m_Table7_Data.ProductB_Production_Values[3].PlannedValue / (m_Table7_Data.ProductA_Production_Values[4].PlannedValue + m_Table7_Data.ProductB_Production_Values[4].PlannedValue) * m_Table12_Data.ProductsProductionCosts_Values[1]),
                        (m_Table7_Data.ProductA_Production_Values[3].ActualValue / m_Table12_Data.ProductsProductions_Values[2] * m_Table12_Data.ProductsProductionCosts_Values[0])
                        + (m_Table7_Data.ProductB_Production_Values[3].ActualValue / m_Table12_Data.ProductsProductions_Values[2] * m_Table12_Data.ProductsProductionCosts_Values[1])),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_SalesCost_Values = new List<DataValues>(quaters) { year };
                return m_SalesCost_Values;
            }
        }

        public List<DataValues> ManagementExpenses_Values
        {
            get
            {
                if (m_ManagementExpenses_Values != null)
                    return m_ManagementExpenses_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Table10_Data.Result_Values[0].PlannedValue, m_Table10_Data.Result_Values[0].ActualValue),
                    new DataValues(m_Table10_Data.Result_Values[1].PlannedValue, m_Table10_Data.Result_Values[1].ActualValue),
                    new DataValues(m_Table10_Data.Result_Values[2].PlannedValue, m_Table10_Data.Result_Values[2].ActualValue),
                    new DataValues(m_Table10_Data.Result_Values[3].PlannedValue, m_Table10_Data.Result_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ManagementExpenses_Values = new List<DataValues>(quaters) { year };
                return m_ManagementExpenses_Values;
            }
        }

        public List<DataValues> CommercialExpenses_Values
        {
            get
            {
                if (m_CommercialExpenses_Values != null)
                    return m_CommercialExpenses_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Table11_Data.Result_Values[0].PlannedValue, m_Table11_Data.Result_Values[0].ActualValue),
                    new DataValues(m_Table11_Data.Result_Values[1].PlannedValue, m_Table11_Data.Result_Values[1].ActualValue),
                    new DataValues(m_Table11_Data.Result_Values[2].PlannedValue, m_Table11_Data.Result_Values[2].ActualValue),
                    new DataValues(m_Table11_Data.Result_Values[3].PlannedValue, m_Table11_Data.Result_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_CommercialExpenses_Values = new List<DataValues>(quaters) { year };
                return m_CommercialExpenses_Values;
            }
        }

        public List<DataValues> Profit_Values
        {
            get
            {
                if (m_Profit_Values != null)
                    return m_Profit_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        Revenue_Values[0].PlannedValue - SalesCost_Values[0].PlannedValue - ManagementExpenses_Values[0].PlannedValue - CommercialExpenses_Values[0].PlannedValue,
                        Revenue_Values[0].ActualValue - SalesCost_Values[0].ActualValue - ManagementExpenses_Values[0].ActualValue - CommercialExpenses_Values[0].ActualValue),
                    new DataValues(
                        Revenue_Values[1].PlannedValue - SalesCost_Values[1].PlannedValue - ManagementExpenses_Values[1].PlannedValue - CommercialExpenses_Values[1].PlannedValue,
                        Revenue_Values[1].ActualValue - SalesCost_Values[1].ActualValue - ManagementExpenses_Values[1].ActualValue - CommercialExpenses_Values[1].ActualValue),
                    new DataValues(
                        Revenue_Values[2].PlannedValue - SalesCost_Values[2].PlannedValue - ManagementExpenses_Values[2].PlannedValue - CommercialExpenses_Values[2].PlannedValue,
                        Revenue_Values[2].ActualValue - SalesCost_Values[2].ActualValue - ManagementExpenses_Values[2].ActualValue - CommercialExpenses_Values[2].ActualValue),
                    new DataValues(
                        Revenue_Values[3].PlannedValue - SalesCost_Values[3].PlannedValue - ManagementExpenses_Values[3].PlannedValue - CommercialExpenses_Values[3].PlannedValue,
                        Revenue_Values[3].ActualValue - SalesCost_Values[3].ActualValue - ManagementExpenses_Values[3].ActualValue - CommercialExpenses_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue) * (1 - (m_Data.IncomeTax / 100)), quaters.Sum(x => x.ActualValue) * (1 - (m_Data.IncomeTax / 100)));
                m_Profit_Values = new List<DataValues>(quaters) { year };
                return m_Profit_Values;
            }
        }
    }
}
