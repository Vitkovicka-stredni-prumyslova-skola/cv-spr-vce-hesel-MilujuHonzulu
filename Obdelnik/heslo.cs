namespace Spravcehesel
{

    interface IHeslo
    {

       int DelkaHeslo();
       int MaxDelkaHesla();
       int MinDelkaHesla();


    }

    class Heslo: IHeslo
    {
        private string heslo;
        private static int maxDelkaHesla = 20;
        private static int minDelkaHesla = 8;




        String[] malaPismena  = [""]
        String[] velkaPismena = [""]
        String[] cisla = [""]
        string specialniZnaky = [""]
           
        public int DelkaHesla(){
            return 0;
        }
        public int MaxDelkaHesla (){
            return maxDelkaHesla;
        }
        public int MinDelkaHesla (){
            return minDelkaHesla;
        }

        public static void

    }





}