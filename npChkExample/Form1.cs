using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using npChkExample.ServiceFNS;

namespace npChkExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void bntCheckOne_Click(object sender, EventArgs e)
        {
            var s = new NdsRequest2NP{
                INN = "7536134094",
                KPP = "753601001",
                DT  = "03.10.2015"
            };

            NdsRequest2NP[] sList = { s };

            var s2 = new FNSNDSCAWS2_PortClient().NdsRequest2(sList);

            MessageBox.Show(s2.NP.First().State.ToString());
        }

        void btnCheckMulti_Click(object sender, EventArgs e)
        {
            var sList = new List<NdsRequest2NP> { };

            //Действующее ООО
            sList.Add(new NdsRequest2NP { INN = "7536134094", KPP = "", DT = "" });
            //Закрытое ИП
            sList.Add(new NdsRequest2NP { INN = "753609794807", KPP = "", DT = "03.10.2015" });
            //Закрытое ООО
            sList.Add(new NdsRequest2NP { INN = "7536079799", KPP = "753601001", DT = "03.10.2015" });
            //Некоректное количество символов
            sList.Add(new NdsRequest2NP { INN = "751111", KPP = "", DT = "" });

            var s2 = new FNSNDSCAWS2_PortClient().NdsRequest2(sList.ToArray());

            foreach (var x in s2.NP)
            {
                MessageBox.Show("INN: " + x.INN + " State: " + x.State);
            }
        }
    }
}
