#include <stdio.h>
#include <math.h>
void main()
{
  int fun();
  int num;
  num=fun();
  printf("\nThe total of prime is %d",num);
  getch();
}

int fun()
{
  /**/

	int count=0,i,j;
	for (i=101;i<200;i+=2)
	{
		for (j=2;j<i;j++)
			if (i%j==0)
				break;
		if (j==i)
			count++;
	}
	return count;
  /**/
}
