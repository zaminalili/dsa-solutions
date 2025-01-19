#include <iostream>
#include <vector>
using namespace std;


vector<int> plusOne(vector<int>& digits) {

    for (int i = digits.size()-1; i >= 0; i--)
    {
        int sum = digits[i] + 1;

        if(sum<10){
            digits[i] = sum;
            break;
        }
        
        digits[i] = sum%10;

        if(i==0){
            digits[i] = 1;
            digits.push_back(0);
        }
    }

    return digits;
}


int main() 
{
    vector<int> digits = {9};

     plusOne(digits);

    for (int i = 0; i < digits.size(); i++)
    {
        cout << "Digits: " << digits[i] << endl;
    }
    
    return 0;
}