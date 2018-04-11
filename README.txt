If localhost refuses to connect:
1. Close Visual Studio
2. Go into .vs folder (may need to show hidden files)
3. Go into config folder 
4. Delete applicationhost.config
5. Re-Open Visual Studio
6. Run the program again (applicationhost.config should regenerate itself)