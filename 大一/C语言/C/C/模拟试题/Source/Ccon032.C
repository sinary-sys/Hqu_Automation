#include <stdio.h>
void main()
 {
   char str1[20],str2[20];
   int i=0;
   printf("Please input a string:\n");
   scanf("%s",/**/str1        /**/ );
   while(/**/str1[i] /**/)
   {
	 str2[i]=/**/str1[i]^0x07;/**/
     i++;
   }
   str2[i]='\0';
   printf("\n Source string: %s,\n Target string: %s\n", str1,str2);
   getch();
 }
