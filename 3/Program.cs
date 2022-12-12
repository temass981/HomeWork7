
int [,] array1 = Array(4,4);
ArrayOutput(array1);
System.Console.WriteLine();
int [] aarr = AvgArrayColumn(array1);
Console.WriteLine(String.Join(" ", aarr));


int [,] Array(int m, int n){
    int [,] result = new int [m,n];
    for(int i =0; i<result.GetLength(0); i++){
        for (int j=0; j<result.GetLength(1); j++){
            result [i,j] = new Random().Next(0,10);
        }
    }
    return result;
}

void ArrayOutput(int [,] array){
    for(int i =0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            
            System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
}
int [] AvgArrayColumn(int [,] array){
    int [] avg = new int [array.GetLength(1)];
    int sum =0;
    
    for(int i =0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            sum += array[j,i];
           
        }
        avg [i] = sum/array.GetLength(0);
        sum =0;
        
    }
    return avg;
}
