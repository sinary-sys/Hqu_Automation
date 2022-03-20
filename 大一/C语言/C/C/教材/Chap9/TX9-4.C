#include <stdio.h>
void main(void) {
	const int a=10,b=20;
	int c=20;
	const int * const p=&a;
	const int * const q=&b;
	p=&c;
	*p=50;
	p=q;
}