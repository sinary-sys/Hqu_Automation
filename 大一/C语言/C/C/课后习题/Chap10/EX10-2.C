#include <stdio.h>
#define PI 3.1415926
void main(void)
{
	double radius,circumference,area;
	printf("Input the radius of the circle: ");
	scanf("%lf",&radius);
	circumference=2*PI*radius;
	area=PI*radius*radius;
	printf("circumference=%.2lf,area=%.2lf\n",circumference,area);
}
