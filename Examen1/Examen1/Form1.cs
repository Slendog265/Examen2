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
            double Imp;
            int ventas, devtas, RebVtas, totalDedud, vtasNet, renOffi,  com, srvtele, 
                suldG, gasCom, invIni, compTo, devComp, papel, 
                rebC, totalDedcomp, compNet, mercDispvta, utiAimp, invFinal, costoVta, utiOp, comVend, Publi, rentTie, teleTie, empprod, totGasVta, totalGtAdm, totGtop, utiBrut, otroPro, otroG, totOtPr,totOtG, totOtPr1, utiImp, utiNeta;
            ventas = int.Parse(vtas.Text);
            invIni = int.Parse(invIn.Text);
            RebVtas = int.Parse(Rebvt.Text);
            rebC = int.Parse(rebComp.Text);
            devtas = int.Parse(deVtas.Text);
            gasCom = int.Parse(gastCom.Text);
            renOffi = int.Parse(rentOfi.Text);
            suldG = int.Parse(suelGer.Text);
            Publi = int.Parse(publi.Text);
            com = int.Parse(Comp.Text);
            papel = int.Parse(Paper.Text);
            invFinal = int.Parse(invFin.Text);
            devComp = int.Parse(devCom.Text);
            rentTie = int.Parse(rentTiend.Text);
            comVend = int.Parse(comVen.Text);
            srvtele = int.Parse(srvTele.Text);
            empprod = int.Parse(empProd.Text);
            otroPro = int.Parse(oProd.Text);
            otroG = int.Parse(oGastos.Text);

            totalDedud = devtas + RebVtas;
            vtasNet = ventas - totalDedud;
            compTo = com + gasCom;
            totalDedcomp = devComp + rebC;
            compNet = compTo - totalDedcomp;
            mercDispvta = invIni + compNet;
            costoVta = mercDispvta - invFinal;
            utiBrut = vtasNet - costoVta;
            totGasVta = comVend + Publi + rentTie +srvtele + empprod;
            totalGtAdm = suldG + papel + renOffi;
            totGtop = totGasVta + totalGtAdm;
            utiOp = utiBrut - totGtop;
            totOtPr = otroPro;
            totOtG = otroG;
            totOtPr1 = totOtPr - totOtG;
            utiAimp = utiOp + totOtPr1;
            Imp = utiAimp * 0.3;
            utiNeta= (int)(utiAimp - Imp);

            









            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = ventas;
            dataGridView1.Rows[n].Cells[1].Value = RebVtas;
            dataGridView1.Rows[n].Cells[2].Value = devtas;
            dataGridView1.Rows[n].Cells[3].Value = totalDedud;
            dataGridView1.Rows[n].Cells[4].Value = vtasNet;
            dataGridView1.Rows[n].Cells[5].Value = invIni;
            dataGridView1.Rows[n].Cells[6].Value = com;
            dataGridView1.Rows[n].Cells[7].Value = gasCom;
            dataGridView1.Rows[n].Cells[8].Value = compTo;
            dataGridView1.Rows[n].Cells[9].Value = devComp;
            dataGridView1.Rows[n].Cells[10].Value = rebC;
            dataGridView1.Rows[n].Cells[11].Value = totalDedcomp;
            dataGridView1.Rows[n].Cells[12].Value = compNet;
            dataGridView1.Rows[n].Cells[13].Value = mercDispvta;
            dataGridView1.Rows[n].Cells[14].Value = invFinal;
            dataGridView1.Rows[n].Cells[15].Value = costoVta;
            dataGridView1.Rows[n].Cells[16].Value = utiBrut;
            dataGridView1.Rows[n].Cells[17].Value = totGasVta;
            dataGridView1.Rows[n].Cells[18].Value = totalGtAdm;
            dataGridView1.Rows[n].Cells[19].Value = totGtop;
            dataGridView1.Rows[n].Cells[20].Value = utiOp;
            dataGridView1.Rows[n].Cells[21].Value = totOtPr;
            dataGridView1.Rows[n].Cells[22].Value = totOtG;
            dataGridView1.Rows[n].Cells[23].Value = totOtPr1;
            dataGridView1.Rows[n].Cells[24].Value = utiAimp;
            dataGridView1.Rows[n].Cells[25].Value = Imp;
            dataGridView1.Rows[n].Cells[26].Value = utiNeta;
           
            



        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
