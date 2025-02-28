using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public class BaseData
    {
        public double ProductA_SalesVolume { get; set; }
        public double ProductB_SalesVolume { get; set; }
        public double ProductA_SellingPrice { get; set; }
        public double ProductB_SellingPrice { get; set; }
        public double ProductA_PaymentUponDeliveryDuringTheShipmentPeriod { get; set; }
        public double ProductA_PaymentUponDeliveryDuringPeriodFollowingTheShipmentPeriod { get; set; }
        public double ProductB_PaymentUponDeliveryDuringTheShipmentPeriod { get; set; }
        public double ProductB_PaymentUponDeliveryDuringPeriodFollowingTheShipmentPeriod { get; set; }
        public double ProductA_BalanceAtTheBeginningOfTheYear { get; set; }
        public double ProductB_BalanceAtTheBeginningOfTheYear { get; set; }
        public double ProductA_InventoryPolicy { get; set; }
        public double ProductB_InventoryPolicy { get; set; }
        public double ProductA_Material1ConsumptionRate { get; set; }
        public double ProductB_Material1ConsumptionRate { get; set; }
        public double ProductA_Worker1ConsumptionRate { get; set; }
        public double ProductB_Worker1ConsumptionRate { get; set; }
        public double PurchasePrice { get; set; }
        public double HourlyWageRate { get; set; }
        public double StockPolicyForMaterial1 { get; set; }
        public double SupplierRelationshipPolicy1 { get; set; }
        public double AtTheEndOfTheQuarterTheStockOfTheRequirementsOfTheNextPeriod { get; set; }
        public double PaymentInTheDeliveryPeriod { get; set; }
        public double PaymentInThePeriodFollowingTheDeliveryPeriod { get; set; }
        public double SSFContributions { get; set; }
        public double ElectricityForIndustrialPurposes { get; set; }
        public double TelephoneInternet { get; set; }
        public double DepreciationOfProductionEquipment { get; set; }
        public double ElectricityForGeneralEconomicPurposes { get; set; }
        public double ZP_AUP_Production { get; set; }
        public double TravelExpenses { get; set; }
        public double Advertising { get; set; }
        public double PackagingCosts { get; set; }
        public double IncomeTax { get; set; }
        public double ProductA_PlannedCost { get; set; }
        public double ProductB_PlannedCost { get; set; }
        public double BalanceAtTheBeginningOfTheYearMaterial1 { get; set; }
        public double TZR { get; set; }
        public double ZP_AUP { get; set; }
        public double CashBalanceAtTheBeginning { get; set; }
    }
}
