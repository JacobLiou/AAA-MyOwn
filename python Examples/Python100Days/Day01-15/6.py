from time import sleep

class Test:

    def __init__(self, foo):
        self.__foo = foo
        self.pubFoo = foo

    def __bar(self):
        print(self.__foo)
        print('__bar')

class Clock(object):
    def __init__(self, hour=0, minute=0, second=0) -> None:
        super().__init__()
        self._hour = hour
        self._minute = minute
        self._second = second
    
    def show(self):
        print("%02d:%02d:%02d" %(self._hour, self._minute, self._second))
    
    def run(self):
        """走字"""
        self._second += 1
        if self._second == 60:
            self._second = 0
            self._minute += 1
            if self._minute == 60:
                self._minute = 0
                self._hour += 1
                if self._hour == 24:
                    self._hour = 0

class Point:
    def __init__(self, x, y) -> None:
        self.x = x
        self.y = y
    
    def calcDistance(self, rhs):
        import math
        return math.sqrt( (self.x - rhs.x) ** 2 + (self.y - rhs.y) ** 2)

def main():
    test = Test('hello')
    # test.__bar() 私有无法访问
    print(test.pubFoo)
    # print(test.__foo) #私有无法访问

    p1= Point(0, 0)
    p2 = Point(1, 1)
    print(p1.calcDistance(p2))

    clock = Clock(23, 59, 58)
    while True:
        clock.show()
        sleep(1)
        clock.run()

if __name__ == "__main__":
    main()