PluginFramework
===============

Simple project to demonstrate a plugin mechanism managed by a database

----

The database isn't created automatically.   
Simply create a database called "Plugins" in (localdb)\v11.0 and add a Table "Plugin":


`CREATE TABLE [dbo].[Plugin] (`  
`[PluginId] INT            IDENTITY (1, 1) NOT NULL,`  
`[Path]     NVARCHAR (MAX) NOT NULL,`  
`[TypeName] NVARCHAR (MAX) NOT NULL`  
`);`   

Then you can add the path to a plugin and the typename of the plugin in this table.  

Also see [my blogpost on this.](http://blog.alexander-heinz.com/creating-a-simple-plugin-system/ "Creating a simple Plugin system")




