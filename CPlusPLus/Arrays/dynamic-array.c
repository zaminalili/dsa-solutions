#include <stdio.h>
#include <stdlib.h>

struct DynamicArray
{
    int *data;
    int size;
    int capacity;
};

typedef struct DynamicArray DynamicArray;


struct DynamicArray createDynamicArray(int capacity) {
    struct DynamicArray arr;
    arr.capacity = capacity;
    arr.size = 0;
    arr.data = malloc(sizeof(int) * capacity);

    return arr;
}


void initDynamicArray(struct DynamicArray *arr) {
    arr->capacity = 10;
    arr->data = (int*) malloc(sizeof(int) * 10);
    arr->size = 0;
}
    
void printData(struct DynamicArray *arr) {
    for (int i = 0; i < arr->size; i++)
    {
        printf("%d \n", arr->data[i]);
    }
}

void append(DynamicArray *arr, int value) {
    if(arr->size >= arr->capacity) {
        arr->data = realloc(arr->data, sizeof(int) * arr->capacity*2);
        arr->capacity *= 2;
    }

    arr->data[arr->size] = value;
    arr->size++;
}

void freeDynamicArray(DynamicArray *arr) {
    free(arr->data);
    arr->data = NULL;
    arr->size = 0;
    arr->capacity = 0;
}

int main() {
    struct DynamicArray arr = createDynamicArray(5);    
    append(&arr, 1);
    append(&arr, 2);
    append(&arr, 3);
    append(&arr, 4);
    append(&arr, 5);
    append(&arr, 6);
    append(&arr, 7);

    printf("Size of array: %d \nElements: \n", arr.size);
    printData(&arr);

    freeDynamicArray(&arr);
    printData(&arr);

    return 0;
}