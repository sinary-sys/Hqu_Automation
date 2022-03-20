#include <stdio.h>
void main(void) {
	int a[][3]={{1,2,3},{21,22,23}};
	int (*p)[2][3];

	p=&a;
	printf("%d\n",*(*(*p+1)+2));
}