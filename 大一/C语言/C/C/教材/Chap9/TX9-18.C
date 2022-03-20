#include <stdio.h>
int min(int,int);
void main(void) {
	int a,b;
	int (*p_fun)(int,int);
	p_fun=min;

	printf("Enter two integers: ");
	scanf("%d%d",&a,&b);

	printf("min(%d,%d)=%d\n",a,b,(*p_fun)(a,b));
}
int min(int x,int y)
{
	return x<y?x:y;
}