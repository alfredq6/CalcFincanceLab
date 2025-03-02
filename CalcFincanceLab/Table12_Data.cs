using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public class Table12_Data : ITable_Data
    {
        private readonly BaseData m_Data;
        private readonly Table4_Data m_Table4_Data;
        private readonly Table5_Data m_Table5_Data;
        private readonly Table7_Data m_Table7_Data;
        private readonly Table9_Data m_Table9_Data;
        private readonly Table10_Data m_Table10_Data;
        private readonly Table11_Data m_Table11_Data;

        private List<double> m_ProductsMaterialCosts_Values;
        private List<double> m_ProductsTZR_Values;
        private List<double> m_ProductsWorkersSalaries_Values;
        private List<double> m_ProductsProductions_Values;
        private List<double> m_ProductsCostPriceForDirectExpenses_Values;
        private List<double> m_ProductsGeneralProductionExpences_Values;
        private List<double> m_ProductsGeneralBusinessExpenses_Values;
        private List<double> m_ProductsCommercialExpenses_Values;
        private List<double> m_ProductsCostOfIndirectExpenses_Values;
        private List<double> m_ProductsProductionCosts_Values;
        private List<double> m_ProductsUnitCosts_Values;
        private double? m_TZRRate;
        private double? m_OPRRate;

        public Table12_Data(BaseData data, Table4_Data table4_Data, Table5_Data table5_Data, Table7_Data table7_Data,
                            Table9_Data table9_Data, Table10_Data table10_Data, Table11_Data table11_Data)
        {
            m_Data = data;
            m_Table4_Data = table4_Data;
            m_Table5_Data = table5_Data;
            m_Table7_Data = table7_Data;
            m_Table9_Data = table9_Data;
            m_Table10_Data = table10_Data;
            m_Table11_Data = table11_Data;
        }

        public void ClearCachedData()
        {
            m_ProductsMaterialCosts_Values = null;
            m_ProductsTZR_Values = null;
            m_ProductsWorkersSalaries_Values = null;
            m_ProductsProductions_Values = null;
            m_ProductsCostPriceForDirectExpenses_Values = null;
            m_ProductsGeneralProductionExpences_Values = null;
            m_ProductsGeneralBusinessExpenses_Values = null;
            m_ProductsCommercialExpenses_Values = null;
            m_ProductsCostOfIndirectExpenses_Values = null;
            m_ProductsProductionCosts_Values = null;
            m_ProductsUnitCosts_Values = null;
            m_TZRRate = null;
            m_OPRRate = null;
        }

        public List<object[]> GetRows()
        {
            return new List<object[]>
            {
                new List<object>
                {
                    "Прямые расходы, в том числе",
                }.ToArray(),

                new List<object>
                {
                    "….затраты на Материал 1",
                    ProductsMaterialCosts_Values[0],
                    ProductsMaterialCosts_Values[1],
                    ProductsMaterialCosts_Values[2],
                }.ToArray(),

                new List<object>
                {
                    "….транспортно-заготовительные расходы",
                    ProductsTZR_Values[0],
                    ProductsTZR_Values[1],
                    ProductsTZR_Values[2],
                }.ToArray(),

                new List<object>
                {
                    "….затраты на оплату труда Рабочего 1",
                    ProductsWorkersSalaries_Values[0],
                    ProductsWorkersSalaries_Values[1],
                    ProductsWorkersSalaries_Values[2],
                }.ToArray(),

                new List<object>
                {
                    "Объем производства Продукта , шт.",
                    ProductsProductions_Values[0],
                    ProductsProductions_Values[1],
                    ProductsProductions_Values[2],
                }.ToArray(),

                new List<object>
                {
                    "Себестоимость по прямым расходам, руб.",
                    ProductsCostPriceForDirectExpenses_Values[0],
                    ProductsCostPriceForDirectExpenses_Values[1],
                    ProductsCostPriceForDirectExpenses_Values[2],
                }.ToArray(),

                new List<object>
                {
                    "Себестоимость производства, руб.",
                    ProductsProductionCosts_Values[0],
                    ProductsProductionCosts_Values[1],
                    ProductsProductionCosts_Values[2],
                }.ToArray(),

                new List<object>
                {
                    "Себестоимость единицы, руб.",
                    ProductsUnitCosts_Values[0],
                    ProductsUnitCosts_Values[1],
                    ProductsUnitCosts_Values[2],
                }.ToArray(),

                new List<object>
                {
                    "Косвенные расходы, в том числе",
                }.ToArray(),

                new List<object>
                {
                    "….общепроизводственные расходы",
                    ProductsGeneralProductionExpences_Values[0],
                    ProductsGeneralProductionExpences_Values[1],
                    ProductsGeneralProductionExpences_Values[2],
                }.ToArray(),

                new List<object>
                {
                    "….общехозяйственные расходы",
                    ProductsGeneralBusinessExpenses_Values[0],
                    ProductsGeneralBusinessExpenses_Values[1],
                    ProductsGeneralBusinessExpenses_Values[2],
                }.ToArray(),

                new List<object>
                {
                    "….общехозяйственные расходы",
                    ProductsCommercialExpenses_Values[0],
                    ProductsCommercialExpenses_Values[1],
                    ProductsCommercialExpenses_Values[2],
                }.ToArray(),

                new List<object>
                {
                    "Себестоимость по косвенным расходам, руб.",
                    ProductsCostOfIndirectExpenses_Values[0],
                    ProductsCostOfIndirectExpenses_Values[1],
                    ProductsCostOfIndirectExpenses_Values[2],
                }.ToArray(),

                new List<object>
                {
                    "Ставка ТЗР",
                    "",
                    "",
                    TZRRate,
                }.ToArray(),

                new List<object>
                {
                    "Ставка ОПР",
                    "",
                    "",
                    OPRRate,
                }.ToArray(),
            };
        }

        public List<double> ProductsMaterialCosts_Values
        {
            get
            {
                if (m_ProductsMaterialCosts_Values != null)
                    return m_ProductsMaterialCosts_Values;

                var products = new List<double> {
                    m_Data.PurchasePrice * m_Table4_Data.ProductA_ProductionDemand_Values[4].ActualValue,
                    m_Data.PurchasePrice * m_Table4_Data.ProductB_ProductionDemand_Values[4].ActualValue,
                };
                var result = products.Sum();
                m_ProductsMaterialCosts_Values = new List<double>(products) { result };
                return m_ProductsMaterialCosts_Values;
            }
        }

        public List<double> ProductsTZR_Values
        {
            get
            {
                if (m_ProductsTZR_Values != null)
                    return m_ProductsTZR_Values;

                var products = new List<double> {
                    (m_Table4_Data.ProductA_ProductionDemand_Values[4].ActualValue / m_Table4_Data.Result_ProductionDemand_Values[4].ActualValue) * m_Table5_Data.TZR_Values[4].ActualValue,
                    (m_Table4_Data.ProductB_ProductionDemand_Values[4].ActualValue / m_Table4_Data.Result_ProductionDemand_Values[4].ActualValue) * m_Table5_Data.TZR_Values[4].ActualValue,
                };
                var result = products.Sum();
                m_ProductsTZR_Values = new List<double>(products) { result };
                return m_ProductsTZR_Values;
            }
        }

        public List<double> ProductsWorkersSalaries_Values
        {
            get
            {
                if (m_ProductsWorkersSalaries_Values != null)
                    return m_ProductsWorkersSalaries_Values;

                var products = new List<double> {
                    m_Data.HourlyWageRate * m_Table7_Data.ProductA_LaborIntensityPerVolumeOfProduction_Values[4].ActualValue,
                    m_Data.HourlyWageRate * m_Table7_Data.ProductB_LaborIntensityPerVolumeOfProduction_Values[4].ActualValue,
                };
                var result = products.Sum();
                m_ProductsWorkersSalaries_Values = new List<double>(products) { result };
                return m_ProductsWorkersSalaries_Values;
            }
        }

        public List<double> ProductsProductions_Values
        {
            get
            {
                if (m_ProductsProductions_Values != null)
                    return m_ProductsProductions_Values;

                var products = new List<double> {
                    m_Table7_Data.ProductA_Production_Values[4].ActualValue,
                    m_Table7_Data.ProductB_Production_Values[4].ActualValue,
                };
                var result = products.Sum();
                m_ProductsProductions_Values = new List<double>(products) { result };
                return m_ProductsProductions_Values;
            }
        }

        public List<double> ProductsCostPriceForDirectExpenses_Values
        {
            get
            {
                if (m_ProductsCostPriceForDirectExpenses_Values != null)
                    return m_ProductsCostPriceForDirectExpenses_Values;

                var products = new List<double> {
                    ProductsMaterialCosts_Values[0] + ProductsTZR_Values[0] + ProductsWorkersSalaries_Values[0],
                    ProductsMaterialCosts_Values[1] + ProductsTZR_Values[1] + ProductsWorkersSalaries_Values[1],
                };
                var result = products.Sum();
                m_ProductsCostPriceForDirectExpenses_Values = new List<double>(products) { result };
                return m_ProductsCostPriceForDirectExpenses_Values;
            }
        }

        public List<double> ProductsProductionCosts_Values
        {
            get
            {
                if (m_ProductsProductionCosts_Values != null)
                    return m_ProductsProductionCosts_Values;

                var products = new List<double> {
                    ProductsCostPriceForDirectExpenses_Values[0] + ProductsCostOfIndirectExpenses_Values[0],
                    ProductsCostPriceForDirectExpenses_Values[1] + ProductsCostOfIndirectExpenses_Values[1],
                };
                var result = products.Sum();
                m_ProductsProductionCosts_Values = new List<double>(products) { result };
                return m_ProductsProductionCosts_Values;
            }
        }

        public List<double> ProductsUnitCosts_Values
        {
            get
            {
                if (m_ProductsUnitCosts_Values != null)
                    return m_ProductsUnitCosts_Values;

                var products = new List<double> {
                    ProductsProductionCosts_Values[0] / ProductsProductions_Values[0],
                    ProductsProductionCosts_Values[1] / ProductsProductions_Values[1],
                };
                var result = products.Sum();
                m_ProductsUnitCosts_Values = new List<double>(products) { result };
                return m_ProductsUnitCosts_Values;
            }
        }

        public List<double> ProductsGeneralProductionExpences_Values
        {
            get
            {
                if (m_ProductsGeneralProductionExpences_Values != null)
                    return m_ProductsGeneralProductionExpences_Values;

                var products = new List<double> {
                    (ProductsProductions_Values[0] / ProductsProductions_Values[2]) * m_Table9_Data.Result_Values[4].ActualValue,
                    (ProductsProductions_Values[1] / ProductsProductions_Values[2]) * m_Table9_Data.Result_Values[4].ActualValue,
                };
                var result = products.Sum();
                m_ProductsGeneralProductionExpences_Values = new List<double>(products) { result };
                return m_ProductsGeneralProductionExpences_Values;
            }
        }

        public List<double> ProductsGeneralBusinessExpenses_Values
        {
            get
            {
                if (m_ProductsGeneralBusinessExpenses_Values != null)
                    return m_ProductsGeneralBusinessExpenses_Values;

                var products = new List<double> {
                    (ProductsProductions_Values[0] / ProductsProductions_Values[2]) * m_Table10_Data.Result_Values[4].ActualValue,
                    (ProductsProductions_Values[1] / ProductsProductions_Values[2]) * m_Table10_Data.Result_Values[4].ActualValue,
                };
                var result = products.Sum();
                m_ProductsGeneralBusinessExpenses_Values = new List<double>(products) { result };
                return m_ProductsGeneralBusinessExpenses_Values;
            }
        }

        public List<double> ProductsCommercialExpenses_Values
        {
            get
            {
                if (m_ProductsCommercialExpenses_Values != null)
                    return m_ProductsCommercialExpenses_Values;

                var products = new List<double> {
                    (ProductsProductions_Values[0] / ProductsProductions_Values[2]) * m_Table11_Data.Result_Values[4].ActualValue,
                    (ProductsProductions_Values[1] / ProductsProductions_Values[2]) * m_Table11_Data.Result_Values[4].ActualValue,
                };
                var result = products.Sum();
                m_ProductsCommercialExpenses_Values = new List<double>(products) { result };
                return m_ProductsCommercialExpenses_Values;
            }
        }

        public List<double> ProductsCostOfIndirectExpenses_Values
        {
            get
            {
                if (m_ProductsCostOfIndirectExpenses_Values != null)
                    return m_ProductsCostOfIndirectExpenses_Values;

                var products = new List<double> {
                    ProductsGeneralProductionExpences_Values[0] + ProductsGeneralBusinessExpenses_Values[0] + ProductsCommercialExpenses_Values[0],
                    ProductsGeneralProductionExpences_Values[1] + ProductsGeneralBusinessExpenses_Values[1] + ProductsCommercialExpenses_Values[1],
                };
                var result = products.Sum();
                m_ProductsCostOfIndirectExpenses_Values = new List<double>(products) { result };
                return m_ProductsCostOfIndirectExpenses_Values;
            }
        }

        public double TZRRate
        {
            get
            {
                if (m_TZRRate.HasValue)
                    return m_TZRRate.Value;

                m_TZRRate = (800 / (800 + ProductsMaterialCosts_Values[2])) * 100;

                return m_TZRRate.Value;
            }
        }

        public double OPRRate
        {
            get
            {
                if (m_OPRRate.HasValue)
                    return m_OPRRate.Value;

                m_OPRRate = m_Table9_Data.Result_Values[4].ActualValue / ProductsCostPriceForDirectExpenses_Values[2];

                return m_OPRRate.Value;
            }
        }
    }
}
