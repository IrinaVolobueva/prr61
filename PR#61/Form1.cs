using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_61
{
    public partial class Form1 : Form
    {
        Maintenance maintenance;
        public Form1()
        {
            InitializeComponent();
            maintenance = Maintenance.GetInstance();
        }

        private void Consultant_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Здравствуйте! Вы принесли принтер?", "Опрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) maintenance.ConsultantInTheStoreHeadphonesPrinter();
            else
            {
                DialogResult result2 = MessageBox.Show("Вы принести наушники? С ними что-то не так?", "Опрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result2 == DialogResult.Yes) maintenance.ConsultantInTheStoreHeadphones();
                else
                {
                    DialogResult result3 = MessageBox.Show("Ваш компьютер сломался?", "Опрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result3 == DialogResult.Yes) maintenance.ConsultantInTheStoreComputer();
                    else
                    {
                        MessageBox.Show("Давайте тогда в следующий раз!", "Опрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
        }

        private void Camera_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы ходите узнать что вчера произошло?", "Опрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) maintenance.SurveillanceCamera();
            else
            {
                DialogResult result2 = MessageBox.Show("Вам просто хочется узнать что происходит в зале?", "Опрос", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result2 == DialogResult.Yes) maintenance.SurveillanceCamera();
                else
                {
                    MessageBox.Show("Давайте в следующий раз!", "Опрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
