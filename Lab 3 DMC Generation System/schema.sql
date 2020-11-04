create table Student(
    name varchar(30) not null,
    reg_no char(11) primary key,
    degree char(2),
);
create table CourseResult(
    course_id varchar(8) primary key,
    course_title varchar(35) not null,
    credit_hrs int not null,
);
create table student_courses(
    reg_no char(11) foreign key references Student(reg_no),
    course_id varchar(8) foreign key references CourseResult(course_id),
    marks int,
    semester int not null,
    constraint PK_D primary key (reg_no, course_id)
);
