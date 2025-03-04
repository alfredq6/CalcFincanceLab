using System.Collections.Generic;

namespace CalcFincanceLab
{
    public class Table15_Data : ITable_Data
    {
        private readonly BaseData m_Data;
        private readonly Table3_Data m_Table3_Data;
        private readonly Table4_Data m_Table4_Data;
        private readonly Table5_Data m_Table5_Data;
        private readonly Table6_Data m_Table6_Data;
        private readonly Table9_Data m_Table9_Data;
        private readonly Table12_Data m_Table12_Data;
        private readonly Table13_Data m_Table13_Data;
        private readonly Table14_Data m_Table14_Data;

        private List<double> m_FixedAssets_Values;
        private List<double> m_DepreciationFixedAssets_Values;
        private List<double> m_IntangibleAssets_Values;
        private List<double> m_IntangibleAssetsDepreciation_Values;
        private List<double> m_ResultNonCurrentAssets_Values;
        private List<double> m_ProductionStocks_Values;
        private List<double> m_TZR_Values;
        private List<double> m_MainProduction_Values;
        private List<double> m_AuxiliaryProduction_Values;
        private List<double> m_CashRegister_Values;
        private List<double> m_CurrentAccount_Values;
        private List<double> m_FinishedProducts_Values;
        private List<double> m_ResultCurrentAssets_Values;
        private List<double> m_Active_Values;
        private List<double> m_AuthorizedCapital_Values;
        private List<double> m_Profit_Values;
        private List<double> m_AccountsPayable_Values;
        private List<double> m_BankLoan_Values;
        private List<double> m_Remuneration_Values;
        private List<double> m_TaxesAndDeductions_Values;
        private List<double> m_Deviations_Values;
        private List<double> m_Passive_Values;

        public Table15_Data(BaseData data, Table3_Data table3_Data, Table4_Data table4_Data, Table5_Data table5_Data, Table6_Data table6_Data,
                            Table9_Data table9_Data, Table12_Data table12_Data, Table13_Data table13_Data, Table14_Data table14_Data)
        {
            m_Data = data;
            m_Table3_Data = table3_Data;
            m_Table4_Data = table4_Data;
            m_Table5_Data = table5_Data;
            m_Table6_Data = table6_Data;
            m_Table9_Data = table9_Data;
            m_Table12_Data = table12_Data;
            m_Table13_Data = table13_Data;
            m_Table14_Data = table14_Data;
        }

        public void ClearCachedData()
        {
            m_FixedAssets_Values = null;
            m_DepreciationFixedAssets_Values = null;
            m_IntangibleAssets_Values = null;
            m_IntangibleAssetsDepreciation_Values = null;
            m_ResultNonCurrentAssets_Values = null;
            m_ProductionStocks_Values = null;
            m_TZR_Values = null;
            m_MainProduction_Values = null;
            m_AuxiliaryProduction_Values = null;
            m_CashRegister_Values = null;
            m_CurrentAccount_Values = null;
            m_FinishedProducts_Values = null;
            m_ResultCurrentAssets_Values = null;
            m_Active_Values = null;
            m_AuthorizedCapital_Values = null;
            m_Profit_Values = null;
            m_AccountsPayable_Values = null;
            m_BankLoan_Values = null;
            m_Remuneration_Values = null;
            m_TaxesAndDeductions_Values = null;
            m_Deviations_Values = null;
            m_Passive_Values = null;
        }

        public List<object[]> GetRows()
        {
            return new List<object[]>
            {
                new List<object>
                {
                    "Основные средства",
                    FixedAssets_Values[0],
                    FixedAssets_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "износ основных средств",
                    DepreciationFixedAssets_Values[0],
                    DepreciationFixedAssets_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "нематериальные активы",
                    IntangibleAssets_Values[0],
                    IntangibleAssets_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "износ нематериальных активов",
                    IntangibleAssetsDepreciation_Values[0],
                    IntangibleAssetsDepreciation_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "ИТОГО внеоборотные активы",
                    ResultNonCurrentAssets_Values[0],
                    ResultNonCurrentAssets_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "Производственные запасы",
                    ProductionStocks_Values[0],
                    ProductionStocks_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "транспортно-заготовительные расходы",
                    TZR_Values[0],
                    TZR_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "основное производство",
                    MainProduction_Values[0],
                    MainProduction_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "вспомогательное производство",
                    AuxiliaryProduction_Values[0],
                    AuxiliaryProduction_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "касса",
                    CashRegister_Values[0],
                    CashRegister_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "расчетный счет",
                    CurrentAccount_Values[0],
                    CurrentAccount_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "готовая продукция",
                    FinishedProducts_Values[0],
                    FinishedProducts_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "Итого оборотные активы",
                    ResultCurrentAssets_Values[0],
                    ResultCurrentAssets_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "АКТИВ",
                    Active_Values[0],
                    Active_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "Уставный фонд",
                    AuthorizedCapital_Values[0],
                    AuthorizedCapital_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "Прибыль",
                    Profit_Values[0],
                    Profit_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "Кредиторская задолженность",
                    AccountsPayable_Values[0],
                    AccountsPayable_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "Кредит банка",
                    BankLoan_Values[0],
                    BankLoan_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "Оплата труда",
                    Remuneration_Values[0],
                    Remuneration_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "Налоги и отчисления",
                    TaxesAndDeductions_Values[0],
                    TaxesAndDeductions_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "Отклонения",
                    Deviations_Values[0],
                    Deviations_Values[1],
                }.ToArray(),

                new List<object>
                {
                    "ПАССИВ",
                    Passive_Values[0],
                    Passive_Values[1],
                }.ToArray(),
            };
        }

        public List<double> FixedAssets_Values
        {
            get
            {
                if (m_FixedAssets_Values != null)
                    return m_FixedAssets_Values;

                m_FixedAssets_Values = new List<double> {
                    m_Data.CashBalanceAtTheBeginning,
                    m_Data.CashBalanceAtTheBeginning,
                };
                return m_FixedAssets_Values;
            }
        }

        public List<double> DepreciationFixedAssets_Values
        {
            get
            {
                if (m_DepreciationFixedAssets_Values != null)
                    return m_DepreciationFixedAssets_Values;

                m_DepreciationFixedAssets_Values = new List<double> {
                    0,
                    m_Table9_Data.DepreciationOfProductionEquipment_Values[4].PlannedValue,
                };
                return m_DepreciationFixedAssets_Values;
            }
        }

        public List<double> IntangibleAssets_Values
        {
            get
            {
                if (m_IntangibleAssets_Values != null)
                    return m_IntangibleAssets_Values;

                m_IntangibleAssets_Values = new List<double> {
                    0,
                    0,
                };
                return m_IntangibleAssets_Values;
            }
        }

        public List<double> IntangibleAssetsDepreciation_Values
        {
            get
            {
                if (m_IntangibleAssetsDepreciation_Values != null)
                    return m_IntangibleAssetsDepreciation_Values;

                m_IntangibleAssetsDepreciation_Values = new List<double> {
                    0,
                    0,
                };
                return m_IntangibleAssetsDepreciation_Values;
            }
        }

        public List<double> ResultNonCurrentAssets_Values
        {
            get
            {
                if (m_ResultNonCurrentAssets_Values != null)
                    return m_ResultNonCurrentAssets_Values;

                m_ResultNonCurrentAssets_Values = new List<double> {
                    FixedAssets_Values[0] - DepreciationFixedAssets_Values[0] + IntangibleAssets_Values[0] - IntangibleAssetsDepreciation_Values[0],
                    FixedAssets_Values[1] - DepreciationFixedAssets_Values[1] + IntangibleAssets_Values[1] - IntangibleAssetsDepreciation_Values[1],
                };
                return m_ResultNonCurrentAssets_Values;
            }
        }

        public List<double> ProductionStocks_Values
        {
            get
            {
                if (m_ProductionStocks_Values != null)
                    return m_ProductionStocks_Values;

                m_ProductionStocks_Values = new List<double> {
                    m_Data.BalanceAtTheBeginningOfTheYearMaterial1 * m_Data.PurchasePrice,
                    m_Table4_Data.RemainOnTheEnd_Values[4].PlannedValue * m_Data.PurchasePrice,
                };
                return m_ProductionStocks_Values;
            }
        }

        public List<double> TZR_Values
        {
            get
            {
                if (m_TZR_Values != null)
                    return m_TZR_Values;

                m_TZR_Values = new List<double> {
                    0,
                    m_Table5_Data.TZR_Values[4].PlannedValue,
                };
                return m_TZR_Values;
            }
        }

        public List<double> MainProduction_Values
        {
            get
            {
                if (m_MainProduction_Values != null)
                    return m_MainProduction_Values;

                m_MainProduction_Values = new List<double> {
                    0,
                    0,
                };
                return m_MainProduction_Values;
            }
        }

        public List<double> AuxiliaryProduction_Values
        {
            get
            {
                if (m_AuxiliaryProduction_Values != null)
                    return m_AuxiliaryProduction_Values;

                m_AuxiliaryProduction_Values = new List<double> {
                    0,
                    0,
                };
                return m_AuxiliaryProduction_Values;
            }
        }

        public List<double> CashRegister_Values
        {
            get
            {
                if (m_CashRegister_Values != null)
                    return m_CashRegister_Values;

                m_CashRegister_Values = new List<double> {
                    0,
                    0,
                };
                return m_CashRegister_Values;
            }
        }

        public List<double> CurrentAccount_Values
        {
            get
            {
                if (m_CurrentAccount_Values != null)
                    return m_CurrentAccount_Values;

                m_CurrentAccount_Values = new List<double> {
                    m_Table14_Data.RemainingAtTheBeginning_Values[4].PlannedValue,
                    m_Table14_Data.RemainingAtTheEnd_Values[4].ActualValue,
                };
                return m_CurrentAccount_Values;
            }
        }

        public List<double> FinishedProducts_Values
        {
            get
            {
                if (m_FinishedProducts_Values != null)
                    return m_FinishedProducts_Values;

                m_FinishedProducts_Values = new List<double> {
                    (m_Table3_Data.ProductA_PlannedCost_Values[4].PlannedValue * m_Table3_Data.ProductA_BalanceAtTheBeginningOfTheYear_Values[4].PlannedValue) + (m_Table3_Data.ProductB_PlannedCost_Values[4].PlannedValue * m_Table3_Data.ProductB_BalanceAtTheBeginningOfTheYear_Values[4].PlannedValue),
                    (m_Table3_Data.ProductA_BalanceAtTheEndOfTheYear_Values[4].PlannedValue * m_Table12_Data.ProductsUnitCosts_Values[0]) + (m_Table3_Data.ProductB_BalanceAtTheEndOfTheYear_Values[4].PlannedValue * m_Table12_Data.ProductsUnitCosts_Values[1]),
                };
                return m_FinishedProducts_Values;
            }
        }

        public List<double> ResultCurrentAssets_Values
        {
            get
            {
                if (m_ResultCurrentAssets_Values != null)
                    return m_ResultCurrentAssets_Values;

                m_ResultCurrentAssets_Values = new List<double> {
                    ProductionStocks_Values[0] + TZR_Values[0] + MainProduction_Values[0] + AuxiliaryProduction_Values[0] + CashRegister_Values[0] + CurrentAccount_Values[0] + FinishedProducts_Values[0],
                    ProductionStocks_Values[1] + TZR_Values[1] + MainProduction_Values[1] + AuxiliaryProduction_Values[1] + CashRegister_Values[1] + CurrentAccount_Values[1] + FinishedProducts_Values[1],
                };
                return m_ResultCurrentAssets_Values;
            }
        }

        public List<double> Active_Values
        {
            get
            {
                if (m_Active_Values != null)
                    return m_Active_Values;

                m_Active_Values = new List<double> {
                    ResultNonCurrentAssets_Values[0] + ResultCurrentAssets_Values[0],
                    ResultNonCurrentAssets_Values[1] + ResultCurrentAssets_Values[1],
                };
                return m_Active_Values;
            }
        }

        public List<double> AuthorizedCapital_Values
        {
            get
            {
                if (m_AuthorizedCapital_Values != null)
                    return m_AuthorizedCapital_Values;

                m_AuthorizedCapital_Values = new List<double> {
                    Active_Values[0],
                    Active_Values[0],
                };
                return m_AuthorizedCapital_Values;
            }
        }

        public List<double> Profit_Values
        {
            get
            {
                if (m_Profit_Values != null)
                    return m_Profit_Values;

                m_Profit_Values = new List<double> {
                    0,
                    m_Table13_Data.Profit_Values[4].ActualValue,
                };
                return m_Profit_Values;
            }
        }

        public List<double> AccountsPayable_Values
        {
            get
            {
                if (m_AccountsPayable_Values != null)
                    return m_AccountsPayable_Values;

                m_AccountsPayable_Values = new List<double> {
                    0,
                    m_Table6_Data.ThirdQuaterPayments_Values[3].PlannedValue,
                };
                return m_AccountsPayable_Values;
            }
        }

        public List<double> BankLoan_Values
        {
            get
            {
                if (m_BankLoan_Values != null)
                    return m_BankLoan_Values;

                m_BankLoan_Values = new List<double> {
                    0,
                    0,
                };
                return m_BankLoan_Values;
            }
        }

        public List<double> Remuneration_Values
        {
            get
            {
                if (m_Remuneration_Values != null)
                    return m_Remuneration_Values;

                m_Remuneration_Values = new List<double> {
                    0,
                    0,
                };
                return m_Remuneration_Values;
            }
        }

        public List<double> TaxesAndDeductions_Values
        {
            get
            {
                if (m_TaxesAndDeductions_Values != null)
                    return m_TaxesAndDeductions_Values;

                m_TaxesAndDeductions_Values = new List<double> {
                    0,
                    ((m_Table13_Data.Revenue_Values[4].PlannedValue - m_Table13_Data.SalesCost_Values[4].PlannedValue - m_Table13_Data.ManagementExpenses_Values[4].PlannedValue - m_Table13_Data.CommercialExpenses_Values[4].PlannedValue) * (m_Data.IncomeTax / 100)),
                };
                return m_TaxesAndDeductions_Values;
            }
        }

        public List<double> Deviations_Values
        {
            get
            {
                if (m_Deviations_Values != null)
                    return m_Deviations_Values;

                m_Deviations_Values = new List<double> {
                    0,
                    Active_Values[1] - (AuthorizedCapital_Values[1] + Profit_Values[1] + AccountsPayable_Values[1] + BankLoan_Values[1] + Remuneration_Values[1] + TaxesAndDeductions_Values[1]),
                };
                return m_Deviations_Values;
            }
        }

        public List<double> Passive_Values
        {
            get
            {
                if (m_Passive_Values != null)
                    return m_Passive_Values;

                m_Passive_Values = new List<double> {
                    AuthorizedCapital_Values[0] + Profit_Values[0] + AccountsPayable_Values[0] + BankLoan_Values[0] + Remuneration_Values[0] + TaxesAndDeductions_Values[0],
                    AuthorizedCapital_Values[1] + Profit_Values[1] + AccountsPayable_Values[1] + BankLoan_Values[1] + Remuneration_Values[1] + TaxesAndDeductions_Values[1],
                };
                return m_Passive_Values;
            }
        }
    }
}
