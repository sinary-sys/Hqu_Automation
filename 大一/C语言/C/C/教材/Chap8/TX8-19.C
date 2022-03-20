#include <stdio.h>
int matrix_max(int a[][4],int m)
{
	int max=a[0][0],i,j;
	for (i=0;i<m;i++)
		for (j=0;j<4;j++)
			if (a[i][j]>max) max=a[i][j];
	return max;
}
void main()
{
	int A[3][4]={{1,2,3,5},{5,66,7,8},{11,-2,23,8}},
		B[2][4]={{1,2,3,4},{5,6,7,8}};
	printf("The max element of A is %d\n",matrix_max(A,3));
	printf("The max element of B is %d\n",matrix_max(B,2));
}