#include"stdio.h"
#define ROW 3
#define COL 3
void main()
{
  int a[ROW][COL],i,j,max,min;
  clrscr();
  printf("Please input the 9 integers:\n");
  for(i=0;i<ROW;i++)
    for(j=0;j<COL;j++)
    scanf("%d",&a[i][j]);
  /**/max=a[0][0];min=a[0][0];/**/
  for(i=0;i<ROW;i++)
  for(j=0;j<COL;j++)
  {
	if(/**/a[i][j]>max   /**/)
      max=a[i][j];
    if(a[i][j]<min)
	  /**/min=a[i][j];         /**/
  }
    printf("max=%d\n",max);
    printf("min=%d\n",min);
    getch();
}
