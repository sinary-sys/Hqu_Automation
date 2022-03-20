#include <stdio.h>
#include <math.h>
int fun(int a[][3],int m)
{
 /**/

	int i,j,flag=1;
	for (i=0;i<m&&flag;i++)
		for (j=0;j<i;j++)
			if (a[i][j]!=a[j][i])
			{
				flag=0;
				break;
			}




	return flag;

 /**/
}

void main()
{
  int a[3][3],i,j;
  int b;
  for(i=0; i<3; i++)
    for(j=0; j<3; j++)
      scanf("%d",&a[i][j]);
  b = fun(a,3);
  if( b == 1 )
    printf("Yes\n");
  else
    printf("No\n");
  getch();
}