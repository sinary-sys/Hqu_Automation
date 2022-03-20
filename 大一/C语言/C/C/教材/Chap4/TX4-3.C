#include <stdio.h>
void main()
{
	double x,y,t;
	printf("Enter x and y: ");
	scanf("%lf%lf",&x,&y);
	t=x;
	x=y;
	y=t;
	printf("After the swap: x=%7.2lf,y=%7.2lf\n",x,y);
}