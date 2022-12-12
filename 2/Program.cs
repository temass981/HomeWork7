System.Console.WriteLine("Введите количество строк массива");
int a =int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов в массиве");
int b =int.Parse(Console.ReadLine());
int [,] array1 = Array(a,b);
ArrayOutput(array1);
Compar(array1);
int [,] Array(int m, int n){
    int [,] result = new int [m,n];
    for(int i =0; i<result.GetLength(0); i++){
        for (int j=0; j<result.GetLength(1); j++){
            result [i,j] = new Random().Next(0,100);
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
void Compar(int [,] array){
    System.Console.WriteLine("Введите первый индекс массива");
    int c =int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите второй индекс массива");
    int k =int.Parse(Console.ReadLine());
    string res ="Такого элемента не существует";
    for(int i =0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
           if (i==c && j==k) res = "Элемент массива = "+ array[i,j];
        }
    }
    System.Console.WriteLine(res);
    
}