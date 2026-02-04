cd /home/ryan/Documents/Projects/UnityDev/WarWagonTDD/

echo $1

#if '$1';then
# message='$1'
#else
message=$(date +"%A %B %d %Y")
#fi

#echo $message

git add .
git commit -m "$message"
git push origin main
