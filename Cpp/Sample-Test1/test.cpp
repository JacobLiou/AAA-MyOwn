#include "pch.h"
#include "math.h"


TEST(TestCaseName, TestName) {
  EXPECT_EQ(1, 1);
  EXPECT_TRUE(true);
}

TEST(AddCaseName, Add)
{
	EXPECT_EQ(3, add(1, 2));
}

