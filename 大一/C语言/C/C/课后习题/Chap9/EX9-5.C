#include <stdio.h>
void main(void) {
	int a[2][5]={1,2,3,5,6,7,8,9,10},*p;
	for (p=a[0]+9;p>=a[0];p--)
		printf("%4d",*p);
	printf("\n");
}