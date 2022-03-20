#include <stdio.h>
#include <math.h>
float area(float a,float b,float c)
{
	float s=(a+b+c)/2.0f;
	return sqrt(s*(s-a)*(s-b)*(s-c));
}
void main()
{
	float a,b,c;
	printf("Input the length of the three edges of the triangle: \n");
	scanf("%f%f%f",&a,&b,&c);
	printf("The area of the triangle is %.2f\n",area(a,b,c));
}