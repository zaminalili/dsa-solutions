#include <stdio.h>
#include <stdlib.h>

struct Stack
{
    int *arr;
    int size;
    int top;
};

typedef struct Stack Stack;


struct Stack createStack() {
    struct Stack stck;
    stck.size = 10;
    stck.top = 0;
    stck.arr = calloc(stck.size, sizeof(int));

    return stck;
}


void push(Stack* stck, int val) {
    if(stck->top >= stck->size) {
        //int *temp = stck->arr;
        stck->size *= 2;
        stck->arr = realloc(stck->arr, stck->size);

        // for (int i = 0; i < stck->top; i++)
        // {
        //     stck->arr[i] = temp[i];
        // }
        
        //free(temp);
    }
    
    stck->arr[stck->top++] = val;
}

int pop(Stack* stck) {
    if (stck->top > 0){
        int popVal = stck->arr[stck->top-1];
        stck->arr[stck->top--];
        return popVal;
    }
}

int peek(Stack* stck) {
    return stck->arr[stck->top-1];
}

void printValues(Stack* stck) {
    for (int i = 0; i < stck->top; i++)
    {
        printf("%d \n", stck->arr[i]);
    }
}

int main() {
    struct Stack stack = createStack();
    Stack *stck = &stack;
    
    push(stck, 1);
    push(stck, 2);
    push(stck, 3);
    push(stck, 4);
    push(stck, 5);
    push(stck, 6);
    push(stck, 7);
    push(stck, 8);
    push(stck, 9);
    push(stck, 10);
    push(stck, 11);

    printValues(stck);
    printf("Peek val: %d \n", peek(stck));
    //printf("Pop val: %d \n", pop(stck));
    // printf("Peek val: %d \n", peek(stck));

    // printValues(stck);

    printf("Size: %d \n", stck->size);
    printf("Top: %d \n", stck->top);

    printf("Pop val: %d \n", pop(stck));
    printf("Pop val: %d \n", pop(stck));
    printf("Pop val: %d \n", pop(stck));
    printf("Pop val: %d \n", pop(stck));
    printf("Pop val: %d \n", pop(stck));
    printf("Pop val: %d \n", pop(stck));
    printf("Pop val: %d \n", pop(stck));
    printf("Pop val: %d \n", pop(stck));
    printf("Pop val: %d \n", pop(stck));
    printf("Pop val: %d \n", pop(stck));
    printf("Pop val: %d \n", pop(stck));
    printf("Pop val: %d \n", pop(stck));

    printValues(stck);
}