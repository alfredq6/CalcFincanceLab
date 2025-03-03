using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CalcFincanceLab
{
    public partial class Form1 : Form
    {
        private const string DATA_FILE_PATH = "./db_file.json";

        private List<(DataTable table, ITable_Data tableData)> DataTables = new List<(DataTable table, ITable_Data tableData)>();

        private BaseData m_BaseData = new BaseData();
        private Table1_Data Table1Data => new Table1_Data(m_BaseData);
        private Table2_Data Table2Data => new Table2_Data(Table1Data);
        private Table3_Data Table3Data => new Table3_Data(m_BaseData);
        private Table4_Data Table4Data => new Table4_Data(m_BaseData, Table3Data);
        private Table5_Data Table5Data => new Table5_Data(m_BaseData, Table4Data);
        private Table6_Data Table6Data => new Table6_Data(m_BaseData, Table5Data);
        private Table7_Data Table7Data => new Table7_Data(m_BaseData, Table4Data);
        private Table8_Data Table8Data => new Table8_Data(m_BaseData, Table7Data);
        private Table9_Data Table9Data => new Table9_Data(m_BaseData, Table8Data);
        private Table10_Data Table10Data => new Table10_Data(m_BaseData, Table8Data);
        private Table11_Data Table11Data => new Table11_Data(m_BaseData);
        private Table12_Data Table12Data => new Table12_Data(m_BaseData, Table4Data, Table5Data, Table7Data, Table9Data, Table10Data, Table11Data);
        private Table13_Data Table13Data => new Table13_Data(m_BaseData, Table1Data, Table7Data, Table10Data, Table11Data, Table12Data);
        private Table14_Data Table14Data => new Table14_Data(m_BaseData, Table2Data, Table6Data, Table8Data, Table10Data, Table13Data);
        private Table15_Data Table15Data => new Table15_Data(m_BaseData, Table3Data, Table4Data, Table5Data, Table6Data, Table9Data, Table12Data, Table13Data);

        public Form1()
        {
            InitBaseData();
            InitializeComponent();
            InitializeButtons();
            InitializeTabsAndTables();
        }

        private void InitBaseData()
        {
            if (!File.Exists(DATA_FILE_PATH))
            {
                using (var file = File.Create(DATA_FILE_PATH)) { }
            }
            var json = File.ReadAllText(DATA_FILE_PATH);
            if (!string.IsNullOrEmpty(json))
            {
                var data = JObject.Parse(json).ToObject<BaseData>();
                if (data != null) m_BaseData = data;
            }
        }

        private void InitializeButtons()
        {
            var panel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 30,
                BackColor = Color.WhiteSmoke
            };

            var saveBtn = InitializeSaveButton(panel);
            var recalcBtn = InitializeRecalculateButton(panel);

            saveBtn.Location = new Point(panel.Width - saveBtn.Width - 10, (panel.Height - saveBtn.Height) / 2);
            recalcBtn.Location = new Point(saveBtn.Left - recalcBtn.Width - 10, (panel.Height - recalcBtn.Height) / 2);

            Controls.Add(panel);
        }

        private Button InitializeSaveButton(Panel panel)
        {
            var btn = new Button
            {
                Text = "Сохранить",
                Width = 120,
                Height = 30,
                Anchor = AnchorStyles.Right | AnchorStyles.Bottom
            };

            btn.Click += SaveButton_Click;

            panel.Controls.Add(btn);
            return btn;
        }

        private Button InitializeRecalculateButton(Panel panel)
        {
            var btn = new Button
            {
                Text = "Пересчитать",
                Width = 120,
                Height = 30,
                Anchor = AnchorStyles.Right | AnchorStyles.Bottom,
            };

            btn.Click += RecalculateButton_Click;

            panel.Controls.Add(btn);
            return btn;
        }

        private void InitializeTabsAndTables()
        {
            var tabControl = new TabControl
            {
                Dock = DockStyle.Fill,
                Multiline = true
            };
            Controls.Add(tabControl);

            AddTabWithTable(tabControl, "Исходные данные", CreateBaseDataTable(), DataGridView_CellValueChanged);
            AddTabWithTable(tabControl, "1. Бюджет продаж", CreateTable1());
            AddTabWithTable(tabControl, "2. График платежей за Готовую продукцию", CreateTable2());
            AddTabWithTable(tabControl, "3. Бюджет производства и запасов ГП", CreateTable3());
            AddTabWithTable(tabControl, "4. Бюджет потребности в Материале 1", CreateTable4());
            AddTabWithTable(tabControl, "5. Бюджет закупки Материала 1 у Поставщика 1", CreateTable5());
            AddTabWithTable(tabControl, "6. График платежей Поставщику 1 за Материал 1", CreateTable6());
            AddTabWithTable(tabControl, "7. Бюджет потребности в Рабочем 1", CreateTable7());
            AddTabWithTable(tabControl, "8. Бюджет расходов на оплату труда Рабочего 1", CreateTable8());
            AddTabWithTable(tabControl, "9. Бюджет общепроизводственных расходов", CreateTable9());
            AddTabWithTable(tabControl, "10. Бюджет общехозяйственных расходов", CreateTable10());
            AddTabWithTable(tabControl, "11. Бюджет коммерческих расходов", CreateTable11());
            AddTabWithTable(tabControl, "12. Бюджет себестоимости", CreateTable12());
            AddTabWithTable(tabControl, "13. Отчет о прибылях и убытках", CreateTable13());
            AddTabWithTable(tabControl, "14. Прогноз движения денежных средств", CreateTable14());
            AddTabWithTable(tabControl, "15. Баланс", CreateTable15());
        }

        private void AddTabWithTable(TabControl tabControl, string tabName, DataTable table, DataGridViewCellEventHandler cellChanged = null)
        {
            TabPage tabPage = new TabPage(tabName);
            tabControl.TabPages.Add(tabPage);

            DataGridView dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                DataSource = table,
                ColumnHeadersHeight = 60,
            };
            if (cellChanged != null) dataGridView.CellValueChanged += cellChanged;

            tabPage.Controls.Add(dataGridView);
        }

        private DataTable CreateBaseDataTable()
        {
            DataTable table = new DataTable("Исходные данные");

            // Добавляем столбцы
            table.Columns.Add(new DataColumn("Материал/услуга/ресурс", typeof(string)) { ReadOnly = true });
            table.Columns.Add(new DataColumn("Показатель", typeof(string)) { ReadOnly = true });
            table.Columns.Add(new DataColumn("Обозначение", typeof(string)) { ReadOnly = true });
            table.Columns.Add(new DataColumn("Ед.изм.", typeof(string)) { ReadOnly = true });
            table.Columns.Add("значение", typeof(int));
            table.Columns.Add(new DataColumn("коммент", typeof(string)) { ReadOnly = true });

            // Добавляем данные
            table.Rows.Add("Продукт А", "Объем продаж в натуральном выражении", "ОП", "шт", m_BaseData.ProductA_SalesVolume, "");
            table.Rows.Add("Продукт В", "Объем продаж в натуральном выражении", "ОП", "шт", m_BaseData.ProductB_SalesVolume, "");
            table.Rows.Add("Продукт А", "цена реализации", "Ц", "руб.", m_BaseData.ProductA_SellingPrice, "");
            table.Rows.Add("Продукт В", "цена реализации", "Ц", "руб.", m_BaseData.ProductB_SellingPrice, "");
            table.Rows.Add("Продукт А", "оплата по факту поставки в периоде отгрузки (Политика взаимоотношений с Покупателем 1)", "", "", m_BaseData.ProductA_PaymentUponDeliveryDuringTheShipmentPeriod, "оплата по факту поставки в периоде отгрузки");
            table.Rows.Add("Продукт А", "оплата по факту поставки в периоде, следующем за периодом отгрузки (Политика взаимоотношений с Покупателем 1)", "", "", m_BaseData.ProductA_PaymentUponDeliveryDuringPeriodFollowingTheShipmentPeriod, "оплата по факту поставки в периоде, следующем за периодом отгрузки");
            table.Rows.Add("Продукт B", "оплата по факту поставки в периоде отгрузки (Политика взаимоотношений с Покупателем 1)", "", "", m_BaseData.ProductB_PaymentUponDeliveryDuringTheShipmentPeriod, "оплата по факту поставки в периоде отгрузки");
            table.Rows.Add("Продукт B", "оплата по факту поставки в периоде, следующем за периодом отгрузки (Политика взаимоотношений с Покупателем 1)", "", "", m_BaseData.ProductB_PaymentUponDeliveryDuringPeriodFollowingTheShipmentPeriod, "оплата по факту поставки в периоде, следующем за периодом отгрузки");
            table.Rows.Add("Продукт А", "Остаток на начало года по Продукту А", "", "шт.", m_BaseData.ProductA_BalanceAtTheBeginningOfTheYear, "");
            table.Rows.Add("Продукт В", "Остаток на начало года по Продукту В", "", "шт.", m_BaseData.ProductB_BalanceAtTheBeginningOfTheYear, "");
            table.Rows.Add("Продукт А", "Политика запасов по Продукту А", "", "%", m_BaseData.ProductA_InventoryPolicy, "на конец периода (квартал) запас от потребностей следующего периода");
            table.Rows.Add("Продукт В", "Политика запасов по Продукту В", "", "%", m_BaseData.ProductB_InventoryPolicy, "на конец периода (квартал) запас от потребностей следующего периода");
            table.Rows.Add("Продукт А", "норма расхода материал 1", "М1", "м.", m_BaseData.ProductA_Material1ConsumptionRate, "");
            table.Rows.Add("Продукт А", "норма расхода рабочий 1", "Р1", "чел-ч.", m_BaseData.ProductA_Worker1ConsumptionRate, "");
            table.Rows.Add("Продукт В", "норма расхода материал 1", "М1", "м.", m_BaseData.ProductB_Material1ConsumptionRate, "");
            table.Rows.Add("Продукт В", "норма расхода рабочий 1", "Р1", "чел-ч.", m_BaseData.ProductB_Worker1ConsumptionRate, "");
            table.Rows.Add("Материал 1", "Цена закупки", "Цм", "руб.", m_BaseData.PurchasePrice, "");
            table.Rows.Add("Рабочий 1", "Часовая тарифная ставка", "ЧТС", "руб.", m_BaseData.HourlyWageRate, "");
            table.Rows.Add("Материал 1", "Политика запасов по материалу 1", "", "%", m_BaseData.AtTheEndOfTheQuarterTheStockOfTheRequirementsOfTheNextPeriod, "на конец периода (квартала) запас от потребностей следующего периода");
            table.Rows.Add("Материал 1", "оплата в периоде поставки (Политика взаимоотношений с Поставщиком 1)", "", "%", m_BaseData.PaymentInTheDeliveryPeriod, "оплата в периоде поставки");
            table.Rows.Add("Материал 1", "(оплата в периоде, следующем за периодом поставки) Политика взаимоотношений с Поставщиком 1", "", "%", m_BaseData.PaymentInThePeriodFollowingTheDeliveryPeriod, "оплата в периоде, следующем за периодом поставки");
            table.Rows.Add("", "Отчисления в ФСЗН", "", "%", m_BaseData.SSFContributions, "");
            table.Rows.Add("", "Электроэнергия на производственные цели", "", "руб.", m_BaseData.ElectricityForIndustrialPurposes, "");
            table.Rows.Add("", "Телефон, Интернет", "", "руб.", m_BaseData.TelephoneInternet, "");
            table.Rows.Add("", "Амортизация производственного оборудования", "", "руб.", m_BaseData.DepreciationOfProductionEquipment, "");
            table.Rows.Add("", "Электроэнергия на общехозяйственные цели", "", "руб.", m_BaseData.ElectricityForGeneralEconomicPurposes, "");
            table.Rows.Add("", "ЗП АУП производства", "", "руб.", m_BaseData.ZP_AUP_Production, "");
            table.Rows.Add("", "Командировочные расходы", "", "руб.", m_BaseData.TravelExpenses, "");
            table.Rows.Add("", "Реклама", "", "руб.", m_BaseData.Advertising, "");
            table.Rows.Add("", "Расходы на упаковку", "", "руб.", m_BaseData.PackagingCosts, "");
            table.Rows.Add("", "Налог на прибыль", "", "%", m_BaseData.IncomeTax, "");
            table.Rows.Add("", "Плановая (нормативная) себестоимость Продукта А", "", "руб.", m_BaseData.ProductA_PlannedCost, "");
            table.Rows.Add("", "Плановая (нормативная) себестоимость Продукта В", "", "руб.", m_BaseData.ProductB_PlannedCost, "");
            table.Rows.Add("", "Остаток на начало года Материала 1", "", "м.", m_BaseData.BalanceAtTheBeginningOfTheYearMaterial1, "");
            table.Rows.Add("", "ТЗР, норматив в квартал", "", "руб.", m_BaseData.TZR, "");
            table.Rows.Add("", "ЗП АУП", "", "руб.", m_BaseData.ZP_AUP, "");
            table.Rows.Add("", "Остаток денежных средств на начало", "", "руб.", m_BaseData.CashBalanceAtTheBeginning, "");

            return table;
        }

        private DataTable CreateTable1()
        {
            var table = new DataTable("Бюджет продаж");
            DataTables.Add((table, Table1Data));

            AddQuartersAndYearColumns(table);

            foreach (var rowData in Table1Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable2()
        {
            var table = new DataTable("График платежей за Готовую продукцию");
            DataTables.Add((table, Table2Data));

            AddQuartersAndYearColumns(table);

            foreach (var rowData in Table2Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable3()
        {
            var table = new DataTable("Бюджет производства и запасов ГП");
            DataTables.Add((table, Table3Data));

            AddQuartersAndYearColumns(table);

            foreach (var rowData in Table3Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable4()
        {
            var table = new DataTable("Бюджет потребности в Материале 1");
            DataTables.Add((table, Table4Data));

            AddQuartersAndYearColumns(table);

            foreach (var rowData in Table4Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable5()
        {
            var table = new DataTable("Бюджет закупки Материала 1 у Поставщика 1");
            DataTables.Add((table, Table5Data));

            AddQuartersAndYearColumns(table);

            foreach (var rowData in Table5Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable6()
        {
            var table = new DataTable("График платежей Поставщику 1 за Материал 1");
            DataTables.Add((table, Table6Data));

            AddQuartersAndYearColumns(table);

            foreach (var rowData in Table6Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable7()
        {
            var table = new DataTable("Бюджет потребности в Рабочем 1");
            DataTables.Add((table, Table7Data));

            AddQuartersAndYearColumns(table);

            foreach (var rowData in Table7Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable8()
        {
            var table = new DataTable("Бюджет расходов на оплату труда Рабочего 1");
            DataTables.Add((table, Table8Data));

            AddQuartersAndYearColumns(table);

            foreach (var rowData in Table8Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable9()
        {
            var table = new DataTable("Бюджет общепроизводственных расходов");
            DataTables.Add((table, Table9Data));

            AddQuartersAndYearColumns(table);

            foreach (var rowData in Table9Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable10()
        {
            var table = new DataTable("Бюджет общехозяйственных расходов");
            DataTables.Add((table, Table10Data));

            AddQuartersAndYearColumns(table);

            foreach (var rowData in Table10Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable11()
        {
            var table = new DataTable("Бюджет коммерческих расходов");
            DataTables.Add((table, Table11Data));

            AddQuartersAndYearColumns(table);

            foreach (var rowData in Table11Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable12()
        {
            var table = new DataTable("Бюджет себестоимости");
            DataTables.Add((table, Table12Data));

            table.Columns.Add(new DataColumn("статья затрат", typeof(string)) { ReadOnly = true });
            table.Columns.Add(new DataColumn("Продукт А", typeof(string)) { ReadOnly = true });
            table.Columns.Add(new DataColumn("Продукт В", typeof(string)) { ReadOnly = true });
            table.Columns.Add(new DataColumn("Итого", typeof(string)) { ReadOnly = true });

            foreach (var rowData in Table12Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable13()
        {
            var table = new DataTable("Отчет о прибылях и убытках");
            DataTables.Add((table, Table13Data));

            AddQuartersAndYearColumns(table);

            foreach (var rowData in Table13Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable14()
        {
            var table = new DataTable("Прогноз движения денежных средств");
            DataTables.Add((table, Table14Data));

            AddQuartersAndYearColumns(table);

            foreach (var rowData in Table14Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private DataTable CreateTable15()
        {
            var table = new DataTable("Баланс");
            DataTables.Add((table, Table15Data));

            table.Columns.Add(new DataColumn("Статья баланса", typeof(string)) { ReadOnly = true });
            table.Columns.Add(new DataColumn("Начало года", typeof(string)) { ReadOnly = true });
            table.Columns.Add(new DataColumn("Конец года", typeof(string)) { ReadOnly = true });

            foreach (var rowData in Table15Data.GetRows())
                table.Rows.Add(rowData);

            return table;
        }

        private void AddQuartersAndYearColumns(DataTable table)
        {
            table.Columns.Add(new DataColumn("Показатель", typeof(string)) { ReadOnly = true });
            for (int i = 1; i <= 4; i++)
            {
                table.Columns.Add(new DataColumn($"Квартал {i} план", typeof(string)) { ReadOnly = true });
                table.Columns.Add(new DataColumn($"Квартал {i} факт", typeof(string)) { ReadOnly = true });
                table.Columns.Add(new DataColumn($"Квартал {i} откл.", typeof(string)) { ReadOnly = true });
            }
            table.Columns.Add(new DataColumn("Год план", typeof(string)) { ReadOnly = true });
            table.Columns.Add(new DataColumn("Год факт", typeof(string)) { ReadOnly = true });
            table.Columns.Add(new DataColumn("Год откл.", typeof(string)) { ReadOnly = true });
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(DATA_FILE_PATH, JObject.FromObject(m_BaseData).ToString());
            MessageBox.Show("Данные сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RecalculateButton_Click(object sender, EventArgs e)
        {
            foreach (var dataTable in DataTables)
            {
                dataTable.tableData.ClearCachedData();
            }
            foreach (var dataTable in DataTables)
            {
                dataTable.table.Rows.Clear();
                foreach (var rowData in dataTable.tableData.GetRows())
                    dataTable.table.Rows.Add(rowData);
                dataTable.table.AcceptChanges();
            }

            MessageBox.Show("Данные обновлены!", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = sender as DataGridView;

            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                var newValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (int.TryParse(newValue?.ToString(), out var cellValue))
                {
                    switch (e.RowIndex)
                    {
                        case 0: m_BaseData.ProductA_SalesVolume = cellValue; break;
                        case 1: m_BaseData.ProductB_SalesVolume = cellValue; break;
                        case 2: m_BaseData.ProductA_SellingPrice = cellValue; break;
                        case 3: m_BaseData.ProductB_SellingPrice = cellValue; break;
                        case 4: m_BaseData.ProductA_PaymentUponDeliveryDuringTheShipmentPeriod = cellValue; break;
                        case 5: m_BaseData.ProductA_PaymentUponDeliveryDuringPeriodFollowingTheShipmentPeriod = cellValue; break;
                        case 6: m_BaseData.ProductB_PaymentUponDeliveryDuringTheShipmentPeriod = cellValue; break;
                        case 7: m_BaseData.ProductB_PaymentUponDeliveryDuringPeriodFollowingTheShipmentPeriod = cellValue; break;
                        case 8: m_BaseData.ProductA_BalanceAtTheBeginningOfTheYear = cellValue; break;
                        case 9: m_BaseData.ProductB_BalanceAtTheBeginningOfTheYear = cellValue; break;
                        case 10: m_BaseData.ProductA_InventoryPolicy = cellValue; break;
                        case 11: m_BaseData.ProductB_InventoryPolicy = cellValue; break;
                        case 12: m_BaseData.ProductA_Material1ConsumptionRate = cellValue; break;
                        case 13: m_BaseData.ProductA_Worker1ConsumptionRate = cellValue; break;
                        case 14: m_BaseData.ProductB_Material1ConsumptionRate = cellValue; break;
                        case 15: m_BaseData.ProductB_Worker1ConsumptionRate = cellValue; break;
                        case 16: m_BaseData.PurchasePrice = cellValue; break;
                        case 17: m_BaseData.HourlyWageRate = cellValue; break;
                        case 18: m_BaseData.AtTheEndOfTheQuarterTheStockOfTheRequirementsOfTheNextPeriod = cellValue; break;
                        case 19: m_BaseData.PaymentInTheDeliveryPeriod = cellValue; break;
                        case 20: m_BaseData.PaymentInThePeriodFollowingTheDeliveryPeriod = cellValue; break;
                        case 21: m_BaseData.SSFContributions = cellValue; break;
                        case 22: m_BaseData.ElectricityForIndustrialPurposes = cellValue; break;
                        case 23: m_BaseData.TelephoneInternet = cellValue; break;
                        case 24: m_BaseData.DepreciationOfProductionEquipment = cellValue; break;
                        case 25: m_BaseData.ElectricityForGeneralEconomicPurposes = cellValue; break;
                        case 26: m_BaseData.ZP_AUP_Production = cellValue; break;
                        case 27: m_BaseData.TravelExpenses = cellValue; break;
                        case 28: m_BaseData.Advertising = cellValue; break;
                        case 29: m_BaseData.PackagingCosts = cellValue; break;
                        case 30: m_BaseData.IncomeTax = cellValue; break;
                        case 31: m_BaseData.ProductA_PlannedCost = cellValue; break;
                        case 32: m_BaseData.ProductB_PlannedCost = cellValue; break;
                        case 33: m_BaseData.BalanceAtTheBeginningOfTheYearMaterial1 = cellValue; break;
                        case 34: m_BaseData.TZR = cellValue; break;
                        case 35: m_BaseData.ZP_AUP = cellValue; break;
                        case 36: m_BaseData.CashBalanceAtTheBeginning = cellValue; break;
                    }
                }
            }
        }
    }
}
