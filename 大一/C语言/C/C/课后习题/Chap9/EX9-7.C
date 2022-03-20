#include <stdio.h>
char *strchr1(char *str,char ch) {
	while ((*str!=ch) && (*str!='\0')) str++;
	if (*str==ch) return str;
	return NULL;
}

void main(void) {
	char *string="Huaqiao University";
	char ch='U';

	char *pc=strchr1(string,ch);
	printf("The position of the ch is %d\n",pc-string+1);
	printf("Substring is %s\n",pc);
}