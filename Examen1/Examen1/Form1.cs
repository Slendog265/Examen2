using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            int ventas, devtas, RebVtas, totalDedud, vtasNet, renOffi,  com, srvtele, 
                suldG, gasCom, invIni, compTo, devComp, 
                rebC, totalDedcomp, compNet, mercDispvta, invFinal, costoVta, utiOp, comVend, Publi, rentTie, teleTie, empprod, totGasVta, pape, alqui, totalGtAdm, totGtop, utiBrut, otroPro, otroG, totOtPr, utiImp, utiNeta;
            ventas = int.Parse(vtas.Text);
            invIni = int.Parse(invIn.Text);
            devtas = int.Parse(deVtas.Text);
            gasCom = int.Parse(gastCom.Text);
            renOffi = int.Parse(rentOfi.Text);
            suldG = int.Parse(suelGer.Text);
            Publi = int.Parse(publi.Text);
            com = int.Parse(Comp.Text);
            invFinal = int.Parse(invFin.Text);
            devComp = int.Parse(devCom.Text);
            rentTie = int.Parse(rentTiend.Text);
            comVend = int.Parse(comVen.Text);
            srvtele = int.Parse(srvTele.Text);
            empprod = int.Parse(empProd.Text);
            otroPro = int.Parse(oGastos.Text);
            otroG = int.Parse(oGastos.Text);

            totalDedud = ventas - devtas;
            vtasNet = ventas - totalDedud;
            compTo = com - gasCom;
            totalDedud = devtas;
            compNet = compTo - totalDedud;
            mercDispvta = invIni - compNet;
            costoVta = mercDispvta - invFinal;
            utiBrut = vtasNet - comVend;
            totGasVta = comVend - Publi - rentTie - empprod;






            

            
            
           


        }
    }
}
