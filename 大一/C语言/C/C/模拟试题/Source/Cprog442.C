#include <stdio.h>
long  int  Reverse(unsigned int n)
{/**/

	int retval=0;
	while (n>0)
	{
		retval=retval*10+n%10;
		n/=10;
	}
	return retval;



 /**/
}

void main()
{
  unsigned int a;
  printf("Input a (1-10000):");
  scanf("%u",&a);
  printf("result=%ld\n",Reverse(a));
  getch();
}
