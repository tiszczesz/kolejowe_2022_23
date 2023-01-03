#include <iostream>

using namespace std;
int FindMin(int t[],int size){
    int index = 0;
    if(size<=0) return -9999;
    int min = t[0];
    for(int i=0;i<size;i++){
        if(t[i]<min){
            min = t[i];
            index = i;
        }
    }
    return index;
}
int main()
{
    int a[] = {12,7,9,89,56,34,12,78,21,34};
    cout << "Najmniejsza wartosc tablicy: "<<FindMin(a,10) << endl;
    return 0;
}
