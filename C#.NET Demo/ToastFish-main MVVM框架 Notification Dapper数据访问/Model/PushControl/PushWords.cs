﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;
using ToastFish.Model.SqliteControl;
using System.Threading;
using System.Speech.Synthesis;

namespace ToastFish.Model.PushControl
{
    class PushWords
    {
        // 当前推送单词的状态
        public static int WORD_CURRENT_STATUS = 0;  // 背单词时候的状态
        public static string WORD_NUMBER_STRING = "";  // 设置的单词数量
        public static int QUESTION_CURRENT_RIGHT_ANSWER = -1;  // 当前问题的答案
        public static int QUESTION_CURRENT_STATUS = 0;  // 问题的回答状态
        public static Dictionary<string, string> AnswerDict = new Dictionary<string, string> {
            {"0","A"},{"1","B"},{"2","C"},{"3","D"}
        };

        /// <summary>
        /// 判断字符串是否为数字
        /// </summary>
        public static bool IsNumber(string str)
        {
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)    
            {
                if (ch[i] < 48 || ch[i] > 57)
                    return false;
            }
            return true;
        }

        public static Word GetRandomWord(List<Word> WordList)
        {
            Random Rd = new Random();
            int Index = Rd.Next(WordList.Count);
            return WordList[Index];
        }

        /// <summary>
        /// 推送单词的Task
        /// </summary>
        public static Task<int> ProcessToastNotificationRecitation()
        {
            var tcs = new TaskCompletionSource<int>();

            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                ToastArguments Args = ToastArguments.Parse(toastArgs.Argument);
                string Status = "";
                try
                {
                    Status = Args["action"];
                }
                catch
                {
                }
                if (Status == "succeed")
                {
                    tcs.TrySetResult(0);
                }
                else if (Status == "fail")
                {
                    tcs.TrySetResult(1);
                }
                else if (Status == "voice")
                {
                    tcs.TrySetResult(2);
                }
                else
                {
                    tcs.TrySetResult(1);
                }
            };
            return tcs.Task;
        }
        
        /// <summary>
        /// 推送问题的Task
        /// </summary>
        public static Task<int> ProcessToastNotificationQuestion()
        {
            var tcs = new TaskCompletionSource<int>();

            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                ToastArguments Args = ToastArguments.Parse(toastArgs.Argument);
                string Status = "";
                try
                {
                    Status = Args["action"];
                }
                catch
                {
                    tcs.TrySetResult(-1);
                }
                if (Status == QUESTION_CURRENT_RIGHT_ANSWER.ToString())
                {
                    tcs.TrySetResult(1);
                }
                else
                {
                    tcs.TrySetResult(0);
                }
            };
            return tcs.Task;
        }

        /// <summary>
        /// 设置单词数量的Task
        /// </summary>
        public static Task<int> ProcessToastNotificationSetNumber()
        {
            var tcs = new TaskCompletionSource<int>();

            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                ToastArguments Args = ToastArguments.Parse(toastArgs.Argument);
                string Status = "";
                try
                {
                    Status = Args["action"];
                }
                catch
                {
                    tcs.TrySetResult(0);
                }
                if (Status == "yes")
                {
                    WORD_NUMBER_STRING = (string)toastArgs.UserInput["number"];
                    tcs.TrySetResult(1);
                }
                else
                {
                    tcs.TrySetResult(0);
                }
            };
            return tcs.Task;
        }

        /// <summary>
        /// 设置单词数量
        /// </summary>
        public static void SetWordNumber()
        {
            new ToastContentBuilder()
            .AddText("这次要背多少个？")
            .AddToastInput(new ToastSelectionBox("number")
            {
                DefaultSelectionBoxItemId = "10",
                Items =
                {
                    new ToastSelectionBoxItem("5", "5"),
                    new ToastSelectionBoxItem("10", "10"),
                    new ToastSelectionBoxItem("15", "15"),
                    new ToastSelectionBoxItem("20", "20")
                }
            })
            .AddButton(new ToastButton()
                .SetContent("确定")
                .AddArgument("action", "yes")
                .SetBackgroundActivation())
            .Show();
            var task = PushWords.ProcessToastNotificationSetNumber();
            if(task.Result == 1)
            {
                if(IsNumber(WORD_NUMBER_STRING))
                {
                    Select.WORD_NUMBER = int.Parse(WORD_NUMBER_STRING);
                    Select Temp = new Select();
                    Temp.UpdateNumber(Select.WORD_NUMBER);
                    PushMessage("已设置单词数量为：" + WORD_NUMBER_STRING);
                }
            } 
        }

        /// <summary>
        /// 背诵单词
        /// </summary>
        public static  void Recitation(Object Number)
        {
            Select Query = new Select();
            List<Word> RandomList = Query.GetRandomWordList((int)Number);
            if(RandomList.Count == 0)
            {
                PushMessage("好..好像词库里没有单词了，您就是摸鱼之王！");
                return;
            }
            List<Word> CopyList = Clone<Word>(RandomList);
            Word CurrentWord = new Word();
            while (CopyList.Count != 0)
            {
                if(WORD_CURRENT_STATUS != 3)
                    CurrentWord = GetRandomWord(CopyList);
                PushOneWord(CurrentWord);

                WORD_CURRENT_STATUS = 2;
                while (WORD_CURRENT_STATUS == 2)
                {
                    var task = PushWords.ProcessToastNotificationRecitation();
                    if (task.Result == 0)
                    {
                        WORD_CURRENT_STATUS = 1;
                    }
                    else if (task.Result == 1)
                    {
                        WORD_CURRENT_STATUS = 0;
                    }
                    else if (task.Result == 2)
                    {
                        WORD_CURRENT_STATUS = 3;
                        SpeechSynthesizer synth = new SpeechSynthesizer();
                        synth.SpeakAsync(CurrentWord.headWord);
                    }
                }
                if (WORD_CURRENT_STATUS == 1)
                {
                    Query.UpdateWord(CurrentWord.wordRank);
                    Query.UpdateCount();
                    CopyList.Remove(CurrentWord);
                }
            }
            PushMessage("背完了！接下来开始测验！");
            Thread.Sleep(3000);

            /* 背诵结束 */

            CopyList = Clone<Word>(RandomList);
            for (int i = CopyList.Count - 1; i >= 0; i--)
            {
                if (CopyList[i].question != null)
                    CopyList.Remove(CopyList[i]);
            }

            while (CopyList.Count != 0)
            {
                ToastNotificationManagerCompat.History.Clear();
                Thread.Sleep(500);
                CurrentWord = GetRandomWord(CopyList);
                List<Word> FakeWordList = Query.GetRandomWords(2);

                PushOneTransQuestion(CurrentWord, FakeWordList[0].headWord, FakeWordList[1].headWord);

                QUESTION_CURRENT_STATUS = 2;
                while (QUESTION_CURRENT_STATUS == 2)
                {
                    var task = ProcessToastNotificationQuestion();
                    if (task.Result == 1)
                        QUESTION_CURRENT_STATUS = 1;
                    else if(task.Result == 0)
                        QUESTION_CURRENT_STATUS = 0;
                    else if (task.Result == -1)
                        QUESTION_CURRENT_STATUS = -1;
                }
                
                if (QUESTION_CURRENT_STATUS == 1)
                {
                    CopyList.Remove(CurrentWord);
                    Thread.Sleep(500);
                }
                else if (QUESTION_CURRENT_STATUS == 0)
                {
                    //CopyList.Remove(CurrentWord);
                    new ToastContentBuilder()
                    .AddText("错误 正确答案：" + AnswerDict[QUESTION_CURRENT_RIGHT_ANSWER.ToString()] + '.' + CurrentWord.headWord)
                    .Show();
                    Thread.Sleep(3000);
                }
            }

            for (int i = RandomList.Count - 1; i >= 0; i--)
            {
                if (RandomList[i].question == null)
                    RandomList.Remove(RandomList[i]);
            }

            while (RandomList.Count != 0)
            {
                ToastNotificationManagerCompat.History.Clear();
                CurrentWord = GetRandomWord(RandomList);
                QUESTION_CURRENT_RIGHT_ANSWER = int.Parse(CurrentWord.rightIndex) - 1;
                PushOneQuestion(CurrentWord);

                QUESTION_CURRENT_STATUS = 2;
                while (QUESTION_CURRENT_STATUS == 2)
                {
                    var task = ProcessToastNotificationQuestion();
                    if (task.Result == 1)
                        QUESTION_CURRENT_STATUS = 1;
                    else if (task.Result == 0)
                        QUESTION_CURRENT_STATUS = 0;
                }
                if (QUESTION_CURRENT_STATUS == 1)
                {
                    RandomList.Remove(CurrentWord);
                    Thread.Sleep(500);
                }
                else if (QUESTION_CURRENT_STATUS == 0)
                {
                    //RandomList.Remove(CurrentWord);
                    new ToastContentBuilder()
                    .AddText("错误, 正确答案：" + AnswerDict[QUESTION_CURRENT_RIGHT_ANSWER.ToString()])
                    .AddText(CurrentWord.explain)
                    .Show();
                    Thread.Sleep(6000);
                }
            }
            ToastNotificationManagerCompat.History.Clear();
            PushMessage("结束了！恭喜！");
        }

        public static void UnorderWord(Object Num)
        {
            int Number = (int)Num;
            Select Query = new Select();
            List<Word> TestList = Query.GetRandomWords(Number);

            Word CurrentWord = new Word();

            while (TestList.Count != 0)
            {
                ToastNotificationManagerCompat.History.Clear();
                Thread.Sleep(500);
                CurrentWord = GetRandomWord(TestList);
                List<Word> FakeWordList = Query.GetRandomWords(2);

                PushOneTransQuestion(CurrentWord, FakeWordList[0].headWord, FakeWordList[1].headWord);

                QUESTION_CURRENT_STATUS = 2;
                while (QUESTION_CURRENT_STATUS == 2)
                {
                    var task = ProcessToastNotificationQuestion();
                    if (task.Result == 1)
                        QUESTION_CURRENT_STATUS = 1;
                    else if (task.Result == 0)
                        QUESTION_CURRENT_STATUS = 0;
                    else if (task.Result == -1)
                        QUESTION_CURRENT_STATUS = -1;
                }

                if (QUESTION_CURRENT_STATUS == 1)
                {
                    TestList.Remove(CurrentWord);
                    Thread.Sleep(500);
                }
                else if (QUESTION_CURRENT_STATUS == 0)
                {
                    //CopyList.Remove(CurrentWord);
                    new ToastContentBuilder()
                    .AddText("错误 正确答案：" + AnswerDict[QUESTION_CURRENT_RIGHT_ANSWER.ToString()] + '.' + CurrentWord.headWord)
                    .Show();
                    Thread.Sleep(3000);
                }
            }
            ToastNotificationManagerCompat.History.Clear();
            PushMessage("结束了！恭喜！");
        }

        /// <summary>
        /// 推送一条通知
        /// </summary>
        public static void PushMessage(string Message, string Buttom = "")
        {
            if (Buttom != "")
                new ToastContentBuilder()
                .AddText("Toast Fish")
                .AddText(Message)
                .AddButton(new ToastButton()
                .SetContent(Buttom)
                .AddArgument("action", "succeed")
                .SetBackgroundActivation())
                .Show();
            else
                new ToastContentBuilder()
                .AddText("Toast Fish")
                .AddText(Message)
                .Show();
        }

        /// <summary>
        /// 推送一个单词
        /// </summary>
        /// <param name="CurrentWord"></param>
        public static void PushOneWord(Word CurrentWord)
        {
            ToastNotificationManagerCompat.History.Clear();
            string WordPhonePosTran = CurrentWord.headWord + "  (" + CurrentWord.usPhone + ")\n" + CurrentWord.pos + ". " + CurrentWord.tranCN;
            string SentenceTran = "";
            if(CurrentWord.sentence != null && CurrentWord.sentence.Length < 50)
            {
                SentenceTran = CurrentWord.sentence + '\n' + CurrentWord.sentenceCN;
            }
            else if(CurrentWord.phrase != null)
            {
                SentenceTran = CurrentWord.phrase + '\n' + CurrentWord.phraseCN;
            }
            new ToastContentBuilder()
            .AddText(WordPhonePosTran)
            .AddText(SentenceTran)
            
            .AddButton(new ToastButton()
                .SetContent("记住了！")
                .AddArgument("action", "succeed")
                .SetBackgroundActivation())

            .AddButton(new ToastButton()
                .SetContent("暂时跳过..")
                .AddArgument("action", "fail")
                .SetBackgroundActivation())
            
            .AddButton(new ToastButton()
                .SetContent("发音")
                .AddArgument("action", "voice")
                .SetBackgroundActivation())
            .Show();
        }

        /// <summary>
        /// 推送一道选择题
        /// </summary>
        public static void PushOneQuestion(Word CurrentWord)
        {
            string Question = CurrentWord.question;
            string A = CurrentWord.choiceIndexOne;
            string B = CurrentWord.choiceIndexTwo;
            string C = CurrentWord.choiceIndexThree;
            string D = CurrentWord.choiceIndexFour;

            new ToastContentBuilder()
            .AddText("选择题")
            .AddText(Question)
            
            .AddButton(new ToastButton()
                .SetContent(A)
                .AddArgument("action", "0")
                .SetBackgroundActivation())

            .AddButton(new ToastButton()
                .SetContent(B)
                .AddArgument("action", "1")
                .SetBackgroundActivation())
            
            .AddButton(new ToastButton()
                .SetContent(C)
                .AddArgument("action", "2")
                .SetBackgroundActivation())

            .AddButton(new ToastButton()
                .SetContent(D)
                .AddArgument("action", "3")
                .SetBackgroundActivation())
            .Show();

        }

        /// <summary>
        /// 推送翻译问题
        /// </summary>
        public static void PushOneTransQuestion(Word CurrentWord, string B, string C)
        {
            string Question = CurrentWord.tranCN;
            string A = CurrentWord.headWord;

            Random Rd = new Random();
            int AnswerIndex = Rd.Next(3);
            QUESTION_CURRENT_RIGHT_ANSWER = AnswerIndex;

            if (AnswerIndex == 0)
            {
                new ToastContentBuilder()
               .AddText("翻译\n" + Question)

               .AddButton(new ToastButton()
                   .SetContent("A." + A)
                   .AddArgument("action", "0")
                   .SetBackgroundActivation())

               .AddButton(new ToastButton()
                   .SetContent("B." + B)
                   .AddArgument("action", "1")
                   .SetBackgroundActivation())

               .AddButton(new ToastButton()
                   .SetContent("C." + C)
                   .AddArgument("action", "2")
                   .SetBackgroundActivation())

               .Show();
            }
            else if (AnswerIndex == 1)
            {
               new ToastContentBuilder()
               .AddText("翻译\n" + Question)

              .AddButton(new ToastButton()
                  .SetContent("A." + B)
                  .AddArgument("action", "0")
                  .SetBackgroundActivation())

              .AddButton(new ToastButton()
                  .SetContent("B." + A)
                  .AddArgument("action", "1")
                  .SetBackgroundActivation())

              .AddButton(new ToastButton()
                  .SetContent("C." + C)
                  .AddArgument("action", "2")
                  .SetBackgroundActivation())
              .Show();
            }
            else if (AnswerIndex == 2)
            {
               new ToastContentBuilder()
               .AddText("翻译\n" + Question)

              .AddButton(new ToastButton()
                  .SetContent("A." + C)
                  .AddArgument("action", "0")
                  .SetBackgroundActivation())

              .AddButton(new ToastButton()
                  .SetContent("B." + B)
                  .AddArgument("action", "1")
                  .SetBackgroundActivation())

              .AddButton(new ToastButton()
                  .SetContent("C." + A)
                  .AddArgument("action", "2")
                  .SetBackgroundActivation())
              .Show();
            }
        }

        /// <summary>
        /// 克隆Word列表
        /// </summary>
        /// <typeparam name="Word"></typeparam>
        /// <param name="RealObject"></param>
        public static List<Word> Clone<Word>(List<Word> RealObject)
        {
            using (Stream objStream = new MemoryStream())
            {
                //利用 System.Runtime.Serialization序列化与反序列化完成引用对象的复制
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objStream, RealObject);
                objStream.Seek(0, SeekOrigin.Begin);
                return (List<Word>)formatter.Deserialize(objStream);
            }

        }
    }
}
