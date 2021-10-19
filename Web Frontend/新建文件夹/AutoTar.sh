# shell 脚本实战之 系统备份脚本 —案列
# Tar工具全备、增量备份网站，Shell脚本实现自动打包备份

SOURCE_DIR =($*)
TARGET_DIR=/data/backup/
YEAR = `date +%Y
MONTH=`date +%m`
DAY=`date +%d`
WEEK=`date +%u`
A_NAME=`date +%H%M`
FILES=system_backup.tgz
CODE=$?`

if [-z "$*"]; then
    echo "error"
    exit
fi

Full_Backup()
{
    if ["$WEEK" -eq "7"]; then
        rm -rf $TARGET_DIR/snapshot
        cd $TARGET_DIR
    fi


}

sleep 3 
Full_Backup;
