#include <stdio.h>
void main()
{
	double k=1.0,sum=.0,sign=1.0;
	while (1/(k*k)>=1.0e-6)
	{
		sum+=sign*1/(k*k);
		sign=-sign;
		k++;
	}
	printf("sum=%lf\n",sum);
}