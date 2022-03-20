#include <stdio.h>
#include <string.h>

void main(void) {
	FILE *fp;
	char buf[50];
	char *text="this is a test for feof function!";
	char ch;

	printf("Please input a file path to open: ");
	scanf("%s",buf);
	fp=fopen(buf,"w");
	if (fp==NULL) printf("File open failed!\n");
	else {
		fwrite(text,strlen(text)+1,1,fp);
		fp=fopen(buf,"r");
		while (1) {
			ch=fgetc(fp);
			if (feof(fp)) break;
			fputc(ch,stdout);
		}
		fputc('\n',stdout);
		fclose(fp);
	}
}
