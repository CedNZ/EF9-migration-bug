# EF9-migration-bug

Clone code
Generate Migration Script
```dotnet ef migrations script --output C:\Temp\Migration.sql```
Try run script on Sql Server
Fails with: The variable name '@historyTableSchema' has already been declared. Variable names must be unique within a query batch or stored procedure.
