#include <stdio.h>
#include <math.h>
void main()
{
	float a,b,c,d,x1,x2;
	printf("Input the coefficient of quadratic equation: ");
	scanf("%f%f%f",&a,&b,&c);
	d=b*b-4*a*c;
	if (d>=0)
	{
		if (d>0)
		{
			x1=(-b+sqrt(d))/(2*a);
			x2=(-b-sqrt(d))/(2*a);
			printf("x1=%.2f,x2=%.2f\n",x1,x2);
		}
		else {
			x1=x2=-b/(2*a);
			printf("x1=x2=%.2f\n",x1);
		}
	}
	else printf("The quadratic equation has no real roots!\n");
}