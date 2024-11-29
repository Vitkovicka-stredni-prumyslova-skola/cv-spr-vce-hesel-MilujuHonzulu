
namespace FirstApp
{
    public class kniha
    {
        public string Nazev
        {
               get{return Nazev;}
               set{this.Nazev = value;}
        }
        
        public string Autor
        {
               get{return Autor;}
               set{this.Autor = value;}
        }
        public int RokVydani
        {
               get{return RokVydani;}
               set{this.RokVydani = value;}
        }

               public kniha()
               {
                Nazev = "nezadano";
                Autor = "nezadano";
                RokVydani = 0;

               }

               public kniha(string nazev, string autor, int rokVydani)
               {
                Nazev = nazev;
                Autor = autor;
                RokVydani = rokVydani;
               }
               public static void VypisInformace()
               {
                
                Console.WriteLine();

               }
               //.

    }
    class EKniha : kniha
    {

        public double VelikostSouboru
        {

             get{return VelikostSouboru;}
             set{this.VelikostSouboru = value;}
        }

        public string Format
        {
            get{return Format;}
            set{this.Format = value;}

        }

        public EKniha(string nazev string autor, int rokVydani, double VelikostSouboru, string Format);






    }



               

     

        }




    }




}