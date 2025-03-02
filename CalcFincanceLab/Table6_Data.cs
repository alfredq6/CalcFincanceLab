using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public class Table6_Data : ITable_Data
    {
        private readonly BaseData m_Data;
        private readonly Table5_Data m_Table5_Data;

        private List<DataValues> m_FirstQuaterPayments_Values;
        private List<DataValues> m_SecondQuaterPayments_Values;
        private List<DataValues> m_ThirdQuaterPayments_Values;
        private List<DataValues> m_FourthQuaterPayments_Values;
        private List<DataValues> m_ResultPayments_Values;

        public Table6_Data(BaseData data, Table5_Data table5_Data)
        {
            m_Data = data;
            m_Table5_Data = table5_Data;
        }

        public void ClearCachedData()
        {
            m_FirstQuaterPayments_Values = null;
            m_SecondQuaterPayments_Values = null;
            m_ThirdQuaterPayments_Values = null;
            m_FourthQuaterPayments_Values = null;
            m_ResultPayments_Values = null;
        }

        public List<object[]> GetRows()
        {
            return new List<object[]>
            {
                new List<object>
                {
                    "Платежи 1-го квартала, руб.",
                    FirstQuaterPayments_Values[0].PlannedValue,
                    FirstQuaterPayments_Values[0].ActualValue,
                    FirstQuaterPayments_Values[0].DeviationValue,
                    FirstQuaterPayments_Values[1].PlannedValue,
                    FirstQuaterPayments_Values[1].ActualValue,
                    FirstQuaterPayments_Values[1].DeviationValue,
                    FirstQuaterPayments_Values[2].PlannedValue,
                    FirstQuaterPayments_Values[2].ActualValue,
                    FirstQuaterPayments_Values[2].DeviationValue,
                    FirstQuaterPayments_Values[3].PlannedValue,
                    FirstQuaterPayments_Values[3].ActualValue,
                    FirstQuaterPayments_Values[3].DeviationValue,
                    FirstQuaterPayments_Values[4].PlannedValue,
                    FirstQuaterPayments_Values[4].ActualValue,
                    FirstQuaterPayments_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Платежи 2-го квартала, руб.",
                    SecondQuaterPayments_Values[0].PlannedValue,
                    SecondQuaterPayments_Values[0].ActualValue,
                    SecondQuaterPayments_Values[0].DeviationValue,
                    SecondQuaterPayments_Values[1].PlannedValue,
                    SecondQuaterPayments_Values[1].ActualValue,
                    SecondQuaterPayments_Values[1].DeviationValue,
                    SecondQuaterPayments_Values[2].PlannedValue,
                    SecondQuaterPayments_Values[2].ActualValue,
                    SecondQuaterPayments_Values[2].DeviationValue,
                    SecondQuaterPayments_Values[3].PlannedValue,
                    SecondQuaterPayments_Values[3].ActualValue,
                    SecondQuaterPayments_Values[3].DeviationValue,
                    SecondQuaterPayments_Values[4].PlannedValue,
                    SecondQuaterPayments_Values[4].ActualValue,
                    SecondQuaterPayments_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Платежи 3-го квартала, руб.",
                    ThirdQuaterPayments_Values[0].PlannedValue,
                    ThirdQuaterPayments_Values[0].ActualValue,
                    ThirdQuaterPayments_Values[0].DeviationValue,
                    ThirdQuaterPayments_Values[1].PlannedValue,
                    ThirdQuaterPayments_Values[1].ActualValue,
                    ThirdQuaterPayments_Values[1].DeviationValue,
                    ThirdQuaterPayments_Values[2].PlannedValue,
                    ThirdQuaterPayments_Values[2].ActualValue,
                    ThirdQuaterPayments_Values[2].DeviationValue,
                    ThirdQuaterPayments_Values[3].PlannedValue,
                    ThirdQuaterPayments_Values[3].ActualValue,
                    ThirdQuaterPayments_Values[3].DeviationValue,
                    ThirdQuaterPayments_Values[4].PlannedValue,
                    ThirdQuaterPayments_Values[4].ActualValue,
                    ThirdQuaterPayments_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Платежи 4-го квартала, руб.",
                    FourthQuaterPayments_Values[0].PlannedValue,
                    FourthQuaterPayments_Values[0].ActualValue,
                    FourthQuaterPayments_Values[0].DeviationValue,
                    FourthQuaterPayments_Values[1].PlannedValue,
                    FourthQuaterPayments_Values[1].ActualValue,
                    FourthQuaterPayments_Values[1].DeviationValue,
                    FourthQuaterPayments_Values[2].PlannedValue,
                    FourthQuaterPayments_Values[2].ActualValue,
                    FourthQuaterPayments_Values[2].DeviationValue,
                    FourthQuaterPayments_Values[3].PlannedValue,
                    FourthQuaterPayments_Values[3].ActualValue,
                    FourthQuaterPayments_Values[3].DeviationValue,
                    FourthQuaterPayments_Values[4].PlannedValue,
                    FourthQuaterPayments_Values[4].ActualValue,
                    FourthQuaterPayments_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "ИТОГО",
                    ResultPayments_Values[0].PlannedValue,
                    ResultPayments_Values[0].ActualValue,
                    ResultPayments_Values[0].DeviationValue,
                    ResultPayments_Values[1].PlannedValue,
                    ResultPayments_Values[1].ActualValue,
                    ResultPayments_Values[1].DeviationValue,
                    ResultPayments_Values[2].PlannedValue,
                    ResultPayments_Values[2].ActualValue,
                    ResultPayments_Values[2].DeviationValue,
                    ResultPayments_Values[3].PlannedValue,
                    ResultPayments_Values[3].ActualValue,
                    ResultPayments_Values[3].DeviationValue,
                    ResultPayments_Values[4].PlannedValue,
                    ResultPayments_Values[4].ActualValue,
                    ResultPayments_Values[4].DeviationValue
                }.ToArray(),
            };
        }

        public List<DataValues> FirstQuaterPayments_Values
        {
            get
            {
                if (m_FirstQuaterPayments_Values != null)
                    return m_FirstQuaterPayments_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        m_Table5_Data.ResultPurchase_Values[0].PlannedValue * m_Data.PaymentInTheDeliveryPeriod / 100,
                        m_Table5_Data.ResultPurchase_Values[0].ActualValue * m_Data.PaymentInTheDeliveryPeriod / 100),
                    new DataValues(
                        m_Table5_Data.ResultPurchase_Values[0].PlannedValue * m_Data.AtTheEndOfTheQuarterTheStockOfTheRequirementsOfTheNextPeriod / 100,
                        m_Table5_Data.ResultPurchase_Values[0].ActualValue * m_Data.AtTheEndOfTheQuarterTheStockOfTheRequirementsOfTheNextPeriod / 100),
                    new DataValues(0, 0),
                    new DataValues(0, 0),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_FirstQuaterPayments_Values = new List<DataValues>(quaters) { year };
                return m_FirstQuaterPayments_Values;
            }
        }

        public List<DataValues> SecondQuaterPayments_Values
        {
            get
            {
                if (m_SecondQuaterPayments_Values != null)
                    return m_SecondQuaterPayments_Values;

                var quaters = new List<DataValues> {
                    new DataValues(0, 0),
                    new DataValues(
                        m_Table5_Data.ResultPurchase_Values[1].PlannedValue * m_Data.PaymentInTheDeliveryPeriod / 100,
                        m_Table5_Data.ResultPurchase_Values[1].ActualValue * m_Data.PaymentInTheDeliveryPeriod / 100),
                    new DataValues(
                        m_Table5_Data.ResultPurchase_Values[1].PlannedValue * m_Data.AtTheEndOfTheQuarterTheStockOfTheRequirementsOfTheNextPeriod / 100,
                        m_Table5_Data.ResultPurchase_Values[1].ActualValue * m_Data.AtTheEndOfTheQuarterTheStockOfTheRequirementsOfTheNextPeriod / 100),
                    new DataValues(0, 0),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_SecondQuaterPayments_Values = new List<DataValues>(quaters) { year };
                return m_SecondQuaterPayments_Values;
            }
        }

        public List<DataValues> ThirdQuaterPayments_Values
        {
            get
            {
                if (m_ThirdQuaterPayments_Values != null)
                    return m_ThirdQuaterPayments_Values;

                var quaters = new List<DataValues> {
                    new DataValues(0, 0),
                    new DataValues(0, 0),
                    new DataValues(
                        m_Table5_Data.ResultPurchase_Values[2].PlannedValue * m_Data.PaymentInTheDeliveryPeriod / 100,
                        m_Table5_Data.ResultPurchase_Values[2].ActualValue * m_Data.PaymentInTheDeliveryPeriod / 100),
                    new DataValues(
                        m_Table5_Data.ResultPurchase_Values[2].PlannedValue * m_Data.AtTheEndOfTheQuarterTheStockOfTheRequirementsOfTheNextPeriod / 100,
                        m_Table5_Data.ResultPurchase_Values[2].ActualValue * m_Data.AtTheEndOfTheQuarterTheStockOfTheRequirementsOfTheNextPeriod / 100),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ThirdQuaterPayments_Values = new List<DataValues>(quaters) { year };
                return m_ThirdQuaterPayments_Values;
            }
        }

        public List<DataValues> FourthQuaterPayments_Values
        {
            get
            {
                if (m_FourthQuaterPayments_Values != null)
                    return m_FourthQuaterPayments_Values;

                var quaters = new List<DataValues> {
                    new DataValues(0, 0),
                    new DataValues(0, 0),
                    new DataValues(0, 0),
                    new DataValues(
                        m_Table5_Data.ResultPurchase_Values[3].PlannedValue * m_Data.PaymentInTheDeliveryPeriod / 100,
                        m_Table5_Data.ResultPurchase_Values[3].ActualValue * m_Data.PaymentInTheDeliveryPeriod / 100),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_FourthQuaterPayments_Values = new List<DataValues>(quaters) { year };
                return m_FourthQuaterPayments_Values;
            }
        }

        public List<DataValues> ResultPayments_Values
        {
            get
            {
                if (m_ResultPayments_Values != null)
                    return m_ResultPayments_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        FirstQuaterPayments_Values[0].PlannedValue + SecondQuaterPayments_Values[0].PlannedValue + ThirdQuaterPayments_Values[0].PlannedValue + FourthQuaterPayments_Values[0].PlannedValue,
                        FirstQuaterPayments_Values[0].ActualValue + SecondQuaterPayments_Values[0].ActualValue + ThirdQuaterPayments_Values[0].ActualValue + FourthQuaterPayments_Values[0].ActualValue),
                    new DataValues(
                        FirstQuaterPayments_Values[1].PlannedValue + SecondQuaterPayments_Values[1].PlannedValue + ThirdQuaterPayments_Values[1].PlannedValue + FourthQuaterPayments_Values[1].PlannedValue,
                        FirstQuaterPayments_Values[1].ActualValue + SecondQuaterPayments_Values[1].ActualValue + ThirdQuaterPayments_Values[1].ActualValue + FourthQuaterPayments_Values[1].ActualValue),
                    new DataValues(
                        FirstQuaterPayments_Values[2].PlannedValue + SecondQuaterPayments_Values[2].PlannedValue + ThirdQuaterPayments_Values[2].PlannedValue + FourthQuaterPayments_Values[2].PlannedValue,
                        FirstQuaterPayments_Values[2].ActualValue + SecondQuaterPayments_Values[2].ActualValue + ThirdQuaterPayments_Values[2].ActualValue + FourthQuaterPayments_Values[2].ActualValue),
                    new DataValues(
                        FirstQuaterPayments_Values[3].PlannedValue + SecondQuaterPayments_Values[3].PlannedValue + ThirdQuaterPayments_Values[3].PlannedValue + FourthQuaterPayments_Values[3].PlannedValue,
                        FirstQuaterPayments_Values[3].ActualValue + SecondQuaterPayments_Values[3].ActualValue + ThirdQuaterPayments_Values[3].ActualValue + FourthQuaterPayments_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ResultPayments_Values = new List<DataValues>(quaters) { year };
                return m_ResultPayments_Values;
            }
        }
    }
}
