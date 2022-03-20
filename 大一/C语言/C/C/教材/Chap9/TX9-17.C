#include <stdio.h>
int *findmax(int *array,int size,int *index);
void main(void)
{
	int a[]={33,91,54,67,82,37,85,63,19,68};
	int *maxaddr,idx;
	maxaddr=findmax(a,sizeof(a)/sizeof(int),&idx);
	printf("The index of MAX=%d\n",idx);
	printf("Address of MAX=%p\n",maxaddr);
	printf("MAX=%d\n",*maxaddr);
}

int *findmax(int *array,int size,int *index) {
	int max=*array,i;
	for (*index=0,i=1;i<size;i++)
		if (*(array+i)>max) {
			max=*(array+i);
			*index=i;
		}
	return array+*index;
}