#include <stdio.h>
void main(void) {
	enum result {lost,draw,win=3} r1,r2;
	r1=lost;
	r2=win;
	printf("%d,%d\n",r1,r2);
}