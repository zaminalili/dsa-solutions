#ifndef linkedlist_h
#define linkedlist_h

struct ListNode {
    int value;
    struct ListNode *next;
};

typedef struct ListNode node;

node* createLinkedList(int value);

void printValues(node *listNode);

void addNext(node *listNode, int value);

void addLast(node *head, int value);

node* removeFirstMatchingValue(node *head, int value);

void removeNext(node *n);

#endif
