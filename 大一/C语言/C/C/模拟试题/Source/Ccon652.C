#include <stdio.h>
#include <conio.h>
int main()
{ int c7,c3,c2;
  for(c7=4; c7>=0; /**/c7--     /**/)
  {   for(c3=10;c3>=0;c3--)
		for(c2=15; /**/c2>=0    /**/; c2--)
		   if( 7*c7+3*c3+2*c2==/**/ 30  /**/ )
               printf("c7=%d  c3=%d  c2=%d\n",c7,c3,c2);
  }
  getch();
  return 0;
}
