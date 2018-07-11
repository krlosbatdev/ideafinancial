using Microsoft.EntityFrameworkCore.Migrations;

namespace ideafinancial.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Users (FirstName, LastName, CreditLimit, Balance, AvailableFunds) VALUES ('Carlos','Batista', 100000, 50000, 50000 )");
            migrationBuilder.Sql("INSERT INTO Users (FirstName, LastName, CreditLimit, Balance, AvailableFunds) VALUES ('John','Doe', 100000, 30000, 70000 )");
            migrationBuilder.Sql("INSERT INTO Users (FirstName, LastName, CreditLimit, Balance, AvailableFunds) VALUES ('Ann','Steel', 100000, 40000, 60000 )");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Users WHERE FirstName IN ('Carlos','John', 'Ann')");

        }
    }
}
