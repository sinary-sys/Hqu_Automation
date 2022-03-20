#include <stdio.h>
void putmax(int x, int y)
{
	x>y?printf("Max=%d\n",x):printf("Max=%d\n",y);
}
void main()
{
	int a,b;
	printf("Enter a and b: ");
	scanf("%d%d",&a,&b);
	putmax(a,b);
}