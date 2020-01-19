#include<iostream>

using namespace std;

int main(){
    setlocale(LC_ALL, "Russian");
    int a, b, c;
	int pos, neg;
	pos = neg = 0;

    cout<< "¬ведите 3 числа" << endl;
    cin >> a >> b >> c;

    if (a > 0)
		pos++;
	else if(a < 0)
	   neg++;

	if (b > 0)
		pos++;
	else if(b < 0)
	   neg++;

	if (c > 0)
		pos++;
    else if(c < 0)
	   neg++;

	cout<<"Positive:"<<pos<<"\nNegative:"<<neg<<endl;
	return 0;


}
