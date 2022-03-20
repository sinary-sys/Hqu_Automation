#include <stdio.h>
void main()
{
	float disp,price,tax;
	printf("Input the displacement of engine: ");
	scanf("%f",&disp);
	printf("Input the naked price of the car: ");
	scanf("%f",&price);
	if (disp>1.6) tax=price/11.7;
	else tax=price/11.7*.5;
	printf("The purchase tax of the car is: %.2f\n",tax);
}