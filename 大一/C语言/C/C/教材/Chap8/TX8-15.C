#include <stdio.h>
void display(int num)
{
	printf("%4d",num);
}
void main()
{
	int a[]={1,2,3,4,5,6,7,8,9,10},i;
	for (i=0;i<sizeof(a)/sizeof(int);i++) display(a[i]);
	printf("\n");
}
