#include <stdio.h>
#define START 10
int next_item(int diff)
{
	static int item=0;
	return item==0?(item=START):(item+=diff);
}
void main()
{
	int i;
	for (i=1;i<=10;i++) printf("%4d",next_item(5));
	printf("\n");
}