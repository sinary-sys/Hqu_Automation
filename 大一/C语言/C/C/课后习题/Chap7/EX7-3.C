#include <stdio.h>
void main(void) {
	int fib[15]={1,1},i;
	for (i=2;i<15;i++)
		fib[i]=fib[i-2]+fib[i-1];
	printf("fib(15)=%d\n",fib[14]);
}