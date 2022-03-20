#include <stdio.h>
#include <string.h>
void strinsert(char str1[30],char str2[10],int pos)
{
	int i,len1,len2;
	len1=strlen(str1);
	len2=strlen(str2);
	for (i=len1;i>=pos-1;i--)
		str1[i+len2]=str1[i];
	for (i=0;i<len2;i++)
		str1[pos-1+i]=str2[i];
	puts(str2);
}
void main(void) {
	char s1[30],s2[10];
	int pos;
	printf("Input two strings: \n");
	gets(s1);gets(s2);
	printf("Input the inserted position: ");
	scanf("%d",&pos);
	strinsert(s1,s2,pos);
	puts(s1);
}