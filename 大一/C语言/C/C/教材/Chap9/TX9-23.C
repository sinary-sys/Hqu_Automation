#include <stdio.h>
void main(void) {
	int a[]={1,2,3,4,5};
	int b[2][5]={{1,2,3,4,5},{6,7,8,9,10}};
	int (*p)[5];
	p=&a;
	printf("%d\n",*(*p+2));
	printf("%d\n",*(*(b+1)+2));
}