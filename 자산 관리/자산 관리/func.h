#pragma once

#include <stdlib.h>
#include <stdio.h>
#include <windows.h>
#include <string.h>
#include "struct.h"

#define COUNT_LIMIT 10

int count;
int* arr;
NUM* cointest;
NUM* ar;

/*int comp(int y, int z, int t_m)
{
	int result = 0, sw = 0;

	//(10000 + y * i) / (10 + y * i / y)
	for (int i = 0; i < 1000; i++)
	{
		int res = (t_m + y * i) / (t_m / (z * 2 - y) + i);//(((y + z) / 2) + y) / 2 < res && res < (((y + z) / 2) + z) / 2
		if (y < res && res < z)
		{
			printf("%d %d\n", res, i);
			if (res == (y + z) / 2)
			{
				printf("찾음");
				sw = 1;
				result = i;
				break;
			}
		}
	}
	if (sw == 0)
	{
		printf("못 찾음");
	}
	return result;
}*/

void print_per(int percent)
{
	printf("%d%%----------------------\n\n", percent);//퍼센트바 프린트
}

void print_num(NUM* arr)
{
	for (int i = 0; i < COUNT_LIMIT; i++)
	{
		printf("%d : %d\n", arr[i].p_price, arr[i].num);//평균 단가 : 번호 프린트
	}
	printf("\n\n");
}

int between_a_b(int a, int b)
{
	int result = (a + b) / 2;//a와 b의 중간을 계산
	count++;
	if (count > COUNT_LIMIT)
	{
		return result;
	}
	else
	{
		//printf("%d : %d\n", result, count);
		arr[count] = result;//비교 하기 위한 결과를 절대적 배열(다음 큰 계산 전까지 불변)에 대입
		return(between_a_b(a, result));//재귀함수
	}
}

int test(int x, int y, int z, int n)
{
	int current = n * (1 - (z * 0.01));//현재가(하락 후) 계산
	between_a_b(current, n);//현재가(최저가 가정)와 각 경우의 중간을 계산
	count = 0;//다음 계산을 위해 초기화
	print_per(z);//퍼센트바 프린트
	return current;
}

void comp_price(int x, int current)
{
	int num1 = x, num2 = current, comp_num = 0;
	cointest = malloc(sizeof(NUM) * 100);
	ar = malloc(sizeof(NUM) * COUNT_LIMIT);

	for (int i = 1; i <= 100; i++)
	{
		//printf("총 코인 %d개, 총 %d원, 평균 단가 : %d, %d번째\n", i + 1, num2 * i + num1, (num2 * i + num1) / (i + 1), i);

		cointest[i - 1].p_price = (num2 * i + num1) / (i + 1);//각 경우 평균 단가 계산
		cointest[i - 1].num = i;//번호 부여

		for (int j = 0; j < 10; j++)
		{
			if (cointest[i - 1].p_price == arr[j] && cointest[i - 1].p_price != comp_num)
			{
				comp_num = cointest[i - 1].p_price;//필터
				for (int l = 0; l < COUNT_LIMIT; l++)
				{
					if (ar[l].num == 0)
					{
						ar[l] = cointest[i - 1];//프린트용 배열에 값 넣기
						break;
					}
				}
			}
		}
	}
	print_num(ar);//평균 단가 : 번호 식 프린트
}