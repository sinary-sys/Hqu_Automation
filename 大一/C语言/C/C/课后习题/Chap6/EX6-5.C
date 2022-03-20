#include <stdio.h>
void main()
{
	int i,j,n=0;
	for (i=2;i<100;i++)
	{
		for (j=2;j*j<=i;j++)
			if (i%j==0) break;
		if (j*j>i)
		{
			printf("%4d",i);
			if (++n%10==0) printf("\n");
		}
	}
}