using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;



namespace vallalat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Dolgozo dolgozo = new Dolgozo(1, "Kata", "asd");
              Cegvezeto cegvezeto = new Cegvezeto(2, "Petya", "qwe");
              Console.WriteLine(dolgozo.ToString());
              // Console.WriteLine(cegvezeto.GetType());
              dolgozo.dolgozik();
              cegvezeto.dolgozik(); */
            int bid = 0;
            //BEJELENTKEZÉSI ADATOK BEOLVASÁSA
            List<Dolgozo> dolgozok = new List<Dolgozo>();
            using (StreamReader stream = new StreamReader(new FileStream("dolgozo.txt", FileMode.Open)))
            {
                while (!stream.EndOfStream)
                {
                    string sor = stream.ReadLine();
                    string[] elemek = sor.Split(':');
                    int id = Int32.Parse(elemek[0]);
                    string nev = elemek[1];
                    string jelszo = elemek[2];
                    bool IsBoss = Convert.ToBoolean(Int32.Parse(elemek[3]));
                    //Console.WriteLine("{0} {1} {2} {3}", id, nev, jelszo, IsBoss);
                    if (IsBoss == true)
                    {
                        dolgozok.Add(new Cegvezeto(id, nev, jelszo));
                    }
                    else
                    {
                        dolgozok.Add(new Dolgozo(id, nev, jelszo));
                    }



                }

            }
            Console.Clear();

            ///BEOLVASÁS VÉGE


           

            ///REGISZTRÁCIÓ
          
            string rnev = "";
            string rjelsz = "";
            string re = "";
            Console.WriteLine("Írd be, hogy .r, ha regisztrálni szeretnél, .b, ha bejelentkezni");
            re = Console.ReadLine();

            if (re==".r")
            {
                Console.WriteLine(("Örülök ") + ("hogy regisztrálni szeretnél. Írd be a felhasznló neved, majd a jelszavadat"));
                rnev = Console.ReadLine();
                rjelsz = Console.ReadLine();
                Random rnd = new Random();
                int valami = rnd.Next(100000);

                using (StreamWriter stream = new StreamWriter(new FileStream("dolgozo.txt", FileMode.Append)))
                {
                    stream.WriteLine((valami) + (":") + (rnev) + (":") + (rjelsz) + (":0") );
                }


            }

            ///BEJELENTKEZÉS
            if(re==".b")
            {
                string bnev = "";
                string bjelsz = "";
                bool JoE = false;
                Console.Write("Felhasználónév: ");
                bnev = Console.ReadLine();
                Console.Write("Jelszó: ");
                bjelsz = Console.ReadLine();
                string cv = "";
                

                foreach (Dolgozo emberke in dolgozok)
                {

                    if (emberke.Nev == bnev && emberke.Jelszo == bjelsz)
                    {
                        JoE = true;

                        if (emberke is Cegvezeto)
                        {
                            cv = bnev + " bejelentkezett cégvezetőként";
                            bid = emberke.DolgozoId;
                        }
                        else
                        {
                            cv = bnev + " bejelentkezett dolgozóként";
                            bid = emberke.DolgozoId;
                        }
                    }
                }

                Console.Clear();
                if (JoE)
                {
                    Console.WriteLine("Sikeres bejelentkezés");
                    Console.WriteLine(cv);
                    
                }
                else
                {
                    Console.WriteLine("Sikertelen bejelentkezés, kérjük próbálkozz mégegyszer");
                    



                }
            }
            ///BEJELENTKEZÉS VÉGE

            //PROJEKTEK BEOLVASÁSA

            List<Projekt2> projektek2 = new List<Projekt2>();
            using (StreamReader stream = new StreamReader(new FileStream(@"E:\asztal\InfóTábor\Petin\vallalat\vallalat\tagsag.txt", FileMode.Open)))
            {
                while(!stream.EndOfStream)
                {
                    string p2sor = stream.ReadLine();
                    string[] p2elemek = p2sor.Split(':');
                    int pid2 = Int32.Parse(p2elemek[0]);
                    string pnev2 = p2elemek[1];
                    DateTime pkezd = DateTime.ParseExact(p2elemek[2], "yyyy.MM.dd", CultureInfo.CurrentCulture);
                    DateTime pbef  = DateTime.ParseExact(p2elemek[3], "yyyy.MM.dd", CultureInfo.CurrentCulture);
                    projektek2.Add(new Projekt2(pid2, pnev2, pkezd, pbef));
                    Console.WriteLine("{0} {1} {2} {3}", pid2, pnev2, pkezd, pbef);



                }
            }
            

                ///PROJEKTEK BEOLVASÁSÁNAK VÉGE


                //TAGSAGOK BEOLVASÁSA

                List<Projekt> projektek = new List<Projekt>();
            using (StreamReader stream = new StreamReader(new FileStream(@"E:\asztal\InfóTábor\Petin\vallalat\vallalat\projekt.txt", FileMode.Open)))
            {
                while(!stream.EndOfStream)
                {   
                    string psor = stream.ReadLine();
                    string[] pelemek = psor.Split(':');
                    int pid = Int32.Parse(pelemek[0]);
                    int pdolg = Int32.Parse(pelemek[1]);
                    bool IsPboss = Convert.ToBoolean(Int32.Parse(pelemek[2]));
                    if (IsPboss == true)
                    {
                        projektek.Add(new Projekt(pid, pdolg));
                    }
                    else
                    {
                        projektek.Add(new Projekt(pid, pdolg));

                        
                    }

            
                }
            }
            



            //TAGSAGOK BEOLVASÁSÁNAK VÉGE;

            //TAGSAGOK KEZELÉSE
        

            foreach (Projekt projekt in projektek)
            {
                if(projekt.Pdolg == bid)
                {
                    Console.WriteLine("Projektszám: ");
                    Console.WriteLine(projekt.ProjektId);
                }
            }
            
            //TAGSAGOK KEZELÉSÉNEK VÉGE










                Console.ReadKey();
        }
    }
}
