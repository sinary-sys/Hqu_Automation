#include <stdio.h>
#define N 4
void fun(int a[N][N])
{/**/
	int i,j,t;
	for (i=0;i<N-1;i++)
		for (j=i+1;j<N;j++)
			if (a[i][i]>a[j][j])
			{
				t=a[i][i];
				a[i][i]=a[j][j];
				a[j][j]=t;
			}


 /**/
}
void main()
{  int a[N][N]={{1,2,3,4},{-5,-6,-7,-8},{9,10,11,12},{13,-14,-15,16}},i,j;
   fun(a);
   for( i=0;i<N;i++)
   {
     for(j=0;j<N;j++)   printf("%4d ",a[i][j]);
     printf("\n");
   }
   getch();
}
