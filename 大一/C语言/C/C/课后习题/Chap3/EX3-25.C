#include <stdio.h>
void main()
{
	float length,width,area,circumference;
	printf("Input the length and width of the rectangle: ");
	scanf("%f%f",&length,&width);
	area=length*width;
	circumference=(length+width)*2;
	printf("area=%.2f,circumference=%.2f\n",area,circumference);
}