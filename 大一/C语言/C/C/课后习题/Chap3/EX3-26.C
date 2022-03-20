#include <stdio.h>
void main()
{
	float C,F;
	printf("Input the celcius temperature: ");
	scanf("%f",&C);
	F=32.0+C*1.8;
	printf("The corresponding farenheight temperature is %f\n",F);
}