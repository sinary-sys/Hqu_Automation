#include <stdio.h>
int max(int a[],int n)
{
	if (n==1) return a[0];
	else return max(a,n-1)>a[n-1]?max(a,n-1):a[n-1];
}
void main()
{
	int a[]={31,29,37,42,18,33};
	printf("The maximum element is %d\n",max(a,sizeof(a)/sizeof(int)));
}