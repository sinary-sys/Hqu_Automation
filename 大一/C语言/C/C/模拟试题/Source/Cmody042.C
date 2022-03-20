#include <stdio.h>
#include <math.h>
#define M 8
main()
 { int a[M],i;
   printf("Please input 8 numbers:\n");
   for(i=0; i<M; i++)
/*   scanf("%d", a[i]);*/
	scanf("%d",&a[i]);
   printf("Inverse order is: \n");
/*  for(i=M-1; i<=0; i--)  */
	for (i=M-1;i>=0;i--)
      printf("%d  ", a[i]);
   printf("\n" );
   getch();
}