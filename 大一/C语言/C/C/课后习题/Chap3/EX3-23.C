#include <stdio.h>
void main()
{
	float m;
	int d;
	printf("Input a float: ");
	scanf("%f",&m);
	d=(int)m%10;
	printf("The last digit of integer part is %d\n",d);
}