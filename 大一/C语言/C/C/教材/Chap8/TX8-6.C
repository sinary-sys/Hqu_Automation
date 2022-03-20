#include <stdio.h>
int max(int,int,int);
int larger(int,int);
void main()
{
	int a,b,c;
	printf("Enter a,b and c: ");
	scanf("%d%d%d",&a,&b,&c);
	printf("max(%d,%d,%d)=%d\n",a,b,c,max(a,b,c));
}
int max(int x,int y,int z)
{
	return larger(x,y)>z?larger(x,y):z;
}
int larger(int x,int y)
{
	return x>y?x:y;
}