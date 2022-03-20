#include <stdio.h>
void main()
{
	int i,n=0;
	for (i=1;i<=100;i++)
	{
		if (i%3==0) continue;
		printf("%4d",i);
		n++;
		if (n%10==0) printf("\n");
	}
	printf("\n");
}