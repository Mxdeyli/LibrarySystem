# LibrarySystem

使用 Windows、.NET Framework 4.7.2 和 MySQL。用 Visual Studio 打开 `LibrarySystem.sln`，还原 NuGet 包后构建。

1. 创建一个 MySQL 数据库，在该库执行 `schema.sql`。
2. 将进程环境变量 `LIBRARYSYSTEM_CONNECTION_STRING` 设为该库的 MySQL 连接字符串，再启动应用。
3. 在 `users` 中创建首个管理员，`Role` 为 `admin`，`PasswordHash` 填入你自己用 BCrypt 生成的哈希。其余用户可以在应用的用户管理页创建。
4. 在图书页的搜索框输入书名、作者或 ISBN，按 Enter 搜索。选中图书后可借阅或归还。

旧库升级时，先备份并确认 `users`、`books` 使用 InnoDB。若旧库只有 `Password` 列，先添加可空的 `PasswordHash VARCHAR(60)`。旧库若将 `Password` 定义为必填，允许该列为空后才可创建新账户。旧账户仍可用原密码登录，可以逐步将密码转换成 BCrypt 哈希。旧版直接扣减库存时没有写入借阅记录，升级前已借出的图书需要根据实际台账补录到 `bookloans`。
