chcp 65001
set root="C:\ProgramData\Anaconda3"
set segFilename="main.py"

call %root%\Scripts\activate.bat %root%
python %segFilename% %1 %2