#include <stdio.h>
void swap(int x,int y)
{
	int t=x;
	x=y;
	y=t;
	printf("In swap(): x=%d,y=%d\n",x,y);
}
void main(void) {
	int a,b;
	printf("Input two integers: ");
	scanf("%d%d",&a,&b);
	swap(a,b);
	printf("In main(): a=%d,b=%d\n",a,b);
}