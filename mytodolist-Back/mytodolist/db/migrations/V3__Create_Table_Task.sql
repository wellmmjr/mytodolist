CREATE TABLE IF NOT EXISTS `task` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `description` varchar(80) NOT NULL,
  `dtcreate` datetime(6) NOT NULL,
  `enabled` bit(1) NOT NULL DEFAULT b'1',
  `concluded` bit(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
