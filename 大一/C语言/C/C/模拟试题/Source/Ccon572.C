/**/ #include         /**/ <stdio.h>
#include <conio.h>
void main()
{ char str[80];
  int i,j;
  printf("Input string :");
  gets(str);
  i=j=/**/0   /**/;
  while( str[i]!='\0')
  { if(str[i]!='A')
    { str[j]=str[i];
      j++ ;
    }
    /**/i++      /**/; 
  }
  str[j]='\0';
  printf("New string is:");
  puts(str); 
  getch();
}