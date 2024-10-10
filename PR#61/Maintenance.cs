using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_61
{
    internal class Maintenance
    {

        private static Maintenance instance;
        private Maintenance() { }
        public static Maintenance GetInstance()
        {
            if (instance == null)
            {
                instance = new Maintenance();
            }
            return instance;
        }
        public void SurveillanceCamera()
        {
            Random random = new Random();
            int rand = random.Next(0, 3);
            switch (rand)
            {
                case 0:
                    MessageBox.Show("На видео видно как вы съели кусок телефона!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 1:
                    MessageBox.Show("ОГО, Вы видели это??! Что это там за ходячий телефизор? У него буквально есть ноги и руки!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 2:
                    MessageBox.Show("Тот парень очень подазрительно идет к выходу? Может это он наш варишка?", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
        }
        public void ConsultantInTheStoreComputer()
        {
            Random random = new Random();
            int rand = random.Next(0, 3);
            switch (rand)
            {
                case 0:
                    MessageBox.Show("Ваш экран сделан из мармелада!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 1:
                    MessageBox.Show("Кажется у вас на компьютаре много видео с котиками! Вот она причина не работающего компьютера!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 2:
                    MessageBox.Show("О, боже! Вы что никогда не убирали пыль? У вас теперь тут друг из пыли и грязи!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
        }
        public void ConsultantInTheStoreHeadphones()
        {
            Random random = new Random();
            int rand = random.Next(0, 2);
            switch (rand)
            {
                case 0:
                    MessageBox.Show("Очень странно, ваши наушники играют только Барбарики!", "Случайное сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 1:
                    MessageBox.Show("Это не наушники! Это беруши для сна с веревкой! Что вы принесли?", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
        }

        public void ConsultantInTheStoreHeadphonesPrinter()
        {
            Random random = new Random();
            int rand = random.Next(0, 2);
            switch (rand)
            {
                case 0:
                    MessageBox.Show("Ваш принтер не работает, потому что там застрал чей-то вонючий носок!", "Случайное сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 1:
                    MessageBox.Show("Этот принтер старее чем моя пра-пра-пра сколько-то раз прабабушка!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;

            }
        }
    }
}
