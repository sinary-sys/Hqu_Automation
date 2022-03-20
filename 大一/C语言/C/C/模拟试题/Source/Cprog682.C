#include <stdio.h>
#include <conio.h>
#define N 4
void fun(int a[N][N])
{ /**/

	int i,j,t;
	for (i=0;i<N;i++)
		for (j=0;j<i;j++)
		{
			t=a[i][j];
			a[i][j]=a[j][i];
			a[j][i]=t;
		}



 /**/
}

int main()
{
	int a[N][N]={{11,-2,3,4},{1,-6,-7,8},{10,9,-3,7},{1,12,-3,4}},i,j;
	printf("Before transform:\n");
	for(i=0;i<N;i++)
	{
		for(j=0;j<N;j++) printf("%d ",a[i][j]);
		printf("\n");
	}
	fun(a);
	printf("\nAfter transform:\n");
	for(i=0;i<N;i++)
	{
		for(j=0;j<N;j++) printf("%d ",a[i][j]);
		printf("\n");
	}
	printf("\n");
	getch();
	return 0;
}
