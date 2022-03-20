#include <stdio.h>
void main()
{
	int a,b,c,min;
	printf("Input three integers: ");
	scanf("%d%d%d",&a,&b,&c);
	min=(a>=b)?(b>=c)?c:b:(c>a)?a:c;
	printf("Minimum number is %d.\n",min);
}