#include <stdio.h>
#include <stdlib.h>
#include "linkedlist.h"

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