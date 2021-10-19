import re
import time
import keyboard

def play_music(musicChars, keytime):
    for charactor in musicChars:
        if charactor.isupper():
            keyboard.press(Key.shift)
            time.sleep(0.001)
            Keyboard.press(charactor.lower())
            keyboard.release(charactor.lower())
            keyboard.release(Key.shift)
        elif charactor == "|" or charactor == ")":
            pass
        elif charactor in "!@$%^*(":
            keyboard.press(Key.shift)
            time.sleep(0.001)
            keyboard.press("1245689"["!@$%^*(".index(charactor)])
            time.sleep(keytime - 0.001)
            keyboard.release("1245689"["!@$%^*(".index(charactor)])
            keyboard.release(Key.shift)
        elif charactor != " " and charactor != "-":
            keyboard.press(charactor)
            if musicChars.index(charactor) != len(musicChars) - 1 and musicChars[musicChars.index(charactor) + 1] == ")":
                time.sleep(keytime / 2)
            else:
                time.sleep(keytime)
            keyboard.release(charactor)
        elif charactor == "-":
            time.sleep(2 * keytime)
        else:
            time.sleep(keytime)
