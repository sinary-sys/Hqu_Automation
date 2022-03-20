#include <stdio.h>
#define N 8
int search(int a[])
{ /**/

	int i,max=0,second=1;
	for (i=0;i<N;i++)
	{
		if (a[max]<a[i])
		{
			second=max;
			max=i;
		}
		else
		if (a[second]<a[i]) second=i;
	}
	return a[second];
  /**/
}

void main()
{
  int a[N]={16,8,66,45,6,79,40,58};
  int max_next;
  max_next=search(a);
  printf("Max_next is %d\n",max_next);
  getch();
}

