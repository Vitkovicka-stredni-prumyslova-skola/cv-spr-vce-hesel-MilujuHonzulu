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


        int DelkaHesla(){
            return 0;
            






        }



    }





}