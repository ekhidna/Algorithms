using Algorithms.JsonFile;
using Algorithms.Pattern;

namespace Algorithms {
    public class Program {
        static void Main(string[] args) {

            int[] intArray = {17, 39 , 78 , 324 , 43 , 33 , 234 , 99 , 34 , 555 , 39 , 78 , 324 , 43 , 45 , 92 };   //-> [39, 78, 324, 43]
            //int[] intArray = { 1, 3, 2, 1, 1, 3, 3, 4, 1, 3, 2, 1, 2, 1};                                           //-> [1, 3, 2, 1]
            //int[] intArray = { 6 , 2 , 6 , 8 , 22 , 0 , 9 , 5 , 8 , 22 , 0 , 9 , 8 , 1 , 2 , 4 , 5 , 6 , 7 };       //->  [8, 22, 0, 9]
            //int[] intArray = { 1 , 2 , 1 , 2 , 1 , 3 , 1 , 1 , 2 , 5 , 1 , 7 };                                     //-> [1,2] - Special case if I didn't have  i+z==j before the break it would return [1, 2, 1]
            //int[] intArray = { 0 , 20 , 3 , 5 , 0 , 20 , 0 , 0 , 0 , 20 , 3 , 5 , 0 , 20 , 0 , 0 , 0 };             //-> [0, 20, 3, 5, 0, 20, 0, 0]
            //int[] intArray = { 1 , 2 , 3 };                                                                         //-> []
            //int[] intArray = { 1 , 2 , 1 , 2 };                                                                     //-> [1,2] 
            //int[] intArray = { 1, 2, 1, 2, 1, 2, 1 };                                                               //-> [1, 2 1] 

            int[] result = FindConsecutiveNumbers.FindNumbers(intArray);
            Console.WriteLine(result);

            JsonCreateFile.WriteJsonToFile();
        }
    }
}