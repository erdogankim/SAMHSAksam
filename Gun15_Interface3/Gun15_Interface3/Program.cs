

using Gun15_Interface3;
using Gun15_Interface3.DbRepositories;

Person p = new Person();


DbOperation dbOperation = new DbOperation(new OracleDbRepository());
dbOperation.InsertEntityToDb(p);


///
//
//
//

//

//

dbOperation.InsertEntityToDb(p);