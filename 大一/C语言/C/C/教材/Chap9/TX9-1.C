#include <stdio.h>
void main()
{
	int a[]={1,2,3,4,5};
	int *pa;
	pa=&a[0];
	printf("pa=%p\n",pa);
	printf("*pa=%d\n",*pa);

	pa+=4;
	printf("\nsizeof(int)=%d\n",sizeof(int));
	printf("pa=%p\n",pa);
	printf("*pa=%d\n",*pa);
}