#include <iostream>
#include <string>
using namespace std;

void SortStrings(string t[],int size){
    //todo

}
int main()
{
    string words[] = {"ala","monika","edyta","halina","elzbieta","renata"};
    for(auto a : words){
        cout << a << endl;
    }
    SortStrings(words,6);
     for(auto a : words){
        cout << a << endl;
    }
    cout << " ----------------------------------------- "<<endl;
    if(words[0]>words[1]){
        cout << words[0] << endl;
    }else{
        cout << words[1] << endl;
    }
    return 0;
}
