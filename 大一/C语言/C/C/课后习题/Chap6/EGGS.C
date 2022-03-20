#include <stdio.h>
void main(void)
{
	int tw=1,th=2,fo=3,fi=5;
	while (1) {
		if ((tw==th)&&(tw==fo)&&(tw==fi)) break;
		while (tw<fi) tw+=2;
		while (th<tw) th+=3;
		while (fo<th) fo+=4;
		while (fi<fo) fi+=10;
	}
	printf("Eggs=%d\n",tw);
}