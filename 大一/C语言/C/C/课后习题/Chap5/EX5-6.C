#include <stdio.h>
void main()
{
	int x,f;
	printf("Input integer x: ");
	scanf("%d",&x);
	if (x<0) f=5+x;
	else if (x<=10) f=100-x;
	else f=x*7-6;
	printf("f(%d)=%d\n",x,f);
}