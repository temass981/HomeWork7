
double [,] array1 = Array(5,5);
ArrayOutput(array1);
double [,] Array(int m, int n){
    double [,] result = new double [m,n];
    for(int i =0; i<result.GetLength(0); i++){
        for (int j=0; j<result.GetLength(1); j++){
            result [i,j] = new Random().NextDouble() * 20.0+30.0;
        }
    }
    return result;
}

void ArrayOutput(double [,] array){
    for(int i =0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            System.Console.Write($"{array[i,j]:f2} ");
        }
        System.Console.WriteLine();
    }
}

