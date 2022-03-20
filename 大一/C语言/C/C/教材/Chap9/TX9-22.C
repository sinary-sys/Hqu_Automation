#include <stdio.h>
void main(void) {
	int x=10;
	int *p=&x;
	int **q=&p;

	printf("p=%p\n",p);
	printf("&x=%p\n",&x);
	printf("x=%d\n",*p);
	printf("q=%p\n",q);
	printf("*q=%p\n",*q);
	printf("**q=%d\n",**q);
	printf("&q=%p\n",&q);
}