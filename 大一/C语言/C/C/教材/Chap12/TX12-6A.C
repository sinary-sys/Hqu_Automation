#include <stdio.h>
void main(void) {
	FILE *fp;
	char c;
	char *string="This is an example\n";
	if ((fp=fopen("e:\\tc\\example.txt","w+"))==NULL) {
		printf("Open error on writing\n");
		exit(0);
	}
	c=fputs(string,fp);
	printf("%ld\n",ftell(fp));
	if ((fp=fopen("e:\\tc\\example.txt","r+"))==NULL) {
		printf("Open error on reading\n");
		exit(0);
	}
	printf("%ld\n",ftell(fp));
	while ((c=fgetc(fp))!=EOF) putchar(c);
	fclose(fp);
}