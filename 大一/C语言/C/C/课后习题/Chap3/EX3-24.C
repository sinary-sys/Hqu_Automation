#include <stdio.h>
void main()
{
	float m;
	int d;
	printf("Input a float: ");
	scanf("%f",&m);
	d=(int)m%100;
	printf("The last two digits of integer part is %d\n",d);
}