# PostgreSQL-to-Access
Project was made in purpose to export certain tables from different chemes of PostgreSQL database to MS Access.

The application exports tables (the list is represented in CheckedListBox_Tables) from different chemes (the list is represented in ListBox_Schemes with the function of adding, removing schemes from the list, exporting and importing from/to txt file). Exporting tables from PostgreSQL to Access is made with VBA module which is created in working Access database by C# application. 

In VBA module the Sub "Export" gets the link parameters and the arrays of Schemes and Tables from C# app to work with. "Export" Sub calls the Sub "Link_ODBCTbl" which performs the link procedure for each table and create new table with the linked PG-table in Access database. After calling the "Link_ODBCTbl" the "Export" Sub performs the postproduction of tables with merging tables from different schemes to an united one and changing the datatype of table fields from MEMO to Varchar, which is optional. 

All the comments of code were made in russian except of explanation of "Link_ODBCTbl" which was taken from  www.postgresql.org. This project was made in aim of studying the C# possibilities to connect PG and Access with making VBA module inside of Access database (after some experiments this method showed the best perfomance between other ways like using Recordset method or Datatable method direct from C# app).

In case of somebody show any interest to this project the translation of comments will be given as well as explanation of some corners.

Oleg Sviridov 2017

