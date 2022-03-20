#include <stdio.h>
int highest_score(int a[][5][2],int m)
{
	int highest=a[0][0][0],i,j,k;
	for (i=0;i<m;i++)
		for (j=0;j<5;j++)
			for (k=0;k<2;k++)
				if (a[i][j][k]>highest) highest=a[i][j][k];
	return highest;
}
void main()
{
	int A[3][5][2]={{{60,80},{56,80},{77,88},{86,68},{80,68}},
					{{70,90},{90,56},{88,79},{70,82},{100,89}},
					{{87,70},{60,56},{78,79},{80,82},{90,89}}};
	printf("The highest score is %3d\n",highest_score(A,3));
}