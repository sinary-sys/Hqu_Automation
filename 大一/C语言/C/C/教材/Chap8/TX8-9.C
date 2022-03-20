#include <stdio.h>
double power(double x,int n)
{
	if (n==0) return 1.0;
	else return x*power(x,n-1);
}
void main()
{
	double x;
	int n;
	printf("Enter x and n: ");
	scanf("%lf%d",&x,&n);
	printf("%lf^%d=%lf\n",x,n,power(x,n));
}