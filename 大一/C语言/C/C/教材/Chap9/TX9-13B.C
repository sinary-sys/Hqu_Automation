#include <stdio.h>
void fun(int *q) {
	q+=2;
	*q=100;
}

void main(void) {
	int a[]={1,2,3,4,5};
	int *pa=a;
	printf("Before calling fun(): ");
	printf("a[2]=%d\n",a[2]);
	printf("*pa=%d\n",*pa);

	fun(pa);

	printf("\nAfter calling fun(): ");
	printf("a[2]=%d\n",a[2]);
	printf("*pa=%d\n",*pa);
}