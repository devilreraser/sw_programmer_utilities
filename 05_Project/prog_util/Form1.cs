namespace prog_util
{
    public partial class Form1 : Form
    {
        private const string input =
        @"№
Параметър
Пояснение
MODBUS
адрес Диапазон
Заводска
настройка
o.00
PV-in [V=]
Напрежение на PV входа на честотния конвертор
0x0C00
—
[V=]
0
o.01
PV-in [A=]
Tок консумиран от PV входа на честотния конвертор
0x0C01
—
[A=]
0.0
o.02
PV-in [W]
Мощност, консумирана от PV входа на честотния конвертор
0x0C02
—
[W]
0
o.03
AC-in [V~]
Линейно напрежение на AC входа на честотният конвертор
0x0C03
—
[V~]
0
o.04
AC-in [A~]
Фазов ток на AC входа на честотния конвертор
0x0C04
—
[A~]
0.0
o.05
AC-in [W]
Активна мощност, консумирана от AC източника
0x0C05
—
[W]
0
o.06
DC-link[V=]
Напрежение на DC-link кондензаторната група
0x0C06
—
[V=]
0
o.07
DC-link[А=]
Ток към междинното DC-звено
0x0C07
—
[А=]
0.0
o.08
AC-out [V~]
Линейно напрежение на изхода на честотният конвертор
0x0C08
—
[V~]
0.0
o.09
AC-out [A~]
Усреднен фазов ток на изхода на честотният конвертор
0x0C09
—
[A~]
0.0
o.10
AC-outU[A~]
Ток на изхода на инвертора – фаза ‘U’
0x0C0A
—
[A~]
0.0
o.11
AC-outV[A~]
Ток на изхода на инвертора – фаза ‘V’
0x0C0B
—
[A~]
0.0
o.12
AC-outW[A~]
Ток на изхода на инвертора – фаза ‘W’
0x0C0C
—
[A~]
0.0
o.13
AC-out [W]
Активна изходна мощност на честотният конвертор
0x0C0D
—
[W]
0
o.14
OutFreq[Hz]
Изходна честота на честотният конвертор
0x0C0E
—
[Hz]
0.0
o.15
PowerFactor
Фактор на мощността на изхода
0x0C0F
—
—
0.000
o.16
Press [Bar]
Налягане на помпата (вход от сензор за налягане)
0x0C10
—
[Bar]
0.00
o.17
Litres/min
Дебит на помпата (вход от сензор за поток)
0x0C11
—
[lt/min]
0
o.18
NTC_HS [°C]
Температура на охладителя на силовия блок
0x0C12
—
[°C]
0.0
o.19
ON minutes
Общо минути работа на помпата
0x0C13
—
[min]
0
o.20
PV-in [kWh]
Обща консумирана енергия от фотоволтаичният (PV) източник
0x0C14
—
[kWh]
0.000
o.21
AC-in [kWh]
Обща консумирана енергия от променливотоковият (AC) източник
0x0C15
—
[kWh]
0.000
o.22
AC-out[kWh]
Обща активна изходна енергия
0x0C16
—
[kWh]
0.000
o.23
PumpOut[m3]
Общо количество изпомпена вода
0x0C17
—
[m3]
0.000";

        public Form1()
        {
            InitializeComponent();
            inputText.Text = input;
            columnsTextToTableToolStripMenuItem.Text = "7";
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] cells = inputText.Text.Split('\n');
            string output = "";
            int cols = int.Parse(columnsTextToTableToolStripMenuItem.Text);
            if (cols == 0)
            {
                cols = 1;
            }

            int[] maxlenght = new int[cols];

            for (int i = 0; i < cells.Length; i += cols)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i + j < cells.Length)
                    {
                        if (maxlenght[j] < cells[i + j].Trim().Length)
                        {
                            maxlenght[j] = cells[i + j].Trim().Length;
                        }
                    }
                }
            }


            for (int i = 0; i < cells.Length; i += cols)
            {
                string line = "";
                for (int j = 0; j < cols; j++)
                {
                    if (i + j < cells.Length)
                    {
                        line = line + cells[i + j].Trim().PadRight(maxlenght[j]) + "    ";
                    }
                }
                output += line + "\r\n";
            }
            outputText.Text = output;

        }
    }
}