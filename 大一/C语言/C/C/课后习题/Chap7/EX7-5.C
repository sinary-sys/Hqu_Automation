#include <stdio.h>
#define N 10
void main()
{
	int a[N],i,first,second;
	printf("Input ten integers: \n");
	for (i=0;i<N;i++) scanf("%d",&a[i]);
	first=second=a[0];
	for (i=1;i<N;i++)
		if (a[i]>first) {
			second=first;
			first=a[i];
		}
		else if (a[i]>second) second=a[i];
	printf("The largest is %d\n",first);
	printf("The second largest is %d\n",second);
}