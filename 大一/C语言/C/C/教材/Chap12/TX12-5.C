#include <stdio.h>
#include <stdlib.h>
void main(void) {
	FILE *fp;
	char *string="";
	if ((fp=fopen("e:\\tc\\example.txt","r+"))==NULL) {
		printf("Open error on reading\n");
		exit(0);
	}
	fgets(string,9,fp);
	printf("%s\n",string);
	fclose(fp);
}