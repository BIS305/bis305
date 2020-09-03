#suppress error display if the test folder is being accessed by another app a.k.a. Git Bash
$ErrorActionPreference= 'silentlycontinue'

#remove git folder if present
IF(Test-Path test){
	#Write-Output "got git"
	# -r (recursive). Note that -f in PowerShell is ambiguous for -Filter and -Force and thus -fo needs to be used.
	Remove-Item test -r -fo
	
} 

mkdir test
Set-Location test

git init

#number of commits on the master branch
$numberOfCommitsArray = @("File.txt v1", "File.txt v2", "File.txt v3")
 
for($i = 0; $i -lt $numberOfCommitsArray.length; $i++){ 
	$numberOfCommitsArray[$i] | Out-File $numberOfCommitsArray[$i]
	git add .
	git commit -m $numberOfCommitsArray[$i]
}

#in a separte terminal run this script to view the .git structure updates
#DO
#{
#clear
#tree .git
#Start-Sleep -s 2
#}
#While (1 -eq 1)