#include <stdio.h>
void main()
{
	int nc=0;
l1:	if (getchar()!='\n')
	{
		nc++;
		goto l1;
	}
	printf("%d characters typed.\n",nc);
}