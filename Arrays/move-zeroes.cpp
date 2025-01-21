#include <iostream>
#include <vector>
using namespace std;

void moveZeroes(vector<int>& nums) {
    int i = 0;
    int j = 1;

    while (j < nums.size())
    {
        if(nums[i] == 0 && nums[j] != 0) {
            nums[i] = nums[j];
            nums[j] = 0;
            i++;
            j++;
        }
        else if(nums[i] != 0) {
            i++;
            j++;
        } else {
            j++;
        }
        // else if(nums[j] == 0)
    
    }
    

    for (int i = 0; i < nums.size(); i++)
    {
        cout << "num: " << nums[i] << endl;
    }
}


int main() 
{
    vector<int> nums = {0};

    moveZeroes(nums);

    return 0;
}