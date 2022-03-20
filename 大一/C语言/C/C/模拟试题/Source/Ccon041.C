#include <stdio.h>
main()
{
 /**/char       /**/ s[80];
 int i;
 printf("Please input a string:");
 for(i=0;(s[i]=getchar())!='\n';i++);
 s[i]='\0';
 for(i=0;s[i]!='\0';i++)
 { if(s[i]>='a'&&s[i]<='z')
     s[i]=s[i]-32;
   /**/ else if       /**/( s[i]>='A'&&s[i]<='Z' )
     s[i]=s[i]+32;
   printf("%c",s[i]);
 }
 getch();
}