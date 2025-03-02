using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public class Table5_Data : ITable_Data
    {
        private readonly BaseData m_Data;
        private readonly Table4_Data m_Table4_Data;

        private List<DataValues> m_ToBuying_Values;
        private List<DataValues> m_BuyingPrice_Values;
        private List<DataValues> m_BuyingCost_Values;
        private List<DataValues> m_TZR_Values;
        private List<DataValues> m_ResultPurchase_Values;

        public Table5_Data(BaseData data, Table4_Data table4_Data)
        {
            m_Data = data;
            m_Table4_Data = table4_Data;
        }

        public void ClearCachedData()
        {
            m_ToBuying_Values = null;
            m_BuyingPrice_Values = null;
            m_BuyingCost_Values = null;
            m_TZR_Values = null;
            m_ResultPurchase_Values = null;
        }

        public List<object[]> GetRows()
        {
            return new List<object[]>
            {
                new List<object>
                {
                    "К закупке, м.",
                    ToBuying_Values[0].PlannedValue,
                    ToBuying_Values[0].ActualValue,
                    ToBuying_Values[0].DeviationValue,
                    ToBuying_Values[1].PlannedValue,
                    ToBuying_Values[1].ActualValue,
                    ToBuying_Values[1].DeviationValue,
                    ToBuying_Values[2].PlannedValue,
                    ToBuying_Values[2].ActualValue,
                    ToBuying_Values[2].DeviationValue,
                    ToBuying_Values[3].PlannedValue,
                    ToBuying_Values[3].ActualValue,
                    ToBuying_Values[3].DeviationValue,
                    ToBuying_Values[4].PlannedValue,
                    ToBuying_Values[4].ActualValue,
                    ToBuying_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "цена закупки, руб.",
                    BuyingPrice_Values[0].PlannedValue,
                    BuyingPrice_Values[0].ActualValue,
                    BuyingPrice_Values[0].DeviationValue,
                    BuyingPrice_Values[1].PlannedValue,
                    BuyingPrice_Values[1].ActualValue,
                    BuyingPrice_Values[1].DeviationValue,
                    BuyingPrice_Values[2].PlannedValue,
                    BuyingPrice_Values[2].ActualValue,
                    BuyingPrice_Values[2].DeviationValue,
                    BuyingPrice_Values[3].PlannedValue,
                    BuyingPrice_Values[3].ActualValue,
                    BuyingPrice_Values[3].DeviationValue,
                    BuyingPrice_Values[4].PlannedValue,
                    BuyingPrice_Values[4].ActualValue,
                    BuyingPrice_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Стоимость закупки, руб.",
                    BuyingCost_Values[0].PlannedValue,
                    BuyingCost_Values[0].ActualValue,
                    BuyingCost_Values[0].DeviationValue,
                    BuyingCost_Values[1].PlannedValue,
                    BuyingCost_Values[1].ActualValue,
                    BuyingCost_Values[1].DeviationValue,
                    BuyingCost_Values[2].PlannedValue,
                    BuyingCost_Values[2].ActualValue,
                    BuyingCost_Values[2].DeviationValue,
                    BuyingCost_Values[3].PlannedValue,
                    BuyingCost_Values[3].ActualValue,
                    BuyingCost_Values[3].DeviationValue,
                    BuyingCost_Values[4].PlannedValue,
                    BuyingCost_Values[4].ActualValue,
                    BuyingCost_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Транспортно-заготовительные расходы, руб.",
                    TZR_Values[0].PlannedValue,
                    TZR_Values[0].ActualValue,
                    TZR_Values[0].DeviationValue,
                    TZR_Values[1].PlannedValue,
                    TZR_Values[1].ActualValue,
                    TZR_Values[1].DeviationValue,
                    TZR_Values[2].PlannedValue,
                    TZR_Values[2].ActualValue,
                    TZR_Values[2].DeviationValue,
                    TZR_Values[3].PlannedValue,
                    TZR_Values[3].ActualValue,
                    TZR_Values[3].DeviationValue,
                    TZR_Values[4].PlannedValue,
                    TZR_Values[4].ActualValue,
                    TZR_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "ИТОГО Закупка, руб.",
                    ResultPurchase_Values[0].PlannedValue,
                    ResultPurchase_Values[0].ActualValue,
                    ResultPurchase_Values[0].DeviationValue,
                    ResultPurchase_Values[1].PlannedValue,
                    ResultPurchase_Values[1].ActualValue,
                    ResultPurchase_Values[1].DeviationValue,
                    ResultPurchase_Values[2].PlannedValue,
                    ResultPurchase_Values[2].ActualValue,
                    ResultPurchase_Values[2].DeviationValue,
                    ResultPurchase_Values[3].PlannedValue,
                    ResultPurchase_Values[3].ActualValue,
                    ResultPurchase_Values[3].DeviationValue,
                    ResultPurchase_Values[4].PlannedValue,
                    ResultPurchase_Values[4].ActualValue,
                    ResultPurchase_Values[4].DeviationValue
                }.ToArray(),
            };
        }

        public List<DataValues> ToBuying_Values
        {
            get
            {
                if (m_ToBuying_Values != null)
                    return m_ToBuying_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Table4_Data.ResultToBuying_Values[0].PlannedValue, m_Table4_Data.ResultToBuying_Values[0].ActualValue),
                    new DataValues(m_Table4_Data.ResultToBuying_Values[1].PlannedValue, m_Table4_Data.ResultToBuying_Values[1].ActualValue),
                    new DataValues(m_Table4_Data.ResultToBuying_Values[2].PlannedValue, m_Table4_Data.ResultToBuying_Values[2].ActualValue),
                    new DataValues(m_Table4_Data.ResultToBuying_Values[3].PlannedValue, m_Table4_Data.ResultToBuying_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ToBuying_Values = new List<DataValues>(quaters) { year };
                return m_ToBuying_Values;
            }
        }

        public List<DataValues> BuyingPrice_Values
        {
            get
            {
                if (m_BuyingPrice_Values != null)
                    return m_BuyingPrice_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Data.PurchasePrice, m_Data.PurchasePrice),
                    new DataValues(m_Data.PurchasePrice, m_Data.PurchasePrice),
                    new DataValues(m_Data.PurchasePrice, m_Data.PurchasePrice),
                    new DataValues(m_Data.PurchasePrice, m_Data.PurchasePrice),
                };
                var year = new DataValues(m_Data.PurchasePrice, m_Data.PurchasePrice);
                m_BuyingPrice_Values = new List<DataValues>(quaters) { year };
                return m_BuyingPrice_Values;
            }
        }

        public List<DataValues> BuyingCost_Values
        {
            get
            {
                if (m_BuyingCost_Values != null)
                    return m_BuyingCost_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        ToBuying_Values[0].PlannedValue * BuyingPrice_Values[0].PlannedValue,
                        ToBuying_Values[0].ActualValue * BuyingPrice_Values[0].ActualValue),
                    new DataValues(
                        ToBuying_Values[1].PlannedValue * BuyingPrice_Values[1].PlannedValue,
                        ToBuying_Values[1].ActualValue * BuyingPrice_Values[1].ActualValue),
                    new DataValues(
                        ToBuying_Values[2].PlannedValue * BuyingPrice_Values[2].PlannedValue,
                        ToBuying_Values[2].ActualValue * BuyingPrice_Values[2].ActualValue),
                    new DataValues(
                        ToBuying_Values[3].PlannedValue * BuyingPrice_Values[3].PlannedValue,
                        ToBuying_Values[3].ActualValue * BuyingPrice_Values[3].ActualValue),
                };
                var year = new DataValues(
                    ToBuying_Values[4].PlannedValue * BuyingPrice_Values[4].PlannedValue,
                    ToBuying_Values[4].ActualValue * BuyingPrice_Values[4].ActualValue);
                m_BuyingCost_Values = new List<DataValues>(quaters) { year };
                return m_BuyingCost_Values;
            }
        }

        public List<DataValues> TZR_Values
        {
            get
            {
                if (m_TZR_Values != null)
                    return m_TZR_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Data.TZR, m_Data.TZR),
                    new DataValues(m_Data.TZR, m_Data.TZR),
                    new DataValues(m_Data.TZR, m_Data.TZR),
                    new DataValues(m_Data.TZR, m_Data.TZR),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_TZR_Values = new List<DataValues>(quaters) { year };
                return m_TZR_Values;
            }
        }

        public List<DataValues> ResultPurchase_Values
        {
            get
            {
                if (m_ResultPurchase_Values != null)
                    return m_ResultPurchase_Values;

                var quaters = new List<DataValues> {
                    new DataValues(BuyingCost_Values[0].PlannedValue + TZR_Values[0].PlannedValue, BuyingCost_Values[0].ActualValue + TZR_Values[0].ActualValue),
                    new DataValues(BuyingCost_Values[1].PlannedValue + TZR_Values[1].PlannedValue, BuyingCost_Values[1].ActualValue + TZR_Values[1].ActualValue),
                    new DataValues(BuyingCost_Values[2].PlannedValue + TZR_Values[2].PlannedValue, BuyingCost_Values[2].ActualValue + TZR_Values[2].ActualValue),
                    new DataValues(BuyingCost_Values[3].PlannedValue + TZR_Values[3].PlannedValue, BuyingCost_Values[3].ActualValue + TZR_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ResultPurchase_Values = new List<DataValues>(quaters) { year };
                return m_ResultPurchase_Values;
            }
        }
    }
}
