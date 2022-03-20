#include <stdio.h>
#define N 3
void fun(int a[N][N])
{/**/
	int i,j;
	for (i=0;i<N;i++)
		for (j=0;j<i;j++)
			a[j][i]=a[i][j];



 /**/
}

void main()
{ int i,j;
  int b[N][N]={{1,0,0},
               {-2,3,0},
               {4,-5,6}};
  fun(b);
  for(i=0;i<N;i++)
  { for(j=0;j<N;j++)
      printf("%-4d",b[i][j]);
    printf("\n");
  }
  getch();
}
