#include <stdio.h>
void main()
{
	int i,j,n=0;
	for (i=101;i<=200;i+=2)
	{
		for (j=2;j*j<=i;j++)
			if (i%j==0) break;
		if (j*j>i) {
			printf("%4d",i);
			n++;
		}
		if (n%10==0) printf("\n");
	}
}