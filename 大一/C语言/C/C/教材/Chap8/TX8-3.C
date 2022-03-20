#include <stdio.h>
int max(int x,int y)
{
	return x>y?x:y;
}
void main()
{
	int a,b;
	printf("Enter a and b: ");
	scanf("%d%d",&a,&b);
	printf("Max=%d\n",max(a,b));
}