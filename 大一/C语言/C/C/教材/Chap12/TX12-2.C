#include <stdio.h>
#include <stdlib.h>

void main(void) {
	FILE *fp;
	char c;
	char file[30];
	printf("Input directory and file: ");
	gets(file);
	if ((fp=fopen(file,"w"))==NULL) {
		printf("Open error on writing\n",file);
		exit(0);
	}
	while ((c=getchar())!='\n') fputc(c,fp);
	if ((fp=fopen(file,"r"))==NULL) {
		printf("Open error on reading\n");
		exit(0);
	}
	while ((c=fgetc(fp))!=EOF) putchar(c);
	fclose(fp);
}