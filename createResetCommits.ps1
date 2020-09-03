#suppress error display if the test folder is being accessed by another app a.k.a. Git Bash
$ErrorActionPreference= 'silentlycontinue'

#remove git folder if present
IF(Test-Path test){
	#Write-Output "got git"
	# -r (recursive). Note that -f in PowerShell is ambiguous for -Filter and -Force and thus -fo needs to be used.
	Remove-Item test -r -fo
	
} 

#make a directory named test
mkdir test

#set the working location in the test folder
Set-Location test

#create an empty Git repository
git init

#the commits to place in the repo
$numberOfCommitsArray = @("File.txt v1", "File.txt v2", "File.txt v3")

#iterate each string in the $numberOfCommitsArray
for($i = 0; $i -lt $numberOfCommitsArray.length; $i++){
	#send the string to a newly created file of the same name as the string
	$numberOfCommitsArray[$i] | Out-File $numberOfCommitsArray[$i]

	#add the file to stage (index)
	git add .

	#create a new commit containing the current contents of stage with the log message of the string
	git commit -m $numberOfCommitsArray[$i]
}
