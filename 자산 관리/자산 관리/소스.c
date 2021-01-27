#include "include.h"

void main()
{
	arr = (int*)malloc(sizeof(int) * COUNT_LIMIT);
	int x = 0, y = 0, z = 0, n = 0, result = 0;

	//printf("\n\n투자금, 개수, 하락율, 이전 구매가 : ");
	scanf_s("%d %d %d", &x, &y, &n);//투자금, 개수, 이전 구매가(test : 1000 1 1000)

	for (int i = 100; i >= 1; i--)
	{
		comp_price(x, test(x, y, i, n));//현재가(current)를 리턴하면서 기초 계산
	}
}