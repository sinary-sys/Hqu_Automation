#include <stdio.h>
int min;
int fun(int a[][5],int n) {
	int i,j,max;
	max=min=a[0][0];

	for (i=0;i<n;i++)
		for (j=0;j<5;j++)
		{
			if (a[i][j]>max) max=a[i][j];
			if (a[i][j]<min) min=a[i][j];
		}
	return max;
}
void main(void)
{
	int A[][5]={{12,3,8,6,17},{-3,15,9,21,7},{17,-11,6,3,15},{12,1,-8,17,4}};
	int rows=sizeof(A)/sizeof(int [5]);
	printf("max=%d\n",fun(A,rows));
	printf("min=%d\n",min);
}