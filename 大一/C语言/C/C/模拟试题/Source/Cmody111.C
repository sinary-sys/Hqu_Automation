#include <stdio.h>
#include <conio.h>
void main()
{
  /* int i;j; */
  int i,j;
  /* for(i=6;i>1;i--) */
  for (i=6;i>=1;i--)
  {
    printf("@");
    for(j=1;j<=6-i;j++)
      printf("@");
	/*printf("\r");*/
	printf("\n");
  }
   getch();
}
