#include <stdio.h>
int isprime(int n)
{
	int i;
	for (i=2;i*i<=n;i++)
		if (n%i==0) return 0;
	return  1;
}
void main()
{
	int i,count;
	for (count=0,i=101;i<200;i+=2)
		if (isprime(i)) {
			printf("%5d",i);
			if (++count%10==0) printf("\n");
		}
}