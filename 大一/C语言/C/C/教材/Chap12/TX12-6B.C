#include <stdio.h>
void main(void) {
	FILE *fp;
	long int N;
	fp=fopen("e:\\tc\\example.txt","rb");

	fseek(fp,0,SEEK_END);
	N=ftell(fp);
	fclose(fp);
	printf("%ld\n",N);
}