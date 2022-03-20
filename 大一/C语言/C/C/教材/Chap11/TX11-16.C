#include <stdio.h>
void main(void) {
	enum result {lost,draw,win=3} r1;
	r1=lost;
	switch (r1) {
		case lost: printf("lost\n");break;
		case draw: printf("draw\n");break;
		case win: printf("win\n");
	}
}