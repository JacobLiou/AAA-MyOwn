# 连接到Mysql数据库

import mysql.connector

mydb = mysql.connector.connect(
    host="localhost",
    user="root",
    password="laumenghui",
    database="jacob"
)

print(mydb)

mycursor = mydb.cursor()
mycursor.execute("select * from person")

# try:
#   cnx = mysql.connector.connect(user='scott',
#                                 database='employ')
# except mysql.connector.Error as err:
#   if err.errno == errorcode.ER_ACCESS_DENIED_ERROR:
#     print("Something is wrong with your user name or password")
#   elif err.errno == errorcode.ER_BAD_DB_ERROR:
#     print("Database does not exist")
#   else:
#     print(err)
# else:
#   cnx.close()


# 连接到SqlServer
import pyodbc 
# Some other example server values are
# server = 'localhost\sqlexpress' # for a named instance
# server = 'myserver,port' # to specify an alternate port
server = 'tcp:myserver.database.windows.net' 
database = 'mydb' 
username = 'myusername' 
password = 'mypassword' 
cnxn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
cursor = cnxn.cursor()