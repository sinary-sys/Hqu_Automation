#include <stdio.h>
void main()
{ int  m , n ,/**/k     /**/;
  for ( m = 1; m < 10 ; m++)
    for ( n = 1 ; n < 10 ; n++)
	{ k =/**/(m*10+n)/**/  * (n*10+m);
      if (k == 1008)
        printf ( "M = %d  N = %d\n", m, n );
    }
  getch();
}

