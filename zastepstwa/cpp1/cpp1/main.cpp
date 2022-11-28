#include <iostream>
#include <fstream>
#include <ctime>
#include <cstdlib>

using namespace std;
void generTab(int tab[],int size){
    for(int i=0; i<size;i++){
        tab[i] = rand()%100;
    }
}

int main()
{
    srand(time(0));
    const int ROZM = 20;
    int t1[ROZM];
    generTab(t1,ROZM);
    for(int i=0;i<ROZM;i++){
        cout << t1[i]<<" ";
    }
    std::cout << "\nHello world! new" << std::endl;
    return 0;
}

