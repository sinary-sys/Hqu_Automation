#include <stdio.h>
#include <math.h>
void main()
{
	float a,b,c,s,area;
	printf("Input the edges length of the triangle: ");
	scanf("%f%f%f",&a,&b,&c);
	s=.5*(a+b+c);
	area=sqrt(s*(s-a)*(s-b)*(s-c));
	printf("The area of the triangle is %.2f\n",area);
}