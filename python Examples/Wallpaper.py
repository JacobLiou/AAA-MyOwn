import os
import sys
from subprocess import call
from threading import Thread
from time import sleep

import cv2
from PyQt5 import QtCore, QtWidgets
from PyQt5.QtCore import Qt, QTimer
from PyQt5.QtGui import QImage, QPixmap, QIcon

from PyQt5.QtWidgets import QAction, QGridLayout, QMenu, QMessageBox, QPushButton, QMainWindow, QFileDialog, QLabel, QSystemTrayIcon
QSystemTrayIcon, QAction, QMenu, QMessageBox

from os import path as pathq

class WallPaper:
    def __init__(self) -> None:
        pass

    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(505, 615)
        MainWindow.setToolButtonStyle(QtCore.Qt.ToolButtonIconOnly)
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")
        self.pushButton = QtWidgets.QPushButton(self.centralwidget)
        self.pushButton.setGeometry(QtCore.QRect(22, 10, 89, 31))
        self.pushButton.setObjectName("pushButton")
        self.pushButton.clicked.connect(self.openmp4)
        self.pushButton.setStyleSheet(
            '''QPushButton{background:#F7D674;border-radius:5px;}QPushButton:hover{background:yellow;}''')
        self.groupBox = QtWidgets.QGroupBox(self.centralwidget)
        self.groupBox.setGeometry(QtCore.QRect(22, 50, 452, 351))
        self.groupBox.setObjectName("groupBox")
        self.widget = QtWidgets.QWidget(self.groupBox)
        self.widget.setGeometry(QtCore.QRect(11, 20, 430, 291))
        self.widget.setObjectName("widget")
        self.gridLayout_3 = QtWidgets.QGridLayout(self.widget)
        self.gridLayout_3.setObjectName("gridLayout_3")
        self.label = QLabel(self)
        self.label.resize(400, 300)
        self.label.setText("Waiting for video...")
        self.gridLayout_3.addWidget(self.label)
        self.close_widget = QtWidgets.QWidget(self.centralwidget)
        self.close_widget.setGeometry(QtCore.QRect(420, 0, 93, 41))
        self.close_widget.setObjectName("close_widget")
        self.close_layout = QGridLayout()  # 创建左侧部件的网格布局层
        self.close_widget.setLayout(self.close_layout)  # 设置左侧部件布局为网格
        self.left_close = QPushButton("")  # 关闭按钮
        self.left_close.clicked.connect(self.close)
        self.left_visit = QPushButton("")  # 空白按钮
        #self.left_visit.clicked.connect(MainWindow.big)
        self.left_mini = QPushButton("")  # 最小化按钮
        self.left_mini.clicked.connect(MainWindow.mini)
        self.close_layout.addWidget(self.left_mini, 0, 0, 1, 1)
        self.close_layout.addWidget(self.left_close, 0, 2, 1, 1)
        self.close_layout.addWidget(self.left_visit, 0, 1, 1, 1)
        self.left_close.setFixedSize(15, 15)  # 设置关闭按钮的大小
        self.left_visit.setFixedSize(15, 15)  # 设置按钮大小
        self.left_mini.setFixedSize(15, 15)  # 设置最小化按钮大小
        self.left_close.setStyleSheet(
            '''QPushButton{background:#F76677;border-radius:5px;}QPushButton:hover{background:red;}''')
        self.left_visit.setStyleSheet(
            '''QPushButton{background:#F7D674;border-radius:5px;}QPushButton:hover{background:yellow;}''')
        self.left_mini.setStyleSheet(
            '''QPushButton{background:#6DDF6D;border-radius:5px;}QPushButton:hover{background:green;}''')
        self.horizontalLayout = QtWidgets.QHBoxLayout(self.close_widget)
        self.horizontalLayout.setContentsMargins(0, 0, 0, 0)
        self.horizontalLayout.setObjectName("horizontalLayout")
        self.pushButton_2 = QtWidgets.QPushButton(self.centralwidget)
        self.pushButton_2.setGeometry(QtCore.QRect(77, 440, 133, 41))
        self.pushButton_2.setObjectName("pushButton_2")
        self.pushButton_2.clicked.connect(self.play)
        self.pushButton_2.setStyleSheet(
            '''QPushButton{background:#6DDF6D;border-radius:5px;}QPushButton:hover{background:green;}''')
        self.pushButton_3 = QtWidgets.QPushButton(self.centralwidget)
        self.pushButton_3.setGeometry(QtCore.QRect(308, 440, 111, 41))
        self.pushButton_3.setObjectName("pushButton_3")
        self.pushButton_3.clicked.connect(self.close_wall)
        self.pushButton_3.setStyleSheet(
            '''QPushButton{background:#F76677;border-radius:5px;}QPushButton:hover{background:red;}''')
        self.pushButton_4 = QtWidgets.QPushButton(self.centralwidget)
        self.pushButton_4.setGeometry(QtCore.QRect(187, 540, 133, 21))
        self.pushButton_4.setObjectName("pushButton_4")
        self.pushButton_4.clicked.connect(self.openurl)
        self.pushButton_4.setStyleSheet(
            '''QPushButton{background:#222225;color:white;border-radius:5px;}QPushButton:hover{background:#222225;color:skyblue}''')
        MainWindow.setCentralWidget(self.centralwidget)
        self.menubar = QtWidgets.QMenuBar(MainWindow)
        self.menubar.setGeometry(QtCore.QRect(0, 0, 505, 23))
        self.menubar.setObjectName("menubar")
        MainWindow.setMenuBar(self.menubar)
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        self.statusbar.setObjectName("statusbar")
        MainWindow.setStatusBar(self.statusbar)
        self.retranslateUi(MainWindow)
        QtCore.QMetaObject.connectSlotsByName(MainWindow)
        self.groupBox.setStyleSheet('''
        color:white
        ''')
        MainWindow.setWindowOpacity(0.95)  # 设置窗口透明度
        MainWindow.setAttribute(Qt.WA_TranslucentBackground)
        MainWindow.setWindowFlag(Qt.FramelessWindowHint)  # 隐藏边框
        
    # author：Dragon少年
    def retranslateUi(self, MainWindow):
        _translate = QtCore.QCoreApplication.translate
        MainWindow.setWindowTitle(_translate("MainWindow", "MainWindow"))
        self.pushButton.setText(_translate("MainWindow", "从本地选择"))
        self.groupBox.setTitle(_translate("MainWindow", "预览"))
        self.pushButton_2.setText(_translate("MainWindow", "应用"))
        self.pushButton_3.setText(_translate("MainWindow", "关闭壁纸"))
        self.pushButton_4.setText(_translate("MainWindow", "在线资源"))

    def openMp4(self):
        try:
            global path
            path, filetype = QFileDialog.getOpenFileName(None, "选择文件", ".",
            "视频文件(*.AVI;*.mov;*.rmvb;*.rm;*.FLV;*.mp4;*.3GP)")

            # 打开文件
            if path == "":
                return
            
            self.slotStart()
            t = Thread(target=self.selfStop)
            t.start()
        except Exception as e:
            print(e)
    
    def slotStart(self):
        videoName = path
        if videoName != "":  # “”为用户取消
            self.cap = cv2.VideoCapture(videoName)
            self.timer_camera.start(50)
            self.timer_camera.timeout.connect(self.openFrame)

    # author：CSDN-Dragon少年
    def openFrame(self):
        if (self.cap.isOpened()):
            ret, self.frame = self.cap.read()
            if ret:
                self.getFileName()
            else:
                self.cap.release()
                self.timer_camera.stop()  # 停止计时器

    def getFileName(self):
        frame = cv2.cvtColor(self.frame, cv2.COLOR_BGR2RGB)
        if self.detectFlag == True:
            # 检测代码self.frame
            self.label_num.setText("There are " + str(5) + " people.")
        height, width, bytesPerComponent = frame.shape
        bytesPerLine = bytesPerComponent * width
        q_image = QImage(frame.data, width, height, bytesPerLine,
                        QImage.Format_RGB888).scaled(self.label.width(), self.label.height())
        self.label.setPixmap(QPixmap.fromImage(q_image))

# # author：CSDN-Dragon少年 全局函数
# def pretreatmentHandle():
#     hwnd = win32gui.FindWindow("Progman", "Program Manager")
#     win32gui.SendMessageTimeout(hwnd, 0x052C, 0, None, 0, 0x03E8)
#     hwnd_WorkW = None
#     while 1:
#         hwnd_WorkW = win32gui.FindWindowEx(None, hwnd_WorkW, "WorkerW", None)
#         if not hwnd_WorkW:
#             continue
#         hView = win32gui.FindWindowEx(hwnd_WorkW, None, "SHELLDLL_DefView", None)
#         # print('hwmd_hView: ', hView)
#         if not hView:
#             continue
#         h = win32gui.FindWindowEx(None, hwnd_WorkW, "WorkerW", None)
#         while h:
#             win32gui.SendMessage(h, 0x0010, 0, 0)  # WM_CLOSE
#             h = win32gui.FindWindowEx(None, hwnd_WorkW, "WorkerW", None)
#         break
#     return hwnd

