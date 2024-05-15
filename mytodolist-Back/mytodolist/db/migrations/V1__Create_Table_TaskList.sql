CREATE TABLE IF NOT EXISTS `tasklist` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `title` varchar(80) NOT NULL,
  `dtcreate` datetime(6) NOT NULL,
  `enabled` bit(1) NOT NULL DEFAULT b'1'
  PRIMARY KEY (`id`)
)