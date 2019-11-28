\connect bsdb
CREATE TABLE blog
(
 id serial PRIMARY KEY,
 name VARCHAR (50) NOT NULL
);
ALTER TABLE "blog" OWNER TO bsuser;
Insert into blog(name) values('name');
