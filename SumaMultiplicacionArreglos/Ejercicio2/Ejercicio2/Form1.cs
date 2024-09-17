using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        //Arreglos para la lista de asientos
        private bool[] smokingSeats = new bool[5]; //asientos del 1 al 5
        private bool[] nonsmokingSeats = new bool[5]; //asientos del 6 al 10
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSmoking_Click(object sender, EventArgs e)
        {
        AssignSeat(true);

        }

        private void btnNonSmoking_Click(object sender, EventArgs e)
        {
            AssignSeat(false);
        }

        private int GetAvailableSeat(bool[] seats)
        {
            for (int i = 0; i < seats.Length; i++)
            {
                if (!seats[i])
                {
                    seats[i] = true; // Marcar como ocupado
                    return i;
                }
            }
            return -1; // No hay asientos disponibles
        }

        private void ShowBoardingPass(int seatNumber, bool isSmoking)
        {
            string section = isSmoking ? "smoking" : "nonsmoking";
            MessageBox.Show($"Pase de abordaje: Asiento {seatNumber} - Sección {section}");
        }

        private void AssignSeat(bool isSmoking)
        {
            int seatNumber = -1;

            // Verificar disponibilidad en la seccion correspondiente
            if (isSmoking)
            {
                seatNumber = GetAvailableSeat(smokingSeats);
                if (seatNumber == -1)
                {
                    // Seccion de fumar llena, ofrecer cambio
                    if (MessageBox.Show("La sección de fumar está llena. ¿Desea ser ubicado en la sección de no fumar?", "Sección llena", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        seatNumber = GetAvailableSeat(nonsmokingSeats);
                        if (seatNumber != -1)
                        {
                            ShowBoardingPass(seatNumber + 5, false);
                        }
                        else
                        {
                            MessageBox.Show("Next flight leaves in 3 hours.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Next flight leaves in 3 hours.");
                    }
                }
                else
                {
                    ShowBoardingPass(seatNumber + 1, true);
                }
            }
            else
            {
                seatNumber = GetAvailableSeat(nonsmokingSeats);
                if (seatNumber == -1)
                {
                    // Sección de no fumar llena, ofrecer cambio
                    if (MessageBox.Show("La sección de no fumar está llena. ¿Desea ser ubicado en la sección de fumar?", "Sección llena", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        seatNumber = GetAvailableSeat(smokingSeats);
                        if (seatNumber != -1)
                        {
                            ShowBoardingPass(seatNumber + 1, true);
                        }
                        else
                        {
                            MessageBox.Show("Next flight leaves in 3 hours.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Next flight leaves in 3 hours.");
                    }
                }
                else
                {
                    ShowBoardingPass(seatNumber + 6, false);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
