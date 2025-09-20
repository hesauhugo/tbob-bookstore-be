CREATE SEQUENCE seq_users;

CREATE TABLE users (
    id int PRIMARY KEY DEFAULT NEXTVAL('seq_users'),
    name character  varying NOT NULL,
    email character  varying UNIQUE NOT NULL,
    psw character  varying NOT NULL,
    contact_number character varying
);