#include <stdio.h>
#include <string.h>
char *substr(const char *str, int start, int length)
{
	char *sub;
	int i=0;
	sub=(char *)malloc((length+1)*sizeof(char));
	if (start+length-1<strlen(str))
	{
		const char *p=str+start-1;
		while (i<length)
		{
			*(sub+i)=*(p+i);
			i++;
		}
		*(sub+i)='\0';
		return sub;
	}
	return NULL;
}
void main(void) {
	char s[]="Hello the world";
	printf("%s\n",substr(s,7,3));
}