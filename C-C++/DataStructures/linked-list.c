#include <stdio.h>
#include <stdlib.h>

struct ListNode {
    int value;
    struct ListNode *next;
};

typedef struct ListNode node;

node* createLinkedList(int value) {
    node *head = malloc(sizeof(node));
    head->value = value;
    head->next = NULL;

    return head;
}

void printValues(node *listNode) {
    
    node *current = listNode;
    while (current != NULL)
    {
        printf("%d \n", current->value);
        current = current->next;
    }
}

void addNext(node *listNode, int value) {
    node* next = listNode->next;
    
    listNode->next = malloc(sizeof(int));
    listNode->next->value = value;

    listNode->next->next = next;
}

void addLast(node *head, int value) {
    node *current = head;
    while (current->next != NULL)
    {
        current = current->next;
    }

    addNext(current, value);
}

node* removeFirstMatchingValue(node *head, int value){
    node *current = head;
    node *tempNode;

    if(head->value == value) {
        tempNode = head;
        head = head->next;
        free(tempNode);
        return head;
    }

    while (current->next != NULL && current->next->value != value)
    {
        current = current->next;
    }

    if(current->next == NULL) {
        return head;
    }
    
    tempNode = current->next;
    current->next = current->next->next;
    free(tempNode);

}

void removeNext(node *n) {
    if(n->next != NULL) {
        node *temp = n->next;
        n->next = n->next->next;
        free(temp);
    }
}


int main() {

    // node *head = malloc(sizeof(node));
    // head->value = 1;
    // head->next = malloc(sizeof(node));
    // head->next->value = 2;

    // node *current = head;

    // printf("%d \n", head->value);
    // printf("%d \n", head->next->value);

    // while (current->next != NULL)
    // {
    //     printf("%d \n", current->value);
    //     current = current->next;
    // }
    

    node *head = createLinkedList(1);
    //printf("%d \n", head->value);

    addNext(head, 2);
    addNext(head, 3);
    addNext(head, 4);
    //printValues(head);

    addLast(head, 10);
    printValues(head);

    freeLinkedList(head);
    //printValues(head);
    return 0;
}