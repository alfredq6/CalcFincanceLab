using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public class Table14_Data : ITable_Data
    {
        private readonly BaseData m_Data;
        private readonly Table2_Data m_Table2_Data;
        private readonly Table6_Data m_Table6_Data;
        private readonly Table8_Data m_Table8_Data;
        private readonly Table10_Data m_Table10_Data;
        private readonly Table13_Data m_Table13_Data;

        private List<DataValues> m_ReceiptFromBuyers_Values;
        private List<DataValues> m_Influx_Values;
        private List<DataValues> m_Outflow_Values;
        private List<DataValues> m_PaymentsForMaterials_Values;
        private List<DataValues> m_PaymentOfWages_Values;
        private List<DataValues> m_SSFContributions_Values;
        private List<DataValues> m_PaymentsForElectricity_Values;
        private List<DataValues> m_PaymentsForAdvertising_Values;
        private List<DataValues> m_PaymentsForTelephoneInternet_Values;
        private List<DataValues> m_PaymentsOther_Values;
        private List<DataValues> m_OperatingNetCashFlow_Values;
        private List<DataValues> m_ResultNetCashFlow_Values;
        private List<DataValues> m_RemainingAtTheBeginning_Values;
        private List<DataValues> m_RemainingAtTheEnd_Values;

        public Table14_Data(BaseData data, Table2_Data table2_Data, Table6_Data table6_Data, Table8_Data table8_Data, Table10_Data table10_Data, Table13_Data table13_Data)
        {
            m_Data = data;
            m_Table2_Data = table2_Data;
            m_Table6_Data = table6_Data;
            m_Table8_Data = table8_Data;
            m_Table10_Data = table10_Data;
            m_Table13_Data = table13_Data;
        }

        public void ClearCachedData()
        {
            m_ReceiptFromBuyers_Values = null;
            m_Influx_Values = null;
            m_Outflow_Values = null;
            m_PaymentsForMaterials_Values = null;
            m_PaymentOfWages_Values = null;
            m_SSFContributions_Values = null;
            m_PaymentsForElectricity_Values = null;
            m_PaymentsForAdvertising_Values = null;
            m_PaymentsForTelephoneInternet_Values = null;
            m_PaymentsOther_Values = null;
            m_OperatingNetCashFlow_Values = null;
            m_ResultNetCashFlow_Values = null;
            m_RemainingAtTheBeginning_Values = null;
            m_RemainingAtTheEnd_Values = null;
        }

        public List<object[]> GetRows()
        {
            return new List<object[]>
            {
                new List<object>
                {
                    "Операционная деятельность",
                }.ToArray(),

                new List<object>
                {
                    "….Поступление от покупателей",
                    ReceiptFromBuyers_Values[0].PlannedValue,
                    ReceiptFromBuyers_Values[0].ActualValue,
                    ReceiptFromBuyers_Values[0].DeviationValue,
                    ReceiptFromBuyers_Values[1].PlannedValue,
                    ReceiptFromBuyers_Values[1].ActualValue,
                    ReceiptFromBuyers_Values[1].DeviationValue,
                    ReceiptFromBuyers_Values[2].PlannedValue,
                    ReceiptFromBuyers_Values[2].ActualValue,
                    ReceiptFromBuyers_Values[2].DeviationValue,
                    ReceiptFromBuyers_Values[3].PlannedValue,
                    ReceiptFromBuyers_Values[3].ActualValue,
                    ReceiptFromBuyers_Values[3].DeviationValue,
                    ReceiptFromBuyers_Values[4].PlannedValue,
                    ReceiptFromBuyers_Values[4].ActualValue,
                    ReceiptFromBuyers_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "..Приток",
                    Influx_Values[0].PlannedValue,
                    Influx_Values[0].ActualValue,
                    Influx_Values[0].DeviationValue,
                    Influx_Values[1].PlannedValue,
                    Influx_Values[1].ActualValue,
                    Influx_Values[1].DeviationValue,
                    Influx_Values[2].PlannedValue,
                    Influx_Values[2].ActualValue,
                    Influx_Values[2].DeviationValue,
                    Influx_Values[3].PlannedValue,
                    Influx_Values[3].ActualValue,
                    Influx_Values[3].DeviationValue,
                    Influx_Values[4].PlannedValue,
                    Influx_Values[4].ActualValue,
                    Influx_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "..Отток, в том числе",
                    Outflow_Values[0].PlannedValue,
                    Outflow_Values[0].ActualValue,
                    Outflow_Values[0].DeviationValue,
                    Outflow_Values[1].PlannedValue,
                    Outflow_Values[1].ActualValue,
                    Outflow_Values[1].DeviationValue,
                    Outflow_Values[2].PlannedValue,
                    Outflow_Values[2].ActualValue,
                    Outflow_Values[2].DeviationValue,
                    Outflow_Values[3].PlannedValue,
                    Outflow_Values[3].ActualValue,
                    Outflow_Values[3].DeviationValue,
                    Outflow_Values[4].PlannedValue,
                    Outflow_Values[4].ActualValue,
                    Outflow_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "....Платежи за материалы",
                    PaymentsForMaterials_Values[0].PlannedValue,
                    PaymentsForMaterials_Values[0].ActualValue,
                    PaymentsForMaterials_Values[0].DeviationValue,
                    PaymentsForMaterials_Values[1].PlannedValue,
                    PaymentsForMaterials_Values[1].ActualValue,
                    PaymentsForMaterials_Values[1].DeviationValue,
                    PaymentsForMaterials_Values[2].PlannedValue,
                    PaymentsForMaterials_Values[2].ActualValue,
                    PaymentsForMaterials_Values[2].DeviationValue,
                    PaymentsForMaterials_Values[3].PlannedValue,
                    PaymentsForMaterials_Values[3].ActualValue,
                    PaymentsForMaterials_Values[3].DeviationValue,
                    PaymentsForMaterials_Values[4].PlannedValue,
                    PaymentsForMaterials_Values[4].ActualValue,
                    PaymentsForMaterials_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "….Выплата ЗП",
                    PaymentOfWages_Values[0].PlannedValue,
                    PaymentOfWages_Values[0].ActualValue,
                    PaymentOfWages_Values[0].DeviationValue,
                    PaymentOfWages_Values[1].PlannedValue,
                    PaymentOfWages_Values[1].ActualValue,
                    PaymentOfWages_Values[1].DeviationValue,
                    PaymentOfWages_Values[2].PlannedValue,
                    PaymentOfWages_Values[2].ActualValue,
                    PaymentOfWages_Values[2].DeviationValue,
                    PaymentOfWages_Values[3].PlannedValue,
                    PaymentOfWages_Values[3].ActualValue,
                    PaymentOfWages_Values[3].DeviationValue,
                    PaymentOfWages_Values[4].PlannedValue,
                    PaymentOfWages_Values[4].ActualValue,
                    PaymentOfWages_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "….Перечисление в ФСЗН",
                    SSFContributions_Values[0].PlannedValue,
                    SSFContributions_Values[0].ActualValue,
                    SSFContributions_Values[0].DeviationValue,
                    SSFContributions_Values[1].PlannedValue,
                    SSFContributions_Values[1].ActualValue,
                    SSFContributions_Values[1].DeviationValue,
                    SSFContributions_Values[2].PlannedValue,
                    SSFContributions_Values[2].ActualValue,
                    SSFContributions_Values[2].DeviationValue,
                    SSFContributions_Values[3].PlannedValue,
                    SSFContributions_Values[3].ActualValue,
                    SSFContributions_Values[3].DeviationValue,
                    SSFContributions_Values[4].PlannedValue,
                    SSFContributions_Values[4].ActualValue,
                    SSFContributions_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "….Платежи за электроэнергию",
                    PaymentsForElectricity_Values[0].PlannedValue,
                    PaymentsForElectricity_Values[0].ActualValue,
                    PaymentsForElectricity_Values[0].DeviationValue,
                    PaymentsForElectricity_Values[1].PlannedValue,
                    PaymentsForElectricity_Values[1].ActualValue,
                    PaymentsForElectricity_Values[1].DeviationValue,
                    PaymentsForElectricity_Values[2].PlannedValue,
                    PaymentsForElectricity_Values[2].ActualValue,
                    PaymentsForElectricity_Values[2].DeviationValue,
                    PaymentsForElectricity_Values[3].PlannedValue,
                    PaymentsForElectricity_Values[3].ActualValue,
                    PaymentsForElectricity_Values[3].DeviationValue,
                    PaymentsForElectricity_Values[4].PlannedValue,
                    PaymentsForElectricity_Values[4].ActualValue,
                    PaymentsForElectricity_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "….Платежи за рекламу",
                    PaymentsForAdvertising_Values[0].PlannedValue,
                    PaymentsForAdvertising_Values[0].ActualValue,
                    PaymentsForAdvertising_Values[0].DeviationValue,
                    PaymentsForAdvertising_Values[1].PlannedValue,
                    PaymentsForAdvertising_Values[1].ActualValue,
                    PaymentsForAdvertising_Values[1].DeviationValue,
                    PaymentsForAdvertising_Values[2].PlannedValue,
                    PaymentsForAdvertising_Values[2].ActualValue,
                    PaymentsForAdvertising_Values[2].DeviationValue,
                    PaymentsForAdvertising_Values[3].PlannedValue,
                    PaymentsForAdvertising_Values[3].ActualValue,
                    PaymentsForAdvertising_Values[3].DeviationValue,
                    PaymentsForAdvertising_Values[4].PlannedValue,
                    PaymentsForAdvertising_Values[4].ActualValue,
                    PaymentsForAdvertising_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "….Платежи за телефон, интернет",
                    PaymentsForTelephoneInternet_Values[0].PlannedValue,
                    PaymentsForTelephoneInternet_Values[0].ActualValue,
                    PaymentsForTelephoneInternet_Values[0].DeviationValue,
                    PaymentsForTelephoneInternet_Values[1].PlannedValue,
                    PaymentsForTelephoneInternet_Values[1].ActualValue,
                    PaymentsForTelephoneInternet_Values[1].DeviationValue,
                    PaymentsForTelephoneInternet_Values[2].PlannedValue,
                    PaymentsForTelephoneInternet_Values[2].ActualValue,
                    PaymentsForTelephoneInternet_Values[2].DeviationValue,
                    PaymentsForTelephoneInternet_Values[3].PlannedValue,
                    PaymentsForTelephoneInternet_Values[3].ActualValue,
                    PaymentsForTelephoneInternet_Values[3].DeviationValue,
                    PaymentsForTelephoneInternet_Values[4].PlannedValue,
                    PaymentsForTelephoneInternet_Values[4].ActualValue,
                    PaymentsForTelephoneInternet_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "….Платежи прочие",
                    PaymentsOther_Values[0].PlannedValue,
                    PaymentsOther_Values[0].ActualValue,
                    PaymentsOther_Values[0].DeviationValue,
                    PaymentsOther_Values[1].PlannedValue,
                    PaymentsOther_Values[1].ActualValue,
                    PaymentsOther_Values[1].DeviationValue,
                    PaymentsOther_Values[2].PlannedValue,
                    PaymentsOther_Values[2].ActualValue,
                    PaymentsOther_Values[2].DeviationValue,
                    PaymentsOther_Values[3].PlannedValue,
                    PaymentsOther_Values[3].ActualValue,
                    PaymentsOther_Values[3].DeviationValue,
                    PaymentsOther_Values[4].PlannedValue,
                    PaymentsOther_Values[4].ActualValue,
                    PaymentsOther_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Операционный чистый денежный поток",
                    OperatingNetCashFlow_Values[0].PlannedValue,
                    OperatingNetCashFlow_Values[0].ActualValue,
                    OperatingNetCashFlow_Values[0].DeviationValue,
                    OperatingNetCashFlow_Values[1].PlannedValue,
                    OperatingNetCashFlow_Values[1].ActualValue,
                    OperatingNetCashFlow_Values[1].DeviationValue,
                    OperatingNetCashFlow_Values[2].PlannedValue,
                    OperatingNetCashFlow_Values[2].ActualValue,
                    OperatingNetCashFlow_Values[2].DeviationValue,
                    OperatingNetCashFlow_Values[3].PlannedValue,
                    OperatingNetCashFlow_Values[3].ActualValue,
                    OperatingNetCashFlow_Values[3].DeviationValue,
                    OperatingNetCashFlow_Values[4].PlannedValue,
                    OperatingNetCashFlow_Values[4].ActualValue,
                    OperatingNetCashFlow_Values[4].DeviationValue
                }.ToArray(),


                new List<object>
                {
                    "Инвестиционная деятельность",
                }.ToArray(),

                new List<object>
                {
                    "..Приток",
                }.ToArray(),

                new List<object>
                {
                    "…",
                }.ToArray(),

                new List<object>
                {
                    "..Отток",
                }.ToArray(),

                new List<object>
                {
                    "…",
                }.ToArray(),

                new List<object>
                {
                    "Инвестиционный чистый денежный поток",
                }.ToArray(),

                new List<object>
                {
                    "Финансовая деятельность",
                }.ToArray(),

                new List<object>
                {
                    "..Приток",
                }.ToArray(),

                new List<object>
                {
                    "…",
                }.ToArray(),

                new List<object>
                {
                    "..Отток",
                }.ToArray(),

                new List<object>
                {
                    "…",
                }.ToArray(),
                
                new List<object>
                {
                    "Финансовый чистый денежный поток",
                }.ToArray(),

                new List<object>
                {
                    "ИТОГО чистый денежный поток",
                    ResultNetCashFlow_Values[0].PlannedValue,
                    ResultNetCashFlow_Values[0].ActualValue,
                    ResultNetCashFlow_Values[0].DeviationValue,
                    ResultNetCashFlow_Values[1].PlannedValue,
                    ResultNetCashFlow_Values[1].ActualValue,
                    ResultNetCashFlow_Values[1].DeviationValue,
                    ResultNetCashFlow_Values[2].PlannedValue,
                    ResultNetCashFlow_Values[2].ActualValue,
                    ResultNetCashFlow_Values[2].DeviationValue,
                    ResultNetCashFlow_Values[3].PlannedValue,
                    ResultNetCashFlow_Values[3].ActualValue,
                    ResultNetCashFlow_Values[3].DeviationValue,
                    ResultNetCashFlow_Values[4].PlannedValue,
                    ResultNetCashFlow_Values[4].ActualValue,
                    ResultNetCashFlow_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Остаток на начало",
                    RemainingAtTheBeginning_Values[0].PlannedValue,
                    RemainingAtTheBeginning_Values[0].ActualValue,
                    RemainingAtTheBeginning_Values[0].DeviationValue,
                    RemainingAtTheBeginning_Values[1].PlannedValue,
                    RemainingAtTheBeginning_Values[1].ActualValue,
                    RemainingAtTheBeginning_Values[1].DeviationValue,
                    RemainingAtTheBeginning_Values[2].PlannedValue,
                    RemainingAtTheBeginning_Values[2].ActualValue,
                    RemainingAtTheBeginning_Values[2].DeviationValue,
                    RemainingAtTheBeginning_Values[3].PlannedValue,
                    RemainingAtTheBeginning_Values[3].ActualValue,
                    RemainingAtTheBeginning_Values[3].DeviationValue,
                    RemainingAtTheBeginning_Values[4].PlannedValue,
                    RemainingAtTheBeginning_Values[4].ActualValue,
                    RemainingAtTheBeginning_Values[4].DeviationValue
                }.ToArray(),

                new List<object>
                {
                    "Остаток на конец",
                    RemainingAtTheEnd_Values[0].PlannedValue,
                    RemainingAtTheEnd_Values[0].ActualValue,
                    RemainingAtTheEnd_Values[0].DeviationValue,
                    RemainingAtTheEnd_Values[1].PlannedValue,
                    RemainingAtTheEnd_Values[1].ActualValue,
                    RemainingAtTheEnd_Values[1].DeviationValue,
                    RemainingAtTheEnd_Values[2].PlannedValue,
                    RemainingAtTheEnd_Values[2].ActualValue,
                    RemainingAtTheEnd_Values[2].DeviationValue,
                    RemainingAtTheEnd_Values[3].PlannedValue,
                    RemainingAtTheEnd_Values[3].ActualValue,
                    RemainingAtTheEnd_Values[3].DeviationValue,
                    RemainingAtTheEnd_Values[4].PlannedValue,
                    RemainingAtTheEnd_Values[4].ActualValue,
                    RemainingAtTheEnd_Values[4].DeviationValue
                }.ToArray(),
            };
        }

        public List<DataValues> ReceiptFromBuyers_Values
        {
            get
            {
                if (m_ReceiptFromBuyers_Values != null)
                    return m_ReceiptFromBuyers_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Table2_Data.ResultPayments_Values[0].PlannedValue, m_Table2_Data.ResultPayments_Values[0].ActualValue),
                    new DataValues(m_Table2_Data.ResultPayments_Values[1].PlannedValue, m_Table2_Data.ResultPayments_Values[1].ActualValue),
                    new DataValues(m_Table2_Data.ResultPayments_Values[2].PlannedValue, m_Table2_Data.ResultPayments_Values[2].ActualValue),
                    new DataValues(m_Table2_Data.ResultPayments_Values[3].PlannedValue, m_Table2_Data.ResultPayments_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ReceiptFromBuyers_Values = new List<DataValues>(quaters) { year };
                return m_ReceiptFromBuyers_Values;
            }
        }

        public List<DataValues> Influx_Values
        {
            get
            {
                if (m_Influx_Values != null)
                    return m_Influx_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Table2_Data.ResultPayments_Values[0].PlannedValue, m_Table2_Data.ResultPayments_Values[0].ActualValue),
                    new DataValues(m_Table2_Data.ResultPayments_Values[1].PlannedValue, m_Table2_Data.ResultPayments_Values[1].ActualValue),
                    new DataValues(m_Table2_Data.ResultPayments_Values[2].PlannedValue, m_Table2_Data.ResultPayments_Values[2].ActualValue),
                    new DataValues(m_Table2_Data.ResultPayments_Values[3].PlannedValue, m_Table2_Data.ResultPayments_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_Influx_Values = new List<DataValues>(quaters) { year };
                return m_Influx_Values;
            }
        }

        public List<DataValues> Outflow_Values
        {
            get
            {
                if (m_Outflow_Values != null)
                    return m_Outflow_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        PaymentsForMaterials_Values[0].PlannedValue + PaymentOfWages_Values[0].PlannedValue + SSFContributions_Values[0].PlannedValue + PaymentsForElectricity_Values[0].PlannedValue + PaymentsForAdvertising_Values[0].PlannedValue + PaymentsForTelephoneInternet_Values[0].PlannedValue + PaymentsOther_Values[0].PlannedValue,
                        PaymentsForMaterials_Values[0].ActualValue + PaymentOfWages_Values[0].ActualValue + SSFContributions_Values[0].ActualValue + PaymentsForElectricity_Values[0].ActualValue + PaymentsForAdvertising_Values[0].ActualValue + PaymentsForTelephoneInternet_Values[0].ActualValue + PaymentsOther_Values[0].ActualValue),
                    new DataValues(
                        PaymentsForMaterials_Values[1].PlannedValue + PaymentOfWages_Values[1].PlannedValue + SSFContributions_Values[1].PlannedValue + PaymentsForElectricity_Values[1].PlannedValue + PaymentsForAdvertising_Values[1].PlannedValue + PaymentsForTelephoneInternet_Values[1].PlannedValue + PaymentsOther_Values[1].PlannedValue,
                        PaymentsForMaterials_Values[1].ActualValue + PaymentOfWages_Values[1].ActualValue + SSFContributions_Values[1].ActualValue + PaymentsForElectricity_Values[1].ActualValue + PaymentsForAdvertising_Values[1].ActualValue + PaymentsForTelephoneInternet_Values[1].ActualValue + PaymentsOther_Values[1].ActualValue),
                    new DataValues(
                        PaymentsForMaterials_Values[2].PlannedValue + PaymentOfWages_Values[2].PlannedValue + SSFContributions_Values[2].PlannedValue + PaymentsForElectricity_Values[2].PlannedValue + PaymentsForAdvertising_Values[2].PlannedValue + PaymentsForTelephoneInternet_Values[2].PlannedValue + PaymentsOther_Values[2].PlannedValue,
                        PaymentsForMaterials_Values[2].ActualValue + PaymentOfWages_Values[2].ActualValue + SSFContributions_Values[2].ActualValue + PaymentsForElectricity_Values[2].ActualValue + PaymentsForAdvertising_Values[2].ActualValue + PaymentsForTelephoneInternet_Values[2].ActualValue + PaymentsOther_Values[2].ActualValue),
                    new DataValues(
                        PaymentsForMaterials_Values[3].PlannedValue + PaymentOfWages_Values[3].PlannedValue + SSFContributions_Values[3].PlannedValue + PaymentsForElectricity_Values[3].PlannedValue + PaymentsForAdvertising_Values[3].PlannedValue + PaymentsForTelephoneInternet_Values[3].PlannedValue + PaymentsOther_Values[3].PlannedValue,
                        PaymentsForMaterials_Values[3].ActualValue + PaymentOfWages_Values[3].ActualValue + SSFContributions_Values[3].ActualValue + PaymentsForElectricity_Values[3].ActualValue + PaymentsForAdvertising_Values[3].ActualValue + PaymentsForTelephoneInternet_Values[3].ActualValue + PaymentsOther_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_Outflow_Values = new List<DataValues>(quaters) { year };
                return m_Outflow_Values;
            }
        }

        public List<DataValues> PaymentsForMaterials_Values
        {
            get
            {
                if (m_PaymentsForMaterials_Values != null)
                    return m_PaymentsForMaterials_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Table6_Data.ResultPayments_Values[0].PlannedValue, m_Table6_Data.ResultPayments_Values[0].ActualValue),
                    new DataValues(m_Table6_Data.ResultPayments_Values[1].PlannedValue, m_Table6_Data.ResultPayments_Values[1].ActualValue),
                    new DataValues(m_Table6_Data.ResultPayments_Values[2].PlannedValue, m_Table6_Data.ResultPayments_Values[2].ActualValue),
                    new DataValues(m_Table6_Data.ResultPayments_Values[3].PlannedValue, m_Table6_Data.ResultPayments_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_PaymentsForMaterials_Values = new List<DataValues>(quaters) { year };
                return m_PaymentsForMaterials_Values;
            }
        }

        public List<DataValues> PaymentOfWages_Values
        {
            get
            {
                if (m_PaymentOfWages_Values != null)
                    return m_PaymentOfWages_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Table8_Data.Salary_Values[0].PlannedValue, m_Table8_Data.Salary_Values[0].ActualValue),
                    new DataValues(m_Table8_Data.Salary_Values[1].PlannedValue, m_Table8_Data.Salary_Values[1].ActualValue),
                    new DataValues(m_Table8_Data.Salary_Values[2].PlannedValue, m_Table8_Data.Salary_Values[2].ActualValue),
                    new DataValues(m_Table8_Data.Salary_Values[3].PlannedValue, m_Table8_Data.Salary_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_PaymentOfWages_Values = new List<DataValues>(quaters) { year };
                return m_PaymentOfWages_Values;
            }
        }

        public List<DataValues> SSFContributions_Values
        {
            get
            {
                if (m_SSFContributions_Values != null)
                    return m_SSFContributions_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Table10_Data.DeductionsForSalary_Values[0].PlannedValue, m_Table10_Data.DeductionsForSalary_Values[0].ActualValue),
                    new DataValues(m_Table10_Data.DeductionsForSalary_Values[1].PlannedValue, m_Table10_Data.DeductionsForSalary_Values[1].ActualValue),
                    new DataValues(m_Table10_Data.DeductionsForSalary_Values[2].PlannedValue, m_Table10_Data.DeductionsForSalary_Values[2].ActualValue),
                    new DataValues(m_Table10_Data.DeductionsForSalary_Values[3].PlannedValue, m_Table10_Data.DeductionsForSalary_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_SSFContributions_Values = new List<DataValues>(quaters) { year };
                return m_SSFContributions_Values;
            }
        }

        public List<DataValues> PaymentsForElectricity_Values
        {
            get
            {
                if (m_PaymentsForElectricity_Values != null)
                    return m_PaymentsForElectricity_Values;

                var plannedValue = (m_Data.ElectricityForGeneralEconomicPurposes + m_Data.ElectricityForIndustrialPurposes) / 4;
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_PaymentsForElectricity_Values = new List<DataValues>(quaters) { year };
                return m_PaymentsForElectricity_Values;
            }
        }

        public List<DataValues> PaymentsForAdvertising_Values
        {
            get
            {
                if (m_PaymentsForAdvertising_Values != null)
                    return m_PaymentsForAdvertising_Values;

                var plannedValue = m_Data.Advertising / 4;
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_PaymentsForAdvertising_Values = new List<DataValues>(quaters) { year };
                return m_PaymentsForAdvertising_Values;
            }
        }

        public List<DataValues> PaymentsForTelephoneInternet_Values
        {
            get
            {
                if (m_PaymentsForTelephoneInternet_Values != null)
                    return m_PaymentsForTelephoneInternet_Values;

                var plannedValue = m_Data.TelephoneInternet / 4;
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_PaymentsForTelephoneInternet_Values = new List<DataValues>(quaters) { year };
                return m_PaymentsForTelephoneInternet_Values;
            }
        }

        public List<DataValues> PaymentsOther_Values
        {
            get
            {
                if (m_PaymentsOther_Values != null)
                    return m_PaymentsOther_Values;

                var plannedValue = (m_Data.TravelExpenses + m_Data.PackagingCosts) / 4;
                var actualValue = plannedValue;
                var quaters = new List<DataValues> {
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(plannedValue, actualValue),
                    new DataValues(
                        plannedValue + ((m_Table13_Data.Revenue_Values[4].PlannedValue - m_Table13_Data.SalesCost_Values[4].PlannedValue - m_Table13_Data.ManagementExpenses_Values[4].PlannedValue - m_Table13_Data.CommercialExpenses_Values[4].PlannedValue) * (m_Data.IncomeTax / 100)),
                        actualValue + ((m_Table13_Data.Revenue_Values[4].ActualValue - m_Table13_Data.SalesCost_Values[4].ActualValue - m_Table13_Data.ManagementExpenses_Values[4].ActualValue - m_Table13_Data.CommercialExpenses_Values[4].ActualValue) * (m_Data.IncomeTax / 100))),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_PaymentsOther_Values = new List<DataValues>(quaters) { year };
                return m_PaymentsOther_Values;
            }
        }

        public List<DataValues> OperatingNetCashFlow_Values
        {
            get
            {
                if (m_OperatingNetCashFlow_Values != null)
                    return m_OperatingNetCashFlow_Values;

                var quaters = new List<DataValues> {
                    new DataValues(
                        Influx_Values[0].PlannedValue - Outflow_Values[0].PlannedValue,
                        Influx_Values[0].ActualValue - Outflow_Values[0].ActualValue),
                    new DataValues(
                        Influx_Values[1].PlannedValue - Outflow_Values[1].PlannedValue,
                        Influx_Values[1].ActualValue - Outflow_Values[1].ActualValue),
                    new DataValues(
                        Influx_Values[2].PlannedValue - Outflow_Values[2].PlannedValue,
                        Influx_Values[2].ActualValue - Outflow_Values[2].ActualValue),
                    new DataValues(
                        Influx_Values[3].PlannedValue - Outflow_Values[3].PlannedValue,
                        Influx_Values[3].ActualValue - Outflow_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_OperatingNetCashFlow_Values = new List<DataValues>(quaters) { year };
                return m_OperatingNetCashFlow_Values;
            }
        }

        public List<DataValues> ResultNetCashFlow_Values
        {
            get
            {
                if (m_ResultNetCashFlow_Values != null)
                    return m_ResultNetCashFlow_Values;

                var quaters = new List<DataValues> {
                    new DataValues(OperatingNetCashFlow_Values[0].PlannedValue, OperatingNetCashFlow_Values[0].ActualValue),
                    new DataValues(OperatingNetCashFlow_Values[1].PlannedValue, OperatingNetCashFlow_Values[1].ActualValue),
                    new DataValues(OperatingNetCashFlow_Values[2].PlannedValue, OperatingNetCashFlow_Values[2].ActualValue),
                    new DataValues(OperatingNetCashFlow_Values[3].PlannedValue, OperatingNetCashFlow_Values[3].ActualValue),
                };
                var year = new DataValues(quaters.Sum(x => x.PlannedValue), quaters.Sum(x => x.ActualValue));
                m_ResultNetCashFlow_Values = new List<DataValues>(quaters) { year };
                return m_ResultNetCashFlow_Values;
            }
        }

        public List<DataValues> RemainingAtTheBeginning_Values
        {
            get
            {
                if (m_RemainingAtTheBeginning_Values != null)
                    return m_RemainingAtTheBeginning_Values;

                var quaters = new List<DataValues> {
                    new DataValues(m_Data.CashBalanceAtTheBeginning, m_Data.CashBalanceAtTheBeginning),
                    new DataValues(RemainingAtTheEnd_Values[0].PlannedValue, RemainingAtTheEnd_Values[0].ActualValue),
                    new DataValues(RemainingAtTheEnd_Values[1].PlannedValue, RemainingAtTheEnd_Values[1].ActualValue),
                    new DataValues(RemainingAtTheEnd_Values[2].PlannedValue, RemainingAtTheEnd_Values[2].ActualValue),
                };
                var year = new DataValues(quaters[0].PlannedValue, quaters[0].ActualValue);
                m_RemainingAtTheBeginning_Values = new List<DataValues>(quaters) { year };
                return m_RemainingAtTheBeginning_Values;
            }
        }

        public List<DataValues> RemainingAtTheEnd_Values
        {
            get
            {
                if (m_RemainingAtTheEnd_Values != null)
                    return m_RemainingAtTheEnd_Values;

                var quaters = new List<DataValues>();
                quaters.Add(new DataValues(
                    m_Data.CashBalanceAtTheBeginning + OperatingNetCashFlow_Values[0].PlannedValue,
                    m_Data.CashBalanceAtTheBeginning + OperatingNetCashFlow_Values[0].ActualValue));

                quaters.Add(new DataValues(
                    quaters[0].PlannedValue + OperatingNetCashFlow_Values[1].PlannedValue,
                    quaters[0].ActualValue + OperatingNetCashFlow_Values[1].ActualValue));

                quaters.Add(new DataValues(
                    quaters[1].PlannedValue + OperatingNetCashFlow_Values[2].PlannedValue,
                    quaters[1].ActualValue + OperatingNetCashFlow_Values[2].ActualValue));

                quaters.Add(new DataValues(
                    quaters[2].PlannedValue + OperatingNetCashFlow_Values[3].PlannedValue,
                    quaters[2].ActualValue + OperatingNetCashFlow_Values[3].ActualValue));

                var year = new DataValues(
                    m_Data.CashBalanceAtTheBeginning + OperatingNetCashFlow_Values[4].PlannedValue,
                    m_Data.CashBalanceAtTheBeginning + OperatingNetCashFlow_Values[4].ActualValue);
                m_RemainingAtTheEnd_Values = new List<DataValues>(quaters) { year };
                return m_RemainingAtTheEnd_Values;
            }
        }
    }
}
