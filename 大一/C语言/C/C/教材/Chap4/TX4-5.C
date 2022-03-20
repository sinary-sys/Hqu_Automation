#include <stdio.h>
void main()
{
	int num,d3,d2,d1,sum;
	printf("Enter an integer between 0 and 999: ");
	scanf("%d",&num);
	d3=num/100;
	d2=num/10%10;
	d1=num%10;
	sum=d3+d2+d1;
	printf("%d+%d+%d=%d\n",d3,d2,d1,sum);
}