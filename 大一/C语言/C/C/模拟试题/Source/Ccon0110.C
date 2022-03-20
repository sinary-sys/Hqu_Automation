#include <stdio.h>
main()
{
  struct stu
  {
   char name[10];
   float score;
  };
  /**/struct stu  /**/ stu[3]={"Mary",76,"John",85,"Tom",81};
  int i=0;
  float total=0,aver=0;
  while(i<3)
   {
	 total=total+/**/stu[i].score            /**/;
     i++;
    }
   aver=total/3;
   printf("\ntotal=%.2f,aver=%.2f", total,aver);
   getch();
}