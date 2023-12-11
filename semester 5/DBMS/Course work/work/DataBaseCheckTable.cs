using System.Collections.Generic;
using System.Data.Common;

namespace work
{
    public partial class DataBase
    {
        static Dictionary<string, string>? CreateCodeMySQL = new Dictionary<string, string>()
        {
            {"code", """
CREATE TABLE `code` (
	`id` SMALLINT(5) UNSIGNED NOT NULL DEFAULT '0',
	`country` VARCHAR(3) NOT NULL DEFAULT '' COLLATE 'utf8mb4_general_ci',
	`phone` SMALLINT(5) UNSIGNED NOT NULL,
	PRIMARY KEY (`id`) USING BTREE,
	UNIQUE INDEX `id` (`id`) USING BTREE,
	UNIQUE INDEX `country` (`country`) USING BTREE
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
"""},


            {"registration", """
CREATE TABLE `registration` (
	`phone_code` SMALLINT(5) UNSIGNED NOT NULL,
	`phone` BIGINT(20) UNSIGNED NOT NULL DEFAULT '0',
	`password` VARCHAR(64) NOT NULL DEFAULT '0' COMMENT 'sha3-256' COLLATE 'utf8mb4_general_ci',
	`name` VARCHAR(40) NOT NULL DEFAULT '' COLLATE 'utf8mb4_general_ci',
	`surname` VARCHAR(40) NOT NULL DEFAULT '' COLLATE 'utf8mb4_general_ci',
	`date_birth` DATE NOT NULL,
	`code` VARCHAR(64) NOT NULL DEFAULT '' COLLATE 'utf8mb4_general_ci',
	INDEX `FK_registration_code` (`phone_code`) USING HASH,
	INDEX `phone` (`phone`) USING HASH
)
COLLATE='utf8mb4_general_ci'
ENGINE=MEMORY
""" },


            {"session","""
CREATE TABLE `session` (
	`id` BIGINT(20) UNSIGNED NOT NULL,
	`uuid` VARCHAR(36) NOT NULL COLLATE 'utf8mb4_general_ci',
	`key` VARCHAR(20) NOT NULL COLLATE 'utf8mb4_general_ci',
	PRIMARY KEY (`uuid`) USING HASH,
	UNIQUE INDEX `uuid` (`uuid`) USING HASH,
	INDEX `FK_session_uuid` (`id`, `uuid`) USING HASH
)
COLLATE='utf8mb4_general_ci'
ENGINE=MEMORY
"""},


            {"user_login","""
CREATE TABLE `user_login` (
	`id` BIGINT(20) UNSIGNED NOT NULL AUTO_INCREMENT,
	`phone_code` SMALLINT(5) UNSIGNED NOT NULL DEFAULT '0',
	`phone` BIGINT(20) UNSIGNED NOT NULL,
	`password` VARCHAR(64) NOT NULL COMMENT 'sha3-256' COLLATE 'utf8mb4_general_ci',
	PRIMARY KEY (`id`) USING BTREE,
	UNIQUE INDEX `id` (`id`) USING BTREE,
	INDEX `FK_login_code` (`phone_code`) USING BTREE,
	CONSTRAINT `FK_login_code` FOREIGN KEY (`phone_code`) REFERENCES `code` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
"""},


            {"group","""
CREATE TABLE `group` (
	`id` BIGINT(20) UNSIGNED NOT NULL AUTO_INCREMENT,
	PRIMARY KEY (`id`) USING BTREE,
	UNIQUE INDEX `id` (`id`) USING BTREE
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
"""},


            {"photo","""
CREATE TABLE `photo` (
	`id` BIGINT(20) UNSIGNED NOT NULL AUTO_INCREMENT,
	`file` VARCHAR(64) NOT NULL DEFAULT '' COLLATE 'utf8mb4_general_ci',
	PRIMARY KEY (`id`) USING BTREE,
	UNIQUE INDEX `id` (`id`) USING BTREE,
	UNIQUE INDEX `file` (`file`) USING BTREE
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
"""},


            {"photo_album","""
CREATE TABLE `photo_album` (
	`id` BIGINT(20) UNSIGNED NOT NULL AUTO_INCREMENT,
	PRIMARY KEY (`id`) USING BTREE,
	UNIQUE INDEX `id` (`id`) USING BTREE
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
"""},


            {"wall","""
CREATE TABLE `wall` (
	`id` BIGINT(20) UNSIGNED NOT NULL AUTO_INCREMENT,
	PRIMARY KEY (`id`) USING BTREE,
	UNIQUE INDEX `id` (`id`) USING BTREE
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
"""},


            {"user","""
CREATE TABLE `user` (
	`id` BIGINT(20) UNSIGNED NOT NULL,
	`name` VARCHAR(40) NOT NULL DEFAULT '' COLLATE 'utf8mb4_general_ci',
	`surname` VARCHAR(40) NOT NULL DEFAULT '' COLLATE 'utf8mb4_general_ci',
	`date_birth` DATE NOT NULL,
	`status` VARCHAR(255) NOT NULL DEFAULT '' COLLATE 'utf8mb4_general_ci',
	`wall` BIGINT(20) UNSIGNED NOT NULL,
	`photo` BIGINT(20) UNSIGNED NOT NULL,
	PRIMARY KEY (`id`) USING BTREE,
	UNIQUE INDEX `id` (`id`) USING BTREE,
	UNIQUE INDEX `wall` (`wall`) USING BTREE,
	UNIQUE INDEX `photo` (`photo`) USING BTREE,
	CONSTRAINT `FK_user_login` FOREIGN KEY (`id`) REFERENCES `user_login` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION,
	CONSTRAINT `FK_user_photo_album` FOREIGN KEY (`photo`) REFERENCES `photo_album` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION,
	CONSTRAINT `FK_user_wall` FOREIGN KEY (`wall`) REFERENCES `wall` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
"""},


            {"user_email","""
CREATE TABLE `user_email` (
	`id` BIGINT(20) UNSIGNED NOT NULL,
	`email` VARCHAR(255) NOT NULL DEFAULT '' COLLATE 'utf8mb4_general_ci',
	PRIMARY KEY (`id`) USING BTREE,
	UNIQUE INDEX `id` (`id`) USING BTREE,
	UNIQUE INDEX `email` (`email`) USING BTREE,
	CONSTRAINT `FK_email_user` FOREIGN KEY (`id`) REFERENCES `user` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
"""},


            {"user_interactive","""
CREATE TABLE `user_interactive` (
	`user_1` BIGINT(20) UNSIGNED NOT NULL,
	`user_2` BIGINT(20) UNSIGNED NOT NULL,
	`type` TINYINT(4) NOT NULL DEFAULT '0' COMMENT '-3 (обоюдный бан);  \r\n-2 (2 забанил 1);  \r\n-1 (1 забанил 2);  \r\n0 (ничего);  \r\n1 (1 подписался 2);\r\n2 (2 подписался 1);\r\n3 (дружба)',
	INDEX `FK_relationships_user` (`user_1`) USING BTREE,
	INDEX `FK_relationships_user_2` (`user_2`) USING BTREE,
	CONSTRAINT `FK_relationships_user` FOREIGN KEY (`user_1`) REFERENCES `user` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION,
	CONSTRAINT `FK_relationships_user_2` FOREIGN KEY (`user_2`) REFERENCES `user` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
"""},


            {"uuid","""
CREATE TABLE `uuid` (
	`id` BIGINT(20) UNSIGNED NOT NULL COMMENT 'id пользователя',
	`uuid` VARCHAR(36) NOT NULL COMMENT 'uuid данной сессии' COLLATE 'utf8mb4_general_ci',
	`ip_login` VARCHAR(45) NOT NULL COMMENT 'айпи с которого началась сессия' COLLATE 'utf8mb4_general_ci',
	`client` VARCHAR(255) NOT NULL COMMENT 'клиент сессии' COLLATE 'utf8mb4_general_ci',
	`date_login` BIGINT(20) NOT NULL DEFAULT unix_timestamp() COMMENT 'начало сессии',
	`date_limit` BIGINT(20) NOT NULL COMMENT 'время когда сессия перестанет быть активной',
	`date_logout` BIGINT(20) NOT NULL DEFAULT '0' COMMENT 'время когда отключили сессию',
	`ip_logout` VARCHAR(45) NOT NULL DEFAULT '' COMMENT 'айпи того, кто отключил сессию' COLLATE 'utf8mb4_general_ci',
	`uuid_logout` VARCHAR(36) NOT NULL DEFAULT '' COMMENT 'uuid того, кто отключил сессию' COLLATE 'utf8mb4_general_ci',
	`status` TINYINT(4) NOT NULL DEFAULT '0' COMMENT 'статус активности\r\n0 - активно\r\n1 - сменили пароль\r\n2 - закрыли сессию\r\n3 - время сессии истекло',
	PRIMARY KEY (`uuid`) USING BTREE,
	UNIQUE INDEX `uuid` (`uuid`) USING BTREE,
	INDEX `FK_uuid_login` (`id`) USING BTREE,
	CONSTRAINT `FK_uuid_login` FOREIGN KEY (`id`) REFERENCES `user_login` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION
)
COMMENT='uuid_login ссылается на uuid. ключа нет, чтобы поле по стандарту было заполнено'
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
"""},


            {"tag","""
CREATE TABLE `tag` (
	`id` BIGINT(20) UNSIGNED NOT NULL AUTO_INCREMENT,
	`tag` VARCHAR(16) NOT NULL DEFAULT '0' COLLATE 'utf8mb4_general_ci',
	`type` TINYINT(4) NOT NULL DEFAULT '0' COMMENT '0 - user;\r\n1 - group;\r\n2 - artist;',
	PRIMARY KEY (`id`) USING BTREE,
	UNIQUE INDEX `id` (`id`) USING BTREE,
	UNIQUE INDEX `tag` (`tag`) USING BTREE
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
"""},


            {"tag_group","""
CREATE TABLE `tag_group` (
	`id` BIGINT(20) UNSIGNED NOT NULL,
	`group` BIGINT(20) UNSIGNED NOT NULL,
	PRIMARY KEY (`id`) USING BTREE,
	UNIQUE INDEX `id` (`id`) USING BTREE,
	UNIQUE INDEX `group` (`group`) USING BTREE,
	CONSTRAINT `FK_tag_group_group` FOREIGN KEY (`group`) REFERENCES `group` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION,
	CONSTRAINT `FK_tag_group_tag` FOREIGN KEY (`id`) REFERENCES `tag` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
ROW_FORMAT=DYNAMIC
"""},


            {"tag_user","""
CREATE TABLE `tag_user` (
	`id` BIGINT(20) UNSIGNED NOT NULL,
	`user` BIGINT(20) UNSIGNED NOT NULL,
	PRIMARY KEY (`id`) USING BTREE,
	UNIQUE INDEX `user` (`user`) USING BTREE,
	UNIQUE INDEX `id` (`id`) USING BTREE,
	CONSTRAINT `FK_tag_user_tag` FOREIGN KEY (`id`) REFERENCES `tag` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION,
	CONSTRAINT `FK_tag_user_user` FOREIGN KEY (`user`) REFERENCES `user` (`id`) ON UPDATE NO ACTION ON DELETE NO ACTION
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
"""}
        };



        void CheckTable()
        {
            Dictionary<string, string>? CreateCode = null;
            switch (Type)
            {
                case DataBaseType.MYSQL:
                    CreateCode = CreateCodeMySQL;
                    break;
            }
            if(CreateCode != null)
            {
                CheckTable(CreateCode, "code");
                CheckTable(CreateCode, "registration");
                CheckTable(CreateCode, "session");
                CheckTable(CreateCode, "user_login");
                CheckTable(CreateCode, "group");
                CheckTable(CreateCode, "photo");
                CheckTable(CreateCode, "photo_album");
                CheckTable(CreateCode, "wall");
                CheckTable(CreateCode, "user");
                CheckTable(CreateCode, "user_email");
                CheckTable(CreateCode, "user_interactive");
                CheckTable(CreateCode, "uuid");
                CheckTable(CreateCode, "tag");
                CheckTable(CreateCode, "tag_group");
                CheckTable(CreateCode, "tag_user");
            }
        }
        void CheckTable(Dictionary<string, string> CreateCode, string Name)
        {
            if (CreateCode.ContainsKey(Name))
            {
                CheckTableResult result = CheckTable(Name, CreateCode[Name]);
                if(result == CheckTableResult.ANOTHER)
                {
                    //Спрашиваем пользователя, стоит ли пересоздать все таблицы, открыть новую базу данных или продолжить код
                    //если да, то -> result = CheckTableResult.NO;

                    //так-как автоинкеремент - изменяется, пока игнорируем
                }
                if (result == CheckTableResult.NO)
                {
                    command.CommandText = CreateCode[Name];
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                //обработка, если нет CreateCode[Name]
            }
        }
        CheckTableResult CheckTable(string Name, string Code)
        {
            string Column = "";
            DbDataReader? reader = null;
            CheckTableResult result = CheckTableResult.NO;


            switch (Type)
            {
                case DataBaseType.SQLITE:
                    command.CommandText = $"SELECT * FROM sqlite_master WHERE type='table' AND name='{Name}';";
                    Column = "sql";
                    break;
                case DataBaseType.MYSQL:
                    command.CommandText = $"SHOW CREATE TABLE `{Name}`;";
                    Column = "Create Table";
                    break;
                default:
                    return CheckTableResult.NO;
            }

            try
            {
                reader = command.ExecuteReader();
            }
            catch
            {
                if(reader != null)
                {
                    reader.Close();
                }
                return CheckTableResult.NO;
            }


            if (reader.HasRows && reader.Read())
            {
                //проверяем с кодом, для создания таблицы
                if (reader[Column].Equals(Code))
                {
                    result = CheckTableResult.YES;
                }
                else
                {
                    result = CheckTableResult.ANOTHER;
                }
            }
            reader.Close();
            return result;
        }

    }
}
