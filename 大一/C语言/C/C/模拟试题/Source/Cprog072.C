#include<stdio.h>
#define ROW 4
#define COL 4
int fun(int a[][COL],int row,int b[])
{
 /**/
	int i,j,k=0,sum=0;
	for (i=0;i<ROW;i++)
	{
		for (j=0;j<COL;j++)
		{
			if (a[i][j]==0)
				break;
			else
			if (a[i][j]>0)
			{
				b[k]=a[i][j];
				sum=sum+b[k];
				k++;
			}
		}
	}


	return sum;





 /**/
}

void main()
{
  int sss=0, b[16]={0};
  int a[ROW][COL]={{1,2,-3,-4},{0,-12,-13,14},{-21,23,0,-24},{-31,32,-33,0}};
  clrscr();
  sss=fun(a,ROW,b);
  printf("Sum of positive elements is %d\n",sss);
  getch();
}
