namespace Algorithms.Pattern {
    public class FindConsecutiveNumbers {
        public static int[] FindNumbers(int[] intArray) {

            int i, j, z = 0, control = 0;
           
            int[] tempArray = new int[intArray.Length / 2 + 1];  //The final array can not be longer then half of the intArray
            int[] patternArray = Array.Empty<int>();

            for(i = 0; i < intArray.Length - 1; i++) {
                for(j = i + 1; j < intArray.Length - 1; j++) { //it will iterate through the array comparing the 1st item witn 2nd, 3rd... until it find equal | [i]; [j]=i+1
                    while(intArray[i] == intArray[j]) {        //if [i]==[j], proceed to: [i+1]=[j+1] to find pattern                        
                        tempArray[z] = intArray[j];
                        z++;
                        i++;
                        j++;
                        if((j >= intArray.Length) || (i + z == j))  // (i+z==j) needs to break on case { 1 , 2 , 1 , 2 , 1 , 3 , 1 , 1 , 2 , 5 , 1 , 7 }
                            break;
                    }
                    if(z != 0) {
                        if(control < z) { //after finding a pattern, control allows that only if the new found pattern is bigger then the previous will enter here and make a deep copy
                            control = z;
                            patternArray = (int[])tempArray.Clone();  //deep copy of tempArray to patternArray; 
                        }
                        Array.Clear(tempArray);
                        j -= z;
                        i -= z;
                        z = 0;
                    }
                }
            }
            return patternArray;
        }
    }
}
