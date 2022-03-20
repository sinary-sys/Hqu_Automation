#include <stdio.h>
void main()
{
  int a,b,c;
  float f;
  clrscr();
  printf("Please input a b :");
  scanf("%d%d",&a,&b);
  f=/**/(float)a/b        /**/;
  c=/**/(int)        /**/ (f*100)%10;
  printf("\n a/b=%f   The second decimal place is: %d\n",f,c);
  getch();
}