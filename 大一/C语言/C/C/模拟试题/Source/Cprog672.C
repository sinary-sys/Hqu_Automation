#include <stdio.h>
#include <conio.h>
#define N 4
void fun(int a[N][N],int b[N])
{ /**/

	int i,j;
	for (i=0;i<N;i++)
	{
		b[i]=a[i][0];
		for (j=1;j<N;j++)
			if (a[i][j]>b[i]) b[i]=a[i][j];
	}



 /**/
}

int main()
{
	int a[N][N]={{1,2,3,4},{5,-6,-7,-8},{0,9,-3,7},{11,12,-3,4}},b[N]={0},i;
	fun(a,b);
	for(i=0;i<N;i++) printf("%d ",b[i]);
	printf("\n");
	getch();
	return 0;
}