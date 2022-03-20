#include <stdio.h>
#include <string.h>
void main()
{
  char str1[60]="One World ", str2[]="One Dream ";
  char * p1,*p2;
  p1 = str1;
/**/  p2=str2;  /**/
  while(*p1)
     p1++;
  while(*p2)
/**/ *(p1++) = *(p2++);  /**/
  printf("\n%s\n",str1);
  getch();
}
