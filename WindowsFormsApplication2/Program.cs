using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Reversi
{
    class Reversi : Form
    {

        static void Main()
        {
            Application.Run(new Reversi());
        }

        // statusweergave

     
        public Reversi()
        {
            this.ClientSize = new Size (1000, 1000);
            this.Text = "Reversi";
            this.Paint += this.Status;

            //Buttons

            Button NG;
            NG = new Button();
            NG.Size = new Size (100, 40);
            NG.Location = new Point (50, 30);
            NG.Text = " Nieuw Spel";
       //     NG.MouseClick += methodenieuwspel;
            this.Controls.Add(NG);

            Button RS;
            RS = new Button();
            RS.Size = new Size (100,40);
            RS.Location = new Point(200, 30);
            RS.Text = " Reset";
         //   RS.MouseClick += methodeResetspel;
            this.Controls.Add(RS);

            Button HP;
            HP = new Button();
            HP.Size = new Size (100,40);
            HP.Location = new Point(350, 30);
            HP.Text = " Help";
          //  HP.MouseClick += methodeHelp;
            this.Controls.Add(HP);

        }

        void Status(object o, PaintEventArgs pea)
        {
            string stenenBlauw = "aantalBlauw " + "stenen";
            string stenenRood = "aantalRood " + "stenen";

            pea.Graphics.DrawString(stenenBlauw,
                                    new Font("Ariel", 10, FontStyle.Bold),
                                    Brushes.CadetBlue,
                                    80, 100);

            pea.Graphics.DrawString(stenenRood,
                        new Font("Ariel", 10, FontStyle.Bold),
                        Brushes.IndianRed,
                        80, 80);
        }

        /*
            int stenenRood = "methode aantal rode stenen";
            int stenenBlauw = "methode aantal blauwe stenen";
         *  turn = ??


            static string statusnu(string status)
            {   if (turn = Blauw)
                    return "Blauw is aan zet";
                if (turn = Rood)
                    return "Rood is aan zet";
                if (status = stenenBlauw > stenenRood)
                    return "Blauw heeft gewonnen!";
                if (status = stenenRood > stenenBlauw)
                    return "Rood heeft gewonnen!";
                if (status = stenenRood = stenenBlauw)
                    return "Remise";
            }
         */

            

        }
}
    
        

        //methode status

       

       // methode voor muisclick
  
    

     // methode om de zaak te resetten

    //methode om de help functie te activeren

    // methode om status te tonen

        

    //methode voor tekeken van de stenen 

    // methode voor het tekenen van het bord.

       


