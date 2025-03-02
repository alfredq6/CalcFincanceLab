using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public class Table4_Data : ITable_Data
    {
        private readonly BaseData m_Data;
        private readonly Table3_Data m_Table3_Data;

        private List<DataValues> m_ResultToBuying_Values;
        private List<DataValues> m_ProductA_Production_Values;
        private List<DataValues> m_ProductB_Production_Values;
        private List<DataValues> m_ProductA_Material1ConsumptionRate_Values;
        private List<DataValues> m_ProductB_Material1ConsumptionRate_Values;
        private List<DataValues> m_ProductA_ProductionDemand_Values;
        private List<DataValues> m_ProductB_ProductionDemand_Values;
        private List<DataValues> m_Result_ProductionDemand_Values;
        private List<DataValues> m_RemainOnTheEnd_Values;
        private List<DataValues> m_RemainOnTheBeginning_Values;


        public Table4_Data(BaseData data, Table3_Data table3_Data)
        {
            m_Data = data;
            m_Table3_Data = table3_Data;
        }

        public void ClearCachedData()
        {
            m_ResultToBuying_Values = null;
            m_ProductA_Production_Values = null;
            m_ProductB_Production_Values = null;
            m_ProductA_Material1ConsumptionRate_Values = null;
            m_ProductB_Material1ConsumptionRate_Values = null;
            m_ProductA_ProductionDemand_Values = null;
            m_ProductB_ProductionDemand_Values = null;
            m_Result_ProductionDemand_Values = null;
            m_RemainOnTheEnd_Values = null;
            m_RemainOnTheBeginning_Values = null;
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
                    "норма расхода для Продукта А, м.",
                    ProductA_Material1ConsumptionRate_Values[0].PlannedValue,
                    ProductA_Material1ConsumptionRate_Values[0].ActualValue,
                    ProductA_Material1ConsumptionRate_Values[0].DeviationValue,
                    ProductA_Material1ConsumptionRate_Values[1].PlannedValue,
                    ProductA_Material1ConsumptionRate_Values[1].ActualValue,
                    ProductA_Material1ConsumptionRate_Values[1].DeviationValue,
                    ProductA_Material1ConsumptionRate_Values[2].PlannedValue,
                    ProductA_Material1ConsumptionRate_Values[2].ActualValue,
                    ProductA_Material1ConsumptionRate_Values[2].DeviationValue,
                    ProductA_Material1ConsumptionRate_Values[3].PlannedValue,
                    ProductA_Material1ConsumptionRate_Values[3].ActualValue,
                    ProductA_Material1ConsumptionRate_Values[3].DeviationValue,
                    ProductA_Material1ConsumptionRate_Values[4].PlannedValue,
                    ProductA_Material1ConsumptionRate_Values[4].ActualValue,
                    ProductA_Material1ConsumptionRate_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "норма расхода для Продукта В, м.",
                    ProductB_Material1ConsumptionRate_Values[0].PlannedValue,
                    ProductB_Material1ConsumptionRate_Values[0].ActualValue,
                    ProductB_Material1ConsumptionRate_Values[0].DeviationValue,
                    ProductB_Material1ConsumptionRate_Values[1].PlannedValue,
                    ProductB_Material1ConsumptionRate_Values[1].ActualValue,
                    ProductB_Material1ConsumptionRate_Values[1].DeviationValue,
                    ProductB_Material1ConsumptionRate_Values[2].PlannedValue,
                    ProductB_Material1ConsumptionRate_Values[2].ActualValue,
                    ProductB_Material1ConsumptionRate_Values[2].DeviationValue,
                    ProductB_Material1ConsumptionRate_Values[3].PlannedValue,
                    ProductB_Material1ConsumptionRate_Values[3].ActualValue,
                    ProductB_Material1ConsumptionRate_Values[3].DeviationValue,
                    ProductB_Material1ConsumptionRate_Values[4].PlannedValue,
                    ProductB_Material1ConsumptionRate_Values[4].ActualValue,
                    ProductB_Material1ConsumptionRate_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Потребность на объем производства Продукта А, м.",
                    ProductA_ProductionDemand_Values[0].PlannedValue,
                    ProductA_ProductionDemand_Values[0].ActualValue,
                    ProductA_ProductionDemand_Values[0].DeviationValue,
                    ProductA_ProductionDemand_Values[1].PlannedValue,
                    ProductA_ProductionDemand_Values[1].ActualValue,
                    ProductA_ProductionDemand_Values[1].DeviationValue,
                    ProductA_ProductionDemand_Values[2].PlannedValue,
                    ProductA_ProductionDemand_Values[2].ActualValue,
                    ProductA_ProductionDemand_Values[2].DeviationValue,
                    ProductA_ProductionDemand_Values[3].PlannedValue,
                    ProductA_ProductionDemand_Values[3].ActualValue,
                    ProductA_ProductionDemand_Values[3].DeviationValue,
                    ProductA_ProductionDemand_Values[4].PlannedValue,
                    ProductA_ProductionDemand_Values[4].ActualValue,
                    ProductA_ProductionDemand_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Потребность на объем производства Продукта В, м.",
                    ProductB_ProductionDemand_Values[0].PlannedValue,
                    ProductB_ProductionDemand_Values[0].ActualValue,
                    ProductB_ProductionDemand_Values[0].DeviationValue,
                    ProductB_ProductionDemand_Values[1].PlannedValue,
                    ProductB_ProductionDemand_Values[1].ActualValue,
                    ProductB_ProductionDemand_Values[1].DeviationValue,
                    ProductB_ProductionDemand_Values[2].PlannedValue,
                    ProductB_ProductionDemand_Values[2].ActualValue,
                    ProductB_ProductionDemand_Values[2].DeviationValue,
                    ProductB_ProductionDemand_Values[3].PlannedValue,
                    ProductB_ProductionDemand_Values[3].ActualValue,
                    ProductB_ProductionDemand_Values[3].DeviationValue,
                    ProductB_ProductionDemand_Values[4].PlannedValue,
                    ProductB_ProductionDemand_Values[4].ActualValue,
                    ProductB_ProductionDemand_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Итого потребность на объем производства, м.",
                    Result_ProductionDemand_Values[0].PlannedValue,
                    Result_ProductionDemand_Values[0].ActualValue,
                    Result_ProductionDemand_Values[0].DeviationValue,
                    Result_ProductionDemand_Values[1].PlannedValue,
                    Result_ProductionDemand_Values[1].ActualValue,
                    Result_ProductionDemand_Values[1].DeviationValue,
                    Result_ProductionDemand_Values[2].PlannedValue,
                    Result_ProductionDemand_Values[2].ActualValue,
                    Result_ProductionDemand_Values[2].DeviationValue,
                    Result_ProductionDemand_Values[3].PlannedValue,
                    Result_ProductionDemand_Values[3].ActualValue,
                    Result_ProductionDemand_Values[3].DeviationValue,
                    Result_ProductionDemand_Values[4].PlannedValue,
                    Result_ProductionDemand_Values[4].ActualValue,
                    Result_ProductionDemand_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "остаток на начало, м.",
                    RemainOnTheBeginning_Values[0].PlannedValue,
                    RemainOnTheBeginning_Values[0].ActualValue,
                    RemainOnTheBeginning_Values[0].DeviationValue,
                    RemainOnTheBeginning_Values[1].PlannedValue,
                    RemainOnTheBeginning_Values[1].ActualValue,
                    RemainOnTheBeginning_Values[1].DeviationValue,
                    RemainOnTheBeginning_Values[2].PlannedValue,
                    RemainOnTheBeginning_Values[2].ActualValue,
                    RemainOnTheBeginning_Values[2].DeviationValue,
                    RemainOnTheBeginning_Values[3].PlannedValue,
                    RemainOnTheBeginning_Values[3].ActualValue,
                    RemainOnTheBeginning_Values[3].DeviationValue,
                    RemainOnTheBeginning_Values[4].PlannedValue,
                    RemainOnTheBeginning_Values[4].ActualValue,
                    RemainOnTheBeginning_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "остаток на конец, м.",
                    RemainOnTheEnd_Values[0].PlannedValue,
                    RemainOnTheEnd_Values[0].ActualValue,
                    RemainOnTheEnd_Values[0].DeviationValue,
                    RemainOnTheEnd_Values[1].PlannedValue,
                    RemainOnTheEnd_Values[1].ActualValue,
                    RemainOnTheEnd_Values[1].DeviationValue,
                    RemainOnTheEnd_Values[2].PlannedValue,
                    RemainOnTheEnd_Values[2].ActualValue,
                    RemainOnTheEnd_Values[2].DeviationValue,
                    RemainOnTheEnd_Values[3].PlannedValue,
                    RemainOnTheEnd_Values[3].ActualValue,
                    RemainOnTheEnd_Values[3].DeviationValue,
                    RemainOnTheEnd_Values[4].PlannedValue,
                    RemainOnTheEnd_Values[4].ActualValue,
                    RemainOnTheEnd_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "ИТОГО К закупке, м.",
                    ResultToBuying_Values[0].PlannedValue,
                    ResultToBuying_Values[0].ActualValue,
                    ResultToBuying_Values[0].DeviationValue,
                    ResultToBuying_Values[1].PlannedValue,
                    ResultToBuying_Values[1].ActualValue,
                    ResultToBuying_Values[1].DeviationValue,
                    ResultToBuying_Values[2].PlannedValue,
                    ResultToBuying_Values[2].ActualValue,
                    ResultToBuying_Values[2].DeviationValue,
                    ResultToBuying_Values[3].PlannedValue,
                    ResultToBuying_Values[3].ActualValue,
                    ResultToBuying_Values[3].DeviationValue,
                    ResultToBuying_Values[4].PlannedValue,
                    ResultToBuying_Values[4].ActualValue,
                    ResultToBuying_Values[4].DeviationValue
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
                    new DataValues(m_Table3_Data.ProductA_Production_Values[0].PlannedValue, m_Table3_Data.ProductA_Production_Values[0].ActualValue),
                    new DataValues(m_Table3_Data.ProductA_Production_Values[1].PlannedValue, m_Table3_Data.ProductA_Production_Values[1].ActualValue),
                    new DataValues(m_Table3_Data.ProductA_Production_Values[2].PlannedValue, m_Table3_Data.ProductA_Production_Values[2].ActualValue),
                    new DataValues(m_Table3_Data.ProductA_Production_Values[3].PlannedValue, m_Table3_Data.ProductA_Production_Values[3].ActualValue),
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
                    new DataValues(m_Table3_Data.ProductB_Production_Values[0].PlannedValue, m_Table3_Data.ProductB_Production_Values[0].ActualValue),
                    new DataValues(m_Table3_Data.ProductB_Production_Values[1].PlannedValue, m_Table3_Data.ProductB_Production_Values[1].ActualValue),
                    new DataValues(m_Table3_Data.ProductB_Production_Values[2].PlannedValue, m_Table3_Data.ProductB_Production_Values[2].ActualValue),
                    new DataValues(m_Table3_Data.ProductB_Production_Values[3].PlannedValue, m_Table3_Data.ProductB_Production_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ProductB_Production_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_Production_Values;
            }
        }

        public List<DataValues> ProductA_Material1ConsumptionRate_Values
        {
            get
            {
                if (m_ProductA_Material1ConsumptionRate_Values != null)
                    return m_ProductA_Material1ConsumptionRate_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Data.ProductA_Material1ConsumptionRate, m_Data.ProductA_Material1ConsumptionRate),
                    new DataValues(m_Data.ProductA_Material1ConsumptionRate, m_Data.ProductA_Material1ConsumptionRate),
                    new DataValues(m_Data.ProductA_Material1ConsumptionRate, m_Data.ProductA_Material1ConsumptionRate),
                    new DataValues(m_Data.ProductA_Material1ConsumptionRate, m_Data.ProductA_Material1ConsumptionRate),
                };
                var year = new DataValues(m_Data.ProductA_Material1ConsumptionRate, m_Data.ProductA_Material1ConsumptionRate);
                m_ProductA_Material1ConsumptionRate_Values = new List<DataValues>(quaters) { year };
                return m_ProductA_Material1ConsumptionRate_Values;
            }
        }

        public List<DataValues> ProductB_Material1ConsumptionRate_Values
        {
            get
            {
                if (m_ProductB_Material1ConsumptionRate_Values != null)
                    return m_ProductB_Material1ConsumptionRate_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Data.ProductB_Material1ConsumptionRate, m_Data.ProductB_Material1ConsumptionRate),
                    new DataValues(m_Data.ProductB_Material1ConsumptionRate, m_Data.ProductB_Material1ConsumptionRate),
                    new DataValues(m_Data.ProductB_Material1ConsumptionRate, m_Data.ProductB_Material1ConsumptionRate),
                    new DataValues(m_Data.ProductB_Material1ConsumptionRate, m_Data.ProductB_Material1ConsumptionRate),
                };
                var year = new DataValues(m_Data.ProductB_Material1ConsumptionRate, m_Data.ProductB_Material1ConsumptionRate);
                m_ProductB_Material1ConsumptionRate_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_Material1ConsumptionRate_Values;
            }
        }

        public List<DataValues> ProductA_ProductionDemand_Values
        {
            get
            {
                if (m_ProductA_ProductionDemand_Values != null)
                    return m_ProductA_ProductionDemand_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        ProductA_Production_Values[0].PlannedValue * ProductA_Material1ConsumptionRate_Values[0].PlannedValue,
                        ProductA_Production_Values[0].ActualValue * ProductA_Material1ConsumptionRate_Values[0].ActualValue),
                    new DataValues(
                        ProductA_Production_Values[1].PlannedValue * ProductA_Material1ConsumptionRate_Values[1].PlannedValue,
                        ProductA_Production_Values[1].ActualValue * ProductA_Material1ConsumptionRate_Values[1].ActualValue),
                    new DataValues(
                        ProductA_Production_Values[2].PlannedValue * ProductA_Material1ConsumptionRate_Values[2].PlannedValue,
                        ProductA_Production_Values[2].ActualValue * ProductA_Material1ConsumptionRate_Values[2].ActualValue),
                    new DataValues(
                        ProductA_Production_Values[3].PlannedValue * ProductA_Material1ConsumptionRate_Values[3].PlannedValue,
                        ProductA_Production_Values[3].ActualValue * ProductA_Material1ConsumptionRate_Values[3].ActualValue),
                };
                var year = new DataValues(
                    ProductA_Production_Values[4].PlannedValue * ProductA_Material1ConsumptionRate_Values[4].PlannedValue,
                    ProductA_Production_Values[4].ActualValue * ProductA_Material1ConsumptionRate_Values[4].ActualValue);
                m_ProductA_ProductionDemand_Values = new List<DataValues>(quaters) { year };
                return m_ProductA_ProductionDemand_Values;
            }
        }

        public List<DataValues> ProductB_ProductionDemand_Values
        {
            get
            {
                if (m_ProductB_ProductionDemand_Values != null)
                    return m_ProductB_ProductionDemand_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        ProductB_Production_Values[0].PlannedValue * ProductB_Material1ConsumptionRate_Values[0].PlannedValue,
                        ProductB_Production_Values[0].ActualValue * ProductB_Material1ConsumptionRate_Values[0].ActualValue),
                    new DataValues(
                        ProductB_Production_Values[1].PlannedValue * ProductB_Material1ConsumptionRate_Values[1].PlannedValue,
                        ProductB_Production_Values[1].ActualValue * ProductB_Material1ConsumptionRate_Values[1].ActualValue),
                    new DataValues(
                        ProductB_Production_Values[2].PlannedValue * ProductB_Material1ConsumptionRate_Values[2].PlannedValue,
                        ProductB_Production_Values[2].ActualValue * ProductB_Material1ConsumptionRate_Values[2].ActualValue),
                    new DataValues(
                        ProductB_Production_Values[3].PlannedValue * ProductB_Material1ConsumptionRate_Values[3].PlannedValue,
                        ProductB_Production_Values[3].ActualValue * ProductB_Material1ConsumptionRate_Values[3].ActualValue),
                };
                var year = new DataValues(
                    ProductB_Production_Values[4].PlannedValue * ProductB_Material1ConsumptionRate_Values[4].PlannedValue,
                    ProductB_Production_Values[4].ActualValue * ProductB_Material1ConsumptionRate_Values[4].ActualValue);
                m_ProductB_ProductionDemand_Values = new List<DataValues>(quaters) { year };
                return m_ProductB_ProductionDemand_Values;
            }
        }

        public List<DataValues> Result_ProductionDemand_Values
        {
            get
            {
                if (m_Result_ProductionDemand_Values != null)
                    return m_Result_ProductionDemand_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        ProductA_ProductionDemand_Values[0].PlannedValue + ProductB_ProductionDemand_Values[0].PlannedValue,
                        ProductA_ProductionDemand_Values[0].ActualValue + ProductB_ProductionDemand_Values[0].ActualValue),
                    new DataValues(
                        ProductA_ProductionDemand_Values[1].PlannedValue + ProductB_ProductionDemand_Values[1].PlannedValue,
                        ProductA_ProductionDemand_Values[1].ActualValue + ProductB_ProductionDemand_Values[1].ActualValue),
                    new DataValues(
                        ProductA_ProductionDemand_Values[2].PlannedValue + ProductB_ProductionDemand_Values[2].PlannedValue,
                        ProductA_ProductionDemand_Values[2].ActualValue + ProductB_ProductionDemand_Values[2].ActualValue),
                    new DataValues(
                        ProductA_ProductionDemand_Values[3].PlannedValue + ProductB_ProductionDemand_Values[3].PlannedValue,
                        ProductA_ProductionDemand_Values[3].ActualValue + ProductB_ProductionDemand_Values[3].ActualValue),
                };
                var year = new DataValues(
                    ProductA_ProductionDemand_Values[4].PlannedValue + ProductB_ProductionDemand_Values[4].PlannedValue,
                    ProductA_ProductionDemand_Values[4].ActualValue + ProductB_ProductionDemand_Values[4].ActualValue);
                m_Result_ProductionDemand_Values = new List<DataValues>(quaters) { year };
                return m_Result_ProductionDemand_Values;
            }
        }

        public List<DataValues> RemainOnTheEnd_Values
        {
            get
            {
                if (m_RemainOnTheEnd_Values != null)
                    return m_RemainOnTheEnd_Values;

                var percents = m_Data.AtTheEndOfTheQuarterTheStockOfTheRequirementsOfTheNextPeriod / 100;
                var quaters = new List<DataValues> {
                    new DataValues(
                        Result_ProductionDemand_Values[0].PlannedValue * percents,
                        Result_ProductionDemand_Values[0].ActualValue * percents),
                    new DataValues(
                        Result_ProductionDemand_Values[1].PlannedValue * percents,
                        Result_ProductionDemand_Values[1].ActualValue * percents),
                    new DataValues(
                        Result_ProductionDemand_Values[2].PlannedValue * percents,
                        Result_ProductionDemand_Values[2].ActualValue * percents),
                    new DataValues(
                        Result_ProductionDemand_Values[3].PlannedValue * percents,
                        Result_ProductionDemand_Values[3].ActualValue * percents),
                };
                var year = new DataValues(
                    quaters[3].PlannedValue,
                    quaters[3].ActualValue);
                m_RemainOnTheEnd_Values = new List<DataValues>(quaters) { year };
                return m_RemainOnTheEnd_Values;
            }
        }

        public List<DataValues> RemainOnTheBeginning_Values
        {
            get
            {
                if (m_RemainOnTheBeginning_Values != null)
                    return m_RemainOnTheBeginning_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Data.BalanceAtTheBeginningOfTheYearMaterial1, m_Data.BalanceAtTheBeginningOfTheYearMaterial1),
                    new DataValues(RemainOnTheEnd_Values[0].PlannedValue, RemainOnTheEnd_Values[0].ActualValue),
                    new DataValues(RemainOnTheEnd_Values[1].PlannedValue, RemainOnTheEnd_Values[1].ActualValue),
                    new DataValues(RemainOnTheEnd_Values[2].PlannedValue, RemainOnTheEnd_Values[2].ActualValue),
                };
                var year = new DataValues(m_Data.BalanceAtTheBeginningOfTheYearMaterial1, m_Data.BalanceAtTheBeginningOfTheYearMaterial1);
                m_RemainOnTheBeginning_Values = new List<DataValues>(quaters) { year };
                return m_RemainOnTheBeginning_Values;
            }
        }

        public List<DataValues> ResultToBuying_Values
        {
            get
            {
                if (m_ResultToBuying_Values != null)
                    return m_ResultToBuying_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        Result_ProductionDemand_Values[0].PlannedValue - RemainOnTheBeginning_Values[0].PlannedValue + RemainOnTheEnd_Values[0].PlannedValue,
                        Result_ProductionDemand_Values[0].ActualValue - RemainOnTheBeginning_Values[0].ActualValue + RemainOnTheEnd_Values[0].ActualValue),
                    new DataValues(
                        Result_ProductionDemand_Values[1].PlannedValue - RemainOnTheBeginning_Values[1].PlannedValue + RemainOnTheEnd_Values[1].PlannedValue,
                        Result_ProductionDemand_Values[1].ActualValue - RemainOnTheBeginning_Values[1].ActualValue + RemainOnTheEnd_Values[1].ActualValue),
                    new DataValues(
                        Result_ProductionDemand_Values[2].PlannedValue - RemainOnTheBeginning_Values[2].PlannedValue + RemainOnTheEnd_Values[2].PlannedValue,
                        Result_ProductionDemand_Values[2].ActualValue - RemainOnTheBeginning_Values[2].ActualValue + RemainOnTheEnd_Values[2].ActualValue),
                    new DataValues(
                        Result_ProductionDemand_Values[3].PlannedValue - RemainOnTheBeginning_Values[3].PlannedValue + RemainOnTheEnd_Values[3].PlannedValue,
                        Result_ProductionDemand_Values[3].ActualValue - RemainOnTheBeginning_Values[3].ActualValue + RemainOnTheEnd_Values[3].ActualValue),
                };
                var year = new DataValues(
                        Result_ProductionDemand_Values[4].PlannedValue - RemainOnTheBeginning_Values[4].PlannedValue + RemainOnTheEnd_Values[4].PlannedValue,
                        Result_ProductionDemand_Values[4].ActualValue - RemainOnTheBeginning_Values[4].ActualValue + RemainOnTheEnd_Values[4].ActualValue);
                m_ResultToBuying_Values = new List<DataValues>(quaters) { year };
                return m_ResultToBuying_Values;
            }
        }
    }
}
