namespace Potato.Tests.Parser.Variable.Expressions.Integer;

using AstNodes;

using Xunit.Abstractions;

public class SingleLowerPrecedenceBeforeSingleHigherPrecedence : TestBase
{
    public SingleLowerPrecedenceBeforeSingleHigherPrecedence(ITestOutputHelper helper) : base(helper)
    {
    }

    [Fact]
    public void SubtractionDivision()
    {
        string input = "Integer integerIdentifier = 1 - 2 / 3;";
        IEnumerable<string> testData = ReadTestData(input);
        _testOutputHelper.WriteLine(input);
        PotatoRootAstNode expectedResult = new() {
            VariableAssignments = {
                new IntegerAssignmentStatementNode {
                    VariableLiteral = "integerIdentifier",
                    VariableExpressionNode = new InFixExpressionNode {
                        TokenType = TokenTypesEnum.Sign_Subtraction,
                        ExpressionNodeType = ExpressionNodeType.Infix,
                        LeftSideNode = new IntegerLiteralExpressionNode {
                            TokenType = TokenTypesEnum.IntegerLiteral,
                            Value = 1,
                            ValueLiteral = "1",
                        },
                        RightSideNode = new InFixExpressionNode {
                            TokenType = TokenTypesEnum.Sign_Division,
                            ExpressionNodeType = ExpressionNodeType.Infix,
                            LeftSideNode = new IntegerLiteralExpressionNode {
                                TokenType = TokenTypesEnum.IntegerLiteral,
                                Value = 2,
                                ValueLiteral = "2",
                            },
                            RightSideNode = new IntegerLiteralExpressionNode {
                                TokenType = TokenTypesEnum.IntegerLiteral,
                                Value = 3,
                                ValueLiteral = "3",
                            },
                        },
                    },
                },
            },
        };
        PotatoRootAstNode result = Parser.Parse(testData);
        PrintResult(result);
        CheckResult(result, expectedResult);
    }

    [Fact]
    public void AdditionDivision()
    {
        string input = "Integer integerIdentifier = 1 + 2 / 3;";
        IEnumerable<string> testData = ReadTestData(input);
        _testOutputHelper.WriteLine(input);
        PotatoRootAstNode expectedResult = new() {
            VariableAssignments = {
                new IntegerAssignmentStatementNode {
                    VariableLiteral = "integerIdentifier",
                    VariableExpressionNode = new InFixExpressionNode {
                        TokenType = TokenTypesEnum.Sign_Addition,
                        ExpressionNodeType = ExpressionNodeType.Infix,
                        LeftSideNode = new IntegerLiteralExpressionNode {
                            TokenType = TokenTypesEnum.IntegerLiteral,
                            Value = 1,
                            ValueLiteral = "1",
                        },
                        RightSideNode = new InFixExpressionNode {
                            TokenType = TokenTypesEnum.Sign_Division,
                            ExpressionNodeType = ExpressionNodeType.Infix,
                            LeftSideNode = new IntegerLiteralExpressionNode {
                                TokenType = TokenTypesEnum.IntegerLiteral,
                                Value = 2,
                                ValueLiteral = "2",
                            },
                            RightSideNode = new IntegerLiteralExpressionNode {
                                TokenType = TokenTypesEnum.IntegerLiteral,
                                Value = 3,
                                ValueLiteral = "3",
                            },
                        },
                    },
                },
            },
        };
        PotatoRootAstNode result = Parser.Parse(testData);
        PrintResult(result);
        CheckResult(result, expectedResult);
    }

    [Fact]
    public void SubtractionMultiplication()
    {
        string input = "Integer integerIdentifier = 1 - 2 * 3;";
        IEnumerable<string> testData = ReadTestData(input);
        _testOutputHelper.WriteLine(input);
        PotatoRootAstNode expectedResult = new() {
            VariableAssignments = {
                new IntegerAssignmentStatementNode {
                    VariableLiteral = "integerIdentifier",
                    VariableExpressionNode = new InFixExpressionNode {
                        TokenType = TokenTypesEnum.Sign_Subtraction,
                        ExpressionNodeType = ExpressionNodeType.Infix,
                        LeftSideNode = new IntegerLiteralExpressionNode {
                            TokenType = TokenTypesEnum.IntegerLiteral,
                            Value = 1,
                            ValueLiteral = "1",
                        },
                        RightSideNode = new InFixExpressionNode {
                            TokenType = TokenTypesEnum.Sign_Multiplication,
                            ExpressionNodeType = ExpressionNodeType.Infix,
                            LeftSideNode = new IntegerLiteralExpressionNode {
                                TokenType = TokenTypesEnum.IntegerLiteral,
                                Value = 2,
                                ValueLiteral = "2",
                            },
                            RightSideNode = new IntegerLiteralExpressionNode {
                                TokenType = TokenTypesEnum.IntegerLiteral,
                                Value = 3,
                                ValueLiteral = "3",
                            },
                        },
                    },
                },
            },
        };
        PotatoRootAstNode result = Parser.Parse(testData);
        PrintResult(result);
        CheckResult(result, expectedResult);
    }


    [Fact]
    public void AdditionMultiplication()
    {
        string input = "Integer integerIdentifier = 1 + 2 * 3;";
        IEnumerable<string> testData = ReadTestData(input);
        _testOutputHelper.WriteLine(input);
        PotatoRootAstNode expectedResult = new() {
            VariableAssignments = {
                new IntegerAssignmentStatementNode {
                    VariableLiteral = "integerIdentifier",
                    VariableExpressionNode = new InFixExpressionNode {
                        TokenType = TokenTypesEnum.Sign_Addition,
                        ExpressionNodeType = ExpressionNodeType.Infix,
                        LeftSideNode = new IntegerLiteralExpressionNode {
                            TokenType = TokenTypesEnum.IntegerLiteral,
                            Value = 1,
                            ValueLiteral = "1",
                        },
                        RightSideNode = new InFixExpressionNode {
                            TokenType = TokenTypesEnum.Sign_Multiplication,
                            ExpressionNodeType = ExpressionNodeType.Infix,
                            LeftSideNode = new IntegerLiteralExpressionNode {
                                TokenType = TokenTypesEnum.IntegerLiteral,
                                Value = 2,
                                ValueLiteral = "2",
                            },
                            RightSideNode = new IntegerLiteralExpressionNode {
                                TokenType = TokenTypesEnum.IntegerLiteral,
                                Value = 3,
                                ValueLiteral = "3",
                            },
                        },
                    },
                },
            },
        };
        PotatoRootAstNode result = Parser.Parse(testData);
        PrintResult(result);
        CheckResult(result, expectedResult);
    }
}