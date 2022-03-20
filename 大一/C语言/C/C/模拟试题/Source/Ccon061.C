#include <stdio.h>
#include <math.h>
void main()
{
  int /**/i    /**/, j ;
  int a[5][5],sum;
  sum=/**/0    /**/;
  printf("Please input 25 numbers:\n");
  for(i=0; i<5;i++)
    for(j=0;j<5;j++)
     scanf("%d",&a[i][j]);
  for(j=0;j<5;j++)
	sum += /**/a[4][j];         /**/
  printf("%d\n",sum);
  getch();
}
