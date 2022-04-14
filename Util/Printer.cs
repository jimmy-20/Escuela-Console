using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void Linea(int size = 20){
            string linea = "";


            // for (int i = 0; i < size; i++)
            // {
            //     linea += "=";
            // }
            WriteLine(linea.PadLeft(size,'='));
        }

        public static void EscribirTitulo(string titulo){
            Linea();
            WriteLine("\t"+titulo);
            Linea();
        }
    }
}