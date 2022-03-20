#define N 20
#define M 5
#include <stdio.h>
void main(void) {
	int person[N]={0},i=0,count=N,no=0;
	while (count>1) {
		if (person[i]==0) no++;
		if (no==M) {
			no=0;
			person[i]=1; /*quit the circle*/
			count--;
		}
		i++;
		if (i==N) i=0;
	}
	for (i=0;i<N;i++)
		if (person[i]==0) printf("%3d",i+1);
}