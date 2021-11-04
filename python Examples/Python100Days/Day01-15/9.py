import multiprocessing
import threading
import time

class downloadFileThread:
    def __init__(self) -> None:
        pass

def downloadFile(filename):
    print('开始下载-%s'%filename)
    time_to_d = 5
    time.sleep(time_to_d)
    print('下载完成-%s'%filename)

def main():
    start = time.time()
    proc1 = multiprocessing.Process(target=downloadFile, args=("python 经典.pdf", ))
    proc2 = multiprocessing.Process(target=downloadFile, args=("C# 经典.pdf", ))
    proc1.start()
    proc2.start()
    proc1.join()
    proc2.join()
    end = time.time()
    print("总共花费：%.2f" % (end - start))

    start = time.time()
    proc1 = threading.Thread(target=downloadFile, args=("python 经典.pdf", ))
    proc2 = threading.Thread(target=downloadFile, args=("C# 经典.pdf", ))
    proc1.start()
    proc2.start()
    proc1.join()
    proc2.join()
    end = time.time()
    print("总共花费：%.2f" % (end - start))

if __name__ == '__main__':
    main()
