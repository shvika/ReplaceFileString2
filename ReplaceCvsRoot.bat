@echo off
for /r %%i in (*) do ( 

	rem echo %%i 
	rem echo %%~nxi 
	
	if "%%~nxi" == "Root" (
	
	echo Replacing strings in %%i 
	
	c:\ReplaceFileString %%i 172.16.2.5 orpakcvs
	
	)
	

)
@echo on