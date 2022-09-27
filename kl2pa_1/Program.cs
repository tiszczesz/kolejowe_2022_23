Console.Write("Podaj rozmiar tablicy: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = GenerRandom(size);
ShowArray(numbers);
int[] GenerRandom(int size){
    Random rnd = new Random();
    int[] result = new int[size];
    for(int i=0;i<size;i++){
        result[i] = rnd.Next(0,100);
    }
    return result;
}
void ShowArray(int[] data){
    foreach(int elem in data){
        Console.Write(elem+" ");
    }
}
//zwraca indeks znalezionego elementu lub -1 jak go brak
