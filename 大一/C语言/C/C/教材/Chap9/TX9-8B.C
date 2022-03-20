#include <stdio.h>
void swap(int *px,int *py)
{
	int t=*px;
	*px=*py;
	*py=t;
	printf("In swap(): *px=%d,*py=%d\n",*px,*py);
}
void main(void) {
	int a,b;
	printf("Input two integers: ");
	scanf("%d%d",&a,&b);
	swap(&a,&b);
	printf("In main(): a=%d,b=%d\n",a,b);
}