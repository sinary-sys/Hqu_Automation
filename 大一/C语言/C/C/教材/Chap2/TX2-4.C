#include <stdio.h>
int larger(int x,int y)
{
	return x>y?x:y;
}
int largest(int x,int y,int z)
{
	return larger(x,y)>z?larger(x,y):z;
}
void main()
{
	int a,b,c;
	printf("Input integer a, b and c: ");
	scanf("%d%d%d",&a,&b,&c);
	printf("The largest is %d\n",largest(a,b,c));
}