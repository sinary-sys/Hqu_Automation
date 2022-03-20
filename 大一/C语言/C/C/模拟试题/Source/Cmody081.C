#include <stdio.h>
void main()
{
  int i;
  /* for( i=100; i<200; i++ );  */
  for (i=100;i<200;i++)
    if((i-2)%4 == 0)
      if( !((i-3)%7) )
        if( i%9 == 5 )
	/*  printf("%d\n", &i); */
			printf("%d\n",i);
  getch();
}
