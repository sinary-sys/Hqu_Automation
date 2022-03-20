#include <stdio.h>
#include <conio.h>
#include <string.h>

void ch_nw( char str1[], char str2[] )
{ char temp;
  int i=0,j=0;
  while( !(str1[i]>='0' && str1[i]<='9') )
		/**/i++;    /**/
  while( !(str2[j]>='0' && /**/str2[j]<'9'      /**/ ) )
         j++;
  temp=str1[i];
  str1[i]=str2[j];
  str2[j]=/**/temp    /**/;
}

int main()
{ char str1[50],str2[50];
  printf("Input first  strings:");
  gets(str1);
  printf("Input second strings:");
  gets(str2);
  ch_nw( str1,str2 );
  printf("\nThe first  string is: %s\n",str1);
  printf("\nThe second string is: %s\n",str2);
  getch( );
  return 0;
}
